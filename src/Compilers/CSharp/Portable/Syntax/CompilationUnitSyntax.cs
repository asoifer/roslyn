// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public sealed partial class CompilationUnitSyntax : CSharpSyntaxNode, ICompilationUnitSyntax
    {
        public IList<ReferenceDirectiveTriviaSyntax> GetReferenceDirectives()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10047, 536, 677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 630, 666);

                return f_10047_637_665(this, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10047, 536, 677);

                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax>
                f_10047_637_665(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax, bool>?
                filter)
                {
                    var return_v = this_param.GetReferenceDirectives(filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10047, 637, 665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10047, 536, 677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10047, 536, 677);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IList<ReferenceDirectiveTriviaSyntax> GetReferenceDirectives(Func<ReferenceDirectiveTriviaSyntax, bool>? filter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10047, 689, 1096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 920, 999);

                var
                firstToken = (SyntaxNodeOrToken)f_10047_956_998(this, includeZeroWidth: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 1013, 1085);

                return firstToken.GetDirectives<ReferenceDirectiveTriviaSyntax>(filter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10047, 689, 1096);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10047_956_998(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param, bool
                includeZeroWidth)
                {
                    var return_v = this_param.GetFirstToken(includeZeroWidth: includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10047, 956, 998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10047, 689, 1096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10047, 689, 1096);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IList<LoadDirectiveTriviaSyntax> GetLoadDirectives()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10047, 1223, 1572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 1395, 1474);

                var
                firstToken = (SyntaxNodeOrToken)f_10047_1431_1473(this, includeZeroWidth: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 1488, 1561);

                return firstToken.GetDirectives<LoadDirectiveTriviaSyntax>(filter: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10047, 1223, 1572);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10047_1431_1473(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param, bool
                includeZeroWidth)
                {
                    var return_v = this_param.GetFirstToken(includeZeroWidth: includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10047, 1431, 1473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10047, 1223, 1572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10047, 1223, 1572);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Syntax.InternalSyntax.DirectiveStack GetConditionalDirectivesStack()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10047, 1584, 2203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 1686, 1791);

                IEnumerable<DirectiveTriviaSyntax>
                directives = f_10047_1734_1790(this, filter: IsActiveConditionalDirective)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 1805, 1869);

                var
                directiveStack = Syntax.InternalSyntax.DirectiveStack.Empty
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 1883, 2156);
                    foreach (DirectiveTriviaSyntax directive in f_10047_1927_1937_I(directives))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10047, 1883, 2156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 1971, 2056);

                        var
                        internalDirective = (Syntax.InternalSyntax.DirectiveTriviaSyntax)f_10047_2040_2055(directive)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 2074, 2141);

                        directiveStack = f_10047_2091_2140(internalDirective, directiveStack);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10047, 1883, 2156);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10047, 1, 274);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10047, 1, 274);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 2170, 2192);

                return directiveStack;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10047, 1584, 2203);

                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10047_1734_1790(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>
                filter)
                {
                    var return_v = this_param.GetDirectives(filter: filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10047, 1734, 1790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10047_2040_2055(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10047, 2040, 2055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10047_2091_2140(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                stack)
                {
                    var return_v = this_param.ApplyDirectives(stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10047, 2091, 2140);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10047_1927_1937_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10047, 1927, 1937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10047, 1584, 2203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10047, 1584, 2203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsActiveConditionalDirective(DirectiveTriviaSyntax directive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10047, 2215, 2716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 2321, 2705);

                switch (f_10047_2329_2345(directive))
                {

                    case SyntaxKind.DefineDirectiveTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10047, 2321, 2705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 2439, 2496);

                        return f_10047_2446_2495(((DefineDirectiveTriviaSyntax)directive));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10047, 2321, 2705);

                    case SyntaxKind.UndefDirectiveTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10047, 2321, 2705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 2573, 2629);

                        return f_10047_2580_2628(((UndefDirectiveTriviaSyntax)directive));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10047, 2321, 2705);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10047, 2321, 2705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10047, 2677, 2690);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10047, 2321, 2705);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10047, 2215, 2716);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10047_2329_2345(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10047, 2329, 2345);
                    return return_v;
                }


                bool
                f_10047_2446_2495(Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.IsActive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10047, 2446, 2495);
                    return return_v;
                }


                bool
                f_10047_2580_2628(Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.IsActive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10047, 2580, 2628);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10047, 2215, 2716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10047, 2215, 2716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompilationUnitSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10047, 315, 2723);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10047, 315, 2723);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10047, 315, 2723);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10047, 315, 2723);
    }
}
