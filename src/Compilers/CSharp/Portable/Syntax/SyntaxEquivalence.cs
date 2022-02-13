// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using Green = InternalSyntax;
    internal static class SyntaxEquivalence
    {
        internal static bool AreEquivalent(SyntaxTree? before, SyntaxTree? after, Func<SyntaxKind, bool>? ignoreChildNode, bool topLevel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10804, 435, 892);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 589, 669) || true) && (before == after)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 589, 669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 642, 654);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 589, 669);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 685, 782) || true) && (before == null || (DynAbs.Tracing.TraceSender.Expression_False(10804, 689, 720) || after == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 685, 782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 754, 767);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 685, 782);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 798, 881);

                return f_10804_805_880(f_10804_819_835(before), f_10804_837_852(after), ignoreChildNode, topLevel);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10804, 435, 892);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10804_819_835(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 819, 835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10804_837_852(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 837, 852);
                    return return_v;
                }


                bool
                f_10804_805_880(Microsoft.CodeAnalysis.SyntaxNode
                before, Microsoft.CodeAnalysis.SyntaxNode
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode, bool
                topLevel)
                {
                    var return_v = AreEquivalent(before, after, ignoreChildNode, topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 805, 880);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10804, 435, 892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10804, 435, 892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalent(SyntaxNode? before, SyntaxNode? after, Func<SyntaxKind, bool>? ignoreChildNode, bool topLevel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10804, 904, 1351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 1056, 1107);

                f_10804_1056_1106(!topLevel || (DynAbs.Tracing.TraceSender.Expression_False(10804, 1069, 1105) || ignoreChildNode == null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 1123, 1230) || true) && (before == null || (DynAbs.Tracing.TraceSender.Expression_False(10804, 1127, 1158) || after == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 1123, 1230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 1192, 1215);

                    return before == after;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 1123, 1230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 1246, 1340);

                return f_10804_1253_1339(f_10804_1276_1288(before), f_10804_1290_1301(after), ignoreChildNode, topLevel: topLevel);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10804, 904, 1351);

                int
                f_10804_1056_1106(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 1056, 1106);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10804_1276_1288(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 1276, 1288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10804_1290_1301(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 1290, 1301);
                    return return_v;
                }


                bool
                f_10804_1253_1339(Microsoft.CodeAnalysis.GreenNode
                before, Microsoft.CodeAnalysis.GreenNode
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode, bool
                topLevel)
                {
                    var return_v = AreEquivalentRecursive(before, after, ignoreChildNode, topLevel: topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 1253, 1339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10804, 904, 1351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10804, 904, 1351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalent(SyntaxTokenList before, SyntaxTokenList after)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10804, 1363, 1573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 1467, 1562);

                return f_10804_1474_1561(before.Node, after.Node, ignoreChildNode: null, topLevel: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10804, 1363, 1573);

                bool
                f_10804_1474_1561(Microsoft.CodeAnalysis.GreenNode?
                before, Microsoft.CodeAnalysis.GreenNode?
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode, bool
                topLevel)
                {
                    var return_v = AreEquivalentRecursive(before, after, ignoreChildNode: ignoreChildNode, topLevel: topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 1474, 1561);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10804, 1363, 1573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10804, 1363, 1573);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalent(SyntaxToken before, SyntaxToken after)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10804, 1585, 1827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 1681, 1816);

                return before.RawKind == after.RawKind && (DynAbs.Tracing.TraceSender.Expression_True(10804, 1688, 1815) && (before.Node == null || (DynAbs.Tracing.TraceSender.Expression_False(10804, 1724, 1814) || f_10804_1747_1814(before.Node, after.Node, ignoreChildNode: null))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10804, 1585, 1827);

                bool
                f_10804_1747_1814(Microsoft.CodeAnalysis.GreenNode
                before, Microsoft.CodeAnalysis.GreenNode?
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode)
                {
                    var return_v = AreTokensEquivalent(before, after, ignoreChildNode: ignoreChildNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 1747, 1814);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10804, 1585, 1827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10804, 1585, 1827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AreTokensEquivalent(GreenNode? before, GreenNode? after, Func<SyntaxKind, bool>? ignoreChildNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10804, 1839, 3697);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 1981, 2106) || true) && (before is null || (DynAbs.Tracing.TraceSender.Expression_False(10804, 1985, 2016) || after is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 1981, 2106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 2050, 2091);

                    return (before is null && (DynAbs.Tracing.TraceSender.Expression_True(10804, 2058, 2089) && after is null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 1981, 2106);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 2589, 2635);

                f_10804_2589_2634(f_10804_2602_2616(before) == f_10804_2620_2633(after));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 2651, 2752) || true) && (f_10804_2655_2671(before) != f_10804_2675_2690(after))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 2651, 2752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 2724, 2737);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 2651, 2752);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 2833, 3599);

                switch ((SyntaxKind)f_10804_2853_2867(before))
                {

                    case SyntaxKind.IdentifierToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 2833, 3599);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 2955, 3122) || true) && (f_10804_2959_2996(((Green.SyntaxToken)before)) != f_10804_3000_3036(((Green.SyntaxToken)after)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 2955, 3122);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 3086, 3099);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 2955, 3122);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10804, 3144, 3150);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 2833, 3599);

                    case SyntaxKind.NumericLiteralToken:
                    case SyntaxKind.CharacterLiteralToken:
                    case SyntaxKind.StringLiteralToken:
                    case SyntaxKind.InterpolatedStringTextToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 2833, 3599);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 3399, 3556) || true) && (f_10804_3403_3435(((Green.SyntaxToken)before)) != f_10804_3439_3470(((Green.SyntaxToken)after)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 3399, 3556);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 3520, 3533);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 3399, 3556);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10804, 3578, 3584);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 2833, 3599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 3615, 3686);

                return f_10804_3622_3685(before, after, ignoreChildNode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10804, 1839, 3697);

                int
                f_10804_2602_2616(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 2602, 2616);
                    return return_v;
                }


                int
                f_10804_2620_2633(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 2620, 2633);
                    return return_v;
                }


                int
                f_10804_2589_2634(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 2589, 2634);
                    return 0;
                }


                bool
                f_10804_2655_2671(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 2655, 2671);
                    return return_v;
                }


                bool
                f_10804_2675_2690(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 2675, 2690);
                    return return_v;
                }


                int
                f_10804_2853_2867(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 2853, 2867);
                    return return_v;
                }


                string
                f_10804_2959_2996(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 2959, 2996);
                    return return_v;
                }


                string
                f_10804_3000_3036(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 3000, 3036);
                    return return_v;
                }


                string
                f_10804_3403_3435(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 3403, 3435);
                    return return_v;
                }


                string
                f_10804_3439_3470(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 3439, 3470);
                    return return_v;
                }


                bool
                f_10804_3622_3685(Microsoft.CodeAnalysis.GreenNode
                before, Microsoft.CodeAnalysis.GreenNode
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode)
                {
                    var return_v = AreNullableDirectivesEquivalent(before, after, ignoreChildNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 3622, 3685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10804, 1839, 3697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10804, 1839, 3697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AreEquivalentRecursive(GreenNode? before, GreenNode? after, Func<SyntaxKind, bool>? ignoreChildNode, bool topLevel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10804, 3709, 8994);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 3869, 3949) || true) && (before == after)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 3869, 3949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 3922, 3934);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 3869, 3949);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 3965, 4062) || true) && (before == null || (DynAbs.Tracing.TraceSender.Expression_False(10804, 3969, 4000) || after == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 3965, 4062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 4034, 4047);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 3965, 4062);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 4078, 4175) || true) && (f_10804_4082_4096(before) != f_10804_4100_4113(after))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 4078, 4175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 4147, 4160);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 4078, 4175);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 4191, 4363) || true) && (f_10804_4195_4209(before))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 4191, 4363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 4243, 4271);

                    f_10804_4243_4270(f_10804_4256_4269(after));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 4289, 4348);

                    return f_10804_4296_4347(before, after, ignoreChildNode);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 4191, 4363);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 4379, 6733) || true) && (topLevel)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 4379, 6733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 4576, 4850);

                    switch ((SyntaxKind)f_10804_4596_4610(before))
                    {

                        case SyntaxKind.Block:
                        case SyntaxKind.ArrowExpressionClause:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 4576, 4850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 4760, 4831);

                            return f_10804_4767_4830(before, after, ignoreChildNode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 4576, 4850);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 5233, 5886) || true) && ((SyntaxKind)f_10804_5249_5263(before) == SyntaxKind.FieldDeclaration)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 5233, 5886);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 5336, 5391);

                        var
                        fieldBefore = (Green.FieldDeclarationSyntax)before
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 5413, 5466);

                        var
                        fieldAfter = (Green.FieldDeclarationSyntax)after
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 5490, 5566);

                        var
                        isConstBefore = fieldBefore.Modifiers.Any((int)SyntaxKind.ConstKeyword)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 5588, 5662);

                        var
                        isConstAfter = fieldAfter.Modifiers.Any((int)SyntaxKind.ConstKeyword)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 5686, 5867) || true) && (!isConstBefore && (DynAbs.Tracing.TraceSender.Expression_True(10804, 5690, 5721) && !isConstAfter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 5686, 5867);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 5771, 5844);

                            ignoreChildNode = childKind => childKind == SyntaxKind.EqualsValueClause;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 5686, 5867);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 5233, 5886);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 4379, 6733);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 6749, 8983) || true) && (ignoreChildNode != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 6749, 8983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 6810, 6864);

                    var
                    e1 = f_10804_6819_6847(before).GetEnumerator()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 6882, 6935);

                    var
                    e2 = f_10804_6891_6918(after).GetEnumerator()
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 6953, 8271) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 6953, 8271);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 7006, 7031);

                            GreenNode?
                            child1 = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 7053, 7078);

                            GreenNode?
                            child2 = null
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 7149, 7490) || true) && (e1.MoveNext())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 7149, 7490);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 7219, 7238);

                                    var
                                    c = e1.Current
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 7264, 7467) || true) && (c != null && (DynAbs.Tracing.TraceSender.Expression_True(10804, 7268, 7335) && (f_10804_7282_7291(c) || (DynAbs.Tracing.TraceSender.Expression_False(10804, 7282, 7334) || !f_10804_7296_7334(ignoreChildNode, f_10804_7324_7333(c))))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 7264, 7467);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 7393, 7404);

                                        child1 = c;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10804, 7434, 7440);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 7264, 7467);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 7149, 7490);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10804, 7149, 7490);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10804, 7149, 7490);
                            }
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 7514, 7855) || true) && (e2.MoveNext())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 7514, 7855);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 7584, 7603);

                                    var
                                    c = e2.Current
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 7629, 7832) || true) && (c != null && (DynAbs.Tracing.TraceSender.Expression_True(10804, 7633, 7700) && (f_10804_7647_7656(c) || (DynAbs.Tracing.TraceSender.Expression_False(10804, 7647, 7699) || !f_10804_7661_7699(ignoreChildNode, f_10804_7689_7698(c))))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 7629, 7832);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 7758, 7769);

                                        child2 = c;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10804, 7799, 7805);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 7629, 7832);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 7514, 7855);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10804, 7514, 7855);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10804, 7514, 7855);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 7879, 8072) || true) && (child1 == null || (DynAbs.Tracing.TraceSender.Expression_False(10804, 7883, 7915) || child2 == null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 7879, 8072);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8025, 8049);

                                return child1 == child2;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 7879, 8072);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8096, 8252) || true) && (!f_10804_8101_8166(child1, child2, ignoreChildNode, topLevel))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 8096, 8252);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8216, 8229);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 8096, 8252);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 6953, 8271);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10804, 6953, 8271);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10804, 6953, 8271);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 6749, 8983);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 6749, 8983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8401, 8434);

                    int
                    slotCount = f_10804_8417_8433(before)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8452, 8558) || true) && (slotCount != f_10804_8469_8484(after))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 8452, 8558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8526, 8539);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 8452, 8558);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8587, 8592);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8578, 8936) || true) && (i < slotCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8609, 8612)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 8578, 8936))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 8578, 8936);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8654, 8685);

                            var
                            child1 = f_10804_8667_8684(before, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8707, 8737);

                            var
                            child2 = f_10804_8720_8736(after, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8761, 8917) || true) && (!f_10804_8766_8831(child1, child2, ignoreChildNode, topLevel))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 8761, 8917);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8881, 8894);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 8761, 8917);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10804, 1, 359);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10804, 1, 359);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 8956, 8968);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 6749, 8983);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10804, 3709, 8994);

                int
                f_10804_4082_4096(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 4082, 4096);
                    return return_v;
                }


                int
                f_10804_4100_4113(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 4100, 4113);
                    return return_v;
                }


                bool
                f_10804_4195_4209(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 4195, 4209);
                    return return_v;
                }


                bool
                f_10804_4256_4269(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 4256, 4269);
                    return return_v;
                }


                int
                f_10804_4243_4270(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 4243, 4270);
                    return 0;
                }


                bool
                f_10804_4296_4347(Microsoft.CodeAnalysis.GreenNode
                before, Microsoft.CodeAnalysis.GreenNode
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode)
                {
                    var return_v = AreTokensEquivalent(before, after, ignoreChildNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 4296, 4347);
                    return return_v;
                }


                int
                f_10804_4596_4610(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 4596, 4610);
                    return return_v;
                }


                bool
                f_10804_4767_4830(Microsoft.CodeAnalysis.GreenNode
                before, Microsoft.CodeAnalysis.GreenNode
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode)
                {
                    var return_v = AreNullableDirectivesEquivalent(before, after, ignoreChildNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 4767, 4830);
                    return return_v;
                }


                int
                f_10804_5249_5263(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 5249, 5263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList
                f_10804_6819_6847(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 6819, 6847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList
                f_10804_6891_6918(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 6891, 6918);
                    return return_v;
                }


                bool
                f_10804_7282_7291(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 7282, 7291);
                    return return_v;
                }


                int
                f_10804_7324_7333(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 7324, 7333);
                    return return_v;
                }


                bool
                f_10804_7296_7334(System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>
                this_param, int
                arg)
                {
                    var return_v = this_param.Invoke((Microsoft.CodeAnalysis.CSharp.SyntaxKind)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 7296, 7334);
                    return return_v;
                }


                bool
                f_10804_7647_7656(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 7647, 7656);
                    return return_v;
                }


                int
                f_10804_7689_7698(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 7689, 7698);
                    return return_v;
                }


                bool
                f_10804_7661_7699(System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>
                this_param, int
                arg)
                {
                    var return_v = this_param.Invoke((Microsoft.CodeAnalysis.CSharp.SyntaxKind)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 7661, 7699);
                    return return_v;
                }


                bool
                f_10804_8101_8166(Microsoft.CodeAnalysis.GreenNode
                before, Microsoft.CodeAnalysis.GreenNode
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>
                ignoreChildNode, bool
                topLevel)
                {
                    var return_v = AreEquivalentRecursive(before, after, ignoreChildNode, topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 8101, 8166);
                    return return_v;
                }


                int
                f_10804_8417_8433(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 8417, 8433);
                    return return_v;
                }


                int
                f_10804_8469_8484(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 8469, 8484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10804_8667_8684(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 8667, 8684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10804_8720_8736(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 8720, 8736);
                    return return_v;
                }


                bool
                f_10804_8766_8831(Microsoft.CodeAnalysis.GreenNode?
                before, Microsoft.CodeAnalysis.GreenNode?
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode, bool
                topLevel)
                {
                    var return_v = AreEquivalentRecursive(before, after, ignoreChildNode, topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 8766, 8831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10804, 3709, 8994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10804, 3709, 8994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AreNullableDirectivesEquivalent(GreenNode before, GreenNode after, Func<SyntaxKind, bool>? ignoreChildNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10804, 9006, 10958);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 9287, 9432) || true) && (ignoreChildNode is object && (DynAbs.Tracing.TraceSender.Expression_True(10804, 9291, 9371) && f_10804_9320_9371(ignoreChildNode, SyntaxKind.NullableDirectiveTrivia)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 9287, 9432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 9405, 9417);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 9287, 9432);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 9448, 9552);

                using var
                beforeDirectivesEnumerator = f_10804_9487_9551(f_10804_9487_9535(((Green.CSharpSyntaxNode)before)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 9566, 9668);

                using var
                afterDirectivesEnumerator = f_10804_9604_9667(f_10804_9604_9651(((Green.CSharpSyntaxNode)after)))
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 9682, 10947) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 9682, 10947);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 9727, 9845);

                        Green.DirectiveTriviaSyntax?
                        beforeAnnotation = f_10804_9775_9844(beforeDirectivesEnumerator, ignoreChildNode)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 9863, 9979);

                        Green.DirectiveTriviaSyntax?
                        afterAnnotation = f_10804_9910_9978(afterDirectivesEnumerator, ignoreChildNode)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 9999, 10158) || true) && (beforeAnnotation == null || (DynAbs.Tracing.TraceSender.Expression_False(10804, 10003, 10054) || afterAnnotation == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 9999, 10158);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 10096, 10139);

                            return beforeAnnotation == afterAnnotation;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 9999, 10158);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 10178, 10348) || true) && (!f_10804_10183_10274(beforeAnnotation, afterAnnotation, ignoreChildNode, topLevel: false))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 10178, 10348);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 10316, 10329);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 10178, 10348);
                        }

                        Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax?
                f_10804_9775_9844(System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                enumerator, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode)
                        {
                            var return_v = getNextNullableDirective(enumerator, ignoreChildNode);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 9775, 9844);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax?
                        f_10804_9910_9978(System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                        enumerator, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                        ignoreChildNode)
                        {
                            var return_v = getNextNullableDirective(enumerator, ignoreChildNode);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 9910, 9978);
                            return return_v;
                        }

                        static Green.DirectiveTriviaSyntax? getNextNullableDirective(IEnumerator<Green.DirectiveTriviaSyntax> enumerator, Func<SyntaxKind, bool>? ignoreChildNode)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10804, 10368, 10932);
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 10563, 10877) || true) && (f_10804_10570_10591(enumerator))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 10563, 10877);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 10641, 10674);

                                        var
                                        current = f_10804_10655_10673(enumerator)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 10700, 10854) || true) && (f_10804_10704_10716(current) == SyntaxKind.NullableDirectiveTrivia)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10804, 10700, 10854);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 10812, 10827);

                                            return current;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 10700, 10854);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 10563, 10877);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10804, 10563, 10877);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10804, 10563, 10877);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10804, 10901, 10913);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10804, 10368, 10932);

                                bool
                                f_10804_10570_10591(System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                                this_param)
                                {
                                    var return_v = this_param.MoveNext();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 10570, 10591);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                                f_10804_10655_10673(System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                                this_param)
                                {
                                    var return_v = this_param.Current;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 10655, 10673);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                                f_10804_10704_10716(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                                this_param)
                                {
                                    var return_v = this_param.Kind;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10804, 10704, 10716);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10804, 10368, 10932);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10804, 10368, 10932);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10804, 9682, 10947);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10804, 9682, 10947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10804, 9682, 10947);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10804, 9006, 10958);

                bool
                f_10804_9320_9371(System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 9320, 9371);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                f_10804_9487_9535(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.GetDirectives();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 9487, 9535);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                f_10804_9487_9551(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 9487, 9551);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                f_10804_9604_9651(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.GetDirectives();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 9604, 9651);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                f_10804_9604_9667(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 9604, 9667);
                    return return_v;
                }


                


                bool
                f_10804_10183_10274(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                before, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode, bool
                topLevel)
                {
                    var return_v = AreEquivalentRecursive((Microsoft.CodeAnalysis.GreenNode)before, (Microsoft.CodeAnalysis.GreenNode)after, ignoreChildNode, topLevel: topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10804, 10183, 10274);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10804, 9006, 10958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10804, 9006, 10958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxEquivalence()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10804, 379, 10965);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10804, 379, 10965);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10804, 379, 10965);
        }

    }
}
