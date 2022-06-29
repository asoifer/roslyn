// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Xml;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal partial class XmlDocumentationCommentTextReader
    {
        private XmlReader _reader;

        private readonly Reader _textReader;

        private static readonly ObjectPool<XmlDocumentationCommentTextReader> s_pool;

        public static XmlException ParseAndGetException(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(281, 1024, 1267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1109, 1140);

                var
                reader = f_281_1122_1139(s_pool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1154, 1194);

                var
                retVal = f_281_1167_1193(reader, text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1208, 1228);

                f_281_1208_1227(s_pool, reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1242, 1256);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(281, 1024, 1267);

                Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader
                f_281_1122_1139(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 1122, 1139);
                    return return_v;
                }


                System.Xml.XmlException
                f_281_1167_1193(Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader
                this_param, string
                text)
                {
                    var return_v = this_param.ParseInternal(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 1167, 1193);
                    return return_v;
                }


                int
                f_281_1208_1227(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader>
                this_param, Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 1208, 1227);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(281, 1024, 1267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(281, 1024, 1267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly XmlReaderSettings s_xmlSettings;

        internal XmlException ParseInternal(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(281, 1447, 2440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1520, 1546);

                f_281_1520_1545(_textReader, text);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1562, 1685) || true) && (_reader == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(281, 1562, 1685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1615, 1670);

                    _reader = f_281_1625_1669(_textReader, s_xmlSettings);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(281, 1562, 1685);
                }

                try
                {
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(281, 1737, 1868);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1780, 1795);

                                f_281_1780_1794(_reader);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(281, 1737, 1868);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1737, 1868) || true) && (!f_281_1840_1866(_reader))
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(281, 1737, 1868);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(281, 1737, 1868);
                        }
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1888, 2065) || true) && (f_281_1892_1907(_textReader))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(281, 1888, 2065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1949, 1967);

                        f_281_1949_1966(_reader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1989, 2004);

                        _reader = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 2026, 2046);

                        f_281_2026_2045(_textReader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(281, 1888, 2065);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 2085, 2097);

                    return null;
                }
                catch (XmlException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(281, 2126, 2429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 2297, 2315);

                    f_281_2297_2314(                // The reader is in a bad state, so dispose of it and recreate a new one next time we get called.
                                    _reader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 2333, 2348);

                    _reader = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 2366, 2386);

                    f_281_2366_2385(_textReader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 2404, 2414);

                    return ex;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(281, 2126, 2429);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(281, 1447, 2440);

                int
                f_281_1520_1545(Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader.Reader
                this_param, string
                text)
                {
                    this_param.SetText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 1520, 1545);
                    return 0;
                }


                System.Xml.XmlReader
                f_281_1625_1669(Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader.Reader
                input, System.Xml.XmlReaderSettings
                settings)
                {
                    var return_v = XmlReader.Create((System.IO.TextReader)input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 1625, 1669);
                    return return_v;
                }


                bool
                f_281_1780_1794(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 1780, 1794);
                    return return_v;
                }


                bool
                f_281_1840_1866(System.Xml.XmlReader
                reader)
                {
                    var return_v = Reader.ReachedEnd(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 1840, 1866);
                    return return_v;
                }


                bool
                f_281_1892_1907(Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader.Reader
                this_param)
                {
                    var return_v = this_param.Eof;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(281, 1892, 1907);
                    return return_v;
                }


                int
                f_281_1949_1966(System.Xml.XmlReader
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 1949, 1966);
                    return 0;
                }


                int
                f_281_2026_2045(Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader.Reader
                this_param)
                {
                    this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 2026, 2045);
                    return 0;
                }


                int
                f_281_2297_2314(System.Xml.XmlReader?
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 2297, 2314);
                    return 0;
                }


                int
                f_281_2366_2385(Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader.Reader
                this_param)
                {
                    this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 2366, 2385);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(281, 1447, 2440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(281, 1447, 2440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public XmlDocumentationCommentTextReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(281, 642, 2447);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 733, 740);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 775, 801);
            this._textReader = f_281_789_801(); DynAbs.Tracing.TraceSender.TraceExitConstructor(281, 642, 2447);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(281, 642, 2447);
        }


        static XmlDocumentationCommentTextReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(281, 642, 2447);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 884, 1011);
            s_pool = f_281_906_1011(() => new XmlDocumentationCommentTextReader(), size: 2); DynAbs.Tracing.TraceSender.TraceSimpleStatement(281, 1321, 1401);
            s_xmlSettings = new XmlReaderSettings { DtdProcessing = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => DtdProcessing.Prohibit, 281, 1337, 1401) }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(281, 642, 2447);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(281, 642, 2447);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(281, 642, 2447);

        Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader.Reader
        f_281_789_801()
        {
            var return_v = new Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader.Reader();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 789, 801);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader>
        f_281_906_1011(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader>.Factory
        factory, int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.XmlDocumentationCommentTextReader>(factory, size: size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(281, 906, 1011);
            return return_v;
        }

    }
}
