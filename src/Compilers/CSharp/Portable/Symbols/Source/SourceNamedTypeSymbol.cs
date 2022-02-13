// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class SourceNamedTypeSymbol : SourceMemberContainerTypeSymbol, IAttributeTargetSymbol
    {
        private ImmutableArray<TypeParameterSymbol> _lazyTypeParameters;

        private ImmutableArray<ImmutableArray<TypeWithAnnotations>> _lazyTypeParameterConstraintTypes;

        private ImmutableArray<TypeParameterConstraintKind> _lazyTypeParameterConstraintKinds;

        private CustomAttributesBag<CSharpAttributeData> _lazyCustomAttributesBag;

        private string _lazyDocComment;

        private string _lazyExpandedDocComment;

        private ThreeState _lazyIsExplicitDefinitionOfNoPiaLocalType;

        protected override Location GetCorrespondingBaseListLocation(NamedTypeSymbol @base)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 1886, 3504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 1994, 2025);

                Location
                backupLocation = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 2039, 2091);

                var
                unusedDiagnostics = f_10072_2063_2090()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 2107, 3418);
                    foreach (SyntaxReference part in f_10072_2140_2156_I(f_10072_2140_2156()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 2107, 3418);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 2190, 2264);

                        TypeDeclarationSyntax
                        typeBlock = (TypeDeclarationSyntax)f_10072_2247_2263(part)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 2282, 2324);

                        BaseListSyntax
                        bases = f_10072_2305_2323(typeBlock)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 2342, 2429) || true) && (bases == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 2342, 2429);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 2401, 2410);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 2342, 2429);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 2447, 2516);

                        SeparatedSyntaxList<BaseTypeSyntax>
                        inheritedTypeDecls = f_10072_2504_2515(bases)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 2536, 2596);

                        var
                        baseBinder = f_10072_2553_2595(f_10072_2553_2578(this), bases)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 2614, 2729);

                        baseBinder = f_10072_2627_2728(baseBinder, BinderFlags.SuppressConstraintChecks, this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 2749, 2902) || true) && ((object)backupLocation == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 2749, 2902);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 2825, 2883);

                            backupLocation = f_10072_2842_2882(f_10072_2842_2868(inheritedTypeDecls[0]));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 2749, 2902);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 2922, 3403);
                            foreach (BaseTypeSyntax baseTypeSyntax in f_10072_2964_2982_I(inheritedTypeDecls))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 2922, 3403);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 3024, 3059);

                                TypeSyntax
                                t = f_10072_3039_3058(baseTypeSyntax)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 3081, 3144);

                                TypeSymbol
                                bt = f_10072_3097_3138(baseBinder, t, unusedDiagnostics).Type
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 3168, 3384) || true) && (f_10072_3172_3237(bt, @base, TypeCompareKind.ConsiderEverything2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 3168, 3384);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 3287, 3312);

                                    f_10072_3287_3311(unusedDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 3338, 3361);

                                    return f_10072_3345_3360(t);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 3168, 3384);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 2922, 3403);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 482);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 482);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 2107, 3418);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 1312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 1312);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 3432, 3457);

                f_10072_3432_3456(unusedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 3471, 3493);

                return backupLocation;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 1886, 3504);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10072_2063_2090()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 2063, 2090);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10072_2140_2156()
                {
                    var return_v = SyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 2140, 2156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10072_2247_2263(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 2247, 2263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax?
                f_10072_2305_2323(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.BaseList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 2305, 2323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax>
                f_10072_2504_2515(Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                this_param)
                {
                    var return_v = this_param.Types;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 2504, 2515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10072_2553_2578(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 2553, 2578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10072_2553_2595(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                syntax)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 2553, 2595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10072_2627_2728(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                containing)
                {
                    var return_v = this_param.WithAdditionalFlagsAndContainingMemberOrLambda(flags, (Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 2627, 2728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10072_2842_2868(Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 2842, 2868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10072_2842_2882(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 2842, 2882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10072_3039_3058(Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 3039, 3058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10072_3097_3138(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 3097, 3138);
                    return return_v;
                }


                bool
                f_10072_3172_3237(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 3172, 3237);
                    return return_v;
                }


                int
                f_10072_3287_3311(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 3287, 3311);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10072_3345_3360(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 3345, 3360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax>
                f_10072_2964_2982_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 2964, 2982);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10072_2140_2156_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 2140, 2156);
                    return return_v;
                }


                int
                f_10072_3432_3456(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 3432, 3456);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 1886, 3504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 1886, 3504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SourceNamedTypeSymbol(NamespaceOrTypeSymbol containingSymbol, MergedTypeDeclaration declaration, DiagnosticBag diagnostics, TupleExtraData tupleData = null)
        : base(f_10072_3702_3718_C(containingSymbol), declaration, diagnostics, tupleData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10072, 3516, 4500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 1663, 1687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 1715, 1730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 1756, 1779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 1811, 1873);
                this._lazyIsExplicitDefinitionOfNoPiaLocalType = ThreeState.Unknown; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 811, 829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 866, 915);
                this._lazyBaseType = ErrorTypeSymbol.UnknownResultType; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 567, 586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 621, 680);
                this._lazyEnumUnderlyingType = ErrorTypeSymbol.UnknownResultType; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 3781, 4262);

                switch (f_10072_3789_3805(declaration))
                {

                    case DeclarationKind.Struct:
                    case DeclarationKind.Interface:
                    case DeclarationKind.Enum:
                    case DeclarationKind.Delegate:
                    case DeclarationKind.Class:
                    case DeclarationKind.Record:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 3781, 4262);
                        DynAbs.Tracing.TraceSender.TraceBreak(10072, 4121, 4127);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 3781, 4262);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 3781, 4262);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 4175, 4219);

                        f_10072_4175_4218(false, "bad declaration kind");
                        DynAbs.Tracing.TraceSender.TraceBreak(10072, 4241, 4247);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 3781, 4262);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 4278, 4489) || true) && (f_10072_4282_4303(containingSymbol) == SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 4278, 4489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 4413, 4474);

                    _lazyIsExplicitDefinitionOfNoPiaLocalType = ThreeState.False;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 4278, 4489);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10072, 3516, 4500);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 3516, 4500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 3516, 4500);
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 4512, 4716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 4613, 4705);

                return f_10072_4620_4704(f_10072_4646_4660(), declaration, f_10072_4675_4694(), newData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 4512, 4716);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10072_4646_4660()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 4646, 4660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10072_4675_4694()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 4675, 4694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                f_10072_4620_4704(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                containingSymbol, Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                declaration, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                tupleData)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?)containingSymbol, declaration, diagnostics, tupleData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 4620, 4704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 4512, 4716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 4512, 4716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxToken GetName(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10072, 4754, 5505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 4836, 5494);

                switch (f_10072_4844_4855(node))
                {

                    case SyntaxKind.EnumDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 4836, 5494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 4943, 4991);

                        return f_10072_4950_4990(((EnumDeclarationSyntax)node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 4836, 5494);

                    case SyntaxKind.DelegateDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 4836, 5494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 5067, 5119);

                        return f_10072_5074_5118(((DelegateDeclarationSyntax)node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 4836, 5494);

                    case SyntaxKind.ClassDeclaration:
                    case SyntaxKind.InterfaceDeclaration:
                    case SyntaxKind.StructDeclaration:
                    case SyntaxKind.RecordDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 4836, 5494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 5351, 5403);

                        return f_10072_5358_5402(((BaseTypeDeclarationSyntax)node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 4836, 5494);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 4836, 5494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 5451, 5479);

                        return default(SyntaxToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 4836, 5494);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10072, 4754, 5505);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10072_4844_4855(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 4844, 4855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10072_4950_4990(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 4950, 4990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10072_5074_5118(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 5074, 5118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10072_5358_5402(Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 5358, 5402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 4754, 5505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 4754, 5505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 5517, 5957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 5723, 5819);

                ref var
                lazyDocComment = ref (DynAbs.Tracing.TraceSender.Conditional_F1(10072, 5752, 5766) || ((expandIncludes && DynAbs.Tracing.TraceSender.Conditional_F2(10072, 5769, 5796)) || DynAbs.Tracing.TraceSender.Conditional_F3(10072, 5799, 5818))) ? ref _lazyExpandedDocComment : ref _lazyDocComment
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 5833, 5946);

                return f_10072_5840_5945(this, expandIncludes, ref lazyDocComment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 5517, 5957);

                string
                f_10072_5840_5945(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                symbol, bool
                expandIncludes, ref string
                lazyXmlText)
                {
                    var return_v = SourceDocumentationCommentUtils.GetAndCacheDocumentationComment((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, expandIncludes, ref lazyXmlText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 5840, 5945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 5517, 5957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 5517, 5957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeParameterSymbol> MakeTypeParameters(DiagnosticBag diagnostics)
        {
            if (declaration.Arity == 0)
            {
                return ImmutableArray<TypeParameterSymbol>.Empty;
            }

            var typeParameterMismatchReported = false;
            var typeParameterNames = new string[declaration.Arity];
            var typeParameterVarianceKeywords = new string[declaration.Arity];
            var parameterBuilders1 = new List<List<TypeParameterBuilder>>();

            foreach (var syntaxRef in this.SyntaxReferences)
            {
                var typeDecl = (CSharpSyntaxNode)syntaxRef.GetSyntax();
                var syntaxTree = syntaxRef.SyntaxTree;

                TypeParameterListSyntax tpl;
                SyntaxKind typeKind = typeDecl.Kind();
                switch (typeKind)
                {
                    case SyntaxKind.ClassDeclaration:
                    case SyntaxKind.StructDeclaration:
                    case SyntaxKind.InterfaceDeclaration:
                    case SyntaxKind.RecordDeclaration:
                        tpl = ((TypeDeclarationSyntax)typeDecl).TypeParameterList;
                        break;

                    case SyntaxKind.DelegateDeclaration:
                        tpl = ((DelegateDeclarationSyntax)typeDecl).TypeParameterList;
                        break;

                    case SyntaxKind.EnumDeclaration:
                    default:
                        // there is no such thing as a generic enum, so code should never reach here.
                        throw ExceptionUtilities.UnexpectedValue(typeDecl.Kind());
                }

                bool isInterfaceOrDelegate = typeKind == SyntaxKind.InterfaceDeclaration || typeKind == SyntaxKind.DelegateDeclaration;
                var parameterBuilder = new List<TypeParameterBuilder>();
                parameterBuilders1.Add(parameterBuilder);
                int i = 0;
                foreach (var tp in tpl.Parameters)
                {
                    if (tp.VarianceKeyword.Kind() != SyntaxKind.None &&
                        !isInterfaceOrDelegate)
                    {
                        diagnostics.Add(ErrorCode.ERR_IllegalVarianceSyntax, tp.VarianceKeyword.GetLocation());
                    }

                    var name = typeParameterNames[i];
                    var location = new SourceLocation(tp.Identifier);
                    var varianceKind = typeParameterVarianceKeywords[i];

                    ReportTypeNamedRecord(tp.Identifier.Text, this.DeclaringCompilation, diagnostics, location);

                    if (name == null)
                    {
                        name = typeParameterNames[i] = tp.Identifier.ValueText;
                        varianceKind = typeParameterVarianceKeywords[i] = tp.VarianceKeyword.ValueText;
                        for (int j = 0; j < i; j++)
                        {
                            if (name == typeParameterNames[j])
                            {
                                typeParameterMismatchReported = true;
                                diagnostics.Add(ErrorCode.ERR_DuplicateTypeParameter, location, name);
                                goto next;
                            }
                        }

                        if (!ReferenceEquals(ContainingType, null))
                        {
                            var tpEnclosing = ContainingType.FindEnclosingTypeParameter(name);
                            if ((object)tpEnclosing != null)
                            {
                                // Type parameter '{0}' has the same name as the type parameter from outer type '{1}'
                                diagnostics.Add(ErrorCode.WRN_TypeParameterSameAsOuterTypeParameter, location, name, tpEnclosing.ContainingType);
                            }
                        }
next:;
                    }
                    else if (!typeParameterMismatchReported)
                    {
                        // Note: the "this", below, refers to the name of the current class, which includes its type
                        // parameter names.  But the type parameter names have not been computed yet.  Therefore, we
                        // take advantage of the fact that "this" won't undergo "ToString()" until later, when the
                        // diagnostic is printed, by which time the type parameters field will have been filled in.
                        if (varianceKind != tp.VarianceKeyword.ValueText)
                        {
                            // Dev10 reports CS1067, even if names also don't match
                            typeParameterMismatchReported = true;
                            diagnostics.Add(
                                ErrorCode.ERR_PartialWrongTypeParamsVariance,
                                declaration.NameLocations.First(),
                                this); // see comment above
                        }
                        else if (name != tp.Identifier.ValueText)
                        {
                            typeParameterMismatchReported = true;
                            diagnostics.Add(
                                ErrorCode.ERR_PartialWrongTypeParams,
                                declaration.NameLocations.First(),
                                this); // see comment above
                        }
                    }
                    parameterBuilder.Add(new TypeParameterBuilder(syntaxTree.GetReference(tp), this, location));
                    i++;
                }
            }

            var parameterBuilders2 = parameterBuilders1.Transpose(); // type arguments are positional
            var parameters = parameterBuilders2.Select((builders, i) => builders[0].MakeSymbol(i, builders, diagnostics));
            return parameters.AsImmutable();
        }

        internal ImmutableArray<TypeWithAnnotations> GetTypeParameterConstraintTypes(int ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 12180, 12482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 12294, 12350);

                var
                constraintTypes = f_10072_12316_12349(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 12364, 12471);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10072, 12371, 12399) || (((constraintTypes.Length > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10072, 12402, 12426)) || DynAbs.Tracing.TraceSender.Conditional_F3(10072, 12429, 12470))) ? constraintTypes[ordinal] : ImmutableArray<TypeWithAnnotations>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 12180, 12482);

                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>>
                f_10072_12316_12349(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeParameterConstraintTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 12316, 12349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 12180, 12482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 12180, 12482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 12494, 13272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 12612, 12668);

                var
                constraintTypes = _lazyTypeParameterConstraintTypes
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 12682, 13222) || true) && (constraintTypes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 12682, 13222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 12745, 12779);

                    f_10072_12745_12778(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 12799, 12845);

                    var
                    diagnostics = f_10072_12817_12844()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 12863, 13100) || true) && (f_10072_12867_12995(ref _lazyTypeParameterConstraintTypes, f_10072_12949_12994(this, diagnostics)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 12863, 13100);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 13037, 13081);

                        f_10072_13037_13080(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 12863, 13100);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 13118, 13137);

                    f_10072_13118_13136(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 13155, 13207);

                    constraintTypes = _lazyTypeParameterConstraintTypes;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 12682, 13222);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 13238, 13261);

                return constraintTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 12494, 13272);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                f_10072_12745_12778(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeParameterConstraintKinds();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 12745, 12778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10072_12817_12844()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 12817, 12844);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>>
                f_10072_12949_12994(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeTypeParameterConstraintTypes(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 12949, 12994);
                    return return_v;
                }


                bool
                f_10072_12867_12995(ref System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>>
                location, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 12867, 12995);
                    return return_v;
                }


                int
                f_10072_13037_13080(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 13037, 13080);
                    return 0;
                }


                int
                f_10072_13118_13136(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 13118, 13136);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 12494, 13272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 12494, 13272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeParameterConstraintKind GetTypeParameterConstraintKind(int ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 13402, 13686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 13507, 13563);

                var
                constraintKinds = f_10072_13529_13562(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 13577, 13675);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10072, 13584, 13612) || (((constraintKinds.Length > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10072, 13615, 13639)) || DynAbs.Tracing.TraceSender.Conditional_F3(10072, 13642, 13674))) ? constraintKinds[ordinal] : TypeParameterConstraintKind.None;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 13402, 13686);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                f_10072_13529_13562(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeParameterConstraintKinds();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 13529, 13562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 13402, 13686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 13402, 13686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 13698, 14194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 13808, 13864);

                var
                constraintKinds = _lazyTypeParameterConstraintKinds
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 13878, 14144) || true) && (constraintKinds.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 13878, 14144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 13941, 14059);

                    f_10072_13941_14058(ref _lazyTypeParameterConstraintKinds, f_10072_14023_14057(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 14077, 14129);

                    constraintKinds = _lazyTypeParameterConstraintKinds;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 13878, 14144);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 14160, 14183);

                return constraintKinds;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 13698, 14194);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                f_10072_14023_14057(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MakeTypeParameterConstraintKinds();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 14023, 14057);
                    return return_v;
                }


                bool
                f_10072_13941_14058(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 13941, 14058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 13698, 14194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 13698, 14194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<ImmutableArray<TypeWithAnnotations>> MakeTypeParameterConstraintTypes(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 14206, 17722);
                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax typeParameterList = default(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 14350, 14391);

                var
                typeParameters = f_10072_14371_14390(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 14405, 14471);

                var
                results = ImmutableArray<TypeParameterConstraintClause>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 14487, 14521);

                int
                arity = typeParameters.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 14535, 17632) || true) && (arity > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 14535, 17632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 14582, 14687);

                    bool
                    skipPartialDeclarationsWithoutConstraintClauses = f_10072_14637_14686(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 14705, 14792);

                    ArrayBuilder<ImmutableArray<TypeParameterConstraintClause>>
                    otherPartialClauses = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 14812, 17253);
                        foreach (var decl in f_10072_14833_14857_I(f_10072_14833_14857(declaration)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 14812, 17253);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 14899, 14936);

                            var
                            syntaxRef = f_10072_14915_14935(decl)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 14958, 15091);

                            var
                            constraintClauses = f_10072_14982_15090(f_10072_15021_15042(syntaxRef), out typeParameterList)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 15115, 15280) || true) && (skipPartialDeclarationsWithoutConstraintClauses && (DynAbs.Tracing.TraceSender.Expression_True(10072, 15119, 15198) && constraintClauses.Count == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 15115, 15280);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 15248, 15257);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 15115, 15280);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 15304, 15389);

                            var
                            binderFactory = f_10072_15324_15388(f_10072_15324_15349(this), f_10072_15367_15387(syntaxRef))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 15411, 15425);

                            Binder
                            binder
                            = default(Binder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 15447, 15505);

                            ImmutableArray<TypeParameterConstraintClause>
                            constraints
                            = default(ImmutableArray<TypeParameterConstraintClause>);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 15529, 16613) || true) && (constraintClauses.Count == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 15529, 16613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 15611, 15677);

                                binder = f_10072_15620_15676(binderFactory, f_10072_15644_15672(typeParameterList)[0]);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 15705, 15786);

                                constraints = f_10072_15719_15785(binder, typeParameterList);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 15529, 16613);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 15529, 16613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 15884, 15939);

                                binder = f_10072_15893_15938(binderFactory, constraintClauses[0]);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 16145, 16220);

                                f_10072_16145_16219(!f_10072_16159_16218(binder.Flags, BinderFlags.GenericConstraintsClause));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 16246, 16394);

                                binder = f_10072_16255_16393(f_10072_16255_16296(binder, this), BinderFlags.GenericConstraintsClause | BinderFlags.SuppressConstraintChecks);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 16422, 16590);

                                constraints = f_10072_16436_16589(binder, this, typeParameters, typeParameterList, constraintClauses, diagnostics, performOnlyCycleSafeValidation: false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 15529, 16613);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 16637, 16679);

                            f_10072_16637_16678(constraints.Length == arity);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 16703, 17234) || true) && (results.Length == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 16703, 17234);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 16776, 16798);

                                results = constraints;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 16703, 17234);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 16703, 17234);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 16931, 17211) || true) && (otherPartialClauses == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 16931, 17211);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 17021, 17117);

                                    otherPartialClauses = f_10072_17043_17116();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 17147, 17184);

                                    f_10072_17147_17183(otherPartialClauses, constraints);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 16931, 17211);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 16703, 17234);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 14812, 17253);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 2442);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 2442);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 17273, 17369);

                    results = f_10072_17283_17368(this, results, otherPartialClauses, diagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 17389, 17569) || true) && (results.All(clause => clause.ConstraintTypes.IsEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 17389, 17569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 17488, 17550);

                        results = ImmutableArray<TypeParameterConstraintClause>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 17389, 17569);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 17589, 17617);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(otherPartialClauses, 10072, 17589, 17616)?.Free(), 10072, 17609, 17616);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 14535, 17632);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 17648, 17711);

                return results.SelectAsArray(clause => clause.ConstraintTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 14206, 17722);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10072_14371_14390(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 14371, 14390);
                    return return_v;
                }


                bool
                f_10072_14637_14686(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SkipPartialDeclarationsWithoutConstraintClauses();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 14637, 14686);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10072_14833_14857(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 14833, 14857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10072_14915_14935(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.SyntaxReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 14915, 14935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10072_15021_15042(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 15021, 15042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10072_14982_15090(Microsoft.CodeAnalysis.SyntaxNode
                node, out Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList)
                {
                    var return_v = GetConstraintClauses((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, out typeParameterList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 14982, 15090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10072_15324_15349(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 15324, 15349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10072_15367_15387(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 15367, 15387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10072_15324_15388(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 15324, 15388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>
                f_10072_15644_15672(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 15644, 15672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10072_15620_15676(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 15620, 15676);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10072_15719_15785(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList)
                {
                    var return_v = this_param.GetDefaultTypeParameterConstraintClauses(typeParameterList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 15719, 15785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10072_15893_15938(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 15893, 15938);
                    return return_v;
                }


                bool
                f_10072_16159_16218(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 16159, 16218);
                    return return_v;
                }


                int
                f_10072_16145_16219(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 16145, 16219);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10072_16255_16296(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                containing)
                {
                    var return_v = this_param.WithContainingMemberOrLambda((Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 16255, 16296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10072_16255_16393(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 16255, 16393);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10072_16436_16589(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                containingSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                clauses, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                performOnlyCycleSafeValidation)
                {
                    var return_v = this_param.BindTypeParameterConstraintClauses((Microsoft.CodeAnalysis.CSharp.Symbol)containingSymbol, typeParameters, typeParameterList, clauses, diagnostics, performOnlyCycleSafeValidation: performOnlyCycleSafeValidation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 16436, 16589);
                    return return_v;
                }


                int
                f_10072_16637_16678(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 16637, 16678);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>>
                f_10072_17043_17116()
                {
                    var return_v = ArrayBuilder<ImmutableArray<TypeParameterConstraintClause>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 17043, 17116);
                    return return_v;
                }


                int
                f_10072_17147_17183(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 17147, 17183);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10072_14833_14857_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 14833, 14857);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10072_17283_17368(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                constraintClauses, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>>?
                otherPartialClauses, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MergeConstraintTypesForPartialDeclarations(constraintClauses, otherPartialClauses, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 17283, 17368);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 14206, 17722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 14206, 17722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool SkipPartialDeclarationsWithoutConstraintClauses()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 17734, 18122);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 17821, 18082);
                    foreach (var decl in f_10072_17842_17866_I(f_10072_17842_17866(declaration)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 17821, 18082);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 17900, 18067) || true) && (f_10072_17904_17983(f_10072_17943_17975(f_10072_17943_17963(decl)), out _).Count != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 17900, 18067);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 18036, 18048);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 17900, 18067);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 17821, 18082);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 18098, 18111);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 17734, 18122);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10072_17842_17866(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 17842, 17866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10072_17943_17963(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.SyntaxReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 17943, 17963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10072_17943_17975(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 17943, 17975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10072_17904_17983(Microsoft.CodeAnalysis.SyntaxNode
                node, out Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList)
                {
                    var return_v = GetConstraintClauses((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, out typeParameterList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 17904, 17983);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10072_17842_17866_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 17842, 17866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 17734, 18122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 17734, 18122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeParameterConstraintKind> MakeTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 18134, 22171);
                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax typeParameterList = default(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 18245, 18286);

                var
                typeParameters = f_10072_18266_18285(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 18300, 18366);

                var
                results = ImmutableArray<TypeParameterConstraintClause>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 18382, 18416);

                int
                arity = typeParameters.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 18430, 22085) || true) && (arity > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 18430, 22085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 18477, 18582);

                    bool
                    skipPartialDeclarationsWithoutConstraintClauses = f_10072_18532_18581(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 18600, 18687);

                    ArrayBuilder<ImmutableArray<TypeParameterConstraintClause>>
                    otherPartialClauses = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 18707, 21574);
                        foreach (var decl in f_10072_18728_18752_I(f_10072_18728_18752(declaration)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 18707, 21574);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 18794, 18831);

                            var
                            syntaxRef = f_10072_18810_18830(decl)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 18853, 18986);

                            var
                            constraintClauses = f_10072_18877_18985(f_10072_18916_18937(syntaxRef), out typeParameterList)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 19010, 19175) || true) && (skipPartialDeclarationsWithoutConstraintClauses && (DynAbs.Tracing.TraceSender.Expression_True(10072, 19014, 19093) && constraintClauses.Count == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 19010, 19175);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 19143, 19152);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 19010, 19175);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 19199, 19284);

                            var
                            binderFactory = f_10072_19219_19283(f_10072_19219_19244(this), f_10072_19262_19282(syntaxRef))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 19306, 19320);

                            Binder
                            binder
                            = default(Binder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 19342, 19400);

                            ImmutableArray<TypeParameterConstraintClause>
                            constraints
                            = default(ImmutableArray<TypeParameterConstraintClause>);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 19424, 20934) || true) && (constraintClauses.Count == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 19424, 20934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 19506, 19572);

                                binder = f_10072_19515_19571(binderFactory, f_10072_19539_19567(typeParameterList)[0]);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 19598, 19679);

                                constraints = f_10072_19612_19678(binder, typeParameterList);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 19424, 20934);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 19424, 20934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 19777, 19832);

                                binder = f_10072_19786_19831(binderFactory, constraintClauses[0]);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 20190, 20265);

                                f_10072_20190_20264(!f_10072_20204_20263(binder.Flags, BinderFlags.GenericConstraintsClause));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 20291, 20481);

                                binder = f_10072_20300_20480(f_10072_20300_20341(binder, this), BinderFlags.GenericConstraintsClause | BinderFlags.SuppressConstraintChecks | BinderFlags.SuppressTypeArgumentBinding);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 20509, 20553);

                                var
                                discarded = f_10072_20525_20552()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 20703, 20868);

                                constraints = f_10072_20717_20867(binder, this, typeParameters, typeParameterList, constraintClauses, discarded, performOnlyCycleSafeValidation: true);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 20894, 20911);

                                f_10072_20894_20910(discarded);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 19424, 20934);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 20958, 21000);

                            f_10072_20958_20999(constraints.Length == arity);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 21024, 21555) || true) && (results.Length == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 21024, 21555);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 21097, 21119);

                                results = constraints;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 21024, 21555);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 21024, 21555);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 21252, 21532) || true) && (otherPartialClauses == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 21252, 21532);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 21342, 21438);

                                    otherPartialClauses = f_10072_21364_21437();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 21468, 21505);

                                    f_10072_21468_21504(otherPartialClauses, constraints);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 21252, 21532);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 21024, 21555);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 18707, 21574);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 2868);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 2868);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 21594, 21677);

                    results = f_10072_21604_21676(this, results, otherPartialClauses);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 21695, 21798);

                    results = f_10072_21705_21797(this, typeParameters, results);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 21818, 22022) || true) && (results.All(clause => clause.Constraints == TypeParameterConstraintKind.None))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 21818, 22022);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 21941, 22003);

                        results = ImmutableArray<TypeParameterConstraintClause>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 21818, 22022);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 22042, 22070);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(otherPartialClauses, 10072, 22042, 22069)?.Free(), 10072, 22062, 22069);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 18430, 22085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 22101, 22160);

                return results.SelectAsArray(clause => clause.Constraints);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 18134, 22171);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10072_18266_18285(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 18266, 18285);
                    return return_v;
                }


                bool
                f_10072_18532_18581(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SkipPartialDeclarationsWithoutConstraintClauses();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 18532, 18581);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10072_18728_18752(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 18728, 18752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10072_18810_18830(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.SyntaxReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 18810, 18830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10072_18916_18937(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 18916, 18937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10072_18877_18985(Microsoft.CodeAnalysis.SyntaxNode
                node, out Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList)
                {
                    var return_v = GetConstraintClauses((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, out typeParameterList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 18877, 18985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10072_19219_19244(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 19219, 19244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10072_19262_19282(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 19262, 19282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10072_19219_19283(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 19219, 19283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>
                f_10072_19539_19567(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 19539, 19567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10072_19515_19571(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 19515, 19571);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10072_19612_19678(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList)
                {
                    var return_v = this_param.GetDefaultTypeParameterConstraintClauses(typeParameterList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 19612, 19678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10072_19786_19831(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 19786, 19831);
                    return return_v;
                }


                bool
                f_10072_20204_20263(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 20204, 20263);
                    return return_v;
                }


                int
                f_10072_20190_20264(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 20190, 20264);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10072_20300_20341(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                containing)
                {
                    var return_v = this_param.WithContainingMemberOrLambda((Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 20300, 20341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10072_20300_20480(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 20300, 20480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10072_20525_20552()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 20525, 20552);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10072_20717_20867(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                containingSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                clauses, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                performOnlyCycleSafeValidation)
                {
                    var return_v = this_param.BindTypeParameterConstraintClauses((Microsoft.CodeAnalysis.CSharp.Symbol)containingSymbol, typeParameters, typeParameterList, clauses, diagnostics, performOnlyCycleSafeValidation: performOnlyCycleSafeValidation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 20717, 20867);
                    return return_v;
                }


                int
                f_10072_20894_20910(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 20894, 20910);
                    return 0;
                }


                int
                f_10072_20958_20999(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 20958, 20999);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>>
                f_10072_21364_21437()
                {
                    var return_v = ArrayBuilder<ImmutableArray<TypeParameterConstraintClause>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 21364, 21437);
                    return return_v;
                }


                int
                f_10072_21468_21504(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 21468, 21504);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10072_18728_18752_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 18728, 18752);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10072_21604_21676(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                constraintClauses, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>>?
                otherPartialClauses)
                {
                    var return_v = this_param.MergeConstraintKindsForPartialDeclarations(constraintClauses, otherPartialClauses);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 21604, 21676);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10072_21705_21797(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                constraintClauses)
                {
                    var return_v = ConstraintsHelper.AdjustConstraintKindsBasedOnConstraintTypes((Microsoft.CodeAnalysis.CSharp.Symbol)container, typeParameters, constraintClauses);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 21705, 21797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 18134, 22171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 18134, 22171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxList<TypeParameterConstraintClauseSyntax> GetConstraintClauses(CSharpSyntaxNode node, out TypeParameterListSyntax typeParameterList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10072, 22183, 23226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 22361, 23215);

                switch (f_10072_22369_22380(node))
                {

                    case SyntaxKind.ClassDeclaration:
                    case SyntaxKind.StructDeclaration:
                    case SyntaxKind.InterfaceDeclaration:
                    case SyntaxKind.RecordDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 22361, 23215);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 22628, 22678);

                        var
                        typeDeclaration = (TypeDeclarationSyntax)node
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 22700, 22754);

                        typeParameterList = f_10072_22720_22753(typeDeclaration);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 22776, 22817);

                        return f_10072_22783_22816(typeDeclaration);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 22361, 23215);

                    case SyntaxKind.DelegateDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 22361, 23215);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 22893, 22951);

                        var
                        delegateDeclaration = (DelegateDeclarationSyntax)node
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 22973, 23031);

                        typeParameterList = f_10072_22993_23030(delegateDeclaration);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 23053, 23098);

                        return f_10072_23060_23097(delegateDeclaration);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 22361, 23215);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 22361, 23215);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 23146, 23200);

                        throw f_10072_23152_23199(f_10072_23187_23198(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 22361, 23215);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10072, 22183, 23226);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10072_22369_22380(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 22369, 22380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                f_10072_22720_22753(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 22720, 22753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10072_22783_22816(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ConstraintClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 22783, 22816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                f_10072_22993_23030(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 22993, 23030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10072_23060_23097(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ConstraintClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 23060, 23097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10072_23187_23198(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 23187, 23198);
                    return return_v;
                }


                System.Exception
                f_10072_23152_23199(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 23152, 23199);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 22183, 23226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 22183, 23226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeParameterConstraintClause> MergeConstraintTypesForPartialDeclarations(ImmutableArray<TypeParameterConstraintClause> constraintClauses,
                                                                                                                 ArrayBuilder<ImmutableArray<TypeParameterConstraintClause>> otherPartialClauses,
                                                                                                                 DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 23395, 30616);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 23901, 24006) || true) && (otherPartialClauses == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 23901, 24006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 23966, 23991);

                    return constraintClauses;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 23901, 24006);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24022, 24081);

                ArrayBuilder<TypeParameterConstraintClause>
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24095, 24131);

                var
                typeParameters = f_10072_24116_24130()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24145, 24179);

                int
                arity = typeParameters.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24195, 24243);

                f_10072_24195_24242(constraintClauses.Length == arity);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24268, 24273);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24259, 26603) || true) && (i < arity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24286, 24289)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 24259, 26603))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 24259, 26603);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24323, 24361);

                        var
                        constraint = constraintClauses[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24381, 24470);

                        ImmutableArray<TypeWithAnnotations>
                        originalConstraintTypes = constraint.ConstraintTypes
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24488, 24551);

                        ArrayBuilder<TypeWithAnnotations>
                        mergedConstraintTypes = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24569, 24645);

                        SmallDictionary<TypeWithAnnotations, int>
                        originalConstraintTypesMap = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24794, 24895);

                        bool
                        report = (f_10072_24809_24842(this, i) & TypeParameterConstraintKind.PartialMismatch) != 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 24913, 25295);
                            foreach (ImmutableArray<TypeParameterConstraintClause> otherPartialConstraints in f_10072_24995_25014_I(otherPartialClauses))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 24913, 25295);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 25056, 25276) || true) && (!f_10072_25061_25189(originalConstraintTypes, ref originalConstraintTypesMap, ref mergedConstraintTypes, otherPartialConstraints[i]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 25056, 25276);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 25239, 25253);

                                    report = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 25056, 25276);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 24913, 25295);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 383);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 383);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 25315, 25591) || true) && (report)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 25315, 25591);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 25478, 25572);

                            f_10072_25478_25571(                    // "Partial declarations of '{0}' have inconsistent constraints for type parameter '{1}'"
                                                diagnostics, ErrorCode.ERR_PartialWrongConstraints, f_10072_25533_25542()[0], this, typeParameters[i]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 25315, 25591);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 25611, 26588) || true) && (mergedConstraintTypes != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 25611, 26588);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 25697, 25773);

                            f_10072_25697_25772(originalConstraintTypes.Length == f_10072_25744_25771(mergedConstraintTypes));
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 25806, 25811);

                                for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 25797, 26052) || true) && (j < originalConstraintTypes.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 25849, 25852)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 25797, 26052))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 25797, 26052);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 25902, 26029);

                                    f_10072_25902_26028(originalConstraintTypes[j].Equals(f_10072_25949_25973(mergedConstraintTypes, j), TypeCompareKind.ObliviousNullableModifierMatchesAny));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 256);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 256);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 26082, 26328) || true) && (builder == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 26082, 26328);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 26151, 26243);

                                builder = f_10072_26161_26242(constraintClauses.Length);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 26269, 26305);

                                f_10072_26269_26304(builder, constraintClauses);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 26082, 26328);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 26352, 26569);

                            builder[i] = f_10072_26365_26568(constraint.Constraints, f_10072_26497_26540_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(mergedConstraintTypes, 10072, 26497, 26540)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>?>(10072, 26497, 26567) ?? originalConstraintTypes));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 25611, 26588);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 2345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 2345);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 26619, 26736) || true) && (builder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 26619, 26736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 26672, 26721);

                    constraintClauses = f_10072_26692_26720(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 26619, 26736);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 26752, 26777);

                return constraintClauses;

                static bool mergeConstraints(ImmutableArray<TypeWithAnnotations> originalConstraintTypes,
                                                         ref SmallDictionary<TypeWithAnnotations, int> originalConstraintTypesMap, ref ArrayBuilder<TypeWithAnnotations> mergedConstraintTypes,
                                                         TypeParameterConstraintClause clause)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10072, 26793, 30026);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 27172, 27191);

                        bool
                        result = true
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 27211, 27608) || true) && (originalConstraintTypes.Length == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 27211, 27608);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 27292, 27417) || true) && (clause.ConstraintTypes.Length == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 27292, 27417);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 27380, 27394);

                                return result;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 27292, 27417);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 27441, 27454);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 27211, 27608);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 27211, 27608);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 27496, 27608) || true) && (clause.ConstraintTypes.Length == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 27496, 27608);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 27576, 27589);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 27496, 27608);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 27211, 27608);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 27655, 27868) || true) && (originalConstraintTypesMap == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 27655, 27868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 27716, 27868);

                            originalConstraintTypesMap = f_10072_27745_27867(originalConstraintTypes, TypeWithAnnotations.EqualsComparer.IgnoreNullableModifiersForReferenceTypesComparer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 27655, 27868);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 27886, 28029);

                        SmallDictionary<TypeWithAnnotations, int>
                        clauseConstraintTypesMap = f_10072_27955_28028(clause.ConstraintTypes, originalConstraintTypesMap.Comparer)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 28049, 29657);
                            foreach (int index1 in f_10072_28072_28105_I(f_10072_28072_28105(originalConstraintTypesMap)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 28049, 29657);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 28147, 28251);

                                TypeWithAnnotations
                                constraintType1 = f_10072_28185_28215_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(mergedConstraintTypes, 10072, 28185, 28215)?[index1]) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations?>(10072, 28185, 28250) ?? originalConstraintTypes[index1])
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 28273, 28284);

                                int
                                index2
                                = default(int);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 28308, 28546) || true) && (!f_10072_28313_28378(clauseConstraintTypesMap, constraintType1, out index2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 28308, 28546);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 28473, 28488);

                                    result = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 28514, 28523);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 28308, 28546);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 28570, 28639);

                                TypeWithAnnotations
                                constraintType2 = clause.ConstraintTypes[index2]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 28663, 28963) || true) && (!constraintType1.Equals(constraintType2, TypeCompareKind.ObliviousNullableModifierMatchesAny))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 28663, 28963);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 28890, 28905);

                                    result = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 28931, 28940);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 28663, 28963);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 28987, 29638) || true) && (!constraintType1.Equals(constraintType2, TypeCompareKind.ConsiderEverything))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 28987, 29638);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 29176, 29482) || true) && (mergedConstraintTypes == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 29176, 29482);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 29267, 29369);

                                        mergedConstraintTypes = f_10072_29291_29368(originalConstraintTypes.Length);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 29399, 29455);

                                        f_10072_29399_29454(mergedConstraintTypes, originalConstraintTypes);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 29176, 29482);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 29510, 29615);

                                    mergedConstraintTypes[index1] = constraintType1.MergeEquivalentTypes(constraintType2, VarianceKind.None);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 28987, 29638);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 28049, 29657);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 1609);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 1609);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 29677, 29977);
                            foreach (var constraintType in f_10072_29708_29737_I(f_10072_29708_29737(clauseConstraintTypesMap)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 29677, 29977);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 29779, 29958) || true) && (!f_10072_29784_29838(originalConstraintTypesMap, constraintType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 29779, 29958);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 29888, 29903);

                                    result = false;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10072, 29929, 29935);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 29779, 29958);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 29677, 29977);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 301);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 301);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 29997, 30011);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10072, 26793, 30026);

                        Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>
                        f_10072_27745_27867(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        constraintTypes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.EqualsComparer
                        comparer)
                        {
                            var return_v = toDictionary(constraintTypes, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>)comparer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 27745, 27867);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>
                        f_10072_27955_28028(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        constraintTypes, System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        comparer)
                        {
                            var return_v = toDictionary(constraintTypes, comparer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 27955, 28028);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>.ValueCollection
                        f_10072_28072_28105(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>
                        this_param)
                        {
                            var return_v = this_param.Values;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 28072, 28105);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations?
                        f_10072_28185_28215_M(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 28185, 28215);
                            return return_v;
                        }


                        bool
                        f_10072_28313_28378(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        key, out int
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 28313, 28378);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10072_29291_29368(int
                        capacity)
                        {
                            var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 29291, 29368);
                            return return_v;
                        }


                        int
                        f_10072_29399_29454(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        items)
                        {
                            this_param.AddRange(items);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 29399, 29454);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>.ValueCollection
                        f_10072_28072_28105_I(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>.ValueCollection
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 28072, 28105);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>.KeyCollection
                        f_10072_29708_29737(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>
                        this_param)
                        {
                            var return_v = this_param.Keys;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 29708, 29737);
                            return return_v;
                        }


                        bool
                        f_10072_29784_29838(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        key)
                        {
                            var return_v = this_param.ContainsKey(key);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 29784, 29838);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>.KeyCollection
                        f_10072_29708_29737_I(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>.KeyCollection
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 29708, 29737);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 26793, 30026);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 26793, 30026);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static SmallDictionary<TypeWithAnnotations, int> toDictionary(ImmutableArray<TypeWithAnnotations> constraintTypes, IEqualityComparer<TypeWithAnnotations> comparer)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10072, 30042, 30605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 30238, 30307);

                        var
                        result = f_10072_30251_30306(comparer)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 30336, 30366);

                            for (int
            i = constraintTypes.Length - 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 30327, 30556) || true) && (i >= 0)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 30376, 30379)
            , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 30327, 30556))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 30327, 30556);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 30421, 30452);

                                result[constraintTypes[i]] = i;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 230);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 230);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 30576, 30590);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10072, 30042, 30605);

                        Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>
                        f_10072_30251_30306(System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        comparer)
                        {
                            var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>(comparer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 30251, 30306);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 30042, 30605);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 30042, 30605);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 23395, 30616);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10072_24116_24130()
                {
                    var return_v = TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 24116, 24130);
                    return return_v;
                }


                int
                f_10072_24195_24242(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 24195, 24242);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                f_10072_24809_24842(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, int
                ordinal)
                {
                    var return_v = this_param.GetTypeParameterConstraintKind(ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 24809, 24842);
                    return return_v;
                }


                bool
                f_10072_25061_25189(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                originalConstraintTypes, ref Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, int>?
                originalConstraintTypesMap, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>?
                mergedConstraintTypes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                clause)
                {
                    var return_v = mergeConstraints(originalConstraintTypes, ref originalConstraintTypesMap, ref mergedConstraintTypes, clause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 25061, 25189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>>
                f_10072_24995_25014_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 24995, 25014);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10072_25533_25542()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 25533, 25542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10072_25478_25571(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 25478, 25571);
                    return return_v;
                }


                int
                f_10072_25744_25771(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 25744, 25771);
                    return return_v;
                }


                int
                f_10072_25697_25772(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 25697, 25772);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10072_25949_25973(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 25949, 25973);
                    return return_v;
                }


                int
                f_10072_25902_26028(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 25902, 26028);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10072_26161_26242(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeParameterConstraintClause>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 26161, 26242);
                    return return_v;
                }


                int
                f_10072_26269_26304(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 26269, 26304);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>?
                f_10072_26497_26540_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 26497, 26540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                f_10072_26365_26568(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                constraints, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes)
                {
                    var return_v = TypeParameterConstraintClause.Create(constraints, constraintTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 26365, 26568);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10072_26692_26720(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 26692, 26720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 23395, 30616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 23395, 30616);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeParameterConstraintClause> MergeConstraintKindsForPartialDeclarations(ImmutableArray<TypeParameterConstraintClause> constraintClauses,
                                                                                                                 ArrayBuilder<ImmutableArray<TypeParameterConstraintClause>> otherPartialClauses)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 30785, 36430);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31158, 31263) || true) && (otherPartialClauses == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 31158, 31263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31223, 31248);

                    return constraintClauses;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 31158, 31263);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31279, 31338);

                ArrayBuilder<TypeParameterConstraintClause>
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31352, 31388);

                var
                typeParameters = f_10072_31373_31387()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31402, 31436);

                int
                arity = typeParameters.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31452, 31500);

                f_10072_31452_31499(constraintClauses.Length == arity);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31525, 31530);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31516, 33456) || true) && (i < arity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31543, 31546)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 31516, 33456))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 31516, 33456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31580, 31618);

                        var
                        constraint = constraintClauses[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31638, 31702);

                        TypeParameterConstraintKind
                        mergedKind = constraint.Constraints
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31720, 31809);

                        ImmutableArray<TypeWithAnnotations>
                        originalConstraintTypes = constraint.ConstraintTypes
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31829, 32077);
                            foreach (ImmutableArray<TypeParameterConstraintClause> otherPartialConstraints in f_10072_31911_31930_I(otherPartialClauses))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 31829, 32077);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 31972, 32058);

                                f_10072_31972_32057(ref mergedKind, originalConstraintTypes, otherPartialConstraints[i]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 31829, 32077);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 249);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 249);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 32097, 33441) || true) && (constraint.Constraints != mergedKind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 32097, 33441);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 32179, 32448);

                            f_10072_32179_32447((constraint.Constraints & (TypeParameterConstraintKind.AllNonNullableKinds | TypeParameterConstraintKind.NotNull)) ==
                                                             (mergedKind & (TypeParameterConstraintKind.AllNonNullableKinds | TypeParameterConstraintKind.NotNull)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 32470, 32701);

                            f_10072_32470_32700((mergedKind & TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10072, 32483, 32699) || (constraint.Constraints & TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType) != 0));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 32723, 33041);

                            f_10072_32723_33040((constraint.Constraints & TypeParameterConstraintKind.AllReferenceTypeKinds) == (mergedKind & TypeParameterConstraintKind.AllReferenceTypeKinds) || (DynAbs.Tracing.TraceSender.Expression_False(10072, 32736, 33039) || (constraint.Constraints & TypeParameterConstraintKind.AllReferenceTypeKinds) == TypeParameterConstraintKind.ReferenceType));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 33065, 33311) || true) && (builder == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 33065, 33311);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 33134, 33226);

                                builder = f_10072_33144_33225(constraintClauses.Length);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 33252, 33288);

                                f_10072_33252_33287(builder, constraintClauses);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 33065, 33311);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 33335, 33422);

                            builder[i] = f_10072_33348_33421(mergedKind, originalConstraintTypes);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 32097, 33441);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 1941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 1941);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 33472, 33589) || true) && (builder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 33472, 33589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 33525, 33574);

                    constraintClauses = f_10072_33545_33573(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 33472, 33589);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 33605, 33630);

                return constraintClauses;

                static void mergeConstraints(ref TypeParameterConstraintKind mergedKind, ImmutableArray<TypeWithAnnotations> originalConstraintTypes, TypeParameterConstraintClause clause)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10072, 33646, 36419);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 33850, 34189) || true) && ((mergedKind & (TypeParameterConstraintKind.AllNonNullableKinds | TypeParameterConstraintKind.NotNull)) != (clause.Constraints & (TypeParameterConstraintKind.AllNonNullableKinds | TypeParameterConstraintKind.NotNull)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 33850, 34189);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 34112, 34170);

                            mergedKind |= TypeParameterConstraintKind.PartialMismatch;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 33850, 34189);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 34209, 35545) || true) && ((mergedKind & TypeParameterConstraintKind.ReferenceType) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10072, 34213, 34347) && (clause.Constraints & TypeParameterConstraintKind.ReferenceType) != 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 34209, 35545);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 34461, 34573);

                            TypeParameterConstraintKind
                            clause1Constraints = mergedKind & TypeParameterConstraintKind.AllReferenceTypeKinds
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 34595, 34715);

                            TypeParameterConstraintKind
                            clause2Constraints = clause.Constraints & TypeParameterConstraintKind.AllReferenceTypeKinds
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 34737, 35526) || true) && (clause1Constraints != clause2Constraints)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 34737, 35526);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 34831, 35503) || true) && (clause1Constraints == TypeParameterConstraintKind.ReferenceType)
                                ) // Oblivious

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 34831, 35503);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 35031, 35133);

                                    mergedKind = (mergedKind & (~TypeParameterConstraintKind.AllReferenceTypeKinds)) | clause2Constraints;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 34831, 35503);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 34831, 35503);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 35191, 35503) || true) && (clause2Constraints != TypeParameterConstraintKind.ReferenceType)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 35191, 35503);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 35418, 35476);

                                        mergedKind |= TypeParameterConstraintKind.PartialMismatch;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 35191, 35503);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 34831, 35503);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 34737, 35526);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 34209, 35545);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 35565, 36404) || true) && (originalConstraintTypes.Length == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10072, 35569, 35642) && clause.ConstraintTypes.Length == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 35565, 36404);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 35763, 36385) || true) && (((mergedKind | clause.Constraints) & ~(TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType | TypeParameterConstraintKind.Constructor)) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10072, 35767, 36030) && (mergedKind & TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType) != 0) && (DynAbs.Tracing.TraceSender.Expression_True(10072, 35767, 36163) && (clause.Constraints & TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType) == 0))
                            )   // 'object?' 

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 35763, 36385);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 36283, 36362);

                                mergedKind &= ~TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 35763, 36385);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 35565, 36404);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10072, 33646, 36419);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 33646, 36419);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 33646, 36419);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 30785, 36430);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10072_31373_31387()
                {
                    var return_v = TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 31373, 31387);
                    return return_v;
                }


                int
                f_10072_31452_31499(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 31452, 31499);
                    return 0;
                }


                int
                f_10072_31972_32057(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                mergedKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                originalConstraintTypes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                clause)
                {
                    mergeConstraints(ref mergedKind, originalConstraintTypes, clause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 31972, 32057);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>>
                f_10072_31911_31930_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 31911, 31930);
                    return return_v;
                }


                int
                f_10072_32179_32447(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 32179, 32447);
                    return 0;
                }


                int
                f_10072_32470_32700(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 32470, 32700);
                    return 0;
                }


                int
                f_10072_32723_33040(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 32723, 33040);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10072_33144_33225(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeParameterConstraintClause>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 33144, 33225);
                    return return_v;
                }


                int
                f_10072_33252_33287(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 33252, 33287);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                f_10072_33348_33421(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                constraints, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes)
                {
                    var return_v = TypeParameterConstraintClause.Create(constraints, constraintTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 33348, 33421);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10072_33545_33573(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 33545, 33573);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 30785, 36430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 30785, 36430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 36576, 36669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 36612, 36654);

                    return f_10072_36619_36653(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 36576, 36669);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10072_36619_36653(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeParametersAsTypeArguments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 36619, 36653);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 36442, 36680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 36442, 36680);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 36783, 37302);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 36819, 37240) || true) && (_lazyTypeParameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 36819, 37240);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 36894, 36940);

                        var
                        diagnostics = f_10072_36912_36939()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 36962, 37178) || true) && (f_10072_36966_37066(ref _lazyTypeParameters, f_10072_37034_37065(this, diagnostics)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 36962, 37178);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 37116, 37155);

                            f_10072_37116_37154(this, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 36962, 37178);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 37202, 37221);

                        f_10072_37202_37220(
                                            diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 36819, 37240);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 37260, 37287);

                    return _lazyTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 36783, 37302);

                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10072_36912_36939()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 36912, 36939);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10072_37034_37065(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.MakeTypeParameters(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 37034, 37065);
                        return return_v;
                    }


                    bool
                    f_10072_36966_37066(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 36966, 37066);
                        return return_v;
                    }


                    int
                    f_10072_37116_37154(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        this_param.AddDeclarationDiagnostics(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 37116, 37154);
                        return 0;
                    }


                    int
                    f_10072_37202_37220(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 37202, 37220);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 36692, 37313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 36692, 37313);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 37377, 37542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 37485, 37531);

                return f_10072_37492_37530(declaration);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 37377, 37542);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10072_37492_37530(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.GetAttributeDeclarations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 37492, 37530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 37377, 37542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 37377, 37542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IAttributeTargetSymbol IAttributeTargetSymbol.AttributesOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 37640, 37660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 37646, 37658);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 37640, 37660);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 37554, 37671);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 37554, 37671);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 37773, 37811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 37779, 37809);

                    return AttributeLocation.Type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 37773, 37811);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 37683, 37822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 37683, 37822);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 37925, 38535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 37961, 38520);

                    switch (f_10072_37969_37977())
                    {

                        case TypeKind.Delegate:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 37961, 38520);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 38068, 38125);

                            return AttributeLocation.Type | AttributeLocation.Return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 37961, 38520);

                        case TypeKind.Enum:
                        case TypeKind.Interface:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 37961, 38520);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 38240, 38270);

                            return AttributeLocation.Type;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 37961, 38520);

                        case TypeKind.Struct:
                        case TypeKind.Class:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 37961, 38520);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 38383, 38413);

                            return AttributeLocation.Type;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 37961, 38520);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 37961, 38520);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 38471, 38501);

                            return AttributeLocation.None;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 37961, 38520);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 37925, 38535);

                    Microsoft.CodeAnalysis.TypeKind
                    f_10072_37969_37977()
                    {
                        var return_v = TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 37969, 37977);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 37834, 38546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 37834, 38546);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private CustomAttributesBag<CSharpAttributeData> GetAttributesBag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 38872, 39508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 38964, 38999);

                var
                bag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 39013, 39104) || true) && (bag != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 39017, 39044) && f_10072_39032_39044(bag)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 39013, 39104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 39078, 39089);

                    return bag;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 39013, 39104);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 39120, 39387) || true) && (f_10072_39124_39230(this, f_10072_39150_39199(f_10072_39167_39198(this)), ref _lazyCustomAttributesBag))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 39120, 39387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 39264, 39330);

                    var
                    completed = state.NotePartComplete(CompletionPart.Attributes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 39348, 39372);

                    f_10072_39348_39371(completed);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 39120, 39387);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 39403, 39451);

                f_10072_39403_39450(f_10072_39416_39449(_lazyCustomAttributesBag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 39465, 39497);

                return _lazyCustomAttributesBag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 38872, 39508);

                bool
                f_10072_39032_39044(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 39032, 39044);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10072_39167_39198(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributeDeclarations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 39167, 39198);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10072_39150_39199(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                many)
                {
                    var return_v = OneOrMany.Create(many);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 39150, 39199);
                    return return_v;
                }


                bool
                f_10072_39124_39230(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                attributesSyntaxLists, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributesBag)
                {
                    var return_v = this_param.LoadAndValidateAttributes(attributesSyntaxLists, ref lazyCustomAttributesBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 39124, 39230);
                    return return_v;
                }


                int
                f_10072_39348_39371(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 39348, 39371);
                    return 0;
                }


                bool
                f_10072_39416_39449(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 39416, 39449);
                    return return_v;
                }


                int
                f_10072_39403_39450(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 39403, 39450);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 38872, 39508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 38872, 39508);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 39688, 39840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 39787, 39829);

                return f_10072_39794_39828(f_10072_39794_39817(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 39688, 39840);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10072_39794_39817(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 39794, 39817);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10072_39794_39828(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 39794, 39828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 39688, 39840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 39688, 39840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWellKnownAttributeData GetDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 40129, 40560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 40223, 40268);

                var
                attributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 40282, 40454) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10072, 40286, 40365) || f_10072_40311_40365_M(!attributesBag.IsDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 40282, 40454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 40399, 40439);

                    attributesBag = f_10072_40415_40438(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 40282, 40454);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 40470, 40549);

                return (TypeWellKnownAttributeData)f_10072_40505_40548(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 40129, 40560);

                bool
                f_10072_40311_40365_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 40311, 40365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10072_40415_40438(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 40415, 40438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10072_40505_40548(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 40505, 40548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 40129, 40560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 40129, 40560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CommonTypeEarlyWellKnownAttributeData GetEarlyDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 40869, 41338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 40980, 41025);

                var
                attributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 41039, 41216) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10072, 41043, 41127) || f_10072_41068_41127_M(!attributesBag.IsEarlyDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 41039, 41216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 41161, 41201);

                    attributesBag = f_10072_41177_41200(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 41039, 41216);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 41232, 41327);

                return (CommonTypeEarlyWellKnownAttributeData)f_10072_41278_41326(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 40869, 41338);

                bool
                f_10072_41068_41127_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 41068, 41127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10072_41177_41200(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 41177, 41200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                f_10072_41278_41326(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 41278, 41326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 40869, 41338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 40869, 41338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override CSharpAttributeData EarlyDecodeWellKnownAttribute(ref EarlyDecodeWellKnownAttributeArguments<EarlyWellKnownAttributeBinder, NamedTypeSymbol, AttributeSyntax, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 41350, 45555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 41580, 41603);

                bool
                hasAnyDiagnostics
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 41617, 41652);

                CSharpAttributeData
                boundAttribute
                = default(CSharpAttributeData);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 41668, 42353) || true) && (f_10072_41672_41807(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.ComImportAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 41668, 42353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 41841, 41963);

                    boundAttribute = f_10072_41858_41962(arguments.Binder, arguments.AttributeSyntax, arguments.AttributeType, out hasAnyDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 41981, 42306) || true) && (f_10072_41985_42010_M(!boundAttribute.HasErrors))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 41981, 42306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 42052, 42148);

                        arguments.GetOrCreateData<CommonTypeEarlyWellKnownAttributeData>().HasComImportAttribute = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 42170, 42287) || true) && (!hasAnyDiagnostics)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 42170, 42287);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 42242, 42264);

                            return boundAttribute;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 42170, 42287);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 41981, 42306);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 42326, 42338);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 41668, 42353);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 42369, 43076) || true) && (f_10072_42373_42519(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.CodeAnalysisEmbeddedAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 42369, 43076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 42553, 42675);

                    boundAttribute = f_10072_42570_42674(arguments.Binder, arguments.AttributeSyntax, arguments.AttributeType, out hasAnyDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 42693, 43029) || true) && (f_10072_42697_42722_M(!boundAttribute.HasErrors))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 42693, 43029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 42764, 42871);

                        arguments.GetOrCreateData<CommonTypeEarlyWellKnownAttributeData>().HasCodeAnalysisEmbeddedAttribute = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 42893, 43010) || true) && (!hasAnyDiagnostics)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 42893, 43010);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 42965, 42987);

                            return boundAttribute;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 42893, 43010);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 42693, 43029);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 43049, 43061);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 42369, 43076);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 43092, 43889) || true) && (f_10072_43096_43233(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.ConditionalAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 43092, 43889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 43267, 43389);

                    boundAttribute = f_10072_43284_43388(arguments.Binder, arguments.AttributeSyntax, arguments.AttributeType, out hasAnyDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 43407, 43842) || true) && (f_10072_43411_43436_M(!boundAttribute.HasErrors))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 43407, 43842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 43478, 43568);

                        string
                        name = f_10072_43492_43567(boundAttribute, 0, SpecialType.System_String)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 43590, 43684);

                        f_10072_43590_43683(arguments.GetOrCreateData<CommonTypeEarlyWellKnownAttributeData>(), name);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 43706, 43823) || true) && (!hasAnyDiagnostics)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 43706, 43823);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 43778, 43800);

                            return boundAttribute;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 43706, 43823);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 43407, 43842);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 43862, 43874);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 43092, 43889);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 43905, 43940);

                ObsoleteAttributeData
                obsoleteData
                = default(ObsoleteAttributeData);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 43954, 44345) || true) && (f_10072_43958_44065(ref arguments, out boundAttribute, out obsoleteData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 43954, 44345);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 44099, 44288) || true) && (obsoleteData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 44099, 44288);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 44165, 44269);

                        arguments.GetOrCreateData<CommonTypeEarlyWellKnownAttributeData>().ObsoleteAttributeData = obsoleteData;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 44099, 44288);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 44308, 44330);

                    return boundAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 43954, 44345);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 44361, 45471) || true) && (f_10072_44365_44505(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.AttributeUsageAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 44361, 45471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 44539, 44661);

                    boundAttribute = f_10072_44556_44660(arguments.Binder, arguments.AttributeSyntax, arguments.AttributeType, out hasAnyDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 44679, 45424) || true) && (f_10072_44683_44708_M(!boundAttribute.HasErrors))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 44679, 45424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 44750, 44871);

                        AttributeUsageInfo
                        info = f_10072_44776_44870(this, boundAttribute, arguments.AttributeSyntax, diagnose: false)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 44893, 45405) || true) && (f_10072_44897_44909_M(!info.IsNull))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 44893, 45405);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 44959, 45041);

                            var
                            typeData = arguments.GetOrCreateData<CommonTypeEarlyWellKnownAttributeData>()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 45067, 45225) || true) && (typeData.AttributeUsageInfo.IsNull)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 45067, 45225);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 45163, 45198);

                                typeData.AttributeUsageInfo = info;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 45067, 45225);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 45253, 45382) || true) && (!hasAnyDiagnostics)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 45253, 45382);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 45333, 45355);

                                return boundAttribute;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 45253, 45382);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 44893, 45405);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 44679, 45424);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 45444, 45456);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 44361, 45471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 45487, 45544);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EarlyDecodeWellKnownAttribute(ref arguments), 10072, 45494, 45543);
                var temp = base.EarlyDecodeWellKnownAttribute(ref arguments);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 45494, 45543);
                return temp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 41350, 45555);

                bool
                f_10072_41672_41807(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 41672, 41807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10072_41858_41962(Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                boundAttributeType, out bool
                generatedDiagnostics)
                {
                    var return_v = this_param.GetAttribute(node, boundAttributeType, out generatedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 41858, 41962);
                    return return_v;
                }


                bool
                f_10072_41985_42010_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 41985, 42010);
                    return return_v;
                }


                bool
                f_10072_42373_42519(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 42373, 42519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10072_42570_42674(Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                boundAttributeType, out bool
                generatedDiagnostics)
                {
                    var return_v = this_param.GetAttribute(node, boundAttributeType, out generatedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 42570, 42674);
                    return return_v;
                }


                bool
                f_10072_42697_42722_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 42697, 42722);
                    return return_v;
                }


                bool
                f_10072_43096_43233(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 43096, 43233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10072_43284_43388(Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                boundAttributeType, out bool
                generatedDiagnostics)
                {
                    var return_v = this_param.GetAttribute(node, boundAttributeType, out generatedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 43284, 43388);
                    return return_v;
                }


                bool
                f_10072_43411_43436_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 43411, 43436);
                    return return_v;
                }


                string?
                f_10072_43492_43567(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, int
                i, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetConstructorArgument<string>(i, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 43492, 43567);
                    return return_v;
                }


                int
                f_10072_43590_43683(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
                this_param, string?
                name)
                {
                    this_param.AddConditionalSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 43590, 43683);
                    return 0;
                }


                bool
                f_10072_43958_44065(ref Microsoft.CodeAnalysis.EarlyDecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, out Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attributeData, out Microsoft.CodeAnalysis.ObsoleteAttributeData
                obsoleteData)
                {
                    var return_v = EarlyDecodeDeprecatedOrExperimentalOrObsoleteAttribute(ref arguments, out attributeData, out obsoleteData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 43958, 44065);
                    return return_v;
                }


                bool
                f_10072_44365_44505(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 44365, 44505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10072_44556_44660(Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                boundAttributeType, out bool
                generatedDiagnostics)
                {
                    var return_v = this_param.GetAttribute(node, boundAttributeType, out generatedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 44556, 44660);
                    return return_v;
                }


                bool
                f_10072_44683_44708_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 44683, 44708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10072_44776_44870(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, bool
                diagnose)
                {
                    var return_v = this_param.DecodeAttributeUsageAttribute(attribute, node, diagnose: diagnose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 44776, 44870);
                    return return_v;
                }


                bool
                f_10072_44897_44909_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 44897, 44909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 41350, 45555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 41350, 45555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override AttributeUsageInfo GetAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 45567, 46189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 45652, 45763);

                f_10072_45652_45762(f_10072_45665_45681(this) == SpecialType.System_Object || (DynAbs.Tracing.TraceSender.Expression_False(10072, 45665, 45761) || f_10072_45714_45761(f_10072_45714_45739(this), this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 45779, 45869);

                CommonTypeEarlyWellKnownAttributeData
                data = f_10072_45824_45868(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 45883, 46014) || true) && (data != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 45887, 45934) && f_10072_45903_45934_M(!data.AttributeUsageInfo.IsNull)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 45883, 46014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 45968, 45999);

                    return f_10072_45975_45998(data);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 45883, 46014);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 46030, 46178);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10072, 46037, 46088) || ((((object)f_10072_46046_46079(this) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10072, 46091, 46148)) || DynAbs.Tracing.TraceSender.Conditional_F3(10072, 46151, 46177))) ? f_10072_46091_46148(f_10072_46091_46124(this)) : AttributeUsageInfo.Default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 45567, 46189);

                Microsoft.CodeAnalysis.SpecialType
                f_10072_45665_45681(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 45665, 45681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10072_45714_45739(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 45714, 45739);
                    return return_v;
                }


                bool
                f_10072_45714_45761(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                type)
                {
                    var return_v = this_param.IsAttributeType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 45714, 45761);
                    return return_v;
                }


                int
                f_10072_45652_45762(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 45652, 45762);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
                f_10072_45824_45868(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetEarlyDecodedWellKnownAttributeData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 45824, 45868);
                    return return_v;
                }


                bool
                f_10072_45903_45934_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 45903, 45934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10072_45975_45998(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeUsageInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 45975, 45998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10072_46046_46079(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 46046, 46079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10072_46091_46124(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 46091, 46124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10072_46091_46148(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributeUsageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 46091, 46148);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 45567, 46189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 45567, 46189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 46555, 47338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 46591, 46646);

                    var
                    lazyCustomAttributesBag = _lazyCustomAttributesBag
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 46664, 47019) || true) && (lazyCustomAttributesBag != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 46668, 46771) && f_10072_46703_46771(lazyCustomAttributesBag)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 46664, 47019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 46813, 46922);

                        var
                        data = (CommonTypeEarlyWellKnownAttributeData)f_10072_46863_46921(lazyCustomAttributesBag)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 46944, 47000);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10072, 46951, 46963) || ((data != null && DynAbs.Tracing.TraceSender.Conditional_F2(10072, 46966, 46992)) || DynAbs.Tracing.TraceSender.Conditional_F3(10072, 46995, 46999))) ? f_10072_46966_46992(data) : null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 46664, 47019);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 47039, 47291);
                        foreach (var decl in f_10072_47060_47089_I(f_10072_47060_47089(this.declaration)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 47039, 47291);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 47131, 47272) || true) && (f_10072_47135_47156(decl))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 47131, 47272);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 47206, 47249);

                                return ObsoleteAttributeData.Uninitialized;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 47131, 47272);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 47039, 47291);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 253);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 253);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 47311, 47323);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 46555, 47338);

                    bool
                    f_10072_46703_46771(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    this_param)
                    {
                        var return_v = this_param.IsEarlyDecodedWellKnownAttributeDataComputed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 46703, 46771);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                    f_10072_46863_46921(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    this_param)
                    {
                        var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 46863, 46921);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10072_46966_46992(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.ObsoleteAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 46966, 46992);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10072_47060_47089(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.Declarations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 47060, 47089);
                        return return_v;
                    }


                    bool
                    f_10072_47135_47156(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.HasAnyAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 47135, 47156);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10072_47060_47089_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 47060, 47089);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 46469, 47349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 46469, 47349);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 47361, 53261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 47546, 47605);

                f_10072_47546_47604((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 47621, 47657);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 47671, 47706);

                f_10072_47671_47705(f_10072_47684_47704_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 47720, 47781);

                f_10072_47720_47780(arguments.SymbolPart == AttributeLocation.None);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 47797, 53250) || true) && (f_10072_47801_47880(attribute, this, AttributeDescription.AttributeUsageAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 47797, 53250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 47914, 48040);

                    f_10072_47914_48039(this, attribute, arguments.AttributeSyntaxOpt, diagnose: true, diagnosticsOpt: arguments.Diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 47797, 53250);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 47797, 53250);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 48074, 53250) || true) && (f_10072_48078_48156(attribute, this, AttributeDescription.DefaultMemberAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 48074, 53250);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 48190, 48279);

                        arguments.GetOrCreateData<TypeWellKnownAttributeData>().HasDefaultMemberAttribute = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 48074, 53250);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 48074, 53250);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 48313, 53250) || true) && (f_10072_48317_48389(attribute, this, AttributeDescription.CoClassAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 48313, 53250);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 48423, 48461);

                            f_10072_48423_48460(this, ref arguments);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 48313, 53250);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 48313, 53250);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 48495, 53250) || true) && (f_10072_48499_48575(attribute, this, AttributeDescription.ConditionalAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 48495, 53250);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 48609, 48702);

                                f_10072_48609_48701(this, attribute, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 48495, 53250);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 48495, 53250);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 48736, 53250) || true) && (f_10072_48740_48809(attribute, this, AttributeDescription.GuidAttribute))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 48736, 53250);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 48843, 48995);

                                    arguments.GetOrCreateData<TypeWellKnownAttributeData>().GuidString = f_10072_48912_48994(attribute, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 48736, 53250);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 48736, 53250);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 49029, 53250) || true) && (f_10072_49033_49109(attribute, this, AttributeDescription.SpecialNameAttribute))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 49029, 53250);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 49143, 49230);

                                        arguments.GetOrCreateData<TypeWellKnownAttributeData>().HasSpecialNameAttribute = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 49029, 53250);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 49029, 53250);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 49264, 53250) || true) && (f_10072_49268_49345(attribute, this, AttributeDescription.SerializableAttribute))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 49264, 53250);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 49379, 49467);

                                            arguments.GetOrCreateData<TypeWellKnownAttributeData>().HasSerializableAttribute = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 49264, 53250);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 49264, 53250);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 49501, 53250) || true) && (f_10072_49505_49593(attribute, this, AttributeDescription.ExcludeFromCodeCoverageAttribute))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 49501, 53250);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 49627, 49726);

                                                arguments.GetOrCreateData<TypeWellKnownAttributeData>().HasExcludeFromCodeCoverageAttribute = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 49501, 53250);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 49501, 53250);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 49760, 53250) || true) && (f_10072_49764_49841(attribute, this, AttributeDescription.StructLayoutAttribute))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 49760, 53250);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 49875, 50140);

                                                    f_10072_49875_50139(ref arguments, f_10072_50039_50069(this), defaultAutoLayoutSize: 0, messageProvider: MessageProvider.Instance);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 49760, 53250);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 49760, 53250);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 50174, 53250) || true) && (f_10072_50178_50272(attribute, this, AttributeDescription.SuppressUnmanagedCodeSecurityAttribute))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 50174, 53250);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 50306, 50411);

                                                        arguments.GetOrCreateData<TypeWellKnownAttributeData>().HasSuppressUnmanagedCodeSecurityAttribute = true;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 50174, 53250);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 50174, 53250);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 50445, 53250) || true) && (f_10072_50449_50528(attribute, this, AttributeDescription.ClassInterfaceAttribute))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 50445, 53250);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 50562, 50655);

                                                            f_10072_50562_50654(attribute, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 50445, 53250);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 50445, 53250);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 50689, 53250) || true) && (f_10072_50693_50771(attribute, this, AttributeDescription.InterfaceTypeAttribute))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 50689, 53250);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 50805, 50897);

                                                                f_10072_50805_50896(attribute, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 50689, 53250);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 50689, 53250);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 50931, 53250) || true) && (f_10072_50935_51020(attribute, this, AttributeDescription.WindowsRuntimeImportAttribute))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 50931, 53250);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 51054, 51150);

                                                                    arguments.GetOrCreateData<TypeWellKnownAttributeData>().HasWindowsRuntimeImportAttribute = true;
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 50931, 53250);
                                                                }

                                                                else
                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 50931, 53250);

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 51184, 53250) || true) && (f_10072_51188_51270(attribute, this, AttributeDescription.RequiredAttributeAttribute))
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 51184, 53250);
                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 51384, 51494);

                                                                        f_10072_51384_51493(                // CS1608: The Required attribute is not permitted on C# types
                                                                                        arguments.Diagnostics, ErrorCode.ERR_CantUseRequiredAttribute, f_10072_51450_51492(f_10072_51450_51483(arguments.AttributeSyntaxOpt)));
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 51184, 53250);
                                                                    }

                                                                    else
                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 51184, 53250);

                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 51528, 53250) || true) && (f_10072_51532_51992(this, arguments, ReservedAttributes.DynamicAttribute | ReservedAttributes.IsReadOnlyAttribute | ReservedAttributes.IsUnmanagedAttribute | ReservedAttributes.IsByRefLikeAttribute | ReservedAttributes.TupleElementNamesAttribute | ReservedAttributes.NullableAttribute | ReservedAttributes.NullableContextAttribute | ReservedAttributes.NativeIntegerAttribute | ReservedAttributes.CaseSensitiveExtensionAttribute))
                                                                        )

                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 51528, 53250);
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 51528, 53250);
                                                                        }

                                                                        else
                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 51528, 53250);

                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 52042, 53250) || true) && (f_10072_52046_52127(attribute, this, AttributeDescription.SecurityCriticalAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10072, 52046, 52233) || f_10072_52148_52233(attribute, this, AttributeDescription.SecuritySafeCriticalAttribute)))
                                                                            )

                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 52042, 53250);
                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 52267, 52360);

                                                                                arguments.GetOrCreateData<TypeWellKnownAttributeData>().HasSecurityCriticalAttributes = true;
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 52042, 53250);
                                                                            }

                                                                            else
                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 52042, 53250);

                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 52394, 53250) || true) && (f_10072_52398_52477(attribute, this, AttributeDescription.SkipLocalsInitAttribute))
                                                                                )

                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 52394, 53250);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 52511, 52626);

                                                                                    f_10072_52511_52625(f_10072_52589_52609(), ref arguments);
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 52394, 53250);
                                                                                }

                                                                                else
                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 52394, 53250);

                                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 52660, 53250) || true) && (_lazyIsExplicitDefinitionOfNoPiaLocalType == ThreeState.Unknown && (DynAbs.Tracing.TraceSender.Expression_True(10072, 52664, 52810) && f_10072_52731_52810(attribute, this, AttributeDescription.TypeIdentifierAttribute)))
                                                                                    )

                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 52660, 53250);
                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 52844, 52904);

                                                                                        _lazyIsExplicitDefinitionOfNoPiaLocalType = ThreeState.True;
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 52660, 53250);
                                                                                    }

                                                                                    else

                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 52660, 53250);
                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 52970, 53014);

                                                                                        var
                                                                                        compilation = f_10072_52988_53013(this)
                                                                                        ;

                                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 53032, 53235) || true) && (f_10072_53036_53078(attribute, compilation))
                                                                                        )

                                                                                        {
                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 53032, 53235);
                                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 53120, 53216);

                                                                                            f_10072_53120_53215(attribute, this, compilation, ref arguments);
                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 53032, 53235);
                                                                                        }
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 52660, 53250);
                                                                                    }
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 52394, 53250);
                                                                                }
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 52042, 53250);
                                                                            }
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 51528, 53250);
                                                                        }
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 51184, 53250);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 50931, 53250);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 50689, 53250);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 50445, 53250);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 50174, 53250);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 49760, 53250);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 49501, 53250);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 49264, 53250);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 49029, 53250);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 48736, 53250);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 48495, 53250);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 48313, 53250);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 48074, 53250);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 47797, 53250);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 47361, 53261);

                int
                f_10072_47546_47604(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 47546, 47604);
                    return 0;
                }


                bool
                f_10072_47684_47704_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 47684, 47704);
                    return return_v;
                }


                int
                f_10072_47671_47705(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 47671, 47705);
                    return 0;
                }


                int
                f_10072_47720_47780(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 47720, 47780);
                    return 0;
                }


                bool
                f_10072_47801_47880(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 47801, 47880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10072_47914_48039(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, bool
                diagnose, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt)
                {
                    var return_v = this_param.DecodeAttributeUsageAttribute(attribute, node, diagnose: diagnose, diagnosticsOpt: diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 47914, 48039);
                    return return_v;
                }


                bool
                f_10072_48078_48156(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 48078, 48156);
                    return return_v;
                }


                bool
                f_10072_48317_48389(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 48317, 48389);
                    return return_v;
                }


                int
                f_10072_48423_48460(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeCoClassAttribute(ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 48423, 48460);
                    return 0;
                }


                bool
                f_10072_48499_48575(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 48499, 48575);
                    return return_v;
                }


                int
                f_10072_48609_48701(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ValidateConditionalAttribute(attribute, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 48609, 48701);
                    return 0;
                }


                bool
                f_10072_48740_48809(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 48740, 48809);
                    return return_v;
                }


                string
                f_10072_48912_48994(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                nodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.DecodeGuidAttribute(nodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 48912, 48994);
                    return return_v;
                }


                bool
                f_10072_49033_49109(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 49033, 49109);
                    return return_v;
                }


                bool
                f_10072_49268_49345(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 49268, 49345);
                    return return_v;
                }


                bool
                f_10072_49505_49593(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 49505, 49593);
                    return return_v;
                }


                bool
                f_10072_49764_49841(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 49764, 49841);
                    return return_v;
                }


                System.Runtime.InteropServices.CharSet
                f_10072_50039_50069(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DefaultMarshallingCharSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 50039, 50069);
                    return return_v;
                }


                int
                f_10072_49875_50139(ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, System.Runtime.InteropServices.CharSet
                defaultCharSet, int
                defaultAutoLayoutSize, Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider)
                {
                    AttributeData.DecodeStructLayoutAttribute<TypeWellKnownAttributeData, AttributeSyntax, CSharpAttributeData, AttributeLocation>(ref arguments, defaultCharSet, defaultAutoLayoutSize: defaultAutoLayoutSize, messageProvider: (Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 49875, 50139);
                    return 0;
                }


                bool
                f_10072_50178_50272(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 50178, 50272);
                    return return_v;
                }


                bool
                f_10072_50449_50528(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 50449, 50528);
                    return return_v;
                }


                int
                f_10072_50562_50654(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                nodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.DecodeClassInterfaceAttribute(nodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 50562, 50654);
                    return 0;
                }


                bool
                f_10072_50693_50771(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 50693, 50771);
                    return return_v;
                }


                int
                f_10072_50805_50896(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.DecodeInterfaceTypeAttribute(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 50805, 50896);
                    return 0;
                }


                bool
                f_10072_50935_51020(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 50935, 51020);
                    return return_v;
                }


                bool
                f_10072_51188_51270(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 51188, 51270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10072_51450_51483(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 51450, 51483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10072_51450_51492(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 51450, 51492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10072_51384_51493(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 51384, 51493);
                    return return_v;
                }


                bool
                f_10072_51532_51992(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.CSharp.Symbol.ReservedAttributes
                reserved)
                {
                    var return_v = this_param.ReportExplicitUseOfReservedAttributes(arguments, reserved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 51532, 51992);
                    return return_v;
                }


                bool
                f_10072_52046_52127(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 52046, 52127);
                    return return_v;
                }


                bool
                f_10072_52148_52233(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 52148, 52233);
                    return return_v;
                }


                bool
                f_10072_52398_52477(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 52398, 52477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10072_52589_52609()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 52589, 52609);
                    return return_v;
                }


                int
                f_10072_52511_52625(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    CSharpAttributeData.DecodeSkipLocalsInitAttribute<TypeWellKnownAttributeData>(compilation, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 52511, 52625);
                    return 0;
                }


                bool
                f_10072_52731_52810(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 52731, 52810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10072_52988_53013(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 52988, 53013);
                    return return_v;
                }


                bool
                f_10072_53036_53078(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsSecurityAttribute(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 53036, 53078);
                    return return_v;
                }


                int
                f_10072_53120_53215(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeSecurityAttribute<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData>((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, compilation, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 53120, 53215);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 47361, 53261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 47361, 53261);
            }
        }

        internal override bool IsExplicitDefinitionOfNoPiaLocalType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 53357, 53986);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 53393, 53787) || true) && (_lazyIsExplicitDefinitionOfNoPiaLocalType == ThreeState.Unknown)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 53393, 53787);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 53502, 53543);

                        f_10072_53502_53542(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 53567, 53768) || true) && (_lazyIsExplicitDefinitionOfNoPiaLocalType == ThreeState.Unknown)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 53567, 53768);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 53684, 53745);

                            _lazyIsExplicitDefinitionOfNoPiaLocalType = ThreeState.False;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 53567, 53768);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 53393, 53787);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 53807, 53885);

                    f_10072_53807_53884(_lazyIsExplicitDefinitionOfNoPiaLocalType != ThreeState.Unknown);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 53903, 53971);

                    return _lazyIsExplicitDefinitionOfNoPiaLocalType == ThreeState.True;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 53357, 53986);

                    int
                    f_10072_53502_53542(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        this_param.CheckPresenceOfTypeIdentifierAttribute();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 53502, 53542);
                        return 0;
                    }


                    int
                    f_10072_53807_53884(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 53807, 53884);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 53273, 53997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 53273, 53997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void CheckPresenceOfTypeIdentifierAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 54009, 55676);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 54150, 54283) || true) && (f_10072_54154_54219_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyCustomAttributesBag, 10072, 54154, 54219)?.IsDecodedWellKnownAttributeDataComputed) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 54150, 54283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 54261, 54268);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 54150, 54283);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 54571, 54663);

                ImmutableArray<SyntaxList<AttributeListSyntax>>
                attributeLists = f_10072_54636_54662(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 54679, 55665);
                    foreach (SyntaxList<AttributeListSyntax> list in f_10072_54728_54742_I(attributeLists))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 54679, 55665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 54776, 54814);

                        var
                        syntaxTree = f_10072_54793_54813(list.Node)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 54832, 54972);

                        QuickAttributeChecker
                        checker = f_10072_54864_54971(f_10072_54864_54949(f_10072_54864_54928(f_10072_54864_54889(this), f_10072_54907_54927(list.Node)), list.Node))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 54992, 55650);
                            foreach (AttributeListSyntax attrList in f_10072_55033_55037_I(list))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 54992, 55650);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 55079, 55631);
                                    foreach (AttributeSyntax attr in f_10072_55112_55131_I(f_10072_55112_55131(attrList)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 55079, 55631);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 55181, 55608) || true) && (f_10072_55185_55246(checker, attr, QuickAttributes.TypeIdentifier))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 55181, 55608);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 55528, 55544);

                                            f_10072_55528_55543(this);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 55574, 55581);

                                            return;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 55181, 55608);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 55079, 55631);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 553);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 553);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 54992, 55650);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 659);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 659);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 54679, 55665);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 987);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 54009, 55676);

                bool?
                f_10072_54154_54219_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 54154, 54219);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10072_54636_54662(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributeDeclarations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 54636, 54662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10072_54793_54813(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 54793, 54813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10072_54864_54889(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 54864, 54889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10072_54907_54927(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 54907, 54927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10072_54864_54928(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 54864, 54928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10072_54864_54949(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 54864, 54949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                f_10072_54864_54971(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.QuickAttributeChecker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 54864, 54971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                f_10072_55112_55131(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 55112, 55131);
                    return return_v;
                }


                bool
                f_10072_55185_55246(Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attr, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes
                pattern)
                {
                    var return_v = this_param.IsPossibleMatch(attr, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 55185, 55246);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10072_55528_55543(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 55528, 55543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                f_10072_55112_55131_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 55112, 55131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10072_55033_55037_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 55033, 55037);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10072_54728_54742_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 54728, 54742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 54009, 55676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 54009, 55676);
            }
        }

        private AttributeUsageInfo DecodeAttributeUsageAttribute(CSharpAttributeData attribute, AttributeSyntax node, bool diagnose, DiagnosticBag diagnosticsOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 55772, 57383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 55958, 56009);

                f_10072_55958_56008(diagnose == (diagnosticsOpt != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 56023, 56058);

                f_10072_56023_56057(f_10072_56036_56056_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 56074, 56108);

                f_10072_56074_56107(!f_10072_56088_56106(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 56199, 57372) || true) && (!f_10072_56204_56251(f_10072_56204_56229(this), this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 56199, 57372);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 56285, 56474) || true) && (diagnose)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 56285, 56474);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 56339, 56455);

                        f_10072_56339_56454(diagnosticsOpt, ErrorCode.ERR_AttributeUsageOnNonAttributeClass, f_10072_56407_56425(f_10072_56407_56416(node)), f_10072_56427_56453(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 56285, 56474);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 56494, 56525);

                    return AttributeUsageInfo.Null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 56199, 57372);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 56199, 57372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 56591, 56659);

                    AttributeUsageInfo
                    info = f_10072_56617_56658(attribute)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 56801, 57325) || true) && (f_10072_56805_56835_M(!info.HasValidAttributeTargets))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 56801, 57325);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 56877, 57251) || true) && (diagnose)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 56877, 57251);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 56992, 57081);

                            CSharpSyntaxNode
                            attributeArgumentSyntax = f_10072_57035_57080(attribute, 0, node)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 57107, 57228);

                            f_10072_57107_57227(diagnosticsOpt, ErrorCode.ERR_InvalidAttributeArgument, f_10072_57166_57198(attributeArgumentSyntax), f_10072_57200_57226(node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 56877, 57251);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 57275, 57306);

                        return AttributeUsageInfo.Null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 56801, 57325);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 57345, 57357);

                    return info;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 56199, 57372);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 55772, 57383);

                int
                f_10072_55958_56008(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 55958, 56008);
                    return 0;
                }


                bool
                f_10072_56036_56056_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 56036, 56056);
                    return return_v;
                }


                int
                f_10072_56023_56057(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 56023, 56057);
                    return 0;
                }


                bool
                f_10072_56088_56106(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 56088, 56106);
                    return return_v;
                }


                int
                f_10072_56074_56107(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 56074, 56107);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10072_56204_56229(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 56204, 56229);
                    return return_v;
                }


                bool
                f_10072_56204_56251(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                type)
                {
                    var return_v = this_param.IsAttributeType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 56204, 56251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10072_56407_56416(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 56407, 56416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10072_56407_56425(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 56407, 56425);
                    return return_v;
                }


                string
                f_10072_56427_56453(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 56427, 56453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10072_56339_56454(Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 56339, 56454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10072_56617_56658(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.DecodeAttributeUsageAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 56617, 56658);
                    return return_v;
                }


                bool
                f_10072_56805_56835_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 56805, 56835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10072_57035_57080(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    var return_v = attribute.GetAttributeArgumentSyntax(parameterIndex, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 57035, 57080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10072_57166_57198(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 57166, 57198);
                    return return_v;
                }


                string
                f_10072_57200_57226(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 57200, 57226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10072_57107_57227(Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 57107, 57227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 55772, 57383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 55772, 57383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DecodeCoClassAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 57395, 58323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 57561, 57597);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 57611, 57646);

                f_10072_57611_57645(f_10072_57624_57644_M(!attribute.HasErrors));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 57662, 58312) || true) && (f_10072_57666_57688(this) && (DynAbs.Tracing.TraceSender.Expression_True(10072, 57666, 57807) && (f_10072_57693_57718_M(!arguments.HasDecodedData) || (DynAbs.Tracing.TraceSender.Expression_False(10072, 57693, 57806) || (object)f_10072_57730_57798(((TypeWellKnownAttributeData)arguments.DecodedData)) == null))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 57662, 58312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 57841, 57906);

                    TypedConstant
                    argument = f_10072_57866_57902(attribute)[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 57924, 57978);

                    f_10072_57924_57977(argument.Kind == TypedConstantKind.Type);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 57998, 58058);

                    var
                    coClassType = argument.ValueInternal as NamedTypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 58076, 58297) || true) && ((object)coClassType != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 58080, 58149) && f_10072_58111_58131(coClassType) == TypeKind.Class))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 58076, 58297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 58191, 58278);

                        arguments.GetOrCreateData<TypeWellKnownAttributeData>().ComImportCoClass = coClassType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 58076, 58297);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 57662, 58312);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 57395, 58323);

                bool
                f_10072_57624_57644_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 57624, 57644);
                    return return_v;
                }


                int
                f_10072_57611_57645(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 57611, 57645);
                    return 0;
                }


                bool
                f_10072_57666_57688(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 57666, 57688);
                    return return_v;
                }


                bool
                f_10072_57693_57718_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 57693, 57718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10072_57730_57798(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.ComImportCoClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 57730, 57798);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10072_57866_57902(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 57866, 57902);
                    return return_v;
                }


                int
                f_10072_57924_57977(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 57924, 57977);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10072_58111_58131(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 58111, 58131);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 57395, 58323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 57395, 58323);
            }
        }

        internal override bool IsComImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 58394, 58603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 58430, 58520);

                    CommonTypeEarlyWellKnownAttributeData
                    data = f_10072_58475_58519(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 58538, 58588);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 58545, 58587) && f_10072_58561_58587(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 58394, 58603);

                    Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
                    f_10072_58475_58519(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetEarlyDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 58475, 58519);
                        return return_v;
                    }


                    bool
                    f_10072_58561_58587(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasComImportAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 58561, 58587);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 58335, 58614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 58335, 58614);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol ComImportCoClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 58701, 58895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 58737, 58811);

                    TypeWellKnownAttributeData
                    data = f_10072_58771_58810(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 58829, 58880);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10072, 58836, 58848) || ((data != null && DynAbs.Tracing.TraceSender.Conditional_F2(10072, 58851, 58872)) || DynAbs.Tracing.TraceSender.Conditional_F3(10072, 58875, 58879))) ? f_10072_58851_58872(data) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 58701, 58895);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    f_10072_58771_58810(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 58771, 58810);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10072_58851_58872(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.ComImportCoClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 58851, 58872);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 58626, 58906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 58626, 58906);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void ValidateConditionalAttribute(CSharpAttributeData attribute, AttributeSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 58918, 60079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 59064, 59097);

                f_10072_59064_59096(f_10072_59077_59095(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 59111, 59146);

                f_10072_59111_59145(f_10072_59124_59144_M(!attribute.HasErrors));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 59162, 60068) || true) && (!f_10072_59167_59214(f_10072_59167_59192(this), this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 59162, 60068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 59338, 59443);

                    f_10072_59338_59442(                // CS1689: Attribute '{0}' is only valid on methods or attribute classes
                                    diagnostics, ErrorCode.ERR_ConditionalOnNonAttributeClass, f_10072_59400_59413(node), f_10072_59415_59441(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 59162, 60068);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 59162, 60068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 59509, 59594);

                    string
                    name = f_10072_59523_59593(attribute, 0, SpecialType.System_String)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 59614, 60053) || true) && (name == null || (DynAbs.Tracing.TraceSender.Expression_False(10072, 59618, 59670) || !f_10072_59635_59670(name)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 59614, 60053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 59807, 59896);

                        CSharpSyntaxNode
                        attributeArgumentSyntax = f_10072_59850_59895(attribute, 0, node)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 59918, 60034);

                        f_10072_59918_60033(diagnostics, ErrorCode.ERR_BadArgumentToAttribute, f_10072_59972_60004(attributeArgumentSyntax), f_10072_60006_60032(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 59614, 60053);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 59162, 60068);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 58918, 60079);

                bool
                f_10072_59077_59095(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsConditional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 59077, 59095);
                    return return_v;
                }


                int
                f_10072_59064_59096(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 59064, 59096);
                    return 0;
                }


                bool
                f_10072_59124_59144_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 59124, 59144);
                    return return_v;
                }


                int
                f_10072_59111_59145(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 59111, 59145);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10072_59167_59192(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 59167, 59192);
                    return return_v;
                }


                bool
                f_10072_59167_59214(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                type)
                {
                    var return_v = this_param.IsAttributeType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 59167, 59214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10072_59400_59413(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 59400, 59413);
                    return return_v;
                }


                string
                f_10072_59415_59441(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 59415, 59441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10072_59338_59442(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 59338, 59442);
                    return return_v;
                }


                string?
                f_10072_59523_59593(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, int
                i, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetConstructorArgument<string>(i, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 59523, 59593);
                    return return_v;
                }


                bool
                f_10072_59635_59670(string
                name)
                {
                    var return_v = SyntaxFacts.IsValidIdentifier(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 59635, 59670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10072_59850_59895(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    var return_v = attribute.GetAttributeArgumentSyntax(parameterIndex, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 59850, 59895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10072_59972_60004(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 59972, 60004);
                    return return_v;
                }


                string
                f_10072_60006_60032(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 60006, 60032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10072_59918_60033(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 59918, 60033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 58918, 60079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 58918, 60079);
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 60153, 60320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 60189, 60235);

                    var
                    data = f_10072_60200_60234(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 60253, 60305);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 60260, 60304) && f_10072_60276_60304(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 60153, 60320);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    f_10072_60200_60234(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 60200, 60234);
                        return return_v;
                    }


                    bool
                    f_10072_60276_60304(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasSpecialNameAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 60276, 60304);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 60091, 60331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 60091, 60331);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasCodeAnalysisEmbeddedAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 60423, 60604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 60459, 60510);

                    var
                    data = f_10072_60470_60509(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 60528, 60589);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 60535, 60588) && f_10072_60551_60588(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 60423, 60604);

                    Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
                    f_10072_60470_60509(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetEarlyDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 60470, 60509);
                        return return_v;
                    }


                    bool
                    f_10072_60551_60588(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasCodeAnalysisEmbeddedAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 60551, 60588);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 60343, 60615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 60343, 60615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool ShouldAddWinRTMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 60703, 60724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 60709, 60722);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 60703, 60724);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 60627, 60735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 60627, 60735);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsWindowsRuntimeImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 60824, 61028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 60860, 60934);

                    TypeWellKnownAttributeData
                    data = f_10072_60894_60933(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 60952, 61013);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 60959, 61012) && f_10072_60975_61012(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 60824, 61028);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    f_10072_60894_60933(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 60894, 60933);
                        return return_v;
                    }


                    bool
                    f_10072_60975_61012(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasWindowsRuntimeImportAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 60975, 61012);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 60747, 61039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 60747, 61039);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 61118, 61291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 61154, 61205);

                    var
                    data = f_10072_61165_61204(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 61223, 61276);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 61230, 61275) && f_10072_61246_61275(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 61118, 61291);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    f_10072_61165_61204(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 61165, 61204);
                        return return_v;
                    }


                    bool
                    f_10072_61246_61275(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasSerializableAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 61246, 61275);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 61051, 61302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 61051, 61302);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 61382, 61623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 61418, 61469);

                    var
                    data = f_10072_61429_61468(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 61487, 61608);

                    return f_10072_61494_61526_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(data, 10072, 61494, 61526)?.HasSkipLocalsInitAttribute) != true && (DynAbs.Tracing.TraceSender.Expression_True(10072, 61494, 61607) && (f_10072_61539_61570_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10072_61539_61553(), 10072, 61539, 61570)?.AreLocalsZeroed) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10072, 61539, 61606) ?? f_10072_61574_61606(f_10072_61574_61590()))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 61382, 61623);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    f_10072_61429_61468(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 61429, 61468);
                        return return_v;
                    }


                    bool?
                    f_10072_61494_61526_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 61494, 61526);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10072_61539_61553()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 61539, 61553);
                        return return_v;
                    }


                    bool?
                    f_10072_61539_61570_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 61539, 61570);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10072_61574_61590()
                    {
                        var return_v = ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 61574, 61590);
                        return return_v;
                    }


                    bool
                    f_10072_61574_61606(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.AreLocalsZeroed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 61574, 61606);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 61314, 61634);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 61314, 61634);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDirectlyExcludedFromCodeCoverage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 61704, 61799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 61720, 61799);
                    return f_10072_61720_61791_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10072_61720_61754(this), 10072, 61720, 61791)?.HasExcludeFromCodeCoverageAttribute) == true; DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 61704, 61799);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 61704, 61799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 61704, 61799);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool HasInstanceFields()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 61812, 62585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 61869, 61910);

                var
                members = f_10072_61883_61909(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 61933, 61938);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 61924, 62545) || true) && (i < members.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 61960, 61963)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 61924, 62545))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 61924, 62545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 61997, 62016);

                        var
                        m = members[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 62034, 62530) || true) && (f_10072_62038_62049_M(!m.IsStatic))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 62034, 62530);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 62091, 62511);

                            switch (f_10072_62099_62105(m))
                            {

                                case SymbolKind.Field:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 62091, 62511);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 62207, 62219);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 62091, 62511);

                                case SymbolKind.Event:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 62091, 62511);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 62299, 62452) || true) && (f_10072_62303_62335(((EventSymbol)m)) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 62299, 62452);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 62409, 62421);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 62299, 62452);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10072, 62482, 62488);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 62091, 62511);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 62034, 62530);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 622);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 622);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 62561, 62574);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 61812, 62585);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10072_61883_61909(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 61883, 61909);
                    return return_v;
                }


                bool
                f_10072_62038_62049_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 62038, 62049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10072_62099_62105(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 62099, 62105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10072_62303_62335(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 62303, 62335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 61812, 62585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 61812, 62585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override TypeLayout Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 62664, 63621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 62700, 62746);

                    var
                    data = f_10072_62711_62745(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 62764, 62893) || true) && (data != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 62768, 62813) && f_10072_62784_62813(data)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 62764, 62893);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 62855, 62874);

                        return f_10072_62862_62873(data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 62764, 62893);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 62913, 63559) || true) && (f_10072_62917_62930(this) == TypeKind.Struct)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 62913, 63559);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 63447, 63540);

                        return f_10072_63454_63539(LayoutKind.Sequential, (DynAbs.Tracing.TraceSender.Conditional_F1(10072, 63492, 63516) || ((f_10072_63492_63516(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10072, 63519, 63520)) || DynAbs.Tracing.TraceSender.Conditional_F3(10072, 63523, 63524))) ? 0 : 1, alignment: 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 62913, 63559);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 63579, 63606);

                    return default(TypeLayout);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 62664, 63621);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    f_10072_62711_62745(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 62711, 62745);
                        return return_v;
                    }


                    bool
                    f_10072_62784_62813(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasStructLayoutAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 62784, 62813);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeLayout
                    f_10072_62862_62873(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.Layout;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 62862, 62873);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10072_62917_62930(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 62917, 62930);
                        return return_v;
                    }


                    bool
                    f_10072_63492_63516(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.HasInstanceFields();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 63492, 63516);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeLayout
                    f_10072_63454_63539(System.Runtime.InteropServices.LayoutKind
                    kind, int
                    size, int
                    alignment)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TypeLayout(kind, size, alignment: (byte)alignment);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 63454, 63539);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 62597, 63632);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 62597, 63632);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasStructLayoutAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 63707, 63875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 63743, 63789);

                    var
                    data = f_10072_63754_63788(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 63807, 63860);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 63814, 63859) && f_10072_63830_63859(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 63707, 63875);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    f_10072_63754_63788(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 63754, 63788);
                        return return_v;
                    }


                    bool
                    f_10072_63830_63859(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasStructLayoutAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 63830, 63859);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 63644, 63886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 63644, 63886);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CharSet MarshallingCharSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 63967, 64191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 64003, 64049);

                    var
                    data = f_10072_64014_64048(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 64067, 64176);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10072, 64074, 64121) || (((data != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 64075, 64120) && f_10072_64091_64120(data))) && DynAbs.Tracing.TraceSender.Conditional_F2(10072, 64124, 64147)) || DynAbs.Tracing.TraceSender.Conditional_F3(10072, 64150, 64175))) ? f_10072_64124_64147(data) : f_10072_64150_64175();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 63967, 64191);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    f_10072_64014_64048(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 64014, 64048);
                        return return_v;
                    }


                    bool
                    f_10072_64091_64120(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasStructLayoutAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 64091, 64120);
                        return return_v;
                    }


                    System.Runtime.InteropServices.CharSet
                    f_10072_64124_64147(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.MarshallingCharSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 64124, 64147);
                        return return_v;
                    }


                    System.Runtime.InteropServices.CharSet
                    f_10072_64150_64175()
                    {
                        var return_v = DefaultMarshallingCharSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 64150, 64175);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 63898, 64202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 63898, 64202);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 64291, 64462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 64327, 64378);

                    var
                    data = f_10072_64338_64377(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 64396, 64447);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 64403, 64446) && f_10072_64419_64446(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 64291, 64462);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    f_10072_64338_64377(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 64338, 64377);
                        return return_v;
                    }


                    bool
                    f_10072_64419_64446(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasDeclarativeSecurity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 64419, 64446);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 64214, 64473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 64214, 64473);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasSecurityCriticalAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 64553, 64731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 64589, 64640);

                    var
                    data = f_10072_64600_64639(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 64658, 64716);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 64665, 64715) && f_10072_64681_64715(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 64553, 64731);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    f_10072_64600_64639(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 64600, 64639);
                        return return_v;
                    }


                    bool
                    f_10072_64681_64715(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasSecurityCriticalAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 64681, 64715);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 64485, 64742);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 64485, 64742);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 64754, 65401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 64873, 64917);

                var
                attributesBag = f_10072_64893_64916(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 64931, 65023);

                var
                wellKnownData = (TypeWellKnownAttributeData)f_10072_64979_65022(attributesBag)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 65037, 65362) || true) && (wellKnownData != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 65037, 65362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 65096, 65176);

                    SecurityWellKnownAttributeData
                    securityData = f_10072_65142_65175(wellKnownData)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 65194, 65347) || true) && (securityData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 65194, 65347);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 65260, 65328);

                        return f_10072_65267_65327(securityData, f_10072_65302_65326(attributesBag));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 65194, 65347);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 65037, 65362);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 65378, 65390);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 64754, 65401);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10072_64893_64916(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 64893, 64916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10072_64979_65022(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 64979, 65022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SecurityWellKnownAttributeData
                f_10072_65142_65175(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.SecurityInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 65142, 65175);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10072_65302_65326(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 65302, 65326);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10072_65267_65327(Microsoft.CodeAnalysis.SecurityWellKnownAttributeData
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                customAttributes)
                {
                    var return_v = this_param.GetSecurityAttributes<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 65267, 65327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 64754, 65401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 64754, 65401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 65413, 65662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 65509, 65560);

                var
                data = f_10072_65520_65559(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 65574, 65651);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10072, 65581, 65593) || ((data != null && DynAbs.Tracing.TraceSender.Conditional_F2(10072, 65596, 65619)) || DynAbs.Tracing.TraceSender.Conditional_F3(10072, 65622, 65650))) ? f_10072_65596_65619(data) : ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 65413, 65662);

                Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
                f_10072_65520_65559(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetEarlyDecodedWellKnownAttributeData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 65520, 65559);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10072_65596_65619(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.ConditionalSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 65596, 65619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 65413, 65662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 65413, 65662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void PostDecodeWellKnownAttributes(ImmutableArray<CSharpAttributeData> boundAttributes, ImmutableArray<AttributeSyntax> allAttributeSyntaxNodes, DiagnosticBag diagnostics, AttributeLocation symbolPart, WellKnownAttributeData decodedData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 65674, 70205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 65954, 65995);

                f_10072_65954_65994(f_10072_65967_65993_M(!boundAttributes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 66009, 66058);

                f_10072_66009_66057(f_10072_66022_66056_M(!allAttributeSyntaxNodes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 66072, 66143);

                f_10072_66072_66142(boundAttributes.Length == allAttributeSyntaxNodes.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 66157, 66204);

                f_10072_66157_66203(_lazyCustomAttributesBag != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 66218, 66297);

                f_10072_66218_66296(f_10072_66231_66295(_lazyCustomAttributesBag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 66311, 66362);

                f_10072_66311_66361(symbolPart == AttributeLocation.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 66378, 66429);

                var
                data = (TypeWellKnownAttributeData)decodedData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 66445, 69540) || true) && (f_10072_66449_66465(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 66445, 69540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 66499, 66535);

                    f_10072_66499_66534(boundAttributes.Any());

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 66632, 66968) || true) && (data == null || (DynAbs.Tracing.TraceSender.Expression_False(10072, 66636, 66675) || f_10072_66652_66667(data) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 66632, 66968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 66717, 66809);

                        int
                        index = boundAttributes.IndexOfAttribute(this, AttributeDescription.ComImportAttribute)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 66831, 66949);

                        f_10072_66831_66948(diagnostics, ErrorCode.ERR_ComImportWithoutUuidAttribute, f_10072_66892_66936(f_10072_66892_66927(allAttributeSyntaxNodes[index])), f_10072_66938_66947(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 66632, 66968);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 66988, 69065) || true) && (f_10072_66992_67005(this) == TypeKind.Class)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 66988, 69065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 67065, 67114);

                        var
                        baseType = f_10072_67080_67113(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 67136, 67477) || true) && ((object)baseType != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 67140, 67217) && f_10072_67168_67188(baseType) != SpecialType.System_Object))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 67136, 67477);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 67375, 67454);

                            f_10072_67375_67453(                        // CS0424: '{0}': a class with the ComImport attribute cannot specify a base class
                                                    diagnostics, ErrorCode.ERR_ComImportWithBase, f_10072_67424_67438(this)[0], f_10072_67443_67452(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 67136, 67477);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 67501, 67544);

                        var
                        initializers = f_10072_67520_67543(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 67566, 68344) || true) && (f_10072_67570_67600_M(!initializers.IsDefaultOrEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 67566, 68344);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 67650, 68321);
                                foreach (var initializerGroup in f_10072_67683_67695_I(initializers))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 67650, 68321);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 67753, 68294);
                                        foreach (var singleInitializer in f_10072_67787_67803_I(initializerGroup))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 67753, 68294);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 67869, 68263) || true) && (f_10072_67873_67919_M(!singleInitializer.FieldOpt.IsMetadataConstant))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 67869, 68263);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 68120, 68228);

                                                f_10072_68120_68227(                                    // CS8028: '{0}': a class with the ComImport attribute cannot specify field initializers.
                                                                                    diagnostics, ErrorCode.ERR_ComImportWithInitializers, f_10072_68177_68215(singleInitializer.Syntax), f_10072_68217_68226(this));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 67869, 68263);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 67753, 68294);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 542);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 542);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 67650, 68321);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 672);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 672);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 67566, 68344);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 68368, 68409);

                        initializers = f_10072_68383_68408(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 68431, 69046) || true) && (f_10072_68435_68465_M(!initializers.IsDefaultOrEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 68431, 69046);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 68515, 69023);
                                foreach (var initializerGroup in f_10072_68548_68560_I(initializers))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 68515, 69023);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 68618, 68996);
                                        foreach (var singleInitializer in f_10072_68652_68668_I(initializerGroup))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 68618, 68996);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 68857, 68965);

                                            f_10072_68857_68964(                                // CS8028: '{0}': a class with the ComImport attribute cannot specify field initializers.
                                                                            diagnostics, ErrorCode.ERR_ComImportWithInitializers, f_10072_68914_68952(singleInitializer.Syntax), f_10072_68954_68963(this));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 68618, 68996);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 379);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 379);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 68515, 69023);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10072, 1, 509);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10072, 1, 509);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 68431, 69046);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 66988, 69065);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 66445, 69540);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 66445, 69540);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 69099, 69540) || true) && ((object)f_10072_69111_69132(this) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 69099, 69540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 69174, 69210);

                        f_10072_69174_69209(boundAttributes.Any());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 69310, 69400);

                        int
                        index = boundAttributes.IndexOfAttribute(this, AttributeDescription.CoClassAttribute)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 69418, 69525);

                        f_10072_69418_69524(diagnostics, ErrorCode.WRN_CoClassWithoutComImport, f_10072_69473_69512(allAttributeSyntaxNodes[index]), f_10072_69514_69523(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 69099, 69540);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 66445, 69540);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 69667, 70063) || true) && (data != null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 69671, 69717) && f_10072_69687_69717(data)) && (DynAbs.Tracing.TraceSender.Expression_True(10072, 69671, 69740) && this.Indexers.Any()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 69667, 70063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 69774, 69810);

                    f_10072_69774_69809(boundAttributes.Any());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 69830, 69926);

                    int
                    index = boundAttributes.IndexOfAttribute(this, AttributeDescription.DefaultMemberAttribute)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 69944, 70048);

                    f_10072_69944_70047(diagnostics, ErrorCode.ERR_DefaultMemberOnIndexedType, f_10072_70002_70046(f_10072_70002_70037(allAttributeSyntaxNodes[index])));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 69667, 70063);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 70079, 70194);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.PostDecodeWellKnownAttributes(boundAttributes, allAttributeSyntaxNodes, diagnostics, symbolPart, decodedData), 10072, 70079, 70193);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 65674, 70205);

                bool
                f_10072_65967_65993_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 65967, 65993);
                    return return_v;
                }


                int
                f_10072_65954_65994(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 65954, 65994);
                    return 0;
                }


                bool
                f_10072_66022_66056_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 66022, 66056);
                    return return_v;
                }


                int
                f_10072_66009_66057(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 66009, 66057);
                    return 0;
                }


                int
                f_10072_66072_66142(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 66072, 66142);
                    return 0;
                }


                int
                f_10072_66157_66203(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 66157, 66203);
                    return 0;
                }


                bool
                f_10072_66231_66295(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsDecodedWellKnownAttributeDataComputed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 66231, 66295);
                    return return_v;
                }


                int
                f_10072_66218_66296(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 66218, 66296);
                    return 0;
                }


                int
                f_10072_66311_66361(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 66311, 66361);
                    return 0;
                }


                bool
                f_10072_66449_66465(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsComImport;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 66449, 66465);
                    return return_v;
                }


                int
                f_10072_66499_66534(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 66499, 66534);
                    return 0;
                }


                string
                f_10072_66652_66667(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.GuidString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 66652, 66667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10072_66892_66927(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 66892, 66927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10072_66892_66936(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 66892, 66936);
                    return return_v;
                }


                string
                f_10072_66938_66947(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 66938, 66947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10072_66831_66948(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 66831, 66948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10072_66992_67005(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 66992, 67005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10072_67080_67113(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 67080, 67113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10072_67168_67188(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 67168, 67188);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10072_67424_67438(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 67424, 67438);
                    return return_v;
                }


                string
                f_10072_67443_67452(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 67443, 67452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10072_67375_67453(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 67375, 67453);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                f_10072_67520_67543(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.StaticInitializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 67520, 67543);
                    return return_v;
                }


                bool
                f_10072_67570_67600_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 67570, 67600);
                    return return_v;
                }


                bool
                f_10072_67873_67919_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 67873, 67919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10072_68177_68215(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 68177, 68215);
                    return return_v;
                }


                string
                f_10072_68217_68226(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 68217, 68226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10072_68120_68227(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 68120, 68227);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>
                f_10072_67787_67803_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 67787, 67803);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                f_10072_67683_67695_I(System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 67683, 67695);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                f_10072_68383_68408(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InstanceInitializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 68383, 68408);
                    return return_v;
                }


                bool
                f_10072_68435_68465_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 68435, 68465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10072_68914_68952(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 68914, 68952);
                    return return_v;
                }


                string
                f_10072_68954_68963(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 68954, 68963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10072_68857_68964(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 68857, 68964);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>
                f_10072_68652_68668_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 68652, 68668);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                f_10072_68548_68560_I(System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 68548, 68560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10072_69111_69132(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ComImportCoClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 69111, 69132);
                    return return_v;
                }


                int
                f_10072_69174_69209(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 69174, 69209);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10072_69473_69512(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 69473, 69512);
                    return return_v;
                }


                string
                f_10072_69514_69523(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 69514, 69523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10072_69418_69524(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 69418, 69524);
                    return return_v;
                }


                bool
                f_10072_69687_69717(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasDefaultMemberAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 69687, 69717);
                    return return_v;
                }


                int
                f_10072_69774_69809(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 69774, 69809);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10072_70002_70037(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 70002, 70037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10072_70002_70046(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 70002, 70046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10072_69944_70047(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 69944, 70047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 65674, 70205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 65674, 70205);
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 70414, 73389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 70572, 70633);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10072, 70572, 70632);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 70572, 70632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 70649, 70707);

                CSharpCompilation
                compilation = f_10072_70681_70706(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 70723, 71125) || true) && (f_10072_70727_70756(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 70723, 71125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 70960, 71110);

                    f_10072_70960_71109(ref attributes, f_10072_71000_71108(compilation, WellKnownMember.System_Runtime_CompilerServices_ExtensionAttribute__ctor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 70723, 71125);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 71141, 72597) || true) && (f_10072_71145_71163(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 71141, 72597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 71197, 71289);

                    f_10072_71197_71288(ref attributes, f_10072_71237_71287(moduleBuilder, this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 71309, 71350);

                    var
                    obsoleteData = f_10072_71328_71349()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 71368, 71498);

                    f_10072_71368_71497(obsoleteData != ObsoleteAttributeData.Uninitialized, "getting synthesized attributes before attributes are decoded");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 71903, 72582) || true) && (obsoleteData == null && (DynAbs.Tracing.TraceSender.Expression_True(10072, 71907, 71980) && !f_10072_71932_71980(this, ignoreSpanLikeTypes: true)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 71903, 72582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 72022, 72563);

                        f_10072_72022_72562(ref attributes, f_10072_72062_72561(compilation, WellKnownMember.System_ObsoleteAttribute__ctor, f_10072_72170_72500(f_10072_72222_72349(f_10072_72240_72293(compilation, SpecialType.System_String), TypedConstantKind.Primitive, PEModule.ByRefLikeMarker), f_10072_72391_72499(f_10072_72409_72463(compilation, SpecialType.System_Boolean), TypedConstantKind.Primitive, true)), isOptionalUse: true));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 71903, 72582);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 71141, 72597);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 72613, 72772) || true) && (f_10072_72617_72632(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 72613, 72772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 72666, 72757);

                    f_10072_72666_72756(ref attributes, f_10072_72706_72755(moduleBuilder, this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 72613, 72772);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 72788, 73378) || true) && (this.Indexers.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10072, 72788, 73378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 72845, 72907);

                    string
                    defaultMemberName = f_10072_72872_72906(this.Indexers.First())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 72957, 73110);

                    var
                    defaultMemberNameConstant = f_10072_72989_73109(f_10072_73007_73060(compilation, SpecialType.System_String), TypedConstantKind.Primitive, defaultMemberName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 73130, 73363);

                    f_10072_73130_73362(ref attributes, f_10072_73170_73361(compilation, WellKnownMember.System_Reflection_DefaultMemberAttribute__ctor, f_10072_73312_73360(defaultMemberNameConstant)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10072, 72788, 73378);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 70414, 73389);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10072_70681_70706(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 70681, 70706);
                    return return_v;
                }


                bool
                f_10072_70727_70756(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainsExtensionMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 70727, 70756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10072_71000_71108(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 71000, 71108);
                    return return_v;
                }


                int
                f_10072_70960_71109(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 70960, 71109);
                    return 0;
                }


                bool
                f_10072_71145_71163(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsRefLikeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 71145, 71163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10072_71237_71287(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.SynthesizeIsByRefLikeAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 71237, 71287);
                    return return_v;
                }


                int
                f_10072_71197_71288(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 71197, 71288);
                    return 0;
                }


                Microsoft.CodeAnalysis.ObsoleteAttributeData
                f_10072_71328_71349()
                {
                    var return_v = ObsoleteAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 71328, 71349);
                    return return_v;
                }


                int
                f_10072_71368_71497(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 71368, 71497);
                    return 0;
                }


                bool
                f_10072_71932_71980(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                type, bool
                ignoreSpanLikeTypes)
                {
                    var return_v = type.IsRestrictedType(ignoreSpanLikeTypes: ignoreSpanLikeTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 71932, 71980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10072_72240_72293(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 72240, 72293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10072_72222_72349(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, string
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 72222, 72349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10072_72409_72463(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 72409, 72463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10072_72391_72499(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, bool
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 72391, 72499);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10072_72170_72500(Microsoft.CodeAnalysis.TypedConstant
                item1, Microsoft.CodeAnalysis.TypedConstant
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 72170, 72500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10072_72062_72561(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, bool
                isOptionalUse)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments, isOptionalUse: isOptionalUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 72062, 72561);
                    return return_v;
                }


                int
                f_10072_72022_72562(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 72022, 72562);
                    return 0;
                }


                bool
                f_10072_72617_72632(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 72617, 72632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10072_72706_72755(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.SynthesizeIsReadOnlyAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 72706, 72755);
                    return return_v;
                }


                int
                f_10072_72666_72756(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 72666, 72756);
                    return 0;
                }


                string
                f_10072_72872_72906(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 72872, 72906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10072_73007_73060(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 73007, 73060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10072_72989_73109(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, string
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 72989, 73109);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10072_73312_73360(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 73312, 73360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10072_73170_73361(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 73170, 73361);
                    return return_v;
                }


                int
                f_10072_73130_73362(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 73130, 73362);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 70414, 73389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 70414, 73389);
            }
        }

        internal override NamedTypeSymbol AsNativeInteger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 73423, 73689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 73499, 73609);

                f_10072_73499_73608(f_10072_73512_73528(this) == SpecialType.System_IntPtr || (DynAbs.Tracing.TraceSender.Expression_False(10072, 73512, 73607) || f_10072_73561_73577(this) == SpecialType.System_UIntPtr));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 73625, 73678);

                return f_10072_73632_73677(f_10072_73632_73650(), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 73423, 73689);

                Microsoft.CodeAnalysis.SpecialType
                f_10072_73512_73528(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 73512, 73528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10072_73561_73577(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 73561, 73577);
                    return return_v;
                }


                int
                f_10072_73499_73608(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 73499, 73608);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10072_73632_73650()
                {
                    var return_v = ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 73632, 73650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10072_73632_73677(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                underlyingType)
                {
                    var return_v = this_param.GetNativeIntegerType((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)underlyingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 73632, 73677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 73423, 73689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 73423, 73689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol NativeIntegerUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 73763, 73770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 73766, 73770);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 73763, 73770);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 73763, 73770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 73763, 73770);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10072, 73783, 74250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10072, 74081, 74239);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10072, 74088, 74117) || ((t2 is NativeIntegerTypeSymbol && DynAbs.Tracing.TraceSender.Conditional_F2(10072, 74137, 74191)) || DynAbs.Tracing.TraceSender.Conditional_F3(10072, 74211, 74238))) ? f_10072_74137_74191(((NativeIntegerTypeSymbol)t2), this, comparison) : DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(t2, comparison), 10072, 74211, 74238);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10072, 73783, 74250);

                bool
                f_10072_74137_74191(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)other, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 74137, 74191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10072, 73783, 74250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 73783, 74250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceNamedTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10072, 812, 74257);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10072, 812, 74257);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10072, 812, 74257);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10072, 812, 74257);

        Microsoft.CodeAnalysis.CSharp.DeclarationKind
        f_10072_3789_3805(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 3789, 3805);
            return return_v;
        }


        int
        f_10072_4175_4218(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 4175, 4218);
            return 0;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10072_4282_4303(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 4282, 4303);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        f_10072_3702_3718_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10072, 3516, 4500);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData?
        f_10072_61720_61754(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10072, 61720, 61754);
            return return_v;
        }


        bool?
        f_10072_61720_61791_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10072, 61720, 61791);
            return return_v;
        }

    }
}
