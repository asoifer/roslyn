// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{

    internal readonly struct NullableContextState
    {

        internal int Position { get; }

        internal State WarningsState { get; }

        internal State AnnotationsState { get; }

        internal NullableContextState(int position, State warningsState, State annotationsState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10786, 826, 1064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 939, 959);

                Position = position;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 973, 1003);

                WarningsState = warningsState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 1017, 1053);

                AnnotationsState = annotationsState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10786, 826, 1064);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10786, 826, 1064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 826, 1064);
            }
        }

        internal enum State : byte
        {
            Unknown,
            Disabled,
            Enabled,
            ExplicitlyRestored
        }
        static NullableContextState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10786, 625, 1230);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10786, 625, 1230);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 625, 1230);
        }
    }

    internal readonly struct NullableContextStateMap
    {

        private readonly ImmutableArray<NullableContextState> _contexts;

        internal static NullableContextStateMap Create(SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10786, 1379, 1570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 1467, 1500);

                var
                contexts = GetContexts(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 1514, 1559);

                return f_10786_1521_1558(contexts);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10786, 1379, 1570);

                Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap
                f_10786_1521_1558(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState>
                contexts)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap(contexts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 1521, 1558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10786, 1379, 1570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 1379, 1570);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NullableContextStateMap(ImmutableArray<NullableContextState> contexts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10786, 1582, 1901);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 1705, 1710);
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 1696, 1847) || true) && (i < contexts.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 1733, 1736)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10786, 1696, 1847))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10786, 1696, 1847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 1770, 1832);

                        f_10786_1770_1831(contexts[i - 1].Position < contexts[i].Position);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10786, 1, 152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10786, 1, 152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 1869, 1890);

                _contexts = contexts;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10786, 1582, 1901);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10786, 1582, 1901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 1582, 1901);
            }
        }

        private static NullableContextState GetContextForFileStart()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10786, 1987, 2184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 1990, 2184);
                return f_10786_1990_2184(position: 0, warningsState: NullableContextState.State.Unknown, annotationsState: NullableContextState.State.Unknown); DynAbs.Tracing.TraceSender.TraceExitMethod(10786, 1987, 2184);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10786, 1987, 2184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 1987, 2184);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState
            f_10786_1990_2184(int
            position, Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState.State
            warningsState, Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState.State
            annotationsState)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState(position: position, warningsState: warningsState, annotationsState: annotationsState);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 1990, 2184);
                return return_v;
            }

        }

        private int GetContextStateIndex(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10786, 2197, 3209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 2342, 2502);

                var
                searchContext = f_10786_2362_2501(position, warningsState: NullableContextState.State.Unknown, annotationsState: NullableContextState.State.Unknown)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 2516, 2593);

                int
                index = _contexts.BinarySearch(searchContext, PositionComparer.Instance)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 2607, 2822) || true) && (index < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10786, 2607, 2822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 2788, 2807);

                    index = ~index - 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10786, 2607, 2822);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 2838, 2864);

                f_10786_2838_2863(index >= -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 2878, 2917);

                f_10786_2878_2916(index < _contexts.Length);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 2942, 3163) || true) && (index >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10786, 2942, 3163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 2990, 3042);

                    f_10786_2990_3041(_contexts[index].Position <= position);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 3060, 3148);

                    f_10786_3060_3147(index == _contexts.Length - 1 || (DynAbs.Tracing.TraceSender.Expression_False(10786, 3073, 3146) || position < _contexts[index + 1].Position));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10786, 2942, 3163);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 3185, 3198);

                return index;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10786, 2197, 3209);

                Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState
                f_10786_2362_2501(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState.State
                warningsState, Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState.State
                annotationsState)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState(position, warningsState: warningsState, annotationsState: annotationsState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 2362, 2501);
                    return return_v;
                }


                int
                f_10786_2838_2863(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 2838, 2863);
                    return 0;
                }


                int
                f_10786_2878_2916(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 2878, 2916);
                    return 0;
                }


                int
                f_10786_2990_3041(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 2990, 3041);
                    return 0;
                }


                int
                f_10786_3060_3147(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 3060, 3147);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10786, 2197, 3209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 2197, 3209);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NullableContextState GetContextState(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10786, 3221, 3436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 3305, 3348);

                var
                index = GetContextStateIndex(position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 3362, 3425);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10786, 3369, 3378) || ((index < 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10786, 3381, 3405)) || DynAbs.Tracing.TraceSender.Conditional_F3(10786, 3408, 3424))) ? GetContextForFileStart() : _contexts[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10786, 3221, 3436);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10786, 3221, 3436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 3221, 3436);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool? IsNullableAnalysisEnabled(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10786, 3759, 4942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 3839, 3883);

                bool
                hasUnknownOrExplicitlyRestored = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 3897, 3942);

                int
                index = GetContextStateIndex(span.Start)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 3956, 4026);

                var
                context = (DynAbs.Tracing.TraceSender.Conditional_F1(10786, 3970, 3979) || ((index < 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10786, 3982, 4006)) || DynAbs.Tracing.TraceSender.Conditional_F3(10786, 4009, 4025))) ? GetContextForFileStart() : _contexts[index]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 4040, 4085);

                f_10786_4040_4084(context.Position <= span.Start);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 4101, 4862) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10786, 4101, 4862);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 4146, 4545);

                        switch (context.WarningsState)
                        {

                            case NullableContextState.State.Enabled:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10786, 4146, 4545);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 4283, 4295);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10786, 4146, 4545);

                            case NullableContextState.State.Unknown:
                            case NullableContextState.State.ExplicitlyRestored:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10786, 4146, 4545);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 4456, 4494);

                                hasUnknownOrExplicitlyRestored = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(10786, 4520, 4526);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10786, 4146, 4545);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 4563, 4571);

                        index++;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 4589, 4685) || true) && (index >= _contexts.Length)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10786, 4589, 4685);
                            DynAbs.Tracing.TraceSender.TraceBreak(10786, 4660, 4666);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10786, 4589, 4685);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 4703, 4730);

                        context = _contexts[index];

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 4748, 4847) || true) && (context.Position >= span.End)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10786, 4748, 4847);
                            DynAbs.Tracing.TraceSender.TraceBreak(10786, 4822, 4828);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10786, 4748, 4847);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10786, 4101, 4862);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10786, 4101, 4862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10786, 4101, 4862);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 4878, 4931);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10786, 4885, 4915) || ((hasUnknownOrExplicitlyRestored && DynAbs.Tracing.TraceSender.Conditional_F2(10786, 4918, 4922)) || DynAbs.Tracing.TraceSender.Conditional_F3(10786, 4925, 4930))) ? null : false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10786, 3759, 4942);

                int
                f_10786_4040_4084(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 4040, 4084);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10786, 3759, 4942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 3759, 4942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<NullableContextState> GetContexts(SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10786, 4954, 6860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5059, 5106);

                var
                previousContext = GetContextForFileStart()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5122, 5185);

                var
                builder = f_10786_5136_5184()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5199, 6797);
                    foreach (var d in f_10786_5217_5247_I(f_10786_5217_5247(f_10786_5217_5231(tree))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10786, 5199, 6797);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5281, 5401) || true) && (f_10786_5285_5293(d) != SyntaxKind.NullableDirectiveTrivia)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10786, 5281, 5401);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5373, 5382);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10786, 5281, 5401);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5419, 5461);

                        var
                        nn = (NullableDirectiveTriviaSyntax)d
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5479, 5594) || true) && (nn.SettingToken.IsMissing || (DynAbs.Tracing.TraceSender.Expression_False(10786, 5483, 5524) || f_10786_5512_5524_M(!nn.IsActive)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10786, 5479, 5594);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5566, 5575);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10786, 5479, 5594);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5614, 5644);

                        var
                        position = f_10786_5629_5643(nn)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5662, 6096);

                        var
                        setting = (nn.SettingToken.Kind()) switch
                        {
                            SyntaxKind.EnableKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5748, 5810) && DynAbs.Tracing.TraceSender.Expression_True(10786, 5748, 5810))
