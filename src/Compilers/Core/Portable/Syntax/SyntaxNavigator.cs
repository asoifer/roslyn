// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal sealed class SyntaxNavigator
    {
        private const int
        None = 0
        ;

        public static readonly SyntaxNavigator Instance;

        private SyntaxNavigator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(686, 575, 622);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(686, 575, 622);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 575, 622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 575, 622);
            }
        }

        [Flags]
        private enum SyntaxKinds
        {
            DocComments = 1,
            Directives = 2,
            SkippedTokens = 4,
        }

        private static readonly Func<SyntaxTrivia, bool>?[] s_stepIntoFunctions;

        private static Func<SyntaxTrivia, bool>? GetStepIntoFunction(
                    bool skipped, bool directives, bool docComments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(686, 1578, 1984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 1726, 1920);

                var
                index = ((DynAbs.Tracing.TraceSender.Conditional_F1(686, 1739, 1746) || ((skipped && DynAbs.Tracing.TraceSender.Conditional_F2(686, 1749, 1774)) || DynAbs.Tracing.TraceSender.Conditional_F3(686, 1777, 1778))) ? SyntaxKinds.SkippedTokens : 0) |
                                        ((DynAbs.Tracing.TraceSender.Conditional_F1(686, 1808, 1818) || ((directives && DynAbs.Tracing.TraceSender.Conditional_F2(686, 1821, 1843)) || DynAbs.Tracing.TraceSender.Conditional_F3(686, 1846, 1847))) ? SyntaxKinds.Directives : 0) |
                                        ((DynAbs.Tracing.TraceSender.Conditional_F1(686, 1877, 1888) || ((docComments && DynAbs.Tracing.TraceSender.Conditional_F2(686, 1891, 1914)) || DynAbs.Tracing.TraceSender.Conditional_F3(686, 1917, 1918))) ? SyntaxKinds.DocComments : 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 1934, 1973);

                return s_stepIntoFunctions[(int)index];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(686, 1578, 1984);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 1578, 1984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 1578, 1984);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Func<SyntaxToken, bool> GetPredicateFunction(bool includeZeroWidth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(686, 1996, 2183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 2103, 2172);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(686, 2110, 2126) || ((includeZeroWidth && DynAbs.Tracing.TraceSender.Conditional_F2(686, 2129, 2144)) || DynAbs.Tracing.TraceSender.Conditional_F3(686, 2147, 2171))) ? SyntaxToken.Any : SyntaxToken.NonZeroWidth;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(686, 1996, 2183);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 1996, 2183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 1996, 2183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Matches(Func<SyntaxToken, bool>? predicate, SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(686, 2195, 2405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 2302, 2394);

                return predicate == null || (DynAbs.Tracing.TraceSender.Expression_False(686, 2309, 2373) || f_686_2330_2373(predicate, SyntaxToken.Any)) || (DynAbs.Tracing.TraceSender.Expression_False(686, 2309, 2393) || f_686_2377_2393(predicate, token));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(686, 2195, 2405);

                bool
                f_686_2330_2373(System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                objA, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 2330, 2373);
                    return return_v;
                }


                bool
                f_686_2377_2393(System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 2377, 2393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 2195, 2405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 2195, 2405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetFirstToken(in SyntaxNode current, bool includeZeroWidth, bool includeSkipped, bool includeDirectives, bool includeDocumentationComments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 2417, 2769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 2602, 2758);

                return f_686_2609_2757(this, current, f_686_2632_2670(includeZeroWidth), f_686_2672_2756(includeSkipped, includeDirectives, includeDocumentationComments));
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 2417, 2769);

                System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                f_686_2632_2670(bool
                includeZeroWidth)
                {
                    var return_v = GetPredicateFunction(includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 2632, 2670);
                    return return_v;
                }


                System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                f_686_2672_2756(bool
                skipped, bool
                directives, bool
                docComments)
                {
                    var return_v = GetStepIntoFunction(skipped, directives, docComments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 2672, 2756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_2609_2757(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetFirstToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 2609, 2757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 2417, 2769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 2417, 2769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetLastToken(in SyntaxNode current, bool includeZeroWidth, bool includeSkipped, bool includeDirectives, bool includeDocumentationComments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 2781, 3131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 2965, 3120);

                return f_686_2972_3119(this, current, f_686_2994_3032(includeZeroWidth), f_686_3034_3118(includeSkipped, includeDirectives, includeDocumentationComments));
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 2781, 3131);

                System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                f_686_2994_3032(bool
                includeZeroWidth)
                {
                    var return_v = GetPredicateFunction(includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 2994, 3032);
                    return return_v;
                }


                System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                f_686_3034_3118(bool
                skipped, bool
                directives, bool
                docComments)
                {
                    var return_v = GetStepIntoFunction(skipped, directives, docComments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 3034, 3118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_2972_3119(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetLastToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 2972, 3119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 2781, 3131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 2781, 3131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetPreviousToken(in SyntaxToken current, bool includeZeroWidth, bool includeSkipped, bool includeDirectives, bool includeDocumentationComments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 3143, 3502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 3332, 3491);

                return f_686_3339_3490(this, current, f_686_3365_3403(includeZeroWidth), f_686_3405_3489(includeSkipped, includeDirectives, includeDocumentationComments));
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 3143, 3502);

                System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                f_686_3365_3403(bool
                includeZeroWidth)
                {
                    var return_v = GetPredicateFunction(includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 3365, 3403);
                    return return_v;
                }


                System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                f_686_3405_3489(bool
                skipped, bool
                directives, bool
                docComments)
                {
                    var return_v = GetStepIntoFunction(skipped, directives, docComments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 3405, 3489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_3339_3490(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetPreviousToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 3339, 3490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 3143, 3502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 3143, 3502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetNextToken(in SyntaxToken current, bool includeZeroWidth, bool includeSkipped, bool includeDirectives, bool includeDocumentationComments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 3514, 3865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 3699, 3854);

                return f_686_3706_3853(this, current, f_686_3728_3766(includeZeroWidth), f_686_3768_3852(includeSkipped, includeDirectives, includeDocumentationComments));
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 3514, 3865);

                System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                f_686_3728_3766(bool
                includeZeroWidth)
                {
                    var return_v = GetPredicateFunction(includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 3728, 3766);
                    return return_v;
                }


                System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                f_686_3768_3852(bool
                skipped, bool
                directives, bool
                docComments)
                {
                    var return_v = GetStepIntoFunction(skipped, directives, docComments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 3768, 3852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_3706_3853(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetNextToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 3706, 3853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 3514, 3865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 3514, 3865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetPreviousToken(in SyntaxToken current, Func<SyntaxToken, bool> predicate, Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 3877, 4117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 4034, 4106);

                return f_686_4041_4105(this, current, predicate, stepInto != null, stepInto);
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 3877, 4117);

                Microsoft.CodeAnalysis.SyntaxToken
                f_686_4041_4105(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, bool
                searchInsideCurrentTokenLeadingTrivia, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetPreviousToken(current, predicate, searchInsideCurrentTokenLeadingTrivia, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 4041, 4105);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 3877, 4117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 3877, 4117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetNextToken(in SyntaxToken current, Func<SyntaxToken, bool> predicate, Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 4129, 4361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 4282, 4350);

                return f_686_4289_4349(this, current, predicate, stepInto != null, stepInto);
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 4129, 4361);

                Microsoft.CodeAnalysis.SyntaxToken
                f_686_4289_4349(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, bool
                searchInsideCurrentTokenTrailingTrivia, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetNextToken(current, predicate, searchInsideCurrentTokenTrailingTrivia, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 4289, 4349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 4129, 4361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 4129, 4361);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ObjectPool<Stack<ChildSyntaxList.Enumerator>> s_childEnumeratorStackPool
        ;

        internal SyntaxToken GetFirstToken(SyntaxNode current, Func<SyntaxToken, bool>? predicate, Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 4598, 6089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 4749, 4799);

                var
                stack = f_686_4761_4798(s_childEnumeratorStackPool)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 4849, 4907);

                    f_686_4849_4906(stack, f_686_4860_4889(current).GetEnumerator());
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 4927, 5888) || true) && (f_686_4934_4945(stack) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 4927, 5888);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 4991, 5012);

                            var
                            en = f_686_5000_5011(stack)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 5034, 5869) || true) && (en.MoveNext())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 5034, 5869);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 5101, 5124);

                                var
                                child = en.Current
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 5152, 5483) || true) && (child.IsToken)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 5152, 5483);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 5227, 5291);

                                    var
                                    token = f_686_5239_5290(this, child.AsToken(), predicate, stepInto)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 5321, 5456) || true) && (token.RawKind != None)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 5321, 5456);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 5412, 5425);

                                        return token;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 5321, 5456);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 5152, 5483);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 5579, 5594);

                                f_686_5579_5593(
                                                        // push this enumerator back, not done yet
                                                        stack, en);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 5622, 5846) || true) && (child.IsNode)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 5622, 5846);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 5696, 5723);

                                    f_686_5696_5722(child.IsNode);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 5753, 5819);

                                    f_686_5753_5818(stack, f_686_5764_5801(child.AsNode()!).GetEnumerator());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 5622, 5846);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 5034, 5869);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 4927, 5888);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(686, 4927, 5888);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(686, 4927, 5888);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 5908, 5923);

                    return default;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(686, 5952, 6078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 5992, 6006);

                    f_686_5992_6005(stack);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 6024, 6063);

                    f_686_6024_6062(s_childEnumeratorStackPool, stack);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(686, 5952, 6078);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 4598, 6089);

                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                f_686_4761_4798(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 4761, 4798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_686_4860_4889(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 4860, 4889);
                    return return_v;
                }


                int
                f_686_4849_4906(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                this_param, Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 4849, 4906);
                    return 0;
                }


                int
                f_686_4934_4945(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(686, 4934, 4945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator
                f_686_5000_5011(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 5000, 5011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_5239_5290(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetFirstToken(token, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 5239, 5290);
                    return return_v;
                }


                int
                f_686_5579_5593(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                this_param, Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 5579, 5593);
                    return 0;
                }


                int
                f_686_5696_5722(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 5696, 5722);
                    return 0;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_686_5764_5801(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 5764, 5801);
                    return return_v;
                }


                int
                f_686_5753_5818(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                this_param, Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 5753, 5818);
                    return 0;
                }


                int
                f_686_5992_6005(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 5992, 6005);
                    return 0;
                }


                int
                f_686_6024_6062(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>>
                this_param, System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 6024, 6062);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 4598, 6089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 4598, 6089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ObjectPool<Stack<ChildSyntaxList.Reversed.Enumerator>> s_childReversedEnumeratorStackPool
        ;

        internal SyntaxToken GetLastToken(SyntaxNode current, Func<SyntaxToken, bool> predicate, Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 6361, 7887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 6510, 6568);

                var
                stack = f_686_6522_6567(s_childReversedEnumeratorStackPool)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 6618, 6686);

                    f_686_6618_6685(stack, f_686_6629_6658(current).Reverse().GetEnumerator());
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 6706, 7678) || true) && (f_686_6713_6724(stack) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 6706, 7678);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 6770, 6791);

                            var
                            en = f_686_6779_6790(stack)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 6815, 7659) || true) && (en.MoveNext())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 6815, 7659);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 6882, 6905);

                                var
                                child = en.Current
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 6933, 7263) || true) && (child.IsToken)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 6933, 7263);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 7008, 7071);

                                    var
                                    token = f_686_7020_7070(this, child.AsToken(), predicate, stepInto)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 7101, 7236) || true) && (token.RawKind != None)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 7101, 7236);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 7192, 7205);

                                        return token;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 7101, 7236);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 6933, 7263);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 7359, 7374);

                                f_686_7359_7373(
                                                        // push this enumerator back, not done yet
                                                        stack, en);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 7402, 7636) || true) && (child.IsNode)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 7402, 7636);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 7476, 7503);

                                    f_686_7476_7502(child.IsNode);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 7533, 7609);

                                    f_686_7533_7608(stack, f_686_7544_7581(child.AsNode()!).Reverse().GetEnumerator());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 7402, 7636);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 6815, 7659);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 6706, 7678);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(686, 6706, 7678);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(686, 6706, 7678);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 7698, 7713);

                    return default;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(686, 7742, 7876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 7782, 7796);

                    f_686_7782_7795(stack);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 7814, 7861);

                    f_686_7814_7860(s_childReversedEnumeratorStackPool, stack);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(686, 7742, 7876);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 6361, 7887);

                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>
                f_686_6522_6567(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 6522, 6567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_686_6629_6658(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 6629, 6658);
                    return return_v;
                }


                int
                f_686_6618_6685(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>
                this_param, Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 6618, 6685);
                    return 0;
                }


                int
                f_686_6713_6724(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(686, 6713, 6724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator
                f_686_6779_6790(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 6779, 6790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_7020_7070(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetLastToken(token, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 7020, 7070);
                    return return_v;
                }


                int
                f_686_7359_7373(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>
                this_param, Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 7359, 7373);
                    return 0;
                }


                int
                f_686_7476_7502(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 7476, 7502);
                    return 0;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_686_7544_7581(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 7544, 7581);
                    return return_v;
                }


                int
                f_686_7533_7608(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>
                this_param, Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 7533, 7608);
                    return 0;
                }


                int
                f_686_7782_7795(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 7782, 7795);
                    return 0;
                }


                int
                f_686_7814_7860(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>>
                this_param, System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 7814, 7860);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 6361, 7887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 6361, 7887);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken GetFirstToken(
                    SyntaxTriviaList triviaList,
                    Func<SyntaxToken, bool>? predicate,
                    Func<SyntaxTrivia, bool> stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 7899, 8583);
                Microsoft.CodeAnalysis.SyntaxNode? structure = default(Microsoft.CodeAnalysis.SyntaxNode?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 8097, 8128);

                f_686_8097_8127(stepInto != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 8142, 8541);
                    foreach (var trivia in f_686_8165_8175_I(triviaList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 8142, 8541);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 8209, 8526) || true) && (trivia.TryGetStructure(out structure
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(686, 8213, 8274) && f_686_8258_8274(stepInto, trivia)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 8209, 8526);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 8316, 8374);

                            var
                            token = f_686_8328_8373(this, structure, predicate, stepInto)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 8396, 8507) || true) && (token.RawKind != None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 8396, 8507);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 8471, 8484);

                                return token;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 8396, 8507);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 8209, 8526);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 8142, 8541);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(686, 1, 400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(686, 1, 400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 8557, 8572);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 7899, 8583);

                int
                f_686_8097_8127(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 8097, 8127);
                    return 0;
                }


                bool
                f_686_8258_8274(System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 8258, 8274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_8328_8373(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                stepInto)
                {
                    var return_v = this_param.GetFirstToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 8328, 8373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_686_8165_8175_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 8165, 8175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 7899, 8583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 7899, 8583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken GetLastToken(
                    SyntaxTriviaList list,
                    Func<SyntaxToken, bool> predicate,
                    Func<SyntaxTrivia, bool> stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 8595, 9148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 8785, 8816);

                f_686_8785_8815(stepInto != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 8832, 9106);
                    foreach (var trivia in f_686_8855_8869_I(list.Reverse()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 8832, 9106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 8903, 8921);

                        SyntaxToken
                        token
                        = default(SyntaxToken);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 8939, 9091) || true) && (f_686_8943_9017(this, trivia, predicate, stepInto, out token))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 8939, 9091);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 9059, 9072);

                            return token;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 8939, 9091);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 8832, 9106);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(686, 1, 275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(686, 1, 275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 9122, 9137);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 8595, 9148);

                int
                f_686_8785_8815(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 8785, 8815);
                    return 0;
                }


                bool
                f_686_8943_9017(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                trivia, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                stepInto, out Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.TryGetLastTokenForStructuredTrivia(trivia, predicate, stepInto, out token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 8943, 9017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed
                f_686_8855_8869_I(Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 8855, 8869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 8595, 9148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 8595, 9148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetLastTokenForStructuredTrivia(
                    SyntaxTrivia trivia,
                    Func<SyntaxToken, bool> predicate,
                    Func<SyntaxTrivia, bool>? stepInto,
                    out SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 9160, 9706);
                Microsoft.CodeAnalysis.SyntaxNode? structure = default(Microsoft.CodeAnalysis.SyntaxNode?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 9400, 9416);

                token = default;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 9432, 9581) || true) && (!trivia.TryGetStructure(out structure
                ) || (DynAbs.Tracing.TraceSender.Expression_False(686, 9436, 9498) || stepInto == null) || (DynAbs.Tracing.TraceSender.Expression_False(686, 9436, 9519) || !f_686_9503_9519(stepInto, trivia)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 9432, 9581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 9553, 9566);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 9432, 9581);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 9597, 9650);

                token = f_686_9605_9649(this, structure, predicate, stepInto);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 9666, 9695);

                return token.RawKind != None;
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 9160, 9706);

                bool
                f_686_9503_9519(System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 9503, 9519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_9605_9649(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                stepInto)
                {
                    var return_v = this_param.GetLastToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 9605, 9649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 9160, 9706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 9160, 9706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken GetFirstToken(
                    SyntaxToken token,
                    Func<SyntaxToken, bool>? predicate,
                    Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 9718, 10804);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 10009, 10323) || true) && (stepInto != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 10009, 10323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 10108, 10181);

                    var
                    firstToken = f_686_10125_10180(this, token.LeadingTrivia, predicate, stepInto)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 10199, 10308) || true) && (firstToken.RawKind != None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 10199, 10308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 10271, 10289);

                        return firstToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 10199, 10308);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 10009, 10323);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 10339, 10430) || true) && (f_686_10343_10368(predicate, token))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 10339, 10430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 10402, 10415);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 10339, 10430);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 10446, 10762) || true) && (stepInto != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 10446, 10762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 10546, 10620);

                    var
                    firstToken = f_686_10563_10619(this, token.TrailingTrivia, predicate, stepInto)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 10638, 10747) || true) && (firstToken.RawKind != None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 10638, 10747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 10710, 10728);

                        return firstToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 10638, 10747);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 10446, 10762);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 10778, 10793);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 9718, 10804);

                Microsoft.CodeAnalysis.SyntaxToken
                f_686_10125_10180(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                triviaList, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                stepInto)
                {
                    var return_v = this_param.GetFirstToken(triviaList, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 10125, 10180);
                    return return_v;
                }


                bool
                f_686_10343_10368(System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = Matches(predicate, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 10343, 10368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_10563_10619(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                triviaList, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                stepInto)
                {
                    var return_v = this_param.GetFirstToken(triviaList, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 10563, 10619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 9718, 10804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 9718, 10804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken GetLastToken(
                    SyntaxToken token,
                    Func<SyntaxToken, bool> predicate,
                    Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 10816, 11892);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 11105, 11416) || true) && (stepInto != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 11105, 11416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 11204, 11276);

                    var
                    lastToken = f_686_11220_11275(this, token.TrailingTrivia, predicate, stepInto)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 11294, 11401) || true) && (lastToken.RawKind != None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 11294, 11401);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 11365, 11382);

                        return lastToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 11294, 11401);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 11105, 11416);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 11432, 11523) || true) && (f_686_11436_11461(predicate, token))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 11432, 11523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 11495, 11508);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 11432, 11523);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 11539, 11850) || true) && (stepInto != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 11539, 11850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 11639, 11710);

                    var
                    lastToken = f_686_11655_11709(this, token.LeadingTrivia, predicate, stepInto)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 11728, 11835) || true) && (lastToken.RawKind != None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 11728, 11835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 11799, 11816);

                        return lastToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 11728, 11835);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 11539, 11850);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 11866, 11881);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 10816, 11892);

                Microsoft.CodeAnalysis.SyntaxToken
                f_686_11220_11275(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                list, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                stepInto)
                {
                    var return_v = this_param.GetLastToken(list, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 11220, 11275);
                    return return_v;
                }


                bool
                f_686_11436_11461(System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = Matches(predicate, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 11436, 11461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_11655_11709(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                list, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                stepInto)
                {
                    var return_v = this_param.GetLastToken(list, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 11655, 11709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 10816, 11892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 10816, 11892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetNextToken(
                    SyntaxTrivia current,
                    Func<SyntaxToken, bool>? predicate,
                    Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 11904, 13216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 12096, 12120);

                bool
                returnNext = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 12198, 12298);

                var
                token = f_686_12210_12297(this, current, current.Token.LeadingTrivia, predicate, stepInto, ref returnNext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 12312, 12399) || true) && (token.RawKind != None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 12312, 12399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 12371, 12384);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 12312, 12399);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 12501, 12668) || true) && (returnNext && (DynAbs.Tracing.TraceSender.Expression_True(686, 12505, 12598) && (predicate == null || (DynAbs.Tracing.TraceSender.Expression_False(686, 12520, 12569) || predicate == SyntaxToken.Any) || (DynAbs.Tracing.TraceSender.Expression_False(686, 12520, 12597) || f_686_12573_12597(predicate, current.Token)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 12501, 12668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 12632, 12653);

                    return current.Token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 12501, 12668);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 12762, 12859);

                token = f_686_12770_12858(this, current, current.Token.TrailingTrivia, predicate, stepInto, ref returnNext);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 12873, 12960) || true) && (token.RawKind != None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 12873, 12960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 12932, 12945);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 12873, 12960);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 13142, 13205);

                return f_686_13149_13204(this, current.Token, predicate, false, stepInto);
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 11904, 13216);

                Microsoft.CodeAnalysis.SyntaxToken
                f_686_12210_12297(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                current, Microsoft.CodeAnalysis.SyntaxTriviaList
                list, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto, ref bool
                returnNext)
                {
                    var return_v = this_param.GetNextToken(current, list, predicate, stepInto, ref returnNext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 12210, 12297);
                    return return_v;
                }


                bool
                f_686_12573_12597(System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 12573, 12597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_12770_12858(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                current, Microsoft.CodeAnalysis.SyntaxTriviaList
                list, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto, ref bool
                returnNext)
                {
                    var return_v = this_param.GetNextToken(current, list, predicate, stepInto, ref returnNext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 12770, 12858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_13149_13204(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, bool
                searchInsideCurrentTokenTrailingTrivia, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetNextToken(current, predicate, searchInsideCurrentTokenTrailingTrivia, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 13149, 13204);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 11904, 13216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 11904, 13216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetPreviousToken(
                    SyntaxTrivia current,
                    Func<SyntaxToken, bool> predicate,
                    Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 13228, 14525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 13423, 13451);

                bool
                returnPrevious = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 13529, 13638);

                var
                token = f_686_13541_13637(this, current, current.Token.TrailingTrivia, predicate, stepInto, ref returnPrevious)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 13652, 13739) || true) && (token.RawKind != None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 13652, 13739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 13711, 13724);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 13652, 13739);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 13841, 13966) || true) && (returnPrevious && (DynAbs.Tracing.TraceSender.Expression_True(686, 13845, 13896) && f_686_13863_13896(predicate, current.Token)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 13841, 13966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 13930, 13951);

                    return current.Token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 13841, 13966);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 14060, 14164);

                token = f_686_14068_14163(this, current, current.Token.LeadingTrivia, predicate, stepInto, ref returnPrevious);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 14178, 14265) || true) && (token.RawKind != None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 14178, 14265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 14237, 14250);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 14178, 14265);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 14447, 14514);

                return f_686_14454_14513(this, current.Token, predicate, false, stepInto);
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 13228, 14525);

                Microsoft.CodeAnalysis.SyntaxToken
                f_686_13541_13637(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                current, Microsoft.CodeAnalysis.SyntaxTriviaList
                list, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto, ref bool
                returnPrevious)
                {
                    var return_v = this_param.GetPreviousToken(current, list, predicate, stepInto, ref returnPrevious);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 13541, 13637);
                    return return_v;
                }


                bool
                f_686_13863_13896(System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = Matches(predicate, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 13863, 13896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_14068_14163(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                current, Microsoft.CodeAnalysis.SyntaxTriviaList
                list, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto, ref bool
                returnPrevious)
                {
                    var return_v = this_param.GetPreviousToken(current, list, predicate, stepInto, ref returnPrevious);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 14068, 14163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_14454_14513(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, bool
                searchInsideCurrentTokenLeadingTrivia, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetPreviousToken(current, predicate, searchInsideCurrentTokenLeadingTrivia, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 14454, 14513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 13228, 14525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 13228, 14525);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken GetNextToken(
                    SyntaxTrivia current,
                    SyntaxTriviaList list,
                    Func<SyntaxToken, bool>? predicate,
                    Func<SyntaxTrivia, bool>? stepInto,
                    ref bool returnNext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 14537, 15480);
                Microsoft.CodeAnalysis.SyntaxNode? structure = default(Microsoft.CodeAnalysis.SyntaxNode?);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 14798, 15438);
                    foreach (var trivia in f_686_14821_14825_I(list))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 14798, 15438);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 14859, 15423) || true) && (returnNext)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 14859, 15423);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 14915, 15281) || true) && (trivia.TryGetStructure(out structure
                            ) && (DynAbs.Tracing.TraceSender.Expression_True(686, 14919, 14980) && stepInto != null) && (DynAbs.Tracing.TraceSender.Expression_True(686, 14919, 15000) && f_686_14984_15000(stepInto, trivia)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 14915, 15281);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 15050, 15109);

                                var
                                token = f_686_15062_15108(this, structure!, predicate, stepInto)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 15135, 15258) || true) && (token.RawKind != None)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 15135, 15258);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 15218, 15231);

                                    return token;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 15135, 15258);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 14915, 15281);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 14859, 15423);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 14859, 15423);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 15323, 15423) || true) && (trivia == current)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 15323, 15423);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 15386, 15404);

                                returnNext = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 15323, 15423);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 14859, 15423);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 14798, 15438);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(686, 1, 641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(686, 1, 641);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 15454, 15469);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 14537, 15480);

                bool
                f_686_14984_15000(System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 14984, 15000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_15062_15108(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                stepInto)
                {
                    var return_v = this_param.GetFirstToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 15062, 15108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_686_14821_14825_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 14821, 14825);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 14537, 15480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 14537, 15480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken GetPreviousToken(
                    SyntaxTrivia current,
                    SyntaxTriviaList list,
                    Func<SyntaxToken, bool> predicate,
                    Func<SyntaxTrivia, bool>? stepInto,
                    ref bool returnPrevious)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 15492, 16298);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 15760, 16256);
                    foreach (var trivia in f_686_15783_15797_I(list.Reverse()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 15760, 16256);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 15831, 16241) || true) && (returnPrevious)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 15831, 16241);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 15891, 15909);

                            SyntaxToken
                            token
                            = default(SyntaxToken);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 15931, 16095) || true) && (f_686_15935_16009(this, trivia, predicate, stepInto, out token))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 15931, 16095);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 16059, 16072);

                                return token;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 15931, 16095);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 15831, 16241);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 15831, 16241);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 16137, 16241) || true) && (trivia == current)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 16137, 16241);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 16200, 16222);

                                returnPrevious = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 16137, 16241);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 15831, 16241);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 15760, 16256);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(686, 1, 497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(686, 1, 497);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 16272, 16287);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 15492, 16298);

                bool
                f_686_15935_16009(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                trivia, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto, out Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.TryGetLastTokenForStructuredTrivia(trivia, predicate, stepInto, out token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 15935, 16009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed
                f_686_15783_15797_I(Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 15783, 15797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 15492, 16298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 15492, 16298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetNextToken(
                    SyntaxNode node,
                    Func<SyntaxToken, bool>? predicate,
                    Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 16310, 18188);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 16497, 17967) || true) && (f_686_16504_16515(node) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 16497, 17967);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 16688, 16712);

                        bool
                        returnNext = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 16730, 17824);
                            foreach (var child in f_686_16752_16785_I(f_686_16752_16785(f_686_16752_16763(node))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 16730, 17824);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 16827, 17805) || true) && (returnNext)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 16827, 17805);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 16891, 17622) || true) && (child.IsToken)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 16891, 17622);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 16966, 17030);

                                        var
                                        token = f_686_16978_17029(this, child.AsToken(), predicate, stepInto)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 17060, 17195) || true) && (token.RawKind != None)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 17060, 17195);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 17151, 17164);

                                            return token;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 17060, 17195);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 16891, 17622);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 16891, 17622);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 17309, 17336);

                                        f_686_17309_17335(child.IsNode);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 17366, 17430);

                                        var
                                        token = f_686_17378_17429(this, child.AsNode()!, predicate, stepInto)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 17460, 17595) || true) && (token.RawKind != None)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 17460, 17595);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 17551, 17564);

                                            return token;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 17460, 17595);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 16891, 17622);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 16827, 17805);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 16827, 17805);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 17672, 17805) || true) && (child.IsNode && (DynAbs.Tracing.TraceSender.Expression_True(686, 17676, 17714) && child.AsNode() == node))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 17672, 17805);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 17764, 17782);

                                        returnNext = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 17672, 17805);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 16827, 17805);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 16730, 17824);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(686, 1, 1095);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(686, 1, 1095);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 17933, 17952);

                        node = f_686_17940_17951(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 16497, 17967);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(686, 16497, 17967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(686, 16497, 17967);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 17983, 18146) || true) && (f_686_17987_18010(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 17983, 18146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 18044, 18131);

                    return f_686_18051_18130(this, f_686_18064_18108(((IStructuredTriviaSyntax)node)), predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 17983, 18146);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 18162, 18177);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 16310, 18188);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_686_16504_16515(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(686, 16504, 16515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_686_16752_16763(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(686, 16752, 16763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_686_16752_16785(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 16752, 16785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_16978_17029(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetFirstToken(token, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 16978, 17029);
                    return return_v;
                }


                int
                f_686_17309_17335(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 17309, 17335);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_17378_17429(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetFirstToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 17378, 17429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_686_16752_16785_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 16752, 16785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_686_17940_17951(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(686, 17940, 17951);
                    return return_v;
                }


                bool
                f_686_17987_18010(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.IsStructuredTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(686, 17987, 18010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_686_18064_18108(Microsoft.CodeAnalysis.IStructuredTriviaSyntax
                this_param)
                {
                    var return_v = this_param.ParentTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(686, 18064, 18108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_18051_18130(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetNextToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 18051, 18130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 16310, 18188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 16310, 18188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetPreviousToken(
                    SyntaxNode node,
                    Func<SyntaxToken, bool> predicate,
                    Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 18200, 20113);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 18390, 19888) || true) && (f_686_18397_18408(node) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 18390, 19888);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 18585, 18613);

                        bool
                        returnPrevious = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 18631, 19741);
                            foreach (var child in f_686_18653_18696_I(f_686_18653_18686(f_686_18653_18664(node)).Reverse()))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 18631, 19741);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 18738, 19722) || true) && (returnPrevious)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 18738, 19722);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 18806, 19535) || true) && (child.IsToken)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 18806, 19535);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 18881, 18944);

                                        var
                                        token = f_686_18893_18943(this, child.AsToken(), predicate, stepInto)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 18974, 19109) || true) && (token.RawKind != None)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 18974, 19109);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 19065, 19078);

                                            return token;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 18974, 19109);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 18806, 19535);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 18806, 19535);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 19223, 19250);

                                        f_686_19223_19249(child.IsNode);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 19280, 19343);

                                        var
                                        token = f_686_19292_19342(this, child.AsNode()!, predicate, stepInto)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 19373, 19508) || true) && (token.RawKind != None)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 19373, 19508);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 19464, 19477);

                                            return token;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 19373, 19508);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 18806, 19535);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 18738, 19722);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 18738, 19722);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 19585, 19722) || true) && (child.IsNode && (DynAbs.Tracing.TraceSender.Expression_True(686, 19589, 19627) && child.AsNode() == node))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 19585, 19722);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 19677, 19699);

                                        returnPrevious = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 19585, 19722);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 18738, 19722);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 18631, 19741);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(686, 1, 1111);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(686, 1, 1111);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 19854, 19873);

                        node = f_686_19861_19872(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 18390, 19888);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(686, 18390, 19888);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(686, 18390, 19888);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 19904, 20071) || true) && (f_686_19908_19931(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 19904, 20071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 19965, 20056);

                    return f_686_19972_20055(this, f_686_19989_20033(((IStructuredTriviaSyntax)node)), predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 19904, 20071);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 20087, 20102);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 18200, 20113);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_686_18397_18408(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(686, 18397, 18408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_686_18653_18664(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(686, 18653, 18664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_686_18653_18686(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 18653, 18686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_18893_18943(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetLastToken(token, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 18893, 18943);
                    return return_v;
                }


                int
                f_686_19223_19249(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 19223, 19249);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_19292_19342(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetLastToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 19292, 19342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList.Reversed
                f_686_18653_18696_I(Microsoft.CodeAnalysis.ChildSyntaxList.Reversed
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 18653, 18696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_686_19861_19872(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(686, 19861, 19872);
                    return return_v;
                }


                bool
                f_686_19908_19931(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.IsStructuredTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(686, 19908, 19931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_686_19989_20033(Microsoft.CodeAnalysis.IStructuredTriviaSyntax
                this_param)
                {
                    var return_v = this_param.ParentTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(686, 19989, 20033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_19972_20055(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetPreviousToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 19972, 20055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 18200, 20113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 18200, 20113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetNextToken(in SyntaxToken current, Func<SyntaxToken, bool>? predicate, bool searchInsideCurrentTokenTrailingTrivia, Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 20125, 22374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 20324, 20406);

                f_686_20324_20405(searchInsideCurrentTokenTrailingTrivia == false || (DynAbs.Tracing.TraceSender.Expression_False(686, 20337, 20404) || stepInto != null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 20420, 22332) || true) && (current.Parent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 20420, 22332);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 20542, 20865) || true) && (searchInsideCurrentTokenTrailingTrivia)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 20542, 20865);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 20626, 20703);

                        var
                        firstToken = f_686_20643_20702(this, current.TrailingTrivia, predicate, stepInto!)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 20725, 20846) || true) && (firstToken.RawKind != None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 20725, 20846);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 20805, 20823);

                            return firstToken;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 20725, 20846);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 20542, 20865);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 21015, 21039);

                    bool
                    returnNext = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 21057, 22159);
                        foreach (var child in f_686_21079_21115_I(f_686_21079_21115(current.Parent)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 21057, 22159);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 21157, 22140) || true) && (returnNext)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 21157, 22140);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 21221, 21952) || true) && (child.IsToken)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 21221, 21952);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 21296, 21360);

                                    var
                                    token = f_686_21308_21359(this, child.AsToken(), predicate, stepInto)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 21390, 21525) || true) && (token.RawKind != None)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 21390, 21525);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 21481, 21494);

                                        return token;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 21390, 21525);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 21221, 21952);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 21221, 21952);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 21639, 21666);

                                    f_686_21639_21665(child.IsNode);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 21696, 21760);

                                    var
                                    token = f_686_21708_21759(this, child.AsNode()!, predicate, stepInto)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 21790, 21925) || true) && (token.RawKind != None)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 21790, 21925);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 21881, 21894);

                                        return token;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 21790, 21925);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 21221, 21952);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 21157, 22140);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 21157, 22140);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 22002, 22140) || true) && (child.IsToken && (DynAbs.Tracing.TraceSender.Expression_True(686, 22006, 22049) && child.AsToken() == current))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 22002, 22140);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 22099, 22117);

                                    returnNext = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 22002, 22140);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 21157, 22140);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 21057, 22159);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(686, 1, 1103);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(686, 1, 1103);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 22260, 22317);

                    return f_686_22267_22316(this, current.Parent, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 20420, 22332);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 22348, 22363);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 20125, 22374);

                int
                f_686_20324_20405(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 20324, 20405);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_20643_20702(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                triviaList, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                stepInto)
                {
                    var return_v = this_param.GetFirstToken(triviaList, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 20643, 20702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_686_21079_21115(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 21079, 21115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_21308_21359(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetFirstToken(token, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 21308, 21359);
                    return return_v;
                }


                int
                f_686_21639_21665(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 21639, 21665);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_21708_21759(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetFirstToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 21708, 21759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_686_21079_21115_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 21079, 21115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_22267_22316(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetNextToken(node, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 22267, 22316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 20125, 22374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 20125, 22374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetPreviousToken(in SyntaxToken current, Func<SyntaxToken, bool> predicate, bool searchInsideCurrentTokenLeadingTrivia,
                    Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(686, 22386, 24667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 22600, 22681);

                f_686_22600_22680(searchInsideCurrentTokenLeadingTrivia == false || (DynAbs.Tracing.TraceSender.Expression_False(686, 22613, 22679) || stepInto != null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 22695, 24625) || true) && (current.Parent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 22695, 24625);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 22817, 23134) || true) && (searchInsideCurrentTokenLeadingTrivia)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 22817, 23134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 22900, 22974);

                        var
                        lastToken = f_686_22916_22973(this, current.LeadingTrivia, predicate, stepInto!)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 22996, 23115) || true) && (lastToken.RawKind != None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 22996, 23115);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 23075, 23092);

                            return lastToken;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 22996, 23115);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 22817, 23134);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 23284, 23312);

                    bool
                    returnPrevious = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 23330, 24448);
                        foreach (var child in f_686_23352_23398_I(f_686_23352_23388(current.Parent).Reverse()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 23330, 24448);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 23440, 24429) || true) && (returnPrevious)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 23440, 24429);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 23508, 24237) || true) && (child.IsToken)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 23508, 24237);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 23583, 23646);

                                    var
                                    token = f_686_23595_23645(this, child.AsToken(), predicate, stepInto)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 23676, 23811) || true) && (token.RawKind != None)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 23676, 23811);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 23767, 23780);

                                        return token;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 23676, 23811);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 23508, 24237);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 23508, 24237);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 23925, 23952);

                                    f_686_23925_23951(child.IsNode);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 23982, 24045);

                                    var
                                    token = f_686_23994_24044(this, child.AsNode()!, predicate, stepInto)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 24075, 24210) || true) && (token.RawKind != None)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 24075, 24210);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 24166, 24179);

                                        return token;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(686, 24075, 24210);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 23508, 24237);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 23440, 24429);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 23440, 24429);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 24287, 24429) || true) && (child.IsToken && (DynAbs.Tracing.TraceSender.Expression_True(686, 24291, 24334) && child.AsToken() == current))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(686, 24287, 24429);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 24384, 24406);

                                    returnPrevious = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 24287, 24429);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(686, 23440, 24429);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(686, 23330, 24448);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(686, 1, 1119);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(686, 1, 1119);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 24549, 24610);

                    return f_686_24556_24609(this, current.Parent, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(686, 22695, 24625);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 24641, 24656);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(686, 22386, 24667);

                int
                f_686_22600_22680(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 22600, 22680);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_22916_22973(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                list, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                stepInto)
                {
                    var return_v = this_param.GetLastToken(list, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 22916, 22973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_686_23352_23388(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 23352, 23388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_23595_23645(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetLastToken(token, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 23595, 23645);
                    return return_v;
                }


                int
                f_686_23925_23951(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 23925, 23951);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_23994_24044(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetLastToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 23994, 24044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList.Reversed
                f_686_23352_23398_I(Microsoft.CodeAnalysis.ChildSyntaxList.Reversed
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 23352, 23398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_686_24556_24609(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetPreviousToken(node, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 24556, 24609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(686, 22386, 24667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 22386, 24667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxNavigator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(686, 398, 24674);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 470, 478);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 530, 562);
            Instance = f_686_541_562(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 852, 1565);
            s_stepIntoFunctions = new Func<SyntaxTrivia, bool>?[]
                    {
            /* 000 */ null,
            /* 001 */ t =>                                             t.IsDocumentationCommentTrivia,
            /* 010 */ t =>                            t.IsDirective,
            /* 011 */ t =>                            t.IsDirective || t.IsDocumentationCommentTrivia,
            /* 100 */ t => t.IsSkippedTokensTrivia,
            /* 101 */ t => t.IsSkippedTokensTrivia                  || t.IsDocumentationCommentTrivia,
            /* 110 */ t => t.IsSkippedTokensTrivia || t.IsDirective,
            /* 111 */ t => t.IsSkippedTokensTrivia || t.IsDirective || t.IsDocumentationCommentTrivia,
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 4443, 4585);
            s_childEnumeratorStackPool = f_686_4485_4585(() => new Stack<ChildSyntaxList.Enumerator>(), 10); DynAbs.Tracing.TraceSender.TraceSimpleStatement(686, 6180, 6348);
            s_childReversedEnumeratorStackPool = f_686_6230_6348(() => new Stack<ChildSyntaxList.Reversed.Enumerator>(), 10); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(686, 398, 24674);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(686, 398, 24674);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(686, 398, 24674);

        static Microsoft.CodeAnalysis.SyntaxNavigator
        f_686_541_562()
        {
            var return_v = new Microsoft.CodeAnalysis.SyntaxNavigator();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 541, 562);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>>
        f_686_4485_4585(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>>.Factory
        factory, int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>>(factory, size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 4485, 4585);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>>
        f_686_6230_6348(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>>.Factory
        factory, int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator>>(factory, size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(686, 6230, 6348);
            return return_v;
        }

    }
}
