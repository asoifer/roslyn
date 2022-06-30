// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal partial class SyntaxList
    {
        internal class WithThreeChildren : SyntaxList
        {
            private SyntaxNode? _child0;

            private SyntaxNode? _child1;

            private SyntaxNode? _child2;

            internal WithThreeChildren(InternalSyntax.SyntaxList green, SyntaxNode? parent, int position)
            : base(f_679_639_644_C(green), parent, position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(679, 521, 693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 413, 420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 455, 462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 497, 504);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(679, 521, 693);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(679, 521, 693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(679, 521, 693);
                }
            }

            internal override SyntaxNode? GetNodeSlot(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(679, 709, 1227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 794, 1212);

                    switch (index)
                    {

                        case 0:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(679, 794, 1212);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 882, 924);

                            return f_679_889_923(this, ref _child0, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(679, 794, 1212);

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(679, 794, 1212);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 979, 1028);

                            return f_679_986_1027(this, ref _child1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(679, 794, 1212);

                        case 2:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(679, 794, 1212);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 1083, 1125);

                            return f_679_1090_1124(this, ref _child2, 2);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(679, 794, 1212);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(679, 794, 1212);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 1181, 1193);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(679, 794, 1212);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(679, 709, 1227);

                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_679_889_923(Microsoft.CodeAnalysis.Syntax.SyntaxList.WithThreeChildren
                    this_param, ref Microsoft.CodeAnalysis.SyntaxNode?
                    element, int
                    slot)
                    {
                        var return_v = this_param.GetRedElement(ref element, slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(679, 889, 923);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_679_986_1027(Microsoft.CodeAnalysis.Syntax.SyntaxList.WithThreeChildren
                    this_param, ref Microsoft.CodeAnalysis.SyntaxNode?
                    element)
                    {
                        var return_v = this_param.GetRedElementIfNotToken(ref element);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(679, 986, 1027);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_679_1090_1124(Microsoft.CodeAnalysis.Syntax.SyntaxList.WithThreeChildren
                    this_param, ref Microsoft.CodeAnalysis.SyntaxNode?
                    element, int
                    slot)
                    {
                        var return_v = this_param.GetRedElement(ref element, slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(679, 1090, 1124);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(679, 709, 1227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(679, 709, 1227);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override SyntaxNode? GetCachedSlot(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(679, 1243, 1675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 1330, 1660);

                    switch (index)
                    {

                        case 0:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(679, 1330, 1660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 1418, 1433);

                            return _child0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(679, 1330, 1660);

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(679, 1330, 1660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 1488, 1503);

                            return _child1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(679, 1330, 1660);

                        case 2:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(679, 1330, 1660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 1558, 1573);

                            return _child2;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(679, 1330, 1660);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(679, 1330, 1660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(679, 1629, 1641);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(679, 1330, 1660);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(679, 1243, 1675);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(679, 1243, 1675);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(679, 1243, 1675);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static WithThreeChildren()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(679, 323, 1686);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(679, 323, 1686);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(679, 323, 1686);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(679, 323, 1686);

            static Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            f_679_639_644_C(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(679, 521, 693);
                return return_v;
            }

        }
    }
}
