// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SourcePropertySymbol : SourcePropertySymbolBase
    {
        internal static SourcePropertySymbol Create(SourceMemberContainerTypeSymbol containingType, Binder bodyBinder, PropertyDeclarationSyntax syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10273, 541, 943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 737, 771);

                var
                nameToken = f_10273_753_770(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 785, 824);

                var
                location = nameToken.GetLocation()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 838, 932);

                return f_10273_845_931(containingType, bodyBinder, syntax, nameToken.ValueText, location, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10273, 541, 943);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10273_753_770(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 753, 770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                f_10273_845_931(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                syntax, string
                name, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Create(containingType, binder, (Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)syntax, name, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 845, 931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 541, 943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 541, 943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SourcePropertySymbol Create(SourceMemberContainerTypeSymbol containingType, Binder bodyBinder, IndexerDeclarationSyntax syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10273, 955, 1316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 1150, 1198);

                var
                location = syntax.ThisKeyword.GetLocation()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 1212, 1305);

                return f_10273_1219_1304(containingType, bodyBinder, syntax, DefaultIndexerName, location, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10273, 955, 1316);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                f_10273_1219_1304(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                syntax, string
                name, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Create(containingType, binder, (Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)syntax, name, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 1219, 1304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 955, 1316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 955, 1316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SourcePropertySymbol Create(
                    SourceMemberContainerTypeSymbol containingType,
                    Binder binder,
                    BasePropertyDeclarationSyntax syntax,
                    string name,
                    Location location,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10273, 1328, 3719);
                bool isAutoProperty = default(bool);
                bool hasAccessorList = default(bool);
                bool accessorsHaveImplementation = default(bool);
                bool isInitOnly = default(bool);
                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode? getSyntax = default(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?);
                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode? setSyntax = default(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 1634, 1964);

                f_10273_1634_1963(syntax, diagnostics, out isAutoProperty, out hasAccessorList, out accessorsHaveImplementation, out isInitOnly, out getSyntax, out setSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 1980, 2051);

                var
                explicitInterfaceSpecifier = f_10273_2013_2050(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 2065, 2134);

                SyntaxTokenList
                modifiersTokenList = f_10273_2102_2133(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 2148, 2226);

                bool
                isExplicitInterfaceImplementation = explicitInterfaceSpecifier is object
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 2240, 2625);

                var
                modifiers = f_10273_2256_2624(containingType, modifiersTokenList, isExplicitInterfaceImplementation, isIndexer: f_10273_2421_2434(syntax) == SyntaxKind.IndexerDeclaration, accessorsHaveImplementation: accessorsHaveImplementation, location, diagnostics, out _)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 2641, 2722);

                bool
                isExpressionBodied = !hasAccessorList && (DynAbs.Tracing.TraceSender.Expression_True(10273, 2667, 2721) && f_10273_2687_2713(syntax) != null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 2738, 2802);

                binder = f_10273_2747_2801(binder, modifiersTokenList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 2816, 2850);

                TypeSymbol?
                explicitInterfaceType
                = default(TypeSymbol?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 2864, 2890);

                string?
                aliasQualifierOpt
                = default(string?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 2904, 3086);

                string
                memberName = f_10273_2924_3085(binder, explicitInterfaceSpecifier, name, diagnostics, out explicitInterfaceType, out aliasQualifierOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 3102, 3708);

                return f_10273_3109_3707(containingType, syntax, hasGetAccessor: getSyntax != null || (DynAbs.Tracing.TraceSender.Expression_False(10273, 3226, 3265) || isExpressionBodied), hasSetAccessor: setSyntax != null, isExplicitInterfaceImplementation, explicitInterfaceType, aliasQualifierOpt, modifiers, isAutoProperty: isAutoProperty, isExpressionBodied: isExpressionBodied, isInitOnly: isInitOnly, memberName, location, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10273, 1328, 3719);

                int
                f_10273_1634_1963(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                isAutoProperty, out bool
                hasAccessorList, out bool
                accessorsHaveImplementation, out bool
                isInitOnly, out Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                getSyntax, out Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                setSyntax)
                {
                    GetAccessorDeclarations((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntaxNode, diagnostics, out isAutoProperty, out hasAccessorList, out accessorsHaveImplementation, out isInitOnly, out getSyntax, out setSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 1634, 1963);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10273_2013_2050(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                syntax)
                {
                    var return_v = GetExplicitInterfaceSpecifier((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 2013, 2050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10273_2102_2133(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                syntax)
                {
                    var return_v = GetModifierTokensSyntax((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 2102, 2133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10273_2421_2434(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 2421, 2434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10273_2256_2624(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingType, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, bool
                isExplicitInterfaceImplementation, bool
                isIndexer, bool
                accessorsHaveImplementation, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                modifierErrors)
                {
                    var return_v = MakeModifiers((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, modifiers, isExplicitInterfaceImplementation, isIndexer: isIndexer, accessorsHaveImplementation: accessorsHaveImplementation, location, diagnostics, out modifierErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 2256, 2624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10273_2687_2713(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                syntax)
                {
                    var return_v = GetArrowExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 2687, 2713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10273_2747_2801(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers)
                {
                    var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 2747, 2801);
                    return return_v;
                }


                string
                f_10273_2924_3085(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                explicitInterfaceSpecifierOpt, string
                name, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                explicitInterfaceTypeOpt, out string?
                aliasQualifierOpt)
                {
                    var return_v = ExplicitInterfaceHelpers.GetMemberNameAndInterfaceSymbol(binder, explicitInterfaceSpecifierOpt, name, diagnostics, out explicitInterfaceTypeOpt, out aliasQualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 2924, 3085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                f_10273_3109_3707(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                syntax, bool
                hasGetAccessor, bool
                hasSetAccessor, bool
                isExplicitInterfaceImplementation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                explicitInterfaceType, string
                aliasQualifierOpt, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, bool
                isAutoProperty, bool
                isExpressionBodied, bool
                isInitOnly, string
                memberName, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol(containingType, syntax, hasGetAccessor: hasGetAccessor, hasSetAccessor: hasSetAccessor, isExplicitInterfaceImplementation, explicitInterfaceType, aliasQualifierOpt, modifiers, isAutoProperty: isAutoProperty, isExpressionBodied: isExpressionBodied, isInitOnly: isInitOnly, memberName, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 3109, 3707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 1328, 3719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 1328, 3719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SourcePropertySymbol(
                    SourceMemberContainerTypeSymbol containingType,
                    BasePropertyDeclarationSyntax syntax,
                    bool hasGetAccessor,
                    bool hasSetAccessor,
                    bool isExplicitInterfaceImplementation,
                    TypeSymbol? explicitInterfaceType,
                    string? aliasQualifierOpt,
                    DeclarationModifiers modifiers,
                    bool isAutoProperty,
                    bool isExpressionBodied,
                    bool isInitOnly,
                    string memberName,
                    Location location,
                    DiagnosticBag diagnostics)
        : base(
        f_10273_4371_4385_C(containingType), syntax, hasGetAccessor, hasSetAccessor, isExplicitInterfaceImplementation, explicitInterfaceType, aliasQualifierOpt, modifiers, hasInitializer: f_10273_4667_4689(syntax), isAutoProperty: isAutoProperty, isExpressionBodied: isExpressionBodied, isInitOnly: isInitOnly, f_10273_4855_4879(f_10273_4855_4866(syntax)), memberName, f_10273_4927_4948(syntax), location, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10273, 3731, 5592);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 5031, 5389) || true) && (f_10273_5035_5049())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 5031, 5389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 5083, 5374);

                    f_10273_5083_5373(syntax, (DynAbs.Tracing.TraceSender.Conditional_F1(10273, 5166, 5201) || (((hasGetAccessor && (DynAbs.Tracing.TraceSender.Expression_True(10273, 5167, 5200) && !hasSetAccessor)) && DynAbs.Tracing.TraceSender.Conditional_F2(10273, 5204, 5258)) || DynAbs.Tracing.TraceSender.Conditional_F3(10273, 5261, 5307))) ? MessageID.IDS_FeatureReadonlyAutoImplementedProperties : MessageID.IDS_FeatureAutoImplementedProperties, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 5031, 5389);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 5405, 5581);

                f_10273_5405_5580(f_10273_5454_5473(syntax), f_10273_5492_5524(syntax), syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10273, 3731, 5592);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 3731, 5592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 3731, 5592);
            }
        }

        private TypeSyntax GetTypeSyntax(SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 5656, 5703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 5659, 5703);
                return f_10273_5659_5703(((BasePropertyDeclarationSyntax)syntax)); DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 5656, 5703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 5656, 5703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 5656, 5703);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
            f_10273_5659_5703(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 5659, 5703);
                return return_v;
            }

        }

        protected override Location TypeLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 5770, 5813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 5773, 5813);
                    return f_10273_5773_5813(f_10273_5773_5804(this, f_10273_5787_5803())); DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 5770, 5813);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 5770, 5813);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 5770, 5813);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static SyntaxTokenList GetModifierTokensSyntax(SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 5913, 5965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 5916, 5965);
                return f_10273_5916_5965(((BasePropertyDeclarationSyntax)syntax)); DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 5913, 5965);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 5913, 5965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 5913, 5965);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxTokenList
            f_10273_5916_5965(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
            this_param)
            {
                var return_v = this_param.Modifiers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 5916, 5965);
                return return_v;
            }

        }

        private static ArrowExpressionClauseSyntax? GetArrowExpression(SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 6073, 6328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 6076, 6328);
                return syntax switch
                {
                    PropertyDeclarationSyntax p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 6122, 6169) && DynAbs.Tracing.TraceSender.Expression_True(10273, 6122, 6169))
    => f_10273_6153_6169(p),
                    IndexerDeclarationSyntax i when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 6188, 6234) && DynAbs.Tracing.TraceSender.Expression_True(10273, 6188, 6234))
    => f_10273_6218_6234(i),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 6253, 6313) && DynAbs.Tracing.TraceSender.Expression_True(10273, 6253, 6313))
    => throw f_10273_6264_6313(f_10273_6299_6312(syntax))
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 6073, 6328);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 6073, 6328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 6073, 6328);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            f_10273_6153_6169(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
            this_param)
            {
                var return_v = this_param.ExpressionBody;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 6153, 6169);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            f_10273_6218_6234(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
            this_param)
            {
                var return_v = this_param.ExpressionBody;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 6218, 6234);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10273_6299_6312(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = node.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 6299, 6312);
                return return_v;
            }


            System.Exception
            f_10273_6264_6313(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 6264, 6313);
                return return_v;
            }

        }

        private static bool HasInitializer(SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 6408, 6467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 6411, 6467);
                return syntax is PropertyDeclarationSyntax { Initializer: { } }; DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 6408, 6467);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 6408, 6467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 6408, 6467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SyntaxList<AttributeListSyntax> AttributeDeclarationSyntaxList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 6572, 6639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 6575, 6639);
                    return f_10273_6575_6639(((BasePropertyDeclarationSyntax)f_10273_6607_6623())); DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 6572, 6639);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 6572, 6639);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 6572, 6639);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override IAttributeTargetSymbol AttributesOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 6707, 6714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 6710, 6714);
                    return this; DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 6707, 6714);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 6707, 6714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 6707, 6714);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static void GetAccessorDeclarations(
                    CSharpSyntaxNode syntaxNode,
                    DiagnosticBag diagnostics,
                    out bool isAutoProperty,
                    out bool hasAccessorList,
                    out bool accessorsHaveImplementation,
                    out bool isInitOnly,
                    out CSharpSyntaxNode? getSyntax,
                    out CSharpSyntaxNode? setSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10273, 6727, 10032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7132, 7187);

                var
                syntax = (BasePropertyDeclarationSyntax)syntaxNode
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7201, 7223);

                isAutoProperty = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7237, 7283);

                hasAccessorList = f_10273_7255_7274(syntax) != null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7297, 7314);

                getSyntax = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7328, 7345);

                setSyntax = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7359, 7378);

                isInitOnly = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7394, 10021) || true) && (hasAccessorList)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 7394, 10021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7447, 7483);

                    accessorsHaveImplementation = false;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7501, 9832);
                        foreach (var accessor in f_10273_7526_7556_I(f_10273_7526_7556(syntax.AccessorList!)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 7501, 9832);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7598, 9572);

                            switch (f_10273_7606_7621(accessor))
                            {

                                case SyntaxKind.GetAccessorDeclaration:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 7598, 9572);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7740, 8090) || true) && (getSyntax == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 7740, 8090);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7827, 7848);

                                        getSyntax = accessor;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 7740, 8090);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 7740, 8090);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 7978, 8059);

                                        f_10273_7978_8058(diagnostics, ErrorCode.ERR_DuplicateAccessor, accessor.Keyword.GetLocation());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 7740, 8090);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10273, 8120, 8126);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 7598, 9572);

                                case SyntaxKind.SetAccessorDeclaration:
                                case SyntaxKind.InitAccessorDeclaration:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 7598, 9572);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 8287, 8849) || true) && (setSyntax == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 8287, 8849);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 8374, 8395);

                                        setSyntax = accessor;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 8429, 8607) || true) && (accessor.Keyword.IsKind(SyntaxKind.InitKeyword))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 8429, 8607);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 8554, 8572);

                                            isInitOnly = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 8429, 8607);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 8287, 8849);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 8287, 8849);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 8737, 8818);

                                        f_10273_8737_8817(diagnostics, ErrorCode.ERR_DuplicateAccessor, accessor.Keyword.GetLocation());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 8287, 8849);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10273, 8879, 8885);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 7598, 9572);

                                case SyntaxKind.AddAccessorDeclaration:
                                case SyntaxKind.RemoveAccessorDeclaration:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 7598, 9572);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 9048, 9128);

                                    f_10273_9048_9127(diagnostics, ErrorCode.ERR_GetOrSetExpected, accessor.Keyword.GetLocation());
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 9158, 9167);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 7598, 9572);

                                case SyntaxKind.UnknownAccessorDeclaration:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 7598, 9572);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 9418, 9427);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 7598, 9572);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 7598, 9572);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 9491, 9549);

                                    throw f_10273_9497_9548(f_10273_9532_9547(accessor));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 7598, 9572);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 9596, 9813) || true) && (f_10273_9600_9613(accessor) != null || (DynAbs.Tracing.TraceSender.Expression_False(10273, 9600, 9656) || f_10273_9625_9648(accessor) != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 9596, 9813);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 9706, 9729);

                                isAutoProperty = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 9755, 9790);

                                accessorsHaveImplementation = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 9596, 9813);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 7501, 9832);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10273, 1, 2332);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10273, 1, 2332);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 7394, 10021);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 7394, 10021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 9898, 9921);

                    isAutoProperty = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 9939, 10006);

                    accessorsHaveImplementation = f_10273_9969_9995(syntax) is object;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 7394, 10021);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10273, 6727, 10032);

                Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax?
                f_10273_7255_7274(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AccessorList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 7255, 7274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
                f_10273_7526_7556(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
                this_param)
                {
                    var return_v = this_param.Accessors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 7526, 7556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10273_7606_7621(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 7606, 7621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10273_7978_8058(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 7978, 8058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10273_8737_8817(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 8737, 8817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10273_9048_9127(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 9048, 9127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10273_9532_9547(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 9532, 9547);
                    return return_v;
                }


                System.Exception
                f_10273_9497_9548(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 9497, 9548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10273_9600_9613(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 9600, 9613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10273_9625_9648(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 9625, 9648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
                f_10273_7526_7556_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 7526, 7556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10273_9969_9995(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                syntax)
                {
                    var return_v = GetArrowExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 9969, 9995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 6727, 10032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 6727, 10032);
            }
        }

        private static AccessorDeclarationSyntax GetGetAccessorDeclaration(BasePropertyDeclarationSyntax syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10273, 10044, 10506);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 10173, 10442);
                    foreach (var accessor in f_10273_10198_10228_I(f_10273_10198_10228(syntax.AccessorList!)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 10173, 10442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 10262, 10427);

                        switch (f_10273_10270_10285(accessor))
                        {

                            case SyntaxKind.GetAccessorDeclaration:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 10262, 10427);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 10392, 10408);

                                return accessor;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 10262, 10427);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 10173, 10442);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10273, 1, 270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10273, 1, 270);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 10458, 10495);

                throw f_10273_10464_10494();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10273, 10044, 10506);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
                f_10273_10198_10228(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
                this_param)
                {
                    var return_v = this_param.Accessors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 10198, 10228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10273_10270_10285(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 10270, 10285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
                f_10273_10198_10228_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 10198, 10228);
                    return return_v;
                }


                System.Exception
                f_10273_10464_10494()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 10464, 10494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 10044, 10506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 10044, 10506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static AccessorDeclarationSyntax GetSetAccessorDeclaration(BasePropertyDeclarationSyntax syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10273, 10518, 11042);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 10647, 10978);
                    foreach (var accessor in f_10273_10672_10702_I(f_10273_10672_10702(syntax.AccessorList!)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 10647, 10978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 10736, 10963);

                        switch (f_10273_10744_10759(accessor))
                        {

                            case SyntaxKind.SetAccessorDeclaration:
                            case SyntaxKind.InitAccessorDeclaration:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 10736, 10963);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 10928, 10944);

                                return accessor;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 10736, 10963);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 10647, 10978);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10273, 1, 332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10273, 1, 332);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 10994, 11031);

                throw f_10273_11000_11030();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10273, 10518, 11042);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
                f_10273_10672_10702(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
                this_param)
                {
                    var return_v = this_param.Accessors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 10672, 10702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10273_10744_10759(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 10744, 10759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
                f_10273_10672_10702_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 10672, 10702);
                    return return_v;
                }


                System.Exception
                f_10273_11000_11030()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 11000, 11030);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 10518, 11042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 10518, 11042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static DeclarationModifiers MakeModifiers(
                    NamedTypeSymbol containingType,
                    SyntaxTokenList modifiers,
                    bool isExplicitInterfaceImplementation,
                    bool isIndexer,
                    bool accessorsHaveImplementation,
                    Location location,
                    DiagnosticBag diagnostics,
                    out bool modifierErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10273, 11054, 14971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 11453, 11499);

                bool
                isInterface = f_10273_11472_11498(containingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 11513, 11644);

                var
                defaultAccess = (DynAbs.Tracing.TraceSender.Conditional_F1(10273, 11533, 11582) || ((isInterface && (DynAbs.Tracing.TraceSender.Expression_True(10273, 11533, 11582) && !isExplicitInterfaceImplementation) && DynAbs.Tracing.TraceSender.Conditional_F2(10273, 11585, 11612)) || DynAbs.Tracing.TraceSender.Conditional_F3(10273, 11615, 11643))) ? DeclarationModifiers.Public : DeclarationModifiers.Private
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 11719, 11770);

                var
                allowedModifiers = DeclarationModifiers.Unsafe
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 11784, 11856);

                var
                defaultInterfaceImplementationModifiers = DeclarationModifiers.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 11872, 13670) || true) && (!isExplicitInterfaceImplementation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 11872, 13670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 11944, 12271);

                    allowedModifiers |= DeclarationModifiers.New |
                                                        DeclarationModifiers.Sealed |
                                                        DeclarationModifiers.Abstract |
                                                        DeclarationModifiers.Virtual |
                                                        DeclarationModifiers.AccessibilityMask;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 12291, 12414) || true) && (!isIndexer)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 12291, 12414);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 12347, 12395);

                        allowedModifiers |= DeclarationModifiers.Static;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 12291, 12414);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 12434, 13456) || true) && (!isInterface)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 12434, 13456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 12492, 12542);

                        allowedModifiers |= DeclarationModifiers.Override;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 12434, 13456);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 12434, 13456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 12798, 12840);

                        defaultAccess = DeclarationModifiers.None;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 12864, 13437);

                        defaultInterfaceImplementationModifiers |= DeclarationModifiers.Sealed |
                                                                                       DeclarationModifiers.Abstract |
                                                                                       ((DynAbs.Tracing.TraceSender.Conditional_F1(10273, 13098, 13107) || ((isIndexer && DynAbs.Tracing.TraceSender.Conditional_F2(10273, 13110, 13111)) || DynAbs.Tracing.TraceSender.Conditional_F3(10273, 13114, 13141))) ? 0 : DeclarationModifiers.Static) |
                                                                                       DeclarationModifiers.Virtual |
                                                                                       DeclarationModifiers.Extern |
                                                                                       DeclarationModifiers.AccessibilityMask;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 12434, 13456);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 11872, 13670);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 11872, 13670);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 13490, 13670) || true) && (isInterface)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 13490, 13670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 13539, 13587);

                        f_10273_13539_13586(isExplicitInterfaceImplementation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 13605, 13655);

                        allowedModifiers |= DeclarationModifiers.Abstract;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 13490, 13670);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 11872, 13670);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 13686, 13818) || true) && (f_10273_13690_13719(containingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 13686, 13818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 13753, 13803);

                    allowedModifiers |= DeclarationModifiers.ReadOnly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 13686, 13818);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 13834, 13882);

                allowedModifiers |= DeclarationModifiers.Extern;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 13898, 14045);

                var
                mods = f_10273_13909_14044(modifiers, defaultAccess, allowedModifiers, location, diagnostics, out modifierErrors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 14061, 14125);

                f_10273_14061_14124(
                            containingType, mods, location, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 14141, 14446);

                f_10273_14141_14445(accessorsHaveImplementation, mods, defaultInterfaceImplementationModifiers, location, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 14626, 14817) || true) && (isInterface)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 14626, 14817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 14675, 14802);

                    mods = f_10273_14682_14801(mods, accessorsHaveImplementation, isExplicitInterfaceImplementation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 14626, 14817);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 14833, 14932) || true) && (isIndexer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 14833, 14932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 14880, 14917);

                    mods |= DeclarationModifiers.Indexer;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 14833, 14932);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 14948, 14960);

                return mods;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10273, 11054, 14971);

                bool
                f_10273_11472_11498(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 11472, 11498);
                    return return_v;
                }


                int
                f_10273_13539_13586(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 13539, 13586);
                    return 0;
                }


                bool
                f_10273_13690_13719(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 13690, 13719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10273_13909_14044(Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                defaultAccess, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                allowedModifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                modifierErrors)
                {
                    var return_v = ModifierUtils.MakeAndCheckNontypeMemberModifiers(modifiers, defaultAccess, allowedModifiers, errorLocation, diagnostics, out modifierErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 13909, 14044);
                    return return_v;
                }


                int
                f_10273_14061_14124(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    symbol.CheckUnsafeModifier(modifiers, errorLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 14061, 14124);
                    return 0;
                }


                int
                f_10273_14141_14445(bool
                hasBody, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                defaultInterfaceImplementationModifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ModifierUtils.ReportDefaultInterfaceImplementationModifiers(hasBody, modifiers, defaultInterfaceImplementationModifiers, errorLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 14141, 14445);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10273_14682_14801(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                mods, bool
                hasBody, bool
                isExplicitInterfaceImplementation)
                {
                    var return_v = ModifierUtils.AdjustModifiersForAnInterfaceMember(mods, hasBody, isExplicitInterfaceImplementation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 14682, 14801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 11054, 14971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 11054, 14971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SourcePropertyAccessorSymbol CreateGetAccessorSymbol(bool isAutoPropertyAccessor, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 14983, 15695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 15135, 15196);

                var
                syntax = (BasePropertyDeclarationSyntax)f_10273_15179_15195()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 15210, 15284);

                ArrowExpressionClauseSyntax?
                arrowExpression = f_10273_15257_15283(syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 15300, 15684) || true) && (f_10273_15304_15323(syntax) is null && (DynAbs.Tracing.TraceSender.Expression_True(10273, 15304, 15358) && arrowExpression != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 15300, 15684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 15392, 15503);

                    return f_10273_15399_15502(this, arrowExpression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 15300, 15684);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 15300, 15684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 15569, 15669);

                    return f_10273_15576_15668(this, f_10273_15597_15630(syntax), isAutoPropertyAccessor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 15300, 15684);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 14983, 15695);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10273_15179_15195()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 15179, 15195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10273_15257_15283(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                syntax)
                {
                    var return_v = GetArrowExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 15257, 15283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax?
                f_10273_15304_15323(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AccessorList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 15304, 15323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                f_10273_15399_15502(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateExpressionBodiedAccessor(syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 15399, 15502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                f_10273_15597_15630(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                syntax)
                {
                    var return_v = GetGetAccessorDeclaration(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 15597, 15630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                f_10273_15576_15668(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                syntax, bool
                isAutoPropertyAccessor, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateAccessorSymbol(syntax, isAutoPropertyAccessor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 15576, 15668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 14983, 15695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 14983, 15695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SourcePropertyAccessorSymbol CreateSetAccessorSymbol(bool isAutoPropertyAccessor, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 15707, 16144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 15859, 15920);

                var
                syntax = (BasePropertyDeclarationSyntax)f_10273_15903_15919()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 15934, 16017);

                f_10273_15934_16016(!(f_10273_15949_15968(syntax) is null && (DynAbs.Tracing.TraceSender.Expression_True(10273, 15949, 16014) && f_10273_15980_16006(syntax) != null)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 16033, 16133);

                return f_10273_16040_16132(this, f_10273_16061_16094(syntax), isAutoPropertyAccessor, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 15707, 16144);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10273_15903_15919()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 15903, 15919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax?
                f_10273_15949_15968(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AccessorList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 15949, 15968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10273_15980_16006(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                syntax)
                {
                    var return_v = GetArrowExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 15980, 16006);
                    return return_v;
                }


                int
                f_10273_15934_16016(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 15934, 16016);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                f_10273_16061_16094(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                syntax)
                {
                    var return_v = GetSetAccessorDeclaration(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 16061, 16094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                f_10273_16040_16132(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                syntax, bool
                isAutoPropertyAccessor, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateAccessorSymbol(syntax, isAutoPropertyAccessor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 16040, 16132);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 15707, 16144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 15707, 16144);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SourcePropertyAccessorSymbol CreateAccessorSymbol(
                    AccessorDeclarationSyntax syntax,
                    bool isAutoPropertyAccessor,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 16156, 16618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 16368, 16607);

                return f_10273_16375_16606(f_10273_16443_16457(), this, _modifiers, syntax, isAutoPropertyAccessor, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 16156, 16618);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10273_16443_16457()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 16443, 16457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                f_10273_16375_16606(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                property, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                propertyModifiers, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                syntax, bool
                isAutoPropertyAccessor, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = SourcePropertyAccessorSymbol.CreateAccessorSymbol(containingType, property, propertyModifiers, syntax, isAutoPropertyAccessor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 16375, 16606);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 16156, 16618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 16156, 16618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SourcePropertyAccessorSymbol CreateExpressionBodiedAccessor(
                    ArrowExpressionClauseSyntax syntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 16630, 17021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 16812, 17010);

                return f_10273_16819_17009(f_10273_16887_16901(), this, _modifiers, syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 16630, 17021);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10273_16887_16901()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 16887, 16901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                f_10273_16819_17009(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                property, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                propertyModifiers, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = SourcePropertyAccessorSymbol.CreateAccessorSymbol(containingType, property, propertyModifiers, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 16819, 17009);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 16630, 17021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 16630, 17021);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Binder CreateBinderForTypeAndParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 17033, 17658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 17107, 17151);

                var
                compilation = f_10273_17125_17150(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 17165, 17193);

                var
                syntaxTree = f_10273_17182_17192()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 17207, 17237);

                var
                syntax = f_10273_17220_17236()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 17251, 17312);

                var
                binderFactory = f_10273_17271_17311(compilation, syntaxTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 17326, 17385);

                var
                binder = f_10273_17339_17384(binderFactory, syntax, syntax, this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 17399, 17459);

                SyntaxTokenList
                modifiers = f_10273_17427_17458(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 17473, 17528);

                binder = f_10273_17482_17527(binder, modifiers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 17542, 17647);

                return f_10273_17549_17646(binder, BinderFlags.SuppressConstraintChecks, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 17033, 17658);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10273_17125_17150(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 17125, 17150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10273_17182_17192()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 17182, 17192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10273_17220_17236()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 17220, 17236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10273_17271_17311(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 17271, 17311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10273_17339_17384(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                memberDeclarationOpt, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                memberOpt)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node, memberDeclarationOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)memberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 17339, 17384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10273_17427_17458(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = GetModifierTokensSyntax((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 17427, 17458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10273_17482_17527(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers)
                {
                    var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 17482, 17527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10273_17549_17646(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                containing)
                {
                    var return_v = this_param.WithAdditionalFlagsAndContainingMemberOrLambda(flags, (Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 17549, 17646);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 17033, 17658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 17033, 17658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override (TypeWithAnnotations Type, ImmutableArray<ParameterSymbol> Parameters) MakeParametersAndBindType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 17670, 18057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 17837, 17888);

                Binder
                binder = f_10273_17853_17887(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 17902, 17932);

                var
                syntax = f_10273_17915_17931()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 17948, 18046);

                return (f_10273_17956_17996(this, binder, syntax, diagnostics), f_10273_17998_18044(this, binder, syntax, diagnostics));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 17670, 18057);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10273_17853_17887(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param)
                {
                    var return_v = this_param.CreateBinderForTypeAndParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 17853, 17887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10273_17915_17931()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 17915, 17931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10273_17956_17996(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ComputeType(binder, (Microsoft.CodeAnalysis.SyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 17956, 17996);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10273_17998_18044(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ComputeParameters(binder, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 17998, 18044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 17670, 18057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 17670, 18057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWithAnnotations ComputeType(Binder binder, SyntaxNode syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 18069, 19303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 18194, 18210);

                RefKind
                refKind
                = default(RefKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 18224, 18284);

                var
                typeSyntax = f_10273_18241_18283(f_10273_18241_18262(this, syntax), out refKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 18298, 18350);

                var
                type = f_10273_18309_18349(binder, typeSyntax, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 18364, 18415);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;

                // LAFHIS
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 18431, 18937);
                var tempA = f_10273_18435_18466(this) is null;
                var tempB = false;
                if (tempA)
                {
                    DynAbs.Tracing.TraceSender.Expression_True(10273, 18435, 18533);
                    tempB = !this.IsNoMoreVisibleThan(type, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 11691, 11751);
                }
                if (tempA && tempB)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 18431, 18937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 18790, 18922);

                    f_10273_18790_18921(                // "Inconsistent accessibility: indexer return type '{1}' is less accessible than indexer '{0}'"
                                                        // "Inconsistent accessibility: property type '{1}' is less accessible than property '{0}'"
                                    diagnostics, ((DynAbs.Tracing.TraceSender.Conditional_F1(10273, 18807, 18821) || ((f_10273_18807_18821(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10273, 18824, 18857)) || DynAbs.Tracing.TraceSender.Conditional_F3(10273, 18860, 18892))) ? ErrorCode.ERR_BadVisIndexerReturn : ErrorCode.ERR_BadVisPropertyType), f_10273_18895_18903(), this, type.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 18431, 18937);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 18953, 18999);

                f_10273_18953_18998(
                            diagnostics, f_10273_18969_18977(), useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 19015, 19264) || true) && (type.IsVoidType())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 19015, 19264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 19070, 19188);

                    ErrorCode
                    errorCode = (DynAbs.Tracing.TraceSender.Conditional_F1(10273, 19092, 19106) || ((f_10273_19092_19106(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10273, 19109, 19146)) || DynAbs.Tracing.TraceSender.Conditional_F3(10273, 19149, 19187))) ? ErrorCode.ERR_IndexerCantHaveVoidType : ErrorCode.ERR_PropertyCantHaveVoidType
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 19206, 19249);

                    f_10273_19206_19248(diagnostics, errorCode, f_10273_19233_19241(), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 19015, 19264);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 19280, 19292);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 18069, 19303);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10273_18241_18262(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.GetTypeSyntax(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 18241, 18262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10273_18241_18283(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, out Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = syntax.SkipRef(out refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 18241, 18283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10273_18309_18349(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 18309, 18349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10273_18435_18466(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param)
                {
                    var return_v = this_param.GetExplicitInterfaceSpecifier();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 18435, 18466);
                    return return_v;
                }


                bool
                f_10273_18807_18821(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param)
                {
                    var return_v = this_param.IsIndexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 18807, 18821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10273_18895_18903()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 18895, 18903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10273_18790_18921(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 18790, 18921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10273_18969_18977()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 18969, 18977);
                    return return_v;
                }


                bool
                f_10273_18953_18998(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 18953, 18998);
                    return return_v;
                }


                bool
                f_10273_19092_19106(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param)
                {
                    var return_v = this_param.IsIndexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 19092, 19106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10273_19233_19241()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 19233, 19241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10273_19206_19248(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 19206, 19248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 18069, 19303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 18069, 19303);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<ParameterSymbol> MakeParameters(
                    Binder binder, SourcePropertySymbolBase owner, BaseParameterListSyntax? parameterSyntaxOpt, DiagnosticBag diagnostics, bool addRefReadOnlyModifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10273, 19315, 21201);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 19563, 19687) || true) && (parameterSyntaxOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 19563, 19687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 19627, 19672);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 19563, 19687);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 19703, 19893) || true) && (parameterSyntaxOpt.Parameters.Count < 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 19703, 19893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 19780, 19878);

                    f_10273_19780_19877(diagnostics, ErrorCode.ERR_IndexerNeedsParam, f_10273_19829_19862(parameterSyntaxOpt).GetLocation());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 19703, 19893);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 19909, 19934);

                SyntaxToken
                arglistToken
                = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 19948, 20250);

                var
                parameters = f_10273_19965_20249(binder, owner, parameterSyntaxOpt, out arglistToken, allowRefOrOut: false, allowThis: false, addRefReadOnlyModifier: addRefReadOnlyModifier, diagnostics: diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 20266, 20431) || true) && (arglistToken.Kind() != SyntaxKind.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 20266, 20431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 20342, 20416);

                    f_10273_20342_20415(diagnostics, ErrorCode.ERR_IllegalVarArgs, arglistToken.GetLocation());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 20266, 20431);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 20657, 21156) || true) && (parameters.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10273, 20661, 20727) && f_10273_20687_20727_M(!owner.IsExplicitInterfaceImplementation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 20657, 21156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 20761, 20828);

                    ParameterSyntax
                    parameterSyntax = f_10273_20795_20824(parameterSyntaxOpt)[0]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 20846, 21141) || true) && (f_10273_20850_20873(parameterSyntax) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 20846, 21141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 20923, 20979);

                        SyntaxToken
                        paramNameToken = f_10273_20952_20978(parameterSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 21001, 21122);

                        f_10273_21001_21121(diagnostics, ErrorCode.WRN_DefaultValueForUnconsumedLocation, paramNameToken.GetLocation(), paramNameToken.ValueText);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 20846, 21141);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 20657, 21156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 21172, 21190);

                return parameters;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10273, 19315, 21201);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10273_19829_19862(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax
                this_param)
                {
                    var return_v = this_param.GetLastToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 19829, 19862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10273_19780_19877(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 19780, 19877);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10273_19965_20249(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax
                syntax, out Microsoft.CodeAnalysis.SyntaxToken
                arglistToken, bool
                allowRefOrOut, bool
                allowThis, bool
                addRefReadOnlyModifier, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ParameterHelpers.MakeParameters(binder, (Microsoft.CodeAnalysis.CSharp.Symbol)owner, syntax, out arglistToken, allowRefOrOut: allowRefOrOut, allowThis: allowThis, addRefReadOnlyModifier: addRefReadOnlyModifier, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 19965, 20249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10273_20342_20415(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 20342, 20415);
                    return return_v;
                }


                bool
                f_10273_20687_20727_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 20687, 20727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                f_10273_20795_20824(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 20795, 20824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10273_20850_20873(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 20850, 20873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10273_20952_20978(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 20952, 20978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10273_21001_21121(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 21001, 21121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 19315, 21201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 19315, 21201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<ParameterSymbol> ComputeParameters(Binder binder, CSharpSyntaxNode syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 21213, 21603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 21362, 21418);

                var
                parameterSyntaxOpt = f_10273_21387_21417(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 21432, 21560);

                var
                parameters = f_10273_21449_21559(binder, this, parameterSyntaxOpt, diagnostics, addRefReadOnlyModifier: f_10273_21535_21544() || (DynAbs.Tracing.TraceSender.Expression_False(10273, 21535, 21558) || f_10273_21548_21558()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 21574, 21592);

                return parameters;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 21213, 21603);

                Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax?
                f_10273_21387_21417(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = GetParameterListSyntax(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 21387, 21417);
                    return return_v;
                }


                bool
                f_10273_21535_21544()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 21535, 21544);
                    return return_v;
                }


                bool
                f_10273_21548_21558()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 21548, 21558);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10273_21449_21559(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax?
                parameterSyntaxOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                addRefReadOnlyModifier)
                {
                    var return_v = MakeParameters(binder, (Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase)owner, parameterSyntaxOpt, diagnostics, addRefReadOnlyModifier: addRefReadOnlyModifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 21449, 21559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 21213, 21603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 21213, 21603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AfterAddingTypeMembersChecks(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 21615, 22569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 21747, 21807);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AfterAddingTypeMembersChecks(conversions, diagnostics), 10273, 21747, 21806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 21823, 21874);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 21890, 22496);
                    foreach (ParameterSymbol param in f_10273_21924_21934_I(f_10273_21924_21934()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 21890, 22496);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 21968, 22481) || true) && (f_10273_21972_22006_M(!IsExplicitInterfaceImplementation) && (DynAbs.Tracing.TraceSender.Expression_True(10273, 21972, 22071) && !f_10273_22011_22071(this, f_10273_22036_22046(param), ref useSiteDiagnostics)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 21968, 22481);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 22113, 22191);

                            f_10273_22113_22190(diagnostics, ErrorCode.ERR_BadVisIndexerParam, f_10273_22163_22171(), this, f_10273_22179_22189(param));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 21968, 22481);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 21968, 22481);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 22233, 22481) || true) && (f_10273_22237_22246() is object && (DynAbs.Tracing.TraceSender.Expression_True(10273, 22237, 22308) && f_10273_22260_22270(param) == ParameterSymbol.ValueParameterName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10273, 22233, 22481);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 22350, 22462);

                                f_10273_22350_22461(diagnostics, ErrorCode.ERR_DuplicateGeneratedName, param.Locations.FirstOrDefault() ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10273, 22404, 22448) ?? f_10273_22440_22448()), f_10273_22450_22460(param));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 22233, 22481);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 21968, 22481);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10273, 21890, 22496);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10273, 1, 607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10273, 1, 607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 22512, 22558);

                f_10273_22512_22557(
                            diagnostics, f_10273_22528_22536(), useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 21615, 22569);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10273_21924_21934()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 21924, 21934);
                    return return_v;
                }


                bool
                f_10273_21972_22006_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 21972, 22006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10273_22036_22046(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 22036, 22046);
                    return return_v;
                }


                bool
                f_10273_22011_22071(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = symbol.IsNoMoreVisibleThan(type, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 22011, 22071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10273_22163_22171()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 22163, 22171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10273_22179_22189(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 22179, 22189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10273_22113_22190(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 22113, 22190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10273_22237_22246()
                {
                    var return_v = SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 22237, 22246);
                    return return_v;
                }


                string
                f_10273_22260_22270(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 22260, 22270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10273_22440_22448()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 22440, 22448);
                    return return_v;
                }


                string
                f_10273_22450_22460(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 22450, 22460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10273_22350_22461(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 22350, 22461);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10273_21924_21934_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 21924, 21934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10273_22528_22536()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 22528, 22536);
                    return return_v;
                }


                bool
                f_10273_22512_22557(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 22512, 22557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 21615, 22569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 21615, 22569);
            }
        }

        protected override bool HasPointerTypeSyntactically
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 22657, 22909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 22693, 22757);

                    var
                    typeSyntax = f_10273_22710_22756(f_10273_22710_22741(this, f_10273_22724_22740()), out _)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 22775, 22894);

                    return f_10273_22782_22799(typeSyntax) switch
                    {
                        SyntaxKind.PointerType when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 22809, 22839) && DynAbs.Tracing.TraceSender.Expression_True(10273, 22809, 22839))
