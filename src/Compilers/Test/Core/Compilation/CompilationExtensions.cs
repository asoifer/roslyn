// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;
using Xunit.Sdk;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public static class CompilationExtensions
    {
        internal static bool EnableVerifyIOperation { get; }

        internal static ImmutableArray<byte> EmitToArray(
                    this Compilation compilation,
                    EmitOptions options = null,
                    CompilationTestData testData = null,
                    DiagnosticDescription[] expectedWarnings = null,
                    Stream pdbStream = null,
                    IMethodSymbol debugEntryPoint = null,
                    Stream sourceLinkStream = null,
                    IEnumerable<EmbeddedText> embeddedTexts = null,
                    IEnumerable<ResourceDescription> manifestResources = null,
                    Stream metadataPEStream = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25006, 1137, 3366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 1719, 1753);

                var
                peStream = f_25006_1734_1752()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 1769, 2414) || true) && (pdbStream == null && (DynAbs.Tracing.TraceSender.Expression_True(25006, 1773, 1858) && f_25006_1794_1831(f_25006_1794_1813(compilation)) == OptimizationLevel.Debug) && (DynAbs.Tracing.TraceSender.Expression_True(25006, 1773, 1928) && f_25006_1862_1893_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(options, 25006, 1862, 1893)?.DebugInformationFormat) != DebugInformationFormat.Embedded))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 1769, 2414);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 1962, 2198) || true) && (f_25006_1966_1995() || (DynAbs.Tracing.TraceSender.Expression_False(25006, 1966, 2031) || f_25006_1999_2031()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 1962, 2198);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 2073, 2179);

                        options = f_25006_2083_2178((options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Emit.EmitOptions?>(25006, 2084, 2114) ?? EmitOptions.Default)), DebugInformationFormat.PortablePdb);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 1962, 2198);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 2218, 2329);

                    var
                    discretePdb = (object)options != null && (DynAbs.Tracing.TraceSender.Expression_True(25006, 2236, 2328) && f_25006_2263_2293(options) != DebugInformationFormat.Embedded)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 2347, 2399);

                    pdbStream = (DynAbs.Tracing.TraceSender.Conditional_F1(25006, 2359, 2370) || ((discretePdb && DynAbs.Tracing.TraceSender.Conditional_F2(25006, 2373, 2391)) || DynAbs.Tracing.TraceSender.Conditional_F3(25006, 2394, 2398))) ? f_25006_2373_2391() : null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 1769, 2414);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 2430, 3022);

                var
                emitResult = f_25006_2447_3021(compilation, peStream: peStream, metadataPEStream: metadataPEStream, pdbStream: pdbStream, xmlDocumentationStream: null, win32Resources: null, manifestResources: manifestResources, options: options, debugEntryPoint: debugEntryPoint, sourceLinkStream: sourceLinkStream, embeddedTexts: embeddedTexts, testData: testData, cancellationToken: default(CancellationToken))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 3038, 3168);

                f_25006_3038_3167(f_25006_3056_3074(emitResult), "Diagnostics:\r\n" + f_25006_3097_3166("\r\n", emitResult.Diagnostics.Select(d => d.ToString())));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 3184, 3309) || true) && (expectedWarnings != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 3184, 3309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 3246, 3294);

                    emitResult.Diagnostics.Verify(expectedWarnings);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 3184, 3309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 3325, 3355);

                return f_25006_3332_3354(peStream);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25006, 1137, 3366);

                System.IO.MemoryStream
                f_25006_1734_1752()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 1734, 1752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25006_1794_1813(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 1794, 1813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_25006_1794_1831(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 1794, 1831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat?
                f_25006_1862_1893_M(Microsoft.CodeAnalysis.Emit.DebugInformationFormat?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 1862, 1893);
                    return return_v;
                }


                bool
                f_25006_1966_1995()
                {
                    var return_v = MonoHelpers.IsRunningOnMono();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 1966, 1995);
                    return return_v;
                }


                bool
                f_25006_1999_2031()
                {
                    var return_v = PathUtilities.IsUnixLikePlatform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 1999, 2031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_25006_2083_2178(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = this_param.WithDebugInformationFormat(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 2083, 2178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_25006_2263_2293(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 2263, 2293);
                    return return_v;
                }


                System.IO.MemoryStream
                f_25006_2373_2391()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 2373, 2391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_25006_2447_3021(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.Stream?
                metadataPEStream, System.IO.Stream?
                pdbStream, System.IO.Stream?
                xmlDocumentationStream, System.IO.Stream?
                win32Resources, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions?
                options, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.CodeGen.CompilationTestData?
                testData, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.Emit(peStream: (System.IO.Stream)peStream, metadataPEStream: metadataPEStream, pdbStream: pdbStream, xmlDocumentationStream: xmlDocumentationStream, win32Resources: win32Resources, manifestResources: manifestResources, options: options, debugEntryPoint: debugEntryPoint, sourceLinkStream: sourceLinkStream, embeddedTexts: embeddedTexts, testData: testData, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 2447, 3021);
                    return return_v;
                }


                bool
                f_25006_3056_3074(Microsoft.CodeAnalysis.Emit.EmitResult
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 3056, 3074);
                    return return_v;
                }


                string
                f_25006_3097_3166(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 3097, 3166);
                    return return_v;
                }


                bool
                f_25006_3038_3167(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 3038, 3167);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25006_3332_3354(System.IO.MemoryStream
                stream)
                {
                    var return_v = stream.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 3332, 3354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 1137, 3366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 1137, 3366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemoryStream EmitToStream(this Compilation compilation, EmitOptions options = null, DiagnosticDescription[] expectedWarnings = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25006, 3378, 4010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 3549, 3581);

                var
                stream = f_25006_3562_3580()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 3595, 3655);

                var
                emitResult = f_25006_3612_3654(compilation, stream, options: options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 3669, 3794);

                f_25006_3669_3793(f_25006_3687_3705(emitResult), "Diagnostics: " + f_25006_3725_3792(", ", emitResult.Diagnostics.Select(d => d.ToString())));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 3810, 3935) || true) && (expectedWarnings != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 3810, 3935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 3872, 3920);

                    emitResult.Diagnostics.Verify(expectedWarnings);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 3810, 3935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 3951, 3971);

                stream.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 3985, 3999);

                return stream;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25006, 3378, 4010);

                System.IO.MemoryStream
                f_25006_3562_3580()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 3562, 3580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_25006_3612_3654(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.MemoryStream
                peStream, Microsoft.CodeAnalysis.Emit.EmitOptions?
                options)
                {
                    var return_v = this_param.Emit((System.IO.Stream)peStream, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 3612, 3654);
                    return return_v;
                }


                bool
                f_25006_3687_3705(Microsoft.CodeAnalysis.Emit.EmitResult
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 3687, 3705);
                    return return_v;
                }


                string
                f_25006_3725_3792(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 3725, 3792);
                    return return_v;
                }


                bool
                f_25006_3669_3793(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 3669, 3793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 3378, 4010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 3378, 4010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MetadataReference EmitToImageReference(
                    this Compilation comp,
                    EmitOptions options = null,
                    bool embedInteropTypes = false,
                    ImmutableArray<string> aliases = default,
                    DiagnosticDescription[] expectedWarnings = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25006, 4315, 4412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 4318, 4412);
                return f_25006_4318_4412(comp, options, embedInteropTypes, aliases, expectedWarnings); DynAbs.Tracing.TraceSender.TraceExitMethod(25006, 4315, 4412);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 4315, 4412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 4315, 4412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static PortableExecutableReference EmitToPortableExecutableReference(
                    this Compilation comp,
                    EmitOptions options = null,
                    bool embedInteropTypes = false,
                    ImmutableArray<string> aliases = default,
                    DiagnosticDescription[] expectedWarnings = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25006, 4425, 5288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 4765, 4839);

                var
                image = f_25006_4777_4838(comp, options, expectedWarnings: expectedWarnings)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 4853, 5277) || true) && (f_25006_4857_4880(f_25006_4857_4869(comp)) == OutputKind.NetModule)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 4853, 5277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 4938, 5034);

                    return f_25006_4945_5033(f_25006_4945_4982(image), display: f_25006_5005_5032(comp));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 4853, 5277);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 4853, 5277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 5100, 5262);

                    return f_25006_5107_5261(f_25006_5107_5146(image), aliases: aliases, embedInteropTypes: embedInteropTypes, display: f_25006_5225_5260(comp));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 4853, 5277);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25006, 4425, 5288);

                System.Collections.Immutable.ImmutableArray<byte>
                f_25006_4777_4838(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitOptions?
                options, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]?
                expectedWarnings)
                {
                    var return_v = compilation.EmitToArray(options, expectedWarnings: expectedWarnings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 4777, 4838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25006_4857_4869(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 4857, 4869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_25006_4857_4880(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 4857, 4880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_25006_4945_4982(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 4945, 4982);
                    return return_v;
                }


                string
                f_25006_5005_5032(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.MakeSourceModuleName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 5005, 5032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_25006_4945_5033(Microsoft.CodeAnalysis.ModuleMetadata
                this_param, string
                display)
                {
                    var return_v = this_param.GetReference(display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 4945, 5033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_25006_5107_5146(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = AssemblyMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 5107, 5146);
                    return return_v;
                }


                string
                f_25006_5225_5260(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.MakeSourceAssemblySimpleName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 5225, 5260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_25006_5107_5261(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param, System.Collections.Immutable.ImmutableArray<string>
                aliases, bool
                embedInteropTypes, string
                display)
                {
                    var return_v = this_param.GetReference(aliases: aliases, embedInteropTypes: embedInteropTypes, display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 5107, 5261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 4425, 5288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 4425, 5288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CompilationDifference EmitDifference(
                    this Compilation compilation,
                    EmitBaseline baseline,
                    ImmutableArray<SemanticEdit> edits,
                    IEnumerable<ISymbol> allAddedSymbols = null,
                    CompilationTestData testData = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25006, 5300, 6604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 5614, 5653);

                testData ??= f_25006_5627_5652();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 5667, 5755);

                var
                isAddedSymbol = new Func<ISymbol, bool>(s => allAddedSymbols?.Contains(s) ?? false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 5771, 5811);

                using var
                mdStream = f_25006_5792_5810()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 5825, 5865);

                using var
                ilStream = f_25006_5846_5864()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 5879, 5920);

                using var
                pdbStream = f_25006_5901_5919()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 5936, 5992);

                var
                updatedMethods = f_25006_5957_5991()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 6008, 6315);

                var
                result = f_25006_6021_6314(compilation, baseline, edits, isAddedSymbol, mdStream, ilStream, pdbStream, updatedMethods, testData, CancellationToken.None)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 6331, 6593);

                return f_25006_6338_6592(f_25006_6382_6404(mdStream), f_25006_6423_6445(ilStream), f_25006_6464_6487(pdbStream), testData, result, f_25006_6558_6591(updatedMethods));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25006, 5300, 6604);

                Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                f_25006_5627_5652()
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 5627, 5652);
                    return return_v;
                }


                System.IO.MemoryStream
                f_25006_5792_5810()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 5792, 5810);
                    return return_v;
                }


                System.IO.MemoryStream
                f_25006_5846_5864()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 5846, 5864);
                    return return_v;
                }


                System.IO.MemoryStream
                f_25006_5901_5919()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 5901, 5919);
                    return return_v;
                }


                System.Collections.Generic.List<System.Reflection.Metadata.MethodDefinitionHandle>
                f_25006_5957_5991()
                {
                    var return_v = new System.Collections.Generic.List<System.Reflection.Metadata.MethodDefinitionHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 5957, 5991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitDifferenceResult
                f_25006_6021_6314(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits, System.Func<Microsoft.CodeAnalysis.ISymbol, bool>
                isAddedSymbol, System.IO.MemoryStream
                metadataStream, System.IO.MemoryStream
                ilStream, System.IO.MemoryStream
                pdbStream, System.Collections.Generic.List<System.Reflection.Metadata.MethodDefinitionHandle>
                updatedMethodHandles, Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                testData, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.EmitDifference(baseline, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>)edits, isAddedSymbol, (System.IO.Stream)metadataStream, (System.IO.Stream)ilStream, (System.IO.Stream)pdbStream, (System.Collections.Generic.ICollection<System.Reflection.Metadata.MethodDefinitionHandle>)updatedMethodHandles, testData, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 6021, 6314);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25006_6382_6404(System.IO.MemoryStream
                stream)
                {
                    var return_v = stream.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 6382, 6404);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25006_6423_6445(System.IO.MemoryStream
                stream)
                {
                    var return_v = stream.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 6423, 6445);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25006_6464_6487(System.IO.MemoryStream
                stream)
                {
                    var return_v = stream.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 6464, 6487);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.Metadata.MethodDefinitionHandle>
                f_25006_6558_6591(System.Collections.Generic.List<System.Reflection.Metadata.MethodDefinitionHandle>
                items)
                {
                    var return_v = items.ToImmutableArray<System.Reflection.Metadata.MethodDefinitionHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 6558, 6591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                f_25006_6338_6592(System.Collections.Immutable.ImmutableArray<byte>
                metadata, System.Collections.Immutable.ImmutableArray<byte>
                il, System.Collections.Immutable.ImmutableArray<byte>
                pdb, Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                testData, Microsoft.CodeAnalysis.Emit.EmitDifferenceResult
                result, System.Collections.Immutable.ImmutableArray<System.Reflection.Metadata.MethodDefinitionHandle>
                methodHandles)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference(metadata, il, pdb, testData, result, methodHandles);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 6338, 6592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 5300, 6604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 5300, 6604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void VerifyAssemblyVersionsAndAliases(this Compilation compilation, params string[] expectedAssembliesAndAliases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25006, 6616, 7120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 6770, 7005);

                var
                actual = f_25006_6783_7004(f_25006_6783_6852(f_25006_6783_6821(compilation)), t => $"{t.Item1.Identity.Name}, Version={t.Item1.Identity.Version}{(t.Item2.IsEmpty ? "" : ": " + string.Join(",", t.Item2))}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 7021, 7109);

                f_25006_7021_7108(expectedAssembliesAndAliases, actual, itemInspector: s => '"' + s + '"');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25006, 6616, 7120);

                Microsoft.CodeAnalysis.CommonReferenceManager
                f_25006_6783_6821(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.GetBoundReferenceManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 6783, 6821);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<(Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal, System.Collections.Immutable.ImmutableArray<string>)>
                f_25006_6783_6852(Microsoft.CodeAnalysis.CommonReferenceManager
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblyAliases();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 6783, 6852);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25006_6783_7004(System.Collections.Generic.IEnumerable<(Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal, System.Collections.Immutable.ImmutableArray<string>)>
                source, System.Func<(Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal, System.Collections.Immutable.ImmutableArray<string>), string>
                selector)
                {
                    var return_v = source.Select<(Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal, System.Collections.Immutable.ImmutableArray<string>), string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 6783, 7004);
                    return return_v;
                }


                bool
                f_25006_7021_7108(string[]
                expected, System.Collections.Generic.IEnumerable<string>
                actual, System.Func<string, string>
                itemInspector)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<string>)expected, actual, itemInspector: itemInspector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 7021, 7108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 6616, 7120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 6616, 7120);
            }
        }

        internal static void VerifyAssemblyAliases(this Compilation compilation, params string[] expectedAssembliesAndAliases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25006, 7132, 7589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 7275, 7474);

                var
                actual = f_25006_7288_7473(f_25006_7288_7357(f_25006_7288_7326(compilation)), t => $"{t.Item1.Identity.Name}{(t.Item2.IsEmpty ? "" : ": " + string.Join(",", t.Item2))}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 7490, 7578);

                f_25006_7490_7577(expectedAssembliesAndAliases, actual, itemInspector: s => '"' + s + '"');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25006, 7132, 7589);

                Microsoft.CodeAnalysis.CommonReferenceManager
                f_25006_7288_7326(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.GetBoundReferenceManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 7288, 7326);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<(Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal, System.Collections.Immutable.ImmutableArray<string>)>
                f_25006_7288_7357(Microsoft.CodeAnalysis.CommonReferenceManager
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblyAliases();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 7288, 7357);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25006_7288_7473(System.Collections.Generic.IEnumerable<(Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal, System.Collections.Immutable.ImmutableArray<string>)>
                source, System.Func<(Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal, System.Collections.Immutable.ImmutableArray<string>), string>
                selector)
                {
                    var return_v = source.Select<(Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal, System.Collections.Immutable.ImmutableArray<string>), string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 7288, 7473);
                    return return_v;
                }


                bool
                f_25006_7490_7577(string[]
                expected, System.Collections.Generic.IEnumerable<string>
                actual, System.Func<string, string>
                itemInspector)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<string>)expected, actual, itemInspector: itemInspector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 7490, 7577);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 7132, 7589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 7132, 7589);
            }
        }

        internal static void VerifyOperationTree(this Compilation compilation, SyntaxNode node, string expectedOperationTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25006, 7601, 7891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 7743, 7811);

                SemanticModel
                model = f_25006_7765_7810(compilation, f_25006_7794_7809(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 7825, 7880);

                f_25006_7825_7879(model, node, expectedOperationTree);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25006, 7601, 7891);

                Microsoft.CodeAnalysis.SyntaxTree
                f_25006_7794_7809(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 7794, 7809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_25006_7765_7810(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 7765, 7810);
                    return return_v;
                }


                int
                f_25006_7825_7879(Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.SyntaxNode
                node, string
                expectedOperationTree)
                {
                    model.VerifyOperationTree(node, expectedOperationTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 7825, 7879);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 7601, 7891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 7601, 7891);
            }
        }

        internal static void VerifyOperationTree(this Compilation compilation, string expectedOperationTree, bool skipImplicitlyDeclaredSymbols = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25006, 7903, 8246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 8072, 8235);

                f_25006_8072_8234(compilation, symbolToVerify: null, expectedOperationTree: expectedOperationTree, skipImplicitlyDeclaredSymbols: skipImplicitlyDeclaredSymbols);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25006, 7903, 8246);

                int
                f_25006_8072_8234(Microsoft.CodeAnalysis.Compilation
                compilation, string
                symbolToVerify, string
                expectedOperationTree, bool
                skipImplicitlyDeclaredSymbols)
                {
                    compilation.VerifyOperationTree(symbolToVerify: symbolToVerify, expectedOperationTree: expectedOperationTree, skipImplicitlyDeclaredSymbols: skipImplicitlyDeclaredSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 8072, 8234);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 7903, 8246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 7903, 8246);
            }
        }

        internal static void VerifyOperationTree(this Compilation compilation, string symbolToVerify, string expectedOperationTree, bool skipImplicitlyDeclaredSymbols = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25006, 8258, 11035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 8450, 8500);

                SyntaxTree
                tree = f_25006_8468_8499(f_25006_8468_8491(compilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 8514, 8547);

                SyntaxNode
                root = f_25006_8532_8546(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 8561, 8618);

                SemanticModel
                model = f_25006_8583_8617(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 8632, 8702);

                var
                declarationsBuilder = f_25006_8658_8701()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 8716, 8868);

                f_25006_8716_8867(model, root, associatedSymbol: null, getSymbol: true, builder: declarationsBuilder, cancellationToken: CancellationToken.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 8884, 8928);

                var
                actualTextBuilder = f_25006_8908_8927()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 8942, 10926);
                    foreach (DeclarationInfo declaration in f_25006_8982_9108_I(f_25006_8982_9108(f_25006_8982_9055(f_25006_8982_9018(declarationsBuilder), d => d.DeclaredSymbol != null), d => d.DeclaredSymbol.ToTestDisplayString())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 8942, 10926);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 9142, 9271) || true) && (!f_25006_9147_9201(declaration.DeclaredSymbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 9142, 9271);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 9243, 9252);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 9142, 9271);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 9291, 9445) || true) && (skipImplicitlyDeclaredSymbols && (DynAbs.Tracing.TraceSender.Expression_True(25006, 9295, 9375) && f_25006_9328_9375(declaration.DeclaredSymbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 9291, 9445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 9417, 9426);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 9291, 9445);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 9465, 9661) || true) && (!f_25006_9470_9506(symbolToVerify) && (DynAbs.Tracing.TraceSender.Expression_True(25006, 9469, 9591) && !f_25006_9511_9591(f_25006_9511_9542(declaration.DeclaredSymbol), symbolToVerify, StringComparison.Ordinal)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 9465, 9661);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 9633, 9642);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 9465, 9661);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 9681, 9756);

                        f_25006_9681_9755(
                                        actualTextBuilder, f_25006_9706_9754(declaration.DeclaredSymbol));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 9776, 10845) || true) && (declaration.ExecutableCodeBlocks.Length == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 9776, 10845);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 9866, 9925);

                            f_25006_9866_9924(actualTextBuilder, $" ('0' executable code blocks)");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 9776, 10845);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 9776, 10845);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 10137, 10220);

                            ImmutableArray<SyntaxNode>
                            executableCodeBlocks = declaration.ExecutableCodeBlocks
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 10242, 10510) || true) && (f_25006_10246_10277(declaration.DeclaredSymbol) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(25006, 10246, 10351) && f_25006_10302_10322(compilation) == LanguageNames.VisualBasic))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 10242, 10510);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 10401, 10487);

                                executableCodeBlocks = executableCodeBlocks.RemoveAt(executableCodeBlocks.Length - 1);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 10242, 10510);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 10534, 10826);
                                foreach (SyntaxNode executableCodeBlock in f_25006_10577_10597_I(executableCodeBlocks))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 10534, 10826);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 10647, 10693);

                                    f_25006_10647_10692(actualTextBuilder, f_25006_10672_10691());
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 10719, 10803);

                                    f_25006_10719_10802(model, executableCodeBlock, actualTextBuilder, initialIndent: 2);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 10534, 10826);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25006, 1, 293);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25006, 1, 293);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 9776, 10845);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 10865, 10911);

                        f_25006_10865_10910(
                                        actualTextBuilder, f_25006_10890_10909());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 8942, 10926);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25006, 1, 1985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25006, 1, 1985);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 10942, 11024);

                f_25006_10942_11023(expectedOperationTree, f_25006_10994_11022(actualTextBuilder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25006, 8258, 11035);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_25006_8468_8491(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 8468, 8491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_25006_8468_8499(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                source)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.SyntaxTree>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 8468, 8499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25006_8532_8546(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 8532, 8546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_25006_8583_8617(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 8583, 8617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DeclarationInfo>
                f_25006_8658_8701()
                {
                    var return_v = ArrayBuilder<DeclarationInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 8658, 8701);
                    return return_v;
                }


                int
                f_25006_8716_8867(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.ISymbol
                associatedSymbol, bool
                getSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DeclarationInfo>
                builder, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.ComputeDeclarationsInNode(node, associatedSymbol: associatedSymbol, getSymbol: getSymbol, builder: builder, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 8716, 8867);
                    return 0;
                }


                System.Text.StringBuilder
                f_25006_8908_8927()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 8908, 8927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DeclarationInfo[]
                f_25006_8982_9018(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DeclarationInfo>
                this_param)
                {
                    var return_v = this_param.ToArrayAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 8982, 9018);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.DeclarationInfo>
                f_25006_8982_9055(Microsoft.CodeAnalysis.DeclarationInfo[]
                source, System.Func<Microsoft.CodeAnalysis.DeclarationInfo, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.DeclarationInfo>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 8982, 9055);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.DeclarationInfo>
                f_25006_8982_9108(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.DeclarationInfo>
                source, System.Func<Microsoft.CodeAnalysis.DeclarationInfo, string>
                keySelector)
                {
                    var return_v = source.OrderBy<Microsoft.CodeAnalysis.DeclarationInfo, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 8982, 9108);
                    return return_v;
                }


                bool
                f_25006_9147_9201(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = CanHaveExecutableCodeBlock(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 9147, 9201);
                    return return_v;
                }


                bool
                f_25006_9328_9375(Microsoft.CodeAnalysis.ISymbol?
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 9328, 9375);
                    return return_v;
                }


                bool
                f_25006_9470_9506(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 9470, 9506);
                    return return_v;
                }


                string
                f_25006_9511_9542(Microsoft.CodeAnalysis.ISymbol?
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 9511, 9542);
                    return return_v;
                }


                bool
                f_25006_9511_9591(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 9511, 9591);
                    return return_v;
                }


                string
                f_25006_9706_9754(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 9706, 9754);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25006_9681_9755(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 9681, 9755);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25006_9866_9924(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 9866, 9924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_25006_10246_10277(Microsoft.CodeAnalysis.ISymbol?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 10246, 10277);
                    return return_v;
                }


                string
                f_25006_10302_10322(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 10302, 10322);
                    return return_v;
                }


                string
                f_25006_10672_10691()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 10672, 10691);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25006_10647_10692(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 10647, 10692);
                    return return_v;
                }


                int
                f_25006_10719_10802(Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Text.StringBuilder
                actualTextBuilder, int
                initialIndent)
                {
                    model.AppendOperationTree(node, actualTextBuilder, initialIndent: initialIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 10719, 10802);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                f_25006_10577_10597_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 10577, 10597);
                    return return_v;
                }


                string
                f_25006_10890_10909()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 10890, 10909);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25006_10865_10910(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 10865, 10910);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.DeclarationInfo>
                f_25006_8982_9108_I(System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.DeclarationInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 8982, 9108);
                    return return_v;
                }


                string
                f_25006_10994_11022(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 10994, 11022);
                    return return_v;
                }


                bool
                f_25006_10942_11023(string
                expectedOperationTree, string
                actualOperationTree)
                {
                    var return_v = OperationTreeVerifier.Verify(expectedOperationTree, actualOperationTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 10942, 11023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 8258, 11035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 8258, 11035);
            }
        }

        internal static bool CanHaveExecutableCodeBlock(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25006, 11047, 11501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 11135, 11490);

                switch (f_25006_11143_11154(symbol))
                {

                    case SymbolKind.Field:
                    case SymbolKind.Event:
                    case SymbolKind.Method:
                    case SymbolKind.NamedType:
                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 11135, 11490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 11400, 11412);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 11135, 11490);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 11135, 11490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 11462, 11475);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 11135, 11490);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25006, 11047, 11501);

                Microsoft.CodeAnalysis.SymbolKind
                f_25006_11143_11154(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 11143, 11154);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 11047, 11501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 11047, 11501);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void ValidateIOperations(Func<Compilation> createCompilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25006, 11513, 17075);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 11613, 11696) || true) && (f_25006_11617_11640_M(!EnableVerifyIOperation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 11613, 11696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 11674, 11681);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 11613, 11696);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 11712, 11750);

                var
                compilation = f_25006_11730_11749(createCompilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 11764, 11853);

                var
                roots = f_25006_11776_11852()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 11867, 11899);

                var
                stopWatch = f_25006_11883_11898()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 11913, 12023) || true) && (f_25006_11917_11956_M(!System.Diagnostics.Debugger.IsAttached))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 11913, 12023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 11990, 12008);

                    f_25006_11990_12007(stopWatch);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 11913, 12023);
                }

                void checkTimeout()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25006, 12039, 12284);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 12091, 12117);

                        const int
                        timeout = 15000
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 12135, 12269);

                        f_25006_12135_12268(f_25006_12154_12183(stopWatch) > timeout, $"ValidateIOperations took too long: {f_25006_12233_12262(stopWatch)} ms");
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25006, 12039, 12284);

                        long
                        f_25006_12154_12183(System.Diagnostics.Stopwatch
                        this_param)
                        {
                            var return_v = this_param.ElapsedMilliseconds;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 12154, 12183);
                            return return_v;
                        }


                        long
                        f_25006_12233_12262(System.Diagnostics.Stopwatch
                        this_param)
                        {
                            var return_v = this_param.ElapsedMilliseconds;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 12233, 12262);
                            return return_v;
                        }


                        bool
                        f_25006_12135_12268(bool
                        condition, string
                        userMessage)
                        {
                            var return_v = CustomAssert.False(condition, userMessage);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 12135, 12268);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 12039, 12284);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 12039, 12284);
                    }
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 12300, 13962);
                    foreach (var tree in f_25006_12321_12344_I(f_25006_12321_12344(compilation)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 12300, 13962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 12378, 12433);

                        var
                        semanticModel = f_25006_12398_12432(compilation, tree)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 12451, 12477);

                        var
                        root = f_25006_12462_12476(tree)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 12497, 13947);
                            foreach (var node in f_25006_12518_12547_I(f_25006_12518_12547(root)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 12497, 13947);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 12589, 12604);

                                f_25006_12589_12603();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 12628, 12677);

                                var
                                operation = f_25006_12644_12676(semanticModel, node)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 12699, 13928) || true) && (operation != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 12699, 13928);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 12940, 13036);

                                    f_25006_12940_13035(node == f_25006_12966_12982(operation), $"Expected : {node} - Actual : {f_25006_13016_13032(operation)}");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 13064, 13186);

                                    f_25006_13064_13185(f_25006_13082_13096(operation) == null || (DynAbs.Tracing.TraceSender.Expression_False(25006, 13082, 13137) || !f_25006_13109_13137(operation)), $"Unexpected non-null type: {f_25006_13168_13182(operation)}");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 13214, 13272);

                                    f_25006_13214_13271(semanticModel, f_25006_13247_13270(operation));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 13298, 13378);

                                    f_25006_13298_13377(semanticModel, f_25006_13334_13376(((Operation)operation)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 13404, 13469);

                                    f_25006_13404_13468(f_25006_13425_13467(((Operation)operation)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 13495, 13594);

                                    f_25006_13495_13593(semanticModel, f_25006_13528_13592(f_25006_13528_13570(((Operation)operation))));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 13620, 13690);

                                    f_25006_13620_13689(semanticModel, f_25006_13653_13688(semanticModel));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 13718, 13905) || true) && (f_25006_13722_13738(operation) == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 13718, 13905);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 13804, 13878);

                                        f_25006_13804_13877(roots, (operation, f_25006_13826_13875(semanticModel, f_25006_13858_13874(operation))));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 13718, 13905);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 12699, 13928);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 12497, 13947);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25006, 1, 1451);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25006, 1, 1451);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 12300, 13962);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25006, 1, 1663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25006, 1, 1663);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 13978, 14041);

                var
                explicitNodeMap = f_25006_14000_14040()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 14055, 14100);

                var
                visitor = TestOperationVisitor.Singleton
                ;

                foreach (var (root, associatedSymbol) in roots)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 14196, 14889);
                        foreach (var operation in f_25006_14222_14247_I(f_25006_14222_14247(root)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 14196, 14889);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 14289, 14304);

                            f_25006_14289_14303();

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 14328, 14821) || true) && (f_25006_14332_14353_M(!operation.IsImplicit))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 14328, 14821);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 14463, 14512);

                                    f_25006_14463_14511(explicitNodeMap, f_25006_14483_14499(operation), operation);
                                }
                                catch (ArgumentException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(25006, 14565, 14798);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 14647, 14771);

                                    f_25006_14647_14770(true, $"Duplicate explicit node for syntax ({f_25006_14711_14735(f_25006_14711_14727(operation))}): {f_25006_14740_14767(f_25006_14740_14756(operation))}");
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(25006, 14565, 14798);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 14328, 14821);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 14845, 14870);

                            f_25006_14845_14869(
                                                visitor, operation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 14196, 14889);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25006, 1, 694);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25006, 1, 694);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 14909, 14926);

                    f_25006_14909_14925(
                                    stopWatch);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 14944, 14990);

                    f_25006_14944_14989(root, associatedSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 15008, 15026);

                    f_25006_15008_15025(stopWatch);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 15057, 15070);

                f_25006_15057_15069(
                            roots);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 15084, 15101);

                f_25006_15084_15100(stopWatch);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 15115, 15122);

                return;

                void checkControlFlowGraph(IOperation root, ISymbol associatedSymbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25006, 15138, 17064);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 15240, 17049);

                        switch (root)
                        {

                            case IBlockOperation blockOperation:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 15240, 17049);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 15485, 15761) || true) && (f_25006_15489_15534(f_25006_15489_15529(f_25006_15489_15521(f_25006_15489_15510(blockOperation)))) != SourceCodeKind.Script)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 15485, 15761);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 15617, 15734);

                                    f_25006_15617_15733(compilation, f_25006_15668_15714(blockOperation), associatedSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 15485, 15761);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(25006, 15789, 15795);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 15240, 17049);

                            case IMethodBodyOperation methodBody:
                            case IConstructorBodyOperation constructorBody:
                            case IFieldInitializerOperation fieldInitializerOperation:
                            case IPropertyInitializerOperation propertyInitializerOperation:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 15240, 17049);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 16117, 16224);

                                f_25006_16117_16223(compilation, f_25006_16168_16204(root), associatedSymbol);
                                DynAbs.Tracing.TraceSender.TraceBreak(25006, 16250, 16256);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 15240, 17049);

                            case IParameterInitializerOperation parameterInitializerOperation:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 15240, 17049);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 16580, 16998) || true) && ((f_25006_16585_16641(f_25006_16585_16624(parameterInitializerOperation)) is IMethodSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(25006, 16584, 16806) && f_25006_16692_16778(((IMethodSymbol)(f_25006_16709_16765(f_25006_16709_16748(parameterInitializerOperation))))) != MethodKind.LocalFunction))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25006, 16580, 16998);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 16864, 16971);

                                    f_25006_16864_16970(compilation, f_25006_16915_16951(root), associatedSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 16580, 16998);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(25006, 17024, 17030);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25006, 15240, 17049);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25006, 15138, 17064);

                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25006_15489_15510(Microsoft.CodeAnalysis.Operations.IBlockOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 15489, 15510);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxTree
                        f_25006_15489_15521(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.SyntaxTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 15489, 15521);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ParseOptions
                        f_25006_15489_15529(Microsoft.CodeAnalysis.SyntaxTree
                        this_param)
                        {
                            var return_v = this_param.Options;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 15489, 15529);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SourceCodeKind
                        f_25006_15489_15534(Microsoft.CodeAnalysis.ParseOptions
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 15489, 15534);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        f_25006_15668_15714(Microsoft.CodeAnalysis.Operations.IBlockOperation
                        body)
                        {
                            var return_v = ControlFlowGraphBuilder.Create((Microsoft.CodeAnalysis.IOperation)body);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 15668, 15714);
                            return return_v;
                        }


                        string
                        f_25006_15617_15733(Microsoft.CodeAnalysis.Compilation
                        compilation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        graph, Microsoft.CodeAnalysis.ISymbol
                        associatedSymbol)
                        {
                            var return_v = ControlFlowGraphVerifier.GetFlowGraph(compilation, graph, associatedSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 15617, 15733);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        f_25006_16168_16204(Microsoft.CodeAnalysis.IOperation
                        body)
                        {
                            var return_v = ControlFlowGraphBuilder.Create(body);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 16168, 16204);
                            return return_v;
                        }


                        string
                        f_25006_16117_16223(Microsoft.CodeAnalysis.Compilation
                        compilation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        graph, Microsoft.CodeAnalysis.ISymbol
                        associatedSymbol)
                        {
                            var return_v = ControlFlowGraphVerifier.GetFlowGraph(compilation, graph, associatedSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 16117, 16223);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IParameterSymbol
                        f_25006_16585_16624(Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation
                        this_param)
                        {
                            var return_v = this_param.Parameter;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 16585, 16624);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_25006_16585_16641(Microsoft.CodeAnalysis.IParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 16585, 16641);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IParameterSymbol
                        f_25006_16709_16748(Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation
                        this_param)
                        {
                            var return_v = this_param.Parameter;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 16709, 16748);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_25006_16709_16765(Microsoft.CodeAnalysis.IParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 16709, 16765);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MethodKind
                        f_25006_16692_16778(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.MethodKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 16692, 16778);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        f_25006_16915_16951(Microsoft.CodeAnalysis.IOperation
                        body)
                        {
                            var return_v = ControlFlowGraphBuilder.Create(body);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 16915, 16951);
                            return return_v;
                        }


                        string
                        f_25006_16864_16970(Microsoft.CodeAnalysis.Compilation
                        compilation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        graph, Microsoft.CodeAnalysis.ISymbol
                        associatedSymbol)
                        {
                            var return_v = ControlFlowGraphVerifier.GetFlowGraph(compilation, graph, associatedSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 16864, 16970);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 15138, 17064);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 15138, 17064);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25006, 11513, 17075);

                bool
                f_25006_11617_11640_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 11617, 11640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_25006_11730_11749(System.Func<Microsoft.CodeAnalysis.Compilation>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 11730, 11749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.ISymbol associatedSymbol)>
                f_25006_11776_11852()
                {
                    var return_v = ArrayBuilder<(IOperation operation, ISymbol associatedSymbol)>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 11776, 11852);
                    return return_v;
                }


                System.Diagnostics.Stopwatch
                f_25006_11883_11898()
                {
                    var return_v = new System.Diagnostics.Stopwatch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 11883, 11898);
                    return return_v;
                }


                bool
                f_25006_11917_11956_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 11917, 11956);
                    return return_v;
                }


                int
                f_25006_11990_12007(System.Diagnostics.Stopwatch
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 11990, 12007);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_25006_12321_12344(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 12321, 12344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_25006_12398_12432(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 12398, 12432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25006_12462_12476(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 12462, 12476);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_25006_12518_12547(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodesAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 12518, 12547);
                    return return_v;
                }


                int
                f_25006_12589_12603()
                {
                    checkTimeout();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 12589, 12603);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25006_12644_12676(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetOperation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 12644, 12676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25006_12966_12982(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 12966, 12982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25006_13016_13032(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 13016, 13032);
                    return return_v;
                }


                bool
                f_25006_12940_13035(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 12940, 13035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25006_13082_13096(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 13082, 13096);
                    return return_v;
                }


                bool
                f_25006_13109_13137(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = operation.MustHaveNullType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 13109, 13137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25006_13168_13182(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 13168, 13182);
                    return return_v;
                }


                bool
                f_25006_13064_13185(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 13064, 13185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_25006_13247_13270(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.SemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 13247, 13270);
                    return return_v;
                }


                bool
                f_25006_13214_13271(Microsoft.CodeAnalysis.SemanticModel
                expected, Microsoft.CodeAnalysis.SemanticModel?
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 13214, 13271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_25006_13334_13376(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 13334, 13376);
                    return return_v;
                }


                bool
                f_25006_13298_13377(Microsoft.CodeAnalysis.SemanticModel
                expected, Microsoft.CodeAnalysis.SemanticModel?
                actual)
                {
                    var return_v = CustomAssert.NotSame((object)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 13298, 13377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_25006_13425_13467(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 13425, 13467);
                    return return_v;
                }


                bool
                f_25006_13404_13468(Microsoft.CodeAnalysis.SemanticModel?
                @object)
                {
                    var return_v = CustomAssert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 13404, 13468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_25006_13528_13570(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 13528, 13570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_25006_13528_13592(Microsoft.CodeAnalysis.SemanticModel?
                this_param)
                {
                    var return_v = this_param.ContainingModelOrSelf;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 13528, 13592);
                    return return_v;
                }


                bool
                f_25006_13495_13593(Microsoft.CodeAnalysis.SemanticModel
                expected, Microsoft.CodeAnalysis.SemanticModel
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 13495, 13593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_25006_13653_13688(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.ContainingModelOrSelf;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 13653, 13688);
                    return return_v;
                }


                bool
                f_25006_13620_13689(Microsoft.CodeAnalysis.SemanticModel
                expected, Microsoft.CodeAnalysis.SemanticModel
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 13620, 13689);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25006_13722_13738(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 13722, 13738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25006_13858_13874(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 13858, 13874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_25006_13826_13875(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                declaration)
                {
                    var return_v = semanticModel.GetDeclaredSymbol(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 13826, 13875);
                    return return_v;
                }


                int
                f_25006_13804_13877(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.ISymbol associatedSymbol)>
                this_param, (Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.ISymbol?)
                item)
                {
                    this_param.Add(((Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.ISymbol associatedSymbol))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 13804, 13877);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_25006_12518_12547_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 12518, 12547);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_25006_12321_12344_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 12321, 12344);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                f_25006_14000_14040()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 14000, 14040);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25006_14222_14247(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = operation.DescendantsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 14222, 14247);
                    return return_v;
                }


                int
                f_25006_14289_14303()
                {
                    checkTimeout();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 14289, 14303);
                    return 0;
                }


                bool
                f_25006_14332_14353_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 14332, 14353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25006_14483_14499(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 14483, 14499);
                    return return_v;
                }


                int
                f_25006_14463_14511(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key, Microsoft.CodeAnalysis.IOperation
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 14463, 14511);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25006_14711_14727(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 14711, 14727);
                    return return_v;
                }


                int
                f_25006_14711_14735(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 14711, 14735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25006_14740_14756(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25006, 14740, 14756);
                    return return_v;
                }


                string
                f_25006_14740_14767(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 14740, 14767);
                    return return_v;
                }


                bool
                f_25006_14647_14770(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 14647, 14770);
                    return return_v;
                }


                int
                f_25006_14845_14869(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    this_param.Visit(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 14845, 14869);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25006_14222_14247_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 14222, 14247);
                    return return_v;
                }


                int
                f_25006_14909_14925(System.Diagnostics.Stopwatch
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 14909, 14925);
                    return 0;
                }


                int
                f_25006_14944_14989(Microsoft.CodeAnalysis.IOperation
                root, Microsoft.CodeAnalysis.ISymbol
                associatedSymbol)
                {
                    checkControlFlowGraph(root, associatedSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 14944, 14989);
                    return 0;
                }


                int
                f_25006_15008_15025(System.Diagnostics.Stopwatch
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 15008, 15025);
                    return 0;
                }


                int
                f_25006_15057_15069(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.ISymbol associatedSymbol)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 15057, 15069);
                    return 0;
                }


                int
                f_25006_15084_15100(System.Diagnostics.Stopwatch
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 15084, 15100);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 11513, 17075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 11513, 17075);
            }
        }

        public static PortableExecutableReference CreateWindowsRuntimeMetadataReference()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25006, 17410, 19401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 17516, 18621);

                var
                source = @"
