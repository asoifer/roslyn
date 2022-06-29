// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public static class FileSystemExtensions
    {
        public static EmitResult Emit(
                    this Compilation compilation,
                    string outputPath,
                    string? pdbPath = null,
                    string? xmlDocPath = null,
                    string? win32ResourcesPath = null,
                    IEnumerable<ResourceDescription>? manifestResources = null,
                    CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(18, 1815, 3401);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(18, 2203, 2328) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(18, 2203, 2328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(18, 2260, 2313);

                    throw f_18_2266_2312(nameof(compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(18, 2203, 2328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(18, 2344, 3390);
                using (var
                outputStream = f_18_2370_2452(File.Create, outputPath, nameof(outputPath))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(18, 2467, 3390);
                    using (var
                    pdbStream = ((DynAbs.Tracing.TraceSender.Conditional_F1(18, 2491, 2506) || ((pdbPath == null && DynAbs.Tracing.TraceSender.Conditional_F2(18, 2509, 2513)) || DynAbs.Tracing.TraceSender.Conditional_F3(18, 2516, 2592))) ? null : f_18_2516_2592(File.Create, pdbPath, nameof(pdbPath)))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(18, 2608, 3390);
                        using (var
                        xmlDocStream = ((DynAbs.Tracing.TraceSender.Conditional_F1(18, 2635, 2653) || ((xmlDocPath == null && DynAbs.Tracing.TraceSender.Conditional_F2(18, 2656, 2660)) || DynAbs.Tracing.TraceSender.Conditional_F3(18, 2663, 2745))) ? null : f_18_2663_2745(File.Create, xmlDocPath, nameof(xmlDocPath)))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(18, 2761, 3390);
                            using (var
                            win32ResourcesStream = ((DynAbs.Tracing.TraceSender.Conditional_F1(18, 2796, 2822) || ((win32ResourcesPath == null && DynAbs.Tracing.TraceSender.Conditional_F2(18, 2825, 2829)) || DynAbs.Tracing.TraceSender.Conditional_F3(18, 2832, 2932))) ? null : f_18_2832_2932(File.OpenRead, win32ResourcesPath, nameof(win32ResourcesPath)))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(18, 2967, 3375);

                                return f_18_2974_3374(compilation, outputStream, pdbStream: pdbStream, xmlDocumentationStream: xmlDocStream, win32Resources: win32ResourcesStream, manifestResources: manifestResources, options: f_18_3277_3314(pdbFilePath: pdbPath), cancellationToken: cancellationToken);
                                DynAbs.Tracing.TraceSender.TraceExitUsing(18, 2761, 3390);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitUsing(18, 2608, 3390);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(18, 2467, 3390);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(18, 2344, 3390);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(18, 1815, 3401);

                System.ArgumentNullException
                f_18_2266_2312(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(18, 2266, 2312);
                    return return_v;
                }


                System.IO.Stream
                f_18_2370_2452(System.Func<string, System.IO.Stream>
                factory, string
                path, string
                paramName)
                {
                    var return_v = FileUtilities.CreateFileStreamChecked(factory, path, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(18, 2370, 2452);
                    return return_v;
                }


                System.IO.Stream
                f_18_2516_2592(System.Func<string, System.IO.Stream>
                factory, string
                path, string
                paramName)
                {
                    var return_v = FileUtilities.CreateFileStreamChecked(factory, path, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(18, 2516, 2592);
                    return return_v;
                }


                System.IO.Stream
                f_18_2663_2745(System.Func<string, System.IO.Stream>
                factory, string
                path, string
                paramName)
                {
                    var return_v = FileUtilities.CreateFileStreamChecked(factory, path, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(18, 2663, 2745);
                    return return_v;
                }


                System.IO.Stream
                f_18_2832_2932(System.Func<string, System.IO.Stream>
                factory, string
                path, string
                paramName)
                {
                    var return_v = FileUtilities.CreateFileStreamChecked(factory, path, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(18, 2832, 2932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_18_3277_3314(string?
                pdbFilePath)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitOptions(pdbFilePath: pdbFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(18, 3277, 3314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_18_2974_3374(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.Stream
                peStream, System.IO.Stream?
                pdbStream, System.IO.Stream?
                xmlDocumentationStream, System.IO.Stream?
                win32Resources, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                options, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.Emit(peStream, pdbStream: pdbStream, xmlDocumentationStream: xmlDocumentationStream, win32Resources: win32Resources, manifestResources: manifestResources, options: options, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(18, 2974, 3374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(18, 1815, 3401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(18, 1815, 3401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FileSystemExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(18, 405, 3408);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(18, 405, 3408);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(18, 405, 3408);
        }

    }
}
