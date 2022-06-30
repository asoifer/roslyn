// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal partial class SyntaxList
    {
        internal class WithTwoChildren : SyntaxList
        {
            private SyntaxNode? _child0;

            private SyntaxNode? _child1;

            internal WithTwoChildren(InternalSyntax.SyntaxList green, SyntaxNode? parent, int position)
            : base(f_680_653_658_C(green), parent, position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(680, 537, 707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(680, 471, 478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(680, 513, 520);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(680, 537, 707);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(680, 537, 707);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(680, 537, 707);
                }
            }

            internal override SyntaxNode? GetNodeSlot(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(680, 723, 1144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(680, 808, 1129);

                    switch (index)
                    {

                        case 0:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(680, 808, 1129);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(680, 896, 938);

                            return f_680_903_937(this, ref _child0, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(680, 808, 1129);

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(680, 808, 1129);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(680, 993, 1042);

                            return f_680_1000_1041(this, ref _child1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(680, 808, 1129);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(680, 808, 1129);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(680, 1098, 1110);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(680, 808, 1129);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(680, 723, 1144);

                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_680_903_937(Microsoft.CodeAnalysis.Syntax.SyntaxList.WithTwoChildren
                    this_param, ref Microsoft.CodeAnalysis.SyntaxNode?
                    element, int
                    slot)
                    {
                        var return_v = this_param.GetRedElement(ref element, slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(680, 903, 937);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_680_1000_1041(Microsoft.CodeAnalysis.Syntax.SyntaxList.WithTwoChildren
                    this_param, ref Microsoft.CodeAnalysis.SyntaxNode?
                    element)
                    {
                        var return_v = this_param.GetRedElementIfNotToken(ref element);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(680, 1000, 1041);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(680, 723, 1144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(680, 723, 1144);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override SyntaxNode? GetCachedSlot(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(680, 1160, 1522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(680, 1247, 1507);

                    switch (index)
                    {

                        case 0:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(680, 1247, 1507);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(680, 1335, 1350);

                            return _child0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(680, 1247, 1507);

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(680, 1247, 1507);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(680, 1405, 1420);

                            return _child1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(680, 1247, 1507);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(680, 1247, 1507);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(680, 1476, 1488);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(680, 1247, 1507);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(680, 1160, 1522);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(680, 1160, 1522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(680, 1160, 1522);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static WithTwoChildren()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(680, 383, 1535);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(680, 383, 1535);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(680, 383, 1535);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(680, 383, 1535);

            static Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            f_680_653_658_C(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(680, 537, 707);
                return return_v;
            }

        }
    }
}
