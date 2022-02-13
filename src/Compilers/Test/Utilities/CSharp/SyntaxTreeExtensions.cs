// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public static class SyntaxTreeExtensions
    {
        public static SyntaxTree WithReplace(this SyntaxTree syntaxTree, int offset, int length, string newText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21018, 533, 884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 662, 701);

                var
                oldFullText = f_21018_680_700(syntaxTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 715, 812);

                var
                newFullText = f_21018_733_811(oldFullText, f_21018_757_810(f_21018_772_800(offset, length), newText))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 826, 873);

                return f_21018_833_872(syntaxTree, newFullText);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21018, 533, 884);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21018, 533, 884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 533, 884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree WithReplaceFirst(this SyntaxTree syntaxTree, string oldText, string newText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21018, 896, 1277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 1022, 1072);

                var
                oldFullText = f_21018_1040_1071(f_21018_1040_1060(syntaxTree))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 1086, 1154);

                int
                offset = f_21018_1099_1153(oldFullText, oldText, StringComparison.Ordinal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 1168, 1196);

                int
                length = f_21018_1181_1195(oldText)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 1210, 1266);

                return f_21018_1217_1265(syntaxTree, offset, length, newText);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21018, 896, 1277);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21018, 896, 1277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 896, 1277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree WithReplace(this SyntaxTree syntaxTree, int startIndex, string oldText, string newText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21018, 1289, 1750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 1426, 1476);

                var
                oldFullText = f_21018_1444_1475(f_21018_1444_1464(syntaxTree))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 1490, 1570);

                int
                offset = f_21018_1503_1569(oldFullText, oldText, startIndex, StringComparison.Ordinal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 1641, 1669);

                int
                length = f_21018_1654_1668(oldText)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 1683, 1739);

                return f_21018_1690_1738(syntaxTree, offset, length, newText);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21018, 1289, 1750);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21018, 1289, 1750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 1289, 1750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree WithInsertAt(this SyntaxTree syntaxTree, int offset, string newText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21018, 1762, 1942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 1880, 1931);

                return f_21018_1887_1930(syntaxTree, offset, 0, newText);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21018, 1762, 1942);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21018, 1762, 1942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 1762, 1942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree WithInsertBefore(this SyntaxTree syntaxTree, string existingText, string newText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21018, 1954, 2298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 2085, 2135);

                var
                oldFullText = f_21018_2103_2134(f_21018_2103_2123(syntaxTree))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 2149, 2222);

                int
                offset = f_21018_2162_2221(oldFullText, existingText, StringComparison.Ordinal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 2236, 2287);

                return f_21018_2243_2286(syntaxTree, offset, 0, newText);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21018, 1954, 2298);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21018, 1954, 2298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 1954, 2298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree WithRemoveAt(this SyntaxTree syntaxTree, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21018, 2310, 2496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 2424, 2485);

                return f_21018_2431_2484(syntaxTree, offset, length, string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21018, 2310, 2496);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21018, 2310, 2496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 2310, 2496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree WithRemoveFirst(this SyntaxTree syntaxTree, string oldText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21018, 2508, 2687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 2617, 2676);

                return f_21018_2624_2675(syntaxTree, oldText, string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21018, 2508, 2687);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21018, 2508, 2687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 2508, 2687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string Dump(this SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21018, 2699, 2894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 2773, 2813);

                var
                visitor = f_21018_2787_2812()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 2827, 2847);

                f_21018_2827_2846(visitor, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 2861, 2883);

                return f_21018_2868_2882(visitor);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21018, 2699, 2894);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21018, 2699, 2894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 2699, 2894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string Dump(this SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21018, 2906, 3020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 2980, 3009);

                return f_21018_2987_3008(f_21018_2987_3001(tree));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21018, 2906, 3020);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21018, 2906, 3020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 2906, 3020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class CSharpSyntaxPrinter : CSharpSyntaxWalker
        {
            readonly PooledStringBuilder builder;

            int indent;

            internal CSharpSyntaxPrinter()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(21018, 3193, 3315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 3140, 3147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 3166, 3176);
                    this.indent = 0; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 3256, 3300);

                    builder = f_21018_3266_3299();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(21018, 3193, 3315);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21018, 3193, 3315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 3193, 3315);
                }
            }

            internal string Dump()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(21018, 3331, 3434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 3386, 3419);

                    return f_21018_3393_3418(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(21018, 3331, 3434);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21018, 3331, 3434);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 3331, 3434);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override void DefaultVisit(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(21018, 3450, 4158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 3533, 3582);

                    f_21018_3533_3581(builder.Builder, ' ', repeatCount: indent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 3600, 3647);

                    f_21018_3600_3646(builder.Builder, f_21018_3623_3645(f_21018_3623_3634(node)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 3665, 3992) || true) && (f_21018_3669_3683(node))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21018, 3665, 3992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 3725, 3762);

                        f_21018_3725_3761(builder.Builder, " (missing)");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21018, 3665, 3992);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21018, 3665, 3992);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 3804, 3992) || true) && (node is IdentifierNameSyntax name)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21018, 3804, 3992);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 3883, 3911);

                            f_21018_3883_3910(builder.Builder, " ");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 3933, 3973);

                            f_21018_3933_3972(builder.Builder, f_21018_3956_3971(name));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21018, 3804, 3992);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21018, 3665, 3992);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 4010, 4039);

                    f_21018_4010_4038(builder.Builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 4059, 4071);

                    indent += 2;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 4089, 4113);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DefaultVisit(node), 21018, 4089, 4112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21018, 4131, 4143);

                    indent -= 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(21018, 3450, 4158);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21018, 3450, 4158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 3450, 4158);
                }
            }

            static CSharpSyntaxPrinter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21018, 3032, 4169);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21018, 3032, 4169);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 3032, 4169);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21018, 3032, 4169);

            static Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
            f_21018_3266_3299()
            {
                var return_v = PooledStringBuilder.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 3266, 3299);
                return return_v;
            }


            string
            f_21018_3393_3418(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
            this_param)
            {
                var return_v = this_param.ToStringAndFree();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 3393, 3418);
                return return_v;
            }


            System.Text.StringBuilder
            f_21018_3533_3581(System.Text.StringBuilder
            this_param, char
            value, int
            repeatCount)
            {
                var return_v = this_param.Append(value, repeatCount: repeatCount);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 3533, 3581);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_21018_3623_3634(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = node.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 3623, 3634);
                return return_v;
            }


            string
            f_21018_3623_3645(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            this_param)
            {
                var return_v = this_param.ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 3623, 3645);
                return return_v;
            }


            System.Text.StringBuilder
            f_21018_3600_3646(System.Text.StringBuilder
            this_param, string
            value)
            {
                var return_v = this_param.Append(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 3600, 3646);
                return return_v;
            }


            bool
            f_21018_3669_3683(Microsoft.CodeAnalysis.SyntaxNode
            this_param)
            {
                var return_v = this_param.IsMissing;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21018, 3669, 3683);
                return return_v;
            }


            System.Text.StringBuilder
            f_21018_3725_3761(System.Text.StringBuilder
            this_param, string
            value)
            {
                var return_v = this_param.Append(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 3725, 3761);
                return return_v;
            }


            System.Text.StringBuilder
            f_21018_3883_3910(System.Text.StringBuilder
            this_param, string
            value)
            {
                var return_v = this_param.Append(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 3883, 3910);
                return return_v;
            }


            string
            f_21018_3956_3971(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
            this_param)
            {
                var return_v = this_param.ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 3956, 3971);
                return return_v;
            }


            System.Text.StringBuilder
            f_21018_3933_3972(System.Text.StringBuilder
            this_param, string
            value)
            {
                var return_v = this_param.Append(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 3933, 3972);
                return return_v;
            }


            System.Text.StringBuilder
            f_21018_4010_4038(System.Text.StringBuilder
            this_param)
            {
                var return_v = this_param.AppendLine();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 4010, 4038);
                return return_v;
            }

        }

        static SyntaxTreeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21018, 476, 4176);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21018, 476, 4176);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21018, 476, 4176);
        }


        static Microsoft.CodeAnalysis.Text.SourceText
        f_21018_680_700(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetText();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 680, 700);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.TextSpan
        f_21018_772_800(int
        start, int
        length)
        {
            var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 772, 800);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.TextChange
        f_21018_757_810(Microsoft.CodeAnalysis.Text.TextSpan
        span, string
        newText)
        {
            var return_v = new Microsoft.CodeAnalysis.Text.TextChange(span, newText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 757, 810);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.SourceText
        f_21018_733_811(Microsoft.CodeAnalysis.Text.SourceText
        this_param, params Microsoft.CodeAnalysis.Text.TextChange[]
        changes)
        {
            var return_v = this_param.WithChanges(changes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 733, 811);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_21018_833_872(Microsoft.CodeAnalysis.SyntaxTree
        this_param, Microsoft.CodeAnalysis.Text.SourceText
        newText)
        {
            var return_v = this_param.WithChangedText(newText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 833, 872);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.SourceText
        f_21018_1040_1060(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetText();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 1040, 1060);
            return return_v;
        }


        static string
        f_21018_1040_1071(Microsoft.CodeAnalysis.Text.SourceText
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 1040, 1071);
            return return_v;
        }


        static int
        f_21018_1099_1153(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.IndexOf(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 1099, 1153);
            return return_v;
        }


        static int
        f_21018_1181_1195(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21018, 1181, 1195);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_21018_1217_1265(Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree, int
        offset, int
        length, string
        newText)
        {
            var return_v = syntaxTree.WithReplace(offset, length, newText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 1217, 1265);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.SourceText
        f_21018_1444_1464(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetText();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 1444, 1464);
            return return_v;
        }


        static string
        f_21018_1444_1475(Microsoft.CodeAnalysis.Text.SourceText
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 1444, 1475);
            return return_v;
        }


        static int
        f_21018_1503_1569(string
        this_param, string
        value, int
        startIndex, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.IndexOf(value, startIndex, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 1503, 1569);
            return return_v;
        }


        static int
        f_21018_1654_1668(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21018, 1654, 1668);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_21018_1690_1738(Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree, int
        offset, int
        length, string
        newText)
        {
            var return_v = syntaxTree.WithReplace(offset, length, newText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 1690, 1738);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_21018_1887_1930(Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree, int
        offset, int
        length, string
        newText)
        {
            var return_v = syntaxTree.WithReplace(offset, length, newText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 1887, 1930);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.SourceText
        f_21018_2103_2123(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetText();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 2103, 2123);
            return return_v;
        }


        static string
        f_21018_2103_2134(Microsoft.CodeAnalysis.Text.SourceText
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 2103, 2134);
            return return_v;
        }


        static int
        f_21018_2162_2221(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.IndexOf(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 2162, 2221);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_21018_2243_2286(Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree, int
        offset, int
        length, string
        newText)
        {
            var return_v = syntaxTree.WithReplace(offset, length, newText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 2243, 2286);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_21018_2431_2484(Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree, int
        offset, int
        length, string
        newText)
        {
            var return_v = syntaxTree.WithReplace(offset, length, newText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 2431, 2484);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_21018_2624_2675(Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree, string
        oldText, string
        newText)
        {
            var return_v = syntaxTree.WithReplaceFirst(oldText, newText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 2624, 2675);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.UnitTests.SyntaxTreeExtensions.CSharpSyntaxPrinter
        f_21018_2787_2812()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.SyntaxTreeExtensions.CSharpSyntaxPrinter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 2787, 2812);
            return return_v;
        }


        static int
        f_21018_2827_2846(Microsoft.CodeAnalysis.CSharp.UnitTests.SyntaxTreeExtensions.CSharpSyntaxPrinter
        this_param, Microsoft.CodeAnalysis.SyntaxNode
        node)
        {
            this_param.Visit(node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 2827, 2846);
            return 0;
        }


        static string
        f_21018_2868_2882(Microsoft.CodeAnalysis.CSharp.UnitTests.SyntaxTreeExtensions.CSharpSyntaxPrinter
        this_param)
        {
            var return_v = this_param.Dump();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 2868, 2882);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_21018_2987_3001(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 2987, 3001);
            return return_v;
        }


        static string
        f_21018_2987_3008(Microsoft.CodeAnalysis.SyntaxNode
        node)
        {
            var return_v = node.Dump();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21018, 2987, 3008);
            return return_v;
        }

    }
}
