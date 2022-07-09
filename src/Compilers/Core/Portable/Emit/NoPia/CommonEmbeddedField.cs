// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CodeGen;

namespace Microsoft.CodeAnalysis.Emit.NoPia
{
    internal abstract partial class EmbeddedTypesManager<
            TPEModuleBuilder,
            TModuleCompilationState,
            TEmbeddedTypesManager,
            TSyntaxNode,
            TAttributeData,
            TSymbol,
            TAssemblySymbol,
            TNamedTypeSymbol,
            TFieldSymbol,
            TMethodSymbol,
            TEventSymbol,
            TPropertySymbol,
            TParameterSymbol,
            TTypeParameterSymbol,
            TEmbeddedType,
            TEmbeddedField,
            TEmbeddedMethod,
            TEmbeddedEvent,
            TEmbeddedProperty,
            TEmbeddedParameter,
            TEmbeddedTypeParameter>
    {
        internal abstract class CommonEmbeddedField : CommonEmbeddedMember<TFieldSymbol>, Cci.IFieldDefinition
        {
            public readonly TEmbeddedType ContainingType;

            protected CommonEmbeddedField(TEmbeddedType containingType, TFieldSymbol underlyingField) : base(f_771_1286_1301_C<TFieldSymbol>(underlyingField))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(771, 1172, 1387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 1141, 1155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 1335, 1372);

                    this.ContainingType = containingType;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(771, 1172, 1387);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 1172, 1387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 1172, 1387);
                }
            }

            public TFieldSymbol UnderlyingField
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 1471, 1558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 1515, 1539);

                        return UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 1471, 1558);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 1403, 1573);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 1403, 1573);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected abstract MetadataConstant GetCompileTimeValue(EmitContext context);

            protected abstract bool IsCompileTimeConstant { get; }

            protected abstract bool IsNotSerialized { get; }

            protected abstract bool IsReadOnly { get; }

            protected abstract bool IsRuntimeSpecial { get; }

            protected abstract bool IsSpecialName { get; }

            protected abstract bool IsStatic { get; }

            protected abstract bool IsMarshalledExplicitly { get; }

            protected abstract Cci.IMarshallingInformation MarshallingInformation { get; }

            protected abstract ImmutableArray<byte> MarshallingDescriptor { get; }

            protected abstract int? TypeLayoutOffset { get; }

            protected abstract Cci.TypeMemberVisibility Visibility { get; }

            protected abstract string Name { get; }

            MetadataConstant Cci.IFieldDefinition.GetCompileTimeValue(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 2485, 2647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 2596, 2632);

                    return f_771_2603_2631(this, context);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(771, 2485, 2647);

                    Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                    f_771_2603_2631(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedField
                    this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                    context)
                    {
                        var return_v = this_param.GetCompileTimeValue(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(771, 2603, 2631);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 2485, 2647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 2485, 2647);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            ImmutableArray<byte> Cci.IFieldDefinition.MappedData
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 2748, 2848);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 2792, 2829);

                        return default(ImmutableArray<byte>);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 2748, 2848);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 2663, 2863);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 2663, 2863);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IFieldDefinition.IsCompileTimeConstant
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 2959, 3051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 3003, 3032);

                        return f_771_3010_3031();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 2959, 3051);

                        bool
                        f_771_3010_3031()
                        {
                            var return_v = IsCompileTimeConstant;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 3010, 3031);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 2879, 3066);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 2879, 3066);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IFieldDefinition.IsNotSerialized
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 3156, 3242);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 3200, 3223);

                        return f_771_3207_3222();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 3156, 3242);

                        bool
                        f_771_3207_3222()
                        {
                            var return_v = IsNotSerialized;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 3207, 3222);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 3082, 3257);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 3082, 3257);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IFieldDefinition.IsReadOnly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 3342, 3423);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 3386, 3404);

                        return f_771_3393_3403();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 3342, 3423);

                        bool
                        f_771_3393_3403()
                        {
                            var return_v = IsReadOnly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 3393, 3403);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 3273, 3438);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 3273, 3438);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IFieldDefinition.IsRuntimeSpecial
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 3529, 3616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 3573, 3597);

                        return f_771_3580_3596();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 3529, 3616);

                        bool
                        f_771_3580_3596()
                        {
                            var return_v = IsRuntimeSpecial;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 3580, 3596);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 3454, 3631);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 3454, 3631);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IFieldDefinition.IsSpecialName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 3719, 3803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 3763, 3784);

                        return f_771_3770_3783();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 3719, 3803);

                        bool
                        f_771_3770_3783()
                        {
                            var return_v = IsSpecialName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 3770, 3783);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 3647, 3818);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 3647, 3818);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IFieldDefinition.IsStatic
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 3901, 3980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 3945, 3961);

                        return f_771_3952_3960();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 3901, 3980);

                        bool
                        f_771_3952_3960()
                        {
                            var return_v = IsStatic;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 3952, 3960);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 3834, 3995);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 3834, 3995);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IFieldDefinition.IsMarshalledExplicitly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 4092, 4185);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 4136, 4166);

                        return f_771_4143_4165();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 4092, 4185);

                        bool
                        f_771_4143_4165()
                        {
                            var return_v = IsMarshalledExplicitly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 4143, 4165);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 4011, 4200);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 4011, 4200);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IMarshallingInformation Cci.IFieldDefinition.MarshallingInformation
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 4320, 4413);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 4364, 4394);

                        return f_771_4371_4393();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 4320, 4413);

                        Microsoft.Cci.IMarshallingInformation
                        f_771_4371_4393()
                        {
                            var return_v = MarshallingInformation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 4371, 4393);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 4216, 4428);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 4216, 4428);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            ImmutableArray<byte> Cci.IFieldDefinition.MarshallingDescriptor
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 4540, 4632);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 4584, 4613);

                        return f_771_4591_4612();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 4540, 4632);

                        System.Collections.Immutable.ImmutableArray<byte>
                        f_771_4591_4612()
                        {
                            var return_v = MarshallingDescriptor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 4591, 4612);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 4444, 4647);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 4444, 4647);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            int Cci.IFieldDefinition.Offset
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 4727, 4819);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 4771, 4800);

                        return f_771_4778_4794() ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(771, 4778, 4799) ?? 0);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 4727, 4819);

                        int?
                        f_771_4778_4794()
                        {
                            var return_v = TypeLayoutOffset;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 4778, 4794);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 4663, 4834);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 4663, 4834);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeDefinition Cci.ITypeDefinitionMember.ContainingTypeDefinition
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 4953, 5038);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 4997, 5019);

                        return ContainingType;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 4953, 5038);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 4850, 5053);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 4850, 5053);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.TypeMemberVisibility Cci.ITypeDefinitionMember.Visibility
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 5163, 5244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 5207, 5225);

                        return f_771_5214_5224();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 5163, 5244);

                        Microsoft.Cci.TypeMemberVisibility
                        f_771_5214_5224()
                        {
                            var return_v = Visibility;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 5214, 5224);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 5069, 5259);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 5069, 5259);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeReference Cci.ITypeMemberReference.GetContainingType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 5275, 5427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 5390, 5412);

                    return ContainingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(771, 5275, 5427);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 5275, 5427);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 5275, 5427);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 5443, 5590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 5533, 5575);

                    f_771_5533_5574(visitor, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(771, 5443, 5590);

                    int
                    f_771_5533_5574(Microsoft.Cci.MetadataVisitor
                    this_param, Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedField
                    fieldDefinition)
                    {
                        this_param.Visit((Microsoft.Cci.IFieldDefinition)fieldDefinition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(771, 5533, 5574);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 5443, 5590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 5443, 5590);
                }
            }

            Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 5606, 5730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 5703, 5715);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(771, 5606, 5730);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 5606, 5730);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 5606, 5730);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            string Cci.INamedEntity.Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 5807, 5882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 5851, 5863);

                        return f_771_5858_5862();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 5807, 5882);

                        string
                        f_771_5858_5862()
                        {
                            var return_v = Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 5858, 5862);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 5746, 5897);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 5746, 5897);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeReference Cci.IFieldReference.GetType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 5913, 6068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 6013, 6053);

                    return f_771_6020_6052(f_771_6020_6035(), context);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(771, 5913, 6068);

                    TFieldSymbol
                    f_771_6020_6035()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(771, 6020, 6035);
                        return return_v;
                    }


                    Microsoft.Cci.ITypeReference
                    f_771_6020_6052(TFieldSymbol
                    this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                    context)
                    {
                        var return_v = this_param.GetType(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(771, 6020, 6052);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 5913, 6068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 5913, 6068);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            Cci.IFieldDefinition Cci.IFieldReference.GetResolvedField(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 6084, 6222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 6195, 6207);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(771, 6084, 6222);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 6084, 6222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 6084, 6222);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            Cci.ISpecializedFieldReference Cci.IFieldReference.AsSpecializedFieldReference
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 6349, 6424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 6393, 6405);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 6349, 6424);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 6238, 6439);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 6238, 6439);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IFieldReference.IsContextualNamedEntity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(771, 6536, 6612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(771, 6580, 6593);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(771, 6536, 6612);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(771, 6455, 6627);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 6455, 6627);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static CommonEmbeddedField()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(771, 984, 6638);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(771, 984, 6638);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(771, 984, 6638);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(771, 984, 6638);

            static TFieldSymbol
            f_771_1286_1301_C<TFieldSymbol>(TFieldSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(771, 1172, 1387);
                return return_v;
            }

        }
    }
}
