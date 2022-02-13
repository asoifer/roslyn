// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.CodeGen
{
    internal partial class CodeGenerator
    {
        private void EmitStackAllocInitializers(TypeSymbol type, BoundArrayInitialization inits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10966, 565, 2550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 678, 745);

                f_10966_678_744(type is PointerTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10966, 691, 743) || type is NamedTypeSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 761, 989);

                var
                elementType = ((DynAbs.Tracing.TraceSender.Conditional_F1(10966, 780, 813) || ((f_10966_780_793(type) == TypeKind.Pointer
                && DynAbs.Tracing.TraceSender.Conditional_F2(10966, 833, 887)) || DynAbs.Tracing.TraceSender.Conditional_F3(10966, 907, 982))) ? f_10966_833_887(((PointerTypeSymbol)type)) : f_10966_907_979(((NamedTypeSymbol)type))[0]).Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 1005, 1040);

                var
                initExprs = f_10966_1021_1039(inits)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 1056, 1146);

                var
                initializationStyle = f_10966_1082_1145(this, elementType, initExprs)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 1160, 2539) || true) && (initializationStyle == ArrayInitializerStyle.Element)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 1160, 2539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 1250, 1332);

                    f_10966_1250_1331(this, elementType, initExprs, includeConstants: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 1160, 2539);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 1160, 2539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 1398, 1453);

                    ImmutableArray<byte>
                    data = f_10966_1426_1452(this, initExprs)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 1471, 2524) || true) && (data.All(datum => datum == data[0]))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 1471, 2524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 1552, 1647);

                        f_10966_1552_1646(_builder, data, inits.Syntax, emitInitBlock: true, _diagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 1671, 1881) || true) && (initializationStyle == ArrayInitializerStyle.Mixed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 1671, 1881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 1775, 1858);

                            f_10966_1775_1857(this, elementType, initExprs, includeConstants: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 1671, 1881);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 1471, 2524);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 1471, 2524);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 1923, 2524) || true) && (f_10966_1927_1964(f_10966_1927_1950(elementType)) == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 1923, 2524);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 2011, 2107);

                            f_10966_2011_2106(_builder, data, inits.Syntax, emitInitBlock: false, _diagnostics);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 2131, 2341) || true) && (initializationStyle == ArrayInitializerStyle.Mixed)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 2131, 2341);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 2235, 2318);

                                f_10966_2235_2317(this, elementType, initExprs, includeConstants: false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 2131, 2341);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 1923, 2524);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 1923, 2524);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 2423, 2505);

                            f_10966_2423_2504(this, elementType, initExprs, includeConstants: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 1923, 2524);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 1471, 2524);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 1160, 2539);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10966, 565, 2550);

                int
                f_10966_678_744(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 678, 744);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10966_780_793(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10966, 780, 793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10966_833_887(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10966, 833, 887);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10966_907_979(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10966, 907, 979);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10966_1021_1039(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10966, 1021, 1039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.ArrayInitializerStyle
                f_10966_1082_1145(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits)
                {
                    var return_v = this_param.ShouldEmitBlockInitializerForStackAlloc(elementType, inits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 1082, 1145);
                    return return_v;
                }


                int
                f_10966_1250_1331(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits, bool
                includeConstants)
                {
                    this_param.EmitElementStackAllocInitializers(elementType, inits, includeConstants: includeConstants);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 1250, 1331);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10966_1426_1452(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers)
                {
                    var return_v = this_param.GetRawData(initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 1426, 1452);
                    return return_v;
                }


                int
                f_10966_1552_1646(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                data, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, bool
                emitInitBlock, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitStackAllocBlockInitializer(data, syntaxNode, emitInitBlock: emitInitBlock, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 1552, 1646);
                    return 0;
                }


                int
                f_10966_1775_1857(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits, bool
                includeConstants)
                {
                    this_param.EmitElementStackAllocInitializers(elementType, inits, includeConstants: includeConstants);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 1775, 1857);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10966_1927_1950(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10966, 1927, 1950);
                    return return_v;
                }


                int
                f_10966_1927_1964(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.SizeInBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 1927, 1964);
                    return return_v;
                }


                int
                f_10966_2011_2106(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                data, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, bool
                emitInitBlock, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitStackAllocBlockInitializer(data, syntaxNode, emitInitBlock: emitInitBlock, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 2011, 2106);
                    return 0;
                }


                int
                f_10966_2235_2317(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits, bool
                includeConstants)
                {
                    this_param.EmitElementStackAllocInitializers(elementType, inits, includeConstants: includeConstants);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 2235, 2317);
                    return 0;
                }


                int
                f_10966_2423_2504(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits, bool
                includeConstants)
                {
                    this_param.EmitElementStackAllocInitializers(elementType, inits, includeConstants: includeConstants);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 2423, 2504);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10966, 565, 2550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10966, 565, 2550);
            }
        }

        private ArrayInitializerStyle ShouldEmitBlockInitializerForStackAlloc(TypeSymbol elementType, ImmutableArray<BoundExpression> inits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10966, 2562, 3686);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 2719, 2842) || true) && (f_10966_2723_2756_M(!_module.SupportsPrivateImplClass))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 2719, 2842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 2790, 2827);

                    return ArrayInitializerStyle.Element;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 2719, 2842);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 2858, 2911);

                elementType = f_10966_2872_2910(elementType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 2927, 3622) || true) && (f_10966_2931_2968(f_10966_2931_2954(elementType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 2927, 3622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3002, 3020);

                    int
                    initCount = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3038, 3057);

                    int
                    constCount = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3075, 3140);

                    f_10966_3075_3139(this, inits, ref initCount, ref constCount);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3160, 3607) || true) && (initCount > 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 3160, 3607);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3219, 3354) || true) && (initCount == constCount)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 3219, 3354);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3296, 3331);

                            return ArrayInitializerStyle.Block;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 3219, 3354);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3378, 3426);

                        int
                        thresholdCnt = f_10966_3397_3425(3, (initCount / 3))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3450, 3588) || true) && (constCount >= thresholdCnt)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 3450, 3588);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3530, 3565);

                            return ArrayInitializerStyle.Mixed;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 3450, 3588);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 3160, 3607);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 2927, 3622);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3638, 3675);

                return ArrayInitializerStyle.Element;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10966, 2562, 3686);

                bool
                f_10966_2723_2756_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10966, 2723, 2756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10966_2872_2910(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.EnumUnderlyingTypeOrSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 2872, 2910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10966_2931_2954(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10966, 2931, 2954);
                    return return_v;
                }


                bool
                f_10966_2931_2968(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsBlittable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 2931, 2968);
                    return return_v;
                }


                int
                f_10966_3075_3139(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits, ref int
                initCount, ref int
                constInits)
                {
                    this_param.StackAllocInitializerCount(inits, ref initCount, ref constInits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 3075, 3139);
                    return 0;
                }


                int
                f_10966_3397_3425(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 3397, 3425);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10966, 2562, 3686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10966, 2562, 3686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void StackAllocInitializerCount(ImmutableArray<BoundExpression> inits, ref int initCount, ref int constInits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10966, 3698, 4283);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3840, 3917) || true) && (inits.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 3840, 3917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3895, 3902);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 3840, 3917);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3933, 4272);
                    foreach (var init in f_10966_3954_3959_I(inits))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 3933, 4272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 3993, 4097);

                        f_10966_3993_4096(!(init is BoundArrayInitialization), "Nested initializers are not allowed for stackalloc");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 4117, 4132);

                        initCount += 1;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 4150, 4257) || true) && (f_10966_4154_4172(init) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 4150, 4257);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 4222, 4238);

                            constInits += 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 4150, 4257);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 3933, 4272);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10966, 1, 340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10966, 1, 340);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10966, 3698, 4283);

                int
                f_10966_3993_4096(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 3993, 4096);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10966_4154_4172(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10966, 4154, 4172);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10966_3954_3959_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 3954, 3959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10966, 3698, 4283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10966, 3698, 4283);
            }
        }

        private void EmitElementStackAllocInitializers(TypeSymbol elementType, ImmutableArray<BoundExpression> inits, bool includeConstants)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10966, 4295, 5050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 4452, 4466);

                int
                index = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 4480, 4547);

                int
                elementTypeSizeInBytes = f_10966_4509_4546(f_10966_4509_4532(elementType))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 4561, 5039);
                    foreach (BoundExpression init in f_10966_4594_4599_I(inits))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 4561, 5039);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 4633, 4996) || true) && (includeConstants || (DynAbs.Tracing.TraceSender.Expression_False(10966, 4637, 4683) || f_10966_4657_4675(init) == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 4633, 4996);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 4725, 4759);

                            f_10966_4725_4758(_builder, ILOpCode.Dup);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 4781, 4856);

                            f_10966_4781_4855(this, init, elementType, elementTypeSizeInBytes, index);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 4878, 4911);

                            f_10966_4878_4910(this, init, used: true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 4933, 4977);

                            f_10966_4933_4976(this, elementType, init.Syntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 4633, 4996);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5016, 5024);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 4561, 5039);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10966, 1, 479);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10966, 1, 479);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10966, 4295, 5050);

                Microsoft.CodeAnalysis.SpecialType
                f_10966_4509_4532(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10966, 4509, 4532);
                    return return_v;
                }


                int
                f_10966_4509_4546(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.SizeInBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 4509, 4546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10966_4657_4675(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10966, 4657, 4675);
                    return return_v;
                }


                int
                f_10966_4725_4758(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 4725, 4758);
                    return 0;
                }


                int
                f_10966_4781_4855(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                init, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, int
                elementTypeSizeInBytes, int
                index)
                {
                    this_param.EmitPointerElementAccess(init, elementType, elementTypeSizeInBytes, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 4781, 4855);
                    return 0;
                }


                int
                f_10966_4878_4910(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 4878, 4910);
                    return 0;
                }


                int
                f_10966_4933_4976(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitIndirectStore(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 4933, 4976);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10966_4594_4599_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 4594, 4599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10966, 4295, 5050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10966, 4295, 5050);
            }
        }

        private void EmitPointerElementAccess(BoundExpression init, TypeSymbol elementType, int elementTypeSizeInBytes, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10966, 5062, 6013);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5209, 5279) || true) && (index == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 5209, 5279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5257, 5264);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 5209, 5279);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5295, 6002) || true) && (elementTypeSizeInBytes == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 5295, 6002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5360, 5392);

                    f_10966_5360_5391(_builder, index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5410, 5444);

                    f_10966_5410_5443(_builder, ILOpCode.Add);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 5295, 6002);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 5295, 6002);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5478, 6002) || true) && (index == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 5478, 6002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5526, 5593);

                        f_10966_5526_5592(this, init, elementType, elementTypeSizeInBytes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5611, 5645);

                        f_10966_5611_5644(_builder, ILOpCode.Add);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 5478, 6002);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 5478, 6002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5711, 5743);

                        f_10966_5711_5742(_builder, index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5761, 5798);

                        f_10966_5761_5797(_builder, ILOpCode.Conv_i);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5816, 5883);

                        f_10966_5816_5882(this, init, elementType, elementTypeSizeInBytes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5901, 5935);

                        f_10966_5901_5934(_builder, ILOpCode.Mul);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 5953, 5987);

                        f_10966_5953_5986(_builder, ILOpCode.Add);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 5478, 6002);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 5295, 6002);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10966, 5062, 6013);

                int
                f_10966_5360_5391(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 5360, 5391);
                    return 0;
                }


                int
                f_10966_5410_5443(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 5410, 5443);
                    return 0;
                }


                int
                f_10966_5526_5592(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                init, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, int
                elementTypeSizeInBytes)
                {
                    this_param.EmitIntConstantOrSizeOf(init, elementType, elementTypeSizeInBytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 5526, 5592);
                    return 0;
                }


                int
                f_10966_5611_5644(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 5611, 5644);
                    return 0;
                }


                int
                f_10966_5711_5742(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 5711, 5742);
                    return 0;
                }


                int
                f_10966_5761_5797(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 5761, 5797);
                    return 0;
                }


                int
                f_10966_5816_5882(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                init, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, int
                elementTypeSizeInBytes)
                {
                    this_param.EmitIntConstantOrSizeOf(init, elementType, elementTypeSizeInBytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 5816, 5882);
                    return 0;
                }


                int
                f_10966_5901_5934(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 5901, 5934);
                    return 0;
                }


                int
                f_10966_5953_5986(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 5953, 5986);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10966, 5062, 6013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10966, 5062, 6013);
            }
        }

        private void EmitIntConstantOrSizeOf(BoundExpression init, TypeSymbol elementType, int elementTypeSizeInBytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10966, 6025, 6463);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 6160, 6452) || true) && (elementTypeSizeInBytes == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 6160, 6452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 6225, 6262);

                    f_10966_6225_6261(_builder, ILOpCode.Sizeof);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 6280, 6322);

                    f_10966_6280_6321(this, elementType, init.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 6160, 6452);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10966, 6160, 6452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10966, 6388, 6437);

                    f_10966_6388_6436(_builder, elementTypeSizeInBytes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10966, 6160, 6452);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10966, 6025, 6463);

                int
                f_10966_6225_6261(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 6225, 6261);
                    return 0;
                }


                int
                f_10966_6280_6321(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 6280, 6321);
                    return 0;
                }


                int
                f_10966_6388_6436(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10966, 6388, 6436);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10966, 6025, 6463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10966, 6025, 6463);
            }
        }
    }
}
