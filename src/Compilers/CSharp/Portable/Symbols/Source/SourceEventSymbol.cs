// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceEventSymbol : EventSymbol, IAttributeTargetSymbol
    {
        private readonly Location _location;

        private readonly SyntaxReference _syntaxRef;

        private readonly DeclarationModifiers _modifiers;

        internal readonly SourceMemberContainerTypeSymbol containingType;

        private SymbolCompletionState _state;

        private CustomAttributesBag<CSharpAttributeData>? _lazyCustomAttributesBag;

        private string? _lazyDocComment;

        private string? _lazyExpandedDocComment;

        private OverriddenOrHiddenMembersResult? _lazyOverriddenOrHiddenMembers;

        private ThreeState _lazyIsWindowsRuntimeEvent;

        internal SourceEventSymbol(
                    SourceMemberContainerTypeSymbol containingType,
                    CSharpSyntaxNode syntax,
                    SyntaxTokenList modifiers,
                    bool isFieldLike,
                    ExplicitInterfaceSpecifierSyntax? interfaceSpecifierSyntaxOpt,
                    SyntaxToken nameTokenSyntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10250, 1716, 2620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 1079, 1088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 1132, 1142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 1191, 1201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 1262, 1276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 1386, 1410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 1437, 1452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 1479, 1502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 1554, 1584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 1614, 1661);
                this._lazyIsWindowsRuntimeEvent = ThreeState.Unknown; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 2096, 2138);

                _location = nameTokenSyntax.GetLocation();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 2154, 2191);

                this.containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 2207, 2242);

                _syntaxRef = f_10250_2220_2241(syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 2258, 2334);

                var
                isExplicitInterfaceImplementation = interfaceSpecifierSyntaxOpt != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 2348, 2368);

                bool
                modifierErrors
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 2382, 2512);

                _modifiers = f_10250_2395_2511(this, modifiers, isExplicitInterfaceImplementation, isFieldLike, _location, diagnostics, out modifierErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 2526, 2609);

                f_10250_2526_2608(this, _location, diagnostics, isExplicitInterfaceImplementation);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10250, 1716, 2620);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 1716, 2620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 1716, 2620);
            }
        }

        internal sealed override bool RequiresCompletion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 2705, 2725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 2711, 2723);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 2705, 2725);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 2632, 2736);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 2632, 2736);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasComplete(CompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 2748, 2878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 2835, 2867);

                return _state.HasComplete(part);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 2748, 2878);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 2748, 2878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 2748, 2878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void ForceComplete(SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 2890, 3081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 3017, 3070);

                _state.DefaultForceComplete(this, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 2890, 3081);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 2890, 3081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 2890, 3081);
            }
        }

        public abstract override string Name { get; }

        public abstract override MethodSymbol? AddMethod { get; }

        public abstract override MethodSymbol? RemoveMethod { get; }

        public abstract override ImmutableArray<EventSymbol> ExplicitInterfaceImplementations { get; }

        public abstract override TypeWithAnnotations TypeWithAnnotations { get; }

        public sealed override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 3553, 3626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 3589, 3611);

                    return containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 3553, 3626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 3482, 3637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 3482, 3637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 3720, 3798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 3756, 3783);

                    return this.containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 3720, 3798);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 3649, 3809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 3649, 3809);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LexicalSortKey GetLexicalSortKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 3821, 3973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 3898, 3962);

                return f_10250_3905_3961(_location, f_10250_3935_3960(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 3821, 3973);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10250_3935_3960(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 3935, 3960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                f_10250_3905_3961(Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey(location, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 3905, 3961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 3821, 3973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 3821, 3973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 4067, 4158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 4103, 4143);

                    return f_10250_4110_4142(_location);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 4067, 4158);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10250_4110_4142(Microsoft.CodeAnalysis.Location
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 4110, 4142);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 3985, 4169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 3985, 4169);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 4286, 4395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 4322, 4380);

                    return f_10250_4329_4379(_syntaxRef);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 4286, 4395);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10250_4329_4379(Microsoft.CodeAnalysis.SyntaxReference
                    item)
                    {
                        var return_v = ImmutableArray.Create<SyntaxReference>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 4329, 4379);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 4181, 4406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 4181, 4406);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SyntaxList<AttributeListSyntax> AttributeDeclarationSyntaxList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 4645, 5595);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 4681, 5545) || true) && (f_10250_4685_4727(this.containingType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 4681, 5545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 4769, 4804);

                        var
                        syntax = f_10250_4782_4803(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 4826, 5526) || true) && (syntax != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 4826, 5526);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 4894, 5503);

                            switch (f_10250_4902_4915(syntax))
                            {

                                case SyntaxKind.EventDeclaration:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 4894, 5503);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 5040, 5095);

                                    return f_10250_5047_5094(((EventDeclarationSyntax)syntax));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 4894, 5503);

                                case SyntaxKind.VariableDeclarator:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 4894, 5503);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 5194, 5240);

                                    f_10250_5194_5239(f_10250_5207_5228(syntax.Parent!) is object);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 5274, 5348);

                                    return f_10250_5281_5347(((EventFieldDeclarationSyntax)f_10250_5311_5331(f_10250_5311_5324(syntax))));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 4894, 5503);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 4894, 5503);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 5420, 5476);

                                    throw f_10250_5426_5475(f_10250_5461_5474(syntax));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 4894, 5503);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 4826, 5526);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 4681, 5545);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 5565, 5580);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 4645, 5595);

                    bool
                    f_10250_4685_4727(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.AnyMemberHasAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 4685, 4727);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10250_4782_4803(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    this_param)
                    {
                        var return_v = this_param.CSharpSyntaxNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 4782, 4803);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10250_4902_4915(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 4902, 4915);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    f_10250_5047_5094(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.AttributeLists;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 5047, 5094);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10250_5207_5228(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 5207, 5228);
                        return return_v;
                    }


                    int
                    f_10250_5194_5239(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 5194, 5239);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10250_5311_5324(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 5311, 5324);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10250_5311_5331(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 5311, 5331);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    f_10250_5281_5347(Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.AttributeLists;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 5281, 5347);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10250_5461_5474(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 5461, 5474);
                        return return_v;
                    }


                    System.Exception
                    f_10250_5426_5475(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 5426, 5475);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 4549, 5606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 4549, 5606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IAttributeTargetSymbol IAttributeTargetSymbol.AttributesOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 5704, 5724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 5710, 5722);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 5704, 5724);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 5618, 5735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 5618, 5735);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AttributeLocation IAttributeTargetSymbol.DefaultAttributeLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 5837, 5876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 5843, 5874);

                    return AttributeLocation.Event;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 5837, 5876);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 5747, 5887);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 5747, 5887);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AttributeLocation IAttributeTargetSymbol.AllowedAttributeLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 5990, 6079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 6026, 6064);

                    return f_10250_6033_6063(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 5990, 6079);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                    f_10250_6033_6063(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    this_param)
                    {
                        var return_v = this_param.AllowedAttributeLocations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 6033, 6063);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 5899, 6090);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 5899, 6090);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract AttributeLocation AllowedAttributeLocations
        {
            get;
        }

        private CustomAttributesBag<CSharpAttributeData> GetAttributesBag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 6530, 7203);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 6622, 7078) || true) && ((_lazyCustomAttributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10250, 6627, 6697) || f_10250_6663_6697_M(!_lazyCustomAttributesBag.IsSealed))) && (DynAbs.Tracing.TraceSender.Expression_True(10250, 6626, 6829) && f_10250_6719_6829(this, f_10250_6745_6798(f_10250_6762_6797(this)), ref _lazyCustomAttributesBag)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 6622, 7078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 6863, 6910);

                    f_10250_6863_6909(f_10250_6863_6883(), this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 6928, 7008);

                    var
                    wasCompletedThisThread = _state.NotePartComplete(CompletionPart.Attributes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 7026, 7063);

                    f_10250_7026_7062(wasCompletedThisThread);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 6622, 7078);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 7094, 7146);

                f_10250_7094_7145(_lazyCustomAttributesBag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 7160, 7192);

                return _lazyCustomAttributesBag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 6530, 7203);

                bool
                f_10250_6663_6697_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 6663, 6697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10250_6762_6797(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.AttributeDeclarationSyntaxList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 6762, 6797);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10250_6745_6798(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 6745, 6798);
                    return return_v;
                }


                bool
                f_10250_6719_6829(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                attributesSyntaxLists, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                lazyCustomAttributesBag)
                {
                    var return_v = this_param.LoadAndValidateAttributes(attributesSyntaxLists, ref lazyCustomAttributesBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 6719, 6829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10250_6863_6883()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 6863, 6883);
                    return return_v;
                }


                int
                f_10250_6863_6909(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                symbol)
                {
                    this_param.SymbolDeclaredEvent((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 6863, 6909);
                    return 0;
                }


                int
                f_10250_7026_7062(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 7026, 7062);
                    return 0;
                }


                int
                f_10250_7094_7145(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value)
                {
                    RoslynDebug.AssertNotNull(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 7094, 7145);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 6530, 7203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 6530, 7203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 7636, 7788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 7735, 7777);

                return f_10250_7742_7776(f_10250_7742_7765(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 7636, 7788);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10250_7742_7765(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 7742, 7765);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10250_7742_7776(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 7742, 7776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 7636, 7788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 7636, 7788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected CommonEventWellKnownAttributeData GetDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 8077, 8524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 8180, 8225);

                var
                attributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 8239, 8411) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10250, 8243, 8322) || f_10250_8268_8322_M(!attributesBag.IsDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 8239, 8411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 8356, 8396);

                    attributesBag = f_10250_8372_8395(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 8239, 8411);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 8427, 8513);

                return (CommonEventWellKnownAttributeData)f_10250_8469_8512(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 8077, 8524);

                bool
                f_10250_8268_8322_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 8268, 8322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10250_8372_8395(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 8372, 8395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10250_8469_8512(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 8469, 8512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 8077, 8524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 8077, 8524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CommonEventEarlyWellKnownAttributeData GetEarlyDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 8833, 9306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 8945, 8990);

                var
                attributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 9006, 9183) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10250, 9010, 9094) || f_10250_9035_9094_M(!attributesBag.IsEarlyDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 9006, 9183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 9128, 9168);

                    attributesBag = f_10250_9144_9167(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 9006, 9183);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 9199, 9295);

                return (CommonEventEarlyWellKnownAttributeData)f_10250_9246_9294(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 8833, 9306);

                bool
                f_10250_9035_9094_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 9035, 9094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10250_9144_9167(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 9144, 9167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                f_10250_9246_9294(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 9246, 9294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 8833, 9306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 8833, 9306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override CSharpAttributeData? EarlyDecodeWellKnownAttribute(ref EarlyDecodeWellKnownAttributeArguments<EarlyWellKnownAttributeBinder, NamedTypeSymbol, AttributeSyntax, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 9318, 10127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 9549, 9585);

                CSharpAttributeData?
                boundAttribute
                = default(CSharpAttributeData?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 9599, 9635);

                ObsoleteAttributeData?
                obsoleteData
                = default(ObsoleteAttributeData?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 9651, 10043) || true) && (f_10250_9655_9762(ref arguments, out boundAttribute, out obsoleteData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 9651, 10043);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 9796, 9986) || true) && (obsoleteData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 9796, 9986);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 9862, 9967);

                        arguments.GetOrCreateData<CommonEventEarlyWellKnownAttributeData>().ObsoleteAttributeData = obsoleteData;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 9796, 9986);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 10006, 10028);

                    return boundAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 9651, 10043);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 10059, 10116);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EarlyDecodeWellKnownAttribute(ref arguments), 10250, 10066, 10115);
                var temp = base.EarlyDecodeWellKnownAttribute(ref arguments);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 10066, 10115);
                return temp;

                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 9318, 10127);

                bool
                f_10250_9655_9762(ref Microsoft.CodeAnalysis.EarlyDecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, out Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData?
                attributeData, out Microsoft.CodeAnalysis.ObsoleteAttributeData?
                obsoleteData)
                {
                    var return_v = EarlyDecodeDeprecatedOrExperimentalOrObsoleteAttribute(ref arguments, out attributeData, out obsoleteData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 9655, 9762);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 9318, 10127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 9318, 10127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData? ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 10494, 11177);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 10530, 10650) || true) && (f_10250_10534_10577_M(!this.containingType.AnyMemberHasAttributes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 10530, 10650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 10619, 10631);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 10530, 10650);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 10670, 10725);

                    var
                    lazyCustomAttributesBag = _lazyCustomAttributesBag
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 10743, 11099) || true) && (lazyCustomAttributesBag != null && (DynAbs.Tracing.TraceSender.Expression_True(10250, 10747, 10850) && f_10250_10782_10850(lazyCustomAttributesBag)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 10743, 11099);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 10892, 11002);

                        var
                        data = (CommonEventEarlyWellKnownAttributeData)f_10250_10943_11001(lazyCustomAttributesBag)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 11024, 11080);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10250, 11031, 11043) || ((data != null && DynAbs.Tracing.TraceSender.Conditional_F2(10250, 11046, 11072)) || DynAbs.Tracing.TraceSender.Conditional_F3(10250, 11075, 11079))) ? f_10250_11046_11072(data) : null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 10743, 11099);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 11119, 11162);

                    return ObsoleteAttributeData.Uninitialized;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 10494, 11177);

                    bool
                    f_10250_10534_10577_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 10534, 10577);
                        return return_v;
                    }


                    bool
                    f_10250_10782_10850(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    this_param)
                    {
                        var return_v = this_param.IsEarlyDecodedWellKnownAttributeDataComputed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 10782, 10850);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                    f_10250_10943_11001(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    this_param)
                    {
                        var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 10943, 11001);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10250_11046_11072(Microsoft.CodeAnalysis.CommonEventEarlyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.ObsoleteAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 11046, 11072);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 10407, 11188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 10407, 11188);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 11200, 12569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 11385, 11421);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 11435, 11470);

                f_10250_11435_11469(f_10250_11448_11468_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 11484, 11545);

                f_10250_11484_11544(arguments.SymbolPart == AttributeLocation.None);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 11561, 12558) || true) && (f_10250_11565_11641(attribute, this, AttributeDescription.SpecialNameAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 11561, 12558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 11675, 11769);

                    arguments.GetOrCreateData<CommonEventWellKnownAttributeData>().HasSpecialNameAttribute = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 11561, 12558);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 11561, 12558);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 11803, 12558) || true) && (f_10250_11807_11988(this, arguments, ReservedAttributes.NullableAttribute | ReservedAttributes.NativeIntegerAttribute | ReservedAttributes.TupleElementNamesAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 11803, 12558);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 11803, 12558);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 11803, 12558);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 12038, 12558) || true) && (f_10250_12042_12130(attribute, this, AttributeDescription.ExcludeFromCodeCoverageAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 12038, 12558);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 12164, 12270);

                            arguments.GetOrCreateData<CommonEventWellKnownAttributeData>().HasExcludeFromCodeCoverageAttribute = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 12038, 12558);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 12038, 12558);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 12304, 12558) || true) && (f_10250_12308_12387(attribute, this, AttributeDescription.SkipLocalsInitAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 12304, 12558);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 12421, 12543);

                                f_10250_12421_12542(f_10250_12506_12526(), ref arguments);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 12304, 12558);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 12038, 12558);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 11803, 12558);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 11561, 12558);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 11200, 12569);

                bool
                f_10250_11448_11468_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 11448, 11468);
                    return return_v;
                }


                int
                f_10250_11435_11469(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 11435, 11469);
                    return 0;
                }


                int
                f_10250_11484_11544(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 11484, 11544);
                    return 0;
                }


                bool
                f_10250_11565_11641(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 11565, 11641);
                    return return_v;
                }


                bool
                f_10250_11807_11988(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.CSharp.Symbol.ReservedAttributes
                reserved)
                {
                    var return_v = this_param.ReportExplicitUseOfReservedAttributes(arguments, reserved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 11807, 11988);
                    return return_v;
                }


                bool
                f_10250_12042_12130(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 12042, 12130);
                    return return_v;
                }


                bool
                f_10250_12308_12387(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 12308, 12387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10250_12506_12526()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 12506, 12526);
                    return return_v;
                }


                int
                f_10250_12421_12542(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    CSharpAttributeData.DecodeSkipLocalsInitAttribute<CommonEventWellKnownAttributeData>(compilation, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 12421, 12542);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 11200, 12569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 11200, 12569);
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData>? attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 12581, 13831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 12740, 12801);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10250, 12740, 12800);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 12740, 12800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 12817, 12861);

                var
                compilation = f_10250_12835_12860(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 12875, 12911);

                var
                type = f_10250_12886_12910(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 12927, 13127) || true) && (f_10250_12931_12958(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 12927, 13127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 12992, 13112);

                    f_10250_12992_13111(ref attributes, f_10250_13032_13110(compilation, type.Type, type.CustomModifiers.Length));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 12927, 13127);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 13143, 13334) || true) && (f_10250_13147_13180(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 13143, 13334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 13214, 13319);

                    f_10250_13214_13318(ref attributes, f_10250_13254_13317(moduleBuilder, this, type.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 13143, 13334);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 13350, 13557) || true) && (f_10250_13354_13384(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 13350, 13557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 13418, 13542);

                    f_10250_13418_13541(ref attributes, f_10250_13479_13540(f_10250_13479_13499(), type.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 13350, 13557);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 13573, 13820) || true) && (f_10250_13577_13623(compilation, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 13573, 13820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 13657, 13805);

                    f_10250_13657_13804(ref attributes, f_10250_13697_13803(moduleBuilder, this, f_10250_13756_13796(containingType), type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 13573, 13820);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 12581, 13831);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10250_12835_12860(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 12835, 12860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10250_12886_12910(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 12886, 12910);
                    return return_v;
                }


                bool
                f_10250_12931_12958(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 12931, 12958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10250_13032_13110(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, int
                customModifiersCount)
                {
                    var return_v = this_param.SynthesizeDynamicAttribute(type, customModifiersCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 13032, 13110);
                    return return_v;
                }


                int
                f_10250_12992_13111(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 12992, 13111);
                    return 0;
                }


                bool
                f_10250_13147_13180(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 13147, 13180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10250_13254_13317(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeNativeIntegerAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 13254, 13317);
                    return return_v;
                }


                int
                f_10250_13214_13318(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 13214, 13318);
                    return 0;
                }


                bool
                f_10250_13354_13384(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 13354, 13384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10250_13479_13499()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 13479, 13499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10250_13479_13540(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeTupleNamesAttribute(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 13479, 13540);
                    return return_v;
                }


                int
                f_10250_13418_13541(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 13418, 13541);
                    return 0;
                }


                bool
                f_10250_13577_13623(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 13577, 13623);
                    return return_v;
                }


                byte?
                f_10250_13756_13796(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 13756, 13796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10250_13697_13803(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                symbol, byte?
                nullableContextValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.SynthesizeNullableAttributeIfNecessary((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, nullableContextValue, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 13697, 13803);
                    return return_v;
                }


                int
                f_10250_13657_13804(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 13657, 13804);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 12581, 13831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 12581, 13831);
            }
        }

        internal sealed override bool IsDirectlyExcludedFromCodeCoverage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 13908, 14003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 13924, 14003);
                    return f_10250_13924_13995_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10250_13924_13958(this), 10250, 13924, 13995)?.HasExcludeFromCodeCoverageAttribute) == true; DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 13908, 14003);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 13908, 14003);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 13908, 14003);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 14085, 14252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 14121, 14167);

                    var
                    data = f_10250_14132_14166(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 14185, 14237);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10250, 14192, 14236) && f_10250_14208_14236(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 14085, 14252);

                    Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData
                    f_10250_14132_14166(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 14132, 14166);
                        return return_v;
                    }


                    bool
                    f_10250_14208_14236(Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasSpecialNameAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 14208, 14236);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 14016, 14263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 14016, 14263);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasSkipLocalsInitAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 14327, 14400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 14330, 14400);
                    return f_10250_14330_14392_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10250_14330_14364(this), 10250, 14330, 14392)?.HasSkipLocalsInitAttribute) == true; DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 14327, 14400);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 14327, 14400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 14327, 14400);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 14476, 14541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 14482, 14539);

                    return (_modifiers & DeclarationModifiers.Abstract) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 14476, 14541);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 14413, 14552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 14413, 14552);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 14625, 14688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 14631, 14686);

                    return (_modifiers & DeclarationModifiers.Extern) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 14625, 14688);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 14564, 14699);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 14564, 14699);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 14772, 14835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 14778, 14833);

                    return (_modifiers & DeclarationModifiers.Static) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 14772, 14835);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 14711, 14846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 14711, 14846);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 14921, 14986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 14927, 14984);

                    return (_modifiers & DeclarationModifiers.Override) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 14921, 14986);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 14858, 14997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 14858, 14997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 15070, 15133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 15076, 15131);

                    return (_modifiers & DeclarationModifiers.Sealed) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 15070, 15133);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 15009, 15144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 15009, 15144);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 15218, 15282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 15224, 15280);

                    return (_modifiers & DeclarationModifiers.Virtual) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 15218, 15282);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 15156, 15293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 15156, 15293);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 15354, 15419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 15360, 15417);

                    return (_modifiers & DeclarationModifiers.ReadOnly) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 15354, 15419);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 15305, 15430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 15305, 15430);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 15525, 15589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 15531, 15587);

                    return f_10250_15538_15586(_modifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 15525, 15589);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10250_15538_15586(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                    modifiers)
                    {
                        var return_v = ModifierUtils.EffectiveAccessibility(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 15538, 15586);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 15442, 15600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 15442, 15600);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool MustCallMethodsDirectly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 15690, 15711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 15696, 15709);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 15690, 15711);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 15612, 15756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 15612, 15756);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SyntaxReference SyntaxReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 15833, 15859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 15839, 15857);

                    return _syntaxRef;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 15833, 15859);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 15768, 15870);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 15768, 15870);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CSharpSyntaxNode CSharpSyntaxNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 15949, 16005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 15955, 16003);

                    return (CSharpSyntaxNode)f_10250_15980_16002(_syntaxRef);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 15949, 16005);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10250_15980_16002(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 15980, 16002);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 15882, 16016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 15882, 16016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SyntaxTree SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 16083, 16120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 16089, 16118);

                    return f_10250_16096_16117(_syntaxRef);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 16083, 16120);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10250_16096_16117(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 16096, 16117);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 16028, 16131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 16028, 16131);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsNew
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 16187, 16247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 16193, 16245);

                    return (_modifiers & DeclarationModifiers.New) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 16187, 16247);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 16143, 16258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 16143, 16258);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal DeclarationModifiers Modifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 16334, 16360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 16340, 16358);

                    return _modifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 16334, 16360);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 16270, 16371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 16270, 16371);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void CheckAccessibility(Location location, DiagnosticBag diagnostics, bool isExplicitInterfaceImplementation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 16383, 16762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 16525, 16622);

                var
                info = f_10250_16536_16621(_modifiers, this, isExplicitInterfaceImplementation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 16636, 16751) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 16636, 16751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 16686, 16736);

                    f_10250_16686_16735(diagnostics, f_10250_16702_16734(info, location));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 16636, 16751);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 16383, 16762);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_16536_16621(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                symbol, bool
                isExplicitInterfaceImplementation)
                {
                    var return_v = ModifierUtils.CheckAccessibility(modifiers, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, isExplicitInterfaceImplementation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 16536, 16621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10250_16702_16734(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 16702, 16734);
                    return return_v;
                }


                int
                f_10250_16686_16735(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 16686, 16735);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 16383, 16762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 16383, 16762);
            }
        }

        private DeclarationModifiers MakeModifiers(SyntaxTokenList modifiers, bool explicitInterfaceImplementation,
                                                           bool isFieldLike, Location location,
                                                           DiagnosticBag diagnostics, out bool modifierErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 16774, 20490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 17099, 17150);

                bool
                isInterface = f_10250_17118_17149(f_10250_17118_17137(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 17164, 17293);

                var
                defaultAccess = (DynAbs.Tracing.TraceSender.Conditional_F1(10250, 17184, 17231) || ((isInterface && (DynAbs.Tracing.TraceSender.Expression_True(10250, 17184, 17231) && !explicitInterfaceImplementation) && DynAbs.Tracing.TraceSender.Conditional_F2(10250, 17234, 17261)) || DynAbs.Tracing.TraceSender.Conditional_F3(10250, 17264, 17292))) ? DeclarationModifiers.Public : DeclarationModifiers.Private
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 17307, 17379);

                var
                defaultInterfaceImplementationModifiers = DeclarationModifiers.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 17454, 17505);

                var
                allowedModifiers = DeclarationModifiers.Unsafe
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 17519, 19289) || true) && (!explicitInterfaceImplementation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 17519, 19289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 17589, 17983);

                    allowedModifiers |= DeclarationModifiers.New |
                                                        DeclarationModifiers.Sealed |
                                                        DeclarationModifiers.Abstract |
                                                        DeclarationModifiers.Static |
                                                        DeclarationModifiers.Virtual |
                                                        DeclarationModifiers.AccessibilityMask;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 18003, 19077) || true) && (!isInterface)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 18003, 19077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 18061, 18111);

                        allowedModifiers |= DeclarationModifiers.Override;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 18003, 19077);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 18003, 19077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 18367, 18409);

                        defaultAccess = DeclarationModifiers.None;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 18433, 18481);

                        allowedModifiers |= DeclarationModifiers.Extern;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 18503, 19058);

                        defaultInterfaceImplementationModifiers |= DeclarationModifiers.Sealed |
                                                                                       DeclarationModifiers.Abstract |
                                                                                       DeclarationModifiers.Static |
                                                                                       DeclarationModifiers.Virtual |
                                                                                       DeclarationModifiers.Extern |
                                                                                       DeclarationModifiers.AccessibilityMask;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 18003, 19077);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 17519, 19289);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 17519, 19289);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 19111, 19289) || true) && (isInterface)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 19111, 19289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 19160, 19206);

                        f_10250_19160_19205(explicitInterfaceImplementation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 19224, 19274);

                        allowedModifiers |= DeclarationModifiers.Abstract;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 19111, 19289);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 17519, 19289);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 19305, 19442) || true) && (f_10250_19309_19343(f_10250_19309_19328(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 19305, 19442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 19377, 19427);

                    allowedModifiers |= DeclarationModifiers.ReadOnly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 19305, 19442);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 19458, 19571) || true) && (!isInterface)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 19458, 19571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 19508, 19556);

                    allowedModifiers |= DeclarationModifiers.Extern;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 19458, 19571);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 19587, 19734);

                var
                mods = f_10250_19598_19733(modifiers, defaultAccess, allowedModifiers, location, diagnostics, out modifierErrors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 19750, 19794);

                f_10250_19750_19793(
                            this, mods, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 19810, 20100);

                f_10250_19810_20099(!isFieldLike, mods, defaultInterfaceImplementationModifiers, location, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 20277, 20451) || true) && (isInterface)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 20277, 20451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 20326, 20436);

                    mods = f_10250_20333_20435(mods, !isFieldLike, explicitInterfaceImplementation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 20277, 20451);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 20467, 20479);

                return mods;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 16774, 20490);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_17118_17137(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 17118, 17137);
                    return return_v;
                }


                bool
                f_10250_17118_17149(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 17118, 17149);
                    return return_v;
                }


                int
                f_10250_19160_19205(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 19160, 19205);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_19309_19328(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 19309, 19328);
                    return return_v;
                }


                bool
                f_10250_19309_19343(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 19309, 19343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10250_19598_19733(Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                defaultAccess, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                allowedModifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                modifierErrors)
                {
                    var return_v = ModifierUtils.MakeAndCheckNontypeMemberModifiers(modifiers, defaultAccess, allowedModifiers, errorLocation, diagnostics, out modifierErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 19598, 19733);
                    return return_v;
                }


                int
                f_10250_19750_19793(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    symbol.CheckUnsafeModifier(modifiers, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 19750, 19793);
                    return 0;
                }


                int
                f_10250_19810_20099(bool
                hasBody, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                defaultInterfaceImplementationModifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ModifierUtils.ReportDefaultInterfaceImplementationModifiers(hasBody, modifiers, defaultInterfaceImplementationModifiers, errorLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 19810, 20099);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10250_20333_20435(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                mods, bool
                hasBody, bool
                isExplicitInterfaceImplementation)
                {
                    var return_v = ModifierUtils.AdjustModifiersForAnInterfaceMember(mods, hasBody, isExplicitInterfaceImplementation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 20333, 20435);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 16774, 20490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 16774, 20490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void CheckModifiersAndType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 20502, 25772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 20590, 20628);

                Location
                location = f_10250_20610_20624(this)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 20642, 20693);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 20707, 20823);

                bool
                isExplicitInterfaceImplementationInInterface = f_10250_20759_20785(f_10250_20759_20773()) && (DynAbs.Tracing.TraceSender.Expression_True(10250, 20759, 20822) && f_10250_20789_20822())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 20839, 25699) || true) && (f_10250_20843_20869(this) == Accessibility.Private && (DynAbs.Tracing.TraceSender.Expression_True(10250, 20843, 20988) && (f_10250_20899_20908() || (DynAbs.Tracing.TraceSender.Expression_False(10250, 20899, 20973) || (f_10250_20913_20923() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 20913, 20972) && !isExplicitInterfaceImplementationInInterface))) || (DynAbs.Tracing.TraceSender.Expression_False(10250, 20899, 20987) || f_10250_20977_20987()))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 20839, 25699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 21022, 21084);

                    f_10250_21022_21083(diagnostics, ErrorCode.ERR_VirtualPrivate, location, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 20839, 25699);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 20839, 25699);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 21118, 25699) || true) && (f_10250_21122_21130() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 21122, 21173) && (f_10250_21135_21145() || (DynAbs.Tracing.TraceSender.Expression_False(10250, 21135, 21158) || f_10250_21149_21158()) || (DynAbs.Tracing.TraceSender.Expression_False(10250, 21135, 21172) || f_10250_21162_21172()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 21118, 25699);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 21300, 21364);

                        f_10250_21300_21363(                // A static member '{0}' cannot be marked as override, virtual, or abstract
                                        diagnostics, ErrorCode.ERR_StaticNotVirtual, location, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 21118, 25699);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 21118, 25699);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 21398, 25699) || true) && (f_10250_21402_21412() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 21402, 21424) && f_10250_21416_21424()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 21398, 25699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 21527, 21601);

                            f_10250_21527_21600(                // Static member '{0}' cannot be marked 'readonly'.
                                            diagnostics, ErrorCode.ERR_StaticMemberCantBeReadOnly, location, this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 21398, 25699);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 21398, 25699);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 21635, 25699) || true) && (f_10250_21639_21649() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 21639, 21671) && f_10250_21653_21671()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 21635, 25699);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 21770, 21846);

                                f_10250_21770_21845(                // Field-like event '{0}' cannot be 'readonly'.
                                                diagnostics, ErrorCode.ERR_FieldLikeEventCantBeReadOnly, location, this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 21635, 25699);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 21635, 25699);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 21880, 25699) || true) && (f_10250_21884_21894() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 21884, 21918) && (f_10250_21899_21904() || (DynAbs.Tracing.TraceSender.Expression_False(10250, 21899, 21917) || f_10250_21908_21917()))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 21880, 25699);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 22041, 22103);

                                    f_10250_22041_22102(                // A member '{0}' marked as override cannot be marked as new or virtual
                                                    diagnostics, ErrorCode.ERR_OverrideNotNew, location, this);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 21880, 25699);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 21880, 25699);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 22137, 25699) || true) && (f_10250_22141_22149() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 22141, 22164) && f_10250_22153_22164_M(!IsOverride)) && (DynAbs.Tracing.TraceSender.Expression_True(10250, 22141, 22229) && !(isExplicitInterfaceImplementationInInterface && (DynAbs.Tracing.TraceSender.Expression_True(10250, 22170, 22228) && f_10250_22218_22228()))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 22137, 25699);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 22336, 22401);

                                        f_10250_22336_22400(                // '{0}' cannot be sealed because it is not an override
                                                        diagnostics, ErrorCode.ERR_SealedNonOverride, location, this);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 22137, 25699);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 22137, 25699);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 22435, 25699) || true) && (f_10250_22439_22449() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 22439, 22495) && f_10250_22453_22476(f_10250_22453_22467()) == TypeKind.Struct))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 22435, 25699);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 22595, 22699);

                                            f_10250_22595_22698(                // The modifier '{0}' is not valid for this item
                                                            diagnostics, ErrorCode.ERR_BadMemberFlag, location, f_10250_22650_22697(SyntaxKind.AbstractKeyword));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 22435, 25699);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 22435, 25699);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 22733, 25699) || true) && (f_10250_22737_22746() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 22737, 22792) && f_10250_22750_22773(f_10250_22750_22764()) == TypeKind.Struct))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 22733, 25699);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 22892, 22995);

                                                f_10250_22892_22994(                // The modifier '{0}' is not valid for this item
                                                                diagnostics, ErrorCode.ERR_BadMemberFlag, location, f_10250_22947_22993(SyntaxKind.VirtualKeyword));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 22733, 25699);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 22733, 25699);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 23029, 25699) || true) && (f_10250_23033_23043() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 23033, 23055) && f_10250_23047_23055()))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 23029, 25699);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 23089, 23154);

                                                    f_10250_23089_23153(diagnostics, ErrorCode.ERR_AbstractAndExtern, location, this);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 23029, 25699);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 23029, 25699);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 23188, 25699) || true) && (f_10250_23192_23202() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 23192, 23214) && f_10250_23206_23214()) && (DynAbs.Tracing.TraceSender.Expression_True(10250, 23192, 23263) && !isExplicitInterfaceImplementationInInterface))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 23188, 25699);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 23297, 23362);

                                                        f_10250_23297_23361(diagnostics, ErrorCode.ERR_AbstractAndSealed, location, this);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 23188, 25699);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 23188, 25699);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 23396, 25699) || true) && (f_10250_23400_23410() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 23400, 23423) && f_10250_23414_23423()))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 23396, 25699);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 23457, 23545);

                                                            f_10250_23457_23544(diagnostics, ErrorCode.ERR_AbstractNotVirtual, location, f_10250_23517_23537(f_10250_23517_23526(this)), this);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 23396, 25699);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 23396, 25699);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 23579, 25699) || true) && (f_10250_23583_23606(f_10250_23583_23597()) && (DynAbs.Tracing.TraceSender.Expression_True(10250, 23583, 23651) && f_10250_23610_23651(f_10250_23610_23636(this))) && (DynAbs.Tracing.TraceSender.Expression_True(10250, 23583, 23671) && f_10250_23655_23671_M(!this.IsOverride)))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 23579, 25699);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 23705, 23802);

                                                                f_10250_23705_23801(diagnostics, f_10250_23721_23784(f_10250_23769_23783()), location, this);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 23579, 25699);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 23579, 25699);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 23836, 25699) || true) && (f_10250_23840_23863(f_10250_23840_23854()) && (DynAbs.Tracing.TraceSender.Expression_True(10250, 23840, 23876) && f_10250_23867_23876_M(!IsStatic)))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 23836, 25699);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 23910, 23985);

                                                                    f_10250_23910_23984(diagnostics, ErrorCode.ERR_InstanceMemberInStaticClass, location, f_10250_23979_23983());
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 23836, 25699);
                                                                }

                                                                else
                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 23836, 25699);

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 24019, 25699) || true) && (f_10250_24023_24045(f_10250_24023_24032(this)))
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 24019, 25699);
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 24019, 25699);
                                                                    }

                                                                    else
                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 24019, 25699);

                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 24169, 25699) || true) && (!f_10250_24174_24233(this, f_10250_24199_24208(this), ref useSiteDiagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(10250, 24173, 24501) &&                //(CSharpSyntaxNode as EventDeclarationSyntax)?.ExplicitInterfaceSpecifier == null
                                                                                        ((!(f_10250_24358_24374() is EventDeclarationSyntax)) || (DynAbs.Tracing.TraceSender.Expression_False(10250, 24355, 24500) || f_10250_24423_24492(((EventDeclarationSyntax)f_10250_24448_24464())) == null))))
                                                                        )

                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 24169, 25699);
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 24729, 24803);

                                                                            f_10250_24729_24802(                // Dev10 reports different errors for field-like events (ERR_BadVisFieldType) and custom events (ERR_BadVisPropertyType).
                                                                                                                // Both seem odd, so add a new one.

                                                                                            diagnostics, ErrorCode.ERR_BadVisEventType, location, this, f_10250_24792_24801(this));
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 24169, 25699);
                                                                        }

                                                                        else
                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 24169, 25699);

                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 24837, 25699) || true) && (!f_10250_24842_24868(f_10250_24842_24851(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10250, 24841, 24896) && !f_10250_24873_24896(f_10250_24873_24882(this))))
                                                                            )

                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 24837, 25699);
                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 24978, 25042);

                                                                                f_10250_24978_25041(                // Suppressed for error types.
                                                                                                diagnostics, ErrorCode.ERR_EventNotDelegate, location, this);
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 24837, 25699);
                                                                            }

                                                                            else
                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 24837, 25699);

                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 25076, 25699) || true) && (f_10250_25080_25090() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 25080, 25120) && f_10250_25094_25120_M(!f_10250_25095_25109().IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10250, 25080, 25217) && (f_10250_25125_25148(f_10250_25125_25139()) == TypeKind.Class || (DynAbs.Tracing.TraceSender.Expression_False(10250, 25125, 25216) || f_10250_25170_25193(f_10250_25170_25184()) == TypeKind.Submission))))
                                                                                )

                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 25076, 25699);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 25336, 25423);

                                                                                    f_10250_25336_25422(                // '{0}' is abstract but it is contained in non-abstract type '{1}'
                                                                                                    diagnostics, ErrorCode.ERR_AbstractInConcreteClass, location, this, f_10250_25407_25421());
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 25076, 25699);
                                                                                }

                                                                                else
                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 25076, 25699);

                                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 25457, 25699) || true) && (f_10250_25461_25470() && (DynAbs.Tracing.TraceSender.Expression_True(10250, 25461, 25497) && f_10250_25474_25497(f_10250_25474_25488())))
                                                                                    )

                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 25457, 25699);
                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 25602, 25684);

                                                                                        f_10250_25602_25683(                // '{0}' is a new virtual member in sealed type '{1}'
                                                                                                        diagnostics, ErrorCode.ERR_NewVirtualInSealed, location, this, f_10250_25668_25682());
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 25457, 25699);
                                                                                    }
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 25076, 25699);
                                                                                }
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 24837, 25699);
                                                                            }
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 24169, 25699);
                                                                        }
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 24019, 25699);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 23836, 25699);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 23579, 25699);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 23396, 25699);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 23188, 25699);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 23029, 25699);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 22733, 25699);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 22435, 25699);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 22137, 25699);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 21880, 25699);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 21635, 25699);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 21398, 25699);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 21118, 25699);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 20839, 25699);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 25715, 25761);

                f_10250_25715_25760(
                            diagnostics, location, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 20502, 25772);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10250_20610_20624(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 20610, 20624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_20759_20773()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 20759, 20773);
                    return return_v;
                }


                bool
                f_10250_20759_20785(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 20759, 20785);
                    return return_v;
                }


                bool
                f_10250_20789_20822()
                {
                    var return_v = IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 20789, 20822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10250_20843_20869(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 20843, 20869);
                    return return_v;
                }


                bool
                f_10250_20899_20908()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 20899, 20908);
                    return return_v;
                }


                bool
                f_10250_20913_20923()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 20913, 20923);
                    return return_v;
                }


                bool
                f_10250_20977_20987()
                {
                    var return_v = IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 20977, 20987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_21022_21083(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 21022, 21083);
                    return return_v;
                }


                bool
                f_10250_21122_21130()
                {
                    var return_v = IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 21122, 21130);
                    return return_v;
                }


                bool
                f_10250_21135_21145()
                {
                    var return_v = IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 21135, 21145);
                    return return_v;
                }


                bool
                f_10250_21149_21158()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 21149, 21158);
                    return return_v;
                }


                bool
                f_10250_21162_21172()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 21162, 21172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_21300_21363(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 21300, 21363);
                    return return_v;
                }


                bool
                f_10250_21402_21412()
                {
                    var return_v = IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 21402, 21412);
                    return return_v;
                }


                bool
                f_10250_21416_21424()
                {
                    var return_v = IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 21416, 21424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_21527_21600(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 21527, 21600);
                    return return_v;
                }


                bool
                f_10250_21639_21649()
                {
                    var return_v = IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 21639, 21649);
                    return return_v;
                }


                bool
                f_10250_21653_21671()
                {
                    var return_v = HasAssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 21653, 21671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_21770_21845(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 21770, 21845);
                    return return_v;
                }


                bool
                f_10250_21884_21894()
                {
                    var return_v = IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 21884, 21894);
                    return return_v;
                }


                bool
                f_10250_21899_21904()
                {
                    var return_v = IsNew;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 21899, 21904);
                    return return_v;
                }


                bool
                f_10250_21908_21917()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 21908, 21917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_22041_22102(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 22041, 22102);
                    return return_v;
                }


                bool
                f_10250_22141_22149()
                {
                    var return_v = IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 22141, 22149);
                    return return_v;
                }


                bool
                f_10250_22153_22164_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 22153, 22164);
                    return return_v;
                }


                bool
                f_10250_22218_22228()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 22218, 22228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_22336_22400(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 22336, 22400);
                    return return_v;
                }


                bool
                f_10250_22439_22449()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 22439, 22449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_22453_22467()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 22453, 22467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10250_22453_22476(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 22453, 22476);
                    return return_v;
                }


                string
                f_10250_22650_22697(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 22650, 22697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_22595_22698(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 22595, 22698);
                    return return_v;
                }


                bool
                f_10250_22737_22746()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 22737, 22746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_22750_22764()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 22750, 22764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10250_22750_22773(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 22750, 22773);
                    return return_v;
                }


                string
                f_10250_22947_22993(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 22947, 22993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_22892_22994(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 22892, 22994);
                    return return_v;
                }


                bool
                f_10250_23033_23043()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23033, 23043);
                    return return_v;
                }


                bool
                f_10250_23047_23055()
                {
                    var return_v = IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23047, 23055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_23089_23153(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 23089, 23153);
                    return return_v;
                }


                bool
                f_10250_23192_23202()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23192, 23202);
                    return return_v;
                }


                bool
                f_10250_23206_23214()
                {
                    var return_v = IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23206, 23214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_23297_23361(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 23297, 23361);
                    return return_v;
                }


                bool
                f_10250_23400_23410()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23400, 23410);
                    return return_v;
                }


                bool
                f_10250_23414_23423()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23414, 23423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10250_23517_23526(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23517, 23526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10250_23517_23537(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 23517, 23537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_23457_23544(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 23457, 23544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_23583_23597()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23583, 23597);
                    return return_v;
                }


                bool
                f_10250_23583_23606(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23583, 23606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10250_23610_23636(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23610, 23636);
                    return return_v;
                }


                bool
                f_10250_23610_23651(Microsoft.CodeAnalysis.Accessibility
                accessibility)
                {
                    var return_v = accessibility.HasProtected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 23610, 23651);
                    return return_v;
                }


                bool
                f_10250_23655_23671_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23655, 23671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_23769_23783()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23769, 23783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10250_23721_23784(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType)
                {
                    var return_v = AccessCheck.GetProtectedMemberInSealedTypeError(containingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 23721, 23784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_23705_23801(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 23705, 23801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_23840_23854()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23840, 23854);
                    return return_v;
                }


                bool
                f_10250_23840_23863(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23840, 23863);
                    return return_v;
                }


                bool
                f_10250_23867_23876_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23867, 23876);
                    return return_v;
                }


                string
                f_10250_23979_23983()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 23979, 23983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_23910_23984(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 23910, 23984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10250_24023_24032(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 24023, 24032);
                    return return_v;
                }


                bool
                f_10250_24023_24045(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 24023, 24045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10250_24199_24208(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 24199, 24208);
                    return return_v;
                }


                bool
                f_10250_24174_24233(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = symbol.IsNoMoreVisibleThan(type, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 24174, 24233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10250_24358_24374()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 24358, 24374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10250_24448_24464()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 24448, 24464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10250_24423_24492(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 24423, 24492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10250_24792_24801(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 24792, 24801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_24729_24802(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 24729, 24802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10250_24842_24851(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 24842, 24851);
                    return return_v;
                }


                bool
                f_10250_24842_24868(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 24842, 24868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10250_24873_24882(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 24873, 24882);
                    return return_v;
                }


                bool
                f_10250_24873_24896(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 24873, 24896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_24978_25041(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 24978, 25041);
                    return return_v;
                }


                bool
                f_10250_25080_25090()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 25080, 25090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_25095_25109()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 25095, 25109);
                    return return_v;
                }


                bool
                f_10250_25094_25120_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 25094, 25120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_25125_25139()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 25125, 25139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10250_25125_25148(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 25125, 25148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_25170_25184()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 25170, 25184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10250_25170_25193(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 25170, 25193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_25407_25421()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 25407, 25421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_25336_25422(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 25336, 25422);
                    return return_v;
                }


                bool
                f_10250_25461_25470()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 25461, 25470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_25474_25488()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 25474, 25488);
                    return return_v;
                }


                bool
                f_10250_25474_25497(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 25474, 25497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10250_25668_25682()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 25668, 25682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10250_25602_25683(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 25602, 25683);
                    return return_v;
                }


                bool
                f_10250_25715_25760(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 25715, 25760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 20502, 25772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 20502, 25772);
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo? preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 25784, 26206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 25972, 26068);

                ref var
                lazyDocComment = ref (DynAbs.Tracing.TraceSender.Conditional_F1(10250, 26001, 26015) || ((expandIncludes && DynAbs.Tracing.TraceSender.Conditional_F2(10250, 26018, 26045)) || DynAbs.Tracing.TraceSender.Conditional_F3(10250, 26048, 26067))) ? ref _lazyExpandedDocComment : ref _lazyDocComment
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 26082, 26195);

                return f_10250_26089_26194(this, expandIncludes, ref lazyDocComment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 25784, 26206);

                string
                f_10250_26089_26194(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                symbol, bool
                expandIncludes, ref string?
                lazyXmlText)
                {
                    var return_v = SourceDocumentationCommentUtils.GetAndCacheDocumentationComment((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, expandIncludes, ref lazyXmlText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 26089, 26194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 25784, 26206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 25784, 26206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static void CopyEventCustomModifiers(EventSymbol eventWithCustomModifiers, ref TypeWithAnnotations type, AssemblySymbol containingAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10250, 26218, 27341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 26392, 26453);

                f_10250_26392_26452((object)eventWithCustomModifiers != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 26469, 26532);

                TypeSymbol
                overriddenEventType = f_10250_26502_26531(eventWithCustomModifiers)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 26855, 27330) || true) && (f_10250_26859_27053(type.Type, overriddenEventType, TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes | TypeCompareKind.IgnoreDynamic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 26855, 27330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 27087, 27315);

                    type = type.WithTypeAndModifiers(f_10250_27120_27215(overriddenEventType, type.Type, containingAssembly), eventWithCustomModifiers.TypeWithAnnotations.CustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 26855, 27330);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10250, 26218, 27341);

                int
                f_10250_26392_26452(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 26392, 26452);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10250_26502_26531(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 26502, 26531);
                    return return_v;
                }


                bool
                f_10250_26859_27053(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 26859, 27053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10250_27120_27215(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destinationType, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                containingAssembly)
                {
                    var return_v = CustomModifierUtils.CopyTypeCustomModifiers(sourceType, destinationType, containingAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 27120, 27215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 26218, 27341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 26218, 27341);
            }
        }

        internal override OverriddenOrHiddenMembersResult OverriddenOrHiddenMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 27453, 27771);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 27489, 27700) || true) && (_lazyOverriddenOrHiddenMembers == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 27489, 27700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 27573, 27681);

                        f_10250_27573_27680(ref _lazyOverriddenOrHiddenMembers, f_10250_27637_27673(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 27489, 27700);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 27718, 27756);

                    return _lazyOverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 27453, 27771);

                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10250_27637_27673(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    member)
                    {
                        var return_v = member.MakeOverriddenOrHiddenMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 27637, 27673);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    f_10250_27573_27680(ref Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 27573, 27680);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 27353, 27782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 27353, 27782);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsWindowsRuntimeEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 27868, 28324);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 27904, 28179) || true) && (!f_10250_27909_27946(_lazyIsWindowsRuntimeEvent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 27904, 28179);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 28085, 28160);

                        _lazyIsWindowsRuntimeEvent = f_10250_28114_28159(f_10250_28114_28144(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 27904, 28179);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 28197, 28249);

                    f_10250_28197_28248(f_10250_28210_28247(_lazyIsWindowsRuntimeEvent));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 28267, 28309);

                    return f_10250_28274_28308(_lazyIsWindowsRuntimeEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 27868, 28324);

                    bool
                    f_10250_27909_27946(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.HasValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 27909, 27946);
                        return return_v;
                    }


                    bool
                    f_10250_28114_28144(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    this_param)
                    {
                        var return_v = this_param.ComputeIsWindowsRuntimeEvent();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 28114, 28144);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_10250_28114_28159(bool
                    value)
                    {
                        var return_v = value.ToThreeState();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 28114, 28159);
                        return return_v;
                    }


                    bool
                    f_10250_28210_28247(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.HasValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 28210, 28247);
                        return return_v;
                    }


                    int
                    f_10250_28197_28248(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 28197, 28248);
                        return 0;
                    }


                    bool
                    f_10250_28274_28308(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.Value();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 28274, 28308);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 27794, 28335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 27794, 28335);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool ComputeIsWindowsRuntimeEvent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 28347, 32345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 28530, 28631);

                ImmutableArray<EventSymbol>
                explicitInterfaceImplementations = f_10250_28593_28630(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 28645, 29219) || true) && (f_10250_28649_28690_M(!explicitInterfaceImplementations.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 28645, 29219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 28854, 28913);

                    f_10250_28854_28912(explicitInterfaceImplementations.Length == 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 29067, 29119);

                    f_10250_29067_29118((object?)f_10250_29089_29109(this) == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 29139, 29204);

                    return f_10250_29146_29203(explicitInterfaceImplementations[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 28645, 29219);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 29391, 29523) || true) && (f_10250_29395_29432(this.containingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 29391, 29523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 29466, 29508);

                    return f_10250_29473_29507(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 29391, 29523);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 29642, 29694);

                EventSymbol?
                overriddenEvent = f_10250_29673_29693(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 29708, 29838) || true) && ((object?)overriddenEvent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 29708, 29838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 29778, 29823);

                    return f_10250_29785_29822(overriddenEvent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 29708, 29838);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 30474, 30513);

                bool
                sawImplicitImplementation = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 30527, 31833);
                    foreach (NamedTypeSymbol @interface in f_10250_30566_30643_I(f_10250_30566_30643(f_10250_30566_30638(this.containingType))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 30527, 31833);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 30677, 31818);
                            foreach (Symbol interfaceMember in f_10250_30712_30744_I(f_10250_30712_30744(@interface, f_10250_30734_30743(this))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 30677, 31818);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 30786, 31799) || true) && (f_10250_30790_30810(interfaceMember) == SymbolKind.Event && (DynAbs.Tracing.TraceSender.Expression_True(10250, 30790, 30949) && f_10250_30901_30949(interfaceMember)) && (DynAbs.Tracing.TraceSender.Expression_True(10250, 30790, 31472) &&                        // We are passing ignoreImplementationInInterfacesIfResultIsNotReady: true to avoid a cycle. If false is passed, FindImplementationForInterfaceMemberInNonInterface
                                                                                                                                                                                                                                                                                                                                                                                           // will look how event accessors are implemented and we end up here again since we will need to know their signature for that.
                                                        this == f_10250_31327_31472(this.containingType, interfaceMember, ignoreImplementationInInterfacesIfResultIsNotReady: true)))
                                ) //slow check (necessary and sufficient)

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 30786, 31799);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 31562, 31595);

                                    sawImplicitImplementation = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 31623, 31776) || true) && (f_10250_31627_31679(((EventSymbol)interfaceMember)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 31623, 31776);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 31737, 31749);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 31623, 31776);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 30786, 31799);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 30677, 31818);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10250, 1, 1142);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10250, 1, 1142);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 30527, 31833);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10250, 1, 1307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10250, 1, 1307);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 31994, 32085) || true) && (sawImplicitImplementation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 31994, 32085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 32057, 32070);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 31994, 32085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 32292, 32334);

                return f_10250_32299_32333(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 28347, 32345);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10250_28593_28630(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 28593, 28630);
                    return return_v;
                }


                bool
                f_10250_28649_28690_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 28649, 28690);
                    return return_v;
                }


                int
                f_10250_28854_28912(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 28854, 28912);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                f_10250_29089_29109(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 29089, 29109);
                    return return_v;
                }


                int
                f_10250_29067_29118(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 29067, 29118);
                    return 0;
                }


                bool
                f_10250_29146_29203(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsWindowsRuntimeEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 29146, 29203);
                    return return_v;
                }


                bool
                f_10250_29395_29432(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 29395, 29432);
                    return return_v;
                }


                bool
                f_10250_29473_29507(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                symbol)
                {
                    var return_v = symbol.IsCompilationOutputWinMdObj();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 29473, 29507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                f_10250_29673_29693(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 29673, 29693);
                    return return_v;
                }


                bool
                f_10250_29785_29822(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsWindowsRuntimeEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 29785, 29822);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10250_30566_30638(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 30566, 30638);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet>.KeyCollection
                f_10250_30566_30643(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 30566, 30643);
                    return return_v;
                }


                string
                f_10250_30734_30743(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 30734, 30743);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10250_30712_30744(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 30712, 30744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10250_30790_30810(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 30790, 30810);
                    return return_v;
                }


                bool
                f_10250_30901_30949(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsImplementableInterfaceMember();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 30901, 30949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10250_31327_31472(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, bool
                ignoreImplementationInInterfacesIfResultIsNotReady)
                {
                    var return_v = this_param.FindImplementationForInterfaceMemberInNonInterface(interfaceMember, ignoreImplementationInInterfacesIfResultIsNotReady: ignoreImplementationInInterfacesIfResultIsNotReady);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 31327, 31472);
                    return return_v;
                }


                bool
                f_10250_31627_31679(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsWindowsRuntimeEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 31627, 31679);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10250_30712_30744_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 30712, 30744);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet>.KeyCollection
                f_10250_30566_30643_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 30566, 30643);
                    return return_v;
                }


                bool
                f_10250_32299_32333(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                symbol)
                {
                    var return_v = symbol.IsCompilationOutputWinMdObj();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 32299, 32333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 28347, 32345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 28347, 32345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetAccessorName(string eventName, bool isAdder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10250, 32357, 32513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 32452, 32502);

                return ((DynAbs.Tracing.TraceSender.Conditional_F1(10250, 32460, 32467) || ((isAdder && DynAbs.Tracing.TraceSender.Conditional_F2(10250, 32470, 32476)) || DynAbs.Tracing.TraceSender.Conditional_F3(10250, 32479, 32488))) ? "add_" : "remove_") + eventName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10250, 32357, 32513);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 32357, 32513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 32357, 32513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TypeWithAnnotations BindEventType(Binder binder, TypeSyntax typeSyntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 32525, 33120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 32898, 33045);

                binder = f_10250_32907_33044(binder, BinderFlags.SuppressConstraintChecks | BinderFlags.SuppressUnsafeDiagnostics, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 33061, 33109);

                return f_10250_33068_33108(binder, typeSyntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 32525, 33120);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10250_32907_33044(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                containing)
                {
                    var return_v = this_param.WithAdditionalFlagsAndContainingMemberOrLambda(flags, (Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 32907, 33044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10250_33068_33108(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 33068, 33108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 32525, 33120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 32525, 33120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AfterAddingTypeMembersChecks(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10250, 33132, 33972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 33264, 33303);

                var
                compilation = f_10250_33282_33302()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 33317, 33350);

                var
                location = f_10250_33332_33346(this)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 33366, 33406);

                f_10250_33366_33405(
                            this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 33420, 33499);

                f_10250_33420_33498(f_10250_33420_33429(this), compilation, conversions, location, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 33515, 33691) || true) && (f_10250_33519_33547(f_10250_33519_33523()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 33515, 33691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 33581, 33676);

                    f_10250_33581_33675(compilation, diagnostics, location, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 33515, 33691);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 33707, 33961) || true) && (f_10250_33711_33757(compilation, this) && (DynAbs.Tracing.TraceSender.Expression_True(10250, 33711, 33822) && f_10250_33778_33797().NeedsNullableAttribute()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10250, 33707, 33961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10250, 33856, 33946);

                    f_10250_33856_33945(compilation, diagnostics, location, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10250, 33707, 33961);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10250, 33132, 33972);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10250_33282_33302()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 33282, 33302);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10250_33332_33346(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 33332, 33346);
                    return return_v;
                }


                int
                f_10250_33366_33405(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckModifiersAndType(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 33366, 33405);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10250_33420_33429(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 33420, 33429);
                    return return_v;
                }


                int
                f_10250_33420_33498(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, conversions, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 33420, 33498);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10250_33519_33523()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 33519, 33523);
                    return return_v;
                }


                bool
                f_10250_33519_33547(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 33519, 33547);
                    return return_v;
                }


                int
                f_10250_33581_33675(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNativeIntegerAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 33581, 33675);
                    return 0;
                }


                bool
                f_10250_33711_33757(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 33711, 33757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10250_33778_33797()
                {
                    var return_v = TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 33778, 33797);
                    return return_v;
                }


                int
                f_10250_33856_33945(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNullableAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 33856, 33945);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10250, 33132, 33972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 33132, 33972);
            }
        }

        static SourceEventSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10250, 957, 33979);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10250, 957, 33979);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10250, 957, 33979);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10250, 957, 33979);

        Microsoft.CodeAnalysis.SyntaxReference
        f_10250_2220_2241(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 2220, 2241);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10250_2395_2511(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        this_param, Microsoft.CodeAnalysis.SyntaxTokenList
        modifiers, bool
        explicitInterfaceImplementation, bool
        isFieldLike, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, out bool
        modifierErrors)
        {
            var return_v = this_param.MakeModifiers(modifiers, explicitInterfaceImplementation, isFieldLike, location, diagnostics, out modifierErrors);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 2395, 2511);
            return return_v;
        }


        int
        f_10250_2526_2608(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        this_param, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, bool
        isExplicitInterfaceImplementation)
        {
            this_param.CheckAccessibility(location, diagnostics, isExplicitInterfaceImplementation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 2526, 2608);
            return 0;
        }


        Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData?
        f_10250_13924_13958(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 13924, 13958);
            return return_v;
        }


        bool?
        f_10250_13924_13995_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 13924, 13995);
            return return_v;
        }


        Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData?
        f_10250_14330_14364(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10250, 14330, 14364);
            return return_v;
        }


        bool?
        f_10250_14330_14392_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10250, 14330, 14392);
            return return_v;
        }

    }
}
