// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{

    internal partial struct SyntaxList<TNode> where TNode : GreenNode
    {

        internal struct Enumerator
        {

            private readonly SyntaxList<TNode> _list;

            private int _index;

            internal Enumerator(SyntaxList<TNode> list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(835, 494, 628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(835, 570, 583);

                    _list = list;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(835, 601, 613);

                    _index = -1;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(835, 494, 628);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(835, 494, 628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(835, 494, 628);
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(835, 644, 930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(835, 699, 725);

                    var
                    newIndex = _index + 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(835, 743, 882) || true) && (newIndex < _list.Count)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(835, 743, 882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(835, 811, 829);

                        _index = newIndex;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(835, 851, 863);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(835, 743, 882);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(835, 902, 915);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(835, 644, 930);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(835, 644, 930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(835, 644, 930);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public TNode Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(835, 999, 1084);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(835, 1043, 1065);

                        return _list[_index]!;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(835, 999, 1084);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(835, 946, 1099);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(835, 946, 1099);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(835, 353, 1110);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(835, 353, 1110);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(835, 353, 1110);
            }
        }
    }
}
