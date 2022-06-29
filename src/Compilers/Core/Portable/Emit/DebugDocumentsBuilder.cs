// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Utilities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Emit
{
    internal sealed class DebugDocumentsBuilder
    {
        private readonly ConcurrentDictionary<string, Cci.DebugSourceDocument> _debugDocuments;

        private readonly ConcurrentCache<(string, string), string> _normalizedPathsCache;

        private readonly SourceReferenceResolver _resolverOpt;

        public DebugDocumentsBuilder(SourceReferenceResolver resolverOpt, bool isDocumentNameCaseSensitive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(288, 1348, 1845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 1165, 1180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 1250, 1271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 1323, 1335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 1472, 1499);

                _resolverOpt = resolverOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 1515, 1744);

                _debugDocuments = f_288_1533_1743((DynAbs.Tracing.TraceSender.Conditional_F1(288, 1613, 1640) || ((isDocumentNameCaseSensitive && DynAbs.Tracing.TraceSender.Conditional_F2(288, 1664, 1686)) || DynAbs.Tracing.TraceSender.Conditional_F3(288, 1710, 1742))) ? f_288_1664_1686() : f_288_1710_1742());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 1760, 1834);

                _normalizedPathsCache = f_288_1784_1833(16);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(288, 1348, 1845);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(288, 1348, 1845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(288, 1348, 1845);
            }
        }

        internal int DebugDocumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(288, 1889, 1913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 1892, 1913);
                    return f_288_1892_1913(_debugDocuments); DynAbs.Tracing.TraceSender.TraceExitMethod(288, 1889, 1913);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(288, 1889, 1913);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(288, 1889, 1913);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void AddDebugDocument(Cci.DebugSourceDocument document)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(288, 1926, 2075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 2015, 2064);

                f_288_2015_2063(_debugDocuments, f_288_2035_2052(document), document);
                DynAbs.Tracing.TraceSender.TraceExitMethod(288, 1926, 2075);

                string
                f_288_2035_2052(Microsoft.Cci.DebugSourceDocument
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(288, 2035, 2052);
                    return return_v;
                }


                int
                f_288_2015_2063(System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.Cci.DebugSourceDocument>
                dict, string
                key, Microsoft.Cci.DebugSourceDocument
                value)
                {
                    dict.Add<string, Microsoft.Cci.DebugSourceDocument>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(288, 2015, 2063);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(288, 1926, 2075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(288, 1926, 2075);
            }
        }

        internal IReadOnlyDictionary<string, Cci.DebugSourceDocument> DebugDocuments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(288, 2177, 2195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 2180, 2195);
                    return _debugDocuments; DynAbs.Tracing.TraceSender.TraceExitMethod(288, 2177, 2195);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(288, 2177, 2195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(288, 2177, 2195);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Cci.DebugSourceDocument TryGetDebugDocument(string path, string basePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(288, 2208, 2414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 2315, 2403);

                return f_288_2322_2402(this, f_288_2359_2401(this, path, basePath));
                DynAbs.Tracing.TraceSender.TraceExitMethod(288, 2208, 2414);

                string
                f_288_2359_2401(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
                this_param, string
                path, string
                basePath)
                {
                    var return_v = this_param.NormalizeDebugDocumentPath(path, basePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(288, 2359, 2401);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_288_2322_2402(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
                this_param, string
                normalizedPath)
                {
                    var return_v = this_param.TryGetDebugDocumentForNormalizedPath(normalizedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(288, 2322, 2402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(288, 2208, 2414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(288, 2208, 2414);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.DebugSourceDocument TryGetDebugDocumentForNormalizedPath(string normalizedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(288, 2426, 2689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 2543, 2576);

                Cci.DebugSourceDocument
                document
                = default(Cci.DebugSourceDocument);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 2590, 2648);

                f_288_2590_2647(_debugDocuments, normalizedPath, out document);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 2662, 2678);

                return document;
                DynAbs.Tracing.TraceSender.TraceExitMethod(288, 2426, 2689);

                bool
                f_288_2590_2647(System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.Cci.DebugSourceDocument>
                this_param, string
                key, out Microsoft.Cci.DebugSourceDocument
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(288, 2590, 2647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(288, 2426, 2689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(288, 2426, 2689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.DebugSourceDocument GetOrAddDebugDocument(string path, string basePath, Func<string, Cci.DebugSourceDocument> factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(288, 2701, 2953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 2857, 2942);

                return f_288_2864_2941(_debugDocuments, f_288_2889_2931(this, path, basePath), factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(288, 2701, 2953);

                string
                f_288_2889_2931(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
                this_param, string
                path, string
                basePath)
                {
                    var return_v = this_param.NormalizeDebugDocumentPath(path, basePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(288, 2889, 2931);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_288_2864_2941(System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.Cci.DebugSourceDocument>
                this_param, string
                key, System.Func<string, Microsoft.Cci.DebugSourceDocument>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(288, 2864, 2941);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(288, 2701, 2953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(288, 2701, 2953);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string NormalizeDebugDocumentPath(string path, string basePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(288, 2965, 3537);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 3062, 3147) || true) && (_resolverOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(288, 3062, 3147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 3120, 3132);

                    return path;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(288, 3062, 3147);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 3163, 3190);

                var
                key = (path, basePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 3204, 3226);

                string
                normalizedPath
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 3240, 3488) || true) && (!f_288_3245_3303(_normalizedPathsCache, key, out normalizedPath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(288, 3240, 3488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 3337, 3405);

                    normalizedPath = f_288_3354_3396(_resolverOpt, path, basePath) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(288, 3354, 3404) ?? path);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 3423, 3473);

                    f_288_3423_3472(_normalizedPathsCache, key, normalizedPath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(288, 3240, 3488);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(288, 3504, 3526);

                return normalizedPath;
                DynAbs.Tracing.TraceSender.TraceExitMethod(288, 2965, 3537);

                bool
                f_288_3245_3303(Microsoft.CodeAnalysis.ConcurrentCache<(string, string), string>
                this_param, (string path, string basePath)
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(288, 3245, 3303);
                    return return_v;
                }


                string?
                f_288_3354_3396(Microsoft.CodeAnalysis.SourceReferenceResolver
                this_param, string
                path, string
                baseFilePath)
                {
                    var return_v = this_param.NormalizePath(path, baseFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(288, 3354, 3396);
                    return return_v;
                }


                bool
                f_288_3423_3472(Microsoft.CodeAnalysis.ConcurrentCache<(string, string), string>
                this_param, (string path, string basePath)
                key, string
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(288, 3423, 3472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(288, 2965, 3537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(288, 2965, 3537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DebugDocumentsBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(288, 390, 3544);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(288, 390, 3544);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(288, 390, 3544);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(288, 390, 3544);

        static System.StringComparer
        f_288_1664_1686()
        {
            var return_v = StringComparer.Ordinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(288, 1664, 1686);
            return return_v;
        }


        static System.StringComparer
        f_288_1710_1742()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(288, 1710, 1742);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.Cci.DebugSourceDocument>
        f_288_1533_1743(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.Cci.DebugSourceDocument>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(288, 1533, 1743);
            return return_v;
        }


        static Microsoft.CodeAnalysis.ConcurrentCache<(string, string), string>
        f_288_1784_1833(int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.ConcurrentCache<(string, string), string>(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(288, 1784, 1833);
            return return_v;
        }


        int
        f_288_1892_1913(System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.Cci.DebugSourceDocument>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(288, 1892, 1913);
            return return_v;
        }

    }
}
