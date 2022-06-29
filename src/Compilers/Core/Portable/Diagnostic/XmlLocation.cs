// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;
using System;
using System.Xml.Linq;
using System.Xml;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    internal class XmlLocation : Location, IEquatable<XmlLocation?>
    {
        private readonly FileLinePositionSpan _positionSpan;

        private XmlLocation(string path, int lineNumber, int columnNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(205, 599, 918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 690, 754);

                LinePosition
                start = f_205_711_753(lineNumber, columnNumber)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 768, 834);

                LinePosition
                end = f_205_787_833(lineNumber, columnNumber + 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 848, 907);

                _positionSpan = f_205_864_906(path, start, end);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(205, 599, 918);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(205, 599, 918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(205, 599, 918);
            }
        }

        public static XmlLocation Create(XmlException exception, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(205, 930, 1303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 1093, 1148);

                int
                lineNumber = f_205_1110_1147(f_205_1119_1139(exception) - 1, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 1162, 1221);

                int
                columnNumber = f_205_1181_1220(f_205_1190_1212(exception) - 1, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 1237, 1292);

                return f_205_1244_1291(path, lineNumber, columnNumber);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(205, 930, 1303);

                int
                f_205_1119_1139(System.Xml.XmlException
                this_param)
                {
                    var return_v = this_param.LineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(205, 1119, 1139);
                    return return_v;
                }


                int
                f_205_1110_1147(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(205, 1110, 1147);
                    return return_v;
                }


                int
                f_205_1190_1212(System.Xml.XmlException
                this_param)
                {
                    var return_v = this_param.LinePosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(205, 1190, 1212);
                    return return_v;
                }


                int
                f_205_1181_1220(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(205, 1181, 1220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.XmlLocation
                f_205_1244_1291(string
                path, int
                lineNumber, int
                columnNumber)
                {
                    var return_v = new Microsoft.CodeAnalysis.XmlLocation(path, lineNumber, columnNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(205, 1244, 1291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(205, 930, 1303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(205, 930, 1303);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlLocation Create(XObject obj, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(205, 1315, 1786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 1398, 1429);

                IXmlLineInfo
                xmlLineInfo = obj
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 1443, 1487);

                f_205_1443_1486(f_205_1456_1480(xmlLineInfo) != 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 1572, 1629);

                int
                lineNumber = f_205_1589_1628(f_205_1598_1620(xmlLineInfo) - 1, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 1643, 1704);

                int
                columnNumber = f_205_1662_1703(f_205_1671_1695(xmlLineInfo) - 1, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 1720, 1775);

                return f_205_1727_1774(path, lineNumber, columnNumber);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(205, 1315, 1786);

                int
                f_205_1456_1480(System.Xml.IXmlLineInfo
                this_param)
                {
                    var return_v = this_param.LinePosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(205, 1456, 1480);
                    return return_v;
                }


                int
                f_205_1443_1486(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(205, 1443, 1486);
                    return 0;
                }


                int
                f_205_1598_1620(System.Xml.IXmlLineInfo
                this_param)
                {
                    var return_v = this_param.LineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(205, 1598, 1620);
                    return return_v;
                }


                int
                f_205_1589_1628(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(205, 1589, 1628);
                    return return_v;
                }


                int
                f_205_1671_1695(System.Xml.IXmlLineInfo
                this_param)
                {
                    var return_v = this_param.LinePosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(205, 1671, 1695);
                    return return_v;
                }


                int
                f_205_1662_1703(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(205, 1662, 1703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.XmlLocation
                f_205_1727_1774(string
                path, int
                lineNumber, int
                columnNumber)
                {
                    var return_v = new Microsoft.CodeAnalysis.XmlLocation(path, lineNumber, columnNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(205, 1727, 1774);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(205, 1315, 1786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(205, 1315, 1786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override LocationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(205, 1856, 1935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 1892, 1920);

                    return LocationKind.XmlFile;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(205, 1856, 1935);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(205, 1798, 1946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(205, 1798, 1946);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FileLinePositionSpan GetLineSpan()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(205, 1958, 2065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 2033, 2054);

                return _positionSpan;
                DynAbs.Tracing.TraceSender.TraceExitMethod(205, 1958, 2065);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(205, 1958, 2065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(205, 1958, 2065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(XmlLocation? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(205, 2077, 2326);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 2140, 2233) || true) && (f_205_2144_2172(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(205, 2140, 2233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 2206, 2218);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(205, 2140, 2233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 2249, 2315);

                return other != null && (DynAbs.Tracing.TraceSender.Expression_True(205, 2256, 2314) && other._positionSpan.Equals(_positionSpan));
                DynAbs.Tracing.TraceSender.TraceExitMethod(205, 2077, 2326);

                bool
                f_205_2144_2172(Microsoft.CodeAnalysis.XmlLocation
                objA, Microsoft.CodeAnalysis.XmlLocation?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(205, 2144, 2172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(205, 2077, 2326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(205, 2077, 2326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(205, 2338, 2453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 2403, 2442);

                return f_205_2410_2441(this, obj as XmlLocation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(205, 2338, 2453);

                bool
                f_205_2410_2441(Microsoft.CodeAnalysis.XmlLocation
                this_param, object?
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.XmlLocation?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(205, 2410, 2441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(205, 2338, 2453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(205, 2338, 2453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(205, 2465, 2569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(205, 2523, 2558);

                return _positionSpan.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceExitMethod(205, 2465, 2569);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(205, 2465, 2569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(205, 2465, 2569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static XmlLocation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(205, 455, 2576);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(205, 455, 2576);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(205, 455, 2576);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(205, 455, 2576);

        static Microsoft.CodeAnalysis.Text.LinePosition
        f_205_711_753(int
        line, int
        character)
        {
            var return_v = new Microsoft.CodeAnalysis.Text.LinePosition(line, character);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(205, 711, 753);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.LinePosition
        f_205_787_833(int
        line, int
        character)
        {
            var return_v = new Microsoft.CodeAnalysis.Text.LinePosition(line, character);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(205, 787, 833);
            return return_v;
        }


        static Microsoft.CodeAnalysis.FileLinePositionSpan
        f_205_864_906(string
        path, Microsoft.CodeAnalysis.Text.LinePosition
        start, Microsoft.CodeAnalysis.Text.LinePosition
        end)
        {
            var return_v = new Microsoft.CodeAnalysis.FileLinePositionSpan(path, start, end);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(205, 864, 906);
            return return_v;
        }

    }
}
