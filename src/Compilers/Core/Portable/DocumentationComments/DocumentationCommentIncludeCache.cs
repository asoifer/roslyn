// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal sealed class DocumentationCommentIncludeCache : CachingFactory<string, KeyValuePair<string, XDocument>>
    {
        private const int
        Size = 5
        ;

        internal static int CacheMissCount { get; private set; }

        public DocumentationCommentIncludeCache(XmlReferenceResolver resolver)
        : base(f_278_880_884_C(Size), key => MakeValue(resolver, key), KeyHashCode, KeyValueEquality)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(278, 789, 1064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(278, 1034, 1053);

                CacheMissCount = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(278, 789, 1064);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(278, 789, 1064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(278, 789, 1064);
            }
        }

        public XDocument GetOrMakeDocument(string resolvedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(278, 1076, 1209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(278, 1156, 1198);

                return f_278_1163_1191(this, resolvedPath).Value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(278, 1076, 1209);

                System.Collections.Generic.KeyValuePair<string, System.Xml.Linq.XDocument>
                f_278_1163_1191(Microsoft.CodeAnalysis.DocumentationCommentIncludeCache
                this_param, string
                key)
                {
                    var return_v = this_param.GetOrMakeValue(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(278, 1163, 1191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(278, 1076, 1209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(278, 1076, 1209);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly XmlReaderSettings s_xmlSettings;

        private static KeyValuePair<string, XDocument> MakeValue(XmlReferenceResolver resolver, string resolvedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(278, 1608, 2194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(278, 1741, 1758);

                f_278_1741_1757_M(CacheMissCount++);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(278, 1774, 2183);
                using (Stream
                stream = f_278_1797_1835(resolver, resolvedPath)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(278, 1869, 2168);
                    using (XmlReader
                    reader = f_278_1895_1934(stream, s_xmlSettings)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(278, 1976, 2072);

                        var
                        document = f_278_1991_2071(reader, LoadOptions.PreserveWhitespace | LoadOptions.SetLineInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(278, 2094, 2149);

                        return f_278_2101_2148(resolvedPath, document);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(278, 1869, 2168);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(278, 1774, 2183);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(278, 1608, 2194);

                int
                f_278_1741_1757_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(278, 1741, 1757);
                    return return_v;
                }


                System.IO.Stream
                f_278_1797_1835(Microsoft.CodeAnalysis.XmlReferenceResolver
                this_param, string
                fullPath)
                {
                    var return_v = this_param.OpenReadChecked(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(278, 1797, 1835);
                    return return_v;
                }


                System.Xml.XmlReader
                f_278_1895_1934(System.IO.Stream
                input, System.Xml.XmlReaderSettings
                settings)
                {
                    var return_v = XmlReader.Create(input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(278, 1895, 1934);
                    return return_v;
                }


                System.Xml.Linq.XDocument
                f_278_1991_2071(System.Xml.XmlReader
                reader, System.Xml.Linq.LoadOptions
                options)
                {
                    var return_v = XDocument.Load(reader, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(278, 1991, 2071);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, System.Xml.Linq.XDocument>
                f_278_2101_2148(string
                key, System.Xml.Linq.XDocument
                value)
                {
                    var return_v = KeyValuePairUtil.Create(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(278, 2101, 2148);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(278, 1608, 2194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(278, 1608, 2194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int KeyHashCode(string resolvedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(278, 2206, 2327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(278, 2282, 2316);

                return f_278_2289_2315(resolvedPath);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(278, 2206, 2327);

                int
                f_278_2289_2315(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(278, 2289, 2315);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(278, 2206, 2327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(278, 2206, 2327);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool KeyValueEquality(string resolvedPath, KeyValuePair<string, XDocument> pathAndDocument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(278, 2339, 2524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(278, 2470, 2513);

                return resolvedPath == pathAndDocument.Key;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(278, 2339, 2524);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(278, 2339, 2524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(278, 2339, 2524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DocumentationCommentIncludeCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(278, 408, 2531);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(278, 578, 586);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(278, 721, 777);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(278, 1263, 1412);
            s_xmlSettings = new XmlReaderSettings()
            {
                // Dev12 prohibits DTD
                DtdProcessing = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => DtdProcessing.Prohibit, 278, 1279, 1412)
            }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(278, 408, 2531);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(278, 408, 2531);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(278, 408, 2531);

        static int
        f_278_880_884_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(278, 789, 1064);
            return return_v;
        }

    }
}
