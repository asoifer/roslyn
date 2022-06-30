// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{

    internal partial struct ChildSyntaxList
    {

        private readonly GreenNode? _node;

        private int _count;

        internal ChildSyntaxList(GreenNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(817, 402, 517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 467, 480);

                _node = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 494, 506);

                _count = -1;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(817, 402, 517);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(817, 402, 517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(817, 402, 517);
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(817, 570, 759);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 606, 710) || true) && (_count == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(817, 606, 710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 664, 691);

                        _count = this.CountNodes();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(817, 606, 710);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 730, 744);

                    return _count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(817, 570, 759);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(817, 529, 770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(817, 529, 770);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int CountNodes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(817, 782, 1024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 831, 841);

                int
                n = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 855, 893);

                var
                enumerator = this.GetEnumerator()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 907, 988) || true) && (enumerator.MoveNext())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(817, 907, 988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 969, 973);

                        n++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(817, 907, 988);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(817, 907, 988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(817, 907, 988);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 1004, 1013);

                return n;
                DynAbs.Tracing.TraceSender.TraceExitMethod(817, 782, 1024);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(817, 782, 1024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(817, 782, 1024);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private GreenNode[] Nodes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(817, 1112, 1383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 1148, 1187);

                    var
                    result = new GreenNode[this.Count]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 1205, 1215);

                    var
                    i = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 1235, 1334);
                        foreach (var n in f_817_1253_1257_I(this))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(817, 1235, 1334);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 1299, 1315);

                            result[i++] = n;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(817, 1235, 1334);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(817, 1, 100);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(817, 1, 100);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 1354, 1368);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(817, 1112, 1383);

                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList
                    f_817_1253_1257_I(Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(817, 1253, 1257);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(817, 1062, 1394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(817, 1062, 1394);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Enumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(817, 1406, 1504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 1464, 1493);

                return f_817_1471_1492(_node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(817, 1406, 1504);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator
                f_817_1471_1492(Microsoft.CodeAnalysis.GreenNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(817, 1471, 1492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(817, 1406, 1504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(817, 1406, 1504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Reversed Reverse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(817, 1516, 1604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(817, 1566, 1593);

                return f_817_1573_1592(_node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(817, 1516, 1604);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Reversed
                f_817_1573_1592(Microsoft.CodeAnalysis.GreenNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Reversed(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(817, 1573, 1592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(817, 1516, 1604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(817, 1516, 1604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static ChildSyntaxList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(817, 271, 1611);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(817, 271, 1611);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(817, 271, 1611);
        }
    }
}
