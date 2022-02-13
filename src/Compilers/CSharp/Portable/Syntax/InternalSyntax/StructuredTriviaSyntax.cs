// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal abstract partial class StructuredTriviaSyntax : CSharpSyntaxNode
    {
        internal StructuredTriviaSyntax(SyntaxKind kind, DiagnosticInfo[] diagnostics = null, SyntaxAnnotation[] annotations = null)
        : base(f_10826_561_565_C(kind), diagnostics, annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10826, 416, 646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10826, 617, 635);

                f_10826_617_634(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10826, 416, 646);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10826, 416, 646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10826, 416, 646);
            }
        }

        internal StructuredTriviaSyntax(ObjectReader reader)
        : base(f_10826_731_737_C(reader))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10826, 658, 792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10826, 763, 781);

                f_10826_763_780(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10826, 658, 792);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10826, 658, 792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10826, 658, 792);
            }
        }

        private void Initialize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10826, 804, 1070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10826, 854, 903);

                this.flags |= NodeFlags.ContainsStructuredTrivia;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10826, 919, 1059) || true) && (f_10826_923_932(this) == SyntaxKind.SkippedTokensTrivia)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10826, 919, 1059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10826, 1000, 1044);

                    this.flags |= NodeFlags.ContainsSkippedText;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10826, 919, 1059);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10826, 804, 1070);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10826_923_932(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.StructuredTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10826, 923, 932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10826, 804, 1070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10826, 804, 1070);
            }
        }

        static StructuredTriviaSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10826, 326, 1077);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10826, 326, 1077);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10826, 326, 1077);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10826, 326, 1077);

        int
        f_10826_617_634(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.StructuredTriviaSyntax
        this_param)
        {
            this_param.Initialize();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10826, 617, 634);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10826_561_565_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10826, 416, 646);
            return return_v;
        }


        int
        f_10826_763_780(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.StructuredTriviaSyntax
        this_param)
        {
            this_param.Initialize();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10826, 763, 780);
            return 0;
        }


        static Roslyn.Utilities.ObjectReader
        f_10826_731_737_C(Roslyn.Utilities.ObjectReader
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10826, 658, 792);
            return return_v;
        }

    }
}
