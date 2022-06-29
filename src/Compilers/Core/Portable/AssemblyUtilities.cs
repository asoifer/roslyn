// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using Microsoft.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal static class AssemblyUtilities
    {
        public static ImmutableArray<string> FindAssemblySet(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(2, 1463, 3301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 1557, 1612);

                f_2_1557_1611(f_2_1576_1610(filePath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 1628, 1673);

                Queue<string>
                workList = f_2_1653_1672()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 1687, 1771);

                HashSet<string>
                assemblySet = f_2_1717_1770(f_2_1737_1769())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 1787, 1814);

                f_2_1787_1813(
                            workList, filePath);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 1830, 3227) || true) && (f_2_1837_1851(workList) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(2, 1830, 3227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 1889, 1930);

                        string
                        assemblyPath = f_2_1911_1929(workList)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 1950, 2054) || true) && (!f_2_1955_1984(assemblySet, assemblyPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(2, 1950, 2054);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 2026, 2035);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(2, 1950, 2054);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 2074, 2126);

                        var
                        directory = f_2_2090_2125(assemblyPath)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 2146, 3212);
                        using (var
                        reader = f_2_2166_2216(f_2_2179_2215(assemblyPath))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 2258, 2306);

                            var
                            metadataReader = f_2_2279_2305(reader)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 2328, 2393);

                            var
                            assemblyReferenceHandles = f_2_2359_2392(metadataReader)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 2417, 3193);
                                foreach (var handle in f_2_2440_2464_I(assemblyReferenceHandles))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(2, 2417, 3193);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 2514, 2574);

                                    var
                                    reference = f_2_2530_2573(metadataReader, handle)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 2600, 2661);

                                    var
                                    referenceName = f_2_2620_2660(metadataReader, reference.Name)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 2854, 2926);

                                    string
                                    referencePath = f_2_2877_2925(directory!, referenceName + ".dll")
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 2954, 3170) || true) && (!f_2_2959_2994(assemblySet, referencePath) && (DynAbs.Tracing.TraceSender.Expression_True(2, 2958, 3053) && f_2_3027_3053(referencePath)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(2, 2954, 3170);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 3111, 3143);

                                        f_2_3111_3142(workList, referencePath);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(2, 2954, 3170);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(2, 2417, 3193);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(2, 1, 777);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(2, 1, 777);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitUsing(2, 2146, 3212);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(2, 1830, 3227);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(2, 1830, 3227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(2, 1830, 3227);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 3243, 3290);

                return f_2_3250_3289(assemblySet);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(2, 1463, 3301);

                bool
                f_2_1576_1610(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 1576, 1610);
                    return return_v;
                }


                int
                f_2_1557_1611(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 1557, 1611);
                    return 0;
                }


                System.Collections.Generic.Queue<string>
                f_2_1653_1672()
                {
                    var return_v = new System.Collections.Generic.Queue<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 1653, 1672);
                    return return_v;
                }


                System.StringComparer
                f_2_1737_1769()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(2, 1737, 1769);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_2_1717_1770(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 1717, 1770);
                    return return_v;
                }


                int
                f_2_1787_1813(System.Collections.Generic.Queue<string>
                this_param, string
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 1787, 1813);
                    return 0;
                }


                int
                f_2_1837_1851(System.Collections.Generic.Queue<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(2, 1837, 1851);
                    return return_v;
                }


                string
                f_2_1911_1929(System.Collections.Generic.Queue<string>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 1911, 1929);
                    return return_v;
                }


                bool
                f_2_1955_1984(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 1955, 1984);
                    return return_v;
                }


                string?
                f_2_2090_2125(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 2090, 2125);
                    return return_v;
                }


                System.IO.Stream
                f_2_2179_2215(string
                fullPath)
                {
                    var return_v = FileUtilities.OpenRead(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 2179, 2215);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_2_2166_2216(System.IO.Stream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 2166, 2216);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_2_2279_2305(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = peReader.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 2279, 2305);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyReferenceHandleCollection
                f_2_2359_2392(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.AssemblyReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(2, 2359, 2392);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyReference
                f_2_2530_2573(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.AssemblyReferenceHandle
                handle)
                {
                    var return_v = this_param.GetAssemblyReference(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 2530, 2573);
                    return return_v;
                }


                string
                f_2_2620_2660(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 2620, 2660);
                    return return_v;
                }


                string
                f_2_2877_2925(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 2877, 2925);
                    return return_v;
                }


                bool
                f_2_2959_2994(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 2959, 2994);
                    return return_v;
                }


                bool
                f_2_3027_3053(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 3027, 3053);
                    return return_v;
                }


                int
                f_2_3111_3142(System.Collections.Generic.Queue<string>
                this_param, string
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 3111, 3142);
                    return 0;
                }


                System.Reflection.Metadata.AssemblyReferenceHandleCollection
                f_2_2440_2464_I(System.Reflection.Metadata.AssemblyReferenceHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 2440, 2464);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_2_3250_3289(System.Collections.Generic.HashSet<string>
                items)
                {
                    var return_v = ImmutableArray.CreateRange((System.Collections.Generic.IEnumerable<string>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 3250, 3289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(2, 1463, 3301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(2, 1463, 3301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Guid ReadMvid(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(2, 3723, 4218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 3792, 3847);

                f_2_3792_3846(f_2_3811_3845(filePath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 3863, 4207);
                using (var
                reader = f_2_3883_3929(f_2_3896_3928(filePath))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 3963, 4011);

                    var
                    metadataReader = f_2_3984_4010(reader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 4029, 4088);

                    var
                    mvidHandle = f_2_4046_4082(metadataReader).Mvid
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 4106, 4156);

                    var
                    fileMvid = f_2_4121_4155(metadataReader, mvidHandle)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 4176, 4192);

                    return fileMvid;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(2, 3863, 4207);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(2, 3723, 4218);

                bool
                f_2_3811_3845(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 3811, 3845);
                    return return_v;
                }


                int
                f_2_3792_3846(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 3792, 3846);
                    return 0;
                }


                System.IO.Stream
                f_2_3896_3928(string
                fullPath)
                {
                    var return_v = FileUtilities.OpenRead(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 3896, 3928);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_2_3883_3929(System.IO.Stream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 3883, 3929);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_2_3984_4010(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = peReader.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 3984, 4010);
                    return return_v;
                }


                System.Reflection.Metadata.ModuleDefinition
                f_2_4046_4082(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.GetModuleDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 4046, 4082);
                    return return_v;
                }


                System.Guid
                f_2_4121_4155(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.GuidHandle
                handle)
                {
                    var return_v = this_param.GetGuid(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 4121, 4155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(2, 3723, 4218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(2, 3723, 4218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<string> FindSatelliteAssemblies(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(2, 4643, 5951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 4745, 4794);

                f_2_4745_4793(f_2_4758_4792(filePath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 4810, 4863);

                var
                builder = f_2_4824_4862()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 4879, 4931);

                string?
                directory = f_2_4899_4930(filePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 4945, 5022);

                string
                fileNameWithoutExtension = f_2_4979_5021(filePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 5036, 5115);

                string
                resourcesNameWithoutExtension = fileNameWithoutExtension + ".resources"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 5129, 5204);

                string
                resourcesNameWithExtension = resourcesNameWithoutExtension + ".dll"
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 5220, 5895);
                    foreach (var subDirectory in f_2_5249_5326_I(f_2_5249_5326(directory, "*", SearchOption.TopDirectoryOnly)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(2, 5220, 5895);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 5360, 5446);

                        string
                        satelliteAssemblyPath = f_2_5391_5445(subDirectory, resourcesNameWithExtension)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 5464, 5598) || true) && (f_2_5468_5502(satelliteAssemblyPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(2, 5464, 5598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 5544, 5579);

                            f_2_5544_5578(builder, satelliteAssemblyPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(2, 5464, 5598);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 5618, 5728);

                        satelliteAssemblyPath = f_2_5642_5727(subDirectory, resourcesNameWithoutExtension, resourcesNameWithExtension);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 5746, 5880) || true) && (f_2_5750_5784(satelliteAssemblyPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(2, 5746, 5880);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 5826, 5861);

                            f_2_5826_5860(builder, satelliteAssemblyPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(2, 5746, 5880);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(2, 5220, 5895);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(2, 1, 676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(2, 1, 676);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 5911, 5940);

                return f_2_5918_5939(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(2, 4643, 5951);

                bool
                f_2_4758_4792(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 4758, 4792);
                    return return_v;
                }


                int
                f_2_4745_4793(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 4745, 4793);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>.Builder
                f_2_4824_4862()
                {
                    var return_v = ImmutableArray.CreateBuilder<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 4824, 4862);
                    return return_v;
                }


                string?
                f_2_4899_4930(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 4899, 4930);
                    return return_v;
                }


                string?
                f_2_4979_5021(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 4979, 5021);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_2_5249_5326(string?
                path, string
                searchPattern, System.IO.SearchOption
                searchOption)
                {
                    var return_v = Directory.EnumerateDirectories(path, searchPattern, searchOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 5249, 5326);
                    return return_v;
                }


                string
                f_2_5391_5445(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 5391, 5445);
                    return return_v;
                }


                bool
                f_2_5468_5502(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 5468, 5502);
                    return return_v;
                }


                int
                f_2_5544_5578(System.Collections.Immutable.ImmutableArray<string>.Builder
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 5544, 5578);
                    return 0;
                }


                string
                f_2_5642_5727(string
                path1, string
                path2, string
                path3)
                {
                    var return_v = Path.Combine(path1, path2, path3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 5642, 5727);
                    return return_v;
                }


                bool
                f_2_5750_5784(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 5750, 5784);
                    return return_v;
                }


                int
                f_2_5826_5860(System.Collections.Immutable.ImmutableArray<string>.Builder
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 5826, 5860);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_2_5249_5326_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 5249, 5326);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_2_5918_5939(System.Collections.Immutable.ImmutableArray<string>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 5918, 5939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(2, 4643, 5951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(2, 4643, 5951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<AssemblyIdentity> IdentifyMissingDependencies(string assemblyPath, IEnumerable<string> dependencyFilePaths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(2, 6416, 7825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 6577, 6636);

                f_2_6577_6635(f_2_6596_6634(assemblyPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 6650, 6698);

                f_2_6650_6697(dependencyFilePaths != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 6714, 6794);

                HashSet<AssemblyIdentity>
                assemblyDefinitions = f_2_6762_6793()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 6808, 7258);
                    foreach (var potentialDependency in f_2_6844_6863_I(dependencyFilePaths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(2, 6808, 7258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 6897, 7243);
                        using (var
                        reader = f_2_6917_6974(f_2_6930_6973(potentialDependency))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 7016, 7064);

                            var
                            metadataReader = f_2_7037_7063(reader)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 7086, 7156);

                            var
                            assemblyDefinition = f_2_7111_7155(metadataReader)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 7180, 7224);

                            f_2_7180_7223(
                                                assemblyDefinitions, assemblyDefinition);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(2, 6897, 7243);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(2, 6808, 7258);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(2, 1, 451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(2, 1, 451);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 7274, 7353);

                HashSet<AssemblyIdentity>
                assemblyReferences = f_2_7321_7352()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 7367, 7677);
                using (var
                reader = f_2_7387_7437(f_2_7400_7436(assemblyPath))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 7471, 7519);

                    var
                    metadataReader = f_2_7492_7518(reader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 7539, 7604);

                    var
                    references = f_2_7556_7603(metadataReader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 7624, 7662);

                    assemblyReferences.AddAll(references);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(2, 7367, 7677);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 7693, 7744);

                f_2_7693_7743(
                            assemblyReferences, assemblyDefinitions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 7760, 7814);

                return f_2_7767_7813(assemblyReferences);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(2, 6416, 7825);

                bool
                f_2_6596_6634(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 6596, 6634);
                    return return_v;
                }


                int
                f_2_6577_6635(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 6577, 6635);
                    return 0;
                }


                int
                f_2_6650_6697(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 6650, 6697);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_2_6762_6793()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.AssemblyIdentity>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 6762, 6793);
                    return return_v;
                }


                System.IO.Stream
                f_2_6930_6973(string
                fullPath)
                {
                    var return_v = FileUtilities.OpenRead(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 6930, 6973);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_2_6917_6974(System.IO.Stream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 6917, 6974);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_2_7037_7063(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = peReader.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 7037, 7063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_2_7111_7155(System.Reflection.Metadata.MetadataReader
                reader)
                {
                    var return_v = reader.ReadAssemblyIdentityOrThrow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 7111, 7155);
                    return return_v;
                }


                bool
                f_2_7180_7223(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 7180, 7223);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_2_6844_6863_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 6844, 6863);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_2_7321_7352()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.AssemblyIdentity>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 7321, 7352);
                    return return_v;
                }


                System.IO.Stream
                f_2_7400_7436(string
                fullPath)
                {
                    var return_v = FileUtilities.OpenRead(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 7400, 7436);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_2_7387_7437(System.IO.Stream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 7387, 7437);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_2_7492_7518(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = peReader.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 7492, 7518);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_2_7556_7603(System.Reflection.Metadata.MetadataReader
                reader)
                {
                    var return_v = reader.GetReferencedAssembliesOrThrow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 7556, 7603);
                    return return_v;
                }


                int
                f_2_7693_7743(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.AssemblyIdentity>
                other)
                {
                    this_param.ExceptWith((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AssemblyIdentity>)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 7693, 7743);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_2_7767_7813(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.AssemblyIdentity>
                items)
                {
                    var return_v = ImmutableArray.CreateRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AssemblyIdentity>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 7767, 7813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(2, 6416, 7825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(2, 6416, 7825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AssemblyIdentity GetAssemblyIdentity(string assemblyPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(2, 8275, 8748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 8371, 8424);

                f_2_8371_8423(f_2_8384_8422(assemblyPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 8440, 8737);
                using (var
                reader = f_2_8460_8510(f_2_8473_8509(assemblyPath))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 8544, 8592);

                    var
                    metadataReader = f_2_8565_8591(reader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 8610, 8678);

                    var
                    assemblyIdentity = f_2_8633_8677(metadataReader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(2, 8698, 8722);

                    return assemblyIdentity;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(2, 8440, 8737);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(2, 8275, 8748);

                bool
                f_2_8384_8422(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 8384, 8422);
                    return return_v;
                }


                int
                f_2_8371_8423(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 8371, 8423);
                    return 0;
                }


                System.IO.Stream
                f_2_8473_8509(string
                fullPath)
                {
                    var return_v = FileUtilities.OpenRead(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 8473, 8509);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_2_8460_8510(System.IO.Stream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 8460, 8510);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_2_8565_8591(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = peReader.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 8565, 8591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_2_8633_8677(System.Reflection.Metadata.MetadataReader
                reader)
                {
                    var return_v = reader.ReadAssemblyIdentityOrThrow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(2, 8633, 8677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(2, 8275, 8748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(2, 8275, 8748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AssemblyUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(2, 488, 8755);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(2, 488, 8755);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(2, 488, 8755);
        }

    }
}
