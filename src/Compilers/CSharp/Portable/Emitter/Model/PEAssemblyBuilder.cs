// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal abstract class PEAssemblyBuilderBase : PEModuleBuilder, Cci.IAssemblyReference
    {
        private readonly SourceAssemblySymbol _sourceAssembly;

        private readonly ImmutableArray<NamedTypeSymbol> _additionalTypes;

        private ImmutableArray<Cci.IFileReference> _lazyFiles;

        private ImmutableArray<Cci.IFileReference> _lazyFilesWithoutManifestResources;

        private SynthesizedEmbeddedAttributeSymbol _lazyEmbeddedAttribute;

        private SynthesizedEmbeddedAttributeSymbol _lazyIsReadOnlyAttribute;

        private SynthesizedEmbeddedAttributeSymbol _lazyIsByRefLikeAttribute;

        private SynthesizedEmbeddedAttributeSymbol _lazyIsUnmanagedAttribute;

        private SynthesizedEmbeddedNullableAttributeSymbol _lazyNullableAttribute;

        private SynthesizedEmbeddedNullableContextAttributeSymbol _lazyNullableContextAttribute;

        private SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol _lazyNullablePublicOnlyAttribute;

        private SynthesizedEmbeddedNativeIntegerAttributeSymbol _lazyNativeIntegerAttribute;

        private readonly string _metadataName;

        public PEAssemblyBuilderBase(
                    SourceAssemblySymbol sourceAssembly,
                    EmitOptions emitOptions,
                    OutputKind outputKind,
                    Cci.ModulePropertiesForSerialization serializationProperties,
                    IEnumerable<ResourceDescription> manifestResources,
                    ImmutableArray<NamedTypeSymbol> additionalTypes)
        : base(f_10202_3396_3441_C((SourceModuleSymbol)f_10202_3416_3438(sourceAssembly)[0]), emitOptions, outputKind, serializationProperties, manifestResources)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10202, 3020, 3963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 777, 792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 1344, 1366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 1420, 1444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 1498, 1523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 1577, 1602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 1664, 1686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 1755, 1784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 1856, 1888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 1955, 1982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 2994, 3007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 3536, 3575);

                f_10202_3536_3574(sourceAssembly is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 3591, 3624);

                _sourceAssembly = sourceAssembly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 3638, 3687);

                _additionalTypes = additionalTypes.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 3701, 3873);

                _metadataName = (DynAbs.Tracing.TraceSender.Conditional_F1(10202, 3717, 3757) || (((f_10202_3718_3748(emitOptions) == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10202, 3760, 3787)) || DynAbs.Tracing.TraceSender.Conditional_F3(10202, 3790, 3872))) ? f_10202_3760_3787(sourceAssembly) : f_10202_3790_3872(f_10202_3824_3854(emitOptions), extension: null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 3889, 3952);

                f_10202_3889_3951(
                            AssemblyOrModuleSymbolToModuleRefMap, sourceAssembly, this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10202, 3020, 3963);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 3020, 3963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 3020, 3963);
            }
        }

        public sealed override ISourceAssemblySymbolInternal SourceAssemblyOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 4059, 4077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 4062, 4077);
                    return _sourceAssembly; DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 4059, 4077);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 4059, 4077);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 4059, 4077);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<NamedTypeSymbol> GetAdditionalTopLevelTypes(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 4212, 4231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 4215, 4231);
                return _additionalTypes; DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 4212, 4231);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 4212, 4231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 4212, 4231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<NamedTypeSymbol> GetEmbeddedTypes(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 4244, 5054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 4367, 4425);

                var
                builder = f_10202_4381_4424()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 4441, 4487);

                f_10202_4441_4486(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 4503, 4548);

                f_10202_4503_4547(
                            builder, _lazyEmbeddedAttribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 4562, 4609);

                f_10202_4562_4608(builder, _lazyIsReadOnlyAttribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 4623, 4671);

                f_10202_4623_4670(builder, _lazyIsUnmanagedAttribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 4685, 4733);

                f_10202_4685_4732(builder, _lazyIsByRefLikeAttribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 4747, 4792);

                f_10202_4747_4791(builder, _lazyNullableAttribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 4806, 4858);

                f_10202_4806_4857(builder, _lazyNullableContextAttribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 4872, 4927);

                f_10202_4872_4926(builder, _lazyNullablePublicOnlyAttribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 4941, 4991);

                f_10202_4941_4990(builder, _lazyNativeIntegerAttribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 5007, 5043);

                return f_10202_5014_5042(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 4244, 5054);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10202_4381_4424()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 4381, 4424);
                    return return_v;
                }


                int
                f_10202_4441_4486(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CreateEmbeddedAttributesIfNeeded(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 4441, 4486);
                    return 0;
                }


                int
                f_10202_4503_4547(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
                value)
                {
                    builder.AddIfNotNull<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 4503, 4547);
                    return 0;
                }


                int
                f_10202_4562_4608(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
                value)
                {
                    builder.AddIfNotNull<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 4562, 4608);
                    return 0;
                }


                int
                f_10202_4623_4670(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
                value)
                {
                    builder.AddIfNotNull<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 4623, 4670);
                    return 0;
                }


                int
                f_10202_4685_4732(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
                value)
                {
                    builder.AddIfNotNull<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 4685, 4732);
                    return 0;
                }


                int
                f_10202_4747_4791(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableAttributeSymbol
                value)
                {
                    builder.AddIfNotNull<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 4747, 4791);
                    return 0;
                }


                int
                f_10202_4806_4857(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableContextAttributeSymbol
                value)
                {
                    builder.AddIfNotNull<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 4806, 4857);
                    return 0;
                }


                int
                f_10202_4872_4926(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol
                value)
                {
                    builder.AddIfNotNull<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 4872, 4926);
                    return 0;
                }


                int
                f_10202_4941_4990(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNativeIntegerAttributeSymbol
                value)
                {
                    builder.AddIfNotNull<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 4941, 4990);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10202_5014_5042(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 5014, 5042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 4244, 5054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 4244, 5054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override IEnumerable<Cci.IFileReference> GetFiles(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 5066, 7468);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 5175, 5308) || true) && (f_10202_5179_5201_M(!context.IsRefAssembly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 5175, 5308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 5235, 5293);

                    return f_10202_5242_5292(ref _lazyFiles, context, _sourceAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 5175, 5308);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 5322, 5404);

                return f_10202_5329_5403(ref _lazyFilesWithoutManifestResources, context, _sourceAssembly);

                ImmutableArray<Cci.IFileReference> getFiles(ref ImmutableArray<Cci.IFileReference> lazyFiles, EmitContext contxt, SourceAssemblySymbol sourceAssSymbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 5443, 7457);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 5627, 7405) || true) && (lazyFiles.IsDefault)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 5627, 7405);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 5692, 5753);

                            var
                            builder = f_10202_5706_5752()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 5827, 5865);

                                var
                                modules = f_10202_5841_5864(sourceAssSymbol)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 5900, 5905);
                                    for (int
            i = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 5891, 6090) || true) && (i < modules.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 5927, 5930)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 5891, 6090))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 5891, 6090);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 5988, 6063);

                                        f_10202_5988_6062(builder, f_10202_6020_6061(this, modules[i], contxt.Diagnostics));
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10202, 1, 200);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10202, 1, 200);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 6118, 6616) || true) && (f_10202_6122_6143_M(!contxt.IsRefAssembly))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 6118, 6616);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 6279, 6589);
                                        foreach (ResourceDescription resource in f_10202_6320_6337_I(ManifestResources))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 6279, 6589);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 6403, 6558) || true) && (f_10202_6407_6427_M(!resource.IsEmbedded))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 6403, 6558);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 6501, 6523);

                                                f_10202_6501_6522(builder, resource);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 6403, 6558);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 6279, 6589);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10202, 1, 311);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10202, 1, 311);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 6118, 6616);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 6758, 7247) || true) && (f_10202_6762_6842(ref lazyFiles, f_10202_6820_6841(builder)) && (DynAbs.Tracing.TraceSender.Expression_True(10202, 6762, 6866) && lazyFiles.Length > 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 6758, 7247);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 6924, 7220) || true) && (!f_10202_6929_7006(f_10202_6976_7005(sourceAssSymbol)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 6924, 7220);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 7072, 7189);

                                        f_10202_7072_7188(contxt.Diagnostics, f_10202_7095_7187(f_10202_7112_7164(ErrorCode.ERR_CryptoHashFailed), NoLocation.Singleton));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 6924, 7220);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 6758, 7247);
                                }
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinally(10202, 7292, 7386);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 7348, 7363);

                                f_10202_7348_7362(builder);
                                DynAbs.Tracing.TraceSender.TraceExitFinally(10202, 7292, 7386);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 5627, 7405);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 7425, 7442);

                        return lazyFiles;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 5443, 7457);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IFileReference>
                        f_10202_5706_5752()
                        {
                            var return_v = ArrayBuilder<Cci.IFileReference>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 5706, 5752);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                        f_10202_5841_5864(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                        this_param)
                        {
                            var return_v = this_param.Modules;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 5841, 5864);
                            return return_v;
                        }


                        Microsoft.Cci.IModuleReference
                        f_10202_6020_6061(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        module, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = this_param.Translate(module, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 6020, 6061);
                            return return_v;
                        }


                        int
                        f_10202_5988_6062(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IFileReference>
                        this_param, Microsoft.Cci.IModuleReference
                        item)
                        {
                            this_param.Add((Microsoft.Cci.IFileReference)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 5988, 6062);
                            return 0;
                        }


                        bool
                        f_10202_6122_6143_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 6122, 6143);
                            return return_v;
                        }


                        bool
                        f_10202_6407_6427_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 6407, 6427);
                            return return_v;
                        }


                        int
                        f_10202_6501_6522(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IFileReference>
                        this_param, Microsoft.CodeAnalysis.ResourceDescription
                        item)
                        {
                            this_param.Add((Microsoft.Cci.IFileReference)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 6501, 6522);
                            return 0;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                        f_10202_6320_6337_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 6320, 6337);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IFileReference>
                        f_10202_6820_6841(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IFileReference>
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 6820, 6841);
                            return return_v;
                        }


                        bool
                        f_10202_6762_6842(ref System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IFileReference>
                        location, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IFileReference>
                        value)
                        {
                            var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 6762, 6842);
                            return return_v;
                        }


                        System.Reflection.AssemblyHashAlgorithm
                        f_10202_6976_7005(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                        this_param)
                        {
                            var return_v = this_param.HashAlgorithm;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 6976, 7005);
                            return return_v;
                        }


                        bool
                        f_10202_6929_7006(System.Reflection.AssemblyHashAlgorithm
                        algorithmId)
                        {
                            var return_v = CryptographicHashProvider.IsSupportedAlgorithm(algorithmId);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 6929, 7006);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10202_7112_7164(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 7112, 7164);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                        f_10202_7095_7187(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        info, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 7095, 7187);
                            return return_v;
                        }


                        int
                        f_10202_7072_7188(Microsoft.CodeAnalysis.DiagnosticBag
                        this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                        diag)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 7072, 7188);
                            return 0;
                        }


                        int
                        f_10202_7348_7362(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IFileReference>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 7348, 7362);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 5443, 7457);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 5443, 7457);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 5066, 7468);

                bool
                f_10202_5179_5201_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 5179, 5201);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IFileReference>
                f_10202_5242_5292(ref System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IFileReference>
                lazyFiles, Microsoft.CodeAnalysis.Emit.EmitContext
                contxt, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                sourceAssSymbol)
                {
                    var return_v = getFiles(ref lazyFiles, contxt, sourceAssSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 5242, 5292);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IFileReference>
                f_10202_5329_5403(ref System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IFileReference>
                lazyFiles, Microsoft.CodeAnalysis.Emit.EmitContext
                contxt, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                sourceAssSymbol)
                {
                    var return_v = getFiles(ref lazyFiles, contxt, sourceAssSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 5329, 5403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 5066, 7468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 5066, 7468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void AddEmbeddedResourcesFromAddedModules(ArrayBuilder<Cci.ManagedResource> builder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 7480, 8664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 7635, 7673);

                var
                modules = f_10202_7649_7672(_sourceAssembly)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 7687, 7714);

                int
                count = modules.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 7739, 7744);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 7730, 8653) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 7757, 7760)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 7730, 8653))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 7730, 8653);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 7794, 7860);

                        var
                        file = (Cci.IFileReference)f_10202_7825_7859(this, modules[i], diagnostics)
                        ;

                        try
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 7924, 8411);
                                foreach (EmbeddedResource resource in f_10202_7962_8047_I(f_10202_7962_8047(f_10202_7962_8017(((Symbols.Metadata.PE.PEModuleSymbol)modules[i])))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 7924, 8411);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 8097, 8388);

                                    f_10202_8097_8387(builder, f_10202_8109_8386(resource.Name, (resource.Attributes & ManifestResourceAttributes.Public) != 0, null, file, resource.Offset));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 7924, 8411);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10202, 1, 488);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10202, 1, 488);
                            }
                        }
                        catch (BadImageFormatException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(10202, 8448, 8638);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 8520, 8619);

                            f_10202_8520_8618(diagnostics, f_10202_8536_8595(ErrorCode.ERR_BindToBogus, modules[i]), NoLocation.Singleton);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(10202, 8448, 8638);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10202, 1, 924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10202, 1, 924);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 7480, 8664);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10202_7649_7672(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 7649, 7672);
                    return return_v;
                }


                Microsoft.Cci.IModuleReference
                f_10202_7825_7859(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                module, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(module, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 7825, 7859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10202_7962_8017(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 7962, 8017);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedResource>
                f_10202_7962_8047(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.GetEmbeddedResourcesOrThrow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 7962, 8047);
                    return return_v;
                }


                Microsoft.Cci.ManagedResource
                f_10202_8109_8386(string
                name, bool
                isPublic, System.Func<System.IO.Stream>?
                streamProvider, Microsoft.Cci.IFileReference
                fileReference, uint
                offset)
                {
                    var return_v = new Microsoft.Cci.ManagedResource(name, isPublic, streamProvider, fileReference, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 8109, 8386);
                    return return_v;
                }


                int
                f_10202_8097_8387(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ManagedResource>
                this_param, Microsoft.Cci.ManagedResource
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 8097, 8387);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedResource>
                f_10202_7962_8047_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedResource>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 7962, 8047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10202_8536_8595(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 8536, 8595);
                    return return_v;
                }


                int
                f_10202_8520_8618(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 8520, 8618);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 7480, 8664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 7480, 8664);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 8704, 8720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 8707, 8720);
                    return _metadataName; DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 8704, 8720);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 8704, 8720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 8704, 8720);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AssemblyIdentity Identity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 8764, 8791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 8767, 8791);
                    return f_10202_8767_8791(_sourceAssembly); DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 8764, 8791);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 8764, 8791);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 8764, 8791);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Version AssemblyVersionPattern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 8840, 8881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 8843, 8881);
                    return f_10202_8843_8881(_sourceAssembly); DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 8840, 8881);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 8840, 8881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 8840, 8881);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SynthesizedAttributeData SynthesizeEmbeddedAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 8894, 9318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 9083, 9307);

                return f_10202_9090_9306(f_10202_9137_9172(_lazyEmbeddedAttribute)[0], ImmutableArray<TypedConstant>.Empty, ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 8894, 9318);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10202_9137_9172(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
                this_param)
                {
                    var return_v = this_param.Constructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 9137, 9172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10202_9090_9306(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 9090, 9306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 8894, 9318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 8894, 9318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SynthesizedAttributeData SynthesizeNullableAttribute(WellKnownMember member, ImmutableArray<TypedConstant> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 9330, 10039);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 9490, 9953) || true) && ((object)_lazyNullableAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 9490, 9953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 9566, 9695);

                    var
                    constructorIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(10202, 9589, 9686) || (((member == WellKnownMember.System_Runtime_CompilerServices_NullableAttribute__ctorTransformFlags) && DynAbs.Tracing.TraceSender.Conditional_F2(10202, 9689, 9690)) || DynAbs.Tracing.TraceSender.Conditional_F3(10202, 9693, 9694))) ? 1 : 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 9713, 9938);

                    return f_10202_9720_9937(f_10202_9771_9806(_lazyNullableAttribute)[constructorIndex], arguments, ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 9490, 9953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 9969, 10028);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SynthesizeNullableAttribute(member, arguments), 10202, 9976, 10027);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 9330, 10039);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10202_9771_9806(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableAttributeSymbol
                this_param)
                {
                    var return_v = this_param.Constructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 9771, 9806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10202_9720_9937(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 9720, 9937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 9330, 10039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 9330, 10039);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SynthesizedAttributeData SynthesizeNullableContextAttribute(ImmutableArray<TypedConstant> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 10051, 10594);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 10194, 10509) || true) && ((object)_lazyNullableContextAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 10194, 10509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 10277, 10494);

                    return f_10202_10284_10493(f_10202_10335_10377(_lazyNullableContextAttribute)[0], arguments, ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 10194, 10509);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 10525, 10583);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SynthesizeNullableContextAttribute(arguments), 10202, 10532, 10582);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 10051, 10594);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10202_10335_10377(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableContextAttributeSymbol
                this_param)
                {
                    var return_v = this_param.Constructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 10335, 10377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10202_10284_10493(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 10284, 10493);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 10051, 10594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 10051, 10594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SynthesizedAttributeData SynthesizeNullablePublicOnlyAttribute(ImmutableArray<TypedConstant> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 10606, 11161);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 10752, 11073) || true) && ((object)_lazyNullablePublicOnlyAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 10752, 11073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 10838, 11058);

                    return f_10202_10845_11057(f_10202_10896_10941(_lazyNullablePublicOnlyAttribute)[0], arguments, ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 10752, 11073);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 11089, 11150);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SynthesizeNullablePublicOnlyAttribute(arguments), 10202, 11096, 11149);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 10606, 11161);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10202_10896_10941(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol
                this_param)
                {
                    var return_v = this_param.Constructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 10896, 10941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10202_10845_11057(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 10845, 11057);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 10606, 11161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 10606, 11161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SynthesizedAttributeData SynthesizeNativeIntegerAttribute(WellKnownMember member, ImmutableArray<TypedConstant> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 11173, 11907);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 11338, 11816) || true) && ((object)_lazyNativeIntegerAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 11338, 11816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 11419, 11553);

                    var
                    constructorIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(10202, 11442, 11544) || (((member == WellKnownMember.System_Runtime_CompilerServices_NativeIntegerAttribute__ctorTransformFlags) && DynAbs.Tracing.TraceSender.Conditional_F2(10202, 11547, 11548)) || DynAbs.Tracing.TraceSender.Conditional_F3(10202, 11551, 11552))) ? 1 : 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 11571, 11801);

                    return f_10202_11578_11800(f_10202_11629_11669(_lazyNativeIntegerAttribute)[constructorIndex], arguments, ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 11338, 11816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 11832, 11896);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SynthesizeNativeIntegerAttribute(member, arguments), 10202, 11839, 11895);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 11173, 11907);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10202_11629_11669(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNativeIntegerAttributeSymbol
                this_param)
                {
                    var return_v = this_param.Constructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 11629, 11669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10202_11578_11800(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 11578, 11800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 11173, 11907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 11173, 11907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SynthesizedAttributeData TrySynthesizeIsReadOnlyAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 11919, 12427);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 12022, 12353) || true) && ((object)_lazyIsReadOnlyAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 12022, 12353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 12100, 12338);

                    return f_10202_12107_12337(f_10202_12158_12195(_lazyIsReadOnlyAttribute)[0], ImmutableArray<TypedConstant>.Empty, ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 12022, 12353);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 12369, 12416);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.TrySynthesizeIsReadOnlyAttribute(), 10202, 12376, 12415);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 11919, 12427);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10202_12158_12195(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
                this_param)
                {
                    var return_v = this_param.Constructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 12158, 12195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10202_12107_12337(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 12107, 12337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 11919, 12427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 11919, 12427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SynthesizedAttributeData TrySynthesizeIsUnmanagedAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 12439, 12951);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 12543, 12876) || true) && ((object)_lazyIsUnmanagedAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 12543, 12876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 12622, 12861);

                    return f_10202_12629_12860(f_10202_12680_12718(_lazyIsUnmanagedAttribute)[0], ImmutableArray<TypedConstant>.Empty, ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 12543, 12876);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 12892, 12940);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.TrySynthesizeIsUnmanagedAttribute(), 10202, 12899, 12939);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 12439, 12951);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10202_12680_12718(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
                this_param)
                {
                    var return_v = this_param.Constructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 12680, 12718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10202_12629_12860(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 12629, 12860);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 12439, 12951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 12439, 12951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SynthesizedAttributeData TrySynthesizeIsByRefLikeAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 12963, 13475);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 13067, 13400) || true) && ((object)_lazyIsByRefLikeAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 13067, 13400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 13146, 13385);

                    return f_10202_13153_13384(f_10202_13204_13242(_lazyIsByRefLikeAttribute)[0], ImmutableArray<TypedConstant>.Empty, ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 13067, 13400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 13416, 13464);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.TrySynthesizeIsByRefLikeAttribute(), 10202, 13423, 13463);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 12963, 13475);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10202_13204_13242(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
                this_param)
                {
                    var return_v = this_param.Constructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 13204, 13242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10202_13153_13384(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 13153, 13384);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 12963, 13475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 12963, 13475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CreateEmbeddedAttributesIfNeeded(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 13487, 17144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 13584, 13653);

                EmbeddableAttributes
                needsAttributes = f_10202_13623_13652(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 13669, 14071) || true) && (f_10202_13673_13712(this) && (DynAbs.Tracing.TraceSender.Expression_True(10202, 13673, 13855) && f_10202_13733_13855(Compilation, EmbeddableAttributes.NullablePublicOnlyAttribute, diagnostics, f_10202_13841_13854())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 13669, 14071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 13889, 13957);

                    needsAttributes |= EmbeddableAttributes.NullablePublicOnlyAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 13669, 14071);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 13669, 14071);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 13991, 14071) || true) && (needsAttributes == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 13991, 14071);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 14049, 14056);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 13991, 14071);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 13669, 14071);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 14087, 14265);

                var
                createParameterlessEmbeddedAttributeSymbol = new Func<string, NamespaceSymbol, DiagnosticBag, SynthesizedEmbeddedAttributeSymbol>(CreateParameterlessEmbeddedAttributeSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 14281, 14511);

                f_10202_14281_14510(this, ref _lazyEmbeddedAttribute, diagnostics, AttributeDescription.CodeAnalysisEmbeddedAttribute, createParameterlessEmbeddedAttributeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 14527, 14883) || true) && ((needsAttributes & EmbeddableAttributes.IsReadOnlyAttribute) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 14527, 14883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 14630, 14868);

                    f_10202_14630_14867(this, ref _lazyIsReadOnlyAttribute, diagnostics, AttributeDescription.IsReadOnlyAttribute, createParameterlessEmbeddedAttributeSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 14527, 14883);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 14899, 15258) || true) && ((needsAttributes & EmbeddableAttributes.IsByRefLikeAttribute) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 14899, 15258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 15003, 15243);

                    f_10202_15003_15242(this, ref _lazyIsByRefLikeAttribute, diagnostics, AttributeDescription.IsByRefLikeAttribute, createParameterlessEmbeddedAttributeSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 14899, 15258);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 15274, 15633) || true) && ((needsAttributes & EmbeddableAttributes.IsUnmanagedAttribute) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 15274, 15633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 15378, 15618);

                    f_10202_15378_15617(this, ref _lazyIsUnmanagedAttribute, diagnostics, AttributeDescription.IsUnmanagedAttribute, createParameterlessEmbeddedAttributeSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 15274, 15633);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 15649, 15986) || true) && ((needsAttributes & EmbeddableAttributes.NullableAttribute) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 15649, 15986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 15750, 15971);

                    f_10202_15750_15970(this, ref _lazyNullableAttribute, diagnostics, AttributeDescription.NullableAttribute, CreateNullableAttributeSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 15649, 15986);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 16002, 16367) || true) && ((needsAttributes & EmbeddableAttributes.NullableContextAttribute) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 16002, 16367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 16110, 16352);

                    f_10202_16110_16351(this, ref _lazyNullableContextAttribute, diagnostics, AttributeDescription.NullableContextAttribute, CreateNullableContextAttributeSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 16002, 16367);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 16383, 16760) || true) && ((needsAttributes & EmbeddableAttributes.NullablePublicOnlyAttribute) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 16383, 16760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 16494, 16745);

                    f_10202_16494_16744(this, ref _lazyNullablePublicOnlyAttribute, diagnostics, AttributeDescription.NullablePublicOnlyAttribute, CreateNullablePublicOnlyAttributeSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 16383, 16760);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 16776, 17133) || true) && ((needsAttributes & EmbeddableAttributes.NativeIntegerAttribute) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 16776, 17133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 16882, 17118);

                    f_10202_16882_17117(this, ref _lazyNativeIntegerAttribute, diagnostics, AttributeDescription.NativeIntegerAttribute, CreateNativeIntegerAttributeSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 16776, 17133);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 13487, 17144);

                Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                f_10202_13623_13652(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param)
                {
                    var return_v = this_param.GetNeedsGeneratedAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 13623, 13652);
                    return return_v;
                }


                bool
                f_10202_13673_13712(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param)
                {
                    var return_v = this_param.ShouldEmitNullablePublicOnlyAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 13673, 13712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10202_13841_13854()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 13841, 13854);
                    return return_v;
                }


                bool
                f_10202_13733_13855(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt, Microsoft.CodeAnalysis.Location
                locationOpt)
                {
                    var return_v = this_param.CheckIfAttributeShouldBeEmbedded(attribute, diagnosticsOpt, locationOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 13733, 13855);
                    return return_v;
                }


                int
                f_10202_14281_14510(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, ref Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.AttributeDescription
                description, System.Func<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol>
                factory)
                {
                    this_param.CreateAttributeIfNeeded<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol>(ref symbol, diagnostics, description, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 14281, 14510);
                    return 0;
                }


                int
                f_10202_14630_14867(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, ref Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.AttributeDescription
                description, System.Func<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol>
                factory)
                {
                    this_param.CreateAttributeIfNeeded<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol>(ref symbol, diagnostics, description, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 14630, 14867);
                    return 0;
                }


                int
                f_10202_15003_15242(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, ref Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.AttributeDescription
                description, System.Func<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol>
                factory)
                {
                    this_param.CreateAttributeIfNeeded<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol>(ref symbol, diagnostics, description, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 15003, 15242);
                    return 0;
                }


                int
                f_10202_15378_15617(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, ref Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.AttributeDescription
                description, System.Func<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol>
                factory)
                {
                    this_param.CreateAttributeIfNeeded<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol>(ref symbol, diagnostics, description, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 15378, 15617);
                    return 0;
                }


                int
                f_10202_15750_15970(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, ref Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableAttributeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.AttributeDescription
                description, System.Func<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableAttributeSymbol>
                factory)
                {
                    this_param.CreateAttributeIfNeeded<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableAttributeSymbol>(ref symbol, diagnostics, description, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 15750, 15970);
                    return 0;
                }


                int
                f_10202_16110_16351(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, ref Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableContextAttributeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.AttributeDescription
                description, System.Func<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableContextAttributeSymbol>
                factory)
                {
                    this_param.CreateAttributeIfNeeded<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableContextAttributeSymbol>(ref symbol, diagnostics, description, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 16110, 16351);
                    return 0;
                }


                int
                f_10202_16494_16744(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, ref Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.AttributeDescription
                description, System.Func<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol>
                factory)
                {
                    this_param.CreateAttributeIfNeeded<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol>(ref symbol, diagnostics, description, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 16494, 16744);
                    return 0;
                }


                int
                f_10202_16882_17117(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, ref Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNativeIntegerAttributeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.AttributeDescription
                description, System.Func<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNativeIntegerAttributeSymbol>
                factory)
                {
                    this_param.CreateAttributeIfNeeded<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNativeIntegerAttributeSymbol>(ref symbol, diagnostics, description, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 16882, 17117);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 13487, 17144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 13487, 17144);
            }
        }

        private SynthesizedEmbeddedAttributeSymbol CreateParameterlessEmbeddedAttributeSymbol(string name, NamespaceSymbol containingNamespace, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 17332, 17572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 17335, 17572);
                return f_10202_17335_17572(name, containingNamespace, SourceModule, baseType: f_10202_17510_17571(this, WellKnownType.System_Attribute, diagnostics)); DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 17332, 17572);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 17332, 17572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 17332, 17572);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10202_17510_17571(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
            this_param, Microsoft.CodeAnalysis.WellKnownType
            type, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = this_param.GetWellKnownType(type, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 17510, 17571);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
            f_10202_17335_17572(string
            name, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
            containingNamespace, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
            containingModule, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            baseType)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol(name, containingNamespace, (Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)containingModule, baseType: baseType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 17335, 17572);
                return return_v;
            }

        }

        private SynthesizedEmbeddedNullableAttributeSymbol CreateNullableAttributeSymbol(string name, NamespaceSymbol containingNamespace, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 17756, 18069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 17759, 18069);
                return f_10202_17759_18069(name, containingNamespace, SourceModule, f_10202_17932_17993(this, WellKnownType.System_Attribute, diagnostics), f_10202_18016_18068(this, SpecialType.System_Byte, diagnostics)); DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 17756, 18069);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 17756, 18069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 17756, 18069);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10202_17932_17993(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
            this_param, Microsoft.CodeAnalysis.WellKnownType
            type, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = this_param.GetWellKnownType(type, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 17932, 17993);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10202_18016_18068(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
            this_param, Microsoft.CodeAnalysis.SpecialType
            type, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = this_param.GetSpecialType(type, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 18016, 18068);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableAttributeSymbol
            f_10202_17759_18069(string
            name, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
            containingNamespace, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
            containingModule, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            systemAttributeType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            systemByteType)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableAttributeSymbol(name, containingNamespace, (Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)containingModule, systemAttributeType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)systemByteType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 17759, 18069);
                return return_v;
            }

        }

        private SynthesizedEmbeddedNullableContextAttributeSymbol CreateNullableContextAttributeSymbol(string name, NamespaceSymbol containingNamespace, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 18267, 18587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 18270, 18587);
                return f_10202_18270_18587(name, containingNamespace, SourceModule, f_10202_18450_18511(this, WellKnownType.System_Attribute, diagnostics), f_10202_18534_18586(this, SpecialType.System_Byte, diagnostics)); DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 18267, 18587);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 18267, 18587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 18267, 18587);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10202_18450_18511(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
            this_param, Microsoft.CodeAnalysis.WellKnownType
            type, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = this_param.GetWellKnownType(type, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 18450, 18511);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10202_18534_18586(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
            this_param, Microsoft.CodeAnalysis.SpecialType
            type, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = this_param.GetSpecialType(type, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 18534, 18586);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableContextAttributeSymbol
            f_10202_18270_18587(string
            name, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
            containingNamespace, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
            containingModule, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            systemAttributeType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            systemByteType)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableContextAttributeSymbol(name, containingNamespace, (Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)containingModule, systemAttributeType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)systemByteType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 18270, 18587);
                return return_v;
            }

        }

        private SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol CreateNullablePublicOnlyAttributeSymbol(string name, NamespaceSymbol containingNamespace, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 18791, 19117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 18794, 19117);
                return f_10202_18794_19117(name, containingNamespace, SourceModule, f_10202_18977_19038(this, WellKnownType.System_Attribute, diagnostics), f_10202_19061_19116(this, SpecialType.System_Boolean, diagnostics)); DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 18791, 19117);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 18791, 19117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 18791, 19117);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10202_18977_19038(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
            this_param, Microsoft.CodeAnalysis.WellKnownType
            type, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = this_param.GetWellKnownType(type, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 18977, 19038);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10202_19061_19116(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
            this_param, Microsoft.CodeAnalysis.SpecialType
            type, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = this_param.GetSpecialType(type, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 19061, 19116);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol
            f_10202_18794_19117(string
            name, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
            containingNamespace, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
            containingModule, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            systemAttributeType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            systemBooleanType)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol(name, containingNamespace, (Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)containingModule, systemAttributeType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)systemBooleanType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 18794, 19117);
                return return_v;
            }

        }

        private SynthesizedEmbeddedNativeIntegerAttributeSymbol CreateNativeIntegerAttributeSymbol(string name, NamespaceSymbol containingNamespace, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 19311, 19632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 19314, 19632);
                return f_10202_19314_19632(name, containingNamespace, SourceModule, f_10202_19492_19553(this, WellKnownType.System_Attribute, diagnostics), f_10202_19576_19631(this, SpecialType.System_Boolean, diagnostics)); DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 19311, 19632);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 19311, 19632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 19311, 19632);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10202_19492_19553(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
            this_param, Microsoft.CodeAnalysis.WellKnownType
            type, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = this_param.GetWellKnownType(type, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 19492, 19553);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10202_19576_19631(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
            this_param, Microsoft.CodeAnalysis.SpecialType
            type, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = this_param.GetSpecialType(type, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 19576, 19631);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNativeIntegerAttributeSymbol
            f_10202_19314_19632(string
            name, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
            containingNamespace, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
            containingModule, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            systemAttributeType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            boolType)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNativeIntegerAttributeSymbol(name, containingNamespace, (Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)containingModule, systemAttributeType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)boolType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 19314, 19632);
                return return_v;
            }

        }

        private void CreateAttributeIfNeeded<T>(
                    ref T symbol,
                    DiagnosticBag diagnostics,
                    AttributeDescription description,
                    Func<string, NamespaceSymbol, DiagnosticBag, T> factory)
                    where T : SynthesizedEmbeddedAttributeSymbolBase
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 19645, 20648);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 19956, 20637) || true) && (symbol is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 19956, 20637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 20008, 20069);

                    f_10202_20008_20068<T>(this, description, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 20089, 20163);

                    var
                    containingNamespace = f_10202_20115_20162<T>(this, description.Namespace)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 20183, 20252);

                    symbol = f_10202_20192_20251<T>(factory, description.Name, containingNamespace, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 20270, 20344);

                    f_10202_20270_20343<T>(symbol.Constructors.Length == f_10202_20313_20342<T>(description.Signatures));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 20364, 20548) || true) && (f_10202_20368_20398<T>(symbol) != AttributeUsageInfo.Default)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 20364, 20548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 20470, 20529);

                        f_10202_20470_20528<T>(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 20364, 20548);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 20568, 20622);

                    f_10202_20568_20621<T>(this, containingNamespace, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 19956, 20637);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 19645, 20648);

                int
                f_10202_20008_20068<T>(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                description, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics) where T : SynthesizedEmbeddedAttributeSymbolBase

                {
                    this_param.AddDiagnosticsForExistingAttribute(description, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 20008, 20068);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10202_20115_20162<T>(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, string
                namespaceFullName) where T : SynthesizedEmbeddedAttributeSymbolBase

                {
                    var return_v = this_param.GetOrSynthesizeNamespace(namespaceFullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 20115, 20162);
                    return return_v;
                }


                T
                f_10202_20192_20251<T>(System.Func<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.DiagnosticBag, T>
                this_param, string
                arg1, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                arg2, Microsoft.CodeAnalysis.DiagnosticBag
                arg3) where T : SynthesizedEmbeddedAttributeSymbolBase

                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 20192, 20251);
                    return return_v;
                }


                int
                f_10202_20313_20342<T>(byte[][]
                this_param) where T : SynthesizedEmbeddedAttributeSymbolBase

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 20313, 20342);
                    return return_v;
                }


                int
                f_10202_20270_20343<T>(bool
                condition) where T : SynthesizedEmbeddedAttributeSymbolBase

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 20270, 20343);
                    return 0;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10202_20368_20398<T>(T
                this_param) where T : SynthesizedEmbeddedAttributeSymbolBase

                {
                    var return_v = this_param.GetAttributeUsageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 20368, 20398);
                    return return_v;
                }


                int
                f_10202_20470_20528<T>(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics) where T : SynthesizedEmbeddedAttributeSymbolBase

                {
                    this_param.EnsureAttributeUsageAttributeMembersAvailable(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 20470, 20528);
                    return 0;
                }


                int
                f_10202_20568_20621<T>(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                container, T
                typeOrNamespace) where T : SynthesizedEmbeddedAttributeSymbolBase

                {
                    this_param.AddSynthesizedDefinition((Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal)container, (Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal)typeOrNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 20568, 20621);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 19645, 20648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 19645, 20648);
            }
        }

        private void AddDiagnosticsForExistingAttribute(AttributeDescription description, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 20660, 21336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 20793, 20873);

                var
                attributeMetadataName = MetadataTypeName.FromFullName(description.FullName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 20887, 20997);

                var
                userDefinedAttribute = f_10202_20914_20996(f_10202_20914_20942(_sourceAssembly), ref attributeMetadataName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 21011, 21103);

                f_10202_21011_21102((object)f_10202_21032_21069(userDefinedAttribute) == f_10202_21073_21101(_sourceAssembly));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 21119, 21325) || true) && (!(userDefinedAttribute is MissingMetadataTypeSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 21119, 21325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 21209, 21310);

                    f_10202_21209_21309(diagnostics, ErrorCode.ERR_TypeReserved, f_10202_21253_21283(userDefinedAttribute)[0], description.FullName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 21119, 21325);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 20660, 21336);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                f_10202_20914_20942(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 20914, 20942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10202_20914_20996(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 20914, 20996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10202_21032_21069(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 21032, 21069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                f_10202_21073_21101(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 21073, 21101);
                    return return_v;
                }


                int
                f_10202_21011_21102(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 21011, 21102);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10202_21253_21283(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 21253, 21283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10202_21209_21309(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 21209, 21309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 20660, 21336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 20660, 21336);
            }
        }

        private NamespaceSymbol GetOrSynthesizeNamespace(string namespaceFullName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 21348, 22042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 21447, 21489);

                var
                result = f_10202_21460_21488(SourceModule)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 21505, 22001);
                    foreach (var partName in f_10202_21530_21558_I(f_10202_21530_21558(namespaceFullName, '.')))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 21505, 22001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 21592, 21708);

                        var
                        subnamespace = (NamespaceSymbol)f_10202_21628_21655(result, partName).FirstOrDefault(m => m.Kind == SymbolKind.Namespace)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 21726, 21944) || true) && (subnamespace == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10202, 21726, 21944);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 21792, 21856);

                            subnamespace = f_10202_21807_21855(result, partName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 21878, 21925);

                            f_10202_21878_21924(this, result, subnamespace);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 21726, 21944);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 21964, 21986);

                        result = subnamespace;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10202, 21505, 22001);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10202, 1, 497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10202, 1, 497);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 22017, 22031);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 21348, 22042);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10202_21460_21488(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 21460, 21488);
                    return return_v;
                }


                string[]
                f_10202_21530_21558(string
                this_param, char
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 21530, 21558);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10202_21628_21655(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 21628, 21655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedNamespaceSymbol
                f_10202_21807_21855(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                containingNamespace, string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedNamespaceSymbol(containingNamespace, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 21807, 21855);
                    return return_v;
                }


                int
                f_10202_21878_21924(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                typeOrNamespace)
                {
                    this_param.AddSynthesizedDefinition((Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal)container, (Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal)typeOrNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 21878, 21924);
                    return 0;
                }


                string[]
                f_10202_21530_21558_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 21530, 21558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 21348, 22042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 21348, 22042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol GetWellKnownType(WellKnownType type, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 22054, 22360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 22166, 22239);

                var
                result = f_10202_22179_22238(f_10202_22179_22215(_sourceAssembly), type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 22253, 22321);

                f_10202_22253_22320(result, diagnostics, f_10202_22306_22319());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 22335, 22349);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 22054, 22360);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10202_22179_22215(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 22179, 22215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10202_22179_22238(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 22179, 22238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10202_22306_22319()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 22306, 22319);
                    return return_v;
                }


                bool
                f_10202_22253_22320(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 22253, 22320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 22054, 22360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 22054, 22360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol GetSpecialType(SpecialType type, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 22372, 22672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 22480, 22551);

                var
                result = f_10202_22493_22550(f_10202_22493_22529(_sourceAssembly), type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 22565, 22633);

                f_10202_22565_22632(result, diagnostics, f_10202_22618_22631());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 22647, 22661);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 22372, 22672);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10202_22493_22529(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 22493, 22529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10202_22493_22550(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 22493, 22550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10202_22618_22631()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 22618, 22631);
                    return return_v;
                }


                bool
                f_10202_22565_22632(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 22565, 22632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 22372, 22672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 22372, 22672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EnsureAttributeUsageAttributeMembersAvailable(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 22684, 23291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 22794, 22849);

                var
                compilation = f_10202_22812_22848(_sourceAssembly)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 22863, 22988);

                f_10202_22863_22987(compilation, WellKnownMember.System_AttributeUsageAttribute__ctor, diagnostics, f_10202_22973_22986());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 23002, 23136);

                f_10202_23002_23135(compilation, WellKnownMember.System_AttributeUsageAttribute__AllowMultiple, diagnostics, f_10202_23121_23134());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 23150, 23280);

                f_10202_23150_23279(compilation, WellKnownMember.System_AttributeUsageAttribute__Inherited, diagnostics, f_10202_23265_23278());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 22684, 23291);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10202_22812_22848(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 22812, 22848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10202_22973_22986()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 22973, 22986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10202_22863_22987(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 22863, 22987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10202_23121_23134()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 23121, 23134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10202_23002_23135(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 23002, 23135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10202_23265_23278()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 23265, 23278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10202_23150_23279(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 23150, 23279);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 22684, 23291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 22684, 23291);
            }
        }

        static PEAssemblyBuilderBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10202, 635, 23298);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10202, 635, 23298);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 635, 23298);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10202, 635, 23298);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
        f_10202_3416_3438(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        this_param)
        {
            var return_v = this_param.Modules;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 3416, 3438);
            return return_v;
        }


        int
        f_10202_3536_3574(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 3536, 3574);
            return 0;
        }


        string?
        f_10202_3718_3748(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.OutputNameOverride;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 3718, 3748);
            return return_v;
        }


        string
        f_10202_3760_3787(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        this_param)
        {
            var return_v = this_param.MetadataName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 3760, 3787);
            return return_v;
        }


        string
        f_10202_3824_3854(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.OutputNameOverride;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 3824, 3854);
            return return_v;
        }


        string?
        f_10202_3790_3872(string
        path, string?
        extension)
        {
            var return_v = FileNameUtilities.ChangeExtension(path, extension: extension);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 3790, 3872);
            return return_v;
        }


        int
        f_10202_3889_3951(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>
        dict, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        key, Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilderBase
        value)
        {
            dict.Add<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.Cci.IModuleReference)value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10202, 3889, 3951);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
        f_10202_3396_3441_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10202, 3020, 3963);
            return return_v;
        }


        Microsoft.CodeAnalysis.AssemblyIdentity
        f_10202_8767_8791(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        this_param)
        {
            var return_v = this_param.Identity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 8767, 8791);
            return return_v;
        }


        System.Version
        f_10202_8843_8881(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        this_param)
        {
            var return_v = this_param.AssemblyVersionPattern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10202, 8843, 8881);
            return return_v;
        }

    }
    internal sealed class PEAssemblyBuilder : PEAssemblyBuilderBase
    {
        public PEAssemblyBuilder(
                    SourceAssemblySymbol sourceAssembly,
                    EmitOptions emitOptions,
                    OutputKind outputKind,
                    Cci.ModulePropertiesForSerialization serializationProperties,
                    IEnumerable<ResourceDescription> manifestResources)
        : base(f_10202_23696_23710_C(sourceAssembly), emitOptions, outputKind, serializationProperties, manifestResources, ImmutableArray<NamedTypeSymbol>.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10202, 23386, 23841);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10202, 23386, 23841);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 23386, 23841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 23386, 23841);
            }
        }

        public override int CurrentGenerationOrdinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10202, 23898, 23902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10202, 23901, 23902);
                    return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10202, 23898, 23902);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10202, 23898, 23902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 23898, 23902);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PEAssemblyBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10202, 23306, 23910);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10202, 23306, 23910);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10202, 23306, 23910);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10202, 23306, 23910);

        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        f_10202_23696_23710_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10202, 23386, 23841);
            return return_v;
        }

    }
}
