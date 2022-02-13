// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    using MetadataOrDiagnostic = System.Object;

    public partial class CSharpCompilation
    {
        /// <summary>
        /// ReferenceManager encapsulates functionality to create an underlying SourceAssemblySymbol 
        /// (with underlying ModuleSymbols) for Compilation and AssemblySymbols for referenced
        /// assemblies (with underlying ModuleSymbols) all properly linked together based on
        /// reference resolution between them.
        /// 
        /// ReferenceManager is also responsible for reuse of metadata readers for imported modules
        /// and assemblies as well as existing AssemblySymbols for referenced assemblies. In order
        /// to do that, it maintains global cache for metadata readers and AssemblySymbols
        /// associated with them. The cache uses WeakReferences to refer to the metadata readers and
        /// AssemblySymbols to allow memory and resources being reclaimed once they are no longer
        /// used. The tricky part about reusing existing AssemblySymbols is to find a set of
        /// AssemblySymbols that are created for the referenced assemblies, which (the
        /// AssemblySymbols from the set) are linked in a way, consistent with the reference
        /// resolution between the referenced assemblies.
        /// 
        /// When existing Compilation is used as a metadata reference, there are scenarios when its
        /// underlying SourceAssemblySymbol cannot be used to provide symbols in context of the new
        /// Compilation. Consider classic multi-targeting scenario: compilation C1 references v1 of
        /// Lib.dll and compilation C2 references C1 and v2 of Lib.dll. In this case,
        /// SourceAssemblySymbol for C1 is linked to AssemblySymbol for v1 of Lib.dll. However,
        /// given the set of references for C2, the same reference for C1 should be resolved against
        /// v2 of Lib.dll. In other words, in context of C2, all types from v1 of Lib.dll leaking
        /// through C1 (through method signatures, etc.) must be retargeted to the types from v2 of
        /// Lib.dll. In this case, ReferenceManager creates a special RetargetingAssemblySymbol for
        /// C1, which is responsible for the type retargeting. The RetargetingAssemblySymbols could
        /// also be reused for different Compilations, ReferenceManager maintains a cache of
        /// RetargetingAssemblySymbols (WeakReferences) for each Compilation.
        /// 
        /// The only public entry point of this class is CreateSourceAssembly() method.
        /// </summary>
        internal sealed class ReferenceManager : CommonReferenceManager<CSharpCompilation, AssemblySymbol>
        {
            public ReferenceManager(string simpleAssemblyName, AssemblyIdentityComparer identityComparer, Dictionary<MetadataReference, MetadataOrDiagnostic>? observedMetadata)
            : base(f_10061_3661_3679_C(simpleAssemblyName), identityComparer, observedMetadata)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10061, 3472, 3746);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10061, 3472, 3746);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 3472, 3746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 3472, 3746);
                }
            }

            protected override CommonMessageProvider MessageProvider
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 3851, 3898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 3857, 3896);

                        return CSharp.MessageProvider.Instance;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 3851, 3898);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 3762, 3913);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 3762, 3913);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected override AssemblyData CreateAssemblyDataForFile(
                            PEAssembly assembly,
                            WeakList<IAssemblySymbolInternal> cachedSymbols,
                            DocumentationProvider documentationProvider,
                            string sourceAssemblySimpleName,
                            MetadataImportOptions importOptions,
                            bool embedInteropTypes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 3929, 4612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 4331, 4597);

                    return f_10061_4338_4596(assembly, cachedSymbols, embedInteropTypes, documentationProvider, sourceAssemblySimpleName, importOptions);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 3929, 4612);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager.AssemblyDataForFile
                    f_10061_4338_4596(Microsoft.CodeAnalysis.PEAssembly
                    assembly, Roslyn.Utilities.WeakList<Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>
                    cachedSymbols, bool
                    embedInteropTypes, Microsoft.CodeAnalysis.DocumentationProvider
                    documentationProvider, string
                    sourceAssemblySimpleName, Microsoft.CodeAnalysis.MetadataImportOptions
                    compilationImportOptions)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager.AssemblyDataForFile(assembly, cachedSymbols, embedInteropTypes, documentationProvider, sourceAssemblySimpleName, compilationImportOptions);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 4338, 4596);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 3929, 4612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 3929, 4612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override AssemblyData CreateAssemblyDataForCompilation(CompilationReference compilationReference)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 4628, 5332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 4768, 4837);

                    var
                    csReference = compilationReference as CSharpCompilationReference
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 4855, 5068) || true) && (csReference == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 4855, 5068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 4920, 5049);

                        throw f_10061_4926_5048(f_10061_4952_5047(f_10061_4966_5008(), f_10061_5010_5040(compilationReference), "C#"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 4855, 5068);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 5088, 5199);

                    var
                    result = f_10061_5101_5198(f_10061_5132_5155(csReference), csReference.Properties.EmbedInteropTypes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 5217, 5285);

                    f_10061_5217_5284(f_10061_5230_5253(csReference)._lazyAssemblySymbol is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 5303, 5317);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 4628, 5332);

                    string
                    f_10061_4966_5008()
                    {
                        var return_v = CSharpResources.CantReferenceCompilationOf;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 4966, 5008);
                        return return_v;
                    }


                    System.Type
                    f_10061_5010_5040(Microsoft.CodeAnalysis.CompilationReference
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 5010, 5040);
                        return return_v;
                    }


                    string
                    f_10061_4952_5047(string
                    format, System.Type
                    arg0, string
                    arg1)
                    {
                        var return_v = string.Format(format, (object)arg0, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 4952, 5047);
                        return return_v;
                    }


                    System.NotSupportedException
                    f_10061_4926_5048(string
                    message)
                    {
                        var return_v = new System.NotSupportedException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 4926, 5048);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10061_5132_5155(Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 5132, 5155);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager.AssemblyDataForCompilation
                    f_10061_5101_5198(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, bool
                    embedInteropTypes)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager.AssemblyDataForCompilation(compilation, embedInteropTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 5101, 5198);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10061_5230_5253(Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 5230, 5253);
                        return return_v;
                    }


                    int
                    f_10061_5217_5284(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 5217, 5284);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 4628, 5332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 4628, 5332);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override bool CheckPropertiesConsistency(MetadataReference primaryReference, MetadataReference duplicateReference, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 5809, 6374);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 5993, 6327) || true) && (primaryReference.Properties.EmbedInteropTypes != duplicateReference.Properties.EmbedInteropTypes)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 5993, 6327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 6135, 6273);

                        f_10061_6135_6272(diagnostics, ErrorCode.ERR_AssemblySpecifiedForLinkAndRef, NoLocation.Singleton, f_10061_6219_6245(duplicateReference), f_10061_6247_6271(primaryReference));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 6295, 6308);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 5993, 6327);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 6347, 6359);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 5809, 6374);

                    string?
                    f_10061_6219_6245(Microsoft.CodeAnalysis.MetadataReference
                    this_param)
                    {
                        var return_v = this_param.Display;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 6219, 6245);
                        return return_v;
                    }


                    string?
                    f_10061_6247_6271(Microsoft.CodeAnalysis.MetadataReference
                    this_param)
                    {
                        var return_v = this_param.Display;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 6247, 6271);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10061_6135_6272(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = diagnostics.Add(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 6135, 6272);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 5809, 6374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 5809, 6374);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override bool WeakIdentityPropertiesEquivalent(AssemblyIdentity identity1, AssemblyIdentity identity2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 6713, 7089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 6858, 6955);

                    f_10061_6858_6954(f_10061_6871_6953(f_10061_6871_6914(), f_10061_6922_6936(identity1), f_10061_6938_6952(identity2)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 6973, 7074);

                    return f_10061_6980_7073(f_10061_6980_7020(), f_10061_7028_7049(identity1), f_10061_7051_7072(identity2));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 6713, 7089);

                    System.StringComparer
                    f_10061_6871_6914()
                    {
                        var return_v = AssemblyIdentityComparer.SimpleNameComparer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 6871, 6914);
                        return return_v;
                    }


                    string
                    f_10061_6922_6936(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 6922, 6936);
                        return return_v;
                    }


                    string
                    f_10061_6938_6952(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 6938, 6952);
                        return return_v;
                    }


                    bool
                    f_10061_6871_6953(System.StringComparer
                    this_param, string
                    x, string
                    y)
                    {
                        var return_v = this_param.Equals(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 6871, 6953);
                        return return_v;
                    }


                    int
                    f_10061_6858_6954(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 6858, 6954);
                        return 0;
                    }


                    System.StringComparer
                    f_10061_6980_7020()
                    {
                        var return_v = AssemblyIdentityComparer.CultureComparer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 6980, 7020);
                        return return_v;
                    }


                    string
                    f_10061_7028_7049(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.CultureName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 7028, 7049);
                        return return_v;
                    }


                    string
                    f_10061_7051_7072(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.CultureName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 7051, 7072);
                        return return_v;
                    }


                    bool
                    f_10061_6980_7073(System.StringComparer
                    this_param, string
                    x, string
                    y)
                    {
                        var return_v = this_param.Equals(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 6980, 7073);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 6713, 7089);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 6713, 7089);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override void GetActualBoundReferencesUsedBy(AssemblySymbol assemblySymbol, List<AssemblySymbol?> referencedAssemblySymbols)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 7105, 7893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 7272, 7322);

                    f_10061_7272_7321(f_10061_7285_7320(referencedAssemblySymbols));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 7340, 7520);
                        foreach (var module in f_10061_7363_7385_I(f_10061_7363_7385(assemblySymbol)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 7340, 7520);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 7427, 7501);

                            f_10061_7427_7500(referencedAssemblySymbols, f_10061_7462_7499(module));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 7340, 7520);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 181);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 181);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 7549, 7554);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 7540, 7878) || true) && (i < f_10061_7560_7591(referencedAssemblySymbols))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 7593, 7596)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 7540, 7878))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 7540, 7878);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 7638, 7859) || true) && (f_10061_7642_7681(referencedAssemblySymbols[i]!))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 7638, 7859);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 7731, 7767);

                                referencedAssemblySymbols[i] = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 7638, 7859);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 339);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 339);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 7105, 7893);

                    bool
                    f_10061_7285_7320(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?>
                    source)
                    {
                        var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 7285, 7320);
                        return return_v;
                    }


                    int
                    f_10061_7272_7321(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 7272, 7321);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10061_7363_7385(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 7363, 7385);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_7462_7499(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetReferencedAssemblySymbols();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 7462, 7499);
                        return return_v;
                    }


                    int
                    f_10061_7427_7500(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    collection)
                    {
                        this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?>)collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 7427, 7500);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10061_7363_7385_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 7363, 7385);
                        return return_v;
                    }


                    int
                    f_10061_7560_7591(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 7560, 7591);
                        return return_v;
                    }


                    bool
                    f_10061_7642_7681(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.IsMissing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 7642, 7681);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 7105, 7893);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 7105, 7893);
                }
            }

            protected override ImmutableArray<AssemblySymbol> GetNoPiaResolutionAssemblies(AssemblySymbol candidateAssembly)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 7909, 8640);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 8054, 8549) || true) && (candidateAssembly is SourceAssemblySymbol)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 8054, 8549);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 8486, 8530);

                        return ImmutableArray<AssemblySymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 8054, 8549);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 8569, 8625);

                    return f_10061_8576_8624(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 7909, 8640);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_8576_8624(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetNoPiaResolutionAssemblies();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 8576, 8624);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 7909, 8640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 7909, 8640);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override bool IsLinked(AssemblySymbol candidateAssembly)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 8656, 8804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 8755, 8789);

                    return f_10061_8762_8788(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 8656, 8804);

                    bool
                    f_10061_8762_8788(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.IsLinked;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 8762, 8788);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 8656, 8804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 8656, 8804);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override AssemblySymbol? GetCorLibrary(AssemblySymbol candidateAssembly)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 8820, 9161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 8935, 8992);

                    AssemblySymbol
                    corLibrary = f_10061_8963_8991(candidateAssembly)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 9098, 9146);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10061, 9105, 9125) || ((f_10061_9105_9125(corLibrary) && DynAbs.Tracing.TraceSender.Conditional_F2(10061, 9128, 9132)) || DynAbs.Tracing.TraceSender.Conditional_F3(10061, 9135, 9145))) ? null : corLibrary;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 8820, 9161);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10061_8963_8991(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.CorLibrary;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 8963, 8991);
                        return return_v;
                    }


                    bool
                    f_10061_9105_9125(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.IsMissing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 9105, 9125);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 8820, 9161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 8820, 9161);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void CreateSourceAssemblyForCompilation(CSharpCompilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 9177, 12083);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 10397, 11960) || true) && (f_10061_10401_10409_M(!IsBound) && (DynAbs.Tracing.TraceSender.Expression_True(10061, 10401, 10460) && f_10061_10413_10460(this, compilation)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 10397, 11960);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 10397, 11960);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 10397, 11960);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 10608, 11960) || true) && (f_10061_10612_10633_M(!HasCircularReference))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 10608, 11960);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 10972, 11021);

                            f_10061_10972_11020(this, compilation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 10608, 11960);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 10608, 11960);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 11456, 11565);

                            var
                            newManager = f_10061_11473_11564(this.SimpleAssemblyName, this.IdentityComparer, this.ObservedMetadata)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 11587, 11663);

                            var
                            successful = f_10061_11604_11662(newManager, compilation)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 11867, 11892);

                            f_10061_11867_11891(successful);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 11916, 11941);

                            f_10061_11916_11940(
                                                newManager);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 10608, 11960);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 10397, 11960);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 11980, 11994);

                    f_10061_11980_11993(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 12012, 12068);

                    f_10061_12012_12067(compilation._lazyAssemblySymbol is object);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 9177, 12083);

                    bool
                    f_10061_10401_10409_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 10401, 10409);
                        return return_v;
                    }


                    bool
                    f_10061_10413_10460(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        var return_v = this_param.CreateAndSetSourceAssemblyFullBind(compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 10413, 10460);
                        return return_v;
                    }


                    bool
                    f_10061_10612_10633_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 10612, 10633);
                        return return_v;
                    }


                    int
                    f_10061_10972_11020(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        this_param.CreateAndSetSourceAssemblyReuseData(compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 10972, 11020);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    f_10061_11473_11564(string
                    simpleAssemblyName, Microsoft.CodeAnalysis.AssemblyIdentityComparer
                    identityComparer, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, object>
                    observedMetadata)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager(simpleAssemblyName, identityComparer, observedMetadata);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 11473, 11564);
                        return return_v;
                    }


                    bool
                    f_10061_11604_11662(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        var return_v = this_param.CreateAndSetSourceAssemblyFullBind(compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 11604, 11662);
                        return return_v;
                    }


                    int
                    f_10061_11867_11891(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 11867, 11891);
                        return 0;
                    }


                    int
                    f_10061_11916_11940(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 11916, 11940);
                        return 0;
                    }


                    int
                    f_10061_11980_11993(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 11980, 11993);
                        return 0;
                    }


                    int
                    f_10061_12012_12067(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 12012, 12067);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 9177, 12083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 9177, 12083);
                }
            }

            public PEAssemblySymbol CreatePEAssemblyForAssemblyMetadata(AssemblyMetadata metadata, MetadataImportOptions importOptions, out ImmutableDictionary<AssemblyIdentity, AssemblyIdentity> assemblyReferenceIdentityMap)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 14643, 16534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 14889, 14903);

                    f_10061_14889_14902(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 15053, 15089);

                    f_10061_15053_15088(f_10061_15066_15087_M(!HasCircularReference));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 15109, 15188);

                    var
                    referencedAssembliesByIdentity = f_10061_15146_15187()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 15206, 15375);
                        foreach (var symbol in f_10061_15229_15254_I(f_10061_15229_15254(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 15206, 15375);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 15296, 15356);

                            f_10061_15296_15355(referencedAssembliesByIdentity, f_10061_15331_15346(symbol), symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 15206, 15375);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 170);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 170);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 15395, 15433);

                    var
                    assembly = f_10061_15410_15432(metadata)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 15451, 15484);

                    f_10061_15451_15483(assembly is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 15502, 15632);

                    var
                    peReferences = assembly.AssemblyReferences.SelectAsArray(MapAssemblyIdentityToResolvedSymbol, referencedAssembliesByIdentity)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 15652, 15766);

                    assemblyReferenceIdentityMap = f_10061_15683_15765(peReferences, assembly.AssemblyReferences);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 15786, 15916);

                    var
                    assemblySymbol = f_10061_15807_15915(assembly, f_10061_15838_15867(), isLinked: false, importOptions: importOptions)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 15936, 16190);

                    var
                    unifiedAssemblies = this.UnifiedAssemblies.WhereAsArray((unified, referencedAssembliesByIdentity) => referencedAssembliesByIdentity.Contains(unified.OriginalReference, allowHigherVersion: false), referencedAssembliesByIdentity)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 16210, 16287);

                    f_10061_16210_16286(this, assemblySymbol, peReferences, unifiedAssemblies);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 16307, 16477) || true) && (f_10061_16311_16345(assembly))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 16307, 16477);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 16387, 16458);

                        f_10061_16387_16457(assemblySymbol, f_10061_16431_16456(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 16307, 16477);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 16497, 16519);

                    return assemblySymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 14643, 16534);

                    int
                    f_10061_14889_14902(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 14889, 14902);
                        return 0;
                    }


                    bool
                    f_10061_15066_15087_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 15066, 15087);
                        return return_v;
                    }


                    int
                    f_10061_15053_15088(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 15053, 15088);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.AssemblyIdentityMap<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_15146_15187()
                    {
                        var return_v = new Microsoft.CodeAnalysis.AssemblyIdentityMap<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 15146, 15187);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_15229_15254(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        var return_v = this_param.ReferencedAssemblies;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 15229, 15254);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10061_15331_15346(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 15331, 15346);
                        return return_v;
                    }


                    int
                    f_10061_15296_15355(Microsoft.CodeAnalysis.AssemblyIdentityMap<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                    identity, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    value)
                    {
                        this_param.Add(identity, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 15296, 15355);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_15229_15254_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 15229, 15254);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEAssembly?
                    f_10061_15410_15432(Microsoft.CodeAnalysis.AssemblyMetadata
                    this_param)
                    {
                        var return_v = this_param.GetAssembly();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 15410, 15432);
                        return return_v;
                    }


                    int
                    f_10061_15451_15483(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 15451, 15483);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.AssemblyIdentity>
                    f_10061_15683_15765(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                    originalIdentities)
                    {
                        var return_v = GetAssemblyReferenceIdentityBaselineMap(symbols, originalIdentities);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 15683, 15765);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DocumentationProvider
                    f_10061_15838_15867()
                    {
                        var return_v = DocumentationProvider.Default;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 15838, 15867);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                    f_10061_15807_15915(Microsoft.CodeAnalysis.PEAssembly
                    assembly, Microsoft.CodeAnalysis.DocumentationProvider
                    documentationProvider, bool
                    isLinked, Microsoft.CodeAnalysis.MetadataImportOptions
                    importOptions)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol(assembly, documentationProvider, isLinked: isLinked, importOptions: importOptions);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 15807, 15915);
                        return return_v;
                    }


                    int
                    f_10061_16210_16286(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                    assemblySymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    referencedAssemblies, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    unifiedAssemblies)
                    {
                        this_param.InitializeAssemblyReuseData((Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)assemblySymbol, referencedAssemblies, unifiedAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 16210, 16286);
                        return 0;
                    }


                    bool
                    f_10061_16311_16345(Microsoft.CodeAnalysis.PEAssembly
                    this_param)
                    {
                        var return_v = this_param.ContainsNoPiaLocalTypes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 16311, 16345);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_16431_16456(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        var return_v = this_param.ReferencedAssemblies;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 16431, 16456);
                        return return_v;
                    }


                    int
                    f_10061_16387_16457(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    assemblies)
                    {
                        this_param.SetNoPiaResolutionAssemblies(assemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 16387, 16457);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 14643, 16534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 14643, 16534);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static AssemblySymbol MapAssemblyIdentityToResolvedSymbol(AssemblyIdentity identity, AssemblyIdentityMap<AssemblySymbol> map)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10061, 16550, 17373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 16716, 16738);

                    AssemblySymbol
                    symbol
                    = default(AssemblySymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 16756, 16910) || true) && (f_10061_16760_16835(map, identity, out symbol, CompareVersionPartsSpecifiedInSource))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 16756, 16910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 16877, 16891);

                        return symbol;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 16756, 16910);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 16930, 17295) || true) && (f_10061_16934_16992(map, identity, out symbol, (v1, v2, s) => true))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 16930, 17295);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 17109, 17276);

                        throw f_10061_17115_17275(f_10061_17141_17274(f_10061_17155_17238(), identity, f_10061_17250_17273(f_10061_17250_17265(symbol))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 16930, 17295);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 17315, 17358);

                    return f_10061_17322_17357(identity);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10061, 16550, 17373);

                    bool
                    f_10061_16760_16835(Microsoft.CodeAnalysis.AssemblyIdentityMap<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                    identity, out Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    value, System.Func<System.Version, System.Version, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, bool>
                    comparer)
                    {
                        var return_v = this_param.TryGetValue(identity, out value, comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 16760, 16835);
                        return return_v;
                    }


                    bool
                    f_10061_16934_16992(Microsoft.CodeAnalysis.AssemblyIdentityMap<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                    identity, out Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    value, System.Func<System.Version, System.Version, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, bool>
                    comparer)
                    {
                        var return_v = this_param.TryGetValue(identity, out value, comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 16934, 16992);
                        return return_v;
                    }


                    string
                    f_10061_17155_17238()
                    {
                        var return_v = CodeAnalysisResources.ChangingVersionOfAssemblyReferenceIsNotAllowedDuringDebugging;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 17155, 17238);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10061_17250_17265(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 17250, 17265);
                        return return_v;
                    }


                    System.Version
                    f_10061_17250_17273(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.Version;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 17250, 17273);
                        return return_v;
                    }


                    string
                    f_10061_17141_17274(string
                    format, Microsoft.CodeAnalysis.AssemblyIdentity
                    arg0, System.Version
                    arg1)
                    {
                        var return_v = string.Format(format, (object)arg0, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 17141, 17274);
                        return return_v;
                    }


                    System.NotSupportedException
                    f_10061_17115_17275(string
                    message)
                    {
                        var return_v = new System.NotSupportedException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 17115, 17275);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol
                    f_10061_17322_17357(Microsoft.CodeAnalysis.AssemblyIdentity
                    identity)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol(identity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 17322, 17357);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 16550, 17373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 16550, 17373);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void CreateAndSetSourceAssemblyReuseData(CSharpCompilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 17389, 18561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 17501, 17515);

                    f_10061_17501_17514(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 17665, 17701);

                    f_10061_17665_17700(f_10061_17678_17699_M(!HasCircularReference));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 17721, 17776);

                    string
                    moduleName = f_10061_17741_17775(compilation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 17794, 17914);

                    var
                    assemblySymbol = f_10061_17815_17913(compilation, this.SimpleAssemblyName, moduleName, f_10061_17890_17912(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 17934, 18029);

                    f_10061_17934_18028(this, assemblySymbol, f_10061_17978_18003(this), f_10061_18005_18027(this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 18049, 18546) || true) && (compilation._lazyAssemblySymbol is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 18049, 18546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 18140, 18180);
                        lock (SymbolCacheAndReferenceManagerStateGuard)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 18230, 18504) || true) && (compilation._lazyAssemblySymbol is null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 18230, 18504);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 18331, 18380);

                                compilation._lazyAssemblySymbol = assemblySymbol;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 18410, 18477);

                                f_10061_18410_18476(f_10061_18423_18475(compilation._referenceManager, this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 18230, 18504);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 18049, 18546);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 17389, 18561);

                    int
                    f_10061_17501_17514(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 17501, 17514);
                        return 0;
                    }


                    bool
                    f_10061_17678_17699_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 17678, 17699);
                        return return_v;
                    }


                    int
                    f_10061_17665_17700(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 17665, 17700);
                        return 0;
                    }


                    string
                    f_10061_17741_17775(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.MakeSourceModuleName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 17741, 17775);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                    f_10061_17890_17912(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        var return_v = this_param.ReferencedModules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 17890, 17912);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    f_10061_17815_17913(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, string
                    assemblySimpleName, string
                    moduleName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                    netModules)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol(compilation, assemblySimpleName, moduleName, netModules);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 17815, 17913);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_17978_18003(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        var return_v = this_param.ReferencedAssemblies;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 17978, 18003);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    f_10061_18005_18027(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        var return_v = this_param.UnifiedAssemblies;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 18005, 18027);
                        return return_v;
                    }


                    int
                    f_10061_17934_18028(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    assemblySymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    referencedAssemblies, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    unifiedAssemblies)
                    {
                        this_param.InitializeAssemblyReuseData((Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)assemblySymbol, referencedAssemblies, unifiedAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 17934, 18028);
                        return 0;
                    }


                    bool
                    f_10061_18423_18475(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    objA, Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 18423, 18475);
                        return return_v;
                    }


                    int
                    f_10061_18410_18476(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 18410, 18476);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 17389, 18561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 17389, 18561);
                }
            }

            private void InitializeAssemblyReuseData(AssemblySymbol assemblySymbol, ImmutableArray<AssemblySymbol> referencedAssemblies, ImmutableArray<UnifiedAssembly<AssemblySymbol>> unifiedAssemblies)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 18577, 19623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 18801, 18815);

                    f_10061_18801_18814(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 18835, 18902);

                    f_10061_18835_18901(
                                    assemblySymbol, f_10061_18864_18882(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?>(10061, 18864, 18900) ?? assemblySymbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 18922, 19082);

                    var
                    sourceModuleReferences = f_10061_18951_19081(referencedAssemblies.SelectAsArray(a => a.Identity), referencedAssemblies, unifiedAssemblies)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 19100, 19164);

                    f_10061_19100_19163(f_10061_19100_19122(assemblySymbol)[0], sourceModuleReferences);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 19184, 19229);

                    var
                    assemblyModules = f_10061_19206_19228(assemblySymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 19247, 19314);

                    var
                    referencedModulesReferences = f_10061_19281_19313(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 19332, 19411);

                    f_10061_19332_19410(assemblyModules.Length == referencedModulesReferences.Length + 1);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 19440, 19445);

                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 19431, 19608) || true) && (i < assemblyModules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 19475, 19478)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 19431, 19608))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 19431, 19608);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 19520, 19589);

                            f_10061_19520_19588(assemblyModules[i], referencedModulesReferences[i - 1]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 178);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 178);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 18577, 19623);

                    int
                    f_10061_18801_18814(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 18801, 18814);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                    f_10061_18864_18882(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        var return_v = this_param.CorLibraryOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 18864, 18882);
                        return return_v;
                    }


                    int
                    f_10061_18835_18901(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    corLibrary)
                    {
                        this_param.SetCorLibrary(corLibrary);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 18835, 18901);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_18951_19081(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                    identities, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    unifiedAssemblies)
                    {
                        var return_v = new Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>(identities, symbols, unifiedAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 18951, 19081);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10061_19100_19122(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 19100, 19122);
                        return return_v;
                    }


                    int
                    f_10061_19100_19163(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param, Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    moduleReferences)
                    {
                        this_param.SetReferences(moduleReferences);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 19100, 19163);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10061_19206_19228(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 19206, 19228);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    f_10061_19281_19313(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        var return_v = this_param.ReferencedModulesReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 19281, 19313);
                        return return_v;
                    }


                    int
                    f_10061_19332_19410(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 19332, 19410);
                        return 0;
                    }


                    int
                    f_10061_19520_19588(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param, Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    moduleReferences)
                    {
                        this_param.SetReferences(moduleReferences);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 19520, 19588);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 18577, 19623);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 18577, 19623);
                }
            }

            private bool CreateAndSetSourceAssemblyFullBind(CSharpCompilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 19771, 30583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 19882, 19938);

                    var
                    resolutionDiagnostics = f_10061_19910_19937()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 19956, 20066);

                    var
                    assemblyReferencesBySimpleName = f_10061_19993_20065()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 20084, 20167);

                    bool
                    supersedeLowerVersions = f_10061_20114_20166(f_10061_20114_20133(compilation))
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 20231, 20308);

                        IDictionary<(string, string), MetadataReference>?
                        boundReferenceDirectiveMap
                        = default(IDictionary<(string, string), MetadataReference>?);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 20330, 20389);

                        ImmutableArray<MetadataReference>
                        boundReferenceDirectives
                        = default(ImmutableArray<MetadataReference>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 20411, 20461);

                        ImmutableArray<AssemblyData>
                        referencedAssemblies
                        = default(ImmutableArray<AssemblyData>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 20483, 20516);

                        ImmutableArray<PEModule>
                        modules
                        = default(ImmutableArray<PEModule>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 20599, 20652);

                        ImmutableArray<MetadataReference>
                        explicitReferences
                        = default(ImmutableArray<MetadataReference>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 20676, 21145);

                        ImmutableArray<ResolvedReference>
                        referenceMap = f_10061_20725_21144(this, compilation, assemblyReferencesBySimpleName, out explicitReferences, out boundReferenceDirectiveMap, out boundReferenceDirectives, out referencedAssemblies, out modules, resolutionDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 21169, 21330);

                        var
                        assemblyBeingBuiltData = f_10061_21198_21329(f_10061_21236_21297(name: SimpleAssemblyName, noThrow: true), referencedAssemblies, modules)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 21352, 21434);

                        var
                        explicitAssemblyData = referencedAssemblies.Insert(0, assemblyBeingBuiltData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 21563, 21589);

                        bool
                        hasCircularReference
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 21611, 21631);

                        int
                        corLibraryIndex
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 21653, 21716);

                        ImmutableArray<MetadataReference>
                        implicitlyResolvedReferences
                        = default(ImmutableArray<MetadataReference>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 21738, 21803);

                        ImmutableArray<ResolvedReference>
                        implicitlyResolvedReferenceMap
                        = default(ImmutableArray<ResolvedReference>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 21825, 21870);

                        ImmutableArray<AssemblyData>
                        allAssemblyData
                        = default(ImmutableArray<AssemblyData>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 22229, 22275);

                        var
                        temp1 = f_10061_22241_22274(compilation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 22297, 22364);

                        var
                        temp2 = (DynAbs.Tracing.TraceSender.Conditional_F1(10061, 22309, 22322) || ((temp1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(10061, 22325, 22356)) || DynAbs.Tracing.TraceSender.Conditional_F3(10061, 22359, 22363))) ? f_10061_22325_22356(temp1) : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 22386, 22454);

                        var
                        temp3 = (DynAbs.Tracing.TraceSender.Conditional_F1(10061, 22398, 22411) || ((temp2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(10061, 22414, 22446)) || DynAbs.Tracing.TraceSender.Conditional_F3(10061, 22449, 22453))) ? f_10061_22414_22446(temp2) : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 22476, 22546);

                        var
                        temp4 = (DynAbs.Tracing.TraceSender.Conditional_F1(10061, 22488, 22501) || ((temp3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(10061, 22504, 22538)) || DynAbs.Tracing.TraceSender.Conditional_F3(10061, 22541, 22545))) ? f_10061_22504_22538(temp3) : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 22568, 22686);

                        var
                        implicitReferenceResolutions = temp4 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.PortableExecutableReference?>?>(10061, 22603, 22685) ?? ImmutableDictionary<AssemblyIdentity, PortableExecutableReference?>.Empty)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 22710, 23572);

                        BoundInputAssembly[]
                        bindingResult = f_10061_22747_23571(this, compilation, explicitAssemblyData, modules, explicitReferences, referenceMap, f_10061_22981_23026(f_10061_22981_23000(compilation)), f_10061_23053_23094(f_10061_23053_23072(compilation)), supersedeLowerVersions, assemblyReferencesBySimpleName, out allAssemblyData, out implicitlyResolvedReferences, out implicitlyResolvedReferenceMap, ref implicitReferenceResolutions, resolutionDiagnostics, out hasCircularReference, out corLibraryIndex)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 23596, 23657);

                        f_10061_23596_23656(f_10061_23609_23629(bindingResult) == allAssemblyData.Length);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 23681, 23756);

                        var
                        references = explicitReferences.AddRange(implicitlyResolvedReferences)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 23778, 23847);

                        referenceMap = referenceMap.AddRange(implicitlyResolvedReferenceMap);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 23871, 23952);

                        Dictionary<MetadataReference, int>
                        referencedAssembliesMap
                        = default(Dictionary<MetadataReference, int>),
                        referencedModulesMap
                        = default(Dictionary<MetadataReference, int>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 23974, 24043);

                        ImmutableArray<ImmutableArray<string>>
                        aliasesOfReferencedAssemblies
                        = default(ImmutableArray<ImmutableArray<string>>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 24065, 24588);

                        f_10061_24065_24587(bindingResult, references, referenceMap, modules.Length, referencedAssemblies.Length, assemblyReferencesBySimpleName, supersedeLowerVersions, out referencedAssembliesMap, out referencedModulesMap, out aliasesOfReferencedAssemblies);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 24711, 24744);

                        var
                        newSymbols = f_10061_24728_24743()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 24777, 24782);

                            for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 24768, 25425) || true) && (i < f_10061_24788_24808(bindingResult))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 24810, 24813)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 24768, 25425))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 24768, 25425);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 24863, 24915);

                                ref BoundInputAssembly
                                bound = ref bindingResult[i]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 24941, 25299) || true) && (bound.AssemblySymbol is null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 24941, 25299);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 25119, 25224);

                                    bound.AssemblySymbol = f_10061_25142_25223(((AssemblyDataForMetadataOrCompilation)allAssemblyData[i]));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 25254, 25272);

                                    f_10061_25254_25271(newSymbols, i);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 24941, 25299);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 25327, 25402);

                                f_10061_25327_25401(f_10061_25340_25367(allAssemblyData[i]) == f_10061_25371_25400(bound.AssemblySymbol));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 658);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 658);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 25449, 25585);

                        var
                        assemblySymbol = f_10061_25470_25584(compilation, SimpleAssemblyName, f_10061_25528_25562(compilation), netModules: modules)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 25609, 25636);

                        AssemblySymbol?
                        corLibrary
                        = default(AssemblySymbol?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 25660, 26111) || true) && (corLibraryIndex == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 25660, 26111);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 25734, 25762);

                            corLibrary = assemblySymbol;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 25660, 26111);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 25660, 26111);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 25812, 26111) || true) && (corLibraryIndex > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 25812, 26111);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 25885, 25944);

                                corLibrary = bindingResult[corLibraryIndex].AssemblySymbol;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 25812, 26111);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 25812, 26111);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 26042, 26088);

                                corLibrary = MissingCorLibrarySymbol.Instance;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 25812, 26111);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 25660, 26111);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 26135, 26176);

                        f_10061_26135_26175(
                                            assemblySymbol, corLibrary);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 26369, 26447);

                        Dictionary<AssemblyIdentity, MissingAssemblySymbol>?
                        missingAssemblies = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 26524, 26586);

                        int
                        totalReferencedAssemblyCount = allAssemblyData.Length - 1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 26696, 26762);

                        ImmutableArray<ModuleReferences<AssemblySymbol>>
                        moduleReferences
                        = default(ImmutableArray<ModuleReferences<AssemblySymbol>>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 26784, 27083);

                        f_10061_26784_27082(assemblySymbol, modules, totalReferencedAssemblyCount, bindingResult, ref missingAssemblies, out moduleReferences);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 27107, 27695) || true) && (f_10061_27111_27127(newSymbols) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 27107, 27695);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 27386, 27544) || true) && (hasCircularReference)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 27386, 27544);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 27468, 27517);

                                bindingResult[0].AssemblySymbol = assemblySymbol;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 27386, 27544);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 27572, 27672);

                            f_10061_27572_27671(newSymbols, assemblySymbol, allAssemblyData, bindingResult, missingAssemblies);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 27107, 27695);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 27719, 30339) || true) && (compilation._lazyAssemblySymbol is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 27719, 30339);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 27818, 27858);
                            lock (SymbolCacheAndReferenceManagerStateGuard)
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 27916, 30289) || true) && (compilation._lazyAssemblySymbol is null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 27916, 30289);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 28025, 28428) || true) && (f_10061_28029_28036())
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 28025, 28428);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 28380, 28393);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 28025, 28428);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 28464, 28532);

                                    f_10061_28464_28531(newSymbols, allAssemblyData, bindingResult);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 28568, 29622);

                                    f_10061_28568_29621(this, referencedAssembliesMap, referencedModulesMap, boundReferenceDirectiveMap, boundReferenceDirectives, explicitReferences, implicitReferenceResolutions, hasCircularReference, f_10061_29055_29089(resolutionDiagnostics), (DynAbs.Tracing.TraceSender.Conditional_F1(10061, 29128, 29171) || ((f_10061_29128_29171(corLibrary, assemblySymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10061, 29174, 29179)) || DynAbs.Tracing.TraceSender.Conditional_F3(10061, 29182, 29192))) ? null! : corLibrary, modules, moduleReferences, f_10061_29405_29463(f_10061_29405_29432(assemblySymbol)), aliasesOfReferencedAssemblies, f_10061_29570_29620(f_10061_29570_29597(assemblySymbol)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 29776, 29867);

                                    f_10061_29776_29866(f_10061_29789_29841(compilation._referenceManager, this) || (DynAbs.Tracing.TraceSender.Expression_False(10061, 29789, 29865) || f_10061_29845_29865()));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 29901, 29938);

                                    compilation._referenceManager = this;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 30209, 30258);

                                    compilation._lazyAssemblySymbol = assemblySymbol;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 27916, 30289);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 27719, 30339);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 30363, 30375);

                        return true;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(10061, 30412, 30568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 30460, 30489);

                        f_10061_30460_30488(resolutionDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 30511, 30549);

                        f_10061_30511_30548(assemblyReferencesBySimpleName);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(10061, 30412, 30568);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 19771, 30583);

                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10061_19910_19937()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 19910, 19937);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.ReferencedAssemblyIdentity>>
                    f_10061_19993_20065()
                    {
                        var return_v = PooledDictionary<string, List<ReferencedAssemblyIdentity>>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 19993, 20065);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10061_20114_20133(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 20114, 20133);
                        return return_v;
                    }


                    bool
                    f_10061_20114_20166(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.ReferencesSupersedeLowerVersions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 20114, 20166);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.ResolvedReference>
                    f_10061_20725_21144(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.ReferencedAssemblyIdentity>>
                    assemblyReferencesBySimpleName, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    references, out System.Collections.Generic.IDictionary<(string, string), Microsoft.CodeAnalysis.MetadataReference>?
                    boundReferenceDirectiveMap, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    boundReferenceDirectives, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyData>
                    assemblies, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                    modules, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.ResolveMetadataReferences(compilation, (System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.ReferencedAssemblyIdentity>>)assemblyReferencesBySimpleName, out references, out boundReferenceDirectiveMap, out boundReferenceDirectives, out assemblies, out modules, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 20725, 21144);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10061_21236_21297(string
                    name, bool
                    noThrow)
                    {
                        var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name: name, noThrow: noThrow);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 21236, 21297);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyDataForAssemblyBeingBuilt
                    f_10061_21198_21329(Microsoft.CodeAnalysis.AssemblyIdentity
                    identity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyData>
                    referencedAssemblyData, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                    modules)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyDataForAssemblyBeingBuilt(identity, referencedAssemblyData, modules);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 21198, 21329);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpScriptCompilationInfo?
                    f_10061_22241_22274(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.ScriptCompilationInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 22241, 22274);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
                    f_10061_22325_22356(Microsoft.CodeAnalysis.CSharp.CSharpScriptCompilationInfo
                    this_param)
                    {
                        var return_v = this_param.PreviousScriptCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 22325, 22356);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    f_10061_22414_22446(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.GetBoundReferenceManager();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 22414, 22446);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.PortableExecutableReference?>
                    f_10061_22504_22538(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        var return_v = this_param.ImplicitReferenceResolutions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 22504, 22538);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10061_22981_23000(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 22981, 23000);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MetadataReferenceResolver?
                    f_10061_22981_23026(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.MetadataReferenceResolver;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 22981, 23026);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10061_23053_23072(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 23053, 23072);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MetadataImportOptions
                    f_10061_23053_23094(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.MetadataImportOptions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 23053, 23094);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly[]
                    f_10061_22747_23571(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyData>
                    explicitAssemblies, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                    explicitModules, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    explicitReferences, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.ResolvedReference>
                    explicitReferenceMap, Microsoft.CodeAnalysis.MetadataReferenceResolver?
                    resolverOpt, Microsoft.CodeAnalysis.MetadataImportOptions
                    importOptions, bool
                    supersedeLowerVersions, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.ReferencedAssemblyIdentity>>
                    assemblyReferencesBySimpleName, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyData>
                    allAssemblies, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    implicitlyResolvedReferences, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.ResolvedReference>
                    implicitlyResolvedReferenceMap, ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.PortableExecutableReference?>
                    implicitReferenceResolutions, Microsoft.CodeAnalysis.DiagnosticBag
                    resolutionDiagnostics, out bool
                    hasCircularReference, out int
                    corLibraryIndex)
                    {
                        var return_v = this_param.Bind(compilation, explicitAssemblies, explicitModules, explicitReferences, explicitReferenceMap, resolverOpt, importOptions, supersedeLowerVersions, (System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.ReferencedAssemblyIdentity>>)assemblyReferencesBySimpleName, out allAssemblies, out implicitlyResolvedReferences, out implicitlyResolvedReferenceMap, ref implicitReferenceResolutions, resolutionDiagnostics, out hasCircularReference, out corLibraryIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 22747, 23571);
                        return return_v;
                    }


                    int
                    f_10061_23609_23629(Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 23609, 23629);
                        return return_v;
                    }


                    int
                    f_10061_23596_23656(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 23596, 23656);
                        return 0;
                    }


                    int
                    f_10061_24065_24587(Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly[]
                    bindingResult, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    references, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.ResolvedReference>
                    referenceMap, int
                    referencedModuleCount, int
                    explicitlyReferencedAssemblyCount, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.ReferencedAssemblyIdentity>>
                    assemblyReferencesBySimpleName, bool
                    supersedeLowerVersions, out System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                    referencedAssembliesMap, out System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                    referencedModulesMap, out System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<string>>
                    aliasesOfReferencedAssemblies)
                    {
                        BuildReferencedAssembliesAndModulesMaps(bindingResult, references, referenceMap, referencedModuleCount, explicitlyReferencedAssemblyCount, (System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.ReferencedAssemblyIdentity>>)assemblyReferencesBySimpleName, supersedeLowerVersions, out referencedAssembliesMap, out referencedModulesMap, out aliasesOfReferencedAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 24065, 24587);
                        return 0;
                    }


                    System.Collections.Generic.List<int>
                    f_10061_24728_24743()
                    {
                        var return_v = new System.Collections.Generic.List<int>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 24728, 24743);
                        return return_v;
                    }


                    int
                    f_10061_24788_24808(Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 24788, 24808);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10061_25142_25223(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager.AssemblyDataForMetadataOrCompilation
                    this_param)
                    {
                        var return_v = this_param.CreateAssemblySymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 25142, 25223);
                        return return_v;
                    }


                    int
                    f_10061_25254_25271(System.Collections.Generic.List<int>
                    this_param, int
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 25254, 25271);
                        return 0;
                    }


                    bool
                    f_10061_25340_25367(Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyData
                    this_param)
                    {
                        var return_v = this_param.IsLinked;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 25340, 25367);
                        return return_v;
                    }


                    bool
                    f_10061_25371_25400(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.IsLinked;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 25371, 25400);
                        return return_v;
                    }


                    int
                    f_10061_25327_25401(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 25327, 25401);
                        return 0;
                    }


                    string
                    f_10061_25528_25562(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.MakeSourceModuleName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 25528, 25562);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    f_10061_25470_25584(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, string
                    assemblySimpleName, string
                    moduleName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                    netModules)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol(compilation, assemblySimpleName, moduleName, netModules: netModules);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 25470, 25584);
                        return return_v;
                    }


                    int
                    f_10061_26135_26175(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                    corLibrary)
                    {
                        this_param.SetCorLibrary(corLibrary);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 26135, 26175);
                        return 0;
                    }


                    int
                    f_10061_26784_27082(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    sourceAssembly, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                    modules, int
                    totalReferencedAssemblyCount, Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly[]
                    bindingResult, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>?
                    missingAssemblies, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    moduleReferences)
                    {
                        SetupReferencesForSourceAssembly(sourceAssembly, modules, totalReferencedAssemblyCount, bindingResult, ref missingAssemblies, out moduleReferences);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 26784, 27082);
                        return 0;
                    }


                    int
                    f_10061_27111_27127(System.Collections.Generic.List<int>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 27111, 27127);
                        return return_v;
                    }


                    int
                    f_10061_27572_27671(System.Collections.Generic.List<int>
                    newSymbols, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    sourceAssembly, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyData>
                    assemblies, Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly[]
                    bindingResult, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>?
                    missingAssemblies)
                    {
                        InitializeNewSymbols(newSymbols, sourceAssembly, assemblies, bindingResult, missingAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 27572, 27671);
                        return 0;
                    }


                    bool
                    f_10061_28029_28036()
                    {
                        var return_v = IsBound;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 28029, 28036);
                        return return_v;
                    }


                    int
                    f_10061_28464_28531(System.Collections.Generic.List<int>
                    newSymbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyData>
                    assemblies, Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly[]
                    bindingResult)
                    {
                        UpdateSymbolCacheNoLock(newSymbols, assemblies, bindingResult);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 28464, 28531);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_10061_29055_29089(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        var return_v = this_param.ToReadOnly();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 29055, 29089);
                        return return_v;
                    }


                    bool
                    f_10061_29128_29171(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object?)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 29128, 29171);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10061_29405_29432(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.SourceModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 29405, 29432);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_29405_29463(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetReferencedAssemblySymbols();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 29405, 29463);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10061_29570_29597(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.SourceModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 29570, 29597);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    f_10061_29570_29620(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUnifiedAssemblies();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 29570, 29620);
                        return return_v;
                    }


                    int
                    f_10061_28568_29621(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                    referencedAssembliesMap, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                    referencedModulesMap, System.Collections.Generic.IDictionary<(string, string), Microsoft.CodeAnalysis.MetadataReference>
                    boundReferenceDirectiveMap, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    directiveReferences, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    explicitReferences, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.PortableExecutableReference?>
                    implicitReferenceResolutions, bool
                    containsCircularReferences, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                    corLibraryOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                    referencedModules, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    referencedModulesReferences, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    referencedAssemblies, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<string>>
                    aliasesOfReferencedAssemblies, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    unifiedAssemblies)
                    {
                        this_param.InitializeNoLock(referencedAssembliesMap, referencedModulesMap, boundReferenceDirectiveMap, directiveReferences, explicitReferences, implicitReferenceResolutions, containsCircularReferences, diagnostics, corLibraryOpt, referencedModules, referencedModulesReferences, referencedAssemblies, aliasesOfReferencedAssemblies, unifiedAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 28568, 29621);
                        return 0;
                    }


                    bool
                    f_10061_29789_29841(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    objA, Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 29789, 29841);
                        return return_v;
                    }


                    bool
                    f_10061_29845_29865()
                    {
                        var return_v = HasCircularReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 29845, 29865);
                        return return_v;
                    }


                    int
                    f_10061_29776_29866(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 29776, 29866);
                        return 0;
                    }


                    int
                    f_10061_30460_30488(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 30460, 30488);
                        return 0;
                    }


                    int
                    f_10061_30511_30548(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.ReferencedAssemblyIdentity>>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 30511, 30548);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 19771, 30583);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 19771, 30583);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static void InitializeNewSymbols(
                            List<int> newSymbols,
                            SourceAssemblySymbol sourceAssembly,
                            ImmutableArray<AssemblyData> assemblies,
                            BoundInputAssembly[] bindingResult,
                            Dictionary<AssemblyIdentity, MissingAssemblySymbol>? missingAssemblies)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10061, 30599, 34475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 30966, 31001);

                    f_10061_30966_31000(f_10061_30979_30995(newSymbols) > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 31021, 31064);

                    var
                    corLibrary = f_10061_31038_31063(sourceAssembly)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 31082, 31129);

                    f_10061_31082_31128((object)corLibrary != null);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 31149, 31883);
                        foreach (int i in f_10061_31167_31177_I(newSymbols))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 31149, 31883);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 31219, 31285);

                            var
                            compilationData = assemblies[i] as AssemblyDataForCompilation
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 31309, 31864) || true) && (compilationData != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 31309, 31864);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 31386, 31525);

                                f_10061_31386_31524(bindingResult, ref bindingResult[i], ref missingAssemblies, sourceAssemblyDebugOnly: sourceAssembly);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 31309, 31864);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 31309, 31864);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 31623, 31673);

                                var
                                fileData = (AssemblyDataForFile)assemblies[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 31699, 31841);

                                f_10061_31699_31840(fileData, bindingResult, ref bindingResult[i], ref missingAssemblies, sourceAssemblyDebugOnly: sourceAssembly);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 31309, 31864);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 31149, 31883);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 735);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 735);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 31987, 32070);

                    var
                    linkedReferencedAssembliesBuilder = f_10061_32027_32069()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 32088, 32177);

                    var
                    noPiaResolutionAssemblies = f_10061_32120_32176(f_10061_32120_32142(sourceAssembly)[0])
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 32197, 34118);
                        foreach (int i in f_10061_32215_32225_I(newSymbols))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 32197, 34118);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 32267, 32334);

                            ref BoundInputAssembly
                            currentBindingResult = ref bindingResult[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 32356, 32416);

                            f_10061_32356_32415(currentBindingResult.AssemblySymbol is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 32438, 32500);

                            f_10061_32438_32499(currentBindingResult.ReferenceBinding is object);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 32524, 32730) || true) && (f_10061_32528_32565(assemblies[i]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 32524, 32730);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 32615, 32707);

                                f_10061_32615_32706(currentBindingResult.AssemblySymbol, noPiaResolutionAssemblies);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 32524, 32730);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 32814, 32856);

                            f_10061_32814_32855(
                                                // Setup linked referenced assemblies.
                                                linkedReferencedAssembliesBuilder);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 32880, 33054) || true) && (f_10061_32884_32906(assemblies[i]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 32880, 33054);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 32956, 33031);

                                f_10061_32956_33030(linkedReferencedAssembliesBuilder, currentBindingResult.AssemblySymbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 32880, 33054);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 33078, 33675);
                                foreach (var referenceBinding in f_10061_33111_33148_I(currentBindingResult.ReferenceBinding))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 33078, 33675);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 33198, 33652) || true) && (referenceBinding.IsBound && (DynAbs.Tracing.TraceSender.Expression_True(10061, 33202, 33312) && f_10061_33259_33312(assemblies[referenceBinding.DefinitionIndex])))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 33198, 33652);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 33370, 33460);

                                        var
                                        linkedAssemblySymbol = bindingResult[referenceBinding.DefinitionIndex].AssemblySymbol
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 33490, 33535);

                                        f_10061_33490_33534(linkedAssemblySymbol is object);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 33565, 33625);

                                        f_10061_33565_33624(linkedReferencedAssembliesBuilder, linkedAssemblySymbol);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 33198, 33652);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 33078, 33675);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 598);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 598);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 33699, 34013) || true) && (f_10061_33703_33742(linkedReferencedAssembliesBuilder) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 33699, 34013);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 33796, 33849);

                                f_10061_33796_33848(linkedReferencedAssembliesBuilder);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 33875, 33990);

                                f_10061_33875_33989(currentBindingResult.AssemblySymbol, f_10061_33941_33988(linkedReferencedAssembliesBuilder));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 33699, 34013);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 34037, 34099);

                            f_10061_34037_34098(
                                                currentBindingResult.AssemblySymbol, corLibrary);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 32197, 34118);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 1922);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 1922);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 34138, 34179);

                    f_10061_34138_34178(
                                    linkedReferencedAssembliesBuilder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 34199, 34460) || true) && (missingAssemblies != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 34199, 34460);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 34270, 34441);
                            foreach (var missingAssembly in f_10061_34302_34326_I(f_10061_34302_34326(missingAssemblies)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 34270, 34441);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 34376, 34418);

                                f_10061_34376_34417(missingAssembly, corLibrary);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 34270, 34441);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 172);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 172);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 34199, 34460);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10061, 30599, 34475);

                    int
                    f_10061_30979_30995(System.Collections.Generic.List<int>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 30979, 30995);
                        return return_v;
                    }


                    int
                    f_10061_30966_31000(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 30966, 31000);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10061_31038_31063(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.CorLibrary;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 31038, 31063);
                        return return_v;
                    }


                    int
                    f_10061_31082_31128(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 31082, 31128);
                        return 0;
                    }


                    int
                    f_10061_31386_31524(Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly[]
                    bindingResult, ref Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly
                    currentBindingResult, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>?
                    missingAssemblies, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    sourceAssemblyDebugOnly)
                    {
                        SetupReferencesForRetargetingAssembly(bindingResult, ref currentBindingResult, ref missingAssemblies, sourceAssemblyDebugOnly: sourceAssemblyDebugOnly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 31386, 31524);
                        return 0;
                    }


                    int
                    f_10061_31699_31840(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager.AssemblyDataForFile
                    fileData, Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly[]
                    bindingResult, ref Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly
                    currentBindingResult, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>?
                    missingAssemblies, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    sourceAssemblyDebugOnly)
                    {
                        SetupReferencesForFileAssembly(fileData, bindingResult, ref currentBindingResult, ref missingAssemblies, sourceAssemblyDebugOnly: sourceAssemblyDebugOnly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 31699, 31840);
                        return 0;
                    }


                    System.Collections.Generic.List<int>
                    f_10061_31167_31177_I(System.Collections.Generic.List<int>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 31167, 31177);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_32027_32069()
                    {
                        var return_v = ArrayBuilder<AssemblySymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 32027, 32069);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10061_32120_32142(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 32120, 32142);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_32120_32176(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetReferencedAssemblySymbols();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 32120, 32176);
                        return return_v;
                    }


                    int
                    f_10061_32356_32415(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 32356, 32415);
                        return 0;
                    }


                    int
                    f_10061_32438_32499(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 32438, 32499);
                        return 0;
                    }


                    bool
                    f_10061_32528_32565(Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyData
                    this_param)
                    {
                        var return_v = this_param.ContainsNoPiaLocalTypes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 32528, 32565);
                        return return_v;
                    }


                    int
                    f_10061_32615_32706(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    assemblies)
                    {
                        this_param.SetNoPiaResolutionAssemblies(assemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 32615, 32706);
                        return 0;
                    }


                    int
                    f_10061_32814_32855(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 32814, 32855);
                        return 0;
                    }


                    bool
                    f_10061_32884_32906(Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyData
                    this_param)
                    {
                        var return_v = this_param.IsLinked;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 32884, 32906);
                        return return_v;
                    }


                    int
                    f_10061_32956_33030(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 32956, 33030);
                        return 0;
                    }


                    bool
                    f_10061_33259_33312(Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyData
                    this_param)
                    {
                        var return_v = this_param.IsLinked;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 33259, 33312);
                        return return_v;
                    }


                    int
                    f_10061_33490_33534(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 33490, 33534);
                        return 0;
                    }


                    int
                    f_10061_33565_33624(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 33565, 33624);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyReferenceBinding[]
                    f_10061_33111_33148_I(Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyReferenceBinding[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 33111, 33148);
                        return return_v;
                    }


                    int
                    f_10061_33703_33742(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 33703, 33742);
                        return return_v;
                    }


                    int
                    f_10061_33796_33848(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    this_param)
                    {
                        this_param.RemoveDuplicates();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 33796, 33848);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_33941_33988(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 33941, 33988);
                        return return_v;
                    }


                    int
                    f_10061_33875_33989(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    assemblies)
                    {
                        this_param.SetLinkedReferencedAssemblies(assemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 33875, 33989);
                        return 0;
                    }


                    int
                    f_10061_34037_34098(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    corLibrary)
                    {
                        this_param.SetCorLibrary(corLibrary);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 34037, 34098);
                        return 0;
                    }


                    System.Collections.Generic.List<int>
                    f_10061_32215_32225_I(System.Collections.Generic.List<int>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 32215, 32225);
                        return return_v;
                    }


                    int
                    f_10061_34138_34178(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 34138, 34178);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>.ValueCollection
                    f_10061_34302_34326(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 34302, 34326);
                        return return_v;
                    }


                    int
                    f_10061_34376_34417(Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    corLibrary)
                    {
                        this_param.SetCorLibrary(corLibrary);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 34376, 34417);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>.ValueCollection
                    f_10061_34302_34326_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>.ValueCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 34302, 34326);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 30599, 34475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 30599, 34475);
                }
            }

            private static void UpdateSymbolCacheNoLock(List<int> newSymbols, ImmutableArray<AssemblyData> assemblies, BoundInputAssembly[] bindingResult)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10061, 34491, 35497);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 34726, 35482);
                        foreach (int i in f_10061_34744_34754_I(newSymbols))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 34726, 35482);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 34796, 34850);

                            ref BoundInputAssembly
                            current = ref bindingResult[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 34872, 34919);

                            f_10061_34872_34918(current.AssemblySymbol is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 34943, 35009);

                            var
                            compilationData = assemblies[i] as AssemblyDataForCompilation
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 35031, 35463) || true) && (compilationData != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 35031, 35463);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 35108, 35197);

                                f_10061_35108_35196(compilationData.Compilation, current.AssemblySymbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 35031, 35463);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 35031, 35463);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 35295, 35345);

                                var
                                fileData = (AssemblyDataForFile)assemblies[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 35371, 35440);

                                f_10061_35371_35439(fileData.CachedSymbols, (PEAssemblySymbol)(current.AssemblySymbol));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 35031, 35463);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 34726, 35482);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 757);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 757);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10061, 34491, 35497);

                    int
                    f_10061_34872_34918(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 34872, 34918);
                        return 0;
                    }


                    int
                    f_10061_35108_35196(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    assembly)
                    {
                        this_param.CacheRetargetingAssemblySymbolNoLock((Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal)assembly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 35108, 35196);
                        return 0;
                    }


                    int
                    f_10061_35371_35439(Roslyn.Utilities.WeakList<Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 35371, 35439);
                        return 0;
                    }


                    System.Collections.Generic.List<int>
                    f_10061_34744_34754_I(System.Collections.Generic.List<int>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 34744, 34754);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 34491, 35497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 34491, 35497);
                }
            }

            private static void SetupReferencesForRetargetingAssembly(
                            BoundInputAssembly[] bindingResult,
                            ref BoundInputAssembly currentBindingResult,
                            ref Dictionary<AssemblyIdentity, MissingAssemblySymbol>? missingAssemblies,
                            SourceAssemblySymbol sourceAssemblyDebugOnly)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10061, 35513, 39524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 35875, 35935);

                    f_10061_35875_35934(currentBindingResult.AssemblySymbol is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 35953, 36015);

                    f_10061_35953_36014(currentBindingResult.ReferenceBinding is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 36033, 36128);

                    var
                    retargetingAssemblySymbol = (RetargetingAssemblySymbol)currentBindingResult.AssemblySymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 36146, 36219);

                    ImmutableArray<ModuleSymbol>
                    modules = f_10061_36185_36218(retargetingAssemblySymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 36237, 36270);

                    int
                    moduleCount = modules.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 36288, 36305);

                    int
                    refsUsed = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 36334, 36339);

                        for (int
        j = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 36325, 39509) || true) && (j < moduleCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 36358, 36361)
        , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 36325, 39509))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 36325, 39509);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 36403, 36566);

                            ImmutableArray<AssemblyIdentity>
                            referencedAssemblies =
                            f_10061_36484_36565(f_10061_36484_36536(f_10061_36484_36528(retargetingAssemblySymbol))[j])
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 36666, 38291) || true) && (j == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 36666, 38291);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 36726, 36911);

                                ImmutableArray<AssemblySymbol>
                                underlyingReferencedAssemblySymbols =
                                f_10061_36824_36910(f_10061_36824_36876(f_10061_36824_36868(retargetingAssemblySymbol))[0])
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 36939, 36974);

                                int
                                linkedUnderlyingReferences = 0
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 37000, 37293);
                                    foreach (AssemblySymbol asm in f_10061_37031_37066_I(underlyingReferencedAssemblySymbols))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 37000, 37293);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 37124, 37266) || true) && (f_10061_37128_37140(asm))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 37124, 37266);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 37206, 37235);

                                            linkedUnderlyingReferences++;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 37124, 37266);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 37000, 37293);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 294);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 294);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 37321, 38268) || true) && (linkedUnderlyingReferences > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 37321, 38268);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 37413, 37527);

                                    var
                                    filteredReferencedAssemblies = new AssemblyIdentity[referencedAssemblies.Length - linkedUnderlyingReferences]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 37557, 37574);

                                    int
                                    newIndex = 0
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 37615, 37620);

                                        for (int
            k = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 37606, 38045) || true) && (k < underlyingReferencedAssemblySymbols.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 37670, 37673)
            , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 37606, 38045))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 37606, 38045);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 37739, 38014) || true) && (f_10061_37743_37791_M(!underlyingReferencedAssemblySymbols[k].IsLinked))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 37739, 38014);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 37865, 37930);

                                                filteredReferencedAssemblies[newIndex] = referencedAssemblies[k];
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 37968, 37979);

                                                newIndex++;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 37739, 38014);
                                            }
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 440);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 440);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 38077, 38139);

                                    f_10061_38077_38138(newIndex == f_10061_38102_38137(filteredReferencedAssemblies));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 38169, 38241);

                                    referencedAssemblies = f_10061_38192_38240(filteredReferencedAssemblies);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 37321, 38268);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 36666, 38291);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 38315, 38359);

                            int
                            refsCount = referencedAssemblies.Length
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 38381, 38438);

                            AssemblySymbol[]
                            symbols = new AssemblySymbol[refsCount]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 38460, 38532);

                            ArrayBuilder<UnifiedAssembly<AssemblySymbol>>?
                            unifiedAssemblies = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 38565, 38570);

                                for (int
            k = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 38556, 39179) || true) && (k < refsCount)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 38587, 38590)
            , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 38556, 39179))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 38556, 39179);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 38640, 38715);

                                    var
                                    referenceBinding = currentBindingResult.ReferenceBinding[refsUsed + k]
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 38741, 39156) || true) && (referenceBinding.IsBound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 38741, 39156);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 38827, 38924);

                                        symbols[k] = f_10061_38840_38923(bindingResult, referenceBinding, ref unifiedAssemblies);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 38741, 39156);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 38741, 39156);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 39038, 39129);

                                        symbols[k] = f_10061_39051_39128(referencedAssemblies[k], ref missingAssemblies);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 38741, 39156);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 624);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 624);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 39203, 39354);

                            var
                            moduleReferences = f_10061_39226_39353(referencedAssemblies, f_10061_39285_39312(symbols), f_10061_39314_39352(unifiedAssemblies))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 39376, 39444);

                            f_10061_39376_39443(modules[j], moduleReferences, sourceAssemblyDebugOnly);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 39468, 39490);

                            refsUsed += refsCount;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 3185);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 3185);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10061, 35513, 39524);

                    int
                    f_10061_35875_35934(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 35875, 35934);
                        return 0;
                    }


                    int
                    f_10061_35953_36014(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 35953, 36014);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10061_36185_36218(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 36185, 36218);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10061_36484_36528(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.UnderlyingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 36484, 36528);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10061_36484_36536(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 36484, 36536);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                    f_10061_36484_36565(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetReferencedAssemblies();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 36484, 36565);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10061_36824_36868(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.UnderlyingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 36824, 36868);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10061_36824_36876(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 36824, 36876);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_36824_36910(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetReferencedAssemblySymbols();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 36824, 36910);
                        return return_v;
                    }


                    bool
                    f_10061_37128_37140(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.IsLinked;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 37128, 37140);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_37031_37066_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 37031, 37066);
                        return return_v;
                    }


                    bool
                    f_10061_37743_37791_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 37743, 37791);
                        return return_v;
                    }


                    int
                    f_10061_38102_38137(Microsoft.CodeAnalysis.AssemblyIdentity[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 38102, 38137);
                        return return_v;
                    }


                    int
                    f_10061_38077_38138(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 38077, 38138);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                    f_10061_38192_38240(Microsoft.CodeAnalysis.AssemblyIdentity[]
                    items)
                    {
                        var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.AssemblyIdentity>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 38192, 38240);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10061_38840_38923(Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly[]
                    bindingResult, Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyReferenceBinding
                    referenceBinding, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>?
                    unifiedAssemblies)
                    {
                        var return_v = GetAssemblyDefinitionSymbol(bindingResult, referenceBinding, ref unifiedAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 38840, 38923);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol
                    f_10061_39051_39128(Microsoft.CodeAnalysis.AssemblyIdentity
                    assemblyIdentity, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>?
                    missingAssemblies)
                    {
                        var return_v = GetOrAddMissingAssemblySymbol(assemblyIdentity, ref missingAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 39051, 39128);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_39285_39312(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol[]
                    items)
                    {
                        var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 39285, 39312);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    f_10061_39314_39352(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>?
                    items)
                    {
                        var return_v = items.AsImmutableOrEmpty<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 39314, 39352);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_39226_39353(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                    identities, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    unifiedAssemblies)
                    {
                        var return_v = new Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>(identities, symbols, unifiedAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 39226, 39353);
                        return return_v;
                    }


                    int
                    f_10061_39376_39443(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param, Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    moduleReferences, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    originatingSourceAssemblyDebugOnly)
                    {
                        this_param.SetReferences(moduleReferences, originatingSourceAssemblyDebugOnly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 39376, 39443);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 35513, 39524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 35513, 39524);
                }
            }

            private static void SetupReferencesForFileAssembly(
                            AssemblyDataForFile fileData,
                            BoundInputAssembly[] bindingResult,
                            ref BoundInputAssembly currentBindingResult,
                            ref Dictionary<AssemblyIdentity, MissingAssemblySymbol>? missingAssemblies,
                            SourceAssemblySymbol sourceAssemblyDebugOnly)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10061, 39540, 41914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 39942, 40002);

                    f_10061_39942_40001(currentBindingResult.AssemblySymbol is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40020, 40082);

                    f_10061_40020_40081(currentBindingResult.ReferenceBinding is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40100, 40193);

                    var
                    portableExecutableAssemblySymbol = (PEAssemblySymbol)currentBindingResult.AssemblySymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40213, 40293);

                    ImmutableArray<ModuleSymbol>
                    modules = f_10061_40252_40292(portableExecutableAssemblySymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40311, 40344);

                    int
                    moduleCount = modules.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40362, 40379);

                    int
                    refsUsed = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40408, 40413);

                        for (int
        j = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40399, 41899) || true) && (j < moduleCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40432, 40435)
        , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 40399, 41899))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 40399, 41899);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40477, 40547);

                            int
                            moduleReferenceCount = fileData.Assembly.ModuleReferenceCounts[j]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40569, 40629);

                            var
                            identities = new AssemblyIdentity[moduleReferenceCount]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40651, 40706);

                            var
                            symbols = new AssemblySymbol[moduleReferenceCount]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40730, 40812);

                            fileData.AssemblyReferences.CopyTo(refsUsed, identities, 0, moduleReferenceCount);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40836, 40908);

                            ArrayBuilder<UnifiedAssembly<AssemblySymbol>>?
                            unifiedAssemblies = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40939, 40944);
                                for (int
            k = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40930, 41548) || true) && (k < moduleReferenceCount)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 40972, 40975)
            , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 40930, 41548))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 40930, 41548);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 41025, 41098);

                                    var
                                    boundReference = currentBindingResult.ReferenceBinding[refsUsed + k]
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 41124, 41525) || true) && (boundReference.IsBound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 41124, 41525);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 41208, 41303);

                                        symbols[k] = f_10061_41221_41302(bindingResult, boundReference, ref unifiedAssemblies);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 41124, 41525);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 41124, 41525);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 41417, 41498);

                                        symbols[k] = f_10061_41430_41497(identities[k], ref missingAssemblies);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 41124, 41525);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 619);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 619);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 41572, 41733);

                            var
                            moduleReferences = f_10061_41595_41732(f_10061_41632_41662(identities), f_10061_41664_41691(symbols), f_10061_41693_41731(unifiedAssemblies))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 41755, 41823);

                            f_10061_41755_41822(modules[j], moduleReferences, sourceAssemblyDebugOnly);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 41847, 41880);

                            refsUsed += moduleReferenceCount;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 1501);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 1501);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10061, 39540, 41914);

                    int
                    f_10061_39942_40001(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 39942, 40001);
                        return 0;
                    }


                    int
                    f_10061_40020_40081(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 40020, 40081);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10061_40252_40292(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 40252, 40292);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10061_41221_41302(Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly[]
                    bindingResult, Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyReferenceBinding
                    referenceBinding, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>?
                    unifiedAssemblies)
                    {
                        var return_v = GetAssemblyDefinitionSymbol(bindingResult, referenceBinding, ref unifiedAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 41221, 41302);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol
                    f_10061_41430_41497(Microsoft.CodeAnalysis.AssemblyIdentity
                    assemblyIdentity, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>?
                    missingAssemblies)
                    {
                        var return_v = GetOrAddMissingAssemblySymbol(assemblyIdentity, ref missingAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 41430, 41497);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                    f_10061_41632_41662(Microsoft.CodeAnalysis.AssemblyIdentity[]
                    items)
                    {
                        var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.AssemblyIdentity>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 41632, 41662);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_41664_41691(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol[]
                    items)
                    {
                        var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 41664, 41691);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    f_10061_41693_41731(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>?
                    items)
                    {
                        var return_v = items.AsImmutableOrEmpty<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 41693, 41731);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_41595_41732(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                    identities, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    unifiedAssemblies)
                    {
                        var return_v = new Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>(identities, symbols, unifiedAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 41595, 41732);
                        return return_v;
                    }


                    int
                    f_10061_41755_41822(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param, Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    moduleReferences, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    originatingSourceAssemblyDebugOnly)
                    {
                        this_param.SetReferences(moduleReferences, originatingSourceAssemblyDebugOnly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 41755, 41822);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 39540, 41914);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 39540, 41914);
                }
            }

            private static void SetupReferencesForSourceAssembly(
                            SourceAssemblySymbol sourceAssembly,
                            ImmutableArray<PEModule> modules,
                            int totalReferencedAssemblyCount,
                            BoundInputAssembly[] bindingResult,
                            ref Dictionary<AssemblyIdentity, MissingAssemblySymbol>? missingAssemblies,
                            out ImmutableArray<ModuleReferences<AssemblySymbol>> moduleReferences)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10061, 41930, 44768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 42406, 42449);

                    var
                    moduleSymbols = f_10061_42426_42448(sourceAssembly)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 42467, 42524);

                    f_10061_42467_42523(moduleSymbols.Length == 1 + modules.Length);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 42544, 42671);

                    var
                    moduleReferencesBuilder = (DynAbs.Tracing.TraceSender.Conditional_F1(10061, 42574, 42600) || (((moduleSymbols.Length > 1) && DynAbs.Tracing.TraceSender.Conditional_F2(10061, 42603, 42663)) || DynAbs.Tracing.TraceSender.Conditional_F3(10061, 42666, 42670))) ? f_10061_42603_42663() : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 42691, 42708);

                    int
                    refsUsed = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 42735, 42750);
                        for (int
        moduleIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 42726, 44662) || true) && (moduleIndex < moduleSymbols.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 42788, 42801)
        , moduleIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 42726, 44662))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 42726, 44662);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 42843, 42964);

                            int
                            refsCount = (DynAbs.Tracing.TraceSender.Conditional_F1(10061, 42859, 42877) || (((moduleIndex == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10061, 42880, 42908)) || DynAbs.Tracing.TraceSender.Conditional_F3(10061, 42911, 42963))) ? totalReferencedAssemblyCount : modules[moduleIndex - 1].ReferencedAssemblies.Length
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 42988, 43037);

                            var
                            identities = new AssemblyIdentity[refsCount]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 43059, 43103);

                            var
                            symbols = new AssemblySymbol[refsCount]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 43127, 43199);

                            ArrayBuilder<UnifiedAssembly<AssemblySymbol>>?
                            unifiedAssemblies = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 43232, 43237);

                                for (int
            k = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 43223, 44092) || true) && (k < refsCount)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 43254, 43257)
            , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 43223, 44092))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 43223, 44092);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 43307, 43365);

                                    f_10061_43307_43364(bindingResult[0].ReferenceBinding is object);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 43391, 43461);

                                    var
                                    boundReference = bindingResult[0].ReferenceBinding![refsUsed + k]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 43487, 43544);

                                    f_10061_43487_43543(boundReference.ReferenceIdentity is object);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 43572, 43992) || true) && (boundReference.IsBound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 43572, 43992);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 43656, 43751);

                                        symbols[k] = f_10061_43669_43750(bindingResult, boundReference, ref unifiedAssemblies);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 43572, 43992);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 43572, 43992);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 43865, 43965);

                                        symbols[k] = f_10061_43878_43964(boundReference.ReferenceIdentity, ref missingAssemblies);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 43572, 43992);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 44020, 44069);

                                    identities[k] = boundReference.ReferenceIdentity;
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 870);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 870);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 44116, 44347);

                            var
                            references = f_10061_44133_44346(f_10061_44196_44226(identities), f_10061_44253_44280(symbols), f_10061_44307_44345(unifiedAssemblies))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 44371, 44504) || true) && (moduleIndex > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 44371, 44504);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 44440, 44481);

                                f_10061_44440_44480(moduleReferencesBuilder!, references);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 44371, 44504);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 44528, 44597);

                            f_10061_44528_44596(
                                                moduleSymbols[moduleIndex], references, sourceAssembly);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 44621, 44643);

                            refsUsed += refsCount;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 1937);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 1937);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 44682, 44753);

                    moduleReferences = f_10061_44701_44752(moduleReferencesBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10061, 41930, 44768);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10061_42426_42448(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 42426, 42448);
                        return return_v;
                    }


                    int
                    f_10061_42467_42523(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 42467, 42523);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    f_10061_42603_42663()
                    {
                        var return_v = ArrayBuilder<ModuleReferences<AssemblySymbol>>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 42603, 42663);
                        return return_v;
                    }


                    int
                    f_10061_43307_43364(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 43307, 43364);
                        return 0;
                    }


                    int
                    f_10061_43487_43543(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 43487, 43543);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10061_43669_43750(Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.BoundInputAssembly[]
                    bindingResult, Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyReferenceBinding
                    referenceBinding, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>?
                    unifiedAssemblies)
                    {
                        var return_v = GetAssemblyDefinitionSymbol(bindingResult, referenceBinding, ref unifiedAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 43669, 43750);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol
                    f_10061_43878_43964(Microsoft.CodeAnalysis.AssemblyIdentity
                    assemblyIdentity, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>?
                    missingAssemblies)
                    {
                        var return_v = GetOrAddMissingAssemblySymbol(assemblyIdentity, ref missingAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 43878, 43964);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                    f_10061_44196_44226(Microsoft.CodeAnalysis.AssemblyIdentity[]
                    items)
                    {
                        var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.AssemblyIdentity>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 44196, 44226);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_44253_44280(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol[]
                    items)
                    {
                        var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 44253, 44280);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    f_10061_44307_44345(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>?
                    items)
                    {
                        var return_v = items.AsImmutableOrEmpty<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 44307, 44345);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_44133_44346(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                    identities, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    unifiedAssemblies)
                    {
                        var return_v = new Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>(identities, symbols, unifiedAssemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 44133, 44346);
                        return return_v;
                    }


                    int
                    f_10061_44440_44480(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    this_param, Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 44440, 44480);
                        return 0;
                    }


                    int
                    f_10061_44528_44596(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param, Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    moduleReferences, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    originatingSourceAssemblyDebugOnly)
                    {
                        this_param.SetReferences(moduleReferences, originatingSourceAssemblyDebugOnly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 44528, 44596);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    f_10061_44701_44752(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>?
                    builder)
                    {
                        var return_v = builder.ToImmutableOrEmptyAndFree<Microsoft.CodeAnalysis.ModuleReferences<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 44701, 44752);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 41930, 44768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 41930, 44768);
                }
            }

            private static AssemblySymbol GetAssemblyDefinitionSymbol(
                            BoundInputAssembly[] bindingResult,
                            AssemblyReferenceBinding referenceBinding,
                            ref ArrayBuilder<UnifiedAssembly<AssemblySymbol>>? unifiedAssemblies)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10061, 44784, 45816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 45075, 45114);

                    f_10061_45075_45113(referenceBinding.IsBound);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 45132, 45191);

                    f_10061_45132_45190(referenceBinding.ReferenceIdentity is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 45209, 45287);

                    var
                    assembly = bindingResult[referenceBinding.DefinitionIndex].AssemblySymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 45305, 45338);

                    f_10061_45305_45337(assembly is object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 45358, 45765) || true) && (referenceBinding.VersionDifference != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 45358, 45765);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 45443, 45617) || true) && (unifiedAssemblies == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 45443, 45617);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 45522, 45594);

                            unifiedAssemblies = f_10061_45542_45593();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 45443, 45617);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 45641, 45746);

                        f_10061_45641_45745(
                                            unifiedAssemblies, f_10061_45663_45744(assembly, referenceBinding.ReferenceIdentity));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 45358, 45765);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 45785, 45801);

                    return assembly;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10061, 44784, 45816);

                    int
                    f_10061_45075_45113(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 45075, 45113);
                        return 0;
                    }


                    int
                    f_10061_45132_45190(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 45132, 45190);
                        return 0;
                    }


                    int
                    f_10061_45305_45337(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 45305, 45337);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    f_10061_45542_45593()
                    {
                        var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 45542, 45593);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10061_45663_45744(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    targetAssembly, Microsoft.CodeAnalysis.AssemblyIdentity
                    originalReference)
                    {
                        var return_v = new Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>(targetAssembly, originalReference);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 45663, 45744);
                        return return_v;
                    }


                    int
                    f_10061_45641_45745(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    this_param, Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 45641, 45745);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 44784, 45816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 44784, 45816);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static MissingAssemblySymbol GetOrAddMissingAssemblySymbol(
                            AssemblyIdentity assemblyIdentity,
                            ref Dictionary<AssemblyIdentity, MissingAssemblySymbol>? missingAssemblies)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10061, 45832, 46698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 46077, 46116);

                    MissingAssemblySymbol?
                    missingAssembly
                    = default(MissingAssemblySymbol?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 46136, 46483) || true) && (missingAssemblies == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 46136, 46483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 46207, 46285);

                        missingAssemblies = f_10061_46227_46284();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 46136, 46483);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 46136, 46483);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 46327, 46483) || true) && (f_10061_46331_46399(missingAssemblies, assemblyIdentity, out missingAssembly))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 46327, 46483);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 46441, 46464);

                            return missingAssembly;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 46327, 46483);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 46136, 46483);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 46503, 46565);

                    missingAssembly = f_10061_46521_46564(assemblyIdentity);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 46583, 46640);

                    f_10061_46583_46639(missingAssemblies, assemblyIdentity, missingAssembly);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 46660, 46683);

                    return missingAssembly;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10061, 45832, 46698);

                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>
                    f_10061_46227_46284()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 46227, 46284);
                        return return_v;
                    }


                    bool
                    f_10061_46331_46399(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>
                    this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 46331, 46399);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol
                    f_10061_46521_46564(Microsoft.CodeAnalysis.AssemblyIdentity
                    identity)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol(identity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 46521, 46564);
                        return return_v;
                    }


                    int
                    f_10061_46583_46639(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol>
                    this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 46583, 46639);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 45832, 46698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 45832, 46698);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private abstract class AssemblyDataForMetadataOrCompilation : AssemblyData
            {
                private List<AssemblySymbol>? _assemblies;

                private readonly AssemblyIdentity _identity;

                private readonly ImmutableArray<AssemblyIdentity> _referencedAssemblies;

                private readonly bool _embedInteropTypes;

                protected AssemblyDataForMetadataOrCompilation(
                                    AssemblyIdentity identity,
                                    ImmutableArray<AssemblyIdentity> referencedAssemblies,
                                    bool embedInteropTypes)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10061, 47094, 47648);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 46851, 46862);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 46915, 46924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 47055, 47073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 47351, 47388);

                        f_10061_47351_47387(identity != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 47410, 47456);

                        f_10061_47410_47455(f_10061_47423_47454_M(!referencedAssemblies.IsDefault));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 47480, 47519);

                        _embedInteropTypes = embedInteropTypes;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 47541, 47562);

                        _identity = identity;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 47584, 47629);

                        _referencedAssemblies = referencedAssemblies;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10061, 47094, 47648);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 47094, 47648);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 47094, 47648);
                    }
                }

                internal abstract AssemblySymbol CreateAssemblySymbol();

                public override AssemblyIdentity Identity
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 47826, 47918);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 47878, 47895);

                            return _identity;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 47826, 47918);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 47744, 47937);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 47744, 47937);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override IEnumerable<AssemblySymbol> AvailableSymbols
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 48058, 48655);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 48110, 48585) || true) && (_assemblies == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 48110, 48585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 48191, 48232);

                                _assemblies = f_10061_48205_48231();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 48525, 48558);

                                f_10061_48525_48557(this, _assemblies);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 48110, 48585);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 48613, 48632);

                            return _assemblies;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 48058, 48655);

                            System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                            f_10061_48205_48231()
                            {
                                var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 48205, 48231);
                                return return_v;
                            }


                            int
                            f_10061_48525_48557(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager.AssemblyDataForMetadataOrCompilation
                            this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                            assemblies)
                            {
                                this_param.AddAvailableSymbols(assemblies);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 48525, 48557);
                                return 0;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 47957, 48674);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 47957, 48674);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                protected abstract void AddAvailableSymbols(List<AssemblySymbol> assemblies);

                public override ImmutableArray<AssemblyIdentity> AssemblyReferences
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 48899, 49003);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 48951, 48980);

                            return _referencedAssemblies;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 48899, 49003);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 48791, 49022);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 48791, 49022);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override AssemblyReferenceBinding[] BindAssemblyReferences(
                                    ImmutableArray<AssemblyData> assemblies, AssemblyIdentityComparer assemblyIdentityComparer)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 49042, 49428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 49262, 49409);

                        return f_10061_49269_49408(_referencedAssemblies, assemblies, definitionStartIndex: 0, assemblyIdentityComparer: assemblyIdentityComparer);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 49042, 49428);

                        Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyReferenceBinding[]
                        f_10061_49269_49408(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                        references, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>.AssemblyData>
                        definitions, int
                        definitionStartIndex, Microsoft.CodeAnalysis.AssemblyIdentityComparer
                        assemblyIdentityComparer)
                        {
                            var return_v = ResolveReferencedAssemblies(references, definitions, definitionStartIndex: definitionStartIndex, assemblyIdentityComparer: assemblyIdentityComparer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 49269, 49408);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 49042, 49428);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 49042, 49428);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public sealed override bool IsLinked
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 49525, 49626);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 49577, 49603);

                            return _embedInteropTypes;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 49525, 49626);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 49448, 49645);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 49448, 49645);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static AssemblyDataForMetadataOrCompilation()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10061, 46714, 49660);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10061, 46714, 49660);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 46714, 49660);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10061, 46714, 49660);

                int
                f_10061_47351_47387(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 47351, 47387);
                    return 0;
                }


                bool
                f_10061_47423_47454_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 47423, 47454);
                    return return_v;
                }


                int
                f_10061_47410_47455(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 47410, 47455);
                    return 0;
                }

            }
            
            private sealed class AssemblyDataForFile : AssemblyDataForMetadataOrCompilation
            {
                public readonly PEAssembly Assembly;

                public readonly WeakList<IAssemblySymbolInternal> CachedSymbols;

                public readonly DocumentationProvider DocumentationProvider;

                private readonly MetadataImportOptions _compilationImportOptions;

                private readonly string _sourceAssemblySimpleName;

                private bool _internalsVisibleComputed;

                private bool _internalsPotentiallyVisibleToCompilation;

                public AssemblyDataForFile(
                                    PEAssembly assembly,
                                    WeakList<IAssemblySymbolInternal> cachedSymbols,
                                    bool embedInteropTypes,
                                    DocumentationProvider documentationProvider,
                                    string sourceAssemblySimpleName,
                                    MetadataImportOptions compilationImportOptions)
                : base(f_10061_51307_51324_C(f_10061_51307_51324(assembly)), assembly.AssemblyReferences, embedInteropTypes)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10061, 50905, 51861);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 49815, 49823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 50068, 50081);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 50140, 50161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 50352, 50377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 50727, 50752);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 50786, 50811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 50843, 50884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 51414, 51464);

                        f_10061_51414_51463(documentationProvider != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 51486, 51528);

                        f_10061_51486_51527(cachedSymbols != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 51552, 51582);

                        CachedSymbols = cachedSymbols;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 51604, 51624);

                        Assembly = assembly;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 51646, 51692);

                        DocumentationProvider = documentationProvider;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 51714, 51767);

                        _compilationImportOptions = compilationImportOptions;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 51789, 51842);

                        _sourceAssemblySimpleName = sourceAssemblySimpleName;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10061, 50905, 51861);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 50905, 51861);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 50905, 51861);
                    }
                }

                internal override AssemblySymbol CreateAssemblySymbol()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 51881, 52101);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 51977, 52082);

                        return f_10061_51984_52081(Assembly, DocumentationProvider, f_10061_52038_52051(this), f_10061_52053_52080(this));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 51881, 52101);

                        bool
                        f_10061_52038_52051(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager.AssemblyDataForFile
                        this_param)
                        {
                            var return_v = this_param.IsLinked;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 52038, 52051);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MetadataImportOptions
                        f_10061_52053_52080(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager.AssemblyDataForFile
                        this_param)
                        {
                            var return_v = this_param.EffectiveImportOptions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 52053, 52080);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                        f_10061_51984_52081(Microsoft.CodeAnalysis.PEAssembly
                        assembly, Microsoft.CodeAnalysis.DocumentationProvider
                        documentationProvider, bool
                        isLinked, Microsoft.CodeAnalysis.MetadataImportOptions
                        importOptions)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol(assembly, documentationProvider, isLinked, importOptions);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 51984, 52081);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 51881, 52101);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 51881, 52101);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                internal bool InternalsMayBeVisibleToCompilation
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 52210, 52666);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 52262, 52566) || true) && (!_internalsVisibleComputed)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 52262, 52566);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 52350, 52476);

                                _internalsPotentiallyVisibleToCompilation = f_10061_52394_52475(_sourceAssemblySimpleName, Assembly);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 52506, 52539);

                                _internalsVisibleComputed = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 52262, 52566);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 52594, 52643);

                            return _internalsPotentiallyVisibleToCompilation;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 52210, 52666);

                            bool
                            f_10061_52394_52475(string
                            compilationName, Microsoft.CodeAnalysis.PEAssembly
                            assembly)
                            {
                                var return_v = InternalsMayBeVisibleToAssemblyBeingCompiled(compilationName, assembly);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 52394, 52475);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 52121, 52685);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 52121, 52685);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                internal MetadataImportOptions EffectiveImportOptions
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 52799, 53280);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 52974, 53196) || true) && (f_10061_52978_53012() && (DynAbs.Tracing.TraceSender.Expression_True(10061, 52978, 53073) && _compilationImportOptions == MetadataImportOptions.Public))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 52974, 53196);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 53131, 53169);

                                return MetadataImportOptions.Internal;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 52974, 53196);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 53224, 53257);

                            return _compilationImportOptions;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 52799, 53280);

                            bool
                            f_10061_52978_53012()
                            {
                                var return_v = InternalsMayBeVisibleToCompilation;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 52978, 53012);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 52705, 53299);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 52705, 53299);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                protected override void AddAvailableSymbols(List<AssemblySymbol> assemblies)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 53319, 53997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 53507, 53547);
                        // accessing cached symbols requires a lock
                        lock (SymbolCacheAndReferenceManagerStateGuard)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 53597, 53955);
                                foreach (var assembly in f_10061_53622_53635_I(CachedSymbols))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 53597, 53955);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 53693, 53739);

                                    var
                                    peAssembly = assembly as PEAssemblySymbol
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 53769, 53928) || true) && (f_10061_53773_53803(this, peAssembly))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 53769, 53928);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 53869, 53897);

                                        f_10061_53869_53896(assemblies, peAssembly!);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 53769, 53928);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 53597, 53955);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 359);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 359);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 53319, 53997);

                        bool
                        f_10061_53773_53803(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager.AssemblyDataForFile
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol?
                        peAssembly)
                        {
                            var return_v = this_param.IsMatchingAssembly(peAssembly);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 53773, 53803);
                            return return_v;
                        }


                        int
                        f_10061_53869_53896(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                        item)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 53869, 53896);
                            return 0;
                        }


                        Roslyn.Utilities.WeakList<Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>
                        f_10061_53622_53635_I(Roslyn.Utilities.WeakList<Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 53622, 53635);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 53319, 53997);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 53319, 53997);
                    }
                }

                public override bool IsMatchingAssembly(AssemblySymbol? candidateAssembly)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 54017, 54216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 54132, 54197);

                        return f_10061_54139_54196(this, candidateAssembly as PEAssemblySymbol);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 54017, 54216);

                        bool
                        f_10061_54139_54196(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager.AssemblyDataForFile
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                        peAssembly)
                        {
                            var return_v = this_param.IsMatchingAssembly((Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol?)peAssembly);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 54139, 54196);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 54017, 54216);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 54017, 54216);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                private bool IsMatchingAssembly(PEAssemblySymbol? peAssembly)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 54236, 55364);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 54338, 54446) || true) && (peAssembly is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 54338, 54446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 54410, 54423);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 54338, 54446);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 54470, 54607) || true) && (!f_10061_54475_54521(f_10061_54491_54510(peAssembly), Assembly))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 54470, 54607);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 54571, 54584);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 54470, 54607);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 54631, 54785) || true) && (f_10061_54635_54657() != f_10061_54661_54685(peAssembly).ImportOptions)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 54631, 54785);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 54749, 54762);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 54631, 54785);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 55156, 55309) || true) && (!f_10061_55161_55223(f_10061_55161_55193(peAssembly), DocumentationProvider))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 55156, 55309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 55273, 55286);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 55156, 55309);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 55333, 55345);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 54236, 55364);

                        Microsoft.CodeAnalysis.PEAssembly
                        f_10061_54491_54510(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                        this_param)
                        {
                            var return_v = this_param.Assembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 54491, 54510);
                            return return_v;
                        }


                        bool
                        f_10061_54475_54521(Microsoft.CodeAnalysis.PEAssembly
                        objA, Microsoft.CodeAnalysis.PEAssembly
                        objB)
                        {
                            var return_v = ReferenceEquals((object)objA, (object)objB);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 54475, 54521);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MetadataImportOptions
                        f_10061_54635_54657()
                        {
                            var return_v = EffectiveImportOptions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 54635, 54657);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                        f_10061_54661_54685(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                        this_param)
                        {
                            var return_v = this_param.PrimaryModule;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 54661, 54685);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DocumentationProvider
                        f_10061_55161_55193(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                        this_param)
                        {
                            var return_v = this_param.DocumentationProvider;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 55161, 55193);
                            return return_v;
                        }


                        bool
                        f_10061_55161_55223(Microsoft.CodeAnalysis.DocumentationProvider
                        this_param, Microsoft.CodeAnalysis.DocumentationProvider
                        obj)
                        {
                            var return_v = this_param.Equals((object)obj);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 55161, 55223);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 54236, 55364);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 54236, 55364);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override bool ContainsNoPiaLocalTypes
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 55469, 55586);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 55521, 55563);

                            return f_10061_55528_55562(Assembly);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 55469, 55586);

                            bool
                            f_10061_55528_55562(Microsoft.CodeAnalysis.PEAssembly
                            this_param)
                            {
                                var return_v = this_param.ContainsNoPiaLocalTypes();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 55528, 55562);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 55384, 55605);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 55384, 55605);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override bool DeclaresTheObjectClass
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 55709, 55823);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 55761, 55800);

                            return f_10061_55768_55799(Assembly);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 55709, 55823);

                            bool
                            f_10061_55768_55799(Microsoft.CodeAnalysis.PEAssembly
                            this_param)
                            {
                                var return_v = this_param.DeclaresTheObjectClass;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 55768, 55799);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 55625, 55842);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 55625, 55842);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override Compilation? SourceCompilation
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 55909, 55916);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 55912, 55916);
                            return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 55909, 55916);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 55909, 55916);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 55909, 55916);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static AssemblyDataForFile()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10061, 49676, 55932);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10061, 49676, 55932);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 49676, 55932);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10061, 49676, 55932);

                static Microsoft.CodeAnalysis.AssemblyIdentity
                f_10061_51307_51324(Microsoft.CodeAnalysis.PEAssembly
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 51307, 51324);
                    return return_v;
                }


                int
                f_10061_51414_51463(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 51414, 51463);
                    return 0;
                }


                int
                f_10061_51486_51527(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 51486, 51527);
                    return 0;
                }


                static Microsoft.CodeAnalysis.AssemblyIdentity
                f_10061_51307_51324_C(Microsoft.CodeAnalysis.AssemblyIdentity
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceBaseCall(10061, 50905, 51861);
                    return return_v;
                }

            }

            private sealed class AssemblyDataForCompilation : AssemblyDataForMetadataOrCompilation
            {
                public readonly CSharpCompilation Compilation;

                public AssemblyDataForCompilation(CSharpCompilation compilation, bool embedInteropTypes)
                : base(f_10061_56250_56279_C(f_10061_56250_56279(f_10061_56250_56270(compilation))), f_10061_56281_56317(compilation), embedInteropTypes)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10061, 56133, 56423);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 56101, 56112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 56378, 56404);

                        Compilation = compilation;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10061, 56133, 56423);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 56133, 56423);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 56133, 56423);
                    }
                }

                private static ImmutableArray<AssemblyIdentity> GetReferencedAssemblies(CSharpCompilation compilation)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10061, 56443, 57766);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 56647, 56705);

                        var
                        result = f_10061_56660_56704()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 56729, 56772);

                        var
                        modules = f_10061_56743_56771(f_10061_56743_56763(compilation))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 56882, 56952);

                        var
                        sourceReferencedAssemblies = f_10061_56915_56951(modules[0])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 56974, 57054);

                        var
                        sourceReferencedAssemblySymbols = f_10061_57012_57053(modules[0])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 57078, 57168);

                        f_10061_57078_57167(sourceReferencedAssemblies.Length == sourceReferencedAssemblySymbols.Length);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 57201, 57206);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 57192, 57498) || true) && (i < sourceReferencedAssemblies.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 57247, 57250)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 57192, 57498))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 57192, 57498);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 57300, 57475) || true) && (f_10061_57304_57348_M(!sourceReferencedAssemblySymbols[i].IsLinked))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 57300, 57475);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 57406, 57448);

                                    f_10061_57406_57447(result, sourceReferencedAssemblies[i]);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 57300, 57475);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 307);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 307);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 57531, 57536);

                            for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 57522, 57688) || true) && (i < modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 57558, 57561)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 57522, 57688))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 57522, 57688);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 57611, 57665);

                                f_10061_57611_57664(result, f_10061_57627_57663(modules[i]));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10061, 1, 167);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10061, 1, 167);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 57712, 57747);

                        return f_10061_57719_57746(result);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10061, 56443, 57766);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
                        f_10061_56660_56704()
                        {
                            var return_v = ArrayBuilder<AssemblyIdentity>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 56660, 56704);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10061_56743_56763(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.Assembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 56743, 56763);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                        f_10061_56743_56771(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        this_param)
                        {
                            var return_v = this_param.Modules;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 56743, 56771);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                        f_10061_56915_56951(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.GetReferencedAssemblies();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 56915, 56951);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                        f_10061_57012_57053(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.GetReferencedAssemblySymbols();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 57012, 57053);
                            return return_v;
                        }


                        int
                        f_10061_57078_57167(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 57078, 57167);
                            return 0;
                        }


                        bool
                        f_10061_57304_57348_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 57304, 57348);
                            return return_v;
                        }


                        int
                        f_10061_57406_57447(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
                        this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 57406, 57447);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                        f_10061_57627_57663(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.GetReferencedAssemblies();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 57627, 57663);
                            return return_v;
                        }


                        int
                        f_10061_57611_57664(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                        items)
                        {
                            this_param.AddRange(items);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 57611, 57664);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                        f_10061_57719_57746(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
                        this_param)
                        {
                            var return_v = this_param.ToImmutableAndFree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 57719, 57746);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 56443, 57766);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 56443, 57766);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                internal override AssemblySymbol CreateAssemblySymbol()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 57786, 57981);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 57882, 57962);

                        return f_10061_57889_57961(f_10061_57919_57945(Compilation), f_10061_57947_57960(this));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 57786, 57981);

                        Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                        f_10061_57919_57945(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.SourceAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 57919, 57945);
                            return return_v;
                        }


                        bool
                        f_10061_57947_57960(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager.AssemblyDataForCompilation
                        this_param)
                        {
                            var return_v = this_param.IsLinked;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 57947, 57960);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                        f_10061_57889_57961(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                        underlyingAssembly, bool
                        isLinked)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol(underlyingAssembly, isLinked);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 57889, 57961);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 57786, 57981);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 57786, 57981);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                protected override void AddAvailableSymbols(List<AssemblySymbol> assemblies)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 58001, 58442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 58118, 58155);

                        f_10061_58118_58154(assemblies, f_10061_58133_58153(Compilation));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 58250, 58290);

                        // accessing cached symbols requires a lock
                        lock (SymbolCacheAndReferenceManagerStateGuard)
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 58340, 58400);

                            f_10061_58340_58399(Compilation, assemblies);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 58001, 58442);

                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10061_58133_58153(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.Assembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 58133, 58153);
                            return return_v;
                        }


                        int
                        f_10061_58118_58154(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 58118, 58154);
                            return 0;
                        }


                        int
                        f_10061_58340_58399(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                        result)
                        {
                            this_param.AddRetargetingAssemblySymbolsNoLock<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>(result);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 58340, 58399);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 58001, 58442);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 58001, 58442);
                    }
                }

                public override bool IsMatchingAssembly(AssemblySymbol? candidateAssembly)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 58462, 59156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 58577, 58642);

                        var
                        retargeting = candidateAssembly as RetargetingAssemblySymbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 58664, 58684);

                        AssemblySymbol?
                        asm
                        = default(AssemblySymbol?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 58708, 58989) || true) && (retargeting is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 58708, 58989);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 58783, 58820);

                            asm = f_10061_58789_58819(retargeting);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 58708, 58989);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10061, 58708, 58989);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 58918, 58966);

                            asm = candidateAssembly as SourceAssemblySymbol;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10061, 58708, 58989);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 59013, 59063);

                        f_10061_59013_59062(!(asm is RetargetingAssemblySymbol));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 59087, 59137);

                        return f_10061_59094_59136(asm, f_10061_59115_59135(Compilation));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 58462, 59156);

                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10061_58789_58819(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                        this_param)
                        {
                            var return_v = this_param.UnderlyingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 58789, 58819);
                            return return_v;
                        }


                        int
                        f_10061_59013_59062(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 59013, 59062);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10061_59115_59135(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.Assembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 59115, 59135);
                            return return_v;
                        }


                        bool
                        f_10061_59094_59136(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                        objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        objB)
                        {
                            var return_v = ReferenceEquals((object?)objA, (object)objB);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 59094, 59136);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 58462, 59156);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 58462, 59156);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override bool ContainsNoPiaLocalTypes
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 59261, 59385);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 59313, 59362);

                            return f_10061_59320_59361(Compilation);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 59261, 59385);

                            bool
                            f_10061_59320_59361(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                            this_param)
                            {
                                var return_v = this_param.MightContainNoPiaLocalTypes();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 59320, 59361);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 59176, 59404);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 59176, 59404);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override bool DeclaresTheObjectClass
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 59508, 59625);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 59560, 59602);

                            return f_10061_59567_59601(Compilation);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 59508, 59625);

                            bool
                            f_10061_59567_59601(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                            this_param)
                            {
                                var return_v = this_param.DeclaresTheObjectClass;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 59567, 59601);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 59424, 59644);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 59424, 59644);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override Compilation SourceCompilation
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10061, 59710, 59724);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 59713, 59724);
                            return Compilation; DynAbs.Tracing.TraceSender.TraceExitMethod(10061, 59710, 59724);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 59710, 59724);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 59710, 59724);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static AssemblyDataForCompilation()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10061, 55948, 59740);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10061, 55948, 59740);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 55948, 59740);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10061, 55948, 59740);

                static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10061_56250_56270(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 56250, 56270);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.AssemblyIdentity
                f_10061_56250_56279(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 56250, 56279);
                    return return_v;
                }


                static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_10061_56281_56317(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = GetReferencedAssemblies(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10061, 56281, 56317);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.AssemblyIdentity
                f_10061_56250_56279_C(Microsoft.CodeAnalysis.AssemblyIdentity
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceBaseCall(10061, 56133, 56423);
                    return return_v;
                }

            }

            internal static bool IsSourceAssemblySymbolCreated(CSharpCompilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10061, 59855, 60033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 59969, 60018);

                    return compilation._lazyAssemblySymbol is object;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10061, 59855, 60033);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 59855, 60033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 59855, 60033);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static bool IsReferenceManagerInitialized(CSharpCompilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10061, 60148, 60322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10061, 60262, 60307);

                    return f_10061_60269_60306(compilation._referenceManager);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10061, 60148, 60322);

                    bool
                    f_10061_60269_60306(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                    this_param)
                    {
                        var return_v = this_param.IsBound;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10061, 60269, 60306);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10061, 60148, 60322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 60148, 60322);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ReferenceManager()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10061, 3349, 60333);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10061, 3349, 60333);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10061, 3349, 60333);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10061, 3349, 60333);

            static string
            f_10061_3661_3679_C(string
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10061, 3472, 3746);
                return return_v;
            }
        }
    }
}
