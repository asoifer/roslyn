// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal partial class SyntaxList
    {
        internal class WithManyChildren : SyntaxList
        {
            private readonly ArrayElement<SyntaxNode?>[] _children;

            internal WithManyChildren(InternalSyntax.SyntaxList green, SyntaxNode? parent, int position)
            : base(f_677_580_585_C(green), parent, position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(677, 463, 711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(677, 437, 446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(677, 637, 696);

                    _children = new ArrayElement<SyntaxNode?>[f_677_679_694(green)];
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(677, 463, 711);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(677, 463, 711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(677, 463, 711);
                }
            }

            internal override SyntaxNode? GetNodeSlot(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(677, 727, 888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(677, 812, 873);

                    return f_677_819_872(this, ref _children[index].Value, index);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(677, 727, 888);

                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_677_819_872(Microsoft.CodeAnalysis.Syntax.SyntaxList.WithManyChildren
                    this_param, ref Microsoft.CodeAnalysis.SyntaxNode?
                    element, int
                    slot)
                    {
                        var return_v = this_param.GetRedElement(ref element, slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(677, 819, 872);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(677, 727, 888);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(677, 727, 888);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override SyntaxNode? GetCachedSlot(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(677, 904, 1030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(677, 991, 1015);

                    return _children[index];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(677, 904, 1030);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(677, 904, 1030);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(677, 904, 1030);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static WithManyChildren()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(677, 323, 1041);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(677, 323, 1041);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(677, 323, 1041);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(677, 323, 1041);

            static int
            f_677_679_694(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            this_param)
            {
                var return_v = this_param.SlotCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(677, 679, 694);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            f_677_580_585_C(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(677, 463, 711);
                return return_v;
            }

        }
    }
}
