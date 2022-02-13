// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class SourceLocalSymbol : LocalSymbol
    {
        private readonly Binder _scopeBinder;

        private readonly Symbol _containingSymbol;

        private readonly SyntaxToken _identifierToken;

        private readonly ImmutableArray<Location> _locations;

        private readonly RefKind _refKind;

        private readonly TypeSyntax _typeSyntax;

        private readonly LocalDeclarationKind _declarationKind;

        private TypeWithAnnotations.Boxed _type;

        protected uint _refEscapeScope;

        protected uint _valEscapeScope;

        private SourceLocalSymbol(
                    Symbol containingSymbol,
                    Binder scopeBinder,
                    bool allowRefKind,
                    TypeSyntax typeSyntax,
                    SyntaxToken identifierToken,
                    LocalDeclarationKind declarationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10255, 1699, 3258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 662, 674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 801, 818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 975, 983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 1022, 1033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 1082, 1098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 1143, 1148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 1399, 1414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 1671, 1686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 12500, 12529);
                this.concurrentTypeResolutions = 0; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 1982, 2038);

                f_10255_1982_2037(identifierToken.Kind() != SyntaxKind.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 2052, 2111);

                f_10255_2052_2110(declarationKind != LocalDeclarationKind.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 2125, 2159);

                f_10255_2125_2158(scopeBinder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 2175, 2207);

                this._scopeBinder = scopeBinder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 2221, 2263);

                this._containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 2277, 2317);

                this._identifierToken = identifierToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 2456, 2571);

                this._typeSyntax = (DynAbs.Tracing.TraceSender.Conditional_F1(10255, 2475, 2487) || ((allowRefKind && DynAbs.Tracing.TraceSender.Conditional_F2(10255, 2490, 2557)) || DynAbs.Tracing.TraceSender.Conditional_F3(10255, 2560, 2570))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(10255, 2491, 2509) || ((typeSyntax != null && DynAbs.Tracing.TraceSender.Conditional_F2(10255, 2512, 2549)) || DynAbs.Tracing.TraceSender.Conditional_F3(10255, 2552, 2556))) ? f_10255_2512_2549(typeSyntax, out this._refKind) : null) : typeSyntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 2585, 2625);

                this._declarationKind = declarationKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 2736, 2812);

                _locations = f_10255_2749_2811(identifierToken.GetLocation());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 2828, 3011);

                _refEscapeScope = (DynAbs.Tracing.TraceSender.Conditional_F1(10255, 2846, 2875) || ((this._refKind == RefKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(10255, 2919, 2946)) || DynAbs.Tracing.TraceSender.Conditional_F3(10255, 2990, 3010))) ? f_10255_2919_2946(scopeBinder) : Binder.ExternalScope;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 3208, 3247);

                _valEscapeScope = Binder.ExternalScope;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10255, 1699, 3258);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 1699, 3258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 1699, 3258);
            }
        }

        internal Binder ScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 3490, 3518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 3496, 3516);

                    return _scopeBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 3490, 3518);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 3438, 3529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 3438, 3529);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SyntaxNode ScopeDesignatorOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 3613, 3657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 3619, 3655);

                    return f_10255_3626_3654(_scopeBinder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 3613, 3657);

                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_10255_3626_3654(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ScopeDesignator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 3626, 3654);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 3541, 3668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 3541, 3668);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override uint RefEscapeScope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 3718, 3736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 3721, 3736);
                    return _refEscapeScope; DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 3718, 3736);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 3718, 3736);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 3718, 3736);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override uint ValEscapeScope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 3787, 3805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 3790, 3805);
                    return _valEscapeScope; DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 3787, 3805);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 3787, 3805);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 3787, 3805);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Binder TypeSyntaxBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 3997, 4025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 4003, 4023);

                    return _scopeBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 3997, 4025);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 3940, 4084);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 3940, 4084);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 4212, 4412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 4282, 4401);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10255, 4289, 4302) || ((_type != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10255, 4322, 4347)) || DynAbs.Tracing.TraceSender.Conditional_F3(10255, 4367, 4400))) ? DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetDebuggerDisplay(), 10255, 4322, 4347) : $"{f_10255_4370_4379(this)} <var> ${f_10255_4389_4398(this)}";
                DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 4212, 4412);

                Microsoft.CodeAnalysis.SymbolKind
                f_10255_4370_4379(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 4370, 4379);
                    return return_v;
                }


                string
                f_10255_4389_4398(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 4389, 4398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 4212, 4412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 4212, 4412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SourceLocalSymbol MakeForeachLocal(
                    MethodSymbol containingMethod,
                    ForEachLoopBinder binder,
                    TypeSyntax typeSyntax,
                    SyntaxToken identifierToken,
                    ExpressionSyntax collection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10255, 4424, 4856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 4701, 4845);

                return f_10255_4708_4844(containingMethod, binder, typeSyntax, identifierToken, collection, LocalDeclarationKind.ForEachIterationVariable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10255, 4424, 4856);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.ForEachLocalSymbol
                f_10255_4708_4844(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                scopeBinder, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                collection, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                declarationKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.ForEachLocalSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)containingSymbol, scopeBinder, typeSyntax, identifierToken, collection, declarationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 4708, 4844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 4424, 4856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 4424, 4856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SourceLocalSymbol MakeDeconstructionLocal(
                    Symbol containingSymbol,
                    Binder scopeBinder,
                    Binder nodeBinder,
                    TypeSyntax closestTypeSyntax,
                    SyntaxToken identifierToken,
                    LocalDeclarationKind kind,
                    SyntaxNode deconstruction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10255, 5750, 6590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 6099, 6139);

                f_10255_6099_6138(closestTypeSyntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 6153, 6186);

                f_10255_6153_6185(nodeBinder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 6202, 6263);

                f_10255_6202_6262(f_10255_6215_6239(closestTypeSyntax) != SyntaxKind.RefType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 6277, 6579);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10255, 6284, 6307) || ((f_10255_6284_6307(closestTypeSyntax) && DynAbs.Tracing.TraceSender.Conditional_F2(10255, 6327, 6457)) || DynAbs.Tracing.TraceSender.Conditional_F3(10255, 6477, 6578))) ? f_10255_6327_6457(containingSymbol, scopeBinder, nodeBinder, closestTypeSyntax, identifierToken, kind, deconstruction) : f_10255_6477_6578(containingSymbol, scopeBinder, false, closestTypeSyntax, identifierToken, kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10255, 5750, 6590);

                int
                f_10255_6099_6138(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 6099, 6138);
                    return 0;
                }


                int
                f_10255_6153_6185(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 6153, 6185);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10255_6215_6239(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 6215, 6239);
                    return return_v;
                }


                int
                f_10255_6202_6262(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 6202, 6262);
                    return 0;
                }


                bool
                f_10255_6284_6307(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.IsVar
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 6284, 6307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.DeconstructionLocalSymbol
                f_10255_6327_6457(Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                scopeBinder, Microsoft.CodeAnalysis.CSharp.Binder
                nodeBinder, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                declarationKind, Microsoft.CodeAnalysis.SyntaxNode
                deconstruction)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.DeconstructionLocalSymbol(containingSymbol, scopeBinder, nodeBinder, typeSyntax, identifierToken, declarationKind, deconstruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 6327, 6457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10255_6477_6578(Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                scopeBinder, bool
                allowRefKind, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                declarationKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol(containingSymbol, scopeBinder, allowRefKind, typeSyntax, identifierToken, declarationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 6477, 6578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 5750, 6590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 5750, 6590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static LocalSymbol MakeLocalSymbolWithEnclosingContext(
                    Symbol containingSymbol,
                    Binder scopeBinder,
                    Binder nodeBinder,
                    TypeSyntax typeSyntax,
                    SyntaxToken identifierToken,
                    LocalDeclarationKind kind,
                    SyntaxNode nodeToBind,
                    SyntaxNode forbiddenZone)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10255, 6769, 8752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 7154, 8231);

                f_10255_7154_8230(f_10255_7185_7202(nodeToBind) == SyntaxKind.CasePatternSwitchLabel || (DynAbs.Tracing.TraceSender.Expression_False(10255, 7185, 7318) || f_10255_7260_7277(nodeToBind) == SyntaxKind.ThisConstructorInitializer) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 7185, 7397) || f_10255_7339_7356(nodeToBind) == SyntaxKind.BaseConstructorInitializer) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 7185, 7476) || f_10255_7418_7435(nodeToBind) == SyntaxKind.PrimaryConstructorBaseType) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 7185, 7588) || f_10255_7537_7554(nodeToBind) == SyntaxKind.SwitchExpressionArm) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 7185, 7765) || f_10255_7609_7626(nodeToBind) == SyntaxKind.ArgumentList && (DynAbs.Tracing.TraceSender.Expression_True(10255, 7609, 7765) && (f_10255_7658_7675(nodeToBind) is ConstructorInitializerSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10255, 7658, 7764) || f_10255_7711_7728(nodeToBind) is PrimaryConstructorBaseTypeSyntax)))) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 7185, 7835) || f_10255_7786_7803(nodeToBind) == SyntaxKind.GotoCaseStatement) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 7185, 8178) || f_10255_7878_7895(nodeToBind) == SyntaxKind.VariableDeclarator && (DynAbs.Tracing.TraceSender.Expression_True(10255, 7878, 8178) && f_10255_7953_8178(new[] { SyntaxKind.LocalDeclarationStatement, SyntaxKind.ForStatement, SyntaxKind.UsingStatement, SyntaxKind.FixedStatement }, f_10255_8114_8177(f_10255_8114_8170(f_10255_8114_8162(f_10255_8114_8136(nodeToBind))))))) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 7185, 8229) || nodeToBind is ExpressionSyntax));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 8245, 8357);

                f_10255_8245_8356(!(f_10255_8260_8277(nodeToBind) == SyntaxKind.SwitchExpressionArm) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 8258, 8355) || nodeBinder is SwitchExpressionArmBinder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 8371, 8741);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10255, 8378, 8466) || ((f_10255_8378_8395_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(typeSyntax, 10255, 8378, 8395)?.IsVar) != false && (DynAbs.Tracing.TraceSender.Expression_True(10255, 8378, 8466) && kind != LocalDeclarationKind.DeclarationExpressionVariable
                ) && DynAbs.Tracing.TraceSender.Conditional_F2(10255, 8486, 8626)) || DynAbs.Tracing.TraceSender.Conditional_F3(10255, 8646, 8740))) ? f_10255_8486_8626(containingSymbol, scopeBinder, nodeBinder, typeSyntax, identifierToken, kind, nodeToBind, forbiddenZone) : f_10255_8646_8740(containingSymbol, scopeBinder, false, typeSyntax, identifierToken, kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10255, 6769, 8752);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10255_7185_7202(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 7185, 7202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10255_7260_7277(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 7260, 7277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10255_7339_7356(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 7339, 7356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10255_7418_7435(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 7418, 7435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10255_7537_7554(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 7537, 7554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10255_7609_7626(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 7609, 7626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10255_7658_7675(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 7658, 7675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10255_7711_7728(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 7711, 7728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10255_7786_7803(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 7786, 7803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10255_7878_7895(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 7878, 7895);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_10255_8114_8136(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Ancestors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 8114, 8136);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10255_8114_8162(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 8114, 8162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10255_8114_8170(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                source)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 8114, 8170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10255_8114_8177(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 8114, 8177);
                    return return_v;
                }


                bool
                f_10255_7953_8178(Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
                list, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                item)
                {
                    var return_v = list.Contains<Microsoft.CodeAnalysis.CSharp.SyntaxKind>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 7953, 8178);
                    return return_v;
                }


                int
                f_10255_7154_8230(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 7154, 8230);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10255_8260_8277(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 8260, 8277);
                    return return_v;
                }


                int
                f_10255_8245_8356(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 8245, 8356);
                    return 0;
                }


                bool?
                f_10255_8378_8395_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 8378, 8395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalSymbolWithEnclosingContext
                f_10255_8486_8626(Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                scopeBinder, Microsoft.CodeAnalysis.CSharp.Binder
                nodeBinder, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                typeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                declarationKind, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind, Microsoft.CodeAnalysis.SyntaxNode
                forbiddenZone)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalSymbolWithEnclosingContext(containingSymbol, scopeBinder, nodeBinder, typeSyntax, identifierToken, declarationKind, nodeToBind, forbiddenZone);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 8486, 8626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10255_8646_8740(Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                scopeBinder, bool
                allowRefKind, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                typeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                declarationKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol(containingSymbol, scopeBinder, allowRefKind, typeSyntax, identifierToken, declarationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 8646, 8740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 6769, 8752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 6769, 8752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SourceLocalSymbol MakeLocal(
                    Symbol containingSymbol,
                    Binder scopeBinder,
                    bool allowRefKind,
                    TypeSyntax typeSyntax,
                    SyntaxToken identifierToken,
                    LocalDeclarationKind declarationKind,
                    EqualsValueClauseSyntax initializer = null,
                    Binder initializerBinderOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10255, 9633, 10474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 10038, 10117);

                f_10255_10038_10116(declarationKind != LocalDeclarationKind.ForEachIterationVariable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 10131, 10463);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10255, 10138, 10159) || (((initializer != null)
                && DynAbs.Tracing.TraceSender.Conditional_F2(10255, 10179, 10330)) || DynAbs.Tracing.TraceSender.Conditional_F3(10255, 10350, 10462))) ? f_10255_10179_10330(containingSymbol, scopeBinder, typeSyntax, identifierToken, initializer, initializerBinderOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Binder?>(10255, 10277, 10312) ?? scopeBinder), declarationKind) : f_10255_10350_10462(containingSymbol, scopeBinder, allowRefKind, typeSyntax, identifierToken, declarationKind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10255, 9633, 10474);

                int
                f_10255_10038_10116(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 10038, 10116);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalWithInitializer
                f_10255_10179_10330(Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                scopeBinder, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                initializer, Microsoft.CodeAnalysis.CSharp.Binder
                initializerBinder, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                declarationKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalWithInitializer(containingSymbol, scopeBinder, typeSyntax, identifierToken, initializer, initializerBinder, declarationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 10179, 10330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10255_10350_10462(Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                scopeBinder, bool
                allowRefKind, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                declarationKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol(containingSymbol, scopeBinder, allowRefKind, typeSyntax, identifierToken, declarationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 10350, 10462);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 9633, 10474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 9633, 10474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsImportedFromMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 10556, 10577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 10562, 10575);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 10556, 10577);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 10486, 10588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 10486, 10588);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LocalDeclarationKind DeclarationKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 10679, 10711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 10685, 10709);

                    return _declarationKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 10679, 10711);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 10600, 10722);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 10600, 10722);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SynthesizedLocalKind SynthesizedKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 10813, 10861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 10819, 10859);

                    return SynthesizedLocalKind.UserDefined;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 10813, 10861);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 10734, 10872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 10734, 10872);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LocalSymbol WithSynthesizedLocalKindAndSyntax(SynthesizedLocalKind kind, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 10884, 11066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 11018, 11055);

                throw f_10255_11024_11054();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 10884, 11066);

                System.Exception
                f_10255_11024_11054()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 11024, 11054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 10884, 11066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 10884, 11066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsPinned
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 11134, 11375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 11347, 11360);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 11134, 11375);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 11078, 11386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 11078, 11386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual void SetRefEscape(uint value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 11398, 11504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 11469, 11493);

                _refEscapeScope = value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 11398, 11504);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 11398, 11504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 11398, 11504);
            }
        }

        internal virtual void SetValEscape(uint value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 11516, 11622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 11587, 11611);

                _valEscapeScope = value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 11516, 11622);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 11516, 11622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 11516, 11622);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 11698, 11731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 11704, 11729);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 11698, 11731);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 11634, 11742);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 11634, 11742);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 11903, 11988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 11939, 11973);

                    return _identifierToken.ValueText;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 11903, 11988);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 11851, 11999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 11851, 11999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SyntaxToken IdentifierToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 12307, 12382);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 12343, 12367);

                    return _identifierToken;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 12307, 12382);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 12237, 12393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 12237, 12393);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int concurrentTypeResolutions;

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 12630, 13038);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 12666, 12984) || true) && (_type == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 12666, 12984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 12736, 12764);

                        concurrentTypeResolutions++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 12786, 12831);

                        f_10255_12786_12830(concurrentTypeResolutions < 50);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 12861, 12909);

                        TypeWithAnnotations
                        localType = f_10255_12893_12908(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 12931, 12965);

                        f_10255_12931_12964(this, localType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 12666, 12984);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13004, 13023);

                    return _type.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 12630, 13038);

                    int
                    f_10255_12786_12830(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 12786, 12830);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10255_12893_12908(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 12893, 12908);
                        return return_v;
                    }


                    int
                    f_10255_12931_12964(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    newType)
                    {
                        this_param.SetTypeWithAnnotations(newType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 12931, 12964);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 12550, 13049);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 12550, 13049);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsVar
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 13103, 13657);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13139, 13320) || true) && (_typeSyntax == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 13139, 13320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13289, 13301);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 13139, 13320);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13340, 13609) || true) && (f_10255_13344_13361(_typeSyntax))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 13340, 13609);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13403, 13414);

                        bool
                        isVar
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13436, 13555);

                        TypeWithAnnotations
                        declType = f_10255_13467_13554(f_10255_13467_13488(this), _typeSyntax, f_10255_13523_13542(), out isVar)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13577, 13590);

                        return isVar;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 13340, 13609);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13629, 13642);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 13103, 13657);

                    bool
                    f_10255_13344_13361(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    this_param)
                    {
                        var return_v = this_param.IsVar;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 13344, 13361);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10255_13467_13488(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeSyntaxBinder;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 13467, 13488);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10255_13523_13542()
                    {
                        var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 13523, 13542);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10255_13467_13554(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    syntax, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, out bool
                    isVar)
                    {
                        var return_v = this_param.BindTypeOrVarKeyword(syntax, diagnostics, out isVar);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 13467, 13554);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 13061, 13668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 13061, 13668);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private TypeWithAnnotations GetTypeSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 13680, 15633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13748, 13794);

                var
                diagnostics = f_10255_13766_13793()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13810, 13852);

                Binder
                typeBinder = f_10255_13830_13851(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13868, 13879);

                bool
                isVar
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13893, 13922);

                TypeWithAnnotations
                declType
                = default(TypeWithAnnotations);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 13936, 14269) || true) && (_typeSyntax == null)
                ) // In recursive patterns the type may be omitted.

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 13936, 14269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 14043, 14056);

                    isVar = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 14074, 14093);

                    declType = default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 13936, 14269);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 13936, 14269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 14159, 14254);

                    declType = f_10255_14170_14253(typeBinder, f_10255_14202_14228(_typeSyntax, out _), diagnostics, out isVar);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 13936, 14269);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 14285, 14870) || true) && (isVar)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 14285, 14870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 14328, 14383);

                    var
                    inferredType = f_10255_14347_14382(this, diagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 14540, 14855) || true) && (inferredType.HasType && (DynAbs.Tracing.TraceSender.Expression_True(10255, 14544, 14615) && !inferredType.IsVoidType()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 14540, 14855);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 14657, 14681);

                        declType = inferredType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 14540, 14855);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 14540, 14855);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 14763, 14836);

                        declType = TypeWithAnnotations.Create(f_10255_14801_14834(typeBinder, "var"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 14540, 14855);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 14285, 14870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 14886, 14917);

                f_10255_14886_14916(declType.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 15573, 15592);

                f_10255_15573_15591(
                            //
                            // Note that we drop the diagnostics on the floor! That is because this code is invoked mainly in
                            // IDE scenarios where we are attempting to use the types of a variable before we have processed
                            // the code which causes the variable's type to be inferred. In batch compilation, on the
                            // other hand, local variables have their type inferred, if necessary, in the course of binding
                            // the statements of a method from top to bottom, and an inferred type is given to a variable
                            // before the variable's type is used by the compiler.
                            //
                            diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 15606, 15622);

                return declType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 13680, 15633);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10255_13766_13793()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 13766, 13793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10255_13830_13851(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.TypeSyntaxBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 13830, 13851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10255_14202_14228(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, out Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = syntax.SkipRef(out refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 14202, 14228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10255_14170_14253(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                isVar)
                {
                    var return_v = this_param.BindTypeOrVarKeyword(syntax, diagnostics, out isVar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 14170, 14253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10255_14347_14382(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.InferTypeOfVarVariable(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 14347, 14382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10255_14801_14834(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, string
                name)
                {
                    var return_v = this_param.CreateErrorType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 14801, 14834);
                    return return_v;
                }


                int
                f_10255_14886_14916(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 14886, 14916);
                    return 0;
                }


                int
                f_10255_15573_15591(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 15573, 15591);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 13680, 15633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 13680, 15633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual TypeWithAnnotations InferTypeOfVarVariable(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 15645, 16088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 16046, 16077);

                return DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_type, 10255, 16053, 16065)?.Value ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations?>(10255, 16053, 16076) ?? default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 15645, 16088);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 15645, 16088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 15645, 16088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetTypeWithAnnotations(TypeWithAnnotations newType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 16100, 16908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 16190, 16227);

                f_10255_16190_16226(newType.Type is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 16241, 16290);

                TypeWithAnnotations?
                originalType = DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_type, 10255, 16277, 16289)?.Value
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 16470, 16722);

                f_10255_16470_16721((object)DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(originalType, 10255, 16491, 16516)?.DefaultType == null || (DynAbs.Tracing.TraceSender.Expression_False(10255, 16483, 16619) || f_10255_16545_16589(originalType.Value.DefaultType) && (DynAbs.Tracing.TraceSender.Expression_True(10255, 16545, 16619) && f_10255_16593_16619(newType.Type))) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 16483, 16720) || originalType.Value.TypeSymbolEquals(newType, TypeCompareKind.ConsiderEverything)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 16738, 16897) || true) && ((object)_type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 16738, 16897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 16797, 16882);

                    f_10255_16797_16881(ref _type, f_10255_16836_16874(newType), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 16738, 16897);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 16100, 16908);

                int
                f_10255_16190_16226(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 16190, 16226);
                    return 0;
                }


                bool
                f_10255_16545_16589(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 16545, 16589);
                    return return_v;
                }


                bool
                f_10255_16593_16619(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 16593, 16619);
                    return return_v;
                }


                int
                f_10255_16470_16721(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 16470, 16721);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                f_10255_16836_16874(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 16836, 16874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                f_10255_16797_16881(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 16797, 16881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 16100, 16908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 16100, 16908);
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 17352, 17421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 17388, 17406);

                    return _locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 17352, 17421);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 17277, 17432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 17277, 17432);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override SyntaxNode GetDeclaratorSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 17444, 17568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 17526, 17557);

                return _identifierToken.Parent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 17444, 17568);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 17444, 17568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 17444, 17568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 17678, 19288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 17714, 17756);

                    SyntaxNode
                    node = _identifierToken.Parent
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 17785, 19197);

                    switch (_declarationKind)
                    {

                        case LocalDeclarationKind.RegularVariable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 17785, 19197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 17919, 17966);

                            f_10255_17919_17965(node is VariableDeclaratorSyntax);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 17992, 17998);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 17785, 19197);

                        case LocalDeclarationKind.Constant:
                        case LocalDeclarationKind.FixedVariable:
                        case LocalDeclarationKind.UsingVariable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 17785, 19197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 18207, 18254);

                            f_10255_18207_18253(node is VariableDeclaratorSyntax);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 18280, 18286);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 17785, 19197);

                        case LocalDeclarationKind.ForEachIterationVariable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 17785, 19197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 18387, 18475);

                            f_10255_18387_18474(node is ForEachStatementSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10255, 18400, 18473) || node is SingleVariableDesignationSyntax));
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 18501, 18507);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 17785, 19197);

                        case LocalDeclarationKind.CatchVariable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 17785, 19197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 18597, 18642);

                            f_10255_18597_18641(node is CatchDeclarationSyntax);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 18668, 18674);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 17785, 19197);

                        case LocalDeclarationKind.OutVariable:
                        case LocalDeclarationKind.DeclarationExpressionVariable:
                        case LocalDeclarationKind.DeconstructionVariable:
                        case LocalDeclarationKind.PatternVariable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 17785, 19197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 18975, 19029);

                            f_10255_18975_19028(node is SingleVariableDesignationSyntax);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 19055, 19061);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 17785, 19197);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 17785, 19197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 19119, 19178);

                            throw f_10255_19125_19177(_declarationKind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 17785, 19197);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 19223, 19273);

                    return f_10255_19230_19272(f_10255_19252_19271(node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 17678, 19288);

                    int
                    f_10255_17919_17965(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 17919, 17965);
                        return 0;
                    }


                    int
                    f_10255_18207_18253(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 18207, 18253);
                        return 0;
                    }


                    int
                    f_10255_18387_18474(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 18387, 18474);
                        return 0;
                    }


                    int
                    f_10255_18597_18641(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 18597, 18641);
                        return 0;
                    }


                    int
                    f_10255_18975_19028(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 18975, 19028);
                        return 0;
                    }


                    System.Exception
                    f_10255_19125_19177(Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 19125, 19177);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxReference
                    f_10255_19252_19271(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetReference();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 19252, 19271);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10255_19230_19272(Microsoft.CodeAnalysis.SyntaxReference
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 19230, 19272);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 17580, 19299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 17580, 19299);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCompilerGenerated
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 19378, 19399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 19384, 19397);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 19378, 19399);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 19311, 19410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 19311, 19410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue GetConstantValue(SyntaxNode node, LocalSymbol inProgress, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 19422, 19586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 19563, 19575);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 19422, 19586);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 19422, 19586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 19422, 19586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Diagnostic> GetConstantValueDiagnostics(BoundExpression boundInitValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 19598, 19778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 19727, 19767);

                return ImmutableArray<Diagnostic>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 19598, 19778);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 19598, 19778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 19598, 19778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 19846, 19870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 19852, 19868);

                    return _refKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 19846, 19870);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 19790, 19881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 19790, 19881);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 19893, 20640);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 19993, 20077) || true) && (obj == (object)this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 19993, 20077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 20050, 20062);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 19993, 20077);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 20263, 20421) || true) && (obj is UpdatedContainingSymbolAndNullableAnnotationLocal updated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 20263, 20421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 20365, 20406);

                    return f_10255_20372_20405(updated, this, compareKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 20263, 20421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 20437, 20629);

                return obj is SourceLocalSymbol symbol
                && (DynAbs.Tracing.TraceSender.Expression_True(10255, 20444, 20544) && symbol._identifierToken.Equals(_identifierToken)) && (DynAbs.Tracing.TraceSender.Expression_True(10255, 20444, 20628) && f_10255_20565_20628(symbol._containingSymbol, _containingSymbol, compareKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 19893, 20640);

                bool
                f_10255_20372_20405(Microsoft.CodeAnalysis.CSharp.Symbols.UpdatedContainingSymbolAndNullableAnnotationLocal
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 20372, 20405);
                    return return_v;
                }


                bool
                f_10255_20565_20628(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 20565, 20628);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 19893, 20640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 19893, 20640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 20652, 20813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 20717, 20802);

                return f_10255_20724_20801(_identifierToken.GetHashCode(), f_10255_20769_20800(_containingSymbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 20652, 20813);

                int
                f_10255_20769_20800(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 20769, 20800);
                    return return_v;
                }


                int
                f_10255_20724_20801(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 20724, 20801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 20652, 20813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 20652, 20813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class LocalWithInitializer : SourceLocalSymbol
        {
            private readonly EqualsValueClauseSyntax _initializer;

            private readonly Binder _initializerBinder;

            private EvaluatedConstant _constantTuple;

            public LocalWithInitializer(
                            Symbol containingSymbol,
                            Binder scopeBinder,
                            TypeSyntax typeSyntax,
                            SyntaxToken identifierToken,
                            EqualsValueClauseSyntax initializer,
                            Binder initializerBinder,
                            LocalDeclarationKind declarationKind) : base(f_10255_21853_21869_C(containingSymbol), scopeBinder, true, typeSyntax, identifierToken, declarationKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10255, 21479, 22455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 21086, 21098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 21137, 21155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 21448, 21462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 21968, 22047);

                    f_10255_21968_22046(declarationKind != LocalDeclarationKind.ForEachIterationVariable);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 22065, 22099);

                    f_10255_22065_22098(initializer != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 22119, 22146);

                    _initializer = initializer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 22164, 22203);

                    _initializerBinder = initializerBinder;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 22328, 22375);

                    _refEscapeScope = f_10255_22346_22374(_scopeBinder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 22393, 22440);

                    _valEscapeScope = f_10255_22411_22439(_scopeBinder);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10255, 21479, 22455);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 21479, 22455);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 21479, 22455);
                }
            }

            protected override TypeWithAnnotations InferTypeOfVarVariable(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 22471, 22820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 22592, 22731);

                    BoundExpression
                    initializerOpt = f_10255_22625_22730(this._initializerBinder, diagnostics, f_10255_22694_22701(), _initializer, _initializer)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 22749, 22805);

                    return TypeWithAnnotations.Create(f_10255_22783_22803_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(initializerOpt, 10255, 22783, 22803)?.Type));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 22471, 22820);

                    Microsoft.CodeAnalysis.RefKind
                    f_10255_22694_22701()
                    {
                        var return_v = RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 22694, 22701);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10255_22625_22730(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.RefKind
                    refKind, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                    initializer, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                    errorSyntax)
                    {
                        var return_v = this_param.BindInferredVariableInitializer(diagnostics, refKind, initializer, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)errorSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 22625, 22730);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10255_22783_22803_M(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 22783, 22803);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 22471, 22820);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 22471, 22820);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override SyntaxNode ForbiddenZone
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 22879, 22894);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 22882, 22894);
                        return _initializer; DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 22879, 22894);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 22879, 22894);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 22879, 22894);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private void MakeConstantTuple(LocalSymbol inProgress, BoundExpression boundInitValue)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 23429, 24597);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 23548, 24582) || true) && (f_10255_23552_23564(this) && (DynAbs.Tracing.TraceSender.Expression_True(10255, 23552, 23590) && _constantTuple == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 23548, 24582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 23632, 23685);

                        var
                        value = f_10255_23644_23684()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 23707, 23768);

                        Location
                        initValueNodeLocation = f_10255_23740_23767(f_10255_23740_23758(_initializer))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 23790, 23836);

                        var
                        diagnostics = f_10255_23808_23835()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 23858, 23891);

                        f_10255_23858_23890(inProgress != this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 23913, 23934);

                        var
                        type = f_10255_23924_23933(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 23956, 24281) || true) && (boundInitValue == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 23956, 24281);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 24032, 24112);

                            var
                            inProgressBinder = f_10255_24055_24111(this, this._initializerBinder)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 24138, 24258);

                            boundInitValue = f_10255_24155_24257(inProgressBinder, _initializer, f_10255_24225_24237(this), type, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 23956, 24281);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 24305, 24424);

                        value = f_10255_24313_24423(boundInitValue, this, type, initValueNodeLocation, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 24446, 24563);

                        f_10255_24446_24562(ref _constantTuple, f_10255_24494_24555(value, f_10255_24523_24554(diagnostics)), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 23548, 24582);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 23429, 24597);

                    bool
                    f_10255_23552_23564(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalWithInitializer
                    this_param)
                    {
                        var return_v = this_param.IsConst;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 23552, 23564);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10255_23644_23684()
                    {
                        var return_v = Microsoft.CodeAnalysis.ConstantValue.Bad;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 23644, 23684);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    f_10255_23740_23758(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 23740, 23758);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10255_23740_23767(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 23740, 23767);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10255_23808_23835()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 23808, 23835);
                        return return_v;
                    }


                    int
                    f_10255_23858_23890(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 23858, 23890);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10255_23924_23933(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalWithInitializer
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 23924, 23933);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalInProgressBinder
                    f_10255_24055_24111(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalWithInitializer
                    inProgress, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalInProgressBinder((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)inProgress, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 24055, 24111);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10255_24225_24237(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalWithInitializer
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 24225, 24237);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10255_24155_24257(Microsoft.CodeAnalysis.CSharp.LocalInProgressBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                    initializerOpt, Microsoft.CodeAnalysis.RefKind
                    refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    varType, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.BindVariableOrAutoPropInitializerValue(initializerOpt, refKind, varType, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 24155, 24257);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10255_24313_24423(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    boundValue, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalWithInitializer
                    thisSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    typeSymbol, Microsoft.CodeAnalysis.Location
                    initValueNodeLocation, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = ConstantValueUtils.GetAndValidateConstantValue(boundValue, (Microsoft.CodeAnalysis.CSharp.Symbol)thisSymbol, typeSymbol, initValueNodeLocation, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 24313, 24423);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_10255_24523_24554(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        var return_v = this_param.ToReadOnlyAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 24523, 24554);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EvaluatedConstant
                    f_10255_24494_24555(Microsoft.CodeAnalysis.ConstantValue
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    diagnostics)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.EvaluatedConstant(value, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 24494, 24555);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EvaluatedConstant?
                    f_10255_24446_24562(ref Microsoft.CodeAnalysis.CSharp.Symbols.EvaluatedConstant?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.EvaluatedConstant
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.EvaluatedConstant?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 24446, 24562);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 23429, 24597);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 23429, 24597);
                }
            }

            internal override ConstantValue GetConstantValue(SyntaxNode node, LocalSymbol inProgress, DiagnosticBag diagnostics = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 24613, 25273);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 24769, 25108) || true) && (f_10255_24773_24785(this) && (DynAbs.Tracing.TraceSender.Expression_True(10255, 24773, 24807) && inProgress == this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 24769, 25108);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 24849, 25017) || true) && (diagnostics != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 24849, 25017);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 24922, 24994);

                            f_10255_24922_24993(diagnostics, ErrorCode.ERR_CircConstValue, f_10255_24968_24986(node), this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 24849, 25017);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 25041, 25089);

                        return f_10255_25048_25088();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 24769, 25108);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 25128, 25180);

                    f_10255_25128_25179(this, inProgress, boundInitValue: null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 25198, 25258);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10255, 25205, 25227) || ((_constantTuple == null && DynAbs.Tracing.TraceSender.Conditional_F2(10255, 25230, 25234)) || DynAbs.Tracing.TraceSender.Conditional_F3(10255, 25237, 25257))) ? null : _constantTuple.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 24613, 25273);

                    bool
                    f_10255_24773_24785(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalWithInitializer
                    this_param)
                    {
                        var return_v = this_param.IsConst;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 24773, 24785);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10255_24968_24986(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 24968, 24986);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10255_24922_24993(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = diagnostics.Add(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 24922, 24993);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10255_25048_25088()
                    {
                        var return_v = Microsoft.CodeAnalysis.ConstantValue.Bad;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 25048, 25088);
                        return return_v;
                    }


                    int
                    f_10255_25128_25179(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalWithInitializer
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    inProgress, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    boundInitValue)
                    {
                        this_param.MakeConstantTuple(inProgress, boundInitValue: boundInitValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 25128, 25179);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 24613, 25273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 24613, 25273);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<Diagnostic> GetConstantValueDiagnostics(BoundExpression boundInitValue)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 25289, 25676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 25426, 25463);

                    f_10255_25426_25462(boundInitValue != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 25481, 25549);

                    f_10255_25481_25548(this, inProgress: null, boundInitValue: boundInitValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 25567, 25661);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10255, 25574, 25596) || ((_constantTuple == null && DynAbs.Tracing.TraceSender.Conditional_F2(10255, 25599, 25631)) || DynAbs.Tracing.TraceSender.Conditional_F3(10255, 25634, 25660))) ? ImmutableArray<Diagnostic>.Empty : _constantTuple.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 25289, 25676);

                    int
                    f_10255_25426_25462(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 25426, 25462);
                        return 0;
                    }


                    int
                    f_10255_25481_25548(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalWithInitializer
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    inProgress, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    boundInitValue)
                    {
                        this_param.MakeConstantTuple(inProgress: inProgress, boundInitValue: boundInitValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 25481, 25548);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 25289, 25676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 25289, 25676);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override void SetRefEscape(uint value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 25692, 25868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 25772, 25811);

                    f_10255_25772_25810(value <= _refEscapeScope);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 25829, 25853);

                    _refEscapeScope = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 25692, 25868);

                    int
                    f_10255_25772_25810(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 25772, 25810);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 25692, 25868);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 25692, 25868);
                }
            }

            internal override void SetValEscape(uint value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 25884, 26060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 25964, 26003);

                    f_10255_25964_26002(value <= _valEscapeScope);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 26021, 26045);

                    _valEscapeScope = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 25884, 26060);

                    int
                    f_10255_25964_26002(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 25964, 26002);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 25884, 26060);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 25884, 26060);
                }
            }

            static LocalWithInitializer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10255, 20959, 26071);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10255, 20959, 26071);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 20959, 26071);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10255, 20959, 26071);

            int
            f_10255_21968_22046(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 21968, 22046);
                return 0;
            }


            int
            f_10255_22065_22098(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 22065, 22098);
                return 0;
            }


            uint
            f_10255_22346_22374(Microsoft.CodeAnalysis.CSharp.Binder
            this_param)
            {
                var return_v = this_param.LocalScopeDepth;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 22346, 22374);
                return return_v;
            }


            uint
            f_10255_22411_22439(Microsoft.CodeAnalysis.CSharp.Binder
            this_param)
            {
                var return_v = this_param.LocalScopeDepth;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 22411, 22439);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbol
            f_10255_21853_21869_C(Microsoft.CodeAnalysis.CSharp.Symbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10255, 21479, 22455);
                return return_v;
            }

        }
        private sealed class ForEachLocalSymbol : SourceLocalSymbol
        {
            private readonly ExpressionSyntax _collection;

            public ForEachLocalSymbol(
                            Symbol containingSymbol,
                            ForEachLoopBinder scopeBinder,
                            TypeSyntax typeSyntax,
                            SyntaxToken identifierToken,
                            ExpressionSyntax collection,
                            LocalDeclarationKind declarationKind) : base(f_10255_26750_26766_C(containingSymbol), scopeBinder, allowRefKind: true, typeSyntax, identifierToken, declarationKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10255, 26418, 27016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 26390, 26401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 26879, 26958);

                    f_10255_26879_26957(declarationKind == LocalDeclarationKind.ForEachIterationVariable);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 26976, 27001);

                    _collection = collection;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10255, 26418, 27016);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 26418, 27016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 26418, 27016);
                }
            }

            private ForEachLoopBinder ForEachLoopBinder
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 27272, 27305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 27275, 27305);
                        return (ForEachLoopBinder)f_10255_27294_27305(); DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 27272, 27305);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 27272, 27305);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 27272, 27305);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected override TypeWithAnnotations InferTypeOfVarVariable(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 27322, 27536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 27443, 27521);

                    return f_10255_27450_27520(f_10255_27450_27467(), diagnostics, _collection);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 27322, 27536);

                    Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                    f_10255_27450_27467()
                    {
                        var return_v = ForEachLoopBinder;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 27450, 27467);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10255_27450_27520(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    collectionSyntax)
                    {
                        var return_v = this_param.InferCollectionElementType(diagnostics, collectionSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 27450, 27520);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 27322, 27536);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 27322, 27536);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override SyntaxNode ForbiddenZone
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 27808, 27815);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 27811, 27815);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 27808, 27815);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 27808, 27815);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 27808, 27815);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ForEachLocalSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10255, 26272, 27827);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10255, 26272, 27827);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 26272, 27827);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10255, 26272, 27827);

            int
            f_10255_26879_26957(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 26879, 26957);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbol
            f_10255_26750_26766_C(Microsoft.CodeAnalysis.CSharp.Symbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10255, 26418, 27016);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Binder
            f_10255_27294_27305()
            {
                var return_v = ScopeBinder;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 27294, 27305);
                return return_v;
            }

        }
        private class DeconstructionLocalSymbol : SourceLocalSymbol
        {
            private readonly SyntaxNode _deconstruction;

            private readonly Binder _nodeBinder;

            public DeconstructionLocalSymbol(
                            Symbol containingSymbol,
                            Binder scopeBinder,
                            Binder nodeBinder,
                            TypeSyntax typeSyntax,
                            SyntaxToken identifierToken,
                            LocalDeclarationKind declarationKind,
                            SyntaxNode deconstruction)
            : base(f_10255_28617_28633_C(containingSymbol), scopeBinder, false, typeSyntax, identifierToken, declarationKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10255, 28263, 28824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 28181, 28196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 28235, 28246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 28733, 28766);

                    _deconstruction = deconstruction;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 28784, 28809);

                    _nodeBinder = nodeBinder;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10255, 28263, 28824);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 28263, 28824);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 28263, 28824);
                }
            }

            protected override TypeWithAnnotations InferTypeOfVarVariable(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 28840, 30202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 29100, 30148);

                    switch (f_10255_29108_29130(_deconstruction))
                    {

                        case SyntaxKind.SimpleAssignmentExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 29100, 30148);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 29241, 29302);

                            var
                            assignment = (AssignmentExpressionSyntax)_deconstruction
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 29328, 29372);

                            f_10255_29328_29371(f_10255_29341_29370(assignment));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 29398, 29445);

                            DeclarationExpressionSyntax
                            declaration = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 29471, 29506);

                            ExpressionSyntax
                            expression = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 29532, 29656);

                            f_10255_29532_29655(_nodeBinder, assignment, f_10255_29575_29590(assignment), f_10255_29592_29608(assignment), diagnostics, ref declaration, ref expression);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 29682, 29688);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 29100, 30148);

                        case SyntaxKind.ForEachVariableStatement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 29100, 30148);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 29779, 29884);

                            f_10255_29779_29883(f_10255_29792_29867(f_10255_29792_29808(this), (ForEachVariableStatementSyntax)_deconstruction) == _nodeBinder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 29910, 29974);

                            f_10255_29910_29973(_nodeBinder, diagnostics, _nodeBinder);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 30000, 30006);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 29100, 30148);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 29100, 30148);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 30064, 30129);

                            return TypeWithAnnotations.Create(f_10255_30098_30127(_nodeBinder));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 29100, 30148);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 30168, 30187);

                    return _type.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 28840, 30202);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10255_29108_29130(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = node.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 29108, 29130);
                        return return_v;
                    }


                    bool
                    f_10255_29341_29370(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                    self)
                    {
                        var return_v = self.IsDeconstruction();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 29341, 29370);
                        return return_v;
                    }


                    int
                    f_10255_29328_29371(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 29328, 29371);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    f_10255_29575_29590(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.Left;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 29575, 29590);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    f_10255_29592_29608(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.Right;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 29592, 29608);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                    f_10255_29532_29655(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                    deconstruction, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    left, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    right, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, ref Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax?
                    declaration, ref Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                    expression)
                    {
                        var return_v = this_param.BindDeconstruction((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)deconstruction, left, right, diagnostics, ref declaration, ref expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 29532, 29655);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10255_29792_29808(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.DeconstructionLocalSymbol
                    this_param)
                    {
                        var return_v = this_param.ScopeBinder;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 29792, 29808);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10255_29792_29867(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                    node)
                    {
                        var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 29792, 29867);
                        return return_v;
                    }


                    int
                    f_10255_29779_29883(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 29779, 29883);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10255_29910_29973(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.Binder
                    originalBinder)
                    {
                        var return_v = this_param.BindForEachDeconstruction(diagnostics, originalBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 29910, 29973);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10255_30098_30127(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.CreateErrorType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 30098, 30127);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 28840, 30202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 28840, 30202);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override SyntaxNode ForbiddenZone
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 30293, 30918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 30337, 30899);

                        switch (f_10255_30345_30367(_deconstruction))
                        {

                            case SyntaxKind.SimpleAssignmentExpression:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 30337, 30899);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 30490, 30513);

                                return _deconstruction;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 30337, 30899);

                            case SyntaxKind.ForEachVariableStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 30337, 30899);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 30786, 30798);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 30337, 30899);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 30337, 30899);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 30864, 30876);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 30337, 30899);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 30293, 30918);

                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_10255_30345_30367(Microsoft.CodeAnalysis.SyntaxNode
                        node)
                        {
                            var return_v = node.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 30345, 30367);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 30218, 30933);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 30218, 30933);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static DeconstructionLocalSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10255, 28069, 30944);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10255, 28069, 30944);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 28069, 30944);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10255, 28069, 30944);

            static Microsoft.CodeAnalysis.CSharp.Symbol
            f_10255_28617_28633_C(Microsoft.CodeAnalysis.CSharp.Symbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10255, 28263, 28824);
                return return_v;
            }

        }
        private class LocalSymbolWithEnclosingContext : SourceLocalSymbol
        {
            private readonly SyntaxNode _forbiddenZone;

            private readonly Binder _nodeBinder;

            private readonly SyntaxNode _nodeToBind;

            public LocalSymbolWithEnclosingContext(
                            Symbol containingSymbol,
                            Binder scopeBinder,
                            Binder nodeBinder,
                            TypeSyntax typeSyntax,
                            SyntaxToken identifierToken,
                            LocalDeclarationKind declarationKind,
                            SyntaxNode nodeToBind,
                            SyntaxNode forbiddenZone)
            : base(f_10255_31612_31628_C(containingSymbol), scopeBinder, false, typeSyntax, identifierToken, declarationKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10255, 31209, 32864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 31074, 31088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 31127, 31138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 31181, 31192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 31728, 32569);

                    f_10255_31728_32568(f_10255_31763_31780(nodeToBind) == SyntaxKind.CasePatternSwitchLabel || (DynAbs.Tracing.TraceSender.Expression_False(10255, 31763, 31900) || f_10255_31842_31859(nodeToBind) == SyntaxKind.ThisConstructorInitializer) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 31763, 31983) || f_10255_31925_31942(nodeToBind) == SyntaxKind.BaseConstructorInitializer) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 31763, 32066) || f_10255_32008_32025(nodeToBind) == SyntaxKind.PrimaryConstructorBaseType) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 31763, 32287) || f_10255_32131_32148(nodeToBind) == SyntaxKind.ArgumentList && (DynAbs.Tracing.TraceSender.Expression_True(10255, 32131, 32287) && (f_10255_32180_32197(nodeToBind) is ConstructorInitializerSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10255, 32180, 32286) || f_10255_32233_32250(nodeToBind) is PrimaryConstructorBaseTypeSyntax)))) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 31763, 32362) || f_10255_32312_32329(nodeToBind) == SyntaxKind.VariableDeclarator) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 31763, 32438) || f_10255_32387_32404(nodeToBind) == SyntaxKind.SwitchExpressionArm) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 31763, 32512) || f_10255_32463_32480(nodeToBind) == SyntaxKind.GotoCaseStatement) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 31763, 32567) || nodeToBind is ExpressionSyntax));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 32587, 32699);

                    f_10255_32587_32698(!(f_10255_32602_32619(nodeToBind) == SyntaxKind.SwitchExpressionArm) || (DynAbs.Tracing.TraceSender.Expression_False(10255, 32600, 32697) || nodeBinder is SwitchExpressionArmBinder));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 32717, 32747);

                    this._nodeBinder = nodeBinder;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 32765, 32795);

                    this._nodeToBind = nodeToBind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 32813, 32849);

                    this._forbiddenZone = forbiddenZone;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10255, 31209, 32864);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 31209, 32864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 31209, 32864);
                }
            }

            internal override SyntaxNode ForbiddenZone
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 32923, 32940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 32926, 32940);
                        return _forbiddenZone; DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 32923, 32940);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 32923, 32940);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 32923, 32940);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override ErrorCode ForbiddenDiagnostic
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 33236, 33304);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 33239, 33304);
                        return ErrorCode.ERR_ImplicitlyTypedOutVariableUsedInTheSameArgumentList; DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 33236, 33304);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 33236, 33304);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 33236, 33304);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected override TypeWithAnnotations InferTypeOfVarVariable(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10255, 33321, 36481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 33442, 36126);

                    switch (f_10255_33450_33468(_nodeToBind))
                    {

                        case SyntaxKind.ThisConstructorInitializer:
                        case SyntaxKind.BaseConstructorInitializer:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 33442, 36126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 33644, 33704);

                            var
                            initializer = (ConstructorInitializerSyntax)_nodeToBind
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 33730, 33795);

                            f_10255_33730_33794(_nodeBinder, initializer, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 33821, 33827);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 33442, 36126);

                        case SyntaxKind.PrimaryConstructorBaseType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 33442, 36126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 33918, 34017);

                            f_10255_33918_34016(_nodeBinder, _nodeToBind, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 34043, 34049);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 33442, 36126);

                        case SyntaxKind.ArgumentList:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 33442, 36126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 34126, 34790);

                            switch (f_10255_34134_34152(_nodeToBind))
                            {

                                case ConstructorInitializerSyntax ctorInitializer:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 34126, 34790);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 34294, 34363);

                                    f_10255_34294_34362(_nodeBinder, ctorInitializer, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10255, 34397, 34403);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 34126, 34790);

                                case PrimaryConstructorBaseTypeSyntax ctorInitializer:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 34126, 34790);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 34521, 34590);

                                    f_10255_34521_34589(_nodeBinder, ctorInitializer, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10255, 34624, 34630);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 34126, 34790);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 34126, 34790);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 34702, 34763);

                                    throw f_10255_34708_34762(f_10255_34743_34761(_nodeToBind));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 34126, 34790);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 34816, 34822);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 33442, 36126);

                        case SyntaxKind.CasePatternSwitchLabel:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 33442, 36126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 34909, 35012);

                            f_10255_34909_35011(_nodeBinder, _nodeToBind, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 35038, 35044);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 33442, 36126);

                        case SyntaxKind.VariableDeclarator:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 33442, 36126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 35317, 35405);

                            f_10255_35317_35404(                        // This occurs, for example, in
                                                                        // int x, y[out var Z, 1 is int I];
                                                                        // for (int x, y[out var Z, 1 is int I]; ;) {}
                                                    _nodeBinder, _nodeToBind, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 35431, 35437);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 33442, 36126);

                        case SyntaxKind.SwitchExpressionArm:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 33442, 36126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 35521, 35570);

                            var
                            arm = (SwitchExpressionArmSyntax)_nodeToBind
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 35596, 35651);

                            var
                            armBinder = (SwitchExpressionArmBinder)_nodeBinder
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 35677, 35729);

                            f_10255_35677_35728(armBinder, arm, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 35755, 35761);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 33442, 36126);

                        case SyntaxKind.GotoCaseStatement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 33442, 36126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 35843, 35916);

                            f_10255_35843_35915(_nodeBinder, (GotoStatementSyntax)_nodeToBind, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 35942, 35948);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 33442, 36126);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 33442, 36126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 36004, 36075);

                            f_10255_36004_36074(_nodeBinder, _nodeToBind, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceBreak(10255, 36101, 36107);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 33442, 36126);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 36146, 36427) || true) && (this._type == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10255, 36146, 36427);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 36210, 36299);

                        f_10255_36210_36298(f_10255_36223_36243(this) == LocalDeclarationKind.DeclarationExpressionVariable);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 36321, 36408);

                        f_10255_36321_36407(this, TypeWithAnnotations.Create(f_10255_36371_36405(_nodeBinder, "var")));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10255, 36146, 36427);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10255, 36447, 36466);

                    return _type.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10255, 33321, 36481);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10255_33450_33468(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = node.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 33450, 33468);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10255_33730_33794(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                    initializer, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.BindConstructorInitializer(initializer, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 33730, 33794);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10255_33918_34016(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    initializer, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.BindConstructorInitializer((Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax)initializer, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 33918, 34016);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_10255_34134_34152(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 34134, 34152);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10255_34294_34362(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                    initializer, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.BindConstructorInitializer(initializer, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 34294, 34362);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10255_34521_34589(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                    initializer, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.BindConstructorInitializer(initializer, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 34521, 34589);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_10255_34743_34761(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 34743, 34761);
                        return return_v;
                    }


                    System.Exception
                    f_10255_34708_34762(Microsoft.CodeAnalysis.SyntaxNode?
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object?)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 34708, 34762);
                        return return_v;
                    }


                    int
                    f_10255_34909_35011(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        this_param.BindPatternSwitchLabelForInference((Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax)node, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 34909, 35011);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10255_35317_35404(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    declarator, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.BindDeclaratorArguments((Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax)declarator, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 35317, 35404);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                    f_10255_35677_35728(Microsoft.CodeAnalysis.CSharp.SwitchExpressionArmBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                    node, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.BindSwitchExpressionArm(node, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 35677, 35728);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10255_35843_35915(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                    node, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.BindStatement((Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax)node, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 35843, 35915);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10255_36004_36074(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.BindExpression((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)node, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 36004, 36074);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                    f_10255_36223_36243(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalSymbolWithEnclosingContext
                    this_param)
                    {
                        var return_v = this_param.DeclarationKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 36223, 36243);
                        return return_v;
                    }


                    int
                    f_10255_36210_36298(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 36210, 36298);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10255_36371_36405(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, string
                    name)
                    {
                        var return_v = this_param.CreateErrorType(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 36371, 36405);
                        return return_v;
                    }


                    int
                    f_10255_36321_36407(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol.LocalSymbolWithEnclosingContext
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    newType)
                    {
                        this_param.SetTypeWithAnnotations(newType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 36321, 36407);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10255, 33321, 36481);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 33321, 36481);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static LocalSymbolWithEnclosingContext()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10255, 30956, 36492);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10255, 30956, 36492);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 30956, 36492);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10255, 30956, 36492);

            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10255_31763_31780(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = node.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 31763, 31780);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10255_31842_31859(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = node.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 31842, 31859);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10255_31925_31942(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = node.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 31925, 31942);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10255_32008_32025(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = node.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 32008, 32025);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10255_32131_32148(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = node.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 32131, 32148);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxNode?
            f_10255_32180_32197(Microsoft.CodeAnalysis.SyntaxNode
            this_param)
            {
                var return_v = this_param.Parent;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 32180, 32197);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxNode?
            f_10255_32233_32250(Microsoft.CodeAnalysis.SyntaxNode
            this_param)
            {
                var return_v = this_param.Parent;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 32233, 32250);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10255_32312_32329(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = node.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 32312, 32329);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10255_32387_32404(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = node.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 32387, 32404);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10255_32463_32480(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = node.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 32463, 32480);
                return return_v;
            }


            int
            f_10255_31728_32568(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 31728, 32568);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10255_32602_32619(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = node.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 32602, 32619);
                return return_v;
            }


            int
            f_10255_32587_32698(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 32587, 32698);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbol
            f_10255_31612_31628_C(Microsoft.CodeAnalysis.CSharp.Symbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10255, 31209, 32864);
                return return_v;
            }

        }

        static SourceLocalSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10255, 575, 36499);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10255, 575, 36499);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10255, 575, 36499);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10255, 575, 36499);

        int
        f_10255_1982_2037(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 1982, 2037);
            return 0;
        }


        int
        f_10255_2052_2110(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 2052, 2110);
            return 0;
        }


        int
        f_10255_2125_2158(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 2125, 2158);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        f_10255_2512_2549(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        syntax, out Microsoft.CodeAnalysis.RefKind
        refKind)
        {
            var return_v = syntax.SkipRef(out refKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 2512, 2549);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10255_2749_2811(Microsoft.CodeAnalysis.Location
        item)
        {
            var return_v = ImmutableArray.Create<Location>(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10255, 2749, 2811);
            return return_v;
        }


        uint
        f_10255_2919_2946(Microsoft.CodeAnalysis.CSharp.Binder
        this_param)
        {
            var return_v = this_param.LocalScopeDepth;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10255, 2919, 2946);
            return return_v;
        }

    }
}
