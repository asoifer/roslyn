// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;
using CommonAssemblyWellKnownAttributeData = Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class SourceAssemblySymbol : MetadataOrSourceAssemblySymbol, ISourceAssemblySymbolInternal, IAttributeTargetSymbol
    {
        private readonly CSharpCompilation _compilation;

        private SymbolCompletionState _state;

        internal AssemblyIdentity lazyAssemblyIdentity;

        private readonly string _assemblySimpleName;

        private StrongNameKeys _lazyStrongNameKeys;

        private readonly ImmutableArray<ModuleSymbol> _modules;

        private CustomAttributesBag<CSharpAttributeData> _lazySourceAttributesBag;

        private CustomAttributesBag<CSharpAttributeData> _lazyNetModuleAttributesBag;

        private IDictionary<string, NamedTypeSymbol> _lazyForwardedTypesFromSource;

        private ConcurrentSet<int> _lazyOmittedAttributeIndices;

        private ThreeState _lazyContainsExtensionMethods;

        private readonly ConcurrentDictionary<FieldSymbol, bool> _unassignedFieldsMap;

        private readonly ConcurrentSet<FieldSymbol> _unreadFields;

        internal ConcurrentSet<TypeSymbol> TypesReferencedInExternalMethods;

        private ImmutableArray<Diagnostic> _unusedFieldWarnings;

        internal SourceAssemblySymbol(
                    CSharpCompilation compilation,
                    string assemblySimpleName,
                    string moduleName,
                    ImmutableArray<PEModule> netModules)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10218, 5683, 7495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 1393, 1405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 1574, 1594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 1629, 1648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 2775, 2794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 3293, 3317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 3536, 3563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 3621, 3650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 4262, 4290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 4322, 4351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 4839, 4907);
                this._unassignedFieldsMap = f_10218_4862_4907(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 5080, 5128);
                this._unreadFields = f_10218_5096_5128(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 5444, 5510);
                this.TypesReferencedInExternalMethods = f_10218_5479_5510(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 19797, 19834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 94440, 94466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 5904, 5938);

                f_10218_5904_5937(compilation != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 5952, 5993);

                f_10218_5952_5992(assemblySimpleName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 6007, 6060);

                f_10218_6007_6059(!f_10218_6021_6058(moduleName));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 6074, 6110);

                f_10218_6074_6109(f_10218_6087_6108_M(!netModules.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 6126, 6153);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 6167, 6208);

                _assemblySimpleName = assemblySimpleName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 6224, 6321);

                ArrayBuilder<ModuleSymbol>
                moduleBuilder = f_10218_6267_6320(1 + netModules.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 6337, 6423);

                f_10218_6337_6422(
                            moduleBuilder, f_10218_6355_6421(this, f_10218_6384_6408(compilation), moduleName));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 6439, 6610);

                var
                importOptions = (DynAbs.Tracing.TraceSender.Conditional_F1(10218, 6459, 6531) || (((f_10218_6460_6501(f_10218_6460_6479(compilation)) == MetadataImportOptions.All) && DynAbs.Tracing.TraceSender.Conditional_F2(10218, 6551, 6576)) || DynAbs.Tracing.TraceSender.Conditional_F3(10218, 6579, 6609))) ? MetadataImportOptions.All : MetadataImportOptions.Internal
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 6626, 7013);
                    foreach (PEModule netModule in f_10218_6657_6667_I(netModules))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 6626, 7013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 6701, 6792);

                        f_10218_6701_6791(moduleBuilder, f_10218_6719_6790(this, netModule, importOptions, f_10218_6770_6789(moduleBuilder)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 6626, 7013);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 388);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 7029, 7075);

                _modules = f_10218_7040_7074(moduleBuilder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 7091, 7484) || true) && (f_10218_7095_7139_M(!f_10218_7096_7115(compilation).CryptoPublicKey.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 7091, 7484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 7316, 7469);

                    _lazyStrongNameKeys = f_10218_7338_7468(f_10218_7360_7395(f_10218_7360_7379(compilation)), privateKey: null, hasCounterSignature: false, MessageProvider.Instance);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 7091, 7484);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10218, 5683, 7495);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 5683, 7495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 5683, 7495);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 7559, 7637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 7595, 7622);

                    return _assemblySimpleName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 7559, 7637);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 7507, 7648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 7507, 7648);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override CSharpCompilation DeclaringCompilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 7883, 7954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 7919, 7939);

                    return _compilation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 7883, 7954);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 7795, 7965);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 7795, 7965);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsInteractive
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 8036, 8120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 8072, 8105);

                    return f_10218_8079_8104(_compilation);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 8036, 8120);

                    bool
                    f_10218_8079_8104(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.IsSubmission;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 8079, 8104);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 7977, 8131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 7977, 8131);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool MightContainNoPiaLocalTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 8143, 8580);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 8220, 8225);
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 8211, 8503) || true) && (i < _modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 8248, 8251)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 8211, 8503))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 8211, 8503);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 8285, 8346);

                        var
                        peModuleSymbol = (Metadata.PE.PEModuleSymbol)_modules[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 8364, 8488) || true) && (f_10218_8368_8415(f_10218_8368_8389(peModuleSymbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 8364, 8488);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 8457, 8469);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 8364, 8488);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 293);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 8519, 8569);

                return f_10218_8526_8568(f_10218_8526_8538());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 8143, 8580);

                Microsoft.CodeAnalysis.PEModule
                f_10218_8368_8389(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 8368, 8389);
                    return return_v;
                }


                bool
                f_10218_8368_8415(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.ContainsNoPiaLocalTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 8368, 8415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                f_10218_8526_8538()
                {
                    var return_v = SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 8526, 8538);
                    return return_v;
                }


                bool
                f_10218_8526_8568(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.MightContainNoPiaLocalTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 8526, 8568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 8143, 8580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 8143, 8580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AssemblyIdentity Identity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 8658, 8891);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 8694, 8828) || true) && (lazyAssemblyIdentity == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 8694, 8828);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 8749, 8828);

                        f_10218_8749_8827(ref lazyAssemblyIdentity, f_10218_8803_8820(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 8694, 8828);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 8848, 8876);

                    return lazyAssemblyIdentity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 8658, 8891);

                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10218_8803_8820(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.ComputeIdentity();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 8803, 8820);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AssemblyIdentity?
                    f_10218_8749_8827(ref Microsoft.CodeAnalysis.AssemblyIdentity?
                    location1, Microsoft.CodeAnalysis.AssemblyIdentity
                    value, Microsoft.CodeAnalysis.AssemblyIdentity?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 8749, 8827);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 8592, 8902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 8592, 8902);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Symbol GetSpecialTypeMember(SpecialMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 8914, 9104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 9006, 9093);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10218, 9013, 9049) || ((f_10218_9013_9049(_compilation, member) && DynAbs.Tracing.TraceSender.Conditional_F2(10218, 9052, 9056)) || DynAbs.Tracing.TraceSender.Conditional_F3(10218, 9059, 9092))) ? null : DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetSpecialTypeMember(member), 10218, 9059, 9092);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 8914, 9104);

                bool
                f_10218_9013_9049(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = this_param.IsMemberMissing(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 9013, 9049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 8914, 9104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 8914, 9104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetWellKnownAttributeDataStringField(Func<CommonAssemblyWellKnownAttributeData, string> fieldGetter, string missingValue = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 9116, 9828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 9284, 9317);

                string
                fieldValue = missingValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 9333, 9385);

                var
                data = f_10218_9344_9384(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 9399, 9495) || true) && (data != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 9399, 9495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 9449, 9480);

                    fieldValue = f_10218_9462_9479(fieldGetter, data);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 9399, 9495);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 9511, 9783) || true) && ((object)fieldValue == (object)missingValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 9511, 9783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 9591, 9642);

                    data = f_10218_9598_9641(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 9660, 9768) || true) && (data != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 9660, 9768);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 9718, 9749);

                        fieldValue = f_10218_9731_9748(fieldGetter, data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 9660, 9768);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 9511, 9783);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 9799, 9817);

                return fieldValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 9116, 9828);

                Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_9344_9384(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetSourceDecodedWellKnownAttributeData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 9344, 9384);
                    return return_v;
                }


                string
                f_10218_9462_9479(System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                this_param, Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 9462, 9479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_9598_9641(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetNetModuleDecodedWellKnownAttributeData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 9598, 9641);
                    return return_v;
                }


                string
                f_10218_9731_9748(System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                this_param, Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 9731, 9748);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 9116, 9828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 9116, 9828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool RuntimeCompatibilityWrapNonExceptionThrows
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 9921, 10312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 9957, 10056);

                    var
                    data = f_10218_9968_10008(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>(10218, 9968, 10055) ?? f_10218_10012_10055(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 10156, 10297);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10218, 10163, 10177) || (((data != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10218, 10180, 10227)) || DynAbs.Tracing.TraceSender.Conditional_F3(10218, 10230, 10296))) ? f_10218_10180_10227(data) : CommonAssemblyWellKnownAttributeData.WrapNonExceptionThrowsDefault;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 9921, 10312);

                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10218_9968_10008(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetSourceDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 9968, 10008);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10218_10012_10055(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetNetModuleDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 10012, 10055);
                        return return_v;
                    }


                    bool
                    f_10218_10180_10227(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.RuntimeCompatibilityWrapNonExceptionThrows;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 10180, 10227);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 9840, 10323);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 9840, 10323);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string FileVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 10387, 10532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 10423, 10517);

                    return f_10218_10430_10516(this, data => data.AssemblyFileVersionAttributeSetting);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 10387, 10532);

                    string
                    f_10218_10430_10516(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                    fieldGetter)
                    {
                        var return_v = this_param.GetWellKnownAttributeDataStringField(fieldGetter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 10430, 10516);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 10335, 10543);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 10335, 10543);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string Title
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 10601, 10740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 10637, 10725);

                    return f_10218_10644_10724(this, data => data.AssemblyTitleAttributeSetting);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 10601, 10740);

                    string
                    f_10218_10644_10724(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                    fieldGetter)
                    {
                        var return_v = this_param.GetWellKnownAttributeDataStringField(fieldGetter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 10644, 10724);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 10555, 10751);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 10555, 10751);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string Description
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 10815, 10960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 10851, 10945);

                    return f_10218_10858_10944(this, data => data.AssemblyDescriptionAttributeSetting);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 10815, 10960);

                    string
                    f_10218_10858_10944(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                    fieldGetter)
                    {
                        var return_v = this_param.GetWellKnownAttributeDataStringField(fieldGetter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 10858, 10944);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 10763, 10971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 10763, 10971);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string Company
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 11031, 11172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 11067, 11157);

                    return f_10218_11074_11156(this, data => data.AssemblyCompanyAttributeSetting);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 11031, 11172);

                    string
                    f_10218_11074_11156(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                    fieldGetter)
                    {
                        var return_v = this_param.GetWellKnownAttributeDataStringField(fieldGetter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 11074, 11156);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 10983, 11183);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 10983, 11183);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string Product
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 11243, 11384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 11279, 11369);

                    return f_10218_11286_11368(this, data => data.AssemblyProductAttributeSetting);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 11243, 11384);

                    string
                    f_10218_11286_11368(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                    fieldGetter)
                    {
                        var return_v = this_param.GetWellKnownAttributeDataStringField(fieldGetter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 11286, 11368);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 11195, 11395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 11195, 11395);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string InformationalVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 11468, 11622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 11504, 11607);

                    return f_10218_11511_11606(this, data => data.AssemblyInformationalVersionAttributeSetting);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 11468, 11622);

                    string
                    f_10218_11511_11606(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                    fieldGetter)
                    {
                        var return_v = this_param.GetWellKnownAttributeDataStringField(fieldGetter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 11511, 11606);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 11407, 11633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 11407, 11633);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string Copyright
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 11695, 11838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 11731, 11823);

                    return f_10218_11738_11822(this, data => data.AssemblyCopyrightAttributeSetting);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 11695, 11838);

                    string
                    f_10218_11738_11822(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                    fieldGetter)
                    {
                        var return_v = this_param.GetWellKnownAttributeDataStringField(fieldGetter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 11738, 11822);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 11645, 11849);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 11645, 11849);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string Trademark
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 11911, 12054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 11947, 12039);

                    return f_10218_11954_12038(this, data => data.AssemblyTrademarkAttributeSetting);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 11911, 12054);

                    string
                    f_10218_11954_12038(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                    fieldGetter)
                    {
                        var return_v = this_param.GetWellKnownAttributeDataStringField(fieldGetter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 11954, 12038);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 11861, 12065);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 11861, 12065);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ThreeState AssemblyDelaySignAttributeSetting
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 12154, 12873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 12190, 12228);

                    var
                    defaultValue = ThreeState.Unknown
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 12246, 12276);

                    var
                    fieldValue = defaultValue
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 12296, 12348);

                    var
                    data = f_10218_12307_12347(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 12366, 12495) || true) && (data != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 12366, 12495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 12424, 12476);

                        fieldValue = f_10218_12437_12475(data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 12366, 12495);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 12515, 12820) || true) && (fieldValue == defaultValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 12515, 12820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 12587, 12638);

                        data = f_10218_12594_12637(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 12660, 12801) || true) && (data != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 12660, 12801);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 12726, 12778);

                            fieldValue = f_10218_12739_12777(data);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 12660, 12801);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 12515, 12820);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 12840, 12858);

                    return fieldValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 12154, 12873);

                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10218_12307_12347(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetSourceDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 12307, 12347);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_10218_12437_12475(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.AssemblyDelaySignAttributeSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 12437, 12475);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10218_12594_12637(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetNetModuleDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 12594, 12637);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_10218_12739_12777(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.AssemblyDelaySignAttributeSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 12739, 12777);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 12077, 12884);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 12077, 12884);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string AssemblyKeyContainerAttributeSetting
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 12972, 13161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 13008, 13146);

                    return f_10218_13015_13145(this, data => data.AssemblyKeyContainerAttributeSetting, WellKnownAttributeData.StringMissingValue);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 12972, 13161);

                    string
                    f_10218_13015_13145(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                    fieldGetter, string
                    missingValue)
                    {
                        var return_v = this_param.GetWellKnownAttributeDataStringField(fieldGetter, missingValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 13015, 13145);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 12896, 13172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 12896, 13172);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string AssemblyKeyFileAttributeSetting
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 13255, 13439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 13291, 13424);

                    return f_10218_13298_13423(this, data => data.AssemblyKeyFileAttributeSetting, WellKnownAttributeData.StringMissingValue);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 13255, 13439);

                    string
                    f_10218_13298_13423(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                    fieldGetter, string
                    missingValue)
                    {
                        var return_v = this_param.GetWellKnownAttributeDataStringField(fieldGetter, missingValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 13298, 13423);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 13184, 13450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 13184, 13450);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string AssemblyCultureAttributeSetting
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 13533, 13674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 13569, 13659);

                    return f_10218_13576_13658(this, data => data.AssemblyCultureAttributeSetting);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 13533, 13674);

                    string
                    f_10218_13576_13658(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                    fieldGetter)
                    {
                        var return_v = this_param.GetWellKnownAttributeDataStringField(fieldGetter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 13576, 13658);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 13462, 13685);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 13462, 13685);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string SignatureKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 13748, 13894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 13784, 13879);

                    return f_10218_13791_13878(this, data => data.AssemblySignatureKeyAttributeSetting);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 13748, 13894);

                    string
                    f_10218_13791_13878(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, System.Func<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>, string>
                    fieldGetter)
                    {
                        var return_v = this_param.GetWellKnownAttributeDataStringField(fieldGetter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 13791, 13878);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 13697, 13905);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 13697, 13905);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Version AssemblyVersionAttributeSetting
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 13989, 14699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 14025, 14058);

                    var
                    defaultValue = (Version)null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 14076, 14106);

                    var
                    fieldValue = defaultValue
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 14126, 14178);

                    var
                    data = f_10218_14137_14177(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 14196, 14323) || true) && (data != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 14196, 14323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 14254, 14304);

                        fieldValue = f_10218_14267_14303(data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 14196, 14323);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 14343, 14646) || true) && (fieldValue == defaultValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 14343, 14646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 14415, 14466);

                        data = f_10218_14422_14465(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 14488, 14627) || true) && (data != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 14488, 14627);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 14554, 14604);

                            fieldValue = f_10218_14567_14603(data);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 14488, 14627);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 14343, 14646);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 14666, 14684);

                    return fieldValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 13989, 14699);

                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10218_14137_14177(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetSourceDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 14137, 14177);
                        return return_v;
                    }


                    System.Version
                    f_10218_14267_14303(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.AssemblyVersionAttributeSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 14267, 14303);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10218_14422_14465(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetNetModuleDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 14422, 14465);
                        return return_v;
                    }


                    System.Version
                    f_10218_14567_14603(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.AssemblyVersionAttributeSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 14567, 14603);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 13917, 14710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 13917, 14710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Version AssemblyVersionPattern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 14793, 15068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 14829, 14882);

                    var
                    attributeValue = f_10218_14850_14881()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 14900, 15053);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10218, 14907, 15028) || (((object)attributeValue == null || (DynAbs.Tracing.TraceSender.Expression_False(10218, 14907, 15028) || (f_10218_14942_14962(attributeValue) != ushort.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(10218, 14942, 15027) && f_10218_14985_15008(attributeValue) != ushort.MaxValue))) && DynAbs.Tracing.TraceSender.Conditional_F2(10218, 15031, 15035)) || DynAbs.Tracing.TraceSender.Conditional_F3(10218, 15038, 15052))) ? null : attributeValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 14793, 15068);

                    System.Version
                    f_10218_14850_14881()
                    {
                        var return_v = AssemblyVersionAttributeSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 14850, 14881);
                        return return_v;
                    }


                    int
                    f_10218_14942_14962(System.Version
                    this_param)
                    {
                        var return_v = this_param.Build;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 14942, 14962);
                        return return_v;
                    }


                    int
                    f_10218_14985_15008(System.Version
                    this_param)
                    {
                        var return_v = this_param.Revision;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 14985, 15008);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 14722, 15079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 14722, 15079);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AssemblyHashAlgorithm HashAlgorithm
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 15158, 15282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 15194, 15267);

                    return f_10218_15201_15236() ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Reflection.AssemblyHashAlgorithm?>(10218, 15201, 15266) ?? AssemblyHashAlgorithm.Sha1);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 15158, 15282);

                    System.Reflection.AssemblyHashAlgorithm?
                    f_10218_15201_15236()
                    {
                        var return_v = AssemblyAlgorithmIdAttributeSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 15201, 15236);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 15091, 15293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 15091, 15293);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal AssemblyHashAlgorithm? AssemblyAlgorithmIdAttributeSetting
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 15397, 16074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 15433, 15479);

                    var
                    fieldValue = (AssemblyHashAlgorithm?)null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 15499, 15551);

                    var
                    data = f_10218_15510_15550(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 15569, 15700) || true) && (data != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 15569, 15700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 15627, 15681);

                        fieldValue = f_10218_15640_15680(data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 15569, 15700);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 15720, 16021) || true) && (f_10218_15724_15744_M(!fieldValue.HasValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 15720, 16021);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 15786, 15837);

                        data = f_10218_15793_15836(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 15859, 16002) || true) && (data != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 15859, 16002);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 15925, 15979);

                            fieldValue = f_10218_15938_15978(data);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 15859, 16002);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 15720, 16021);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 16041, 16059);

                    return fieldValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 15397, 16074);

                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10218_15510_15550(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetSourceDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 15510, 15550);
                        return return_v;
                    }


                    System.Reflection.AssemblyHashAlgorithm?
                    f_10218_15640_15680(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.AssemblyAlgorithmIdAttributeSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 15640, 15680);
                        return return_v;
                    }


                    bool
                    f_10218_15724_15744_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 15724, 15744);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10218_15793_15836(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetNetModuleDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 15793, 15836);
                        return return_v;
                    }


                    System.Reflection.AssemblyHashAlgorithm?
                    f_10218_15938_15978(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.AssemblyAlgorithmIdAttributeSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 15938, 15978);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 15305, 16085);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 15305, 16085);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AssemblyFlags AssemblyFlags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 16389, 16998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 16425, 16467);

                    var
                    defaultValue = default(AssemblyFlags)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 16485, 16515);

                    var
                    fieldValue = defaultValue
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 16535, 16587);

                    var
                    data = f_10218_16546_16586(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 16605, 16730) || true) && (data != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 16605, 16730);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 16663, 16711);

                        fieldValue = f_10218_16676_16710(data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 16605, 16730);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 16750, 16801);

                    data = f_10218_16757_16800(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 16819, 16945) || true) && (data != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 16819, 16945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 16877, 16926);

                        fieldValue |= f_10218_16891_16925(data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 16819, 16945);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 16965, 16983);

                    return fieldValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 16389, 16998);

                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10218_16546_16586(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetSourceDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 16546, 16586);
                        return return_v;
                    }


                    System.Reflection.AssemblyFlags
                    f_10218_16676_16710(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.AssemblyFlagsAttributeSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 16676, 16710);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10218_16757_16800(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetNetModuleDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 16757, 16800);
                        return return_v;
                    }


                    System.Reflection.AssemblyFlags
                    f_10218_16891_16925(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.AssemblyFlagsAttributeSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 16891, 16925);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 16330, 17009);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 16330, 17009);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private StrongNameKeys ComputeStrongNameKeys()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 17021, 19527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 17405, 17432);

                f_10218_17405_17431(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 17536, 17588);

                string
                keyFile = f_10218_17553_17587(f_10218_17553_17573(_compilation))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 17651, 18542) || true) && (f_10218_17655_17694(f_10218_17655_17683(f_10218_17655_17675())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 17651, 18542);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 17998, 18361) || true) && (!f_10218_18003_18032(keyFile) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 18002, 18070) && !f_10218_18037_18070(keyFile)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 17998, 18361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 18234, 18293);

                        f_10218_18234_18292(f_10218_18247_18291_M(!f_10218_18248_18276(f_10218_18248_18268()).Errors.IsEmpty));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 18315, 18342);

                        return StrongNameKeys.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 17998, 18361);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 18463, 18527);

                    return f_10218_18470_18526(keyFile, MessageProvider.Instance);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 17651, 18542);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 18558, 18855) || true) && (f_10218_18562_18591(keyFile))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 18558, 18855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 18625, 18672);

                    keyFile = f_10218_18635_18671(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 18692, 18840) || true) && ((object)keyFile == (object)WellKnownAttributeData.StringMissingValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 18692, 18840);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 18806, 18821);

                        keyFile = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 18692, 18840);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 18558, 18855);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 18871, 18933);

                string
                keyContainer = f_10218_18893_18932(f_10218_18893_18913(_compilation))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 18949, 19271) || true) && (f_10218_18953_18987(keyContainer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 18949, 19271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 19021, 19078);

                    keyContainer = f_10218_19036_19077(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 19098, 19256) || true) && ((object)keyContainer == (object)WellKnownAttributeData.StringMissingValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 19098, 19256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 19217, 19237);

                        keyContainer = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 19098, 19256);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 18949, 19271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 19287, 19354);

                var
                hasCounterSignature = !f_10218_19314_19353(f_10218_19335_19352(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 19368, 19516);

                return f_10218_19375_19515(f_10218_19397_19444(f_10218_19397_19425(f_10218_19397_19417())), keyFile, keyContainer, hasCounterSignature, MessageProvider.Instance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 17021, 19527);

                int
                f_10218_17405_17431(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    this_param.EnsureAttributesAreBound();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 17405, 17431);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_17553_17573(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 17553, 17573);
                    return return_v;
                }


                string?
                f_10218_17553_17587(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 17553, 17587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10218_17655_17675()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 17655, 17675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_17655_17683(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 17655, 17683);
                    return return_v;
                }


                bool
                f_10218_17655_17694(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.PublicSign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 17655, 17694);
                    return return_v;
                }


                bool
                f_10218_18003_18032(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 18003, 18032);
                    return return_v;
                }


                bool
                f_10218_18037_18070(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 18037, 18070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10218_18248_18268()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 18248, 18268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_18248_18276(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 18248, 18276);
                    return return_v;
                }


                bool
                f_10218_18247_18291_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 18247, 18291);
                    return return_v;
                }


                int
                f_10218_18234_18292(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 18234, 18292);
                    return 0;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_10218_18470_18526(string?
                keyFilePath, Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider)
                {
                    var return_v = StrongNameKeys.Create(keyFilePath, (Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 18470, 18526);
                    return return_v;
                }


                bool
                f_10218_18562_18591(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 18562, 18591);
                    return return_v;
                }


                string
                f_10218_18635_18671(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.AssemblyKeyFileAttributeSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 18635, 18671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_18893_18913(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 18893, 18913);
                    return return_v;
                }


                string?
                f_10218_18893_18932(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 18893, 18932);
                    return return_v;
                }


                bool
                f_10218_18953_18987(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 18953, 18987);
                    return return_v;
                }


                string
                f_10218_19036_19077(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.AssemblyKeyContainerAttributeSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 19036, 19077);
                    return return_v;
                }


                string
                f_10218_19335_19352(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.SignatureKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 19335, 19352);
                    return return_v;
                }


                bool
                f_10218_19314_19353(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 19314, 19353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10218_19397_19417()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 19397, 19417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_19397_19425(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 19397, 19425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameProvider?
                f_10218_19397_19444(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.StrongNameProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 19397, 19444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_10218_19375_19515(Microsoft.CodeAnalysis.StrongNameProvider?
                providerOpt, string?
                keyFilePath, string?
                keyContainerName, bool
                hasCounterSignature, Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider)
                {
                    var return_v = StrongNameKeys.Create(providerOpt, keyFilePath, keyContainerName, hasCounterSignature, (Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 19375, 19515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 17021, 19527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 17021, 19527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ConcurrentDictionary<AssemblySymbol, bool> _optimisticallyGrantedInternalsAccess;

        [ThreadStatic]
        private static AssemblySymbol t_assemblyForWhichCurrentThreadIsComputingKeys;

        internal StrongNameKeys StrongNameKeys
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 20126, 20710);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 20162, 20648) || true) && (_lazyStrongNameKeys == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 20162, 20648);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 20287, 20341);

                            t_assemblyForWhichCurrentThreadIsComputingKeys = this;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 20367, 20451);

                            f_10218_20367_20450(ref _lazyStrongNameKeys, f_10218_20420_20443(this), null);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(10218, 20496, 20629);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 20552, 20606);

                            t_assemblyForWhichCurrentThreadIsComputingKeys = null;
                            DynAbs.Tracing.TraceSender.TraceExitFinally(10218, 20496, 20629);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 20162, 20648);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 20668, 20695);

                    return _lazyStrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 20126, 20710);

                    Microsoft.CodeAnalysis.StrongNameKeys
                    f_10218_20420_20443(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.ComputeStrongNameKeys();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 20420, 20443);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.StrongNameKeys?
                    f_10218_20367_20450(ref Microsoft.CodeAnalysis.StrongNameKeys?
                    location1, Microsoft.CodeAnalysis.StrongNameKeys
                    value, Microsoft.CodeAnalysis.StrongNameKeys?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 20367, 20450);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 20063, 20721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 20063, 20721);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<byte> PublicKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 20806, 20846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 20812, 20844);

                    return f_10218_20819_20833().PublicKey;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 20806, 20846);

                    Microsoft.CodeAnalysis.StrongNameKeys
                    f_10218_20819_20833()
                    {
                        var return_v = StrongNameKeys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 20819, 20833);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 20733, 20857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 20733, 20857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ModuleSymbol> Modules
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 20946, 21013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 20982, 20998);

                    return _modules;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 20946, 21013);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 20869, 21024);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 20869, 21024);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 21134, 21248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 21170, 21233);

                    return f_10218_21177_21232(f_10218_21177_21218(this.Modules, m => m.Locations));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 21134, 21248);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>
                    f_10218_21177_21218(/*ref LAFHIS*/ System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>>
                    selector)
                    {
                        var return_v = source.SelectMany<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol, Microsoft.CodeAnalysis.Location>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 21177, 21218);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10218_21177_21232(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>
                    items)
                    {
                        var return_v = items.AsImmutable<Microsoft.CodeAnalysis.Location>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 21177, 21232);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 21059, 21259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 21059, 21259);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void ValidateAttributeSemantics(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 21271, 23807);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 21524, 21709) || true) && (f_10218_21528_21542().DiagnosticOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10218, 21528, 21614) && !f_10218_21569_21614(f_10218_21569_21600(f_10218_21569_21589(_compilation)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 21524, 21709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 21648, 21694);

                    f_10218_21648_21693(diagnostics, f_10218_21664_21678().DiagnosticOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 21524, 21709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 21725, 21760);

                f_10218_21725_21759(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 21889, 21933);

                f_10218_21889_21932(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 21949, 21996);

                f_10218_21949_21995(this, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 22012, 22175) || true) && (f_10218_22016_22029() && (DynAbs.Tracing.TraceSender.Expression_True(10218, 22016, 22055) && f_10218_22033_22055_M(!f_10218_22034_22042().HasPublicKey)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 22012, 22175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 22089, 22160);

                    f_10218_22089_22159(diagnostics, ErrorCode.WRN_DelaySignButNoKey, NoLocation.Singleton);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 22012, 22175);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 22191, 22648) || true) && (f_10218_22195_22234(f_10218_22195_22223(f_10218_22195_22215())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 22191, 22648);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 22268, 22633) || true) && (f_10218_22272_22317(f_10218_22272_22303(f_10218_22272_22292(_compilation))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 22268, 22633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 22359, 22432);

                        f_10218_22359_22431(diagnostics, ErrorCode.ERR_PublicSignNetModule, NoLocation.Singleton);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 22268, 22633);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 22268, 22633);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 22474, 22633) || true) && (f_10218_22478_22500_M(!f_10218_22479_22487().HasPublicKey))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 22474, 22633);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 22542, 22614);

                            f_10218_22542_22613(diagnostics, ErrorCode.ERR_PublicSignButNoKey, NoLocation.Singleton);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 22474, 22633);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 22268, 22633);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 22191, 22648);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 23054, 23711) || true) && (f_10218_23058_23097(f_10218_23058_23086(f_10218_23058_23078())) != OutputKind.NetModule && (DynAbs.Tracing.TraceSender.Expression_True(10218, 23058, 23194) && f_10218_23142_23170(f_10218_23142_23162()).CryptoPublicKey.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 23058, 23236) && f_10218_23215_23236(f_10218_23215_23223())) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 23058, 23271) && f_10218_23257_23271_M(!IsDelaySigned)) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 23058, 23332) && f_10218_23292_23332_M(!f_10218_23293_23321(f_10218_23293_23313()).PublicSign)) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 23058, 23376) && f_10218_23353_23376_M(!f_10218_23354_23368().CanSign)) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 23058, 23433) && f_10218_23397_23411().DiagnosticOpt == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 23054, 23711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 23595, 23696);

                    f_10218_23595_23695(                // Since the container always contains both keys, the problem is that the key file didn't contain private key.
                                    diagnostics, ErrorCode.ERR_SignButNoPrivateKey, NoLocation.Singleton, f_10218_23668_23682().KeyFilePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 23054, 23711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 23727, 23796);

                f_10218_23727_23795(_compilation, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 21271, 23807);

                Microsoft.CodeAnalysis.StrongNameKeys
                f_10218_21528_21542()
                {
                    var return_v = StrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 21528, 21542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_21569_21589(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 21569, 21589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_21569_21600(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 21569, 21600);
                    return return_v;
                }


                bool
                f_10218_21569_21614(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 21569, 21614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_10218_21664_21678()
                {
                    var return_v = StrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 21664, 21678);
                    return return_v;
                }


                int
                f_10218_21648_21693(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 21648, 21693);
                    return 0;
                }


                int
                f_10218_21725_21759(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ValidateIVTPublicKeys(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 21725, 21759);
                    return 0;
                }


                int
                f_10218_21889_21932(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.CheckOptimisticIVTAccessGrants(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 21889, 21932);
                    return 0;
                }


                int
                f_10218_21949_21995(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.DetectAttributeAndOptionConflicts(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 21949, 21995);
                    return 0;
                }


                bool
                f_10218_22016_22029()
                {
                    var return_v = IsDelaySigned;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 22016, 22029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10218_22034_22042()
                {
                    var return_v = Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 22034, 22042);
                    return return_v;
                }


                bool
                f_10218_22033_22055_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 22033, 22055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_22089_22159(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 22089, 22159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10218_22195_22215()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 22195, 22215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_22195_22223(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 22195, 22223);
                    return return_v;
                }


                bool
                f_10218_22195_22234(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.PublicSign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 22195, 22234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_22272_22292(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 22272, 22292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_22272_22303(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 22272, 22303);
                    return return_v;
                }


                bool
                f_10218_22272_22317(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 22272, 22317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_22359_22431(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 22359, 22431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10218_22479_22487()
                {
                    var return_v = Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 22479, 22487);
                    return return_v;
                }


                bool
                f_10218_22478_22500_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 22478, 22500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_22542_22613(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 22542, 22613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10218_23058_23078()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23058, 23078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_23058_23086(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23058, 23086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_23058_23097(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23058, 23097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10218_23142_23162()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23142, 23162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_23142_23170(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23142, 23170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10218_23215_23223()
                {
                    var return_v = Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23215, 23223);
                    return return_v;
                }


                bool
                f_10218_23215_23236(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.HasPublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23215, 23236);
                    return return_v;
                }


                bool
                f_10218_23257_23271_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23257, 23271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10218_23293_23313()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23293, 23313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_23293_23321(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23293, 23321);
                    return return_v;
                }


                bool
                f_10218_23292_23332_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23292, 23332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_10218_23354_23368()
                {
                    var return_v = StrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23354, 23368);
                    return return_v;
                }


                bool
                f_10218_23353_23376_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23353, 23376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_10218_23397_23411()
                {
                    var return_v = StrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23397, 23411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_10218_23668_23682()
                {
                    var return_v = StrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 23668, 23682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_23595_23695(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 23595, 23695);
                    return return_v;
                }


                int
                f_10218_23727_23795(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportDiagnosticsForSynthesizedAttributes(compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 23727, 23795);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 21271, 23807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 21271, 23807);
            }
        }

        private static void ReportDiagnosticsForSynthesizedAttributes(CSharpCompilation compilation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10218, 24539, 26838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 24683, 24757);

                f_10218_24683_24756(compilation, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 24773, 24839);

                CSharpCompilationOptions
                compilationOptions = f_10218_24819_24838(compilation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 24853, 26827) || true) && (!f_10218_24858_24901(f_10218_24858_24887(compilationOptions)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 24853, 26827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 24935, 25088);

                    TypeSymbol
                    compilationRelaxationsAttribute = f_10218_24980_25087(compilation, WellKnownType.System_Runtime_CompilerServices_CompilationRelaxationsAttribute)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 25106, 25215);

                    f_10218_25106_25214((object)compilationRelaxationsAttribute != null, "GetWellKnownType unexpectedly returned null");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 25233, 25745) || true) && (!(compilationRelaxationsAttribute is MissingMetadataTypeSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 25233, 25745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 25507, 25726);

                        f_10218_25507_25725(compilation, WellKnownMember.System_Runtime_CompilerServices_CompilationRelaxationsAttribute__ctorInt32, diagnostics, NoLocation.Singleton);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 25233, 25745);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 25765, 25914);

                    TypeSymbol
                    runtimeCompatibilityAttribute = f_10218_25808_25913(compilation, WellKnownType.System_Runtime_CompilerServices_RuntimeCompatibilityAttribute)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 25932, 26039);

                    f_10218_25932_26038((object)runtimeCompatibilityAttribute != null, "GetWellKnownType unexpectedly returned null");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 26057, 26812) || true) && (!(runtimeCompatibilityAttribute is MissingMetadataTypeSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 26057, 26812);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 26327, 26539);

                        f_10218_26327_26538(compilation, WellKnownMember.System_Runtime_CompilerServices_RuntimeCompatibilityAttribute__ctor, diagnostics, NoLocation.Singleton);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 26563, 26793);

                        f_10218_26563_26792(compilation, WellKnownMember.System_Runtime_CompilerServices_RuntimeCompatibilityAttribute__WrapNonExceptionThrows, diagnostics, NoLocation.Singleton);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 26057, 26812);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 24853, 26827);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10218, 24539, 26838);

                int
                f_10218_24683_24756(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportDiagnosticsForUnsafeSynthesizedAttributes(compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 24683, 24756);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_24819_24838(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 24819, 24838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_24858_24887(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 24858, 24887);
                    return return_v;
                }


                bool
                f_10218_24858_24901(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 24858, 24901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_24980_25087(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 24980, 25087);
                    return return_v;
                }


                int
                f_10218_25106_25214(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 25106, 25214);
                    return 0;
                }


                int
                f_10218_25507_25725(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                attributeMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    Binder.ReportUseSiteDiagnosticForSynthesizedAttribute(compilation, attributeMember, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 25507, 25725);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_25808_25913(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 25808, 25913);
                    return return_v;
                }


                int
                f_10218_25932_26038(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 25932, 26038);
                    return 0;
                }


                int
                f_10218_26327_26538(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                attributeMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    Binder.ReportUseSiteDiagnosticForSynthesizedAttribute(compilation, attributeMember, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 26327, 26538);
                    return 0;
                }


                int
                f_10218_26563_26792(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                attributeMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    Binder.ReportUseSiteDiagnosticForSynthesizedAttribute(compilation, attributeMember, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 26563, 26792);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 24539, 26838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 24539, 26838);
            }
        }

        private static void ReportDiagnosticsForUnsafeSynthesizedAttributes(CSharpCompilation compilation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10218, 27703, 30278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 27853, 27919);

                CSharpCompilationOptions
                compilationOptions = f_10218_27899_27918(compilation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 27933, 28024) || true) && (f_10218_27937_27968_M(!compilationOptions.AllowUnsafe))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 27933, 28024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 28002, 28009);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 27933, 28024);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 28040, 28165);

                TypeSymbol
                unverifiableCodeAttribute = f_10218_28079_28164(compilation, WellKnownType.System_Security_UnverifiableCodeAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 28179, 28282);

                f_10218_28179_28281((object)unverifiableCodeAttribute != null, "GetWellKnownType unexpectedly returned null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 28296, 28410) || true) && (unverifiableCodeAttribute is MissingMetadataTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 28296, 28410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 28388, 28395);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 28296, 28410);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 28593, 28777);

                f_10218_28593_28776(compilation, WellKnownMember.System_Security_UnverifiableCodeAttribute__ctor, diagnostics, NoLocation.Singleton);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 28795, 28936);

                TypeSymbol
                securityPermissionAttribute = f_10218_28836_28935(compilation, WellKnownType.System_Security_Permissions_SecurityPermissionAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 28950, 29055);

                f_10218_28950_29054((object)securityPermissionAttribute != null, "GetWellKnownType unexpectedly returned null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 29069, 29185) || true) && (securityPermissionAttribute is MissingMetadataTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 29069, 29185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 29163, 29170);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 29069, 29185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 29201, 29316);

                TypeSymbol
                securityAction = f_10218_29229_29315(compilation, WellKnownType.System_Security_Permissions_SecurityAction)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 29330, 29422);

                f_10218_29330_29421((object)securityAction != null, "GetWellKnownType unexpectedly returned null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 29436, 29539) || true) && (securityAction is MissingMetadataTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 29436, 29539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 29517, 29524);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 29436, 29539);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 29772, 29970);

                f_10218_29772_29969(compilation, WellKnownMember.System_Security_Permissions_SecurityPermissionAttribute__ctor, diagnostics, NoLocation.Singleton);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 30057, 30267);

                f_10218_30057_30266(compilation, WellKnownMember.System_Security_Permissions_SecurityPermissionAttribute__SkipVerification, diagnostics, NoLocation.Singleton);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10218, 27703, 30278);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_27899_27918(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 27899, 27918);
                    return return_v;
                }


                bool
                f_10218_27937_27968_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 27937, 27968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_28079_28164(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 28079, 28164);
                    return return_v;
                }


                int
                f_10218_28179_28281(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 28179, 28281);
                    return 0;
                }


                int
                f_10218_28593_28776(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                attributeMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    Binder.ReportUseSiteDiagnosticForSynthesizedAttribute(compilation, attributeMember, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 28593, 28776);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_28836_28935(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 28836, 28935);
                    return return_v;
                }


                int
                f_10218_28950_29054(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 28950, 29054);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_29229_29315(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 29229, 29315);
                    return return_v;
                }


                int
                f_10218_29330_29421(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 29330, 29421);
                    return 0;
                }


                int
                f_10218_29772_29969(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                attributeMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    Binder.ReportUseSiteDiagnosticForSynthesizedAttribute(compilation, attributeMember, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 29772, 29969);
                    return 0;
                }


                int
                f_10218_30057_30266(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                attributeMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    Binder.ReportUseSiteDiagnosticForSynthesizedAttribute(compilation, attributeMember, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 30057, 30266);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 27703, 30278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 27703, 30278);
            }
        }

        private void ValidateIVTPublicKeys(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 30290, 31012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 30376, 30403);

                f_10218_30376_30402(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 30419, 30476) || true) && (f_10218_30423_30450_M(!f_10218_30424_30437(this).IsStrongName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 30419, 30476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 30469, 30476);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 30419, 30476);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 30492, 31001) || true) && (_lazyInternalsVisibleToMap != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 30492, 31001);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 30564, 30986);
                        foreach (var keys in f_10218_30585_30618_I(f_10218_30585_30618(_lazyInternalsVisibleToMap)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 30564, 30986);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 30660, 30967);
                                foreach (var oneKey in f_10218_30683_30687_I(keys))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 30660, 30967);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 30737, 30944) || true) && (oneKey.Key.IsDefaultOrEmpty)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 30737, 30944);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 30826, 30917);

                                        f_10218_30826_30916(diagnostics, ErrorCode.ERR_FriendAssemblySNReq, f_10218_30877_30895(oneKey.Value), f_10218_30897_30915(oneKey.Value));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 30737, 30944);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 30660, 30967);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 308);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 308);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 30564, 30986);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 423);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 423);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 30492, 31001);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 30290, 31012);

                int
                f_10218_30376_30402(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    this_param.EnsureAttributesAreBound();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 30376, 30402);
                    return 0;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10218_30424_30437(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 30424, 30437);
                    return return_v;
                }


                bool
                f_10218_30423_30450_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 30423, 30450);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>
                f_10218_30585_30618(System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 30585, 30618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_30877_30895(System.Tuple<Microsoft.CodeAnalysis.Location, string>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 30877, 30895);
                    return return_v;
                }


                string
                f_10218_30897_30915(System.Tuple<Microsoft.CodeAnalysis.Location, string>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 30897, 30915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_30826_30916(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 30826, 30916);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>
                f_10218_30683_30687_I(System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 30683, 30687);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>
                f_10218_30585_30618_I(System.Collections.Generic.ICollection<System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 30585, 30618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 30290, 31012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 30290, 31012);
            }
        }

        public bool InternalsAreVisible
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 31388, 31526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 31424, 31451);

                    f_10218_31424_31450(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 31469, 31511);

                    return _lazyInternalsVisibleToMap != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 31388, 31526);

                    int
                    f_10218_31424_31450(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        this_param.EnsureAttributesAreBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 31424, 31450);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 31332, 31537);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 31332, 31537);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void DetectAttributeAndOptionConflicts(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 31549, 38623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 31647, 31674);

                f_10218_31647_31673(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 31690, 31776);

                ThreeState
                assemblyDelaySignAttributeSetting = f_10218_31737_31775(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 31790, 32217) || true) && (f_10218_31794_31833(f_10218_31794_31824(f_10218_31794_31814(_compilation))) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 31794, 31894) && (assemblyDelaySignAttributeSetting != ThreeState.Unknown)) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 31794, 32019) && (f_10218_31916_31960(f_10218_31916_31954(f_10218_31916_31944(f_10218_31916_31936()))) != (assemblyDelaySignAttributeSetting == ThreeState.True))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 31790, 32217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 32053, 32202);

                    f_10218_32053_32201(diagnostics, ErrorCode.WRN_CmdOptionConflictsSource, NoLocation.Singleton, "DelaySign", AttributeDescription.AssemblyDelaySignAttribute.FullName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 31790, 32217);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 32233, 32592) || true) && (f_10218_32237_32268(f_10218_32237_32257(_compilation)) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 32237, 32324) && assemblyDelaySignAttributeSetting == ThreeState.True))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 32233, 32592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 32358, 32577);

                    f_10218_32358_32576(diagnostics, ErrorCode.WRN_CmdOptionConflictsSource, NoLocation.Singleton, nameof(_compilation.Options.PublicSign), AttributeDescription.AssemblyDelaySignAttribute.FullName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 32233, 32592);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 32608, 35913) || true) && (!f_10218_32613_32674(f_10218_32634_32673(f_10218_32634_32654(_compilation))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 32608, 35913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 32708, 32796);

                    string
                    assemblyKeyContainerAttributeSetting = f_10218_32754_32795(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 32816, 35898) || true) && ((object)assemblyKeyContainerAttributeSetting == (object)CommonAssemblyWellKnownAttributeData.StringMissingValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 32816, 35898);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 32973, 33542) || true) && (f_10218_32977_33008(f_10218_32977_32997(_compilation)) == OutputKind.NetModule)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 32973, 33542);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 33263, 33519);

                            f_10218_33263_33518(_compilation, WellKnownMember.System_Reflection_AssemblyKeyNameAttribute__ctor, diagnostics, NoLocation.Singleton);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 32973, 33542);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 32816, 35898);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 32816, 35898);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 33584, 35898) || true) && (f_10218_33588_33717(f_10218_33603_33642(f_10218_33603_33623(_compilation)), assemblyKeyContainerAttributeSetting, StringComparison.OrdinalIgnoreCase) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 33584, 35898);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 35337, 35879) || true) && (f_10218_35341_35372(f_10218_35341_35361(_compilation)) == OutputKind.NetModule)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 35337, 35879);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 35446, 35602);

                                f_10218_35446_35601(diagnostics, ErrorCode.ERR_CmdOptionConflictsSource, NoLocation.Singleton, AttributeDescription.AssemblyKeyNameAttribute.FullName, "CryptoKeyContainer");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 35337, 35879);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 35337, 35879);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 35700, 35856);

                                f_10218_35700_35855(diagnostics, ErrorCode.WRN_CmdOptionConflictsSource, NoLocation.Singleton, "CryptoKeyContainer", AttributeDescription.AssemblyKeyNameAttribute.FullName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 35337, 35879);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 33584, 35898);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 32816, 35898);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 32608, 35913);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 35929, 36360) || true) && (f_10218_35933_35964(f_10218_35933_35953(_compilation)) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 35933, 36031) && !f_10218_35986_36031(f_10218_35986_36017(f_10218_35986_36006(_compilation)))) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 35933, 36168) && (object)f_10218_36060_36101(this) != (object)CommonAssemblyWellKnownAttributeData.StringMissingValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 35929, 36360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 36202, 36345);

                    f_10218_36202_36344(diagnostics, ErrorCode.WRN_AttributeIgnoredWhenPublicSigning, NoLocation.Singleton, AttributeDescription.AssemblyKeyNameAttribute.FullName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 35929, 36360);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 36376, 38170) || true) && (!f_10218_36381_36437(f_10218_36402_36436(f_10218_36402_36422(_compilation))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 36376, 38170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 36471, 36549);

                    string
                    assemblyKeyFileAttributeSetting = f_10218_36512_36548(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 36569, 38155) || true) && ((object)assemblyKeyFileAttributeSetting == (object)CommonAssemblyWellKnownAttributeData.StringMissingValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 36569, 38155);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 36721, 37290) || true) && (f_10218_36725_36756(f_10218_36725_36745(_compilation)) == OutputKind.NetModule)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 36721, 37290);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 37011, 37267);

                            f_10218_37011_37266(_compilation, WellKnownMember.System_Reflection_AssemblyKeyFileAttribute__ctor, diagnostics, NoLocation.Singleton);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 36721, 37290);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 36569, 38155);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 36569, 38155);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 37332, 38155) || true) && (f_10218_37336_37455(f_10218_37351_37385(f_10218_37351_37371(_compilation)), assemblyKeyFileAttributeSetting, StringComparison.OrdinalIgnoreCase) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 37332, 38155);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 37604, 38136) || true) && (f_10218_37608_37639(f_10218_37608_37628(_compilation)) == OutputKind.NetModule)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 37604, 38136);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 37713, 37864);

                                f_10218_37713_37863(diagnostics, ErrorCode.ERR_CmdOptionConflictsSource, NoLocation.Singleton, AttributeDescription.AssemblyKeyFileAttribute.FullName, "CryptoKeyFile");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 37604, 38136);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 37604, 38136);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 37962, 38113);

                                f_10218_37962_38112(diagnostics, ErrorCode.WRN_CmdOptionConflictsSource, NoLocation.Singleton, "CryptoKeyFile", AttributeDescription.AssemblyKeyFileAttribute.FullName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 37604, 38136);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 37332, 38155);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 36569, 38155);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 36376, 38170);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 38186, 38612) || true) && (f_10218_38190_38221(f_10218_38190_38210(_compilation)) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 38190, 38288) && !f_10218_38243_38288(f_10218_38243_38274(f_10218_38243_38263(_compilation)))) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 38190, 38420) && (object)f_10218_38317_38353(this) != (object)CommonAssemblyWellKnownAttributeData.StringMissingValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 38186, 38612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 38454, 38597);

                    f_10218_38454_38596(diagnostics, ErrorCode.WRN_AttributeIgnoredWhenPublicSigning, NoLocation.Singleton, AttributeDescription.AssemblyKeyFileAttribute.FullName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 38186, 38612);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 31549, 38623);

                int
                f_10218_31647_31673(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    this_param.EnsureAttributesAreBound();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 31647, 31673);
                    return 0;
                }


                Microsoft.CodeAnalysis.ThreeState
                f_10218_31737_31775(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.AssemblyDelaySignAttributeSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 31737, 31775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_31794_31814(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 31794, 31814);
                    return return_v;
                }


                bool?
                f_10218_31794_31824(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.DelaySign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 31794, 31824);
                    return return_v;
                }


                bool
                f_10218_31794_31833(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 31794, 31833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10218_31916_31936()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 31916, 31936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_31916_31944(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 31916, 31944);
                    return return_v;
                }


                bool?
                f_10218_31916_31954(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.DelaySign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 31916, 31954);
                    return return_v;
                }


                bool
                f_10218_31916_31960(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 31916, 31960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_32053_32201(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 32053, 32201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_32237_32257(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 32237, 32257);
                    return return_v;
                }


                bool
                f_10218_32237_32268(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.PublicSign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 32237, 32268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_32358_32576(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 32358, 32576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_32634_32654(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 32634, 32654);
                    return return_v;
                }


                string?
                f_10218_32634_32673(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 32634, 32673);
                    return return_v;
                }


                bool
                f_10218_32613_32674(string?
                value)
                {
                    var return_v = String.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 32613, 32674);
                    return return_v;
                }


                string
                f_10218_32754_32795(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.AssemblyKeyContainerAttributeSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 32754, 32795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_32977_32997(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 32977, 32997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_32977_33008(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 32977, 33008);
                    return return_v;
                }


                int
                f_10218_33263_33518(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                attributeMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    Binder.ReportUseSiteDiagnosticForSynthesizedAttribute(compilation, attributeMember, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 33263, 33518);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_33603_33623(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 33603, 33623);
                    return return_v;
                }


                string
                f_10218_33603_33642(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 33603, 33642);
                    return return_v;
                }


                int
                f_10218_33588_33717(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = String.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 33588, 33717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_35341_35361(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 35341, 35361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_35341_35372(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 35341, 35372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_35446_35601(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 35446, 35601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_35700_35855(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 35700, 35855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_35933_35953(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 35933, 35953);
                    return return_v;
                }


                bool
                f_10218_35933_35964(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.PublicSign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 35933, 35964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_35986_36006(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 35986, 36006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_35986_36017(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 35986, 36017);
                    return return_v;
                }


                bool
                f_10218_35986_36031(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 35986, 36031);
                    return return_v;
                }


                string
                f_10218_36060_36101(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.AssemblyKeyContainerAttributeSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 36060, 36101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_36202_36344(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 36202, 36344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_36402_36422(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 36402, 36422);
                    return return_v;
                }


                string?
                f_10218_36402_36436(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 36402, 36436);
                    return return_v;
                }


                bool
                f_10218_36381_36437(string?
                value)
                {
                    var return_v = String.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 36381, 36437);
                    return return_v;
                }


                string
                f_10218_36512_36548(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.AssemblyKeyFileAttributeSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 36512, 36548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_36725_36745(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 36725, 36745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_36725_36756(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 36725, 36756);
                    return return_v;
                }


                int
                f_10218_37011_37266(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                attributeMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    Binder.ReportUseSiteDiagnosticForSynthesizedAttribute(compilation, attributeMember, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 37011, 37266);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_37351_37371(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 37351, 37371);
                    return return_v;
                }


                string
                f_10218_37351_37385(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 37351, 37385);
                    return return_v;
                }


                int
                f_10218_37336_37455(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = String.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 37336, 37455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_37608_37628(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 37608, 37628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_37608_37639(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 37608, 37639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_37713_37863(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 37713, 37863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_37962_38112(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 37962, 38112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_38190_38210(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 38190, 38210);
                    return return_v;
                }


                bool
                f_10218_38190_38221(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.PublicSign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 38190, 38221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_38243_38263(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 38243, 38263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_38243_38274(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 38243, 38274);
                    return return_v;
                }


                bool
                f_10218_38243_38288(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 38243, 38288);
                    return return_v;
                }


                string
                f_10218_38317_38353(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.AssemblyKeyFileAttributeSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 38317, 38353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_38454_38596(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 38454, 38596);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 31549, 38623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 31549, 38623);
            }
        }

        internal bool IsDelaySigned
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 38687, 39283);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 38824, 38972) || true) && (f_10218_38828_38867(f_10218_38828_38858(f_10218_38828_38848(_compilation))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 38824, 38972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 38909, 38953);

                        return f_10218_38916_38952(f_10218_38916_38946(f_10218_38916_38936(_compilation)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 38824, 38972);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 39072, 39181) || true) && (f_10218_39076_39107(f_10218_39076_39096(_compilation)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 39072, 39181);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 39149, 39162);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 39072, 39181);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 39201, 39268);

                    return (f_10218_39209_39247(this) == ThreeState.True);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 38687, 39283);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10218_38828_38848(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 38828, 38848);
                        return return_v;
                    }


                    bool?
                    f_10218_38828_38858(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.DelaySign;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 38828, 38858);
                        return return_v;
                    }


                    bool
                    f_10218_38828_38867(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 38828, 38867);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10218_38916_38936(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 38916, 38936);
                        return return_v;
                    }


                    bool?
                    f_10218_38916_38946(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.DelaySign;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 38916, 38946);
                        return return_v;
                    }


                    bool
                    f_10218_38916_38952(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 38916, 38952);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10218_39076_39096(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 39076, 39096);
                        return return_v;
                    }


                    bool
                    f_10218_39076_39107(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.PublicSign;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 39076, 39107);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_10218_39209_39247(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.AssemblyDelaySignAttributeSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 39209, 39247);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 38635, 39294);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 38635, 39294);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SourceModuleSymbol SourceModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 39371, 39422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 39377, 39420);

                    return (SourceModuleSymbol)f_10218_39404_39416(this)[0];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 39371, 39422);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10218_39404_39416(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 39404, 39416);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 39306, 39433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 39306, 39433);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool RequiresCompletion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 39511, 39531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 39517, 39529);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 39511, 39531);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 39445, 39542);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 39445, 39542);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasComplete(CompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 39554, 39677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 39634, 39666);

                return _state.HasComplete(part);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 39554, 39677);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 39554, 39677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 39554, 39677);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var incompletePart = _state.NextIncompletePart;
                switch (incompletePart)
                {
                    case CompletionPart.Attributes:
                        EnsureAttributesAreBound();
                        break;
                    case CompletionPart.StartAttributeChecks:
                    case CompletionPart.FinishAttributeChecks:
                        if (_state.NotePartComplete(CompletionPart.StartAttributeChecks))
                        {
                            var diagnostics = DiagnosticBag.GetInstance();
                            ValidateAttributeSemantics(diagnostics);
                            AddDeclarationDiagnostics(diagnostics);
                            var thisThreadCompleted = _state.NotePartComplete(CompletionPart.FinishAttributeChecks);
                            Debug.Assert(thisThreadCompleted);
                            diagnostics.Free();
                        }
                        break;
                    case CompletionPart.Module:
                        SourceModule.ForceComplete(locationOpt, cancellationToken);
                        if (SourceModule.HasComplete(CompletionPart.MembersCompleted))
                        {
                            _state.NotePartComplete(CompletionPart.Module);
                            break;
                        }
                        else
                        {
                            Debug.Assert(locationOpt != null, "If no location was specified, then the module members should be completed");
                            // this is the last completion part we can handle if there is a location.
                            return;
                        }

                    case CompletionPart.StartValidatingAddedModules:
                    case CompletionPart.FinishValidatingAddedModules:
                        if (_state.NotePartComplete(CompletionPart.StartValidatingAddedModules))
                        {
                            ReportDiagnosticsForAddedModules();
                            var thisThreadCompleted = _state.NotePartComplete(CompletionPart.FinishValidatingAddedModules);
                            Debug.Assert(thisThreadCompleted);
                        }
                        break;

                    case CompletionPart.None:
                        return;

                    default:
                        // any other values are completion parts intended for other kinds of symbols
                        _state.NotePartComplete(CompletionPart.All & ~CompletionPart.AssemblySymbolAll);
                        break;
                }

                _state.SpinWaitComplete(incompletePart, cancellationToken);
            }
        }

        private void ReportDiagnosticsForAddedModules()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 42747, 46944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 42819, 42865);

                var
                diagnostics = f_10218_42837_42864()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 42881, 43672);
                    foreach (var pair in f_10218_42902_42966_I(f_10218_42902_42966(f_10218_42902_42941(_compilation))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 42881, 43672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 43000, 43054);

                        var
                        fileRef = pair.Key as PortableExecutableReference
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 43074, 43657) || true) && ((object)fileRef != null && (DynAbs.Tracing.TraceSender.Expression_True(10218, 43078, 43137) && (object)f_10218_43113_43129(fileRef) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 43074, 43657);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 43179, 43245);

                            string
                            fileName = f_10218_43197_43244(f_10218_43227_43243(fileRef))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 43267, 43313);

                            string
                            moduleName = f_10218_43287_43312(_modules[pair.Value])
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 43337, 43638) || true) && (!f_10218_43342_43413(fileName, moduleName, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 43337, 43638);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 43518, 43615);

                                f_10218_43518_43614(                        // Used to be ERR_ALinkFailed
                                                        diagnostics, ErrorCode.ERR_NetModuleNameMismatch, NoLocation.Singleton, moduleName, fileName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 43337, 43638);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 43074, 43657);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 42881, 43672);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 792);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 792);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 43765, 46729) || true) && (_modules.Length > 1 && (DynAbs.Tracing.TraceSender.Expression_True(10218, 43769, 43838) && !f_10218_43793_43838(f_10218_43793_43824(f_10218_43793_43813(_compilation)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 43765, 46729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 43872, 43907);

                    var
                    assemblyMachine = f_10218_43894_43906(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 43925, 44045);

                    bool
                    isPlatformAgnostic = (assemblyMachine == System.Reflection.PortableExecutable.Machine.I386 && (DynAbs.Tracing.TraceSender.Expression_True(10218, 43952, 44043) && f_10218_44024_44043_M(!this.Bit32Required)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 44063, 44140);

                    var
                    knownModuleNames = f_10218_44086_44139(f_10218_44106_44138())
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 44169, 44174);

                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 44160, 45540) || true) && (i < _modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 44197, 44200)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 44160, 45540))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 44160, 45540);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 44242, 44271);

                            ModuleSymbol
                            m = _modules[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 44293, 44486) || true) && (!f_10218_44298_44326(knownModuleNames, f_10218_44319_44325(m)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 44293, 44486);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 44376, 44463);

                                f_10218_44376_44462(diagnostics, ErrorCode.ERR_NetModuleNameMustBeUnique, NoLocation.Singleton, f_10218_44455_44461(m));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 44293, 44486);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 44510, 45521) || true) && (f_10218_44514_44552_M(!f_10218_44515_44541(((PEModuleSymbol)m)).IsCOFFOnly))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 44510, 45521);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 44602, 44632);

                                var
                                moduleMachine = f_10218_44622_44631(m)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 44660, 45498) || true) && (moduleMachine == System.Reflection.PortableExecutable.Machine.I386 && (DynAbs.Tracing.TraceSender.Expression_True(10218, 44664, 44750) && f_10218_44734_44750_M(!m.Bit32Required)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 44660, 45498);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 44886, 44887);
                                    // Other module is agnostic, this is always safe
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 44660, 45498);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 44660, 45498);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 44945, 45498) || true) && (isPlatformAgnostic)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 44945, 45498);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 45025, 45105);

                                        f_10218_45025_45104(diagnostics, ErrorCode.ERR_AgnosticToMachineModule, NoLocation.Singleton, m);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 44945, 45498);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 44945, 45498);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 45163, 45498) || true) && (assemblyMachine != moduleMachine)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 45163, 45498);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 45390, 45471);

                                            f_10218_45390_45470(                            // Different machine types, and neither is agnostic
                                                                                            // So it is a conflict
                                                                        diagnostics, ErrorCode.ERR_ConflictingMachineModule, NoLocation.Singleton, m);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 45163, 45498);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 44945, 45498);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 44660, 45498);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 44510, 45521);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 1381);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 1381);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 45787, 45792);

                        // Assembly main module must explicitly reference all the modules referenced by other assembly 
                        // modules, i.e. all modules from transitive closure must be referenced explicitly here
                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 45778, 46714) || true) && (i < _modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 45815, 45818)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 45778, 46714))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 45778, 46714);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 45860, 45896);

                            var
                            m = (PEModuleSymbol)_modules[i]
                            ;

                            try
                            {
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 45972, 46457);
                                    foreach (var referencedModuleName in f_10218_46009_46054_I(f_10218_46009_46054(f_10218_46009_46017(m))))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 45972, 46457);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 46186, 46430) || true) && (f_10218_46190_46232(knownModuleNames, referencedModuleName))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 46186, 46430);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 46298, 46399);

                                            f_10218_46298_46398(diagnostics, ErrorCode.ERR_MissingNetModuleReference, NoLocation.Singleton, referencedModuleName);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 46186, 46430);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 45972, 46457);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 486);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 486);
                                }
                            }
                            catch (BadImageFormatException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(10218, 46502, 46695);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 46582, 46672);

                                f_10218_46582_46671(diagnostics, f_10218_46598_46648(ErrorCode.ERR_BindToBogus, m), NoLocation.Singleton);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(10218, 46502, 46695);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 937);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 937);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 43765, 46729);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 46745, 46826);

                f_10218_46745_46825(this, f_10218_46791_46811(this), diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 46842, 46900);

                f_10218_46842_46899(f_10218_46842_46877(_compilation), diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 46914, 46933);

                f_10218_46914_46932(diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 42747, 46944);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10218_42837_42864()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 42837, 42864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                f_10218_42902_42941(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetBoundReferenceManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 42902, 42941);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                f_10218_42902_42966(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                this_param)
                {
                    var return_v = this_param.ReferencedModuleIndexMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 42902, 42966);
                    return return_v;
                }


                string?
                f_10218_43113_43129(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 43113, 43129);
                    return return_v;
                }


                string
                f_10218_43227_43243(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 43227, 43243);
                    return return_v;
                }


                string?
                f_10218_43197_43244(string
                path)
                {
                    var return_v = FileNameUtilities.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 43197, 43244);
                    return return_v;
                }


                string
                f_10218_43287_43312(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 43287, 43312);
                    return return_v;
                }


                bool
                f_10218_43342_43413(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 43342, 43413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_43518_43614(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 43518, 43614);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                f_10218_42902_42966_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 42902, 42966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_43793_43813(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 43793, 43813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_43793_43824(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 43793, 43824);
                    return return_v;
                }


                bool
                f_10218_43793_43838(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 43793, 43838);
                    return return_v;
                }


                System.Reflection.PortableExecutable.Machine
                f_10218_43894_43906(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Machine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 43894, 43906);
                    return return_v;
                }


                bool
                f_10218_44024_44043_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 44024, 44043);
                    return return_v;
                }


                System.StringComparer
                f_10218_44106_44138()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 44106, 44138);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_10218_44086_44139(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 44086, 44139);
                    return return_v;
                }


                string
                f_10218_44319_44325(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 44319, 44325);
                    return return_v;
                }


                bool
                f_10218_44298_44326(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 44298, 44326);
                    return return_v;
                }


                string
                f_10218_44455_44461(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 44455, 44461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_44376_44462(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 44376, 44462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10218_44515_44541(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 44515, 44541);
                    return return_v;
                }


                bool
                f_10218_44514_44552_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 44514, 44552);
                    return return_v;
                }


                System.Reflection.PortableExecutable.Machine
                f_10218_44622_44631(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.Machine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 44622, 44631);
                    return return_v;
                }


                bool
                f_10218_44734_44750_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 44734, 44750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_45025_45104(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 45025, 45104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_45390_45470(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 45390, 45470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10218_46009_46017(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 46009, 46017);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10218_46009_46054(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.GetReferencedManagedModulesOrThrow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 46009, 46054);
                    return return_v;
                }


                bool
                f_10218_46190_46232(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 46190, 46232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_46298_46398(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 46298, 46398);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10218_46009_46054_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 46009, 46054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_46598_46648(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 46598, 46648);
                    return return_v;
                }


                int
                f_10218_46582_46671(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 46582, 46671);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10218_46791_46811(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 46791, 46811);
                    return return_v;
                }


                int
                f_10218_46745_46825(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                ns, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportNameCollisionDiagnosticsForAddedModules(ns, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 46745, 46825);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10218_46842_46877(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DeclarationDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 46842, 46877);
                    return return_v;
                }


                int
                f_10218_46842_46899(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 46842, 46899);
                    return 0;
                }


                int
                f_10218_46914_46932(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 46914, 46932);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 42747, 46944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 42747, 46944);
            }
        }

        private void ReportNameCollisionDiagnosticsForAddedModules(NamespaceSymbol ns, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 46956, 49781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 47086, 47129);

                var
                mergedNs = ns as MergedNamespaceSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 47145, 47229) || true) && ((object)mergedNs == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 47145, 47229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 47207, 47214);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 47145, 47229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 47245, 47322);

                ImmutableArray<NamespaceSymbol>
                constituent = f_10218_47291_47321(mergedNs)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 47338, 49770) || true) && (constituent.Length > 2 || (DynAbs.Tracing.TraceSender.Expression_False(10218, 47342, 47489) || (constituent.Length == 2 && (DynAbs.Tracing.TraceSender.Expression_True(10218, 47369, 47440) && f_10218_47396_47435(f_10218_47396_47427(constituent[0])) != 0) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 47369, 47488) && f_10218_47444_47483(f_10218_47444_47475(constituent[1])) != 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 47338, 49770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 47523, 47598);

                    var
                    topLevelTypesFromModules = f_10218_47554_47597()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 47618, 47974);
                        foreach (var moduleNs in f_10218_47643_47654_I(constituent))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 47618, 47974);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 47696, 47755);

                            f_10218_47696_47754(moduleNs.Extent.Kind == NamespaceKind.Module);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 47779, 47955) || true) && (f_10218_47783_47816(f_10218_47783_47808(moduleNs)) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 47779, 47955);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 47871, 47932);

                                f_10218_47871_47931(topLevelTypesFromModules, f_10218_47905_47930(moduleNs));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 47779, 47955);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 47618, 47974);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 357);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 357);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 47994, 48076);

                    f_10218_47994_48075(
                                    topLevelTypesFromModules, NameCollisionForAddedModulesTypeComparer.Singleton);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 48096, 48125);

                    bool
                    reportedAnError = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 48154, 48159);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 48145, 49328) || true) && (i < f_10218_48165_48195(topLevelTypesFromModules) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 48201, 48204)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 48145, 49328))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 48145, 49328);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 48246, 48294);

                            NamedTypeSymbol
                            x = f_10218_48266_48293(topLevelTypesFromModules, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 48316, 48368);

                            NamedTypeSymbol
                            y = f_10218_48336_48367(topLevelTypesFromModules, i + 1)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 48392, 49309) || true) && (f_10218_48396_48403(x) == f_10218_48407_48414(y) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 48396, 48434) && f_10218_48418_48424(x) == f_10218_48428_48434(y)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 48392, 49309);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 48484, 49164) || true) && (!reportedAnError)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 48484, 49164);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 48652, 49082) || true) && (f_10218_48656_48663(x) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(10218, 48656, 48712) || f_10218_48672_48712_M(!f_10218_48673_48694(x).IsGlobalNamespace)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 48656, 48736) || f_10218_48716_48722(x) != "<Module>"))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 48652, 49082);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 48802, 49051);

                                        f_10218_48802_49050(diagnostics, ErrorCode.ERR_DuplicateNameInNS, y.Locations.FirstOrNone(), f_10218_48927_48977(y, SymbolDisplayFormat.ShortFormat), f_10218_49028_49049(y));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 48652, 49082);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 49114, 49137);

                                    reportedAnError = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 48484, 49164);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 48392, 49309);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 48392, 49309);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 49262, 49286);

                                reportedAnError = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 48392, 49309);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 1184);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 1184);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 49348, 49380);

                    f_10218_49348_49379(
                                    topLevelTypesFromModules);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 49451, 49755);
                        foreach (Symbol member in f_10218_49477_49498_I(f_10218_49477_49498(mergedNs)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 49451, 49755);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 49540, 49736) || true) && (f_10218_49544_49555(member) == SymbolKind.Namespace)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 49540, 49736);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 49629, 49713);

                                f_10218_49629_49712(this, member, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 49540, 49736);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 49451, 49755);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 305);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 305);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 47338, 49770);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 46956, 49781);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10218_47291_47321(Microsoft.CodeAnalysis.CSharp.Symbols.MergedNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ConstituentNamespaces;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 47291, 47321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10218_47396_47427(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 47396, 47427);
                    return return_v;
                }


                int
                f_10218_47396_47435(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 47396, 47435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10218_47444_47475(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 47444, 47475);
                    return return_v;
                }


                int
                f_10218_47444_47483(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 47444, 47483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_47554_47597()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 47554, 47597);
                    return return_v;
                }


                int
                f_10218_47696_47754(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 47696, 47754);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10218_47783_47808(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 47783, 47808);
                    return return_v;
                }


                int
                f_10218_47783_47816(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 47783, 47816);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_47905_47930(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 47905, 47930);
                    return return_v;
                }


                int
                f_10218_47871_47931(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 47871, 47931);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10218_47643_47654_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 47643, 47654);
                    return return_v;
                }


                int
                f_10218_47994_48075(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol.NameCollisionForAddedModulesTypeComparer
                comparer)
                {
                    this_param.Sort((System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 47994, 48075);
                    return 0;
                }


                int
                f_10218_48165_48195(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 48165, 48195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_48266_48293(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 48266, 48293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_48336_48367(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 48336, 48367);
                    return return_v;
                }


                int
                f_10218_48396_48403(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 48396, 48403);
                    return return_v;
                }


                int
                f_10218_48407_48414(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 48407, 48414);
                    return return_v;
                }


                string
                f_10218_48418_48424(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 48418, 48424);
                    return return_v;
                }


                string
                f_10218_48428_48434(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 48428, 48434);
                    return return_v;
                }


                int
                f_10218_48656_48663(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 48656, 48663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10218_48673_48694(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 48673, 48694);
                    return return_v;
                }


                bool
                f_10218_48672_48712_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 48672, 48712);
                    return return_v;
                }


                string
                f_10218_48716_48722(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 48716, 48722);
                    return return_v;
                }


                string
                f_10218_48927_48977(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 48927, 48977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10218_49028_49049(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 49028, 49049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_48802_49050(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 48802, 49050);
                    return return_v;
                }


                int
                f_10218_49348_49379(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 49348, 49379);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10218_49477_49498(Microsoft.CodeAnalysis.CSharp.Symbols.MergedNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 49477, 49498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10218_49544_49555(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 49544, 49555);
                    return return_v;
                }


                int
                f_10218_49629_49712(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                ns, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportNameCollisionDiagnosticsForAddedModules((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)ns, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 49629, 49712);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10218_49477_49498_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 49477, 49498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 46956, 49781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 46956, 49781);
            }
        }
        private class NameCollisionForAddedModulesTypeComparer : IComparer<NamedTypeSymbol>
        {
            public static readonly NameCollisionForAddedModulesTypeComparer Singleton;

            private NameCollisionForAddedModulesTypeComparer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10218, 50040, 50094);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10218, 50040, 50094);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 50040, 50094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 50040, 50094);
                }
            }

            public int Compare(NamedTypeSymbol x, NamedTypeSymbol y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 50110, 50599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 50199, 50250);

                    int
                    result = f_10218_50212_50249(f_10218_50234_50240(x), f_10218_50242_50248(y))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 50270, 50550) || true) && (result == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 50270, 50550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 50327, 50354);

                        result = f_10218_50336_50343(x) - f_10218_50346_50353(y);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 50378, 50531) || true) && (result == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 50378, 50531);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 50443, 50508);

                            result = f_10218_50452_50478(f_10218_50452_50470(x)) - f_10218_50481_50507(f_10218_50481_50499(y));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 50378, 50531);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 50270, 50550);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 50570, 50584);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 50110, 50599);

                    string
                    f_10218_50234_50240(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 50234, 50240);
                        return return_v;
                    }


                    string
                    f_10218_50242_50248(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 50242, 50248);
                        return return_v;
                    }


                    int
                    f_10218_50212_50249(string
                    strA, string
                    strB)
                    {
                        var return_v = String.CompareOrdinal(strA, strB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 50212, 50249);
                        return return_v;
                    }


                    int
                    f_10218_50336_50343(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 50336, 50343);
                        return return_v;
                    }


                    int
                    f_10218_50346_50353(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 50346, 50353);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10218_50452_50470(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 50452, 50470);
                        return return_v;
                    }


                    int
                    f_10218_50452_50478(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 50452, 50478);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10218_50481_50499(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 50481, 50499);
                        return return_v;
                    }


                    int
                    f_10218_50481_50507(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 50481, 50507);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 50110, 50599);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 50110, 50599);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static NameCollisionForAddedModulesTypeComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10218, 49793, 50610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 49965, 50023);
                Singleton = f_10218_49977_50023(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10218, 49793, 50610);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 49793, 50610);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10218, 49793, 50610);

            static Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol.NameCollisionForAddedModulesTypeComparer
            f_10218_49977_50023()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol.NameCollisionForAddedModulesTypeComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 49977, 50023);
                return return_v;
            }

        }

        private bool IsKnownAssemblyAttribute(CSharpAttributeData attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 50622, 52868);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 50919, 52828) || true) && (f_10218_50923_51001(attribute, this, AttributeDescription.AssemblyTitleAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 51106) || f_10218_51022_51106(attribute, this, AttributeDescription.AssemblyDescriptionAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 51213) || f_10218_51127_51213(attribute, this, AttributeDescription.AssemblyConfigurationAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 51314) || f_10218_51234_51314(attribute, this, AttributeDescription.AssemblyCultureAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 51415) || f_10218_51335_51415(attribute, this, AttributeDescription.AssemblyVersionAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 51516) || f_10218_51436_51516(attribute, this, AttributeDescription.AssemblyCompanyAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 51617) || f_10218_51537_51617(attribute, this, AttributeDescription.AssemblyProductAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 51731) || f_10218_51638_51731(attribute, this, AttributeDescription.AssemblyInformationalVersionAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 51834) || f_10218_51752_51834(attribute, this, AttributeDescription.AssemblyCopyrightAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 51937) || f_10218_51855_51937(attribute, this, AttributeDescription.AssemblyTrademarkAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 52038) || f_10218_51958_52038(attribute, this, AttributeDescription.AssemblyKeyFileAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 52139) || f_10218_52059_52139(attribute, this, AttributeDescription.AssemblyKeyNameAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 52244) || f_10218_52160_52244(attribute, this, AttributeDescription.AssemblyAlgorithmIdAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 52343) || f_10218_52265_52343(attribute, this, AttributeDescription.AssemblyFlagsAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 52446) || f_10218_52364_52446(attribute, this, AttributeDescription.AssemblyDelaySignAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 52551) || f_10218_52467_52551(attribute, this, AttributeDescription.AssemblyFileVersionAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 52661) || f_10218_52572_52661(attribute, this, AttributeDescription.SatelliteContractVersionAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 50923, 52767) || f_10218_52682_52767(attribute, this, AttributeDescription.AssemblySignatureKeyAttribute)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 50919, 52828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 52801, 52813);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 50919, 52828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 52844, 52857);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 50622, 52868);

                bool
                f_10218_50923_51001(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 50923, 51001);
                    return return_v;
                }


                bool
                f_10218_51022_51106(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 51022, 51106);
                    return return_v;
                }


                bool
                f_10218_51127_51213(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 51127, 51213);
                    return return_v;
                }


                bool
                f_10218_51234_51314(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 51234, 51314);
                    return return_v;
                }


                bool
                f_10218_51335_51415(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 51335, 51415);
                    return return_v;
                }


                bool
                f_10218_51436_51516(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 51436, 51516);
                    return return_v;
                }


                bool
                f_10218_51537_51617(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 51537, 51617);
                    return return_v;
                }


                bool
                f_10218_51638_51731(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 51638, 51731);
                    return return_v;
                }


                bool
                f_10218_51752_51834(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 51752, 51834);
                    return return_v;
                }


                bool
                f_10218_51855_51937(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 51855, 51937);
                    return return_v;
                }


                bool
                f_10218_51958_52038(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 51958, 52038);
                    return return_v;
                }


                bool
                f_10218_52059_52139(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 52059, 52139);
                    return return_v;
                }


                bool
                f_10218_52160_52244(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 52160, 52244);
                    return return_v;
                }


                bool
                f_10218_52265_52343(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 52265, 52343);
                    return return_v;
                }


                bool
                f_10218_52364_52446(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 52364, 52446);
                    return return_v;
                }


                bool
                f_10218_52467_52551(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 52467, 52551);
                    return return_v;
                }


                bool
                f_10218_52572_52661(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 52572, 52661);
                    return return_v;
                }


                bool
                f_10218_52682_52767(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 52682, 52767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 50622, 52868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 50622, 52868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddOmittedAttributeIndex(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 52880, 53203);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 52953, 53136) || true) && (_lazyOmittedAttributeIndices == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 52953, 53136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 53027, 53121);

                    f_10218_53027_53120(ref _lazyOmittedAttributeIndices, f_10218_53089_53113(), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 52953, 53136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 53152, 53192);

                f_10218_53152_53191(
                            _lazyOmittedAttributeIndices, index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 52880, 53203);

                Roslyn.Utilities.ConcurrentSet<int>
                f_10218_53089_53113()
                {
                    var return_v = new Roslyn.Utilities.ConcurrentSet<int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 53089, 53113);
                    return return_v;
                }


                Roslyn.Utilities.ConcurrentSet<int>?
                f_10218_53027_53120(ref Roslyn.Utilities.ConcurrentSet<int>?
                location1, Roslyn.Utilities.ConcurrentSet<int>
                value, Roslyn.Utilities.ConcurrentSet<int>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 53027, 53120);
                    return return_v;
                }


                bool
                f_10218_53152_53191(Roslyn.Utilities.ConcurrentSet<int>
                this_param, int
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 53152, 53191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 52880, 53203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 52880, 53203);
            }
        }

        private HashSet<CSharpAttributeData> GetUniqueSourceAssemblyAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 53417, 54184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 53514, 53617);

                ImmutableArray<CSharpAttributeData>
                appliedSourceAttributes = f_10218_53576_53616(f_10218_53576_53605(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 53633, 53686);

                HashSet<CSharpAttributeData>
                uniqueAttributes = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 53711, 53716);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 53702, 54133) || true) && (i < appliedSourceAttributes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 53754, 53757)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 53702, 54133))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 53702, 54133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 53791, 53850);

                        CSharpAttributeData
                        attribute = appliedSourceAttributes[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 53868, 54118) || true) && (f_10218_53872_53892_M(!attribute.HasErrors))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 53868, 54118);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 53934, 54099) || true) && (!f_10218_53939_53998(attribute, ref uniqueAttributes))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 53934, 54099);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 54048, 54076);

                                f_10218_54048_54075(this, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 53934, 54099);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 53868, 54118);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 432);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 54149, 54173);

                return uniqueAttributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 53417, 54184);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_53576_53605(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetSourceAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 53576, 53605);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_53576_53616(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 53576, 53616);
                    return return_v;
                }


                bool
                f_10218_53872_53892_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 53872, 53892);
                    return return_v;
                }


                bool
                f_10218_53939_53998(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                uniqueAttributes)
                {
                    var return_v = AddUniqueAssemblyAttribute(attribute, ref uniqueAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 53939, 53998);
                    return return_v;
                }


                int
                f_10218_54048_54075(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, int
                index)
                {
                    this_param.AddOmittedAttributeIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 54048, 54075);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 53417, 54184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 53417, 54184);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AddUniqueAssemblyAttribute(CSharpAttributeData attribute, ref HashSet<CSharpAttributeData> uniqueAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10218, 54196, 54643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 54349, 54384);

                f_10218_54349_54383(f_10218_54362_54382_M(!attribute.HasErrors));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 54400, 54577) || true) && (uniqueAttributes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 54400, 54577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 54462, 54562);

                    uniqueAttributes = f_10218_54481_54561(comparer: CommonAttributeDataComparer.Instance);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 54400, 54577);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 54593, 54632);

                return f_10218_54600_54631(uniqueAttributes, attribute);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10218, 54196, 54643);

                bool
                f_10218_54362_54382_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 54362, 54382);
                    return return_v;
                }


                int
                f_10218_54349_54383(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 54349, 54383);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_54481_54561(Microsoft.CodeAnalysis.CommonAttributeDataComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>(comparer: (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 54481, 54561);
                    return return_v;
                }


                bool
                f_10218_54600_54631(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 54600, 54631);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 54196, 54643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 54196, 54643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ValidateAttributeUsageForNetModuleAttribute(CSharpAttributeData attribute, string netModuleName, DiagnosticBag diagnostics, ref HashSet<CSharpAttributeData> uniqueAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 54655, 57942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 54867, 54902);

                f_10218_54867_54901(f_10218_54880_54900_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 54918, 54964);

                var
                attributeClass = f_10218_54939_54963(attribute)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 54980, 57426) || true) && (f_10218_54984_55022(attributeClass).AllowMultiple)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 54980, 57426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 55232, 55299);

                    return f_10218_55239_55298(attribute, ref uniqueAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 54980, 57426);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 54980, 57426);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 55543, 57411) || true) && (uniqueAttributes == null || (DynAbs.Tracing.TraceSender.Expression_False(10218, 55547, 55698) || !f_10218_55576_55698(uniqueAttributes, (a) => TypeSymbol.Equals(a.AttributeClass, attributeClass, TypeCompareKind.ConsiderEverything2))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 55543, 57411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 55819, 55894);

                        bool
                        success = f_10218_55834_55893(attribute, ref uniqueAttributes)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 55916, 55938);

                        f_10218_55916_55937(success);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 55960, 55972);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 55543, 57411);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 55543, 57411);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 56581, 57355) || true) && (f_10218_56585_56620(this, attribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 56581, 57355);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 56670, 57006) || true) && (!f_10218_56675_56711(uniqueAttributes, attribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 56670, 57006);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 56845, 56979);

                                f_10218_56845_56978(                            // This attribute application will be ignored.
                                                            diagnostics, ErrorCode.WRN_AssemblyAttributeFromModuleIsOverridden, NoLocation.Singleton, f_10218_56938_56962(attribute), netModuleName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 56670, 57006);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 56581, 57355);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 56581, 57355);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 57056, 57355) || true) && (f_10218_57060_57119(attribute, ref uniqueAttributes))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 57056, 57355);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 57203, 57332);

                                f_10218_57203_57331(                        // Error
                                                        diagnostics, ErrorCode.ERR_DuplicateAttributeInNetModule, NoLocation.Singleton, f_10218_57286_57315(f_10218_57286_57310(attribute)), netModuleName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 57056, 57355);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 56581, 57355);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 57379, 57392);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 55543, 57411);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 54980, 57426);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 54655, 57942);

                bool
                f_10218_54880_54900_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 54880, 54900);
                    return return_v;
                }


                int
                f_10218_54867_54901(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 54867, 54901);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10218_54939_54963(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 54939, 54963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10218_54984_55022(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.GetAttributeUsageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 54984, 55022);
                    return return_v;
                }


                bool
                f_10218_55239_55298(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                uniqueAttributes)
                {
                    var return_v = AddUniqueAssemblyAttribute(attribute, ref uniqueAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 55239, 55298);
                    return return_v;
                }


                bool
                f_10218_55576_55698(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                sequence, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, bool>
                predicate)
                {
                    var return_v = sequence.Contains<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 55576, 55698);
                    return return_v;
                }


                bool
                f_10218_55834_55893(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                uniqueAttributes)
                {
                    var return_v = AddUniqueAssemblyAttribute(attribute, ref uniqueAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 55834, 55893);
                    return return_v;
                }


                int
                f_10218_55916_55937(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 55916, 55937);
                    return 0;
                }


                bool
                f_10218_56585_56620(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute)
                {
                    var return_v = this_param.IsKnownAssemblyAttribute(attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 56585, 56620);
                    return return_v;
                }


                bool
                f_10218_56675_56711(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 56675, 56711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10218_56938_56962(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 56938, 56962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_56845_56978(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 56845, 56978);
                    return return_v;
                }


                bool
                f_10218_57060_57119(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                uniqueAttributes)
                {
                    var return_v = AddUniqueAssemblyAttribute(attribute, ref uniqueAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 57060, 57119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10218_57286_57310(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 57286, 57310);
                    return return_v;
                }


                string
                f_10218_57286_57315(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 57286, 57315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_57203_57331(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 57203, 57331);
                    return return_v;
                }


                // CONSIDER Handling badly targeted assembly attributes from netmodules
                //if (!badDuplicateAttribute && ((attributeUsageInfo.ValidTargets & AttributeTargets.Assembly) == 0))
                //{
                //    // Error and skip
                //    diagnostics.Add(ErrorCode.ERR_AttributeOnBadSymbolTypeInNetModule, NoLocation.Singleton, attribute.AttributeClass.Name, netModuleName, attributeUsageInfo.GetValidTargetsString());
                //    return false;
                //}
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 54655, 57942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 54655, 57942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<CSharpAttributeData> GetNetModuleAttributes(out ImmutableArray<string> netModuleNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 57954, 59376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58088, 58161);

                ArrayBuilder<CSharpAttributeData>
                moduleAssemblyAttributesBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58175, 58224);

                ArrayBuilder<string>
                netModuleNameBuilder = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58249, 58254);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58240, 59006) || true) && (i < _modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58277, 58280)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 58240, 59006))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 58240, 59006);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58314, 58375);

                        var
                        peModuleSymbol = (Metadata.PE.PEModuleSymbol)_modules[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58393, 58436);

                        string
                        netModuleName = f_10218_58416_58435(peModuleSymbol)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58454, 58991);
                            foreach (var attributeData in f_10218_58484_58522_I(f_10218_58484_58522(peModuleSymbol)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 58454, 58991);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58564, 58835) || true) && (netModuleNameBuilder == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 58564, 58835);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58646, 58704);

                                    netModuleNameBuilder = f_10218_58669_58703();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58730, 58812);

                                    moduleAssemblyAttributesBuilder = f_10218_58764_58811();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 58564, 58835);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58859, 58899);

                                f_10218_58859_58898(
                                                    netModuleNameBuilder, netModuleName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 58921, 58972);

                                f_10218_58921_58971(moduleAssemblyAttributesBuilder, attributeData);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 58454, 58991);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 538);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 538);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 767);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 59022, 59216) || true) && (netModuleNameBuilder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 59022, 59216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 59088, 59134);

                    netModuleNames = ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 59152, 59201);

                    return ImmutableArray<CSharpAttributeData>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 59022, 59216);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 59232, 59291);

                netModuleNames = f_10218_59249_59290(netModuleNameBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 59305, 59365);

                return f_10218_59312_59364(moduleAssemblyAttributesBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 57954, 59376);

                string
                f_10218_58416_58435(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 58416, 58435);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_58484_58522(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetAssemblyAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 58484, 58522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10218_58669_58703()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 58669, 58703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_58764_58811()
                {
                    var return_v = ArrayBuilder<CSharpAttributeData>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 58764, 58811);
                    return return_v;
                }


                int
                f_10218_58859_58898(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 58859, 58898);
                    return 0;
                }


                int
                f_10218_58921_58971(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 58921, 58971);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_58484_58522_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 58484, 58522);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10218_59249_59290(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 59249, 59290);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_59312_59364(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 59312, 59364);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 57954, 59376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 57954, 59376);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private WellKnownAttributeData ValidateAttributeUsageAndDecodeWellKnownAttributes(
                    ImmutableArray<CSharpAttributeData> attributesFromNetModules,
                    ImmutableArray<string> netModuleNames,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 59388, 61825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 59662, 59707);

                f_10218_59662_59706(attributesFromNetModules.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 59721, 59756);

                f_10218_59721_59755(netModuleNames.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 59770, 59841);

                f_10218_59770_59840(attributesFromNetModules.Length == netModuleNames.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 59857, 59891);

                var
                tree = CSharpSyntaxTree.Dummy
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 59907, 59970);

                int
                netModuleAttributesCount = attributesFromNetModules.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 59984, 60060);

                int
                sourceAttributesCount = f_10218_60012_60041(this).Attributes.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 60131, 60215);

                HashSet<CSharpAttributeData>
                uniqueAttributes = f_10218_60179_60214(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 60231, 60344);

                var
                arguments = f_10218_60247_60343()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 60358, 60411);

                arguments.AttributesCount = netModuleAttributesCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 60425, 60461);

                arguments.Diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 60475, 60521);

                arguments.SymbolPart = AttributeLocation.None;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 60817, 60849);

                    // Attributes from the second added module should override attributes from the first added module, etc. 
                    // Attributes from source should override attributes from added modules.
                    // That is why we are iterating attributes backwards.
                    for (int
        i = netModuleAttributesCount - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 60808, 61735) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 60859, 60862)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 60808, 61735))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 60808, 61735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 60896, 60939);

                        var
                        totalIndex = i + sourceAttributesCount
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 60959, 61019);

                        CSharpAttributeData
                        attribute = attributesFromNetModules[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 61037, 61720) || true) && (f_10218_61041_61061_M(!attribute.HasErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 61041, 61173) && f_10218_61065_61173(this, attribute, netModuleNames[i], diagnostics, ref uniqueAttributes)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 61037, 61720);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 61215, 61247);

                            arguments.Attribute = attribute;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 61269, 61289);

                            arguments.Index = i;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 61442, 61478);

                            arguments.AttributeSyntaxOpt = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 61502, 61582);

                            f_10218_61502_61581(
                                                this, ref arguments, totalIndex, isFromNetModule: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 61037, 61720);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 61037, 61720);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 61664, 61701);

                            f_10218_61664_61700(this, totalIndex);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 61037, 61720);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 928);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 61751, 61814);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10218, 61758, 61782) || ((arguments.HasDecodedData && DynAbs.Tracing.TraceSender.Conditional_F2(10218, 61785, 61806)) || DynAbs.Tracing.TraceSender.Conditional_F3(10218, 61809, 61813))) ? arguments.DecodedData : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 59388, 61825);

                int
                f_10218_59662_59706(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 59662, 59706);
                    return 0;
                }


                int
                f_10218_59721_59755(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 59721, 59755);
                    return 0;
                }


                int
                f_10218_59770_59840(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 59770, 59840);
                    return 0;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_60012_60041(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetSourceAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 60012, 60041);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_60179_60214(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetUniqueSourceAssemblyAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 60179, 60214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                f_10218_60247_60343()
                {
                    var return_v = new Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 60247, 60343);
                    return return_v;
                }


                bool
                f_10218_61041_61061_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 61041, 61061);
                    return return_v;
                }


                bool
                f_10218_61065_61173(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, string
                netModuleName, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                uniqueAttributes)
                {
                    var return_v = this_param.ValidateAttributeUsageForNetModuleAttribute(attribute, netModuleName, diagnostics, ref uniqueAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 61065, 61173);
                    return return_v;
                }


                int
                f_10218_61502_61581(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, int
                index, bool
                isFromNetModule)
                {
                    this_param.DecodeWellKnownAttribute(ref arguments, index, isFromNetModule: isFromNetModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 61502, 61581);
                    return 0;
                }


                int
                f_10218_61664_61700(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, int
                index)
                {
                    this_param.AddOmittedAttributeIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 61664, 61700);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 59388, 61825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 59388, 61825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadAndValidateNetModuleAttributes(ref CustomAttributesBag<CSharpAttributeData> lazyNetModuleAttributesBag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 61837, 66253);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 61982, 66176) || true) && (f_10218_61986_62031(f_10218_61986_62017(f_10218_61986_62006(_compilation))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 61982, 66176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 62065, 62179);

                    f_10218_62065_62178(ref lazyNetModuleAttributesBag, CustomAttributesBag<CSharpAttributeData>.Empty, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 61982, 66176);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 61982, 66176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 62245, 62291);

                    var
                    diagnostics = f_10218_62263_62290()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 62311, 62349);

                    ImmutableArray<string>
                    netModuleNames
                    = default(ImmutableArray<string>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 62367, 62473);

                    ImmutableArray<CSharpAttributeData>
                    attributesFromNetModules = f_10218_62430_62472(this, out netModuleNames)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 62493, 62537);

                    WellKnownAttributeData
                    wellKnownData = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 62557, 63054) || true) && (attributesFromNetModules.Any())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 62557, 63054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 62633, 62755);

                        wellKnownData = f_10218_62649_62754(this, attributesFromNetModules, netModuleNames, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 62557, 63054);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 62557, 63054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 62986, 63035);

                        var
                        unused = f_10218_62999_63034(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 62557, 63054);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 63128, 63175);

                    HashSet<NamedTypeSymbol>
                    forwardedTypes = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 63410, 63433);

                        // Similar to attributes, type forwarders from the second added module should override type forwarders from the first added module, etc. 
                        // This affects only diagnostics.
                        for (int
        i = _modules.Length - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 63401, 65047) || true) && (i > 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 63442, 63445)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 63401, 65047))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 63401, 65047);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 63487, 63548);

                            var
                            peModuleSymbol = (Metadata.PE.PEModuleSymbol)_modules[i]
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 63572, 65028);
                                foreach (NamedTypeSymbol forwarded in f_10218_63610_63644_I(f_10218_63610_63644(peModuleSymbol)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 63572, 65028);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 63694, 64425) || true) && (forwardedTypes == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 63694, 64425);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 63778, 63959) || true) && (wellKnownData == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 63778, 63959);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 63869, 63928);

                                            wellKnownData = f_10218_63885_63927();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 63778, 63959);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 63991, 64077);

                                        forwardedTypes = f_10218_64008_64076(((CommonAssemblyWellKnownAttributeData)wellKnownData));

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 64107, 64398) || true) && (forwardedTypes == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 64107, 64398);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 64199, 64247);

                                            forwardedTypes = f_10218_64216_64246();
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 64281, 64367);

                                            ((CommonAssemblyWellKnownAttributeData)wellKnownData).ForwardedTypes = forwardedTypes;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 64107, 64398);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 63694, 64425);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 64453, 65005) || true) && (f_10218_64457_64486(forwardedTypes, forwarded))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 64453, 65005);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 64544, 64978) || true) && (f_10218_64548_64571(forwarded))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 64544, 64978);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 64637, 64734);

                                            DiagnosticInfo
                                            info = f_10218_64659_64691(forwarded) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.DiagnosticInfo>(10218, 64659, 64733) ?? f_10218_64695_64733(((ErrorTypeSymbol)forwarded)))
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 64770, 64947) || true) && ((object)info != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 64770, 64947);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 64868, 64912);

                                                f_10218_64868_64911(diagnostics, info, NoLocation.Singleton);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 64770, 64947);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 64544, 64978);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 64453, 65005);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 63572, 65028);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 1457);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 1457);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 1647);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 1647);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 65067, 65131);

                    CustomAttributesBag<CSharpAttributeData>
                    netModuleAttributesBag
                    = default(CustomAttributesBag<CSharpAttributeData>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 65151, 65896) || true) && (wellKnownData != null || (DynAbs.Tracing.TraceSender.Expression_False(10218, 65155, 65210) || attributesFromNetModules.Any()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 65151, 65896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 65252, 65324);

                        netModuleAttributesBag = f_10218_65277_65323();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 65348, 65415);

                        f_10218_65348_65414(
                                            netModuleAttributesBag, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 65437, 65508);

                        f_10218_65437_65507(netModuleAttributesBag, wellKnownData);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 65530, 65593);

                        f_10218_65530_65592(netModuleAttributesBag, attributesFromNetModules);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 65615, 65723) || true) && (f_10218_65619_65649(netModuleAttributesBag))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 65615, 65723);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 65651, 65723);

                            netModuleAttributesBag = CustomAttributesBag<CSharpAttributeData>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 65615, 65723);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 65151, 65896);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 65151, 65896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 65805, 65877);

                        netModuleAttributesBag = CustomAttributesBag<CSharpAttributeData>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 65151, 65896);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 65916, 66122) || true) && (f_10218_65920_66009(ref lazyNetModuleAttributesBag, netModuleAttributesBag, null) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 65916, 66122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 66059, 66103);

                        f_10218_66059_66102(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 65916, 66122);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 66142, 66161);

                    f_10218_66142_66160(
                                    diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 61982, 66176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 66192, 66242);

                f_10218_66192_66241(f_10218_66205_66240(lazyNetModuleAttributesBag));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 61837, 66253);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_61986_62006(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 61986, 62006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_61986_62017(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 61986, 62017);
                    return return_v;
                }


                bool
                f_10218_61986_62031(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 61986, 62031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_62065_62178(ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location1, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 62065, 62178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10218_62263_62290()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 62263, 62290);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_62430_62472(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, out System.Collections.Immutable.ImmutableArray<string>
                netModuleNames)
                {
                    var return_v = this_param.GetNetModuleAttributes(out netModuleNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 62430, 62472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10218_62649_62754(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributesFromNetModules, System.Collections.Immutable.ImmutableArray<string>
                netModuleNames, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ValidateAttributeUsageAndDecodeWellKnownAttributes(attributesFromNetModules, netModuleNames, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 62649, 62754);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_62999_63034(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetUniqueSourceAssemblyAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 62999, 63034);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_63610_63644(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetForwardedTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 63610, 63644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_63885_63927()
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 63885, 63927);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_64008_64076(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ForwardedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 64008, 64076);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_64216_64246()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 64216, 64246);
                    return return_v;
                }


                bool
                f_10218_64457_64486(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 64457, 64486);
                    return return_v;
                }


                bool
                f_10218_64548_64571(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 64548, 64571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10218_64659_64691(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 64659, 64691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10218_64695_64733(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ErrorInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 64695, 64733);
                    return return_v;
                }


                int
                f_10218_64868_64911(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 64868, 64911);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_63610_63644_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 63610, 63644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_65277_65323()
                {
                    var return_v = new Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 65277, 65323);
                    return return_v;
                }


                bool
                f_10218_65348_65414(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                data)
                {
                    var return_v = this_param.SetEarlyDecodedWellKnownAttributeData(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 65348, 65414);
                    return return_v;
                }


                bool
                f_10218_65437_65507(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, Microsoft.CodeAnalysis.WellKnownAttributeData?
                data)
                {
                    var return_v = this_param.SetDecodedWellKnownAttributeData(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 65437, 65507);
                    return return_v;
                }


                bool
                f_10218_65530_65592(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                newCustomAttributes)
                {
                    var return_v = this_param.SetAttributes(newCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 65530, 65592);
                    return return_v;
                }


                bool
                f_10218_65619_65649(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 65619, 65649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_65920_66009(ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location1, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 65920, 66009);
                    return return_v;
                }


                int
                f_10218_66059_66102(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 66059, 66102);
                    return 0;
                }


                int
                f_10218_66142_66160(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 66142, 66160);
                    return 0;
                }


                bool
                f_10218_66205_66240(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 66205, 66240);
                    return return_v;
                }


                int
                f_10218_66192_66241(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 66192, 66241);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 61837, 66253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 61837, 66253);
            }
        }

        private void EnsureNetModuleAttributesAreBound()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 66265, 66505);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 66338, 66494) || true) && (_lazyNetModuleAttributesBag == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 66338, 66494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 66411, 66479);

                    f_10218_66411_66478(this, ref _lazyNetModuleAttributesBag);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 66338, 66494);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 66265, 66505);

                int
                f_10218_66411_66478(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                lazyNetModuleAttributesBag)
                {
                    this_param.LoadAndValidateNetModuleAttributes(ref lazyNetModuleAttributesBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 66411, 66478);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 66265, 66505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 66265, 66505);
            }
        }

        private CustomAttributesBag<CSharpAttributeData> GetNetModuleAttributesBag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 66517, 66714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 66618, 66654);

                f_10218_66618_66653(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 66668, 66703);

                return _lazyNetModuleAttributesBag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 66517, 66714);

                int
                f_10218_66618_66653(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    this_param.EnsureNetModuleAttributesAreBound();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 66618, 66653);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 66517, 66714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 66517, 66714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CommonAssemblyWellKnownAttributeData GetNetModuleDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 66726, 67058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 66840, 66893);

                var
                attributesBag = f_10218_66860_66892(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 66907, 66944);

                f_10218_66907_66943(f_10218_66920_66942(attributesBag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 66958, 67047);

                return (CommonAssemblyWellKnownAttributeData)f_10218_67003_67046(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 66726, 67058);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_66860_66892(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetNetModuleAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 66860, 66892);
                    return return_v;
                }


                bool
                f_10218_66920_66942(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 66920, 66942);
                    return return_v;
                }


                int
                f_10218_66907_66943(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 66907, 66943);
                    return 0;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10218_67003_67046(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 67003, 67046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 66726, 67058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 66726, 67058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 67070, 67784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 67178, 67252);

                var
                builder = f_10218_67192_67251()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 67266, 67341);

                var
                declarations = f_10218_67285_67340(f_10218_67285_67327(f_10218_67285_67305()))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 67355, 67723);
                    foreach (RootSingleNamespaceDeclaration rootNs in f_10218_67405_67417_I(declarations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 67355, 67723);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 67451, 67708) || true) && (f_10218_67455_67483(rootNs))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 67451, 67708);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 67525, 67563);

                            var
                            tree = f_10218_67536_67562(f_10218_67536_67551(rootNs))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 67585, 67634);

                            var
                            root = (CompilationUnitSyntax)f_10218_67619_67633(tree)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 67656, 67689);

                            f_10218_67656_67688(builder, f_10218_67668_67687(root));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 67451, 67708);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 67355, 67723);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 369);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 67737, 67773);

                return f_10218_67744_67772(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 67070, 67784);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10218_67192_67251()
                {
                    var return_v = ArrayBuilder<SyntaxList<AttributeListSyntax>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 67192, 67251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10218_67285_67305()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 67285, 67305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                f_10218_67285_67327(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.MergedRootDeclaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 67285, 67327);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10218_67285_67340(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 67285, 67340);
                    return return_v;
                }


                bool
                f_10218_67455_67483(Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.HasAssemblyAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 67455, 67483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10218_67536_67551(Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 67536, 67551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10218_67536_67562(Microsoft.CodeAnalysis.SourceLocation
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 67536, 67562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10218_67619_67633(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 67619, 67633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10218_67668_67687(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 67668, 67687);
                    return return_v;
                }


                int
                f_10218_67656_67688(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 67656, 67688);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10218_67405_67417_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 67405, 67417);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10218_67744_67772(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 67744, 67772);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 67070, 67784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 67070, 67784);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EnsureAttributesAreBound()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 67796, 68169);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 67860, 68158) || true) && ((_lazySourceAttributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10218, 67865, 67935) || f_10218_67901_67935_M(!_lazySourceAttributesBag.IsSealed))) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 67864, 68058) && f_10218_67957_68058(this, f_10218_67983_68027(f_10218_68000_68026(this)), ref _lazySourceAttributesBag)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 67860, 68158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 68092, 68143);

                    _state.NotePartComplete(CompletionPart.Attributes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 67860, 68158);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 67796, 68169);

                bool
                f_10218_67901_67935_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 67901, 67935);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10218_68000_68026(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetAttributeDeclarations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 68000, 68026);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10218_67983_68027(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                many)
                {
                    var return_v = OneOrMany.Create(many);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 67983, 68027);
                    return return_v;
                }


                bool
                f_10218_67957_68058(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                attributesSyntaxLists, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                lazyCustomAttributesBag)
                {
                    var return_v = this_param.LoadAndValidateAttributes(attributesSyntaxLists, ref lazyCustomAttributesBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 67957, 68058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 67796, 68169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 67796, 68169);
            }
        }

        private CustomAttributesBag<CSharpAttributeData> GetSourceAttributesBag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 68495, 68677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 68593, 68620);

                f_10218_68593_68619(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 68634, 68666);

                return _lazySourceAttributesBag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 68495, 68677);

                int
                f_10218_68593_68619(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    this_param.EnsureAttributesAreBound();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 68593, 68619);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 68495, 68677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 68495, 68677);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 69116, 69897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 69215, 69273);

                var
                attributes = f_10218_69232_69272(f_10218_69232_69261(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 69287, 69357);

                var
                netmoduleAttributes = f_10218_69313_69356(f_10218_69313_69345(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 69371, 69407);

                f_10218_69371_69406(f_10218_69384_69405_M(!attributes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 69421, 69466);

                f_10218_69421_69465(f_10218_69434_69464_M(!netmoduleAttributes.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 69482, 69802) || true) && (attributes.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 69482, 69802);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 69541, 69688) || true) && (netmoduleAttributes.Length > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 69541, 69688);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 69617, 69669);

                        attributes = attributes.Concat(netmoduleAttributes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 69541, 69688);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 69482, 69802);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 69482, 69802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 69754, 69787);

                    attributes = netmoduleAttributes;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 69482, 69802);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 69818, 69854);

                f_10218_69818_69853(f_10218_69831_69852_M(!attributes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 69868, 69886);

                return attributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 69116, 69897);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_69232_69261(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetSourceAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 69232, 69261);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_69232_69272(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 69232, 69272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_69313_69345(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetNetModuleAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 69313, 69345);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_69313_69356(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 69313, 69356);
                    return return_v;
                }


                bool
                f_10218_69384_69405_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 69384, 69405);
                    return return_v;
                }


                int
                f_10218_69371_69406(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 69371, 69406);
                    return 0;
                }


                bool
                f_10218_69434_69464_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 69434, 69464);
                    return return_v;
                }


                int
                f_10218_69421_69465(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 69421, 69465);
                    return 0;
                }


                bool
                f_10218_69831_69852_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 69831, 69852);
                    return return_v;
                }


                int
                f_10218_69818_69853(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 69818, 69853);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 69116, 69897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 69116, 69897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsIndexOfOmittedAssemblyAttribute(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 70353, 70921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 70436, 70572);

                f_10218_70436_70571(_lazyOmittedAttributeIndices == null || (DynAbs.Tracing.TraceSender.Expression_False(10218, 70449, 70570) || !f_10218_70490_70570(_lazyOmittedAttributeIndices, i => i < 0 || i >= this.GetAttributes().Length)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 70586, 70634);

                f_10218_70586_70633(f_10218_70599_70632(_lazySourceAttributesBag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 70648, 70699);

                f_10218_70648_70698(f_10218_70661_70697(_lazyNetModuleAttributesBag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 70713, 70738);

                f_10218_70713_70737(index >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 70752, 70802);

                f_10218_70752_70801(index < f_10218_70773_70793(this).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 70818, 70910);

                return _lazyOmittedAttributeIndices != null && (DynAbs.Tracing.TraceSender.Expression_True(10218, 70825, 70909) && f_10218_70865_70909(_lazyOmittedAttributeIndices, index));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 70353, 70921);

                bool
                f_10218_70490_70570(Roslyn.Utilities.ConcurrentSet<int>
                source, System.Func<int, bool>
                predicate)
                {
                    var return_v = source.Any<int>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 70490, 70570);
                    return return_v;
                }


                int
                f_10218_70436_70571(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 70436, 70571);
                    return 0;
                }


                bool
                f_10218_70599_70632(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 70599, 70632);
                    return return_v;
                }


                int
                f_10218_70586_70633(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 70586, 70633);
                    return 0;
                }


                bool
                f_10218_70661_70697(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 70661, 70697);
                    return return_v;
                }


                int
                f_10218_70648_70698(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 70648, 70698);
                    return 0;
                }


                int
                f_10218_70713_70737(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 70713, 70737);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_70773_70793(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 70773, 70793);
                    return return_v;
                }


                int
                f_10218_70752_70801(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 70752, 70801);
                    return 0;
                }


                bool
                f_10218_70865_70909(Roslyn.Utilities.ConcurrentSet<int>
                this_param, int
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 70865, 70909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 70353, 70921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 70353, 70921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CommonAssemblyWellKnownAttributeData GetSourceDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 71455, 71919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 71566, 71611);

                var
                attributesBag = _lazySourceAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 71625, 71803) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10218, 71629, 71708) || f_10218_71654_71708_M(!attributesBag.IsDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 71625, 71803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 71742, 71788);

                    attributesBag = f_10218_71758_71787(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 71625, 71803);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 71819, 71908);

                return (CommonAssemblyWellKnownAttributeData)f_10218_71864_71907(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 71455, 71919);

                bool
                f_10218_71654_71708_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 71654, 71708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_71758_71787(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetSourceAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 71758, 71787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10218_71864_71907(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 71864, 71907);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 71455, 71919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 71455, 71919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal HashSet<NamedTypeSymbol> GetForwardedTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 72101, 72950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 72179, 72261);

                CustomAttributesBag<CSharpAttributeData>
                attributesBag = _lazySourceAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 72275, 72548) || true) && (f_10218_72279_72333_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(attributesBag, 10218, 72279, 72333)?.IsDecodedWellKnownAttributeDataComputed) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 72275, 72548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 72426, 72533);

                    return f_10218_72433_72532_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(((CommonAssemblyWellKnownAttributeData)f_10218_72472_72515(attributesBag)), 10218, 72433, 72532)?.ForwardedTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 72275, 72548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 72564, 72585);

                attributesBag = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 72599, 72751);

                f_10218_72599_72750(this, f_10218_72625_72669(f_10218_72642_72668(this)), ref attributesBag, attributeMatchesOpt: this.IsPossibleForwardedTypesAttribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 72767, 72879);

                var
                wellKnownAttributeData = (CommonAssemblyWellKnownAttributeData)f_10218_72834_72878_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(attributesBag, 10218, 72834, 72878)?.DecodedWellKnownAttributeData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 72893, 72939);

                return f_10218_72900_72938_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(wellKnownAttributeData, 10218, 72900, 72938)?.ForwardedTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 72101, 72950);

                bool?
                f_10218_72279_72333_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 72279, 72333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10218_72472_72515(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 72472, 72515);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                f_10218_72433_72532_M(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 72433, 72532);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10218_72642_72668(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetAttributeDeclarations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 72642, 72668);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10218_72625_72669(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                many)
                {
                    var return_v = OneOrMany.Create(many);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 72625, 72669);
                    return return_v;
                }


                bool
                f_10218_72599_72750(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                attributesSyntaxLists, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                lazyCustomAttributesBag, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, bool>
                attributeMatchesOpt)
                {
                    var return_v = this_param.LoadAndValidateAttributes(attributesSyntaxLists, ref lazyCustomAttributesBag, attributeMatchesOpt: attributeMatchesOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 72599, 72750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData?
                f_10218_72834_72878_M(Microsoft.CodeAnalysis.WellKnownAttributeData?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 72834, 72878);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                f_10218_72900_72938_M(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 72900, 72938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 72101, 72950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 72101, 72950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsPossibleForwardedTypesAttribute(AttributeSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 72962, 73299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 73055, 73202);

                QuickAttributeChecker
                checker =
                f_10218_73104_73201(f_10218_73104_73179(f_10218_73104_73163(f_10218_73104_73129(this), f_10218_73147_73162(node)), node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 73218, 73288);

                return f_10218_73225_73287(checker, node, QuickAttributes.TypeForwardedTo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 72962, 73299);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10218_73104_73129(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 73104, 73129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10218_73147_73162(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 73147, 73162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10218_73104_73163(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 73104, 73163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10218_73104_73179(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 73104, 73179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                f_10218_73104_73201(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.QuickAttributeChecker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 73104, 73201);
                    return return_v;
                }


                bool
                f_10218_73225_73287(Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attr, Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributes
                pattern)
                {
                    var return_v = this_param.IsPossibleMatch(attr, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 73225, 73287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 72962, 73299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 72962, 73299);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<Cci.SecurityAttribute> GetSecurityAttributes(CustomAttributesBag<CSharpAttributeData> attributesBag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10218, 73311, 74146);

                var listYield = new List<Cci.SecurityAttribute>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 73463, 73500);

                f_10218_73463_73499(f_10218_73476_73498(attributesBag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 73516, 73627);

                var
                wellKnownAttributeData = (CommonAssemblyWellKnownAttributeData)f_10218_73583_73626(attributesBag)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 73641, 74135) || true) && (wellKnownAttributeData != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 73641, 74135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 73709, 73798);

                    SecurityWellKnownAttributeData
                    securityData = f_10218_73755_73797(wellKnownAttributeData)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 73816, 74120) || true) && (securityData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 73816, 74120);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 73882, 74101);
                            foreach (var securityAttribute in f_10218_73916_73997_I(f_10218_73916_73997(securityData, f_10218_73972_73996(attributesBag))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 73882, 74101);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 74047, 74078);

                                listYield.Add(securityAttribute);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 73882, 74101);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 220);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 220);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 73816, 74120);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 73641, 74135);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10218, 73311, 74146);

                return listYield;

                bool
                f_10218_73476_73498(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 73476, 73498);
                    return return_v;
                }


                int
                f_10218_73463_73499(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 73463, 73499);
                    return 0;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10218_73583_73626(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 73583, 73626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SecurityWellKnownAttributeData
                f_10218_73755_73797(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.SecurityInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 73755, 73797);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_73972_73996(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 73972, 73996);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10218_73916_73997(Microsoft.CodeAnalysis.SecurityWellKnownAttributeData
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                customAttributes)
                {
                    var return_v = this_param.GetSecurityAttributes<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 73916, 73997);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10218_73916_73997_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 73916, 73997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 73311, 74146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 73311, 74146);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<Cci.SecurityAttribute> GetSecurityAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 74158, 77293);

                var listYield = new List<Cci.SecurityAttribute>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 74302, 74468);
                    foreach (var securityAttribute in f_10218_74336_74388_I(f_10218_74336_74388(f_10218_74358_74387(this))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 74302, 74468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 74422, 74453);

                        listYield.Add(securityAttribute);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 74302, 74468);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 167);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 74543, 74712);
                    foreach (var securityAttribute in f_10218_74577_74632_I(f_10218_74577_74632(f_10218_74599_74631(this))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 74543, 74712);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 74666, 74697);

                        listYield.Add(securityAttribute);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 74543, 74712);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 170);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 74779, 77282) || true) && (f_10218_74783_74815(f_10218_74783_74803(_compilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 74779, 77282);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 74976, 77267) || true) && (!(f_10218_74982_75068(_compilation, WellKnownType.System_Security_UnverifiableCodeAttribute) is MissingMetadataTypeSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 74980, 75255) && !(f_10218_75125_75225(_compilation, WellKnownType.System_Security_Permissions_SecurityPermissionAttribute) is MissingMetadataTypeSymbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 74976, 77267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 75297, 75410);

                        var
                        securityActionType = f_10218_75322_75409(_compilation, WellKnownType.System_Security_Permissions_SecurityAction)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 75432, 77248) || true) && (!(securityActionType is MissingMetadataTypeSymbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 75432, 77248);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 75536, 75687);

                            var
                            fieldRequestMinimum = (FieldSymbol)f_10218_75575_75686(_compilation, WellKnownMember.System_Security_Permissions_SecurityAction__RequestMinimum)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 75783, 75921);

                            object
                            constantValue = (DynAbs.Tracing.TraceSender.Conditional_F1(10218, 75806, 75880) || (((object)fieldRequestMinimum == null || (DynAbs.Tracing.TraceSender.Expression_False(10218, 75806, 75880) || f_10218_75845_75880(fieldRequestMinimum)) && DynAbs.Tracing.TraceSender.Conditional_F2(10218, 75883, 75884)) || DynAbs.Tracing.TraceSender.Conditional_F3(10218, 75887, 75920))) ? 0 : f_10218_75887_75920(fieldRequestMinimum)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 75947, 76058);

                            var
                            typedConstantRequestMinimum = f_10218_75981_76057(securityActionType, TypedConstantKind.Enum, constantValue)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 76086, 76157);

                            var
                            boolType = f_10218_76101_76156(_compilation, SpecialType.System_Boolean)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 76183, 76323);

                            f_10218_76183_76322(f_10218_76196_76221_M(!boolType.HasUseSiteError), "Use site errors should have been checked ahead of time (type bool).");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 76351, 76445);

                            var
                            typedConstantTrue = f_10218_76375_76444(boolType, TypedConstantKind.Primitive, value: true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 76473, 76994);

                            var
                            attribute = f_10218_76489_76993(_compilation, WellKnownMember.System_Security_Permissions_SecurityPermissionAttribute__ctor, f_10218_76663_76713(typedConstantRequestMinimum), f_10218_76744_76992(f_10218_76766_76991(WellKnownMember.System_Security_Permissions_SecurityPermissionAttribute__SkipVerification, typedConstantTrue)))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 77022, 77225) || true) && (attribute != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 77022, 77225);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 77101, 77198);

                                listYield.Add(f_10218_77114_77197((int)constantValue, attribute));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 77022, 77225);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 75432, 77248);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 74976, 77267);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 74779, 77282);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 74158, 77293);

                return listYield;

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_74358_74387(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetSourceAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 74358, 74387);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10218_74336_74388(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributesBag)
                {
                    var return_v = GetSecurityAttributes(attributesBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 74336, 74388);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10218_74336_74388_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 74336, 74388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10218_74599_74631(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetNetModuleAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 74599, 74631);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10218_74577_74632(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributesBag)
                {
                    var return_v = GetSecurityAttributes(attributesBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 74577, 74632);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10218_74577_74632_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 74577, 74632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_74783_74803(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 74783, 74803);
                    return return_v;
                }


                bool
                f_10218_74783_74815(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.AllowUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 74783, 74815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_74982_75068(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 74982, 75068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_75125_75225(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 75125, 75225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_75322_75409(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 75322, 75409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10218_75575_75686(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 75575, 75686);
                    return return_v;
                }


                bool
                f_10218_75845_75880(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.HasUseSiteError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 75845, 75880);
                    return return_v;
                }


                object
                f_10218_75887_75920(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 75887, 75920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10218_75981_76057(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, object
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 75981, 76057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_76101_76156(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 76101, 76156);
                    return return_v;
                }


                bool
                f_10218_76196_76221_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 76196, 76221);
                    return return_v;
                }


                int
                f_10218_76183_76322(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 76183, 76322);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10218_76375_76444(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, bool
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, value: (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 76375, 76444);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_76663_76713(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 76663, 76713);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>
                f_10218_76766_76991(Microsoft.CodeAnalysis.WellKnownMember
                key, Microsoft.CodeAnalysis.TypedConstant
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 76766, 76991);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>>
                f_10218_76744_76992(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 76744, 76992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10218_76489_76993(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 76489, 76993);
                    return return_v;
                }


                Microsoft.Cci.SecurityAttribute
                f_10218_77114_77197(int
                action, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    var return_v = new Microsoft.Cci.SecurityAttribute((System.Reflection.DeclarativeSecurityAction)action, (Microsoft.Cci.ICustomAttribute)attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 77114, 77197);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 74158, 77293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 74158, 77293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<AssemblySymbol> GetNoPiaResolutionAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 77305, 77470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 77409, 77459);

                return f_10218_77416_77458(_modules[0]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 77305, 77470);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10218_77416_77458(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblySymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 77416, 77458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 77305, 77470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 77305, 77470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void SetNoPiaResolutionAssemblies(ImmutableArray<AssemblySymbol> assemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 77482, 77649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 77601, 77638);

                throw f_10218_77607_77637();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 77482, 77649);

                System.Exception
                f_10218_77607_77637()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 77607, 77637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 77482, 77649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 77482, 77649);
            }
        }

        internal override ImmutableArray<AssemblySymbol> GetLinkedReferencedAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 77661, 77962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 77904, 77951);

                return default(ImmutableArray<AssemblySymbol>);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 77661, 77962);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 77661, 77962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 77661, 77962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void SetLinkedReferencedAssemblies(ImmutableArray<AssemblySymbol> assemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 77974, 78280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 78232, 78269);

                throw f_10218_78238_78268();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 77974, 78280);

                System.Exception
                f_10218_78238_78268()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 78238, 78268);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 77974, 78280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 77974, 78280);
            }
        }

        internal override bool IsLinked
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 78348, 78412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 78384, 78397);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 78348, 78412);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 78292, 78423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 78292, 78423);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool DeclaresTheObjectClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 78496, 78835);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 78532, 78649) || true) && ((object)f_10218_78544_78559(this) != (object)this)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 78532, 78649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 78617, 78630);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 78532, 78649);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 78669, 78721);

                    var
                    obj = f_10218_78679_78720(this, SpecialType.System_Object)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 78741, 78820);

                    return !f_10218_78749_78766(obj) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 78748, 78819) && f_10218_78770_78795(obj) == Accessibility.Public);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 78496, 78835);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10218_78544_78559(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.CorLibrary;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 78544, 78559);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10218_78679_78720(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    type)
                    {
                        var return_v = this_param.GetSpecialType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 78679, 78720);
                        return return_v;
                    }


                    bool
                    f_10218_78749_78766(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsErrorType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 78749, 78766);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Accessibility
                    f_10218_78770_78795(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 78770, 78795);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 78435, 78846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 78435, 78846);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 78932, 79431);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 79236, 79386) || true) && (f_10218_79240_79280(_lazyContainsExtensionMethods))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 79236, 79386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 79322, 79367);

                        return f_10218_79329_79366(_lazyContainsExtensionMethods);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 79236, 79386);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 79404, 79416);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 78932, 79431);

                    bool
                    f_10218_79240_79280(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.HasValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 79240, 79280);
                        return return_v;
                    }


                    bool
                    f_10218_79329_79366(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.Value();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 79329, 79366);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 78858, 79442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 78858, 79442);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool HasDebuggableAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 79514, 79748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 79550, 79648);

                    CommonAssemblyWellKnownAttributeData
                    assemblyData = f_10218_79602_79647(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 79666, 79733);

                    return assemblyData != null && (DynAbs.Tracing.TraceSender.Expression_True(10218, 79673, 79732) && f_10218_79697_79732(assemblyData));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 79514, 79748);

                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10218_79602_79647(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetSourceDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 79602, 79647);
                        return return_v;
                    }


                    bool
                    f_10218_79697_79732(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.HasDebuggableAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 79697, 79732);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 79454, 79759);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 79454, 79759);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool HasReferenceAssemblyAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 79838, 80079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 79874, 79972);

                    CommonAssemblyWellKnownAttributeData
                    assemblyData = f_10218_79926_79971(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 79990, 80064);

                    return assemblyData != null && (DynAbs.Tracing.TraceSender.Expression_True(10218, 79997, 80063) && f_10218_80021_80063(assemblyData));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 79838, 80079);

                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10218_79926_79971(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetSourceDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 79926, 79971);
                        return return_v;
                    }


                    bool
                    f_10218_80021_80063(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.HasReferenceAssemblyAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 80021, 80063);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 79771, 80090);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 79771, 80090);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 80102, 87198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 80260, 80321);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10218, 80260, 80320);

                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 80260, 80320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 80337, 80393);

                CSharpCompilationOptions
                options = f_10218_80372_80392(_compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 80407, 80467);

                bool
                isBuildingNetModule = f_10218_80434_80466(f_10218_80434_80452(options))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 80481, 80545);

                bool
                containsExtensionMethods = f_10218_80513_80544(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 80561, 80981) || true) && (containsExtensionMethods)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 80561, 80981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 80793, 80966);

                    f_10218_80793_80965(ref attributes, f_10218_80833_80964(_compilation, WellKnownMember.System_Runtime_CompilerServices_ExtensionAttribute__ctor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 80561, 80981);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 81488, 81624);

                bool
                emitCompilationRelaxationsAttribute = !isBuildingNetModule && (DynAbs.Tracing.TraceSender.Expression_True(10218, 81531, 81623) && !this.Modules.Any(m => m.HasAssemblyCompilationRelaxationsAttribute))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 81638, 82880) || true) && (emitCompilationRelaxationsAttribute)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 81638, 82880);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 81958, 82865) || true) && (!(f_10218_81964_82072(_compilation, WellKnownType.System_Runtime_CompilerServices_CompilationRelaxationsAttribute) is MissingMetadataTypeSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 81958, 82865);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 82144, 82214);

                        var
                        int32Type = f_10218_82160_82213(_compilation, SpecialType.System_Int32)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 82236, 82372);

                        f_10218_82236_82371(f_10218_82249_82275_M(!int32Type.HasUseSiteError), "Use site errors should have been checked ahead of time (type int).");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 82396, 82547);

                        var
                        typedConstantNoStringInterning = f_10218_82433_82546(int32Type, TypedConstantKind.Primitive, Cci.Constants.CompilationRelaxations_NoStringInterning)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 82571, 82846);

                        f_10218_82571_82845(ref attributes, f_10218_82611_82844(_compilation, WellKnownMember.System_Runtime_CompilerServices_CompilationRelaxationsAttribute__ctorInt32, f_10218_82790_82843(typedConstantNoStringInterning)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 81958, 82865);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 81638, 82880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 82896, 83028);

                bool
                emitRuntimeCompatibilityAttribute = !isBuildingNetModule && (DynAbs.Tracing.TraceSender.Expression_True(10218, 82937, 83027) && !this.Modules.Any(m => m.HasAssemblyRuntimeCompatibilityAttribute))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 83042, 84440) || true) && (emitRuntimeCompatibilityAttribute)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 83042, 84440);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 83347, 84425) || true) && (!(f_10218_83353_83459(_compilation, WellKnownType.System_Runtime_CompilerServices_RuntimeCompatibilityAttribute) is MissingMetadataTypeSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 83347, 84425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 83531, 83602);

                        var
                        boolType = f_10218_83546_83601(_compilation, SpecialType.System_Boolean)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 83624, 83735);

                        f_10218_83624_83734(f_10218_83637_83662_M(!boolType.HasUseSiteError), "Use site errors should have been checked ahead of time (type bool).");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 83759, 83853);

                        var
                        typedConstantTrue = f_10218_83783_83852(boolType, TypedConstantKind.Primitive, value: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 83877, 84406);

                        f_10218_83877_84405(ref attributes, f_10218_83917_84404(_compilation, WellKnownMember.System_Runtime_CompilerServices_RuntimeCompatibilityAttribute__ctor, ImmutableArray<TypedConstant>.Empty, f_10218_84151_84403(f_10218_84173_84402(WellKnownMember.System_Runtime_CompilerServices_RuntimeCompatibilityAttribute__WrapNonExceptionThrows, typedConstantTrue))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 83347, 84425);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 83042, 84440);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 85018, 85209) || true) && (!isBuildingNetModule && (DynAbs.Tracing.TraceSender.Expression_True(10218, 85022, 85074) && f_10218_85046_85074_M(!this.HasDebuggableAttribute)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 85018, 85209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 85108, 85194);

                    f_10218_85108_85193(ref attributes, f_10218_85148_85192(_compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 85018, 85209);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 85225, 87187) || true) && (f_10218_85229_85260(f_10218_85229_85249(_compilation)) == OutputKind.NetModule)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 85225, 87187);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 85529, 86348) || true) && (!f_10218_85534_85595(f_10218_85555_85594(f_10218_85555_85575(_compilation))) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 85533, 85731) && (object)f_10218_85628_85664() == (object)CommonAssemblyWellKnownAttributeData.StringMissingValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 85529, 86348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 85773, 85845);

                        var
                        stringType = f_10218_85790_85844(_compilation, SpecialType.System_String)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 85867, 85982);

                        f_10218_85867_85981(f_10218_85880_85907_M(!stringType.HasUseSiteError), "Use site errors should have been checked ahead of time (type string).");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 86006, 86126);

                        var
                        typedConstant = f_10218_86026_86125(stringType, TypedConstantKind.Primitive, f_10218_86085_86124(f_10218_86085_86105(_compilation)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 86148, 86329);

                        f_10218_86148_86328(ref attributes, f_10218_86188_86327(_compilation, WellKnownMember.System_Reflection_AssemblyKeyNameAttribute__ctor, f_10218_86290_86326(typedConstant)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 85529, 86348);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 86368, 87172) || true) && (!f_10218_86373_86429(f_10218_86394_86428(f_10218_86394_86414(_compilation))) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 86372, 86560) && (object)f_10218_86462_86493() == (object)CommonAssemblyWellKnownAttributeData.StringMissingValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 86368, 87172);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 86602, 86674);

                        var
                        stringType = f_10218_86619_86673(_compilation, SpecialType.System_String)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 86696, 86811);

                        f_10218_86696_86810(f_10218_86709_86736_M(!stringType.HasUseSiteError), "Use site errors should have been checked ahead of time (type string).");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 86835, 86950);

                        var
                        typedConstant = f_10218_86855_86949(stringType, TypedConstantKind.Primitive, f_10218_86914_86948(f_10218_86914_86934(_compilation)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 86972, 87153);

                        f_10218_86972_87152(ref attributes, f_10218_87012_87151(_compilation, WellKnownMember.System_Reflection_AssemblyKeyFileAttribute__ctor, f_10218_87114_87150(typedConstant)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 86368, 87172);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 85225, 87187);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 80102, 87198);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_80372_80392(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 80372, 80392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_80434_80452(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 80434, 80452);
                    return return_v;
                }


                bool
                f_10218_80434_80466(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 80434, 80466);
                    return return_v;
                }


                bool
                f_10218_80513_80544(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.ContainsExtensionMethods();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 80513, 80544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10218_80833_80964(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 80833, 80964);
                    return return_v;
                }


                int
                f_10218_80793_80965(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 80793, 80965);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_81964_82072(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 81964, 82072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_82160_82213(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 82160, 82213);
                    return return_v;
                }


                bool
                f_10218_82249_82275_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 82249, 82275);
                    return return_v;
                }


                int
                f_10218_82236_82371(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 82236, 82371);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10218_82433_82546(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, int
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 82433, 82546);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_82790_82843(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 82790, 82843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10218_82611_82844(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 82611, 82844);
                    return return_v;
                }


                int
                f_10218_82571_82845(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 82571, 82845);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_83353_83459(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 83353, 83459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_83546_83601(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 83546, 83601);
                    return return_v;
                }


                bool
                f_10218_83637_83662_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 83637, 83662);
                    return return_v;
                }


                int
                f_10218_83624_83734(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 83624, 83734);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10218_83783_83852(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, bool
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, value: (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 83783, 83852);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>
                f_10218_84173_84402(Microsoft.CodeAnalysis.WellKnownMember
                key, Microsoft.CodeAnalysis.TypedConstant
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 84173, 84402);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>>
                f_10218_84151_84403(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 84151, 84403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10218_83917_84404(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 83917, 84404);
                    return return_v;
                }


                int
                f_10218_83877_84405(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 83877, 84405);
                    return 0;
                }


                bool
                f_10218_85046_85074_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 85046, 85074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10218_85148_85192(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SynthesizeDebuggableAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 85148, 85192);
                    return return_v;
                }


                int
                f_10218_85108_85193(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 85108, 85193);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_85229_85249(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 85229, 85249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_85229_85260(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 85229, 85260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_85555_85575(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 85555, 85575);
                    return return_v;
                }


                string?
                f_10218_85555_85594(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 85555, 85594);
                    return return_v;
                }


                bool
                f_10218_85534_85595(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 85534, 85595);
                    return return_v;
                }


                string
                f_10218_85628_85664()
                {
                    var return_v = AssemblyKeyContainerAttributeSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 85628, 85664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_85790_85844(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 85790, 85844);
                    return return_v;
                }


                bool
                f_10218_85880_85907_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 85880, 85907);
                    return return_v;
                }


                int
                f_10218_85867_85981(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 85867, 85981);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_86085_86105(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 86085, 86105);
                    return return_v;
                }


                string
                f_10218_86085_86124(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 86085, 86124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10218_86026_86125(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, string
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 86026, 86125);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_86290_86326(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 86290, 86326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10218_86188_86327(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 86188, 86327);
                    return return_v;
                }


                int
                f_10218_86148_86328(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 86148, 86328);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_86394_86414(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 86394, 86414);
                    return return_v;
                }


                string?
                f_10218_86394_86428(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 86394, 86428);
                    return return_v;
                }


                bool
                f_10218_86373_86429(string?
                value)
                {
                    var return_v = String.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 86373, 86429);
                    return return_v;
                }


                string
                f_10218_86462_86493()
                {
                    var return_v = AssemblyKeyFileAttributeSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 86462, 86493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_86619_86673(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 86619, 86673);
                    return return_v;
                }


                bool
                f_10218_86709_86736_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 86709, 86736);
                    return return_v;
                }


                int
                f_10218_86696_86810(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 86696, 86810);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_86914_86934(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 86914, 86934);
                    return return_v;
                }


                string
                f_10218_86914_86948(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 86914, 86948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10218_86855_86949(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, string
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 86855, 86949);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_87114_87150(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 87114, 87150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10218_87012_87151(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 87012, 87151);
                    return return_v;
                }


                int
                f_10218_86972_87152(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 86972, 87152);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 80102, 87198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 80102, 87198);
            }
        }

        private bool ContainsExtensionMethods()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 87614, 87926);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 87678, 87854) || true) && (!f_10218_87683_87723(_lazyContainsExtensionMethods))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 87678, 87854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 87757, 87839);

                    _lazyContainsExtensionMethods = f_10218_87789_87838(f_10218_87789_87823(_modules));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 87678, 87854);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 87870, 87915);

                return f_10218_87877_87914(_lazyContainsExtensionMethods);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 87614, 87926);

                bool
                f_10218_87683_87723(Microsoft.CodeAnalysis.ThreeState
                value)
                {
                    var return_v = value.HasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 87683, 87723);
                    return return_v;
                }


                bool
                f_10218_87789_87823(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                modules)
                {
                    var return_v = ContainsExtensionMethods(modules);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 87789, 87823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ThreeState
                f_10218_87789_87838(bool
                value)
                {
                    var return_v = value.ToThreeState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 87789, 87838);
                    return return_v;
                }


                bool
                f_10218_87877_87914(Microsoft.CodeAnalysis.ThreeState
                value)
                {
                    var return_v = value.Value();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 87877, 87914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 87614, 87926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 87614, 87926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ContainsExtensionMethods(ImmutableArray<ModuleSymbol> modules)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10218, 87938, 88287);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 88045, 88249);
                    foreach (var module in f_10218_88068_88075_I(modules))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 88045, 88249);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 88109, 88234) || true) && (f_10218_88113_88161(f_10218_88138_88160(module)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 88109, 88234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 88203, 88215);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 88109, 88234);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 88045, 88249);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 88263, 88276);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10218, 87938, 88287);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10218_88138_88160(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 88138, 88160);
                    return return_v;
                }


                bool
                f_10218_88113_88161(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                ns)
                {
                    var return_v = ContainsExtensionMethods(ns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 88113, 88161);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10218_88068_88075_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 88068, 88075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 87938, 88287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 87938, 88287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ContainsExtensionMethods(NamespaceSymbol ns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10218, 88299, 89207);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 88388, 89169);
                    foreach (var member in f_10218_88411_88435_I(f_10218_88411_88435(ns)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 88388, 89169);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 88469, 89154);

                        switch (f_10218_88477_88488(member))
                        {

                            case SymbolKind.Namespace:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 88469, 89154);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 88582, 88732) || true) && (f_10218_88586_88635(member))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 88582, 88732);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 88693, 88705);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 88582, 88732);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10218, 88758, 88764);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 88469, 89154);

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 88469, 89154);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 88838, 88993) || true) && (f_10218_88842_88896(((NamedTypeSymbol)member)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 88838, 88993);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 88954, 88966);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 88838, 88993);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10218, 89019, 89025);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 88469, 89154);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 88469, 89154);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 89081, 89135);

                                throw f_10218_89087_89134(f_10218_89122_89133(member));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 88469, 89154);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 88388, 89169);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 782);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 89183, 89196);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10218, 88299, 89207);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10218_88411_88435(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 88411, 88435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10218_88477_88488(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 88477, 88488);
                    return return_v;
                }


                bool
                f_10218_88586_88635(Microsoft.CodeAnalysis.CSharp.Symbol
                ns)
                {
                    var return_v = ContainsExtensionMethods((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)ns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 88586, 88635);
                    return return_v;
                }


                bool
                f_10218_88842_88896(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MightContainExtensionMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 88842, 88896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10218_89122_89133(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 89122, 89133);
                    return return_v;
                }


                System.Exception
                f_10218_89087_89134(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 89087, 89134);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10218_88411_88435_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 88411, 88435);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 88299, 89207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 88299, 89207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckOptimisticIVTAccessGrants(DiagnosticBag bag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 89476, 90598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 89563, 89668);

                ConcurrentDictionary<AssemblySymbol, bool>
                haveGrantedAssemblies = _optimisticallyGrantedInternalsAccess
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 89684, 90587) || true) && (haveGrantedAssemblies != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 89684, 90587);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 89751, 90572);
                        foreach (var otherAssembly in f_10218_89781_89807_I(f_10218_89781_89807(haveGrantedAssemblies)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 89751, 90572);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 89849, 89917);

                            IVTConclusion
                            conclusion = f_10218_89876_89916(this, otherAssembly)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 89941, 90005);

                            f_10218_89941_90004(conclusion != IVTConclusion.NoRelationshipClaimed);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 90029, 90553) || true) && (conclusion == IVTConclusion.PublicKeyDoesntMatch)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 90029, 90553);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 90108, 90287);

                                f_10218_90108_90286(bag, ErrorCode.ERR_FriendRefNotEqualToThis, NoLocation.Singleton, f_10218_90248_90270(otherAssembly), f_10218_90272_90285(this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 90029, 90553);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 90029, 90553);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 90314, 90553) || true) && (conclusion == IVTConclusion.OneSignedOneNot)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 90314, 90553);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 90388, 90553);

                                    f_10218_90388_90552(bag, ErrorCode.ERR_FriendRefSigningMismatch, NoLocation.Singleton, f_10218_90529_90551(otherAssembly));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 90314, 90553);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 90029, 90553);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 89751, 90572);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 822);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 822);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 89684, 90587);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 89476, 90598);

                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10218_89781_89807(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, bool>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 89781, 89807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IVTConclusion
                f_10218_89876_89916(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                potentialGiverOfAccess)
                {
                    var return_v = this_param.MakeFinalIVTDetermination(potentialGiverOfAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 89876, 89916);
                    return return_v;
                }


                int
                f_10218_89941_90004(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 89941, 90004);
                    return 0;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10218_90248_90270(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 90248, 90270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10218_90272_90285(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 90272, 90285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_90108_90286(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 90108, 90286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10218_90529_90551(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 90529, 90551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_90388_90552(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 90388, 90552);
                    return return_v;
                }


                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10218_89781_89807_I(System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 89781, 89807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 89476, 90598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 89476, 90598);
            }
        }

        internal override IEnumerable<ImmutableArray<byte>> GetInternalsVisibleToPublicKeys(string simpleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 90610, 91543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 91066, 91093);

                f_10218_91066_91092(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 91109, 91236) || true) && (_lazyInternalsVisibleToMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 91109, 91236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 91166, 91236);

                    return f_10218_91173_91235();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 91109, 91236);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 91252, 91334);

                ConcurrentDictionary<ImmutableArray<byte>, Tuple<Location, string>>
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 91350, 91413);

                f_10218_91350_91412(
                            _lazyInternalsVisibleToMap, simpleName, out result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 91429, 91532);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10218, 91436, 91452) || (((result != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10218, 91455, 91466)) || DynAbs.Tracing.TraceSender.Conditional_F3(10218, 91469, 91531))) ? f_10218_91455_91466(result) : f_10218_91469_91531();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 90610, 91543);

                int
                f_10218_91066_91092(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    this_param.EnsureAttributesAreBound();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 91066, 91092);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_10218_91173_91235()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<ImmutableArray<byte>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 91173, 91235);
                    return return_v;
                }


                bool
                f_10218_91350_91412(System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>
                this_param, string
                key, out System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 91350, 91412);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Collections.Immutable.ImmutableArray<byte>>
                f_10218_91455_91466(System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 91455, 91466);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_10218_91469_91531()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<ImmutableArray<byte>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 91469, 91531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 90610, 91543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 90610, 91543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool AreInternalsVisibleToThisAssembly(AssemblySymbol potentialGiverOfAccess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 91555, 93262);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 92111, 93054) || true) && (_lazyStrongNameKeys == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 92111, 93054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 92176, 92263);

                    var
                    assemblyWhoseKeysAreBeingComputed = t_assemblyForWhichCurrentThreadIsComputingKeys
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 92281, 93039) || true) && ((object)assemblyWhoseKeysAreBeingComputed != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 92281, 93039);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 92454, 93020) || true) && (!f_10218_92459_92534(f_10218_92459_92524(potentialGiverOfAccess, f_10218_92514_92523(this))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 92454, 93020);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 92584, 92791) || true) && (_optimisticallyGrantedInternalsAccess == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 92584, 92791);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 92664, 92791);

                                f_10218_92664_92790(ref _optimisticallyGrantedInternalsAccess, f_10218_92735_92783(), null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 92584, 92791);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 92819, 92894);

                            f_10218_92819_92893(
                                                    _optimisticallyGrantedInternalsAccess, potentialGiverOfAccess, true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 92920, 92932);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 92454, 93020);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 92454, 93020);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 93007, 93020);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 92454, 93020);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 92281, 93039);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 92111, 93054);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 93070, 93147);

                IVTConclusion
                conclusion = f_10218_93097_93146(this, potentialGiverOfAccess)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 93163, 93251);

                return conclusion == IVTConclusion.Match || (DynAbs.Tracing.TraceSender.Expression_False(10218, 93170, 93250) || conclusion == IVTConclusion.OneSignedOneNot);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 91555, 93262);

                string
                f_10218_92514_92523(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 92514, 92523);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_10218_92459_92524(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, string
                simpleName)
                {
                    var return_v = this_param.GetInternalsVisibleToPublicKeys(simpleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 92459, 92524);
                    return return_v;
                }


                bool
                f_10218_92459_92534(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                source)
                {
                    var return_v = source.IsEmpty<System.Collections.Immutable.ImmutableArray<byte>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 92459, 92534);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, bool>
                f_10218_92735_92783()
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, bool>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 92735, 92783);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, bool>?
                f_10218_92664_92790(ref System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, bool>?
                location1, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, bool>
                value, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, bool>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 92664, 92790);
                    return return_v;
                }


                bool
                f_10218_92819_92893(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key, bool
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 92819, 92893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IVTConclusion
                f_10218_93097_93146(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                potentialGiverOfAccess)
                {
                    var return_v = this_param.MakeFinalIVTDetermination(potentialGiverOfAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 93097, 93146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 91555, 93262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 91555, 93262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AssemblyIdentity ComputeIdentity()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 93274, 93730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 93341, 93719);

                return f_10218_93348_93718(_assemblySimpleName, f_10218_93425_93551(f_10218_93480_93517(f_10218_93480_93500(_compilation)), f_10218_93519_93550()), f_10218_93570_93606(this), f_10218_93625_93639().PublicKey, hasPublicKey: f_10218_93682_93717_M(!f_10218_93683_93697().PublicKey.IsDefault));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 93274, 93730);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_93480_93500(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 93480, 93500);
                    return return_v;
                }


                System.DateTime
                f_10218_93480_93517(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CurrentLocalTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 93480, 93517);
                    return return_v;
                }


                System.Version
                f_10218_93519_93550()
                {
                    var return_v = AssemblyVersionAttributeSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 93519, 93550);
                    return return_v;
                }


                System.Version?
                f_10218_93425_93551(System.DateTime
                time, System.Version
                pattern)
                {
                    var return_v = VersionHelper.GenerateVersionFromPatternAndCurrentTime(time, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 93425, 93551);
                    return return_v;
                }


                string
                f_10218_93570_93606(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.AssemblyCultureAttributeSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 93570, 93606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_10218_93625_93639()
                {
                    var return_v = StrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 93625, 93639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_10218_93683_93697()
                {
                    var return_v = StrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 93683, 93697);
                    return return_v;
                }


                bool
                f_10218_93682_93717_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 93682, 93717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10218_93348_93718(string
                name, System.Version?
                version, string
                cultureName, System.Collections.Immutable.ImmutableArray<byte>
                publicKeyOrToken, bool
                hasPublicKey)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, version, cultureName, publicKeyOrToken, hasPublicKey: hasPublicKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 93348, 93718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 93274, 93730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 93274, 93730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ConcurrentDictionary<string, ConcurrentDictionary<ImmutableArray<byte>, Tuple<Location, string>>> _lazyInternalsVisibleToMap;

        private static Location GetAssemblyAttributeLocationForDiagnostic(AttributeSyntax attributeSyntaxOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10218, 94479, 94711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 94605, 94700);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10218, 94612, 94646) || (((object)attributeSyntaxOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10218, 94649, 94676)) || DynAbs.Tracing.TraceSender.Conditional_F3(10218, 94679, 94699))) ? f_10218_94649_94676(attributeSyntaxOpt) : NoLocation.Singleton;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10218, 94479, 94711);

                Microsoft.CodeAnalysis.Location
                f_10218_94649_94676(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 94649, 94676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 94479, 94711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 94479, 94711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DecodeTypeForwardedToAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 94723, 98444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 95002, 95047);

                f_10218_95002_95046(f_10218_95015_95045_M(!arguments.Attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 95063, 95166);

                TypeSymbol
                forwardedType = (TypeSymbol)f_10218_95102_95148(arguments.Attribute)[0].ValueInternal
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 95251, 95487) || true) && ((object)forwardedType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 95251, 95487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 95318, 95447);

                    f_10218_95318_95446(arguments.Diagnostics, ErrorCode.ERR_InvalidFwdType, f_10218_95374_95445(arguments.AttributeSyntaxOpt));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 95465, 95472);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 95251, 95487);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 95503, 95575);

                DiagnosticInfo
                useSiteDiagnostic = f_10218_95538_95574(forwardedType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 95589, 95934) || true) && (useSiteDiagnostic != null && (DynAbs.Tracing.TraceSender.Expression_True(10218, 95593, 95712) && f_10218_95639_95661(useSiteDiagnostic) != (int)ErrorCode.ERR_UnexpectedUnboundGenericName) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 95593, 95878) && f_10218_95733_95878(useSiteDiagnostic, arguments.Diagnostics, f_10218_95806_95877(arguments.AttributeSyntaxOpt))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 95589, 95934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 95912, 95919);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 95589, 95934);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 95950, 96005);

                f_10218_95950_96004(f_10218_95963_95985(forwardedType) != TypeKind.Error);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 96021, 96296) || true) && (f_10218_96025_96057(forwardedType) == this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 96021, 96296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 96099, 96256);

                    f_10218_96099_96255(arguments.Diagnostics, ErrorCode.ERR_ForwardedTypeInThisAssembly, f_10218_96168_96239(arguments.AttributeSyntaxOpt), forwardedType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 96274, 96281);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 96021, 96296);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 96312, 96615) || true) && ((object)f_10218_96324_96352(forwardedType) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 96312, 96615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 96394, 96575);

                    f_10218_96394_96574(arguments.Diagnostics, ErrorCode.ERR_ForwardedTypeIsNested, f_10218_96457_96528(arguments.AttributeSyntaxOpt), forwardedType, f_10218_96545_96573(forwardedType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 96593, 96600);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 96312, 96615);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 96631, 97224) || true) && (f_10218_96635_96653(forwardedType) != SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 96631, 97224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 97055, 97184);

                    f_10218_97055_97183(                // NOTE: Dev10 actually tests whether the forwarded type is an aggregate.  This would seem to
                                                        // exclude nullable and void, but that shouldn't be an issue because they have to be defined in
                                                        // corlib (since they are special types) and corlib can't refer to other assemblies (by definition).

                                    arguments.Diagnostics, ErrorCode.ERR_InvalidFwdType, f_10218_97111_97182(arguments.AttributeSyntaxOpt));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 97202, 97209);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 96631, 97224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 97487, 97572);

                var
                assemblyData = arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 97586, 97656);

                HashSet<NamedTypeSymbol>
                forwardedTypes = f_10218_97628_97655(assemblyData)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 97670, 98433) || true) && (forwardedTypes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 97670, 98433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 97730, 97813);

                    forwardedTypes = new HashSet<NamedTypeSymbol>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (NamedTypeSymbol)forwardedType, 10218, 97747, 97812) };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 97831, 97876);

                    assemblyData.ForwardedTypes = forwardedTypes;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 97670, 98433);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 97670, 98433);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 97910, 98433) || true) && (!f_10218_97915_97965(forwardedTypes, forwardedType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 97910, 98433);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 98266, 98418);

                        f_10218_98266_98417(                // NOTE: For the purposes of reporting this error, Dev10 considers C<int> and C<char>
                                                            // different types.  However, it will actually emit a single forwarder for C`1 (i.e.
                                                            // we'll have to de-dup again at emit time).
                                        arguments.Diagnostics, ErrorCode.ERR_DuplicateTypeForwarder, f_10218_98330_98401(arguments.AttributeSyntaxOpt), forwardedType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 97910, 98433);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 97670, 98433);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 94723, 98444);

                bool
                f_10218_95015_95045_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 95015, 95045);
                    return return_v;
                }


                int
                f_10218_95002_95046(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 95002, 95046);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_95102_95148(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 95102, 95148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_95374_95445(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = GetAssemblyAttributeLocationForDiagnostic(attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 95374, 95445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_95318_95446(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 95318, 95446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10218_95538_95574(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 95538, 95574);
                    return return_v;
                }


                int
                f_10218_95639_95661(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 95639, 95661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_95806_95877(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = GetAssemblyAttributeLocationForDiagnostic(attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 95806, 95877);
                    return return_v;
                }


                bool
                f_10218_95733_95878(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 95733, 95878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10218_95963_95985(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 95963, 95985);
                    return return_v;
                }


                int
                f_10218_95950_96004(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 95950, 96004);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10218_96025_96057(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 96025, 96057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_96168_96239(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = GetAssemblyAttributeLocationForDiagnostic(attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 96168, 96239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_96099_96255(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 96099, 96255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_96324_96352(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 96324, 96352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_96457_96528(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = GetAssemblyAttributeLocationForDiagnostic(attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 96457, 96528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_96545_96573(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 96545, 96573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_96394_96574(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 96394, 96574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10218_96635_96653(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 96635, 96653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_97111_97182(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = GetAssemblyAttributeLocationForDiagnostic(attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 97111, 97182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_97055_97183(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 97055, 97183);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_97628_97655(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ForwardedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 97628, 97655);
                    return return_v;
                }


                bool
                f_10218_97915_97965(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 97915, 97965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_98330_98401(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = GetAssemblyAttributeLocationForDiagnostic(attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 98330, 98401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_98266_98417(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 98266, 98417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 94723, 98444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 94723, 98444);
            }
        }

        private void DecodeOneInternalsVisibleToAttribute(
                    AttributeSyntax nodeOpt,
                    CSharpAttributeData attrData,
                    DiagnosticBag diagnostics,
                    int index,
                    ref ConcurrentDictionary<string, ConcurrentDictionary<ImmutableArray<byte>, Tuple<Location, string>>> lazyInternalsVisibleToMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 98456, 102163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 98923, 98957);

                f_10218_98923_98956(f_10218_98936_98955_M(!attrData.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 98973, 99055);

                string
                displayName = (string)f_10218_99002_99037(attrData)[0].ValueInternal
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 99071, 99283) || true) && (displayName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 99071, 99283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 99128, 99243);

                    f_10218_99128_99242(diagnostics, ErrorCode.ERR_CannotPassNullForFriendAssembly, f_10218_99191_99241(nodeOpt));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 99261, 99268);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 99071, 99283);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 99299, 99325);

                AssemblyIdentity
                identity
                = default(AssemblyIdentity);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 99339, 99367);

                AssemblyIdentityParts
                parts
                = default(AssemblyIdentityParts);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 99381, 99700) || true) && (!f_10218_99386_99460(displayName, out identity, out parts))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 99381, 99700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 99494, 99610);

                    f_10218_99494_99609(diagnostics, ErrorCode.WRN_InvalidAssemblyName, f_10218_99545_99595(nodeOpt), displayName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 99628, 99660);

                    f_10218_99628_99659(this, index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 99678, 99685);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 99381, 99700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 99824, 99967);

                const AssemblyIdentityParts
                allowedParts = AssemblyIdentityParts.Name | AssemblyIdentityParts.PublicKey | AssemblyIdentityParts.PublicKeyToken
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 99983, 100207) || true) && ((parts & ~allowedParts) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 99983, 100207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 100049, 100167);

                    f_10218_100049_100166(diagnostics, ErrorCode.ERR_FriendAssemblyBadArgs, f_10218_100102_100152(nodeOpt), displayName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 100185, 100192);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 99983, 100207);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 100223, 100556) || true) && (lazyInternalsVisibleToMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 100223, 100556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 100294, 100541);

                    f_10218_100294_100540(ref lazyInternalsVisibleToMap, f_10218_100398_100533(f_10218_100500_100532()), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 100223, 100556);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 100839, 100887);

                Tuple<Location, string>
                locationAndValue = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 101149, 101340) || true) && (identity.PublicKey.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 101149, 101340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 101213, 101325);

                    locationAndValue = f_10218_101232_101324(f_10218_101260_101310(nodeOpt), displayName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 101149, 101340);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 101606, 101686);

                ConcurrentDictionary<ImmutableArray<byte>, Tuple<Location, string>>
                keys = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 101700, 102152) || true) && (f_10218_101704_101766(lazyInternalsVisibleToMap, f_10218_101742_101755(identity), out keys))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 101700, 102152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 101800, 101850);

                    f_10218_101800_101849(keys, f_10218_101812_101830(identity), locationAndValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 101700, 102152);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 101700, 102152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 101916, 101997);

                    keys = f_10218_101923_101996();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 102015, 102065);

                    f_10218_102015_102064(keys, f_10218_102027_102045(identity), locationAndValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 102083, 102137);

                    f_10218_102083_102136(lazyInternalsVisibleToMap, f_10218_102116_102129(identity), keys);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 101700, 102152);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 98456, 102163);

                bool
                f_10218_98936_98955_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 98936, 98955);
                    return return_v;
                }


                int
                f_10218_98923_98956(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 98923, 98956);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_99002_99037(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 99002, 99037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_99191_99241(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntaxOpt)
                {
                    var return_v = GetAssemblyAttributeLocationForDiagnostic(attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 99191, 99241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_99128_99242(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 99128, 99242);
                    return return_v;
                }


                bool
                f_10218_99386_99460(string
                displayName, out Microsoft.CodeAnalysis.AssemblyIdentity
                identity, out Microsoft.CodeAnalysis.AssemblyIdentityParts
                parts)
                {
                    var return_v = AssemblyIdentity.TryParseDisplayName(displayName, out identity, out parts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 99386, 99460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_99545_99595(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntaxOpt)
                {
                    var return_v = GetAssemblyAttributeLocationForDiagnostic(attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 99545, 99595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_99494_99609(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 99494, 99609);
                    return return_v;
                }


                int
                f_10218_99628_99659(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, int
                index)
                {
                    this_param.AddOmittedAttributeIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 99628, 99659);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_100102_100152(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntaxOpt)
                {
                    var return_v = GetAssemblyAttributeLocationForDiagnostic(attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 100102, 100152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_100049_100166(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 100049, 100166);
                    return return_v;
                }


                System.StringComparer
                f_10218_100500_100532()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 100500, 100532);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>
                f_10218_100398_100533(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 100398, 100533);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>?
                f_10218_100294_100540(ref System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>?
                location1, System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>
                value, System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 100294, 100540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_101260_101310(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntaxOpt)
                {
                    var return_v = GetAssemblyAttributeLocationForDiagnostic(attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 101260, 101310);
                    return return_v;
                }


                System.Tuple<Microsoft.CodeAnalysis.Location, string>
                f_10218_101232_101324(Microsoft.CodeAnalysis.Location
                item1, string
                item2)
                {
                    var return_v = new System.Tuple<Microsoft.CodeAnalysis.Location, string>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 101232, 101324);
                    return return_v;
                }


                string
                f_10218_101742_101755(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 101742, 101755);
                    return return_v;
                }


                bool
                f_10218_101704_101766(System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>
                this_param, string
                key, out System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 101704, 101766);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10218_101812_101830(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.PublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 101812, 101830);
                    return return_v;
                }


                bool
                f_10218_101800_101849(System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                key, System.Tuple<Microsoft.CodeAnalysis.Location, string>?
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 101800, 101849);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>
                f_10218_101923_101996()
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 101923, 101996);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10218_102027_102045(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.PublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 102027, 102045);
                    return return_v;
                }


                bool
                f_10218_102015_102064(System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                key, System.Tuple<Microsoft.CodeAnalysis.Location, string>?
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 102015, 102064);
                    return return_v;
                }


                string
                f_10218_102116_102129(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 102116, 102129);
                    return return_v;
                }


                bool
                f_10218_102083_102136(System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>
                this_param, string
                key, System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 102083, 102136);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 98456, 102163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 98456, 102163);
            }
        }

        IAttributeTargetSymbol IAttributeTargetSymbol.AttributesOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 102261, 102281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 102267, 102279);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 102261, 102281);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 102175, 102292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 102175, 102292);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AttributeLocation IAttributeTargetSymbol.DefaultAttributeLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 102394, 102436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 102400, 102434);

                    return AttributeLocation.Assembly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 102394, 102436);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 102304, 102447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 102304, 102447);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AttributeLocation IAttributeTargetSymbol.AllowedAttributeLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 102550, 102703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 102586, 102688);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10218, 102593, 102606) || ((f_10218_102593_102606() && DynAbs.Tracing.TraceSender.Conditional_F2(10218, 102609, 102631)) || DynAbs.Tracing.TraceSender.Conditional_F3(10218, 102634, 102687))) ? AttributeLocation.None : AttributeLocation.Assembly | AttributeLocation.Module;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 102550, 102703);

                    bool
                    f_10218_102593_102606()
                    {
                        var return_v = IsInteractive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 102593, 102606);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 102459, 102714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 102459, 102714);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 102726, 102996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 102904, 102985);

                f_10218_102904_102984(this, ref arguments, arguments.Index, isFromNetModule: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 102726, 102996);

                int
                f_10218_102904_102984(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, int
                index, bool
                isFromNetModule)
                {
                    this_param.DecodeWellKnownAttribute(ref arguments, index, isFromNetModule: isFromNetModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 102904, 102984);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 102726, 102996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 102726, 102996);
            }
        }

        private void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments, int index, bool isFromNetModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 103008, 116095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 103209, 103245);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 103259, 103294);

                f_10218_103259_103293(f_10218_103272_103292_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 103308, 103369);

                f_10218_103308_103368(arguments.SymbolPart == AttributeLocation.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 103383, 103397);

                int
                signature
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 103413, 116084) || true) && (f_10218_103417_103500(attribute, this, AttributeDescription.InternalsVisibleToAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 103413, 116084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 103534, 103674);

                    f_10218_103534_103673(this, arguments.AttributeSyntaxOpt, attribute, arguments.Diagnostics, index, ref _lazyInternalsVisibleToMap);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 103413, 116084);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 103413, 116084);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 103708, 116084) || true) && (f_10218_103712_103797(attribute, this, AttributeDescription.AssemblySignatureKeyAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 103708, 116084);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 103831, 103912);

                        var
                        signatureKey = (string)f_10218_103858_103894(attribute)[0].ValueInternal
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 103930, 104048);

                        arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblySignatureKeyAttributeSetting = signatureKey;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 104068, 104331) || true) && (!f_10218_104073_104124(signatureKey))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 104068, 104331);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 104166, 104312);

                            f_10218_104166_104311(arguments.Diagnostics, ErrorCode.ERR_InvalidSignaturePublicKey, f_10218_104233_104310(attribute, 0, arguments.AttributeSyntaxOpt));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 104068, 104331);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 103708, 116084);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 103708, 116084);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 104365, 116084) || true) && (f_10218_104369_104449(attribute, this, AttributeDescription.AssemblyKeyFileAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 104365, 116084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 104483, 104645);

                            arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyKeyFileAttributeSetting = (string)f_10218_104591_104627(attribute)[0].ValueInternal;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 104365, 116084);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 104365, 116084);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 104679, 116084) || true) && (f_10218_104683_104763(attribute, this, AttributeDescription.AssemblyKeyNameAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 104679, 116084);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 104797, 104964);

                                arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyKeyContainerAttributeSetting = (string)f_10218_104910_104946(attribute)[0].ValueInternal;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 104679, 116084);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 104679, 116084);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 104998, 116084) || true) && (f_10218_105002_105084(attribute, this, AttributeDescription.AssemblyDelaySignAttribute))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 104998, 116084);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 105118, 105317);

                                    arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyDelaySignAttributeSetting = (DynAbs.Tracing.TraceSender.Conditional_F1(10218, 105220, 105279) || (((bool)f_10218_105226_105262(attribute)[0].ValueInternal && DynAbs.Tracing.TraceSender.Conditional_F2(10218, 105282, 105297)) || DynAbs.Tracing.TraceSender.Conditional_F3(10218, 105300, 105316))) ? ThreeState.True : ThreeState.False;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 104998, 116084);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 104998, 116084);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 105351, 116084) || true) && (f_10218_105355_105435(attribute, this, AttributeDescription.AssemblyVersionAttribute))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 105351, 116084);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 105469, 105550);

                                        string
                                        verString = (string)f_10218_105496_105532(attribute)[0].ValueInternal
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 105568, 105584);

                                        Version
                                        version
                                        = default(Version);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 105602, 106210) || true) && (!f_10218_105607_105727(verString, allowWildcard: f_10218_105671_105704_M(!_compilation.IsEmitDeterministic), version: out version))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 105602, 106210);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 105769, 105890);

                                            Location
                                            attributeArgumentSyntaxLocation = f_10218_105812_105889(attribute, 0, arguments.AttributeSyntaxOpt)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 105912, 106005);

                                            bool
                                            foundBadWildcard = f_10218_105936_105968(_compilation) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 105936, 106004) && f_10218_105972_105996_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(verString, 10218, 105972, 105996)?.Contains('*')) == true)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 106027, 106191);

                                            f_10218_106027_106190(arguments.Diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10218, 106053, 106069) || ((foundBadWildcard && DynAbs.Tracing.TraceSender.Conditional_F2(10218, 106072, 106119)) || DynAbs.Tracing.TraceSender.Conditional_F3(10218, 106122, 106156))) ? ErrorCode.ERR_InvalidVersionFormatDeterministic : ErrorCode.ERR_InvalidVersionFormat, attributeArgumentSyntaxLocation);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 105602, 106210);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 106230, 106338);

                                        arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyVersionAttributeSetting = version;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 105351, 116084);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 105351, 116084);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 106372, 116084) || true) && (f_10218_106376_106460(attribute, this, AttributeDescription.AssemblyFileVersionAttribute))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 106372, 116084);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 106494, 106508);

                                            Version
                                            dummy
                                            = default(Version);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 106526, 106607);

                                            string
                                            verString = (string)f_10218_106553_106589(attribute)[0].ValueInternal
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 106625, 106982) || true) && (!f_10218_106630_106683(verString, version: out dummy))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 106625, 106982);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 106725, 106846);

                                                Location
                                                attributeArgumentSyntaxLocation = f_10218_106768_106845(attribute, 0, arguments.AttributeSyntaxOpt)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 106868, 106963);

                                                f_10218_106868_106962(arguments.Diagnostics, ErrorCode.WRN_InvalidVersionFormat, attributeArgumentSyntaxLocation);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 106625, 106982);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 107002, 107116);

                                            arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyFileVersionAttributeSetting = verString;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 106372, 116084);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 106372, 116084);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 107150, 116084) || true) && (f_10218_107154_107232(attribute, this, AttributeDescription.AssemblyTitleAttribute))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 107150, 116084);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 107266, 107426);

                                                arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyTitleAttributeSetting = (string)f_10218_107372_107408(attribute)[0].ValueInternal;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 107150, 116084);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 107150, 116084);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 107460, 116084) || true) && (f_10218_107464_107548(attribute, this, AttributeDescription.AssemblyDescriptionAttribute))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 107460, 116084);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 107582, 107748);

                                                    arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyDescriptionAttributeSetting = (string)f_10218_107694_107730(attribute)[0].ValueInternal;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 107460, 116084);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 107460, 116084);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 107782, 116084) || true) && (f_10218_107786_107866(attribute, this, AttributeDescription.AssemblyCultureAttribute))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 107782, 116084);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 107900, 107982);

                                                        var
                                                        cultureString = (string)f_10218_107928_107964(attribute)[0].ValueInternal
                                                        ;

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 108000, 108719) || true) && (!f_10218_108005_108040(cultureString))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 108000, 108719);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 108082, 108700) || true) && (f_10218_108086_108133(f_10218_108086_108117(f_10218_108086_108106(_compilation))))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 108082, 108700);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 108183, 108332);

                                                                f_10218_108183_108331(arguments.Diagnostics, ErrorCode.ERR_InvalidAssemblyCultureForExe, f_10218_108253_108330(attribute, 0, arguments.AttributeSyntaxOpt));
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 108082, 108700);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 108082, 108700);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 108382, 108700) || true) && (!f_10218_108387_108437(cultureString))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 108382, 108700);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 108487, 108630);

                                                                    f_10218_108487_108629(arguments.Diagnostics, ErrorCode.ERR_InvalidAssemblyCulture, f_10218_108551_108628(attribute, 0, arguments.AttributeSyntaxOpt));
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 108656, 108677);

                                                                    cultureString = null;
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 108382, 108700);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 108082, 108700);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 108000, 108719);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 108739, 108853);

                                                        arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyCultureAttributeSetting = cultureString;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 107782, 116084);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 107782, 116084);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 108887, 116084) || true) && (f_10218_108891_108971(attribute, this, AttributeDescription.AssemblyCompanyAttribute))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 108887, 116084);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 109005, 109167);

                                                            arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyCompanyAttributeSetting = (string)f_10218_109113_109149(attribute)[0].ValueInternal;
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 108887, 116084);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 108887, 116084);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 109201, 116084) || true) && (f_10218_109205_109285(attribute, this, AttributeDescription.AssemblyProductAttribute))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 109201, 116084);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 109319, 109481);

                                                                arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyProductAttributeSetting = (string)f_10218_109427_109463(attribute)[0].ValueInternal;
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 109201, 116084);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 109201, 116084);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 109515, 116084) || true) && (f_10218_109519_109612(attribute, this, AttributeDescription.AssemblyInformationalVersionAttribute))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 109515, 116084);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 109646, 109821);

                                                                    arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyInformationalVersionAttributeSetting = (string)f_10218_109767_109803(attribute)[0].ValueInternal;
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 109515, 116084);
                                                                }

                                                                else
                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 109515, 116084);

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 109855, 116084) || true) && (f_10218_109859_109948(attribute, this, AttributeDescription.SatelliteContractVersionAttribute))
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 109855, 116084);
                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 110068, 110082);

                                                                        Version
                                                                        dummy
                                                                        = default(Version);
                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 110100, 110181);

                                                                        string
                                                                        verString = (string)f_10218_110127_110163(attribute)[0].ValueInternal
                                                                        ;

                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 110201, 110596) || true) && (!f_10218_110206_110296(verString, allowWildcard: false, version: out dummy))
                                                                        )

                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 110201, 110596);
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 110338, 110459);

                                                                            Location
                                                                            attributeArgumentSyntaxLocation = f_10218_110381_110458(attribute, 0, arguments.AttributeSyntaxOpt)
                                                                            ;
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 110481, 110577);

                                                                            f_10218_110481_110576(arguments.Diagnostics, ErrorCode.ERR_InvalidVersionFormat2, attributeArgumentSyntaxLocation);
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 110201, 110596);
                                                                        }
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 109855, 116084);
                                                                    }

                                                                    else
                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 109855, 116084);

                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 110630, 116084) || true) && (f_10218_110634_110716(attribute, this, AttributeDescription.AssemblyCopyrightAttribute))
                                                                        )

                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 110630, 116084);
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 110750, 110914);

                                                                            arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyCopyrightAttributeSetting = (string)f_10218_110860_110896(attribute)[0].ValueInternal;
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 110630, 116084);
                                                                        }

                                                                        else
                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 110630, 116084);

                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 110948, 116084) || true) && (f_10218_110952_111034(attribute, this, AttributeDescription.AssemblyTrademarkAttribute))
                                                                            )

                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 110948, 116084);
                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 111068, 111232);

                                                                                arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyTrademarkAttributeSetting = (string)f_10218_111178_111214(attribute)[0].ValueInternal;
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 110948, 116084);
                                                                            }

                                                                            else
                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 110948, 116084);

                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 111266, 116084) || true) && ((signature = f_10218_111283_111376(attribute, this, AttributeDescription.AssemblyFlagsAttribute)) != -1)
                                                                                )

                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 111266, 116084);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 111417, 111486);

                                                                                    object
                                                                                    value = f_10218_111432_111468(attribute)[0].ValueInternal
                                                                                    ;
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 111504, 111528);

                                                                                    AssemblyFlags
                                                                                    nameFlags
                                                                                    = default(AssemblyFlags);

                                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 111548, 111818) || true) && (signature == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10218, 111552, 111584) || signature == 1))
                                                                                    )

                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 111548, 111818);
                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 111626, 111678);

                                                                                        nameFlags = (AssemblyFlags)(AssemblyNameFlags)value;
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 111548, 111818);
                                                                                    }

                                                                                    else

                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 111548, 111818);
                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 111760, 111799);

                                                                                        nameFlags = (AssemblyFlags)(uint)value;
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 111548, 111818);
                                                                                    }
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 111838, 111946);

                                                                                    arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyFlagsAttributeSetting = nameFlags;
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 111266, 116084);
                                                                                }

                                                                                else
                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 111266, 116084);

                                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 111980, 116084) || true) && (f_10218_111984_112027(attribute, _compilation))
                                                                                    )

                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 111980, 116084);
                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 112061, 112168);

                                                                                        f_10218_112061_112167(attribute, this, _compilation, ref arguments);
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 111980, 116084);
                                                                                    }

                                                                                    else
                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 111980, 116084);

                                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 112202, 116084) || true) && (f_10218_112206_112285(attribute, this, AttributeDescription.ClassInterfaceAttribute))
                                                                                        )

                                                                                        {
                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 112202, 116084);
                                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 112319, 112412);

                                                                                            f_10218_112319_112411(attribute, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 112202, 116084);
                                                                                        }

                                                                                        else
                                                                                        {
                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 112202, 116084);

                                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 112446, 116084) || true) && (f_10218_112450_112529(attribute, this, AttributeDescription.TypeLibVersionAttribute))
                                                                                            )

                                                                                            {
                                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 112446, 116084);
                                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 112563, 112673);

                                                                                                f_10218_112563_112672(attribute, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 112446, 116084);
                                                                                            }

                                                                                            else
                                                                                            {
                                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 112446, 116084);

                                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 112707, 116084) || true) && (f_10218_112711_112796(attribute, this, AttributeDescription.ComCompatibleVersionAttribute))
                                                                                                )

                                                                                                {
                                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 112707, 116084);
                                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 112830, 112940);

                                                                                                    f_10218_112830_112939(attribute, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 112707, 116084);
                                                                                                }

                                                                                                else
                                                                                                {
                                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 112707, 116084);

                                                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 112974, 116084) || true) && (f_10218_112978_113047(attribute, this, AttributeDescription.GuidAttribute))
                                                                                                    )

                                                                                                    {
                                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 112974, 116084);
                                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 113081, 113164);

                                                                                                        f_10218_113081_113163(attribute, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 112974, 116084);
                                                                                                    }

                                                                                                    else
                                                                                                    {
                                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 112974, 116084);

                                                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 113198, 116084) || true) && (f_10218_113202_113289(attribute, this, AttributeDescription.CompilationRelaxationsAttribute))
                                                                                                        )

                                                                                                        {
                                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 113198, 116084);
                                                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 113323, 113431);

                                                                                                            arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().HasCompilationRelaxationsAttribute = true;
                                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 113198, 116084);
                                                                                                        }

                                                                                                        else
                                                                                                        {
                                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 113198, 116084);

                                                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 113465, 116084) || true) && (f_10218_113469_113551(attribute, this, AttributeDescription.ReferenceAssemblyAttribute))
                                                                                                            )

                                                                                                            {
                                                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 113465, 116084);
                                                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 113585, 113688);

                                                                                                                arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().HasReferenceAssemblyAttribute = true;
                                                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 113465, 116084);
                                                                                                            }

                                                                                                            else
                                                                                                            {
                                                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 113465, 116084);

                                                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 113722, 116084) || true) && (f_10218_113726_113811(attribute, this, AttributeDescription.RuntimeCompatibilityAttribute))
                                                                                                                )

                                                                                                                {
                                                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 113722, 116084);
                                                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 113845, 113880);

                                                                                                                    bool
                                                                                                                    wrapNonExceptionThrows = true
                                                                                                                    ;
                                                                                                                    try
                                                                                                                    {
                                                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 113900, 114291);
                                                                                                                        foreach (var namedArg in f_10218_113925_113955_I(f_10218_113925_113955(attribute)))
                                                                                                                        {
                                                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 113900, 114291);
                                                                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 113997, 114272);

                                                                                                                            switch (namedArg.Key)
                                                                                                                            {

                                                                                                                                case "WrapNonExceptionThrows":
                                                                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 113997, 114272);
                                                                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 114127, 114213);

                                                                                                                                    wrapNonExceptionThrows = namedArg.Value.DecodeValue<bool>(SpecialType.System_Boolean);
                                                                                                                                    DynAbs.Tracing.TraceSender.TraceBreak(10218, 114243, 114249);

                                                                                                                                    break;
                                                                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 113997, 114272);
                                                                                                                            }
                                                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 113900, 114291);
                                                                                                                        }
                                                                                                                    }
                                                                                                                    catch (System.Exception)
                                                                                                                    {
                                                                                                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 392);
                                                                                                                        throw;
                                                                                                                    }
                                                                                                                    finally
                                                                                                                    {
                                                                                                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 392);
                                                                                                                    }
                                                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 114311, 114445);

                                                                                                                    arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().RuntimeCompatibilityWrapNonExceptionThrows = wrapNonExceptionThrows;
                                                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 113722, 116084);
                                                                                                                }

                                                                                                                else
                                                                                                                {
                                                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 113722, 116084);

                                                                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 114479, 116084) || true) && (f_10218_114483_114558(attribute, this, AttributeDescription.DebuggableAttribute))
                                                                                                                    )

                                                                                                                    {
                                                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 114479, 116084);
                                                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 114592, 114688);

                                                                                                                        arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().HasDebuggableAttribute = true;
                                                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 114479, 116084);
                                                                                                                    }

                                                                                                                    else
                                                                                                                    {
                                                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 114479, 116084);

                                                                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 114722, 116084) || true) && (!isFromNetModule && (DynAbs.Tracing.TraceSender.Expression_True(10218, 114726, 114826) && f_10218_114746_114826(attribute, this, AttributeDescription.TypeForwardedToAttribute)))
                                                                                                                        )

                                                                                                                        {
                                                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 114722, 116084);
                                                                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 114860, 114906);

                                                                                                                            f_10218_114860_114905(this, ref arguments);
                                                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 114722, 116084);
                                                                                                                        }

                                                                                                                        else
                                                                                                                        {
                                                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 114722, 116084);

                                                                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 114940, 116084) || true) && (f_10218_114944_115031(attribute, this, AttributeDescription.CaseSensitiveExtensionAttribute))
                                                                                                                            )

                                                                                                                            {
                                                                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 114940, 116084);

                                                                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 115065, 115348) || true) && ((object)arguments.AttributeSyntaxOpt != null)
                                                                                                                                )

                                                                                                                                {
                                                                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 115065, 115348);
                                                                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 115231, 115329);

                                                                                                                                    f_10218_115231_115328(                    // [Extension] attribute should not be set explicitly.
                                                                                                                                                        arguments.Diagnostics, ErrorCode.ERR_ExplicitExtension, f_10218_115290_115327(arguments.AttributeSyntaxOpt));
                                                                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 115065, 115348);
                                                                                                                                }
                                                                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 114940, 116084);
                                                                                                                            }

                                                                                                                            else
                                                                                                                            {
                                                                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 114940, 116084);

                                                                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 115382, 116084) || true) && ((signature = f_10218_115399_115498(attribute, this, AttributeDescription.AssemblyAlgorithmIdAttribute)) != -1)
                                                                                                                                )

                                                                                                                                {
                                                                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 115382, 116084);
                                                                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 115539, 115608);

                                                                                                                                    object
                                                                                                                                    value = f_10218_115554_115590(attribute)[0].ValueInternal
                                                                                                                                    ;
                                                                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 115626, 115660);

                                                                                                                                    AssemblyHashAlgorithm
                                                                                                                                    algorithmId
                                                                                                                                    = default(AssemblyHashAlgorithm);

                                                                                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 115680, 115933) || true) && (signature == 0)
                                                                                                                                    )

                                                                                                                                    {
                                                                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 115680, 115933);
                                                                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 115740, 115783);

                                                                                                                                        algorithmId = (AssemblyHashAlgorithm)value;
                                                                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 115680, 115933);
                                                                                                                                    }

                                                                                                                                    else

                                                                                                                                    {
                                                                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 115680, 115933);
                                                                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 115865, 115914);

                                                                                                                                        algorithmId = (AssemblyHashAlgorithm)(uint)value;
                                                                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 115680, 115933);
                                                                                                                                    }
                                                                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 115953, 116069);

                                                                                                                                    arguments.GetOrCreateData<CommonAssemblyWellKnownAttributeData>().AssemblyAlgorithmIdAttributeSetting = algorithmId;
                                                                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 115382, 116084);
                                                                                                                                }
                                                                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 114940, 116084);
                                                                                                                            }
                                                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 114722, 116084);
                                                                                                                        }
                                                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 114479, 116084);
                                                                                                                    }
                                                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 113722, 116084);
                                                                                                                }
                                                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 113465, 116084);
                                                                                                            }
                                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 113198, 116084);
                                                                                                        }
                                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 112974, 116084);
                                                                                                    }
                                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 112707, 116084);
                                                                                                }
                                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 112446, 116084);
                                                                                            }
                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 112202, 116084);
                                                                                        }
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 111980, 116084);
                                                                                    }
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 111266, 116084);
                                                                                }
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 110948, 116084);
                                                                            }
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 110630, 116084);
                                                                        }
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 109855, 116084);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 109515, 116084);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 109201, 116084);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 108887, 116084);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 107782, 116084);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 107460, 116084);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 107150, 116084);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 106372, 116084);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 105351, 116084);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 104998, 116084);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 104679, 116084);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 104365, 116084);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 103708, 116084);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 103413, 116084);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 103008, 116095);

                bool
                f_10218_103272_103292_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 103272, 103292);
                    return return_v;
                }


                int
                f_10218_103259_103293(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 103259, 103293);
                    return 0;
                }


                int
                f_10218_103308_103368(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 103308, 103368);
                    return 0;
                }


                bool
                f_10218_103417_103500(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 103417, 103500);
                    return return_v;
                }


                int
                f_10218_103534_103673(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                nodeOpt, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attrData, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, int
                index, ref System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Tuple<Microsoft.CodeAnalysis.Location, string>>>
                lazyInternalsVisibleToMap)
                {
                    this_param.DecodeOneInternalsVisibleToAttribute(nodeOpt, attrData, diagnostics, index, ref lazyInternalsVisibleToMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 103534, 103673);
                    return 0;
                }


                bool
                f_10218_103712_103797(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 103712, 103797);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_103858_103894(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 103858, 103894);
                    return return_v;
                }


                bool
                f_10218_104073_104124(string?
                publicKey)
                {
                    var return_v = StrongNameKeys.IsValidPublicKeyString(publicKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 104073, 104124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_104233_104310(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = attribute.GetAttributeArgumentSyntaxLocation(parameterIndex, attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 104233, 104310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_104166_104311(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 104166, 104311);
                    return return_v;
                }


                bool
                f_10218_104369_104449(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 104369, 104449);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_104591_104627(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 104591, 104627);
                    return return_v;
                }


                bool
                f_10218_104683_104763(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 104683, 104763);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_104910_104946(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 104910, 104946);
                    return return_v;
                }


                bool
                f_10218_105002_105084(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 105002, 105084);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_105226_105262(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 105226, 105262);
                    return return_v;
                }


                bool
                f_10218_105355_105435(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 105355, 105435);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_105496_105532(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 105496, 105532);
                    return return_v;
                }


                bool
                f_10218_105671_105704_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 105671, 105704);
                    return return_v;
                }


                bool
                f_10218_105607_105727(string?
                s, bool
                allowWildcard, out System.Version
                version)
                {
                    var return_v = VersionHelper.TryParseAssemblyVersion(s, allowWildcard: allowWildcard, out version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 105607, 105727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_105812_105889(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = attribute.GetAttributeArgumentSyntaxLocation(parameterIndex, attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 105812, 105889);
                    return return_v;
                }


                bool
                f_10218_105936_105968(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.IsEmitDeterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 105936, 105968);
                    return return_v;
                }


                bool?
                f_10218_105972_105996_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 105972, 105996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_106027_106190(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 106027, 106190);
                    return return_v;
                }


                bool
                f_10218_106376_106460(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 106376, 106460);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_106553_106589(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 106553, 106589);
                    return return_v;
                }


                bool
                f_10218_106630_106683(string?
                s, out System.Version
                version)
                {
                    var return_v = VersionHelper.TryParse(s, out version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 106630, 106683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_106768_106845(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = attribute.GetAttributeArgumentSyntaxLocation(parameterIndex, attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 106768, 106845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_106868_106962(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 106868, 106962);
                    return return_v;
                }


                bool
                f_10218_107154_107232(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 107154, 107232);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_107372_107408(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 107372, 107408);
                    return return_v;
                }


                bool
                f_10218_107464_107548(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 107464, 107548);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_107694_107730(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 107694, 107730);
                    return return_v;
                }


                bool
                f_10218_107786_107866(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 107786, 107866);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_107928_107964(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 107928, 107964);
                    return return_v;
                }


                bool
                f_10218_108005_108040(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 108005, 108040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_108086_108106(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 108086, 108106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_108086_108117(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 108086, 108117);
                    return return_v;
                }


                bool
                f_10218_108086_108133(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 108086, 108133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_108253_108330(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = attribute.GetAttributeArgumentSyntaxLocation(parameterIndex, attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 108253, 108330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_108183_108331(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 108183, 108331);
                    return return_v;
                }


                bool
                f_10218_108387_108437(string
                name)
                {
                    var return_v = AssemblyIdentity.IsValidCultureName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 108387, 108437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_108551_108628(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = attribute.GetAttributeArgumentSyntaxLocation(parameterIndex, attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 108551, 108628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_108487_108629(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 108487, 108629);
                    return return_v;
                }


                bool
                f_10218_108891_108971(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 108891, 108971);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_109113_109149(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 109113, 109149);
                    return return_v;
                }


                bool
                f_10218_109205_109285(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 109205, 109285);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_109427_109463(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 109427, 109463);
                    return return_v;
                }


                bool
                f_10218_109519_109612(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 109519, 109612);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_109767_109803(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 109767, 109803);
                    return return_v;
                }


                bool
                f_10218_109859_109948(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 109859, 109948);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_110127_110163(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 110127, 110163);
                    return return_v;
                }


                bool
                f_10218_110206_110296(string?
                s, bool
                allowWildcard, out System.Version
                version)
                {
                    var return_v = VersionHelper.TryParseAssemblyVersion(s, allowWildcard: allowWildcard, out version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 110206, 110296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_110381_110458(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = attribute.GetAttributeArgumentSyntaxLocation(parameterIndex, attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 110381, 110458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_110481_110576(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 110481, 110576);
                    return return_v;
                }


                bool
                f_10218_110634_110716(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 110634, 110716);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_110860_110896(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 110860, 110896);
                    return return_v;
                }


                bool
                f_10218_110952_111034(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 110952, 111034);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_111178_111214(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 111178, 111214);
                    return return_v;
                }


                int
                f_10218_111283_111376(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.GetTargetAttributeSignatureIndex((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 111283, 111376);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_111432_111468(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 111432, 111468);
                    return return_v;
                }


                bool
                f_10218_111984_112027(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsSecurityAttribute(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 111984, 112027);
                    return return_v;
                }


                int
                f_10218_112061_112167(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeSecurityAttribute<Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, compilation, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 112061, 112167);
                    return 0;
                }


                bool
                f_10218_112206_112285(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 112206, 112285);
                    return return_v;
                }


                int
                f_10218_112319_112411(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                nodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.DecodeClassInterfaceAttribute(nodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 112319, 112411);
                    return 0;
                }


                bool
                f_10218_112450_112529(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 112450, 112529);
                    return return_v;
                }


                int
                f_10218_112563_112672(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                nodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ValidateIntegralAttributeNonNegativeArguments(attribute, nodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 112563, 112672);
                    return 0;
                }


                bool
                f_10218_112711_112796(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 112711, 112796);
                    return return_v;
                }


                int
                f_10218_112830_112939(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                nodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ValidateIntegralAttributeNonNegativeArguments(attribute, nodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 112830, 112939);
                    return 0;
                }


                bool
                f_10218_112978_113047(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 112978, 113047);
                    return return_v;
                }


                string
                f_10218_113081_113163(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                nodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.DecodeGuidAttribute(nodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 113081, 113163);
                    return return_v;
                }


                bool
                f_10218_113202_113289(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 113202, 113289);
                    return return_v;
                }


                bool
                f_10218_113469_113551(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 113469, 113551);
                    return return_v;
                }


                bool
                f_10218_113726_113811(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 113726, 113811);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10218_113925_113955(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonNamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 113925, 113955);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10218_113925_113955_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 113925, 113955);
                    return return_v;
                }


                bool
                f_10218_114483_114558(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 114483, 114558);
                    return return_v;
                }


                bool
                f_10218_114746_114826(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 114746, 114826);
                    return return_v;
                }


                int
                f_10218_114860_114905(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeTypeForwardedToAttribute(ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 114860, 114905);
                    return 0;
                }


                bool
                f_10218_114944_115031(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 114944, 115031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_115290_115327(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 115290, 115327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_115231_115328(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 115231, 115328);
                    return return_v;
                }


                int
                f_10218_115399_115498(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.GetTargetAttributeSignatureIndex((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 115399, 115498);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10218_115554_115590(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 115554, 115590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 103008, 116095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 103008, 116095);
            }
        }

        private static void ValidateIntegralAttributeNonNegativeArguments(CSharpAttributeData attribute, AttributeSyntax nodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10218, 116207, 117115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 116380, 116415);

                f_10218_116380_116414(f_10218_116393_116413_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 116431, 116490);

                int
                argCount = attribute.CommonConstructorArguments.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 116513, 116518);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 116504, 117104) || true) && (i < argCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 116534, 116537)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 116504, 117104))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 116504, 117104);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 116571, 116648);

                        int
                        arg = f_10218_116581_116647(attribute, i, SpecialType.System_Int32)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 116666, 117089) || true) && (arg < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 116666, 117089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 116797, 116897);

                            Location
                            attributeArgumentSyntaxLocation = f_10218_116840_116896(attribute, i, nodeOpt)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 116919, 117070);

                            f_10218_116919_117069(diagnostics, ErrorCode.ERR_InvalidAttributeArgument, attributeArgumentSyntaxLocation, (DynAbs.Tracing.TraceSender.Conditional_F1(10218, 117008, 117031) || (((object)nodeOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10218, 117034, 117063)) || DynAbs.Tracing.TraceSender.Conditional_F3(10218, 117066, 117068))) ? f_10218_117034_117063(nodeOpt) : "");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 116666, 117089);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 601);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 601);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10218, 116207, 117115);

                bool
                f_10218_116393_116413_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 116393, 116413);
                    return return_v;
                }


                int
                f_10218_116380_116414(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 116380, 116414);
                    return 0;
                }


                int
                f_10218_116581_116647(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, int
                i, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetConstructorArgument<int>(i, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 116581, 116647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10218_116840_116896(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = attribute.GetAttributeArgumentSyntaxLocation(parameterIndex, attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 116840, 116896);
                    return return_v;
                }


                string
                f_10218_117034_117063(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 117034, 117063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_116919_117069(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 116919, 117069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 116207, 117115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 116207, 117115);
            }
        }

        internal void NoteFieldAccess(FieldSymbol field, bool read, bool write)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 117127, 118516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 117223, 117295);

                var
                container = f_10218_117239_117259(field) as SourceMemberContainerTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 117309, 117438) || true) && ((object)container == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 117309, 117438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 117416, 117423);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 117309, 117438);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 117454, 117494);

                f_10218_117454_117493(
                            container);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 117510, 118505) || true) && (_unusedFieldWarnings.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 117510, 118505);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 117578, 117675) || true) && (read)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 117578, 117675);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 117628, 117656);

                        f_10218_117628_117655(_unreadFields, field);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 117578, 117675);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 117695, 117839) || true) && (write)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 117695, 117839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 117746, 117753);

                        bool
                        _
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 117775, 117820);

                        f_10218_117775_117819(_unassignedFieldsMap, field, out _);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 117695, 117839);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 117510, 118505);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 117510, 118505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 118099, 118279);

                    f_10218_118099_118278(!(read && (DynAbs.Tracing.TraceSender.Expression_True(10218, 118137, 118172) && f_10218_118145_118172(_unreadFields, field))), "we are already reporting unused field warnings, there could be no more changes");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 118299, 118490);

                    f_10218_118299_118489(!(write && (DynAbs.Tracing.TraceSender.Expression_True(10218, 118336, 118384) && f_10218_118345_118384(_unassignedFieldsMap, field))), "we are already reporting unused field warnings, there could be no more changes");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 117510, 118505);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 117127, 118516);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_117239_117259(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 117239, 117259);
                    return return_v;
                }


                int
                f_10218_117454_117493(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    this_param.EnsureFieldDefinitionsNoted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 117454, 117493);
                    return 0;
                }


                bool
                f_10218_117628_117655(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                value)
                {
                    var return_v = this_param.Remove(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 117628, 117655);
                    return return_v;
                }


                bool
                f_10218_117775_117819(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                key, out bool
                value)
                {
                    var return_v = this_param.TryRemove(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 117775, 117819);
                    return return_v;
                }


                bool
                f_10218_118145_118172(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                value)
                {
                    var return_v = this_param.Remove(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 118145, 118172);
                    return return_v;
                }


                int
                f_10218_118099_118278(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 118099, 118278);
                    return 0;
                }


                bool
                f_10218_118345_118384(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 118345, 118384);
                    return return_v;
                }


                int
                f_10218_118299_118489(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 118299, 118489);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 117127, 118516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 117127, 118516);
            }
        }

        internal void NoteFieldDefinition(FieldSymbol field, bool isInternal, bool isUnread)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 118528, 118937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 118637, 118763);

                f_10218_118637_118762(_unusedFieldWarnings.IsDefault, "We shouldn't have computed the diagnostics if we're still noting definitions.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 118779, 118826);

                f_10218_118779_118825(
                            _unassignedFieldsMap, field, isInternal);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 118840, 118926) || true) && (isUnread)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 118840, 118926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 118886, 118911);

                    f_10218_118886_118910(_unreadFields, field);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 118840, 118926);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 118528, 118937);

                int
                f_10218_118637_118762(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 118637, 118762);
                    return 0;
                }


                bool
                f_10218_118779_118825(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                key, bool
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 118779, 118825);
                    return return_v;
                }


                bool
                f_10218_118886_118910(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 118886, 118910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 118528, 118937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 118528, 118937);
            }
        }

        internal override bool IsNetModule()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 118986, 119039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 118989, 119039);
                return f_10218_118989_119039(f_10218_118989_119025(f_10218_118989_119014(this._compilation))); DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 118986, 119039);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 118986, 119039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 118986, 119039);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
            f_10218_118989_119014(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            this_param)
            {
                var return_v = this_param.Options;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 118989, 119014);
                return return_v;
            }


            Microsoft.CodeAnalysis.OutputKind
            f_10218_118989_119025(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
            this_param)
            {
                var return_v = this_param.OutputKind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 118989, 119025);
                return return_v;
            }


            bool
            f_10218_118989_119039(Microsoft.CodeAnalysis.OutputKind
            kind)
            {
                var return_v = kind.IsNetModule();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 118989, 119039);
                return return_v;
            }

        }

        internal ImmutableArray<Diagnostic> GetUnusedFieldWarnings(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 119220, 124365);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 119340, 124250) || true) && (_unusedFieldWarnings.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 119340, 124250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 119514, 119590);

                    f_10218_119514_119589(                //Our maps of unread and unassigned fields won't be done until the assembly is complete.
                                    this, locationOpt: null, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 119610, 119769);

                    f_10218_119610_119768(f_10218_119623_119662(this, CompletionPart.Module), "Don't consume unused field information if there are still types to be processed.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 119949, 120005);

                    DiagnosticBag
                    diagnostics = f_10218_119977_120004()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 120505, 120621);

                    bool
                    internalsAreVisible =
                    f_10218_120553_120577(this) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 120553, 120620) || f_10218_120602_120620(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 120641, 120689);

                    HashSet<FieldSymbol>
                    handledUnreadFields = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 120709, 123239);
                        foreach (FieldSymbol field in f_10218_120739_120764_I(f_10218_120739_120764(_unassignedFieldsMap)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 120709, 123239);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 120848, 120877);

                            bool
                            isInternalAccessibility
                            = default(bool);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 120899, 120983);

                            bool
                            success = f_10218_120914_120982(_unassignedFieldsMap, field, out isInternalAccessibility)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121005, 121101);

                            f_10218_121005_121100(success, "Once CompletionPart.Module is set, no-one should be modifying the map.");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121125, 121257) || true) && (isInternalAccessibility && (DynAbs.Tracing.TraceSender.Expression_True(10218, 121129, 121175) && internalsAreVisible))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 121125, 121257);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121225, 121234);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 121125, 121257);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121281, 121395) || true) && (f_10218_121285_121313_M(!field.CanBeReferencedByName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 121281, 121395);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121363, 121372);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 121281, 121395);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121419, 121486);

                            var
                            containingType = f_10218_121440_121460(field) as SourceNamedTypeSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121508, 121624) || true) && ((object)containingType == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 121508, 121624);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121592, 121601);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 121508, 121624);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121648, 121764) || true) && (field is TupleErrorFieldSymbol)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 121648, 121764);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121732, 121741);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 121648, 121764);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121788, 121832);

                            bool
                            unread = f_10218_121802_121831(_unreadFields, field)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121854, 122159) || true) && (unread)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 121854, 122159);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 121914, 122079) || true) && (handledUnreadFields == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 121914, 122079);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 122003, 122052);

                                    handledUnreadFields = f_10218_122025_122051();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 121914, 122079);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 122105, 122136);

                                f_10218_122105_122135(handledUnreadFields, field);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 121854, 122159);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 122183, 122308) || true) && (f_10218_122187_122226(containingType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 122183, 122308);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 122276, 122285);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 122183, 122308);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 122332, 122390);

                            Symbol
                            associatedPropertyOrEvent = f_10218_122367_122389(field)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 122412, 123220) || true) && ((object)associatedPropertyOrEvent != null && (DynAbs.Tracing.TraceSender.Expression_True(10218, 122416, 122511) && f_10218_122461_122491(associatedPropertyOrEvent) == SymbolKind.Event))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 122412, 123220);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 122561, 122783) || true) && (unread)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 122561, 122783);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 122629, 122756);

                                    f_10218_122629_122755(diagnostics, ErrorCode.WRN_UnreferencedEvent, associatedPropertyOrEvent.Locations.FirstOrNone(), associatedPropertyOrEvent);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 122561, 122783);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 122412, 123220);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 122412, 123220);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 122833, 123220) || true) && (unread)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 122833, 123220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 122893, 122980);

                                    f_10218_122893_122979(diagnostics, ErrorCode.WRN_UnreferencedField, field.Locations.FirstOrNone(), field);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 122833, 123220);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 122833, 123220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 123078, 123197);

                                    f_10218_123078_123196(diagnostics, ErrorCode.WRN_UnassignedInternalField, field.Locations.FirstOrNone(), field, f_10218_123171_123195(f_10218_123184_123194(field)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 122833, 123220);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 122412, 123220);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 120709, 123239);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 2531);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 2531);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 123259, 124113);
                        foreach (FieldSymbol field in f_10218_123289_123302_I(_unreadFields))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 123259, 124113);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 123386, 123601) || true) && (handledUnreadFields != null && (DynAbs.Tracing.TraceSender.Expression_True(10218, 123390, 123456) && f_10218_123421_123456(handledUnreadFields, field)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 123386, 123601);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 123569, 123578);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 123386, 123601);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 123625, 123739) || true) && (f_10218_123629_123657_M(!field.CanBeReferencedByName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 123625, 123739);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 123707, 123716);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 123625, 123739);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 123763, 123830);

                            var
                            containingType = f_10218_123784_123804(field) as SourceNamedTypeSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 123852, 124094) || true) && ((object)containingType != null && (DynAbs.Tracing.TraceSender.Expression_True(10218, 123856, 123930) && f_10218_123890_123930_M(!containingType.HasStructLayoutAttribute)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 123852, 124094);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 123980, 124071);

                                f_10218_123980_124070(diagnostics, ErrorCode.WRN_UnreferencedFieldAssg, field.Locations.FirstOrNone(), field);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 123852, 124094);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 123259, 124113);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 855);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 855);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 124133, 124235);

                    f_10218_124133_124234(ref _unusedFieldWarnings, f_10218_124202_124233(diagnostics));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 119340, 124250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 124266, 124312);

                f_10218_124266_124311(f_10218_124279_124310_M(!_unusedFieldWarnings.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 124326, 124354);

                return _unusedFieldWarnings;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 119220, 124365);

                int
                f_10218_119514_119589(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.SourceLocation
                locationOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.ForceComplete(locationOpt: locationOpt, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 119514, 119589);
                    return 0;
                }


                bool
                f_10218_119623_119662(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CompletionPart
                part)
                {
                    var return_v = this_param.HasComplete(part);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 119623, 119662);
                    return return_v;
                }


                int
                f_10218_119610_119768(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 119610, 119768);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10218_119977_120004()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 119977, 120004);
                    return return_v;
                }


                bool
                f_10218_120553_120577(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.InternalsAreVisible;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 120553, 120577);
                    return return_v;
                }


                bool
                f_10218_120602_120620(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 120602, 120620);
                    return return_v;
                }


                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10218_120739_120764(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, bool>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 120739, 120764);
                    return return_v;
                }


                bool
                f_10218_120914_120982(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                key, out bool
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 120914, 120982);
                    return return_v;
                }


                int
                f_10218_121005_121100(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 121005, 121100);
                    return 0;
                }


                bool
                f_10218_121285_121313_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 121285, 121313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_121440_121460(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 121440, 121460);
                    return return_v;
                }


                bool
                f_10218_121802_121831(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 121802, 121831);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10218_122025_122051()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 122025, 122051);
                    return return_v;
                }


                bool
                f_10218_122105_122135(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 122105, 122135);
                    return return_v;
                }


                bool
                f_10218_122187_122226(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.HasStructLayoutAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 122187, 122226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10218_122367_122389(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 122367, 122389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10218_122461_122491(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 122461, 122491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_122629_122755(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 122629, 122755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_122893_122979(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 122893, 122979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10218_123184_123194(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 123184, 123194);
                    return return_v;
                }


                string
                f_10218_123171_123195(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = DefaultValue(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 123171, 123195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_123078_123196(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 123078, 123196);
                    return return_v;
                }


                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10218_120739_120764_I(System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 120739, 120764);
                    return return_v;
                }


                bool
                f_10218_123421_123456(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 123421, 123456);
                    return return_v;
                }


                bool
                f_10218_123629_123657_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 123629, 123657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_123784_123804(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 123784, 123804);
                    return return_v;
                }


                bool
                f_10218_123890_123930_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 123890, 123930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10218_123980_124070(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 123980, 124070);
                    return return_v;
                }


                Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10218_123289_123302_I(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 123289, 123302);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10218_124202_124233(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 124202, 124233);
                    return return_v;
                }


                bool
                f_10218_124133_124234(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 124133, 124234);
                    return return_v;
                }


                bool
                f_10218_124279_124310_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 124279, 124310);
                    return return_v;
                }


                int
                f_10218_124266_124311(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 124266, 124311);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 119220, 124365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 119220, 124365);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string DefaultValue(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10218, 124377, 125330);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 124498, 124538) || true) && (f_10218_124502_124522(type))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 124498, 124538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 124524, 124538);

                    return "null";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 124498, 124538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 124552, 125319);

                switch (f_10218_124560_124576(type))
                {

                    case SpecialType.System_Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 124552, 125319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 124664, 124679);

                        return "false";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 124552, 125319);

                    case SpecialType.System_Byte:
                    case SpecialType.System_Decimal:
                    case SpecialType.System_Double:
                    case SpecialType.System_Int16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Single:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 124552, 125319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 125235, 125246);

                        return "0";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 124552, 125319);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 124552, 125319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 125294, 125304);

                        return "";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 124552, 125319);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10218, 124377, 125330);

                bool
                f_10218_124502_124522(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 124502, 124522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10218_124560_124576(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 124560, 124576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 124377, 125330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 124377, 125330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol TryLookupForwardedMetadataTypeWithCycleDetection(ref MetadataTypeName emittedName, ConsList<AssemblySymbol> visitedAssemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 125342, 129970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 125527, 125569);

                int
                forcedArity = emittedName.ForcedArity
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 125585, 126019) || true) && (emittedName.UseCLSCompliantNameArityEncoding)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 125585, 126019);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 125667, 125929) || true) && (forcedArity == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 125667, 125929);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 125730, 125770);

                        forcedArity = emittedName.InferredArity;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 125667, 125929);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 125667, 125929);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 125812, 125929) || true) && (forcedArity != emittedName.InferredArity)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 125812, 125929);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 125898, 125910);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 125812, 125929);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 125667, 125929);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 125949, 126004);

                    f_10218_125949_126003(forcedArity == emittedName.InferredArity);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 125585, 126019);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 126035, 127763) || true) && (_lazyForwardedTypesFromSource == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 126035, 127763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 126110, 126172);

                    IDictionary<string, NamedTypeSymbol>
                    forwardedTypesFromSource
                    = default(IDictionary<string, NamedTypeSymbol>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 126290, 126352);

                    HashSet<NamedTypeSymbol>
                    forwardedTypes = f_10218_126332_126351(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 126372, 127671) || true) && (forwardedTypes != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 126372, 127671);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 126440, 126539);

                        forwardedTypesFromSource = f_10218_126467_126538(StringOrdinalComparer.Instance);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 126563, 127477);
                            foreach (NamedTypeSymbol forwardedType in f_10218_126605_126619_I(forwardedTypes))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 126563, 127477);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 126669, 126739);

                                NamedTypeSymbol
                                originalDefinition = f_10218_126706_126738(forwardedType)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 126765, 126869);

                                f_10218_126765_126868((object)f_10218_126786_126819(originalDefinition) == null, "How did a nested type get forwarded?");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 126897, 127173);

                                string
                                fullEmittedName = f_10218_126922_127172(f_10218_126957_127053(f_10218_126957_126992(originalDefinition), SymbolDisplayFormat.QualifiedNameOnlyFormat), f_10218_127140_127171(originalDefinition))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 127391, 127454);

                                forwardedTypesFromSource[fullEmittedName] = originalDefinition;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 126563, 127477);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 915);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 915);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 126372, 127671);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 126372, 127671);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 127559, 127652);

                        forwardedTypesFromSource = f_10218_127586_127651();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 126372, 127671);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 127691, 127748);

                    _lazyForwardedTypesFromSource = forwardedTypesFromSource;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 126035, 127763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 127779, 127802);

                NamedTypeSymbol
                result
                = default(NamedTypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 127818, 129931) || true) && (f_10218_127822_127897(_lazyForwardedTypesFromSource, emittedName.FullName, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 127818, 129931);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 127931, 128174) || true) && ((forcedArity == -1 || (DynAbs.Tracing.TraceSender.Expression_False(10218, 127936, 127984) || f_10218_127957_127969(result) == forcedArity)) && (DynAbs.Tracing.TraceSender.Expression_True(10218, 127935, 128099) && (f_10218_128011_128056_M(!emittedName.UseCLSCompliantNameArityEncoding) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 128011, 128077) || f_10218_128060_128072(result) == 0) || (DynAbs.Tracing.TraceSender.Expression_False(10218, 128011, 128098) || f_10218_128081_128098(result)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 127931, 128174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 128141, 128155);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 127931, 128174);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 127818, 129931);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 127818, 129931);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 128208, 129931) || true) && (!f_10218_128213_128258(f_10218_128213_128244(f_10218_128213_128233(_compilation))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 128208, 129931);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 128524, 128547);
                            // See if any of added modules forward the type.

                            // Similar to attributes, type forwarders from the second added module should override type forwarders from the first added module, etc. 
                            for (int
            i = _modules.Length - 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 128515, 129916) || true) && (i > 0)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 128556, 128559)
            , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 128515, 129916))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 128515, 129916);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 128601, 128662);

                                var
                                peModuleSymbol = (Metadata.PE.PEModuleSymbol)_modules[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 128686, 128808);

                                (AssemblySymbol firstSymbol, AssemblySymbol secondSymbol) = f_10218_128746_128807(peModuleSymbol, ref emittedName);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 128832, 129897) || true) && ((object)firstSymbol != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 128832, 129897);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 128913, 129137) || true) && ((object)secondSymbol != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 128913, 129137);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 129003, 129110);

                                        return f_10218_129010_129109(this, ref emittedName, peModuleSymbol, firstSymbol, secondSymbol);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 128913, 129137);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 129267, 129874) || true) && (visitedAssemblies != null && (DynAbs.Tracing.TraceSender.Expression_True(10218, 129271, 129339) && f_10218_129300_129339(visitedAssemblies, firstSymbol)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 129267, 129874);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 129397, 129463);

                                        return f_10218_129404_129462(this, ref emittedName);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 129267, 129874);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10218, 129267, 129874);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 129577, 129685);

                                        visitedAssemblies = f_10218_129597_129684(this, visitedAssemblies ?? (DynAbs.Tracing.TraceSender.Expression_Null<Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>?>(10218, 129632, 129683) ?? ConsList<AssemblySymbol>.Empty));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 129715, 129847);

                                        return f_10218_129722_129846(firstSymbol, ref emittedName, visitedAssemblies, digThroughForwardedTypes: true);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 129267, 129874);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 128832, 129897);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10218, 1, 1402);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10218, 1, 1402);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 128208, 129931);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10218, 127818, 129931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 129947, 129959);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 125342, 129970);

                int
                f_10218_125949_126003(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 125949, 126003);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_126332_126351(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetForwardedTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 126332, 126351);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_126467_126538(Roslyn.Utilities.StringOrdinalComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 126467, 126538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_126706_126738(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 126706, 126738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_126786_126819(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 126786, 126819);
                    return return_v;
                }


                int
                f_10218_126765_126868(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 126765, 126868);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10218_126957_126992(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 126957, 126992);
                    return return_v;
                }


                string
                f_10218_126957_127053(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 126957, 127053);
                    return return_v;
                }


                string
                f_10218_127140_127171(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 127140, 127171);
                    return return_v;
                }


                string
                f_10218_126922_127172(string
                qualifier, string
                name)
                {
                    var return_v = MetadataHelpers.BuildQualifiedName(qualifier, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 126922, 127172);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_126605_126619_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 126605, 126619);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_127586_127651()
                {
                    var return_v = SpecializedCollections.EmptyDictionary<string, NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 127586, 127651);
                    return return_v;
                }


                bool
                f_10218_127822_127897(System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 127822, 127897);
                    return return_v;
                }


                int
                f_10218_127957_127969(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 127957, 127969);
                    return return_v;
                }


                bool
                f_10218_128011_128056_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 128011, 128056);
                    return return_v;
                }


                int
                f_10218_128060_128072(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 128060, 128072);
                    return return_v;
                }


                bool
                f_10218_128081_128098(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MangleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 128081, 128098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10218_128213_128233(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 128213, 128233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10218_128213_128244(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 128213, 128244);
                    return return_v;
                }


                bool
                f_10218_128213_128258(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 128213, 128258);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol FirstSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol SecondSymbol)
                f_10218_128746_128807(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName)
                {
                    var return_v = this_param.GetAssembliesForForwardedType(ref fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 128746, 128807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                f_10218_129010_129109(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                forwardingModule, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                destination1, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                destination2)
                {
                    var return_v = this_param.CreateMultipleForwardingErrorTypeSymbol(ref emittedName, (Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)forwardingModule, destination1, destination2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 129010, 129109);
                    return return_v;
                }


                bool
                f_10218_129300_129339(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                source, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                value)
                {
                    var return_v = source.Contains<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 129300, 129339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                f_10218_129404_129462(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.CreateCycleInTypeForwarderErrorTypeSymbol(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 129404, 129462);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10218_129597_129684(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                head, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                tail)
                {
                    var return_v = new Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)head, tail);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 129597, 129684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10218_129722_129846(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                visitedAssemblies, bool
                digThroughForwardedTypes)
                {
                    var return_v = this_param.LookupTopLevelMetadataTypeWithCycleDetection(ref emittedName, visitedAssemblies, digThroughForwardedTypes: digThroughForwardedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 129722, 129846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 125342, 129970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 125342, 129970);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<NamedTypeSymbol> GetAllTopLevelForwardedTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 129982, 130157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 130084, 130146);

                return f_10218_130091_130145(this, builder: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 129982, 130157);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10218_130091_130145(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                sourceAssembly, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExportedType>?
                builder)
                {
                    var return_v = PEModuleBuilder.GetForwardedTypes(sourceAssembly, builder: builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 130091, 130145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 129982, 130157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 129982, 130157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AssemblyMetadata GetMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 130216, 130223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 130219, 130223);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 130216, 130223);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 130216, 130223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 130216, 130223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10218, 130236, 130364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10218, 130303, 130353);

                return f_10218_130310_130352(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10218, 130236, 130364);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.SourceAssemblySymbol
                f_10218_130310_130352(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.SourceAssemblySymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 130310, 130352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10218, 130236, 130364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10218, 130236, 130364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, bool>
        f_10218_4862_4907()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, bool>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 4862, 4907);
            return return_v;
        }


        Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
        f_10218_5096_5128()
        {
            var return_v = new Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 5096, 5128);
            return return_v;
        }


        Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
        f_10218_5479_5510()
        {
            var return_v = new Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 5479, 5510);
            return return_v;
        }


        int
        f_10218_5904_5937(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 5904, 5937);
            return 0;
        }


        int
        f_10218_5952_5992(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 5952, 5992);
            return 0;
        }


        bool
        f_10218_6021_6058(string
        value)
        {
            var return_v = String.IsNullOrWhiteSpace(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 6021, 6058);
            return return_v;
        }


        int
        f_10218_6007_6059(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 6007, 6059);
            return 0;
        }


        bool
        f_10218_6087_6108_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 6087, 6108);
            return return_v;
        }


        int
        f_10218_6074_6109(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 6074, 6109);
            return 0;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
        f_10218_6267_6320(int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 6267, 6320);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationTable
        f_10218_6384_6408(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Declarations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 6384, 6408);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
        f_10218_6355_6421(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        assemblySymbol, Microsoft.CodeAnalysis.CSharp.DeclarationTable
        declarations, string
        moduleName)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol(assemblySymbol, declarations, moduleName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 6355, 6421);
            return return_v;
        }


        int
        f_10218_6337_6422(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 6337, 6422);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10218_6460_6479(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 6460, 6479);
            return return_v;
        }


        Microsoft.CodeAnalysis.MetadataImportOptions
        f_10218_6460_6501(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.MetadataImportOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 6460, 6501);
            return return_v;
        }


        int
        f_10218_6770_6789(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 6770, 6789);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        f_10218_6719_6790(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        assemblySymbol, Microsoft.CodeAnalysis.PEModule
        module, Microsoft.CodeAnalysis.MetadataImportOptions
        importOptions, int
        ordinal)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol(assemblySymbol, module, importOptions, ordinal);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 6719, 6790);
            return return_v;
        }


        int
        f_10218_6701_6791(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 6701, 6791);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
        f_10218_6657_6667_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 6657, 6667);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
        f_10218_7040_7074(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
        this_param)
        {
            var return_v = this_param.ToImmutableAndFree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 7040, 7074);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10218_7096_7115(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 7096, 7115);
            return return_v;
        }


        bool
        f_10218_7095_7139_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 7095, 7139);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10218_7360_7379(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 7360, 7379);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<byte>
        f_10218_7360_7395(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.CryptoPublicKey;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10218, 7360, 7395);
            return return_v;
        }


        Microsoft.CodeAnalysis.StrongNameKeys
        f_10218_7338_7468(System.Collections.Immutable.ImmutableArray<byte>
        publicKey, System.Security.Cryptography.RSAParameters?
        privateKey, bool
        hasCounterSignature, Microsoft.CodeAnalysis.CSharp.MessageProvider
        messageProvider)
        {
            var return_v = StrongNameKeys.Create(publicKey, privateKey: privateKey, hasCounterSignature: hasCounterSignature, (Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10218, 7338, 7468);
            return return_v;
        }

    }
}
