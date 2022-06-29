// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal abstract class AnalyzerAssemblyLoader : IAnalyzerAssemblyLoader
    {
        private readonly object _guard;

        private readonly Dictionary<string, Assembly> _loadedAssembliesByPath;

        private readonly Dictionary<string, AssemblyIdentity> _loadedAssemblyIdentitiesByPath;

        private readonly Dictionary<AssemblyIdentity, Assembly> _loadedAssembliesByIdentity;

        private readonly Dictionary<string, HashSet<string>> _knownAssemblyPathsBySimpleName;

        protected abstract Assembly LoadFromPathImpl(string fullPath);

        public void AddDependencyLocation(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(218, 1223, 1856);
                System.Collections.Generic.HashSet<string> paths = default(System.Collections.Generic.HashSet<string>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 1298, 1368);

                f_218_1298_1367(fullPath, nameof(fullPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 1382, 1463);

                string
                simpleName = f_218_1402_1462(fullPath, includeExtension: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 1485, 1491);

                lock (_guard)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 1525, 1790) || true) && (!f_218_1530_1600(_knownAssemblyPathsBySimpleName, simpleName, out paths))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 1525, 1790);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 1642, 1694);

                        paths = f_218_1650_1693(PathUtilities.Comparer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 1716, 1771);

                        f_218_1716_1770(_knownAssemblyPathsBySimpleName, simpleName, paths);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(218, 1525, 1790);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 1810, 1830);

                    f_218_1810_1829(
                                    paths, fullPath);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(218, 1223, 1856);

                int
                f_218_1298_1367(string
                path, string
                argumentName)
                {
                    CompilerPathUtilities.RequireAbsolutePath(path, argumentName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 1298, 1367);
                    return 0;
                }


                string?
                f_218_1402_1462(string
                path, bool
                includeExtension)
                {
                    var return_v = PathUtilities.GetFileName(path, includeExtension: includeExtension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 1402, 1462);
                    return return_v;
                }


                bool
                f_218_1530_1600(System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<string>>
                this_param, string
                key, out System.Collections.Generic.HashSet<string>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 1530, 1600);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_218_1650_1693(System.Collections.Generic.IEqualityComparer<string>
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 1650, 1693);
                    return return_v;
                }


                int
                f_218_1716_1770(System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<string>>
                this_param, string
                key, System.Collections.Generic.HashSet<string>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 1716, 1770);
                    return 0;
                }


                bool
                f_218_1810_1829(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 1810, 1829);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(218, 1223, 1856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(218, 1223, 1856);
            }
        }

        public Assembly LoadFromPath(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(218, 1868, 2072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 1938, 2008);

                f_218_1938_2007(fullPath, nameof(fullPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 2022, 2061);

                return f_218_2029_2060(this, fullPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(218, 1868, 2072);

                int
                f_218_1938_2007(string
                path, string
                argumentName)
                {
                    CompilerPathUtilities.RequireAbsolutePath(path, argumentName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 1938, 2007);
                    return 0;
                }


                System.Reflection.Assembly
                f_218_2029_2060(Microsoft.CodeAnalysis.AnalyzerAssemblyLoader
                this_param, string
                fullPath)
                {
                    var return_v = this_param.LoadFromPathUnchecked(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 2029, 2060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(218, 1868, 2072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(218, 1868, 2072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Assembly LoadFromPathUnchecked(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(218, 2106, 2240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 2186, 2229);

                return f_218_2193_2228(this, fullPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(218, 2106, 2240);

                System.Reflection.Assembly
                f_218_2193_2228(Microsoft.CodeAnalysis.AnalyzerAssemblyLoader
                this_param, string
                fullPath)
                {
                    var return_v = this_param.LoadFromPathUncheckedCore(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 2193, 2228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(218, 2106, 2240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(218, 2106, 2240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Assembly LoadFromPathUncheckedCore(string fullPath, AssemblyIdentity identity = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(218, 2252, 3507);
                System.Reflection.Assembly existingAssembly = default(System.Reflection.Assembly);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 2370, 2419);

                f_218_2370_2418(f_218_2383_2417(fullPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 2542, 2573);

                Assembly
                loadedAssembly = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 2593, 2599);
                lock (_guard)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 2633, 3157) || true) && (f_218_2637_2708(_loadedAssembliesByPath, fullPath, out existingAssembly))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 2633, 3157);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 2750, 2784);

                        loadedAssembly = existingAssembly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(218, 2633, 3157);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 2633, 3157);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 2866, 2914);

                        identity ??= f_218_2879_2913(this, fullPath);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 2936, 3138) || true) && (identity != null && (DynAbs.Tracing.TraceSender.Expression_True(218, 2940, 3031) && f_218_2960_3031(_loadedAssembliesByIdentity, identity, out existingAssembly)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 2936, 3138);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 3081, 3115);

                            loadedAssembly = existingAssembly;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(218, 2936, 3138);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(218, 2633, 3157);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 3234, 3353) || true) && (loadedAssembly == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 3234, 3353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 3294, 3338);

                    loadedAssembly = f_218_3311_3337(this, fullPath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(218, 3234, 3353);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 3442, 3496);

                return f_218_3449_3495(this, loadedAssembly, fullPath, identity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(218, 2252, 3507);

                bool
                f_218_2383_2417(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 2383, 2417);
                    return return_v;
                }


                int
                f_218_2370_2418(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 2370, 2418);
                    return 0;
                }


                bool
                f_218_2637_2708(System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                this_param, string
                key, out System.Reflection.Assembly
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 2637, 2708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_218_2879_2913(Microsoft.CodeAnalysis.AnalyzerAssemblyLoader
                this_param, string
                fullPath)
                {
                    var return_v = this_param.GetOrAddAssemblyIdentity(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 2879, 2913);
                    return return_v;
                }


                bool
                f_218_2960_3031(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, System.Reflection.Assembly>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                key, out System.Reflection.Assembly?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 2960, 3031);
                    return return_v;
                }


                System.Reflection.Assembly
                f_218_3311_3337(Microsoft.CodeAnalysis.AnalyzerAssemblyLoader
                this_param, string
                fullPath)
                {
                    var return_v = this_param.LoadFromPathImpl(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 3311, 3337);
                    return return_v;
                }


                System.Reflection.Assembly
                f_218_3449_3495(Microsoft.CodeAnalysis.AnalyzerAssemblyLoader
                this_param, System.Reflection.Assembly
                assembly, string
                fullPath, Microsoft.CodeAnalysis.AssemblyIdentity?
                identity)
                {
                    var return_v = this_param.AddToCache(assembly, fullPath, identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 3449, 3495);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(218, 2252, 3507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(218, 2252, 3507);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Assembly AddToCache(Assembly assembly, string fullPath, AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(218, 3519, 4718);
                System.Reflection.Assembly existingAssembly = default(System.Reflection.Assembly);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 3634, 3683);

                f_218_3634_3682(f_218_3647_3681(fullPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 3697, 3728);

                f_218_3697_3727(assembly != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 3744, 3839);

                identity = f_218_3755_3838(this, fullPath, identity ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.AssemblyIdentity>(218, 3776, 3837) ?? f_218_3788_3837(assembly)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 3853, 3884);

                f_218_3853_3883(identity != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 3906, 3912);

                lock (_guard)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 4156, 4458) || true) && (f_218_4160_4235(_loadedAssembliesByIdentity, identity, out existingAssembly))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 4156, 4458);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 4277, 4305);

                        assembly = existingAssembly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(218, 4156, 4458);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 4156, 4458);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 4387, 4439);

                        f_218_4387_4438(_loadedAssembliesByIdentity, identity, assembly);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(218, 4156, 4458);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 4611, 4656);

                    _loadedAssembliesByPath[fullPath] = assembly;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 4676, 4692);

                    return assembly;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(218, 3519, 4718);

                bool
                f_218_3647_3681(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 3647, 3681);
                    return return_v;
                }


                int
                f_218_3634_3682(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 3634, 3682);
                    return 0;
                }


                int
                f_218_3697_3727(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 3697, 3727);
                    return 0;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_218_3788_3837(System.Reflection.Assembly
                assembly)
                {
                    var return_v = AssemblyIdentity.FromAssemblyDefinition(assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 3788, 3837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_218_3755_3838(Microsoft.CodeAnalysis.AnalyzerAssemblyLoader
                this_param, string
                fullPath, Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = this_param.AddToCache(fullPath, identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 3755, 3838);
                    return return_v;
                }


                int
                f_218_3853_3883(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 3853, 3883);
                    return 0;
                }


                bool
                f_218_4160_4235(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, System.Reflection.Assembly>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                key, out System.Reflection.Assembly
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 4160, 4235);
                    return return_v;
                }


                int
                f_218_4387_4438(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, System.Reflection.Assembly>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                key, System.Reflection.Assembly
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 4387, 4438);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(218, 3519, 4718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(218, 3519, 4718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AssemblyIdentity GetOrAddAssemblyIdentity(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(218, 4730, 5264);
                Microsoft.CodeAnalysis.AssemblyIdentity existingIdentity = default(Microsoft.CodeAnalysis.AssemblyIdentity);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 4821, 4870);

                f_218_4821_4869(f_218_4834_4868(fullPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 4892, 4898);

                lock (_guard)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 4932, 5100) || true) && (f_218_4936_5015(_loadedAssemblyIdentitiesByPath, fullPath, out existingIdentity))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 4932, 5100);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 5057, 5081);

                        return existingIdentity;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(218, 4932, 5100);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 5131, 5201);

                var
                identity = f_218_5146_5200(fullPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 5215, 5253);

                return f_218_5222_5252(this, fullPath, identity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(218, 4730, 5264);

                bool
                f_218_4834_4868(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 4834, 4868);
                    return return_v;
                }


                int
                f_218_4821_4869(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 4821, 4869);
                    return 0;
                }


                bool
                f_218_4936_5015(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param, string
                key, out Microsoft.CodeAnalysis.AssemblyIdentity
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 4936, 5015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity?
                f_218_5146_5200(string
                filePath)
                {
                    var return_v = AssemblyIdentityUtils.TryGetAssemblyIdentity(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 5146, 5200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_218_5222_5252(Microsoft.CodeAnalysis.AnalyzerAssemblyLoader
                this_param, string
                fullPath, Microsoft.CodeAnalysis.AssemblyIdentity?
                identity)
                {
                    var return_v = this_param.AddToCache(fullPath, identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 5222, 5252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(218, 4730, 5264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(218, 4730, 5264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AssemblyIdentity AddToCache(string fullPath, AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(218, 5276, 5819);
                Microsoft.CodeAnalysis.AssemblyIdentity existingIdentity = default(Microsoft.CodeAnalysis.AssemblyIdentity);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 5386, 5392);
                lock (_guard)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 5426, 5761) || true) && (f_218_5430_5509(_loadedAssemblyIdentitiesByPath, fullPath, out existingIdentity) && (DynAbs.Tracing.TraceSender.Expression_True(218, 5430, 5537) && existingIdentity != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 5426, 5761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 5579, 5607);

                        identity = existingIdentity;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(218, 5426, 5761);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 5426, 5761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 5689, 5742);

                        _loadedAssemblyIdentitiesByPath[fullPath] = identity;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(218, 5426, 5761);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 5792, 5808);

                return identity;
                DynAbs.Tracing.TraceSender.TraceExitMethod(218, 5276, 5819);

                bool
                f_218_5430_5509(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param, string
                key, out Microsoft.CodeAnalysis.AssemblyIdentity
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 5430, 5509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(218, 5276, 5819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(218, 5276, 5819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Assembly Load(string displayName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(218, 5831, 7431);
                Microsoft.CodeAnalysis.AssemblyIdentity? requestedIdentity = default(Microsoft.CodeAnalysis.AssemblyIdentity?);
                System.Reflection.Assembly existingAssembly = default(System.Reflection.Assembly);
                System.Collections.Generic.HashSet<string> pathList = default(System.Collections.Generic.HashSet<string>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 5896, 6038) || true) && (!f_218_5901_5977(displayName, out requestedIdentity))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 5896, 6038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 6011, 6023);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(218, 5896, 6038);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 6054, 6092);

                ImmutableArray<string>
                candidatePaths
                = default(ImmutableArray<string>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 6112, 6118);
                lock (_guard)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 6241, 6414) || true) && (f_218_6245_6329(_loadedAssembliesByIdentity, requestedIdentity, out existingAssembly))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 6241, 6414);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 6371, 6395);

                        return existingAssembly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(218, 6241, 6414);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 6542, 6705) || true) && (!f_218_6547_6632(_knownAssemblyPathsBySimpleName, f_218_6591_6613(requestedIdentity), out pathList))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 6542, 6705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 6674, 6686);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(218, 6542, 6705);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 6725, 6758);

                    f_218_6725_6757(f_218_6738_6752(pathList) > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 6776, 6821);

                    candidatePaths = f_218_6793_6820(pathList);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 7040, 7392);
                    foreach (var candidatePath in f_218_7070_7084_I(candidatePaths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 7040, 7392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 7118, 7182);

                        var
                        candidateIdentity = f_218_7142_7181(this, candidatePath)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 7202, 7377) || true) && (f_218_7206_7249(requestedIdentity, candidateIdentity))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(218, 7202, 7377);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 7291, 7358);

                            return f_218_7298_7357(this, candidatePath, candidateIdentity);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(218, 7202, 7377);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(218, 7040, 7392);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(218, 1, 353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(218, 1, 353);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 7408, 7420);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(218, 5831, 7431);

                bool
                f_218_5901_5977(string
                displayName, out Microsoft.CodeAnalysis.AssemblyIdentity?
                identity)
                {
                    var return_v = AssemblyIdentity.TryParseDisplayName(displayName, out identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 5901, 5977);
                    return return_v;
                }


                bool
                f_218_6245_6329(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AssemblyIdentity, System.Reflection.Assembly>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                key, out System.Reflection.Assembly
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 6245, 6329);
                    return return_v;
                }


                string
                f_218_6591_6613(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(218, 6591, 6613);
                    return return_v;
                }


                bool
                f_218_6547_6632(System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<string>>
                this_param, string
                key, out System.Collections.Generic.HashSet<string>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 6547, 6632);
                    return return_v;
                }


                int
                f_218_6738_6752(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(218, 6738, 6752);
                    return return_v;
                }


                int
                f_218_6725_6757(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 6725, 6757);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_218_6793_6820(System.Collections.Generic.HashSet<string>
                items)
                {
                    var return_v = items.ToImmutableArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 6793, 6820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_218_7142_7181(Microsoft.CodeAnalysis.AnalyzerAssemblyLoader
                this_param, string
                fullPath)
                {
                    var return_v = this_param.GetOrAddAssemblyIdentity(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 7142, 7181);
                    return return_v;
                }


                bool
                f_218_7206_7249(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 7206, 7249);
                    return return_v;
                }


                System.Reflection.Assembly
                f_218_7298_7357(Microsoft.CodeAnalysis.AnalyzerAssemblyLoader
                this_param, string
                fullPath, Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = this_param.LoadFromPathUncheckedCore(fullPath, identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 7298, 7357);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_218_7070_7084_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(218, 7070, 7084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(218, 5831, 7431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(218, 5831, 7431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public AnalyzerAssemblyLoader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(218, 437, 7438);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 550, 564);
            this._guard = new(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 661, 692);
            this._loadedAssembliesByPath = new(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 757, 796);
            this._loadedAssemblyIdentitiesByPath = new(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 863, 898);
            this._loadedAssembliesByIdentity = new(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(218, 1035, 1106);
            this._knownAssemblyPathsBySimpleName = new(f_218_1073_1105()); DynAbs.Tracing.TraceSender.TraceExitConstructor(218, 437, 7438);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(218, 437, 7438);
        }


        static AnalyzerAssemblyLoader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(218, 437, 7438);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(218, 437, 7438);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(218, 437, 7438);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(218, 437, 7438);

        System.StringComparer
        f_218_1073_1105()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(218, 1073, 1105);
            return return_v;
        }

    }
}
