// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal partial class SyntaxList
    {
        internal class SeparatedWithManyChildren : SyntaxList
        {
            private readonly ArrayElement<SyntaxNode?>[] _children;

            internal SeparatedWithManyChildren(InternalSyntax.SyntaxList green, SyntaxNode? parent, int position)
            : base(f_675_598_603_C(green), parent, position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(675, 472, 740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(675, 446, 455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(675, 655, 725);

                    _children = new ArrayElement<SyntaxNode?>[(f_675_698_713(green) + 1) >> 1];
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(675, 472, 740);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(675, 472, 740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(675, 472, 740);
                }
            }

            internal override SyntaxNode? GetNodeSlot(int i)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(675, 756, 1052);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(675, 837, 959) || true) && ((i & 1) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(675, 837, 959);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(675, 928, 940);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(675, 837, 959);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(675, 979, 1037);

                    return f_675_986_1036(this, ref _children[i >> 1].Value, i);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(675, 756, 1052);

                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_675_986_1036(Microsoft.CodeAnalysis.Syntax.SyntaxList.SeparatedWithManyChildren
                    this_param, ref Microsoft.CodeAnalysis.SyntaxNode?
                    element, int
                    slot)
                    {
                        var return_v = this_param.GetRedElement(ref element, slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(675, 986, 1036);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(675, 756, 1052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(675, 756, 1052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override SyntaxNode? GetCachedSlot(int i)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(675, 1068, 1339);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(675, 1151, 1273) || true) && ((i & 1) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(675, 1151, 1273);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(675, 1242, 1254);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(675, 1151, 1273);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(675, 1293, 1324);

                    return _children[i >> 1].Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(675, 1068, 1339);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(675, 1068, 1339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(675, 1068, 1339);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SeparatedWithManyChildren()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(675, 323, 1350);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(675, 323, 1350);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(675, 323, 1350);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(675, 323, 1350);

            static int
            f_675_698_713(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            this_param)
            {
                var return_v = this_param.SlotCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(675, 698, 713);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            f_675_598_603_C(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(675, 472, 740);
                return return_v;
            }

        }
    }
}
