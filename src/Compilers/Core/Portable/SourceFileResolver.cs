// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public class SourceFileResolver : SourceReferenceResolver, IEquatable<SourceFileResolver>
    {
        public static SourceFileResolver Default { get; }

        private readonly string? _baseDirectory;

        private readonly ImmutableArray<string> _searchPaths;

        private readonly ImmutableArray<KeyValuePair<string, string>> _pathMap;

        public SourceFileResolver(IEnumerable<string> searchPaths, string? baseDirectory)
        : this(f_33_1138_1169_C(f_33_1138_1169(searchPaths)), baseDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(33, 1036, 1207);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(33, 1036, 1207);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 1036, 1207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 1036, 1207);
            }
        }

        public SourceFileResolver(ImmutableArray<string> searchPaths, string? baseDirectory)
        : this(f_33_1324_1335_C(searchPaths), baseDirectory, ImmutableArray<KeyValuePair<string, string>>.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(33, 1219, 1425);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(33, 1219, 1425);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 1219, 1425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 1219, 1425);
            }
        }

        public SourceFileResolver(
                    ImmutableArray<string> searchPaths,
                    string? baseDirectory,
                    ImmutableArray<KeyValuePair<string, string>> pathMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(33, 1437, 3725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 865, 879);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 1640, 1767) || true) && (searchPaths.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(33, 1640, 1767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 1699, 1752);

                    throw f_33_1705_1751(nameof(searchPaths));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(33, 1640, 1767);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 1783, 2017) || true) && (baseDirectory != null && (DynAbs.Tracing.TraceSender.Expression_True(33, 1787, 1873) && f_33_1812_1852(baseDirectory) != PathKind.Absolute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(33, 1783, 2017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 1907, 2002);

                    throw f_33_1913_2001(f_33_1935_1977(), nameof(baseDirectory));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(33, 1783, 2017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 2033, 2064);

                _baseDirectory = baseDirectory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 2078, 2105);

                _searchPaths = searchPaths;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 2553, 3714) || true) && (f_33_2557_2582_M(!pathMap.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(33, 2553, 3714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 2616, 2708);

                    var
                    pathMapBuilder = f_33_2637_2707(pathMap.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 2728, 3504);
                        foreach (var (key, value) in f_33_2757_2764_I(pathMap))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(33, 2728, 3504);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 2806, 2999) || true) && (key == null || (DynAbs.Tracing.TraceSender.Expression_False(33, 2810, 2840) || f_33_2825_2835(key) == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(33, 2806, 2999);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 2890, 2976);

                                throw f_33_2896_2975(f_33_2918_2957(), nameof(pathMap));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(33, 2806, 2999);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 3023, 3200) || true) && (value == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(33, 3023, 3200);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 3090, 3177);

                                throw f_33_3096_3176(f_33_3118_3158(), nameof(pathMap));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(33, 3023, 3200);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 3224, 3287);

                            var
                            normalizedKey = f_33_3244_3286(key)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 3309, 3376);

                            var
                            normalizedValue = f_33_3331_3375(value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 3400, 3485);

                            f_33_3400_3484(
                                                pathMapBuilder, f_33_3419_3483(normalizedKey, normalizedValue));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(33, 2728, 3504);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(33, 1, 777);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(33, 1, 777);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 3524, 3571);

                    _pathMap = f_33_3535_3570(pathMapBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(33, 2553, 3714);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(33, 2553, 3714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 3637, 3699);

                    _pathMap = ImmutableArray<KeyValuePair<string, string>>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(33, 2553, 3714);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(33, 1437, 3725);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 1437, 3725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 1437, 3725);
            }
        }

        public string? BaseDirectory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(33, 3766, 3783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 3769, 3783);
                    return _baseDirectory; DynAbs.Tracing.TraceSender.TraceExitMethod(33, 3766, 3783);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 3766, 3783);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 3766, 3783);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<string> SearchPaths
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(33, 3838, 3853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 3841, 3853);
                    return _searchPaths; DynAbs.Tracing.TraceSender.TraceExitMethod(33, 3838, 3853);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 3838, 3853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 3838, 3853);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<KeyValuePair<string, string>> PathMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(33, 3926, 3937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 3929, 3937);
                    return _pathMap; DynAbs.Tracing.TraceSender.TraceExitMethod(33, 3926, 3937);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 3926, 3937);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 3926, 3937);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string? NormalizePath(string path, string? baseFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(33, 3950, 4309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 4047, 4144);

                string?
                normalizedPath = f_33_4072_4143(path, baseFilePath, _baseDirectory)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 4158, 4298);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(33, 4165, 4218) || (((normalizedPath == null || (DynAbs.Tracing.TraceSender.Expression_False(33, 4166, 4217) || _pathMap.IsDefaultOrEmpty)) && DynAbs.Tracing.TraceSender.Conditional_F2(33, 4221, 4235)) || DynAbs.Tracing.TraceSender.Conditional_F3(33, 4238, 4297))) ? normalizedPath : f_33_4238_4297(normalizedPath, _pathMap);
                DynAbs.Tracing.TraceSender.TraceExitMethod(33, 3950, 4309);

                string?
                f_33_4072_4143(string
                path, string?
                basePath, string?
                baseDirectory)
                {
                    var return_v = FileUtilities.NormalizeRelativePath(path, basePath, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 4072, 4143);
                    return return_v;
                }


                string
                f_33_4238_4297(string
                filePath, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                pathMap)
                {
                    var return_v = PathUtilities.NormalizePathPrefix(filePath, pathMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 4238, 4297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 3950, 4309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 3950, 4309);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string? ResolveReference(string path, string? baseFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(33, 4321, 4726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 4421, 4540);

                string?
                resolvedPath = f_33_4444_4539(path, baseFilePath, _baseDirectory, _searchPaths, FileExists)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 4554, 4639) || true) && (resolvedPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(33, 4554, 4639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 4612, 4624);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(33, 4554, 4639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 4655, 4715);

                return f_33_4662_4714(resolvedPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(33, 4321, 4726);

                string?
                f_33_4444_4539(string
                path, string?
                basePath, string?
                baseDirectory, System.Collections.Immutable.ImmutableArray<string>
                searchPaths, System.Func<string, bool>
                fileExists)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, basePath, baseDirectory, (System.Collections.Generic.IEnumerable<string>)searchPaths, fileExists);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 4444, 4539);
                    return return_v;
                }


                string?
                f_33_4662_4714(string
                path)
                {
                    var return_v = FileUtilities.TryNormalizeAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 4662, 4714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 4321, 4726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 4321, 4726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Stream OpenRead(string resolvedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(33, 4738, 4962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 4815, 4893);

                f_33_4815_4892(resolvedPath, nameof(resolvedPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 4907, 4951);

                return f_33_4914_4950(resolvedPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(33, 4738, 4962);

                int
                f_33_4815_4892(string
                path, string
                argumentName)
                {
                    CompilerPathUtilities.RequireAbsolutePath(path, argumentName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 4815, 4892);
                    return 0;
                }


                System.IO.Stream
                f_33_4914_4950(string
                fullPath)
                {
                    var return_v = FileUtilities.OpenRead(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 4914, 4950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 4738, 4962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 4738, 4962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual bool FileExists([NotNullWhen(true)] string? resolvedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(33, 4974, 5118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 5074, 5107);

                return f_33_5081_5106(resolvedPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(33, 4974, 5118);

                bool
                f_33_5081_5106(string?
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 5081, 5106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 4974, 5118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 4974, 5118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(33, 5130, 5449);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 5276, 5383) || true) && (obj == null || (DynAbs.Tracing.TraceSender.Expression_False(33, 5280, 5321) || f_33_5295_5304(this) != f_33_5308_5321(obj)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(33, 5276, 5383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 5355, 5368);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(33, 5276, 5383);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 5399, 5438);

                return f_33_5406_5437(this, obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(33, 5130, 5449);

                System.Type
                f_33_5295_5304(Microsoft.CodeAnalysis.SourceFileResolver
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 5295, 5304);
                    return return_v;
                }


                System.Type
                f_33_5308_5321(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 5308, 5321);
                    return return_v;
                }


                bool
                f_33_5406_5437(Microsoft.CodeAnalysis.SourceFileResolver
                this_param, object
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.SourceFileResolver)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 5406, 5437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 5130, 5449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 5130, 5449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(SourceFileResolver? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(33, 5461, 5889);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 5531, 5610) || true) && (other is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(33, 5531, 5610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 5582, 5595);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(33, 5531, 5610);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 5626, 5878);

                return
                f_33_5650_5727(_baseDirectory, other._baseDirectory, StringComparison.Ordinal) && (DynAbs.Tracing.TraceSender.Expression_True(33, 5650, 5818) && _searchPaths.SequenceEqual(other._searchPaths, f_33_5795_5817())) && (DynAbs.Tracing.TraceSender.Expression_True(33, 5650, 5877) && _pathMap.SequenceEqual(other._pathMap));
                DynAbs.Tracing.TraceSender.TraceExitMethod(33, 5461, 5889);

                bool
                f_33_5650_5727(string?
                a, string?
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 5650, 5727);
                    return return_v;
                }


                System.StringComparer
                f_33_5795_5817()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(33, 5795, 5817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 5461, 5889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 5461, 5889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(33, 5901, 6213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 5959, 6202);

                return f_33_5966_6201((DynAbs.Tracing.TraceSender.Conditional_F1(33, 5979, 6001) || ((_baseDirectory != null && DynAbs.Tracing.TraceSender.Conditional_F2(33, 6004, 6054)) || DynAbs.Tracing.TraceSender.Conditional_F3(33, 6057, 6058))) ? f_33_6004_6054(f_33_6004_6026(), _baseDirectory) : 0, f_33_6080_6200(f_33_6093_6149(_searchPaths, f_33_6126_6148()), f_33_6171_6199(_pathMap)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(33, 5901, 6213);

                System.StringComparer
                f_33_6004_6026()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(33, 6004, 6026);
                    return return_v;
                }


                int
                f_33_6004_6054(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 6004, 6054);
                    return return_v;
                }


                System.StringComparer
                f_33_6126_6148()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(33, 6126, 6148);
                    return return_v;
                }


                int
                f_33_6093_6149(System.Collections.Immutable.ImmutableArray<string>
                values, System.StringComparer
                stringComparer)
                {
                    var return_v = Hash.CombineValues((System.Collections.Generic.IEnumerable<string?>)values, stringComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 6093, 6149);
                    return return_v;
                }


                int
                f_33_6171_6199(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                values)
                {
                    var return_v = Hash.CombineValues(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 6171, 6199);
                    return return_v;
                }


                int
                f_33_6080_6200(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 6080, 6200);
                    return return_v;
                }


                int
                f_33_5966_6201(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 5966, 6201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(33, 5901, 6213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 5901, 6213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceFileResolver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(33, 596, 6220);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(33, 702, 828);
            Default = f_33_754_827(ImmutableArray<string>.Empty, baseDirectory: null); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(33, 596, 6220);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(33, 596, 6220);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(33, 596, 6220);

        static Microsoft.CodeAnalysis.SourceFileResolver
        f_33_754_827(System.Collections.Immutable.ImmutableArray<string>
        searchPaths, string?
        baseDirectory)
        {
            var return_v = new Microsoft.CodeAnalysis.SourceFileResolver(searchPaths, baseDirectory: baseDirectory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 754, 827);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_33_1138_1169(System.Collections.Generic.IEnumerable<string>
        items)
        {
            var return_v = items.AsImmutableOrNull<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 1138, 1169);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_33_1138_1169_C(System.Collections.Immutable.ImmutableArray<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(33, 1036, 1207);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_33_1324_1335_C(System.Collections.Immutable.ImmutableArray<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(33, 1219, 1425);
            return return_v;
        }


        static System.ArgumentNullException
        f_33_1705_1751(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 1705, 1751);
            return return_v;
        }


        static Roslyn.Utilities.PathKind
        f_33_1812_1852(string
        path)
        {
            var return_v = PathUtilities.GetPathKind(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 1812, 1852);
            return return_v;
        }


        static string
        f_33_1935_1977()
        {
            var return_v = CodeAnalysisResources.AbsolutePathExpected;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(33, 1935, 1977);
            return return_v;
        }


        static System.ArgumentException
        f_33_1913_2001(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 1913, 2001);
            return return_v;
        }


        bool
        f_33_2557_2582_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(33, 2557, 2582);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, string>>
        f_33_2637_2707(int
        capacity)
        {
            var return_v = ArrayBuilder<KeyValuePair<string, string>>.GetInstance(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 2637, 2707);
            return return_v;
        }


        static int
        f_33_2825_2835(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(33, 2825, 2835);
            return return_v;
        }


        static string
        f_33_2918_2957()
        {
            var return_v = CodeAnalysisResources.EmptyKeyInPathMap;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(33, 2918, 2957);
            return return_v;
        }


        static System.ArgumentException
        f_33_2896_2975(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 2896, 2975);
            return return_v;
        }


        static string
        f_33_3118_3158()
        {
            var return_v = CodeAnalysisResources.NullValueInPathMap;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(33, 3118, 3158);
            return return_v;
        }


        static System.ArgumentException
        f_33_3096_3176(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 3096, 3176);
            return return_v;
        }


        static string
        f_33_3244_3286(string
        s)
        {
            var return_v = PathUtilities.EnsureTrailingSeparator(s);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 3244, 3286);
            return return_v;
        }


        static string
        f_33_3331_3375(string
        s)
        {
            var return_v = PathUtilities.EnsureTrailingSeparator(s);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 3331, 3375);
            return return_v;
        }


        static System.Collections.Generic.KeyValuePair<string, string>
        f_33_3419_3483(string
        key, string
        value)
        {
            var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 3419, 3483);
            return return_v;
        }


        static int
        f_33_3400_3484(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, string>>
        this_param, System.Collections.Generic.KeyValuePair<string, string>
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 3400, 3484);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
        f_33_2757_2764_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 2757, 2764);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
        f_33_3535_3570(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, string>>
        this_param)
        {
            var return_v = this_param.ToImmutableAndFree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(33, 3535, 3570);
            return return_v;
        }

    }
}
