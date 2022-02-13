// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Roslyn.Test.Utilities.PDB;
using Roslyn.Utilities;
using TestResources.NetFX;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.PDB
{
    public class CSharpDeterministicBuildCompilationTests : CSharpTestBase, IEnumerable<object[]>
    {
        private static void VerifyCompilationOptions(
                    CSharpCompilationOptions originalOptions,
                    Compilation compilation,
                    EmitOptions emitOptions,
                    BlobReader compilationOptionsBlobReader,
                    string langVersion,
                    int sourceFileCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23125, 944, 2290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 1266, 1378);

                var
                pdbOptions = f_23125_1283_1377(compilationOptionsBlobReader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 1394, 1510);

                f_23125_1394_1509(emitOptions, originalOptions, compilation, pdbOptions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 1613, 1692);

                f_23125_1613_1691(
                            // See CSharpCompilation.SerializeForPdb to see options that are included
                            pdbOptions, "nullable", f_23125_1652_1690(originalOptions));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 1706, 1775);

                f_23125_1706_1774(pdbOptions, "checked", f_23125_1744_1773(originalOptions));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 1789, 1855);

                f_23125_1789_1854(pdbOptions, "unsafe", f_23125_1826_1853(originalOptions));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 1871, 1929);

                f_23125_1871_1928(langVersion, f_23125_1897_1927(pdbOptions, "language-version"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 1943, 2017);

                f_23125_1943_2016(f_23125_1956_1982(sourceFileCount), f_23125_1984_2015(pdbOptions, "source-file-count"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 2033, 2114);

                var
                firstSyntaxTree = (CSharpSyntaxTree)f_23125_2073_2113(f_23125_2073_2096(compilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 2128, 2279);

                f_23125_2128_2278(pdbOptions, "define", f_23125_2165_2212(f_23125_2165_2188(firstSyntaxTree)), isDefault: v => v.IsEmpty(), toString: v => string.Join(",", v));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23125, 944, 2290);

                static System.Collections.Immutable.ImmutableDictionary<string, string>
                f_23125_1283_1377(System.Reflection.Metadata.BlobReader
                blobReader)
                {
                    var return_v = DeterministicBuildCompilationTestHelpers.ParseCompilationOptions(blobReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 1283, 1377);
                    return return_v;
                }


                static int
                f_23125_1394_1509(Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions, Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Immutable.ImmutableDictionary<string, string>
                pdbOptions)
                {
                    DeterministicBuildCompilationTestHelpers.AssertCommonOptions(emitOptions, (Microsoft.CodeAnalysis.CompilationOptions)compilationOptions, compilation, pdbOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 1394, 1509);
                    return 0;
                }


                static Microsoft.CodeAnalysis.NullableContextOptions
                f_23125_1652_1690(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 1652, 1690);
                    return return_v;
                }


                static int
                f_23125_1613_1691(System.Collections.Immutable.ImmutableDictionary<string, string>
                pdbOptions, string
                pdbName, Microsoft.CodeAnalysis.NullableContextOptions
                expectedValue)
                {
                    pdbOptions.VerifyPdbOption<Microsoft.CodeAnalysis.NullableContextOptions>(pdbName, expectedValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 1613, 1691);
                    return 0;
                }


                static bool
                f_23125_1744_1773(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CheckOverflow;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 1744, 1773);
                    return return_v;
                }


                static int
                f_23125_1706_1774(System.Collections.Immutable.ImmutableDictionary<string, string>
                pdbOptions, string
                pdbName, bool
                expectedValue)
                {
                    pdbOptions.VerifyPdbOption<bool>(pdbName, expectedValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 1706, 1774);
                    return 0;
                }


                static bool
                f_23125_1826_1853(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.AllowUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 1826, 1853);
                    return return_v;
                }


                static int
                f_23125_1789_1854(System.Collections.Immutable.ImmutableDictionary<string, string>
                pdbOptions, string
                pdbName, bool
                expectedValue)
                {
                    pdbOptions.VerifyPdbOption<bool>(pdbName, expectedValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 1789, 1854);
                    return 0;
                }


                static string
                f_23125_1897_1927(System.Collections.Immutable.ImmutableDictionary<string, string>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 1897, 1927);
                    return return_v;
                }


                static int
                f_23125_1871_1928(string
                expected, string
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 1871, 1928);
                    return 0;
                }


                static string
                f_23125_1956_1982(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 1956, 1982);
                    return return_v;
                }


                static string
                f_23125_1984_2015(System.Collections.Immutable.ImmutableDictionary<string, string>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 1984, 2015);
                    return return_v;
                }


                static int
                f_23125_1943_2016(string
                expected, string
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 1943, 2016);
                    return 0;
                }


                static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_23125_2073_2096(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 2073, 2096);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.SyntaxTree
                f_23125_2073_2113(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                source)
                {
                    var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.SyntaxTree>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 2073, 2113);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_23125_2165_2188(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 2165, 2188);
                    return return_v;
                }


                static System.Collections.Generic.IEnumerable<string>
                f_23125_2165_2212(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.PreprocessorSymbolNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 2165, 2212);
                    return return_v;
                }


                static int
                f_23125_2128_2278(System.Collections.Immutable.ImmutableDictionary<string, string>
                pdbOptions, string
                pdbName, System.Collections.Generic.IEnumerable<string>
                expectedValue, System.Func<System.Collections.Generic.IEnumerable<string>, bool>
                isDefault, System.Func<System.Collections.Generic.IEnumerable<string>, string>
                toString)
                {
                    pdbOptions.VerifyPdbOption<System.Collections.Generic.IEnumerable<string>>(pdbName, expectedValue, isDefault: isDefault, toString: toString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 2128, 2278);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23125, 944, 2290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23125, 944, 2290);
            }
        }

        private static void TestDeterministicCompilationCSharp(
                    string langVersion,
                    SyntaxTree[] syntaxTrees,
                    CSharpCompilationOptions compilationOptions,
                    EmitOptions emitOptions,
                    TestMetadataReferenceInfo[] metadataReferences,
                    int? debugDocumentsCount = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23125, 2302, 4688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 2657, 3076);

                var
                originalCompilation = f_23125_2683_3075(syntaxTrees, references: f_23125_2761_2819(metadataReferences, r => r.MetadataReference), options: compilationOptions, targetFramework: TargetFramework.NetCoreApp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 3092, 3159);

                var
                peBlob = f_23125_3105_3158(originalCompilation, options: emitOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 3175, 4677);
                using (var
                peReader = f_23125_3197_3217(peBlob)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 3251, 3295);

                    var
                    entries = f_23125_3265_3294(peReader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 3315, 3523);

                    f_23125_3315_3522(new[] { DebugDirectoryEntryType.CodeView, DebugDirectoryEntryType.PdbChecksum, DebugDirectoryEntryType.Reproducible, DebugDirectoryEntryType.EmbeddedPortablePdb }, entries.Select(e => e.Type));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 3543, 3569);

                    var
                    codeView = entries[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 3587, 3613);

                    var
                    checksum = entries[1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 3631, 3661);

                    var
                    reproducible = entries[2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 3679, 3705);

                    var
                    embedded = entries[3]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 3725, 4662);
                    using (var
                    embeddedPdb = f_23125_3750_3810(peReader, embedded)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 3852, 3900);

                        var
                        pdbReader = f_23125_3868_3899(embeddedPdb)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 3922, 4078);

                        var
                        metadataReferenceReader = f_23125_3952_4077(PortableCustomDebugInfoKinds.CompilationMetadataReferences, pdbReader)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 4100, 4246);

                        var
                        compilationOptionsReader = f_23125_4131_4245(PortableCustomDebugInfoKinds.CompilationOptions, pdbReader)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 4270, 4353);

                        f_23125_4270_4352(debugDocumentsCount ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(23125, 4283, 4324) ?? f_23125_4306_4324(syntaxTrees)), pdbReader.Documents.Count);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 4377, 4515);

                        f_23125_4377_4514(compilationOptions, originalCompilation, emitOptions, compilationOptionsReader, langVersion, f_23125_4495_4513(syntaxTrees));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 4537, 4643);

                        f_23125_4537_4642(metadataReferences, metadataReferenceReader);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(23125, 3725, 4662);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(23125, 3175, 4677);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23125, 2302, 4688);

                static System.Collections.Immutable.ImmutableArray<Roslyn.Test.Utilities.TestMetadataReference>
                f_23125_2761_2819(Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo[]
                source, System.Func<Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo, Roslyn.Test.Utilities.TestMetadataReference>
                selector)
                {
                    var return_v = source.SelectAsArray<Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo, Roslyn.Test.Utilities.TestMetadataReference>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 2761, 2819);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23125_2683_3075(Microsoft.CodeAnalysis.SyntaxTree[]
                source, System.Collections.Immutable.ImmutableArray<Roslyn.Test.Utilities.TestMetadataReference>
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Roslyn.Test.Utilities.TargetFramework
                targetFramework)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options, targetFramework: targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 2683, 3075);
                    return return_v;
                }


                static System.Collections.Immutable.ImmutableArray<byte>
                f_23125_3105_3158(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitOptions
                options)
                {
                    var return_v = compilation.EmitToArray(options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 3105, 3158);
                    return return_v;
                }


                static System.Reflection.PortableExecutable.PEReader
                f_23125_3197_3217(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 3197, 3217);
                    return return_v;
                }


                static System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.DebugDirectoryEntry>
                f_23125_3265_3294(System.Reflection.PortableExecutable.PEReader
                this_param)
                {
                    var return_v = this_param.ReadDebugDirectory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 3265, 3294);
                    return return_v;
                }


                static int
                f_23125_3315_3522(System.Reflection.PortableExecutable.DebugDirectoryEntryType[]
                expected, System.Collections.Generic.IEnumerable<System.Reflection.PortableExecutable.DebugDirectoryEntryType>
                actual)
                {
                    AssertEx.Equal((System.Collections.Generic.IEnumerable<System.Reflection.PortableExecutable.DebugDirectoryEntryType>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 3315, 3522);
                    return 0;
                }


                static System.Reflection.Metadata.MetadataReaderProvider
                f_23125_3750_3810(System.Reflection.PortableExecutable.PEReader
                this_param, System.Reflection.PortableExecutable.DebugDirectoryEntry
                entry)
                {
                    var return_v = this_param.ReadEmbeddedPortablePdbDebugDirectoryData(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 3750, 3810);
                    return return_v;
                }


                static System.Reflection.Metadata.MetadataReader
                f_23125_3868_3899(System.Reflection.Metadata.MetadataReaderProvider
                this_param)
                {
                    var return_v = this_param.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 3868, 3899);
                    return return_v;
                }


                static System.Reflection.Metadata.BlobReader
                f_23125_3952_4077(System.Guid
                infoGuid, System.Reflection.Metadata.MetadataReader
                pdbReader)
                {
                    var return_v = DeterministicBuildCompilationTestHelpers.GetSingleBlob(infoGuid, pdbReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 3952, 4077);
                    return return_v;
                }


                static System.Reflection.Metadata.BlobReader
                f_23125_4131_4245(System.Guid
                infoGuid, System.Reflection.Metadata.MetadataReader
                pdbReader)
                {
                    var return_v = DeterministicBuildCompilationTestHelpers.GetSingleBlob(infoGuid, pdbReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 4131, 4245);
                    return return_v;
                }


                static int
                f_23125_4306_4324(Microsoft.CodeAnalysis.SyntaxTree[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 4306, 4324);
                    return return_v;
                }


                static int
                f_23125_4270_4352(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 4270, 4352);
                    return 0;
                }


                static int
                f_23125_4495_4513(Microsoft.CodeAnalysis.SyntaxTree[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 4495, 4513);
                    return return_v;
                }


                static int
                f_23125_4377_4514(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                originalOptions, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, System.Reflection.Metadata.BlobReader
                compilationOptionsBlobReader, string
                langVersion, int
                sourceFileCount)
                {
                    VerifyCompilationOptions(originalOptions, (Microsoft.CodeAnalysis.Compilation)compilation, emitOptions, compilationOptionsBlobReader, langVersion, sourceFileCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 4377, 4514);
                    return 0;
                }


                static int
                f_23125_4537_4642(Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo[]
                references, System.Reflection.Metadata.BlobReader
                metadataReferenceReader)
                {
                    DeterministicBuildCompilationTestHelpers.VerifyReferenceInfo(references, metadataReferenceReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 4537, 4642);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23125, 2302, 4688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23125, 2302, 4688);
            }
        }

        [Theory]
        [ClassData(typeof(CSharpDeterministicBuildCompilationTests))]
        public void PortablePdb_DeterministicCompilation(CSharpCompilationOptions compilationOptions, EmitOptions emitOptions, CSharpParseOptions parseOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23125, 4700, 6627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 4965, 5174);

                var
                sourceOne = f_23125_4981_5173(@"
using System;

class MainType
{
    public static void Main()
    {
        Console.WriteLine();
    }
}
", filename: "a.cs", options: parseOptions, encoding: f_23125_5159_5172())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 5190, 5347);

                var
                sourceTwo = f_23125_5206_5346(@"
class TypeTwo
{
}", filename: "b.cs", options: parseOptions, encoding: f_23125_5289_5345(encoderShouldEmitUTF8Identifier: false))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 5363, 5484);

                var
                sourceThree = f_23125_5381_5483(@"
class TypeThree
{
}", filename: "c.cs", options: parseOptions, encoding: f_23125_5466_5482())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 5500, 5709);

                var
                referenceOneCompilation = f_23125_5530_5708(@"public struct StructWithReference
{
    string PrivateData;
}
public struct StructWithValue
{
    int PrivateData;
}", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 5725, 5842);

                var
                referenceTwoCompilation = f_23125_5755_5841(@"public class ReferenceTwo
{
}", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 5858, 6041);

                using var
                referenceOne = f_23125_5883_6040(referenceOneCompilation, fullPath: "abcd.dll", emitOptions: emitOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 6057, 6240);

                using var
                referenceTwo = f_23125_6082_6239(referenceTwoCompilation, fullPath: "efgh.dll", emitOptions: emitOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 6256, 6317);

                var
                testSource = new[] { sourceOne, sourceTwo, sourceThree }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 6331, 6616);

                f_23125_6331_6615(f_23125_6384_6463(f_23125_6384_6445(f_23125_6384_6412(parseOptions))), testSource, compilationOptions, emitOptions, new[] { referenceOne, referenceTwo });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23125, 4700, 6627);

                System.Text.Encoding
                f_23125_5159_5172()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 5159, 5172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23125_4981_5173(string
                text, string
                filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, System.Text.Encoding
                encoding)
                {
                    var return_v = Parse(text, filename: filename, options: options, encoding: encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 4981, 5173);
                    return return_v;
                }


                System.Text.UTF8Encoding
                f_23125_5289_5345(bool
                encoderShouldEmitUTF8Identifier)
                {
                    var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: encoderShouldEmitUTF8Identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 5289, 5345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23125_5206_5346(string
                text, string
                filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, System.Text.UTF8Encoding
                encoding)
                {
                    var return_v = Parse(text, filename: filename, options: options, encoding: (System.Text.Encoding)encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 5206, 5346);
                    return return_v;
                }


                System.Text.Encoding
                f_23125_5466_5482()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 5466, 5482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23125_5381_5483(string
                text, string
                filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, System.Text.Encoding
                encoding)
                {
                    var return_v = Parse(text, filename: filename, options: options, encoding: encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 5381, 5483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23125_5530_5708(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 5530, 5708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23125_5755_5841(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 5755, 5841);
                    return return_v;
                }


                Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo
                f_23125_5883_6040(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                fullPath, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = TestMetadataReferenceInfo.Create((Microsoft.CodeAnalysis.Compilation)compilation, fullPath: fullPath, emitOptions: emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 5883, 6040);
                    return return_v;
                }


                Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo
                f_23125_6082_6239(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                fullPath, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = TestMetadataReferenceInfo.Create((Microsoft.CodeAnalysis.Compilation)compilation, fullPath: fullPath, emitOptions: emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 6082, 6239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_23125_6384_6412(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 6384, 6412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_23125_6384_6445(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.MapSpecifiedToEffectiveVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 6384, 6445);
                    return return_v;
                }


                string
                f_23125_6384_6463(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 6384, 6463);
                    return return_v;
                }


                int
                f_23125_6331_6615(string
                langVersion, Microsoft.CodeAnalysis.SyntaxTree[]
                syntaxTrees, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo[]
                metadataReferences)
                {
                    TestDeterministicCompilationCSharp(langVersion, syntaxTrees, compilationOptions, emitOptions, metadataReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 6331, 6615);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23125, 4700, 6627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23125, 4700, 6627);
            }
        }

        [Theory]
        [ClassData(typeof(CSharpDeterministicBuildCompilationTests))]
        public void PortablePdb_DeterministicCompilation_DuplicateFilePaths(CSharpCompilationOptions compilationOptions, EmitOptions emitOptions, CSharpParseOptions parseOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23125, 6639, 8851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 6923, 7132);

                var
                sourceOne = f_23125_6939_7131(@"
using System;

class MainType
{
    public static void Main()
    {
        Console.WriteLine();
    }
}
", filename: "a.cs", options: parseOptions, encoding: f_23125_7117_7130())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 7148, 7305);

                var
                sourceTwo = f_23125_7164_7304(@"
class TypeTwo
{
}", filename: "b.cs", options: parseOptions, encoding: f_23125_7247_7303(encoderShouldEmitUTF8Identifier: false))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 7321, 7442);

                var
                sourceThree = f_23125_7339_7441(@"
class TypeThree
{
}", filename: "a.cs", options: parseOptions, encoding: f_23125_7424_7440())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 7458, 7667);

                var
                referenceOneCompilation = f_23125_7488_7666(@"public struct StructWithReference
{
    string PrivateData;
}
public struct StructWithValue
{
    int PrivateData;
}", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 7683, 7800);

                var
                referenceTwoCompilation = f_23125_7713_7799(@"public class ReferenceTwo
{
}", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 7816, 7999);

                using var
                referenceOne = f_23125_7841_7998(referenceOneCompilation, fullPath: "abcd.dll", emitOptions: emitOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 8015, 8198);

                using var
                referenceTwo = f_23125_8040_8197(referenceTwoCompilation, fullPath: "efgh.dll", emitOptions: emitOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 8214, 8275);

                var
                testSource = new[] { sourceOne, sourceTwo, sourceThree }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 8514, 8840);

                f_23125_8514_8839(f_23125_8567_8646(f_23125_8567_8628(f_23125_8567_8595(parseOptions))), testSource, compilationOptions, emitOptions, new[] { referenceOne, referenceTwo }, debugDocumentsCount: 2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23125, 6639, 8851);

                System.Text.Encoding
                f_23125_7117_7130()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 7117, 7130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23125_6939_7131(string
                text, string
                filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, System.Text.Encoding
                encoding)
                {
                    var return_v = Parse(text, filename: filename, options: options, encoding: encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 6939, 7131);
                    return return_v;
                }


                System.Text.UTF8Encoding
                f_23125_7247_7303(bool
                encoderShouldEmitUTF8Identifier)
                {
                    var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: encoderShouldEmitUTF8Identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 7247, 7303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23125_7164_7304(string
                text, string
                filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, System.Text.UTF8Encoding
                encoding)
                {
                    var return_v = Parse(text, filename: filename, options: options, encoding: (System.Text.Encoding)encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 7164, 7304);
                    return return_v;
                }


                System.Text.Encoding
                f_23125_7424_7440()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 7424, 7440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23125_7339_7441(string
                text, string
                filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, System.Text.Encoding
                encoding)
                {
                    var return_v = Parse(text, filename: filename, options: options, encoding: encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 7339, 7441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23125_7488_7666(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 7488, 7666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23125_7713_7799(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 7713, 7799);
                    return return_v;
                }


                Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo
                f_23125_7841_7998(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                fullPath, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = TestMetadataReferenceInfo.Create((Microsoft.CodeAnalysis.Compilation)compilation, fullPath: fullPath, emitOptions: emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 7841, 7998);
                    return return_v;
                }


                Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo
                f_23125_8040_8197(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                fullPath, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = TestMetadataReferenceInfo.Create((Microsoft.CodeAnalysis.Compilation)compilation, fullPath: fullPath, emitOptions: emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 8040, 8197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_23125_8567_8595(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 8567, 8595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_23125_8567_8628(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.MapSpecifiedToEffectiveVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 8567, 8628);
                    return return_v;
                }


                string
                f_23125_8567_8646(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 8567, 8646);
                    return return_v;
                }


                int
                f_23125_8514_8839(string
                langVersion, Microsoft.CodeAnalysis.SyntaxTree[]
                syntaxTrees, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo[]
                metadataReferences, int
                debugDocumentsCount)
                {
                    TestDeterministicCompilationCSharp(langVersion, syntaxTrees, compilationOptions, emitOptions, metadataReferences, debugDocumentsCount: (int?)debugDocumentsCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 8514, 8839);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23125, 6639, 8851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23125, 6639, 8851);
            }
        }

        [ConditionalTheory(typeof(DesktopOnly))]
        [ClassData(typeof(CSharpDeterministicBuildCompilationTests))]
        public void PortablePdb_DeterministicCompilationWithSJIS(CSharpCompilationOptions compilationOptions, EmitOptions emitOptions, CSharpParseOptions parseOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23125, 8863, 10856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 9168, 9377);

                var
                sourceOne = f_23125_9184_9376(@"
using System;

class MainType
{
    public static void Main()
    {
        Console.WriteLine();
    }
}
", filename: "a.cs", options: parseOptions, encoding: f_23125_9362_9375())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 9393, 9550);

                var
                sourceTwo = f_23125_9409_9549(@"
class TypeTwo
{
}", filename: "b.cs", options: parseOptions, encoding: f_23125_9492_9548(encoderShouldEmitUTF8Identifier: false))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 9566, 9696);

                var
                sourceThree = f_23125_9584_9695(@"
class TypeThree
{
}", filename: "c.cs", options: parseOptions, encoding: f_23125_9669_9694(932))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 9729, 9938);

                var
                referenceOneCompilation = f_23125_9759_9937(@"public struct StructWithReference
{
    string PrivateData;
}
public struct StructWithValue
{
    int PrivateData;
}", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 9954, 10071);

                var
                referenceTwoCompilation = f_23125_9984_10070(@"public class ReferenceTwo
{
}", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 10087, 10270);

                using var
                referenceOne = f_23125_10112_10269(referenceOneCompilation, fullPath: "abcd.dll", emitOptions: emitOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 10286, 10469);

                using var
                referenceTwo = f_23125_10311_10468(referenceTwoCompilation, fullPath: "efgh.dll", emitOptions: emitOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 10485, 10546);

                var
                testSource = new[] { sourceOne, sourceTwo, sourceThree }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 10560, 10845);

                f_23125_10560_10844(f_23125_10613_10692(f_23125_10613_10674(f_23125_10613_10641(parseOptions))), testSource, compilationOptions, emitOptions, new[] { referenceOne, referenceTwo });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23125, 8863, 10856);

                System.Text.Encoding
                f_23125_9362_9375()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 9362, 9375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23125_9184_9376(string
                text, string
                filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, System.Text.Encoding
                encoding)
                {
                    var return_v = Parse(text, filename: filename, options: options, encoding: encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 9184, 9376);
                    return return_v;
                }


                System.Text.UTF8Encoding
                f_23125_9492_9548(bool
                encoderShouldEmitUTF8Identifier)
                {
                    var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: encoderShouldEmitUTF8Identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 9492, 9548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23125_9409_9549(string
                text, string
                filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, System.Text.UTF8Encoding
                encoding)
                {
                    var return_v = Parse(text, filename: filename, options: options, encoding: (System.Text.Encoding)encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 9409, 9549);
                    return return_v;
                }


                System.Text.Encoding
                f_23125_9669_9694(int
                codepage)
                {
                    var return_v = Encoding.GetEncoding(codepage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 9669, 9694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23125_9584_9695(string
                text, string
                filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, System.Text.Encoding
                encoding)
                {
                    var return_v = Parse(text, filename: filename, options: options, encoding: encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 9584, 9695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23125_9759_9937(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 9759, 9937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23125_9984_10070(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 9984, 10070);
                    return return_v;
                }


                Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo
                f_23125_10112_10269(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                fullPath, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = TestMetadataReferenceInfo.Create((Microsoft.CodeAnalysis.Compilation)compilation, fullPath: fullPath, emitOptions: emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 10112, 10269);
                    return return_v;
                }


                Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo
                f_23125_10311_10468(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                fullPath, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = TestMetadataReferenceInfo.Create((Microsoft.CodeAnalysis.Compilation)compilation, fullPath: fullPath, emitOptions: emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 10311, 10468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_23125_10613_10641(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23125, 10613, 10641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_23125_10613_10674(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.MapSpecifiedToEffectiveVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 10613, 10674);
                    return return_v;
                }


                string
                f_23125_10613_10692(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 10613, 10692);
                    return return_v;
                }


                int
                f_23125_10560_10844(string
                langVersion, Microsoft.CodeAnalysis.SyntaxTree[]
                syntaxTrees, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo[]
                metadataReferences)
                {
                    TestDeterministicCompilationCSharp(langVersion, syntaxTrees, compilationOptions, emitOptions, metadataReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 10560, 10844);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23125, 8863, 10856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23125, 8863, 10856);
            }
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23125, 10913, 10951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 10916, 10951);
                return f_23125_10916_10951(f_23125_10916_10935()); DynAbs.Tracing.TraceSender.TraceExitMethod(23125, 10913, 10951);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23125, 10913, 10951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23125, 10913, 10951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23125, 11004, 11022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 11007, 11022);
                return f_23125_11007_11022(this); DynAbs.Tracing.TraceSender.TraceExitMethod(23125, 11004, 11022);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23125, 11004, 11022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23125, 11004, 11022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<object[]> GetTestParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23125, 11035, 11581);

                var listYield = new List<Object[]>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 11116, 11570);
                    foreach (var compilationOptions in f_23125_11151_11174_I(f_23125_11151_11174()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23125, 11116, 11570);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 11208, 11555);
                            foreach (var emitOptions in f_23125_11236_11293_I(f_23125_11236_11293()))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(23125, 11208, 11555);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 11335, 11536);
                                    foreach (var parseOptions in f_23125_11364_11387_I(f_23125_11364_11387()))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23125, 11335, 11536);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 11437, 11513);

                                        listYield.Add(new object[] { compilationOptions, emitOptions, parseOptions });
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(23125, 11335, 11536);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(23125, 1, 202);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(23125, 1, 202);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(23125, 11208, 11555);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(23125, 1, 348);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(23125, 1, 348);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(23125, 11116, 11570);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(23125, 1, 455);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(23125, 1, 455);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23125, 11035, 11581);

                return listYield;

                static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions>
                f_23125_11151_11174()
                {
                    var return_v = GetCompilationOptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 11151, 11174);
                    return return_v;
                }


                static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.EmitOptions>
                f_23125_11236_11293()
                {
                    var return_v = DeterministicBuildCompilationTestHelpers.GetEmitOptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 11236, 11293);
                    return return_v;
                }


                static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.CSharpParseOptions>
                f_23125_11364_11387()
                {
                    var return_v = GetCSharpParseOptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 11364, 11387);
                    return return_v;
                }


                static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.CSharpParseOptions>
                f_23125_11364_11387_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.CSharpParseOptions>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 11364, 11387);
                    return return_v;
                }


                static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.EmitOptions>
                f_23125_11236_11293_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.EmitOptions>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 11236, 11293);
                    return return_v;
                }


                static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions>
                f_23125_11151_11174_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 11151, 11174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23125, 11035, 11581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23125, 11035, 11581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<CSharpCompilationOptions> GetCompilationOptions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23125, 11593, 15321);

                var listYield = new List<CSharpCompilationOptions>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 12221, 13787);

                var
                defaultOptions = f_23125_12242_13786(OutputKind.ConsoleApplication, reportSuppressedDiagnostics: false, moduleName: "Module", mainTypeName: "MainType", scriptClassName: null, usings: new[] { "System", "System.Threading" }, optimizationLevel: OptimizationLevel.Debug, checkOverflow: true, allowUnsafe: true, cryptoKeyContainer: null, cryptoKeyFile: null, cryptoPublicKey: default, delaySign: null, platform: Platform.AnyCpu, generalDiagnosticOption: ReportDiagnostic.Default, warningLevel: 4, specificDiagnosticOptions: null, concurrentBuild: true, deterministic: true, currentLocalTime: default, debugPlusMode: false, xmlReferenceResolver: null, sourceReferenceResolver: null, syntaxTreeOptionsProvider: null, metadataReferenceResolver: null, assemblyIdentityComparer: null, strongNameProvider: null, metadataImportOptions: MetadataImportOptions.Public, referencesSupersedeLowerVersions: false, publicSign: false, topLevelBinderFlags: BinderFlags.None, nullableContextOptions: NullableContextOptions.Enable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 13803, 13831);

                listYield.Add(defaultOptions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 13845, 13932);

                listYield.Add(f_23125_13858_13931(defaultOptions, NullableContextOptions.Disable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 13946, 14034);

                listYield.Add(f_23125_13959_14033(defaultOptions, NullableContextOptions.Warnings));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 14048, 14125);

                listYield.Add(f_23125_14061_14124(defaultOptions, OptimizationLevel.Release));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 14139, 14191);

                listYield.Add(f_23125_14152_14190(defaultOptions, true));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 14205, 14306);

                listYield.Add(f_23125_14218_14305(f_23125_14218_14281(defaultOptions, OptimizationLevel.Release), true));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 14320, 14558);

                listYield.Add(f_23125_14333_14557(defaultOptions, f_23125_14377_14556(f_23125_14413_14555(suppressSilverlightLibraryAssembliesPortability: false, suppressSilverlightPlatformAssembliesPortability: false))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 14572, 14809);

                listYield.Add(f_23125_14585_14808(defaultOptions, f_23125_14629_14807(f_23125_14665_14806(suppressSilverlightLibraryAssembliesPortability: true, suppressSilverlightPlatformAssembliesPortability: false))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 14823, 15060);

                listYield.Add(f_23125_14836_15059(defaultOptions, f_23125_14880_15058(f_23125_14916_15057(suppressSilverlightLibraryAssembliesPortability: false, suppressSilverlightPlatformAssembliesPortability: true))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 15074, 15310);

                listYield.Add(f_23125_15087_15309(defaultOptions, f_23125_15131_15308(f_23125_15167_15307(suppressSilverlightLibraryAssembliesPortability: true, suppressSilverlightPlatformAssembliesPortability: true))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23125, 11593, 15321);

                return listYield;

                static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23125_12242_13786(Microsoft.CodeAnalysis.OutputKind
                outputKind, bool
                reportSuppressedDiagnostics, string
                moduleName, string
                mainTypeName, string?
                scriptClassName, string[]
                usings, Microsoft.CodeAnalysis.OptimizationLevel
                optimizationLevel, bool
                checkOverflow, bool
                allowUnsafe, string?
                cryptoKeyContainer, string?
                cryptoKeyFile, System.Collections.Immutable.ImmutableArray<byte>
                cryptoPublicKey, bool?
                delaySign, Microsoft.CodeAnalysis.Platform
                platform, Microsoft.CodeAnalysis.ReportDiagnostic
                generalDiagnosticOption, int
                warningLevel, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>?
                specificDiagnosticOptions, bool
                concurrentBuild, bool
                deterministic, System.DateTime
                currentLocalTime, bool
                debugPlusMode, Microsoft.CodeAnalysis.XmlReferenceResolver?
                xmlReferenceResolver, Microsoft.CodeAnalysis.SourceReferenceResolver?
                sourceReferenceResolver, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                syntaxTreeOptionsProvider, Microsoft.CodeAnalysis.MetadataReferenceResolver?
                metadataReferenceResolver, Microsoft.CodeAnalysis.AssemblyIdentityComparer?
                assemblyIdentityComparer, Microsoft.CodeAnalysis.StrongNameProvider?
                strongNameProvider, Microsoft.CodeAnalysis.MetadataImportOptions
                metadataImportOptions, bool
                referencesSupersedeLowerVersions, bool
                publicSign, Microsoft.CodeAnalysis.CSharp.BinderFlags
                topLevelBinderFlags, Microsoft.CodeAnalysis.NullableContextOptions
                nullableContextOptions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions(outputKind, reportSuppressedDiagnostics: reportSuppressedDiagnostics, moduleName: moduleName, mainTypeName: mainTypeName, scriptClassName: scriptClassName, usings: (System.Collections.Generic.IEnumerable<string>)usings, optimizationLevel: optimizationLevel, checkOverflow: checkOverflow, allowUnsafe: allowUnsafe, cryptoKeyContainer: cryptoKeyContainer, cryptoKeyFile: cryptoKeyFile, cryptoPublicKey: cryptoPublicKey, delaySign: delaySign, platform: platform, generalDiagnosticOption: generalDiagnosticOption, warningLevel: warningLevel, specificDiagnosticOptions: specificDiagnosticOptions, concurrentBuild: concurrentBuild, deterministic: deterministic, currentLocalTime: currentLocalTime, debugPlusMode: debugPlusMode, xmlReferenceResolver: xmlReferenceResolver, sourceReferenceResolver: sourceReferenceResolver, syntaxTreeOptionsProvider: syntaxTreeOptionsProvider, metadataReferenceResolver: metadataReferenceResolver, assemblyIdentityComparer: assemblyIdentityComparer, strongNameProvider: strongNameProvider, metadataImportOptions: metadataImportOptions, referencesSupersedeLowerVersions: referencesSupersedeLowerVersions, publicSign: publicSign, topLevelBinderFlags: topLevelBinderFlags, nullableContextOptions: nullableContextOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 12242, 13786);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23125_13858_13931(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.NullableContextOptions
                options)
                {
                    var return_v = this_param.WithNullableContextOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 13858, 13931);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23125_13959_14033(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.NullableContextOptions
                options)
                {
                    var return_v = this_param.WithNullableContextOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 13959, 14033);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23125_14061_14124(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.OptimizationLevel
                value)
                {
                    var return_v = this_param.WithOptimizationLevel(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14061, 14124);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23125_14152_14190(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool
                debugPlusMode)
                {
                    var return_v = this_param.WithDebugPlusMode(debugPlusMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14152, 14190);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23125_14218_14281(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.OptimizationLevel
                value)
                {
                    var return_v = this_param.WithOptimizationLevel(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14218, 14281);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23125_14218_14305(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool
                debugPlusMode)
                {
                    var return_v = this_param.WithDebugPlusMode(debugPlusMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14218, 14305);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.AssemblyPortabilityPolicy
                f_23125_14413_14555(bool
                suppressSilverlightLibraryAssembliesPortability, bool
                suppressSilverlightPlatformAssembliesPortability)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyPortabilityPolicy(suppressSilverlightLibraryAssembliesPortability: suppressSilverlightLibraryAssembliesPortability, suppressSilverlightPlatformAssembliesPortability: suppressSilverlightPlatformAssembliesPortability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14413, 14555);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                f_23125_14377_14556(Microsoft.CodeAnalysis.AssemblyPortabilityPolicy
                policy)
                {
                    var return_v = new Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer(policy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14377, 14556);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23125_14333_14557(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                comparer)
                {
                    var return_v = this_param.WithAssemblyIdentityComparer((Microsoft.CodeAnalysis.AssemblyIdentityComparer)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14333, 14557);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.AssemblyPortabilityPolicy
                f_23125_14665_14806(bool
                suppressSilverlightLibraryAssembliesPortability, bool
                suppressSilverlightPlatformAssembliesPortability)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyPortabilityPolicy(suppressSilverlightLibraryAssembliesPortability: suppressSilverlightLibraryAssembliesPortability, suppressSilverlightPlatformAssembliesPortability: suppressSilverlightPlatformAssembliesPortability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14665, 14806);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                f_23125_14629_14807(Microsoft.CodeAnalysis.AssemblyPortabilityPolicy
                policy)
                {
                    var return_v = new Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer(policy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14629, 14807);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23125_14585_14808(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                comparer)
                {
                    var return_v = this_param.WithAssemblyIdentityComparer((Microsoft.CodeAnalysis.AssemblyIdentityComparer)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14585, 14808);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.AssemblyPortabilityPolicy
                f_23125_14916_15057(bool
                suppressSilverlightLibraryAssembliesPortability, bool
                suppressSilverlightPlatformAssembliesPortability)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyPortabilityPolicy(suppressSilverlightLibraryAssembliesPortability: suppressSilverlightLibraryAssembliesPortability, suppressSilverlightPlatformAssembliesPortability: suppressSilverlightPlatformAssembliesPortability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14916, 15057);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                f_23125_14880_15058(Microsoft.CodeAnalysis.AssemblyPortabilityPolicy
                policy)
                {
                    var return_v = new Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer(policy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14880, 15058);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23125_14836_15059(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                comparer)
                {
                    var return_v = this_param.WithAssemblyIdentityComparer((Microsoft.CodeAnalysis.AssemblyIdentityComparer)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 14836, 15059);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.AssemblyPortabilityPolicy
                f_23125_15167_15307(bool
                suppressSilverlightLibraryAssembliesPortability, bool
                suppressSilverlightPlatformAssembliesPortability)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyPortabilityPolicy(suppressSilverlightLibraryAssembliesPortability: suppressSilverlightLibraryAssembliesPortability, suppressSilverlightPlatformAssembliesPortability: suppressSilverlightPlatformAssembliesPortability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 15167, 15307);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                f_23125_15131_15308(Microsoft.CodeAnalysis.AssemblyPortabilityPolicy
                policy)
                {
                    var return_v = new Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer(policy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 15131, 15308);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23125_15087_15309(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                comparer)
                {
                    var return_v = this_param.WithAssemblyIdentityComparer((Microsoft.CodeAnalysis.AssemblyIdentityComparer)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 15087, 15309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23125, 11593, 15321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23125, 11593, 15321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<CSharpParseOptions> GetCSharpParseOptions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23125, 15333, 15884);

                var listYield = new List<CSharpParseOptions>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 15428, 15577);

                var
                parseOptions = f_23125_15447_15576(languageVersion: LanguageVersion.CSharp8, kind: SourceCodeKind.Regular)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 15593, 15619);

                listYield.Add(parseOptions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 15633, 15704);

                listYield.Add(f_23125_15646_15703(parseOptions, LanguageVersion.CSharp9));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 15718, 15788);

                listYield.Add(f_23125_15731_15787(parseOptions, LanguageVersion.Latest));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23125, 15802, 15873);

                listYield.Add(f_23125_15815_15872(parseOptions, LanguageVersion.Preview));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23125, 15333, 15884);

                return listYield;

                static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_23125_15447_15576(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                languageVersion, Microsoft.CodeAnalysis.SourceCodeKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpParseOptions(languageVersion: languageVersion, kind: kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 15447, 15576);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_23125_15646_15703(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = this_param.WithLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 15646, 15703);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_23125_15731_15787(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = this_param.WithLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 15731, 15787);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_23125_15815_15872(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = this_param.WithLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 15815, 15872);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23125, 15333, 15884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23125, 15333, 15884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpDeterministicBuildCompilationTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(23125, 834, 15891);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(23125, 834, 15891);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23125, 834, 15891);
        }


        static CSharpDeterministicBuildCompilationTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23125, 834, 15891);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23125, 834, 15891);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23125, 834, 15891);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23125, 834, 15891);

        System.Collections.Generic.IEnumerable<object[]>
        f_23125_10916_10935()
        {
            var return_v = GetTestParameters();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 10916, 10935);
            return return_v;
        }


        System.Collections.Generic.IEnumerator<object[]>
        f_23125_10916_10951(System.Collections.Generic.IEnumerable<object[]>
        this_param)
        {
            var return_v = this_param.GetEnumerator();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 10916, 10951);
            return return_v;
        }


        System.Collections.Generic.IEnumerator<object[]>
        f_23125_11007_11022(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.CSharpDeterministicBuildCompilationTests
        this_param)
        {
            var return_v = this_param.GetEnumerator();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(23125, 11007, 11022);
            return return_v;
        }

    }
}
