// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal partial class SyntaxList
    {
        internal class WithManyWeakChildren : SyntaxList
        {
            private readonly ArrayElement<WeakReference<SyntaxNode>?>[] _children;

            private readonly int[] _childPositions;

            internal WithManyWeakChildren(InternalSyntax.SyntaxList.WithManyChildrenBase green, SyntaxNode parent, int position)
            : base(f_678_1002_1007_C(green), parent, position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(678, 861, 1618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 481, 490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 829, 844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1059, 1087);

                    int
                    count = f_678_1071_1086(green)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1105, 1169);

                    _children = new ArrayElement<WeakReference<SyntaxNode>?>[count];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1189, 1223);

                    var
                    childOffsets = new int[count]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1243, 1272);

                    int
                    childPosition = position
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1290, 1325);

                    var
                    greenChildren = green.children
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1352, 1357);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1343, 1552) || true) && (i < f_678_1363_1382(childOffsets))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1384, 1387)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(678, 1343, 1552))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(678, 1343, 1552);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1429, 1461);

                            childOffsets[i] = childPosition;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1483, 1533);

                            childPosition += f_678_1500_1532(greenChildren[i].Value);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(678, 1, 210);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(678, 1, 210);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1572, 1603);

                    _childPositions = childOffsets;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(678, 861, 1618);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(678, 861, 1618);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(678, 861, 1618);
                }
            }

            internal override int GetChildPosition(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(678, 1634, 1761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1716, 1746);

                    return _childPositions[index];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(678, 1634, 1761);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(678, 1634, 1761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(678, 1634, 1761);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override SyntaxNode GetNodeSlot(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(678, 1777, 1936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 1861, 1921);

                    return f_678_1868_1920(this, ref _children[index].Value, index);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(678, 1777, 1936);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_678_1868_1920(Microsoft.CodeAnalysis.Syntax.SyntaxList.WithManyWeakChildren
                    this_param, ref System.WeakReference<Microsoft.CodeAnalysis.SyntaxNode>?
                    slot, int
                    index)
                    {
                        var return_v = this_param.GetWeakRedElement(ref slot, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(678, 1868, 1920);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(678, 1777, 1936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(678, 1777, 1936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override SyntaxNode? GetCachedSlot(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(678, 1952, 2176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 2039, 2064);

                    SyntaxNode?
                    value = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 2082, 2130);

                    f_678_2082_2129_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_children[index].Value, 678, 2082, 2129).TryGetTarget(out value));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(678, 2148, 2161);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(678, 1952, 2176);

                    bool?
                    f_678_2082_2129_I(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(678, 2082, 2129);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(678, 1952, 2176);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(678, 1952, 2176);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static WithManyWeakChildren()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(678, 348, 2187);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(678, 348, 2187);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(678, 348, 2187);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(678, 348, 2187);

            static int
            f_678_1071_1086(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
            this_param)
            {
                var return_v = this_param.SlotCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(678, 1071, 1086);
                return return_v;
            }


            static int
            f_678_1363_1382(int[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(678, 1363, 1382);
                return return_v;
            }


            static int
            f_678_1500_1532(Microsoft.CodeAnalysis.GreenNode
            this_param)
            {
                var return_v = this_param.FullWidth;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(678, 1500, 1532);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            f_678_1002_1007_C(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(678, 861, 1618);
                return return_v;
            }

        }
    }
}