=> true,
                        SyntaxKind.FunctionPointerType when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 22841, 22879) && DynAbs.Tracing.TraceSender.Expression_True(10273, 22841, 22879))
               => true,
                        _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 22881, 22891) && DynAbs.Tracing.TraceSender.Expression_True(10273, 22881, 22891))
               => false
                    };
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 22657, 22909);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10273_22724_22740()
                    {
                        var return_v = CSharpSyntaxNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 22724, 22740);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    f_10273_22710_22741(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    syntax)
                    {
                        var return_v = this_param.GetTypeSyntax((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 22710, 22741);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    f_10273_22710_22756(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    syntax, out Microsoft.CodeAnalysis.RefKind
                    refKind)
                    {
                        var return_v = syntax.SkipRef(out refKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 22710, 22756);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10273_22782_22799(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 22782, 22799);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 22581, 22920);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 22581, 22920);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static BaseParameterListSyntax? GetParameterListSyntax(CSharpSyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10273, 23033, 23233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10273, 23139, 23233);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10273, 23139, 23175) || ((            // LAFHIS
                                                                                                        //(syntax as IndexerDeclarationSyntax)?.ParameterList
                            (syntax is IndexerDeclarationSyntax) && DynAbs.Tracing.TraceSender.Conditional_F2(10273, 23178, 23226)) || DynAbs.Tracing.TraceSender.Conditional_F3(10273, 23229, 23233))) ? f_10273_23178_23226(((IndexerDeclarationSyntax)syntax)) : null; DynAbs.Tracing.TraceSender.TraceExitMethod(10273, 23033, 23233);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10273, 23033, 23233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 23033, 23233);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax
            f_10273_23178_23226(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
            this_param)
            {
                var return_v = this_param.ParameterList;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 23178, 23226);
                return return_v;
            }

        }

        static SourcePropertySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10273, 455, 23241);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10273, 455, 23241);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10273, 455, 23241);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10273, 455, 23241);

        static bool
        f_10273_4667_4689(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
        syntax)
        {
            var return_v = HasInitializer((Microsoft.CodeAnalysis.SyntaxNode)syntax);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 4667, 4689);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        f_10273_4855_4866(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 4855, 4866);
            return return_v;
        }


        static Microsoft.CodeAnalysis.RefKind
        f_10273_4855_4879(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        syntax)
        {
            var return_v = syntax.GetRefKind();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 4855, 4879);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        f_10273_4927_4948(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
        this_param)
        {
            var return_v = this_param.AttributeLists;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 4927, 4948);
            return return_v;
        }


        bool
        f_10273_5035_5049()
        {
            var return_v = IsAutoProperty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 5035, 5049);
            return return_v;
        }


        bool
        f_10273_5083_5373(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
        syntax, Microsoft.CodeAnalysis.CSharp.MessageID
        feature, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = Binder.CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 5083, 5373);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax?
        f_10273_5454_5473(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
        this_param)
        {
            var return_v = this_param.AccessorList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 5454, 5473);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10273_5492_5524(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
        node)
        {
            var return_v = node.GetExpressionBodySyntax();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 5492, 5524);
            return return_v;
        }


        int
        f_10273_5405_5580(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax?
        block, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        expression, Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
        syntax, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            CheckForBlockAndExpressionBody((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)block, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)expression, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 5405, 5580);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10273_4371_4385_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10273, 3731, 5592);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        f_10273_5787_5803()
        {
            var return_v = CSharpSyntaxNode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 5787, 5803);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        f_10273_5773_5804(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
        this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        syntax)
        {
            var return_v = this_param.GetTypeSyntax((Microsoft.CodeAnalysis.SyntaxNode)syntax);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10273, 5773, 5804);
            return return_v;
        }


        Microsoft.CodeAnalysis.Location
        f_10273_5773_5813(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        this_param)
        {
            var return_v = this_param.Location;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 5773, 5813);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        f_10273_6607_6623()
        {
            var return_v = CSharpSyntaxNode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 6607, 6623);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        f_10273_6575_6639(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
        this_param)
        {
            var return_v = this_param.AttributeLists;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10273, 6575, 6639);
            return return_v;
        }

    }
}
