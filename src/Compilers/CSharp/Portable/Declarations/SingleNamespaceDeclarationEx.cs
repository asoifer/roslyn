// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SingleNamespaceDeclarationEx : SingleNamespaceDeclaration
    {
        private readonly bool _hasUsings;

        private readonly bool _hasExternAliases;

        public SingleNamespaceDeclarationEx(
                    string name, bool hasUsings, bool hasExternAliases,
                    SyntaxReference syntaxReference, SourceLocation nameLocation,
                    ImmutableArray<SingleNamespaceOrTypeDeclaration> children,
                    ImmutableArray<Diagnostic> diagnostics)
        : base(f_10398_829_833_C(name), syntaxReference, nameLocation, children, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10398, 507, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10398, 434, 444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10398, 477, 494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10398, 913, 936);

                _hasUsings = hasUsings;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10398, 950, 987);

                _hasExternAliases = hasExternAliases;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10398, 507, 998);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10398, 507, 998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10398, 507, 998);
            }
        }

        public override bool HasUsings
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10398, 1065, 1134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10398, 1101, 1119);

                    return _hasUsings;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10398, 1065, 1134);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10398, 1010, 1145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10398, 1010, 1145);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasExternAliases
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10398, 1219, 1295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10398, 1255, 1280);

                    return _hasExternAliases;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10398, 1219, 1295);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10398, 1157, 1306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10398, 1157, 1306);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SingleNamespaceDeclarationEx()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10398, 316, 1313);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10398, 316, 1313);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10398, 316, 1313);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10398, 316, 1313);

        static string
        f_10398_829_833_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10398, 507, 998);
            return return_v;
        }

    }
}
