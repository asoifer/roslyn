// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis
{
    internal abstract class CommonSyntaxAndDeclarationManager
    {
        internal readonly ImmutableArray<SyntaxTree> ExternalSyntaxTrees;

        internal readonly string ScriptClassName;

        internal readonly SourceReferenceResolver Resolver;

        internal readonly CommonMessageProvider MessageProvider;

        internal readonly bool IsSubmission;

        public CommonSyntaxAndDeclarationManager(
                    ImmutableArray<SyntaxTree> externalSyntaxTrees,
                    string scriptClassName,
                    SourceReferenceResolver resolver,
                    CommonMessageProvider messageProvider,
                    bool isSubmission)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(144, 663, 1214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(144, 462, 477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(144, 530, 538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(144, 589, 604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(144, 638, 650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(144, 958, 1005);

                this.ExternalSyntaxTrees = externalSyntaxTrees;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(144, 1019, 1064);

                this.ScriptClassName = scriptClassName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(144, 1042, 1063) ?? "");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(144, 1078, 1103);

                this.Resolver = resolver;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(144, 1117, 1156);

                this.MessageProvider = messageProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(144, 1170, 1203);

                this.IsSubmission = isSubmission;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(144, 663, 1214);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(144, 663, 1214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(144, 663, 1214);
            }
        }

        static CommonSyntaxAndDeclarationManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(144, 288, 1221);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(144, 288, 1221);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(144, 288, 1221);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(144, 288, 1221);
    }
}
