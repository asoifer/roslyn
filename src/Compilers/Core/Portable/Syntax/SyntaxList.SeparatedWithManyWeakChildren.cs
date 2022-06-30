// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal partial class SyntaxList
    {
        internal class SeparatedWithManyWeakChildren : SyntaxList
        {
            private readonly ArrayElement<WeakReference<SyntaxNode>?>[] _children;

            internal SeparatedWithManyWeakChildren(InternalSyntax.SyntaxList green, SyntaxNode parent, int position)
            : base(f_676_620_625_C(green), parent, position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(676, 491, 785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(676, 465, 474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(676, 677, 770);

                    _children = new ArrayElement<WeakReference<SyntaxNode>?>[(((f_676_737_752(green) + 1) >> 1) - 1)];
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(676, 491, 785);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(676, 491, 785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(676, 491, 785);
                }
            }

            internal override SyntaxNode? GetNodeSlot(int i)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(676, 801, 1158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(676, 882, 908);

                    SyntaxNode?
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(676, 928, 1109) || true) && ((i & 1) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(676, 928, 1109);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(676, 1026, 1090);

                        result = f_676_1035_1089(this, ref this._children[i >> 1].Value, i);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(676, 928, 1109);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(676, 1129, 1143);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(676, 801, 1158);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_676_1035_1089(Microsoft.CodeAnalysis.Syntax.SyntaxList.SeparatedWithManyWeakChildren
                    this_param, ref System.WeakReference<Microsoft.CodeAnalysis.SyntaxNode>?
                    slot, int
                    index)
                    {
                        var return_v = this_param.GetWeakRedElement(ref slot, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(676, 1035, 1089);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(676, 801, 1158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(676, 801, 1158);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override SyntaxNode? GetCachedSlot(int i)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(676, 1174, 1650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(676, 1257, 1283);

                    SyntaxNode?
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(676, 1303, 1601) || true) && ((i & 1) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(676, 1303, 1601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(676, 1401, 1441);

                        var
                        weak = this._children[i >> 1].Value
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(676, 1463, 1582) || true) && (weak != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(676, 1463, 1582);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(676, 1529, 1559);

                            f_676_1529_1558(weak, out result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(676, 1463, 1582);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(676, 1303, 1601);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(676, 1621, 1635);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(676, 1174, 1650);

                    bool
                    f_676_1529_1558(System.WeakReference<Microsoft.CodeAnalysis.SyntaxNode>
                    this_param, out Microsoft.CodeAnalysis.SyntaxNode?
                    target)
                    {
                        var return_v = this_param.TryGetTarget(out target);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(676, 1529, 1558);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(676, 1174, 1650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(676, 1174, 1650);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SeparatedWithManyWeakChildren()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(676, 323, 1661);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(676, 323, 1661);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(676, 323, 1661);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(676, 323, 1661);

            static int
            f_676_737_752(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            this_param)
            {
                var return_v = this_param.SlotCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(676, 737, 752);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            f_676_620_625_C(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(676, 491, 785);
                return return_v;
            }

        }
    }
}
