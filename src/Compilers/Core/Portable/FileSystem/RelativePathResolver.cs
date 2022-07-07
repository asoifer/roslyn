// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

#pragma warning disable 436 // The type 'RelativePathResolver' conflicts with imported type

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Roslyn.Utilities;
using System.IO;

namespace Microsoft.CodeAnalysis
{
    internal class RelativePathResolver : IEquatable<RelativePathResolver>
    {
        public ImmutableArray<string> SearchPaths { get; }

        public string BaseDirectory { get; }

        public RelativePathResolver(ImmutableArray<string> searchPaths, string baseDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(303, 1086, 1464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 656, 692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 1196, 1252);

                f_303_1196_1251(searchPaths.All(PathUtilities.IsAbsolute));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 1266, 1367);

                f_303_1266_1366(baseDirectory == null || (DynAbs.Tracing.TraceSender.Expression_False(303, 1279, 1365) || f_303_1304_1344(baseDirectory) == PathKind.Absolute));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 1383, 1409);

                SearchPaths = searchPaths;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 1423, 1453);

                BaseDirectory = baseDirectory;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(303, 1086, 1464);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(303, 1086, 1464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(303, 1086, 1464);
            }
        }

        public string ResolvePath(string reference, string baseFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(303, 1476, 1872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 1565, 1686);

                string
                resolvedPath = f_303_1587_1685(reference, baseFilePath, f_303_1646_1659(), f_303_1661_1672(), FileExists)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 1700, 1785) || true) && (resolvedPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(303, 1700, 1785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 1758, 1770);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(303, 1700, 1785);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 1801, 1861);

                return f_303_1808_1860(resolvedPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(303, 1476, 1872);

                string
                f_303_1646_1659()
                {
                    var return_v = BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(303, 1646, 1659);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_303_1661_1672()
                {
                    var return_v = SearchPaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(303, 1661, 1672);
                    return return_v;
                }


                string?
                f_303_1587_1685(string
                path, string
                basePath, string
                baseDirectory, System.Collections.Immutable.ImmutableArray<string>
                searchPaths, System.Func<string, bool>
                fileExists)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, basePath, baseDirectory, (System.Collections.Generic.IEnumerable<string>)searchPaths, fileExists);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 1587, 1685);
                    return return_v;
                }


                string?
                f_303_1808_1860(string
                path)
                {
                    var return_v = FileUtilities.TryNormalizeAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 1808, 1860);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(303, 1476, 1872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(303, 1476, 1872);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual bool FileExists(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(303, 1884, 2107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 1959, 1990);

                f_303_1959_1989(fullPath != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 2004, 2053);

                f_303_2004_2052(f_303_2017_2051(fullPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 2067, 2096);

                return f_303_2074_2095(fullPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(303, 1884, 2107);

                int
                f_303_1959_1989(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 1959, 1989);
                    return 0;
                }


                bool
                f_303_2017_2051(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 2017, 2051);
                    return return_v;
                }


                int
                f_303_2004_2052(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 2004, 2052);
                    return 0;
                }


                bool
                f_303_2074_2095(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 2074, 2095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(303, 1884, 2107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(303, 1884, 2107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RelativePathResolver WithSearchPaths(ImmutableArray<string> searchPaths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(303, 2199, 2246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 2215, 2246);
                return f_303_2215_2246(searchPaths, f_303_2232_2245());

                Microsoft.CodeAnalysis.RelativePathResolver
f_303_2215_2246(System.Collections.Immutable.ImmutableArray<string>
searchPaths, string
baseDirectory)
                {
                    var return_v = new Microsoft.CodeAnalysis.RelativePathResolver(searchPaths, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 2215, 2246);
                    return return_v;
                }

                DynAbs.Tracing.TraceSender.TraceExitMethod(303, 2199, 2246);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(303, 2199, 2246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(303, 2199, 2246);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string
            f_303_2232_2245()
            {
                var return_v = BaseDirectory;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(303, 2232, 2245);
                return return_v;
            }

        }

        public RelativePathResolver WithBaseDirectory(string baseDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(303, 2327, 2374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 2343, 2374);
                return new(f_303_2347_2358(), baseDirectory); DynAbs.Tracing.TraceSender.TraceExitMethod(303, 2327, 2374);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(303, 2327, 2374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(303, 2327, 2374);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<string>
            f_303_2347_2358()
            {
                var return_v = SearchPaths;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(303, 2347, 2358);
                return return_v;
            }

        }

        public bool Equals(RelativePathResolver other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(303, 2434, 2534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 2450, 2534);
                return f_303_2450_2463() == f_303_2467_2486(other) && (DynAbs.Tracing.TraceSender.Expression_True(303, 2450, 2534) && f_303_2490_2501().SequenceEqual(f_303_2516_2533(other))); DynAbs.Tracing.TraceSender.TraceExitMethod(303, 2434, 2534);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(303, 2434, 2534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(303, 2434, 2534);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string
            f_303_2450_2463()
            {
                var return_v = BaseDirectory;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(303, 2450, 2463);
                return return_v;
            }


            string
            f_303_2467_2486(Microsoft.CodeAnalysis.RelativePathResolver
            this_param)
            {
                var return_v = this_param.BaseDirectory;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(303, 2467, 2486);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<string>
            f_303_2490_2501()
            {
                var return_v = SearchPaths;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(303, 2490, 2501);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<string>
            f_303_2516_2533(Microsoft.CodeAnalysis.RelativePathResolver
            this_param)
            {
                var return_v = this_param.SearchPaths;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(303, 2516, 2533);
                return return_v;
            }

        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(303, 2581, 2657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 2597, 2657);
                return f_303_2597_2657(f_303_2610_2623(), f_303_2625_2656(f_303_2644_2655())); DynAbs.Tracing.TraceSender.TraceExitMethod(303, 2581, 2657);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(303, 2581, 2657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(303, 2581, 2657);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string
            f_303_2610_2623()
            {
                var return_v = BaseDirectory;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(303, 2610, 2623);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<string>
            f_303_2644_2655()
            {
                var return_v = SearchPaths;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(303, 2644, 2655);
                return return_v;
            }


            int
            f_303_2625_2656(System.Collections.Immutable.ImmutableArray<string>
            values)
            {
                var return_v = Hash.CombineValues(values);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 2625, 2656);
                return return_v;
            }


            int
            f_303_2597_2657(string
            newKeyPart, int
            currentKey)
            {
                var return_v = Hash.Combine(newKeyPart, currentKey);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 2597, 2657);
                return return_v;
            }

        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(303, 2710, 2748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(303, 2713, 2748);
                return f_303_2713_2748(this, obj as RelativePathResolver); DynAbs.Tracing.TraceSender.TraceExitMethod(303, 2710, 2748);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(303, 2710, 2748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(303, 2710, 2748);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_303_2713_2748(Microsoft.CodeAnalysis.RelativePathResolver
            this_param, object
            other)
            {
                var return_v = this_param.Equals((Microsoft.CodeAnalysis.RelativePathResolver?)other);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 2713, 2748);
                return return_v;
            }

        }

        static RelativePathResolver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(303, 509, 2756);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(303, 509, 2756);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(303, 509, 2756);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(303, 509, 2756);

        static int
        f_303_1196_1251(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 1196, 1251);
            return 0;
        }


        static Roslyn.Utilities.PathKind
        f_303_1304_1344(string
        path)
        {
            var return_v = PathUtilities.GetPathKind(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 1304, 1344);
            return return_v;
        }


        static int
        f_303_1266_1366(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(303, 1266, 1366);
            return 0;
        }

    }
}
