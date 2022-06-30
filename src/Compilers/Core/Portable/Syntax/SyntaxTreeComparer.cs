// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal class SyntaxTreeComparer : IEqualityComparer<SyntaxTree>
    {
        public static readonly SyntaxTreeComparer Instance;

        public bool Equals(SyntaxTree? x, SyntaxTree? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(703, 534, 969);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(703, 607, 780) || true) && (x == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(703, 607, 780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(703, 654, 671);

                    return y == null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(703, 607, 780);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(703, 607, 780);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(703, 705, 780) || true) && (y == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(703, 705, 780);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(703, 752, 765);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(703, 705, 780);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(703, 607, 780);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(703, 796, 958);

                return f_703_803_876(f_703_817_827(x), f_703_829_839(y), StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(703, 803, 957) && f_703_897_957(SourceTextComparer.Instance, f_703_932_943(x), f_703_945_956(y)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(703, 534, 969);

                string
                f_703_817_827(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(703, 817, 827);
                    return return_v;
                }


                string
                f_703_829_839(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(703, 829, 839);
                    return return_v;
                }


                bool
                f_703_803_876(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(703, 803, 876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_703_932_943(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(703, 932, 943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_703_945_956(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(703, 945, 956);
                    return return_v;
                }


                bool
                f_703_897_957(Microsoft.CodeAnalysis.Text.SourceTextComparer
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                x, Microsoft.CodeAnalysis.Text.SourceText
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(703, 897, 957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(703, 534, 969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(703, 534, 969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(SyntaxTree obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(703, 981, 1159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(703, 1044, 1148);

                return f_703_1051_1147(f_703_1064_1090(f_703_1064_1076(obj)), f_703_1092_1146(SourceTextComparer.Instance, f_703_1132_1145(obj)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(703, 981, 1159);

                string
                f_703_1064_1076(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(703, 1064, 1076);
                    return return_v;
                }


                int
                f_703_1064_1090(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(703, 1064, 1090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_703_1132_1145(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(703, 1132, 1145);
                    return return_v;
                }


                int
                f_703_1092_1146(Microsoft.CodeAnalysis.Text.SourceTextComparer
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(703, 1092, 1146);
                    return return_v;
                }


                int
                f_703_1051_1147(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(703, 1051, 1147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(703, 981, 1159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(703, 981, 1159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTreeComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(703, 362, 1166);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(703, 362, 1166);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(703, 362, 1166);
        }


        static SyntaxTreeComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(703, 362, 1166);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(703, 486, 521);
            Instance = f_703_497_521(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(703, 362, 1166);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(703, 362, 1166);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(703, 362, 1166);

        static Microsoft.CodeAnalysis.SyntaxTreeComparer
        f_703_497_521()
        {
            var return_v = new Microsoft.CodeAnalysis.SyntaxTreeComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(703, 497, 521);
            return return_v;
        }

    }
}
