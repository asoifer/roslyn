// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceMethodSymbolWithAttributes : SourceMethodSymbol, IAttributeTargetSymbol
    {
        private CustomAttributesBag<CSharpAttributeData> _lazyCustomAttributesBag;

        private CustomAttributesBag<CSharpAttributeData> _lazyReturnTypeCustomAttributesBag;

        protected readonly SyntaxReference syntaxReferenceOpt;

        protected SourceMethodSymbolWithAttributes(SyntaxReference syntaxReferenceOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10261, 1225, 1384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 939, 963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 1023, 1057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 1196, 1214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 1328, 1373);

                this.syntaxReferenceOpt = syntaxReferenceOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10261, 1225, 1384);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 1225, 1384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 1225, 1384);
            }
        }

        protected CSharpSyntaxNode? GetInMethodSyntaxNode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 1526, 2961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 1602, 2950);

                switch (f_10261_1610_1620())
                {

                    case ConstructorDeclarationSyntax constructor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 1602, 2950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 1722, 1822);

                        return f_10261_1729_1752(constructor) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?>(10261, 1729, 1821) ?? (CSharpSyntaxNode?)f_10261_1775_1791(constructor) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?>(10261, 1756, 1821) ?? f_10261_1795_1821(constructor)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 1602, 2950);

                    case BaseMethodDeclarationSyntax method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 1602, 2950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 1902, 1965);

                        return (CSharpSyntaxNode?)f_10261_1928_1939(method) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?>(10261, 1909, 1964) ?? f_10261_1943_1964(method));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 1602, 2950);

                    case AccessorDeclarationSyntax accessor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 1602, 2950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 2045, 2112);

                        return (CSharpSyntaxNode?)f_10261_2071_2084(accessor) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?>(10261, 2052, 2111) ?? f_10261_2088_2111(accessor));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 1602, 2950);

                    case ArrowExpressionClauseSyntax arrowExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 1602, 2950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 2201, 2380);

                        f_10261_2201_2379(f_10261_2214_2244(arrowExpression.Parent!) == SyntaxKind.PropertyDeclaration || (DynAbs.Tracing.TraceSender.Expression_False(10261, 2214, 2378) || f_10261_2316_2345(f_10261_2316_2338(arrowExpression)) == SyntaxKind.IndexerDeclaration));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 2402, 2425);

                        return arrowExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 1602, 2950);

                    case LocalFunctionStatementSyntax localFunction:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 1602, 2950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 2513, 2590);

                        return (CSharpSyntaxNode?)f_10261_2539_2557(localFunction) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?>(10261, 2520, 2589) ?? f_10261_2561_2589(localFunction));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 1602, 2950);

                    case CompilationUnitSyntax _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 2637, 2701) || true) && (this is SynthesizedSimpleProgramEntryPointSymbol entryPoint) && (DynAbs.Tracing.TraceSender.Expression_True(10261, 2637, 2701) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 1602, 2950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 2724, 2777);

                        return (CSharpSyntaxNode)f_10261_2749_2776(entryPoint);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 1602, 2950);

                    case RecordDeclarationSyntax recordDecl:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 1602, 2950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 2857, 2875);

                        return recordDecl;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 1602, 2950);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 1602, 2950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 2923, 2935);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 1602, 2950);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 1526, 2961);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10261_1610_1620()
                {
                    var return_v = SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 1610, 1620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
                f_10261_1729_1752(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 1729, 1752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10261_1775_1791(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 1775, 1791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10261_1795_1821(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 1795, 1821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10261_1928_1939(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 1928, 1939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10261_1943_1964(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 1943, 1964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10261_2071_2084(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 2071, 2084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10261_2088_2111(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 2088, 2111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10261_2214_2244(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 2214, 2244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10261_2316_2338(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 2316, 2338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10261_2316_2345(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 2316, 2345);
                    return return_v;
                }


                int
                f_10261_2201_2379(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 2201, 2379);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10261_2539_2557(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 2539, 2557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10261_2561_2589(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 2561, 2589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10261_2749_2776(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 2749, 2776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 1526, 2961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 1526, 2961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxReference SyntaxRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 3051, 3133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 3087, 3118);

                    return this.syntaxReferenceOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 3051, 3133);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 2992, 3144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 2992, 3144);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual CSharpSyntaxNode SyntaxNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 3225, 3380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 3261, 3365);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 3268, 3301) || (((this.syntaxReferenceOpt == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 3304, 3308)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 3311, 3364))) ? null : (CSharpSyntaxNode)f_10261_3329_3364(this.syntaxReferenceOpt);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 3225, 3380);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10261_3329_3364(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 3329, 3364);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 3156, 3391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 3156, 3391);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 3458, 3592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 3494, 3577);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 3501, 3532) || ((this.syntaxReferenceOpt == null && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 3535, 3539)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 3542, 3576))) ? null : f_10261_3542_3576(this.syntaxReferenceOpt);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 3458, 3592);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10261_3542_3576(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 3542, 3576);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 3403, 3603);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 3403, 3603);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 3713, 3894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 3749, 3879);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 3756, 3789) || (((this.syntaxReferenceOpt == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 3792, 3829)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 3832, 3878))) ? ImmutableArray<SyntaxReference>.Empty : f_10261_3832_3878(this.syntaxReferenceOpt);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 3713, 3894);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10261_3832_3878(Microsoft.CodeAnalysis.SyntaxReference
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 3832, 3878);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 3615, 3905);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 3615, 3905);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 3991, 4089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 4007, 4089);
                    return f_10261_4007_4089(f_10261_4044_4088(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 3991, 4089);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 3991, 4089);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 3991, 4089);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 4188, 4296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 4191, 4296);
                    return f_10261_4191_4262_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10261_4191_4235(this), 10261, 4191, 4262)?.NotNullIfParameterNotNull) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableHashSet<string>?>(10261, 4191, 4296) ?? ImmutableHashSet<string>.Empty); DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 4188, 4296);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 4188, 4296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 4188, 4296);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual SourceMemberMethodSymbol BoundAttributesSource
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 4816, 4879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 4852, 4864);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 4816, 4879);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 4727, 4890);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 4727, 4890);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual IAttributeTargetSymbol AttributeOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 4982, 5002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 4988, 5000);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 4982, 5002);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 4902, 5013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 4902, 5013);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 5111, 5146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 5117, 5144);

                    return f_10261_5124_5143(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 5111, 5146);

                    Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
                    f_10261_5124_5143(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.AttributeOwner;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 5124, 5143);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 5025, 5157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 5025, 5157);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 5259, 5299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 5265, 5297);

                    return AttributeLocation.Method;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 5259, 5299);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 5169, 5310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 5169, 5310);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 5413, 6115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 5449, 6100);

                    switch (f_10261_5457_5467())
                    {

                        case MethodKind.Constructor:
                        case MethodKind.Destructor:
                        case MethodKind.StaticConstructor:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 5449, 6100);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 5668, 5700);

                            return AttributeLocation.Method;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 5449, 6100);

                        case MethodKind.PropertySet:
                        case MethodKind.EventRemove:
                        case MethodKind.EventAdd:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 5449, 6100);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 5875, 5964);

                            return AttributeLocation.Method | AttributeLocation.Return | AttributeLocation.Parameter;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 5449, 6100);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 5449, 6100);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 6022, 6081);

                            return AttributeLocation.Method | AttributeLocation.Return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 5449, 6100);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 5413, 6115);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10261_5457_5467()
                    {
                        var return_v = MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 5457, 5467);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 5322, 6126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 5322, 6126);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 6289, 6477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 6400, 6466);

                return f_10261_6407_6465(default(SyntaxList<AttributeListSyntax>));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 6289, 6477);

                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10261_6407_6465(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 6407, 6465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 6289, 6477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 6289, 6477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual OneOrMany<SyntaxList<AttributeListSyntax>> GetReturnTypeAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 6648, 7004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 6959, 6993);

                return f_10261_6966_6992(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 6648, 7004);

                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10261_6966_6992(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetAttributeDeclarations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 6966, 6992);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 6648, 7004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 6648, 7004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MethodEarlyWellKnownAttributeData GetEarlyDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 7313, 7774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 7420, 7465);

                var
                attributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 7479, 7656) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10261, 7483, 7567) || f_10261_7508_7567_M(!attributesBag.IsEarlyDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 7479, 7656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 7601, 7641);

                    attributesBag = f_10261_7617_7640(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 7479, 7656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 7672, 7763);

                return (MethodEarlyWellKnownAttributeData)f_10261_7714_7762(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 7313, 7774);

                bool
                f_10261_7508_7567_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 7508, 7567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_7617_7640(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 7617, 7640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                f_10261_7714_7762(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 7714, 7762);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 7313, 7774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 7313, 7774);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected MethodWellKnownAttributeData GetDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 8063, 8500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 8161, 8206);

                var
                attributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 8220, 8392) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10261, 8224, 8303) || f_10261_8249_8303_M(!attributesBag.IsDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 8220, 8392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 8337, 8377);

                    attributesBag = f_10261_8353_8376(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 8220, 8392);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 8408, 8489);

                return (MethodWellKnownAttributeData)f_10261_8445_8488(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 8063, 8500);

                bool
                f_10261_8249_8303_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 8249, 8303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_8353_8376(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 8353, 8376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10261_8445_8488(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 8445, 8488);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 8063, 8500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 8063, 8500);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ReturnTypeWellKnownAttributeData GetDecodedReturnTypeWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 8816, 9290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 8927, 8982);

                var
                attributesBag = _lazyReturnTypeCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 8996, 9178) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10261, 9000, 9079) || f_10261_9025_9079_M(!attributesBag.IsDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 8996, 9178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 9113, 9163);

                    attributesBag = f_10261_9129_9162(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 8996, 9178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 9194, 9279);

                return (ReturnTypeWellKnownAttributeData)f_10261_9235_9278(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 8816, 9290);

                bool
                f_10261_9025_9079_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 9025, 9079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_9129_9162(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetReturnTypeAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 9129, 9162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10261_9235_9278(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 9235, 9278);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 8816, 9290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 8816, 9290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CustomAttributesBag<CSharpAttributeData> GetAttributesBag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 9616, 9951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 9708, 9743);

                var
                bag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 9757, 9848) || true) && (bag != null && (DynAbs.Tracing.TraceSender.Expression_True(10261, 9761, 9788) && f_10261_9776_9788(bag)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 9757, 9848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 9822, 9833);

                    return bag;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 9757, 9848);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 9864, 9940);

                return f_10261_9871_9939(this, ref _lazyCustomAttributesBag, forReturnType: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 9616, 9951);

                bool
                f_10261_9776_9788(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 9776, 9788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_9871_9939(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributesBag, bool
                forReturnType)
                {
                    var return_v = this_param.GetAttributesBag(ref lazyCustomAttributesBag, forReturnType: forReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 9871, 9939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 9616, 9951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 9616, 9951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CustomAttributesBag<CSharpAttributeData> GetReturnTypeAttributesBag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 10282, 10646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 10384, 10429);

                var
                bag = _lazyReturnTypeCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 10443, 10534) || true) && (bag != null && (DynAbs.Tracing.TraceSender.Expression_True(10261, 10447, 10474) && f_10261_10462_10474(bag)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 10443, 10534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 10508, 10519);

                    return bag;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 10443, 10534);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 10550, 10635);

                return f_10261_10557_10634(this, ref _lazyReturnTypeCustomAttributesBag, forReturnType: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 10282, 10646);

                bool
                f_10261_10462_10474(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 10462, 10474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_10557_10634(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributesBag, bool
                forReturnType)
                {
                    var return_v = this_param.GetAttributesBag(ref lazyCustomAttributesBag, forReturnType: forReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 10557, 10634);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 10282, 10646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 10282, 10646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CustomAttributesBag<CSharpAttributeData> GetAttributesBag(ref CustomAttributesBag<CSharpAttributeData> lazyCustomAttributesBag, bool forReturnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 10658, 12245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 10838, 10880);

                var
                copyFrom = f_10261_10853_10879(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 10940, 10987);

                f_10261_10940_10986(!f_10261_10954_10985(copyFrom, this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 11003, 11031);

                bool
                bagCreatedOnThisThread
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 11045, 12058) || true) && ((object)copyFrom != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 11045, 12058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 11107, 11211);

                    var
                    attributesBag = (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 11127, 11140) || ((forReturnType && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 11143, 11180)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 11183, 11210))) ? f_10261_11143_11180(copyFrom) : f_10261_11183_11210(copyFrom)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 11229, 11340);

                    bagCreatedOnThisThread = f_10261_11254_11331(ref lazyCustomAttributesBag, attributesBag, null) == null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 11045, 12058);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 11045, 12058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 11406, 11617);

                    var (declarations, symbolPart) = (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 11439, 11452) || ((forReturnType
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 11476, 11540)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 11564, 11616))) ? (f_10261_11477_11513(this), AttributeLocation.Return)
                    : (f_10261_11565_11591(this), AttributeLocation.None);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 11635, 12043);

                    bagCreatedOnThisThread = f_10261_11660_12042(this, declarations, ref lazyCustomAttributesBag, symbolPart, binderOpt:
                    (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 11959, 11988) || ((                    // LAFHIS
                                                                                                             //(this as LocalFunctionSymbol)?.SignatureBinder
                                        (this is LocalFunctionSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 11991, 12034)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 12037, 12041))) ? f_10261_11991_12034(((LocalFunctionSymbol)this)) : null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 11045, 12058);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 12074, 12187) || true) && (bagCreatedOnThisThread)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 12074, 12187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 12134, 12172);

                    f_10261_12134_12171(this, forReturnType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 12074, 12187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 12203, 12234);

                return lazyCustomAttributesBag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 10658, 12245);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                f_10261_10853_10879(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.BoundAttributesSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 10853, 10879);
                    return return_v;
                }


                bool
                f_10261_10954_10985(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 10954, 10985);
                    return return_v;
                }


                int
                f_10261_10940_10986(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 10940, 10986);
                    return 0;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_11143_11180(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetReturnTypeAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 11143, 11180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_11183_11210(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 11183, 11210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_11254_11331(ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location1, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 11254, 11331);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10261_11477_11513(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetReturnTypeAttributeDeclarations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 11477, 11513);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10261_11565_11591(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetAttributeDeclarations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 11565, 11591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10261_11991_12034(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.SignatureBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 11991, 12034);
                    return return_v;
                }


                bool
                f_10261_11660_12042(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                attributesSyntaxLists, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributesBag, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                symbolPart, Microsoft.CodeAnalysis.CSharp.Binder?
                binderOpt)
                {
                    var return_v = this_param.LoadAndValidateAttributes(attributesSyntaxLists, ref lazyCustomAttributesBag, symbolPart, binderOpt: binderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 11660, 12042);
                    return return_v;
                }


                int
                f_10261_12134_12171(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, bool
                forReturnType)
                {
                    this_param.NoteAttributesComplete(forReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 12134, 12171);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 10658, 12245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 10658, 12245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract void NoteAttributesComplete(bool forReturnType);

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 12662, 12807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 12754, 12796);

                return f_10261_12761_12795(f_10261_12761_12784(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 12662, 12807);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_12761_12784(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 12761, 12784);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_12761_12795(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 12761, 12795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 12662, 12807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 12662, 12807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<CSharpAttributeData> GetReturnTypeAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 13014, 13179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 13116, 13168);

                return f_10261_13123_13167(f_10261_13123_13156(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 13014, 13179);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_13123_13156(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetReturnTypeAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 13123, 13156);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_13123_13167(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 13123, 13167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 13014, 13179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 13014, 13179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override CSharpAttributeData EarlyDecodeWellKnownAttribute(ref EarlyDecodeWellKnownAttributeArguments<EarlyWellKnownAttributeBinder, NamedTypeSymbol, AttributeSyntax, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 13191, 15887);
                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData boundAttribute = default(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData);
                Microsoft.CodeAnalysis.ObsoleteAttributeData obsoleteData = default(Microsoft.CodeAnalysis.ObsoleteAttributeData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 13428, 13541);

                f_10261_13428_13540(arguments.SymbolPart == AttributeLocation.None || (DynAbs.Tracing.TraceSender.Expression_False(10261, 13441, 13539) || arguments.SymbolPart == AttributeLocation.Return));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 13557, 13580);

                bool
                hasAnyDiagnostics
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 13596, 15803) || true) && (arguments.SymbolPart == AttributeLocation.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 13596, 15803);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 13680, 15788) || true) && (f_10261_13684_13821(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.ConditionalAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 13680, 15788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 13863, 13989);

                        boundAttribute = f_10261_13884_13988(arguments.Binder, arguments.AttributeSyntax, arguments.AttributeType, out hasAnyDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 14011, 14474) || true) && (f_10261_14015_14040_M(!boundAttribute.HasErrors))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 14011, 14474);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 14090, 14180);

                            string
                            name = f_10261_14104_14179(boundAttribute, 0, SpecialType.System_String)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 14206, 14296);

                            f_10261_14206_14295(arguments.GetOrCreateData<MethodEarlyWellKnownAttributeData>(), name);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 14322, 14451) || true) && (!hasAnyDiagnostics)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 14322, 14451);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 14402, 14424);

                                return boundAttribute;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 14322, 14451);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 14011, 14474);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 14498, 14510);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 13680, 15788);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 13680, 15788);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 14552, 15788) || true) && (f_10261_14556_14705(ref arguments, out boundAttribute, out obsoleteData))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 14552, 15788);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 14747, 14944) || true) && (obsoleteData != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 14747, 14944);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 14821, 14921);

                                arguments.GetOrCreateData<MethodEarlyWellKnownAttributeData>().ObsoleteAttributeData = obsoleteData;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 14747, 14944);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 14968, 14990);

                            return boundAttribute;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 14552, 15788);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 14552, 15788);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 15032, 15788) || true) && (f_10261_15036_15182(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.UnmanagedCallersOnlyAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 15032, 15788);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 15224, 15331);

                                arguments.GetOrCreateData<MethodEarlyWellKnownAttributeData>().UnmanagedCallersOnlyAttributePresent = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 15757, 15769);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 15032, 15788);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 14552, 15788);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 13680, 15788);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 13596, 15803);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 15819, 15876);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EarlyDecodeWellKnownAttribute(ref arguments), 10261, 15826, 15875);

				var temp = base.EarlyDecodeWellKnownAttribute(ref arguments);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 15826, 15875);
				return temp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 13191, 15887);

                int
                f_10261_13428_13540(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 13428, 13540);
                    return 0;
                }


                bool
                f_10261_13684_13821(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 13684, 13821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10261_13884_13988(Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                boundAttributeType, out bool
                generatedDiagnostics)
                {
                    var return_v = this_param.GetAttribute(node, boundAttributeType, out generatedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 13884, 13988);
                    return return_v;
                }


                bool
                f_10261_14015_14040_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 14015, 14040);
                    return return_v;
                }


                string?
                f_10261_14104_14179(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, int
                i, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetConstructorArgument<string>(i, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 14104, 14179);
                    return return_v;
                }


                int
                f_10261_14206_14295(Microsoft.CodeAnalysis.CSharp.Symbols.MethodEarlyWellKnownAttributeData
                this_param, string?
                name)
                {
                    this_param.AddConditionalSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 14206, 14295);
                    return 0;
                }


                bool
                f_10261_14556_14705(ref Microsoft.CodeAnalysis.EarlyDecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, out Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attributeData, out Microsoft.CodeAnalysis.ObsoleteAttributeData
                obsoleteData)
                {
                    var return_v = EarlyDecodeDeprecatedOrExperimentalOrObsoleteAttribute(ref arguments, out attributeData, out obsoleteData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 14556, 14705);
                    return return_v;
                }


                bool
                f_10261_15036_15182(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 15036, 15182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 13191, 15887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 13191, 15887);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 15960, 16163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 15996, 16047);

                    var
                    data = f_10261_16007_16046(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 16065, 16148);

                    return f_10261_16072_16104_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(data, 10261, 16072, 16104)?.HasSkipLocalsInitAttribute) != true && (DynAbs.Tracing.TraceSender.Expression_True(10261, 16072, 16147) && f_10261_16116_16147());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 15960, 16163);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    f_10261_16007_16046(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 16007, 16046);
                        return return_v;
                    }


                    bool?
                    f_10261_16072_16104_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 16072, 16104);
                        return return_v;
                    }


                    bool
                    f_10261_16116_16147()
                    {
                        var return_v = AreContainingSymbolLocalsZeroed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 16116, 16147);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 15899, 16174);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 15899, 16174);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 16547, 17445);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 16583, 16745) || true) && (f_10261_16587_16603() is SourceMemberContainerTypeSymbol { AnyMemberHasAttributes: false })
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 16583, 16745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 16714, 16726);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 16583, 16745);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 16765, 16820);

                    var
                    lazyCustomAttributesBag = _lazyCustomAttributesBag
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 16838, 17189) || true) && (lazyCustomAttributesBag != null && (DynAbs.Tracing.TraceSender.Expression_True(10261, 16842, 16945) && f_10261_16877_16945(lazyCustomAttributesBag)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 16838, 17189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 16987, 17092);

                        var
                        data = (MethodEarlyWellKnownAttributeData)f_10261_17033_17091(lazyCustomAttributesBag)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 17114, 17170);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 17121, 17133) || ((data != null && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 17136, 17162)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 17165, 17169))) ? f_10261_17136_17162(data) : null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 16838, 17189);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 17209, 17367) || true) && (syntaxReferenceOpt is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 17209, 17367);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 17336, 17348);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 17209, 17367);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 17387, 17430);

                    return ObsoleteAttributeData.Uninitialized;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 16547, 17445);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10261_16587_16603()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 16587, 16603);
                        return return_v;
                    }


                    bool
                    f_10261_16877_16945(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    this_param)
                    {
                        var return_v = this_param.IsEarlyDecodedWellKnownAttributeDataComputed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 16877, 16945);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                    f_10261_17033_17091(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    this_param)
                    {
                        var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 17033, 17091);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ObsoleteAttributeData?
                    f_10261_17136_17162(Microsoft.CodeAnalysis.CSharp.Symbols.MethodEarlyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.ObsoleteAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 17136, 17162);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 16454, 17456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 16454, 17456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override UnmanagedCallersOnlyAttributeData? GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 17486, 20143);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 17627, 17769) || true) && (syntaxReferenceOpt is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 17627, 17769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 17742, 17754);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 17627, 17769);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 17785, 17876) || true) && (forceComplete)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 17785, 17876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 17836, 17861);

                    _ = f_10261_17840_17860(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 17785, 17876);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 17892, 17947);

                var
                lazyCustomAttributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 17961, 18220) || true) && (lazyCustomAttributesBag is null || (DynAbs.Tracing.TraceSender.Expression_False(10261, 17965, 18069) || f_10261_18000_18069_M(!lazyCustomAttributesBag.IsEarlyDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 17961, 18220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 18103, 18132);

                    f_10261_18103_18131(!forceComplete);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 18150, 18205);

                    return UnmanagedCallersOnlyAttributeData.Uninitialized;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 17961, 18220);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 18236, 18689) || true) && (f_10261_18240_18303(lazyCustomAttributesBag))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 18236, 18689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 18337, 18437);

                    var
                    lateData = (MethodWellKnownAttributeData?)f_10261_18383_18436(lazyCustomAttributesBag)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 18468, 18595);

                    f_10261_18468_18594(f_10261_18525_18583(lazyCustomAttributesBag), lateData);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 18623, 18674);

                    return f_10261_18630_18673_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(lateData, 10261, 18630, 18673)?.UnmanagedCallersOnlyAttributeData);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 18236, 18689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 18705, 18816);

                var
                earlyData = (MethodEarlyWellKnownAttributeData?)f_10261_18757_18815(lazyCustomAttributesBag)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 18830, 18859);

                f_10261_18830_18858(!forceComplete);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 18873, 19042);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 18880, 18935) || ((f_10261_18880_18927_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(earlyData, 10261, 18880, 18927)?.UnmanagedCallersOnlyAttributePresent) == true
                && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 18955, 19017)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 19037, 19041))) ? UnmanagedCallersOnlyAttributeData.AttributePresentDataNotBound
                : null;

                static void verifyDataConsistent(MethodEarlyWellKnownAttributeData? earlyData, MethodWellKnownAttributeData? lateData)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10261, 19180, 20124);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 19331, 20109) || true) && (lateData is { UnmanagedCallersOnlyAttributeData: not null })
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 19331, 20109);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 19782, 19856);

                            f_10261_19782_19855(earlyData is { UnmanagedCallersOnlyAttributePresent: true });
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 19331, 20109);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 19331, 20109);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 19898, 20109) || true) && (earlyData is null or { UnmanagedCallersOnlyAttributePresent: false })
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 19898, 20109);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 20012, 20090);

                                f_10261_20012_20089(lateData is null or { UnmanagedCallersOnlyAttributeData: null });
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 19898, 20109);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 19331, 20109);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10261, 19180, 20124);

                        int
                        f_10261_19782_19855(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 19782, 19855);
                            return 0;
                        }


                        int
                        f_10261_20012_20089(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 20012, 20089);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 19180, 20124);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 19180, 20124);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 17486, 20143);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_17840_17860(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 17840, 17860);
                    return return_v;
                }


                bool
                f_10261_18000_18069_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 18000, 18069);
                    return return_v;
                }


                int
                f_10261_18103_18131(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 18103, 18131);
                    return 0;
                }


                bool
                f_10261_18240_18303(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsDecodedWellKnownAttributeDataComputed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 18240, 18303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10261_18383_18436(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 18383, 18436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                f_10261_18525_18583(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 18525, 18583);
                    return return_v;
                }


                int
                f_10261_18468_18594(Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                earlyData, Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData?
                lateData)
                {
                    verifyDataConsistent((Microsoft.CodeAnalysis.CSharp.Symbols.MethodEarlyWellKnownAttributeData?)earlyData, lateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 18468, 18594);
                    return 0;
                }


                Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                f_10261_18630_18673_M(Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 18630, 18673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                f_10261_18757_18815(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 18757, 18815);
                    return return_v;
                }


                int
                f_10261_18830_18858(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 18830, 18858);
                    return 0;
                }


                bool?
                f_10261_18880_18927_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 18880, 18927);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 17486, 20143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 17486, 20143);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 20174, 20465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 20277, 20363);

                MethodEarlyWellKnownAttributeData
                data = f_10261_20318_20362(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 20377, 20454);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 20384, 20396) || ((data != null && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 20399, 20422)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 20425, 20453))) ? f_10261_20399_20422(data) : ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 20174, 20465);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodEarlyWellKnownAttributeData
                f_10261_20318_20362(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetEarlyDecodedWellKnownAttributeData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 20318, 20362);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10261_20399_20422(Microsoft.CodeAnalysis.CSharp.Symbols.MethodEarlyWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.ConditionalSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 20399, 20422);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 20174, 20465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 20174, 20465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 20477, 21141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 20662, 20707);

                f_10261_20662_20706(f_10261_20675_20705_M(!arguments.Attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 20721, 20834);

                f_10261_20721_20833(arguments.SymbolPart == AttributeLocation.None || (DynAbs.Tracing.TraceSender.Expression_False(10261, 20734, 20832) || arguments.SymbolPart == AttributeLocation.Return));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 20850, 21130) || true) && (arguments.SymbolPart == AttributeLocation.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 20850, 21130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 20934, 20989);

                    f_10261_20934_20988(this, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 20850, 21130);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 20850, 21130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 21055, 21115);

                    f_10261_21055_21114(this, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 20850, 21130);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 20477, 21141);

                bool
                f_10261_20675_20705_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 20675, 20705);
                    return return_v;
                }


                int
                f_10261_20662_20706(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 20662, 20706);
                    return 0;
                }


                int
                f_10261_20721_20833(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 20721, 20833);
                    return 0;
                }


                int
                f_10261_20934_20988(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeWellKnownAttributeAppliedToMethod(ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 20934, 20988);
                    return 0;
                }


                int
                f_10261_21055_21114(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeWellKnownAttributeAppliedToReturnValue(ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 21055, 21114);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 20477, 21141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 20477, 21141);
            }
        }

        private void DecodeWellKnownAttributeAppliedToMethod(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 21153, 26842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 21336, 21395);

                f_10261_21336_21394((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 21411, 21447);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 21461, 21496);

                f_10261_21461_21495(f_10261_21474_21494_M(!attribute.HasErrors));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 21512, 26831) || true) && (f_10261_21516_21592(attribute, this, AttributeDescription.PreserveSigAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 21512, 26831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 21626, 21722);

                    f_10261_21626_21721(arguments.GetOrCreateData<MethodWellKnownAttributeData>(), arguments.Index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 21512, 26831);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 21512, 26831);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 21756, 26831) || true) && (f_10261_21760_21835(attribute, this, AttributeDescription.MethodImplAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 21756, 26831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 21869, 22037);

                        f_10261_21869_22036(ref arguments, MessageProvider.Instance);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 21756, 26831);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 21756, 26831);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 22071, 26831) || true) && (f_10261_22075_22149(attribute, this, AttributeDescription.DllImportAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 22071, 26831);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 22183, 22223);

                            f_10261_22183_22222(this, ref arguments);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 22071, 26831);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 22071, 26831);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 22257, 26831) || true) && (f_10261_22261_22337(attribute, this, AttributeDescription.SpecialNameAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 22257, 26831);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 22371, 22460);

                                arguments.GetOrCreateData<MethodWellKnownAttributeData>().HasSpecialNameAttribute = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 22257, 26831);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 22257, 26831);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 22494, 26831) || true) && (f_10261_22498_22586(attribute, this, AttributeDescription.ExcludeFromCodeCoverageAttribute))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 22494, 26831);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 22620, 22721);

                                    arguments.GetOrCreateData<MethodWellKnownAttributeData>().HasExcludeFromCodeCoverageAttribute = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 22494, 26831);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 22494, 26831);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 22755, 26831) || true) && (f_10261_22759_22835(attribute, this, AttributeDescription.ConditionalAttribute))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 22755, 26831);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 22869, 22962);

                                        f_10261_22869_22961(this, attribute, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 22755, 26831);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 22755, 26831);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 22996, 26831) || true) && (f_10261_23000_23094(attribute, this, AttributeDescription.SuppressUnmanagedCodeSecurityAttribute))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 22996, 26831);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 23128, 23235);

                                            arguments.GetOrCreateData<MethodWellKnownAttributeData>().HasSuppressUnmanagedCodeSecurityAttribute = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 22996, 26831);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 22996, 26831);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 23269, 26831) || true) && (f_10261_23273_23359(attribute, this, AttributeDescription.DynamicSecurityMethodAttribute))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 23269, 26831);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 23393, 23492);

                                                arguments.GetOrCreateData<MethodWellKnownAttributeData>().HasDynamicSecurityMethodAttribute = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 23269, 26831);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 23269, 26831);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 23526, 26831) || true) && (f_10261_23530_23623(this, ref arguments, AttributeDescription.ObsoleteAttribute))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 23526, 26831);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 23526, 26831);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 23526, 26831);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 23673, 26831) || true) && (f_10261_23677_23772(this, ref arguments, AttributeDescription.DeprecatedAttribute))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 23673, 26831);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 23673, 26831);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 23673, 26831);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 23822, 26831) || true) && (f_10261_23826_24117(this, arguments, ReservedAttributes.IsReadOnlyAttribute | ReservedAttributes.IsUnmanagedAttribute | ReservedAttributes.IsByRefLikeAttribute | ReservedAttributes.NullableContextAttribute | ReservedAttributes.CaseSensitiveExtensionAttribute))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 23822, 26831);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 23822, 26831);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 23822, 26831);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 24167, 26831) || true) && (f_10261_24171_24252(attribute, this, AttributeDescription.SecurityCriticalAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10261, 24171, 24358) || f_10261_24273_24358(attribute, this, AttributeDescription.SecuritySafeCriticalAttribute)))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 24167, 26831);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 24392, 24642) || true) && (f_10261_24396_24403())
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 24392, 24642);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 24445, 24623);

                                                                    f_10261_24445_24622(arguments.Diagnostics, ErrorCode.ERR_SecurityCriticalOrSecuritySafeCriticalOnAsync, f_10261_24532_24569(arguments.AttributeSyntaxOpt), f_10261_24571_24621(arguments.AttributeSyntaxOpt));
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 24392, 24642);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 24167, 26831);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 24167, 26831);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 24676, 26831) || true) && (f_10261_24680_24759(attribute, this, AttributeDescription.SkipLocalsInitAttribute))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 24676, 26831);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 24793, 24910);

                                                                    f_10261_24793_24909(f_10261_24873_24893(), ref arguments);
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 24676, 26831);
                                                                }

                                                                else
                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 24676, 26831);

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 24944, 26831) || true) && (f_10261_24948_25026(attribute, this, AttributeDescription.DoesNotReturnAttribute))
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 24944, 26831);
                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 25060, 25151);

                                                                        arguments.GetOrCreateData<MethodWellKnownAttributeData>().HasDoesNotReturnAttribute = true;
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 24944, 26831);
                                                                    }

                                                                    else
                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 24944, 26831);

                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 25185, 26831) || true) && (f_10261_25189_25267(attribute, this, AttributeDescription.MemberNotNullAttribute))
                                                                        )

                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 25185, 26831);
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 25301, 25414);

                                                                            f_10261_25301_25413(MessageID.IDS_FeatureMemberNotNull, arguments.Diagnostics, arguments.AttributeSyntaxOpt);
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 25432, 25542);

                                                                            f_10261_25432_25541(f_10261_25511_25525(), ref arguments);
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 25185, 26831);
                                                                        }

                                                                        else
                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 25185, 26831);

                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 25576, 26831) || true) && (f_10261_25580_25662(attribute, this, AttributeDescription.MemberNotNullWhenAttribute))
                                                                            )

                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 25576, 26831);
                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 25696, 25809);

                                                                                f_10261_25696_25808(MessageID.IDS_FeatureMemberNotNull, arguments.Diagnostics, arguments.AttributeSyntaxOpt);
                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 25827, 25941);

                                                                                f_10261_25827_25940(f_10261_25910_25924(), ref arguments);
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 25576, 26831);
                                                                            }

                                                                            else
                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 25576, 26831);

                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 25975, 26831) || true) && (f_10261_25979_26061(attribute, this, AttributeDescription.ModuleInitializerAttribute))
                                                                                )

                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 25975, 26831);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 26095, 26213);

                                                                                    f_10261_26095_26212(MessageID.IDS_FeatureModuleInitializers, arguments.Diagnostics, arguments.AttributeSyntaxOpt);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 26231, 26275);

                                                                                    f_10261_26231_26274(this, arguments);
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 25975, 26831);
                                                                                }

                                                                                else
                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 25975, 26831);

                                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 26309, 26831) || true) && (f_10261_26313_26398(attribute, this, AttributeDescription.UnmanagedCallersOnlyAttribute))
                                                                                    )

                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 26309, 26831);
                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 26432, 26483);

                                                                                        f_10261_26432_26482(this, ref arguments);
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 26309, 26831);
                                                                                    }

                                                                                    else

                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 26309, 26831);
                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 26549, 26593);

                                                                                        var
                                                                                        compilation = f_10261_26567_26592(this)
                                                                                        ;

                                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 26611, 26816) || true) && (f_10261_26615_26657(attribute, compilation))
                                                                                        )

                                                                                        {
                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 26611, 26816);
                                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 26699, 26797);

                                                                                            f_10261_26699_26796(attribute, this, compilation, ref arguments);
                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 26611, 26816);
                                                                                        }
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 26309, 26831);
                                                                                    }
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 25975, 26831);
                                                                                }
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 25576, 26831);
                                                                            }
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 25185, 26831);
                                                                        }
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 24944, 26831);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 24676, 26831);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 24167, 26831);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 23822, 26831);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 23673, 26831);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 23526, 26831);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 23269, 26831);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 22996, 26831);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 22755, 26831);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 22494, 26831);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 22257, 26831);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 22071, 26831);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 21756, 26831);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 21512, 26831);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 21153, 26842);

                int
                f_10261_21336_21394(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 21336, 21394);
                    return 0;
                }


                bool
                f_10261_21474_21494_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 21474, 21494);
                    return return_v;
                }


                int
                f_10261_21461_21495(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 21461, 21495);
                    return 0;
                }


                bool
                f_10261_21516_21592(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 21516, 21592);
                    return return_v;
                }


                int
                f_10261_21626_21721(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                this_param, int
                attributeIndex)
                {
                    this_param.SetPreserveSignature(attributeIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 21626, 21721);
                    return 0;
                }


                bool
                f_10261_21760_21835(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 21760, 21835);
                    return return_v;
                }


                int
                f_10261_21869_22036(ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider)
                {
                    AttributeData.DecodeMethodImplAttribute<MethodWellKnownAttributeData, AttributeSyntax, CSharpAttributeData, AttributeLocation>(ref arguments, (Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 21869, 22036);
                    return 0;
                }


                bool
                f_10261_22075_22149(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 22075, 22149);
                    return return_v;
                }


                int
                f_10261_22183_22222(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeDllImportAttribute(ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 22183, 22222);
                    return 0;
                }


                bool
                f_10261_22261_22337(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 22261, 22337);
                    return return_v;
                }


                bool
                f_10261_22498_22586(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 22498, 22586);
                    return return_v;
                }


                bool
                f_10261_22759_22835(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 22759, 22835);
                    return return_v;
                }


                int
                f_10261_22869_22961(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ValidateConditionalAttribute(attribute, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 22869, 22961);
                    return 0;
                }


                bool
                f_10261_23000_23094(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 23000, 23094);
                    return return_v;
                }


                bool
                f_10261_23273_23359(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 23273, 23359);
                    return return_v;
                }


                bool
                f_10261_23530_23623(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.VerifyObsoleteAttributeAppliedToMethod(ref arguments, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 23530, 23623);
                    return return_v;
                }


                bool
                f_10261_23677_23772(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.VerifyObsoleteAttributeAppliedToMethod(ref arguments, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 23677, 23772);
                    return return_v;
                }


                bool
                f_10261_23826_24117(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.CSharp.Symbol.ReservedAttributes
                reserved)
                {
                    var return_v = this_param.ReportExplicitUseOfReservedAttributes(arguments, reserved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 23826, 24117);
                    return return_v;
                }


                bool
                f_10261_24171_24252(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 24171, 24252);
                    return return_v;
                }


                bool
                f_10261_24273_24358(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 24273, 24358);
                    return return_v;
                }


                bool
                f_10261_24396_24403()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 24396, 24403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_24532_24569(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 24532, 24569);
                    return return_v;
                }


                string
                f_10261_24571_24621(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 24571, 24621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_24445_24622(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 24445, 24622);
                    return return_v;
                }


                bool
                f_10261_24680_24759(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 24680, 24759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10261_24873_24893()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 24873, 24893);
                    return return_v;
                }


                int
                f_10261_24793_24909(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    CSharpAttributeData.DecodeSkipLocalsInitAttribute<MethodWellKnownAttributeData>(compilation, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 24793, 24909);
                    return 0;
                }


                bool
                f_10261_24948_25026(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 24948, 25026);
                    return return_v;
                }


                bool
                f_10261_25189_25267(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 25189, 25267);
                    return return_v;
                }


                bool
                f_10261_25301_25413(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                syntax)
                {
                    var return_v = feature.CheckFeatureAvailability(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode?)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 25301, 25413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_25511_25525()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 25511, 25525);
                    return return_v;
                }


                int
                f_10261_25432_25541(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    CSharpAttributeData.DecodeMemberNotNullAttribute<MethodWellKnownAttributeData>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 25432, 25541);
                    return 0;
                }


                bool
                f_10261_25580_25662(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 25580, 25662);
                    return return_v;
                }


                bool
                f_10261_25696_25808(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                syntax)
                {
                    var return_v = feature.CheckFeatureAvailability(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode?)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 25696, 25808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_25910_25924()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 25910, 25924);
                    return return_v;
                }


                int
                f_10261_25827_25940(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    CSharpAttributeData.DecodeMemberNotNullWhenAttribute<MethodWellKnownAttributeData>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 25827, 25940);
                    return 0;
                }


                bool
                f_10261_25979_26061(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 25979, 26061);
                    return return_v;
                }


                bool
                f_10261_26095_26212(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                syntax)
                {
                    var return_v = feature.CheckFeatureAvailability(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode?)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 26095, 26212);
                    return return_v;
                }


                int
                f_10261_26231_26274(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeModuleInitializerAttribute(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 26231, 26274);
                    return 0;
                }


                bool
                f_10261_26313_26398(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 26313, 26398);
                    return return_v;
                }


                int
                f_10261_26432_26482(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeUnmanagedCallersOnlyAttribute(ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 26432, 26482);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10261_26567_26592(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 26567, 26592);
                    return return_v;
                }


                bool
                f_10261_26615_26657(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsSecurityAttribute(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 26615, 26657);
                    return return_v;
                }


                int
                f_10261_26699_26796(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeSecurityAttribute<Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData>((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, compilation, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 26699, 26796);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 21153, 26842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 21153, 26842);
            }
        }

        internal override ImmutableArray<string> NotNullMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 26910, 27008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 26926, 27008);
                    return f_10261_26926_26976_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10261_26926_26960(this), 10261, 26926, 26976)?.NotNullMembers) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<string>?>(10261, 26926, 27008) ?? ImmutableArray<string>.Empty); DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 26910, 27008);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 26910, 27008);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 26910, 27008);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<string> NotNullWhenTrueMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 27085, 27191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 27101, 27191);
                    return f_10261_27101_27159_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10261_27101_27135(this), 10261, 27101, 27159)?.NotNullWhenTrueMembers) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<string>?>(10261, 27101, 27191) ?? ImmutableArray<string>.Empty); DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 27085, 27191);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 27085, 27191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 27085, 27191);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<string> NotNullWhenFalseMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 27269, 27376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 27285, 27376);
                    return f_10261_27285_27344_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10261_27285_27319(this), 10261, 27285, 27344)?.NotNullWhenFalseMembers) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<string>?>(10261, 27285, 27376) ?? ImmutableArray<string>.Empty); DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 27269, 27376);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 27269, 27376);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 27269, 27376);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 27477, 27600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 27513, 27585);

                    return f_10261_27520_27584(f_10261_27549_27583(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 27477, 27600);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    f_10261_27549_27583(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 27549, 27583);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                    f_10261_27520_27584(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    attributeData)
                    {
                        var return_v = DecodeFlowAnalysisAttributes(attributeData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 27520, 27584);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 27389, 27611);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 27389, 27611);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static FlowAnalysisAnnotations DecodeFlowAnalysisAttributes(MethodWellKnownAttributeData attributeData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 27748, 27870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 27751, 27870);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 27751, 27799) || ((f_10261_27751_27791_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(attributeData, 10261, 27751, 27791)?.HasDoesNotReturnAttribute) == true && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 27802, 27839)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 27842, 27870))) ? FlowAnalysisAnnotations.DoesNotReturn : FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 27748, 27870);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 27748, 27870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 27748, 27870);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool?
            f_10261_27751_27791_M(bool?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 27751, 27791);
                return return_v;
            }

        }

        private bool VerifyObsoleteAttributeAppliedToMethod(
                    ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments,
                    AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 27883, 29151);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 28126, 29111) || true) && (f_10261_28130_28186(arguments.Attribute, this, description))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 28126, 29111);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 28220, 29064) || true) && (f_10261_28224_28241(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 28220, 29064);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 28283, 29045) || true) && (this is SourceEventAccessorSymbol)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 28283, 29045);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 28495, 28590);

                            AttributeUsageInfo
                            attributeUsage = f_10261_28531_28589(f_10261_28531_28565(arguments.Attribute))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 28616, 28798);

                            f_10261_28616_28797(arguments.Diagnostics, ErrorCode.ERR_AttributeNotOnEventAccessor, f_10261_28685_28727(f_10261_28685_28718(arguments.AttributeSyntaxOpt)), description.FullName, attributeUsage.GetValidTargetsErrorArgument());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 28283, 29045);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 28283, 29045);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 28896, 29022);

                            f_10261_28896_29021(MessageID.IDS_FeatureObsoleteOnPropertyAccessor, arguments.Diagnostics, arguments.AttributeSyntaxOpt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 28283, 29045);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 28220, 29064);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 29084, 29096);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 28126, 29111);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 29127, 29140);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 27883, 29151);

                bool
                f_10261_28130_28186(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 28130, 28186);
                    return return_v;
                }


                bool
                f_10261_28224_28241(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                methodSymbol)
                {
                    var return_v = methodSymbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 28224, 28241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10261_28531_28565(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 28531, 28565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10261_28531_28589(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.GetAttributeUsageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 28531, 28589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10261_28685_28718(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 28685, 28718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_28685_28727(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 28685, 28727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_28616_28797(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 28616, 28797);
                    return return_v;
                }


                bool
                f_10261_28896_29021(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                syntax)
                {
                    var return_v = feature.CheckFeatureAvailability(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode?)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 28896, 29021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 27883, 29151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 27883, 29151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ValidateConditionalAttribute(CSharpAttributeData attribute, AttributeSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 29163, 32108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 29309, 29342);

                f_10261_29309_29341(f_10261_29322_29340(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 29358, 32097) || true) && (f_10261_29362_29379(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 29358, 32097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 29542, 29627);

                    AttributeUsageInfo
                    attributeUsage = f_10261_29578_29626(f_10261_29578_29602(attribute))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 29645, 29794);

                    f_10261_29645_29793(diagnostics, ErrorCode.ERR_AttributeNotOnAccessor, f_10261_29699_29717(f_10261_29699_29708(node)), f_10261_29719_29745(node), attributeUsage.GetValidTargetsErrorArgument());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 29358, 32097);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 29358, 32097);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 29828, 32097) || true) && (f_10261_29832_29869(f_10261_29832_29851(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 29828, 32097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 29991, 30066);

                        f_10261_29991_30065(                // CS0582: The Conditional attribute is not valid on interface members
                                        diagnostics, ErrorCode.ERR_ConditionalOnInterfaceMethod, f_10261_30051_30064(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 29828, 32097);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 29828, 32097);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 30100, 32097) || true) && (f_10261_30104_30119(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 30100, 32097);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 30262, 30336);

                            f_10261_30262_30335(                // CS0243: The Conditional attribute is not valid on '{0}' because it is an override method
                                            diagnostics, ErrorCode.ERR_ConditionalOnOverride, f_10261_30315_30328(node), this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 30100, 32097);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 30100, 32097);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 30370, 32097) || true) && (f_10261_30374_30401_M(!this.CanBeReferencedByName) || (DynAbs.Tracing.TraceSender.Expression_False(10261, 30374, 30445) || f_10261_30405_30420(this) == MethodKind.Destructor))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 30370, 32097);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 30643, 30722);

                                f_10261_30643_30721(                // CS0577: The Conditional attribute is not valid on '{0}' because it is a constructor, destructor, operator, or explicit interface implementation
                                                diagnostics, ErrorCode.ERR_ConditionalOnSpecialMethod, f_10261_30701_30714(node), this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 30370, 32097);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 30370, 32097);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 30756, 32097) || true) && (f_10261_30760_30777_M(!this.ReturnsVoid))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 30756, 32097);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 30923, 31001);

                                    f_10261_30923_31000(                // CS0578: The Conditional attribute is not valid on '{0}' because its return type is not void
                                                    diagnostics, ErrorCode.ERR_ConditionalMustReturnVoid, f_10261_30980_30993(node), this);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 30756, 32097);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 30756, 32097);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 31035, 32097) || true) && (f_10261_31039_31064(this))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 31035, 32097);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 31180, 31256);

                                        f_10261_31180_31255(                // CS0685: Conditional member '{0}' cannot have an out parameter
                                                        diagnostics, ErrorCode.ERR_ConditionalWithOutParam, f_10261_31235_31248(node), this);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 31035, 32097);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 31035, 32097);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 31290, 32097) || true) && (this is { MethodKind: MethodKind.LocalFunction, IsStatic: false })
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 31290, 32097);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 31393, 31472);

                                            f_10261_31393_31471(diagnostics, ErrorCode.ERR_ConditionalOnLocalFunction, f_10261_31451_31464(node), this);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 31290, 32097);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 31290, 32097);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 31538, 31623);

                                            string
                                            name = f_10261_31552_31622(attribute, 0, SpecialType.System_String)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 31643, 32082) || true) && (name == null || (DynAbs.Tracing.TraceSender.Expression_False(10261, 31647, 31699) || !f_10261_31664_31699(name)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 31643, 32082);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 31836, 31925);

                                                CSharpSyntaxNode
                                                attributeArgumentSyntax = f_10261_31879_31924(attribute, 0, node)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 31947, 32063);

                                                f_10261_31947_32062(diagnostics, ErrorCode.ERR_BadArgumentToAttribute, f_10261_32001_32033(attributeArgumentSyntax), f_10261_32035_32061(node));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 31643, 32082);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 31290, 32097);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 31035, 32097);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 30756, 32097);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 30370, 32097);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 30100, 32097);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 29828, 32097);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 29358, 32097);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 29163, 32108);

                bool
                f_10261_29322_29340(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.IsConditional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 29322, 29340);
                    return return_v;
                }


                int
                f_10261_29309_29341(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 29309, 29341);
                    return 0;
                }


                bool
                f_10261_29362_29379(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                methodSymbol)
                {
                    var return_v = methodSymbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 29362, 29379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10261_29578_29602(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 29578, 29602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10261_29578_29626(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.GetAttributeUsageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 29578, 29626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10261_29699_29708(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 29699, 29708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_29699_29717(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 29699, 29717);
                    return return_v;
                }


                string
                f_10261_29719_29745(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 29719, 29745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_29645_29793(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 29645, 29793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_29832_29851(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 29832, 29851);
                    return return_v;
                }


                bool
                f_10261_29832_29869(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 29832, 29869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_30051_30064(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 30051, 30064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_29991_30065(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 29991, 30065);
                    return return_v;
                }


                bool
                f_10261_30104_30119(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 30104, 30119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_30315_30328(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 30315, 30328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_30262_30335(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 30262, 30335);
                    return return_v;
                }


                bool
                f_10261_30374_30401_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 30374, 30401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10261_30405_30420(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 30405, 30420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_30701_30714(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 30701, 30714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_30643_30721(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 30643, 30721);
                    return return_v;
                }


                bool
                f_10261_30760_30777_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 30760, 30777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_30980_30993(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 30980, 30993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_30923_31000(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 30923, 31000);
                    return return_v;
                }


                bool
                f_10261_31039_31064(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.HasAnyOutParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 31039, 31064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_31235_31248(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 31235, 31248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_31180_31255(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 31180, 31255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_31451_31464(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 31451, 31464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_31393_31471(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 31393, 31471);
                    return return_v;
                }


                string?
                f_10261_31552_31622(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, int
                i, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetConstructorArgument<string>(i, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 31552, 31622);
                    return return_v;
                }


                bool
                f_10261_31664_31699(string
                name)
                {
                    var return_v = SyntaxFacts.IsValidIdentifier(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 31664, 31699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10261_31879_31924(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    var return_v = attribute.GetAttributeArgumentSyntax(parameterIndex, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 31879, 31924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_32001_32033(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 32001, 32033);
                    return return_v;
                }


                string
                f_10261_32035_32061(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 32035, 32061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_31947_32062(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 31947, 32062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 29163, 32108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 29163, 32108);
            }
        }

        private bool HasAnyOutParameter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 32120, 32409);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 32178, 32369);
                    foreach (var param in f_10261_32200_32215_I(f_10261_32200_32215(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 32178, 32369);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 32249, 32354) || true) && (f_10261_32253_32266(param) == RefKind.Out)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 32249, 32354);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 32323, 32335);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 32249, 32354);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 32178, 32369);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10261, 1, 192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10261, 1, 192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 32385, 32398);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 32120, 32409);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10261_32200_32215(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 32200, 32215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10261_32253_32266(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 32253, 32266);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10261_32200_32215_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 32200, 32215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 32120, 32409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 32120, 32409);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DecodeWellKnownAttributeAppliedToReturnValue(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 32421, 34351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 32609, 32668);

                f_10261_32609_32667((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 32684, 32720);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 32734, 32769);

                f_10261_32734_32768(f_10261_32747_32767_M(!attribute.HasErrors));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 32785, 34340) || true) && (f_10261_32789_32863(attribute, this, AttributeDescription.MarshalAsAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 32785, 34340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 32956, 33151);

                    f_10261_32956_33150(ref arguments, AttributeTargets.ReturnValue, MessageProvider.Instance);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 32785, 34340);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 32785, 34340);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 33185, 34340) || true) && (f_10261_33189_33550(this, arguments, ReservedAttributes.DynamicAttribute | ReservedAttributes.IsUnmanagedAttribute | ReservedAttributes.IsReadOnlyAttribute | ReservedAttributes.IsByRefLikeAttribute | ReservedAttributes.TupleElementNamesAttribute | ReservedAttributes.NullableAttribute | ReservedAttributes.NativeIntegerAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 33185, 34340);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 33185, 34340);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 33185, 34340);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 33600, 34340) || true) && (f_10261_33604_33678(attribute, this, AttributeDescription.MaybeNullAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 33600, 34340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 33712, 33803);

                            arguments.GetOrCreateData<ReturnTypeWellKnownAttributeData>().HasMaybeNullAttribute = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 33600, 34340);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 33600, 34340);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 33837, 34340) || true) && (f_10261_33841_33913(attribute, this, AttributeDescription.NotNullAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 33837, 34340);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 33947, 34036);

                                arguments.GetOrCreateData<ReturnTypeWellKnownAttributeData>().HasNotNullAttribute = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 33837, 34340);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 33837, 34340);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 34070, 34340) || true) && (f_10261_34074_34155(attribute, this, AttributeDescription.NotNullIfNotNullAttribute))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 34070, 34340);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 34189, 34325);

                                    f_10261_34189_34324(arguments.GetOrCreateData<ReturnTypeWellKnownAttributeData>(), f_10261_34280_34323(attribute));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 34070, 34340);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 33837, 34340);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 33600, 34340);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 33185, 34340);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 32785, 34340);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 32421, 34351);

                int
                f_10261_32609_32667(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 32609, 32667);
                    return 0;
                }


                bool
                f_10261_32747_32767_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 32747, 32767);
                    return return_v;
                }


                int
                f_10261_32734_32768(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 32734, 32768);
                    return 0;
                }


                bool
                f_10261_32789_32863(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 32789, 32863);
                    return return_v;
                }


                int
                f_10261_32956_33150(ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, System.AttributeTargets
                target, Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider)
                {
                    MarshalAsAttributeDecoder<ReturnTypeWellKnownAttributeData, AttributeSyntax, CSharpAttributeData, AttributeLocation>.Decode(ref arguments, target, (Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 32956, 33150);
                    return 0;
                }


                bool
                f_10261_33189_33550(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.CSharp.Symbol.ReservedAttributes
                reserved)
                {
                    var return_v = this_param.ReportExplicitUseOfReservedAttributes(arguments, reserved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 33189, 33550);
                    return return_v;
                }


                bool
                f_10261_33604_33678(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 33604, 33678);
                    return return_v;
                }


                bool
                f_10261_33841_33913(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 33841, 33913);
                    return return_v;
                }


                bool
                f_10261_34074_34155(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 34074, 34155);
                    return return_v;
                }


                string?
                f_10261_34280_34323(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute)
                {
                    var return_v = attribute.DecodeNotNullIfNotNullAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 34280, 34323);
                    return return_v;
                }


                int
                f_10261_34189_34324(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                this_param, string?
                parameterName)
                {
                    this_param.AddNotNullIfParameterNotNull(parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 34189, 34324);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 32421, 34351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 32421, 34351);
            }
        }

        private void DecodeDllImportAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 34381, 40343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 34549, 34622);

                f_10261_34549_34621(f_10261_34568_34610_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(arguments.AttributeSyntaxOpt, 10261, 34568, 34610)?.ArgumentList) is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 34638, 34674);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 34688, 34723);

                f_10261_34688_34722(f_10261_34701_34721_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 34737, 34760);

                bool
                hasErrors = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 34776, 34840);

                var
                implementationPart = f_10261_34801_34831(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(10261, 34801, 34839) ?? this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 34854, 35112) || true) && (f_10261_34858_34886_M(!implementationPart.IsExtern) || (DynAbs.Tracing.TraceSender.Expression_False(10261, 34858, 34918) || f_10261_34890_34918_M(!implementationPart.IsStatic)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 34854, 35112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 34952, 35062);

                    f_10261_34952_35061(arguments.Diagnostics, ErrorCode.ERR_DllImportOnInvalidMethod, f_10261_35018_35060(f_10261_35018_35051(arguments.AttributeSyntaxOpt)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 35080, 35097);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 34854, 35112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 35128, 35165);

                var
                isAnyNestedMethodGeneric = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 35198, 35212);
                    for (MethodSymbol?
        current = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 35179, 35480) || true) && (current is object)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 35233, 35283)
        , current = f_10261_35243_35267(current) as MethodSymbol, DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 35179, 35480))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 35179, 35480);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 35317, 35465) || true) && (f_10261_35321_35344(current))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 35317, 35465);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 35386, 35418);

                            isAnyNestedMethodGeneric = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(10261, 35440, 35446);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 35317, 35465);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10261, 1, 302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10261, 1, 302);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 35496, 35759) || true) && (isAnyNestedMethodGeneric || (DynAbs.Tracing.TraceSender.Expression_False(10261, 35500, 35565) || f_10261_35528_35557_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10261_35528_35542(), 10261, 35528, 35557)?.IsGenericType) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 35496, 35759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 35599, 35709);

                    f_10261_35599_35708(arguments.Diagnostics, ErrorCode.ERR_DllImportOnGenericMethod, f_10261_35665_35707(f_10261_35665_35698(arguments.AttributeSyntaxOpt)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 35727, 35744);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 35496, 35759);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 35775, 35867);

                string?
                moduleName = f_10261_35796_35866(attribute, 0, SpecialType.System_String)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 35881, 36415) || true) && (!f_10261_35886_35939(moduleName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 35881, 36415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 36046, 36159);

                    CSharpSyntaxNode
                    attributeArgumentSyntax = f_10261_36089_36158(attribute, 0, arguments.AttributeSyntaxOpt)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 36177, 36329);

                    f_10261_36177_36328(arguments.Diagnostics, ErrorCode.ERR_InvalidAttributeArgument, f_10261_36243_36275(attributeArgumentSyntax), f_10261_36277_36327(arguments.AttributeSyntaxOpt));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 36347, 36364);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 36382, 36400);

                    moduleName = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 35881, 36415);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 36853, 36946);

                CharSet
                charSet = f_10261_36871_36915(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Runtime.InteropServices.CharSet?>(10261, 36871, 36945) ?? Cci.Constants.CharSet_None)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 36962, 36988);

                string?
                importName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 37002, 37026);

                bool
                preserveSig = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 37040, 37134);

                CallingConvention
                callingConvention = System.Runtime.InteropServices.CallingConvention.Winapi
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 37148, 37174);

                bool
                setLastError = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 37188, 37215);

                bool
                exactSpelling = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 37273, 37301);

                bool?
                bestFitMapping = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 37315, 37346);

                bool?
                throwOnUnmappable = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 37362, 37379);

                int
                position = 1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 37393, 39746);
                    foreach (var namedArg in f_10261_37418_37448_I(f_10261_37418_37448(attribute)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 37393, 39746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 37482, 39700);

                        switch (namedArg.Key)
                        {

                            case "EntryPoint":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 37482, 39700);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 37588, 37640);

                                importName = namedArg.Value.ValueInternal as string;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 37666, 38137) || true) && (!f_10261_37671_37724(importName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 37666, 38137);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 37867, 38015);

                                    f_10261_37867_38014(                            // Dev10 reports CS0647: "Error emitting attribute ..."
                                                                arguments.Diagnostics, ErrorCode.ERR_InvalidNamedArgument, f_10261_37929_37999(f_10261_37929_37980(f_10261_37929_37970(arguments.AttributeSyntaxOpt))[position]), namedArg.Key);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 38045, 38062);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 38092, 38110);

                                    importName = null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 37666, 38137);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10261, 38165, 38171);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 37482, 39700);

                            case "CharSet":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 37482, 39700);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 38295, 38366);

                                charSet = namedArg.Value.DecodeValue<CharSet>(SpecialType.System_Enum);
                                DynAbs.Tracing.TraceSender.TraceBreak(10261, 38392, 38398);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 37482, 39700);

                            case "SetLastError":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 37482, 39700);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 38527, 38603);

                                setLastError = namedArg.Value.DecodeValue<bool>(SpecialType.System_Boolean);
                                DynAbs.Tracing.TraceSender.TraceBreak(10261, 38629, 38635);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 37482, 39700);

                            case "ExactSpelling":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 37482, 39700);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 38765, 38842);

                                exactSpelling = namedArg.Value.DecodeValue<bool>(SpecialType.System_Boolean);
                                DynAbs.Tracing.TraceSender.TraceBreak(10261, 38868, 38874);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 37482, 39700);

                            case "PreserveSig":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 37482, 39700);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 38943, 39018);

                                preserveSig = namedArg.Value.DecodeValue<bool>(SpecialType.System_Boolean);
                                DynAbs.Tracing.TraceSender.TraceBreak(10261, 39044, 39050);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 37482, 39700);

                            case "CallingConvention":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 37482, 39700);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 39184, 39275);

                                callingConvention = namedArg.Value.DecodeValue<CallingConvention>(SpecialType.System_Enum);
                                DynAbs.Tracing.TraceSender.TraceBreak(10261, 39301, 39307);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 37482, 39700);

                            case "BestFitMapping":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 37482, 39700);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 39379, 39457);

                                bestFitMapping = namedArg.Value.DecodeValue<bool>(SpecialType.System_Boolean);
                                DynAbs.Tracing.TraceSender.TraceBreak(10261, 39483, 39489);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 37482, 39700);

                            case "ThrowOnUnmappableChar":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 37482, 39700);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 39568, 39649);

                                throwOnUnmappable = namedArg.Value.DecodeValue<bool>(SpecialType.System_Boolean);
                                DynAbs.Tracing.TraceSender.TraceBreak(10261, 39675, 39681);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 37482, 39700);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 39720, 39731);

                        position++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 37393, 39746);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10261, 1, 2354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10261, 1, 2354);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 39762, 40332) || true) && (!hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 39762, 40332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 39810, 40317);

                    f_10261_39810_40316(arguments.GetOrCreateData<MethodWellKnownAttributeData>(), arguments.Index, moduleName, importName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10261, 39974, 39992) ?? f_10261_39988_39992()), f_10261_40015_40281(exactSpelling, charSet, setLastError, callingConvention, bestFitMapping, throwOnUnmappable), preserveSig);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 39762, 40332);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 34381, 40343);

                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                f_10261_34568_34610_M(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 34568, 34610);
                    return return_v;
                }


                int
                f_10261_34549_34621(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 34549, 34621);
                    return 0;
                }


                bool
                f_10261_34701_34721_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 34701, 34721);
                    return return_v;
                }


                int
                f_10261_34688_34722(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 34688, 34722);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10261_34801_34831(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.PartialImplementationPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 34801, 34831);
                    return return_v;
                }


                bool
                f_10261_34858_34886_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 34858, 34886);
                    return return_v;
                }


                bool
                f_10261_34890_34918_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 34890, 34918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10261_35018_35051(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 35018, 35051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_35018_35060(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 35018, 35060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_34952_35061(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 34952, 35061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10261_35243_35267(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 35243, 35267);
                    return return_v;
                }


                bool
                f_10261_35321_35344(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 35321, 35344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_35528_35542()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 35528, 35542);
                    return return_v;
                }


                bool?
                f_10261_35528_35557_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 35528, 35557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10261_35665_35698(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 35665, 35698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_35665_35707(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 35665, 35707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_35599_35708(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 35599, 35708);
                    return return_v;
                }


                string?
                f_10261_35796_35866(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, int
                i, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetConstructorArgument<string>(i, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 35796, 35866);
                    return return_v;
                }


                bool
                f_10261_35886_35939(string?
                str)
                {
                    var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 35886, 35939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10261_36089_36158(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    var return_v = attribute.GetAttributeArgumentSyntax(parameterIndex, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 36089, 36158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_36243_36275(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 36243, 36275);
                    return return_v;
                }


                string
                f_10261_36277_36327(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 36277, 36327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_36177_36328(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 36177, 36328);
                    return return_v;
                }


                System.Runtime.InteropServices.CharSet?
                f_10261_36871_36915(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetEffectiveDefaultMarshallingCharSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 36871, 36915);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10261_37418_37448(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonNamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 37418, 37448);
                    return return_v;
                }


                bool
                f_10261_37671_37724(string?
                str)
                {
                    var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 37671, 37724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                f_10261_37929_37970(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 37929, 37970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10261_37929_37980(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 37929, 37980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_37929_37999(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 37929, 37999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_37867_38014(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 37867, 38014);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10261_37418_37448_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 37418, 37448);
                    return return_v;
                }


                string
                f_10261_39988_39992()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 39988, 39992);
                    return return_v;
                }


                System.Reflection.MethodImportAttributes
                f_10261_40015_40281(bool
                exactSpelling, System.Runtime.InteropServices.CharSet
                charSet, bool
                setLastError, System.Runtime.InteropServices.CallingConvention
                callingConvention, bool?
                useBestFit, bool?
                throwOnUnmappable)
                {
                    var return_v = DllImportData.MakeFlags(exactSpelling, charSet, setLastError, callingConvention, useBestFit, throwOnUnmappable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 40015, 40281);
                    return return_v;
                }


                int
                f_10261_39810_40316(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                this_param, int
                attributeIndex, string?
                moduleName, string
                entryPointName, System.Reflection.MethodImportAttributes
                flags, bool
                preserveSig)
                {
                    this_param.SetDllImport(attributeIndex, moduleName, entryPointName, flags, preserveSig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 39810, 40316);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 34381, 40343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 34381, 40343);
            }
        }

        private void DecodeModuleInitializerAttribute(DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 40355, 42752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 40527, 40580);

                f_10261_40527_40579(arguments.AttributeSyntaxOpt is object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 40596, 40825) || true) && (f_10261_40600_40610() != MethodKind.Ordinary)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 40596, 40825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 40667, 40785);

                    f_10261_40667_40784(arguments.Diagnostics, ErrorCode.ERR_ModuleInitializerMethodMustBeOrdinary, f_10261_40746_40783(arguments.AttributeSyntaxOpt));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 40803, 40810);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 40596, 40825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 40841, 40880);

                f_10261_40841_40879(f_10261_40854_40868() is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 40894, 40915);

                var
                hasError = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 40931, 40982);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 40996, 41309) || true) && (!f_10261_41001_41081(this, f_10261_41038_41056(), ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 40996, 41309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 41115, 41260);

                    f_10261_41115_41259(arguments.Diagnostics, ErrorCode.ERR_ModuleInitializerMethodMustBeAccessibleOutsideTopLevelType, f_10261_41215_41252(arguments.AttributeSyntaxOpt), f_10261_41254_41258());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 41278, 41294);

                    hasError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 40996, 41309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 41325, 41401);

                f_10261_41325_41400(
                            arguments.Diagnostics, arguments.AttributeSyntaxOpt, useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 41417, 41690) || true) && (f_10261_41421_41430_M(!IsStatic) || (DynAbs.Tracing.TraceSender.Expression_False(10261, 41421, 41452) || f_10261_41434_41448() > 0) || (DynAbs.Tracing.TraceSender.Expression_False(10261, 41421, 41468) || f_10261_41456_41468_M(!ReturnsVoid)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 41417, 41690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 41502, 41641);

                    f_10261_41502_41640(arguments.Diagnostics, ErrorCode.ERR_ModuleInitializerMethodMustBeStaticParameterlessVoid, f_10261_41596_41633(arguments.AttributeSyntaxOpt), f_10261_41635_41639());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 41659, 41675);

                    hasError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 41417, 41690);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 41706, 41984) || true) && (f_10261_41710_41725() || (DynAbs.Tracing.TraceSender.Expression_False(10261, 41710, 41757) || f_10261_41729_41757(f_10261_41729_41743())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 41706, 41984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 41791, 41935);

                    f_10261_41791_41934(arguments.Diagnostics, ErrorCode.ERR_ModuleInitializerMethodAndContainingTypesMustNotBeGeneric, f_10261_41890_41927(arguments.AttributeSyntaxOpt), f_10261_41929_41933());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 41953, 41969);

                    hasError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 41706, 41984);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 42192, 42548) || true) && (f_10261_42196_42255(_lazyCustomAttributesBag) is MethodEarlyWellKnownAttributeData { UnmanagedCallersOnlyAttributePresent: true })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 42192, 42548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 42373, 42499);

                    f_10261_42373_42498(arguments.Diagnostics, ErrorCode.ERR_ModuleInitializerCannotBeUnmanagedCallersOnly, f_10261_42460_42497(arguments.AttributeSyntaxOpt));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 42517, 42533);

                    hasError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 42192, 42548);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 42564, 42741) || true) && (!hasError && (DynAbs.Tracing.TraceSender.Expression_True(10261, 42568, 42638) && !f_10261_42582_42638(this, f_10261_42598_42637(arguments.AttributeSyntaxOpt))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 42564, 42741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 42672, 42726);

                    f_10261_42672_42725(f_10261_42672_42692(), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 42564, 42741);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 40355, 42752);

                int
                f_10261_40527_40579(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 40527, 40579);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10261_40600_40610()
                {
                    var return_v = MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 40600, 40610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_40746_40783(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 40746, 40783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_40667_40784(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 40667, 40784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_40854_40868()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 40854, 40868);
                    return return_v;
                }


                int
                f_10261_40841_40879(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 40841, 40879);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10261_41038_41056()
                {
                    var return_v = ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41038, 41056);
                    return return_v;
                }


                bool
                f_10261_41001_41081(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = AccessCheck.IsSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 41001, 41081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_41215_41252(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41215, 41252);
                    return return_v;
                }


                string
                f_10261_41254_41258()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41254, 41258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_41115_41259(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 41115, 41259);
                    return return_v;
                }


                bool
                f_10261_41325_41400(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 41325, 41400);
                    return return_v;
                }


                bool
                f_10261_41421_41430_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41421, 41430);
                    return return_v;
                }


                int
                f_10261_41434_41448()
                {
                    var return_v = ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41434, 41448);
                    return return_v;
                }


                bool
                f_10261_41456_41468_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41456, 41468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_41596_41633(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41596, 41633);
                    return return_v;
                }


                string
                f_10261_41635_41639()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41635, 41639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_41502_41640(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 41502, 41640);
                    return return_v;
                }


                bool
                f_10261_41710_41725()
                {
                    var return_v = IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41710, 41725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_41729_41743()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41729, 41743);
                    return return_v;
                }


                bool
                f_10261_41729_41757(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41729, 41757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_41890_41927(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41890, 41927);
                    return return_v;
                }


                string
                f_10261_41929_41933()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 41929, 41933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_41791_41934(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 41791, 41934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                f_10261_42196_42255(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 42196, 42255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_42460_42497(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 42460, 42497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_42373_42498(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 42373, 42498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10261_42598_42637(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 42598, 42637);
                    return return_v;
                }


                bool
                f_10261_42582_42638(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.CallsAreOmitted(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 42582, 42638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10261_42672_42692()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 42672, 42692);
                    return return_v;
                }


                int
                f_10261_42672_42725(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                method)
                {
                    this_param.AddModuleInitializerMethod((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 42672, 42725);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 40355, 42752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 40355, 42752);
            }
        }

        private void DecodeUnmanagedCallersOnlyAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 42764, 47712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 42943, 42994);

                f_10261_42943_42993(arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 43010, 43250);

                arguments.GetOrCreateData<MethodWellKnownAttributeData>().UnmanagedCallersOnlyAttributeData =
                f_10261_43121_43249(this, arguments.Attribute, f_10261_43188_43225(arguments.AttributeSyntaxOpt), arguments.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 43266, 43400);

                bool
                reportedError = f_10261_43287_43399(this, f_10261_43333_43375(f_10261_43333_43366(arguments.AttributeSyntaxOpt)), arguments.Diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 43416, 43470);

                var
                returnTypeSyntax = f_10261_43439_43469(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 43591, 44048) || true) && (f_10261_43595_43662(returnTypeSyntax, f_10261_43629_43661(CSharpSyntaxTree.Dummy)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 43591, 44048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 43980, 44008);

                    f_10261_43980_44007(reportedError);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 44026, 44033);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 43591, 44048);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 44064, 44160);

                f_10261_44064_44159(f_10261_44091_44101(), returnTypeSyntax, isParam: false, arguments.Diagnostics);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 44174, 44362);
                    foreach (var param in f_10261_44196_44206_I(f_10261_44196_44206()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 44174, 44362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 44240, 44347);

                        f_10261_44240_44346(f_10261_44267_44277(param), f_10261_44279_44307(param), isParam: true, arguments.Diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 44174, 44362);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10261, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10261, 1, 189);
                }
                static void checkAndReportManagedTypes(TypeSymbol type, SyntaxNode syntax, bool isParam, DiagnosticBag diagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10261, 44378, 45788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 44702, 45773);

                        switch (f_10261_44710_44746(type))
                        {

                            case ManagedKind.Unmanaged:
                            case ManagedKind.UnmanagedWithGenerics:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 44702, 45773);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 45224, 45231);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 44702, 45773);

                            case ManagedKind.Managed:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 44702, 45773);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 45416, 45584);

                                f_10261_45416_45583(                        // Cannot use '{0}' as a {1} type on a method attributed with 'UnmanagedCallersOnly.
                                                        diagnostics, ErrorCode.ERR_CannotUseManagedTypeInUnmanagedCallersOnly, f_10261_45490_45505(syntax), type, f_10261_45513_45582(((DynAbs.Tracing.TraceSender.Conditional_F1(10261, 45514, 45521) || ((isParam && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 45524, 45547)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 45550, 45570))) ? MessageID.IDS_Parameter : MessageID.IDS_Return)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 45610, 45617);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 44702, 45773);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 44702, 45773);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 45675, 45754);

                                throw f_10261_45681_45753(f_10261_45716_45752(type));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 44702, 45773);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10261, 44378, 45788);

                        Microsoft.CodeAnalysis.ManagedKind
                        f_10261_44710_44746(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.ManagedKindNoUseSiteDiagnostics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 44710, 44746);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10261_45490_45505(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 45490, 45505);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                        f_10261_45513_45582(Microsoft.CodeAnalysis.CSharp.MessageID
                        id)
                        {
                            var return_v = id.Localize();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 45513, 45582);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10261_45416_45583(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 45416, 45583);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ManagedKind
                        f_10261_45716_45752(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.ManagedKindNoUseSiteDiagnostics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 45716, 45752);
                            return return_v;
                        }


                        System.Exception
                        f_10261_45681_45753(Microsoft.CodeAnalysis.ManagedKind
                        o)
                        {
                            var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 45681, 45753);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 44378, 45788);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 44378, 45788);
                    }
                }

                static UnmanagedCallersOnlyAttributeData DecodeUnmanagedCallersOnlyAttributeData(SourceMethodSymbolWithAttributes @this, CSharpAttributeData attribute, Location location, DiagnosticBag diagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10261, 45804, 47701);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 46034, 46085);

                        f_10261_46034_46084(f_10261_46047_46071(attribute) is not null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 46103, 46198);

                        ImmutableHashSet<CodeAnalysis.Symbols.INamedTypeSymbolInternal>?
                        callingConventionTypes = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 46216, 47594) || true) && (f_10261_46220_46250(attribute) is { IsDefaultOrEmpty: false } namedArgs)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 46216, 47594);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 46333, 46421);

                            var
                            systemType = f_10261_46350_46420(f_10261_46350_46376(@this), WellKnownType.System_Type)
                            ;

                            foreach (var (key, value) in f_10261_46474_46504(attribute))
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 46888, 47204);

                                bool
                                isField = f_10261_46903_46943(f_10261_46903_46927(attribute), key).Any(static (m, systemType) => m is FieldSymbol { Type: ArrayTypeSymbol { ElementType: NamedTypeSymbol elementType } } && elementType.Equals(systemType, TypeCompareKind.ConsiderEverything), systemType)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 47232, 47347);

                                var
                                namedArgumentDecoded = f_10261_47259_47346(key, value, isField, location, diagnostics)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 47375, 47552) || true) && (namedArgumentDecoded.IsCallConvs)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 47375, 47552);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 47469, 47525);

                                    callingConventionTypes = namedArgumentDecoded.CallConvs;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 47375, 47552);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 46216, 47594);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 47614, 47686);

                        return f_10261_47621_47685(callingConventionTypes);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10261, 45804, 47701);

                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                        f_10261_46047_46071(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                        this_param)
                        {
                            var return_v = this_param.AttributeClass;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 46047, 46071);
                            return return_v;
                        }


                        int
                        f_10261_46034_46084(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 46034, 46084);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                        f_10261_46220_46250(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                        this_param)
                        {
                            var return_v = this_param.CommonNamedArguments;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 46220, 46250);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10261_46350_46376(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                        this_param)
                        {
                            var return_v = this_param.DeclaringCompilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 46350, 46376);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10261_46350_46420(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.WellKnownType
                        type)
                        {
                            var return_v = this_param.GetWellKnownType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 46350, 46420);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                        f_10261_46474_46504(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                        this_param)
                        {
                            var return_v = this_param.CommonNamedArguments;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 46474, 46504);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10261_46903_46927(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                        this_param)
                        {
                            var return_v = this_param.AttributeClass;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 46903, 46927);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10261_46903_46943(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param, string
                        name)
                        {
                            var return_v = this_param.GetMembers(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 46903, 46943);
                            return return_v;
                        }


                        (bool IsCallConvs, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>? CallConvs)
                        f_10261_47259_47346(string
                        key, Microsoft.CodeAnalysis.TypedConstant
                        value, bool
                        isField, Microsoft.CodeAnalysis.Location
                        location, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = TryDecodeUnmanagedCallersOnlyCallConvsField(key, value, isField, location, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 47259, 47346);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                        f_10261_47621_47685(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>?
                        callingConventionTypes)
                        {
                            var return_v = UnmanagedCallersOnlyAttributeData.Create(callingConventionTypes);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 47621, 47685);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 45804, 47701);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 45804, 47701);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 42764, 47712);

                int
                f_10261_42943_42993(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 42943, 42993);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_43188_43225(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 43188, 43225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                f_10261_43121_43249(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                @this, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = DecodeUnmanagedCallersOnlyAttributeData(@this, attribute, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 43121, 43249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10261_43333_43366(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 43333, 43366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10261_43333_43375(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 43333, 43375);
                    return return_v;
                }


                bool
                f_10261_43287_43399(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckAndReportValidUnmanagedCallersOnlyTarget(location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 43287, 43399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10261_43439_43469(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                method)
                {
                    var return_v = method.ExtractReturnTypeSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 43439, 43469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10261_43629_43661(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 43629, 43661);
                    return return_v;
                }


                bool
                f_10261_43595_43662(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                objA, Microsoft.CodeAnalysis.SyntaxNode
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 43595, 43662);
                    return return_v;
                }


                int
                f_10261_43980_44007(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 43980, 44007);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10261_44091_44101()
                {
                    var return_v = ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 44091, 44101);
                    return return_v;
                }


                int
                f_10261_44064_44159(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, bool
                isParam, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    checkAndReportManagedTypes(type, (Microsoft.CodeAnalysis.SyntaxNode)syntax, isParam: isParam, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 44064, 44159);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10261_44196_44206()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 44196, 44206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10261_44267_44277(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 44267, 44277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10261_44279_44307(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 44279, 44307);
                    return return_v;
                }


                int
                f_10261_44240_44346(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, bool
                isParam, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    checkAndReportManagedTypes(type, (Microsoft.CodeAnalysis.SyntaxNode)syntax, isParam: isParam, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 44240, 44346);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10261_44196_44206_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 44196, 44206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 42764, 47712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 42764, 47712);
            }
        }

        internal sealed override void PostDecodeWellKnownAttributes(ImmutableArray<CSharpAttributeData> boundAttributes, ImmutableArray<AttributeSyntax> allAttributeSyntaxNodes, DiagnosticBag diagnostics, AttributeLocation symbolPart, WellKnownAttributeData decodedData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 47743, 50566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 48030, 48071);

                f_10261_48030_48070(f_10261_48043_48069_M(!boundAttributes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 48085, 48134);

                f_10261_48085_48133(f_10261_48098_48132_M(!allAttributeSyntaxNodes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 48148, 48219);

                f_10261_48148_48218(boundAttributes.Length == allAttributeSyntaxNodes.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 48233, 48326);

                f_10261_48233_48325(symbolPart == AttributeLocation.None || (DynAbs.Tracing.TraceSender.Expression_False(10261, 48246, 48324) || symbolPart == AttributeLocation.Return));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 48342, 50424) || true) && (symbolPart != AttributeLocation.Return)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 48342, 50424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 48418, 48465);

                    f_10261_48418_48464(_lazyCustomAttributesBag != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 48483, 48562);

                    f_10261_48483_48561(f_10261_48496_48560(_lazyCustomAttributesBag));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 48582, 49748) || true) && (f_10261_48586_48602() is NamedTypeSymbol { IsComImport: true, TypeKind: TypeKind.Class })
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 48582, 49748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 48711, 49729);

                        switch (f_10261_48719_48734(this))
                        {

                            case MethodKind.Constructor:
                            case MethodKind.StaticConstructor:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 48711, 49729);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 48902, 49221) || true) && (f_10261_48906_48932_M(!this.IsImplicitlyDeclared))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 48902, 49221);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 49118, 49190);

                                    f_10261_49118_49189(                                // CS0669: A class with the ComImport attribute cannot have a user-defined constructor
                                                                    diagnostics, ErrorCode.ERR_ComImportWithUserCtor, f_10261_49171_49185(this)[0]);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 48902, 49221);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10261, 49253, 49259);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 48711, 49729);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 48711, 49729);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 49325, 49668) || true) && (f_10261_49329_49345_M(!this.IsAbstract) && (DynAbs.Tracing.TraceSender.Expression_True(10261, 49329, 49363) && f_10261_49349_49363_M(!this.IsExtern)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 49325, 49668);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 49547, 49637);

                                    f_10261_49547_49636(                                // CS0423: Since '{1}' has the ComImport attribute, '{0}' must be extern or abstract
                                                                    diagnostics, ErrorCode.ERR_ComImportWithImpl, f_10261_49596_49610(this)[0], this, f_10261_49621_49635());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 49325, 49668);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10261, 49700, 49706);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 48711, 49729);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 48582, 49748);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 49768, 50409) || true) && (f_10261_49772_49780() && (DynAbs.Tracing.TraceSender.Expression_True(10261, 49772, 49816) && f_10261_49805_49816_M(!IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10261, 49772, 49864) && !f_10261_49842_49864(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10261, 49772, 49920) && f_10261_49889_49912(this) is null
                    ) && (DynAbs.Tracing.TraceSender.Expression_True(10261, 49772, 49968) && boundAttributes.IsEmpty
                    ) && (DynAbs.Tracing.TraceSender.Expression_True(10261, 49772, 50025) && f_10261_49993_50025_M(!f_10261_49994_50013(this).IsComImport)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 49768, 50409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 50067, 50316);

                        var
                        errorCode = (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 50083, 50177) || (((f_10261_50084_50099(this) == MethodKind.Constructor || (DynAbs.Tracing.TraceSender.Expression_False(10261, 50084, 50176) || f_10261_50129_50144(this) == MethodKind.StaticConstructor)) && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 50205, 50245)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 50273, 50315))) ? ErrorCode.WRN_ExternCtorNoImplementation : ErrorCode.WRN_ExternMethodNoImplementation
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 50338, 50390);

                        f_10261_50338_50389(diagnostics, errorCode, f_10261_50365_50379(this)[0], this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 49768, 50409);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 48342, 50424);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 50440, 50555);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.PostDecodeWellKnownAttributes(boundAttributes, allAttributeSyntaxNodes, diagnostics, symbolPart, decodedData), 10261, 50440, 50554);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 47743, 50566);

                bool
                f_10261_48043_48069_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 48043, 48069);
                    return return_v;
                }


                int
                f_10261_48030_48070(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 48030, 48070);
                    return 0;
                }


                bool
                f_10261_48098_48132_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 48098, 48132);
                    return return_v;
                }


                int
                f_10261_48085_48133(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 48085, 48133);
                    return 0;
                }


                int
                f_10261_48148_48218(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 48148, 48218);
                    return 0;
                }


                int
                f_10261_48233_48325(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 48233, 48325);
                    return 0;
                }


                int
                f_10261_48418_48464(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 48418, 48464);
                    return 0;
                }


                bool
                f_10261_48496_48560(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsDecodedWellKnownAttributeDataComputed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 48496, 48560);
                    return return_v;
                }


                int
                f_10261_48483_48561(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 48483, 48561);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10261_48586_48602()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 48586, 48602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10261_48719_48734(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 48719, 48734);
                    return return_v;
                }


                bool
                f_10261_48906_48932_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 48906, 48932);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10261_49171_49185(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 49171, 49185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_49118_49189(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 49118, 49189);
                    return return_v;
                }


                bool
                f_10261_49329_49345_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 49329, 49345);
                    return return_v;
                }


                bool
                f_10261_49349_49363_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 49349, 49363);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10261_49596_49610(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 49596, 49610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_49621_49635()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 49621, 49635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_49547_49636(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 49547, 49636);
                    return return_v;
                }


                bool
                f_10261_49772_49780()
                {
                    var return_v = IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 49772, 49780);
                    return return_v;
                }


                bool
                f_10261_49805_49816_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 49805, 49816);
                    return return_v;
                }


                bool
                f_10261_49842_49864(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                member)
                {
                    var return_v = member.IsPartialMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 49842, 49864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10261_49889_49912(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetInMethodSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 49889, 49912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_49994_50013(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 49994, 50013);
                    return return_v;
                }


                bool
                f_10261_49993_50025_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 49993, 50025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10261_50084_50099(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 50084, 50099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10261_50129_50144(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 50129, 50144);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10261_50365_50379(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 50365, 50379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_50338_50389(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 50338, 50389);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 47743, 50566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 47743, 50566);
            }
        }

        protected void AsyncMethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 50578, 54091);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 50662, 54080) || true) && (f_10261_50666_50673())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 50662, 54080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 50707, 50745);

                    var
                    errorLocation = f_10261_50727_50741(this)[0]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 50765, 51539) || true) && (f_10261_50769_50781(this) != RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 50765, 51539);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 50839, 51244);

                        var
                        returnTypeSyntax = f_10261_50862_50877(this) switch
                        {
                            MethodDeclarationSyntax { ReturnType: var methodReturnType } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 50933, 51013) && DynAbs.Tracing.TraceSender.Expression_True(10261, 50933, 51013))
