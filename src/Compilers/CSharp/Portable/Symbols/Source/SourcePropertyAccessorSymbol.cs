// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class SourcePropertyAccessorSymbol : SourceMemberMethodSymbol
    {
        private readonly SourcePropertySymbolBase _property;

        private ImmutableArray<ParameterSymbol> _lazyParameters;

        private TypeWithAnnotations _lazyReturnType;

        private ImmutableArray<CustomModifier> _lazyRefCustomModifiers;

        private ImmutableArray<MethodSymbol> _lazyExplicitInterfaceImplementations;

        private string _lazyName;

        private readonly bool _isAutoPropertyAccessor;

        private readonly bool _isExpressionBodied;

        private readonly bool _usesInit;

        public static SourcePropertyAccessorSymbol CreateAccessorSymbol(
                    NamedTypeSymbol containingType,
                    SourcePropertySymbol property,
                    DeclarationModifiers propertyModifiers,
                    AccessorDeclarationSyntax syntax,
                    bool isAutoPropertyAccessor,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10272, 1143, 2877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 1503, 1711);

                f_10272_1503_1710(f_10272_1516_1529(syntax) == SyntaxKind.GetAccessorDeclaration || (DynAbs.Tracing.TraceSender.Expression_False(10272, 1516, 1637) || f_10272_1587_1600(syntax) == SyntaxKind.SetAccessorDeclaration) || (DynAbs.Tracing.TraceSender.Expression_False(10272, 1516, 1709) || f_10272_1658_1671(syntax) == SyntaxKind.InitAccessorDeclaration));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 1727, 1799);

                bool
                isGetMethod = (f_10272_1747_1760(syntax) == SyntaxKind.GetAccessorDeclaration)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 1813, 1892);

                var
                methodKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10272, 1830, 1841) || ((isGetMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10272, 1844, 1866)) || DynAbs.Tracing.TraceSender.Conditional_F3(10272, 1869, 1891))) ? MethodKind.PropertyGet : MethodKind.PropertySet
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 1908, 1945);

                bool
                hasBody = f_10272_1923_1934(syntax) is object
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 1959, 2016);

                bool
                hasExpressionBody = f_10272_1984_2005(syntax) is object
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 2030, 2135);

                bool
                isNullableAnalysisEnabled = f_10272_2063_2134(f_10272_2063_2098(containingType), syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 2149, 2237);

                f_10272_2149_2236(f_10272_2180_2191(syntax), f_10272_2193_2214(syntax), syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 2251, 2866);

                return f_10272_2258_2865(containingType, property, propertyModifiers, syntax.Keyword.GetLocation(), syntax, hasBody, hasExpressionBody, isIterator: f_10272_2551_2594(f_10272_2582_2593(syntax)), f_10272_2613_2629(syntax), methodKind, syntax.Keyword.IsKind(SyntaxKind.InitKeyword), isAutoPropertyAccessor, isNullableAnalysisEnabled: isNullableAnalysisEnabled, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10272, 1143, 2877);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10272_1516_1529(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 1516, 1529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10272_1587_1600(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 1587, 1600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10272_1658_1671(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 1658, 1671);
                    return return_v;
                }


                int
                f_10272_1503_1710(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 1503, 1710);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10272_1747_1760(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 1747, 1760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10272_1923_1934(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 1923, 1934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10272_1984_2005(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 1984, 2005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10272_2063_2098(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 2063, 2098);
                    return return_v;
                }


                bool
                f_10272_2063_2134(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                syntax)
                {
                    var return_v = this_param.IsNullableAnalysisEnabledIn((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 2063, 2134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10272_2180_2191(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 2180, 2191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10272_2193_2214(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 2193, 2214);
                    return return_v;
                }


                int
                f_10272_2149_2236(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                block, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                expression, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckForBlockAndExpressionBody((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)block, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)expression, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 2149, 2236);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10272_2582_2593(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 2582, 2593);
                    return return_v;
                }


                bool
                f_10272_2551_2594(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                node)
                {
                    var return_v = SyntaxFacts.HasYieldOperations((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 2551, 2594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10272_2613_2629(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 2613, 2629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                f_10272_2258_2865(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                property, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                propertyModifiers, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                syntax, bool
                hasBody, bool
                hasExpressionBody, bool
                isIterator, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.MethodKind
                methodKind, bool
                usesInit, bool
                isAutoPropertyAccessor, bool
                isNullableAnalysisEnabled, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol(containingType, (Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase)property, propertyModifiers, location, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, hasBody, hasExpressionBody, isIterator: isIterator, modifiers, methodKind, usesInit, isAutoPropertyAccessor, isNullableAnalysisEnabled: isNullableAnalysisEnabled, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 2258, 2865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 1143, 2877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 1143, 2877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SourcePropertyAccessorSymbol CreateAccessorSymbol(
                    NamedTypeSymbol containingType,
                    SourcePropertySymbol property,
                    DeclarationModifiers propertyModifiers,
                    ArrowExpressionClauseSyntax syntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10272, 2889, 3652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 3209, 3314);

                bool
                isNullableAnalysisEnabled = f_10272_3242_3313(f_10272_3242_3277(containingType), syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 3328, 3641);

                return f_10272_3335_3640(containingType, property, propertyModifiers, f_10272_3482_3513(f_10272_3482_3499(syntax)), syntax, isNullableAnalysisEnabled: isNullableAnalysisEnabled, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10272, 2889, 3652);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10272_3242_3277(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 3242, 3277);
                    return return_v;
                }


                bool
                f_10272_3242_3313(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                syntax)
                {
                    var return_v = this_param.IsNullableAnalysisEnabledIn((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 3242, 3313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10272_3482_3499(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 3482, 3499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10272_3482_3513(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 3482, 3513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                f_10272_3335_3640(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                property, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                propertyModifiers, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                syntax, bool
                isNullableAnalysisEnabled, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol(containingType, property, propertyModifiers, location, syntax, isNullableAnalysisEnabled: isNullableAnalysisEnabled, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 3335, 3640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 2889, 3652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 2889, 3652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SourcePropertyAccessorSymbol CreateAccessorSymbol(
                    bool isGetMethod,
                    bool usesInit,
                    NamedTypeSymbol containingType,
                    SynthesizedRecordPropertySymbol property,
                    DeclarationModifiers propertyModifiers,
                    Location location,
                    CSharpSyntaxNode syntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10272, 3682, 4733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 4093, 4172);

                var
                methodKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10272, 4110, 4121) || ((isGetMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10272, 4124, 4146)) || DynAbs.Tracing.TraceSender.Conditional_F3(10272, 4149, 4171))) ? MethodKind.PropertyGet : MethodKind.PropertySet
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 4186, 4722);

                return f_10272_4193_4721(containingType, property, propertyModifiers, location, syntax, hasBody: false, hasExpressionBody: false, isIterator: false, modifiers: f_10272_4515_4536(), methodKind, usesInit, isAutoPropertyAccessor: true, isNullableAnalysisEnabled: false, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10272, 3682, 4733);

                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10272_4515_4536()
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 4515, 4536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                f_10272_4193_4721(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordPropertySymbol
                property, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                propertyModifiers, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, bool
                hasBody, bool
                hasExpressionBody, bool
                isIterator, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.MethodKind
                methodKind, bool
                usesInit, bool
                isAutoPropertyAccessor, bool
                isNullableAnalysisEnabled, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol(containingType, (Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase)property, propertyModifiers, location, syntax, hasBody: hasBody, hasExpressionBody: hasExpressionBody, isIterator: isIterator, modifiers: modifiers, methodKind, usesInit, isAutoPropertyAccessor: isAutoPropertyAccessor, isNullableAnalysisEnabled: isNullableAnalysisEnabled, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 4193, 4721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 3682, 4733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 3682, 4733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SourcePropertyAccessorSymbol CreateAccessorSymbol(
                    NamedTypeSymbol containingType,
                    SynthesizedRecordEqualityContractProperty property,
                    DeclarationModifiers propertyModifiers,
                    Location location,
                    CSharpSyntaxNode syntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10272, 4745, 5368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 5107, 5357);

                return f_10272_5114_5356(containingType, property, propertyModifiers, location, syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10272, 4745, 5368);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityContractProperty.GetAccessorSymbol
                f_10272_5114_5356(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityContractProperty
                property, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                propertyModifiers, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityContractProperty.GetAccessorSymbol(containingType, (Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase)property, propertyModifiers, location, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 5114, 5356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 4745, 5368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 4745, 5368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsExpressionBodied
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 5461, 5483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 5464, 5483);
                    return _isExpressionBodied; DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 5461, 5483);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 5461, 5483);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 5461, 5483);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<string> NotNullMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 5572, 5627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 5575, 5627);
                    return _property.NotNullMembers.Concat(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.NotNullMembers, 10272, 5607, 5626)); DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 5572, 5627);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 5572, 5627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 5572, 5627);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<string> NotNullWhenTrueMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 5724, 5795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 5727, 5795);
                    return _property.NotNullWhenTrueMembers.Concat(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.NotNullWhenTrueMembers, 10272, 5767, 5794)); DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 5724, 5795);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 5724, 5795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 5724, 5795);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<string> NotNullWhenFalseMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 5893, 5966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 5896, 5966);
                    return _property.NotNullWhenFalseMembers.Concat(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.NotNullWhenFalseMembers, 10272, 5937, 5965)); DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 5893, 5966);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 5893, 5966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 5893, 5966);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SourcePropertyAccessorSymbol(
                    NamedTypeSymbol containingType,
                    SourcePropertySymbol property,
                    DeclarationModifiers propertyModifiers,
                    Location location,
                    ArrowExpressionClauseSyntax syntax,
                    bool isNullableAnalysisEnabled,
                    DiagnosticBag diagnostics) : base(f_10272_6345_6359_C(containingType), f_10272_6361_6382(syntax), location, isIterator: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10272, 5979, 7740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 658, 667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 971, 980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 1013, 1036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 1069, 1088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 1121, 1130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 6437, 6458);

                _property = property;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 6472, 6504);

                _isAutoPropertyAccessor = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 6518, 6545);

                _isExpressionBodied = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 6707, 6774);

                var
                declarationModifiers = f_10272_6734_6773(propertyModifiers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 6920, 7178);

                f_10272_6920_7177(
                            // ReturnsVoid property is overridden in this class so
                            // returnsVoid argument to MakeFlags is ignored.
                            this, MethodKind.PropertyGet, declarationModifiers, returnsVoid: false, isExtensionMethod: false, isNullableAnalysisEnabled: isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers: f_10272_7134_7176(property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 7194, 7295);

                f_10272_7194_7294(this, syntax, location, hasBody: true, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 7309, 7354);

                f_10272_7309_7353(this, location, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 7370, 7491);

                var
                info = f_10272_7381_7490(this.DeclarationModifiers, this, f_10272_7447_7489(property))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 7505, 7602) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 7505, 7602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 7555, 7587);

                    f_10272_7555_7586(diagnostics, info, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 7505, 7602);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 7618, 7729);

                f_10272_7618_7728(
                            this, location, hasBody: true, isAutoPropertyOrExpressionBodied: true, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10272, 5979, 7740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 5979, 7740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 5979, 7740);
            }
        }

        protected SourcePropertyAccessorSymbol(
                    NamedTypeSymbol containingType,
                    SourcePropertySymbolBase property,
                    DeclarationModifiers propertyModifiers,
                    Location location,
                    CSharpSyntaxNode syntax,
                    bool hasBody,
                    bool hasExpressionBody,
                    bool isIterator,
                    SyntaxTokenList modifiers,
                    MethodKind methodKind,
                    bool usesInit,
                    bool isAutoPropertyAccessor,
                    bool isNullableAnalysisEnabled,
                    DiagnosticBag diagnostics)
        : base(f_10272_8371_8385_C(containingType), f_10272_8407_8428(syntax), location, isIterator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10272, 7770, 10821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 658, 667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 971, 980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 1013, 1036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 1069, 1088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 1121, 1130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 8516, 8537);

                _property = property;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 8551, 8600);

                _isAutoPropertyAccessor = isAutoPropertyAccessor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 8614, 8727);

                f_10272_8614_8726(f_10272_8627_8656_M(!_property.IsExpressionBodied), "Cannot have accessors in expression bodied lightweight properties");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 8741, 8793);

                _isExpressionBodied = !hasBody && (DynAbs.Tracing.TraceSender.Expression_True(10272, 8763, 8792) && hasExpressionBody);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 8807, 8828);

                _usesInit = usesInit;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 8842, 9005) || true) && (_usesInit)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 8842, 9005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 8889, 8990);

                    f_10272_8889_8989(syntax, MessageID.IDS_FeatureInitOnlySetters, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 8842, 9005);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 9021, 9041);

                bool
                modifierErrors
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 9055, 9229);

                var
                declarationModifiers = f_10272_9082_9228(this, modifiers, f_10272_9112_9154(property), hasBody || (DynAbs.Tracing.TraceSender.Expression_False(10272, 9156, 9184) || hasExpressionBody), location, diagnostics, out modifierErrors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 9351, 9457);

                declarationModifiers |= f_10272_9375_9414(propertyModifiers) & ~DeclarationModifiers.AccessibilityMask;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 9471, 9693) || true) && ((declarationModifiers & DeclarationModifiers.Private) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 9471, 9693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 9624, 9678);

                    declarationModifiers &= ~DeclarationModifiers.Virtual;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 9471, 9693);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 9839, 10085);

                f_10272_9839_10084(
                            // ReturnsVoid property is overridden in this class so
                            // returnsVoid argument to MakeFlags is ignored.
                            this, methodKind, declarationModifiers, returnsVoid: false, isExtensionMethod: false, isNullableAnalysisEnabled: isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers: f_10272_10041_10083(property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 10101, 10239);

                f_10272_10101_10238(this, syntax, location, hasBody: hasBody || (DynAbs.Tracing.TraceSender.Expression_False(10272, 10170, 10198) || hasExpressionBody) || (DynAbs.Tracing.TraceSender.Expression_False(10272, 10170, 10224) || isAutoPropertyAccessor), diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 10255, 10381) || true) && (hasBody || (DynAbs.Tracing.TraceSender.Expression_False(10272, 10259, 10287) || hasExpressionBody))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 10255, 10381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 10321, 10366);

                    f_10272_10321_10365(this, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 10255, 10381);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 10397, 10518);

                var
                info = f_10272_10408_10517(this.DeclarationModifiers, this, f_10272_10474_10516(property))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 10532, 10629) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 10532, 10629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 10582, 10614);

                    f_10272_10582_10613(diagnostics, info, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 10532, 10629);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 10645, 10810) || true) && (!modifierErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 10645, 10810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 10698, 10795);

                    f_10272_10698_10794(this, location, hasBody || (DynAbs.Tracing.TraceSender.Expression_False(10272, 10728, 10756) || hasExpressionBody), isAutoPropertyAccessor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 10645, 10810);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10272, 7770, 10821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 7770, 10821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 7770, 10821);
            }
        }

        private static DeclarationModifiers GetAccessorModifiers(DeclarationModifiers propertyModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 10949, 11048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 10965, 11048);
                return propertyModifiers & ~(DeclarationModifiers.Indexer | DeclarationModifiers.ReadOnly); DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 10949, 11048);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 10949, 11048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 10949, 11048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override void MethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 11061, 13452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 11317, 11366);

                _lazyParameters = f_10272_11335_11365(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 11380, 11429);

                _lazyReturnType = f_10272_11398_11428(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 11443, 11506);

                _lazyRefCustomModifiers = ImmutableArray<CustomModifier>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 11522, 11594);

                var
                explicitInterfaceImplementations = f_10272_11561_11593()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 11608, 13441) || true) && (explicitInterfaceImplementations.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 11608, 13441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 11689, 11748);

                    f_10272_11689_11747(explicitInterfaceImplementations.Length == 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 11766, 11835);

                    MethodSymbol
                    implementedMethod = explicitInterfaceImplementations[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 11853, 12152);

                    f_10272_11853_12151(implementedMethod, this, out _lazyReturnType, out _lazyRefCustomModifiers, out _lazyParameters, alsoCopyParamsModifier: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 11608, 13441);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 11608, 13441);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 12186, 13441) || true) && (f_10272_12190_12205(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 12186, 13441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 12414, 12468);

                        MethodSymbol
                        overriddenMethod = f_10272_12446_12467(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 12486, 12888) || true) && ((object)overriddenMethod != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 12486, 12888);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 12564, 12869);

                            f_10272_12564_12868(overriddenMethod, this, out _lazyReturnType, out _lazyRefCustomModifiers, out _lazyParameters, alsoCopyParamsModifier: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 12486, 12888);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 12186, 13441);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 12186, 13441);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 12922, 13441) || true) && (!_lazyReturnType.IsVoidType())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 12922, 13441);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 12989, 13035);

                            PropertySymbol
                            associatedProperty = _property
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 13053, 13103);

                            var
                            type = f_10272_13064_13102(associatedProperty)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 13121, 13344);

                            _lazyReturnType = _lazyReturnType.WithTypeAndModifiers(f_10272_13198_13299(type.Type, _lazyReturnType.Type, f_10272_13275_13298(this)), type.CustomModifiers);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 13362, 13426);

                            _lazyRefCustomModifiers = f_10272_13388_13425(associatedProperty);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 12922, 13441);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 12186, 13441);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 11608, 13441);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 11061, 13452);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10272_11335_11365(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ComputeParameters(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 11335, 11365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10272_11398_11428(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ComputeReturnType(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 11398, 11428);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10272_11561_11593()
                {
                    var return_v = ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 11561, 11593);
                    return return_v;
                }


                int
                f_10272_11689_11747(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 11689, 11747);
                    return 0;
                }


                int
                f_10272_11853_12151(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                sourceMethod, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                destinationMethod, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, bool
                alsoCopyParamsModifier)
                {
                    CustomModifierUtils.CopyMethodCustomModifiers(sourceMethod, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)destinationMethod, out returnType, out customModifiers, out parameters, alsoCopyParamsModifier: alsoCopyParamsModifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 11853, 12151);
                    return 0;
                }


                bool
                f_10272_12190_12205(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 12190, 12205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10272_12446_12467(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 12446, 12467);
                    return return_v;
                }


                int
                f_10272_12564_12868(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                sourceMethod, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                destinationMethod, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, bool
                alsoCopyParamsModifier)
                {
                    CustomModifierUtils.CopyMethodCustomModifiers(sourceMethod, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)destinationMethod, out returnType, out customModifiers, out parameters, alsoCopyParamsModifier: alsoCopyParamsModifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 12564, 12868);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10272_13064_13102(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 13064, 13102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10272_13275_13298(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 13275, 13298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10272_13198_13299(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destinationType, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                containingAssembly)
                {
                    var return_v = CustomModifierUtils.CopyTypeCustomModifiers(sourceType, destinationType, containingAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 13198, 13299);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10272_13388_13425(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 13388, 13425);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 11061, 13452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 11061, 13452);
            }
        }

        public sealed override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 13547, 14002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 13583, 13627);

                    var
                    accessibility = f_10272_13603_13626(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 13645, 13775) || true) && (accessibility != Accessibility.NotApplicable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 13645, 13775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 13735, 13756);

                        return accessibility;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 13645, 13775);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 13795, 13855);

                    var
                    propertyAccessibility = f_10272_13823_13854(_property)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 13873, 13940);

                    f_10272_13873_13939(propertyAccessibility != Accessibility.NotApplicable);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 13958, 13987);

                    return propertyAccessibility;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 13547, 14002);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10272_13603_13626(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                    this_param)
                    {
                        var return_v = this_param.LocalAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 13603, 13626);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Accessibility
                    f_10272_13823_13854(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 13823, 13854);
                        return return_v;
                    }


                    int
                    f_10272_13873_13939(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 13873, 13939);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 13464, 14013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 13464, 14013);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 14096, 14121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 14102, 14119);

                    return _property;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 14096, 14121);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 14025, 14132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 14025, 14132);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 14205, 14226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 14211, 14224);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 14205, 14226);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 14144, 14237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 14144, 14237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 14313, 14357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 14319, 14355);

                    return f_10272_14326_14354(f_10272_14326_14341(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 14313, 14357);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10272_14326_14341(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 14326, 14341);
                        return return_v;
                    }


                    bool
                    f_10272_14326_14354(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsVoidType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 14326, 14354);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 14249, 14368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 14249, 14368);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 14470, 14581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 14506, 14525);

                    f_10272_14506_14524(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 14543, 14566);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 14470, 14581);

                    int
                    f_10272_14506_14524(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 14506, 14524);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 14380, 14592);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 14380, 14592);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 14702, 14759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 14708, 14757);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 14702, 14759);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 14604, 14770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 14604, 14770);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 14904, 14964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 14907, 14964);
                return ImmutableArray<ImmutableArray<TypeWithAnnotations>>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 14904, 14964);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 14904, 14964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 14904, 14964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 15091, 15143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 15094, 15143);
                return ImmutableArray<TypeParameterConstraintKind>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 15091, 15143);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 15091, 15143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 15091, 15143);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 15219, 15252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 15225, 15250);

                    return f_10272_15232_15249(_property);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 15219, 15252);

                    Microsoft.CodeAnalysis.RefKind
                    f_10272_15232_15249(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 15232, 15249);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 15156, 15263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 15156, 15263);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 15368, 15479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 15404, 15423);

                    f_10272_15404_15422(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 15441, 15464);

                    return _lazyReturnType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 15368, 15479);

                    int
                    f_10272_15404_15422(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 15404, 15422);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 15275, 15490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 15275, 15490);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 15607, 16183);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 15643, 15780) || true) && (f_10272_15647_15657() == MethodKind.PropertySet)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 15643, 15780);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 15725, 15761);

                        return FlowAnalysisAnnotations.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 15643, 15780);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 15800, 15842);

                    var
                    result = FlowAnalysisAnnotations.None
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 15860, 15991) || true) && (f_10272_15864_15886(_property))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 15860, 15991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 15928, 15972);

                        result |= FlowAnalysisAnnotations.MaybeNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 15860, 15991);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 16009, 16136) || true) && (f_10272_16013_16033(_property))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 16009, 16136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 16075, 16117);

                        result |= FlowAnalysisAnnotations.NotNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 16009, 16136);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 16154, 16168);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 15607, 16183);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10272_15647_15657()
                    {
                        var return_v = MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 15647, 15657);
                        return return_v;
                    }


                    bool
                    f_10272_15864_15886(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.HasMaybeNull;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 15864, 15886);
                        return return_v;
                    }


                    bool
                    f_10272_16013_16033(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.HasNotNull;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 16013, 16033);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 15502, 16194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 15502, 16194);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 16286, 16319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 16289, 16319);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 16286, 16319);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 16286, 16319);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 16286, 16319);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private TypeWithAnnotations ComputeReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 16332, 17660);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 16429, 17649) || true) && (f_10272_16433_16448(this) == MethodKind.PropertyGet)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 16429, 17649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 16508, 16549);

                    var
                    type = f_10272_16519_16548(_property)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 16567, 16842) || true) && (f_10272_16571_16589(type.Type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 16567, 16842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 16706, 16823);

                        f_10272_16706_16822(                    // '{0}': static types cannot be used as return types
                                            diagnostics, f_10272_16722_16791(f_10272_16758_16790(f_10272_16758_16772())), this.locations[0], type.Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 16567, 16842);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 16862, 16874);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 16429, 17649);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 16429, 17649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 16940, 16965);

                    var
                    binder = f_10272_16953_16964(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 16983, 17100);

                    var
                    type = TypeWithAnnotations.Create(f_10272_17021_17098(binder, SpecialType.System_Void, diagnostics, f_10272_17081_17097(this)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 17120, 17602) || true) && (f_10272_17124_17134())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 17120, 17602);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 17176, 17367);

                        var
                        isInitOnlyType = f_10272_17197_17366(f_10272_17221_17246(this), WellKnownType.System_Runtime_CompilerServices_IsExternalInit, diagnostics, this.locations[0])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 17391, 17524);

                        var
                        modifiers = f_10272_17407_17523(f_10272_17471_17522(isInitOnlyType))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 17546, 17583);

                        type = type.WithModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 17120, 17602);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 17622, 17634);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 16429, 17649);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 16332, 17660);

                Microsoft.CodeAnalysis.MethodKind
                f_10272_16433_16448(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 16433, 16448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10272_16519_16548(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 16519, 16548);
                    return return_v;
                }


                bool
                f_10272_16571_16589(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 16571, 16589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_16758_16772()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 16758, 16772);
                    return return_v;
                }


                bool
                f_10272_16758_16790(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 16758, 16790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10272_16722_16791(bool
                useWarning)
                {
                    var return_v = ErrorFacts.GetStaticClassReturnCode(useWarning);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 16722, 16791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10272_16706_16822(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 16706, 16822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10272_16953_16964(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.GetBinder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 16953, 16964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10272_17081_17097(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 17081, 17097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_17021_17098(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 17021, 17098);
                    return return_v;
                }


                bool
                f_10272_17124_17134()
                {
                    var return_v = IsInitOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 17124, 17134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10272_17221_17246(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 17221, 17246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_17197_17366(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.GetWellKnownType(compilation, type, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 17197, 17366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomModifier
                f_10272_17471_17522(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = CSharpCustomModifier.CreateRequired(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 17471, 17522);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10272_17407_17523(Microsoft.CodeAnalysis.CustomModifier
                item)
                {
                    var return_v = ImmutableArray.Create<CustomModifier>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 17407, 17523);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 16332, 17660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 16332, 17660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Binder GetBinder()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 17672, 17957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 17723, 17753);

                var
                syntax = f_10272_17736_17752(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 17767, 17811);

                var
                compilation = f_10272_17785_17810(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 17825, 17893);

                var
                binderFactory = f_10272_17845_17892(compilation, f_10272_17874_17891(syntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 17907, 17946);

                return f_10272_17914_17945(binderFactory, syntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 17672, 17957);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10272_17736_17752(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 17736, 17752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10272_17785_17810(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 17785, 17810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10272_17874_17891(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 17874, 17891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10272_17845_17892(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 17845, 17892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10272_17914_17945(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 17914, 17945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 17672, 17957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 17672, 17957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 18066, 18185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 18102, 18121);

                    f_10272_18102_18120(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 18139, 18170);

                    return _lazyRefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 18066, 18185);

                    int
                    f_10272_18102_18120(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 18102, 18120);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 17969, 18196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 17969, 18196);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Accessibility LocalAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 18464, 18543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 18470, 18541);

                    return f_10272_18477_18540(this.DeclarationModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 18464, 18543);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10272_18477_18540(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                    modifiers)
                    {
                        var return_v = ModifierUtils.EffectiveAccessibility(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 18477, 18540);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 18398, 18554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 18398, 18554);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool LocalDeclaredReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 18728, 18790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 18731, 18790);
                    return (DeclarationModifiers & DeclarationModifiers.ReadOnly) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 18728, 18790);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 18728, 18790);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 18728, 18790);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsDeclaredReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 19041, 21518);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 19077, 19235) || true) && (f_10272_19081_19102() || (DynAbs.Tracing.TraceSender.Expression_False(10272, 19081, 19162) || (f_10272_19107_19136(_property) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 19107, 19161) && f_10272_19140_19161()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 19077, 19235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 19204, 19216);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 19077, 19235);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 20241, 20294);

                    var
                    options = (CSharpParseOptions)f_10272_20275_20293(f_10272_20275_20285())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 20312, 20453) || true) && (!f_10272_20317_20379(options, MessageID.IDS_FeatureReadOnlyMembers))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 20312, 20453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 20421, 20434);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 20312, 20453);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 20652, 21060);

                    var
                    isReadOnlyAttributeUsable = f_10272_20684_20802(f_10272_20684_20704(), WellKnownMember.System_Runtime_CompilerServices_IsReadOnlyAttribute__ctor) != null || (DynAbs.Tracing.TraceSender.Expression_False(10272, 20684, 21059) || (f_10272_20836_20875(f_10272_20836_20864(f_10272_20836_20856())) != OutputKind.NetModule && (DynAbs.Tracing.TraceSender.Expression_True(10272, 20836, 21058) && f_10272_20925_21029(f_10272_20925_20945(), WellKnownType.System_Runtime_CompilerServices_IsReadOnlyAttribute) is MissingMetadataTypeSymbol)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 21080, 21293) || true) && (!isReadOnlyAttributeUsable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 21080, 21293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 21261, 21274);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 21080, 21293);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 21313, 21503);

                    return f_10272_21320_21349(f_10272_21320_21334()) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 21320, 21393) && f_10272_21374_21393_M(!_property.IsStatic)) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 21320, 21441) && _isAutoPropertyAccessor) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 21320, 21502) && f_10272_21466_21476() == MethodKind.PropertyGet);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 19041, 21518);

                    bool
                    f_10272_19081_19102()
                    {
                        var return_v = LocalDeclaredReadOnly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 19081, 19102);
                        return return_v;
                    }


                    bool
                    f_10272_19107_19136(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.HasReadOnlyModifier;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 19107, 19136);
                        return return_v;
                    }


                    bool
                    f_10272_19140_19161()
                    {
                        var return_v = IsValidReadOnlyTarget;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 19140, 19161);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10272_20275_20285()
                    {
                        var return_v = SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 20275, 20285);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ParseOptions
                    f_10272_20275_20293(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 20275, 20293);
                        return return_v;
                    }


                    bool
                    f_10272_20317_20379(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    this_param, Microsoft.CodeAnalysis.CSharp.MessageID
                    feature)
                    {
                        var return_v = this_param.IsFeatureEnabled(feature);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 20317, 20379);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10272_20684_20704()
                    {
                        var return_v = DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 20684, 20704);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10272_20684_20802(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member)
                    {
                        var return_v = this_param.GetWellKnownTypeMember(member);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 20684, 20802);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10272_20836_20856()
                    {
                        var return_v = DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 20836, 20856);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10272_20836_20864(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 20836, 20864);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.OutputKind
                    f_10272_20836_20875(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.OutputKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 20836, 20875);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10272_20925_20945()
                    {
                        var return_v = DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 20925, 20945);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10272_20925_21029(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    type)
                    {
                        var return_v = this_param.GetWellKnownType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 20925, 21029);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10272_21320_21334()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 21320, 21334);
                        return return_v;
                    }


                    bool
                    f_10272_21320_21349(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsStructType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 21320, 21349);
                        return return_v;
                    }


                    bool
                    f_10272_21374_21393_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 21374, 21393);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10272_21466_21476()
                    {
                        var return_v = MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 21466, 21476);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 18968, 21529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 18968, 21529);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsInitOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 21582, 21607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 21585, 21607);
                    return f_10272_21585_21594_M(!IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 21585, 21607) && _usesInit); DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 21582, 21607);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 21582, 21607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 21582, 21607);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private DeclarationModifiers MakeModifiers(SyntaxTokenList modifiers, bool isExplicitInterfaceImplementation,
                    bool hasBody, Location location, DiagnosticBag diagnostics, out bool modifierErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 21620, 23202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 21971, 22040);

                const DeclarationModifiers
                defaultAccess = DeclarationModifiers.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 22115, 22241);

                var
                allowedModifiers = (DynAbs.Tracing.TraceSender.Conditional_F1(10272, 22138, 22171) || ((isExplicitInterfaceImplementation && DynAbs.Tracing.TraceSender.Conditional_F2(10272, 22174, 22199)) || DynAbs.Tracing.TraceSender.Conditional_F3(10272, 22202, 22240))) ? DeclarationModifiers.None : DeclarationModifiers.AccessibilityMask
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 22255, 22392) || true) && (f_10272_22259_22293(f_10272_22259_22278(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 22255, 22392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 22327, 22377);

                    allowedModifiers |= DeclarationModifiers.ReadOnly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 22255, 22392);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 22408, 22480);

                var
                defaultInterfaceImplementationModifiers = DeclarationModifiers.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 22496, 22699) || true) && (f_10272_22500_22531(f_10272_22500_22519(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 22500, 22569) && !isExplicitInterfaceImplementation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 22496, 22699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 22603, 22684);

                    defaultInterfaceImplementationModifiers = DeclarationModifiers.AccessibilityMask;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 22496, 22699);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 22715, 22862);

                var
                mods = f_10272_22726_22861(modifiers, defaultAccess, allowedModifiers, location, diagnostics, out modifierErrors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 22878, 23163);

                f_10272_22878_23162(hasBody, mods, defaultInterfaceImplementationModifiers, location, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 23179, 23191);

                return mods;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 21620, 23202);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_22259_22278(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 22259, 22278);
                    return return_v;
                }


                bool
                f_10272_22259_22293(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 22259, 22293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_22500_22519(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 22500, 22519);
                    return return_v;
                }


                bool
                f_10272_22500_22531(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 22500, 22531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10272_22726_22861(Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                defaultAccess, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                allowedModifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                modifierErrors)
                {
                    var return_v = ModifierUtils.MakeAndCheckNontypeMemberModifiers(modifiers, defaultAccess, allowedModifiers, errorLocation, diagnostics, out modifierErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 22726, 22861);
                    return return_v;
                }


                int
                f_10272_22878_23162(bool
                hasBody, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                defaultInterfaceImplementationModifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ModifierUtils.ReportDefaultInterfaceImplementationModifiers(hasBody, modifiers, defaultInterfaceImplementationModifiers, errorLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 22878, 23162);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 21620, 23202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 21620, 23202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckModifiers(Location location, bool hasBody, bool isAutoPropertyOrExpressionBodied, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 23214, 26082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 23470, 23519);

                var
                localAccessibility = f_10272_23495_23518(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 23535, 26071) || true) && (f_10272_23539_23549() && (DynAbs.Tracing.TraceSender.Expression_True(10272, 23539, 23579) && f_10272_23553_23579_M(!f_10272_23554_23568().IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 23539, 23676) && (f_10272_23584_23607(f_10272_23584_23598()) == TypeKind.Class || (DynAbs.Tracing.TraceSender.Expression_False(10272, 23584, 23675) || f_10272_23629_23652(f_10272_23629_23643()) == TypeKind.Submission))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 23535, 26071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 23795, 23882);

                    f_10272_23795_23881(                // '{0}' is abstract but it is contained in non-abstract type '{1}'
                                    diagnostics, ErrorCode.ERR_AbstractInConcreteClass, location, this, f_10272_23866_23880());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 23535, 26071);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 23535, 26071);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 23916, 26071) || true) && (f_10272_23920_23929() && (DynAbs.Tracing.TraceSender.Expression_True(10272, 23920, 23956) && f_10272_23933_23956(f_10272_23933_23947())) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 23920, 24002) && f_10272_23960_23983(f_10272_23960_23974()) != TypeKind.Struct))
                    ) // error CS0106 on struct already

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 23916, 26071);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 24141, 24223);

                        f_10272_24141_24222(                // '{0}' is a new virtual member in sealed type '{1}'
                                        diagnostics, ErrorCode.ERR_NewVirtualInSealed, location, this, f_10272_24207_24221());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 23916, 26071);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 23916, 26071);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 24257, 26071) || true) && (!hasBody && (DynAbs.Tracing.TraceSender.Expression_True(10272, 24261, 24282) && f_10272_24273_24282_M(!IsExtern)) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 24261, 24297) && f_10272_24286_24297_M(!IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 24261, 24334) && !isAutoPropertyOrExpressionBodied))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 24257, 26071);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 24368, 24435);

                            f_10272_24368_24434(diagnostics, ErrorCode.ERR_ConcreteMissingBody, location, this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 24257, 26071);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 24257, 26071);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 24469, 26071) || true) && (f_10272_24473_24496(f_10272_24473_24487()) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 24473, 24533) && f_10272_24500_24533(localAccessibility)) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 24473, 24553) && f_10272_24537_24553_M(!this.IsOverride)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 24469, 26071);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 24587, 24684);

                                f_10272_24587_24683(diagnostics, f_10272_24603_24666(f_10272_24651_24665()), location, this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 24469, 26071);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 24469, 26071);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 24718, 26071) || true) && (f_10272_24722_24743() && (DynAbs.Tracing.TraceSender.Expression_True(10272, 24722, 24776) && f_10272_24747_24776(_property)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 24718, 26071);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 24919, 24999);

                                    f_10272_24919_24998(                // Cannot specify 'readonly' modifiers on both property or indexer '{0}' and its accessors.
                                                    diagnostics, ErrorCode.ERR_InvalidPropertyReadOnlyMods, location, _property);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 24718, 26071);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 24718, 26071);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 25033, 26071) || true) && (f_10272_25037_25058() && (DynAbs.Tracing.TraceSender.Expression_True(10272, 25037, 25070) && f_10272_25062_25070()))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 25033, 26071);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 25173, 25247);

                                        f_10272_25173_25246(                // Static member '{0}' cannot be marked 'readonly'.
                                                        diagnostics, ErrorCode.ERR_StaticMemberCantBeReadOnly, location, this);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 25033, 26071);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 25033, 26071);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 25281, 26071) || true) && (f_10272_25285_25306() && (DynAbs.Tracing.TraceSender.Expression_True(10272, 25285, 25320) && f_10272_25310_25320()))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 25281, 26071);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 25449, 25522);

                                            f_10272_25449_25521(                // 'init' accessors cannot be marked 'readonly'. Mark '{0}' readonly instead.
                                                            diagnostics, ErrorCode.ERR_InitCannotBeReadonly, location, _property);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 25281, 26071);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 25281, 26071);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 25556, 26071) || true) && (f_10272_25560_25581() && (DynAbs.Tracing.TraceSender.Expression_True(10272, 25560, 25608) && _isAutoPropertyAccessor) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 25560, 25648) && f_10272_25612_25622() == MethodKind.PropertySet))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 25556, 26071);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 25763, 25835);

                                                f_10272_25763_25834(                // Auto-implemented accessor '{0}' cannot be marked 'readonly'.
                                                                diagnostics, ErrorCode.ERR_AutoSetterCantBeReadOnly, location, this);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 25556, 26071);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 25556, 26071);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 25869, 26071) || true) && (_usesInit && (DynAbs.Tracing.TraceSender.Expression_True(10272, 25873, 25894) && f_10272_25886_25894()))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 25869, 26071);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 25999, 26056);

                                                    f_10272_25999_26055(                // The 'init' accessor is not valid on static members
                                                                    diagnostics, ErrorCode.ERR_BadInitAccessor, location);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 25869, 26071);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 25556, 26071);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 25281, 26071);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 25033, 26071);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 24718, 26071);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 24469, 26071);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 24257, 26071);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 23916, 26071);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 23535, 26071);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 23214, 26082);

                Microsoft.CodeAnalysis.Accessibility
                f_10272_23495_23518(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.LocalAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23495, 23518);
                    return return_v;
                }


                bool
                f_10272_23539_23549()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23539, 23549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_23554_23568()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23554, 23568);
                    return return_v;
                }


                bool
                f_10272_23553_23579_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23553, 23579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_23584_23598()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23584, 23598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10272_23584_23607(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23584, 23607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_23629_23643()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23629, 23643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10272_23629_23652(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23629, 23652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_23866_23880()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23866, 23880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10272_23795_23881(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 23795, 23881);
                    return return_v;
                }


                bool
                f_10272_23920_23929()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23920, 23929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_23933_23947()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23933, 23947);
                    return return_v;
                }


                bool
                f_10272_23933_23956(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23933, 23956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_23960_23974()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23960, 23974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10272_23960_23983(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 23960, 23983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_24207_24221()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 24207, 24221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10272_24141_24222(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 24141, 24222);
                    return return_v;
                }


                bool
                f_10272_24273_24282_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 24273, 24282);
                    return return_v;
                }


                bool
                f_10272_24286_24297_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 24286, 24297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10272_24368_24434(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 24368, 24434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_24473_24487()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 24473, 24487);
                    return return_v;
                }


                bool
                f_10272_24473_24496(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 24473, 24496);
                    return return_v;
                }


                bool
                f_10272_24500_24533(Microsoft.CodeAnalysis.Accessibility
                accessibility)
                {
                    var return_v = accessibility.HasProtected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 24500, 24533);
                    return return_v;
                }


                bool
                f_10272_24537_24553_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 24537, 24553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_24651_24665()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 24651, 24665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10272_24603_24666(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType)
                {
                    var return_v = AccessCheck.GetProtectedMemberInSealedTypeError(containingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 24603, 24666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10272_24587_24683(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 24587, 24683);
                    return return_v;
                }


                bool
                f_10272_24722_24743()
                {
                    var return_v = LocalDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 24722, 24743);
                    return return_v;
                }


                bool
                f_10272_24747_24776(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.HasReadOnlyModifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 24747, 24776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10272_24919_24998(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 24919, 24998);
                    return return_v;
                }


                bool
                f_10272_25037_25058()
                {
                    var return_v = LocalDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 25037, 25058);
                    return return_v;
                }


                bool
                f_10272_25062_25070()
                {
                    var return_v = IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 25062, 25070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10272_25173_25246(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 25173, 25246);
                    return return_v;
                }


                bool
                f_10272_25285_25306()
                {
                    var return_v = LocalDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 25285, 25306);
                    return return_v;
                }


                bool
                f_10272_25310_25320()
                {
                    var return_v = IsInitOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 25310, 25320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10272_25449_25521(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 25449, 25521);
                    return return_v;
                }


                bool
                f_10272_25560_25581()
                {
                    var return_v = LocalDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 25560, 25581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10272_25612_25622()
                {
                    var return_v = MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 25612, 25622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10272_25763_25834(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 25763, 25834);
                    return return_v;
                }


                bool
                f_10272_25886_25894()
                {
                    var return_v = IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 25886, 25894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10272_25999_26055(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 25999, 26055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 23214, 26082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 23214, 26082);
            }
        }

        internal static string GetAccessorName(string propertyName, bool getNotSet, bool isWinMdOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10272, 26227, 26467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 26347, 26413);

                var
                prefix = (DynAbs.Tracing.TraceSender.Conditional_F1(10272, 26360, 26369) || ((getNotSet && DynAbs.Tracing.TraceSender.Conditional_F2(10272, 26372, 26378)) || DynAbs.Tracing.TraceSender.Conditional_F3(10272, 26381, 26412))) ? "get_" : (DynAbs.Tracing.TraceSender.Conditional_F1(10272, 26381, 26394) || ((isWinMdOutput && DynAbs.Tracing.TraceSender.Conditional_F2(10272, 26397, 26403)) || DynAbs.Tracing.TraceSender.Conditional_F3(10272, 26406, 26412))) ? "put_" : "set_"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 26427, 26456);

                return prefix + propertyName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10272, 26227, 26467);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 26227, 26467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 26227, 26467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CSharpSyntaxNode GetSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 26644, 26828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 26706, 26747);

                f_10272_26706_26746(syntaxReferenceOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 26761, 26817);

                return (CSharpSyntaxNode)f_10272_26786_26816(syntaxReferenceOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 26644, 26828);

                int
                f_10272_26706_26746(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 26706, 26746);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10272_26786_26816(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 26786, 26816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 26644, 26828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 26644, 26828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 26928, 27030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 26964, 27015);

                    return f_10272_26971_27014(_property);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 26928, 27030);

                    bool
                    f_10272_26971_27014(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.IsExplicitInterfaceImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 26971, 27014);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 26840, 27041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 26840, 27041);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 27180, 28577);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 27216, 28497) || true) && (_lazyExplicitInterfaceImplementations.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 27216, 28497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 27309, 27463);

                        PropertySymbol?
                        explicitlyImplementedPropertyOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(10272, 27360, 27393) || ((f_10272_27360_27393() && DynAbs.Tracing.TraceSender.Conditional_F2(10272, 27396, 27455)) || DynAbs.Tracing.TraceSender.Conditional_F3(10272, 27458, 27462))) ? _property.ExplicitInterfaceImplementations.FirstOrDefault() : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 27485, 27547);

                        ImmutableArray<MethodSymbol>
                        explicitInterfaceImplementations
                        = default(ImmutableArray<MethodSymbol>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 27571, 28334) || true) && (explicitlyImplementedPropertyOpt is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 27571, 28334);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 27665, 27735);

                            explicitInterfaceImplementations = ImmutableArray<MethodSymbol>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 27571, 28334);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 27571, 28334);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 27833, 28058);

                            MethodSymbol
                            implementedAccessor = (DynAbs.Tracing.TraceSender.Conditional_F1(10272, 27868, 27909) || ((f_10272_27868_27883(this) == MethodKind.PropertyGet
                            && DynAbs.Tracing.TraceSender.Conditional_F2(10272, 27941, 27983)) || DynAbs.Tracing.TraceSender.Conditional_F3(10272, 28015, 28057))) ? f_10272_27941_27983(explicitlyImplementedPropertyOpt) : f_10272_28015_28057(explicitlyImplementedPropertyOpt)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 28086, 28311);

                            explicitInterfaceImplementations = (DynAbs.Tracing.TraceSender.Conditional_F1(10272, 28121, 28156) || (((object)implementedAccessor == null
                            && DynAbs.Tracing.TraceSender.Conditional_F2(10272, 28188, 28222)) || DynAbs.Tracing.TraceSender.Conditional_F3(10272, 28254, 28310))) ? ImmutableArray<MethodSymbol>.Empty
                            : f_10272_28254_28310(implementedAccessor);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 27571, 28334);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 28358, 28478);

                        f_10272_28358_28477(ref _lazyExplicitInterfaceImplementations, explicitInterfaceImplementations);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 27216, 28497);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 28517, 28562);

                    return _lazyExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 27180, 28577);

                    bool
                    f_10272_27360_27393()
                    {
                        var return_v = IsExplicitInterfaceImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 27360, 27393);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10272_27868_27883(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 27868, 27883);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10272_27941_27983(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 27941, 27983);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10272_28015_28057(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 28015, 28057);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10272_28254_28310(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    item)
                    {
                        var return_v = ImmutableArray.Create<MethodSymbol>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 28254, 28310);
                        return return_v;
                    }


                    bool
                    f_10272_28358_28477(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 28358, 28477);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 27071, 28588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 27071, 28588);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 28619, 29170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 28738, 28768);

                var
                syntax = f_10272_28751_28767(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 28782, 29104);

                switch (f_10272_28790_28803(syntax))
                {

                    case SyntaxKind.GetAccessorDeclaration:
                    case SyntaxKind.SetAccessorDeclaration:
                    case SyntaxKind.InitAccessorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 28782, 29104);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 29013, 29089);

                        return f_10272_29020_29088(f_10272_29037_29087(((AccessorDeclarationSyntax)syntax)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 28782, 29104);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 29120, 29159);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetAttributeDeclarations(), 10272, 29127, 29158);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 28619, 29170);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10272_28751_28767(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 28751, 28767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10272_28790_28803(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 28790, 28803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10272_29037_29087(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 29037, 29087);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10272_29020_29088(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 29020, 29088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 28619, 29170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 28619, 29170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 29259, 31917);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 29295, 31865) || true) && (_lazyName is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 29295, 31865);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 29358, 29419);

                        bool
                        isGetMethod = f_10272_29377_29392(this) == MethodKind.PropertyGet
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 29441, 29461);

                        string?
                        name = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 29485, 31541) || true) && (f_10272_29489_29522())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 29485, 31541);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 29572, 29683);

                            PropertySymbol?
                            explicitlyImplementedPropertyOpt = _property.ExplicitInterfaceImplementations.FirstOrDefault()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 29711, 30846) || true) && (explicitlyImplementedPropertyOpt is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 29711, 30846);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 29815, 30019);

                                MethodSymbol?
                                implementedAccessor = (DynAbs.Tracing.TraceSender.Conditional_F1(10272, 29851, 29862) || ((isGetMethod
                                && DynAbs.Tracing.TraceSender.Conditional_F2(10272, 29898, 29940)) || DynAbs.Tracing.TraceSender.Conditional_F3(10272, 29976, 30018))) ? f_10272_29898_29940(explicitlyImplementedPropertyOpt) : f_10272_29976_30018(explicitlyImplementedPropertyOpt)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 30051, 30373);

                                string
                                accessorName = (DynAbs.Tracing.TraceSender.Conditional_F1(10272, 30073, 30108) || (((object)implementedAccessor != null
                                && DynAbs.Tracing.TraceSender.Conditional_F2(10272, 30144, 30168)) || DynAbs.Tracing.TraceSender.Conditional_F3(10272, 30204, 30372))) ? f_10272_30144_30168(implementedAccessor) : f_10272_30204_30372(f_10272_30220_30265(explicitlyImplementedPropertyOpt), isGetMethod, isWinMdOutput: f_10272_30332_30371(_property))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 30486, 30539);

                                var
                                temp = f_10272_30497_30538(_property)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 30569, 30661);

                                string?
                                aliasQualifierOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(10272, 30597, 30609) || ((temp != null && DynAbs.Tracing.TraceSender.Conditional_F2(10272, 30612, 30644)) || DynAbs.Tracing.TraceSender.Conditional_F3(10272, 30647, 30660))) ? f_10272_30612_30644(f_10272_30612_30621(temp)) : (string?)null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 30691, 30819);

                                name = f_10272_30698_30818(accessorName, f_10272_30751_30798(explicitlyImplementedPropertyOpt), aliasQualifierOpt);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 29711, 30846);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 29485, 31541);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 29485, 31541);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 30896, 31541) || true) && (f_10272_30900_30910())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 30896, 31541);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 30960, 31014);

                                MethodSymbol
                                overriddenMethod = f_10272_30992_31013(this)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 31040, 31518) || true) && ((object)overriddenMethod != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 31040, 31518);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 31462, 31491);

                                    name = f_10272_31469_31490(overriddenMethod);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 31040, 31518);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 30896, 31541);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 29485, 31541);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 31565, 31768) || true) && (name is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 31565, 31768);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 31631, 31745);

                            name = f_10272_31638_31744(f_10272_31654_31674(_property), isGetMethod, isWinMdOutput: f_10272_31704_31743(_property));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 31565, 31768);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 31792, 31846);

                        f_10272_31792_31845(ref _lazyName, name);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 29295, 31865);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 31885, 31902);

                    return _lazyName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 29259, 31917);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10272_29377_29392(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 29377, 29392);
                        return return_v;
                    }


                    bool
                    f_10272_29489_29522()
                    {
                        var return_v = IsExplicitInterfaceImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 29489, 29522);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10272_29898_29940(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 29898, 29940);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10272_29976_30018(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 29976, 30018);
                        return return_v;
                    }


                    string
                    f_10272_30144_30168(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 30144, 30168);
                        return return_v;
                    }


                    string
                    f_10272_30220_30265(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 30220, 30265);
                        return return_v;
                    }


                    bool
                    f_10272_30332_30371(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    symbol)
                    {
                        var return_v = symbol.IsCompilationOutputWinMdObj();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 30332, 30371);
                        return return_v;
                    }


                    string
                    f_10272_30204_30372(string
                    propertyName, bool
                    getNotSet, bool
                    isWinMdOutput)
                    {
                        var return_v = GetAccessorName(propertyName, getNotSet, isWinMdOutput: isWinMdOutput);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 30204, 30372);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                    f_10272_30497_30538(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.GetExplicitInterfaceSpecifier();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 30497, 30538);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                    f_10272_30612_30621(Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 30612, 30621);
                        return return_v;
                    }


                    string?
                    f_10272_30612_30644(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                    this_param)
                    {
                        var return_v = this_param.GetAliasQualifierOpt();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 30612, 30644);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10272_30751_30798(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 30751, 30798);
                        return return_v;
                    }


                    string
                    f_10272_30698_30818(string
                    name, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    explicitInterfaceTypeOpt, string?
                    aliasQualifierOpt)
                    {
                        var return_v = ExplicitInterfaceHelpers.GetMemberName(name, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)explicitInterfaceTypeOpt, aliasQualifierOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 30698, 30818);
                        return return_v;
                    }


                    bool
                    f_10272_30900_30910()
                    {
                        var return_v = IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 30900, 30910);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10272_30992_31013(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 30992, 31013);
                        return return_v;
                    }


                    string
                    f_10272_31469_31490(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 31469, 31490);
                        return return_v;
                    }


                    string
                    f_10272_31654_31674(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.SourceName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 31654, 31674);
                        return return_v;
                    }


                    bool
                    f_10272_31704_31743(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    symbol)
                    {
                        var return_v = symbol.IsCompilationOutputWinMdObj();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 31704, 31743);
                        return return_v;
                    }


                    string
                    f_10272_31638_31744(string
                    propertyName, bool
                    getNotSet, bool
                    isWinMdOutput)
                    {
                        var return_v = GetAccessorName(propertyName, getNotSet, isWinMdOutput: isWinMdOutput);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 31638, 31744);
                        return return_v;
                    }


                    string
                    f_10272_31792_31845(ref string?
                    target, string
                    value)
                    {
                        var return_v = InterlockedOperations.Initialize(ref target, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 31792, 31845);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 29200, 31928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 29200, 31928);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 32032, 32653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 32257, 32605);

                    switch (f_10272_32265_32283(f_10272_32265_32276(this)))
                    {

                        case SyntaxKind.GetAccessorDeclaration:
                        case SyntaxKind.SetAccessorDeclaration:
                        case SyntaxKind.InitAccessorDeclaration:
                        case SyntaxKind.ArrowExpressionClause:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 32257, 32605);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 32573, 32586);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 32257, 32605);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 32605, 32606);
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 32626, 32638);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 32032, 32653);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10272_32265_32276(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 32265, 32276);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10272_32265_32283(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 32265, 32283);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 31959, 32664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 31959, 32664);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 32748, 32811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 32784, 32796);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 32748, 32811);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 32676, 32822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 32676, 32822);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 32902, 33022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 32938, 33007);

                    return f_10272_32945_32982_M(!_property.HasSkipLocalsInitAttribute) && (DynAbs.Tracing.TraceSender.Expression_True(10272, 32945, 33006) && DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.AreLocalsZeroed, 10272, 32986, 33006));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 32902, 33022);

                    bool
                    f_10272_32945_32982_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 32945, 32982);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 32834, 33033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 32834, 33033);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<ParameterSymbol> ComputeParameters(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 33045, 34734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 33154, 33215);

                bool
                isGetMethod = f_10272_33173_33188(this) == MethodKind.PropertyGet
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 33229, 33275);

                var
                propertyParameters = f_10272_33254_33274(_property)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 33289, 33341);

                int
                nPropertyParameters = propertyParameters.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 33355, 33417);

                int
                nParameters = nPropertyParameters + ((DynAbs.Tracing.TraceSender.Conditional_F1(10272, 33396, 33407) || ((isGetMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10272, 33410, 33411)) || DynAbs.Tracing.TraceSender.Conditional_F3(10272, 33414, 33415))) ? 0 : 1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 33433, 33547) || true) && (nParameters == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 33433, 33547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 33487, 33532);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 33433, 33547);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 33563, 33635);

                var
                parameters = f_10272_33580_33634(nParameters)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 33883, 34115);
                    foreach (SourceParameterSymbol propertyParam in f_10272_33931_33949_I(propertyParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 33883, 34115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 33983, 34100);

                        f_10272_33983_34099(parameters, f_10272_33998_34098(propertyParam, this, f_10272_34051_34072(propertyParam), suppressOptional: false));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 33883, 34115);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10272, 1, 233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10272, 1, 233);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 34131, 34668) || true) && (!isGetMethod)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 34131, 34668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 34181, 34230);

                    var
                    propertyType = f_10272_34200_34229(_property)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 34248, 34535) || true) && (propertyType.IsStatic)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 34248, 34535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 34388, 34516);

                        f_10272_34388_34515(                    // '{0}': static types cannot be used as parameters
                                            diagnostics, f_10272_34404_34476(f_10272_34443_34475(f_10272_34443_34457())), this.locations[0], propertyType.Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 34248, 34535);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 34555, 34653);

                    f_10272_34555_34652(
                                    parameters, f_10272_34570_34651(this, propertyType, f_10272_34634_34650(parameters)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 34131, 34668);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 34684, 34723);

                return f_10272_34691_34722(parameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 33045, 34734);

                Microsoft.CodeAnalysis.MethodKind
                f_10272_33173_33188(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 33173, 33188);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10272_33254_33274(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 33254, 33274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10272_33580_33634(int
                capacity)
                {
                    var return_v = ArrayBuilder<ParameterSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 33580, 33634);
                    return return_v;
                }


                int
                f_10272_34051_34072(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 34051, 34072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol
                f_10272_33998_34098(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                originalParam, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                newOwner, int
                newOrdinal, bool
                suppressOptional)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol(originalParam, (Microsoft.CodeAnalysis.CSharp.Symbol)newOwner, newOrdinal, suppressOptional: suppressOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 33998, 34098);
                    return return_v;
                }


                int
                f_10272_33983_34099(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 33983, 34099);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10272_33931_33949_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 33931, 33949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10272_34200_34229(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 34200, 34229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10272_34443_34457()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 34443, 34457);
                    return return_v;
                }


                bool
                f_10272_34443_34475(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 34443, 34475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10272_34404_34476(bool
                useWarning)
                {
                    var return_v = ErrorFacts.GetStaticClassParameterCode(useWarning);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 34404, 34476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10272_34388_34515(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 34388, 34515);
                    return return_v;
                }


                int
                f_10272_34634_34650(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 34634, 34650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol
                f_10272_34570_34651(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                accessor, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                paramType, int
                ordinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol)accessor, paramType, ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 34570, 34651);
                    return return_v;
                }


                int
                f_10272_34555_34652(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 34555, 34652);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10272_34691_34722(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 34691, 34722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 33045, 34734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 33045, 34734);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override void AddSynthesizedReturnTypeAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 34746, 35525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 34921, 34992);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedReturnTypeAttributes(moduleBuilder, ref attributes), 10272, 34921, 34991);
                base.AddSynthesizedReturnTypeAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 34921, 34991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 35008, 35060);

                var
                annotations = f_10272_35026_35059()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 35074, 35289) || true) && ((annotations & FlowAnalysisAnnotations.MaybeNull) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 35074, 35289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 35166, 35274);

                    f_10272_35166_35273(ref attributes, f_10272_35206_35272(f_10272_35235_35271(_property)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 35074, 35289);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 35303, 35514) || true) && ((annotations & FlowAnalysisAnnotations.NotNull) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 35303, 35514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 35393, 35499);

                    f_10272_35393_35498(ref attributes, f_10272_35433_35497(f_10272_35462_35496(_property)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 35303, 35514);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 34746, 35525);

                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10272_35026_35059()
                {
                    var return_v = ReturnTypeFlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 35026, 35059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                f_10272_35235_35271(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.MaybeNullAttributeIfExists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 35235, 35271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10272_35206_35272(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                original)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 35206, 35272);
                    return return_v;
                }


                int
                f_10272_35166_35273(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 35166, 35273);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                f_10272_35462_35496(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.NotNullAttributeIfExists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 35462, 35496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10272_35433_35497(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                original)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 35433, 35497);
                    return return_v;
                }


                int
                f_10272_35393_35498(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 35393, 35498);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 34746, 35525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 34746, 35525);
            }
        }

        internal sealed override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10272, 35537, 36750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 35702, 35763);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10272, 35702, 35762);

                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 35702, 35762);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 35779, 36075) || true) && (_isAutoPropertyAccessor)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 35779, 36075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 35840, 35884);

                    var
                    compilation = f_10272_35858_35883(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 35902, 36060);

                    f_10272_35902_36059(ref attributes, f_10272_35942_36058(compilation, WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 35779, 36075);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 36091, 36383) || true) && (f_10272_36095_36118_M(!f_10272_36096_36110().IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 36091, 36383);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 36152, 36368);
                        foreach (var attributeData in f_10272_36182_36222_I(f_10272_36182_36222(_property)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 36152, 36368);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 36264, 36349);

                            f_10272_36264_36348(ref attributes, f_10272_36304_36347(attributeData));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 36152, 36368);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10272, 1, 217);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10272, 1, 217);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 36091, 36383);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 36399, 36739) || true) && (f_10272_36403_36434_M(!f_10272_36404_36426().IsEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(10272, 36403, 36470) || f_10272_36438_36470_M(!f_10272_36439_36462().IsEmpty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 36399, 36739);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 36504, 36724);
                        foreach (var attributeData in f_10272_36534_36578_I(f_10272_36534_36578(_property)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10272, 36504, 36724);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10272, 36620, 36705);

                            f_10272_36620_36704(ref attributes, f_10272_36660_36703(attributeData));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 36504, 36724);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10272, 1, 221);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10272, 1, 221);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10272, 36399, 36739);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10272, 35537, 36750);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10272_35858_35883(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 35858, 35883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10272_35942_36058(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 35942, 36058);
                    return return_v;
                }


                int
                f_10272_35902_36059(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 35902, 36059);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10272_36096_36110()
                {
                    var return_v = NotNullMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 36096, 36110);
                    return return_v;
                }


                bool
                f_10272_36095_36118_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 36095, 36118);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>
                f_10272_36182_36222(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.MemberNotNullAttributeIfExists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 36182, 36222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10272_36304_36347(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                original)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 36304, 36347);
                    return return_v;
                }


                int
                f_10272_36264_36348(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 36264, 36348);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>
                f_10272_36182_36222_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 36182, 36222);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10272_36404_36426()
                {
                    var return_v = NotNullWhenTrueMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 36404, 36426);
                    return return_v;
                }


                bool
                f_10272_36403_36434_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 36403, 36434);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10272_36439_36462()
                {
                    var return_v = NotNullWhenFalseMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 36439, 36462);
                    return return_v;
                }


                bool
                f_10272_36438_36470_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 36438, 36470);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>
                f_10272_36534_36578(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.MemberNotNullWhenAttributeIfExists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 36534, 36578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10272_36660_36703(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                original)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 36660, 36703);
                    return return_v;
                }


                int
                f_10272_36620_36704(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 36620, 36704);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>
                f_10272_36534_36578_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 36534, 36578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10272, 35537, 36750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 35537, 36750);
            }
        }

        static SourcePropertyAccessorSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10272, 529, 36757);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10272, 529, 36757);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10272, 529, 36757);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10272, 529, 36757);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10272_6361_6382(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 6361, 6382);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10272_6734_6773(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        propertyModifiers)
        {
            var return_v = GetAccessorModifiers(propertyModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 6734, 6773);
            return return_v;
        }


        bool
        f_10272_7134_7176(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
        this_param)
        {
            var return_v = this_param.IsExplicitInterfaceImplementation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 7134, 7176);
            return return_v;
        }


        int
        f_10272_6920_7177(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        this_param, Microsoft.CodeAnalysis.MethodKind
        methodKind, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        declarationModifiers, bool
        returnsVoid, bool
        isExtensionMethod, bool
        isNullableAnalysisEnabled, bool
        isMetadataVirtualIgnoringModifiers)
        {
            this_param.MakeFlags(methodKind, declarationModifiers, returnsVoid: returnsVoid, isExtensionMethod: isExtensionMethod, isNullableAnalysisEnabled: isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers: isMetadataVirtualIgnoringModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 6920, 7177);
            return 0;
        }


        int
        f_10272_7194_7294(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
        declarationSyntax, Microsoft.CodeAnalysis.Location
        location, bool
        hasBody, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.CheckFeatureAvailabilityAndRuntimeSupport((Microsoft.CodeAnalysis.SyntaxNode)declarationSyntax, location, hasBody: hasBody, diagnostics: diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 7194, 7294);
            return 0;
        }


        int
        f_10272_7309_7353(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        this_param, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.CheckModifiersForBody(location, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 7309, 7353);
            return 0;
        }


        bool
        f_10272_7447_7489(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
        this_param)
        {
            var return_v = this_param.IsExplicitInterfaceImplementation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 7447, 7489);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10272_7381_7490(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        modifiers, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        symbol, bool
        isExplicitInterfaceImplementation)
        {
            var return_v = ModifierUtils.CheckAccessibility(modifiers, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, isExplicitInterfaceImplementation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 7381, 7490);
            return return_v;
        }


        int
        f_10272_7555_7586(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        info, Microsoft.CodeAnalysis.Location
        location)
        {
            diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 7555, 7586);
            return 0;
        }


        int
        f_10272_7618_7728(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        this_param, Microsoft.CodeAnalysis.Location
        location, bool
        hasBody, bool
        isAutoPropertyOrExpressionBodied, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.CheckModifiers(location, hasBody: hasBody, isAutoPropertyOrExpressionBodied: isAutoPropertyOrExpressionBodied, diagnostics: diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 7618, 7728);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10272_6345_6359_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10272, 5979, 7740);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxReference
        f_10272_8407_8428(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 8407, 8428);
            return return_v;
        }


        bool
        f_10272_8627_8656_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 8627, 8656);
            return return_v;
        }


        int
        f_10272_8614_8726(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 8614, 8726);
            return 0;
        }


        bool
        f_10272_8889_8989(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        syntax, Microsoft.CodeAnalysis.CSharp.MessageID
        feature, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = Binder.CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 8889, 8989);
            return return_v;
        }


        bool
        f_10272_9112_9154(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param.IsExplicitInterfaceImplementation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 9112, 9154);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10272_9082_9228(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        this_param, Microsoft.CodeAnalysis.SyntaxTokenList
        modifiers, bool
        isExplicitInterfaceImplementation, bool
        hasBody, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, out bool
        modifierErrors)
        {
            var return_v = this_param.MakeModifiers(modifiers, isExplicitInterfaceImplementation, hasBody, location, diagnostics, out modifierErrors);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 9082, 9228);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10272_9375_9414(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        propertyModifiers)
        {
            var return_v = GetAccessorModifiers(propertyModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 9375, 9414);
            return return_v;
        }


        bool
        f_10272_10041_10083(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param.IsExplicitInterfaceImplementation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 10041, 10083);
            return return_v;
        }


        int
        f_10272_9839_10084(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        this_param, Microsoft.CodeAnalysis.MethodKind
        methodKind, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        declarationModifiers, bool
        returnsVoid, bool
        isExtensionMethod, bool
        isNullableAnalysisEnabled, bool
        isMetadataVirtualIgnoringModifiers)
        {
            this_param.MakeFlags(methodKind, declarationModifiers, returnsVoid: returnsVoid, isExtensionMethod: isExtensionMethod, isNullableAnalysisEnabled: isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers: isMetadataVirtualIgnoringModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 9839, 10084);
            return 0;
        }


        int
        f_10272_10101_10238(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        declarationSyntax, Microsoft.CodeAnalysis.Location
        location, bool
        hasBody, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.CheckFeatureAvailabilityAndRuntimeSupport((Microsoft.CodeAnalysis.SyntaxNode)declarationSyntax, location, hasBody: hasBody, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 10101, 10238);
            return 0;
        }


        int
        f_10272_10321_10365(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        this_param, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.CheckModifiersForBody(location, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 10321, 10365);
            return 0;
        }


        bool
        f_10272_10474_10516(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param.IsExplicitInterfaceImplementation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 10474, 10516);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10272_10408_10517(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        modifiers, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        symbol, bool
        isExplicitInterfaceImplementation)
        {
            var return_v = ModifierUtils.CheckAccessibility(modifiers, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, isExplicitInterfaceImplementation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 10408, 10517);
            return return_v;
        }


        int
        f_10272_10582_10613(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        info, Microsoft.CodeAnalysis.Location
        location)
        {
            diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 10582, 10613);
            return 0;
        }


        int
        f_10272_10698_10794(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        this_param, Microsoft.CodeAnalysis.Location
        location, bool
        hasBody, bool
        isAutoPropertyOrExpressionBodied, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.CheckModifiers(location, hasBody, isAutoPropertyOrExpressionBodied, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10272, 10698, 10794);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10272_8371_8385_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10272, 7770, 10821);
            return return_v;
        }


        bool
        f_10272_21585_21594_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10272, 21585, 21594);
            return return_v;
        }

    }
}