=> NullableContextState.State.Enabled,
                            SyntaxKind.DisableKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5833, 5897) && DynAbs.Tracing.TraceSender.Expression_True(10786, 5833, 5897))
=> NullableContextState.State.Disabled,
                            SyntaxKind.RestoreKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 5920, 5994) && DynAbs.Tracing.TraceSender.Expression_True(10786, 5920, 5994))
=> NullableContextState.State.ExplicitlyRestored,
                            var kind when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 6017, 6075) && DynAbs.Tracing.TraceSender.Expression_True(10786, 6017, 6075))
=> throw f_10786_6035_6075(kind),
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 6116, 6697);

                        var
                        context = nn.TargetToken.Kind() switch
                        {
                            SyntaxKind.None when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 6199, 6270) && DynAbs.Tracing.TraceSender.Expression_True(10786, 6199, 6270))
=> f_10786_6218_6270(position, setting, setting),
                            SyntaxKind.WarningsKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 6293, 6433) && DynAbs.Tracing.TraceSender.Expression_True(10786, 6293, 6433))
=> f_10786_6323_6433(position, warningsState: setting, annotationsState: previousContext.AnnotationsState),
                            SyntaxKind.AnnotationsKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 6456, 6596) && DynAbs.Tracing.TraceSender.Expression_True(10786, 6456, 6596))
