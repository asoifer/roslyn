// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal partial class XmlDocumentationCommentTextReader
    {
        internal sealed class Reader : TextReader
        {
            private string _text;

            private int _position;

            private const int
            maxReadsPastTheEnd = 100
            ;

            private int _readsPastTheEnd;

            private static readonly string s_rootElementName;

            private static readonly string s_currentElementName;

            internal static readonly string RootStart;

            internal static readonly string CurrentStart;

            internal static readonly string CurrentEnd;

            public void Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(282, 2481, 2632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 2533, 2546);

                    _text = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 2564, 2578);

                    _position = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 2596, 2617);

                    _readsPastTheEnd = 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(282, 2481, 2632);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(282, 2481, 2632);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(282, 2481, 2632);
                }
            }

            public void SetText(string text)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(282, 2648, 3043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 2713, 2726);

                    _text = text;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 2744, 2765);

                    _readsPastTheEnd = 0;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 2921, 3028) || true) && (_position > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(282, 2921, 3028);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 2980, 3009);

                        _position = f_282_2992_3008(RootStart);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(282, 2921, 3028);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(282, 2648, 3043);

                    int
                    f_282_2992_3008(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 2992, 3008);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(282, 2648, 3043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(282, 2648, 3043);
                }
            }

            internal int Position
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(282, 3141, 3166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 3147, 3164);

                        return _position;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(282, 3141, 3166);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(282, 3087, 3181);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(282, 3087, 3181);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public static bool ReachedEnd(XmlReader reader)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(282, 3197, 3443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 3277, 3428);

                    return f_282_3284_3296(reader) == 1
                    && (DynAbs.Tracing.TraceSender.Expression_True(282, 3284, 3367) && f_282_3326_3341(reader) == XmlNodeType.EndElement
                    ) && (DynAbs.Tracing.TraceSender.Expression_True(282, 3284, 3427) && f_282_3392_3403(reader) == s_currentElementName);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(282, 3197, 3443);

                    int
                    f_282_3284_3296(System.Xml.XmlReader
                    this_param)
                    {
                        var return_v = this_param.Depth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 3284, 3296);
                        return return_v;
                    }


                    System.Xml.XmlNodeType
                    f_282_3326_3341(System.Xml.XmlReader
                    this_param)
                    {
                        var return_v = this_param.NodeType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 3326, 3341);
                        return return_v;
                    }


                    string
                    f_282_3392_3403(System.Xml.XmlReader
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 3392, 3403);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(282, 3197, 3443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(282, 3197, 3443);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Eof
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(282, 3507, 3616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 3551, 3597);

                        return _readsPastTheEnd >= maxReadsPastTheEnd;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(282, 3507, 3616);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(282, 3459, 3631);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(282, 3459, 3631);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int Read(char[] buffer, int index, int count)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(282, 3647, 5105);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 3741, 3832) || true) && (count == 0 || (DynAbs.Tracing.TraceSender.Expression_False(282, 3745, 3762) || f_282_3759_3762()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(282, 3741, 3832);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 3804, 3813);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(282, 3741, 3832);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 4116, 4141);

                    int
                    initialCount = count
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 4188, 4270);

                    _position += f_282_4201_4269(RootStart, _position, buffer, ref index, ref count);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 4320, 4424);

                    _position += f_282_4333_4423(CurrentStart, _position - f_282_4376_4392(RootStart), buffer, ref index, ref count);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 4469, 4588);

                    _position += f_282_4482_4587(_text, _position - f_282_4518_4534(RootStart) - f_282_4537_4556(CurrentStart), buffer, ref index, ref count);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 4639, 4778);

                    _position += f_282_4652_4777(CurrentEnd, _position - f_282_4693_4709(RootStart) - f_282_4712_4731(CurrentStart) - f_282_4734_4746(_text), buffer, ref index, ref count);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 4865, 5042) || true) && (initialCount == count)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(282, 4865, 5042);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 4932, 4951);

                        _readsPastTheEnd++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 4973, 4993);

                        buffer[index] = ' ';
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 5015, 5023);

                        count--;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(282, 4865, 5042);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 5062, 5090);

                    return initialCount - count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(282, 3647, 5105);

                    bool
                    f_282_3759_3762()
                    {
                        var return_v = Eof;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 3759, 3762);
                        return return_v;
                    }


                    int
                    f_282_4201_4269(string
                    src, int
                    srcIndex, char[]
                    dest, ref int
                    destIndex, ref int
                    destCount)
                    {
                        var return_v = EncodeAndAdvance(src, srcIndex, dest, ref destIndex, ref destCount);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(282, 4201, 4269);
                        return return_v;
                    }


                    int
                    f_282_4376_4392(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 4376, 4392);
                        return return_v;
                    }


                    int
                    f_282_4333_4423(string
                    src, int
                    srcIndex, char[]
                    dest, ref int
                    destIndex, ref int
                    destCount)
                    {
                        var return_v = EncodeAndAdvance(src, srcIndex, dest, ref destIndex, ref destCount);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(282, 4333, 4423);
                        return return_v;
                    }


                    int
                    f_282_4518_4534(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 4518, 4534);
                        return return_v;
                    }


                    int
                    f_282_4537_4556(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 4537, 4556);
                        return return_v;
                    }


                    int
                    f_282_4482_4587(string
                    src, int
                    srcIndex, char[]
                    dest, ref int
                    destIndex, ref int
                    destCount)
                    {
                        var return_v = EncodeAndAdvance(src, srcIndex, dest, ref destIndex, ref destCount);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(282, 4482, 4587);
                        return return_v;
                    }


                    int
                    f_282_4693_4709(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 4693, 4709);
                        return return_v;
                    }


                    int
                    f_282_4712_4731(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 4712, 4731);
                        return return_v;
                    }


                    int
                    f_282_4734_4746(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 4734, 4746);
                        return return_v;
                    }


                    int
                    f_282_4652_4777(string
                    src, int
                    srcIndex, char[]
                    dest, ref int
                    destIndex, ref int
                    destCount)
                    {
                        var return_v = EncodeAndAdvance(src, srcIndex, dest, ref destIndex, ref destCount);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(282, 4652, 4777);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(282, 3647, 5105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(282, 3647, 5105);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static int EncodeAndAdvance(string src, int srcIndex, char[] dest, ref int destIndex, ref int destCount)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(282, 5121, 5769);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 5266, 5396) || true) && (destCount == 0 || (DynAbs.Tracing.TraceSender.Expression_False(282, 5270, 5300) || srcIndex < 0) || (DynAbs.Tracing.TraceSender.Expression_False(282, 5270, 5326) || srcIndex >= f_282_5316_5326(src)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(282, 5266, 5396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 5368, 5377);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(282, 5266, 5396);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 5416, 5475);

                    int
                    charCount = f_282_5432_5474(f_282_5441_5451(src) - srcIndex, destCount)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 5493, 5521);

                    f_282_5493_5520(charCount > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 5539, 5588);

                    f_282_5539_5587(src, srcIndex, dest, destIndex, charCount);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 5608, 5631);

                    destIndex += charCount;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 5649, 5672);

                    destCount -= charCount;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 5690, 5719);

                    f_282_5690_5718(destCount >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 5737, 5754);

                    return charCount;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(282, 5121, 5769);

                    int
                    f_282_5316_5326(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 5316, 5326);
                        return return_v;
                    }


                    int
                    f_282_5441_5451(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 5441, 5451);
                        return return_v;
                    }


                    int
                    f_282_5432_5474(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(282, 5432, 5474);
                        return return_v;
                    }


                    int
                    f_282_5493_5520(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(282, 5493, 5520);
                        return 0;
                    }


                    int
                    f_282_5539_5587(string
                    this_param, int
                    sourceIndex, char[]
                    destination, int
                    destinationIndex, int
                    count)
                    {
                        this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(282, 5539, 5587);
                        return 0;
                    }


                    int
                    f_282_5690_5718(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(282, 5690, 5718);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(282, 5121, 5769);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(282, 5121, 5769);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int Read()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(282, 5785, 5949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 5897, 5934);

                    throw f_282_5903_5933();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(282, 5785, 5949);

                    System.Exception
                    f_282_5903_5933()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 5903, 5933);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(282, 5785, 5949);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(282, 5785, 5949);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int Peek()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(282, 5965, 6129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 6077, 6114);

                    throw f_282_6083_6113();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(282, 5965, 6129);

                    System.Exception
                    f_282_6083_6113()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(282, 6083, 6113);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(282, 5965, 6129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(282, 5965, 6129);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public Reader()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(282, 449, 6140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 628, 633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 662, 671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 1733, 1749);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(282, 449, 6140);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(282, 449, 6140);
            }


            static Reader()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(282, 449, 6140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 1682, 1706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 1993, 2047);
                s_rootElementName = "_" + Guid.NewGuid().ToString("N"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 2093, 2150);
                s_currentElementName = "_" + Guid.NewGuid().ToString("N"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 2236, 2277);
                RootStart = "<" + s_rootElementName + ">"; DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 2324, 2371);
                CurrentStart = "<" + s_currentElementName + ">"; DynAbs.Tracing.TraceSender.TraceSimpleStatement(282, 2418, 2464);
                CurrentEnd = "</" + s_currentElementName + ">"; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(282, 449, 6140);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(282, 449, 6140);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(282, 449, 6140);
        }
    }
}
