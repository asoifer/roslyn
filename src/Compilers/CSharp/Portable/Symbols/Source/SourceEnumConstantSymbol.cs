// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceEnumConstantSymbol : SourceFieldSymbolWithSyntaxReference
    {
        public static SourceEnumConstantSymbol CreateExplicitValuedConstant(
                    SourceMemberContainerTypeSymbol containingEnum,
                    EnumMemberDeclarationSyntax syntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10247, 673, 1120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 916, 953);

                var
                initializer = f_10247_934_952(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 967, 1001);

                f_10247_967_1000(initializer != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 1015, 1109);

                return f_10247_1022_1108(containingEnum, syntax, initializer, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10247, 673, 1120);

                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10247_934_952(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.EqualsValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 934, 952);
                    return return_v;
                }


                int
                f_10247_967_1000(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 967, 1000);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol.ExplicitValuedEnumConstantSymbol
                f_10247_1022_1108(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingEnum, Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                initializer, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol.ExplicitValuedEnumConstantSymbol(containingEnum, syntax, initializer, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 1022, 1108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 673, 1120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 673, 1120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SourceEnumConstantSymbol CreateImplicitValuedConstant(
                    SourceMemberContainerTypeSymbol containingEnum,
                    EnumMemberDeclarationSyntax syntax,
                    SourceEnumConstantSymbol otherConstant,
                    int otherConstantOffset,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10247, 1132, 1938);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 1466, 1927) || true) && ((object)otherConstant == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 1466, 1927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 1533, 1572);

                    f_10247_1533_1571(otherConstantOffset == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 1590, 1667);

                    return f_10247_1597_1666(containingEnum, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 1466, 1927);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 1466, 1927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 1733, 1771);

                    f_10247_1733_1770(otherConstantOffset > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 1789, 1912);

                    return f_10247_1796_1911(containingEnum, syntax, otherConstant, otherConstantOffset, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 1466, 1927);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10247, 1132, 1938);

                int
                f_10247_1533_1571(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 1533, 1571);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol.ZeroValuedEnumConstantSymbol
                f_10247_1597_1666(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingEnum, Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol.ZeroValuedEnumConstantSymbol(containingEnum, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 1597, 1666);
                    return return_v;
                }


                int
                f_10247_1733_1770(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 1733, 1770);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol.ImplicitValuedEnumConstantSymbol
                f_10247_1796_1911(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingEnum, Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol
                otherConstant, int
                otherConstantOffset, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol.ImplicitValuedEnumConstantSymbol(containingEnum, syntax, otherConstant, (uint)otherConstantOffset, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 1796, 1911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 1132, 1938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 1132, 1938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SourceEnumConstantSymbol(SourceMemberContainerTypeSymbol containingEnum, EnumMemberDeclarationSyntax syntax, DiagnosticBag diagnostics)
        : base(f_10247_2116_2130_C(containingEnum), syntax.Identifier.ValueText, f_10247_2161_2182(syntax), syntax.Identifier.GetLocation())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10247, 1950, 2472);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 2241, 2461) || true) && (f_10247_2245_2254(this) == WellKnownMemberNames.EnumBackingFieldName)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 2241, 2461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 2333, 2446);

                    f_10247_2333_2445(diagnostics, ErrorCode.ERR_ReservedEnumerator, f_10247_2383_2401(this), WellKnownMemberNames.EnumBackingFieldName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 2241, 2461);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10247, 1950, 2472);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 1950, 2472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 1950, 2472);
            }
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10247, 2484, 2665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 2599, 2654);

                return TypeWithAnnotations.Create(f_10247_2633_2652(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10247, 2484, 2665);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10247_2633_2652(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 2633, 2652);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 2484, 2665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 2484, 2665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10247, 2741, 2804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 2777, 2789);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10247, 2741, 2804);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 2677, 2815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 2677, 2815);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override DeclarationModifiers Modifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10247, 2908, 3053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 2944, 3038);

                    return DeclarationModifiers.Const | DeclarationModifiers.Static | DeclarationModifiers.Public;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10247, 2908, 3053);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 2827, 3064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 2827, 3064);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public new EnumMemberDeclarationSyntax SyntaxNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10247, 3150, 3253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 3186, 3238);

                    return (EnumMemberDeclarationSyntax)DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.SyntaxNode, 10247, 3222, 3237);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10247, 3150, 3253);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 3076, 3264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 3076, 3264);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override SyntaxList<AttributeListSyntax> AttributeDeclarationSyntaxList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10247, 3382, 3646);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 3418, 3563) || true) && (f_10247_3422_3464(this.containingType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 3418, 3563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 3506, 3544);

                        return f_10247_3513_3543(f_10247_3513_3528(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 3418, 3563);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 3583, 3631);

                    return default(SyntaxList<AttributeListSyntax>);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10247, 3382, 3646);

                    bool
                    f_10247_3422_3464(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.AnyMemberHasAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 3422, 3464);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                    f_10247_3513_3528(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol
                    this_param)
                    {
                        var return_v = this_param.SyntaxNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 3513, 3528);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    f_10247_3513_3543(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.AttributeLists;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 3513, 3543);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 3276, 3657);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 3276, 3657);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10247, 3669, 5202);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 3802, 5191) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 3802, 5191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 3847, 3896);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 3914, 3960);

                        var
                        incompletePart = state.NextIncompletePart
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 3978, 5098);

                        switch (incompletePart)
                        {

                            case CompletionPart.Attributes:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 3978, 5098);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 4099, 4115);

                                f_10247_4099_4114(this);
                                DynAbs.Tracing.TraceSender.TraceBreak(10247, 4141, 4147);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 3978, 5098);

                            case CompletionPart.Type:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 3978, 5098);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 4222, 4266);

                                state.NotePartComplete(CompletionPart.Type);
                                DynAbs.Tracing.TraceSender.TraceBreak(10247, 4292, 4298);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 3978, 5098);

                            case CompletionPart.FixedSize:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 3978, 5098);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 4378, 4416);

                                f_10247_4378_4415(f_10247_4391_4414_M(!this.IsFixedSizeBuffer));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 4442, 4491);

                                state.NotePartComplete(CompletionPart.FixedSize);
                                DynAbs.Tracing.TraceSender.TraceBreak(10247, 4517, 4523);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 3978, 5098);

                            case CompletionPart.ConstantValue:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 3978, 5098);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 4607, 4697);

                                f_10247_4607_4696(this, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false);
                                DynAbs.Tracing.TraceSender.TraceBreak(10247, 4723, 4729);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 3978, 5098);

                            case CompletionPart.None:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 3978, 5098);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 4804, 4811);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 3978, 5098);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 3978, 5098);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 4971, 5047);

                                state.NotePartComplete(CompletionPart.All & ~CompletionPart.FieldSymbolAll);
                                DynAbs.Tracing.TraceSender.TraceBreak(10247, 5073, 5079);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 3978, 5098);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 5118, 5176);

                        state.SpinWaitComplete(incompletePart, cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 3802, 5191);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10247, 3802, 5191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10247, 3802, 5191);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10247, 3669, 5202);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10247_4099_4114(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 4099, 4114);
                    return return_v;
                }


                bool
                f_10247_4391_4414_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 4391, 4414);
                    return return_v;
                }


                int
                f_10247_4378_4415(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 4378, 4415);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10247_4607_4696(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 4607, 4696);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 3669, 5202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 3669, 5202);
            }
        }
        private sealed class ZeroValuedEnumConstantSymbol : SourceEnumConstantSymbol
        {
            public ZeroValuedEnumConstantSymbol(
                            SourceMemberContainerTypeSymbol containingEnum,
                            EnumMemberDeclarationSyntax syntax,
                            DiagnosticBag diagnostics)
            : base(f_10247_5538_5552_C(containingEnum), syntax, diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10247, 5315, 5604);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10247, 5315, 5604);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 5315, 5604);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 5315, 5604);
                }
            }

            protected override ConstantValue MakeConstantValue(HashSet<SourceFieldSymbolWithSyntaxReference> dependencies, bool earlyDecodingWellKnownAttributes, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10247, 5620, 5998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 5829, 5899);

                    var
                    constantType = f_10247_5848_5898(f_10247_5848_5886(f_10247_5848_5867(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 5917, 5983);

                    return f_10247_5924_5982(constantType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10247, 5620, 5998);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10247_5848_5867(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol.ZeroValuedEnumConstantSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 5848, 5867);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10247_5848_5886(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.EnumUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 5848, 5886);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10247_5848_5898(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 5848, 5898);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10247_5924_5982(Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = Microsoft.CodeAnalysis.ConstantValue.Default(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 5924, 5982);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 5620, 5998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 5620, 5998);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ZeroValuedEnumConstantSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10247, 5214, 6009);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10247, 5214, 6009);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 5214, 6009);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10247, 5214, 6009);

            static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            f_10247_5538_5552_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10247, 5315, 5604);
                return return_v;
            }

        }
        private sealed class ExplicitValuedEnumConstantSymbol : SourceEnumConstantSymbol
        {
            private readonly SyntaxReference _equalsValueNodeRef;

            public ExplicitValuedEnumConstantSymbol(
                            SourceMemberContainerTypeSymbol containingEnum,
                            EnumMemberDeclarationSyntax syntax,
                            EqualsValueClauseSyntax initializer,
                            DiagnosticBag diagnostics) : base(f_10247_6476_6490_C(containingEnum), syntax, diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10247, 6195, 6609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 6159, 6178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 6545, 6594);

                    _equalsValueNodeRef = f_10247_6567_6593(initializer);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10247, 6195, 6609);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 6195, 6609);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 6195, 6609);
                }
            }

            protected override ConstantValue MakeConstantValue(HashSet<SourceFieldSymbolWithSyntaxReference> dependencies, bool earlyDecodingWellKnownAttributes, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10247, 6625, 7022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 6834, 7007);

                    return f_10247_6841_7006(this, f_10247_6913_6944(_equalsValueNodeRef), dependencies, earlyDecodingWellKnownAttributes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10247, 6625, 7022);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10247_6913_6944(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 6913, 6944);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10247_6841_7006(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol.ExplicitValuedEnumConstantSymbol
                    symbol, Microsoft.CodeAnalysis.SyntaxNode
                    equalsValueNode, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                    dependencies, bool
                    earlyDecodingWellKnownAttributes, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = ConstantValueUtils.EvaluateFieldConstant((Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol)symbol, (Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax)equalsValueNode, dependencies, earlyDecodingWellKnownAttributes, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 6841, 7006);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 6625, 7022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 6625, 7022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ExplicitValuedEnumConstantSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10247, 6021, 7033);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10247, 6021, 7033);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 6021, 7033);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10247, 6021, 7033);

            Microsoft.CodeAnalysis.SyntaxReference
            f_10247_6567_6593(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
            this_param)
            {
                var return_v = this_param.GetReference();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 6567, 6593);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            f_10247_6476_6490_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10247, 6195, 6609);
                return return_v;
            }

        }
        private sealed class ImplicitValuedEnumConstantSymbol : SourceEnumConstantSymbol
        {
            private readonly SourceEnumConstantSymbol _otherConstant;

            private readonly uint _otherConstantOffset;

            public ImplicitValuedEnumConstantSymbol(
                            SourceMemberContainerTypeSymbol containingEnum,
                            EnumMemberDeclarationSyntax syntax,
                            SourceEnumConstantSymbol otherConstant,
                            uint otherConstantOffset,
                            DiagnosticBag diagnostics) : base(f_10247_7607_7621_C(containingEnum), syntax, diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10247, 7280, 7903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 7192, 7206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 7243, 7263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 7676, 7720);

                    f_10247_7676_7719((object)otherConstant != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 7738, 7776);

                    f_10247_7738_7775(otherConstantOffset > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 7796, 7827);

                    _otherConstant = otherConstant;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 7845, 7888);

                    _otherConstantOffset = otherConstantOffset;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10247, 7280, 7903);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 7280, 7903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 7280, 7903);
                }
            }

            protected override ConstantValue MakeConstantValue(HashSet<SourceFieldSymbolWithSyntaxReference> dependencies, bool earlyDecodingWellKnownAttributes, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10247, 7919, 9244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 8128, 8261);

                    var
                    otherValue = f_10247_8145_8260(_otherConstant, f_10247_8177_8225(this, dependencies), earlyDecodingWellKnownAttributes)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 8394, 8565) || true) && (otherValue == f_10247_8412_8454())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 8394, 8565);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 8496, 8546);

                        return f_10247_8503_8545();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 8394, 8565);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 8583, 8712) || true) && (f_10247_8587_8603(otherValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 8583, 8712);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 8645, 8693);

                        return f_10247_8652_8692();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 8583, 8712);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 8730, 8750);

                    ConstantValue
                    value
                    = default(ConstantValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 8768, 8863);

                    var
                    overflowKind = f_10247_8787_8862(otherValue, _otherConstantOffset, out value)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 8881, 9198) || true) && (overflowKind == EnumOverflowKind.OverflowReport)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10247, 8881, 9198);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 9104, 9179);

                        f_10247_9104_9178(                    // Report an error if the value is immediately
                                                              // outside the range, but not otherwise.
                                            diagnostics, ErrorCode.ERR_EnumeratorOverflow, f_10247_9154_9168(this)[0], this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10247, 8881, 9198);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10247, 9216, 9229);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10247, 7919, 9244);

                    Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                    f_10247_8177_8225(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol.ImplicitValuedEnumConstantSymbol
                    fieldOpt, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                    dependencies)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress((Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol)fieldOpt, dependencies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 8177, 8225);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10247_8145_8260(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                    inProgress, bool
                    earlyDecodingWellKnownAttributes)
                    {
                        var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 8145, 8260);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10247_8412_8454()
                    {
                        var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 8412, 8454);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10247_8503_8545()
                    {
                        var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 8503, 8545);
                        return return_v;
                    }


                    bool
                    f_10247_8587_8603(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.IsBad;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 8587, 8603);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10247_8652_8692()
                    {
                        var return_v = Microsoft.CodeAnalysis.ConstantValue.Bad;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 8652, 8692);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.EnumOverflowKind
                    f_10247_8787_8862(Microsoft.CodeAnalysis.ConstantValue
                    constantValue, uint
                    offset, out Microsoft.CodeAnalysis.ConstantValue
                    offsetValue)
                    {
                        var return_v = EnumConstantHelper.OffsetValue(constantValue, offset, out offsetValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 8787, 8862);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10247_9154_9168(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol.ImplicitValuedEnumConstantSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 9154, 9168);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10247_9104_9178(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = diagnostics.Add(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 9104, 9178);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10247, 7919, 9244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 7919, 9244);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ImplicitValuedEnumConstantSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10247, 7045, 9255);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10247, 7045, 9255);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 7045, 9255);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10247, 7045, 9255);

            int
            f_10247_7676_7719(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 7676, 7719);
                return 0;
            }


            int
            f_10247_7738_7775(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 7738, 7775);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            f_10247_7607_7621_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10247, 7280, 7903);
                return return_v;
            }

        }

        static SourceEnumConstantSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10247, 569, 9262);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10247, 569, 9262);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10247, 569, 9262);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10247, 569, 9262);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10247_2161_2182(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 2161, 2182);
            return return_v;
        }


        string
        f_10247_2245_2254(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 2245, 2254);
            return return_v;
        }


        Microsoft.CodeAnalysis.Location
        f_10247_2383_2401(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol
        this_param)
        {
            var return_v = this_param.ErrorLocation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10247, 2383, 2401);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10247_2333_2445(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10247, 2333, 2445);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10247_2116_2130_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10247, 1950, 2472);
            return return_v;
        }

    }
}
