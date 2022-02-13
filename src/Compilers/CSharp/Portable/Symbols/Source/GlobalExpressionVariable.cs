// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class GlobalExpressionVariable : SourceMemberFieldSymbol
    {
        private TypeWithAnnotations.Boxed _lazyType;

        private readonly SyntaxReference _typeSyntaxOpt;

        internal GlobalExpressionVariable(
                    SourceMemberContainerTypeSymbol containingType,
                    DeclarationModifiers modifiers,
                    TypeSyntax typeSyntax,
                    string name,
                    SyntaxReference syntax,
                    Location location)
        : base(f_10228_1217_1231_C(containingType), modifiers, name, syntax, location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10228, 925, 1422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 691, 700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 898, 912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 1292, 1353);

                f_10228_1292_1352(f_10228_1305_1326() == Accessibility.Private);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 1367, 1411);

                _typeSyntaxOpt = f_10228_1384_1410_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(typeSyntax, 10228, 1384, 1410)?.GetReference());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10228, 925, 1422);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 925, 1422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 925, 1422);
            }
        }

        internal static GlobalExpressionVariable Create(
                        SourceMemberContainerTypeSymbol containingType,
                        DeclarationModifiers modifiers,
                        TypeSyntax typeSyntax,
                        string name,
                        SyntaxNode syntax,
                        Location location,
                        FieldSymbol containingFieldOpt,
                        SyntaxNode nodeToBind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10228, 1434, 2366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 1852, 1951);

                f_10228_1852_1950(f_10228_1865_1882(nodeToBind) == SyntaxKind.VariableDeclarator || (DynAbs.Tracing.TraceSender.Expression_False(10228, 1865, 1949) || nodeToBind is ExpressionSyntax));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 1967, 2011);

                var
                syntaxReference = f_10228_1989_2010(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 2025, 2355);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10228, 2032, 2072) || (((typeSyntax == null || (DynAbs.Tracing.TraceSender.Expression_False(10228, 2033, 2071) || f_10228_2055_2071(typeSyntax)))
                && DynAbs.Tracing.TraceSender.Conditional_F2(10228, 2092, 2234)) || DynAbs.Tracing.TraceSender.Conditional_F3(10228, 2254, 2354))) ? f_10228_2092_2234(containingType, modifiers, typeSyntax, name, syntaxReference, location, containingFieldOpt, nodeToBind) : f_10228_2254_2354(containingType, modifiers, typeSyntax, name, syntaxReference, location);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10228, 1434, 2366);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10228_1865_1882(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 1865, 1882);
                    return return_v;
                }


                int
                f_10228_1852_1950(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 1852, 1950);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10228_1989_2010(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 1989, 2010);
                    return return_v;
                }


                bool
                f_10228_2055_2071(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.IsVar;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10228, 2055, 2071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable.InferrableGlobalExpressionVariable
                f_10228_2092_2234(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                typeSyntax, string
                name, Microsoft.CodeAnalysis.SyntaxReference
                syntax, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                containingFieldOpt, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable.InferrableGlobalExpressionVariable(containingType, modifiers, typeSyntax, name, syntax, location, containingFieldOpt, nodeToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 2092, 2234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                f_10228_2254_2354(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, string
                name, Microsoft.CodeAnalysis.SyntaxReference
                syntax, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable(containingType, modifiers, typeSyntax, name, syntax, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 2254, 2354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 1434, 2366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 1434, 2366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SyntaxList<AttributeListSyntax> AttributeDeclarationSyntaxList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10228, 2462, 2505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 2465, 2505);
                    return default(SyntaxList<AttributeListSyntax>); DynAbs.Tracing.TraceSender.TraceExitMethod(10228, 2462, 2505);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 2462, 2505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 2462, 2505);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override TypeSyntax TypeSyntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10228, 2557, 2599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 2560, 2599);
                    return (TypeSyntax)f_10228_2572_2599_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_typeSyntaxOpt, 10228, 2572, 2599)?.GetSyntax()); DynAbs.Tracing.TraceSender.TraceExitMethod(10228, 2557, 2599);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 2557, 2599);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 2557, 2599);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override SyntaxTokenList ModifiersTokenList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10228, 2664, 2691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 2667, 2691);
                    return default(SyntaxTokenList); DynAbs.Tracing.TraceSender.TraceExitMethod(10228, 2664, 2691);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 2664, 2691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 2664, 2691);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasInitializer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10228, 2738, 2746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 2741, 2746);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10228, 2738, 2746);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 2738, 2746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 2738, 2746);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ConstantValue MakeConstantValue(
                    HashSet<SourceFieldSymbolWithSyntaxReference> dependencies,
                    bool earlyDecodingWellKnownAttributes,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10228, 2974, 2981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 2977, 2981);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10228, 2974, 2981);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 2974, 2981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 2974, 2981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10228, 2994, 4685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3109, 3148);

                f_10228_3109_3147(fieldsBeingBound != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3164, 3257) || true) && (_lazyType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10228, 3164, 3257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3219, 3242);

                    return _lazyType.Value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10228, 3164, 3257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3273, 3301);

                var
                typeSyntax = f_10228_3290_3300()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3317, 3361);

                var
                compilation = f_10228_3335_3360(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3377, 3423);

                var
                diagnostics = f_10228_3395_3422()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3437, 3462);

                TypeWithAnnotations
                type
                = default(TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3476, 3487);

                bool
                isVar
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3503, 3564);

                var
                binderFactory = f_10228_3523_3563(compilation, f_10228_3552_3562())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3578, 3641);

                var
                binder = f_10228_3591_3640(binderFactory, typeSyntax ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>(10228, 3615, 3639) ?? f_10228_3629_3639()))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3657, 3975) || true) && (typeSyntax != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10228, 3657, 3975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3713, 3784);

                    type = f_10228_3720_3783(binder, typeSyntax, diagnostics, out isVar);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10228, 3657, 3975);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10228, 3657, 3975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3914, 3927);

                    isVar = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3945, 3960);

                    type = default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10228, 3657, 3975);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 3991, 4027);

                f_10228_3991_4026(type.HasType || (DynAbs.Tracing.TraceSender.Expression_False(10228, 4004, 4025) || isVar));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 4043, 4602) || true) && (isVar && (DynAbs.Tracing.TraceSender.Expression_True(10228, 4047, 4097) && !f_10228_4057_4097(fieldsBeingBound, this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10228, 4043, 4602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 4131, 4172);

                    f_10228_4131_4171(this, fieldsBeingBound, binder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 4190, 4222);

                    f_10228_4190_4221(_lazyType != null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10228, 4043, 4602);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10228, 4043, 4602);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 4288, 4527) || true) && (isVar)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10228, 4288, 4527);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 4339, 4421);

                        f_10228_4339_4420(diagnostics, ErrorCode.ERR_RecursivelyTypedVariable, f_10228_4395_4413(this), this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 4443, 4508);

                        type = TypeWithAnnotations.Create(f_10228_4477_4506(binder, "var"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10228, 4288, 4527);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 4547, 4587);

                    f_10228_4547_4586(this, compilation, diagnostics, type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10228, 4043, 4602);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 4618, 4637);

                f_10228_4618_4636(
                            diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 4651, 4674);

                return _lazyType.Value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10228, 2994, 4685);

                int
                f_10228_3109_3147(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 3109, 3147);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10228_3290_3300()
                {
                    var return_v = TypeSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10228, 3290, 3300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10228_3335_3360(Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10228, 3335, 3360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10228_3395_3422()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 3395, 3422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10228_3552_3562()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10228, 3552, 3562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10228_3523_3563(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 3523, 3563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10228_3629_3639()
                {
                    var return_v = SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10228, 3629, 3639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10228_3591_3640(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 3591, 3640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10228_3720_3783(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                isVar)
                {
                    var return_v = this_param.BindTypeOrVarKeyword(syntax, diagnostics, out isVar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 3720, 3783);
                    return return_v;
                }


                int
                f_10228_3991_4026(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 3991, 4026);
                    return 0;
                }


                bool
                f_10228_4057_4097(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 4057, 4097);
                    return return_v;
                }


                int
                f_10228_4131_4171(Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                fieldsBeingBound, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.InferFieldType(fieldsBeingBound, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 4131, 4171);
                    return 0;
                }


                int
                f_10228_4190_4221(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 4190, 4221);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10228_4395_4413(Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                this_param)
                {
                    var return_v = this_param.ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10228, 4395, 4413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10228_4339_4420(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 4339, 4420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10228_4477_4506(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, string
                name)
                {
                    var return_v = this_param.CreateErrorType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 4477, 4506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10228_4547_4586(Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.SetType(compilation, diagnostics, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 4547, 4586);
                    return return_v;
                }


                int
                f_10228_4618_4636(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 4618, 4636);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 2994, 4685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 2994, 4685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWithAnnotations SetType(CSharpCompilation compilation, DiagnosticBag diagnostics, TypeWithAnnotations type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10228, 4937, 5882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 5081, 5129);

                var
                originalType = DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyType, 10228, 5100, 5128)?.Value.DefaultType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 5308, 5498);

                f_10228_5308_5497((object)originalType == null || (DynAbs.Tracing.TraceSender.Expression_False(10228, 5321, 5396) || f_10228_5370_5396(originalType)) || (DynAbs.Tracing.TraceSender.Expression_False(10228, 5321, 5496) || f_10228_5417_5496(originalType, type.Type, TypeCompareKind.ConsiderEverything2)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 5514, 5834) || true) && (f_10228_5518_5603(ref _lazyType, f_10228_5561_5596(type), null) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10228, 5514, 5834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 5645, 5680);

                    f_10228_5645_5679(this, type.Type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 5700, 5757);

                    f_10228_5700_5756(f_10228_5700_5734(compilation), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 5775, 5819);

                    state.NotePartComplete(CompletionPart.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10228, 5514, 5834);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 5848, 5871);

                return _lazyType.Value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10228, 4937, 5882);

                bool
                f_10228_5370_5396(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 5370, 5396);
                    return return_v;
                }


                bool
                f_10228_5417_5496(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 5417, 5496);
                    return return_v;
                }


                int
                f_10228_5308_5497(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 5308, 5497);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                f_10228_5561_5596(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 5561, 5596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                f_10228_5518_5603(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 5518, 5603);
                    return return_v;
                }


                int
                f_10228_5645_5679(Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.TypeChecks(type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 5645, 5679);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10228_5700_5734(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DeclarationDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10228, 5700, 5734);
                    return return_v;
                }


                int
                f_10228_5700_5756(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 5700, 5756);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 4937, 5882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 4937, 5882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeWithAnnotations SetTypeWithAnnotations(TypeWithAnnotations type, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10228, 6133, 6329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 6262, 6318);

                return f_10228_6269_6317(this, f_10228_6277_6297(), diagnostics, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10228, 6133, 6329);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10228_6277_6297()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10228, 6277, 6297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10228_6269_6317(Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.SetType(compilation, diagnostics, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 6269, 6317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 6133, 6329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 6133, 6329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void InferFieldType(ConsList<FieldSymbol> fieldsBeingBound, Binder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10228, 6341, 6506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 6458, 6495);

                throw f_10228_6464_6494();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10228, 6341, 6506);

                System.Exception
                f_10228_6464_6494()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10228, 6464, 6494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 6341, 6506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 6341, 6506);
            }
        }
        private class InferrableGlobalExpressionVariable : GlobalExpressionVariable
        {
            private readonly FieldSymbol _containingFieldOpt;

            private readonly SyntaxReference _nodeToBind;

            internal InferrableGlobalExpressionVariable(
                            SourceMemberContainerTypeSymbol containingType,
                            DeclarationModifiers modifiers,
                            TypeSyntax typeSyntax,
                            string name,
                            SyntaxReference syntax,
                            Location location,
                            FieldSymbol containingFieldOpt,
                            SyntaxNode nodeToBind)
            : base(f_10228_7161_7175_C(containingType), modifiers, typeSyntax, name, syntax, location)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10228, 6742, 7489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 6647, 6666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 6714, 6725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 7256, 7355);

                    f_10228_7256_7354(f_10228_7269_7286(nodeToBind) == SyntaxKind.VariableDeclarator || (DynAbs.Tracing.TraceSender.Expression_False(10228, 7269, 7353) || nodeToBind is ExpressionSyntax));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 7375, 7416);

                    _containingFieldOpt = containingFieldOpt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 7434, 7474);

                    _nodeToBind = f_10228_7448_7473(nodeToBind);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10228, 6742, 7489);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 6742, 7489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 6742, 7489);
                }
            }

            protected override void InferFieldType(ConsList<FieldSymbol> fieldsBeingBound, Binder binder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10228, 7505, 8881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 7631, 7672);

                    var
                    nodeToBind = f_10228_7648_7671(_nodeToBind)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 7692, 7962) || true) && ((object)_containingFieldOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10228, 7696, 7785) && f_10228_7735_7752(nodeToBind) != SyntaxKind.VariableDeclarator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10228, 7692, 7962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 7827, 7943);

                        binder = f_10228_7836_7942(f_10228_7836_7892(binder, _containingFieldOpt), BinderFlags.FieldInitializer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10228, 7692, 7962);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 7982, 8051);

                    fieldsBeingBound = f_10228_8001_8050(this, fieldsBeingBound);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 8071, 8137);

                    binder = f_10228_8080_8136(binder, fieldsBeingBound);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 8155, 8201);

                    var
                    diagnostics = f_10228_8173_8200()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 8221, 8827);

                    switch (f_10228_8229_8246(nodeToBind))
                    {

                        case SyntaxKind.VariableDeclarator:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10228, 8221, 8827);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 8539, 8621);

                            f_10228_8539_8620(                        // This occurs, for example, in
                                                                      // int x, y[out var Z, 1 is int I];
                                                                      // for (int x, y[out var Z, 1 is int I]; ;) {}
                                                    binder, nodeToBind, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceBreak(10228, 8647, 8653);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10228, 8221, 8827);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10228, 8221, 8827);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 8711, 8776);

                            f_10228_8711_8775(binder, nodeToBind, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceBreak(10228, 8802, 8808);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10228, 8221, 8827);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10228, 8847, 8866);

                    f_10228_8847_8865(
                                    diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10228, 7505, 8881);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10228_7648_7671(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 7648, 7671);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10228_7735_7752(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = node.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 7735, 7752);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10228_7836_7892(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    containing)
                    {
                        var return_v = this_param.WithContainingMemberOrLambda((Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 7836, 7892);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10228_7836_7942(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    flags)
                    {
                        var return_v = this_param.WithAdditionalFlags(flags);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 7836, 7942);
                        return return_v;
                    }


                    Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    f_10228_8001_8050(Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable.InferrableGlobalExpressionVariable
                    head, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    tail)
                    {
                        var return_v = new Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)head, tail);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 8001, 8050);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ImplicitlyTypedFieldBinder
                    f_10228_8080_8136(Microsoft.CodeAnalysis.CSharp.Binder
                    next, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    fieldsBeingBound)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.ImplicitlyTypedFieldBinder(next, fieldsBeingBound);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 8080, 8136);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10228_8173_8200()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 8173, 8200);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10228_8229_8246(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = node.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 8229, 8246);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10228_8539_8620(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    declarator, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.BindDeclaratorArguments((Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax)declarator, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 8539, 8620);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10228_8711_8775(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.BindExpression((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)node, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 8711, 8775);
                        return return_v;
                    }


                    int
                    f_10228_8847_8865(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 8847, 8865);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10228, 7505, 8881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 7505, 8881);
                }
            }

            static InferrableGlobalExpressionVariable()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10228, 6518, 8892);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10228, 6518, 8892);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 6518, 8892);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10228, 6518, 8892);

            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10228_7269_7286(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = node.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 7269, 7286);
                return return_v;
            }


            int
            f_10228_7256_7354(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 7256, 7354);
                return 0;
            }


            Microsoft.CodeAnalysis.SyntaxReference
            f_10228_7448_7473(Microsoft.CodeAnalysis.SyntaxNode
            this_param)
            {
                var return_v = this_param.GetReference();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 7448, 7473);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            f_10228_7161_7175_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10228, 6742, 7489);
                return return_v;
            }

        }

        static GlobalExpressionVariable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10228, 575, 8899);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10228, 575, 8899);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10228, 575, 8899);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10228, 575, 8899);

        Microsoft.CodeAnalysis.Accessibility
        f_10228_1305_1326()
        {
            var return_v = DeclaredAccessibility;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10228, 1305, 1326);
            return return_v;
        }


        int
        f_10228_1292_1352(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 1292, 1352);
            return 0;
        }


        Microsoft.CodeAnalysis.SyntaxReference?
        f_10228_1384_1410_I(Microsoft.CodeAnalysis.SyntaxReference?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 1384, 1410);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10228_1217_1231_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10228, 925, 1422);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode?
        f_10228_2572_2599_I(Microsoft.CodeAnalysis.SyntaxNode?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10228, 2572, 2599);
            return return_v;
        }

    }
}
