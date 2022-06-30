// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{

    internal partial struct ChildSyntaxList
    {

        internal partial struct Reversed
        {

            private readonly GreenNode? _node;

            internal Reversed(GreenNode? node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(819, 486, 581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(819, 553, 566);

                    _node = node;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(819, 486, 581);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(819, 486, 581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(819, 486, 581);
                }
            }

            public Enumerator GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(819, 597, 707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(819, 663, 692);

                    return f_819_670_691(_node);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(819, 597, 707);

                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Reversed.Enumerator
                    f_819_670_691(Microsoft.CodeAnalysis.GreenNode?
                    node)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Reversed.Enumerator(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(819, 670, 691);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(819, 597, 707);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(819, 597, 707);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [Obsolete("For debugging", error: true)]
            private GreenNode[] Nodes
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(819, 875, 1152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(819, 919, 954);

                        var
                        result = f_819_932_953()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(819, 976, 1085);
                            foreach (var n in f_819_994_998_I(this))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(819, 976, 1085);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(819, 1048, 1062);

                                f_819_1048_1061(result, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(819, 976, 1085);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(819, 1, 110);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(819, 1, 110);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(819, 1109, 1133);

                        return f_819_1116_1132(result);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(819, 875, 1152);

                        System.Collections.Generic.List<Microsoft.CodeAnalysis.GreenNode>
                        f_819_932_953()
                        {
                            var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.GreenNode>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(819, 932, 953);
                            return return_v;
                        }


                        int
                        f_819_1048_1061(System.Collections.Generic.List<Microsoft.CodeAnalysis.GreenNode>
                        this_param, Microsoft.CodeAnalysis.GreenNode
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(819, 1048, 1061);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Reversed
                        f_819_994_998_I(Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Reversed
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(819, 994, 998);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.GreenNode[]
                        f_819_1116_1132(System.Collections.Generic.List<Microsoft.CodeAnalysis.GreenNode>
                        this_param)
                        {
                            var return_v = this_param.ToArray();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(819, 1116, 1132);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(819, 763, 1167);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(819, 763, 1167);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
            static Reversed()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(819, 379, 1217);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(819, 379, 1217);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(819, 379, 1217);
            }

#pragma warning restore 618
        }
    }
}
