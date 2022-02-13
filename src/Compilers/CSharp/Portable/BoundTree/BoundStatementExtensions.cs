// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static partial class BoundStatementExtensions
    {
        [Conditional("DEBUG")]
        internal static void AssertIsLabeledStatement(this BoundStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10574, 427, 887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10574, 555, 876);

                switch (f_10574_563_572(node))
                {

                    case BoundKind.LabelStatement:
                    case BoundKind.LabeledStatement:
                    case BoundKind.SwitchSection:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10574, 555, 876);
                        DynAbs.Tracing.TraceSender.TraceBreak(10574, 755, 761);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10574, 555, 876);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10574, 555, 876);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10574, 809, 861);

                        throw f_10574_815_860(f_10574_850_859(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10574, 555, 876);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10574, 427, 887);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10574_563_572(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10574, 563, 572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10574_850_859(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10574, 850, 859);
                    return return_v;
                }


                System.Exception
                f_10574_815_860(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10574, 815, 860);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10574, 427, 887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10574, 427, 887);
            }
        }

        [Conditional("DEBUG")]
        internal static void AssertIsLabeledStatementWithLabel(this BoundStatement node, LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10574, 901, 1979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10574, 1057, 1084);

                f_10574_1057_1083(node != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10574, 1100, 1968);

                switch (f_10574_1108_1117(node))
                {

                    case BoundKind.LabelStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10574, 1100, 1968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10574, 1203, 1260);

                        f_10574_1203_1259(f_10574_1216_1249(((BoundLabelStatement)node)) == label);
                        DynAbs.Tracing.TraceSender.TraceBreak(10574, 1282, 1288);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10574, 1100, 1968);

                    case BoundKind.LabeledStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10574, 1100, 1968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10574, 1362, 1421);

                        f_10574_1362_1420(f_10574_1375_1410(((BoundLabeledStatement)node)) == label);
                        DynAbs.Tracing.TraceSender.TraceBreak(10574, 1443, 1449);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10574, 1100, 1968);

                    case BoundKind.SwitchSection:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10574, 1100, 1968);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10574, 1520, 1792);
                            foreach (var boundSwitchLabel in f_10574_1553_1592_I(f_10574_1553_1592(((BoundSwitchSection)node))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10574, 1520, 1792);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10574, 1642, 1769) || true) && (f_10574_1646_1668(boundSwitchLabel) == label)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10574, 1642, 1769);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10574, 1735, 1742);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10574, 1642, 1769);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10574, 1520, 1792);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10574, 1, 273);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10574, 1, 273);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10574, 1814, 1851);

                        throw f_10574_1820_1850();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10574, 1100, 1968);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10574, 1100, 1968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10574, 1901, 1953);

                        throw f_10574_1907_1952(f_10574_1942_1951(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10574, 1100, 1968);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10574, 901, 1979);

                int
                f_10574_1057_1083(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10574, 1057, 1083);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10574_1108_1117(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10574, 1108, 1117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10574_1216_1249(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10574, 1216, 1249);
                    return return_v;
                }


                int
                f_10574_1203_1259(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10574, 1203, 1259);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10574_1375_1410(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10574, 1375, 1410);
                    return return_v;
                }


                int
                f_10574_1362_1420(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10574, 1362, 1420);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10574_1553_1592(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.SwitchLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10574, 1553, 1592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10574_1646_1668(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10574, 1646, 1668);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10574_1553_1592_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10574, 1553, 1592);
                    return return_v;
                }


                System.Exception
                f_10574_1820_1850()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10574, 1820, 1850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10574_1942_1951(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10574, 1942, 1951);
                    return return_v;
                }


                System.Exception
                f_10574_1907_1952(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10574, 1907, 1952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10574, 901, 1979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10574, 901, 1979);
            }
        }

        static BoundStatementExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10574, 356, 1986);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10574, 356, 1986);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10574, 356, 1986);
        }

    }
}