=> methodReturnType,
                            LocalFunctionStatementSyntax { ReturnType: var localReturnType } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 51040, 51123) && DynAbs.Tracing.TraceSender.Expression_True(10261, 51040, 51123))
=> localReturnType,
                            var unexpected when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 51150, 51220) && DynAbs.Tracing.TraceSender.Expression_True(10261, 51150, 51220))
=> throw f_10261_51174_51220(unexpected)
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 51268, 51317);

                        f_10261_51268_51316(returnTypeSyntax, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 50765, 51539);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 50765, 51539);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 51359, 51539) || true) && (f_10261_51363_51417(f_10261_51363_51373(), f_10261_51391_51416(this)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 51359, 51539);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 51459, 51520);

                            f_10261_51459_51519(diagnostics, ErrorCode.ERR_BadAsyncReturn, errorLocation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 51359, 51539);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 50765, 51539);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 51580, 51606);

                        for (NamedTypeSymbol
        curr = f_10261_51587_51606(this)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 51559, 52105) || true) && ((object)curr != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 51630, 51656)
        , curr = f_10261_51637_51656(curr), DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 51559, 52105))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 51559, 52105);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 51698, 51756);

                            var
                            sourceNamedTypeSymbol = curr as SourceNamedTypeSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 51778, 52086) || true) && ((object)sourceNamedTypeSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10261, 51782, 51874) && f_10261_51823_51874(sourceNamedTypeSymbol)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 51778, 52086);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 51924, 52031);

                                f_10261_51924_52030(diagnostics, ErrorCode.ERR_SecurityCriticalOrSecuritySafeCriticalOnAsyncInClassOrStruct, errorLocation);
                                DynAbs.Tracing.TraceSender.TraceBreak(10261, 52057, 52063);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 51778, 52086);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10261, 1, 547);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10261, 1, 547);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 52125, 52350) || true) && ((f_10261_52130_52159(this) & System.Reflection.MethodImplAttributes.Synchronized) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 52125, 52350);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 52261, 52331);

                        f_10261_52261_52330(diagnostics, ErrorCode.ERR_SynchronizedAsyncMethod, errorLocation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 52125, 52350);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 52370, 52525) || true) && (!f_10261_52375_52409(diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 52370, 52525);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 52451, 52506);

                        f_10261_52451_52505(this, diagnostics, errorLocation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 52370, 52525);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 52545, 52671);

                    var
                    iAsyncEnumerableType = f_10261_52572_52670(f_10261_52572_52592(), WellKnownType.System_Collections_Generic_IAsyncEnumerable_T)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 52689, 54065) || true) && (f_10261_52693_52751(f_10261_52693_52722(f_10261_52693_52703()), iAsyncEnumerableType) && (DynAbs.Tracing.TraceSender.Expression_True(10261, 52693, 52809) && f_10261_52776_52799(this) is object))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 52689, 54065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 52851, 52967);

                        var
                        cancellationTokenType = f_10261_52879_52966(f_10261_52879_52899(), WellKnownType.System_Threading_CancellationToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 52989, 53103);

                        var
                        enumeratorCancellationCount = f_10261_53023_53033().Count(p => p.IsSourceParameterWithEnumeratorCancellationAttribute())
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 53125, 53726) || true) && (enumeratorCancellationCount == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10261, 53129, 53266) && f_10261_53190_53219().Any(p => p.Type.Equals(cancellationTokenType))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 53125, 53726);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 53613, 53703);

                            f_10261_53613_53702(                        // Warn for CancellationToken parameters in async-iterators with no parameter decorated with [EnumeratorCancellation]
                                                                        // There could be more than one parameter that could be decorated with [EnumeratorCancellation] so we warn on the method instead
                                                    diagnostics, ErrorCode.WRN_UndecoratedCancellationTokenParameter, errorLocation, this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 53125, 53726);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 53750, 54046) || true) && (enumeratorCancellationCount > 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 53750, 54046);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 53936, 54023);

                            f_10261_53936_54022(                        // The [EnumeratorCancellation] attribute can only be used on one parameter
                                                    diagnostics, ErrorCode.ERR_MultipleEnumeratorCancellationAttributes, errorLocation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 53750, 54046);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 52689, 54065);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 50662, 54080);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 50578, 54091);

                bool
                f_10261_50666_50673()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 50666, 50673);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10261_50727_50741(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 50727, 50741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10261_50769_50781(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 50769, 50781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10261_50862_50877(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 50862, 50877);
                    return return_v;
                }


                System.Exception
                f_10261_51174_51220(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 51174, 51220);
                    return return_v;
                }


                int
                f_10261_51268_51316(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                returnTypeSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportBadRefToken(returnTypeSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 51268, 51316);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10261_51363_51373()
                {
                    var return_v = ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 51363, 51373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10261_51391_51416(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 51391, 51416);
                    return return_v;
                }


                bool
                f_10261_51363_51417(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                declaringCompilation)
                {
                    var return_v = returnType.IsBadAsyncReturn(declaringCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 51363, 51417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_51459_51519(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 51459, 51519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_51587_51606(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 51587, 51606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_51637_51656(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 51637, 51656);
                    return return_v;
                }


                bool
                f_10261_51823_51874(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.HasSecurityCriticalAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 51823, 51874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_51924_52030(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 51924, 52030);
                    return return_v;
                }


                System.Reflection.MethodImplAttributes
                f_10261_52130_52159(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.ImplementationAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 52130, 52159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_52261_52330(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 52261, 52330);
                    return return_v;
                }


                bool
                f_10261_52375_52409(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyResolvedErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 52375, 52409);
                    return return_v;
                }


                int
                f_10261_52451_52505(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.ReportAsyncParameterErrors(diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 52451, 52505);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10261_52572_52592()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 52572, 52592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_52572_52670(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 52572, 52670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10261_52693_52703()
                {
                    var return_v = ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 52693, 52703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10261_52693_52722(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 52693, 52722);
                    return return_v;
                }


                bool
                f_10261_52693_52751(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 52693, 52751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10261_52776_52799(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetInMethodSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 52776, 52799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10261_52879_52899()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 52879, 52899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_52879_52966(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 52879, 52966);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10261_53023_53033()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 53023, 53033);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10261_53190_53219()
                {
                    var return_v = ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 53190, 53219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_53613_53702(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 53613, 53702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10261_53936_54022(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 53936, 54022);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 50578, 54091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 50578, 54091);
            }
        }

        private static FlowAnalysisAnnotations DecodeReturnTypeAnnotationAttributes(ReturnTypeWellKnownAttributeData attributeData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10261, 54103, 54762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 54251, 54318);

                FlowAnalysisAnnotations
                annotations = FlowAnalysisAnnotations.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 54332, 54718) || true) && (attributeData != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 54332, 54718);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 54391, 54540) || true) && (f_10261_54395_54430(attributeData))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 54391, 54540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 54472, 54521);

                        annotations |= FlowAnalysisAnnotations.MaybeNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 54391, 54540);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 54558, 54703) || true) && (f_10261_54562_54595(attributeData))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 54558, 54703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 54637, 54684);

                        annotations |= FlowAnalysisAnnotations.NotNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 54558, 54703);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 54332, 54718);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 54732, 54751);

                return annotations;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10261, 54103, 54762);

                bool
                f_10261_54395_54430(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasMaybeNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 54395, 54430);
                    return return_v;
                }


                bool
                f_10261_54562_54595(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasNotNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 54562, 54595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 54103, 54762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 54103, 54762);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool HidesBaseMethodsByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 54849, 54913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 54885, 54898);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 54849, 54913);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 54774, 54924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 54774, 54924);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasRuntimeSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 55012, 55129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 55048, 55114);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.HasRuntimeSpecialName, 10261, 55055, 55081) || (DynAbs.Tracing.TraceSender.Expression_False(10261, 55055, 55113) || f_10261_55085_55113(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 55012, 55129);

                    bool
                    f_10261_55085_55113(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.IsVtableGapInterfaceMethod();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 55085, 55113);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 54936, 55140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 54936, 55140);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsVtableGapInterfaceMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 55152, 55348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 55218, 55337);

                return f_10261_55225_55256(f_10261_55225_55244(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10261, 55225, 55336) && f_10261_55280_55332(f_10261_55314_55331(this)) > 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 55152, 55348);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10261_55225_55244(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 55225, 55244);
                    return return_v;
                }


                bool
                f_10261_55225_55256(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 55225, 55256);
                    return return_v;
                }


                string
                f_10261_55314_55331(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 55314, 55331);
                    return return_v;
                }


                int
                f_10261_55280_55332(string
                emittedMethodName)
                {
                    var return_v = ModuleExtensions.GetVTableGapSize(emittedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 55280, 55332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 55152, 55348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 55152, 55348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 55422, 56244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 55458, 55968);

                    switch (f_10261_55466_55481(this))
                    {

                        case MethodKind.Constructor:
                        case MethodKind.StaticConstructor:
                        case MethodKind.PropertyGet:
                        case MethodKind.PropertySet:
                        case MethodKind.EventAdd:
                        case MethodKind.EventRemove:
                        case MethodKind.UserDefinedOperator:
                        case MethodKind.Conversion:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 55458, 55968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 55937, 55949);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 55458, 55968);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 55988, 56093) || true) && (f_10261_55992_56020(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 55988, 56093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 56062, 56074);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 55988, 56093);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 56113, 56159);

                    var
                    data = f_10261_56124_56158(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 56177, 56229);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10261, 56184, 56228) && f_10261_56200_56228(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 55422, 56244);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10261_55466_55481(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 55466, 55481);
                        return return_v;
                    }


                    bool
                    f_10261_55992_56020(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.IsVtableGapInterfaceMethod();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 55992, 56020);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    f_10261_56124_56158(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 56124, 56158);
                        return return_v;
                    }


                    bool
                    f_10261_56200_56228(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasSpecialNameAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 56200, 56228);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 55360, 56255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 55360, 56255);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsDirectlyExcludedFromCodeCoverage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 56332, 56427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 56348, 56427);
                    return f_10261_56348_56419_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10261_56348_56382(this), 10261, 56348, 56419)?.HasExcludeFromCodeCoverageAttribute) == true; DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 56332, 56427);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 56332, 56427);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 56332, 56427);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 56510, 56687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 56546, 56592);

                    var
                    data = f_10261_56557_56591(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 56610, 56672);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10261, 56617, 56671) && f_10261_56633_56671(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 56510, 56687);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    f_10261_56557_56591(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 56557, 56591);
                        return return_v;
                    }


                    bool
                    f_10261_56633_56671(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasDynamicSecurityMethodAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 56633, 56671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 56440, 56698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 56440, 56698);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 56780, 56951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 56816, 56867);

                    var
                    data = f_10261_56827_56866(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 56885, 56936);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10261, 56892, 56935) && f_10261_56908_56935(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 56780, 56951);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    f_10261_56827_56866(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 56827, 56866);
                        return return_v;
                    }


                    bool
                    f_10261_56908_56935(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasDeclarativeSecurity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 56908, 56935);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 56710, 56962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 56710, 56962);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 56974, 57665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 57076, 57120);

                var
                attributesBag = f_10261_57096_57119(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 57134, 57228);

                var
                wellKnownData = (MethodWellKnownAttributeData)f_10261_57184_57227(attributesBag)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 57242, 57567) || true) && (wellKnownData != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 57242, 57567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 57301, 57381);

                    SecurityWellKnownAttributeData
                    securityData = f_10261_57347_57380(wellKnownData)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 57399, 57552) || true) && (securityData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 57399, 57552);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 57465, 57533);

                        return f_10261_57472_57532(securityData, f_10261_57507_57531(attributesBag));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 57399, 57552);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 57242, 57567);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 57583, 57654);

                return f_10261_57590_57653();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 56974, 57665);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_57096_57119(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 57096, 57119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10261_57184_57227(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 57184, 57227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SecurityWellKnownAttributeData
                f_10261_57347_57380(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.SecurityInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 57347, 57380);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10261_57507_57531(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 57507, 57531);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10261_57472_57532(Microsoft.CodeAnalysis.SecurityWellKnownAttributeData
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                customAttributes)
                {
                    var return_v = this_param.GetSecurityAttributes<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 57472, 57532);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10261_57590_57653()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Cci.SecurityAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 57590, 57653);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 56974, 57665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 56974, 57665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 57677, 57888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 57750, 57801);

                var
                data = f_10261_57761_57800(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 57815, 57877);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 57822, 57834) || ((data != null && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 57837, 57869)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 57872, 57876))) ? f_10261_57837_57869(data) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 57677, 57888);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                f_10261_57761_57800(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                this_param)
                {
                    var return_v = this_param.GetDecodedWellKnownAttributeData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 57761, 57800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DllImportData
                f_10261_57837_57869(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.DllImportPlatformInvokeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 57837, 57869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 57677, 57888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 57677, 57888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 58009, 58196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 58045, 58106);

                    var
                    data = f_10261_58056_58105(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 58124, 58181);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 58131, 58143) || ((data != null && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 58146, 58173)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 58176, 58180))) ? f_10261_58146_58173(data) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 58009, 58196);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                    f_10261_58056_58105(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.GetDecodedReturnTypeWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 58056, 58105);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10261_58146_58173(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 58146, 58173);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 57900, 58207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 57900, 58207);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10261, 58325, 58971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 58361, 58407);

                    var
                    data = f_10261_58372_58406(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 58425, 58531);

                    var
                    result = (DynAbs.Tracing.TraceSender.Conditional_F1(10261, 58438, 58452) || (((data != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10261, 58455, 58480)) || DynAbs.Tracing.TraceSender.Conditional_F3(10261, 58483, 58530))) ? f_10261_58455_58480(data) : default(System.Reflection.MethodImplAttributes)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 58551, 58922) || true) && (f_10261_58555_58586(f_10261_58555_58574(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10261, 58555, 58631) && f_10261_58590_58605(this) == MethodKind.Constructor))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10261, 58551, 58922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 58790, 58903);

                        result |= (System.Reflection.MethodImplAttributes.Runtime | System.Reflection.MethodImplAttributes.InternalCall);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10261, 58551, 58922);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10261, 58942, 58956);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10261, 58325, 58971);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    f_10261_58372_58406(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 58372, 58406);
                        return return_v;
                    }


                    System.Reflection.MethodImplAttributes
                    f_10261_58455_58480(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.MethodImplAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 58455, 58480);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10261_58555_58574(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 58555, 58574);
                        return return_v;
                    }


                    bool
                    f_10261_58555_58586(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsComImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 58555, 58586);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10261_58590_58605(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 58590, 58605);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10261, 58219, 58982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 58219, 58982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SourceMethodSymbolWithAttributes()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10261, 772, 58989);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10261, 772, 58989);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10261, 772, 58989);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10261, 772, 58989);

        Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
        f_10261_4044_4088(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
        this_param)
        {
            var return_v = this_param.GetDecodedReturnTypeWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 4044, 4088);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        f_10261_4007_4089(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
        attributeData)
        {
            var return_v = DecodeReturnTypeAnnotationAttributes(attributeData);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 4007, 4089);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData?
        f_10261_4191_4235(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
        this_param)
        {
            var return_v = this_param?.GetDecodedReturnTypeWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 4191, 4235);
            return return_v;
        }


        System.Collections.Immutable.ImmutableHashSet<string>?
        f_10261_4191_4262_M(System.Collections.Immutable.ImmutableHashSet<string>?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 4191, 4262);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData?
        f_10261_26926_26960(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 26926, 26960);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<string>?
        f_10261_26926_26976_M(System.Collections.Immutable.ImmutableArray<string>?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 26926, 26976);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData?
        f_10261_27101_27135(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 27101, 27135);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<string>?
        f_10261_27101_27159_M(System.Collections.Immutable.ImmutableArray<string>?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 27101, 27159);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData?
        f_10261_27285_27319(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 27285, 27319);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<string>?
        f_10261_27285_27344_M(System.Collections.Immutable.ImmutableArray<string>?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 27285, 27344);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData?
        f_10261_56348_56382(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbolWithAttributes
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10261, 56348, 56382);
            return return_v;
        }


        bool?
        f_10261_56348_56419_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10261, 56348, 56419);
            return return_v;
        }

    }
}
