// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal sealed class PEModuleSymbol : NonMissingModuleSymbol
    {
        private readonly AssemblySymbol _assemblySymbol;

        private readonly int _ordinal;

        private readonly PEModule _module;

        private readonly PENamespaceSymbol _globalNamespace;

        private NamedTypeSymbol _lazySystemTypeSymbol;

        private NamedTypeSymbol _lazyEventRegistrationTokenSymbol;

        private NamedTypeSymbol _lazyEventRegistrationTokenTableSymbol;

        private const int
        DefaultTypeMapCapacity = 31
        ;

        internal readonly ConcurrentDictionary<TypeDefinitionHandle, TypeSymbol> TypeHandleToTypeMap;

        internal readonly ConcurrentDictionary<TypeReferenceHandle, TypeSymbol> TypeRefHandleToTypeMap;

        internal readonly ImmutableArray<MetadataLocation> MetadataLocation;

        internal readonly MetadataImportOptions ImportOptions;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        private ImmutableArray<CSharpAttributeData> _lazyAssemblyAttributes;

        private ICollection<string> _lazyTypeNames;

        private ICollection<string> _lazyNamespaceNames;

        private enum NullableMemberMetadata
        {
            Unknown = 0,
            Public,
            Internal,
            All,
        }

        private NullableMemberMetadata _lazyNullableMemberMetadata;

        internal PEModuleSymbol(PEAssemblySymbol assemblySymbol, PEModule module, MetadataImportOptions importOptions, int ordinal)
        : this(f_10708_4336_4366_C((AssemblySymbol)assemblySymbol), module, importOptions, ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10708, 4192, 4462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 4424, 4451);

                f_10708_4424_4450(ordinal >= 0);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10708, 4192, 4462);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 4192, 4462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 4192, 4462);
            }
        }

        internal PEModuleSymbol(SourceAssemblySymbol assemblySymbol, PEModule module, MetadataImportOptions importOptions, int ordinal)
        : this(f_10708_4622_4652_C((AssemblySymbol)assemblySymbol), module, importOptions, ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10708, 4474, 4747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 4710, 4736);

                f_10708_4710_4735(ordinal > 0);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10708, 4474, 4747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 4474, 4747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 4474, 4747);
            }
        }

        internal PEModuleSymbol(RetargetingAssemblySymbol assemblySymbol, PEModule module, MetadataImportOptions importOptions, int ordinal)
        : this(f_10708_4912_4942_C((AssemblySymbol)assemblySymbol), module, importOptions, ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10708, 4759, 5037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 5000, 5026);

                f_10708_5000_5025(ordinal > 0);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10708, 4759, 5037);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 4759, 5037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 4759, 5037);
            }
        }

        private PEModuleSymbol(AssemblySymbol assemblySymbol, PEModule module, MetadataImportOptions importOptions, int ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10708, 5049, 5630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 1132, 1147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 1179, 1187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 1322, 1329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 1455, 1471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 1677, 1698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 1733, 1766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 1801, 1839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 2455, 2627);
                this.TypeHandleToTypeMap = f_10708_2514_2627(concurrencyLevel: 2, capacity: DefaultTypeMapCapacity); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 3107, 3281);
                this.TypeRefHandleToTypeMap = f_10708_3169_3281(concurrencyLevel: 2, capacity: DefaultTypeMapCapacity); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 3414, 3427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 3837, 3851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 3932, 3951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 4152, 4179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 5194, 5239);

                f_10708_5194_5238((object)assemblySymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 5253, 5282);

                f_10708_5253_5281(module != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 5298, 5331);

                _assemblySymbol = assemblySymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 5345, 5364);

                _ordinal = ordinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 5378, 5395);

                _module = module;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 5409, 5444);

                this.ImportOptions = importOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 5458, 5511);

                _globalNamespace = f_10708_5477_5510(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 5527, 5619);

                this.MetadataLocation = f_10708_5551_5618(f_10708_5591_5617(this));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10708, 5049, 5630);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 5049, 5630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 5049, 5630);
            }
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 5710, 5798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 5746, 5783);

                    throw f_10708_5752_5782();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 5710, 5798);

                    System.Exception
                    f_10708_5752_5782()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 5752, 5782);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 5642, 5809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 5642, 5809);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 5875, 5942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 5911, 5927);

                    return _ordinal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 5875, 5942);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 5821, 5953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 5821, 5953);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Machine Machine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 6023, 6097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 6059, 6082);

                    return f_10708_6066_6081(_module);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 6023, 6097);

                    System.Reflection.PortableExecutable.Machine
                    f_10708_6066_6081(Microsoft.CodeAnalysis.PEModule
                    this_param)
                    {
                        var return_v = this_param.Machine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 6066, 6081);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 5965, 6108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 5965, 6108);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool Bit32Required
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 6181, 6261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 6217, 6246);

                    return f_10708_6224_6245(_module);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 6181, 6261);

                    bool
                    f_10708_6224_6245(Microsoft.CodeAnalysis.PEModule
                    this_param)
                    {
                        var return_v = this_param.Bit32Required;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 6224, 6245);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 6120, 6272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 6120, 6272);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PEModule Module
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 6333, 6399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 6369, 6384);

                    return _module;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 6333, 6399);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 6284, 6410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 6284, 6410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamespaceSymbol GlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 6494, 6526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 6500, 6524);

                    return _globalNamespace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 6494, 6526);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 6422, 6537);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 6422, 6537);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 6601, 6672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 6637, 6657);

                    return f_10708_6644_6656(_module);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 6601, 6672);

                    string
                    f_10708_6644_6656(Microsoft.CodeAnalysis.PEModule
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 6644, 6656);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 6549, 6683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 6549, 6683);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static EntityHandle Token
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10708, 6753, 6841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 6789, 6826);

                    return EntityHandle.ModuleDefinition;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10708, 6753, 6841);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 6695, 6852);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 6695, 6852);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 6928, 7002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 6964, 6987);

                    return _assemblySymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 6928, 7002);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 6864, 7013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 6864, 7013);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 7099, 7173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 7135, 7158);

                    return _assemblySymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 7099, 7173);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 7025, 7184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 7025, 7184);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 7271, 7386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 7307, 7371);

                    return this.MetadataLocation.Cast<MetadataLocation, Location>();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 7271, 7386);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 7196, 7397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 7196, 7397);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 7409, 7699);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 7501, 7645) || true) && (_lazyCustomAttributes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 7501, 7645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 7570, 7630);

                    f_10708_7570_7629(this, f_10708_7596_7601(), ref _lazyCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 7501, 7645);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 7659, 7688);

                return _lazyCustomAttributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 7409, 7699);

                System.Reflection.Metadata.EntityHandle
                f_10708_7596_7601()
                {
                    var return_v = Token;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 7596, 7601);
                    return return_v;
                }


                int
                f_10708_7570_7629(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.EntityHandle
                token, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                customAttributes)
                {
                    this_param.LoadCustomAttributes(token, ref customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 7570, 7629);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 7409, 7699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 7409, 7699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<CSharpAttributeData> GetAssemblyAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 7711, 10078);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 7804, 10022) || true) && (_lazyAssemblyAttributes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 7804, 10022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 7875, 7948);

                    ArrayBuilder<CSharpAttributeData>
                    moduleAssemblyAttributesBuilder = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 7968, 8023);

                    string
                    corlibName = f_10708_7988_8022(f_10708_7988_8017(f_10708_7988_8006()))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 8041, 8107);

                    EntityHandle
                    assemblyMSCorLib = f_10708_8073_8106(f_10708_8073_8079(), corlibName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 8125, 9658) || true) && (f_10708_8129_8152_M(!assemblyMSCorLib.IsNil))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 8125, 9658);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 8194, 9639);
                            foreach (var qualifier in f_10708_8220_8276_I(Cci.MetadataWriter.dummyAssemblyAttributeParentQualifier))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 8194, 9639);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 8326, 8693);

                                EntityHandle
                                typerefAssemblyAttributesGoHere =
                                f_10708_8410_8692(f_10708_8410_8416(), assemblyMSCorLib, Cci.MetadataWriter.dummyAssemblyAttributeParentNamespace, Cci.MetadataWriter.dummyAssemblyAttributeParentName + qualifier)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 8721, 9616) || true) && (f_10708_8725_8763_M(!typerefAssemblyAttributesGoHere.IsNil))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 8721, 9616);
                                    try
                                    {
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 8889, 9464);
                                            foreach (var customAttributeHandle in f_10708_8927_8993_I(f_10708_8927_8993(f_10708_8927_8933(), typerefAssemblyAttributesGoHere)))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 8889, 9464);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 9067, 9305) || true) && (moduleAssemblyAttributesBuilder == null)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 9067, 9305);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 9192, 9266);

                                                    moduleAssemblyAttributesBuilder = f_10708_9226_9265();
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 9067, 9305);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 9343, 9429);

                                                f_10708_9343_9428(moduleAssemblyAttributesBuilder, f_10708_9379_9427(this, customAttributeHandle));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 8889, 9464);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10708, 1, 576);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10708, 1, 576);
                                        }
                                    }
                                    catch (BadImageFormatException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10708, 9525, 9589);
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(10708, 9525, 9589);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 8721, 9616);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 8194, 9639);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10708, 1, 1446);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10708, 1, 1446);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 8125, 9658);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 9678, 10007);

                    f_10708_9678_10006(ref _lazyAssemblyAttributes, (DynAbs.Tracing.TraceSender.Conditional_F1(10708, 9798, 9839) || (((moduleAssemblyAttributesBuilder != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10708, 9842, 9894)) || DynAbs.Tracing.TraceSender.Conditional_F3(10708, 9897, 9938))) ? f_10708_9842_9894(moduleAssemblyAttributesBuilder) : ImmutableArray<CSharpAttributeData>.Empty, default(ImmutableArray<CSharpAttributeData>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 7804, 10022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 10036, 10067);

                return _lazyAssemblyAttributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 7711, 10078);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10708_7988_8006()
                {
                    var return_v = ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 7988, 8006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10708_7988_8017(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 7988, 8017);
                    return return_v;
                }


                string
                f_10708_7988_8022(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 7988, 8022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10708_8073_8079()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 8073, 8079);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyReferenceHandle
                f_10708_8073_8106(Microsoft.CodeAnalysis.PEModule
                this_param, string
                assemblyName)
                {
                    var return_v = this_param.GetAssemblyRef(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 8073, 8106);
                    return return_v;
                }


                bool
                f_10708_8129_8152_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 8129, 8152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10708_8410_8416()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 8410, 8416);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_10708_8410_8692(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                resolutionScope, string
                namespaceName, string
                typeName)
                {
                    var return_v = this_param.GetTypeRef(resolutionScope, namespaceName, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 8410, 8692);
                    return return_v;
                }


                bool
                f_10708_8725_8763_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 8725, 8763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10708_8927_8933()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 8927, 8933);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_10708_8927_8993(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributesOrThrow(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 8927, 8993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10708_9226_9265()
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 9226, 9265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                f_10708_9379_9427(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData(moduleSymbol, handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 9379, 9427);
                    return return_v;
                }


                int
                f_10708_9343_9428(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 9343, 9428);
                    return 0;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_10708_8927_8993_I(System.Reflection.Metadata.CustomAttributeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 8927, 8993);
                    return return_v;
                }


                string[,]
                f_10708_8220_8276_I(string[,]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 8220, 8276);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10708_9842_9894(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 9842, 9894);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10708_9678_10006(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 9678, 10006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 7711, 10078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 7711, 10078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void LoadCustomAttributes(EntityHandle token, ref ImmutableArray<CSharpAttributeData> customAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 10090, 10373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 10227, 10275);

                var
                loaded = f_10708_10240_10274(this, token)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 10289, 10362);

                f_10708_10289_10361(ref customAttributes, loaded);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 10090, 10373);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10708_10240_10274(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.EntityHandle
                token)
                {
                    var return_v = this_param.GetCustomAttributesForToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 10240, 10274);
                    return return_v;
                }


                bool
                f_10708_10289_10361(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 10289, 10361);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 10090, 10373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 10090, 10373);
            }
        }

        internal void LoadCustomAttributesFilterCompilerAttributes(EntityHandle token,
                    ref ImmutableArray<CSharpAttributeData> customAttributes,
                    out bool foundExtension,
                    out bool foundReadOnly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 10385, 10867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 10634, 10753);

                var
                loadedCustomAttributes = f_10708_10663_10752(this, token, out foundExtension, out foundReadOnly)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 10767, 10856);

                f_10708_10767_10855(ref customAttributes, loadedCustomAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 10385, 10867);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10708_10663_10752(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.EntityHandle
                token, out bool
                foundExtension, out bool
                foundReadOnly)
                {
                    var return_v = this_param.GetCustomAttributesFilterCompilerAttributes(token, out foundExtension, out foundReadOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 10663, 10752);
                    return return_v;
                }


                bool
                f_10708_10767_10855(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 10767, 10855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 10385, 10867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 10385, 10867);
            }
        }

        internal void LoadCustomAttributesFilterExtensions(EntityHandle token,
                    ref ImmutableArray<CSharpAttributeData> customAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 10879, 11253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 11045, 11139);

                var
                loadedCustomAttributes = f_10708_11074_11138(this, token, out _, out _)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 11153, 11242);

                f_10708_11153_11241(ref customAttributes, loadedCustomAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 10879, 11253);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10708_11074_11138(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.EntityHandle
                token, out bool
                foundExtension, out bool
                foundReadOnly)
                {
                    var return_v = this_param.GetCustomAttributesFilterCompilerAttributes(token, out foundExtension, out foundReadOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 11074, 11138);
                    return return_v;
                }


                bool
                f_10708_11153_11241(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 11153, 11241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 10879, 11253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 10879, 11253);
            }
        }

        internal ImmutableArray<CSharpAttributeData> GetCustomAttributesForToken(EntityHandle token,
                    out CustomAttributeHandle filteredOutAttribute1,
                    AttributeDescription filterOut1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 11265, 11630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 11490, 11619);

                return f_10708_11497_11618(this, token, out filteredOutAttribute1, filterOut1, out _, default, out _, default, out _, default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 11265, 11630);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10708_11497_11618(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.EntityHandle
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
                    var return_v = this_param.GetCustomAttributesForToken(token, out filteredOutAttribute1, filterOut1, out filteredOutAttribute2, filterOut2, out filteredOutAttribute3, filterOut3, out filteredOutAttribute4, filterOut4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 11497, 11618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 11265, 11630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 11265, 11630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<CSharpAttributeData> GetCustomAttributesForToken(EntityHandle token,
                    out CustomAttributeHandle filteredOutAttribute1,
                    AttributeDescription filterOut1,
                    out CustomAttributeHandle filteredOutAttribute2,
                    AttributeDescription filterOut2,
                    out CustomAttributeHandle filteredOutAttribute3,
                    AttributeDescription filterOut3,
                    out CustomAttributeHandle filteredOutAttribute4,
                    AttributeDescription filterOut4)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 11852, 14744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 12401, 12433);

                filteredOutAttribute1 = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 12447, 12479);

                filteredOutAttribute2 = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 12493, 12525);

                filteredOutAttribute3 = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 12539, 12571);

                filteredOutAttribute4 = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 12585, 12650);

                ArrayBuilder<CSharpAttributeData>
                customAttributesBuilder = null
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 12702, 14234);
                        foreach (var customAttributeHandle in f_10708_12740_12781_I(f_10708_12740_12781(_module, token)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 12702, 14234);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13011, 13217) || true) && (f_10708_13015_13063(customAttributeHandle, filterOut1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 13011, 13217);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13113, 13159);

                                filteredOutAttribute1 = customAttributeHandle;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13185, 13194);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 13011, 13217);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13241, 13447) || true) && (f_10708_13245_13293(customAttributeHandle, filterOut2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 13241, 13447);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13343, 13389);

                                filteredOutAttribute2 = customAttributeHandle;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13415, 13424);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 13241, 13447);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13471, 13677) || true) && (f_10708_13475_13523(customAttributeHandle, filterOut3))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 13471, 13677);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13573, 13619);

                                filteredOutAttribute3 = customAttributeHandle;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13645, 13654);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 13471, 13677);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13701, 13907) || true) && (f_10708_13705_13753(customAttributeHandle, filterOut4))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 13701, 13907);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13803, 13849);

                                filteredOutAttribute4 = customAttributeHandle;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13875, 13884);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 13701, 13907);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 13931, 14113) || true) && (customAttributesBuilder == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 13931, 14113);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 14016, 14090);

                                customAttributesBuilder = f_10708_14042_14089();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 13931, 14113);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 14137, 14215);

                            f_10708_14137_14214(
                                                customAttributesBuilder, f_10708_14165_14213(this, customAttributeHandle));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 12702, 14234);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10708, 1, 1533);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10708, 1, 1533);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10708, 14263, 14311);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10708, 14263, 14311);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 14327, 14463) || true) && (customAttributesBuilder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 14327, 14463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 14396, 14448);

                    return f_10708_14403_14447(customAttributesBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 14327, 14463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 14479, 14528);

                return ImmutableArray<CSharpAttributeData>.Empty;

                bool matchesFilter(CustomAttributeHandle handle, AttributeDescription filter)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 14639, 14732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 14642, 14732);
                        return filter.Signatures != null && (DynAbs.Tracing.TraceSender.Expression_True(10708, 14642, 14732) && f_10708_14671_14726(f_10708_14671_14677(), handle, filter) != -1); DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 14639, 14732);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 14639, 14732);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 14639, 14732);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 11852, 14744);

                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_10708_12740_12781(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributesOrThrow(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 12740, 12781);
                    return return_v;
                }


                bool
                f_10708_13015_13063(System.Reflection.Metadata.CustomAttributeHandle
                handle, Microsoft.CodeAnalysis.AttributeDescription
                filter)
                {
                    var return_v = matchesFilter(handle, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 13015, 13063);
                    return return_v;
                }


                bool
                f_10708_13245_13293(System.Reflection.Metadata.CustomAttributeHandle
                handle, Microsoft.CodeAnalysis.AttributeDescription
                filter)
                {
                    var return_v = matchesFilter(handle, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 13245, 13293);
                    return return_v;
                }


                bool
                f_10708_13475_13523(System.Reflection.Metadata.CustomAttributeHandle
                handle, Microsoft.CodeAnalysis.AttributeDescription
                filter)
                {
                    var return_v = matchesFilter(handle, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 13475, 13523);
                    return return_v;
                }


                bool
                f_10708_13705_13753(System.Reflection.Metadata.CustomAttributeHandle
                handle, Microsoft.CodeAnalysis.AttributeDescription
                filter)
                {
                    var return_v = matchesFilter(handle, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 13705, 13753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10708_14042_14089()
                {
                    var return_v = ArrayBuilder<CSharpAttributeData>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 14042, 14089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                f_10708_14165_14213(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData(moduleSymbol, handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 14165, 14213);
                    return return_v;
                }


                int
                f_10708_14137_14214(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 14137, 14214);
                    return 0;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_10708_12740_12781_I(System.Reflection.Metadata.CustomAttributeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 12740, 12781);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10708_14403_14447(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 14403, 14447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10708_14671_14677()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 14671, 14677);
                    return return_v;
                }


                int
                f_10708_14671_14726(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.GetTargetAttributeSignatureIndex(customAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 14671, 14726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 11852, 14744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 11852, 14744);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<CSharpAttributeData> GetCustomAttributesForToken(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 14756, 15018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 14949, 15007);

                return f_10708_14956_15006(this, token, out _, default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 14756, 15018);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10708_14956_15006(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.EntityHandle
                token, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute1, Microsoft.CodeAnalysis.AttributeDescription
                filterOut1)
                {
                    var return_v = this_param.GetCustomAttributesForToken(token, out filteredOutAttribute1, filterOut1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 14956, 15006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 14756, 15018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 14756, 15018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<CSharpAttributeData> GetCustomAttributesForToken(EntityHandle token,
                    out CustomAttributeHandle paramArrayAttribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 15385, 15682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 15562, 15671);

                return f_10708_15569_15670(this, token, out paramArrayAttribute, AttributeDescription.ParamArrayAttribute);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 15385, 15682);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10708_15569_15670(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.EntityHandle
                token, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute1, Microsoft.CodeAnalysis.AttributeDescription
                filterOut1)
                {
                    var return_v = this_param.GetCustomAttributesForToken(token, out filteredOutAttribute1, filterOut1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 15569, 15670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 15385, 15682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 15385, 15682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasAnyCustomAttributes(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 15694, 16063);
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 15811, 15946);
                        foreach (var attr in f_10708_15832_15873_I(f_10708_15832_15873(_module, token)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 15811, 15946);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 15915, 15927);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 15811, 15946);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10708, 1, 136);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10708, 1, 136);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10708, 15975, 16023);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10708, 15975, 16023);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 16039, 16052);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 15694, 16063);

                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_10708_15832_15873(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributesOrThrow(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 15832, 15873);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_10708_15832_15873_I(System.Reflection.Metadata.CustomAttributeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 15832, 15873);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 15694, 16063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 15694, 16063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeSymbol TryDecodeAttributeWithTypeArgument(EntityHandle handle, AttributeDescription attributeDescription)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 16075, 16490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 16218, 16234);

                string
                typeName
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 16248, 16451) || true) && (f_10708_16252_16328(_module, handle, attributeDescription, out typeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 16248, 16451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 16362, 16436);

                    return f_10708_16369_16435(f_10708_16369_16394(this), typeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 16248, 16451);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 16467, 16479);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 16075, 16490);

                bool
                f_10708_16252_16328(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description, out string
                value)
                {
                    var return_v = this_param.HasStringValuedAttribute(token, description, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 16252, 16328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10708_16369_16394(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 16369, 16394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10708_16369_16435(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, string
                s)
                {
                    var return_v = this_param.GetTypeSymbolForSerializedType(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 16369, 16435);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 16075, 16490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 16075, 16490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<CSharpAttributeData> GetCustomAttributesFilterCompilerAttributes(EntityHandle token, out bool foundExtension, out bool foundReadOnly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 16858, 17724);
                System.Reflection.Metadata.CustomAttributeHandle extensionAttribute = default(System.Reflection.Metadata.CustomAttributeHandle);
                System.Reflection.Metadata.CustomAttributeHandle isReadOnlyAttribute = default(System.Reflection.Metadata.CustomAttributeHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 17040, 17569);

                var
                result = f_10708_17053_17568(this, token, filteredOutAttribute1: out extensionAttribute, filterOut1: AttributeDescription.CaseSensitiveExtensionAttribute, filteredOutAttribute2: out isReadOnlyAttribute, filterOut2: AttributeDescription.IsReadOnlyAttribute, filteredOutAttribute3: out _, filterOut3: default, filteredOutAttribute4: out _, filterOut4: default)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 17585, 17628);

                foundExtension = f_10708_17602_17627_M(!extensionAttribute.IsNil);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 17642, 17685);

                foundReadOnly = f_10708_17658_17684_M(!isReadOnlyAttribute.IsNil);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 17699, 17713);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 16858, 17724);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10708_17053_17568(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.EntityHandle
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
                    var return_v = this_param.GetCustomAttributesForToken(token, out filteredOutAttribute1, filterOut1: filterOut1, out filteredOutAttribute2, filterOut2: filterOut2, out filteredOutAttribute3, filterOut3: filterOut3, out filteredOutAttribute4, filterOut4: filterOut4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 17053, 17568);
                    return return_v;
                }


                bool
                f_10708_17602_17627_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 17602, 17627);
                    return return_v;
                }


                bool
                f_10708_17658_17684_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 17658, 17684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 16858, 17724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 16858, 17724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void OnNewTypeDeclarationsLoaded(
                    Dictionary<string, ImmutableArray<PENamedTypeSymbol>> typesDict)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 17736, 18706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 17881, 17989);

                bool
                keepLookingForDeclaredCorTypes = (_ordinal == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10708, 17920, 17987) && f_10708_17937_17987(_assemblySymbol)))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 18005, 18695);
                    foreach (var types in f_10708_18027_18043_I(f_10708_18027_18043(typesDict)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 18005, 18695);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 18077, 18680);
                            foreach (var type in f_10708_18098_18103_I(types))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 18077, 18680);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 18145, 18156);

                                bool
                                added
                                = default(bool);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 18178, 18232);

                                added = f_10708_18186_18231(TypeHandleToTypeMap, f_10708_18213_18224(type), type);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 18254, 18274);

                                f_10708_18254_18273(added);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 18354, 18661) || true) && (keepLookingForDeclaredCorTypes && (DynAbs.Tracing.TraceSender.Expression_True(10708, 18358, 18428) && f_10708_18392_18408(type) != SpecialType.None))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 18354, 18661);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 18478, 18528);

                                    f_10708_18478_18527(_assemblySymbol, type);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 18554, 18638);

                                    keepLookingForDeclaredCorTypes = f_10708_18587_18637(_assemblySymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 18354, 18661);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 18077, 18680);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10708, 1, 604);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10708, 1, 604);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 18005, 18695);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10708, 1, 691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10708, 1, 691);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 17736, 18706);

                bool
                f_10708_17937_17987(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.KeepLookingForDeclaredSpecialTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 17937, 17987);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>.ValueCollection
                f_10708_18027_18043(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 18027, 18043);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandle
                f_10708_18213_18224(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 18213, 18224);
                    return return_v;
                }


                bool
                f_10708_18186_18231(System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                key, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                value)
                {
                    var return_v = this_param.TryAdd(key, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 18186, 18231);
                    return return_v;
                }


                int
                f_10708_18254_18273(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 18254, 18273);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10708_18392_18408(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 18392, 18408);
                    return return_v;
                }


                int
                f_10708_18478_18527(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                corType)
                {
                    this_param.RegisterDeclaredSpecialType((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)corType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 18478, 18527);
                    return 0;
                }


                bool
                f_10708_18587_18637(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.KeepLookingForDeclaredSpecialTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 18587, 18637);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                f_10708_18098_18103_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 18098, 18103);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>.ValueCollection
                f_10708_18027_18043_I(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 18027, 18043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 17736, 18706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 17736, 18706);
            }
        }

        internal override ICollection<string> TypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 18790, 19071);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 18826, 19014) || true) && (_lazyTypeNames == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 18826, 19014);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 18894, 18995);

                        f_10708_18894_18994(ref _lazyTypeNames, f_10708_18942_18987(f_10708_18942_18959(_module)), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 18826, 19014);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 19034, 19056);

                    return _lazyTypeNames;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 18790, 19071);

                    Microsoft.CodeAnalysis.IdentifierCollection
                    f_10708_18942_18959(Microsoft.CodeAnalysis.PEModule
                    this_param)
                    {
                        var return_v = this_param.TypeNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 18942, 18959);
                        return return_v;
                    }


                    System.Collections.Generic.ICollection<string>
                    f_10708_18942_18987(Microsoft.CodeAnalysis.IdentifierCollection
                    this_param)
                    {
                        var return_v = this_param.AsCaseSensitiveCollection();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 18942, 18987);
                        return return_v;
                    }


                    System.Collections.Generic.ICollection<string>?
                    f_10708_18894_18994(ref System.Collections.Generic.ICollection<string>?
                    location1, System.Collections.Generic.ICollection<string>
                    value, System.Collections.Generic.ICollection<string>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 18894, 18994);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 18718, 19082);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 18718, 19082);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ICollection<string> NamespaceNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 19171, 19472);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 19207, 19410) || true) && (_lazyNamespaceNames == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 19207, 19410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 19280, 19391);

                        f_10708_19280_19390(ref _lazyNamespaceNames, f_10708_19333_19383(f_10708_19333_19355(_module)), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 19207, 19410);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 19430, 19457);

                    return _lazyNamespaceNames;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 19171, 19472);

                    Microsoft.CodeAnalysis.IdentifierCollection
                    f_10708_19333_19355(Microsoft.CodeAnalysis.PEModule
                    this_param)
                    {
                        var return_v = this_param.NamespaceNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 19333, 19355);
                        return return_v;
                    }


                    System.Collections.Generic.ICollection<string>
                    f_10708_19333_19383(Microsoft.CodeAnalysis.IdentifierCollection
                    this_param)
                    {
                        var return_v = this_param.AsCaseSensitiveCollection();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 19333, 19383);
                        return return_v;
                    }


                    System.Collections.Generic.ICollection<string>?
                    f_10708_19280_19390(ref System.Collections.Generic.ICollection<string>?
                    location1, System.Collections.Generic.ICollection<string>
                    value, System.Collections.Generic.ICollection<string>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 19280, 19390);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 19094, 19483);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 19094, 19483);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<byte> GetHash(AssemblyHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 19495, 19648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 19601, 19637);

                return f_10708_19608_19636(_module, algorithmId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 19495, 19648);

                System.Collections.Immutable.ImmutableArray<byte>
                f_10708_19608_19636(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.AssemblyHashAlgorithm
                algorithmId)
                {
                    var return_v = this_param.GetHash(algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 19608, 19636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 19495, 19648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 19495, 19648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal DocumentationProvider DocumentationProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 19737, 20103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 19773, 19824);

                    var
                    assembly = _assemblySymbol as PEAssemblySymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 19842, 20088) || true) && ((object)assembly != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 19842, 20088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 19912, 19950);

                        return f_10708_19919_19949(assembly);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 19842, 20088);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 19842, 20088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 20032, 20069);

                        return f_10708_20039_20068();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 19842, 20088);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 19737, 20103);

                    Microsoft.CodeAnalysis.DocumentationProvider
                    f_10708_19919_19949(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.DocumentationProvider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 19919, 19949);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DocumentationProvider
                    f_10708_20039_20068()
                    {
                        var return_v = DocumentationProvider.Default;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 20039, 20068);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 19660, 20114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 19660, 20114);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedTypeSymbol EventRegistrationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 20198, 20902);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 20234, 20828) || true) && ((object)_lazyEventRegistrationTokenSymbol == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 20234, 20828);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 20329, 20723);

                        f_10708_20329_20722(ref _lazyEventRegistrationTokenSymbol, f_10708_20445_20666(this, WellKnownType.System_Runtime_InteropServices_WindowsRuntime_EventRegistrationToken), null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 20745, 20809);

                        f_10708_20745_20808((object)_lazyEventRegistrationTokenSymbol != null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 20234, 20828);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 20846, 20887);

                    return _lazyEventRegistrationTokenSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 20198, 20902);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10708_20445_20666(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    type)
                    {
                        var return_v = this_param.GetTypeSymbolForWellKnownType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 20445, 20666);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10708_20329_20722(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 20329, 20722);
                        return return_v;
                    }


                    int
                    f_10708_20745_20808(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 20745, 20808);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 20126, 20913);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 20126, 20913);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedTypeSymbol EventRegistrationTokenTable_T
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 21004, 21735);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 21040, 21656) || true) && ((object)_lazyEventRegistrationTokenTableSymbol == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 21040, 21656);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 21140, 21546);

                        f_10708_21140_21545(ref _lazyEventRegistrationTokenTableSymbol, f_10708_21261_21489(this, WellKnownType.System_Runtime_InteropServices_WindowsRuntime_EventRegistrationTokenTable_T), null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 21568, 21637);

                        f_10708_21568_21636((object)_lazyEventRegistrationTokenTableSymbol != null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 21040, 21656);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 21674, 21720);

                    return _lazyEventRegistrationTokenTableSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 21004, 21735);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10708_21261_21489(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    type)
                    {
                        var return_v = this_param.GetTypeSymbolForWellKnownType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 21261, 21489);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10708_21140_21545(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 21140, 21545);
                        return return_v;
                    }


                    int
                    f_10708_21568_21636(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 21568, 21636);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 20925, 21746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 20925, 21746);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedTypeSymbol SystemTypeSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 21824, 22315);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 21860, 22253) || true) && ((object)_lazySystemTypeSymbol == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 21860, 22253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 21943, 22160);

                        f_10708_21943_22159(ref _lazySystemTypeSymbol, f_10708_22047_22103(this, WellKnownType.System_Type), null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 22182, 22234);

                        f_10708_22182_22233((object)_lazySystemTypeSymbol != null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 21860, 22253);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 22271, 22300);

                    return _lazySystemTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 21824, 22315);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10708_22047_22103(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    type)
                    {
                        var return_v = this_param.GetTypeSymbolForWellKnownType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 22047, 22103);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10708_21943_22159(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 21943, 22159);
                        return return_v;
                    }


                    int
                    f_10708_22182_22233(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 22182, 22233);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 21758, 22326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 21758, 22326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private NamedTypeSymbol GetTypeSymbolForWellKnownType(WellKnownType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 22338, 24729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 22436, 22561);

                MetadataTypeName
                emittedName = MetadataTypeName.FromFullName(f_10708_22497_22519(type), useCLSCompliantNameArityEncoding: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 22616, 22703);

                NamedTypeSymbol
                currentModuleResult = f_10708_22654_22702(this, ref emittedName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 22719, 23006) || true) && (f_10708_22723_22772(currentModuleResult))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 22719, 23006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 22964, 22991);

                    return currentModuleResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 22719, 23006);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 23107, 23155);

                NamedTypeSymbol
                referencedAssemblyResult = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 23169, 24383);
                    foreach (AssemblySymbol assembly in f_10708_23205_23240_I(f_10708_23205_23240(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 23169, 24383);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 23274, 23388);

                        NamedTypeSymbol
                        currResult = f_10708_23303_23387(assembly, ref emittedName, digThroughForwardedTypes: true)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 23406, 24368) || true) && (f_10708_23410_23450(currResult))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 23406, 24368);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 23492, 24349) || true) && ((object)referencedAssemblyResult == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 23492, 24349);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 23586, 23624);

                                referencedAssemblyResult = currResult;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 23492, 24349);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 23492, 24349);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 24080, 24294) || true) && (!f_10708_24085_24177(referencedAssemblyResult, currResult, TypeCompareKind.ConsiderEverything2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 24080, 24294);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 24235, 24267);

                                    referencedAssemblyResult = null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 24080, 24294);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10708, 24320, 24326);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 23492, 24349);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 23406, 24368);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 23169, 24383);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10708, 1, 1215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10708, 1, 1215);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 24399, 24611) || true) && ((object)referencedAssemblyResult != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 24399, 24611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 24477, 24546);

                    f_10708_24477_24545(f_10708_24490_24544(referencedAssemblyResult));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 24564, 24596);

                    return referencedAssemblyResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 24399, 24611);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 24627, 24677);

                f_10708_24627_24676((object)currentModuleResult != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 24691, 24718);

                return currentModuleResult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 22338, 24729);

                string
                f_10708_22497_22519(Microsoft.CodeAnalysis.WellKnownType
                id)
                {
                    var return_v = id.GetMetadataName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 22497, 22519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10708_22654_22702(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 22654, 22702);
                    return return_v;
                }


                bool
                f_10708_22723_22772(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                candidate)
                {
                    var return_v = IsAcceptableSystemTypeSymbol(candidate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 22723, 22772);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10708_23205_23240(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblySymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 23205, 23240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10708_23303_23387(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, bool
                digThroughForwardedTypes)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName, digThroughForwardedTypes: digThroughForwardedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 23303, 23387);
                    return return_v;
                }


                bool
                f_10708_23410_23450(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                candidate)
                {
                    var return_v = IsAcceptableSystemTypeSymbol(candidate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 23410, 23450);
                    return return_v;
                }


                bool
                f_10708_24085_24177(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 24085, 24177);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10708_23205_23240_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 23205, 23240);
                    return return_v;
                }


                bool
                f_10708_24490_24544(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                candidate)
                {
                    var return_v = IsAcceptableSystemTypeSymbol(candidate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 24490, 24544);
                    return return_v;
                }


                int
                f_10708_24477_24545(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 24477, 24545);
                    return 0;
                }


                int
                f_10708_24627_24676(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 24627, 24676);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 22338, 24729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 22338, 24729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsAcceptableSystemTypeSymbol(NamedTypeSymbol candidate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10708, 24741, 24943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 24841, 24932);

                return f_10708_24848_24862(candidate) != SymbolKind.ErrorType || (DynAbs.Tracing.TraceSender.Expression_False(10708, 24848, 24931) || !(candidate is MissingMetadataTypeSymbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10708, 24741, 24943);

                Microsoft.CodeAnalysis.SymbolKind
                f_10708_24848_24862(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 24848, 24862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 24741, 24943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 24741, 24943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool HasAssemblyCompilationRelaxationsAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 25045, 25271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 25081, 25130);

                    var
                    assemblyAttributes = f_10708_25106_25129(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 25148, 25256);

                    return assemblyAttributes.IndexOfAttribute(this, AttributeDescription.CompilationRelaxationsAttribute) >= 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 25045, 25271);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    f_10708_25106_25129(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetAssemblyAttributes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 25106, 25129);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 24955, 25282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 24955, 25282);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasAssemblyRuntimeCompatibilityAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 25382, 25606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 25418, 25467);

                    var
                    assemblyAttributes = f_10708_25443_25466(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 25485, 25591);

                    return assemblyAttributes.IndexOfAttribute(this, AttributeDescription.RuntimeCompatibilityAttribute) >= 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 25382, 25606);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    f_10708_25443_25466(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetAssemblyAttributes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 25443, 25466);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 25294, 25617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 25294, 25617);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CharSet? DefaultMarshallingCharSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 25706, 25839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 25787, 25824);

                    throw f_10708_25793_25823();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 25706, 25839);

                    System.Exception
                    f_10708_25793_25823()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 25793, 25823);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 25629, 25850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 25629, 25850);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 25975, 25995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 25981, 25993);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 25975, 25995);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 25862, 26006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 25862, 26006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedTypeSymbol LookupTopLevelMetadataType(ref MetadataTypeName emittedName, out bool isNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 26018, 26804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 26155, 26178);

                NamedTypeSymbol
                result
                = default(NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 26192, 26311);

                PENamespaceSymbol
                scope = (PENamespaceSymbol)f_10708_26237_26310(f_10708_26237_26257(this), emittedName.NamespaceSegments)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 26327, 26763) || true) && ((object)scope == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 26327, 26763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 26440, 26465);

                    isNoPiaLocalType = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 26483, 26554);

                    result = f_10708_26492_26553(this, ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 26327, 26763);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 26327, 26763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 26620, 26693);

                    result = f_10708_26629_26692(scope, ref emittedName, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 26711, 26748);

                    f_10708_26711_26747((object)result != null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 26327, 26763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 26779, 26793);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 26018, 26804);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10708_26237_26257(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 26237, 26257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10708_26237_26310(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, System.Collections.Immutable.ImmutableArray<string>
                names)
                {
                    var return_v = this_param.LookupNestedNamespace(names);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 26237, 26310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10708_26492_26553(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)module, ref fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 26492, 26553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10708_26629_26692(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedTypeName, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.LookupMetadataType(ref emittedTypeName, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 26629, 26692);
                    return return_v;
                }


                int
                f_10708_26711_26747(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 26711, 26747);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 26018, 26804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 26018, 26804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal (AssemblySymbol FirstSymbol, AssemblySymbol SecondSymbol) GetAssembliesForForwardedType(ref MetadataTypeName fullName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 27194, 27973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 27346, 27365);

                string
                matchedName
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 27379, 27527);

                (int firstIndex, int secondIndex) = f_10708_27415_27526(f_10708_27415_27426(this), fullName.FullName, ignoreCase: false, matchedName: out matchedName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 27543, 27630) || true) && (firstIndex < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 27543, 27630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 27595, 27615);

                    return (null, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 27543, 27630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 27646, 27715);

                AssemblySymbol
                firstSymbol = f_10708_27675_27714(this, firstIndex)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 27731, 27826) || true) && (secondIndex < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 27731, 27826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 27784, 27811);

                    return (firstSymbol, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 27731, 27826);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 27842, 27913);

                AssemblySymbol
                secondSymbol = f_10708_27872_27912(this, secondIndex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 27927, 27962);

                return (firstSymbol, secondSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 27194, 27973);

                Microsoft.CodeAnalysis.PEModule
                f_10708_27415_27426(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 27415, 27426);
                    return return_v;
                }


                (int FirstIndex, int SecondIndex)
                f_10708_27415_27526(Microsoft.CodeAnalysis.PEModule
                this_param, string
                fullName, bool
                ignoreCase, out string
                matchedName)
                {
                    var return_v = this_param.GetAssemblyRefsForForwardedType(fullName, ignoreCase: ignoreCase, out matchedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 27415, 27526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10708_27675_27714(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, int
                referencedAssemblyIndex)
                {
                    var return_v = this_param.GetReferencedAssemblySymbol(referencedAssemblyIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 27675, 27714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10708_27872_27912(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, int
                referencedAssemblyIndex)
                {
                    var return_v = this_param.GetReferencedAssemblySymbol(referencedAssemblyIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 27872, 27912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 27194, 27973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 27194, 27973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<NamedTypeSymbol> GetForwardedTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 27985, 29373);

                var listYield = new List<NamedTypeSymbol>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 28067, 29362);
                    foreach (KeyValuePair<string, (int FirstIndex, int SecondIndex)> forwarder in f_10708_28145_28171_I(f_10708_28145_28171(f_10708_28145_28151())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 28067, 29362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 28205, 28261);

                        var
                        name = MetadataTypeName.FromFullName(forwarder.Key)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 28281, 28367);

                        f_10708_28281_28366(forwarder.Value.FirstIndex >= 0, "First index should never be negative");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 28385, 28475);

                        AssemblySymbol
                        firstSymbol = f_10708_28414_28474(this, forwarder.Value.FirstIndex)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 28493, 28652);

                        f_10708_28493_28651((object)firstSymbol != null, "Invalid indexes (out of bound) are discarded during reading metadata in PEModule.EnsureForwardTypeToAssemblyMap()");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 28672, 29347) || true) && (forwarder.Value.SecondIndex >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 28672, 29347);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 28750, 28831);

                            var
                            secondSymbol = f_10708_28769_28830(this, forwarder.Value.SecondIndex)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 28853, 29013);

                            f_10708_28853_29012((object)secondSymbol != null, "Invalid indexes (out of bound) are discarded during reading metadata in PEModule.EnsureForwardTypeToAssemblyMap()");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 29037, 29152);

                            listYield.Add(f_10708_29050_29151(f_10708_29050_29068(), ref name, this, firstSymbol, secondSymbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 28672, 29347);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 28672, 29347);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 29234, 29328);

                            listYield.Add(f_10708_29247_29327(firstSymbol, ref name, digThroughForwardedTypes: true));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 28672, 29347);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 28067, 29362);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10708, 1, 1296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10708, 1, 1296);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 27985, 29373);

                return listYield;

                Microsoft.CodeAnalysis.PEModule
                f_10708_28145_28151()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 28145, 28151);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, (int FirstIndex, int SecondIndex)>>
                f_10708_28145_28171(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.GetForwardedTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 28145, 28171);
                    return return_v;
                }


                int
                f_10708_28281_28366(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 28281, 28366);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10708_28414_28474(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, int
                referencedAssemblyIndex)
                {
                    var return_v = this_param.GetReferencedAssemblySymbol(referencedAssemblyIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 28414, 28474);
                    return return_v;
                }


                int
                f_10708_28493_28651(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 28493, 28651);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10708_28769_28830(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, int
                referencedAssemblyIndex)
                {
                    var return_v = this_param.GetReferencedAssemblySymbol(referencedAssemblyIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 28769, 28830);
                    return return_v;
                }


                int
                f_10708_28853_29012(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 28853, 29012);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10708_29050_29068()
                {
                    var return_v = ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 29050, 29068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                f_10708_29050_29151(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                forwardingModule, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                destination1, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                destination2)
                {
                    var return_v = this_param.CreateMultipleForwardingErrorTypeSymbol(ref emittedName, (Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)forwardingModule, destination1, destination2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 29050, 29151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10708_29247_29327(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, bool
                digThroughForwardedTypes)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName, digThroughForwardedTypes: digThroughForwardedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 29247, 29327);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, (int FirstIndex, int SecondIndex)>>
                f_10708_28145_28171_I(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, (int FirstIndex, int SecondIndex)>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 28145, 28171);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 27985, 29373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 27985, 29373);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ModuleMetadata GetMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 29430, 29467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 29433, 29467);
                return f_10708_29433_29467(_module); DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 29430, 29467);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 29430, 29467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 29430, 29467);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.ModuleMetadata
            f_10708_29433_29467(Microsoft.CodeAnalysis.PEModule
            this_param)
            {
                var return_v = this_param.GetNonDisposableMetadata();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 29433, 29467);
                return return_v;
            }

        }

        internal bool ShouldDecodeNullableAttributes(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10708, 29480, 30895);
                bool includesInternals = default(bool);
                bool isInternal = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 29564, 29595);

                f_10708_29564_29594(symbol is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 29609, 29643);

                f_10708_29609_29642(f_10708_29622_29641(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 29657, 29711);

                f_10708_29657_29710((object)f_10708_29678_29701(symbol) == this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 29727, 30104) || true) && (_lazyNullableMemberMetadata == NullableMemberMetadata.Unknown)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 29727, 30104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 29826, 30089);

                    _lazyNullableMemberMetadata = (DynAbs.Tracing.TraceSender.Conditional_F1(10708, 29856, 29929) || ((f_10708_29856_29929(_module, f_10708_29895_29900(), out includesInternals) && DynAbs.Tracing.TraceSender.Conditional_F2(10708, 29953, 30038)) || DynAbs.Tracing.TraceSender.Conditional_F3(10708, 30062, 30088))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(10708, 29954, 29971) || ((includesInternals && DynAbs.Tracing.TraceSender.Conditional_F2(10708, 29974, 30005)) || DynAbs.Tracing.TraceSender.Conditional_F3(10708, 30008, 30037))) ? NullableMemberMetadata.Internal : NullableMemberMetadata.Public) : NullableMemberMetadata.All;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 29727, 30104);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 30120, 30196);

                NullableMemberMetadata
                nullableMemberMetadata = _lazyNullableMemberMetadata
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 30210, 30327) || true) && (nullableMemberMetadata == NullableMemberMetadata.All)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 30210, 30327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 30300, 30312);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 30210, 30327);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 30343, 30855) || true) && (f_10708_30347_30417(symbol, out isInternal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 30343, 30855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 30451, 30840);

                    switch (nullableMemberMetadata)
                    {

                        case NullableMemberMetadata.Public:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 30451, 30840);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 30584, 30603);

                            return !isInternal;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 30451, 30840);

                        case NullableMemberMetadata.Internal:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 30451, 30840);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 30688, 30700);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 30451, 30840);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10708, 30451, 30840);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 30756, 30821);

                            throw f_10708_30762_30820(nullableMemberMetadata);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 30451, 30840);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10708, 30343, 30855);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 30871, 30884);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10708, 29480, 30895);

                int
                f_10708_29564_29594(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 29564, 29594);
                    return 0;
                }


                bool
                f_10708_29622_29641(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 29622, 29641);
                    return return_v;
                }


                int
                f_10708_29609_29642(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 29609, 29642);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10708_29678_29701(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 29678, 29701);
                    return return_v;
                }


                int
                f_10708_29657_29710(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 29657, 29710);
                    return 0;
                }


                System.Reflection.Metadata.EntityHandle
                f_10708_29895_29900()
                {
                    var return_v = Token;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10708, 29895, 29900);
                    return return_v;
                }


                bool
                f_10708_29856_29929(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, out bool
                includesInternals)
                {
                    var return_v = this_param.HasNullablePublicOnlyAttribute(token, out includesInternals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 29856, 29929);
                    return return_v;
                }


                bool
                f_10708_30347_30417(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, out bool
                isInternal)
                {
                    var return_v = AccessCheck.IsEffectivelyPublicOrInternal(symbol, out isInternal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 30347, 30417);
                    return return_v;
                }


                System.Exception
                f_10708_30762_30820(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol.NullableMemberMetadata
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 30762, 30820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10708, 29480, 30895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 29480, 30895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PEModuleSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10708, 881, 30902);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10708, 1986, 2013);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10708, 881, 30902);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10708, 881, 30902);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10708, 881, 30902);

        System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
        f_10708_2514_2627(int
        concurrencyLevel, int
        capacity)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>(concurrencyLevel: concurrencyLevel, capacity: capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 2514, 2627);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeReferenceHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
        f_10708_3169_3281(int
        concurrencyLevel, int
        capacity)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeReferenceHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>(concurrencyLevel: concurrencyLevel, capacity: capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 3169, 3281);
            return return_v;
        }


        int
        f_10708_4424_4450(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 4424, 4450);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10708_4336_4366_C(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10708, 4192, 4462);
            return return_v;
        }


        int
        f_10708_4710_4735(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 4710, 4735);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10708_4622_4652_C(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10708, 4474, 4747);
            return return_v;
        }


        int
        f_10708_5000_5025(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 5000, 5025);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10708_4912_4942_C(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10708, 4759, 5037);
            return return_v;
        }


        int
        f_10708_5194_5238(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 5194, 5238);
            return 0;
        }


        int
        f_10708_5253_5281(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 5253, 5281);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEGlobalNamespaceSymbol
        f_10708_5477_5510(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        moduleSymbol)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEGlobalNamespaceSymbol(moduleSymbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 5477, 5510);
            return return_v;
        }


        Microsoft.CodeAnalysis.MetadataLocation
        f_10708_5591_5617(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        module)
        {
            var return_v = new Microsoft.CodeAnalysis.MetadataLocation((Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal)module);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 5591, 5617);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataLocation>
        f_10708_5551_5618(Microsoft.CodeAnalysis.MetadataLocation
        item)
        {
            var return_v = ImmutableArray.Create<MetadataLocation>(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10708, 5551, 5618);
            return return_v;
        }

    }
}
