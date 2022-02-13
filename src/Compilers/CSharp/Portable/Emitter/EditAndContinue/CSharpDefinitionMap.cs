// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed partial class CSharpDefinitionMap : DefinitionMap
    {
        private readonly MetadataDecoder _metadataDecoder;

        private readonly CSharpSymbolMatcher _mapToMetadata;

        private readonly CSharpSymbolMatcher _mapToPrevious;

        public CSharpDefinitionMap(
                    IEnumerable<SemanticEdit> edits,
                    MetadataDecoder metadataDecoder,
                    CSharpSymbolMatcher mapToMetadata,
                    CSharpSymbolMatcher mapToPrevious)
        : base(f_10937_1388_1393_C(edits))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10937, 1152, 1676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 999, 1015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 1063, 1077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 1125, 1139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 1419, 1457);

                f_10937_1419_1456(metadataDecoder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 1471, 1507);

                f_10937_1471_1506(mapToMetadata != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 1523, 1558);

                _metadataDecoder = metadataDecoder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 1572, 1603);

                _mapToMetadata = mapToMetadata;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 1617, 1665);

                _mapToPrevious = mapToPrevious ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher>(10937, 1634, 1664) ?? mapToMetadata);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10937, 1152, 1676);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 1152, 1676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 1152, 1676);
            }
        }

        protected override SymbolMatcher MapToMetadataSymbolMatcher
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 1748, 1765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 1751, 1765);
                    return _mapToMetadata; DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 1748, 1765);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 1748, 1765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 1748, 1765);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override SymbolMatcher MapToPreviousSymbolMatcher
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 1836, 1853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 1839, 1853);
                    return _mapToPrevious; DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 1836, 1853);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 1836, 1853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 1836, 1853);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ISymbolInternal GetISymbolInternalOrNull(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 1866, 2082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 1989, 2071);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10937, 1996, 2039) || 
                    (((symbol is Symbols.PublicModel.Symbol temp) && DynAbs.Tracing.TraceSender.Conditional_F2(10937, 2042, 2063)) 
                    || DynAbs.Tracing.TraceSender.Conditional_F3(10937, 2066, 2070))) ? f_10937_2042_2063((Symbols.PublicModel.Symbol)symbol) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 1866, 2082);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10937_2042_2063(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                this_param)
                {
                    var return_v = this_param.UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 2042, 2063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 1866, 2082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 1866, 2082);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override CommonMessageProvider MessageProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 2163, 2197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 2166, 2197);
                    return CSharp.MessageProvider.Instance; DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 2163, 2197);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 2163, 2197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 2163, 2197);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override LambdaSyntaxFacts GetLambdaSyntaxFacts()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 2283, 2318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 2286, 2318);
                return CSharpLambdaSyntaxFacts.Instance; DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 2283, 2318);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 2283, 2318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 2283, 2318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool TryGetAnonymousTypeName(AnonymousTypeManager.AnonymousTypeTemplateSymbol template, out string name, out int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 2473, 2545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 2476, 2545);
                return f_10937_2476_2545(_mapToPrevious, template, out name, out index); DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 2473, 2545);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 2473, 2545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 2473, 2545);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10937_2476_2545(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
            template, out string
            name, out int
            index)
            {
                var return_v = this_param.TryGetAnonymousTypeName(template, out name, out index);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 2476, 2545);
                return return_v;
            }

        }

        internal override bool TryGetTypeHandle(Cci.ITypeDefinition def, out TypeDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 2558, 2937);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 2680, 2866) || true) && (f_10937_2684_2738_I(f_10937_2684_2717(_mapToMetadata, def).GetInternalSymbol()) is PENamedTypeSymbol other)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 2680, 2866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 2799, 2821);

                    handle = f_10937_2808_2820(other);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 2839, 2851);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 2680, 2866);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 2882, 2899);

                handle = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 2913, 2926);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 2558, 2937);

                Microsoft.Cci.IDefinition?
                f_10937_2684_2717(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
                this_param, Microsoft.Cci.ITypeDefinition
                definition)
                {
                    var return_v = this_param?.MapDefinition((Microsoft.Cci.IDefinition)definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 2684, 2717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10937_2684_2738_I(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 2684, 2738);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandle
                f_10937_2808_2820(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 2808, 2820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 2558, 2937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 2558, 2937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetEventHandle(Cci.IEventDefinition def, out EventDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 2949, 3327);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 3074, 3256) || true) && (f_10937_3078_3132_I(f_10937_3078_3111(_mapToMetadata, def).GetInternalSymbol()) is PEEventSymbol other)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 3074, 3256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 3189, 3211);

                    handle = f_10937_3198_3210(other);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 3229, 3241);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 3074, 3256);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 3272, 3289);

                handle = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 3303, 3316);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 2949, 3327);

                Microsoft.Cci.IDefinition?
                f_10937_3078_3111(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
                this_param, Microsoft.Cci.IEventDefinition
                definition)
                {
                    var return_v = this_param?.MapDefinition((Microsoft.Cci.IDefinition)definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 3078, 3111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10937_3078_3132_I(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 3078, 3132);
                    return return_v;
                }


                System.Reflection.Metadata.EventDefinitionHandle
                f_10937_3198_3210(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 3198, 3210);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 2949, 3327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 2949, 3327);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetFieldHandle(Cci.IFieldDefinition def, out FieldDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 3339, 3717);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 3464, 3646) || true) && (f_10937_3468_3522_I(f_10937_3468_3501(_mapToMetadata, def).GetInternalSymbol()) is PEFieldSymbol other)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 3464, 3646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 3579, 3601);

                    handle = f_10937_3588_3600(other);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 3619, 3631);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 3464, 3646);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 3662, 3679);

                handle = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 3693, 3706);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 3339, 3717);

                Microsoft.Cci.IDefinition?
                f_10937_3468_3501(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
                this_param, Microsoft.Cci.IFieldDefinition
                definition)
                {
                    var return_v = this_param?.MapDefinition((Microsoft.Cci.IDefinition)definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 3468, 3501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10937_3468_3522_I(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 3468, 3522);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandle
                f_10937_3588_3600(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 3588, 3600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 3339, 3717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 3339, 3717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetMethodHandle(Cci.IMethodDefinition def, out MethodDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 3729, 4111);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 3857, 4040) || true) && (f_10937_3861_3915_I(f_10937_3861_3894(_mapToMetadata, def).GetInternalSymbol()) is PEMethodSymbol other)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 3857, 4040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 3973, 3995);

                    handle = f_10937_3982_3994(other);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 4013, 4025);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 3857, 4040);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 4056, 4073);

                handle = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 4087, 4100);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 3729, 4111);

                Microsoft.Cci.IDefinition?
                f_10937_3861_3894(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
                this_param, Microsoft.Cci.IMethodDefinition
                definition)
                {
                    var return_v = this_param?.MapDefinition((Microsoft.Cci.IDefinition)definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 3861, 3894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10937_3861_3915_I(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 3861, 3915);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandle
                f_10937_3982_3994(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 3982, 3994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 3729, 4111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 3729, 4111);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetPropertyHandle(Cci.IPropertyDefinition def, out PropertyDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 4123, 4513);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 4257, 4442) || true) && (f_10937_4261_4315_I(f_10937_4261_4294(_mapToMetadata, def).GetInternalSymbol()) is PEPropertySymbol other)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 4257, 4442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 4375, 4397);

                    handle = f_10937_4384_4396(other);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 4415, 4427);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 4257, 4442);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 4458, 4475);

                handle = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 4489, 4502);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 4123, 4513);

                Microsoft.Cci.IDefinition?
                f_10937_4261_4294(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
                this_param, Microsoft.Cci.IPropertyDefinition
                definition)
                {
                    var return_v = this_param?.MapDefinition((Microsoft.Cci.IDefinition)definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 4261, 4294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10937_4261_4315_I(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 4261, 4315);
                    return return_v;
                }


                System.Reflection.Metadata.PropertyDefinitionHandle
                f_10937_4384_4396(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 4384, 4396);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 4123, 4513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 4123, 4513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void GetStateMachineFieldMapFromMetadata(
                    ITypeSymbolInternal stateMachineType,
                    ImmutableArray<LocalSlotDebugInfo> localSlotDebugInfo,
                    out IReadOnlyDictionary<EncHoistedLocalInfo, int> hoistedLocalMap,
                    out IReadOnlyDictionary<Cci.ITypeReference, int> awaiterMap,
                    out int awaiterSlotCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 4525, 7584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 4969, 5039);

                f_10937_4969_5038(f_10937_4982_5017(stateMachineType) is PEAssemblySymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 5055, 5118);

                var
                hoistedLocals = f_10937_5075_5117()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 5132, 5234);

                var
                awaiters = f_10937_5147_5233(Cci.SymbolEquivalentEqualityComparer.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 5248, 5277);

                int
                maxAwaiterSlotIndex = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 5293, 7432);
                    foreach (var member in f_10937_5316_5359_I(f_10937_5316_5359(((TypeSymbol)stateMachineType))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 5293, 7432);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 5393, 7417) || true) && (f_10937_5397_5408(member) == SymbolKind.Field)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 5393, 7417);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 5470, 5496);

                            string
                            name = f_10937_5484_5495(member)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 5518, 5532);

                            int
                            slotIndex
                            = default(int);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 5556, 7398);

                            switch (f_10937_5564_5592(name))
                            {

                                case GeneratedNameKind.AwaiterField:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 5556, 7398);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 5708, 6333) || true) && (f_10937_5712_5765(name, out slotIndex))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 5708, 6333);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 5831, 5863);

                                        var
                                        field = (FieldSymbol)member
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 6021, 6090);

                                        awaiters[(Cci.ITypeReference)f_10937_6050_6076(f_10937_6050_6060(field))] = slotIndex;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 6126, 6302) || true) && (slotIndex > maxAwaiterSlotIndex)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 6126, 6302);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 6235, 6267);

                                            maxAwaiterSlotIndex = slotIndex;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 6126, 6302);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 5708, 6333);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10937, 6365, 6371);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 5556, 7398);

                                case GeneratedNameKind.HoistedLocalField:
                                case GeneratedNameKind.HoistedSynthesizedLocalField:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 5556, 7398);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 6548, 7337) || true) && (f_10937_6552_6605(name, out slotIndex))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 6548, 7337);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 6671, 6703);

                                        var
                                        field = (FieldSymbol)member
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 6737, 6965) || true) && (slotIndex >= localSlotDebugInfo.Length)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 6737, 6965);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 6921, 6930);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 6737, 6965);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 7001, 7114);

                                        var
                                        key = f_10937_7011_7113(localSlotDebugInfo[slotIndex], f_10937_7086_7112(f_10937_7086_7096(field)))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 7275, 7306);

                                        hoistedLocals[key] = slotIndex;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 6548, 7337);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10937, 7369, 7375);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 5556, 7398);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 5393, 7417);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 5293, 7432);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10937, 1, 2140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10937, 1, 2140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 7448, 7480);

                hoistedLocalMap = hoistedLocals;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 7494, 7516);

                awaiterMap = awaiters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 7530, 7573);

                awaiterSlotCount = maxAwaiterSlotIndex + 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 4525, 7584);

                Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal
                f_10937_4982_5017(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 4982, 5017);
                    return return_v;
                }


                int
                f_10937_4969_5038(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 4969, 5038);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo, int>
                f_10937_5075_5117()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo, int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 5075, 5117);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeReference, int>
                f_10937_5147_5233(Microsoft.Cci.SymbolEquivalentEqualityComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeReference, int>((System.Collections.Generic.IEqualityComparer<Microsoft.Cci.ITypeReference>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 5147, 5233);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10937_5316_5359(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 5316, 5359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10937_5397_5408(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 5397, 5408);
                    return return_v;
                }


                string
                f_10937_5484_5495(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 5484, 5495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedNameKind
                f_10937_5564_5592(string
                name)
                {
                    var return_v = GeneratedNames.GetKind(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 5564, 5592);
                    return return_v;
                }


                bool
                f_10937_5712_5765(string
                fieldName, out int
                slotIndex)
                {
                    var return_v = GeneratedNames.TryParseSlotIndex(fieldName, out slotIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 5712, 5765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10937_6050_6060(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 6050, 6060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                f_10937_6050_6076(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 6050, 6076);
                    return return_v;
                }


                bool
                f_10937_6552_6605(string
                fieldName, out int
                slotIndex)
                {
                    var return_v = GeneratedNames.TryParseSlotIndex(fieldName, out slotIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 6552, 6605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10937_7086_7096(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 7086, 7096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                f_10937_7086_7112(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 7086, 7112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo
                f_10937_7011_7113(Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                slotInfo, Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo(slotInfo, (Microsoft.Cci.ITypeReference)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 7011, 7113);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10937_5316_5359_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 5316, 5359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 4525, 7584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 4525, 7584);
            }
        }

        protected override ImmutableArray<EncLocalInfo> GetLocalSlotMapFromMetadata(StandaloneSignatureHandle handle, EditAndContinueMethodDebugInformation debugInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 7596, 8053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 7779, 7807);

                f_10937_7779_7806(f_10937_7792_7805_M(!handle.IsNil));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 7823, 7882);

                var
                localInfos = f_10937_7840_7881(_metadataDecoder, handle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 7896, 7951);

                var
                result = f_10937_7909_7950(debugInfo, localInfos)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 7965, 8014);

                f_10937_7965_8013(result.Length == localInfos.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 8028, 8042);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 7596, 8053);

                bool
                f_10937_7792_7805_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 7792, 7805);
                    return return_v;
                }


                int
                f_10937_7779_7806(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 7779, 7806);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LocalInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                f_10937_7840_7881(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.StandaloneSignatureHandle
                handle)
                {
                    var return_v = this_param.GetLocalsOrThrow(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 7840, 7881);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
                f_10937_7909_7950(Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation
                methodEncInfo, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LocalInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                slotMetadata)
                {
                    var return_v = CreateLocalSlotMap(methodEncInfo, slotMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 7909, 7950);
                    return return_v;
                }


                int
                f_10937_7965_8013(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 7965, 8013);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 7596, 8053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 7596, 8053);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ITypeSymbolInternal TryGetStateMachineType(EntityHandle methodHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10937, 8065, 8639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 8178, 8194);

                string
                typeName
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 8208, 8600) || true) && (f_10937_8212_8337(_metadataDecoder.Module, methodHandle, AttributeDescription.AsyncStateMachineAttribute, out typeName) || (DynAbs.Tracing.TraceSender.Expression_False(10937, 8212, 8486) || f_10937_8358_8486(_metadataDecoder.Module, methodHandle, AttributeDescription.IteratorStateMachineAttribute, out typeName)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 8208, 8600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 8520, 8585);

                    return f_10937_8527_8584(_metadataDecoder, typeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 8208, 8600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 8616, 8628);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10937, 8065, 8639);

                bool
                f_10937_8212_8337(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description, out string
                value)
                {
                    var return_v = this_param.HasStringValuedAttribute(token, description, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 8212, 8337);
                    return return_v;
                }


                bool
                f_10937_8358_8486(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description, out string
                value)
                {
                    var return_v = this_param.HasStringValuedAttribute(token, description, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 8358, 8486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10937_8527_8584(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, string
                s)
                {
                    var return_v = this_param.GetTypeSymbolForSerializedType(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 8527, 8584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 8065, 8639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 8065, 8639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<EncLocalInfo> CreateLocalSlotMap(
                    EditAndContinueMethodDebugInformation methodEncInfo,
                    ImmutableArray<LocalInfo<TypeSymbol>> slotMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10937, 8923, 10993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 9142, 9193);

                var
                result = new EncLocalInfo[slotMetadata.Length]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 9209, 9251);

                var
                localSlots = methodEncInfo.LocalSlots
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 9265, 10604) || true) && (f_10937_9269_9290_M(!localSlots.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 9265, 10604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 9464, 9529);

                    int
                    slotCount = f_10937_9480_9528(localSlots.Length, slotMetadata.Length)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 9549, 9595);

                    var
                    map = f_10937_9559_9594()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 9624, 9637);

                        for (int
        slotIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 9615, 10454) || true) && (slotIndex < slotCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 9662, 9673)
        , slotIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 9615, 10454))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 9615, 10454);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 9715, 9748);

                            var
                            slot = localSlots[slotIndex]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 9770, 10435) || true) && (f_10937_9774_9808(slot.SynthesizedKind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 9770, 10435);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 9858, 9897);

                                var
                                metadata = slotMetadata[slotIndex]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 10095, 10412) || true) && (metadata.CustomModifiers.IsDefaultOrEmpty)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 10095, 10412);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 10198, 10329);

                                    var
                                    local = f_10937_10210_10328(slot, f_10937_10253_10282(metadata.Type), metadata.Constraints, metadata.SignatureOpt)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 10359, 10385);

                                    f_10937_10359_10384(map, local, slotIndex);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 10095, 10412);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 9770, 10435);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10937, 1, 840);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10937, 1, 840);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 10474, 10589);
                        foreach (var pair in f_10937_10495_10498_I(map))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 10474, 10589);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 10540, 10570);

                            result[pair.Value] = pair.Key;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 10474, 10589);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10937, 1, 116);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10937, 1, 116);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 9265, 10604);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 10708, 10713);

                    // Populate any remaining locals that were not matched to source.
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 10699, 10929) || true) && (i < f_10937_10719_10732(result))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 10734, 10737)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 10699, 10929))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 10699, 10929);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 10771, 10914) || true) && (result[i].IsDefault)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10937, 10771, 10914);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 10836, 10895);

                            result[i] = f_10937_10848_10894(slotMetadata[i].SignatureOpt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10937, 10771, 10914);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10937, 1, 231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10937, 1, 231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10937, 10945, 10982);

                return f_10937_10952_10981(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10937, 8923, 10993);

                bool
                f_10937_9269_9290_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 9269, 9290);
                    return return_v;
                }


                int
                f_10937_9480_9528(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 9480, 9528);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncLocalInfo, int>
                f_10937_9559_9594()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncLocalInfo, int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 9559, 9594);
                    return return_v;
                }


                bool
                f_10937_9774_9808(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.IsLongLived();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 9774, 9808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                f_10937_10253_10282(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 10253, 10282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EncLocalInfo
                f_10937_10210_10328(Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                slotInfo, Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                type, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints, byte[]
                signature)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EncLocalInfo(slotInfo, (Microsoft.Cci.ITypeReference)type, constraints, signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 10210, 10328);
                    return return_v;
                }


                int
                f_10937_10359_10384(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncLocalInfo, int>
                this_param, Microsoft.CodeAnalysis.Emit.EncLocalInfo
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 10359, 10384);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncLocalInfo, int>
                f_10937_10495_10498_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncLocalInfo, int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 10495, 10498);
                    return return_v;
                }


                int
                f_10937_10719_10732(Microsoft.CodeAnalysis.Emit.EncLocalInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10937, 10719, 10732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EncLocalInfo
                f_10937_10848_10894(byte[]
                signature)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EncLocalInfo(signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 10848, 10894);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
                f_10937_10952_10981(params Microsoft.CodeAnalysis.Emit.EncLocalInfo[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 10952, 10981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10937, 8923, 10993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 8923, 10993);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpDefinitionMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10937, 884, 11000);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10937, 884, 11000);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10937, 884, 11000);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10937, 884, 11000);

        int
        f_10937_1419_1456(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 1419, 1456);
            return 0;
        }


        int
        f_10937_1471_1506(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10937, 1471, 1506);
            return 0;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
        f_10937_1388_1393_C(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10937, 1152, 1676);
            return return_v;
        }

    }
}