=> f_10786_6489_6596(position, warningsState: previousContext.WarningsState, annotationsState: setting),
                            var kind when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 6619, 6677) && DynAbs.Tracing.TraceSender.Expression_True(10786, 6619, 6677))
=> throw f_10786_6637_6677(kind)
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 6717, 6738);

                        f_10786_6717_6737(
                                        builder, context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 6756, 6782);

                        previousContext = context;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10786, 5199, 6797);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10786, 1, 1599);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10786, 1, 1599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 6813, 6849);

                return f_10786_6820_6848(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10786, 4954, 6860);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState>
                f_10786_5136_5184()
                {
                    var return_v = ArrayBuilder<NullableContextState>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 5136, 5184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10786_5217_5231(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 5217, 5231);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10786_5217_5247(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.GetDirectives();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 5217, 5247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10786_5285_5293(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 5285, 5293);
                    return return_v;
                }


                bool
                f_10786_5512_5524_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10786, 5512, 5524);
                    return return_v;
                }


                int
                f_10786_5629_5643(Microsoft.CodeAnalysis.CSharp.Syntax.NullableDirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.EndPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10786, 5629, 5643);
                    return return_v;
                }


                System.Exception
                f_10786_6035_6075(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 6035, 6075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState
                f_10786_6218_6270(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState.State
                warningsState, Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState.State
                annotationsState)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState(position, warningsState, annotationsState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 6218, 6270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState
                f_10786_6323_6433(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState.State
                warningsState, Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState.State
                annotationsState)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState(position, warningsState: warningsState, annotationsState: annotationsState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 6323, 6433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState
                f_10786_6489_6596(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState.State
                warningsState, Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState.State
                annotationsState)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState(position, warningsState: warningsState, annotationsState: annotationsState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 6489, 6596);
                    return return_v;
                }


                System.Exception
                f_10786_6637_6677(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 6637, 6677);
                    return return_v;
                }


                int
                f_10786_6717_6737(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 6717, 6737);
                    return 0;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10786_5217_5247_I(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 5217, 5247);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState>
                f_10786_6820_6848(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 6820, 6848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10786, 4954, 6860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 4954, 6860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class PositionComparer : IComparer<NullableContextState>
        {
            internal static readonly PositionComparer Instance;

            public int Compare(NullableContextState x, NullableContextState y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10786, 7060, 7214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 7159, 7199);

                    return f_10786_7166_7198(x.Position, y.Position);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10786, 7060, 7214);

                    int
                    f_10786_7166_7198(int
                    this_param, int
                    value)
                    {
                        var return_v = this_param.CompareTo(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 7166, 7198);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10786, 7060, 7214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 7060, 7214);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public PositionComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10786, 6872, 7225);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10786, 6872, 7225);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 6872, 7225);
            }


            static PositionComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10786, 6872, 7225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10786, 7010, 7043);
                Instance = f_10786_7021_7043(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10786, 6872, 7225);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 6872, 7225);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10786, 6872, 7225);

            static Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap.PositionComparer
            f_10786_7021_7043()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap.PositionComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 7021, 7043);
                return return_v;
            }

        }
        static NullableContextStateMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10786, 1238, 7232);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10786, 1238, 7232);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10786, 1238, 7232);
        }

        int
        f_10786_1770_1831(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10786, 1770, 1831);
            return 0;
        }

    }
}
