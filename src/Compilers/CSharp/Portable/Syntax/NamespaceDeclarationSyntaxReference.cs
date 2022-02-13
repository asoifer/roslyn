// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class NamespaceDeclarationSyntaxReference : TranslationSyntaxReference
    {
        public NamespaceDeclarationSyntaxReference(SyntaxReference reference)
        : base(f_10784_820_829_C(reference))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10784, 730, 852);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10784, 730, 852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10784, 730, 852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10784, 730, 852);
            }
        }

        protected override SyntaxNode Translate(SyntaxReference reference, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10784, 864, 1050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10784, 992, 1039);

                return f_10784_999_1038(reference, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10784, 864, 1050);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10784_999_1038(Microsoft.CodeAnalysis.SyntaxReference
                reference, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = GetSyntax(reference, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10784, 999, 1038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10784, 864, 1050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10784, 864, 1050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxNode GetSyntax(SyntaxReference reference, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10784, 1062, 1691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10784, 1187, 1255);

                var
                node = (CSharpSyntaxNode)f_10784_1216_1254(reference, cancellationToken)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10784, 1461, 1554) || true) && (node is NameSyntax)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10784, 1461, 1554);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10784, 1520, 1539);

                        node = f_10784_1527_1538(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10784, 1461, 1554);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10784, 1461, 1554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10784, 1461, 1554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10784, 1570, 1652);

                f_10784_1570_1651(node is CompilationUnitSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10784, 1583, 1650) || node is NamespaceDeclarationSyntax));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10784, 1668, 1680);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10784, 1062, 1691);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10784_1216_1254(Microsoft.CodeAnalysis.SyntaxReference
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSyntax(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10784, 1216, 1254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10784_1527_1538(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10784, 1527, 1538);
                    return return_v;
                }


                int
                f_10784_1570_1651(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10784, 1570, 1651);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10784, 1062, 1691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10784, 1062, 1691);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NamespaceDeclarationSyntaxReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10784, 627, 1698);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10784, 627, 1698);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10784, 627, 1698);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10784, 627, 1698);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10784_820_829_C(Microsoft.CodeAnalysis.SyntaxReference
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10784, 730, 852);
            return return_v;
        }

    }
}
