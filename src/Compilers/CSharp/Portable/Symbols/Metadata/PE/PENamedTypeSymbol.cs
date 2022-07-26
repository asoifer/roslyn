// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.DocumentationComments;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal abstract class PENamedTypeSymbol : NamedTypeSymbol
    {
        private static readonly Dictionary<string, ImmutableArray<PENamedTypeSymbol>> s_emptyNestedTypes;

        private readonly NamespaceOrTypeSymbol _container;

        private readonly TypeDefinitionHandle _handle;

        private readonly string _name;

        private readonly TypeAttributes _flags;

        private readonly SpecialType _corTypeId;

        private ICollection<string> _lazyMemberNames;

        private ImmutableArray<Symbol> _lazyMembersInDeclarationOrder;

        private Dictionary<string, ImmutableArray<Symbol>> _lazyMembersByName;

        private Dictionary<string, ImmutableArray<PENamedTypeSymbol>> _lazyNestedTypes;

        private TypeKind _lazyKind;

        private NullableContextKind _lazyNullableContextValue;

        private NamedTypeSymbol _lazyBaseType;

        private ImmutableArray<NamedTypeSymbol> _lazyInterfaces;

        private NamedTypeSymbol _lazyDeclaredBaseType;

        private ImmutableArray<NamedTypeSymbol> _lazyDeclaredInterfaces;

        private Tuple<CultureInfo, string> _lazyDocComment;

        private DiagnosticInfo _lazyUseSiteDiagnostic;

        private static readonly UncommonProperties s_noUncommonProperties;

        private UncommonProperties _lazyUncommonProperties;

        private UncommonProperties GetUncommonProperties()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 4220, 4907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 4295, 4332);

                var
                result = _lazyUncommonProperties
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 4346, 4568) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 4346, 4568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 4409, 4513);

                    f_10709_4409_4512(result != s_noUncommonProperties || (DynAbs.Tracing.TraceSender.Expression_False(10709, 4422, 4481) || f_10709_4458_4481(result)), "default value was modified");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 4539, 4553);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 4346, 4568);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 4584, 4794) || true) && (f_10709_4588_4605(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 4584, 4794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 4639, 4673);

                    result = f_10709_4648_4672();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 4691, 4779);

                    return f_10709_4698_4768(ref _lazyUncommonProperties, result, null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties>(10709, 4698, 4778) ?? result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 4584, 4794);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 4810, 4868);

                _lazyUncommonProperties = result = s_noUncommonProperties;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 4882, 4896);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 4220, 4907);

                bool
                f_10709_4458_4481(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                this_param)
                {
                    var return_v = this_param.IsDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 4458, 4481);
                    return return_v;
                }


                int
                f_10709_4409_4512(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 4409, 4512);
                    return 0;
                }


                bool
                f_10709_4588_4605(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsUncommon();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 4588, 4605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                f_10709_4648_4672()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 4648, 4672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                f_10709_4698_4768(ref Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                value, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 4698, 4768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 4220, 4907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 4220, 4907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsUncommon()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 4994, 5315);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 5044, 5164) || true) && (f_10709_5048_5103(f_10709_5048_5071(this), _handle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 5044, 5164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 5137, 5149);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 5044, 5164);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 5180, 5275) || true) && (f_10709_5184_5197(this) == TypeKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 5180, 5275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 5248, 5260);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 5180, 5275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 5291, 5304);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 4994, 5315);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_5048_5071(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 5048, 5071);
                    return return_v;
                }


                bool
                f_10709_5048_5103(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                token)
                {
                    var return_v = this_param.HasAnyCustomAttributes((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 5048, 5103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10709_5184_5197(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 5184, 5197);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 4994, 5315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 4994, 5315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class UncommonProperties
        {
            internal ImmutableArray<PEFieldSymbol> lazyInstanceEnumFields;

            internal NamedTypeSymbol lazyEnumUnderlyingType;

            internal ImmutableArray<CSharpAttributeData> lazyCustomAttributes;

            internal ImmutableArray<string> lazyConditionalAttributeSymbols;

            internal ObsoleteAttributeData lazyObsoleteAttributeData;

            internal AttributeUsageInfo lazyAttributeUsageInfo;

            internal ThreeState lazyContainsExtensionMethods;

            internal ThreeState lazyIsByRefLike;

            internal ThreeState lazyIsReadOnly;

            internal string lazyDefaultMemberName;

            internal NamedTypeSymbol lazyComImportCoClassType;

            internal ThreeState lazyHasEmbeddedAttribute;

            internal bool IsDefaultValue()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 6589, 7316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 6652, 7301);

                    return lazyInstanceEnumFields.IsDefault && (DynAbs.Tracing.TraceSender.Expression_True(10709, 6659, 6754) && (object)lazyEnumUnderlyingType == null) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 6659, 6809) && lazyCustomAttributes.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 6659, 6875) && lazyConditionalAttributeSymbols.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 6659, 6964) && lazyObsoleteAttributeData == ObsoleteAttributeData.Uninitialized) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 6659, 7018) && lazyAttributeUsageInfo.IsNull) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 6659, 7083) && !f_10709_7044_7083(lazyContainsExtensionMethods)) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 6659, 7137) && lazyDefaultMemberName == null) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 6659, 7239) && (object)lazyComImportCoClassType == (object)ErrorTypeSymbol.UnknownResultType) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 6659, 7300) && !f_10709_7265_7300(lazyHasEmbeddedAttribute));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 6589, 7316);

                    bool
                    f_10709_7044_7083(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.HasValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 7044, 7083);
                        return return_v;
                    }


                    bool
                    f_10709_7265_7300(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.HasValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 7265, 7300);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 6589, 7316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 6589, 7316);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public UncommonProperties()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10709, 5327, 7335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 5708, 5730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 6013, 6076);
                this.lazyObsoleteAttributeData = ObsoleteAttributeData.Uninitialized; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 6119, 6167);
                this.lazyAttributeUsageInfo = AttributeUsageInfo.Null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 6202, 6230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 6265, 6280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 6315, 6329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 6360, 6381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 6421, 6481);
                this.lazyComImportCoClassType = ErrorTypeSymbol.UnknownResultType; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 6516, 6561);
                this.lazyHasEmbeddedAttribute = ThreeState.Unknown; DynAbs.Tracing.TraceSender.TraceExitConstructor(10709, 5327, 7335);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 5327, 7335);
            }


            static UncommonProperties()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10709, 5327, 7335);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10709, 5327, 7335);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 5327, 7335);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10709, 5327, 7335);
        }

        internal static PENamedTypeSymbol Create(
                    PEModuleSymbol moduleSymbol,
                    PENamespaceSymbol containingNamespace,
                    TypeDefinitionHandle handle,
                    string emittedNamespaceName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10709, 7393, 8719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 7637, 7694);

                GenericParameterHandleCollection
                genericParameterHandles
                = default(GenericParameterHandleCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 7708, 7721);

                ushort
                arity
                = default(ushort);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 7735, 7771);

                BadImageFormatException
                mrEx = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 7787, 7874);

                f_10709_7787_7873(moduleSymbol, handle, out genericParameterHandles, out arity, out mrEx);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 7890, 7906);

                bool
                mangleName
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 7920, 7945);

                PENamedTypeSymbol
                result
                = default(PENamedTypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 7961, 8511) || true) && (arity == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 7961, 8511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 8009, 8131);

                    result = f_10709_8018_8130(moduleSymbol, containingNamespace, handle, emittedNamespaceName, out mangleName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 7961, 8511);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 7961, 8511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 8197, 8496);

                    result = f_10709_8206_8495(moduleSymbol, containingNamespace, handle, emittedNamespaceName, genericParameterHandles, arity, out mangleName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 7961, 8511);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 8527, 8678) || true) && (mrEx != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 8527, 8678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 8577, 8663);

                    result._lazyUseSiteDiagnostic = f_10709_8609_8662(ErrorCode.ERR_BogusType, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 8527, 8678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 8694, 8708);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10709, 7393, 8719);

                int
                f_10709_7787_7873(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, System.Reflection.Metadata.TypeDefinitionHandle
                handle, out System.Reflection.Metadata.GenericParameterHandleCollection
                genericParameterHandles, out ushort
                arity, out System.BadImageFormatException
                mrEx)
                {
                    GetGenericInfo(moduleSymbol, handle, out genericParameterHandles, out arity, out mrEx);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 7787, 7873);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolNonGeneric
                f_10709_8018_8130(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                container, System.Reflection.Metadata.TypeDefinitionHandle
                handle, string
                emittedNamespaceName, out bool
                mangleName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolNonGeneric(moduleSymbol, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, handle, emittedNamespaceName, out mangleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 8018, 8130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolGeneric
                f_10709_8206_8495(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                container, System.Reflection.Metadata.TypeDefinitionHandle
                handle, string
                emittedNamespaceName, System.Reflection.Metadata.GenericParameterHandleCollection
                genericParameterHandles, ushort
                arity, out bool
                mangleName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolGeneric(moduleSymbol, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, handle, emittedNamespaceName, genericParameterHandles, arity, out mangleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 8206, 8495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10709_8609_8662(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 8609, 8662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 7393, 8719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 7393, 8719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetGenericInfo(PEModuleSymbol moduleSymbol, TypeDefinitionHandle handle, out GenericParameterHandleCollection genericParameterHandles, out ushort arity, out BadImageFormatException mrEx)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10709, 8731, 9421);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 8998, 9083);

                    genericParameterHandles = f_10709_9024_9082(f_10709_9024_9043(moduleSymbol), handle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 9101, 9147);

                    arity = (ushort)genericParameterHandles.Count;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 9165, 9177);

                    mrEx = null;
                }
                catch (BadImageFormatException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 9206, 9410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 9272, 9282);

                    arity = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 9300, 9368);

                    genericParameterHandles = default(GenericParameterHandleCollection);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 9386, 9395);

                    mrEx = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 9206, 9410);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10709, 8731, 9421);

                Microsoft.CodeAnalysis.PEModule
                f_10709_9024_9043(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 9024, 9043);
                    return return_v;
                }


                System.Reflection.Metadata.GenericParameterHandleCollection
                f_10709_9024_9082(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetTypeDefGenericParamsOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 9024, 9082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 8731, 9421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 8731, 9421);
            }
        }

        internal static PENamedTypeSymbol Create(
                    PEModuleSymbol moduleSymbol,
                    PENamedTypeSymbol containingType,
                    TypeDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10709, 9433, 11005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 9630, 9687);

                GenericParameterHandleCollection
                genericParameterHandles
                = default(GenericParameterHandleCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 9701, 9722);

                ushort
                metadataArity
                = default(ushort);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 9736, 9772);

                BadImageFormatException
                mrEx = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 9788, 9883);

                f_10709_9788_9882(moduleSymbol, handle, out genericParameterHandles, out metadataArity, out mrEx);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 9899, 9916);

                ushort
                arity = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 9930, 9988);

                var
                containerMetadataArity = f_10709_9959_9987(containingType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 10004, 10152) || true) && (metadataArity > containerMetadataArity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 10004, 10152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 10080, 10137);

                    arity = (ushort)(metadataArity - containerMetadataArity);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 10004, 10152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 10168, 10184);

                bool
                mangleName
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 10198, 10223);

                PENamedTypeSymbol
                result
                = default(PENamedTypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 10239, 10755) || true) && (metadataArity == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 10239, 10755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 10295, 10396);

                    result = f_10709_10304_10395(moduleSymbol, containingType, handle, null, out mangleName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 10239, 10755);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 10239, 10755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 10462, 10740);

                    result = f_10709_10471_10739(moduleSymbol, containingType, handle, null, genericParameterHandles, arity, out mangleName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 10239, 10755);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 10771, 10964) || true) && (mrEx != null || (DynAbs.Tracing.TraceSender.Expression_False(10709, 10775, 10829) || metadataArity < containerMetadataArity))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 10771, 10964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 10863, 10949);

                    result._lazyUseSiteDiagnostic = f_10709_10895_10948(ErrorCode.ERR_BogusType, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 10771, 10964);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 10980, 10994);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10709, 9433, 11005);

                int
                f_10709_9788_9882(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, System.Reflection.Metadata.TypeDefinitionHandle
                handle, out System.Reflection.Metadata.GenericParameterHandleCollection
                genericParameterHandles, out ushort
                arity, out System.BadImageFormatException
                mrEx)
                {
                    GetGenericInfo(moduleSymbol, handle, out genericParameterHandles, out arity, out mrEx);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 9788, 9882);
                    return 0;
                }


                int
                f_10709_9959_9987(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MetadataArity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 9959, 9987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolNonGeneric
                f_10709_10304_10395(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                container, System.Reflection.Metadata.TypeDefinitionHandle
                handle, string
                emittedNamespaceName, out bool
                mangleName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolNonGeneric(moduleSymbol, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, handle, emittedNamespaceName, out mangleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 10304, 10395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolGeneric
                f_10709_10471_10739(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                container, System.Reflection.Metadata.TypeDefinitionHandle
                handle, string
                emittedNamespaceName, System.Reflection.Metadata.GenericParameterHandleCollection
                genericParameterHandles, ushort
                arity, out bool
                mangleName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolGeneric(moduleSymbol, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, handle, emittedNamespaceName, genericParameterHandles, arity, out mangleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 10471, 10739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10709_10895_10948(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 10895, 10948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 9433, 11005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 9433, 11005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PENamedTypeSymbol(
                    PEModuleSymbol moduleSymbol,
                    NamespaceOrTypeSymbol container,
                    TypeDefinitionHandle handle,
                    string emittedNamespaceName,
                    ushort arity,
                    out bool mangleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10709, 11017, 13348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 1176, 1186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 1277, 1282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 1325, 1331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 1371, 1381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 1626, 1642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 2500, 2518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 2763, 2779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 2910, 2919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 2960, 2985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 3022, 3071);
                this._lazyBaseType = ErrorTypeSymbol.UnknownResultType; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 3122, 3180);
                this._lazyInterfaces = default(ImmutableArray<NamedTypeSymbol>); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 3215, 3272);
                this._lazyDeclaredBaseType = ErrorTypeSymbol.UnknownResultType; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 3323, 3389);
                this._lazyDeclaredInterfaces = default(ImmutableArray<NamedTypeSymbol>); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 3437, 3452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 3488, 3544);
                this._lazyUseSiteDiagnostic = CSDiagnosticInfo.EmptyErrorInfo; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 4184, 4207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 86979, 87029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 11301, 11329);

                f_10709_11301_11328(f_10709_11314_11327_M(!handle.IsNil));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 11343, 11383);

                f_10709_11343_11382((object)container != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 11397, 11458);

                f_10709_11397_11457(arity == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10709, 11410, 11456) || this is PENamedTypeSymbolGeneric));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 11474, 11494);

                string
                metadataName
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 11508, 11529);

                bool
                makeBad = false
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 11581, 11646);

                    metadataName = f_10709_11596_11645(f_10709_11596_11615(moduleSymbol), handle);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 11675, 11815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 11739, 11767);

                    metadataName = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 11785, 11800);

                    makeBad = true;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 11675, 11815);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 11831, 11848);

                _handle = handle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 11862, 11885);

                _container = container;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 11937, 11997);

                    _flags = f_10709_11946_11996(f_10709_11946_11965(moduleSymbol), handle);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 12026, 12120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 12090, 12105);

                    makeBad = true;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 12026, 12120);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 12136, 12616) || true) && (arity == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 12136, 12616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 12184, 12205);

                    _name = metadataName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 12223, 12242);

                    mangleName = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 12136, 12616);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 12136, 12616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 12362, 12436);

                    _name = f_10709_12370_12435(metadataName, arity);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 12454, 12532);

                    f_10709_12454_12531(f_10709_12467_12503(_name, metadataName) == (_name == metadataName));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 12550, 12601);

                    mangleName = !f_10709_12564_12600(_name, metadataName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 12136, 12616);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 12694, 13184) || true) && (emittedNamespaceName != null && (DynAbs.Tracing.TraceSender.Expression_True(10709, 12698, 12813) && f_10709_12747_12813(f_10709_12747_12778(moduleSymbol))) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 12698, 12884) && f_10709_12834_12860(this) == Accessibility.Public))
                ) // NB: this.flags was set above.

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 12694, 13184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 12951, 13073);

                    _corTypeId = f_10709_12964_13072(f_10709_13001_13071(emittedNamespaceName, metadataName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 12694, 13184);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 12694, 13184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 13139, 13169);

                    _corTypeId = SpecialType.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 12694, 13184);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 13200, 13337) || true) && (makeBad)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 13200, 13337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 13245, 13322);

                    _lazyUseSiteDiagnostic = f_10709_13270_13321(ErrorCode.ERR_BogusType, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 13200, 13337);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10709, 11017, 13348);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 11017, 13348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 11017, 13348);
            }
        }

        public override SpecialType SpecialType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 13424, 13493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 13460, 13478);

                    return _corTypeId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 13424, 13493);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 13360, 13504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 13360, 13504);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PEModuleSymbol ContainingPEModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 13583, 13866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 13619, 13641);

                    Symbol
                    s = _container
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 13661, 13782) || true) && (f_10709_13668_13674(s) != SymbolKind.Namespace)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 13661, 13782);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 13740, 13763);

                            s = f_10709_13744_13762(s);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 13661, 13782);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 13661, 13782);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 13661, 13782);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 13802, 13851);

                    return f_10709_13809_13850(((PENamespaceSymbol)s));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 13583, 13866);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10709_13668_13674(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 13668, 13674);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10709_13744_13762(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 13744, 13762);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_13809_13850(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 13809, 13850);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 13516, 13877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 13516, 13877);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 13961, 14038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 13997, 14023);

                    return f_10709_14004_14022();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 13961, 14038);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_14004_14022()
                    {
                        var return_v = ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 14004, 14022);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 13889, 14049);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 13889, 14049);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract override int Arity
        {
            get;
        }

        internal abstract override bool MangleName
        {
            get;
        }

        internal abstract int MetadataArity
        {
            get;
        }

        internal TypeDefinitionHandle Handle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 14389, 14455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 14425, 14440);

                    return _handle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 14389, 14455);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 14328, 14466);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 14328, 14466);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 14560, 15098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 14596, 14635);

                    var
                    uncommon = f_10709_14611_14634(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 14653, 14765) || true) && (uncommon == s_noUncommonProperties)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 14653, 14765);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 14733, 14746);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 14653, 14765);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 14785, 15014) || true) && (!f_10709_14790_14834(uncommon.lazyHasEmbeddedAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 14785, 15014);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 14876, 14995);

                        uncommon.lazyHasEmbeddedAttribute = f_10709_14912_14994(f_10709_14912_14979(f_10709_14912_14937(f_10709_14912_14930()), _handle));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 14785, 15014);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 15034, 15083);

                    return f_10709_15041_15082(uncommon.lazyHasEmbeddedAttribute);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 14560, 15098);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                    f_10709_14611_14634(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUncommonProperties();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 14611, 14634);
                        return return_v;
                    }


                    bool
                    f_10709_14790_14834(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.HasValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 14790, 14834);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_14912_14930()
                    {
                        var return_v = ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 14912, 14930);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10709_14912_14937(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 14912, 14937);
                        return return_v;
                    }


                    bool
                    f_10709_14912_14979(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.TypeDefinitionHandle
                    token)
                    {
                        var return_v = this_param.HasCodeAnalysisEmbeddedAttribute((System.Reflection.Metadata.EntityHandle)token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 14912, 14979);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_10709_14912_14994(bool
                    value)
                    {
                        var return_v = value.ToThreeState();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 14912, 14994);
                        return return_v;
                    }


                    bool
                    f_10709_15041_15082(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.Value();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 15041, 15082);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 14480, 15109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 14480, 15109);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 15208, 15535);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 15244, 15479) || true) && (f_10709_15248_15313(_lazyBaseType, ErrorTypeSymbol.UnknownResultType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 15244, 15479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 15355, 15460);

                        f_10709_15355_15459(ref _lazyBaseType, f_10709_15402_15423(this), ErrorTypeSymbol.UnknownResultType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 15244, 15479);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 15499, 15520);

                    return _lazyBaseType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 15208, 15535);

                    bool
                    f_10709_15248_15313(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 15248, 15313);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10709_15402_15423(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MakeAcyclicBaseType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 15402, 15423);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10709_15355_15459(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 15355, 15459);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 15121, 15546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 15121, 15546);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 15558, 15975);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 15711, 15925) || true) && (_lazyInterfaces.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 15711, 15925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 15774, 15910);

                    f_10709_15774_15909(ref _lazyInterfaces, f_10709_15843_15866(this), default(ImmutableArray<NamedTypeSymbol>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 15711, 15925);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 15941, 15964);

                return _lazyInterfaces;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 15558, 15975);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_15843_15866(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MakeAcyclicInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 15843, 15866);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_15774_15909(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 15774, 15909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 15558, 15975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 15558, 15975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfacesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 15987, 16134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 16083, 16123);

                return f_10709_16090_16122(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 15987, 16134);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_16090_16122(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 16090, 16122);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 15987, 16134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 15987, 16134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 16146, 16337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 16265, 16326);

                return f_10709_16272_16325(this, skipTransformsIfNecessary: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 16146, 16337);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10709_16272_16325(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, bool
                skipTransformsIfNecessary)
                {
                    var return_v = this_param.GetDeclaredBaseType(skipTransformsIfNecessary: skipTransformsIfNecessary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 16272, 16325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 16146, 16337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 16146, 16337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol GetDeclaredBaseType(bool skipTransformsIfNecessary)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 16349, 17810);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 16449, 17754) || true) && (f_10709_16453_16526(_lazyDeclaredBaseType, ErrorTypeSymbol.UnknownResultType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 16449, 17754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 16560, 16598);

                    var
                    baseType = f_10709_16575_16597(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 16616, 17619) || true) && (baseType is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 16616, 17619);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 16680, 16997) || true) && (skipTransformsIfNecessary)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 16680, 16997);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 16958, 16974);

                            return baseType;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 16680, 16997);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 17021, 17059);

                        var
                        moduleSymbol = f_10709_17040_17058()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 17081, 17175);

                        TypeSymbol
                        decodedType = DynamicTypeDecoder.TransformType(baseType, 0, _handle, moduleSymbol)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 17197, 17286);

                        decodedType = NativeIntegerTypeDecoder.TransformType(decodedType, _handle, moduleSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 17308, 17404);

                        decodedType = TupleTypeDecoder.DecodeTupleTypesIfApplicable(decodedType, _handle, moduleSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 17426, 17600);

                        baseType = (NamedTypeSymbol)f_10709_17454_17594(TypeWithAnnotations.Create(decodedType), _handle, moduleSymbol, accessSymbol: this, nullableContext: this).Type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 16616, 17619);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 17639, 17739);

                    f_10709_17639_17738(ref _lazyDeclaredBaseType, baseType, ErrorTypeSymbol.UnknownResultType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 16449, 17754);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 17770, 17799);

                return _lazyDeclaredBaseType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 16349, 17810);

                bool
                f_10709_16453_16526(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 16453, 16526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10709_16575_16597(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MakeDeclaredBaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 16575, 16597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_17040_17058()
                {
                    var return_v = ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 17040, 17058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10709_17454_17594(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                metadataType, System.Reflection.Metadata.TypeDefinitionHandle
                targetSymbolToken, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                containingModule, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                accessSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                nullableContext)
                {
                    var return_v = NullableTypeDecoder.TransformType(metadataType, (System.Reflection.Metadata.EntityHandle)targetSymbolToken, containingModule, accessSymbol: (Microsoft.CodeAnalysis.CSharp.Symbol)accessSymbol, nullableContext: (Microsoft.CodeAnalysis.CSharp.Symbol)nullableContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 17454, 17594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10709_17639_17738(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 17639, 17738);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 16349, 17810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 16349, 17810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 17822, 18248);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 17959, 18190) || true) && (_lazyDeclaredInterfaces.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 17959, 18190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 18030, 18175);

                    f_10709_18030_18174(ref _lazyDeclaredInterfaces, f_10709_18107_18131(this), default(ImmutableArray<NamedTypeSymbol>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 17959, 18190);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 18206, 18237);

                return _lazyDeclaredInterfaces;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 17822, 18248);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_18107_18131(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MakeDeclaredInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 18107, 18131);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_18030_18174(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 18030, 18174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 17822, 18248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 17822, 18248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol MakeDeclaredBaseType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 18260, 19000);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 18331, 18961) || true) && (!f_10709_18336_18356(_flags))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 18331, 18961);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 18434, 18472);

                        var
                        moduleSymbol = f_10709_18453_18471()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 18494, 18569);

                        EntityHandle
                        token = f_10709_18515_18568(f_10709_18515_18534(moduleSymbol), _handle)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 18591, 18766) || true) && (f_10709_18595_18607_M(!token.IsNil))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 18591, 18766);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 18657, 18743);

                            return (NamedTypeSymbol)f_10709_18681_18742(f_10709_18681_18720(moduleSymbol, this), token);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 18591, 18766);
                        }
                    }
                    catch (BadImageFormatException mrEx)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 18803, 18946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 18880, 18927);

                        return f_10709_18887_18926(mrEx);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 18803, 18946);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 18331, 18961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 18977, 18989);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 18260, 19000);

                bool
                f_10709_18336_18356(System.Reflection.TypeAttributes
                flags)
                {
                    var return_v = flags.IsInterface();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 18336, 18356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_18453_18471()
                {
                    var return_v = ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 18453, 18471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_18515_18534(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 18515, 18534);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_10709_18515_18568(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetBaseTypeOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 18515, 18568);
                    return return_v;
                }


                bool
                f_10709_18595_18607_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 18595, 18607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10709_18681_18720(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 18681, 18720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10709_18681_18742(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.EntityHandle
                token)
                {
                    var return_v = this_param.GetTypeOfToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 18681, 18742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10709_18887_18926(System.BadImageFormatException
                mrEx)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol(mrEx);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 18887, 18926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 18260, 19000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 18260, 19000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<NamedTypeSymbol> MakeDeclaredInterfaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 19012, 20885);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 19137, 19175);

                    var
                    moduleSymbol = f_10709_19156_19174()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 19193, 19278);

                    var
                    interfaceImpls = f_10709_19214_19277(f_10709_19214_19233(moduleSymbol), _handle)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 19298, 20609) || true) && (interfaceImpls.Count > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 19298, 20609);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 19368, 19446);

                        var
                        symbols = f_10709_19382_19445(interfaceImpls.Count)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 19468, 19527);

                        var
                        tokenDecoder = f_10709_19487_19526(moduleSymbol, this)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 19551, 20530);
                            foreach (var interfaceImpl in f_10709_19581_19595_I(interfaceImpls))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 19551, 20530);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 19645, 19763);

                                EntityHandle
                                interfaceHandle = f_10709_19676_19752(f_10709_19676_19710(f_10709_19676_19695(moduleSymbol)), interfaceImpl).Interface
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 19789, 19858);

                                TypeSymbol
                                typeSymbol = f_10709_19813_19857(tokenDecoder, interfaceHandle)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 19886, 19979);

                                typeSymbol = NativeIntegerTypeDecoder.TransformType(typeSymbol, interfaceImpl, moduleSymbol);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 20005, 20105);

                                typeSymbol = TupleTypeDecoder.DecodeTupleTypesIfApplicable(typeSymbol, interfaceImpl, moduleSymbol);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 20131, 20295);

                                typeSymbol = f_10709_20144_20289(TypeWithAnnotations.Create(typeSymbol), interfaceImpl, moduleSymbol, accessSymbol: this, nullableContext: this).Type;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 20323, 20414);

                                var
                                namedTypeSymbol = typeSymbol as NamedTypeSymbol ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?>(10709, 20345, 20413) ?? f_10709_20378_20413())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 20478, 20507);

                                f_10709_20478_20506(symbols, namedTypeSymbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 19551, 20530);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 980);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 980);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 20554, 20590);

                        return f_10709_20561_20589(symbols);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 19298, 20609);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 20629, 20674);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                }
                catch (BadImageFormatException mrEx)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 20703, 20874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 20772, 20859);

                    return f_10709_20779_20858(f_10709_20818_20857(mrEx));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 20703, 20874);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 19012, 20885);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_19156_19174()
                {
                    var return_v = ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 19156, 19174);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_19214_19233(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 19214, 19233);
                    return return_v;
                }


                System.Reflection.Metadata.InterfaceImplementationHandleCollection
                f_10709_19214_19277(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetInterfaceImplementationsOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 19214, 19277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_19382_19445(int
                capacity)
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 19382, 19445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10709_19487_19526(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 19487, 19526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_19676_19695(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 19676, 19695);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_10709_19676_19710(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 19676, 19710);
                    return return_v;
                }


                System.Reflection.Metadata.InterfaceImplementation
                f_10709_19676_19752(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.InterfaceImplementationHandle
                handle)
                {
                    var return_v = this_param.GetInterfaceImplementation(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 19676, 19752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10709_19813_19857(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.EntityHandle
                token)
                {
                    var return_v = this_param.GetTypeOfToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 19813, 19857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10709_20144_20289(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                metadataType, System.Reflection.Metadata.InterfaceImplementationHandle
                targetSymbolToken, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                containingModule, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                accessSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                nullableContext)
                {
                    var return_v = NullableTypeDecoder.TransformType(metadataType, (System.Reflection.Metadata.EntityHandle)targetSymbolToken, containingModule, accessSymbol: (Microsoft.CodeAnalysis.CSharp.Symbol)accessSymbol, nullableContext: (Microsoft.CodeAnalysis.CSharp.Symbol)nullableContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 20144, 20289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10709_20378_20413()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 20378, 20413);
                    return return_v;
                }


                int
                f_10709_20478_20506(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 20478, 20506);
                    return 0;
                }


                System.Reflection.Metadata.InterfaceImplementationHandleCollection
                f_10709_19581_19595_I(System.Reflection.Metadata.InterfaceImplementationHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 19581, 19595);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_20561_20589(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 20561, 20589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10709_20818_20857(System.BadImageFormatException
                mrEx)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol(mrEx);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 20818, 20857);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_20779_20858(Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<NamedTypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 20779, 20858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 19012, 20885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 19012, 20885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override NamedTypeSymbol ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 20969, 21032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 21005, 21017);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 20969, 21032);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 20897, 21043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 20897, 21043);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 21119, 21188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 21155, 21173);

                    return _container;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 21119, 21188);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 21055, 21199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 21055, 21199);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 21282, 21370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 21318, 21355);

                    return _container as NamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 21282, 21370);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 21211, 21381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 21211, 21381);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 21449, 21657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 21485, 21535);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 21553, 21642);

                    return f_10709_21560_21633(this, ref useSiteDiagnostics) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 21449, 21657);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10709_21560_21633(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    containingType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics)
                    {
                        var return_v = SynthesizedRecordClone.FindValidCloneMethod((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)containingType, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 21560, 21633);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 21393, 21668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 21393, 21668);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 21756, 23236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 21792, 21837);

                    Accessibility
                    access = Accessibility.Private
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 21857, 23187);

                    switch (_flags & TypeAttributes.VisibilityMask)
                    {

                        case TypeAttributes.NestedAssembly:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 21857, 23187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 22006, 22038);

                            access = Accessibility.Internal;
                            DynAbs.Tracing.TraceSender.TraceBreak(10709, 22064, 22070);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 21857, 23187);

                        case TypeAttributes.NestedFamORAssem:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 21857, 23187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 22157, 22200);

                            access = Accessibility.ProtectedOrInternal;
                            DynAbs.Tracing.TraceSender.TraceBreak(10709, 22226, 22232);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 21857, 23187);

                        case TypeAttributes.NestedFamANDAssem:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 21857, 23187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 22320, 22364);

                            access = Accessibility.ProtectedAndInternal;
                            DynAbs.Tracing.TraceSender.TraceBreak(10709, 22390, 22396);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 21857, 23187);

                        case TypeAttributes.NestedPrivate:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 21857, 23187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 22480, 22511);

                            access = Accessibility.Private;
                            DynAbs.Tracing.TraceSender.TraceBreak(10709, 22537, 22543);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 21857, 23187);

                        case TypeAttributes.Public:
                        case TypeAttributes.NestedPublic:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 21857, 23187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 22675, 22705);

                            access = Accessibility.Public;
                            DynAbs.Tracing.TraceSender.TraceBreak(10709, 22731, 22737);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 21857, 23187);

                        case TypeAttributes.NestedFamily:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 21857, 23187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 22820, 22853);

                            access = Accessibility.Protected;
                            DynAbs.Tracing.TraceSender.TraceBreak(10709, 22879, 22885);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 21857, 23187);

                        case TypeAttributes.NotPublic:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 21857, 23187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 22965, 22997);

                            access = Accessibility.Internal;
                            DynAbs.Tracing.TraceSender.TraceBreak(10709, 23023, 23029);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 21857, 23187);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 21857, 23187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 23087, 23168);

                            throw f_10709_23093_23167(_flags & TypeAttributes.VisibilityMask);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 21857, 23187);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 23207, 23221);

                    return access;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 21756, 23236);

                    System.Exception
                    f_10709_23093_23167(System.Reflection.TypeAttributes
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 23093, 23167);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 21680, 23247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 21680, 23247);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol EnumUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 23334, 23678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 23370, 23409);

                    var
                    uncommon = f_10709_23385_23408(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 23427, 23538) || true) && (uncommon == s_noUncommonProperties)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 23427, 23538);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 23507, 23519);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 23427, 23538);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 23558, 23606);

                    f_10709_23558_23605(
                                    this, uncommon);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 23624, 23663);

                    return uncommon.lazyEnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 23334, 23678);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                    f_10709_23385_23408(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUncommonProperties();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 23385, 23408);
                        return return_v;
                    }


                    int
                    f_10709_23558_23605(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                    uncommon)
                    {
                        this_param.EnsureEnumUnderlyingTypeIsLoaded(uncommon);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 23558, 23605);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 23259, 23689);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 23259, 23689);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 23701, 25126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 23793, 23832);

                var
                uncommon = f_10709_23808_23831(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 23846, 23982) || true) && (uncommon == s_noUncommonProperties)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 23846, 23982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 23918, 23967);

                    return ImmutableArray<CSharpAttributeData>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 23846, 23982);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 23998, 25062) || true) && (uncommon.lazyCustomAttributes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 23998, 25062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 24075, 24925);

                    var
                    loadedCustomAttributes = f_10709_24104_24924(f_10709_24104_24122(), f_10709_24173_24179(), out _, (DynAbs.Tracing.TraceSender.Conditional_F1(10709, 24277, 24305) || ((f_10709_24277_24305() && DynAbs.Tracing.TraceSender.Conditional_F2(10709, 24308, 24360)) || DynAbs.Tracing.TraceSender.Conditional_F3(10709, 24363, 24370))) ? AttributeDescription.CaseSensitiveExtensionAttribute : default, out _, (DynAbs.Tracing.TraceSender.Conditional_F1(10709, 24495, 24543) || ((                    // Filter out [Obsolete], unless it was user defined
                                        (f_10709_24496_24509() && (DynAbs.Tracing.TraceSender.Expression_True(10709, 24496, 24542) && f_10709_24513_24534() is null)) && DynAbs.Tracing.TraceSender.Conditional_F2(10709, 24546, 24584)) || DynAbs.Tracing.TraceSender.Conditional_F3(10709, 24587, 24594))) ? AttributeDescription.ObsoleteAttribute : default, out _, (DynAbs.Tracing.TraceSender.Conditional_F1(10709, 24693, 24703) || ((f_10709_24693_24703() && DynAbs.Tracing.TraceSender.Conditional_F2(10709, 24706, 24746)) || DynAbs.Tracing.TraceSender.Conditional_F3(10709, 24749, 24756))) ? AttributeDescription.IsReadOnlyAttribute : default, out _, (DynAbs.Tracing.TraceSender.Conditional_F1(10709, 24856, 24869) || ((f_10709_24856_24869() && DynAbs.Tracing.TraceSender.Conditional_F2(10709, 24872, 24913)) || DynAbs.Tracing.TraceSender.Conditional_F3(10709, 24916, 24923))) ? AttributeDescription.IsByRefLikeAttribute : default)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 24945, 25047);

                    f_10709_24945_25046(ref uncommon.lazyCustomAttributes, loadedCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 23998, 25062);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 25078, 25115);

                return uncommon.lazyCustomAttributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 23701, 25126);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                f_10709_23808_23831(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUncommonProperties();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 23808, 23831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_24104_24122()
                {
                    var return_v = ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 24104, 24122);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandle
                f_10709_24173_24179()
                {
                    var return_v = Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 24173, 24179);
                    return return_v;
                }


                bool
                f_10709_24277_24305()
                {
                    var return_v = MightContainExtensionMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 24277, 24305);
                    return return_v;
                }


                bool
                f_10709_24496_24509()
                {
                    var return_v = IsRefLikeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 24496, 24509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ObsoleteAttributeData?
                f_10709_24513_24534()
                {
                    var return_v = ObsoleteAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 24513, 24534);
                    return return_v;
                }


                bool
                f_10709_24693_24703()
                {
                    var return_v = IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 24693, 24703);
                    return return_v;
                }


                bool
                f_10709_24856_24869()
                {
                    var return_v = IsRefLikeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 24856, 24869);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10709_24104_24924(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                token, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute1, Microsoft.CodeAnalysis.AttributeDescription
                filterOut1, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute2, Microsoft.CodeAnalysis.AttributeDescription
                filterOut2, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute3, Microsoft.CodeAnalysis.AttributeDescription
                filterOut3, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute4, Microsoft.CodeAnalysis.AttributeDescription
                filterOut4)
                {
                    var return_v = this_param.GetCustomAttributesForToken((System.Reflection.Metadata.EntityHandle)token, out filteredOutAttribute1, filterOut1, out filteredOutAttribute2, filterOut2, out filteredOutAttribute3, filterOut3, out filteredOutAttribute4, filterOut4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 24104, 24924);
                    return return_v;
                }


                bool
                f_10709_24945_25046(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 24945, 25046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 23701, 25126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 23701, 25126);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 25138, 25304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 25270, 25293);

                return f_10709_25277_25292(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 25138, 25304);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10709_25277_25292(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 25277, 25292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 25138, 25304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 25138, 25304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override byte? GetNullableContextValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 25316, 25804);
                byte arg = default(byte);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 25390, 25402);

                byte?
                value
                = default(byte?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 25416, 25766) || true) && (!f_10709_25421_25468(_lazyNullableContextValue, out value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 25416, 25766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 25502, 25674);

                    value = (DynAbs.Tracing.TraceSender.Conditional_F1(10709, 25510, 25586) || ((f_10709_25510_25586(f_10709_25510_25535(f_10709_25510_25528()), _handle, out arg) && DynAbs.Tracing.TraceSender.Conditional_F2(10709, 25610, 25613)) || DynAbs.Tracing.TraceSender.Conditional_F3(10709, 25637, 25673))) ? arg : f_10709_25637_25673(_container);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 25692, 25751);

                    _lazyNullableContextValue = f_10709_25720_25750(value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 25416, 25766);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 25780, 25793);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 25316, 25804);

                bool
                f_10709_25421_25468(Microsoft.CodeAnalysis.CSharp.Symbols.NullableContextKind
                kind, out byte?
                value)
                {
                    var return_v = kind.TryGetByte(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 25421, 25468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_25510_25528()
                {
                    var return_v = ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 25510, 25528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_25510_25535(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 25510, 25535);
                    return return_v;
                }


                bool
                f_10709_25510_25586(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                token, out byte
                value)
                {
                    var return_v = this_param.HasNullableContextAttribute((System.Reflection.Metadata.EntityHandle)token, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 25510, 25586);
                    return return_v;
                }


                byte?
                f_10709_25637_25673(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 25637, 25673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NullableContextKind
                f_10709_25720_25750(byte?
                value)
                {
                    var return_v = value.ToNullableContextFlags();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 25720, 25750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 25316, 25804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 25316, 25804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override byte? GetLocalNullableContextValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 25816, 25943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 25895, 25932);

                throw f_10709_25901_25931();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 25816, 25943);

                System.Exception
                f_10709_25901_25931()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 25901, 25931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 25816, 25943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 25816, 25943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<string> MemberNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 26027, 26156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 26063, 26099);

                    f_10709_26063_26098(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 26117, 26141);

                    return _lazyMemberNames;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 26027, 26156);

                    int
                    f_10709_26063_26098(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        this_param.EnsureNonTypeMemberNamesAreLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 26063, 26098);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 25955, 26167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 25955, 26167);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void EnsureNonTypeMemberNamesAreLoaded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 26179, 29028);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 26252, 29017) || true) && (_lazyMemberNames == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 26252, 29017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 26314, 26352);

                    var
                    moduleSymbol = f_10709_26333_26351()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 26370, 26403);

                    var
                    module = f_10709_26383_26402(moduleSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 26423, 26457);

                    var
                    names = f_10709_26435_26456()
                    ;

                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 26521, 26885);
                            foreach (var methodDef in f_10709_26547_26586_I(f_10709_26547_26586(module, _handle)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 26521, 26885);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 26696, 26749);

                                    f_10709_26696_26748(names, f_10709_26706_26747(module, methodDef));
                                }
                                catch (BadImageFormatException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 26802, 26862);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 26802, 26862);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 26521, 26885);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 365);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 365);
                        }
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 26922, 26974);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 26922, 26974);
                    }

                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 27038, 27411);
                            foreach (var propertyDef in f_10709_27066_27108_I(f_10709_27066_27108(module, _handle)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 27038, 27411);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 27218, 27275);

                                    f_10709_27218_27274(names, f_10709_27228_27273(module, propertyDef));
                                }
                                catch (BadImageFormatException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 27328, 27388);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 27328, 27388);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 27038, 27411);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 374);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 374);
                        }
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 27448, 27500);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 27448, 27500);
                    }

                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 27564, 27924);
                            foreach (var eventDef in f_10709_27589_27627_I(f_10709_27589_27627(module, _handle)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 27564, 27924);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 27737, 27788);

                                    f_10709_27737_27787(names, f_10709_27747_27786(module, eventDef));
                                }
                                catch (BadImageFormatException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 27841, 27901);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 27841, 27901);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 27564, 27924);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 361);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 361);
                        }
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 27961, 28013);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 27961, 28013);
                    }

                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 28077, 28437);
                            foreach (var fieldDef in f_10709_28102_28140_I(f_10709_28102_28140(module, _handle)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 28077, 28437);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 28250, 28301);

                                    f_10709_28250_28300(names, f_10709_28260_28299(module, fieldDef));
                                }
                                catch (BadImageFormatException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 28354, 28414);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 28354, 28414);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 28077, 28437);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 361);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 361);
                        }
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 28474, 28526);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 28474, 28526);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 28755, 28892) || true) && (f_10709_28759_28775(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 28755, 28892);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 28817, 28873);

                        f_10709_28817_28872(names, WellKnownMemberNames.InstanceConstructorName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 28755, 28892);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 28912, 29002);

                    f_10709_28912_29001(ref _lazyMemberNames, f_10709_28962_28994(names), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 26252, 29017);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 26179, 29028);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_26333_26351()
                {
                    var return_v = ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 26333, 26351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_26383_26402(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 26383, 26402);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_10709_26435_26456()
                {
                    var return_v = new System.Collections.Generic.HashSet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 26435, 26456);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandleCollection
                f_10709_26547_26586(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetMethodsOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 26547, 26586);
                    return return_v;
                }


                string
                f_10709_26706_26747(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.GetMethodDefNameOrThrow(methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 26706, 26747);
                    return return_v;
                }


                bool
                f_10709_26696_26748(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 26696, 26748);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandleCollection
                f_10709_26547_26586_I(System.Reflection.Metadata.MethodDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 26547, 26586);
                    return return_v;
                }


                System.Reflection.Metadata.PropertyDefinitionHandleCollection
                f_10709_27066_27108(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetPropertiesOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 27066, 27108);
                    return return_v;
                }


                string
                f_10709_27228_27273(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.PropertyDefinitionHandle
                propertyDef)
                {
                    var return_v = this_param.GetPropertyDefNameOrThrow(propertyDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 27228, 27273);
                    return return_v;
                }


                bool
                f_10709_27218_27274(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 27218, 27274);
                    return return_v;
                }


                System.Reflection.Metadata.PropertyDefinitionHandleCollection
                f_10709_27066_27108_I(System.Reflection.Metadata.PropertyDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 27066, 27108);
                    return return_v;
                }


                System.Reflection.Metadata.EventDefinitionHandleCollection
                f_10709_27589_27627(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetEventsOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 27589, 27627);
                    return return_v;
                }


                string
                f_10709_27747_27786(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EventDefinitionHandle
                eventDef)
                {
                    var return_v = this_param.GetEventDefNameOrThrow(eventDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 27747, 27786);
                    return return_v;
                }


                bool
                f_10709_27737_27787(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 27737, 27787);
                    return return_v;
                }


                System.Reflection.Metadata.EventDefinitionHandleCollection
                f_10709_27589_27627_I(System.Reflection.Metadata.EventDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 27589, 27627);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandleCollection
                f_10709_28102_28140(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetFieldsOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 28102, 28140);
                    return return_v;
                }


                string
                f_10709_28260_28299(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                fieldDef)
                {
                    var return_v = this_param.GetFieldDefNameOrThrow(fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 28260, 28299);
                    return return_v;
                }


                bool
                f_10709_28250_28300(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 28250, 28300);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandleCollection
                f_10709_28102_28140_I(System.Reflection.Metadata.FieldDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 28102, 28140);
                    return return_v;
                }


                bool
                f_10709_28759_28775(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 28759, 28775);
                    return return_v;
                }


                bool
                f_10709_28817_28872(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 28817, 28872);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_10709_28962_28994(System.Collections.Generic.HashSet<string>
                names)
                {
                    var return_v = CreateReadOnlyMemberNames(names);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 28962, 28994);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>?
                f_10709_28912_29001(ref System.Collections.Generic.ICollection<string>?
                location1, System.Collections.Generic.ICollection<string>
                value, System.Collections.Generic.ICollection<string>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 28912, 29001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 26179, 29028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 26179, 29028);
            }
        }

        private static ICollection<string> CreateReadOnlyMemberNames(HashSet<string> names)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10709, 29040, 30107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 29148, 30096);

                switch (f_10709_29156_29167(names))
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 29148, 30096);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 29230, 29279);

                        return f_10709_29237_29278();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 29148, 30096);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 29148, 30096);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 29328, 29393);

                        return f_10709_29335_29392(f_10709_29378_29391(names));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 29148, 30096);

                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 29148, 30096);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 29941, 29982);

                        return f_10709_29948_29981(names);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 29148, 30096);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 29148, 30096);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 30032, 30081);

                        return f_10709_30039_30080(names);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 29148, 30096);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10709, 29040, 30107);

                int
                f_10709_29156_29167(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 29156, 29167);
                    return return_v;
                }


                System.Collections.Generic.ISet<string>
                f_10709_29237_29278()
                {
                    var return_v = SpecializedCollections.EmptySet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 29237, 29278);
                    return return_v;
                }


                string
                f_10709_29378_29391(System.Collections.Generic.HashSet<string>
                source)
                {
                    var return_v = source.First<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 29378, 29391);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_10709_29335_29392(string
                value)
                {
                    var return_v = SpecializedCollections.SingletonCollection(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 29335, 29392);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10709_29948_29981(System.Collections.Generic.HashSet<string>
                items)
                {
                    var return_v = ImmutableArray.CreateRange((System.Collections.Generic.IEnumerable<string>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 29948, 29981);
                    return return_v;
                }


                System.Collections.Generic.ISet<string>
                f_10709_30039_30080(System.Collections.Generic.HashSet<string>
                set)
                {
                    var return_v = SpecializedCollections.ReadOnlySet((System.Collections.Generic.ISet<string>)set);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 30039, 30080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 29040, 30107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 29040, 30107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 30119, 30286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 30195, 30223);

                f_10709_30195_30222(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 30237, 30275);

                return _lazyMembersInDeclarationOrder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 30119, 30286);

                int
                f_10709_30195_30222(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    this_param.EnsureAllMembersAreLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 30195, 30222);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 30119, 30286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 30119, 30286);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<FieldSymbol> GetEnumFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 30298, 33321);

                var listYield = new List<FieldSymbol>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 30377, 30416);

                var
                uncommon = f_10709_30392_30415(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 30430, 30529) || true) && (uncommon == s_noUncommonProperties)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 30430, 30529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 30502, 30514);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 30430, 30529);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 30545, 30588);

                var
                moduleSymbol = f_10709_30564_30587(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 30602, 30635);

                var
                module = f_10709_30615_30634(moduleSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 30804, 30870);

                var
                fieldDefs = f_10709_30820_30869()
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 30922, 31070);
                        foreach (var fieldDef in f_10709_30947_30985_I(f_10709_30947_30985(module, _handle)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 30922, 31070);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 31027, 31051);

                            f_10709_31027_31050(fieldDefs, fieldDef);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 30922, 31070);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 149);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 149);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 31099, 31147);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 31099, 31147);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 31163, 32077) || true) && (uncommon.lazyInstanceEnumFields.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 31163, 32077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 31242, 31298);

                    var
                    builder = f_10709_31256_31297()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 31318, 31932);
                        foreach (var fieldDef in f_10709_31343_31352_I(fieldDefs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 31318, 31932);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 31446, 31516);

                                FieldAttributes
                                fieldFlags = f_10709_31475_31515(module, fieldDef)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 31542, 31812) || true) && ((fieldFlags & FieldAttributes.Static) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10709, 31546, 31666) && f_10709_31592_31666(fieldFlags, moduleSymbol.ImportOptions)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 31542, 31812);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 31724, 31785);

                                    f_10709_31724_31784(builder, f_10709_31736_31783(moduleSymbol, this, fieldDef));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 31542, 31812);
                                }
                            }
                            catch (BadImageFormatException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 31857, 31913);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 31857, 31913);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 31318, 31932);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 615);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 615);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 31952, 32062);

                    f_10709_31952_32061(ref uncommon.lazyInstanceEnumFields, f_10709_32032_32060(builder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 31163, 32077);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32093, 32113);

                int
                staticIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32127, 32178);

                ImmutableArray<Symbol>
                staticFields = f_10709_32165_32177(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32192, 32214);

                int
                instanceIndex = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32230, 33074);
                    foreach (var fieldDef in f_10709_32255_32264_I(fieldDefs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 32230, 33074);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32298, 32615) || true) && (instanceIndex < uncommon.lazyInstanceEnumFields.Length && (DynAbs.Tracing.TraceSender.Expression_True(10709, 32302, 32425) && f_10709_32360_32413(uncommon.lazyInstanceEnumFields[instanceIndex]) == fieldDef))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 32298, 32615);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32467, 32527);

                            listYield.Add(uncommon.lazyInstanceEnumFields[instanceIndex]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32549, 32565);

                            instanceIndex++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32587, 32596);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 32298, 32615);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32635, 33059) || true) && (staticIndex < staticFields.Length && (DynAbs.Tracing.TraceSender.Expression_True(10709, 32639, 32726) && f_10709_32676_32706(staticFields[staticIndex]) == SymbolKind.Field))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 32635, 33059);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32768, 32821);

                            var
                            field = (PEFieldSymbol)staticFields[staticIndex]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32845, 33040) || true) && (f_10709_32849_32861(field) == fieldDef)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 32845, 33040);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32923, 32942);

                                listYield.Add(field);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 32968, 32982);

                                staticIndex++;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 33008, 33017);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 32845, 33040);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 32635, 33059);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 32230, 33074);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 845);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 845);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 33090, 33107);

                f_10709_33090_33106(
                            fieldDefs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 33123, 33193);

                f_10709_33123_33192(instanceIndex == uncommon.lazyInstanceEnumFields.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 33207, 33310);

                f_10709_33207_33309(staticIndex == staticFields.Length || (DynAbs.Tracing.TraceSender.Expression_False(10709, 33220, 33308) || f_10709_33258_33288(staticFields[staticIndex]) != SymbolKind.Field));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 30298, 33321);

                return listYield;

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                f_10709_30392_30415(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUncommonProperties();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 30392, 30415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_30564_30587(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 30564, 30587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_30615_30634(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 30615, 30634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.FieldDefinitionHandle>
                f_10709_30820_30869()
                {
                    var return_v = ArrayBuilder<FieldDefinitionHandle>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 30820, 30869);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandleCollection
                f_10709_30947_30985(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetFieldsOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 30947, 30985);
                    return return_v;
                }


                int
                f_10709_31027_31050(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.FieldDefinitionHandle>
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 31027, 31050);
                    return 0;
                }


                System.Reflection.Metadata.FieldDefinitionHandleCollection
                f_10709_30947_30985_I(System.Reflection.Metadata.FieldDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 30947, 30985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                f_10709_31256_31297()
                {
                    var return_v = ArrayBuilder<PEFieldSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 31256, 31297);
                    return return_v;
                }


                System.Reflection.FieldAttributes
                f_10709_31475_31515(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                fieldDef)
                {
                    var return_v = this_param.GetFieldDefFlagsOrThrow(fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 31475, 31515);
                    return return_v;
                }


                bool
                f_10709_31592_31666(System.Reflection.FieldAttributes
                flags, Microsoft.CodeAnalysis.MetadataImportOptions
                importOptions)
                {
                    var return_v = ModuleExtensions.ShouldImportField(flags, importOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 31592, 31666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                f_10709_31736_31783(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                containingType, System.Reflection.Metadata.FieldDefinitionHandle
                fieldDef)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol(moduleSymbol, containingType, fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 31736, 31783);
                    return return_v;
                }


                int
                f_10709_31724_31784(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 31724, 31784);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.FieldDefinitionHandle>
                f_10709_31343_31352_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.FieldDefinitionHandle>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 31343, 31352);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                f_10709_32032_32060(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 32032, 32060);
                    return return_v;
                }


                bool
                f_10709_31952_32061(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 31952, 32061);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_32165_32177(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 32165, 32177);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandle
                f_10709_32360_32413(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 32360, 32413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10709_32676_32706(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 32676, 32706);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandle
                f_10709_32849_32861(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 32849, 32861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.FieldDefinitionHandle>
                f_10709_32255_32264_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.FieldDefinitionHandle>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 32255, 32264);
                    return return_v;
                }


                int
                f_10709_33090_33106(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.FieldDefinitionHandle>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 33090, 33106);
                    return 0;
                }


                int
                f_10709_33123_33192(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 33123, 33192);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10709_33258_33288(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 33258, 33288);
                    return return_v;
                }


                int
                f_10709_33207_33309(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 33207, 33309);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 30298, 33321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 30298, 33321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 33333, 36406);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 33418, 36395) || true) && (f_10709_33422_33435(this) == TypeKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 33418, 36395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 33486, 33515);

                    return f_10709_33493_33514(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 33418, 36395);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 33418, 36395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 33668, 33823);

                    IEnumerable<FieldSymbol>
                    nonEventFields = f_10709_33710_33822(f_10709_33710_33781(f_10709_33734_33751(this), SymbolKind.Field, offset: 0), f => f.TupleUnderlyingField ?? f)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 33957, 34002);

                    ArrayBuilder<FieldSymbol>
                    eventFields = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 34022, 34816);
                        foreach (var eventSymbol in f_10709_34050_34067_I(f_10709_34050_34067(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 34022, 34816);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 34109, 34167);

                            FieldSymbol
                            associatedField = f_10709_34139_34166(eventSymbol)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 34189, 34797) || true) && ((object)associatedField != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 34189, 34797);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 34274, 34337);

                                f_10709_34274_34336((object)f_10709_34295_34327(associatedField) != null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 34365, 34439);

                                associatedField = f_10709_34383_34419(associatedField) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(10709, 34383, 34438) ?? associatedField);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 34467, 34523);

                                f_10709_34467_34522(!f_10709_34481_34521(nonEventFields, associatedField));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 34551, 34713) || true) && (eventFields == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 34551, 34713);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 34632, 34686);

                                    eventFields = f_10709_34646_34685();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 34551, 34713);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 34741, 34774);

                                f_10709_34741_34773(
                                                        eventFields, associatedField);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 34189, 34797);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 34022, 34816);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 795);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 795);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 34836, 34978) || true) && (eventFields == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 34836, 34978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 34937, 34959);

                        return nonEventFields;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 34836, 34978);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 35120, 35201);

                    var
                    handleToFieldMap = f_10709_35143_35200()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 35219, 35233);

                    int
                    count = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 35253, 35432);
                        foreach (PEFieldSymbol field in f_10709_35285_35299_I(nonEventFields))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 35253, 35432);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 35341, 35383);

                            f_10709_35341_35382(handleToFieldMap, f_10709_35362_35374(field), field);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 35405, 35413);

                            count++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 35253, 35432);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 180);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 180);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 35452, 35598);
                        foreach (PEFieldSymbol field in f_10709_35484_35495_I(eventFields))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 35452, 35598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 35537, 35579);

                            f_10709_35537_35578(handleToFieldMap, f_10709_35558_35570(field), field);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 35452, 35598);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 147);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 147);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 35618, 35645);

                    count += f_10709_35627_35644(eventFields);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 35663, 35682);

                    f_10709_35663_35681(eventFields);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 35702, 35760);

                    var
                    result = f_10709_35715_35759(count)
                    ;

                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 35824, 36180);
                            foreach (var handle in f_10709_35847_35909_I(f_10709_35847_35909(f_10709_35847_35877(f_10709_35847_35870(this)), _handle)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 35824, 36180);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 35959, 35977);

                                FieldSymbol
                                field
                                = default(FieldSymbol);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 36003, 36157) || true) && (f_10709_36007_36054(handleToFieldMap, handle, out field))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 36003, 36157);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 36112, 36130);

                                    f_10709_36112_36129(result, field);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 36003, 36157);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 35824, 36180);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 357);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 357);
                        }
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 36217, 36269);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 36217, 36269);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 36289, 36325);

                    f_10709_36289_36324(f_10709_36302_36314(result) == count);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 36345, 36380);

                    return f_10709_36352_36379(result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 33418, 36395);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 33333, 36406);

                Microsoft.CodeAnalysis.TypeKind
                f_10709_33422_33435(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 33422, 33435);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10709_33493_33514(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetEnumFieldsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 33493, 33514);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_33734_33751(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 33734, 33751);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10709_33710_33781(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                members, Microsoft.CodeAnalysis.SymbolKind
                kind, int
                offset)
                {
                    var return_v = GetMembers<FieldSymbol>(members, kind, offset: offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 33710, 33781);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10709_33710_33822(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 33710, 33822);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10709_34050_34067(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetEventsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 34050, 34067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10709_34139_34166(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 34139, 34166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10709_34295_34327(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 34295, 34327);
                    return return_v;
                }


                int
                f_10709_34274_34336(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 34274, 34336);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10709_34383_34419(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TupleUnderlyingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 34383, 34419);
                    return return_v;
                }


                bool
                f_10709_34481_34521(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                source, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                value)
                {
                    var return_v = source.Contains<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 34481, 34521);
                    return return_v;
                }


                int
                f_10709_34467_34522(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 34467, 34522);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10709_34646_34685()
                {
                    var return_v = ArrayBuilder<FieldSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 34646, 34685);
                    return return_v;
                }


                int
                f_10709_34741_34773(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 34741, 34773);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10709_34050_34067_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 34050, 34067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<System.Reflection.Metadata.FieldDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10709_35143_35200()
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<System.Reflection.Metadata.FieldDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 35143, 35200);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandle
                f_10709_35362_35374(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 35362, 35374);
                    return return_v;
                }


                int
                f_10709_35341_35382(Microsoft.CodeAnalysis.SmallDictionary<System.Reflection.Metadata.FieldDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                key, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                value)
                {
                    this_param.Add(key, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 35341, 35382);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10709_35285_35299_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 35285, 35299);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandle
                f_10709_35558_35570(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 35558, 35570);
                    return return_v;
                }


                int
                f_10709_35537_35578(Microsoft.CodeAnalysis.SmallDictionary<System.Reflection.Metadata.FieldDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                key, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                value)
                {
                    this_param.Add(key, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 35537, 35578);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10709_35484_35495_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 35484, 35495);
                    return return_v;
                }


                int
                f_10709_35627_35644(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 35627, 35644);
                    return return_v;
                }


                int
                f_10709_35663_35681(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 35663, 35681);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10709_35715_35759(int
                capacity)
                {
                    var return_v = ArrayBuilder<FieldSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 35715, 35759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_35847_35870(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 35847, 35870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_35847_35877(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 35847, 35877);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandleCollection
                f_10709_35847_35909(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetFieldsOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 35847, 35909);
                    return return_v;
                }


                bool
                f_10709_36007_36054(Microsoft.CodeAnalysis.SmallDictionary<System.Reflection.Metadata.FieldDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 36007, 36054);
                    return return_v;
                }


                int
                f_10709_36112_36129(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 36112, 36129);
                    return 0;
                }


                System.Reflection.Metadata.FieldDefinitionHandleCollection
                f_10709_35847_35909_I(System.Reflection.Metadata.FieldDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 35847, 35909);
                    return return_v;
                }


                int
                f_10709_36302_36314(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 36302, 36314);
                    return return_v;
                }


                int
                f_10709_36289_36324(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 36289, 36324);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10709_36352_36379(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 36352, 36379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 33333, 36406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 33333, 36406);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<MethodSymbol> GetMethodsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 36418, 39886);

                var listYield = new List<MethodSymbol>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 36505, 36551);

                ImmutableArray<Symbol>
                members = f_10709_36538_36550(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 36599, 36661);

                int
                index = f_10709_36611_36660(members, SymbolKind.Method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 36677, 39875) || true) && (!f_10709_36682_36704(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 36677, 39875);
                    try
                    {
                        for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 36738, 37283) || true) && (index < members.Length)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 36769, 36776)
   , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 36738, 37283))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 36738, 37283);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 36818, 36941) || true) && (f_10709_36822_36841(members[index]) != SymbolKind.Method)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 36818, 36941);
                                DynAbs.Tracing.TraceSender.TraceBreak(10709, 36912, 36918);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 36818, 36941);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 36965, 37007);

                            var
                            method = (MethodSymbol)members[index]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 37128, 37264) || true) && (!f_10709_37133_37171(method))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 37128, 37264);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 37221, 37241);

                                listYield.Add(method);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 37128, 37264);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 546);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 546);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 36677, 39875);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 36677, 39875);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 37457, 37688) || true) && (index >= members.Length || (DynAbs.Tracing.TraceSender.Expression_False(10709, 37461, 37528) || f_10709_37488_37507(members[index]) != SymbolKind.Method))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 37457, 37688);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 37657, 37669);

                        return listYield;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 37457, 37688);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 37708, 37752);

                    var
                    method = (PEMethodSymbol)members[index]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 37770, 37814);

                    var
                    module = f_10709_37783_37813(f_10709_37783_37806(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 37834, 37902);

                    var
                    methodDefs = f_10709_37851_37901()
                    ;

                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 37966, 38130);
                            foreach (var methodDef in f_10709_37992_38031_I(f_10709_37992_38031(module, _handle)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 37966, 38130);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 38081, 38107);

                                f_10709_38081_38106(methodDefs, methodDef);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 37966, 38130);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 165);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 165);
                        }
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 38167, 38219);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 38167, 38219);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 38239, 39735);
                        foreach (var methodDef in f_10709_38265_38275_I(methodDefs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 38239, 39735);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 38317, 39716) || true) && (f_10709_38321_38334(method) == methodDef)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 38317, 39716);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 38397, 38417);

                                listYield.Add(method);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 38443, 38451);

                                index++;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 38479, 38766) || true) && (index == members.Length || (DynAbs.Tracing.TraceSender.Expression_False(10709, 38483, 38550) || f_10709_38510_38529(members[index]) != SymbolKind.Method))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 38479, 38766);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 38679, 38697);

                                    f_10709_38679_38696(                            // no need to return any gaps at the end.
                                                                methodDefs);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 38727, 38739);

                                    return listYield;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 38479, 38766);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 38794, 38834);

                                method = (PEMethodSymbol)members[index];
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 38317, 39716);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 38317, 39716);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 38979, 38991);

                                int
                                gapSize
                                = default(int);

                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 39079, 39166);

                                    gapSize = f_10709_39089_39165(f_10709_39123_39164(module, methodDef));
                                }
                                catch (BadImageFormatException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 39219, 39346);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 39307, 39319);

                                    gapSize = 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 39219, 39346);
                                }
                                {
                                    try
                                    {
                                        do

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 39503, 39693);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 39562, 39580);

                                            listYield.Add(null);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 39610, 39620);

                                            gapSize--;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 39503, 39693);
                                        }
                                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 39503, 39693) || true) && (gapSize > 0)
                                        );
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 39503, 39693);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 39503, 39693);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 38317, 39716);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 38239, 39735);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 1497);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 1497);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 39823, 39860);

                    throw f_10709_39829_39859();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 36677, 39875);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 36418, 39886);

                return listYield;

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_36538_36550(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 36538, 36550);
                    return return_v;
                }


                int
                f_10709_36611_36660(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                members, Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = GetIndexOfFirstMember(members, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 36611, 36660);
                    return return_v;
                }


                bool
                f_10709_36682_36704(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 36682, 36704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10709_36822_36841(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 36822, 36841);
                    return return_v;
                }


                bool
                f_10709_37133_37171(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsDefaultValueTypeConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 37133, 37171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10709_37488_37507(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 37488, 37507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_37783_37806(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 37783, 37806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_37783_37813(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 37783, 37813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.MethodDefinitionHandle>
                f_10709_37851_37901()
                {
                    var return_v = ArrayBuilder<MethodDefinitionHandle>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 37851, 37901);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandleCollection
                f_10709_37992_38031(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetMethodsOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 37992, 38031);
                    return return_v;
                }


                int
                f_10709_38081_38106(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.MethodDefinitionHandle>
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 38081, 38106);
                    return 0;
                }


                System.Reflection.Metadata.MethodDefinitionHandleCollection
                f_10709_37992_38031_I(System.Reflection.Metadata.MethodDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 37992, 38031);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandle
                f_10709_38321_38334(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 38321, 38334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10709_38510_38529(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 38510, 38529);
                    return return_v;
                }


                int
                f_10709_38679_38696(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.MethodDefinitionHandle>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 38679, 38696);
                    return 0;
                }


                string
                f_10709_39123_39164(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.GetMethodDefNameOrThrow(methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 39123, 39164);
                    return return_v;
                }


                int
                f_10709_39089_39165(string
                emittedMethodName)
                {
                    var return_v = ModuleExtensions.GetVTableGapSize(emittedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 39089, 39165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.MethodDefinitionHandle>
                f_10709_38265_38275_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.MethodDefinitionHandle>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 38265, 38275);
                    return return_v;
                }


                System.Exception
                f_10709_39829_39859()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 39829, 39859);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 36418, 39886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 36418, 39886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<PropertySymbol> GetPropertiesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 39898, 40075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 39990, 40064);

                return f_10709_39997_40063(f_10709_40024_40041(this), SymbolKind.Property);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 39898, 40075);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_40024_40041(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 40024, 40041);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10709_39997_40063(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                members, Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = GetMembers<PropertySymbol>(members, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 39997, 40063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 39898, 40075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 39898, 40075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<EventSymbol> GetEventsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 40087, 40251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 40172, 40240);

                return f_10709_40179_40239(f_10709_40203_40220(this), SymbolKind.Event);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 40087, 40251);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_40203_40220(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 40203, 40220);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10709_40179_40239(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                members, Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = GetMembers<EventSymbol>(members, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 40179, 40239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 40087, 40251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 40087, 40251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 40263, 40408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 40363, 40397);

                return f_10709_40370_40396(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 40263, 40408);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_40370_40396(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 40370, 40396);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 40263, 40408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 40263, 40408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 40420, 40571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 40531, 40560);

                return f_10709_40538_40559(this, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 40420, 40571);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_40538_40559(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 40538, 40559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 40420, 40571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 40420, 40571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class DeclarationOrderTypeSymbolComparer : IComparer<Symbol>
        {
            public static readonly DeclarationOrderTypeSymbolComparer Instance;

            private DeclarationOrderTypeSymbolComparer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10709, 40802, 40850);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10709, 40802, 40850);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 40802, 40850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 40802, 40850);
                }
            }

            public int Compare(Symbol x, Symbol y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 40866, 41052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 40937, 41037);

                    return f_10709_40944_41036(f_10709_40944_40966(), f_10709_40975_41004(((PENamedTypeSymbol)x)), f_10709_41006_41035(((PENamedTypeSymbol)y)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 40866, 41052);

                    System.Reflection.Metadata.HandleComparer
                    f_10709_40944_40966()
                    {
                        var return_v = HandleComparer.Default;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 40944, 40966);
                        return return_v;
                    }


                    System.Reflection.Metadata.TypeDefinitionHandle
                    f_10709_40975_41004(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Handle;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 40975, 41004);
                        return return_v;
                    }


                    System.Reflection.Metadata.TypeDefinitionHandle
                    f_10709_41006_41035(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Handle;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 41006, 41035);
                        return return_v;
                    }


                    int
                    f_10709_40944_41036(System.Reflection.Metadata.HandleComparer
                    this_param, System.Reflection.Metadata.TypeDefinitionHandle
                    x, System.Reflection.Metadata.TypeDefinitionHandle
                    y)
                    {
                        var return_v = this_param.Compare((System.Reflection.Metadata.EntityHandle)x, (System.Reflection.Metadata.EntityHandle)y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 40944, 41036);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 40866, 41052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 40866, 41052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static DeclarationOrderTypeSymbolComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10709, 40583, 41063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 40734, 40785);
                Instance = f_10709_40745_40785(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10709, 40583, 41063);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 40583, 41063);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10709, 40583, 41063);

            static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.DeclarationOrderTypeSymbolComparer
            f_10709_40745_40785()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.DeclarationOrderTypeSymbolComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 40745, 40785);
                return return_v;
            }

        }

        private void EnsureEnumUnderlyingTypeIsLoaded(UncommonProperties uncommon)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 41077, 44371);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 41176, 44360) || true) && ((object)(uncommon.lazyEnumUnderlyingType) == null
                && (DynAbs.Tracing.TraceSender.Expression_True(10709, 41180, 41280) && f_10709_41250_41263(this) == TypeKind.Enum))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 41176, 44360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 41933, 41976);

                    var
                    moduleSymbol = f_10709_41952_41975(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 41994, 42027);

                    var
                    module = f_10709_42007_42026(moduleSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 42045, 42099);

                    var
                    decoder = f_10709_42059_42098(moduleSymbol, this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 42117, 42155);

                    NamedTypeSymbol
                    underlyingType = null
                    ;

                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 42219, 43728);
                            foreach (var fieldDef in f_10709_42244_42282_I(f_10709_42244_42282(module, _handle)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 42219, 43728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 42332, 42359);

                                FieldAttributes
                                fieldFlags
                                = default(FieldAttributes);

                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 42447, 42501);

                                    fieldFlags = f_10709_42460_42500(module, fieldDef);
                                }
                                catch (BadImageFormatException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 42554, 42678);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 42642, 42651);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 42554, 42678);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 42706, 43705) || true) && ((fieldFlags & FieldAttributes.Static) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 42706, 43705);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 42892, 42949);

                                    ImmutableArray<ModifierInfo<TypeSymbol>>
                                    customModifiers
                                    = default(ImmutableArray<ModifierInfo<TypeSymbol>>);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 42979, 43057);

                                    TypeSymbol
                                    type = f_10709_42997_43056(decoder, fieldDef, out customModifiers)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 43089, 43678) || true) && (f_10709_43093_43137(f_10709_43093_43109(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 43093, 43171) && !customModifiers.AnyRequired()))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 43089, 43678);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 43237, 43647) || true) && ((object)underlyingType == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 43237, 43647);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 43345, 43384);

                                            underlyingType = (NamedTypeSymbol)type;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 43237, 43647);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 43237, 43647);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 43530, 43583);

                                            underlyingType = f_10709_43547_43582();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 43237, 43647);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 43089, 43678);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 42706, 43705);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 42219, 43728);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 1510);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 1510);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 43752, 43941) || true) && ((object)underlyingType == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 43752, 43941);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 43836, 43889);

                            underlyingType = f_10709_43853_43888();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 43752, 43941);
                        }
                    }
                    catch (BadImageFormatException mrEx)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 43978, 44238);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 44055, 44219) || true) && ((object)underlyingType == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 44055, 44219);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 44139, 44196);

                            underlyingType = f_10709_44156_44195(mrEx);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 44055, 44219);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 43978, 44238);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 44258, 44345);

                    f_10709_44258_44344(ref uncommon.lazyEnumUnderlyingType, underlyingType, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 41176, 44360);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 41077, 44371);

                Microsoft.CodeAnalysis.TypeKind
                f_10709_41250_41263(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 41250, 41263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_41952_41975(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 41952, 41975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_42007_42026(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 42007, 42026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10709_42059_42098(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 42059, 42098);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandleCollection
                f_10709_42244_42282(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetFieldsOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 42244, 42282);
                    return return_v;
                }


                System.Reflection.FieldAttributes
                f_10709_42460_42500(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                fieldDef)
                {
                    var return_v = this_param.GetFieldDefFlagsOrThrow(fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 42460, 42500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10709_42997_43056(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                fieldHandle, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers)
                {
                    var return_v = this_param.DecodeFieldSignature(fieldHandle, out customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 42997, 43056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10709_43093_43109(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 43093, 43109);
                    return return_v;
                }


                bool
                f_10709_43093_43137(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsValidEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 43093, 43137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10709_43547_43582()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 43547, 43582);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandleCollection
                f_10709_42244_42282_I(System.Reflection.Metadata.FieldDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 42244, 42282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10709_43853_43888()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 43853, 43888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10709_44156_44195(System.BadImageFormatException
                mrEx)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol(mrEx);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 44156, 44195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10709_44258_44344(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 44258, 44344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 41077, 44371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 41077, 44371);
            }
        }

        private void EnsureAllMembersAreLoaded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 44383, 44552);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 44448, 44541) || true) && (_lazyMembersByName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 44448, 44541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 44512, 44526);

                    f_10709_44512_44525(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 44448, 44541);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 44383, 44552);

                int
                f_10709_44512_44525(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    this_param.LoadMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 44512, 44525);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 44383, 44552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 44383, 44552);
            }
        }

        private void LoadMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 44564, 54724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 44615, 44651);

                ArrayBuilder<Symbol>
                members = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 44667, 52182) || true) && (_lazyMembersInDeclarationOrder.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 44667, 52182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 44745, 44774);

                    f_10709_44745_44773(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 44794, 44839);

                    members = f_10709_44804_44838();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 44859, 44938);

                    f_10709_44859_44937(f_10709_44872_44902(SymbolKind.Field) < f_10709_44905_44936(SymbolKind.Method));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 44956, 45038);

                    f_10709_44956_45037(f_10709_44969_45000(SymbolKind.Method) < f_10709_45003_45036(SymbolKind.Property));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 45056, 45137);

                    f_10709_45056_45136(f_10709_45069_45102(SymbolKind.Property) < f_10709_45105_45135(SymbolKind.Event));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 45155, 45237);

                    f_10709_45155_45236(f_10709_45168_45198(SymbolKind.Event) < f_10709_45201_45235(SymbolKind.NamedType));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 45257, 50553) || true) && (f_10709_45261_45274(this) == TypeKind.Enum)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 45257, 50553);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 45333, 45396);

                        f_10709_45333_45395(this, f_10709_45366_45394(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 45420, 45463);

                        var
                        moduleSymbol = f_10709_45439_45462(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 45485, 45518);

                        var
                        module = f_10709_45498_45517(moduleSymbol)
                        ;

                        try
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 45594, 46644);
                                foreach (var fieldDef in f_10709_45619_45657_I(f_10709_45619_45657(module, _handle)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 45594, 46644);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 45715, 45742);

                                    FieldAttributes
                                    fieldFlags
                                    = default(FieldAttributes);

                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 45842, 45896);

                                        fieldFlags = f_10709_45855_45895(module, fieldDef);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 45930, 46094) || true) && ((fieldFlags & FieldAttributes.Static) == 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 45930, 46094);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 46050, 46059);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 45930, 46094);
                                        }
                                    }
                                    catch (BadImageFormatException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 46155, 46297);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 46251, 46266);

                                        fieldFlags = 0;
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 46155, 46297);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 46329, 46617) || true) && (f_10709_46333_46407(fieldFlags, moduleSymbol.ImportOptions))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 46329, 46617);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 46473, 46533);

                                        var
                                        field = f_10709_46485_46532(moduleSymbol, this, fieldDef)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 46567, 46586);

                                        f_10709_46567_46585(members, field);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 46329, 46617);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 45594, 46644);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 1051);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 1051);
                            }
                        }
                        catch (BadImageFormatException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 46689, 46745);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 46689, 46745);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 46769, 46830);

                        var
                        syntheticCtor = f_10709_46789_46829(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 46852, 46879);

                        f_10709_46852_46878(members, syntheticCtor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 45257, 50553);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 45257, 50553);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 46961, 47046);

                        ArrayBuilder<PEFieldSymbol>
                        fieldMembers = f_10709_47004_47045()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 47068, 47142);

                        ArrayBuilder<Symbol>
                        nonFieldMembers = f_10709_47107_47141()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 47166, 47265);

                        MultiDictionary<string, PEFieldSymbol>
                        privateFieldNameToSymbols = f_10709_47233_47264(this, fieldMembers)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 48253, 48369);

                        PooledDictionary<MethodDefinitionHandle, PEMethodSymbol>
                        methodHandleToSymbol = f_10709_48333_48368(this, nonFieldMembers)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 48393, 49284) || true) && (f_10709_48397_48410(this) == TypeKind.Struct)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 48393, 49284);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 48479, 48521);

                            bool
                            haveParameterlessConstructor = false
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 48547, 48891);
                                foreach (MethodSymbol method in f_10709_48579_48594_I(nonFieldMembers))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 48547, 48891);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 48652, 48864) || true) && (f_10709_48656_48691(method))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 48652, 48864);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 48757, 48793);

                                        haveParameterlessConstructor = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10709, 48827, 48833);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 48652, 48864);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 48547, 48891);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 345);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 345);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 49075, 49261) || true) && (!haveParameterlessConstructor)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 49075, 49261);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 49166, 49234);

                                f_10709_49166_49233(nonFieldMembers, 0, f_10709_49192_49232(this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 49075, 49261);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 48393, 49284);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 49308, 49369);

                        f_10709_49308_49368(
                                            this, methodHandleToSymbol, nonFieldMembers);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 49391, 49475);

                        f_10709_49391_49474(this, privateFieldNameToSymbols, methodHandleToSymbol, nonFieldMembers);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 49499, 50335);
                            foreach (PEFieldSymbol field in f_10709_49531_49543_I(fieldMembers))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 49499, 50335);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 49593, 50312) || true) && ((object)f_10709_49605_49627(field) == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 49593, 50312);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 49693, 49712);

                                    f_10709_49693_49711(members, field);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 49593, 50312);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 49593, 50312);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 50223, 50285);

                                    f_10709_50223_50284(f_10709_50236_50263(f_10709_50236_50258(field)) == SymbolKind.Event);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 49593, 50312);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 49499, 50335);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 837);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 837);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 50359, 50393);

                        f_10709_50359_50392(
                                            members, nonFieldMembers);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 50417, 50440);

                        f_10709_50417_50439(
                                            nonFieldMembers);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 50462, 50482);

                        f_10709_50462_50481(fieldMembers);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 50506, 50534);

                        f_10709_50506_50533(
                                            methodHandleToSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 45257, 50553);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 50619, 50652);

                    int
                    membersCount = f_10709_50638_50651(members)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 50672, 50810);
                        foreach (var typeArray in f_10709_50698_50721_I(f_10709_50698_50721(_lazyNestedTypes)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 50672, 50810);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 50763, 50791);

                            f_10709_50763_50790(members, typeArray);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 50672, 50810);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 139);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 139);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 50882, 50954);

                    f_10709_50882_50953(
                                    // Sort the types based on row id.
                                    members, membersCount, DeclarationOrderTypeSymbolComparer.Instance);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 50985, 51008);

                    Symbol
                    previous = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51028, 51480);
                        foreach (var s in f_10709_51046_51053_I(members))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 51028, 51480);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51095, 51461) || true) && (previous == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 51095, 51461);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51165, 51178);

                                previous = s;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 51095, 51461);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 51095, 51461);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51276, 51295);

                                Symbol
                                current = s
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51321, 51393);

                                f_10709_51321_51392(f_10709_51334_51361(f_10709_51334_51347(previous)) <= f_10709_51365_51391(f_10709_51365_51377(current)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51419, 51438);

                                previous = current;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 51095, 51461);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 51028, 51480);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 453);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 453);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51508, 51700) || true) && (f_10709_51512_51523())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 51508, 51700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51565, 51627);

                        members = f_10709_51575_51626(this, f_10709_51597_51625(members));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51649, 51681);

                        f_10709_51649_51680(members is object);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 51508, 51700);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51720, 51774);

                    var
                    membersInDeclarationOrder = f_10709_51752_51773(members)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51794, 52167) || true) && (!f_10709_51799_51904(ref _lazyMembersInDeclarationOrder, membersInDeclarationOrder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 51794, 52167);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51946, 51961);

                        f_10709_51946_51960(members);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 51983, 51998);

                        members = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 51794, 52167);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 51794, 52167);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 52121, 52148);

                        f_10709_52121_52147(                    // remove the types
                                            members, membersCount);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 51794, 52167);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 44667, 52182);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 52198, 54614) || true) && (_lazyMembersByName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 52198, 54614);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 52262, 52711) || true) && (members == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 52262, 52711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 52323, 52368);

                        members = f_10709_52333_52367();
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 52390, 52692);
                            foreach (var member in f_10709_52413_52443_I(_lazyMembersInDeclarationOrder))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 52390, 52692);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 52493, 52623) || true) && (f_10709_52497_52508(member) == SymbolKind.NamedType)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 52493, 52623);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10709, 52590, 52596);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 52493, 52623);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 52649, 52669);

                                f_10709_52649_52668(members, member);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 52390, 52692);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 303);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 303);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 52262, 52711);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 52731, 52809);

                    Dictionary<string, ImmutableArray<Symbol>>
                    membersDict = f_10709_52788_52808(members)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 52829, 52921);

                    var
                    exchangeResult = f_10709_52850_52920(ref _lazyMembersByName, membersDict, null)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 52939, 54599) || true) && (exchangeResult == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 52939, 54599);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 54424, 54502);

                        var
                        memberNames = f_10709_54442_54501(f_10709_54484_54500(membersDict))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 54524, 54580);

                        f_10709_54524_54579(ref _lazyMemberNames, memberNames);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 52939, 54599);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 52198, 54614);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 54630, 54713) || true) && (members != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 54630, 54713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 54683, 54698);

                    f_10709_54683_54697(members);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 54630, 54713);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 44564, 54724);

                int
                f_10709_44745_44773(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    this_param.EnsureNestedTypesAreLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 44745, 44773);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_44804_44838()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 44804, 44838);
                    return return_v;
                }


                int
                f_10709_44872_44902(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.ToSortOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 44872, 44902);
                    return return_v;
                }


                int
                f_10709_44905_44936(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.ToSortOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 44905, 44936);
                    return return_v;
                }


                int
                f_10709_44859_44937(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 44859, 44937);
                    return 0;
                }


                int
                f_10709_44969_45000(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.ToSortOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 44969, 45000);
                    return return_v;
                }


                int
                f_10709_45003_45036(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.ToSortOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 45003, 45036);
                    return return_v;
                }


                int
                f_10709_44956_45037(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 44956, 45037);
                    return 0;
                }


                int
                f_10709_45069_45102(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.ToSortOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 45069, 45102);
                    return return_v;
                }


                int
                f_10709_45105_45135(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.ToSortOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 45105, 45135);
                    return return_v;
                }


                int
                f_10709_45056_45136(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 45056, 45136);
                    return 0;
                }


                int
                f_10709_45168_45198(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.ToSortOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 45168, 45198);
                    return return_v;
                }


                int
                f_10709_45201_45235(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.ToSortOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 45201, 45235);
                    return return_v;
                }


                int
                f_10709_45155_45236(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 45155, 45236);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10709_45261_45274(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 45261, 45274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                f_10709_45366_45394(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUncommonProperties();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 45366, 45394);
                    return return_v;
                }


                int
                f_10709_45333_45395(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                uncommon)
                {
                    this_param.EnsureEnumUnderlyingTypeIsLoaded(uncommon);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 45333, 45395);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_45439_45462(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 45439, 45462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_45498_45517(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 45498, 45517);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandleCollection
                f_10709_45619_45657(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetFieldsOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 45619, 45657);
                    return return_v;
                }


                System.Reflection.FieldAttributes
                f_10709_45855_45895(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                fieldDef)
                {
                    var return_v = this_param.GetFieldDefFlagsOrThrow(fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 45855, 45895);
                    return return_v;
                }


                bool
                f_10709_46333_46407(System.Reflection.FieldAttributes
                flags, Microsoft.CodeAnalysis.MetadataImportOptions
                importOptions)
                {
                    var return_v = ModuleExtensions.ShouldImportField(flags, importOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 46333, 46407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                f_10709_46485_46532(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                containingType, System.Reflection.Metadata.FieldDefinitionHandle
                fieldDef)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol(moduleSymbol, containingType, fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 46485, 46532);
                    return return_v;
                }


                int
                f_10709_46567_46585(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 46567, 46585);
                    return 0;
                }


                System.Reflection.Metadata.FieldDefinitionHandleCollection
                f_10709_45619_45657_I(System.Reflection.Metadata.FieldDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 45619, 45657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                f_10709_46789_46829(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                containingType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 46789, 46829);
                    return return_v;
                }


                int
                f_10709_46852_46878(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 46852, 46878);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                f_10709_47004_47045()
                {
                    var return_v = ArrayBuilder<PEFieldSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 47004, 47045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_47107_47141()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 47107, 47141);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                f_10709_47233_47264(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                fieldMembers)
                {
                    var return_v = this_param.CreateFields(fieldMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 47233, 47264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
                f_10709_48333_48368(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                members)
                {
                    var return_v = this_param.CreateMethods(members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 48333, 48368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10709_48397_48410(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 48397, 48410);
                    return return_v;
                }


                bool
                f_10709_48656_48691(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsParameterlessConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 48656, 48691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_48579_48594_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 48579, 48594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                f_10709_49192_49232(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                containingType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 49192, 49232);
                    return return_v;
                }


                int
                f_10709_49166_49233(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                index, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                item)
                {
                    this_param.Insert(index, (Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 49166, 49233);
                    return 0;
                }


                int
                f_10709_49308_49368(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
                methodHandleToSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                members)
                {
                    this_param.CreateProperties((System.Collections.Generic.Dictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>)methodHandleToSymbol, members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 49308, 49368);
                    return 0;
                }


                int
                f_10709_49391_49474(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                privateFieldNameToSymbols, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
                methodHandleToSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                members)
                {
                    this_param.CreateEvents(privateFieldNameToSymbols, (System.Collections.Generic.Dictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>)methodHandleToSymbol, members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 49391, 49474);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10709_49605_49627(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 49605, 49627);
                    return return_v;
                }


                int
                f_10709_49693_49711(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 49693, 49711);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10709_50236_50258(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 50236, 50258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10709_50236_50263(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 50236, 50263);
                    return return_v;
                }


                int
                f_10709_50223_50284(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 50223, 50284);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                f_10709_49531_49543_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 49531, 49543);
                    return return_v;
                }


                int
                f_10709_50359_50392(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 50359, 50392);
                    return 0;
                }


                int
                f_10709_50417_50439(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 50417, 50439);
                    return 0;
                }


                int
                f_10709_50462_50481(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 50462, 50481);
                    return 0;
                }


                int
                f_10709_50506_50533(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 50506, 50533);
                    return 0;
                }


                int
                f_10709_50638_50651(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 50638, 50651);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>.ValueCollection
                f_10709_50698_50721(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 50698, 50721);
                    return return_v;
                }


                int
                f_10709_50763_50790(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                items)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 50763, 50790);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>.ValueCollection
                f_10709_50698_50721_I(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 50698, 50721);
                    return return_v;
                }


                int
                f_10709_50882_50953(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                startIndex, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.DeclarationOrderTypeSymbolComparer
                comparer)
                {
                    this_param.Sort(startIndex, (System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 50882, 50953);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10709_51334_51347(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 51334, 51347);
                    return return_v;
                }


                int
                f_10709_51334_51361(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.ToSortOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 51334, 51361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10709_51365_51377(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 51365, 51377);
                    return return_v;
                }


                int
                f_10709_51365_51391(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.ToSortOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 51365, 51391);
                    return return_v;
                }


                int
                f_10709_51321_51392(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 51321, 51392);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_51046_51053_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 51046, 51053);
                    return return_v;
                }


                bool
                f_10709_51512_51523()
                {
                    var return_v = IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 51512, 51523);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_51597_51625(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 51597, 51625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_51575_51626(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                currentMembers)
                {
                    var return_v = this_param.AddOrWrapTupleMembers(currentMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 51575, 51626);
                    return return_v;
                }


                int
                f_10709_51649_51680(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 51649, 51680);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_51752_51773(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 51752, 51773);
                    return return_v;
                }


                bool
                f_10709_51799_51904(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 51799, 51904);
                    return return_v;
                }


                int
                f_10709_51946_51960(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 51946, 51960);
                    return 0;
                }


                int
                f_10709_52121_52147(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                limit)
                {
                    this_param.Clip(limit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 52121, 52147);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_52333_52367()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 52333, 52367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10709_52497_52508(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 52497, 52508);
                    return return_v;
                }


                int
                f_10709_52649_52668(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 52649, 52668);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_52413_52443_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 52413, 52443);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>
                f_10709_52788_52808(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = GroupByName(symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 52788, 52808);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>?
                f_10709_52850_52920(ref System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>?
                location1, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>
                value, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 52850, 52920);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>.KeyCollection
                f_10709_54484_54500(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 54484, 54500);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_10709_54442_54501(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>.KeyCollection
                collection)
                {
                    var return_v = SpecializedCollections.ReadOnlyCollection((System.Collections.Generic.ICollection<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 54442, 54501);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_10709_54524_54579(ref System.Collections.Generic.ICollection<string>
                location1, System.Collections.Generic.ICollection<string>
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 54524, 54579);
                    return return_v;
                }


                int
                f_10709_54683_54697(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 54683, 54697);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 44564, 54724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 44564, 54724);
            }
        }

        internal override ImmutableArray<Symbol> GetSimpleNonTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 54736, 55087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 54838, 54866);

                f_10709_54838_54865(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 54882, 54907);

                ImmutableArray<Symbol>
                m
                = default(ImmutableArray<Symbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 54921, 55051) || true) && (!f_10709_54926_54969(_lazyMembersByName, name, out m))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 54921, 55051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 55003, 55036);

                    m = ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 54921, 55051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 55067, 55076);

                return m;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 54736, 55087);

                int
                f_10709_54838_54865(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    this_param.EnsureAllMembersAreLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 54838, 54865);
                    return 0;
                }


                bool
                f_10709_54926_54969(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>
                this_param, string
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 54926, 54969);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 54736, 55087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 54736, 55087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 55099, 55715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 55186, 55214);

                f_10709_55186_55213(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 55230, 55255);

                ImmutableArray<Symbol>
                m
                = default(ImmutableArray<Symbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 55269, 55399) || true) && (!f_10709_55274_55317(_lazyMembersByName, name, out m))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 55269, 55399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 55351, 55384);

                    m = ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 55269, 55399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 55494, 55530);

                ImmutableArray<PENamedTypeSymbol>
                t
                = default(ImmutableArray<PENamedTypeSymbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 55544, 55679) || true) && (f_10709_55548_55589(_lazyNestedTypes, name, out t))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 55544, 55679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 55623, 55664);

                    m = m.Concat(f_10709_55636_55662(t));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 55544, 55679);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 55695, 55704);

                return m;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 55099, 55715);

                int
                f_10709_55186_55213(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    this_param.EnsureAllMembersAreLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 55186, 55213);
                    return 0;
                }


                bool
                f_10709_55274_55317(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>
                this_param, string
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 55274, 55317);
                    return return_v;
                }


                bool
                f_10709_55548_55589(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                this_param, string
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 55548, 55589);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10709_55636_55662(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 55636, 55662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 55099, 55715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 55099, 55715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 55804, 55865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 55807, 55865);
                return f_10709_55807_55865(f_10709_55807_55818(), WellKnownMemberNames.CloneMethodName); DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 55804, 55865);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 55804, 55865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 55804, 55865);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<string>
            f_10709_55807_55818()
            {
                var return_v = MemberNames;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 55807, 55818);
                return return_v;
            }


            bool
            f_10709_55807_55865(System.Collections.Generic.IEnumerable<string>
            sequence, string
            s)
            {
                var return_v = sequence.Contains(s);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 55807, 55865);
                return return_v;
            }

        }

        internal override FieldSymbol FixedElementField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 55950, 56334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 55986, 56012);

                    FieldSymbol
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 56032, 56117);

                    var
                    candidates = f_10709_56049_56116(this, FixedFieldImplementationType.FixedElementFieldName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 56135, 56285) || true) && (f_10709_56139_56160_M(!candidates.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 56139, 56186) && candidates.Length == 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 56135, 56285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 56228, 56266);

                        result = candidates[0] as FieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 56135, 56285);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 56305, 56319);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 55950, 56334);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10709_56049_56116(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 56049, 56116);
                        return return_v;
                    }


                    bool
                    f_10709_56139_56160_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 56139, 56160);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 55878, 56345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 55878, 56345);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<NamedTypeSymbol> GetTypeMembersUnordered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 56357, 56515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 56457, 56504);

                return f_10709_56464_56480(this).ConditionallyDeOrder();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 56357, 56515);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_56464_56480(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 56464, 56480);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 56357, 56515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 56357, 56515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 56527, 56701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 56616, 56645);

                f_10709_56616_56644(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 56659, 56690);

                return f_10709_56666_56689(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 56527, 56701);

                int
                f_10709_56616_56644(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    this_param.EnsureNestedTypesAreLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 56616, 56644);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_56666_56689(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMemberTypesPrivate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 56666, 56689);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 56527, 56701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 56527, 56701);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<NamedTypeSymbol> GetMemberTypesPrivate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 56713, 57062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 56801, 56859);

                var
                builder = f_10709_56815_56858()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 56873, 56999);
                    foreach (var typeArray in f_10709_56899_56922_I(f_10709_56899_56922(_lazyNestedTypes)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 56873, 56999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 56956, 56984);

                        f_10709_56956_56983(builder, typeArray);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 56873, 56999);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 127);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 57015, 57051);

                return f_10709_57022_57050(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 56713, 57062);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_56815_56858()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 56815, 56858);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>.ValueCollection
                f_10709_56899_56922(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 56899, 56922);
                    return return_v;
                }


                int
                f_10709_56956_56983(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                items)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 56956, 56983);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>.ValueCollection
                f_10709_56899_56922_I(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 56899, 56922);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_57022_57050(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 57022, 57050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 56713, 57062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 56713, 57062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EnsureNestedTypesAreLoaded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 57074, 57885);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 57140, 57874) || true) && (_lazyNestedTypes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 57140, 57874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 57202, 57260);

                    var
                    types = f_10709_57214_57259()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 57278, 57319);

                    f_10709_57278_57318(types, f_10709_57293_57317(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 57337, 57372);

                    var
                    typesDict = f_10709_57353_57371(types)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 57392, 57480);

                    var
                    exchangeResult = f_10709_57413_57479(ref _lazyNestedTypes, typesDict, null)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 57498, 57828) || true) && (exchangeResult == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 57498, 57828);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 57692, 57735);

                        var
                        moduleSymbol = f_10709_57711_57734(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 57757, 57809);

                        f_10709_57757_57808(moduleSymbol, typesDict);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 57498, 57828);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 57846, 57859);

                    f_10709_57846_57858(types);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 57140, 57874);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 57074, 57885);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                f_10709_57214_57259()
                {
                    var return_v = ArrayBuilder<PENamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 57214, 57259);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                f_10709_57293_57317(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.CreateNestedTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 57293, 57317);
                    return return_v;
                }


                int
                f_10709_57278_57318(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 57278, 57318);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                f_10709_57353_57371(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                symbols)
                {
                    var return_v = GroupByName(symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 57353, 57371);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>?
                f_10709_57413_57479(ref System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>?
                location1, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                value, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 57413, 57479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_57711_57734(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 57711, 57734);
                    return return_v;
                }


                int
                f_10709_57757_57808(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                typesDict)
                {
                    this_param.OnNewTypeDeclarationsLoaded(typesDict);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 57757, 57808);
                    return 0;
                }


                int
                f_10709_57846_57858(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 57846, 57858);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 57074, 57885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 57074, 57885);
            }
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 57897, 58303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 57997, 58026);

                f_10709_57997_58025(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 58042, 58078);

                ImmutableArray<PENamedTypeSymbol>
                t
                = default(ImmutableArray<PENamedTypeSymbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 58094, 58231) || true) && (f_10709_58098_58139(_lazyNestedTypes, name, out t))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 58094, 58231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 58173, 58216);

                    return f_10709_58180_58215(t);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 58094, 58231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 58247, 58292);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 57897, 58303);

                int
                f_10709_57997_58025(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    this_param.EnsureNestedTypesAreLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 57997, 58025);
                    return 0;
                }


                bool
                f_10709_58098_58139(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                this_param, string
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 58098, 58139);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_58180_58215(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                from)
                {
                    var return_v = StaticCast<NamedTypeSymbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 58180, 58215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 57897, 58303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 57897, 58303);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 58315, 58523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 58426, 58512);

                return f_10709_58433_58453(this, name).WhereAsArray((type, arity) => type.Arity == arity, arity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 58315, 58523);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_58433_58453(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 58433, 58453);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 58315, 58523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 58315, 58523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 58610, 58739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 58646, 58724);

                    return f_10709_58653_58671().MetadataLocation.Cast<MetadataLocation, Location>();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 58610, 58739);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_58653_58671()
                    {
                        var return_v = ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 58653, 58671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 58535, 58750);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 58535, 58750);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 58860, 58956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 58896, 58941);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 58860, 58956);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 58762, 58967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 58762, 58967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 59031, 59095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 59067, 59080);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 59031, 59095);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 58979, 59106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 58979, 59106);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 59180, 59281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 59216, 59266);

                    return (_flags & TypeAttributes.SpecialName) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 59180, 59281);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 59118, 59292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 59118, 59292);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 59431, 59531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 59467, 59516);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 59431, 59531);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 59304, 59542);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 59304, 59542);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 59645, 59745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 59681, 59730);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 59645, 59745);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 59554, 59756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 59554, 59756);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 59822, 60003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 59858, 59988);

                    return
                                        (_flags & TypeAttributes.Sealed) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10709, 59886, 59987) && (_flags & TypeAttributes.Abstract) != 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 59822, 60003);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 59768, 60014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 59768, 60014);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 60082, 60263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 60118, 60248);

                    return
                                        (_flags & TypeAttributes.Abstract) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10709, 60146, 60247) && (_flags & TypeAttributes.Sealed) == 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 60082, 60263);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 60026, 60274);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 60026, 60274);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 60352, 60450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 60388, 60435);

                    return (_flags & TypeAttributes.Abstract) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 60352, 60450);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 60286, 60461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 60286, 60461);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 60527, 60708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 60563, 60693);

                    return
                                        (_flags & TypeAttributes.Sealed) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10709, 60591, 60692) && (_flags & TypeAttributes.Abstract) == 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 60527, 60708);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 60473, 60719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 60473, 60719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 60795, 60891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 60831, 60876);

                    return (_flags & TypeAttributes.Sealed) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 60795, 60891);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 60731, 60902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 60731, 60902);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TypeAttributes Flags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 60968, 61033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 61004, 61018);

                    return _flags;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 60968, 61033);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 60914, 61044);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 60914, 61044);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 61124, 61169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 61130, 61167);

                    throw f_10709_61136_61166();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 61124, 61169);

                    System.Exception
                    f_10709_61136_61166()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 61136, 61166);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 61056, 61180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 61056, 61180);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool MightContainExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 61266, 63042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 61302, 61341);

                    var
                    uncommon = f_10709_61317_61340(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 61359, 61471) || true) && (uncommon == s_noUncommonProperties)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 61359, 61471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 61439, 61452);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 61359, 61471);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 61491, 62954) || true) && (!f_10709_61496_61544(uncommon.lazyContainsExtensionMethods))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 61491, 62954);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 61586, 61618);

                        var
                        contains = ThreeState.False
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 61791, 62862);

                        switch (f_10709_61799_61812(this))
                        {

                            case TypeKind.Class:
                            case TypeKind.Struct:
                            case TypeKind.Delegate:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 61791, 62862);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 62008, 62051);

                                var
                                moduleSymbol = f_10709_62027_62050(this)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 62081, 62114);

                                var
                                module = f_10709_62094_62113(moduleSymbol)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 62144, 62227);

                                bool
                                moduleHasExtension = f_10709_62170_62226(module, _handle, ignoreCase: false)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 62259, 62328);

                                var
                                containingAssembly = f_10709_62284_62307(this) as PEAssemblySymbol
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 62358, 62803) || true) && ((object)containingAssembly != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 62358, 62803);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 62462, 62597);

                                    contains = f_10709_62473_62596((moduleHasExtension
                                    && (DynAbs.Tracing.TraceSender.Expression_True(10709, 62474, 62580) && f_10709_62533_62580(containingAssembly))));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 62358, 62803);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 62358, 62803);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 62727, 62772);

                                    contains = f_10709_62738_62771(moduleHasExtension);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 62358, 62803);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10709, 62833, 62839);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 61791, 62862);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 62886, 62935);

                        uncommon.lazyContainsExtensionMethods = contains;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 61491, 62954);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 62974, 63027);

                    return f_10709_62981_63026(uncommon.lazyContainsExtensionMethods);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 61266, 63042);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                    f_10709_61317_61340(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUncommonProperties();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 61317, 61340);
                        return return_v;
                    }


                    bool
                    f_10709_61496_61544(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.HasValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 61496, 61544);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10709_61799_61812(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 61799, 61812);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_62027_62050(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 62027, 62050);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10709_62094_62113(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 62094, 62113);
                        return return_v;
                    }


                    bool
                    f_10709_62170_62226(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.TypeDefinitionHandle
                    token, bool
                    ignoreCase)
                    {
                        var return_v = this_param.HasExtensionAttribute((System.Reflection.Metadata.EntityHandle)token, ignoreCase: ignoreCase);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 62170, 62226);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10709_62284_62307(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 62284, 62307);
                        return return_v;
                    }


                    bool
                    f_10709_62533_62580(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.MightContainExtensionMethods;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 62533, 62580);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_10709_62473_62596(bool
                    value)
                    {
                        var return_v = value.ToThreeState();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 62473, 62596);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_10709_62738_62771(bool
                    value)
                    {
                        var return_v = value.ToThreeState();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 62738, 62771);
                        return return_v;
                    }


                    bool
                    f_10709_62981_63026(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.Value();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 62981, 63026);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 61192, 63053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 61192, 63053);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 63123, 64980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 63159, 63187);

                    TypeKind
                    result = _lazyKind
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 63207, 64931) || true) && (result == TypeKind.Unknown)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 63207, 64931);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 63279, 64869) || true) && (f_10709_63283_63303(_flags))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 63279, 64869);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 63353, 63381);

                            result = TypeKind.Interface;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 63279, 64869);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 63279, 64869);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 63479, 63551);

                            TypeSymbol
                            @base = f_10709_63498_63550(this, skipTransformsIfNecessary: true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 63579, 63603);

                            result = TypeKind.Class;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 63631, 64846) || true) && ((object)@base != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 63631, 64846);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 63714, 63760);

                                SpecialType
                                baseCorTypeId = f_10709_63742_63759(@base)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 63792, 64819);

                                switch (baseCorTypeId)
                                {

                                    case SpecialType.System_Enum:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 63792, 64819);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 63991, 64014);

                                        result = TypeKind.Enum;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10709, 64052, 64058);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 63792, 64819);

                                    case SpecialType.System_MulticastDelegate:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 63792, 64819);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 64223, 64250);

                                        result = TypeKind.Delegate;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10709, 64288, 64294);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 63792, 64819);

                                    case SpecialType.System_ValueType:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 63792, 64819);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 64500, 64744) || true) && (f_10709_64504_64520(this) != SpecialType.System_Enum)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 64500, 64744);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 64680, 64705);

                                            result = TypeKind.Struct;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 64500, 64744);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10709, 64782, 64788);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 63792, 64819);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 63631, 64846);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 63279, 64869);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 64893, 64912);

                        _lazyKind = result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 63207, 64931);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 64951, 64965);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 63123, 64980);

                    bool
                    f_10709_63283_63303(System.Reflection.TypeAttributes
                    flags)
                    {
                        var return_v = flags.IsInterface();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 63283, 63303);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10709_63498_63550(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param, bool
                    skipTransformsIfNecessary)
                    {
                        var return_v = this_param.GetDeclaredBaseType(skipTransformsIfNecessary: skipTransformsIfNecessary);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 63498, 63550);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10709_63742_63759(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 63742, 63759);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10709_64504_64520(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 64504, 64520);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 63065, 64991);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 63065, 64991);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsInterface
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 65069, 65148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 65105, 65133);

                    return f_10709_65112_65132(_flags);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 65069, 65148);

                    bool
                    f_10709_65112_65132(System.Reflection.TypeAttributes
                    flags)
                    {
                        var return_v = flags.IsInterface();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 65112, 65132);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 65003, 65159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 65003, 65159);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static ExtendedErrorTypeSymbol CyclicInheritanceError(PENamedTypeSymbol type, TypeSymbol declaredBase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10709, 65171, 65514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 65306, 65394);

                var
                info = f_10709_65317_65393(ErrorCode.ERR_ImportedCircularBase, declaredBase, type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 65408, 65503);

                return f_10709_65415_65502(declaredBase, LookupResultKind.NotReferencable, info, true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10709, 65171, 65514);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10709_65317_65393(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 65317, 65393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10709_65415_65502(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo, bool
                unreported)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)guessSymbol, resultKind, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo, unreported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 65415, 65502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 65171, 65514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 65171, 65514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol MakeAcyclicBaseType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 65526, 66112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 65596, 65653);

                NamedTypeSymbol
                declaredBase = f_10709_65627_65652(this, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 65747, 65840) || true) && ((object)declaredBase == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 65747, 65840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 65813, 65825);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 65747, 65840);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 65856, 66009) || true) && (f_10709_65860_65910(declaredBase, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 65856, 66009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 65944, 65994);

                    return f_10709_65951_65993(this, declaredBase);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 65856, 66009);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 66025, 66067);

                f_10709_66025_66066(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 66081, 66101);

                return declaredBase;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 65526, 66112);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10709_65627_65652(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredBaseType(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 65627, 65652);
                    return return_v;
                }


                bool
                f_10709_65860_65910(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                depends, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                on)
                {
                    var return_v = BaseTypeAnalysis.TypeDependsOn(depends, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)on);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 65860, 65910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10709_65951_65993(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                declaredBase)
                {
                    var return_v = CyclicInheritanceError(type, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)declaredBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 65951, 65993);
                    return return_v;
                }


                int
                f_10709_66025_66066(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    this_param.SetKnownToHaveNoDeclaredBaseCycles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 66025, 66066);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 65526, 66112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 65526, 66112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<NamedTypeSymbol> MakeAcyclicInterfaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 66124, 66629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 66212, 66265);

                var
                declaredInterfaces = f_10709_66237_66264(this, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 66279, 66460) || true) && (f_10709_66283_66295_M(!IsInterface))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 66279, 66460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 66419, 66445);

                    return declaredInterfaces;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 66279, 66460);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 66476, 66618);

                return declaredInterfaces
                                .SelectAsArray(t => BaseTypeAnalysis.TypeDependsOn(t, this) ? CyclicInheritanceError(this, t) : t);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 66124, 66629);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10709_66237_66264(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredInterfaces(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 66237, 66264);
                    return return_v;
                }


                bool
                f_10709_66283_66295_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 66283, 66295);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 66124, 66629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 66124, 66629);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 66641, 67001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 66847, 66990);

                return f_10709_66854_66989(this, f_10709_66912_66930(), preferredCulture, cancellationToken, ref _lazyDocComment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 66641, 67001);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_66912_66930()
                {
                    var return_v = ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 66912, 66930);
                    return return_v;
                }


                string
                f_10709_66854_66989(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                containingPEModule, System.Globalization.CultureInfo?
                preferredCulture, System.Threading.CancellationToken
                cancellationToken, ref System.Tuple<System.Globalization.CultureInfo, string>
                lazyDocComment)
                {
                    var return_v = PEDocumentationCommentUtils.GetDocumentationComment((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingPEModule, preferredCulture, cancellationToken, ref lazyDocComment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 66854, 66989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 66641, 67001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 66641, 67001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<PENamedTypeSymbol> CreateNestedTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 67013, 67768);

                var listYield = new List<PENamedTypeSymbol>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 67096, 67139);

                var
                moduleSymbol = f_10709_67115_67138(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 67153, 67186);

                var
                module = f_10709_67166_67185(moduleSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 67202, 67254);

                ImmutableArray<TypeDefinitionHandle>
                nestedTypeDefs
                = default(ImmutableArray<TypeDefinitionHandle>);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 67306, 67364);

                    nestedTypeDefs = f_10709_67323_67363(module, _handle);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 67393, 67484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 67457, 67469);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 67393, 67484);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 67500, 67757);
                    foreach (var typeRid in f_10709_67524_67538_I(nestedTypeDefs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 67500, 67757);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 67572, 67742) || true) && (module.ShouldImportNestedType(typeRid))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 67572, 67742);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 67656, 67723);

                            listYield.Add(f_10709_67669_67722(moduleSymbol, this, typeRid));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 67572, 67742);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 67500, 67757);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 258);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 67013, 67768);

                return listYield;

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_67115_67138(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 67115, 67138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_67166_67185(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 67166, 67185);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.Metadata.TypeDefinitionHandle>
                f_10709_67323_67363(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                container)
                {
                    var return_v = this_param.GetNestedTypeDefsOrThrow(container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 67323, 67363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                f_10709_67669_67722(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                containingType, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = PENamedTypeSymbol.Create(moduleSymbol, containingType, handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 67669, 67722);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.Metadata.TypeDefinitionHandle>
                f_10709_67524_67538_I(System.Collections.Immutable.ImmutableArray<System.Reflection.Metadata.TypeDefinitionHandle>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 67524, 67538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 67013, 67768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 67013, 67768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MultiDictionary<string, PEFieldSymbol> CreateFields(ArrayBuilder<PEFieldSymbol> fieldMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 67780, 70369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 67906, 67983);

                var
                privateFieldNameToSymbols = f_10709_67938_67982()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 67999, 68042);

                var
                moduleSymbol = f_10709_68018_68041(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 68056, 68089);

                var
                module = f_10709_68069_68088(moduleSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 68236, 68265);

                var
                isOrdinaryStruct = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 68425, 68464);

                var
                isOrdinaryEmbeddableStruct = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 68480, 68973) || true) && (f_10709_68484_68497(this) == TypeKind.Struct)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 68480, 68973);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 68550, 68958) || true) && (f_10709_68554_68570(this) == Microsoft.CodeAnalysis.SpecialType.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 68550, 68958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 68655, 68679);

                        isOrdinaryStruct = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 68701, 68763);

                        isOrdinaryEmbeddableStruct = f_10709_68730_68762(f_10709_68730_68753(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 68550, 68958);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 68550, 68958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 68845, 68939);

                        isOrdinaryStruct = (f_10709_68865_68881(this) == Microsoft.CodeAnalysis.SpecialType.System_Nullable_T);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 68550, 68958);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 68480, 68973);
                }

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 69025, 70232);
                        foreach (var fieldRid in f_10709_69050_69088_I(f_10709_69050_69088(module, _handle)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 69025, 70232);
                            try
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 69182, 69531) || true) && 
                                    (!(isOrdinaryEmbeddableStruct || (DynAbs.Tracing.TraceSender.Expression_False(10709, 69188, 69341) || 
                                    (isOrdinaryStruct && (DynAbs.Tracing.TraceSender.Expression_True(10709, 69248, 69340) && 
                                    (f_10709_69269_69309(module, fieldRid) & FieldAttributes.Static) == 0))) || 
                                    (DynAbs.Tracing.TraceSender.Expression_False(10709, 69188, 69436) ||
                                    f_10709_69346_69436(module, fieldRid, moduleSymbol.ImportOptions))))
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 69182, 69531);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 69495, 69504);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 69182, 69531);
                                }

                                // LAFHIS (this should be a ref param)
                                bool f_10709_69346_69436(PEModule module, FieldDefinitionHandle fieldRid, MetadataImportOptions options)
                                {
                                    var retVal = module.ShouldImportField(fieldRid, options);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 69346, 69436);
                                    return retVal;
                                }
                            }
                            catch (BadImageFormatException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 69576, 69632);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 69576, 69632);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 69656, 69717);

                            var
                            symbol = f_10709_69669_69716(moduleSymbol, this, fieldRid)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 69739, 69764);

                            f_10709_69739_69763(fieldMembers, symbol);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 69886, 70213) || true) && (f_10709_69890_69918(symbol) == Accessibility.Private)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 69886, 70213);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 69993, 70016);

                                var
                                name = f_10709_70004_70015(symbol)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 70042, 70190) || true) && (f_10709_70046_70057(name) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 70042, 70190);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 70119, 70163);

                                    f_10709_70119_70162(privateFieldNameToSymbols, name, symbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 70042, 70190);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 69886, 70213);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 69025, 70232);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 1208);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 1208);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 70261, 70309);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 70261, 70309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 70325, 70358);

                return privateFieldNameToSymbols;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 67780, 70369);

                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                f_10709_67938_67982()
                {
                    var return_v = new Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 67938, 67982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_68018_68041(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 68018, 68041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_68069_68088(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 68069, 68088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10709_68484_68497(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 68484, 68497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10709_68554_68570(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 68554, 68570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10709_68730_68753(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 68730, 68753);
                    return return_v;
                }


                bool
                f_10709_68730_68762(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 68730, 68762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10709_68865_68881(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 68865, 68881);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandleCollection
                f_10709_69050_69088(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetFieldsOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 69050, 69088);
                    return return_v;
                }


                System.Reflection.FieldAttributes
                f_10709_69269_69309(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                fieldDef)
                {
                    var return_v = this_param.GetFieldDefFlagsOrThrow(fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 69269, 69309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                f_10709_69669_69716(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                containingType, System.Reflection.Metadata.FieldDefinitionHandle
                fieldDef)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol(moduleSymbol, containingType, fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 69669, 69716);
                    return return_v;
                }


                int
                f_10709_69739_69763(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 69739, 69763);
                    return 0;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10709_69890_69918(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 69890, 69918);
                    return return_v;
                }


                string
                f_10709_70004_70015(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 70004, 70015);
                    return return_v;
                }


                int
                f_10709_70046_70057(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 70046, 70057);
                    return return_v;
                }


                bool
                f_10709_70119_70162(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                this_param, string
                k, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                v)
                {
                    var return_v = this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 70119, 70162);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandleCollection
                f_10709_69050_69088_I(System.Reflection.Metadata.FieldDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 69050, 69088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 67780, 70369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 67780, 70369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PooledDictionary<MethodDefinitionHandle, PEMethodSymbol> CreateMethods(ArrayBuilder<Symbol> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 70381, 71668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 70514, 70557);

                var
                moduleSymbol = f_10709_70533_70556(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 70571, 70604);

                var
                module = f_10709_70584_70603(moduleSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 70618, 70699);

                var
                map = f_10709_70628_70698()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 70861, 71030);

                var
                isOrdinaryEmbeddableStruct = (f_10709_70895_70908(this) == TypeKind.Struct) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 70894, 70993) && (f_10709_70933_70949(this) == Microsoft.CodeAnalysis.SpecialType.None)) && (DynAbs.Tracing.TraceSender.Expression_True(10709, 70894, 71029) && f_10709_70997_71029(f_10709_70997_71020(this)))
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 71082, 71553);
                        foreach (var methodHandle in f_10709_71111_71150_I(f_10709_71111_71150(module, _handle)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 71082, 71553);

                            // LAFHIS
                            bool f_10709_71226_71293()
                            {
                                var temp = module.ShouldImportMethod(methodHandle, moduleSymbol.ImportOptions);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 71226, 71293);
                                return temp;
                            }

                            // LAFHIS
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 71192, 71534) || true) && 
                                (isOrdinaryEmbeddableStruct || (DynAbs.Tracing.TraceSender.Expression_False(10709, 71196, 71293) ||
                                f_10709_71226_71293()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 71192, 71534);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 71343, 71409);

                                var
                                method = f_10709_71356_71408(moduleSymbol, this, methodHandle)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 71435, 71455);

                                f_10709_71435_71454(members, method);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 71481, 71511);

                                f_10709_71481_71510(map, methodHandle, method);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 71192, 71534);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 71082, 71553);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 472);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 472);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 71582, 71630);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 71582, 71630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 71646, 71657);

                return map;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 70381, 71668);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_70533_70556(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 70533, 70556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_70584_70603(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 70584, 70603);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
                f_10709_70628_70698()
                {
                    var return_v = PooledDictionary<MethodDefinitionHandle, PEMethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 70628, 70698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10709_70895_70908(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 70895, 70908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10709_70933_70949(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 70933, 70949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10709_70997_71020(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 70997, 71020);
                    return return_v;
                }


                bool
                f_10709_70997_71029(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 70997, 71029);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandleCollection
                f_10709_71111_71150(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetMethodsOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 71111, 71150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                f_10709_71356_71408(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                containingType, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol(moduleSymbol, containingType, methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 71356, 71408);
                    return return_v;
                }


                int
                f_10709_71435_71454(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 71435, 71454);
                    return 0;
                }


                int
                f_10709_71481_71510(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                key, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 71481, 71510);
                    return 0;
                }


                System.Reflection.Metadata.MethodDefinitionHandleCollection
                f_10709_71111_71150_I(System.Reflection.Metadata.MethodDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 71111, 71150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 70381, 71668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 70381, 71668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CreateProperties(Dictionary<MethodDefinitionHandle, PEMethodSymbol> methodHandleToSymbol, ArrayBuilder<Symbol> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 71680, 72914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 71837, 71880);

                var
                moduleSymbol = f_10709_71856_71879(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 71894, 71927);

                var
                module = f_10709_71907_71926(moduleSymbol)
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 71979, 72826);
                        foreach (var propertyDef in f_10709_72007_72049_I(f_10709_72007_72049(module, _handle)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 71979, 72826);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 72143, 72203);

                                var
                                methods = f_10709_72157_72202(module, propertyDef)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 72231, 72322);

                                PEMethodSymbol
                                getMethod = f_10709_72258_72321(this, module, methodHandleToSymbol, methods.Getter)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 72348, 72439);

                                PEMethodSymbol
                                setMethod = f_10709_72375_72438(this, module, methodHandleToSymbol, methods.Setter)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 72467, 72706) || true) && (((object)getMethod != null) || (DynAbs.Tracing.TraceSender.Expression_False(10709, 72471, 72529) || ((object)setMethod != null)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 72467, 72706);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 72587, 72679);

                                    f_10709_72587_72678(members, f_10709_72599_72677(moduleSymbol, this, propertyDef, getMethod, setMethod));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 72467, 72706);
                                }
                            }
                            catch (BadImageFormatException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 72751, 72807);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 72751, 72807);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 71979, 72826);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 848);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 848);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 72855, 72903);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 72855, 72903);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 71680, 72914);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_71856_71879(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 71856, 71879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_71907_71926(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 71907, 71926);
                    return return_v;
                }


                System.Reflection.Metadata.PropertyDefinitionHandleCollection
                f_10709_72007_72049(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetPropertiesOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 72007, 72049);
                    return return_v;
                }


                System.Reflection.Metadata.PropertyAccessors
                f_10709_72157_72202(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.PropertyDefinitionHandle
                propertyDef)
                {
                    var return_v = this_param.GetPropertyMethodsOrThrow(propertyDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 72157, 72202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                f_10709_72258_72321(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PEModule
                module, System.Collections.Generic.Dictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
                methodHandleToSymbol, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.GetAccessorMethod(module, methodHandleToSymbol, methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 72258, 72321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                f_10709_72375_72438(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PEModule
                module, System.Collections.Generic.Dictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
                methodHandleToSymbol, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.GetAccessorMethod(module, methodHandleToSymbol, methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 72375, 72438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                f_10709_72599_72677(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                containingType, System.Reflection.Metadata.PropertyDefinitionHandle
                handle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol?
                getMethod, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                setMethod)
                {
                    var return_v = PEPropertySymbol.Create(moduleSymbol, containingType, handle, getMethod, setMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 72599, 72677);
                    return return_v;
                }


                int
                f_10709_72587_72678(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 72587, 72678);
                    return 0;
                }


                System.Reflection.Metadata.PropertyDefinitionHandleCollection
                f_10709_72007_72049_I(System.Reflection.Metadata.PropertyDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 72007, 72049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 71680, 72914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 71680, 72914);
            }
        }

        private void CreateEvents(
                    MultiDictionary<string, PEFieldSymbol> privateFieldNameToSymbols,
                    Dictionary<MethodDefinitionHandle, PEMethodSymbol> methodHandleToSymbol,
                    ArrayBuilder<Symbol> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 72926, 74551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 73185, 73228);

                var
                moduleSymbol = f_10709_73204_73227(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 73242, 73275);

                var
                module = f_10709_73255_73274(moduleSymbol)
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 73327, 74463);
                        foreach (var eventRid in f_10709_73352_73390_I(f_10709_73352_73390(module, _handle)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 73327, 74463);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 73484, 73538);

                                var
                                methods = f_10709_73498_73537(module, eventRid)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 73659, 73749);

                                PEMethodSymbol
                                addMethod = f_10709_73686_73748(this, module, methodHandleToSymbol, methods.Adder)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 73775, 73870);

                                PEMethodSymbol
                                removeMethod = f_10709_73805_73869(this, module, methodHandleToSymbol, methods.Remover)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 74080, 74343) || true) && (((object)addMethod != null) || (DynAbs.Tracing.TraceSender.Expression_False(10709, 74084, 74145) || ((object)removeMethod != null)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 74080, 74343);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 74203, 74316);

                                    f_10709_74203_74315(members, f_10709_74215_74314(moduleSymbol, this, eventRid, addMethod, removeMethod, privateFieldNameToSymbols));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 74080, 74343);
                                }
                            }
                            catch (BadImageFormatException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 74388, 74444);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 74388, 74444);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 73327, 74463);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 1137);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 1137);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10709, 74492, 74540);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10709, 74492, 74540);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 72926, 74551);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_73204_73227(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 73204, 73227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_73255_73274(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 73255, 73274);
                    return return_v;
                }


                System.Reflection.Metadata.EventDefinitionHandleCollection
                f_10709_73352_73390(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetEventsOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 73352, 73390);
                    return return_v;
                }


                System.Reflection.Metadata.EventAccessors
                f_10709_73498_73537(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EventDefinitionHandle
                eventDef)
                {
                    var return_v = this_param.GetEventMethodsOrThrow(eventDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 73498, 73537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                f_10709_73686_73748(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PEModule
                module, System.Collections.Generic.Dictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
                methodHandleToSymbol, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.GetAccessorMethod(module, methodHandleToSymbol, methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 73686, 73748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                f_10709_73805_73869(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PEModule
                module, System.Collections.Generic.Dictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
                methodHandleToSymbol, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.GetAccessorMethod(module, methodHandleToSymbol, methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 73805, 73869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
                f_10709_74215_74314(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                containingType, System.Reflection.Metadata.EventDefinitionHandle
                handle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol?
                addMethod, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                removeMethod, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                privateFieldNameToSymbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol(moduleSymbol, containingType, handle, addMethod, removeMethod, privateFieldNameToSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 74215, 74314);
                    return return_v;
                }


                int
                f_10709_74203_74315(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 74203, 74315);
                    return 0;
                }


                System.Reflection.Metadata.EventDefinitionHandleCollection
                f_10709_73352_73390_I(System.Reflection.Metadata.EventDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 73352, 73390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 72926, 74551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 72926, 74551);
            }
        }

        private PEMethodSymbol GetAccessorMethod(PEModule module, Dictionary<MethodDefinitionHandle, PEMethodSymbol> methodHandleToSymbol, MethodDefinitionHandle methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 74563, 75106);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 74752, 74832) || true) && (methodDef.IsNil)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 74752, 74832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 74805, 74817);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 74752, 74832);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 74848, 74870);

                PEMethodSymbol
                method
                = default(PEMethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 74884, 74953);

                bool
                found = f_10709_74897_74952(methodHandleToSymbol, methodDef, out method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 74967, 75067);

                f_10709_74967_75066(found || (DynAbs.Tracing.TraceSender.Expression_False(10709, 74980, 75065) || !module.ShouldImportMethod(methodDef, f_10709_75027_75050(this).ImportOptions)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 75081, 75095);

                return method;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 74563, 75106);

                bool
                f_10709_74897_74952(System.Collections.Generic.Dictionary<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol>
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 74897, 74952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_75027_75050(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 75027, 75050);
                    return return_v;
                }


                int
                f_10709_74967_75066(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 74967, 75066);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 74563, 75106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 74563, 75106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Dictionary<string, ImmutableArray<Symbol>> GroupByName(ArrayBuilder<Symbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10709, 75118, 75326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 75242, 75315);

                return f_10709_75249_75314(symbols, s => s.Name, StringOrdinalComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10709, 75118, 75326);

                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>
                f_10709_75249_75314(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, string>
                keySelector, Roslyn.Utilities.StringOrdinalComparer
                comparer)
                {
                    var return_v = this_param.ToDictionary<string>(keySelector, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 75249, 75314);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 75118, 75326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 75118, 75326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Dictionary<string, ImmutableArray<PENamedTypeSymbol>> GroupByName(ArrayBuilder<PENamedTypeSymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10709, 75338, 75681);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 75484, 75581) || true) && (f_10709_75488_75501(symbols) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 75484, 75581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 75540, 75566);

                    return s_emptyNestedTypes;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 75484, 75581);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 75597, 75670);

                return f_10709_75604_75669(symbols, s => s.Name, StringOrdinalComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10709, 75338, 75681);

                int
                f_10709_75488_75501(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 75488, 75501);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                f_10709_75604_75669(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol, string>
                keySelector, Roslyn.Utilities.StringOrdinalComparer
                comparer)
                {
                    var return_v = this_param.ToDictionary<string>(keySelector, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 75604, 75669);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 75338, 75681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 75338, 75681);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 75695, 76009);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 75775, 75952) || true) && (f_10709_75779_75851(_lazyUseSiteDiagnostic, CSDiagnosticInfo.EmptyErrorInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 75775, 75952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 75885, 75937);

                    _lazyUseSiteDiagnostic = f_10709_75910_75936(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 75775, 75952);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 75968, 75998);

                return _lazyUseSiteDiagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 75695, 76009);

                bool
                f_10709_75779_75851(Microsoft.CodeAnalysis.DiagnosticInfo
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 75779, 75851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10709_75910_75936(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnosticImpl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 75910, 75936);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 75695, 76009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 75695, 76009);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual DiagnosticInfo GetUseSiteDiagnosticImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 76021, 78028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 76105, 76138);

                DiagnosticInfo
                diagnostic = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 76154, 77983) || true) && (!f_10709_76159_76228(this, ref diagnostic, f_10709_76199_76227(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 76154, 77983);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 76468, 77968) || true) && (f_10709_76472_76541(f_10709_76472_76502(f_10709_76472_76495(this)), _handle))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 76468, 77968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 76583, 76648);

                        diagnostic = f_10709_76596_76647(ErrorCode.ERR_BogusType, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 76468, 77968);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 76468, 77968);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 76690, 77968) || true) && (f_10709_76694_76702() == TypeKind.Class && (DynAbs.Tracing.TraceSender.Expression_True(10709, 76694, 76762) && f_10709_76724_76735() != SpecialType.System_Enum))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 76690, 77968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 76804, 76849);

                            TypeSymbol
                            @base = f_10709_76823_76848(this, null)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 76871, 77949) || true) && (f_10709_76875_76893_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(@base, 10709, 76875, 76893)?.SpecialType) == SpecialType.None && (DynAbs.Tracing.TraceSender.Expression_True(10709, 76875, 76960) && f_10709_76917_76952_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10709_76917_76941(@base), 10709, 76917, 76952)?.IsMissing) == true))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 76871, 77949);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 77010, 77072);

                                var
                                missingType = @base as MissingMetadataTypeSymbol.TopLevel
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 77098, 77926) || true) && ((object)missingType != null && (DynAbs.Tracing.TraceSender.Expression_True(10709, 77102, 77155) && f_10709_77133_77150(missingType) == 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 77098, 77926);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 77213, 77322);

                                    string
                                    emittedName = f_10709_77234_77321(f_10709_77269_77294(missingType), f_10709_77296_77320(missingType))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 77352, 77899);

                                    switch (f_10709_77360_77409(emittedName))
                                    {

                                        case SpecialType.System_Enum:
                                        case SpecialType.System_MulticastDelegate:
                                        case SpecialType.System_ValueType:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 77352, 77899);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 77776, 77824);

                                            diagnostic = f_10709_77789_77823(missingType);
                                            DynAbs.Tracing.TraceSender.TraceBreak(10709, 77862, 77868);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 77352, 77899);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 77098, 77926);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 76871, 77949);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 76690, 77968);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 76468, 77968);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 76154, 77983);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 77999, 78017);

                return diagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 76021, 78028);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10709_76199_76227(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.CalculateUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 76199, 76227);
                    return return_v;
                }


                bool
                f_10709_76159_76228(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result, Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = this_param.MergeUseSiteDiagnostics(ref result, info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 76159, 76228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_76472_76495(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 76472, 76495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_76472_76502(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 76472, 76502);
                    return return_v;
                }


                bool
                f_10709_76472_76541(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                token)
                {
                    var return_v = this_param.HasRequiredAttributeAttribute((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 76472, 76541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10709_76596_76647(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 76596, 76647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10709_76694_76702()
                {
                    var return_v = TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 76694, 76702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10709_76724_76735()
                {
                    var return_v = SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 76724, 76735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10709_76823_76848(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredBaseType(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 76823, 76848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType?
                f_10709_76875_76893_M(Microsoft.CodeAnalysis.SpecialType?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 76875, 76893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10709_76917_76941(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 76917, 76941);
                    return return_v;
                }


                bool?
                f_10709_76917_76952_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 76917, 76952);
                    return return_v;
                }


                int
                f_10709_77133_77150(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 77133, 77150);
                    return return_v;
                }


                string
                f_10709_77269_77294(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                this_param)
                {
                    var return_v = this_param.NamespaceName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 77269, 77294);
                    return return_v;
                }


                string
                f_10709_77296_77320(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 77296, 77320);
                    return return_v;
                }


                string
                f_10709_77234_77321(string
                qualifier, string
                name)
                {
                    var return_v = MetadataHelpers.BuildQualifiedName(qualifier, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 77234, 77321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10709_77360_77409(string
                metadataName)
                {
                    var return_v = SpecialTypes.GetTypeFromMetadataName(metadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 77360, 77409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10709_77789_77823(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 77789, 77823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 76021, 78028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 76021, 78028);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string DefaultMemberName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 78098, 79142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 78134, 78173);

                    var
                    uncommon = f_10709_78149_78172(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 78191, 78300) || true) && (uncommon == s_noUncommonProperties)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 78191, 78300);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 78271, 78281);

                        return "";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 78191, 78300);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 78320, 79071) || true) && (uncommon.lazyDefaultMemberName == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 78320, 79071);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 78404, 78429);

                        string
                        defaultMemberName
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 78451, 78540);

                        f_10709_78451_78539(f_10709_78451_78481(f_10709_78451_78474(this)), _handle, out defaultMemberName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 78957, 79052);

                        f_10709_78957_79051(ref uncommon.lazyDefaultMemberName, defaultMemberName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10709, 79021, 79044) ?? ""), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 78320, 79071);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 79089, 79127);

                    return uncommon.lazyDefaultMemberName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 78098, 79142);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                    f_10709_78149_78172(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUncommonProperties();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 78149, 78172);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_78451_78474(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 78451, 78474);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10709_78451_78481(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 78451, 78481);
                        return return_v;
                    }


                    bool
                    f_10709_78451_78539(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.TypeDefinitionHandle
                    token, out string
                    memberName)
                    {
                        var return_v = this_param.HasDefaultMemberAttribute((System.Reflection.Metadata.EntityHandle)token, out memberName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 78451, 78539);
                        return return_v;
                    }


                    string?
                    f_10709_78957_79051(ref string?
                    location1, string
                    value, string?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 78957, 79051);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 78040, 79153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 78040, 79153);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsComImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 79224, 79320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 79260, 79305);

                    return (_flags & TypeAttributes.Import) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 79224, 79320);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 79165, 79331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 79165, 79331);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool ShouldAddWinRTMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 79412, 79450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 79418, 79448);

                    return f_10709_79425_79447();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 79412, 79450);

                    bool
                    f_10709_79425_79447()
                    {
                        var return_v = IsWindowsRuntimeImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 79425, 79447);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 79343, 79461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 79343, 79461);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsWindowsRuntimeImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 79543, 79647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 79579, 79632);

                    return (_flags & TypeAttributes.WindowsRuntime) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 79543, 79647);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 79473, 79658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 79473, 79658);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GetGuidString(out string guidString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 79670, 79840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 79754, 79829);

                return f_10709_79761_79828(f_10709_79761_79786(f_10709_79761_79779()), _handle, out guidString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 79670, 79840);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_79761_79779()
                {
                    var return_v = ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 79761, 79779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_79761_79786(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 79761, 79786);
                    return return_v;
                }


                bool
                f_10709_79761_79828(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                token, out string
                guidValue)
                {
                    var return_v = this_param.HasGuidAttribute((System.Reflection.Metadata.EntityHandle)token, out guidValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 79761, 79828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 79670, 79840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 79670, 79840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeLayout Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 79912, 80024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 79948, 80009);

                    return f_10709_79955_80008(f_10709_79955_79985(f_10709_79955_79978(this)), _handle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 79912, 80024);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_79955_79978(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 79955, 79978);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10709_79955_79985(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 79955, 79985);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeLayout
                    f_10709_79955_80008(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.TypeDefinitionHandle
                    typeDef)
                    {
                        var return_v = this_param.GetTypeLayout(typeDef);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 79955, 80008);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 79852, 80035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 79852, 80035);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 80116, 80403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 80152, 80188);

                    CharSet
                    result = f_10709_80169_80187(_flags)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 80208, 80354) || true) && (result == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 80208, 80354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 80315, 80335);

                        return CharSet.Ansi;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 80208, 80354);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 80374, 80388);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 80116, 80403);

                    System.Runtime.InteropServices.CharSet
                    f_10709_80169_80187(System.Reflection.TypeAttributes
                    flags)
                    {
                        var return_v = flags.ToCharSet();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 80169, 80187);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 80047, 80414);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 80047, 80414);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 80486, 80545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 80492, 80543);

                    return (_flags & TypeAttributes.Serializable) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 80486, 80545);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 80426, 80556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 80426, 80556);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsRefLikeType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 80627, 81456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 80663, 80702);

                    var
                    uncommon = f_10709_80678_80701(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 80720, 80832) || true) && (uncommon == s_noUncommonProperties)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 80720, 80832);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 80800, 80813);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 80720, 80832);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 80852, 81381) || true) && (!f_10709_80857_80892(uncommon.lazyIsByRefLike))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 80852, 81381);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 80934, 80969);

                        var
                        isByRefLike = ThreeState.False
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 80993, 81299) || true) && (f_10709_80997_81010(this) == TypeKind.Struct)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 80993, 81299);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 81079, 81122);

                            var
                            moduleSymbol = f_10709_81098_81121(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 81148, 81181);

                            var
                            module = f_10709_81161_81180(moduleSymbol)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 81207, 81276);

                            isByRefLike = f_10709_81221_81275(f_10709_81221_81260(module, _handle));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 80993, 81299);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 81323, 81362);

                        uncommon.lazyIsByRefLike = isByRefLike;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 80852, 81381);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 81401, 81441);

                    return f_10709_81408_81440(uncommon.lazyIsByRefLike);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 80627, 81456);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                    f_10709_80678_80701(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUncommonProperties();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 80678, 80701);
                        return return_v;
                    }


                    bool
                    f_10709_80857_80892(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.HasValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 80857, 80892);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10709_80997_81010(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 80997, 81010);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_81098_81121(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 81098, 81121);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10709_81161_81180(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 81161, 81180);
                        return return_v;
                    }


                    bool
                    f_10709_81221_81260(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.TypeDefinitionHandle
                    token)
                    {
                        var return_v = this_param.HasIsByRefLikeAttribute((System.Reflection.Metadata.EntityHandle)token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 81221, 81260);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_10709_81221_81275(bool
                    value)
                    {
                        var return_v = value.ToThreeState();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 81221, 81275);
                        return return_v;
                    }


                    bool
                    f_10709_81408_81440(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.Value();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 81408, 81440);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 80568, 81467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 80568, 81467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 81535, 82357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 81571, 81610);

                    var
                    uncommon = f_10709_81586_81609(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 81628, 81740) || true) && (uncommon == s_noUncommonProperties)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 81628, 81740);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 81708, 81721);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 81628, 81740);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 81760, 82283) || true) && (!f_10709_81765_81799(uncommon.lazyIsReadOnly))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 81760, 82283);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 81841, 81875);

                        var
                        isReadOnly = ThreeState.False
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 81899, 82203) || true) && (f_10709_81903_81916(this) == TypeKind.Struct)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 81899, 82203);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 81985, 82028);

                            var
                            moduleSymbol = f_10709_82004_82027(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 82054, 82087);

                            var
                            module = f_10709_82067_82086(moduleSymbol)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 82113, 82180);

                            isReadOnly = f_10709_82126_82179(f_10709_82126_82164(module, _handle));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 81899, 82203);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 82227, 82264);

                        uncommon.lazyIsReadOnly = isReadOnly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 81760, 82283);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 82303, 82342);

                    return f_10709_82310_82341(uncommon.lazyIsReadOnly);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 81535, 82357);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                    f_10709_81586_81609(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUncommonProperties();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 81586, 81609);
                        return return_v;
                    }


                    bool
                    f_10709_81765_81799(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.HasValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 81765, 81799);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10709_81903_81916(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 81903, 81916);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_82004_82027(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 82004, 82027);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10709_82067_82086(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 82067, 82086);
                        return return_v;
                    }


                    bool
                    f_10709_82126_82164(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.TypeDefinitionHandle
                    token)
                    {
                        var return_v = this_param.HasIsReadOnlyAttribute((System.Reflection.Metadata.EntityHandle)token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 82126, 82164);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_10709_82126_82179(bool
                    value)
                    {
                        var return_v = value.ToThreeState();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 82126, 82179);
                        return return_v;
                    }


                    bool
                    f_10709_82310_82341(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.Value();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 82310, 82341);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 81479, 82368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 81479, 82368);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 82450, 82508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 82456, 82506);

                    return (_flags & TypeAttributes.HasSecurity) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 82450, 82508);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 82380, 82519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 82380, 82519);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 82531, 82691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 82643, 82680);

                throw f_10709_82649_82679();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 82531, 82691);

                System.Exception
                f_10709_82649_82679()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 82649, 82679);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 82531, 82691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 82531, 82691);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol ComImportCoClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 82778, 83762);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 82814, 82914) || true) && (!f_10709_82819_82841(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 82814, 82914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 82883, 82895);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 82814, 82914);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 82934, 82973);

                    var
                    uncommon = f_10709_82949_82972(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 82991, 83102) || true) && (uncommon == s_noUncommonProperties)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 82991, 83102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 83071, 83083);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 82991, 83102);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 83122, 83686) || true) && (f_10709_83126_83211(uncommon.lazyComImportCoClassType, ErrorTypeSymbol.UnknownResultType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 83122, 83686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 83253, 83375);

                        var
                        type = f_10709_83264_83374(f_10709_83264_83287(this), f_10709_83323_83334(this), AttributeDescription.CoClassAttribute)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 83397, 83528);

                        var
                        coClassType = (DynAbs.Tracing.TraceSender.Conditional_F1(10709, 83415, 83496) || ((((object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10709, 83416, 83495) && (f_10709_83441_83454(type) == TypeKind.Class || (DynAbs.Tracing.TraceSender.Expression_False(10709, 83441, 83494) || f_10709_83476_83494(type))))) && DynAbs.Tracing.TraceSender.Conditional_F2(10709, 83499, 83520)) || DynAbs.Tracing.TraceSender.Conditional_F3(10709, 83523, 83527))) ? (NamedTypeSymbol)type : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 83552, 83667);

                        f_10709_83552_83666(ref uncommon.lazyComImportCoClassType, coClassType, ErrorTypeSymbol.UnknownResultType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 83122, 83686);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 83706, 83747);

                    return uncommon.lazyComImportCoClassType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 82778, 83762);

                    bool
                    f_10709_82819_82841(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsInterfaceType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 82819, 82841);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                    f_10709_82949_82972(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUncommonProperties();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 82949, 82972);
                        return return_v;
                    }


                    bool
                    f_10709_83126_83211(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 83126, 83211);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_83264_83287(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 83264, 83287);
                        return return_v;
                    }


                    System.Reflection.Metadata.TypeDefinitionHandle
                    f_10709_83323_83334(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Handle;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 83323, 83334);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10709_83264_83374(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param, System.Reflection.Metadata.TypeDefinitionHandle
                    handle, Microsoft.CodeAnalysis.AttributeDescription
                    attributeDescription)
                    {
                        var return_v = this_param.TryDecodeAttributeWithTypeArgument((System.Reflection.Metadata.EntityHandle)handle, attributeDescription);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 83264, 83374);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10709_83441_83454(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 83441, 83454);
                        return return_v;
                    }


                    bool
                    f_10709_83476_83494(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsErrorType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 83476, 83494);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10709_83552_83666(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 83552, 83666);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 82703, 83773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 82703, 83773);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 83785, 84592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 83881, 83920);

                var
                uncommon = f_10709_83896_83919(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 83934, 84057) || true) && (uncommon == s_noUncommonProperties)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 83934, 84057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 84006, 84042);

                    return ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 83934, 84057);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 84073, 84517) || true) && (uncommon.lazyConditionalAttributeSymbols.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 84073, 84517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 84161, 84275);

                    ImmutableArray<string>
                    conditionalSymbols = f_10709_84205_84274(f_10709_84205_84235(f_10709_84205_84228(this)), _handle)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 84293, 84337);

                    f_10709_84293_84336(f_10709_84306_84335_M(!conditionalSymbols.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 84355, 84502);

                    f_10709_84355_84501(ref uncommon.lazyConditionalAttributeSymbols, conditionalSymbols, default(ImmutableArray<string>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 84073, 84517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 84533, 84581);

                return uncommon.lazyConditionalAttributeSymbols;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 83785, 84592);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                f_10709_83896_83919(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUncommonProperties();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 83896, 83919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_84205_84228(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 84205, 84228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_84205_84235(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 84205, 84235);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10709_84205_84274(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                token)
                {
                    var return_v = this_param.GetConditionalAttributeValues((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 84205, 84274);
                    return return_v;
                }


                bool
                f_10709_84306_84335_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 84306, 84335);
                    return return_v;
                }


                int
                f_10709_84293_84336(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 84293, 84336);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10709_84355_84501(ref System.Collections.Immutable.ImmutableArray<string>
                location, System.Collections.Immutable.ImmutableArray<string>
                value, System.Collections.Immutable.ImmutableArray<string>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 84355, 84501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 83785, 84592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 83785, 84592);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 84690, 85207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 84726, 84765);

                    var
                    uncommon = f_10709_84741_84764(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 84783, 84894) || true) && (uncommon == s_noUncommonProperties)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 84783, 84894);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 84863, 84875);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 84783, 84894);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 84914, 84962);

                    bool
                    ignoreByRefLikeMarker = f_10709_84943_84961(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 84980, 85132);

                    f_10709_84980_85131(ref uncommon.lazyObsoleteAttributeData, _handle, f_10709_85089_85107(), ignoreByRefLikeMarker);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 85150, 85192);

                    return uncommon.lazyObsoleteAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 84690, 85207);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                    f_10709_84741_84764(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUncommonProperties();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 84741, 84764);
                        return return_v;
                    }


                    bool
                    f_10709_84943_84961(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsRefLikeType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 84943, 84961);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_85089_85107()
                    {
                        var return_v = ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 85089, 85107);
                        return return_v;
                    }


                    int
                    f_10709_84980_85131(ref Microsoft.CodeAnalysis.ObsoleteAttributeData
                    data, System.Reflection.Metadata.TypeDefinitionHandle
                    token, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    containingModule, bool
                    ignoreByRefLikeMarker)
                    {
                        ObsoleteAttributeHelpers.InitializeObsoleteDataFromMetadata(ref data, (System.Reflection.Metadata.EntityHandle)token, containingModule, ignoreByRefLikeMarker);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 84980, 85131);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 84604, 85218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 84604, 85218);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override AttributeUsageInfo GetAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 85230, 85842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 85315, 85354);

                var
                uncommon = f_10709_85330_85353(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 85368, 85603) || true) && (uncommon == s_noUncommonProperties)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 85368, 85603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 85440, 85588);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10709, 85447, 85498) || ((((object)f_10709_85456_85489(this) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10709, 85501, 85558)) || DynAbs.Tracing.TraceSender.Conditional_F3(10709, 85561, 85587))) ? f_10709_85501_85558(f_10709_85501_85534(this)) : AttributeUsageInfo.Default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 85368, 85603);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 85619, 85776) || true) && (uncommon.lazyAttributeUsageInfo.IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 85619, 85776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 85695, 85761);

                    uncommon.lazyAttributeUsageInfo = f_10709_85729_85760(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 85619, 85776);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 85792, 85831);

                return uncommon.lazyAttributeUsageInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 85230, 85842);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
                f_10709_85330_85353(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUncommonProperties();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 85330, 85353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10709_85456_85489(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 85456, 85489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10709_85501_85534(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 85501, 85534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10709_85501_85558(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributeUsageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 85501, 85558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10709_85729_85760(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DecodeAttributeUsageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 85729, 85760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 85230, 85842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 85230, 85842);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AttributeUsageInfo DecodeAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 85854, 86811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 85932, 86018);

                var
                handle = f_10709_85945_86017(f_10709_85945_85975(f_10709_85945_85968(this)), _handle)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 86034, 86636) || true) && (f_10709_86038_86051_M(!handle.IsNil))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 86034, 86636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 86085, 86139);

                    var
                    decoder = f_10709_86099_86138(f_10709_86119_86137())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 86157, 86188);

                    TypedConstant[]
                    positionalArgs
                    = default(TypedConstant[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 86206, 86254);

                    KeyValuePair<string, TypedConstant>[]
                    namedArgs
                    = default(KeyValuePair<string, TypedConstant>[]);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 86272, 86621) || true) && (f_10709_86276_86345(decoder, handle, out positionalArgs, out namedArgs))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 86272, 86621);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 86387, 86507);

                        AttributeUsageInfo
                        info = f_10709_86413_86506(positionalArgs[0], f_10709_86476_86505(namedArgs))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 86529, 86602);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10709, 86536, 86565) || ((info.HasValidAttributeTargets && DynAbs.Tracing.TraceSender.Conditional_F2(10709, 86568, 86572)) || DynAbs.Tracing.TraceSender.Conditional_F3(10709, 86575, 86601))) ? info : AttributeUsageInfo.Default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 86272, 86621);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 86034, 86636);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 86652, 86800);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10709, 86659, 86710) || ((((object)f_10709_86668_86701(this) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10709, 86713, 86770)) || DynAbs.Tracing.TraceSender.Conditional_F3(10709, 86773, 86799))) ? f_10709_86713_86770(f_10709_86713_86746(this)) : AttributeUsageInfo.Default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 85854, 86811);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_85945_85968(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 85945, 85968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10709_85945_85975(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 85945, 85975);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandle
                f_10709_85945_86017(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                token)
                {
                    var return_v = this_param.GetAttributeUsageAttributeHandle((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 85945, 86017);
                    return return_v;
                }


                bool
                f_10709_86038_86051_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 86038, 86051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10709_86119_86137()
                {
                    var return_v = ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 86119, 86137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10709_86099_86138(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 86099, 86138);
                    return return_v;
                }


                bool
                f_10709_86276_86345(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out Microsoft.CodeAnalysis.TypedConstant[]
                positionalArgs, out System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>[]
                namedArgs)
                {
                    var return_v = this_param.GetCustomAttribute(handle, out positionalArgs, out namedArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 86276, 86345);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10709_86476_86505(System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 86476, 86505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10709_86413_86506(Microsoft.CodeAnalysis.TypedConstant
                positionalArg, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArgs)
                {
                    var return_v = AttributeData.DecodeAttributeUsageAttribute(positionalArg, namedArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 86413, 86506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10709_86668_86701(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 86668, 86701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10709_86713_86746(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 86713, 86746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10709_86713_86770(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributeUsageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 86713, 86770);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 85854, 86811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 85854, 86811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 86936, 86956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 86942, 86954);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 86936, 86956);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 86823, 86967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 86823, 86967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<object> fieldDefs { get; set; }

        private static int GetIndexOfFirstMember(ImmutableArray<Symbol> members, SymbolKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10709, 87218, 87575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 87332, 87355);

                int
                n = members.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 87378, 87383);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 87369, 87541) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 87392, 87395)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 87369, 87541))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 87369, 87541);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 87429, 87526) || true) && (f_10709_87433_87448(members[i]) == kind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 87429, 87526);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 87498, 87507);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 87429, 87526);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 87555, 87564);

                return n;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10709, 87218, 87575);

                Microsoft.CodeAnalysis.SymbolKind
                f_10709_87433_87448(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 87433, 87448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 87218, 87575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 87218, 87575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<TSymbol> GetMembers<TSymbol>(ImmutableArray<Symbol> members, SymbolKind kind, int offset = -1)
                    where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10709, 87790, 88408);

                var listYield = new List<TSymbol>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 87972, 88081) || true) && (offset < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 87972, 88081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 88020, 88066);

                    offset = f_10709_88029_88065<TSymbol>(members, kind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 87972, 88081);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 88095, 88118);

                int
                n = members.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 88141, 88151);
                    for (int
        i = offset
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 88132, 88397) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 88160, 88163)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 88132, 88397))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 88132, 88397);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 88197, 88221);

                        var
                        member = members[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 88239, 88335) || true) && (f_10709_88243_88254<TSymbol>(member) != kind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 88239, 88335);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 88304, 88316);

                            return listYield;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 88239, 88335);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 88353, 88382);

                        listYield.Add((TSymbol)member);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 266);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10709, 87790, 88408);

                return listYield;

                int
                f_10709_88029_88065<TSymbol>(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                members, Microsoft.CodeAnalysis.SymbolKind
                kind) where TSymbol : Symbol

                {
                    var return_v = GetIndexOfFirstMember(members, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 88029, 88065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10709_88243_88254<TSymbol>(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 88243, 88254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 87790, 88408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 87790, 88408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class PENamedTypeSymbolNonGeneric : PENamedTypeSymbol
        {
            internal PENamedTypeSymbolNonGeneric(
                            PEModuleSymbol moduleSymbol,
                            NamespaceOrTypeSymbol container,
                            TypeDefinitionHandle handle,
                            string emittedNamespaceName,
                            out bool mangleName) : base(f_10709_89010_89022_C(moduleSymbol), container, handle, emittedNamespaceName, 0, out mangleName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10709, 88722, 89113);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10709, 88722, 89113);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 88722, 89113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 88722, 89113);
                }
            }

            protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 89223, 89262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 89226, 89262);
                    throw f_10709_89232_89262(); DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 89223, 89262);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 89223, 89262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 89223, 89262);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Exception
                f_10709_89232_89262()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 89232, 89262);
                    return return_v;
                }

            }

            public override int Arity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 89337, 89409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 89381, 89390);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 89337, 89409);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 89279, 89424);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 89279, 89424);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool MangleName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 89506, 89582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 89550, 89563);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 89506, 89582);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 89440, 89597);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 89440, 89597);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override int MetadataArity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 89681, 89892);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 89725, 89778);

                        var
                        containingType = _container as PENamedTypeSymbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 89800, 89873);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10709, 89807, 89837) || (((object)containingType == null && DynAbs.Tracing.TraceSender.Conditional_F2(10709, 89840, 89841)) || DynAbs.Tracing.TraceSender.Conditional_F3(10709, 89844, 89872))) ? 0 : f_10709_89844_89872(containingType);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 89681, 89892);

                        int
                        f_10709_89844_89872(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.MetadataArity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 89844, 89872);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 89613, 89907);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 89613, 89907);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override NamedTypeSymbol AsNativeInteger()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 89923, 90205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 90007, 90117);

                    f_10709_90007_90116(f_10709_90020_90036(this) == SpecialType.System_IntPtr || (DynAbs.Tracing.TraceSender.Expression_False(10709, 90020, 90115) || f_10709_90069_90085(this) == SpecialType.System_UIntPtr));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 90137, 90190);

                    return f_10709_90144_90189(f_10709_90144_90162(), this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 89923, 90205);

                    Microsoft.CodeAnalysis.SpecialType
                    f_10709_90020_90036(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolNonGeneric
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 90020, 90036);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10709_90069_90085(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolNonGeneric
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 90069, 90085);
                        return return_v;
                    }


                    int
                    f_10709_90007_90116(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 90007, 90116);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10709_90144_90162()
                    {
                        var return_v = ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 90144, 90162);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10709_90144_90189(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolNonGeneric
                    underlyingType)
                    {
                        var return_v = this_param.GetNativeIntegerType((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)underlyingType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 90144, 90189);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 89923, 90205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 89923, 90205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override NamedTypeSymbol NativeIntegerUnderlyingType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 90283, 90290);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 90286, 90290);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 90283, 90290);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 90283, 90290);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 90283, 90290);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 90307, 90591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 90412, 90576);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10709, 90419, 90462) || ((t2 is NativeIntegerTypeSymbol nativeInteger && DynAbs.Tracing.TraceSender.Conditional_F2(10709, 90486, 90524)) || DynAbs.Tracing.TraceSender.Conditional_F3(10709, 90548, 90575))) ? f_10709_90486_90524((NativeIntegerTypeSymbol)t2, this, comparison) : DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(t2, comparison), 10709, 90548, 90575);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 90307, 90591);

                    bool
                    f_10709_90486_90524(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolNonGeneric
                    other, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)other, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 90486, 90524);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 90307, 90591);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 90307, 90591);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static PENamedTypeSymbolNonGeneric()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10709, 88629, 90602);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10709, 88629, 90602);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 88629, 90602);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10709, 88629, 90602);

            static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
            f_10709_89010_89022_C(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10709, 88722, 89113);
                return return_v;
            }

        }
        private sealed class PENamedTypeSymbolGeneric : PENamedTypeSymbol
        {
            private readonly GenericParameterHandleCollection _genericParameterHandles;

            private readonly ushort _arity;

            private readonly bool _mangleName;

            private ImmutableArray<TypeParameterSymbol> _lazyTypeParameters;

            internal PENamedTypeSymbolGeneric(
                                PEModuleSymbol moduleSymbol,
                                NamespaceOrTypeSymbol container,
                                TypeDefinitionHandle handle,
                                string emittedNamespaceName,
                                GenericParameterHandleCollection genericParameterHandles,
                                ushort arity,
                                out bool mangleName
                            )
            : base(f_10709_91661_91673_C(moduleSymbol), container, handle, emittedNamespaceName, arity, out mangleName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10709, 91224, 92094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 91075, 91081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 91118, 91129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 91886, 91934);

                    f_10709_91886_91933(genericParameterHandles.Count > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 91952, 91967);

                    _arity = arity;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 91985, 92036);

                    _genericParameterHandles = genericParameterHandles;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 92054, 92079);

                    _mangleName = mangleName;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10709, 91224, 92094);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 91224, 92094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 91224, 92094);
                }
            }

            protected sealed override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 92211, 92250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 92214, 92250);
                    throw f_10709_92220_92250(); DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 92211, 92250);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 92211, 92250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 92211, 92250);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Exception
                f_10709_92220_92250()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 92220, 92250);
                    return return_v;
                }

            }

            public override int Arity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 92325, 92402);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 92369, 92383);

                        return _arity;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 92325, 92402);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 92267, 92417);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 92267, 92417);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool MangleName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 92499, 92581);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 92543, 92562);

                        return _mangleName;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 92499, 92581);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 92433, 92596);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 92433, 92596);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override int MetadataArity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 92680, 92781);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 92724, 92762);

                        return _genericParameterHandles.Count;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 92680, 92781);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 92612, 92796);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 92612, 92796);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 92947, 93169);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 93108, 93150);

                        return f_10709_93115_93149(this);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 92947, 93169);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10709_93115_93149(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolGeneric
                        this_param)
                        {
                            var return_v = this_param.GetTypeParametersAsTypeArguments();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 93115, 93149);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 92812, 93184);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 92812, 93184);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 93299, 93443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 93343, 93375);

                        f_10709_93343_93374(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 93397, 93424);

                        return _lazyTypeParameters;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 93299, 93443);

                        int
                        f_10709_93343_93374(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolGeneric
                        this_param)
                        {
                            this_param.EnsureTypeParametersAreLoaded();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 93343, 93374);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 93200, 93458);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 93200, 93458);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override NamedTypeSymbol AsNativeInteger()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 93533, 93572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 93536, 93572);
                    throw f_10709_93542_93572(); DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 93533, 93572);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 93533, 93572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 93533, 93572);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Exception
                f_10709_93542_93572()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 93542, 93572);
                    return return_v;
                }

            }

            internal sealed override NamedTypeSymbol NativeIntegerUnderlyingType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 93658, 93665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 93661, 93665);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 93658, 93665);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 93658, 93665);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 93658, 93665);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private void EnsureTypeParametersAreLoaded()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 93682, 94634);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 93759, 94619) || true) && (_lazyTypeParameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 93759, 94619);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 93834, 93872);

                        var
                        moduleSymbol = f_10709_93853_93871()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 94023, 94080);

                        int
                        firstIndex = _genericParameterHandles.Count - _arity
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 94104, 94172);

                        TypeParameterSymbol[]
                        ownedParams = new TypeParameterSymbol[_arity]
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 94203, 94208);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 94194, 94426) || true) && (i < f_10709_94214_94232(ownedParams))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 94234, 94237)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 94194, 94426))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 94194, 94426);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 94287, 94403);

                                ownedParams[i] = f_10709_94304_94402(moduleSymbol, this, (ushort)i, _genericParameterHandles[firstIndex + i]);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 233);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 233);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 94450, 94600);

                        f_10709_94450_94599(ref _lazyTypeParameters, f_10709_94543_94598(ownedParams));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 93759, 94619);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 93682, 94634);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_93853_93871()
                    {
                        var return_v = ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 93853, 93871);
                        return return_v;
                    }


                    int
                    f_10709_94214_94232(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 94214, 94232);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                    f_10709_94304_94402(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolGeneric
                    definingNamedType, int
                    ordinal, System.Reflection.Metadata.GenericParameterHandle
                    handle)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol(moduleSymbol, (Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol)definingNamedType, (ushort)ordinal, handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 94304, 94402);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10709_94543_94598(params Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                    items)
                    {
                        var return_v = ImmutableArray.Create<TypeParameterSymbol>(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 94543, 94598);
                        return return_v;
                    }


                    bool
                    f_10709_94450_94599(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 94450, 94599);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 93682, 94634);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 93682, 94634);
                }
            }

            protected override DiagnosticInfo GetUseSiteDiagnosticImpl()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 94650, 95292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 94743, 94776);

                    DiagnosticInfo
                    diagnostic = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 94796, 95239) || true) && (!f_10709_94801_94873(this, ref diagnostic, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetUseSiteDiagnosticImpl(), 10709, 94841, 94872)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 94796, 95239);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 95044, 95220) || true) && (!f_10709_95049_95082(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 95044, 95220);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 95132, 95197);

                            diagnostic = f_10709_95145_95196(ErrorCode.ERR_BogusType, this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 95044, 95220);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 94796, 95239);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 95259, 95277);

                    return diagnostic;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 94650, 95292);

                    bool
                    f_10709_94801_94873(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolGeneric
                    this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                    result, Microsoft.CodeAnalysis.DiagnosticInfo
                    info)
                    {
                        var return_v = this_param.MergeUseSiteDiagnostics(ref result, info);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 94801, 94873);
                        return return_v;
                    }


                    bool
                    f_10709_95049_95082(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolGeneric
                    this_param)
                    {
                        var return_v = this_param.MatchesContainingTypeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 95049, 95082);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10709_95145_95196(Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 95145, 95196);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 94650, 95292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 94650, 95292);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool MatchesContainingTypeParameters()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10709, 95626, 97543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 95705, 95741);

                    var
                    container = f_10709_95721_95740(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 95759, 95861) || true) && ((object)container == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 95759, 95861);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 95830, 95842);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 95759, 95861);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 95881, 95945);

                    var
                    containingTypeParameters = f_10709_95912_95944(container)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 95963, 96003);

                    int
                    n = containingTypeParameters.Length
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 96023, 96106) || true) && (n == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 96023, 96106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 96075, 96087);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 96023, 96106);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 96555, 96664);

                    var
                    nestedType = f_10709_96572_96663(f_10709_96579_96602(this), f_10709_96623_96647(this), _handle, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 96682, 96735);

                    var
                    nestedTypeParameters = f_10709_96709_96734(nestedType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 96753, 96870);

                    var
                    containingTypeMap = f_10709_96777_96869(containingTypeParameters, f_10709_96815_96849(n), allowAlpha: false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 96888, 97023);

                    var
                    nestedTypeMap = f_10709_96908_97022(nestedTypeParameters, f_10709_96942_97002(nestedTypeParameters.Length), allowAlpha: false)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 97052, 97057);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 97043, 97496) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 97066, 97069)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 97043, 97496))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 97043, 97496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 97111, 97169);

                            var
                            containingTypeParameter = containingTypeParameters[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 97191, 97241);

                            var
                            nestedTypeParameter = nestedTypeParameters[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 97263, 97477) || true) && (!f_10709_97268_97391(containingTypeParameter, containingTypeMap, nestedTypeParameter, nestedTypeMap))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10709, 97263, 97477);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 97441, 97454);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10709, 97263, 97477);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10709, 1, 454);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10709, 1, 454);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 97516, 97528);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10709, 95626, 97543);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10709_95721_95740(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolGeneric
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 95721, 95740);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10709_95912_95944(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.GetAllTypeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 95912, 95944);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10709_96579_96602(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolGeneric
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 96579, 96602);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10709_96623_96647(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.PENamedTypeSymbolGeneric
                    this_param)
                    {
                        var return_v = this_param.ContainingNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 96623, 96647);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    f_10709_96572_96663(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    containingNamespace, System.Reflection.Metadata.TypeDefinitionHandle
                    handle, string
                    emittedNamespaceName)
                    {
                        var return_v = Create(moduleSymbol, (Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol)containingNamespace, handle, emittedNamespaceName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 96572, 96663);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10709_96709_96734(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 96709, 96734);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10709_96815_96849(int
                    count)
                    {
                        var return_v = IndexedTypeParameterSymbol.Take(count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 96815, 96849);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10709_96777_96869(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    to, bool
                    allowAlpha)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha: allowAlpha);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 96777, 96869);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10709_96942_97002(int
                    count)
                    {
                        var return_v = IndexedTypeParameterSymbol.Take(count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 96942, 97002);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10709_96908_97022(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    to, bool
                    allowAlpha)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha: allowAlpha);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 96908, 97022);
                        return return_v;
                    }


                    bool
                    f_10709_97268_97391(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    typeMap1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    typeParameter2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    typeMap2)
                    {
                        var return_v = MemberSignatureComparer.HaveSameConstraints(typeParameter1, typeMap1, typeParameter2, typeMap2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 97268, 97391);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10709, 95626, 97543);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 95626, 97543);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static PENamedTypeSymbolGeneric()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10709, 90872, 97554);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10709, 90872, 97554);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 90872, 97554);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10709, 90872, 97554);

            int
            f_10709_91886_91933(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 91886, 91933);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
            f_10709_91661_91673_C(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10709, 91224, 92094);
                return return_v;
            }

        }

        static PENamedTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10709, 868, 97561);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 1022, 1124);
            s_emptyNestedTypes = f_10709_1043_1124(EmptyComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10709, 4097, 4146);
            s_noUncommonProperties = f_10709_4122_4146(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10709, 868, 97561);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10709, 868, 97561);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10709, 868, 97561);

        static System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
        f_10709_1043_1124(Roslyn.Utilities.EmptyComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 1043, 1124);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties
        f_10709_4122_4146()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol.UncommonProperties();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 4122, 4146);
            return return_v;
        }


        bool
        f_10709_11314_11327_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 11314, 11327);
            return return_v;
        }


        int
        f_10709_11301_11328(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 11301, 11328);
            return 0;
        }


        int
        f_10709_11343_11382(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 11343, 11382);
            return 0;
        }


        int
        f_10709_11397_11457(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 11397, 11457);
            return 0;
        }


        Microsoft.CodeAnalysis.PEModule
        f_10709_11596_11615(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 11596, 11615);
            return return_v;
        }


        string
        f_10709_11596_11645(Microsoft.CodeAnalysis.PEModule
        this_param, System.Reflection.Metadata.TypeDefinitionHandle
        typeDef)
        {
            var return_v = this_param.GetTypeDefNameOrThrow(typeDef);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 11596, 11645);
            return return_v;
        }


        Microsoft.CodeAnalysis.PEModule
        f_10709_11946_11965(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 11946, 11965);
            return return_v;
        }


        System.Reflection.TypeAttributes
        f_10709_11946_11996(Microsoft.CodeAnalysis.PEModule
        this_param, System.Reflection.Metadata.TypeDefinitionHandle
        typeDef)
        {
            var return_v = this_param.GetTypeDefFlagsOrThrow(typeDef);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 11946, 11996);
            return return_v;
        }


        string
        f_10709_12370_12435(string
        emittedTypeName, ushort
        arity)
        {
            var return_v = MetadataHelpers.UnmangleMetadataNameForArity(emittedTypeName, (int)arity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 12370, 12435);
            return return_v;
        }


        bool
        f_10709_12467_12503(string
        objA, string
        objB)
        {
            var return_v = ReferenceEquals((object)objA, (object)objB);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 12467, 12503);
            return return_v;
        }


        int
        f_10709_12454_12531(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 12454, 12531);
            return 0;
        }


        bool
        f_10709_12564_12600(string
        objA, string
        objB)
        {
            var return_v = ReferenceEquals((object)objA, (object)objB);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 12564, 12600);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10709_12747_12778(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 12747, 12778);
            return return_v;
        }


        bool
        f_10709_12747_12813(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param)
        {
            var return_v = this_param.KeepLookingForDeclaredSpecialTypes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 12747, 12813);
            return return_v;
        }


        Microsoft.CodeAnalysis.Accessibility
        f_10709_12834_12860(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
        this_param)
        {
            var return_v = this_param.DeclaredAccessibility;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10709, 12834, 12860);
            return return_v;
        }


        string
        f_10709_13001_13071(string
        qualifier, string
        name)
        {
            var return_v = MetadataHelpers.BuildQualifiedName(qualifier, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 13001, 13071);
            return return_v;
        }


        Microsoft.CodeAnalysis.SpecialType
        f_10709_12964_13072(string
        metadataName)
        {
            var return_v = SpecialTypes.GetTypeFromMetadataName(metadataName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 12964, 13072);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10709_13270_13321(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, params object[]
        args)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10709, 13270, 13321);
            return return_v;
        }

    }
}
