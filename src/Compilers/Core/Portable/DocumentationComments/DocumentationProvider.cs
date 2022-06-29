// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Globalization;
using System.Threading;

namespace Microsoft.CodeAnalysis
{
    public abstract partial class DocumentationProvider
    {
        public static DocumentationProvider Default { get; }

        protected DocumentationProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(279, 780, 835);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(279, 780, 835);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(279, 780, 835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(279, 780, 835);
            }
        }

        protected internal abstract string? GetDocumentationForSymbol(
                    string documentationMemberID,
                    CultureInfo preferredCulture,
                    CancellationToken cancellationToken = default);

        public abstract override bool Equals(object? obj);

        public abstract override int GetHashCode();

        static DocumentationProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(279, 613, 2793);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(279, 681, 768);
            Default = f_279_736_767(); 
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(279, 613, 2793);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(279, 613, 2793);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(279, 613, 2793);

        static Microsoft.CodeAnalysis.DocumentationProvider.NullDocumentationProvider
        f_279_736_767()
        {
            var return_v = new Microsoft.CodeAnalysis.DocumentationProvider.NullDocumentationProvider();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(279, 736, 767);
            return return_v;
        }

    }
}
