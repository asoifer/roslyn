// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Linq;
using System.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal class TreeDumper
    {
        private readonly StringBuilder _sb;

        protected TreeDumper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(41, 1900, 1984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 1884, 1887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 1947, 1973);

                _sb = f_41_1953_1972();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(41, 1900, 1984);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(41, 1900, 1984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 1900, 1984);
            }
        }

        public static string DumpCompact(TreeDumperNode root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(41, 1996, 2129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2074, 2118);

                return f_41_2081_2117(f_41_2081_2097(), root);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(41, 1996, 2129);

                Microsoft.CodeAnalysis.TreeDumper
                f_41_2081_2097()
                {
                    var return_v = new Microsoft.CodeAnalysis.TreeDumper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 2081, 2097);
                    return return_v;
                }


                string
                f_41_2081_2117(Microsoft.CodeAnalysis.TreeDumper
                this_param, Microsoft.CodeAnalysis.TreeDumperNode
                root)
                {
                    var return_v = this_param.DoDumpCompact(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 2081, 2117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(41, 1996, 2129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 1996, 2129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected string DoDumpCompact(TreeDumperNode root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(41, 2141, 2298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2217, 2251);

                f_41_2217_2250(this, root, string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2265, 2287);

                return f_41_2272_2286(_sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(41, 2141, 2298);

                int
                f_41_2217_2250(Microsoft.CodeAnalysis.TreeDumper
                this_param, Microsoft.CodeAnalysis.TreeDumperNode
                node, string
                indent)
                {
                    this_param.DoDumpCompact(node, indent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 2217, 2250);
                    return 0;
                }


                string
                f_41_2272_2286(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 2272, 2286);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(41, 2141, 2298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 2141, 2298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DoDumpCompact(TreeDumperNode node, string indent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(41, 2310, 3511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2397, 2430);

                f_41_2397_2429(node != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2444, 2479);

                f_41_2444_2478(indent != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2642, 2664);

                f_41_2642_2663(
                            // Precondition: indentation and prefix has already been output
                            // Precondition: indent is correct for node's *children*
                            _sb, f_41_2653_2662(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2678, 2801) || true) && (f_41_2682_2692(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 2678, 2801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2734, 2786);

                    f_41_2734_2785(_sb, ": {0}", f_41_2760_2784(this, f_41_2773_2783(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(41, 2678, 2801);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2817, 2834);

                f_41_2817_2833(
                            _sb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2848, 2886);

                var
                children = f_41_2863_2885(f_41_2863_2876(node))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2909, 2914);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2900, 3500) || true) && (i < f_41_2920_2934(children))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2936, 2939)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(41, 2900, 3500))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 2900, 3500);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 2973, 2997);

                        var
                        child = f_41_2985_2996(children, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 3015, 3102) || true) && (child == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 3015, 3102);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 3074, 3083);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(41, 3015, 3102);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 3122, 3141);

                        f_41_3122_3140(
                                        _sb, indent);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 3159, 3217);

                        f_41_3159_3216(_sb, (DynAbs.Tracing.TraceSender.Conditional_F1(41, 3170, 3193) || ((i == f_41_3175_3189(children) - 1 && DynAbs.Tracing.TraceSender.Conditional_F2(41, 3196, 3204)) || DynAbs.Tracing.TraceSender.Conditional_F3(41, 3207, 3215))) ? '\u2514' : '\u251C');
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 3235, 3256);

                        f_41_3235_3255(_sb, '\u2500');
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 3409, 3485);

                        f_41_3409_3484(this, child, indent + ((DynAbs.Tracing.TraceSender.Conditional_F1(41, 3440, 3463) || ((i == f_41_3445_3459(children) - 1 && DynAbs.Tracing.TraceSender.Conditional_F2(41, 3466, 3470)) || DynAbs.Tracing.TraceSender.Conditional_F3(41, 3473, 3482))) ? "  " : "\u2502 "));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(41, 1, 601);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(41, 1, 601);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(41, 2310, 3511);

                int
                f_41_2397_2429(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 2397, 2429);
                    return 0;
                }


                int
                f_41_2444_2478(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 2444, 2478);
                    return 0;
                }


                string
                f_41_2653_2662(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 2653, 2662);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_2642_2663(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 2642, 2663);
                    return return_v;
                }


                object?
                f_41_2682_2692(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 2682, 2692);
                    return return_v;
                }


                object
                f_41_2773_2783(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 2773, 2783);
                    return return_v;
                }


                string
                f_41_2760_2784(Microsoft.CodeAnalysis.TreeDumper
                this_param, object
                o)
                {
                    var return_v = this_param.DumperString(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 2760, 2784);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_2734_2785(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 2734, 2785);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_2817_2833(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 2817, 2833);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                f_41_2863_2876(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 2863, 2876);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                f_41_2863_2885(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.TreeDumperNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 2863, 2885);
                    return return_v;
                }


                int
                f_41_2920_2934(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 2920, 2934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TreeDumperNode
                f_41_2985_2996(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 2985, 2996);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_3122_3140(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 3122, 3140);
                    return return_v;
                }


                int
                f_41_3175_3189(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 3175, 3189);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_3159_3216(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 3159, 3216);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_3235_3255(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 3235, 3255);
                    return return_v;
                }


                int
                f_41_3445_3459(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 3445, 3459);
                    return return_v;
                }


                int
                f_41_3409_3484(Microsoft.CodeAnalysis.TreeDumper
                this_param, Microsoft.CodeAnalysis.TreeDumperNode
                node, string
                indent)
                {
                    this_param.DoDumpCompact(node, indent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 3409, 3484);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(41, 2310, 3511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 2310, 3511);
            }
        }

        public static string DumpXML(TreeDumperNode root, string? indent = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(41, 3523, 3779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 3620, 3650);

                var
                dumper = f_41_3633_3649()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 3664, 3725);

                f_41_3664_3724(dumper, root, string.Empty, indent ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(41, 3701, 3723) ?? string.Empty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 3739, 3768);

                return f_41_3746_3767(dumper._sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(41, 3523, 3779);

                Microsoft.CodeAnalysis.TreeDumper
                f_41_3633_3649()
                {
                    var return_v = new Microsoft.CodeAnalysis.TreeDumper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 3633, 3649);
                    return return_v;
                }


                int
                f_41_3664_3724(Microsoft.CodeAnalysis.TreeDumper
                this_param, Microsoft.CodeAnalysis.TreeDumperNode
                node, string
                indent, string
                relativeIndent)
                {
                    this_param.DoDumpXML(node, indent, relativeIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 3664, 3724);
                    return 0;
                }


                string
                f_41_3746_3767(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 3746, 3767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(41, 3523, 3779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 3523, 3779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DoDumpXML(TreeDumperNode node, string indent, string relativeIndent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(41, 3791, 5278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 3897, 3930);

                f_41_3897_3929(node != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 3944, 5267) || true) && (f_41_3948_3989(f_41_3948_3961(node), child => child == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 3944, 5267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4023, 4042);

                    f_41_4023_4041(_sb, indent);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4060, 4336) || true) && (f_41_4064_4074(node) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 4060, 4336);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4124, 4196);

                        f_41_4124_4195(_sb, "<{0}>{1}</{0}>", f_41_4159_4168(node), f_41_4170_4194(this, f_41_4183_4193(node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(41, 4060, 4336);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 4060, 4336);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4278, 4317);

                        f_41_4278_4316(_sb, "<{0} />", f_41_4306_4315(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(41, 4060, 4336);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4354, 4371);

                    f_41_4354_4370(_sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(41, 3944, 5267);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 3944, 5267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4437, 4456);

                    f_41_4437_4455(_sb, indent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4474, 4511);

                    f_41_4474_4510(_sb, "<{0}>", f_41_4500_4509(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4529, 4546);

                    f_41_4529_4545(_sb);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4564, 4777) || true) && (f_41_4568_4578(node) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 4564, 4777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4628, 4647);

                        f_41_4628_4646(_sb, indent);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4669, 4719);

                        f_41_4669_4718(_sb, "{0}", f_41_4693_4717(this, f_41_4706_4716(node)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4741, 4758);

                        f_41_4741_4757(_sb);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(41, 4564, 4777);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4797, 4839);

                    var
                    childIndent = indent + relativeIndent
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4857, 5122);
                        foreach (var child in f_41_4879_4892_I(f_41_4879_4892(node)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 4857, 5122);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 4934, 5033) || true) && (child == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 4934, 5033);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 5001, 5010);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(41, 4934, 5033);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 5057, 5103);

                            f_41_5057_5102(this, child, childIndent, relativeIndent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(41, 4857, 5122);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(41, 1, 266);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(41, 1, 266);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 5142, 5161);

                    f_41_5142_5160(
                                    _sb, indent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 5179, 5217);

                    f_41_5179_5216(_sb, "</{0}>", f_41_5206_5215(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 5235, 5252);

                    f_41_5235_5251(_sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(41, 3944, 5267);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(41, 3791, 5278);

                int
                f_41_3897_3929(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 3897, 3929);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                f_41_3948_3961(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 3948, 3961);
                    return return_v;
                }


                bool
                f_41_3948_3989(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                source, System.Func<Microsoft.CodeAnalysis.TreeDumperNode, bool>
                predicate)
                {
                    var return_v = source.All<Microsoft.CodeAnalysis.TreeDumperNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 3948, 3989);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_4023_4041(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4023, 4041);
                    return return_v;
                }


                object?
                f_41_4064_4074(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 4064, 4074);
                    return return_v;
                }


                string
                f_41_4159_4168(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 4159, 4168);
                    return return_v;
                }


                object
                f_41_4183_4193(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 4183, 4193);
                    return return_v;
                }


                string
                f_41_4170_4194(Microsoft.CodeAnalysis.TreeDumper
                this_param, object
                o)
                {
                    var return_v = this_param.DumperString(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4170, 4194);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_4124_4195(System.Text.StringBuilder
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4124, 4195);
                    return return_v;
                }


                string
                f_41_4306_4315(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 4306, 4315);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_4278_4316(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4278, 4316);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_4354_4370(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4354, 4370);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_4437_4455(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4437, 4455);
                    return return_v;
                }


                string
                f_41_4500_4509(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 4500, 4509);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_4474_4510(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4474, 4510);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_4529_4545(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4529, 4545);
                    return return_v;
                }


                object?
                f_41_4568_4578(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 4568, 4578);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_4628_4646(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4628, 4646);
                    return return_v;
                }


                object
                f_41_4706_4716(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 4706, 4716);
                    return return_v;
                }


                string
                f_41_4693_4717(Microsoft.CodeAnalysis.TreeDumper
                this_param, object
                o)
                {
                    var return_v = this_param.DumperString(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4693, 4717);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_4669_4718(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4669, 4718);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_4741_4757(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4741, 4757);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                f_41_4879_4892(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 4879, 4892);
                    return return_v;
                }


                int
                f_41_5057_5102(Microsoft.CodeAnalysis.TreeDumper
                this_param, Microsoft.CodeAnalysis.TreeDumperNode
                node, string
                indent, string
                relativeIndent)
                {
                    this_param.DoDumpXML(node, indent, relativeIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 5057, 5102);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                f_41_4879_4892_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 4879, 4892);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_5142_5160(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 5142, 5160);
                    return return_v;
                }


                string
                f_41_5206_5215(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 5206, 5215);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_5179_5216(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 5179, 5216);
                    return return_v;
                }


                System.Text.StringBuilder
                f_41_5235_5251(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 5235, 5251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(41, 3791, 5278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 3791, 5278);
            }
        }

        private static bool IsDefaultImmutableArray(Object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(41, 5382, 6169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 5460, 5495);

                var
                ti = f_41_5469_5494(f_41_5469_5480(o))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 5509, 6129) || true) && (f_41_5513_5529(ti) && (DynAbs.Tracing.TraceSender.Expression_True(41, 5513, 5590) && f_41_5533_5562(ti) == typeof(ImmutableArray<>)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 5509, 6129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 5757, 5776);

                    var
                    result = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 5794, 6082) || true) && (ti != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 5794, 6082);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 5850, 5899);

                        var
                        temp = f_41_5861_5898(ti, "get_IsDefault")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 5921, 6063) || true) && (temp != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 5921, 6063);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 5987, 6040);

                            result = (bool)f_41_6002_6039(temp, o, f_41_6017_6038());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(41, 5921, 6063);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(41, 5794, 6082);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6100, 6114);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(41, 5509, 6129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6145, 6158);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(41, 5382, 6169);

                System.Type
                f_41_5469_5480(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 5469, 5480);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_41_5469_5494(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 5469, 5494);
                    return return_v;
                }


                bool
                f_41_5513_5529(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 5513, 5529);
                    return return_v;
                }


                System.Type
                f_41_5533_5562(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 5533, 5562);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_41_5861_5898(System.Reflection.TypeInfo
                this_param, string
                name)
                {
                    var return_v = this_param.GetDeclaredMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 5861, 5898);
                    return return_v;
                }


                object[]
                f_41_6017_6038()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 6017, 6038);
                    return return_v;
                }


                object?
                f_41_6002_6039(System.Reflection.MethodInfo
                this_param, object
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 6002, 6039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(41, 5382, 6169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 5382, 6169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual string DumperString(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(41, 6181, 7030);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6253, 6331) || true) && (o == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 6253, 6331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6300, 6316);

                    return "(null)";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(41, 6253, 6331);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6347, 6369);

                var
                str = o as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6383, 6458) || true) && (str != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 6383, 6458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6432, 6443);

                    return str;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(41, 6383, 6458);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6474, 6569) || true) && (f_41_6478_6504(o))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 6474, 6569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6538, 6554);

                    return "(null)";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(41, 6474, 6569);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6585, 6612);

                var
                seq = o as IEnumerable
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6626, 6792) || true) && (seq != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 6626, 6792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6675, 6777);

                    return f_41_6682_6776("{{{0}}}", f_41_6707_6775(", ", f_41_6725_6774(f_41_6725_6764(f_41_6725_6743(seq), DumperString))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(41, 6626, 6792);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6808, 6834);

                var
                symbol = o as ISymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6848, 6977) || true) && (symbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 6848, 6977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6900, 6962);

                    return f_41_6907_6961(symbol, SymbolDisplayFormat.TestFormat);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(41, 6848, 6977);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 6993, 7019);

                return f_41_7000_7012(o) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(41, 7000, 7018) ?? "");
                DynAbs.Tracing.TraceSender.TraceExitMethod(41, 6181, 7030);

                bool
                f_41_6478_6504(object
                o)
                {
                    var return_v = IsDefaultImmutableArray(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 6478, 6504);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<object>
                f_41_6725_6743(System.Collections.IEnumerable
                source)
                {
                    var return_v = source.Cast<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 6725, 6743);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_41_6725_6764(System.Collections.Generic.IEnumerable<object>
                source, System.Func<object, string>
                selector)
                {
                    var return_v = source.Select<object, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 6725, 6764);
                    return return_v;
                }


                string[]
                f_41_6725_6774(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 6725, 6774);
                    return return_v;
                }


                string
                f_41_6707_6775(string
                separator, params string[]
                value)
                {
                    var return_v = string.Join(separator, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 6707, 6775);
                    return return_v;
                }


                string
                f_41_6682_6776(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 6682, 6776);
                    return return_v;
                }


                string
                f_41_6907_6961(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 6907, 6961);
                    return return_v;
                }


                string?
                f_41_7000_7012(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 7000, 7012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(41, 6181, 7030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 6181, 7030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TreeDumper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(41, 1811, 7037);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(41, 1811, 7037);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 1811, 7037);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(41, 1811, 7037);

        static System.Text.StringBuilder
        f_41_1953_1972()
        {
            var return_v = new System.Text.StringBuilder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 1953, 1972);
            return return_v;
        }

    }
    internal sealed class TreeDumperNode
    {
        public TreeDumperNode(string text, object? value, IEnumerable<TreeDumperNode>? children)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(41, 7186, 7459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 7544, 7573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 7583, 7610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 7620, 7672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 7299, 7316);

                this.Text = text;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 7330, 7349);

                this.Value = value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 7363, 7448);

                this.Children = children ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>?>(41, 7379, 7447) ?? f_41_7391_7447());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(41, 7186, 7459);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(41, 7186, 7459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 7186, 7459);
            }
        }

        public TreeDumperNode(string text) : this(f_41_7513_7517_C(text), null, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(41, 7471, 7534);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(41, 7471, 7534);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(41, 7471, 7534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 7471, 7534);
            }
        }

        public object? Value { get; }

        public string Text { get; }

        public IEnumerable<TreeDumperNode> Children { get; }
        public TreeDumperNode this[string child]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(41, 7747, 7851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 7783, 7836);

                    return f_41_7790_7835(f_41_7790_7798(), c => c.Text == child);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(41, 7747, 7851);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                    f_41_7790_7798()
                    {
                        var return_v = Children;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 7790, 7798);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_41_7790_7835(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                    source, System.Func<Microsoft.CodeAnalysis.TreeDumperNode, bool>
                    predicate)
                    {
                        var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.TreeDumperNode>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 7790, 7835);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(41, 7747, 7851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 7747, 7851);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<KeyValuePair<TreeDumperNode?, TreeDumperNode>> PreorderTraversal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(41, 7991, 8719);

                var listYield = new List<KeyValuePair<TreeDumperNode, TreeDumperNode>>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 8101, 8172);

                var
                stack = f_41_8113_8171()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 8186, 8260);

                f_41_8186_8259(stack, f_41_8197_8258(null, this));
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 8274, 8708) || true) && (f_41_8281_8292(stack) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 8274, 8708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 8331, 8361);

                        var
                        currentEdge = f_41_8349_8360(stack)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 8379, 8404);

                        listYield.Add(currentEdge);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 8422, 8458);

                        var
                        currentNode = currentEdge.Value
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 8476, 8693);
                            foreach (var child in f_41_8498_8550_I(f_41_8498_8550(f_41_8498_8540(f_41_8498_8518(currentNode), x => x != null))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(41, 8476, 8693);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(41, 8592, 8674);

                                f_41_8592_8673(stack, f_41_8603_8672(currentNode, child));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(41, 8476, 8693);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(41, 1, 218);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(41, 1, 218);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(41, 8274, 8708);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(41, 8274, 8708);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(41, 8274, 8708);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(41, 7991, 8719);

                return listYield;

                System.Collections.Generic.Stack<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>>
                f_41_8113_8171()
                {
                    var return_v = new System.Collections.Generic.Stack<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 8113, 8171);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>
                f_41_8197_8258(Microsoft.CodeAnalysis.TreeDumperNode?
                key, Microsoft.CodeAnalysis.TreeDumperNode
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 8197, 8258);
                    return return_v;
                }


                int
                f_41_8186_8259(System.Collections.Generic.Stack<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>>
                this_param, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 8186, 8259);
                    return 0;
                }


                int
                f_41_8281_8292(System.Collections.Generic.Stack<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 8281, 8292);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>
                f_41_8349_8360(System.Collections.Generic.Stack<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 8349, 8360);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                f_41_8498_8518(Microsoft.CodeAnalysis.TreeDumperNode
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(41, 8498, 8518);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                f_41_8498_8540(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                source, System.Func<Microsoft.CodeAnalysis.TreeDumperNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.TreeDumperNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 8498, 8540);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                f_41_8498_8550(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                source)
                {
                    var return_v = source.Reverse<Microsoft.CodeAnalysis.TreeDumperNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 8498, 8550);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>
                f_41_8603_8672(Microsoft.CodeAnalysis.TreeDumperNode
                key, Microsoft.CodeAnalysis.TreeDumperNode
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 8603, 8672);
                    return return_v;
                }


                int
                f_41_8592_8673(System.Collections.Generic.Stack<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>>
                this_param, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.TreeDumperNode?, Microsoft.CodeAnalysis.TreeDumperNode>
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 8592, 8673);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                f_41_8498_8550_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 8498, 8550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(41, 7991, 8719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 7991, 8719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TreeDumperNode()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(41, 7133, 8726);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(41, 7133, 8726);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(41, 7133, 8726);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(41, 7133, 8726);

        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
        f_41_7391_7447()
        {
            var return_v = SpecializedCollections.EmptyEnumerable<TreeDumperNode>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(41, 7391, 7447);
            return return_v;
        }


        static string
        f_41_7513_7517_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(41, 7471, 7534);
            return return_v;
        }

    }
}
