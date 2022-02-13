// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.DiaSymReader.Tools;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    [Flags]
    public enum PdbValidationOptions
    {
        Default = 0,
        SkipConversionValidation = 1,
        ExcludeDocuments = PdbToXmlOptions.ExcludeDocuments,
        ExcludeMethods = PdbToXmlOptions.ExcludeMethods,
        ExcludeSequencePoints = PdbToXmlOptions.ExcludeSequencePoints,
        ExcludeScopes = PdbToXmlOptions.ExcludeScopes,
        ExcludeNamespaces = PdbToXmlOptions.ExcludeNamespaces,
        ExcludeAsyncInfo = PdbToXmlOptions.ExcludeAsyncInfo,
        ExcludeCustomDebugInformation = PdbToXmlOptions.ExcludeCustomDebugInformation
    }
    public static class PdbValidationOptionsExtensions
    {
        public static PdbToXmlOptions ToPdbToXmlOptions(this PdbValidationOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24007, 995, 1719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24007, 1102, 1547);

                const PdbValidationOptions
                mask =
                                PdbValidationOptions.ExcludeDocuments |
                                PdbValidationOptions.ExcludeMethods |
                                PdbValidationOptions.ExcludeSequencePoints |
                                PdbValidationOptions.ExcludeScopes |
                                PdbValidationOptions.ExcludeNamespaces |
                                PdbValidationOptions.ExcludeAsyncInfo |
                                PdbValidationOptions.ExcludeCustomDebugInformation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24007, 1563, 1708);

                return PdbToXmlOptions.ResolveTokens | PdbToXmlOptions.ThrowOnError | PdbToXmlOptions.IncludeEmbeddedSources | (PdbToXmlOptions)(options & mask);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24007, 995, 1719);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24007, 995, 1719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24007, 995, 1719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PdbValidationOptionsExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24007, 928, 1726);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24007, 928, 1726);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24007, 928, 1726);
        }

    }
}
