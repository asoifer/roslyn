// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.DiaSymReader;
using Microsoft.DiaSymReader.Tools;
using Microsoft.Metadata.Tools;
using Roslyn.Test.PdbUtilities;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public static class PdbValidation
    {
        public static CompilationVerifier VerifyPdb(
            this CompilationVerifier verifier,
            XElement expectedPdb,
            IEnumerable<EmbeddedText> embeddedTexts = null,
            IMethodSymbol debugEntryPoint = null,
            DebugInformationFormat format = 0,
            PdbValidationOptions options = PdbValidationOptions.Default,
            [CallerLineNumber] int expectedValueSourceLine = 0,
            [CallerFilePath] string expectedValueSourcePath = null)
        {
            verifier.Compilation.VerifyPdb(expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
            return verifier;
        }

        public static CompilationVerifier VerifyPdb(
            this CompilationVerifier verifier,
            string expectedPdb,
            IEnumerable<EmbeddedText> embeddedTexts = null,
            IMethodSymbol debugEntryPoint = null,
            DebugInformationFormat format = 0,
            PdbValidationOptions options = PdbValidationOptions.Default,
            [CallerLineNumber] int expectedValueSourceLine = 0,
            [CallerFilePath] string expectedValueSourcePath = null)
        {
            verifier.Compilation.VerifyPdb(expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
            return verifier;
        }

        public static CompilationVerifier VerifyPdb(
            this CompilationVerifier verifier,
            string qualifiedMethodName,
            string expectedPdb,
            IEnumerable<EmbeddedText> embeddedTexts = null,
            IMethodSymbol debugEntryPoint = null,
            DebugInformationFormat format = 0,
            PdbValidationOptions options = PdbValidationOptions.Default,
            [CallerLineNumber] int expectedValueSourceLine = 0,
            [CallerFilePath] string expectedValueSourcePath = null)
        {
            verifier.Compilation.VerifyPdb(qualifiedMethodName, expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
            return verifier;
        }

        public static CompilationVerifier VerifyPdb(
            this CompilationVerifier verifier,
            string qualifiedMethodName,
            XElement expectedPdb,
            IEnumerable<EmbeddedText> embeddedTexts = null,
            IMethodSymbol debugEntryPoint = null,
            DebugInformationFormat format = 0,
            PdbValidationOptions options = PdbValidationOptions.Default,
            [CallerLineNumber] int expectedValueSourceLine = 0,
            [CallerFilePath] string expectedValueSourcePath = null)
        {
            verifier.Compilation.VerifyPdb(qualifiedMethodName, expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
            return verifier;
        }

        public static void VerifyPdb(this CompilationDifference diff, IEnumerable<MethodDefinitionHandle> methodHandles, string expectedPdb)
        {
            VerifyPdb(diff, methodHandles.Select(h => MetadataTokens.GetToken(h)), expectedPdb);
        }

        public static void VerifyPdb(this CompilationDifference diff, IEnumerable<MethodDefinitionHandle> methodHandles, XElement expectedPdb)
        {
            VerifyPdb(diff, methodHandles.Select(h => MetadataTokens.GetToken(h)), expectedPdb);
        }

        public static void VerifyPdb(
            this CompilationDifference diff,
            IEnumerable<int> methodTokens,
            string expectedPdb,
            DebugInformationFormat format = DebugInformationFormat.Pdb,
            [CallerLineNumber] int expectedValueSourceLine = 0,
            [CallerFilePath] string expectedValueSourcePath = null)
        {
            VerifyPdb(diff, methodTokens, expectedPdb, format, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral: false);
        }

        public static void VerifyPdb(
            this CompilationDifference diff,
            IEnumerable<int> methodTokens,
            XElement expectedPdb,
            DebugInformationFormat format = DebugInformationFormat.Pdb,
            [CallerLineNumber] int expectedValueSourceLine = 0,
            [CallerFilePath] string expectedValueSourcePath = null)
        {
            VerifyPdb(diff, methodTokens, expectedPdb.ToString(), format, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral: true);
        }

        private static void VerifyPdb(
            this CompilationDifference diff,
            IEnumerable<int> methodTokens,
            string expectedPdb,
            DebugInformationFormat format,
            int expectedValueSourceLine,
            string expectedValueSourcePath,
            bool expectedIsXmlLiteral)
        {
            CustomAssert.NotEqual(default(DebugInformationFormat), format);
            CustomAssert.NotEqual(DebugInformationFormat.Embedded, format);

            string actualPdb = PdbToXmlConverter.DeltaPdbToXml(new ImmutableMemoryStream(diff.PdbDelta), methodTokens);
            var (actual, expected) = AdjustToPdbFormat(actualPdb, expectedPdb, actualIsPortable: diff.NextGeneration.InitialBaseline.HasPortablePdb, actualIsConverted: false);

            AssertEx.AssertLinesEqual(
                expected,
                actual,
                $"PDB format: {format}{Environment.NewLine}",
                expectedValueSourcePath,
                expectedValueSourceLine,
                escapeQuotes: !expectedIsXmlLiteral);
        }

        public static bool VerifyPdb(
            this Compilation compilation,
            string expectedPdb,
            IEnumerable<EmbeddedText> embeddedTexts = null,
            IMethodSymbol debugEntryPoint = null,
            DebugInformationFormat format = 0,
            PdbValidationOptions options = PdbValidationOptions.Default,
            [CallerLineNumber] int expectedValueSourceLine = 0,
            [CallerFilePath] string expectedValueSourcePath = null)
        {
            return VerifyPdb(compilation, "", expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
        }

        public static bool VerifyPdb(
            this Compilation compilation,
            string qualifiedMethodName,
            string expectedPdb,
            IEnumerable<EmbeddedText> embeddedTexts = null,
            IMethodSymbol debugEntryPoint = null,
            DebugInformationFormat format = 0,
            PdbValidationOptions options = PdbValidationOptions.Default,
            [CallerLineNumber] int expectedValueSourceLine = 0,
            [CallerFilePath] string expectedValueSourcePath = null)
        {
            return VerifyPdbImpl(
                compilation,
                embeddedTexts,
                debugEntryPoint,
                qualifiedMethodName,
                string.IsNullOrWhiteSpace(expectedPdb) ? "<symbols></symbols>" : expectedPdb,
                format,
                options,
                expectedValueSourceLine,
                expectedValueSourcePath,
                expectedIsXmlLiteral: false);
        }

        public static void VerifyPdb(
            this Compilation compilation,
            XElement expectedPdb,
            IEnumerable<EmbeddedText> embeddedTexts = null,
            IMethodSymbol debugEntryPoint = null,
            DebugInformationFormat format = 0,
            PdbValidationOptions options = PdbValidationOptions.Default,
            [CallerLineNumber] int expectedValueSourceLine = 0,
            [CallerFilePath] string expectedValueSourcePath = null)
        {
            VerifyPdb(compilation, "", expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
        }

        public static void VerifyPdb(
            this Compilation compilation,
            string qualifiedMethodName,
            XElement expectedPdb,
            IEnumerable<EmbeddedText> embeddedTexts = null,
            IMethodSymbol debugEntryPoint = null,
            DebugInformationFormat format = 0,
            PdbValidationOptions options = PdbValidationOptions.Default,
            [CallerLineNumber] int expectedValueSourceLine = 0,
            [CallerFilePath] string expectedValueSourcePath = null)
        {
            VerifyPdbImpl(
                compilation,
                embeddedTexts,
                debugEntryPoint,
                qualifiedMethodName,
                expectedPdb.ToString(),
                format,
                options,
                expectedValueSourceLine,
                expectedValueSourcePath,
                expectedIsXmlLiteral: true);
        }

        private static bool VerifyPdbImpl(
            this Compilation compilation,
            IEnumerable<EmbeddedText> embeddedTexts,
            IMethodSymbol debugEntryPoint,
            string qualifiedMethodName,
            string expectedPdb,
            DebugInformationFormat format,
            PdbValidationOptions options,
            int expectedValueSourceLine,
            string expectedValueSourcePath,
            bool expectedIsXmlLiteral)
        {
            CustomAssert.NotEqual(DebugInformationFormat.Embedded, format);

            bool testWindowsPdb = (format == 0 || format == DebugInformationFormat.Pdb) && ExecutionConditionUtil.IsWindows;
            bool testPortablePdb = format == 0 || format == DebugInformationFormat.PortablePdb;
            bool testConversion = (options & PdbValidationOptions.SkipConversionValidation) == 0;
            var pdbToXmlOptions = options.ToPdbToXmlOptions();

            // LAFHIS
            var toReturn = true;

            if (testWindowsPdb)
            {
                toReturn = toReturn && Verify(false, testPortablePdb, compilation, embeddedTexts, debugEntryPoint, qualifiedMethodName, expectedPdb, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral, testConversion, pdbToXmlOptions);
            }

            if (testPortablePdb)
            {
                toReturn = toReturn && Verify(true, testWindowsPdb, compilation, embeddedTexts, debugEntryPoint, qualifiedMethodName, expectedPdb, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral, testConversion, pdbToXmlOptions);
            }

            return toReturn;

            #region LAFHIS
            /// LAFHIS: We don't allow variables of other scopes. This was the original method.
            //bool Verify(bool isPortable, bool testOtherFormat)
            //{
            //    var peStream = new MemoryStream();
            //    var pdbStream = new MemoryStream();
            //    EmitWithPdb(peStream, pdbStream, compilation, debugEntryPoint, embeddedTexts, isPortable);

            //    var toReturn = true;

            //    toReturn = toReturn && VerifyPdbMatchesExpectedXml(peStream, pdbStream, qualifiedMethodName, pdbToXmlOptions, expectedPdb, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral, isPortable);

            //    if (testConversion && testOtherFormat)
            //    {
            //        toReturn = toReturn && VerifyConvertedPdbMatchesExpectedXml(peStream, pdbStream, qualifiedMethodName, expectedPdb, pdbToXmlOptions, expectedIsXmlLiteral, isPortable);
            //    }

            //    return toReturn;
            //}
            #endregion

            bool Verify(bool isPortable, 
                bool testOtherFormat,
                Compilation compilation,
                IEnumerable<EmbeddedText> embeddedTexts,
                IMethodSymbol debugEntryPoint,
                string qualifiedMethodName,
                string expectedPdb,
                int expectedValueSourceLine,
                string expectedValueSourcePath,
                bool expectedIsXmlLiteral,
                bool testConversion,
                PdbToXmlOptions pdbToXmlOptions)
            {
                var peStream = new MemoryStream();
                var pdbStream = new MemoryStream();
                EmitWithPdb(peStream, pdbStream, compilation, debugEntryPoint, embeddedTexts, isPortable);

                var toReturn = true;

                toReturn = toReturn && VerifyPdbMatchesExpectedXml(peStream, pdbStream, qualifiedMethodName, pdbToXmlOptions, expectedPdb, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral, isPortable);

                if (testConversion && testOtherFormat)
                {
                    toReturn = toReturn && VerifyConvertedPdbMatchesExpectedXml(peStream, pdbStream, qualifiedMethodName, expectedPdb, pdbToXmlOptions, expectedIsXmlLiteral, isPortable);
                }

                return toReturn;
            }
        }

        private static bool VerifyPdbMatchesExpectedXml(
            Stream peStream,
            Stream pdbStream,
            string qualifiedMethodName,
            PdbToXmlOptions pdbToXmlOptions,
            string expectedPdb,
            int expectedValueSourceLine,
            string expectedValueSourcePath,
            bool expectedIsXmlLiteral,
            bool isPortable)
        {
            peStream.Position = 0;
            pdbStream.Position = 0;
            var actualPdb = XElement.Parse(PdbToXmlConverter.ToXml(pdbStream, peStream, pdbToXmlOptions, methodName: qualifiedMethodName)).ToString();
            var (actual, expected) = AdjustToPdbFormat(actualPdb, expectedPdb, actualIsPortable: isPortable, actualIsConverted: false);

            return AssertEx.AssertLinesEqual(
                expected,
                actual,
                $"PDB format: {(isPortable ? "Portable" : "Windows")}{Environment.NewLine}",
                expectedValueSourcePath,
                expectedValueSourceLine,
                escapeQuotes: !expectedIsXmlLiteral);
        }

        private static bool VerifyConvertedPdbMatchesExpectedXml(
            Stream peStreamOriginal,
            Stream pdbStreamOriginal,
            string qualifiedMethodName,
            string expectedPdb,
            PdbToXmlOptions pdbToXmlOptions,
            bool expectedIsXmlLiteral,
            bool originalIsPortable)
        {
            var pdbStreamConverted = new MemoryStream();
            var converter = new PdbConverter(diagnostic => CustomAssert.True(false, diagnostic.ToString()));

            peStreamOriginal.Position = 0;
            pdbStreamOriginal.Position = 0;

            if (originalIsPortable)
            {
                converter.ConvertPortableToWindows(peStreamOriginal, pdbStreamOriginal, pdbStreamConverted);
            }
            else
            {
                converter.ConvertWindowsToPortable(peStreamOriginal, pdbStreamOriginal, pdbStreamConverted);
            }

            pdbStreamConverted.Position = 0;
            peStreamOriginal.Position = 0;

            var actualConverted = AdjustForConversionArtifacts(XElement.Parse(PdbToXmlConverter.ToXml(pdbStreamConverted, peStreamOriginal, pdbToXmlOptions, methodName: qualifiedMethodName)).ToString());
            var adjustedExpected = AdjustForConversionArtifacts(expectedPdb);

            var (actual, expected) = AdjustToPdbFormat(actualConverted, adjustedExpected, actualIsPortable: !originalIsPortable, actualIsConverted: true);

            return AssertEx.AssertLinesEqual(
                expected,
                actual,
                $"PDB format: {(originalIsPortable ? "Windows" : "Portable")} converted from {(originalIsPortable ? "Portable" : "Windows")}{Environment.NewLine}",
                expectedValueSourcePath: null,
                expectedValueSourceLine: 0,
                escapeQuotes: !expectedIsXmlLiteral);
        }

        private static string AdjustForConversionArtifacts(string pdb)
        {
            var xml = XElement.Parse(pdb);
            var pendingRemoval = new List<XElement>();
            foreach (var e in xml.DescendantsAndSelf())
            {
                if (e.Name == "constant")
                {
                    // only compare constant names; values and signatures might differ:
                    var name = e.Attribute("name");
                    e.RemoveAttributes();
                    e.Add(name);
                }
                else if (e.Name == "bucket" && e.Parent.Name == "dynamicLocals")
                {
                    // dynamic flags might be 0-padded differently

                    var flags = e.Attribute("flags");
                    flags.SetValue(flags.Value.TrimEnd('0'));
                }
                else if (e.Name == "defunct")
                {
                    pendingRemoval.Add(e);
                }
            }

            foreach (var e in pendingRemoval)
            {
                e.Remove();
            }

            RemoveEmptyScopes(xml);
            return xml.ToString();
        }

        internal static (string Actual, string Expected) AdjustToPdbFormat(string actualPdb, string expectedPdb, bool actualIsPortable, bool actualIsConverted)
        {
            var actualXml = XElement.Parse(actualPdb);
            var expectedXml = XElement.Parse(expectedPdb);

            if (actualIsPortable)
            {
                // Windows SymWriter doesn't serialize empty scopes.
                // In Portable PDB each method with a body (even with no locals) has a scope that points to the imports. Such scope appears as empty
                // in the current XML representation. 
                RemoveEmptyScopes(actualXml);

                // Remove elements that are never present in Portable PDB.
                RemoveNonPortableElements(expectedXml);
            }

            if (actualIsPortable)
            {
                RemoveElementsWithSpecifiedFormat(expectedXml, "windows");
            }
            else
            {
                RemoveElementsWithSpecifiedFormat(expectedXml, "portable");
            }

            RemoveEmptySequencePoints(expectedXml);
            RemoveEmptyScopes(expectedXml);
            RemoveEmptyCustomDebugInfo(expectedXml);
            RemoveEmptyMethods(expectedXml);
            RemoveFormatAttributes(expectedXml);

            return (actualXml.ToString(), expectedXml.ToString());
        }

        private static bool RemoveElements(IEnumerable<XElement> elements)
        {
            var array = elements.ToArray();

            foreach (var e in array)
            {
                e.Remove();
            }

            return array.Length > 0;
        }

        private static void RemoveEmptyCustomDebugInfo(XElement pdb)
        {
            RemoveElements(from e in pdb.DescendantsAndSelf()
                           where e.Name == "customDebugInfo" && !e.HasElements
                           select e);
        }

        private static void RemoveEmptyScopes(XElement pdb)
        {
            while (RemoveElements(from e in pdb.DescendantsAndSelf()
                                  where e.Name == "scope" && !e.HasElements
                                  select e))
                ;
        }

        private static void RemoveEmptySequencePoints(XElement pdb)
        {
            RemoveElements(from e in pdb.DescendantsAndSelf()
                           where e.Name == "sequencePoints" && !e.HasElements
                           select e);
        }

        private static void RemoveEmptyMethods(XElement pdb)
        {
            RemoveElements(from e in pdb.DescendantsAndSelf()
                           where e.Name == "method" && !e.HasElements
                           select e);
        }

        private static void RemoveNonPortableElements(XElement expectedNativePdb)
        {
            // The following elements are never present in Portable PDB.
            RemoveElements(from e in expectedNativePdb.DescendantsAndSelf()
                           where e.Name == "forwardIterator" ||
                                 e.Name == "forwardToModule" ||
                                 e.Name == "forward" ||
                                 e.Name == "tupleElementNames" ||
                                 e.Name == "dynamicLocals" ||
                                 e.Name == "using" ||
                                 e.Name == "currentnamespace" ||
                                 e.Name == "defaultnamespace" ||
                                 e.Name == "importsforward" ||
                                 e.Name == "xmlnamespace" ||
                                 e.Name == "alias" ||
                                 e.Name == "namespace" ||
                                 e.Name == "type" ||
                                 e.Name == "extern" ||
                                 e.Name == "externinfo" ||
                                 e.Name == "defunct" ||
                                 e.Name == "local" && e.Attributes().Any(a => a.Name.LocalName == "name" && a.Value.StartsWith("$VB$ResumableLocal_"))
                           select e);
        }

        private static void RemoveElementsWithSpecifiedFormat(XElement expectedNativePdb, string format)
        {
            RemoveElements(from e in expectedNativePdb.DescendantsAndSelf()
                           where e.Attributes().Any(a => a.Name.LocalName == "format" && a.Value == format)
                           select e);
        }

        private static void RemoveFormatAttributes(XElement pdb)
        {
            foreach (var element in pdb.DescendantsAndSelf())
            {
                element.Attributes().FirstOrDefault(a => a.Name.LocalName == "format")?.Remove();
            }
        }

        internal static string GetPdbXml(
            Compilation compilation,
            IEnumerable<EmbeddedText> embeddedTexts = null,
            IMethodSymbol debugEntryPoint = null,
            PdbValidationOptions options = PdbValidationOptions.Default,
            string qualifiedMethodName = "",
            bool portable = true)
        {
            var peStream = new MemoryStream();
            var pdbStream = new MemoryStream();
            EmitWithPdb(peStream, pdbStream, compilation, debugEntryPoint, embeddedTexts, portable);

            pdbStream.Position = 0;
            peStream.Position = 0;
            return PdbToXmlConverter.ToXml(pdbStream, peStream, options.ToPdbToXmlOptions(), methodName: qualifiedMethodName);
        }

        private static void EmitWithPdb(MemoryStream peStream, MemoryStream pdbStream, Compilation compilation, IMethodSymbol debugEntryPoint, IEnumerable<EmbeddedText> embeddedTexts, bool portable)
        {
            var emitOptions = EmitOptions.Default.WithDebugInformationFormat(portable ? DebugInformationFormat.PortablePdb : DebugInformationFormat.Pdb);

            var result = compilation.Emit(
                peStream,
                pdbStream,
                debugEntryPoint: debugEntryPoint,
                options: emitOptions,
                embeddedTexts: embeddedTexts);

            result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).Verify();
            ValidateDebugDirectory(peStream, portable ? pdbStream : null, compilation.AssemblyName + ".pdb", emitOptions.PdbChecksumAlgorithm, hasEmbeddedPdb: false, isDeterministic: compilation.IsEmitDeterministic);
        }

        public static unsafe byte[] GetSourceLinkData(Stream pdbStream)
        {
            pdbStream.Position = 0;

            var symReader = SymReaderFactory.CreateReader(pdbStream);
            try
            {
                Marshal.ThrowExceptionForHR(symReader.GetSourceServerData(out byte* data, out int size));
                if (size == 0)
                {
                    return Array.Empty<byte>();
                }

                var result = new byte[size];
                Marshal.Copy((IntPtr)data, result, 0, result.Length);
                return result;
            }
            finally
            {
                symReader.Dispose();
            }
        }

        public static void ValidateDebugDirectory(Stream peStream, Stream portablePdbStreamOpt, string pdbPath, HashAlgorithmName hashAlgorithm, bool hasEmbeddedPdb, bool isDeterministic)
        {
            peStream.Position = 0;

            var peReader = new PEReader(peStream);
            var entries = peReader.ReadDebugDirectory();
            int entryIndex = 0;

            var codeViewEntry = entries[entryIndex++];

            CustomAssert.Equal((portablePdbStreamOpt != null) ? 0x0100 : 0, codeViewEntry.MajorVersion);
            CustomAssert.Equal((portablePdbStreamOpt != null) ? 0x504d : 0, codeViewEntry.MinorVersion);
            var codeViewData = peReader.ReadCodeViewDebugDirectoryData(codeViewEntry);

            CustomAssert.Equal(1, codeViewData.Age);
            CustomAssert.Equal(pdbPath, codeViewData.Path);

            // CodeView data: 
            //  4B "RSDS"
            // 16B Guid
            //  4B Age
            //     NUL-terminated path
            int paddedPathLength = codeViewEntry.DataSize - 24;

            if (isDeterministic)
            {
                CustomAssert.Equal(Encoding.UTF8.GetByteCount(pdbPath) + 1, paddedPathLength);
            }
            else
            {
                CustomAssert.True(paddedPathLength >= 260, "Path should be at least MAX_PATH long");
            }

            if (portablePdbStreamOpt != null)
            {
                portablePdbStreamOpt.Position = 0;

                using (var provider = MetadataReaderProvider.FromPortablePdbStream(portablePdbStreamOpt, MetadataStreamOptions.LeaveOpen))
                {
                    var pdbReader = provider.GetMetadataReader();
                    ValidatePortablePdbId(pdbReader, codeViewEntry.Stamp, codeViewData.Guid);
                }
            }

            if ((portablePdbStreamOpt != null || hasEmbeddedPdb) && hashAlgorithm.Name != null)
            {
                var entry = entries[entryIndex++];

                var pdbChecksumData = peReader.ReadPdbChecksumDebugDirectoryData(entry);
                CustomAssert.Equal(hashAlgorithm.Name, pdbChecksumData.AlgorithmName);

                // TODO: validate hash
            }

            if (isDeterministic)
            {
                var entry = entries[entryIndex++];
                CustomAssert.Equal(0, entry.MinorVersion);
                CustomAssert.Equal(0, entry.MajorVersion);
                CustomAssert.Equal(0U, entry.Stamp);
                CustomAssert.Equal(DebugDirectoryEntryType.Reproducible, entry.Type);
                CustomAssert.Equal(0, entry.DataPointer);
                CustomAssert.Equal(0, entry.DataRelativeVirtualAddress);
                CustomAssert.Equal(0, entry.DataSize);
            }

            if (hasEmbeddedPdb)
            {
                var entry = entries[entryIndex++];
                using (var provider = peReader.ReadEmbeddedPortablePdbDebugDirectoryData(entry))
                {
                    ValidatePortablePdbId(provider.GetMetadataReader(), codeViewEntry.Stamp, codeViewData.Guid);
                }
            }

            CustomAssert.Equal(entries.Length, entryIndex);
        }

        private static unsafe void ValidatePortablePdbId(MetadataReader pdbReader, uint stampInDebugDirectory, Guid guidInDebugDirectory)
        {
            var expectedId = new BlobContentId(guidInDebugDirectory, stampInDebugDirectory);
            var actualId = new BlobContentId(pdbReader.DebugMetadataHeader.Id);
            CustomAssert.Equal(expectedId, actualId);
        }

        internal static void VerifyPdbLambdasAndClosures(this Compilation compilation, SourceWithMarkedNodes source)
        {
            var pdb = GetPdbXml(compilation);
            var pdbXml = XElement.Parse(pdb);

            // We need to get the method start index from the input source, as its not in the PDB
            var methodStartTags = source.MarkedSpans.WhereAsArray(s => s.TagName == "M");
            CustomAssert.True(methodStartTags.Length == 1, "There must be one and only one method start tag per test input.");
            var methodStart = methodStartTags[0].MatchedSpan.Start;

            // Calculate the expected tags for closures
            var expectedTags = pdbXml.DescendantsAndSelf("closure").Select((c, i) => new { Tag = $"<C:{i}>", StartIndex = methodStart + int.Parse(c.Attribute("offset").Value) }).ToList();

            // Add the expected tags for lambdas
            expectedTags.AddRange(pdbXml.DescendantsAndSelf("lambda").Select((c, i) => new { Tag = $"<L:{i}.{int.Parse(c.Attribute("closure").Value)}>", StartIndex = methodStart + int.Parse(c.Attribute("offset").Value) }));

            // Order by start index so they line up nicely
            expectedTags.Sort((x, y) => x.StartIndex.CompareTo(y.StartIndex));

            // Ensure the tag for the method start is the first element
            expectedTags.Insert(0, new { Tag = "<M>", StartIndex = methodStart });

            // Now reverse the list so we can insert without worrying about offsets
            expectedTags.Reverse();

            var expected = source.Source;

            foreach (var tag in expectedTags)
            {
                expected = expected.Insert(tag.StartIndex, tag.Tag);
            }

            AssertEx.EqualOrDiff(expected, source.Input);
        }
    }
}