namespace System.Runtime.InteropServices.WindowsRuntime
{
    public struct EventRegistrationToken { }

    public sealed class EventRegistrationTokenTable<T> where T : class
    {
        public T InvocationList { get; set; }

        public static EventRegistrationTokenTable<T> GetOrCreateEventRegistrationTokenTable(ref EventRegistrationTokenTable<T> refEventTable)
        {
            throw null;
        }

        public void RemoveEventHandler(EventRegistrationToken token)
        {
        }

        public void RemoveEventHandler(T handler)
        {
        }
    }

    public static class WindowsRuntimeMarshal
    {
        public static void AddEventHandler<T>(Func<T, EventRegistrationToken> addMethod, Action<EventRegistrationToken> removeMethod, T handler)
        {
        }

        public static void RemoveAllEventHandlers(Action<EventRegistrationToken> removeMethod)
        {
        }

        public static void RemoveEventHandler<T>(Action<EventRegistrationToken> removeMethod, T handler)
        {
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 18913, 19271);

                var
                compilation = f_25006_18931_19270("System.Runtime.InteropServices.WindowsRuntime", new[] { f_25006_19048_19082(source) }, references: f_25006_19115_19176(TargetFramework.NetCoreApp), options: f_25006_19204_19269(OutputKind.DynamicallyLinkedLibrary))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 19285, 19321);

