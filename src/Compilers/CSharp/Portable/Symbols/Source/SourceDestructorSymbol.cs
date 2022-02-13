// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SourceDestructorSymbol : SourceMemberMethodSymbol
    {
        private TypeWithAnnotations _lazyReturnType;

        private readonly bool _isExpressionBodied;

        internal SourceDestructorSymbol(
                    SourceMemberContainerTypeSymbol containingType,
                    DestructorDeclarationSyntax syntax,
                    bool isNullableAnalysisEnabled,
                    DiagnosticBag diagnostics) : base(f_10246_865_879_C(containingType), f_10246_881_902(syntax), syntax.Identifier.GetLocation(), isIterator: f_10246_949_992(f_10246_980_991(syntax)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10246, 617, 2771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 585, 604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 1018, 1070);

                const MethodKind
                methodKind = MethodKind.Destructor
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 1084, 1122);

                Location
                location = f_10246_1104_1118(this)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 1138, 1158);

                bool
                modifierErrors
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 1172, 1274);

                var
                declarationModifiers = f_10246_1199_1273(this, f_10246_1213_1229(syntax), location, diagnostics, out modifierErrors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 1288, 1436);

                f_10246_1288_1435(this, methodKind, declarationModifiers, returnsVoid: true, isExtensionMethod: false, isNullableAnalysisEnabled: isNullableAnalysisEnabled);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 1452, 1637) || true) && (syntax.Identifier.ValueText != f_10246_1487_1506(containingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10246, 1452, 1637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 1540, 1622);

                    f_10246_1540_1621(diagnostics, ErrorCode.ERR_BadDestructorName, syntax.Identifier.GetLocation());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10246, 1452, 1637);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 1653, 1693);

                bool
                hasBlockBody = f_10246_1673_1684(syntax) != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 1707, 1776);

                _isExpressionBodied = !hasBlockBody && (DynAbs.Tracing.TraceSender.Expression_True(10246, 1729, 1775) && f_10246_1746_1767(syntax) != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 1792, 2014) || true) && (hasBlockBody || (DynAbs.Tracing.TraceSender.Expression_False(10246, 1796, 1831) || _isExpressionBodied))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10246, 1792, 2014);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 1865, 1999) || true) && (f_10246_1869_1877())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10246, 1865, 1999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 1919, 1980);

                        f_10246_1919_1979(diagnostics, ErrorCode.ERR_ExternHasBody, location, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10246, 1865, 1999);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10246, 1792, 2014);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 2030, 2219) || true) && (!modifierErrors && (DynAbs.Tracing.TraceSender.Expression_True(10246, 2034, 2066) && !hasBlockBody) && (DynAbs.Tracing.TraceSender.Expression_True(10246, 2034, 2090) && !_isExpressionBodied) && (DynAbs.Tracing.TraceSender.Expression_True(10246, 2034, 2103) && f_10246_2094_2103_M(!IsExtern)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10246, 2030, 2219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 2137, 2204);

                    f_10246_2137_2203(diagnostics, ErrorCode.ERR_ConcreteMissingBody, location, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10246, 2030, 2219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 2235, 2292);

                f_10246_2235_2291(f_10246_2248_2268(syntax).Parameters.Count == 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 2308, 2638) || true) && (f_10246_2312_2335(containingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10246, 2308, 2638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 2369, 2440);

                    f_10246_2369_2439(diagnostics, ErrorCode.ERR_DestructorInStaticClass, location, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10246, 2308, 2638);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10246, 2308, 2638);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 2474, 2638) || true) && (f_10246_2478_2509_M(!containingType.IsReferenceType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10246, 2474, 2638);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 2543, 2623);

                        f_10246_2543_2622(diagnostics, ErrorCode.ERR_OnlyClassesCanContainDestructors, location, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10246, 2474, 2638);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10246, 2308, 2638);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 2654, 2760);

                f_10246_2654_2759(f_10246_2703_2714(syntax), f_10246_2716_2737(syntax), syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10246, 617, 2771);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 617, 2771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 617, 2771);
            }
        }

        protected override void MethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 2783, 3176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 2871, 2896);

                var
                syntax = f_10246_2884_2895(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 2910, 3033);

                var
                bodyBinder = f_10246_2927_3032(f_10246_2927_3000(f_10246_2927_2952(this), f_10246_2970_2999(syntaxReferenceOpt)), syntax, syntax, this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 3047, 3165);

                _lazyReturnType = TypeWithAnnotations.Create(f_10246_3092_3163(bodyBinder, SpecialType.System_Void, diagnostics, syntax));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 2783, 3176);

                Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                f_10246_2884_2895(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDestructorSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 2884, 2895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10246_2927_2952(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDestructorSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 2927, 2952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10246_2970_2999(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 2970, 2999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10246_2927_3000(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 2927, 3000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10246_2927_3032(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                memberDeclarationOpt, Microsoft.CodeAnalysis.CSharp.Symbols.SourceDestructorSymbol
                memberOpt)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)memberDeclarationOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)memberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 2927, 3032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10246_3092_3163(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 3092, 3163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 2783, 3176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 2783, 3176);
            }
        }

        internal DestructorDeclarationSyntax GetSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 3188, 3394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 3261, 3302);

                f_10246_3261_3301(syntaxReferenceOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 3316, 3383);

                return (DestructorDeclarationSyntax)f_10246_3352_3382(syntaxReferenceOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 3188, 3394);

                int
                f_10246_3261_3301(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 3261, 3301);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10246_3352_3382(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 3352, 3382);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 3188, 3394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 3188, 3394);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 3460, 3481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 3466, 3479);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 3460, 3481);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 3406, 3492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 3406, 3492);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 3565, 3582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 3571, 3580);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 3565, 3582);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 3504, 3593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 3504, 3593);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 3688, 3741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 3694, 3739);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 3688, 3741);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 3605, 3752);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 3605, 3752);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 3855, 3912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 3861, 3910);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 3855, 3912);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 3764, 3923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 3764, 3923);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 4050, 4110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 4053, 4110);
                return ImmutableArray<ImmutableArray<TypeWithAnnotations>>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 4050, 4110);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 4050, 4110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 4050, 4110);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 4230, 4282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 4233, 4282);
                return ImmutableArray<TypeParameterConstraintKind>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 4230, 4282);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 4230, 4282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 4230, 4282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 4351, 4379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 4357, 4377);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 4351, 4379);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 4295, 4390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 4295, 4390);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 4488, 4599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 4524, 4543);

                    f_10246_4524_4542(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 4561, 4584);

                    return _lazyReturnType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 4488, 4599);

                    int
                    f_10246_4524_4542(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDestructorSymbol
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 4524, 4542);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 4402, 4610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 4402, 4610);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private DeclarationModifiers MakeModifiers(SyntaxTokenList modifiers, Location location, DiagnosticBag diagnostics, out bool modifierErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 4622, 5380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 4846, 4950);

                const DeclarationModifiers
                allowedModifiers = DeclarationModifiers.Extern | DeclarationModifiers.Unsafe
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 4964, 5123);

                var
                mods = f_10246_4975_5122(modifiers, DeclarationModifiers.None, allowedModifiers, location, diagnostics, out modifierErrors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 5139, 5183);

                f_10246_5139_5182(
                            this, mods, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 5199, 5288);

                mods = (mods & ~DeclarationModifiers.AccessibilityMask) | DeclarationModifiers.Protected;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 5357, 5369);

                return mods;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 4622, 5380);

                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10246_4975_5122(Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                defaultAccess, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                allowedModifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                modifierErrors)
                {
                    var return_v = ModifierUtils.MakeAndCheckNontypeMemberModifiers(modifiers, defaultAccess, allowedModifiers, errorLocation, diagnostics, out modifierErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 4975, 5122);
                    return return_v;
                }


                int
                f_10246_5139_5182(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDestructorSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    symbol.CheckUnsafeModifier(modifiers, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 5139, 5182);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 4622, 5380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 4622, 5380);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 5444, 5495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 5450, 5493);

                    return WellKnownMemberNames.DestructorName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 5444, 5495);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 5392, 5506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 5392, 5506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExpressionBodied
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 5584, 5662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 5620, 5647);

                    return _isExpressionBodied;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 5584, 5662);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 5518, 5673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 5518, 5673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 5685, 5927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 5859, 5916);

                return f_10246_5866_5915(f_10246_5883_5914(f_10246_5883_5899(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 5685, 5927);

                Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                f_10246_5883_5899(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDestructorSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 5883, 5899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10246_5883_5914(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 5883, 5914);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10246_5866_5915(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 5866, 5915);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 5685, 5927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 5685, 5927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override OneOrMany<SyntaxList<AttributeListSyntax>> GetReturnTypeAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 5939, 6200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 6123, 6189);

                return f_10246_6130_6188(default(SyntaxList<AttributeListSyntax>));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 5939, 6200);

                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10246_6130_6188(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 6130, 6188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 5939, 6200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 5939, 6200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 6212, 6358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 6335, 6347);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 6212, 6358);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 6212, 6358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 6212, 6358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 6433, 6497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 6469, 6482);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 6433, 6497);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 6370, 6508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 6370, 6508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 6520, 6726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 6643, 6715);

                return (object)f_10246_6658_6706(f_10246_6658_6677(this)) == null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 6520, 6726);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10246_6658_6677(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDestructorSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 6658, 6677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10246_6658_6706(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 6658, 6706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 6520, 6726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 6520, 6726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10246, 6803, 6823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10246, 6809, 6821);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10246, 6803, 6823);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10246, 6738, 6834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 6738, 6834);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SourceDestructorSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10246, 421, 6841);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10246, 421, 6841);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10246, 421, 6841);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10246, 421, 6841);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10246_881_902(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 881, 902);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10246_980_991(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 980, 991);
            return return_v;
        }


        static bool
        f_10246_949_992(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        node)
        {
            var return_v = SyntaxFacts.HasYieldOperations((Microsoft.CodeAnalysis.SyntaxNode?)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 949, 992);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10246_1104_1118(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDestructorSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 1104, 1118);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTokenList
        f_10246_1213_1229(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Modifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 1213, 1229);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10246_1199_1273(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDestructorSymbol
        this_param, Microsoft.CodeAnalysis.SyntaxTokenList
        modifiers, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, out bool
        modifierErrors)
        {
            var return_v = this_param.MakeModifiers(modifiers, location, diagnostics, out modifierErrors);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 1199, 1273);
            return return_v;
        }


        int
        f_10246_1288_1435(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDestructorSymbol
        this_param, Microsoft.CodeAnalysis.MethodKind
        methodKind, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        declarationModifiers, bool
        returnsVoid, bool
        isExtensionMethod, bool
        isNullableAnalysisEnabled)
        {
            this_param.MakeFlags(methodKind, declarationModifiers, returnsVoid: returnsVoid, isExtensionMethod: isExtensionMethod, isNullableAnalysisEnabled: isNullableAnalysisEnabled);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 1288, 1435);
            return 0;
        }


        string
        f_10246_1487_1506(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 1487, 1506);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10246_1540_1621(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 1540, 1621);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10246_1673_1684(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 1673, 1684);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10246_1746_1767(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 1746, 1767);
            return return_v;
        }


        bool
        f_10246_1869_1877()
        {
            var return_v = IsExtern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 1869, 1877);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10246_1919_1979(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 1919, 1979);
            return return_v;
        }


        bool
        f_10246_2094_2103_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 2094, 2103);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10246_2137_2203(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 2137, 2203);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        f_10246_2248_2268(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ParameterList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 2248, 2268);
            return return_v;
        }


        int
        f_10246_2235_2291(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 2235, 2291);
            return 0;
        }


        bool
        f_10246_2312_2335(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsStatic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 2312, 2335);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10246_2369_2439(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 2369, 2439);
            return return_v;
        }


        bool
        f_10246_2478_2509_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 2478, 2509);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10246_2543_2622(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 2543, 2622);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10246_2703_2714(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 2703, 2714);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10246_2716_2737(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10246, 2716, 2737);
            return return_v;
        }


        int
        f_10246_2654_2759(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        block, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        expression, Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
        syntax, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            CheckForBlockAndExpressionBody((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)block, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)expression, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10246, 2654, 2759);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10246_865_879_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10246, 617, 2771);
            return return_v;
        }

    }
}
