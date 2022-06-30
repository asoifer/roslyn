// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal abstract class TranslationSyntaxReference : SyntaxReference
    {
        private readonly SyntaxReference _reference;

        protected TranslationSyntaxReference(SyntaxReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(712, 681, 803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(712, 658, 668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(712, 769, 792);

                _reference = reference;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(712, 681, 803);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(712, 681, 803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(712, 681, 803);
            }
        }

        public sealed override TextSpan Span
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(712, 876, 907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(712, 882, 905);

                    return f_712_889_904(_reference);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(712, 876, 907);

                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_712_889_904(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.Span;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(712, 889, 904);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(712, 815, 918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(712, 815, 918);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override SyntaxTree SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(712, 999, 1036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(712, 1005, 1034);

                    return f_712_1012_1033(_reference);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(712, 999, 1036);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_712_1012_1033(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(712, 1012, 1033);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(712, 930, 1047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(712, 930, 1047);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override SyntaxNode GetSyntax(CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(712, 1059, 1351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(712, 1193, 1245);

                var
                node = f_712_1204_1244(this, _reference, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(712, 1259, 1314);

                f_712_1259_1313(f_712_1272_1287(node) == f_712_1291_1312(_reference));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(712, 1328, 1340);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(712, 1059, 1351);

                Microsoft.CodeAnalysis.SyntaxNode
                f_712_1204_1244(Microsoft.CodeAnalysis.Syntax.TranslationSyntaxReference
                this_param, Microsoft.CodeAnalysis.SyntaxReference
                reference, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.Translate(reference, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(712, 1204, 1244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_712_1272_1287(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(712, 1272, 1287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_712_1291_1312(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(712, 1291, 1312);
                    return return_v;
                }


                int
                f_712_1259_1313(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(712, 1259, 1313);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(712, 1059, 1351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(712, 1059, 1351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract SyntaxNode Translate(SyntaxReference reference, CancellationToken cancellationToken);

        static TranslationSyntaxReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(712, 540, 1474);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(712, 540, 1474);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(712, 540, 1474);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(712, 540, 1474);
    }
}
