// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class CSharpSyntaxTree
    {
        private class DebuggerSyntaxTree : ParsedSyntaxTree
        {
            public DebuggerSyntaxTree(CSharpSyntaxNode root, SourceText text, CSharpParseOptions options)
            : base(
            f_10754_564_568_C(text), f_10754_591_604(text), f_10754_627_649(text), path: "", options: options, root: root, directives: Syntax.InternalSyntax.DirectiveStack.Empty, diagnosticOptions: null, cloneRoot: true)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10754, 424, 944);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10754, 424, 944);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10754, 424, 944);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10754, 424, 944);
                }
            }

            internal override bool SupportsLocations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10754, 1033, 1053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10754, 1039, 1051);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10754, 1033, 1053);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10754, 960, 1068);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10754, 960, 1068);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static DebuggerSyntaxTree()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10754, 348, 1079);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10754, 348, 1079);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10754, 348, 1079);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10754, 348, 1079);

            static System.Text.Encoding?
            f_10754_591_604(Microsoft.CodeAnalysis.Text.SourceText
            this_param)
            {
                var return_v = this_param.Encoding;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10754, 591, 604);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
            f_10754_627_649(Microsoft.CodeAnalysis.Text.SourceText
            this_param)
            {
                var return_v = this_param.ChecksumAlgorithm;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10754, 627, 649);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Text.SourceText
            f_10754_564_568_C(Microsoft.CodeAnalysis.Text.SourceText
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10754, 424, 944);
                return return_v;
            }

        }
    }
}
