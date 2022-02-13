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

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{

    internal struct DynamicTypeDecoder
    {

        private readonly ImmutableArray<bool> _dynamicTransformFlags;

        private readonly AssemblySymbol _containingAssembly;

        private readonly bool _haveCustomModifierFlags;

        private readonly bool _checkLength;

        private int _index;

        private DynamicTypeDecoder(ImmutableArray<bool> dynamicTransformFlags, bool haveCustomModifierFlags, bool checkLength, AssemblySymbol containingAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10698, 2299, 2845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 2477, 2522);

                f_10698_2477_2521(f_10698_2490_2520_M(!dynamicTransformFlags.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 2536, 2585);

                f_10698_2536_2584((object)containingAssembly != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 2601, 2648);

                _dynamicTransformFlags = dynamicTransformFlags;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 2662, 2703);

                _containingAssembly = containingAssembly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 2717, 2768);

                _haveCustomModifierFlags = haveCustomModifierFlags;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 2782, 2809);

                _checkLength = checkLength;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 2823, 2834);

                _index = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10698, 2299, 2845);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 2299, 2845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 2299, 2845);
            }
        }

        internal static TypeSymbol TransformType(
                    TypeSymbol metadataType,
                    int targetSymbolCustomModifierCount,
                    EntityHandle targetSymbolToken,
                    PEModuleSymbol containingModule,
                    RefKind targetSymbolRefKind = RefKind.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10698, 3647, 4621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 3949, 3992);

                f_10698_3949_3991((object)metadataType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 4008, 4051);

                ImmutableArray<bool>
                dynamicTransformFlags
                = default(ImmutableArray<bool>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 4065, 4477) || true) && (f_10698_4069_4158(f_10698_4069_4092(containingModule), targetSymbolToken, out dynamicTransformFlags))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 4065, 4477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 4192, 4462);

                    return TransformTypeInternal(metadataType, f_10698_4235_4270(containingModule), targetSymbolCustomModifierCount, targetSymbolRefKind, dynamicTransformFlags, haveCustomModifierFlags: true, checkLength: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 4065, 4477);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 4590, 4610);

                return metadataType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10698, 3647, 4621);

                int
                f_10698_3949_3991(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 3949, 3991);
                    return 0;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10698_4069_4092(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 4069, 4092);
                    return return_v;
                }


                bool
                f_10698_4069_4158(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, out System.Collections.Immutable.ImmutableArray<bool>
                transformFlags)
                {
                    var return_v = this_param.HasDynamicAttribute(token, out transformFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 4069, 4158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10698_4235_4270(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 4235, 4270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 3647, 4621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 3647, 4621);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeSymbol TransformTypeWithoutCustomModifierFlags(
                    TypeSymbol type,
                    AssemblySymbol containingAssembly,
                    RefKind targetSymbolRefKind,
                    ImmutableArray<bool> dynamicTransformFlags,
                    bool checkLength = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10698, 4633, 5231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 4940, 5220);

                return TransformTypeInternal(type, containingAssembly, 0, targetSymbolRefKind, dynamicTransformFlags, haveCustomModifierFlags: false, checkLength: checkLength);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10698, 4633, 5231);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 4633, 5231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 4633, 5231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeSymbol TransformTypeInternal(
                    TypeSymbol metadataType,
                    AssemblySymbol containingAssembly,
                    int targetSymbolCustomModifierCount,
                    RefKind targetSymbolRefKind,
                    ImmutableArray<bool> dynamicTransformFlags,
                    bool haveCustomModifierFlags,
                    bool checkLength)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10698, 5243, 7038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 5625, 5668);

                f_10698_5625_5667((object)metadataType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 5682, 5731);

                f_10698_5682_5730((object)containingAssembly != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 5745, 5792);

                f_10698_5745_5791(f_10698_5758_5790_M(!dynamicTransformFlags.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 5808, 5937) || true) && (dynamicTransformFlags.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 5808, 5937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 5879, 5922);

                    return f_10698_5886_5921();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 5808, 5937);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 5953, 6071);

                var
                decoder = f_10698_5967_6070(dynamicTransformFlags, haveCustomModifierFlags, checkLength, containingAssembly)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 6221, 6879) || true) && (decoder.HandleCustomModifiers(targetSymbolCustomModifierCount) && (DynAbs.Tracing.TraceSender.Expression_True(10698, 6225, 6333) && decoder.HandleRefKind(targetSymbolRefKind)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 6221, 6879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 6367, 6432);

                    TypeSymbol
                    transformedType = decoder.TransformType(metadataType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 6452, 6864) || true) && ((object)transformedType != null && (DynAbs.Tracing.TraceSender.Expression_True(10698, 6456, 6555) && (!checkLength || (DynAbs.Tracing.TraceSender.Expression_False(10698, 6492, 6554) || decoder._index == dynamicTransformFlags.Length))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 6452, 6864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 6705, 6800);

                        f_10698_6705_6799(checkLength || (DynAbs.Tracing.TraceSender.Expression_False(10698, 6718, 6798) || decoder._dynamicTransformFlags.LastIndexOf(true) < decoder._index));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 6822, 6845);

                        return transformedType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 6452, 6864);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 6221, 6879);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 7007, 7027);

                return metadataType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10698, 5243, 7038);

                int
                f_10698_5625_5667(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 5625, 5667);
                    return 0;
                }


                int
                f_10698_5682_5730(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 5682, 5730);
                    return 0;
                }


                bool
                f_10698_5758_5790_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 5758, 5790);
                    return return_v;
                }


                int
                f_10698_5745_5791(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 5745, 5791);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10698_5886_5921()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 5886, 5921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.DynamicTypeDecoder
                f_10698_5967_6070(System.Collections.Immutable.ImmutableArray<bool>
                dynamicTransformFlags, bool
                haveCustomModifierFlags, bool
                checkLength, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                containingAssembly)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.DynamicTypeDecoder(dynamicTransformFlags, haveCustomModifierFlags, checkLength, containingAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 5967, 6070);
                    return return_v;
                }


                int
                f_10698_6705_6799(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 6705, 6799);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 5243, 7038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 5243, 7038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol TransformType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10698, 7050, 8831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 7124, 7150);

                f_10698_7124_7149(_index >= 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 7166, 7393) || true) && (f_10698_7170_7178_M(!HasFlag) || (DynAbs.Tracing.TraceSender.Expression_False(10698, 7170, 7281) || PeekFlag() && (DynAbs.Tracing.TraceSender.Expression_True(10698, 7199, 7281) && (f_10698_7214_7230(type) != SpecialType.System_Object && (DynAbs.Tracing.TraceSender.Expression_True(10698, 7214, 7280) && !f_10698_7264_7280(type))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 7166, 7393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 7366, 7378);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 7166, 7393);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 7409, 8820);

                switch (f_10698_7417_7426(type))
                {

                    case SymbolKind.ErrorType:
                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 7409, 8820);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 7552, 7872) || true) && (f_10698_7556_7572(type) == SpecialType.System_Object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 7552, 7872);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 7792, 7849);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10698, 7799, 7812) || ((ConsumeFlag() && DynAbs.Tracing.TraceSender.Conditional_F2(10698, 7815, 7841)) || DynAbs.Tracing.TraceSender.Conditional_F3(10698, 7844, 7848))) ? DynamicTypeSymbol.Instance : type;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 7552, 7872);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 7896, 7945);

                        return TransformNamedType((NamedTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 7409, 8820);

                    case SymbolKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 7409, 8820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 8013, 8062);

                        return TransformArrayType((ArrayTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 7409, 8820);

                    case SymbolKind.PointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 7409, 8820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 8132, 8185);

                        return TransformPointerType((PointerTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 7409, 8820);

                    case SymbolKind.FunctionPointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 7409, 8820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 8263, 8332);

                        return TransformFunctionPointerType((FunctionPointerTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 7409, 8820);

                    case SymbolKind.DynamicType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 7409, 8820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 8402, 8484);

                        f_10698_8402_8483(!_haveCustomModifierFlags, "This shouldn't happen during decoding.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 8506, 8648);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10698, 8513, 8526) || ((ConsumeFlag() && DynAbs.Tracing.TraceSender.Conditional_F2(10698, 8554, 8558)) || DynAbs.Tracing.TraceSender.Conditional_F3(10698, 8586, 8647))) ? type
                        : f_10698_8586_8647(_containingAssembly, SpecialType.System_Object);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 7409, 8820);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 7409, 8820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 8698, 8712);

                        ConsumeFlag();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 8734, 8805);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10698, 8741, 8790) || ((HandleCustomModifiers(f_10698_8763_8789(type)) && DynAbs.Tracing.TraceSender.Conditional_F2(10698, 8793, 8797)) || DynAbs.Tracing.TraceSender.Conditional_F3(10698, 8800, 8804))) ? type : null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 7409, 8820);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10698, 7050, 8831);

                int
                f_10698_7124_7149(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 7124, 7149);
                    return 0;
                }


                bool
                f_10698_7170_7178_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 7170, 7178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10698_7214_7230(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 7214, 7230);
                    return return_v;
                }


                bool
                f_10698_7264_7280(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 7264, 7280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10698_7417_7426(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 7417, 7426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10698_7556_7572(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 7556, 7572);
                    return return_v;
                }


                int
                f_10698_8402_8483(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 8402, 8483);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10698_8586_8647(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 8586, 8647);
                    return return_v;
                }


                int
                f_10698_8763_8789(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 8763, 8789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 7050, 8831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 7050, 8831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HandleCustomModifiers(int customModifiersCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10698, 8973, 9678);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 9280, 9370) || true) && (!_haveCustomModifierFlags)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 9280, 9370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 9343, 9355);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 9280, 9370);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 9386, 9426);

                f_10698_9386_9425(customModifiersCount >= 0);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 9451, 9456);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 9442, 9639) || true) && (i < customModifiersCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 9484, 9487)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 9442, 9639))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 9442, 9639);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 9521, 9624) || true) && (f_10698_9525_9533_M(!HasFlag) || (DynAbs.Tracing.TraceSender.Expression_False(10698, 9525, 9550) || ConsumeFlag()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 9521, 9624);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 9592, 9605);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 9521, 9624);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10698, 1, 198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10698, 1, 198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 9655, 9667);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10698, 8973, 9678);

                int
                f_10698_9386_9425(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 9386, 9425);
                    return 0;
                }


                bool
                f_10698_9525_9533_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 9525, 9533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 8973, 9678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 8973, 9678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HandleRefKind(RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10698, 9818, 9986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 9886, 9912);

                f_10698_9886_9911(_index >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 9926, 9975);

                return refKind == RefKind.None || (DynAbs.Tracing.TraceSender.Expression_False(10698, 9933, 9974) || !ConsumeFlag());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10698, 9818, 9986);

                int
                f_10698_9886_9911(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 9886, 9911);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 9818, 9986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 9818, 9986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol TransformNamedType(NamedTypeSymbol namedType, bool isContaining = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10698, 9998, 12377);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 10226, 10355) || true) && (!isContaining)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 10226, 10355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 10277, 10302);

                    var
                    flag = ConsumeFlag()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 10320, 10340);

                    f_10698_10320_10339(!flag);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 10226, 10355);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 10371, 10429);

                NamedTypeSymbol
                containingType = f_10698_10404_10428(namedType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 10443, 10477);

                NamedTypeSymbol
                newContainingType
                = default(NamedTypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 10491, 10986) || true) && ((object)containingType != null && (DynAbs.Tracing.TraceSender.Expression_True(10698, 10495, 10557) && f_10698_10529_10557(containingType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 10491, 10986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 10591, 10676);

                    newContainingType = TransformNamedType(f_10698_10630_10654(namedType), isContaining: true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 10694, 10804) || true) && ((object)newContainingType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 10694, 10804);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 10773, 10785);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 10694, 10804);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 10824, 10870);

                    f_10698_10824_10869(f_10698_10837_10868(newContainingType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 10491, 10986);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 10491, 10986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 10936, 10971);

                    newContainingType = containingType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 10491, 10986);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 11169, 11280);

                ImmutableArray<TypeWithAnnotations>
                typeArguments = f_10698_11221_11279(namedType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 11296, 11397);

                ImmutableArray<TypeWithAnnotations>
                transformedTypeArguments = TransformTypeArguments(typeArguments)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 11491, 11590) || true) && (transformedTypeArguments.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 11491, 11590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 11563, 11575);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 11491, 11590);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 11662, 11781);

                bool
                containerIsChanged = (!f_10698_11690_11779(newContainingType, containingType, TypeCompareKind.ConsiderEverything2))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 11797, 12366) || true) && (containerIsChanged || (DynAbs.Tracing.TraceSender.Expression_False(10698, 11801, 11864) || transformedTypeArguments != typeArguments))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 11797, 12366);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 11898, 12134) || true) && (containerIsChanged)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 11898, 12134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 11962, 12031);

                        namedType = f_10698_11974_12030(f_10698_11974_12002(namedType), newContainingType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 12053, 12115);

                        return namedType.ConstructIfGeneric(transformedTypeArguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 11898, 12134);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 12154, 12268);

                    return f_10698_12161_12267(f_10698_12161_12238(f_10698_12161_12186(namedType), transformedTypeArguments, unbound: false), namedType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 11797, 12366);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 11797, 12366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 12334, 12351);

                    return namedType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 11797, 12366);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10698, 9998, 12377);

                int
                f_10698_10320_10339(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 10320, 10339);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10698_10404_10428(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 10404, 10428);
                    return return_v;
                }


                bool
                f_10698_10529_10557(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 10529, 10557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10698_10630_10654(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 10630, 10654);
                    return return_v;
                }


                bool
                f_10698_10837_10868(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 10837, 10868);
                    return return_v;
                }


                int
                f_10698_10824_10869(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 10824, 10869);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10698_11221_11279(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 11221, 11279);
                    return return_v;
                }


                bool
                f_10698_11690_11779(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 11690, 11779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10698_11974_12002(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 11974, 12002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10698_11974_12030(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 11974, 12030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10698_12161_12186(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 12161, 12186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10698_12161_12238(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.Construct(typeArguments, unbound: unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 12161, 12238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10698_12161_12267(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                original)
                {
                    var return_v = this_param.WithTupleDataFrom(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 12161, 12267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 9998, 12377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 9998, 12377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeWithAnnotations> TransformTypeArguments(ImmutableArray<TypeWithAnnotations> typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10698, 12389, 13735);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 12531, 12625) || true) && (!typeArguments.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 12531, 12625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 12589, 12610);

                    return typeArguments;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 12531, 12625);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 12641, 12722);

                var
                transformedTypeArgsBuilder = f_10698_12674_12721()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 12736, 12764);

                bool
                anyTransformed = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 12778, 13496);
                    foreach (var typeArg in f_10698_12802_12815_I(typeArguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 12778, 13496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 12849, 12909);

                        TypeSymbol
                        transformedTypeArg = TransformType(typeArg.Type)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 12927, 13134) || true) && ((object)transformedTypeArg == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 12927, 13134);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 13007, 13041);

                            f_10698_13007_13040(transformedTypeArgsBuilder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 13063, 13115);

                            return default(ImmutableArray<TypeWithAnnotations>);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 12927, 13134);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 13249, 13355);

                        f_10698_13249_13354(
                                        // Note, modifiers are not involved, this is behavior of the native compiler.
                                        transformedTypeArgsBuilder, typeArg.WithTypeAndModifiers(transformedTypeArg, typeArg.CustomModifiers));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 13373, 13481);

                        anyTransformed |= !f_10698_13392_13480(transformedTypeArg, typeArg.Type, TypeCompareKind.ConsiderEverything2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 12778, 13496);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10698, 1, 719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10698, 1, 719);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 13512, 13653) || true) && (!anyTransformed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 13512, 13653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 13565, 13599);

                    f_10698_13565_13598(transformedTypeArgsBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 13617, 13638);

                    return typeArguments;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 13512, 13653);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 13669, 13724);

                return f_10698_13676_13723(transformedTypeArgsBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10698, 12389, 13735);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10698_12674_12721()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 12674, 12721);
                    return return_v;
                }


                int
                f_10698_13007_13040(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 13007, 13040);
                    return 0;
                }


                int
                f_10698_13249_13354(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 13249, 13354);
                    return 0;
                }


                bool
                f_10698_13392_13480(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 13392, 13480);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10698_12802_12815_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 12802, 12815);
                    return return_v;
                }


                int
                f_10698_13565_13598(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 13565, 13598);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10698_13676_13723(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 13676, 13723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 12389, 13735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 12389, 13735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ArrayTypeSymbol TransformArrayType(ArrayTypeSymbol arrayType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10698, 13747, 14952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 13841, 13866);

                var
                flag = ConsumeFlag()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 13880, 13900);

                f_10698_13880_13899(!flag);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 13916, 14064) || true) && (!HandleCustomModifiers(arrayType.ElementTypeWithAnnotations.CustomModifiers.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 13916, 14064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 14037, 14049);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 13916, 14064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 14080, 14153);

                TypeSymbol
                transformedElementType = TransformType(f_10698_14130_14151(arrayType))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 14167, 14270) || true) && ((object)transformedElementType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 14167, 14270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 14243, 14255);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 14167, 14270);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 14286, 14941);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10698, 14293, 14394) || ((f_10698_14293_14394(transformedElementType, f_10698_14335_14356(arrayType), TypeCompareKind.ConsiderEverything2) && DynAbs.Tracing.TraceSender.Conditional_F2(10698, 14414, 14423)) || DynAbs.Tracing.TraceSender.Conditional_F3(10698, 14443, 14940))) ? arrayType : (DynAbs.Tracing.TraceSender.Conditional_F1(10698, 14443, 14462) || ((f_10698_14443_14462(arrayType) && DynAbs.Tracing.TraceSender.Conditional_F2(10698, 14486, 14673)) || DynAbs.Tracing.TraceSender.Conditional_F3(10698, 14697, 14940))) ? f_10698_14486_14673(_containingAssembly, arrayType.ElementTypeWithAnnotations.WithTypeAndModifiers(transformedElementType, arrayType.ElementTypeWithAnnotations.CustomModifiers)) : f_10698_14697_14940(_containingAssembly, arrayType.ElementTypeWithAnnotations.WithTypeAndModifiers(transformedElementType, arrayType.ElementTypeWithAnnotations.CustomModifiers), f_10698_14885_14899(arrayType), f_10698_14901_14916(arrayType), f_10698_14918_14939(arrayType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10698, 13747, 14952);

                int
                f_10698_13880_13899(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 13880, 13899);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10698_14130_14151(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 14130, 14151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10698_14335_14356(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 14335, 14356);
                    return return_v;
                }


                bool
                f_10698_14293_14394(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 14293, 14394);
                    return return_v;
                }


                bool
                f_10698_14443_14462(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 14443, 14462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10698_14486_14673(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementType)
                {
                    var return_v = ArrayTypeSymbol.CreateSZArray(declaringAssembly, elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 14486, 14673);
                    return return_v;
                }


                int
                f_10698_14885_14899(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 14885, 14899);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10698_14901_14916(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Sizes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 14901, 14916);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10698_14918_14939(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.LowerBounds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 14918, 14939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10698_14697_14940(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementType, int
                rank, System.Collections.Immutable.ImmutableArray<int>
                sizes, System.Collections.Immutable.ImmutableArray<int>
                lowerBounds)
                {
                    var return_v = ArrayTypeSymbol.CreateMDArray(declaringAssembly, elementType, rank, sizes, lowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 14697, 14940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 13747, 14952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 13747, 14952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PointerTypeSymbol TransformPointerType(PointerTypeSymbol pointerType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10698, 14964, 15868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 15066, 15091);

                var
                flag = ConsumeFlag()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 15105, 15125);

                f_10698_15105_15124(!flag);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 15141, 15293) || true) && (!HandleCustomModifiers(pointerType.PointedAtTypeWithAnnotations.CustomModifiers.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 15141, 15293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 15266, 15278);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 15141, 15293);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 15309, 15388);

                TypeSymbol
                transformedPointedAtType = TransformType(f_10698_15361_15386(pointerType))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 15402, 15507) || true) && ((object)transformedPointedAtType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 15402, 15507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 15480, 15492);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 15402, 15507);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 15523, 15857);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10698, 15530, 15637) || ((f_10698_15530_15637(transformedPointedAtType, f_10698_15574_15599(pointerType), TypeCompareKind.ConsiderEverything2) && DynAbs.Tracing.TraceSender.Conditional_F2(10698, 15657, 15668)) || DynAbs.Tracing.TraceSender.Conditional_F3(10698, 15688, 15856))) ? pointerType : f_10698_15688_15856(pointerType.PointedAtTypeWithAnnotations.WithTypeAndModifiers(transformedPointedAtType, pointerType.PointedAtTypeWithAnnotations.CustomModifiers));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10698, 14964, 15868);

                int
                f_10698_15105_15124(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 15105, 15124);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10698_15361_15386(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 15361, 15386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10698_15574_15599(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 15574, 15599);
                    return return_v;
                }


                bool
                f_10698_15530_15637(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 15530, 15637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10698_15688_15856(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                pointedAtType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 15688, 15856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 14964, 15868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 14964, 15868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FunctionPointerTypeSymbol? TransformFunctionPointerType(FunctionPointerTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10698, 15898, 19044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16018, 16043);

                var
                flag = ConsumeFlag()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16057, 16077);

                f_10698_16057_16076(!flag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16093, 16118);

                var
                sig = f_10698_16103_16117(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16134, 16273);

                var (transformedReturnWithAnnotations, madeChanges) = handle(ref this, f_10698_16205_16216(sig), f_10698_16218_16240(sig), f_10698_16242_16271(sig));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16287, 16394) || true) && (transformedReturnWithAnnotations.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 16287, 16394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16367, 16379);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 16287, 16394);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16410, 16480);

                var
                transformedParameters = ImmutableArray<TypeWithAnnotations>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16494, 17607) || true) && (f_10698_16498_16516(sig) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 16494, 17607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16554, 16584);

                    var
                    paramsTransformed = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16602, 16688);

                    var
                    paramsBuilder = f_10698_16622_16687(f_10698_16668_16686(sig))
                    ;
                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16750, 17280);
                            foreach (var param in f_10698_16772_16786_I(f_10698_16772_16786(sig)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 16750, 17280);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16836, 16968);

                                var (transformedParamType, paramTransformed) = handle(ref this, f_10698_16900_16913(param), f_10698_16915_16939(param), f_10698_16941_16966(param));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 16994, 17125) || true) && (transformedParamType.IsDefault)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 16994, 17125);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 17086, 17098);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 16994, 17125);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 17153, 17193);

                                f_10698_17153_17192(
                                                        paramsBuilder, transformedParamType);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 17219, 17257);

                                paramsTransformed |= paramTransformed;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 16750, 17280);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10698, 1, 531);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10698, 1, 531);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 17304, 17412);

                        transformedParameters = (DynAbs.Tracing.TraceSender.Conditional_F1(10698, 17328, 17345) || ((paramsTransformed && DynAbs.Tracing.TraceSender.Conditional_F2(10698, 17348, 17375)) || DynAbs.Tracing.TraceSender.Conditional_F3(10698, 17378, 17411))) ? f_10698_17348_17375(paramsBuilder) : f_10698_17378_17411(sig);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 17434, 17467);

                        madeChanges |= paramsTransformed;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(10698, 17504, 17592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 17552, 17573);

                        f_10698_17552_17572(paramsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(10698, 17504, 17592);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 16494, 17607);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 17623, 17968) || true) && (madeChanges)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 17623, 17968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 17672, 17875);

                    return f_10698_17679_17874(type, transformedReturnWithAnnotations, transformedParameters, refCustomModifiers: default, paramRefCustomModifiers: default);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 17623, 17968);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 17623, 17968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 17941, 17953);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 17623, 17968);
                }

                static (TypeWithAnnotations, bool madeChanges) handle(ref DynamicTypeDecoder decoder, RefKind refKind, ImmutableArray<CustomModifier> refCustomModifiers, TypeWithAnnotations typeWithAnnotations)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10698, 17984, 19033);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 18211, 18512) || true) && (!decoder.HandleCustomModifiers(refCustomModifiers.Length) || (DynAbs.Tracing.TraceSender.Expression_False(10698, 18215, 18328) || !decoder.HandleRefKind(refKind)) || (DynAbs.Tracing.TraceSender.Expression_False(10698, 18215, 18427) || !decoder.HandleCustomModifiers(typeWithAnnotations.CustomModifiers.Length)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 18211, 18512);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 18469, 18493);

                            return (default, false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 18211, 18512);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 18532, 18602);

                        var
                        transformedType = decoder.TransformType(typeWithAnnotations.Type)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 18620, 18732) || true) && (transformedType is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 18620, 18732);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 18689, 18713);

                            return (default, false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 18620, 18732);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 18752, 18937) || true) && (f_10698_18756_18840(transformedType, typeWithAnnotations.Type, TypeCompareKind.ConsiderEverything))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10698, 18752, 18937);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 18882, 18918);

                            return (typeWithAnnotations, false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10698, 18752, 18937);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 18957, 19018);

                        return (typeWithAnnotations.WithType(transformedType), true);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10698, 17984, 19033);

                        bool
                        f_10698_18756_18840(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        t2, Microsoft.CodeAnalysis.TypeCompareKind
                        compareKind)
                        {
                            var return_v = this_param.Equals(t2, compareKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 18756, 18840);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 17984, 19033);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 17984, 19033);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10698, 15898, 19044);

                int
                f_10698_16057_16076(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 16057, 16076);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10698_16103_16117(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 16103, 16117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10698_16205_16216(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 16205, 16216);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10698_16218_16240(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 16218, 16240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10698_16242_16271(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 16242, 16271);
                    return return_v;
                }


                int
                f_10698_16498_16516(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 16498, 16516);
                    return return_v;
                }


                int
                f_10698_16668_16686(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 16668, 16686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10698_16622_16687(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 16622, 16687);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10698_16772_16786(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 16772, 16786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10698_16900_16913(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 16900, 16913);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10698_16915_16939(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 16915, 16939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10698_16941_16966(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 16941, 16966);
                    return return_v;
                }


                int
                f_10698_17153_17192(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 17153, 17192);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10698_16772_16786_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 16772, 16786);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10698_17348_17375(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 17348, 17375);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10698_17378_17411(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 17378, 17411);
                    return return_v;
                }


                int
                f_10698_17552_17572(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 17552, 17572);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10698_17679_17874(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                substitutedReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                substitutedParameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                paramRefCustomModifiers)
                {
                    var return_v = this_param.SubstituteTypeSymbol(substitutedReturnType, substitutedParameterTypes, refCustomModifiers: refCustomModifiers, paramRefCustomModifiers: paramRefCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 17679, 17874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 15898, 19044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 15898, 19044);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasFlag
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10698, 19096, 19154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 19099, 19154);
                    return _index < _dynamicTransformFlags.Length || (DynAbs.Tracing.TraceSender.Expression_False(10698, 19099, 19154) || !_checkLength); DynAbs.Tracing.TraceSender.TraceExitMethod(10698, 19096, 19154);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 19096, 19154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 19096, 19154);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool PeekFlag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10698, 19191, 19266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 19194, 19266);
                return _index < _dynamicTransformFlags.Length && (DynAbs.Tracing.TraceSender.Expression_True(10698, 19194, 19266) && _dynamicTransformFlags[_index]); DynAbs.Tracing.TraceSender.TraceExitMethod(10698, 19191, 19266);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 19191, 19266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 19191, 19266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ConsumeFlag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10698, 19279, 19416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 19330, 19354);

                var
                result = PeekFlag()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 19368, 19377);

                _index++;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10698, 19391, 19405);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10698, 19279, 19416);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10698, 19279, 19416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 19279, 19416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static DynamicTypeDecoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10698, 1815, 19423);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10698, 1815, 19423);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10698, 1815, 19423);
        }

        static bool
        f_10698_2490_2520_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10698, 2490, 2520);
            return return_v;
        }


        static int
        f_10698_2477_2521(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 2477, 2521);
            return 0;
        }


        static int
        f_10698_2536_2584(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10698, 2536, 2584);
            return 0;
        }

    }
}
