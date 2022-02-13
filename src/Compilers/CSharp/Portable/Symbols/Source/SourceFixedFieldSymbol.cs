// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class SourceFixedFieldSymbol : SourceMemberFieldSymbolFromDeclarator
    {
        private const int
        FixedSizeNotInitialized = -1
        ;

        private int _fixedSize;

        internal SourceFixedFieldSymbol(
                    SourceMemberContainerTypeSymbol containingType,
                    VariableDeclaratorSyntax declarator,
                    DeclarationModifiers modifiers,
                    bool modifierErrors,
                    DiagnosticBag diagnostics)
        : base(f_10253_1203_1217_C(containingType), declarator, modifiers, modifierErrors, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10253, 920, 1443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 871, 907);
                this._fixedSize = FixedSizeNotInitialized; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 1395, 1432);

                f_10253_1395_1431(f_10253_1408_1430(this));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10253, 920, 1443);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 920, 1443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 920, 1443);
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 1455, 2390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 1613, 1674);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10253, 1613, 1673);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 1613, 1673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 1690, 1734);

                var
                compilation = f_10253_1708_1733(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 1748, 1821);

                var
                systemType = f_10253_1765_1820(compilation, WellKnownType.System_Type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 1835, 1902);

                var
                intType = f_10253_1849_1901(compilation, SpecialType.System_Int32)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 1916, 2028);

                var
                item1 = f_10253_1928_2027(systemType, TypedConstantKind.Type, f_10253_1982_2026(((PointerTypeSymbol)f_10253_2002_2011(this))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 2042, 2126);

                var
                item2 = f_10253_2054_2125(intType, TypedConstantKind.Primitive, f_10253_2110_2124(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 2140, 2379);

                f_10253_2140_2378(ref attributes, f_10253_2180_2377(compilation, WellKnownMember.System_Runtime_CompilerServices_FixedBufferAttribute__ctor, f_10253_2326_2376(item1, item2)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 1455, 2390);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10253_1708_1733(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFixedFieldSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 1708, 1733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10253_1765_1820(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 1765, 1820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10253_1849_1901(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 1849, 1901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10253_2002_2011(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFixedFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 2002, 2011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10253_1982_2026(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 1982, 2026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10253_1928_2027(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 1928, 2027);
                    return return_v;
                }


                int
                f_10253_2110_2124(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFixedFieldSymbol
                this_param)
                {
                    var return_v = this_param.FixedSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 2110, 2124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10253_2054_2125(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, int
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 2054, 2125);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10253_2326_2376(Microsoft.CodeAnalysis.TypedConstant
                item1, Microsoft.CodeAnalysis.TypedConstant
                item2)
                {
                    var return_v = ImmutableArray.Create<TypedConstant>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 2326, 2376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10253_2180_2377(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 2180, 2377);
                    return return_v;
                }


                int
                f_10253_2140_2378(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 2140, 2378);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 1455, 2390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 1455, 2390);
            }
        }

        public sealed override int FixedSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 2463, 7037);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 2499, 6914) || true) && (_fixedSize == FixedSizeNotInitialized)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10253, 2499, 6914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 2582, 2638);

                        DiagnosticBag
                        diagnostics = f_10253_2610_2637()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 2660, 2673);

                        int
                        size = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 2697, 2758);

                        VariableDeclaratorSyntax
                        declarator = f_10253_2735_2757()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 2780, 6480) || true) && (f_10253_2784_2807(declarator) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10253, 2780, 6480);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10253, 2780, 6480);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10253, 2780, 6480);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 2996, 3078);

                            SeparatedSyntaxList<ArgumentSyntax>
                            arguments = f_10253_3044_3077(f_10253_3044_3067(declarator))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 3106, 6457) || true) && (arguments.Count == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10253, 3110, 3205) || f_10253_3134_3164(f_10253_3134_3157(arguments[0])) == SyntaxKind.OmittedArraySizeExpression))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10253, 3106, 6457);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 3263, 3360);

                                f_10253_3263_3359(f_10253_3276_3319(f_10253_3276_3299(declarator)), "The parser should have caught this.");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10253, 3106, 6457);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10253, 3106, 6457);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 3474, 3688) || true) && (arguments.Count > 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10253, 3474, 3688);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 3563, 3657);

                                    f_10253_3563_3656(diagnostics, ErrorCode.ERR_FixedBufferTooManyDimensions, f_10253_3623_3655(f_10253_3623_3646(declarator)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10253, 3474, 3688);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 3720, 3778);

                                ExpressionSyntax
                                sizeExpression = f_10253_3754_3777(arguments[0])
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 3810, 3895);

                                BinderFactory
                                binderFactory = f_10253_3840_3894(f_10253_3840_3865(this), f_10253_3883_3893())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 3925, 3981);

                                Binder
                                binder = f_10253_3941_3980(binderFactory, sizeExpression)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 4011, 4128);

                                binder = f_10253_4020_4127(f_10253_4020_4101(sizeExpression, f_10253_4061_4092(binder), binder), sizeExpression);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 4160, 4258);

                                TypeSymbol
                                intType = f_10253_4181_4257(binder, SpecialType.System_Int32, diagnostics, sizeExpression)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 4288, 4563);

                                BoundExpression
                                boundSizeExpression = f_10253_4326_4562(binder, intType, f_10253_4441_4515(binder, sizeExpression, diagnostics, Binder.BindValueKind.RValue), diagnostics)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 4806, 4956);

                                ConstantValue
                                sizeConstant = f_10253_4835_4955(boundSizeExpression, this, intType, f_10253_4918_4941(sizeExpression), diagnostics)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 4988, 5023);

                                f_10253_4988_5022(sizeConstant != null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 5053, 5149);

                                f_10253_5053_5148(f_10253_5066_5089(sizeConstant) || (DynAbs.Tracing.TraceSender.Expression_False(10253, 5066, 5119) || f_10253_5093_5119(diagnostics)) || (DynAbs.Tracing.TraceSender.Expression_False(10253, 5066, 5147) || f_10253_5123_5147(sizeExpression)));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 5181, 6430) || true) && (f_10253_5185_5208(sizeConstant))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10253, 5181, 6430);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 5274, 5315);

                                    int
                                    int32Value = f_10253_5291_5314(sizeConstant)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 5349, 6399) || true) && (int32Value > 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10253, 5349, 6399);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 5441, 5459);

                                        size = int32Value;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 5499, 5569);

                                        TypeSymbol
                                        elementType = f_10253_5524_5568(((PointerTypeSymbol)f_10253_5544_5553(this)))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 5607, 5669);

                                        int
                                        elementSize = f_10253_5625_5668(elementType)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 5707, 5754);

                                        long
                                        totalSize = elementSize * 1L * int32Value
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 5792, 6140) || true) && (totalSize > int.MaxValue)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10253, 5792, 6140);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 6006, 6101);

                                            f_10253_6006_6100(                                        // Fixed size buffer of length '{0}' and type '{1}' is too big
                                                                                    diagnostics, ErrorCode.ERR_FixedOverflow, f_10253_6051_6074(sizeExpression), int32Value, elementType);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10253, 5792, 6140);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10253, 5349, 6399);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10253, 5349, 6399);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 6286, 6364);

                                        f_10253_6286_6363(diagnostics, ErrorCode.ERR_InvalidFixedArraySize, f_10253_6339_6362(sizeExpression));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10253, 5349, 6399);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10253, 5181, 6430);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10253, 3106, 6457);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10253, 2780, 6480);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 6555, 6852) || true) && (f_10253_6559_6633(ref _fixedSize, size, FixedSizeNotInitialized) == FixedSizeNotInitialized)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10253, 6555, 6852);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 6710, 6754);

                            f_10253_6710_6753(this, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 6780, 6829);

                            state.NotePartComplete(CompletionPart.FixedSize);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10253, 6555, 6852);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 6876, 6895);

                        f_10253_6876_6894(
                                            diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10253, 2499, 6914);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 6934, 6986);

                    f_10253_6934_6985(_fixedSize != FixedSizeNotInitialized);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 7004, 7022);

                    return _fixedSize;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 2463, 7037);

                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10253_2610_2637()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 2610, 2637);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                    f_10253_2735_2757()
                    {
                        var return_v = VariableDeclaratorNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 2735, 2757);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax?
                    f_10253_2784_2807(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                    this_param)
                    {
                        var return_v = this_param.ArgumentList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 2784, 2807);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax
                    f_10253_3044_3067(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                    this_param)
                    {
                        var return_v = this_param.ArgumentList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 3044, 3067);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                    f_10253_3044_3077(Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax
                    this_param)
                    {
                        var return_v = this_param.Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 3044, 3077);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    f_10253_3134_3157(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                    this_param)
                    {
                        var return_v = this_param.Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 3134, 3157);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10253_3134_3164(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 3134, 3164);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax
                    f_10253_3276_3299(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                    this_param)
                    {
                        var return_v = this_param.ArgumentList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 3276, 3299);
                        return return_v;
                    }


                    bool
                    f_10253_3276_3319(Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax
                    this_param)
                    {
                        var return_v = this_param.ContainsDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 3276, 3319);
                        return return_v;
                    }


                    int
                    f_10253_3263_3359(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 3263, 3359);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax
                    f_10253_3623_3646(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                    this_param)
                    {
                        var return_v = this_param.ArgumentList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 3623, 3646);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10253_3623_3655(Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 3623, 3655);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10253_3563_3656(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location)
                    {
                        var return_v = diagnostics.Add(code, location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 3563, 3656);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    f_10253_3754_3777(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                    this_param)
                    {
                        var return_v = this_param.Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 3754, 3777);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10253_3840_3865(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFixedFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 3840, 3865);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10253_3883_3893()
                    {
                        var return_v = SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 3883, 3893);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory
                    f_10253_3840_3894(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SyntaxTree
                    syntaxTree)
                    {
                        var return_v = this_param.GetBinderFactory(syntaxTree);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 3840, 3894);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10253_3941_3980(Microsoft.CodeAnalysis.CSharp.BinderFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    node)
                    {
                        var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 3941, 3980);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10253_4061_4092(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 4061, 4092);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                    f_10253_4020_4101(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    root, Microsoft.CodeAnalysis.CSharp.Symbol?
                    memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, memberSymbol, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 4020, 4101);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10253_4020_4127(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    node)
                    {
                        var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 4020, 4127);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10253_4181_4257(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    typeId, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    node)
                    {
                        var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 4181, 4257);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10253_4441_4515(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    node, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                    valueKind)
                    {
                        var return_v = this_param.BindValue(node, diagnostics, valueKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 4441, 4515);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10253_4326_4562(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.GenerateConversionForAssignment(targetType, expression, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 4326, 4562);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10253_4918_4941(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 4918, 4941);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10253_4835_4955(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    boundValue, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFixedFieldSymbol
                    thisSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    typeSymbol, Microsoft.CodeAnalysis.Location
                    initValueNodeLocation, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = ConstantValueUtils.GetAndValidateConstantValue(boundValue, (Microsoft.CodeAnalysis.CSharp.Symbol)thisSymbol, typeSymbol, initValueNodeLocation, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 4835, 4955);
                        return return_v;
                    }


                    int
                    f_10253_4988_5022(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 4988, 5022);
                        return 0;
                    }


                    bool
                    f_10253_5066_5089(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.IsIntegral;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 5066, 5089);
                        return return_v;
                    }


                    bool
                    f_10253_5093_5119(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        var return_v = this_param.HasAnyErrors();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 5093, 5119);
                        return return_v;
                    }


                    bool
                    f_10253_5123_5147(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.HasErrors;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 5123, 5147);
                        return return_v;
                    }


                    int
                    f_10253_5053_5148(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 5053, 5148);
                        return 0;
                    }


                    bool
                    f_10253_5185_5208(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.IsIntegral;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 5185, 5208);
                        return return_v;
                    }


                    int
                    f_10253_5291_5314(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Int32Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 5291, 5314);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10253_5544_5553(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFixedFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 5544, 5553);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10253_5524_5568(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PointedAtType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 5524, 5568);
                        return return_v;
                    }


                    int
                    f_10253_5625_5668(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.FixedBufferElementSizeInBytes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 5625, 5668);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10253_6051_6074(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 6051, 6074);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10253_6006_6100(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = diagnostics.Add(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 6006, 6100);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10253_6339_6362(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 6339, 6362);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10253_6286_6363(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location)
                    {
                        var return_v = diagnostics.Add(code, location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 6286, 6363);
                        return return_v;
                    }


                    int
                    f_10253_6559_6633(ref int
                    location1, int
                    value, int
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 6559, 6633);
                        return return_v;
                    }


                    int
                    f_10253_6710_6753(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFixedFieldSymbol
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        this_param.AddDeclarationDiagnostics(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 6710, 6753);
                        return 0;
                    }


                    int
                    f_10253_6876_6894(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 6876, 6894);
                        return 0;
                    }


                    int
                    f_10253_6934_6985(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 6934, 6985);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 2402, 7048);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 2402, 7048);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol FixedImplementationType(PEModuleBuilder emitModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 7060, 7232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 7170, 7221);

                return f_10253_7177_7220(emitModule, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 7060, 7232);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10253_7177_7220(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFixedFieldSymbol
                field)
                {
                    var return_v = this_param.SetFixedImplementationType((Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 7177, 7220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 7060, 7232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 7060, 7232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceFixedFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10253, 623, 7239);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 735, 763);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10253, 623, 7239);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 623, 7239);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10253, 623, 7239);

        bool
        f_10253_1408_1430(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFixedFieldSymbol
        this_param)
        {
            var return_v = this_param.IsFixedSizeBuffer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 1408, 1430);
            return return_v;
        }


        int
        f_10253_1395_1431(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 1395, 1431);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10253_1203_1217_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10253, 920, 1443);
            return return_v;
        }

    }
    internal sealed class FixedFieldImplementationType : SynthesizedContainer
    {
        internal const string
        FixedElementFieldName = "FixedElementField"
        ;

        private readonly SourceMemberFieldSymbol _field;

        private readonly MethodSymbol _constructor;

        private readonly FieldSymbol _internalField;

        public FixedFieldImplementationType(SourceMemberFieldSymbol field)
        : base(f_10253_7669_7728_C(f_10253_7669_7728(f_10253_7717_7727(field))), typeParameters: ImmutableArray<TypeParameterSymbol>.Empty, typeMap: f_10253_7798_7811())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10253, 7582, 8083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 7456, 7462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 7503, 7515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 7555, 7569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 7837, 7852);

                _field = field;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 7866, 7922);

                _constructor = f_10253_7881_7921(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 7936, 8072);

                _internalField = f_10253_7953_8071(this, f_10253_7986_8031(((PointerTypeSymbol)f_10253_8006_8016(field))), FixedElementFieldName, isPublic: true);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10253, 7582, 8083);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 7582, 8083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 7582, 8083);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 8159, 8196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 8165, 8194);

                    return f_10253_8172_8193(_field);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 8159, 8196);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10253_8172_8193(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 8172, 8193);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 8095, 8207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 8095, 8207);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeKind TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 8277, 8308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 8283, 8306);

                    return TypeKind.Struct;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 8277, 8308);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 8219, 8319);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 8219, 8319);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MethodSymbol Constructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 8398, 8426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 8404, 8424);

                    return _constructor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 8398, 8426);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 8331, 8437);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 8331, 8437);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeLayout Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 8509, 9000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 8545, 8578);

                    int
                    nElements = f_10253_8561_8577(_field)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 8596, 8661);

                    var
                    elementType = f_10253_8614_8660(((PointerTypeSymbol)f_10253_8634_8645(_field)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 8679, 8741);

                    int
                    elementSize = f_10253_8697_8740(elementType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 8759, 8783);

                    const int
                    alignment = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 8801, 8841);

                    int
                    totalSize = nElements * elementSize
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 8859, 8911);

                    const LayoutKind
                    layoutKind = LayoutKind.Sequential
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 8929, 8985);

                    return f_10253_8936_8984(layoutKind, totalSize, alignment);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 8509, 9000);

                    int
                    f_10253_8561_8577(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.FixedSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 8561, 8577);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10253_8634_8645(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 8634, 8645);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10253_8614_8660(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PointedAtType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 8614, 8660);
                        return return_v;
                    }


                    int
                    f_10253_8697_8740(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.FixedBufferElementSizeInBytes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 8697, 8740);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeLayout
                    f_10253_8936_8984(System.Runtime.InteropServices.LayoutKind
                    kind, int
                    size, int
                    alignment)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TypeLayout(kind, size, (byte)alignment);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 8936, 8984);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 8449, 9011);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 8449, 9011);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 9092, 9441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 9378, 9426);

                    return f_10253_9385_9425(f_10253_9385_9406(_field));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 9092, 9441);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10253_9385_9406(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 9385, 9406);
                        return return_v;
                    }


                    System.Runtime.InteropServices.CharSet
                    f_10253_9385_9425(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingCharSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 9385, 9425);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 9023, 9452);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 9023, 9452);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override FieldSymbol FixedElementField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 9534, 9564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 9540, 9562);

                    return _internalField;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 9534, 9564);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 9462, 9575);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 9462, 9575);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 9587, 10057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 9745, 9806);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10253, 9745, 9805);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 9745, 9805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 9820, 9876);

                var
                compilation = f_10253_9838_9875(f_10253_9838_9854())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 9890, 10046);

                f_10253_9890_10045(ref attributes, f_10253_9930_10044(compilation, WellKnownMember.System_Runtime_CompilerServices_UnsafeValueTypeAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 9587, 10057);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10253_9838_9854()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 9838, 9854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10253_9838_9875(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 9838, 9875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10253_9930_10044(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 9930, 10044);
                    return return_v;
                }


                int
                f_10253_9890_10045(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 9890, 10045);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 9587, 10057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 9587, 10057);
            }
        }

        public override IEnumerable<string> MemberNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 10141, 10222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 10147, 10220);

                    return f_10253_10154_10219(FixedElementFieldName);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 10141, 10222);

                    System.Collections.Generic.IEnumerable<string>
                    f_10253_10154_10219(string
                    value)
                    {
                        var return_v = SpecializedCollections.SingletonEnumerable(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 10154, 10219);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 10069, 10233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 10069, 10233);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 10245, 10399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 10321, 10388);

                return f_10253_10328_10387(_constructor, _internalField);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 10245, 10399);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10253_10328_10387(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                item2)
                {
                    var return_v = ImmutableArray.Create<Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol)item1, (Microsoft.CodeAnalysis.CSharp.Symbol)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 10328, 10387);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 10245, 10399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 10245, 10399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 10411, 10754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 10498, 10743);

                return
                (DynAbs.Tracing.TraceSender.Conditional_F1(10253, 10522, 10549) || (((name == f_10253_10531_10548(_constructor)) && DynAbs.Tracing.TraceSender.Conditional_F2(10253, 10552, 10595)) || DynAbs.Tracing.TraceSender.Conditional_F3(10253, 10615, 10742))) ? f_10253_10552_10595(_constructor) : (DynAbs.Tracing.TraceSender.Conditional_F1(10253, 10615, 10646) || (((name == FixedElementFieldName) && DynAbs.Tracing.TraceSender.Conditional_F2(10253, 10649, 10694)) || DynAbs.Tracing.TraceSender.Conditional_F3(10253, 10714, 10742))) ? f_10253_10649_10694(_internalField) : ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 10411, 10754);

                string
                f_10253_10531_10548(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 10531, 10548);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10253_10552_10595(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 10552, 10595);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10253_10649_10694(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 10649, 10694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 10411, 10754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 10411, 10754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 10842, 10878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 10848, 10876);

                    return Accessibility.Public;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 10842, 10878);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 10766, 10889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 10766, 10889);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 10977, 11043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 10980, 11043);
                    return f_10253_10980_11043(f_10253_10980_10998(), SpecialType.System_ValueType); DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 10977, 11043);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 10977, 11043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 10977, 11043);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 11113, 11152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 11116, 11152);
                    throw f_10253_11122_11152(); DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 11113, 11152);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 11113, 11152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 11113, 11152);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 11197, 11205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 11200, 11205);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 11197, 11205);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 11197, 11205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 11197, 11205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10253, 11273, 11281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 11276, 11281);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10253, 11273, 11281);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10253, 11273, 11281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 11273, 11281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FixedFieldImplementationType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10253, 7247, 11289);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10253, 7359, 7402);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10253, 7247, 11289);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10253, 7247, 11289);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10253, 7247, 11289);

        static string
        f_10253_7717_7727(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 7717, 7727);
            return return_v;
        }


        static string
        f_10253_7669_7728(string
        fieldName)
        {
            var return_v = GeneratedNames.MakeFixedFieldImplementationName(fieldName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 7669, 7728);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10253_7798_7811()
        {
            var return_v = TypeMap.Empty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 7798, 7811);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
        f_10253_7881_7921(Microsoft.CodeAnalysis.CSharp.Symbols.FixedFieldImplementationType
        containingType)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 7881, 7921);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10253_8006_8016(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 8006, 8016);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10253_7986_8031(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
        this_param)
        {
            var return_v = this_param.PointedAtType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 7986, 8031);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
        f_10253_7953_8071(Microsoft.CodeAnalysis.CSharp.Symbols.FixedFieldImplementationType
        containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type, string
        name, bool
        isPublic)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, type, name, isPublic: isPublic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 7953, 8071);
            return return_v;
        }


        static string
        f_10253_7669_7728_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10253, 7582, 8083);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10253_10980_10998()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 10980, 10998);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10253_10980_11043(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialType
        type)
        {
            var return_v = this_param.GetSpecialType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10253, 10980, 11043);
            return return_v;
        }


        System.Exception
        f_10253_11122_11152()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10253, 11122, 11152);
            return return_v;
        }

    }
}
