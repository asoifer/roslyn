// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.Symbols;

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
        internal abstract class CommonEmbeddedMethod : CommonEmbeddedMember<TMethodSymbol>, Cci.IMethodDefinition
        {
            public readonly TEmbeddedType ContainingType;

            private readonly ImmutableArray<TEmbeddedTypeParameter> _typeParameters;

            private readonly ImmutableArray<TEmbeddedParameter> _parameters;

            protected CommonEmbeddedMethod(TEmbeddedType containingType, TMethodSymbol underlyingMethod) : base(f_773_1596_1612_C<TMethodSymbol>(underlyingMethod))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(773, 1479, 1802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 1284, 1298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 1646, 1683);

                    this.ContainingType = containingType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 1701, 1739);

                    _typeParameters = f_773_1719_1738(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 1757, 1787);

                    _parameters = f_773_1771_1786(this);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(773, 1479, 1802);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 1479, 1802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 1479, 1802);
                }
            }

            protected abstract ImmutableArray<TEmbeddedTypeParameter> GetTypeParameters();

            protected abstract ImmutableArray<TEmbeddedParameter> GetParameters();

            protected abstract bool IsAbstract { get; }

            protected abstract bool IsAccessCheckedOnOverride { get; }

            protected abstract bool IsConstructor { get; }

            protected abstract bool IsExternal { get; }

            protected abstract bool IsHiddenBySignature { get; }

            protected abstract bool IsNewSlot { get; }

            protected abstract Cci.IPlatformInvokeInformation PlatformInvokeData { get; }

            protected abstract bool IsRuntimeSpecial { get; }

            protected abstract bool IsSpecialName { get; }

            protected abstract bool IsSealed { get; }

            protected abstract bool IsStatic { get; }

            protected abstract bool IsVirtual { get; }

            protected abstract System.Reflection.MethodImplAttributes GetImplementationAttributes(EmitContext context);

            protected abstract bool ReturnValueIsMarshalledExplicitly { get; }

            protected abstract Cci.IMarshallingInformation ReturnValueMarshallingInformation { get; }

            protected abstract ImmutableArray<byte> ReturnValueMarshallingDescriptor { get; }

            protected abstract Cci.TypeMemberVisibility Visibility { get; }

            protected abstract string Name { get; }

            protected abstract bool AcceptsExtraArguments { get; }

            protected abstract Cci.ISignature UnderlyingMethodSignature { get; }

            protected abstract Cci.INamespace ContainingNamespace { get; }

            public TMethodSymbol UnderlyingMethod
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 3537, 3561);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 3540, 3561);
                        return this.UnderlyingSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 3537, 3561);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 3537, 3561);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 3537, 3561);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected sealed override TAttributeData PortAttributeIfNeedTo(TAttributeData attrData, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
            {
                // Note, when porting attributes, we are not using constructors from original symbol.
                // The constructors might be missing (for example, in metadata case) and doing lookup
                // will ensure that we report appropriate errors.

                if (TypeManager.IsTargetAttribute(UnderlyingMethod, attrData, AttributeDescription.LCIDConversionAttribute))
                {
                    if (attrData.CommonConstructorArguments.Length == 1)
                    {
                        return TypeManager.CreateSynthesizedAttribute(WellKnownMember.System_Runtime_InteropServices_LCIDConversionAttribute__ctor, attrData, syntaxNodeOpt, diagnostics);
                    }
                }

                return null;
            }

            Cci.IMethodBody Cci.IMethodDefinition.GetBody(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 4544, 5016);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 4643, 4969) || true) && (f_773_4647_4675(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(773, 4643, 4969);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 4923, 4950);

                        return f_773_4930_4949(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(773, 4643, 4969);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 4989, 5001);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(773, 4544, 5016);

                    bool
                    f_773_4647_4675(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMethod
                    methodDef)
                    {
                        var return_v = Cci.Extensions.HasBody(methodDef);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(773, 4647, 4675);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMethod.EmptyBody
                    f_773_4930_4949(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMethod
                    method)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMethod.EmptyBody(method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(773, 4930, 4949);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 4544, 5016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 4544, 5016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            private sealed class EmptyBody : Cci.IMethodBody
            {
                private readonly CommonEmbeddedMethod _method;

                public EmptyBody(CommonEmbeddedMethod method)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(773, 5179, 5301);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 5151, 5158);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 5265, 5282);

                        _method = method;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(773, 5179, 5301);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 5179, 5301);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 5179, 5301);
                    }
                }

                ImmutableArray<Cci.ExceptionHandlerRegion> Cci.IMethodBody.ExceptionRegions
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 5397, 5469);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 5421, 5469);
                            return ImmutableArray<Cci.ExceptionHandlerRegion>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 5397, 5469);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 5397, 5469);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 5397, 5469);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                bool Cci.IMethodBody.HasStackalloc
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 5525, 5533);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 5528, 5533);
                            return false; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 5525, 5533);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 5525, 5533);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 5525, 5533);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                bool Cci.IMethodBody.AreLocalsZeroed
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 5591, 5599);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 5594, 5599);
                            return false; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 5591, 5599);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 5591, 5599);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 5591, 5599);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                ImmutableArray<Cci.ILocalDefinition> Cci.IMethodBody.LocalVariables
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 5688, 5754);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 5712, 5754);
                            return ImmutableArray<Cci.ILocalDefinition>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 5688, 5754);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 5688, 5754);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 5688, 5754);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                Cci.IMethodDefinition Cci.IMethodBody.MethodDefinition
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 5830, 5840);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 5833, 5840);
                            return _method; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 5830, 5840);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 5830, 5840);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 5830, 5840);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                ushort Cci.IMethodBody.MaxStack
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 5893, 5897);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 5896, 5897);
                            return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 5893, 5897);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 5893, 5897);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 5893, 5897);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                ImmutableArray<byte> Cci.IMethodBody.IL
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 5958, 5987);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 5961, 5987);
                            return ImmutableArray<byte>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 5958, 5987);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 5958, 5987);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 5958, 5987);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                ImmutableArray<Cci.SequencePoint> Cci.IMethodBody.SequencePoints
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 6073, 6115);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 6076, 6115);
                            return ImmutableArray<Cci.SequencePoint>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 6073, 6115);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 6073, 6115);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 6073, 6115);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                bool Cci.IMethodBody.HasDynamicLocalVariables
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 6182, 6190);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 6185, 6190);
                            return false; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 6182, 6190);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 6182, 6190);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 6182, 6190);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                StateMachineMoveNextBodyDebugInfo Cci.IMethodBody.MoveNextBodyInfo
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 6278, 6285);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 6281, 6285);
                            return null; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 6278, 6285);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 6278, 6285);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 6278, 6285);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                DynamicAnalysisMethodBodyData Cci.IMethodBody.DynamicAnalysisData
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 6372, 6379);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 6375, 6379);
                            return null; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 6372, 6379);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 6372, 6379);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 6372, 6379);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                ImmutableArray<Cci.LocalScope> Cci.IMethodBody.LocalScopes
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 6459, 6519);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 6483, 6519);
                            return ImmutableArray<Cci.LocalScope>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 6459, 6519);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 6459, 6519);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 6459, 6519);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                Cci.IImportScope Cci.IMethodBody.ImportScope
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 6585, 6592);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 6588, 6592);
                            return null; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 6585, 6592);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 6585, 6592);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 6585, 6592);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                ImmutableArray<StateMachineHoistedLocalScope> Cci.IMethodBody.StateMachineHoistedLocalScopes
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 6706, 6784);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 6730, 6784);
                            return default(ImmutableArray<StateMachineHoistedLocalScope>); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 6706, 6784);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 6706, 6784);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 6706, 6784);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                string Cci.IMethodBody.StateMachineTypeName
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 6849, 6856);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 6852, 6856);
                            return null; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 6849, 6856);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 6849, 6856);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 6849, 6856);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                ImmutableArray<EncHoistedLocalInfo> Cci.IMethodBody.StateMachineHoistedLocalSlots
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 6959, 7027);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 6983, 7027);
                            return default(ImmutableArray<EncHoistedLocalInfo>); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 6959, 7027);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 6959, 7027);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 6959, 7027);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                ImmutableArray<Cci.ITypeReference> Cci.IMethodBody.StateMachineAwaiterSlots
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 7124, 7191);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 7148, 7191);
                            return default(ImmutableArray<Cci.ITypeReference>); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 7124, 7191);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 7124, 7191);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 7124, 7191);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                ImmutableArray<ClosureDebugInfo> Cci.IMethodBody.ClosureDebugInfo
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 7278, 7343);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 7302, 7343);
                            return default(ImmutableArray<ClosureDebugInfo>); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 7278, 7343);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 7278, 7343);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 7278, 7343);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                ImmutableArray<LambdaDebugInfo> Cci.IMethodBody.LambdaDebugInfo
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 7428, 7492);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 7452, 7492);
                            return default(ImmutableArray<LambdaDebugInfo>); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 7428, 7492);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 7428, 7492);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 7428, 7492);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public DebugId MethodId
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 7537, 7556);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 7540, 7556);
                            return default(DebugId); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 7537, 7556);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 7537, 7556);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 7537, 7556);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static EmptyBody()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(773, 5032, 7572);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(773, 5032, 7572);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 5032, 7572);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(773, 5032, 7572);
            }

            IEnumerable<Cci.IGenericMethodParameter> Cci.IMethodDefinition.GenericParameters
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 7669, 7687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 7672, 7687);
                        return _typeParameters; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 7669, 7687);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 7669, 7687);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 7669, 7687);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.HasDeclarativeSecurity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 7754, 7762);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 7757, 7762);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 7754, 7762);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 7754, 7762);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 7754, 7762);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.IsAbstract
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 7817, 7830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 7820, 7830);
                        return f_773_7820_7830(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 7817, 7830);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 7817, 7830);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 7817, 7830);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.IsAccessCheckedOnOverride
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 7900, 7928);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 7903, 7928);
                        return f_773_7903_7928(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 7900, 7928);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 7900, 7928);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 7900, 7928);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.IsConstructor
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 7986, 8002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 7989, 8002);
                        return f_773_7989_8002(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 7986, 8002);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 7986, 8002);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 7986, 8002);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.IsExternal
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 8057, 8070);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 8060, 8070);
                        return f_773_8060_8070(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 8057, 8070);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 8057, 8070);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 8057, 8070);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.IsHiddenBySignature
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 8134, 8156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 8137, 8156);
                        return f_773_8137_8156(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 8134, 8156);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 8134, 8156);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 8134, 8156);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.IsNewSlot
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 8210, 8222);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 8213, 8222);
                        return f_773_8213_8222(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 8210, 8222);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 8210, 8222);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 8210, 8222);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.IsPlatformInvoke
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 8283, 8312);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 8286, 8312);
                        return f_773_8286_8304() != null; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 8283, 8312);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 8283, 8312);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 8283, 8312);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IPlatformInvokeInformation Cci.IMethodDefinition.PlatformInvokeData
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 8401, 8422);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 8404, 8422);
                        return f_773_8404_8422(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 8401, 8422);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 8401, 8422);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 8401, 8422);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.IsRuntimeSpecial
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 8483, 8502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 8486, 8502);
                        return f_773_8486_8502(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 8483, 8502);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 8483, 8502);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 8483, 8502);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.IsSpecialName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 8560, 8576);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 8563, 8576);
                        return f_773_8563_8576(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 8560, 8576);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 8560, 8576);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 8560, 8576);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.IsSealed
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 8629, 8640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 8632, 8640);
                        return f_773_8632_8640(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 8629, 8640);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 8629, 8640);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 8629, 8640);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.IsStatic
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 8693, 8704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 8696, 8704);
                        return f_773_8696_8704(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 8693, 8704);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 8693, 8704);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 8693, 8704);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.IsVirtual
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 8758, 8770);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 8761, 8770);
                        return f_773_8761_8770(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 8758, 8770);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 8758, 8770);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 8758, 8770);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            System.Reflection.MethodImplAttributes Cci.IMethodDefinition.GetImplementationAttributes(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 8787, 8988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 8929, 8973);

                    return f_773_8936_8972(this, context);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(773, 8787, 8988);

                    System.Reflection.MethodImplAttributes
                    f_773_8936_8972(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMethod
                    this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                    context)
                    {
                        var return_v = this_param.GetImplementationAttributes(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(773, 8936, 8972);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 8787, 8988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 8787, 8988);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            ImmutableArray<Cci.IParameterDefinition> Cci.IMethodDefinition.Parameters
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 9110, 9235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 9154, 9216);

                        return f_773_9161_9215(_parameters);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(773, 9110, 9235);

                        System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                        f_773_9161_9215(System.Collections.Immutable.ImmutableArray<TEmbeddedParameter>
                        from)
                        {
                            var return_v = StaticCast<Cci.IParameterDefinition>.From(from);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(773, 9161, 9215);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 9004, 9250);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 9004, 9250);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodDefinition.RequiresSecurityObject
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 9316, 9324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 9319, 9324);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 9316, 9324);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 9316, 9324);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 9316, 9324);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            IEnumerable<Cci.ICustomAttribute> Cci.IMethodDefinition.GetReturnValueAttributes(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 9341, 9586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 9501, 9571);

                    return f_773_9508_9570();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(773, 9341, 9586);

                    System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                    f_773_9508_9570()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(773, 9508, 9570);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 9341, 9586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 9341, 9586);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            bool Cci.IMethodDefinition.ReturnValueIsMarshalledExplicitly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 9663, 9699);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 9666, 9699);
                        return f_773_9666_9699(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 9663, 9699);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 9663, 9699);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 9663, 9699);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IMarshallingInformation Cci.IMethodDefinition.ReturnValueMarshallingInformation
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 9800, 9836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 9803, 9836);
                        return f_773_9803_9836(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 9800, 9836);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 9800, 9836);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 9800, 9836);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            ImmutableArray<byte> Cci.IMethodDefinition.ReturnValueMarshallingDescriptor
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 9929, 9964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 9932, 9964);
                        return f_773_9932_9964(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 9929, 9964);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 9929, 9964);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 9929, 9964);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            IEnumerable<Cci.SecurityAttribute> Cci.IMethodDefinition.SecurityAttributes
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 10057, 10140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 10077, 10140);
                        return f_773_10077_10140(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 10057, 10140);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 10057, 10140);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 10057, 10140);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 10228, 10245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 10231, 10245);
                        return ContainingType; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 10228, 10245);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 10228, 10245);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 10228, 10245);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.INamespace Cci.IMethodDefinition.ContainingNamespace
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 10319, 10341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 10322, 10341);
                        return f_773_10322_10341(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 10319, 10341);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 10319, 10341);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 10319, 10341);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 10420, 10433);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 10423, 10433);
                        return f_773_10423_10433(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 10420, 10433);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 10420, 10433);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 10420, 10433);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeReference Cci.ITypeMemberReference.GetContainingType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 10450, 10602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 10565, 10587);

                    return ContainingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(773, 10450, 10602);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 10450, 10602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 10450, 10602);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 10618, 10743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 10708, 10728);

                    f_773_10708_10727(visitor, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(773, 10618, 10743);

                    int
                    f_773_10708_10727(Microsoft.Cci.MetadataVisitor
                    this_param, Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMethod
                    method)
                    {
                        this_param.Visit((Microsoft.Cci.IMethodDefinition)method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(773, 10708, 10727);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 10618, 10743);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 10618, 10743);
                }
            }

            Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 10759, 10883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 10856, 10868);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(773, 10759, 10883);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 10759, 10883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 10759, 10883);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            string Cci.INamedEntity.Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 10928, 10935);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 10931, 10935);
                        return f_773_10931_10935(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 10928, 10935);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 10928, 10935);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 10928, 10935);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodReference.AcceptsExtraArguments
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 11000, 11024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 11003, 11024);
                        return f_773_11003_11024(); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 11000, 11024);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 11000, 11024);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 11000, 11024);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            ushort Cci.IMethodReference.GenericParameterCount
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 11091, 11124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 11094, 11124);
                        return (ushort)_typeParameters.Length; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 11091, 11124);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 11091, 11124);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 11091, 11124);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IMethodReference.IsGeneric
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 11177, 11206);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 11180, 11206);
                        return _typeParameters.Length > 0; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 11177, 11206);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 11177, 11206);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 11177, 11206);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IMethodDefinition Cci.IMethodReference.GetResolvedMethod(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 11223, 11364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 11337, 11349);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(773, 11223, 11364);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 11223, 11364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 11223, 11364);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            ImmutableArray<Cci.IParameterTypeInformation> Cci.IMethodReference.ExtraParameters
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 11495, 11702);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 11624, 11683);

                        return ImmutableArray<Cci.IParameterTypeInformation>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(773, 11495, 11702);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 11380, 11717);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 11380, 11717);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IGenericMethodInstanceReference Cci.IMethodReference.AsGenericMethodInstanceReference
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 11823, 11830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 11826, 11830);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 11823, 11830);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 11823, 11830);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 11823, 11830);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ISpecializedMethodReference Cci.IMethodReference.AsSpecializedMethodReference
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 11929, 11936);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 11932, 11936);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 11929, 11936);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 11929, 11936);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 11929, 11936);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.CallingConvention Cci.ISignature.CallingConvention
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 12008, 12054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 12011, 12054);
                        return f_773_12011_12054(f_773_12011_12036()); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 12008, 12054);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 12008, 12054);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 12008, 12054);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            ushort Cci.ISignature.ParameterCount
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 12108, 12137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 12111, 12137);
                        return (ushort)_parameters.Length; DynAbs.Tracing.TraceSender.TraceExitMethod(773, 12108, 12137);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 12108, 12137);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 12108, 12137);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            ImmutableArray<Cci.IParameterTypeInformation> Cci.ISignature.GetParameters(EmitContext context)
            {
                return StaticCast<Cci.IParameterTypeInformation>.From(_parameters);
            }

            ImmutableArray<Cci.ICustomModifier> Cci.ISignature.RefCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 12450, 12514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 12470, 12514);
                        return f_773_12470_12514(f_773_12470_12495()); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 12450, 12514);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 12450, 12514);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 12450, 12514);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            ImmutableArray<Cci.ICustomModifier> Cci.ISignature.ReturnValueCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 12609, 12681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 12629, 12681);
                        return f_773_12629_12681(f_773_12629_12654()); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 12609, 12681);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 12609, 12681);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 12609, 12681);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ISignature.ReturnValueIsByRef
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 12737, 12784);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 12740, 12784);
                        return f_773_12740_12784(f_773_12740_12765()); DynAbs.Tracing.TraceSender.TraceExitMethod(773, 12737, 12784);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 12737, 12784);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 12737, 12784);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeReference Cci.ISignature.GetType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(773, 12801, 12961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(773, 12896, 12946);

                    return f_773_12903_12945(f_773_12903_12928(), context);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(773, 12801, 12961);

                    Microsoft.Cci.ISignature
                    f_773_12903_12928()
                    {
                        var return_v = UnderlyingMethodSignature;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 12903, 12928);
                        return return_v;
                    }


                    Microsoft.Cci.ITypeReference
                    f_773_12903_12945(Microsoft.Cci.ISignature
                    this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                    context)
                    {
                        var return_v = this_param.GetType(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(773, 12903, 12945);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(773, 12801, 12961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 12801, 12961);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            /// <remarks>
            /// This is only used for testing.
            /// </remarks>
            public override string ToString()
            {
                return UnderlyingMethod.GetInternalSymbol().GetISymbol().ToDisplayString(SymbolDisplayFormat.ILVisualizationFormat);
            }

            static CommonEmbeddedMethod()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(773, 1124, 13288);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(773, 1124, 13288);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(773, 1124, 13288);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(773, 1124, 13288);

            static System.Collections.Immutable.ImmutableArray<TEmbeddedTypeParameter>
            f_773_1719_1738(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMethod
            this_param)
            {
                var return_v = this_param.GetTypeParameters();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(773, 1719, 1738);
                return return_v;
            }


            static System.Collections.Immutable.ImmutableArray<TEmbeddedParameter>
            f_773_1771_1786(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMethod
            this_param)
            {
                var return_v = this_param.GetParameters();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(773, 1771, 1786);
                return return_v;
            }


            static TMethodSymbol
            f_773_1596_1612_C<TMethodSymbol>(TMethodSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(773, 1479, 1802);
                return return_v;
            }


            bool
            f_773_7820_7830()
            {
                var return_v = IsAbstract;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 7820, 7830);
                return return_v;
            }


            bool
            f_773_7903_7928()
            {
                var return_v = IsAccessCheckedOnOverride;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 7903, 7928);
                return return_v;
            }


            bool
            f_773_7989_8002()
            {
                var return_v = IsConstructor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 7989, 8002);
                return return_v;
            }


            bool
            f_773_8060_8070()
            {
                var return_v = IsExternal;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 8060, 8070);
                return return_v;
            }


            bool
            f_773_8137_8156()
            {
                var return_v = IsHiddenBySignature;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 8137, 8156);
                return return_v;
            }


            bool
            f_773_8213_8222()
            {
                var return_v = IsNewSlot;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 8213, 8222);
                return return_v;
            }


            Microsoft.Cci.IPlatformInvokeInformation
            f_773_8286_8304()
            {
                var return_v = PlatformInvokeData;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 8286, 8304);
                return return_v;
            }


            Microsoft.Cci.IPlatformInvokeInformation
            f_773_8404_8422()
            {
                var return_v = PlatformInvokeData;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 8404, 8422);
                return return_v;
            }


            bool
            f_773_8486_8502()
            {
                var return_v = IsRuntimeSpecial;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 8486, 8502);
                return return_v;
            }


            bool
            f_773_8563_8576()
            {
                var return_v = IsSpecialName;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 8563, 8576);
                return return_v;
            }


            bool
            f_773_8632_8640()
            {
                var return_v = IsSealed;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 8632, 8640);
                return return_v;
            }


            bool
            f_773_8696_8704()
            {
                var return_v = IsStatic;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 8696, 8704);
                return return_v;
            }


            bool
            f_773_8761_8770()
            {
                var return_v = IsVirtual;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 8761, 8770);
                return return_v;
            }


            bool
            f_773_9666_9699()
            {
                var return_v = ReturnValueIsMarshalledExplicitly;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 9666, 9699);
                return return_v;
            }


            Microsoft.Cci.IMarshallingInformation
            f_773_9803_9836()
            {
                var return_v = ReturnValueMarshallingInformation;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 9803, 9836);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<byte>
            f_773_9932_9964()
            {
                var return_v = ReturnValueMarshallingDescriptor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 9932, 9964);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
            f_773_10077_10140()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.SecurityAttribute>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(773, 10077, 10140);
                return return_v;
            }


            Microsoft.Cci.INamespace
            f_773_10322_10341()
            {
                var return_v = ContainingNamespace;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 10322, 10341);
                return return_v;
            }


            Microsoft.Cci.TypeMemberVisibility
            f_773_10423_10433()
            {
                var return_v = Visibility;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 10423, 10433);
                return return_v;
            }


            string
            f_773_10931_10935()
            {
                var return_v = Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 10931, 10935);
                return return_v;
            }


            bool
            f_773_11003_11024()
            {
                var return_v = AcceptsExtraArguments;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 11003, 11024);
                return return_v;
            }


            Microsoft.Cci.ISignature
            f_773_12011_12036()
            {
                var return_v = UnderlyingMethodSignature;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 12011, 12036);
                return return_v;
            }


            Microsoft.Cci.CallingConvention
            f_773_12011_12054(Microsoft.Cci.ISignature
            this_param)
            {
                var return_v = this_param.CallingConvention;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 12011, 12054);
                return return_v;
            }


            Microsoft.Cci.ISignature
            f_773_12470_12495()
            {
                var return_v = UnderlyingMethodSignature;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 12470, 12495);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
            f_773_12470_12514(Microsoft.Cci.ISignature
            this_param)
            {
                var return_v = this_param.RefCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 12470, 12514);
                return return_v;
            }


            Microsoft.Cci.ISignature
            f_773_12629_12654()
            {
                var return_v = UnderlyingMethodSignature;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 12629, 12654);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
            f_773_12629_12681(Microsoft.Cci.ISignature
            this_param)
            {
                var return_v = this_param.ReturnValueCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 12629, 12681);
                return return_v;
            }


            Microsoft.Cci.ISignature
            f_773_12740_12765()
            {
                var return_v = UnderlyingMethodSignature;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 12740, 12765);
                return return_v;
            }


            bool
            f_773_12740_12784(Microsoft.Cci.ISignature
            this_param)
            {
                var return_v = this_param.ReturnValueIsByRef;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(773, 12740, 12784);
                return return_v;
            }

        }
    }
}