                f_25006_19285_19320(compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 19335, 19390);

                return f_25006_19342_19389(compilation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25006, 17410, 19401);

                Microsoft.CodeAnalysis.SyntaxTree
                f_25006_19048_19082(string
                text)
                {
                    var return_v = CSharpSyntaxTree.ParseText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 19048, 19082);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_25006_19115_19176(Roslyn.Test.Utilities.TargetFramework
                targetFramework)
                {
                    var return_v = TargetFrameworkUtil.GetReferences(targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 19115, 19176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_25006_19204_19269(Microsoft.CodeAnalysis.OutputKind
                outputKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions(outputKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 19204, 19269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_25006_18931_19270(string
                assemblyName, Microsoft.CodeAnalysis.SyntaxTree[]
                syntaxTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CSharpCompilation.Create(assemblyName, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 18931, 19270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_25006_19285_19320(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 19285, 19320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_25006_19342_19389(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToPortableExecutableReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 19342, 19389);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25006, 17410, 19401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 17410, 19401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompilationExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25006, 928, 19408);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25006, 986, 1125);
            EnableVerifyIOperation = !f_25006_1042_1124(f_25006_1063_1123("ROSLYN_TEST_IOPERATION")); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25006, 928, 19408);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25006, 928, 19408);
        }


        static string?
        f_25006_1063_1123(string
        variable)
        {
            var return_v = Environment.GetEnvironmentVariable(variable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 1063, 1123);
            return return_v;
        }


        static bool
        f_25006_1042_1124(string?
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 1042, 1124);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25006_4318_4412(Microsoft.CodeAnalysis.Compilation
        comp, Microsoft.CodeAnalysis.Emit.EmitOptions?
        options, bool
        embedInteropTypes, System.Collections.Immutable.ImmutableArray<string>
        aliases, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]?
        expectedWarnings)
        {
            var return_v = comp.EmitToPortableExecutableReference(options, embedInteropTypes, aliases, expectedWarnings);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25006, 4318, 4412);
            return return_v;
        }

    }
}
