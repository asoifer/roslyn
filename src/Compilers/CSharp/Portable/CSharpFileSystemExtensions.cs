// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis.CSharp
{
    public static class CSharpFileSystemExtensions
    {
        public static EmitResult Emit(
                    this CSharpCompilation compilation,
                    string outputPath,
                    string? pdbPath = null,
                    string? xmlDocumentationPath = null,
                    string? win32ResourcesPath = null,
                    IEnumerable<ResourceDescription>? manifestResources = null,
                    CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10974, 1810, 2372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10974, 2214, 2361);

                return f_10974_2221_2360(compilation, outputPath, pdbPath, xmlDocumentationPath, win32ResourcesPath, manifestResources, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10974, 1810, 2372);

                Microsoft.CodeAnalysis.Emit.EmitResult
                f_10974_2221_2360(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                outputPath, string?
                pdbPath, string?
                xmlDocPath, string?
                win32ResourcesPath, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = compilation.Emit(outputPath, pdbPath, xmlDocPath, win32ResourcesPath, manifestResources, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10974, 2221, 2360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10974, 1810, 2372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10974, 1810, 2372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpFileSystemExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10974, 387, 2379);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10974, 387, 2379);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10974, 387, 2379);
        }

    }
}
