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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 1068, 1772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 1588, 1731);

                f_24006_1588_1730(f_24006_1588_1608(verifier), expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 1745, 1761);

                return verifier;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 1068, 1772);

                Microsoft.CodeAnalysis.Compilation
                f_24006_1588_1608(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 1588, 1608);
                    return return_v;
                }


                int
                f_24006_1588_1730(Microsoft.CodeAnalysis.Compilation
                compilation, System.Xml.Linq.XElement
                expectedPdb, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options, int
                expectedValueSourceLine, string
                expectedValueSourcePath)
                {
                    compilation.VerifyPdb(expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 1588, 1730);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 1068, 1772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 1068, 1772);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 1784, 2486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 2302, 2445);

                f_24006_2302_2444(f_24006_2302_2322(verifier), expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 2459, 2475);

                return verifier;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 1784, 2486);

                Microsoft.CodeAnalysis.Compilation
                f_24006_2302_2322(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 2302, 2322);
                    return return_v;
                }


                bool
                f_24006_2302_2444(Microsoft.CodeAnalysis.Compilation
                compilation, string
                expectedPdb, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options, int
                expectedValueSourceLine, string
                expectedValueSourcePath)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 2302, 2444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 1784, 2486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 1784, 2486);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 2498, 3262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 3057, 3221);

                f_24006_3057_3220(f_24006_3057_3077(verifier), qualifiedMethodName, expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 3235, 3251);

                return verifier;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 2498, 3262);

                Microsoft.CodeAnalysis.Compilation
                f_24006_3057_3077(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 3057, 3077);
                    return return_v;
                }


                bool
                f_24006_3057_3220(Microsoft.CodeAnalysis.Compilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options, int
                expectedValueSourceLine, string
                expectedValueSourcePath)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 3057, 3220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 2498, 3262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 2498, 3262);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 3274, 4040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 3835, 3999);

                f_24006_3835_3998(f_24006_3835_3855(verifier), qualifiedMethodName, expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 4013, 4029);

                return verifier;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 3274, 4040);

                Microsoft.CodeAnalysis.Compilation
                f_24006_3835_3855(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 3835, 3855);
                    return return_v;
                }


                int
                f_24006_3835_3998(Microsoft.CodeAnalysis.Compilation
                compilation, string
                qualifiedMethodName, System.Xml.Linq.XElement
                expectedPdb, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options, int
                expectedValueSourceLine, string
                expectedValueSourcePath)
                {
                    compilation.VerifyPdb(qualifiedMethodName, expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 3835, 3998);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 3274, 4040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 3274, 4040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void VerifyPdb(this CompilationDifference diff, IEnumerable<MethodDefinitionHandle> methodHandles, string expectedPdb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 4052, 4304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 4209, 4293);

                f_24006_4209_4292(diff, f_24006_4225_4278(methodHandles, h => MetadataTokens.GetToken(h)), expectedPdb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 4052, 4304);

                System.Collections.Generic.IEnumerable<int>
                f_24006_4225_4278(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MethodDefinitionHandle>
                source, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, int>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.MethodDefinitionHandle, int>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 4225, 4278);
                    return return_v;
                }


                int
                f_24006_4209_4292(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                diff, System.Collections.Generic.IEnumerable<int>
                methodTokens, string
                expectedPdb)
                {
                    diff.VerifyPdb(methodTokens, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 4209, 4292);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 4052, 4304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 4052, 4304);
            }
        }

        public static void VerifyPdb(this CompilationDifference diff, IEnumerable<MethodDefinitionHandle> methodHandles, XElement expectedPdb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 4316, 4570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 4475, 4559);

                f_24006_4475_4558(diff, f_24006_4491_4544(methodHandles, h => MetadataTokens.GetToken(h)), expectedPdb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 4316, 4570);

                System.Collections.Generic.IEnumerable<int>
                f_24006_4491_4544(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MethodDefinitionHandle>
                source, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, int>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.MethodDefinitionHandle, int>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 4491, 4544);
                    return return_v;
                }


                int
                f_24006_4475_4558(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                diff, System.Collections.Generic.IEnumerable<int>
                methodTokens, System.Xml.Linq.XElement
                expectedPdb)
                {
                    diff.VerifyPdb(methodTokens, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 4475, 4558);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 4316, 4570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 4316, 4570);
            }
        }

        public static void VerifyPdb(
                    this CompilationDifference diff,
                    IEnumerable<int> methodTokens,
                    string expectedPdb,
                    DebugInformationFormat format = DebugInformationFormat.Pdb,
                    [CallerLineNumber] int expectedValueSourceLine = 0,
                    [CallerFilePath] string expectedValueSourcePath = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 4582, 5107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 4966, 5096);

                f_24006_4966_5095(diff, methodTokens, expectedPdb, format, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 4582, 5107);

                int
                f_24006_4966_5095(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                diff, System.Collections.Generic.IEnumerable<int>
                methodTokens, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, int
                expectedValueSourceLine, string
                expectedValueSourcePath, bool
                expectedIsXmlLiteral)
                {
                    diff.VerifyPdb(methodTokens, expectedPdb, format, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral: expectedIsXmlLiteral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 4966, 5095);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 4582, 5107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 4582, 5107);
            }
        }

        public static void VerifyPdb(
                    this CompilationDifference diff,
                    IEnumerable<int> methodTokens,
                    XElement expectedPdb,
                    DebugInformationFormat format = DebugInformationFormat.Pdb,
                    [CallerLineNumber] int expectedValueSourceLine = 0,
                    [CallerFilePath] string expectedValueSourcePath = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 5119, 5656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 5505, 5645);

                f_24006_5505_5644(diff, methodTokens, f_24006_5535_5557(expectedPdb), format, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 5119, 5656);

                string
                f_24006_5535_5557(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 5535, 5557);
                    return return_v;
                }


                int
                f_24006_5505_5644(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                diff, System.Collections.Generic.IEnumerable<int>
                methodTokens, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, int
                expectedValueSourceLine, string
                expectedValueSourcePath, bool
                expectedIsXmlLiteral)
                {
                    diff.VerifyPdb(methodTokens, expectedPdb, format, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral: expectedIsXmlLiteral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 5505, 5644);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 5119, 5656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 5119, 5656);
            }
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 5668, 6764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 6017, 6080);

                f_24006_6017_6079(default(DebugInformationFormat), format);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 6094, 6157);

                f_24006_6094_6156(DebugInformationFormat.Embedded, format);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 6173, 6280);

                string
                actualPdb = f_24006_6192_6279(f_24006_6224_6264(diff.PdbDelta), methodTokens)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 6294, 6457);

                var (actual, expected) = f_24006_6319_6456(actualPdb, expectedPdb, actualIsPortable: f_24006_6379_6414(f_24006_6379_6398(diff)).HasPortablePdb, actualIsConverted: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 6473, 6753);

                f_24006_6473_6752(expected, actual, $"PDB format: {format}{f_24006_6592_6611()}", expectedValueSourcePath, expectedValueSourceLine, escapeQuotes: !expectedIsXmlLiteral);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 5668, 6764);

                bool
                f_24006_6017_6079(Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                expected, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 6017, 6079);
                    return return_v;
                }


                bool
                f_24006_6094_6156(Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                expected, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 6094, 6156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Collections.ImmutableMemoryStream
                f_24006_6224_6264(System.Collections.Immutable.ImmutableArray<byte>
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.Collections.ImmutableMemoryStream(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 6224, 6264);
                    return return_v;
                }


                string
                f_24006_6192_6279(Microsoft.CodeAnalysis.Collections.ImmutableMemoryStream
                deltaPdb, System.Collections.Generic.IEnumerable<int>
                methodTokens)
                {
                    var return_v = PdbToXmlConverter.DeltaPdbToXml((System.IO.Stream)deltaPdb, methodTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 6192, 6279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_24006_6379_6398(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                this_param)
                {
                    var return_v = this_param.NextGeneration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 6379, 6398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_24006_6379_6414(Microsoft.CodeAnalysis.Emit.EmitBaseline
                this_param)
                {
                    var return_v = this_param.InitialBaseline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 6379, 6414);
                    return return_v;
                }


                (string Actual, string Expected)
                f_24006_6319_6456(string
                actualPdb, string
                expectedPdb, bool
                actualIsPortable, bool
                actualIsConverted)
                {
                    var return_v = AdjustToPdbFormat(actualPdb, expectedPdb, actualIsPortable: actualIsPortable, actualIsConverted: actualIsConverted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 6319, 6456);
                    return return_v;
                }


                string
                f_24006_6592_6611()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 6592, 6611);
                    return return_v;
                }


                bool
                f_24006_6473_6752(string
                expected, string
                actual, string
                message, string
                expectedValueSourcePath, int
                expectedValueSourceLine, bool
                escapeQuotes)
                {
                    var return_v = AssertEx.AssertLinesEqual(expected, actual, message, expectedValueSourcePath, expectedValueSourceLine, escapeQuotes: escapeQuotes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 6473, 6752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 5668, 6764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 5668, 6764);
            }
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 6776, 7431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 7274, 7420);

                return f_24006_7281_7419(compilation, "", expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 6776, 7431);

                bool
                f_24006_7281_7419(Microsoft.CodeAnalysis.Compilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options, int
                expectedValueSourceLine, string
                expectedValueSourcePath)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 7281, 7419);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 6776, 7431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 6776, 7431);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 7443, 8425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 7982, 8414);

                return f_24006_7989_8413(compilation, embeddedTexts, debugEntryPoint, qualifiedMethodName, (DynAbs.Tracing.TraceSender.Conditional_F1(24006, 8155, 8193) || ((f_24006_8155_8193(expectedPdb) && DynAbs.Tracing.TraceSender.Conditional_F2(24006, 8196, 8217)) || DynAbs.Tracing.TraceSender.Conditional_F3(24006, 8220, 8231))) ? "<symbols></symbols>" : expectedPdb, format, options, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 7443, 8425);

                bool
                f_24006_8155_8193(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 8155, 8193);
                    return return_v;
                }


                bool
                f_24006_7989_8413(Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, string
                qualifiedMethodName, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options, int
                expectedValueSourceLine, string
                expectedValueSourcePath, bool
                expectedIsXmlLiteral)
                {
                    var return_v = compilation.VerifyPdbImpl(embeddedTexts, debugEntryPoint, qualifiedMethodName, expectedPdb, format, options, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral: expectedIsXmlLiteral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 7989, 8413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 7443, 8425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 7443, 8425);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 8437, 9087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 8937, 9076);

                f_24006_8937_9075(compilation, "", expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 8437, 9087);

                int
                f_24006_8937_9075(Microsoft.CodeAnalysis.Compilation
                compilation, string
                qualifiedMethodName, System.Xml.Linq.XElement
                expectedPdb, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options, int
                expectedValueSourceLine, string
                expectedValueSourcePath)
                {
                    compilation.VerifyPdb(qualifiedMethodName, expectedPdb, embeddedTexts, debugEntryPoint, format, options, expectedValueSourceLine, expectedValueSourcePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 8937, 9075);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 8437, 9087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 8437, 9087);
            }
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 9099, 10021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 9640, 10010);

                f_24006_9640_10009(compilation, embeddedTexts, debugEntryPoint, qualifiedMethodName, f_24006_9806_9828(expectedPdb), format, options, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 9099, 10021);

                string
                f_24006_9806_9828(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 9806, 9828);
                    return return_v;
                }


                bool
                f_24006_9640_10009(Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, string
                qualifiedMethodName, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options, int
                expectedValueSourceLine, string
                expectedValueSourcePath, bool
                expectedIsXmlLiteral)
                {
                    var return_v = compilation.VerifyPdbImpl(embeddedTexts, debugEntryPoint, qualifiedMethodName, expectedPdb, format, options, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral: expectedIsXmlLiteral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 9640, 10009);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 9099, 10021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 9099, 10021);
            }
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 10033, 14157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 10521, 10584);

                f_24006_10521_10583(DebugInformationFormat.Embedded, format);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 10600, 10712);

                bool
                testWindowsPdb = (format == 0 || (DynAbs.Tracing.TraceSender.Expression_False(24006, 10623, 10674) || format == DebugInformationFormat.Pdb)) && (DynAbs.Tracing.TraceSender.Expression_True(24006, 10622, 10711) && f_24006_10679_10711())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 10726, 10809);

                bool
                testPortablePdb = format == 0 || (DynAbs.Tracing.TraceSender.Expression_False(24006, 10749, 10808) || format == DebugInformationFormat.PortablePdb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 10823, 10908);

                bool
                testConversion = (options & PdbValidationOptions.SkipConversionValidation) == 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 10922, 10972);

                var
                pdbToXmlOptions = f_24006_10944_10971(options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 11011, 11031);

                var
                toReturn = true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 11047, 11352) || true) && (testWindowsPdb)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 11047, 11352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 11099, 11337);

                    toReturn = toReturn && (DynAbs.Tracing.TraceSender.Expression_True(24006, 11110, 11336) && f_24006_11122_11336(false, testPortablePdb, compilation, embeddedTexts, debugEntryPoint, qualifiedMethodName, expectedPdb, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral, testConversion, pdbToXmlOptions));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 11047, 11352);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 11368, 11672) || true) && (testPortablePdb)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 11368, 11672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 11421, 11657);

                    toReturn = toReturn && (DynAbs.Tracing.TraceSender.Expression_True(24006, 11432, 11656) && f_24006_11444_11656(true, testWindowsPdb, compilation, embeddedTexts, debugEntryPoint, qualifiedMethodName, expectedPdb, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral, testConversion, pdbToXmlOptions));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 11368, 11672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 11688, 11704);

                return toReturn;

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
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(24006, 12791, 14146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 13349, 13383);

                        var
                        peStream = f_24006_13364_13382()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 13401, 13436);

                        var
                        pdbStream = f_24006_13417_13435()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 13454, 13544);

                        f_24006_13454_13543(peStream, pdbStream, compilation, debugEntryPoint, embeddedTexts, isPortable);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 13564, 13584);

                        var
                        toReturn = true
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 13604, 13811);

                        toReturn = toReturn && (DynAbs.Tracing.TraceSender.Expression_True(24006, 13615, 13810) && f_24006_13627_13810(peStream, pdbStream, qualifiedMethodName, pdbToXmlOptions, expectedPdb, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral, isPortable));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 13831, 14095) || true) && (testConversion && (DynAbs.Tracing.TraceSender.Expression_True(24006, 13835, 13868) && testOtherFormat))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 13831, 14095);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 13910, 14076);

                            toReturn = toReturn && (DynAbs.Tracing.TraceSender.Expression_True(24006, 13921, 14075) && f_24006_13933_14075(peStream, pdbStream, qualifiedMethodName, expectedPdb, pdbToXmlOptions, expectedIsXmlLiteral, isPortable));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 13831, 14095);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 14115, 14131);

                        return toReturn;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(24006, 12791, 14146);

                        System.IO.MemoryStream
                        f_24006_13364_13382()
                        {
                            var return_v = new System.IO.MemoryStream();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 13364, 13382);
                            return return_v;
                        }


                        System.IO.MemoryStream
                        f_24006_13417_13435()
                        {
                            var return_v = new System.IO.MemoryStream();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 13417, 13435);
                            return return_v;
                        }


                        int
                        f_24006_13454_13543(System.IO.MemoryStream
                        peStream, System.IO.MemoryStream
                        pdbStream, Microsoft.CodeAnalysis.Compilation
                        compilation, Microsoft.CodeAnalysis.IMethodSymbol
                        debugEntryPoint, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>
                        embeddedTexts, bool
                        portable)
                        {
                            EmitWithPdb(peStream, pdbStream, compilation, debugEntryPoint, embeddedTexts, portable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 13454, 13543);
                            return 0;
                        }


                        bool
                        f_24006_13627_13810(System.IO.MemoryStream
                        peStream, System.IO.MemoryStream
                        pdbStream, string
                        qualifiedMethodName, Microsoft.DiaSymReader.Tools.PdbToXmlOptions
                        pdbToXmlOptions, string
                        expectedPdb, int
                        expectedValueSourceLine, string
                        expectedValueSourcePath, bool
                        expectedIsXmlLiteral, bool
                        isPortable)
                        {
                            var return_v = VerifyPdbMatchesExpectedXml((System.IO.Stream)peStream, (System.IO.Stream)pdbStream, qualifiedMethodName, pdbToXmlOptions, expectedPdb, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral, isPortable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 13627, 13810);
                            return return_v;
                        }


                        bool
                        f_24006_13933_14075(System.IO.MemoryStream
                        peStreamOriginal, System.IO.MemoryStream
                        pdbStreamOriginal, string
                        qualifiedMethodName, string
                        expectedPdb, Microsoft.DiaSymReader.Tools.PdbToXmlOptions
                        pdbToXmlOptions, bool
                        expectedIsXmlLiteral, bool
                        originalIsPortable)
                        {
                            var return_v = VerifyConvertedPdbMatchesExpectedXml((System.IO.Stream)peStreamOriginal, (System.IO.Stream)pdbStreamOriginal, qualifiedMethodName, expectedPdb, pdbToXmlOptions, expectedIsXmlLiteral, originalIsPortable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 13933, 14075);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 12791, 14146);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 12791, 14146);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 10033, 14157);

                bool
                f_24006_10521_10583(Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                expected, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 10521, 10583);
                    return return_v;
                }


                bool
                f_24006_10679_10711()
                {
                    var return_v = ExecutionConditionUtil.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 10679, 10711);
                    return return_v;
                }


                Microsoft.DiaSymReader.Tools.PdbToXmlOptions
                f_24006_10944_10971(Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options)
                {
                    var return_v = options.ToPdbToXmlOptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 10944, 10971);
                    return return_v;
                }


                bool
                f_24006_11122_11336(bool
                isPortable, bool
                testOtherFormat, Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>
                embeddedTexts, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint, string
                qualifiedMethodName, string
                expectedPdb, int
                expectedValueSourceLine, string
                expectedValueSourcePath, bool
                expectedIsXmlLiteral, bool
                testConversion, Microsoft.DiaSymReader.Tools.PdbToXmlOptions
                pdbToXmlOptions)
                {
                    var return_v = Verify(isPortable, testOtherFormat, compilation, embeddedTexts, debugEntryPoint, qualifiedMethodName, expectedPdb, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral, testConversion, pdbToXmlOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 11122, 11336);
                    return return_v;
                }


                bool
                f_24006_11444_11656(bool
                isPortable, bool
                testOtherFormat, Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>
                embeddedTexts, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint, string
                qualifiedMethodName, string
                expectedPdb, int
                expectedValueSourceLine, string
                expectedValueSourcePath, bool
                expectedIsXmlLiteral, bool
                testConversion, Microsoft.DiaSymReader.Tools.PdbToXmlOptions
                pdbToXmlOptions)
                {
                    var return_v = Verify(isPortable, testOtherFormat, compilation, embeddedTexts, debugEntryPoint, qualifiedMethodName, expectedPdb, expectedValueSourceLine, expectedValueSourcePath, expectedIsXmlLiteral, testConversion, pdbToXmlOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 11444, 11656);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 10033, 14157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 10033, 14157);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 14169, 15273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 14580, 14602);

                peStream.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 14616, 14639);

                pdbStream.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 14653, 14791);

                var
                actualPdb = f_24006_14669_14790(f_24006_14669_14779(f_24006_14684_14778(pdbStream, peStream, pdbToXmlOptions, methodName: qualifiedMethodName)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 14805, 14928);

                var (actual, expected) = f_24006_14830_14927(actualPdb, expectedPdb, actualIsPortable: isPortable, actualIsConverted: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 14944, 15262);

                return f_24006_14951_15261(expected, actual, $"PDB format: {((DynAbs.Tracing.TraceSender.Conditional_F1(24006, 15063, 15073) || ((isPortable && DynAbs.Tracing.TraceSender.Conditional_F2(24006, 15076, 15086)) || DynAbs.Tracing.TraceSender.Conditional_F3(24006, 15089, 15098))) ? "Portable" : "Windows")}{f_24006_15101_15120()}", expectedValueSourcePath, expectedValueSourceLine, escapeQuotes: !expectedIsXmlLiteral);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 14169, 15273);

                string
                f_24006_14684_14778(System.IO.Stream
                pdbStream, System.IO.Stream
                peStream, Microsoft.DiaSymReader.Tools.PdbToXmlOptions
                options, string
                methodName)
                {
                    var return_v = PdbToXmlConverter.ToXml(pdbStream, peStream, options, methodName: methodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 14684, 14778);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_24006_14669_14779(string
                text)
                {
                    var return_v = XElement.Parse(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 14669, 14779);
                    return return_v;
                }


                string
                f_24006_14669_14790(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 14669, 14790);
                    return return_v;
                }


                (string Actual, string Expected)
                f_24006_14830_14927(string
                actualPdb, string
                expectedPdb, bool
                actualIsPortable, bool
                actualIsConverted)
                {
                    var return_v = AdjustToPdbFormat(actualPdb, expectedPdb, actualIsPortable: actualIsPortable, actualIsConverted: actualIsConverted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 14830, 14927);
                    return return_v;
                }


                string
                f_24006_15101_15120()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 15101, 15120);
                    return return_v;
                }


                bool
                f_24006_14951_15261(string
                expected, string
                actual, string
                message, string
                expectedValueSourcePath, int
                expectedValueSourceLine, bool
                escapeQuotes)
                {
                    var return_v = AssertEx.AssertLinesEqual(expected, actual, message, expectedValueSourcePath, expectedValueSourceLine, escapeQuotes: escapeQuotes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 14951, 15261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 14169, 15273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 14169, 15273);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 15285, 17185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 15642, 15686);

                var
                pdbStreamConverted = f_24006_15667_15685()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 15700, 15796);

                var
                converter = f_24006_15716_15795(diagnostic => CustomAssert.True(false, diagnostic.ToString()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 15812, 15842);

                peStreamOriginal.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 15856, 15887);

                pdbStreamOriginal.Position = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 15903, 16224) || true) && (originalIsPortable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 15903, 16224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 15959, 16051);

                    f_24006_15959_16050(converter, peStreamOriginal, pdbStreamOriginal, pdbStreamConverted);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 15903, 16224);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 15903, 16224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 16117, 16209);

                    f_24006_16117_16208(converter, peStreamOriginal, pdbStreamOriginal, pdbStreamConverted);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 15903, 16224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 16240, 16272);

                pdbStreamConverted.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 16286, 16316);

                peStreamOriginal.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 16332, 16523);

                var
                actualConverted = f_24006_16354_16522(f_24006_16383_16521(f_24006_16383_16510(f_24006_16398_16509(pdbStreamConverted, peStreamOriginal, pdbToXmlOptions, methodName: qualifiedMethodName))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 16537, 16602);

                var
                adjustedExpected = f_24006_16560_16601(expectedPdb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 16618, 16760);

                var (actual, expected) = f_24006_16643_16759(actualConverted, adjustedExpected, actualIsPortable: !originalIsPortable, actualIsConverted: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 16776, 17174);

                return f_24006_16783_17173(expected, actual, $"PDB format: {((DynAbs.Tracing.TraceSender.Conditional_F1(24006, 16895, 16913) || ((originalIsPortable && DynAbs.Tracing.TraceSender.Conditional_F2(24006, 16916, 16925)) || DynAbs.Tracing.TraceSender.Conditional_F3(24006, 16928, 16938))) ? "Windows" : "Portable")} converted from {((DynAbs.Tracing.TraceSender.Conditional_F1(24006, 16958, 16976) || ((originalIsPortable && DynAbs.Tracing.TraceSender.Conditional_F2(24006, 16979, 16989)) || DynAbs.Tracing.TraceSender.Conditional_F3(24006, 16992, 17001))) ? "Portable" : "Windows")}{f_24006_17004_17023()}", expectedValueSourcePath: null, expectedValueSourceLine: 0, escapeQuotes: !expectedIsXmlLiteral);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 15285, 17185);

                System.IO.MemoryStream
                f_24006_15667_15685()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 15667, 15685);
                    return return_v;
                }


                Microsoft.DiaSymReader.Tools.PdbConverter
                f_24006_15716_15795(System.Action<Microsoft.DiaSymReader.Tools.PdbDiagnostic>
                diagnosticReporter)
                {
                    var return_v = new Microsoft.DiaSymReader.Tools.PdbConverter(diagnosticReporter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 15716, 15795);
                    return return_v;
                }


                int
                f_24006_15959_16050(Microsoft.DiaSymReader.Tools.PdbConverter
                this_param, System.IO.Stream
                peStream, System.IO.Stream
                sourcePdbStream, System.IO.MemoryStream
                targetPdbStream)
                {
                    this_param.ConvertPortableToWindows(peStream, sourcePdbStream, (System.IO.Stream)targetPdbStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 15959, 16050);
                    return 0;
                }


                int
                f_24006_16117_16208(Microsoft.DiaSymReader.Tools.PdbConverter
                this_param, System.IO.Stream
                peStream, System.IO.Stream
                sourcePdbStream, System.IO.MemoryStream
                targetPdbStream)
                {
                    this_param.ConvertWindowsToPortable(peStream, sourcePdbStream, (System.IO.Stream)targetPdbStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 16117, 16208);
                    return 0;
                }


                string
                f_24006_16398_16509(System.IO.MemoryStream
                pdbStream, System.IO.Stream
                peStream, Microsoft.DiaSymReader.Tools.PdbToXmlOptions
                options, string
                methodName)
                {
                    var return_v = PdbToXmlConverter.ToXml((System.IO.Stream)pdbStream, peStream, options, methodName: methodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 16398, 16509);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_24006_16383_16510(string
                text)
                {
                    var return_v = XElement.Parse(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 16383, 16510);
                    return return_v;
                }


                string
                f_24006_16383_16521(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 16383, 16521);
                    return return_v;
                }


                string
                f_24006_16354_16522(string
                pdb)
                {
                    var return_v = AdjustForConversionArtifacts(pdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 16354, 16522);
                    return return_v;
                }


                string
                f_24006_16560_16601(string
                pdb)
                {
                    var return_v = AdjustForConversionArtifacts(pdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 16560, 16601);
                    return return_v;
                }


                (string Actual, string Expected)
                f_24006_16643_16759(string
                actualPdb, string
                expectedPdb, bool
                actualIsPortable, bool
                actualIsConverted)
                {
                    var return_v = AdjustToPdbFormat(actualPdb, expectedPdb, actualIsPortable: actualIsPortable, actualIsConverted: actualIsConverted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 16643, 16759);
                    return return_v;
                }


                string
                f_24006_17004_17023()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 17004, 17023);
                    return return_v;
                }


                bool
                f_24006_16783_17173(string
                expected, string
                actual, string
                message, string
                expectedValueSourcePath, int
                expectedValueSourceLine, bool
                escapeQuotes)
                {
                    var return_v = AssertEx.AssertLinesEqual(expected, actual, message, expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine, escapeQuotes: escapeQuotes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 16783, 17173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 15285, 17185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 15285, 17185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string AdjustForConversionArtifacts(string pdb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 17197, 18388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 17284, 17314);

                var
                xml = f_24006_17294_17313(pdb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 17328, 17370);

                var
                pendingRemoval = f_24006_17349_17369()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 17384, 18194);
                    foreach (var e in f_24006_17402_17426_I(f_24006_17402_17426(xml)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 17384, 18194);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 17460, 18179) || true) && (f_24006_17464_17470(e) == "constant")
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 17460, 18179);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 17615, 17646);

                            var
                            name = f_24006_17626_17645(e, "name")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 17668, 17689);

                            f_24006_17668_17688(e);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 17711, 17723);

                            f_24006_17711_17722(e, name);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 17460, 18179);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 17460, 18179);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 17765, 18179) || true) && (f_24006_17769_17775(e) == "bucket" && (DynAbs.Tracing.TraceSender.Expression_True(24006, 17769, 17823) && f_24006_17791_17804(f_24006_17791_17799(e)) == "dynamicLocals"))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 17765, 18179);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 17935, 17968);

                                var
                                flags = f_24006_17947_17967(e, "flags")
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 17990, 18031);

                                f_24006_17990_18030(flags, f_24006_18005_18029(f_24006_18005_18016(flags), '0'));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 17765, 18179);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 17765, 18179);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 18073, 18179) || true) && (f_24006_18077_18083(e) == "defunct")
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 18073, 18179);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 18138, 18160);

                                    f_24006_18138_18159(pendingRemoval, e);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 18073, 18179);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 17765, 18179);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 17460, 18179);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 17384, 18194);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24006, 1, 811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24006, 1, 811);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 18210, 18302);
                    foreach (var e in f_24006_18228_18242_I(pendingRemoval))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 18210, 18302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 18276, 18287);

                        f_24006_18276_18286(e);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 18210, 18302);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24006, 1, 93);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24006, 1, 93);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 18318, 18341);

                f_24006_18318_18340(xml);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 18355, 18377);

                return f_24006_18362_18376(xml);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 17197, 18388);

                System.Xml.Linq.XElement
                f_24006_17294_17313(string
                text)
                {
                    var return_v = XElement.Parse(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 17294, 17313);
                    return return_v;
                }


                System.Collections.Generic.List<System.Xml.Linq.XElement>
                f_24006_17349_17369()
                {
                    var return_v = new System.Collections.Generic.List<System.Xml.Linq.XElement>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 17349, 17369);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_24006_17402_17426(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.DescendantsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 17402, 17426);
                    return return_v;
                }


                System.Xml.Linq.XName
                f_24006_17464_17470(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 17464, 17470);
                    return return_v;
                }


                System.Xml.Linq.XAttribute
                f_24006_17626_17645(System.Xml.Linq.XElement
                this_param, string
                name)
                {
                    var return_v = this_param.Attribute((System.Xml.Linq.XName)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 17626, 17645);
                    return return_v;
                }


                int
                f_24006_17668_17688(System.Xml.Linq.XElement
                this_param)
                {
                    this_param.RemoveAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 17668, 17688);
                    return 0;
                }


                int
                f_24006_17711_17722(System.Xml.Linq.XElement
                this_param, System.Xml.Linq.XAttribute
                content)
                {
                    this_param.Add((object)content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 17711, 17722);
                    return 0;
                }


                System.Xml.Linq.XName
                f_24006_17769_17775(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 17769, 17775);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_24006_17791_17799(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 17791, 17799);
                    return return_v;
                }


                System.Xml.Linq.XName
                f_24006_17791_17804(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 17791, 17804);
                    return return_v;
                }


                System.Xml.Linq.XAttribute
                f_24006_17947_17967(System.Xml.Linq.XElement
                this_param, string
                name)
                {
                    var return_v = this_param.Attribute((System.Xml.Linq.XName)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 17947, 17967);
                    return return_v;
                }


                string
                f_24006_18005_18016(System.Xml.Linq.XAttribute
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 18005, 18016);
                    return return_v;
                }


                string
                f_24006_18005_18029(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 18005, 18029);
                    return return_v;
                }


                int
                f_24006_17990_18030(System.Xml.Linq.XAttribute
                this_param, string
                value)
                {
                    this_param.SetValue((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 17990, 18030);
                    return 0;
                }


                System.Xml.Linq.XName
                f_24006_18077_18083(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 18077, 18083);
                    return return_v;
                }


                int
                f_24006_18138_18159(System.Collections.Generic.List<System.Xml.Linq.XElement>
                this_param, System.Xml.Linq.XElement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 18138, 18159);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_24006_17402_17426_I(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 17402, 17426);
                    return return_v;
                }


                int
                f_24006_18276_18286(System.Xml.Linq.XElement
                this_param)
                {
                    this_param.Remove();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 18276, 18286);
                    return 0;
                }


                System.Collections.Generic.List<System.Xml.Linq.XElement>
                f_24006_18228_18242_I(System.Collections.Generic.List<System.Xml.Linq.XElement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 18228, 18242);
                    return return_v;
                }


                int
                f_24006_18318_18340(System.Xml.Linq.XElement
                pdb)
                {
                    RemoveEmptyScopes(pdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 18318, 18340);
                    return 0;
                }


                string
                f_24006_18362_18376(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 18362, 18376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 17197, 18388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 17197, 18388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static (string Actual, string Expected) AdjustToPdbFormat(string actualPdb, string expectedPdb, bool actualIsPortable, bool actualIsConverted)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 18400, 19802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 18576, 18618);

                var
                actualXml = f_24006_18592_18617(actualPdb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 18632, 18678);

                var
                expectedXml = f_24006_18650_18677(expectedPdb)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 18694, 19203) || true) && (actualIsPortable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 18694, 19203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19024, 19053);

                    f_24006_19024_19052(actualXml);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19149, 19188);

                    f_24006_19149_19187(expectedXml);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 18694, 19203);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19219, 19471) || true) && (actualIsPortable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 19219, 19471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19273, 19331);

                    f_24006_19273_19330(expectedXml, "windows");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 19219, 19471);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 19219, 19471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19397, 19456);

                    f_24006_19397_19455(expectedXml, "portable");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 19219, 19471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19487, 19526);

                f_24006_19487_19525(expectedXml);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19540, 19571);

                f_24006_19540_19570(expectedXml);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19585, 19625);

                f_24006_19585_19624(expectedXml);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19639, 19671);

                f_24006_19639_19670(expectedXml);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19685, 19721);

                f_24006_19685_19720(expectedXml);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19737, 19791);

                return (f_24006_19745_19765(actualXml), f_24006_19767_19789(expectedXml));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 18400, 19802);

                System.Xml.Linq.XElement
                f_24006_18592_18617(string
                text)
                {
                    var return_v = XElement.Parse(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 18592, 18617);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_24006_18650_18677(string
                text)
                {
                    var return_v = XElement.Parse(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 18650, 18677);
                    return return_v;
                }


                int
                f_24006_19024_19052(System.Xml.Linq.XElement
                pdb)
                {
                    RemoveEmptyScopes(pdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19024, 19052);
                    return 0;
                }


                int
                f_24006_19149_19187(System.Xml.Linq.XElement
                expectedNativePdb)
                {
                    RemoveNonPortableElements(expectedNativePdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19149, 19187);
                    return 0;
                }


                int
                f_24006_19273_19330(System.Xml.Linq.XElement
                expectedNativePdb, string
                format)
                {
                    RemoveElementsWithSpecifiedFormat(expectedNativePdb, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19273, 19330);
                    return 0;
                }


                int
                f_24006_19397_19455(System.Xml.Linq.XElement
                expectedNativePdb, string
                format)
                {
                    RemoveElementsWithSpecifiedFormat(expectedNativePdb, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19397, 19455);
                    return 0;
                }


                int
                f_24006_19487_19525(System.Xml.Linq.XElement
                pdb)
                {
                    RemoveEmptySequencePoints(pdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19487, 19525);
                    return 0;
                }


                int
                f_24006_19540_19570(System.Xml.Linq.XElement
                pdb)
                {
                    RemoveEmptyScopes(pdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19540, 19570);
                    return 0;
                }


                int
                f_24006_19585_19624(System.Xml.Linq.XElement
                pdb)
                {
                    RemoveEmptyCustomDebugInfo(pdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19585, 19624);
                    return 0;
                }


                int
                f_24006_19639_19670(System.Xml.Linq.XElement
                pdb)
                {
                    RemoveEmptyMethods(pdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19639, 19670);
                    return 0;
                }


                int
                f_24006_19685_19720(System.Xml.Linq.XElement
                pdb)
                {
                    RemoveFormatAttributes(pdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19685, 19720);
                    return 0;
                }


                string
                f_24006_19745_19765(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19745, 19765);
                    return return_v;
                }


                string
                f_24006_19767_19789(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19767, 19789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 18400, 19802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 18400, 19802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool RemoveElements(IEnumerable<XElement> elements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 19814, 20086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19905, 19936);

                var
                array = f_24006_19917_19935(elements)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 19952, 20035);
                    foreach (var e in f_24006_19970_19975_I(array))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 19952, 20035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 20009, 20020);

                        f_24006_20009_20019(e);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 19952, 20035);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24006, 1, 84);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24006, 1, 84);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 20051, 20075);

                return f_24006_20058_20070(array) > 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 19814, 20086);

                System.Xml.Linq.XElement[]
                f_24006_19917_19935(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                source)
                {
                    var return_v = source.ToArray<System.Xml.Linq.XElement>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19917, 19935);
                    return return_v;
                }


                int
                f_24006_20009_20019(System.Xml.Linq.XElement
                this_param)
                {
                    this_param.Remove();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 20009, 20019);
                    return 0;
                }


                System.Xml.Linq.XElement[]
                f_24006_19970_19975_I(System.Xml.Linq.XElement[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 19970, 19975);
                    return return_v;
                }


                int
                f_24006_20058_20070(System.Xml.Linq.XElement[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 20058, 20070);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 19814, 20086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 19814, 20086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void RemoveEmptyCustomDebugInfo(XElement pdb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 20098, 20362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 20183, 20351);

                f_24006_20183_20350(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from e in pdb.DescendantsAndSelf()
                                                                                            where e.Name == "customDebugInfo" && !e.HasElements
                                                                                            select e, 24006, 20198, 20349));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 20098, 20362);

                bool
                f_24006_20183_20350(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                elements)
                {
                    var return_v = RemoveElements(elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 20183, 20350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 20098, 20362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 20098, 20362);
            }
        }

        private static void RemoveEmptyScopes(XElement pdb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 20374, 20659);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 20450, 20648) || true) && (f_24006_20457_20628(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from e in pdb.DescendantsAndSelf()
                                                                                                                                                                                          where e.Name == "scope" && !e.HasElements
                                                                                                                                                                                          select e, 24006, 20472, 20627)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 20450, 20648);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 20647, 20648);
                        ;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 20450, 20648);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24006, 20450, 20648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24006, 20450, 20648);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 20374, 20659);

                bool
                f_24006_20457_20628(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                elements)
                {
                    var return_v = RemoveElements(elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 20457, 20628);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 20374, 20659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 20374, 20659);
            }
        }

        private static void RemoveEmptySequencePoints(XElement pdb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 20671, 20933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 20755, 20922);

                f_24006_20755_20921(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from e in pdb.DescendantsAndSelf()
                                                                                            where e.Name == "sequencePoints" && !e.HasElements
                                                                                            select e, 24006, 20770, 20920));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 20671, 20933);

                bool
                f_24006_20755_20921(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                elements)
                {
                    var return_v = RemoveElements(elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 20755, 20921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 20671, 20933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 20671, 20933);
            }
        }

        private static void RemoveEmptyMethods(XElement pdb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 20945, 21192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 21022, 21181);

                f_24006_21022_21180(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from e in pdb.DescendantsAndSelf()
                                                                                            where e.Name == "method" && !e.HasElements
                                                                                            select e, 24006, 21037, 21179));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 20945, 21192);

                bool
                f_24006_21022_21180(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                elements)
                {
                    var return_v = RemoveElements(elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 21022, 21180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 20945, 21192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 20945, 21192);
            }
        }

        private static void RemoveNonPortableElements(XElement expectedNativePdb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 21204, 22612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 21376, 22601);

                f_24006_21376_22600(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from e in expectedNativePdb.DescendantsAndSelf()
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
                                                                                            select e, 24006, 21391, 22599));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 21204, 22612);

                bool
                f_24006_21376_22600(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                elements)
                {
                    var return_v = RemoveElements(elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 21376, 22600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 21204, 22612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 21204, 22612);
            }
        }

        private static void RemoveElementsWithSpecifiedFormat(XElement expectedNativePdb, string format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 22624, 22967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 22745, 22956);

                f_24006_22745_22955(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from e in expectedNativePdb.DescendantsAndSelf()
                                                                                            where e.Attributes().Any(a => a.Name.LocalName == "format" && a.Value == format)
                                                                                            select e, 24006, 22760, 22954));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 22624, 22967);

                bool
                f_24006_22745_22955(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                elements)
                {
                    var return_v = RemoveElements(elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 22745, 22955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 22624, 22967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 22624, 22967);
            }
        }

        private static void RemoveFormatAttributes(XElement pdb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 22979, 23249);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 23060, 23238);
                    foreach (var element in f_24006_23084_23108_I(f_24006_23084_23108(pdb)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 23060, 23238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 23142, 23223);

                        f_24006_23213_23222(f_24006_23142_23212(f_24006_23142_23162(element), a => a.Name.LocalName == "format"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 23060, 23238);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24006, 1, 179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24006, 1, 179);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 22979, 23249);

                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_24006_23084_23108(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.DescendantsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 23084, 23108);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                f_24006_23142_23162(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Attributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 23142, 23162);
                    return return_v;
                }


                System.Xml.Linq.XAttribute
                f_24006_23142_23212(System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                source, System.Func<System.Xml.Linq.XAttribute, bool>
                predicate)
                {
                    var return_v = source.FirstOrDefault<System.Xml.Linq.XAttribute>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 23142, 23212);
                    return return_v;
                }


                int
                f_24006_23213_23222(System.Xml.Linq.XAttribute
                this_param)
                {
                    this_param?.Remove();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 23213, 23222);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_24006_23084_23108_I(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 23084, 23108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 22979, 23249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 22979, 23249);
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 23261, 24023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 23624, 23658);

                var
                peStream = f_24006_23639_23657()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 23672, 23707);

                var
                pdbStream = f_24006_23688_23706()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 23721, 23809);

                f_24006_23721_23808(peStream, pdbStream, compilation, debugEntryPoint, embeddedTexts, portable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 23825, 23848);

                pdbStream.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 23862, 23884);

                peStream.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 23898, 24012);

                return f_24006_23905_24011(pdbStream, peStream, f_24006_23950_23977(options), methodName: qualifiedMethodName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 23261, 24023);

                System.IO.MemoryStream
                f_24006_23639_23657()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 23639, 23657);
                    return return_v;
                }


                System.IO.MemoryStream
                f_24006_23688_23706()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 23688, 23706);
                    return return_v;
                }


                int
                f_24006_23721_23808(System.IO.MemoryStream
                peStream, System.IO.MemoryStream
                pdbStream, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, bool
                portable)
                {
                    EmitWithPdb(peStream, pdbStream, compilation, debugEntryPoint, embeddedTexts, portable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 23721, 23808);
                    return 0;
                }


                Microsoft.DiaSymReader.Tools.PdbToXmlOptions
                f_24006_23950_23977(Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options)
                {
                    var return_v = options.ToPdbToXmlOptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 23950, 23977);
                    return return_v;
                }


                string
                f_24006_23905_24011(System.IO.MemoryStream
                pdbStream, System.IO.MemoryStream
                peStream, Microsoft.DiaSymReader.Tools.PdbToXmlOptions
                options, string
                methodName)
                {
                    var return_v = PdbToXmlConverter.ToXml((System.IO.Stream)pdbStream, (System.IO.Stream)peStream, options, methodName: methodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 23905, 24011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 23261, 24023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 23261, 24023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void EmitWithPdb(MemoryStream peStream, MemoryStream pdbStream, Compilation compilation, IMethodSymbol debugEntryPoint, IEnumerable<EmbeddedText> embeddedTexts, bool portable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 24035, 24954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 24250, 24391);

                var
                emitOptions = f_24006_24268_24390(EmitOptions.Default, (DynAbs.Tracing.TraceSender.Conditional_F1(24006, 24315, 24323) || ((portable && DynAbs.Tracing.TraceSender.Conditional_F2(24006, 24326, 24360)) || DynAbs.Tracing.TraceSender.Conditional_F3(24006, 24363, 24389))) ? DebugInformationFormat.PortablePdb : DebugInformationFormat.Pdb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 24407, 24630);

                var
                result = f_24006_24420_24629(compilation, peStream, pdbStream, debugEntryPoint: debugEntryPoint, options: emitOptions, embeddedTexts: embeddedTexts)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 24646, 24725);

                f_24006_24646_24724(
                            result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 24739, 24943);

                f_24006_24739_24942(peStream, (DynAbs.Tracing.TraceSender.Conditional_F1(24006, 24772, 24780) || ((portable && DynAbs.Tracing.TraceSender.Conditional_F2(24006, 24783, 24792)) || DynAbs.Tracing.TraceSender.Conditional_F3(24006, 24795, 24799))) ? pdbStream : null, f_24006_24801_24825(compilation) + ".pdb", f_24006_24836_24868(emitOptions), hasEmbeddedPdb: false, isDeterministic: f_24006_24910_24941(compilation));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 24035, 24954);

                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_24006_24268_24390(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = this_param.WithDebugInformationFormat(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 24268, 24390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_24006_24420_24629(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.MemoryStream
                pdbStream, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint, Microsoft.CodeAnalysis.Emit.EmitOptions
                options, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>
                embeddedTexts)
                {
                    var return_v = this_param.Emit((System.IO.Stream)peStream, (System.IO.Stream)pdbStream, debugEntryPoint: debugEntryPoint, options: options, embeddedTexts: embeddedTexts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 24420, 24629);
                    return return_v;
                }


                int
                f_24006_24646_24724(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 24646, 24724);
                    return 0;
                }


                string?
                f_24006_24801_24825(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 24801, 24825);
                    return return_v;
                }


                System.Security.Cryptography.HashAlgorithmName
                f_24006_24836_24868(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.PdbChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 24836, 24868);
                    return return_v;
                }


                bool
                f_24006_24910_24941(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.IsEmitDeterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 24910, 24941);
                    return return_v;
                }


                int
                f_24006_24739_24942(System.IO.MemoryStream
                peStream, System.IO.MemoryStream?
                portablePdbStreamOpt, string
                pdbPath, System.Security.Cryptography.HashAlgorithmName
                hashAlgorithm, bool
                hasEmbeddedPdb, bool
                isDeterministic)
                {
                    ValidateDebugDirectory((System.IO.Stream)peStream, (System.IO.Stream?)portablePdbStreamOpt, pdbPath, hashAlgorithm, hasEmbeddedPdb: hasEmbeddedPdb, isDeterministic: isDeterministic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 24739, 24942);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 24035, 24954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 24035, 24954);
            }
        }

        public static unsafe byte[] GetSourceLinkData(Stream pdbStream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 24966, 25674);
                byte* data = default(byte*);
                int size = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 25054, 25077);

                pdbStream.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 25093, 25150);

                // LAFHIS
                //var symReader = f_24006_25109_25149(pdbStream);

                var symReader = SymReaderFactory.CreateReader(pdbStream);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 25109, 25149);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 25200, 25289);

                    // LAFHIS
                    //f_24006_25200_25288(f_24006_25228_25287(symReader, out data, out size));

                    var temp = symReader.GetSourceServerData(out data, out size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 25228, 25287);
                    f_24006_25200_25288(temp);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 25307, 25408) || true) && (size == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 25307, 25408);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 25362, 25389);

                        return f_24006_25369_25388();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 25307, 25408);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 25428, 25456);

                    var
                    result = new byte[size]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 25474, 25527);

                    f_24006_25474_25526(data, result, 0, f_24006_25512_25525(result));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 25545, 25559);

                    return result;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(24006, 25588, 25663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 25628, 25648);

                    // LAFHIS
                    //f_24006_25628_25647(symReader);
                    symReader.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 25628, 25647);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(24006, 25588, 25663);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 24966, 25674);

                int
                f_24006_25200_25288(int
                errorCode)
                {
                    Marshal.ThrowExceptionForHR(errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 25200, 25288);
                    return 0;
                }


                byte[]
                f_24006_25369_25388()
                {
                    var return_v = Array.Empty<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 25369, 25388);
                    return return_v;
                }


                int
                f_24006_25512_25525(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 25512, 25525);
                    return return_v;
                }


                unsafe int
                f_24006_25474_25526(byte*
                source, byte[]
                destination, int
                startIndex, int
                length)
                {
                    Marshal.Copy((System.IntPtr)source, destination, startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 25474, 25526);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 24966, 25674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 24966, 25674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void ValidateDebugDirectory(Stream peStream, Stream portablePdbStreamOpt, string pdbPath, HashAlgorithmName hashAlgorithm, bool hasEmbeddedPdb, bool isDeterministic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 25686, 28946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 25890, 25912);

                peStream.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 25928, 25966);

                var
                peReader = f_24006_25943_25965(peStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 25980, 26024);

                var
                entries = f_24006_25994_26023(peReader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 26038, 26057);

                int
                entryIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 26073, 26115);

                var
                codeViewEntry = entries[entryIndex++]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 26131, 26223);

                f_24006_26131_26222((DynAbs.Tracing.TraceSender.Conditional_F1(24006, 26150, 26180) || (((portablePdbStreamOpt != null) && DynAbs.Tracing.TraceSender.Conditional_F2(24006, 26183, 26189)) || DynAbs.Tracing.TraceSender.Conditional_F3(24006, 26192, 26193))) ? 0x0100 : 0, codeViewEntry.MajorVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 26237, 26329);

                f_24006_26237_26328((DynAbs.Tracing.TraceSender.Conditional_F1(24006, 26256, 26286) || (((portablePdbStreamOpt != null) && DynAbs.Tracing.TraceSender.Conditional_F2(24006, 26289, 26295)) || DynAbs.Tracing.TraceSender.Conditional_F3(24006, 26298, 26299))) ? 0x504d : 0, codeViewEntry.MinorVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 26343, 26417);

                var
                codeViewData = f_24006_26362_26416(peReader, codeViewEntry)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 26433, 26473);

                f_24006_26433_26472(1, codeViewData.Age);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 26487, 26534);

                f_24006_26487_26533(pdbPath, codeViewData.Path);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 26698, 26749);

                int
                paddedPathLength = codeViewEntry.DataSize - 24
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 26765, 27061) || true) && (isDeterministic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 26765, 27061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 26818, 26896);

                    f_24006_26818_26895(f_24006_26837_26872(f_24006_26837_26850(), pdbPath) + 1, paddedPathLength);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 26765, 27061);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 26765, 27061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 26962, 27046);

                    f_24006_26962_27045(paddedPathLength >= 260, "Path should be at least MAX_PATH long");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 26765, 27061);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 27077, 27534) || true) && (portablePdbStreamOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 27077, 27534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 27143, 27177);

                    portablePdbStreamOpt.Position = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 27197, 27519);
                    using (var
                    provider = f_24006_27219_27318(portablePdbStreamOpt, MetadataStreamOptions.LeaveOpen)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 27360, 27405);

                        var
                        pdbReader = f_24006_27376_27404(provider)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 27427, 27500);

                        f_24006_27427_27499(pdbReader, codeViewEntry.Stamp, codeViewData.Guid);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(24006, 27197, 27519);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 27077, 27534);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 27550, 27937) || true) && ((portablePdbStreamOpt != null || (DynAbs.Tracing.TraceSender.Expression_False(24006, 27555, 27601) || hasEmbeddedPdb)) && (DynAbs.Tracing.TraceSender.Expression_True(24006, 27554, 27632) && hashAlgorithm.Name != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 27550, 27937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 27666, 27700);

                    var
                    entry = entries[entryIndex++]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 27720, 27792);

                    var
                    pdbChecksumData = f_24006_27742_27791(peReader, entry)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 27810, 27880);

                    f_24006_27810_27879(hashAlgorithm.Name, pdbChecksumData.AlgorithmName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 27550, 27937);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 27953, 28505) || true) && (isDeterministic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 27953, 28505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28006, 28040);

                    var
                    entry = entries[entryIndex++]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28058, 28100);

                    f_24006_28058_28099(0, entry.MinorVersion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28118, 28160);

                    f_24006_28118_28159(0, entry.MajorVersion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28178, 28214);

                    f_24006_28178_28213(0U, entry.Stamp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28232, 28301);

                    f_24006_28232_28300(DebugDirectoryEntryType.Reproducible, entry.Type);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28319, 28360);

                    f_24006_28319_28359(0, entry.DataPointer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28378, 28434);

                    f_24006_28378_28433(0, entry.DataRelativeVirtualAddress);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28452, 28490);

                    f_24006_28452_28489(0, entry.DataSize);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 27953, 28505);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28521, 28872) || true) && (hasEmbeddedPdb)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 28521, 28872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28573, 28607);

                    var
                    entry = entries[entryIndex++]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28625, 28857);
                    using (var
                    provider = f_24006_28647_28704(peReader, entry)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28746, 28838);

                        f_24006_28746_28837(f_24006_28768_28796(provider), codeViewEntry.Stamp, codeViewData.Guid);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(24006, 28625, 28857);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 28521, 28872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 28888, 28935);

                f_24006_28888_28934(entries.Length, entryIndex);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 25686, 28946);

                System.Reflection.PortableExecutable.PEReader
                f_24006_25943_25965(System.IO.Stream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 25943, 25965);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.DebugDirectoryEntry>
                f_24006_25994_26023(System.Reflection.PortableExecutable.PEReader
                this_param)
                {
                    var return_v = this_param.ReadDebugDirectory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 25994, 26023);
                    return return_v;
                }


                bool
                f_24006_26131_26222(int
                expected, ushort
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 26131, 26222);
                    return return_v;
                }


                bool
                f_24006_26237_26328(int
                expected, ushort
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 26237, 26328);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CodeViewDebugDirectoryData
                f_24006_26362_26416(System.Reflection.PortableExecutable.PEReader
                this_param, System.Reflection.PortableExecutable.DebugDirectoryEntry
                entry)
                {
                    var return_v = this_param.ReadCodeViewDebugDirectoryData(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 26362, 26416);
                    return return_v;
                }


                bool
                f_24006_26433_26472(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 26433, 26472);
                    return return_v;
                }


                bool
                f_24006_26487_26533(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 26487, 26533);
                    return return_v;
                }


                System.Text.Encoding
                f_24006_26837_26850()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 26837, 26850);
                    return return_v;
                }


                int
                f_24006_26837_26872(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetByteCount(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 26837, 26872);
                    return return_v;
                }


                bool
                f_24006_26818_26895(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 26818, 26895);
                    return return_v;
                }


                bool
                f_24006_26962_27045(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 26962, 27045);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReaderProvider
                f_24006_27219_27318(System.IO.Stream
                stream, System.Reflection.Metadata.MetadataStreamOptions
                options)
                {
                    var return_v = MetadataReaderProvider.FromPortablePdbStream(stream, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 27219, 27318);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_24006_27376_27404(System.Reflection.Metadata.MetadataReaderProvider
                this_param)
                {
                    var return_v = this_param.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 27376, 27404);
                    return return_v;
                }


                int
                f_24006_27427_27499(System.Reflection.Metadata.MetadataReader
                pdbReader, uint
                stampInDebugDirectory, System.Guid
                guidInDebugDirectory)
                {
                    ValidatePortablePdbId(pdbReader, stampInDebugDirectory, guidInDebugDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 27427, 27499);
                    return 0;
                }


                System.Reflection.PortableExecutable.PdbChecksumDebugDirectoryData
                f_24006_27742_27791(System.Reflection.PortableExecutable.PEReader
                this_param, System.Reflection.PortableExecutable.DebugDirectoryEntry
                entry)
                {
                    var return_v = this_param.ReadPdbChecksumDebugDirectoryData(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 27742, 27791);
                    return return_v;
                }


                bool
                f_24006_27810_27879(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 27810, 27879);
                    return return_v;
                }


                bool
                f_24006_28058_28099(int
                expected, ushort
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 28058, 28099);
                    return return_v;
                }


                bool
                f_24006_28118_28159(int
                expected, ushort
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 28118, 28159);
                    return return_v;
                }


                bool
                f_24006_28178_28213(uint
                expected, uint
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 28178, 28213);
                    return return_v;
                }


                bool
                f_24006_28232_28300(System.Reflection.PortableExecutable.DebugDirectoryEntryType
                expected, System.Reflection.PortableExecutable.DebugDirectoryEntryType
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 28232, 28300);
                    return return_v;
                }


                bool
                f_24006_28319_28359(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 28319, 28359);
                    return return_v;
                }


                bool
                f_24006_28378_28433(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 28378, 28433);
                    return return_v;
                }


                bool
                f_24006_28452_28489(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 28452, 28489);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReaderProvider
                f_24006_28647_28704(System.Reflection.PortableExecutable.PEReader
                this_param, System.Reflection.PortableExecutable.DebugDirectoryEntry
                entry)
                {
                    var return_v = this_param.ReadEmbeddedPortablePdbDebugDirectoryData(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 28647, 28704);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_24006_28768_28796(System.Reflection.Metadata.MetadataReaderProvider
                this_param)
                {
                    var return_v = this_param.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 28768, 28796);
                    return return_v;
                }


                int
                f_24006_28746_28837(System.Reflection.Metadata.MetadataReader
                pdbReader, uint
                stampInDebugDirectory, System.Guid
                guidInDebugDirectory)
                {
                    ValidatePortablePdbId(pdbReader, stampInDebugDirectory, guidInDebugDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 28746, 28837);
                    return 0;
                }


                bool
                f_24006_28888_28934(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 28888, 28934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 25686, 28946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 25686, 28946);
            }
        }

        private static unsafe void ValidatePortablePdbId(MetadataReader pdbReader, uint stampInDebugDirectory, Guid guidInDebugDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 28958, 29339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 29112, 29192);

                var
                expectedId = f_24006_29129_29191(guidInDebugDirectory, stampInDebugDirectory)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 29206, 29273);

                var
                actualId = f_24006_29221_29272(f_24006_29239_29271(f_24006_29239_29268(pdbReader)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 29287, 29328);

                f_24006_29287_29327(expectedId, actualId);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 28958, 29339);

                System.Reflection.Metadata.BlobContentId
                f_24006_29129_29191(System.Guid
                guid, uint
                stamp)
                {
                    var return_v = new System.Reflection.Metadata.BlobContentId(guid, stamp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 29129, 29191);
                    return return_v;
                }


                System.Reflection.Metadata.DebugMetadataHeader?
                f_24006_29239_29268(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.DebugMetadataHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 29239, 29268);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_24006_29239_29271(System.Reflection.Metadata.DebugMetadataHeader?
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 29239, 29271);
                    return return_v;
                }


                System.Reflection.Metadata.BlobContentId
                f_24006_29221_29272(System.Collections.Immutable.ImmutableArray<byte>
                id)
                {
                    var return_v = new System.Reflection.Metadata.BlobContentId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 29221, 29272);
                    return return_v;
                }


                bool
                f_24006_29287_29327(System.Reflection.Metadata.BlobContentId
                expected, System.Reflection.Metadata.BlobContentId
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 29287, 29327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 28958, 29339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 28958, 29339);
            }
        }

        internal static void VerifyPdbLambdasAndClosures(this Compilation compilation, SourceWithMarkedNodes source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24006, 29351, 31169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 29484, 29517);

                var
                pdb = f_24006_29494_29516(compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 29531, 29564);

                var
                pdbXml = f_24006_29544_29563(pdb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 29679, 29756);

                var
                methodStartTags = source.MarkedSpans.WhereAsArray(s => s.TagName == "M")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 29770, 29884);

                f_24006_29770_29883(methodStartTags.Length == 1, "There must be one and only one method start tag per test input.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 29898, 29953);

                var
                methodStart = methodStartTags[0].MatchedSpan.Start
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 30026, 30201);

                var
                expectedTags = f_24006_30045_30200(f_24006_30045_30191(f_24006_30045_30081(pdbXml, "closure"), (c, i) => new { Tag = $"<C:{i}>", StartIndex = methodStart + int.Parse(c.Attribute("offset").Value) }))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 30267, 30478);

                f_24006_30267_30477(
                            // Add the expected tags for lambdas
                            expectedTags, f_24006_30289_30476(f_24006_30289_30324(pdbXml, "lambda"), (c, i) => new { Tag = $"<L:{i}.{int.Parse(c.Attribute("closure").Value)}>", StartIndex = methodStart + int.Parse(c.Attribute("offset").Value) }));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 30554, 30620);

                f_24006_30554_30619(
                            // Order by start index so they line up nicely
                            expectedTags, (x, y) => x.StartIndex.CompareTo(y.StartIndex));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 30709, 30779);

                f_24006_30709_30778(
                            // Ensure the tag for the method start is the first element
                            expectedTags, 0, new { Tag = "<M>", StartIndex = methodStart });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 30880, 30903);

                f_24006_30880_30902(
                            // Now reverse the list so we can insert without worrying about offsets
                            expectedTags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 30919, 30948);

                var
                expected = source.Source
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 30964, 31097);
                    foreach (var tag in f_24006_30984_30996_I(expectedTags))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24006, 30964, 31097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 31030, 31082);

                        expected = f_24006_31041_31081(expected, f_24006_31057_31071(tag), f_24006_31073_31080(tag));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24006, 30964, 31097);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24006, 1, 134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24006, 1, 134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24006, 31113, 31158);

                f_24006_31113_31157(expected, source.Input);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24006, 29351, 31169);

                string
                f_24006_29494_29516(Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = GetPdbXml(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 29494, 29516);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_24006_29544_29563(string
                text)
                {
                    var return_v = XElement.Parse(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 29544, 29563);
                    return return_v;
                }


                bool
                f_24006_29770_29883(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 29770, 29883);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_24006_30045_30081(System.Xml.Linq.XElement
                this_param, string
                name)
                {
                    var return_v = this_param.DescendantsAndSelf((System.Xml.Linq.XName)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 30045, 30081);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<dynamic>
                f_24006_30045_30191(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                source, System.Func<System.Xml.Linq.XElement, int, dynamic>
                selector)
                {
                    var return_v = source.Select<System.Xml.Linq.XElement, dynamic>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 30045, 30191);
                    return return_v;
                }


                System.Collections.Generic.List<dynamic>
                f_24006_30045_30200(System.Collections.Generic.IEnumerable<dynamic>
                source)
                {
                    var return_v = source.ToList<dynamic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 30045, 30200);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_24006_30289_30324(System.Xml.Linq.XElement
                this_param, string
                name)
                {
                    var return_v = this_param.DescendantsAndSelf((System.Xml.Linq.XName)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 30289, 30324);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<dynamic>
                f_24006_30289_30476(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                source, System.Func<System.Xml.Linq.XElement, int, dynamic>
                selector)
                {
                    var return_v = source.Select<System.Xml.Linq.XElement, dynamic>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 30289, 30476);
                    return return_v;
                }


                int
                f_24006_30267_30477(System.Collections.Generic.List<dynamic>
                this_param, System.Collections.Generic.IEnumerable<dynamic>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 30267, 30477);
                    return 0;
                }


                int
                f_24006_30554_30619(System.Collections.Generic.List<dynamic>
                this_param, System.Comparison<dynamic>
                comparison)
                {
                    this_param.Sort(comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 30554, 30619);
                    return 0;
                }


                int
                f_24006_30709_30778(System.Collections.Generic.List<dynamic>
                this_param, int
                index, dynamic
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 30709, 30778);
                    return 0;
                }


                int
                f_24006_30880_30902(System.Collections.Generic.List<dynamic>
                this_param)
                {
                    this_param.Reverse();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 30880, 30902);
                    return 0;
                }


                int
                f_24006_31057_31071(dynamic
                this_param)
                {
                    var return_v = this_param.StartIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 31057, 31071);
                    return return_v;
                }


                string
                f_24006_31073_31080(dynamic
                this_param)
                {
                    var return_v = this_param.Tag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24006, 31073, 31080);
                    return return_v;
                }


                string
                f_24006_31041_31081(string
                this_param, int
                startIndex, string
                value)
                {
                    var return_v = this_param.Insert(startIndex, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 31041, 31081);
                    return return_v;
                }


                System.Collections.Generic.List<dynamic>
                f_24006_30984_30996_I(System.Collections.Generic.List<dynamic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 30984, 30996);
                    return return_v;
                }


                int
                f_24006_31113_31157(string
                expected, string
                actual)
                {
                    AssertEx.EqualOrDiff(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24006, 31113, 31157);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24006, 29351, 31169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 29351, 31169);
            }
        }

        static PdbValidation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24006, 1018, 31176);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24006, 1018, 31176);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24006, 1018, 31176);
        }

    }
}

