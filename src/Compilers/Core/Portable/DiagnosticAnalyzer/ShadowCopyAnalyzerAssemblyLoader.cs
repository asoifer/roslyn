// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

#if NETCOREAPP

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.CodeAnalysis
{
    internal sealed class ShadowCopyAnalyzerAssemblyLoader : DefaultAnalyzerAssemblyLoader
    {
        private readonly string _baseDirectory;

        internal readonly Task DeleteLeftoverDirectoriesTask;

        private readonly Lazy<(string directory, Mutex)> _shadowCopyDirectoryAndMutex;

        private int _assemblyDirectoryId;

        public ShadowCopyAnalyzerAssemblyLoader(string baseDirectory = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(266, 1525, 2170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 855, 869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 905, 934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 1250, 1278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 1492, 1512);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 1618, 1879) || true) && (baseDirectory != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(266, 1618, 1879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 1677, 1708);

                    _baseDirectory = baseDirectory;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(266, 1618, 1879);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(266, 1618, 1879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 1774, 1864);

                    _baseDirectory = f_266_1791_1863(f_266_1804_1822(), "CodeAnalysis", "AnalyzerShadowCopies");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(266, 1618, 1879);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 1895, 2067);

                _shadowCopyDirectoryAndMutex = f_266_1926_2066(() => CreateUniqueDirectoryForProcess(), LazyThreadSafetyMode.ExecutionAndPublication);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 2083, 2159);

                DeleteLeftoverDirectoriesTask = f_266_2115_2158(DeleteLeftoverDirectories);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(266, 1525, 2170);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(266, 1525, 2170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(266, 1525, 2170);
            }
        }

        private void DeleteLeftoverDirectories()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(266, 2182, 3752);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 2292, 2355) || true) && (!f_266_2297_2329(_baseDirectory))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(266, 2292, 2355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 2348, 2355);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(266, 2292, 2355);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 2371, 2406);

                IEnumerable<string>
                subDirectories
                = default(IEnumerable<string>);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 2456, 2520);

                    subDirectories = f_266_2473_2519(_baseDirectory);
                }
                catch (DirectoryNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(266, 2549, 2638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 2616, 2623);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(266, 2549, 2638);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 2654, 3741);
                    foreach (var subDirectory in f_266_2683_2697_I(subDirectories))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(266, 2654, 3741);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 2731, 2795);

                        string
                        name = f_266_2745_2794(f_266_2745_2775(subDirectory))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 2813, 2832);

                        Mutex
                        mutex = null
                        ;
                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 3068, 3297) || true) && (!f_266_3073_3111(name, out mutex))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(266, 3068, 3297);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 3161, 3200);

                                f_266_3161_3199(subDirectory);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 3226, 3274);

                                f_266_3226_3273(subDirectory, recursive: true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(266, 3068, 3297);
                            }
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(266, 3334, 3535);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(266, 3334, 3535);
                            // If something goes wrong we will leave it to the next run to clean up.
                            // Just swallow the exception and move on.
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(266, 3553, 3726);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 3601, 3707) || true) && (mutex != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(266, 3601, 3707);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 3668, 3684);

                                f_266_3668_3683(mutex);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(266, 3601, 3707);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(266, 3553, 3726);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(266, 2654, 3741);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(266, 1, 1088);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(266, 1, 1088);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(266, 2182, 3752);

                bool
                f_266_2297_2329(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 2297, 2329);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_266_2473_2519(string
                path)
                {
                    var return_v = Directory.EnumerateDirectories(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 2473, 2519);
                    return return_v;
                }


                string?
                f_266_2745_2775(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 2745, 2775);
                    return return_v;
                }


                string
                f_266_2745_2794(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 2745, 2794);
                    return return_v;
                }


                bool
                f_266_3073_3111(string
                name, out System.Threading.Mutex
                result)
                {
                    var return_v = Mutex.TryOpenExisting(name, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 3073, 3111);
                    return return_v;
                }


                int
                f_266_3161_3199(string
                directoryPath)
                {
                    ClearReadOnlyFlagOnFiles(directoryPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 3161, 3199);
                    return 0;
                }


                int
                f_266_3226_3273(string
                path, bool
                recursive)
                {
                    Directory.Delete(path, recursive: recursive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 3226, 3273);
                    return 0;
                }


                int
                f_266_3668_3683(System.Threading.Mutex
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 3668, 3683);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_266_2683_2697_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 2683, 2697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(266, 2182, 3752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(266, 2182, 3752);
            }
        }

        protected override Assembly LoadImpl(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(266, 3764, 4056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 3842, 3904);

                string
                assemblyDirectory = f_266_3869_3903(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 3918, 3992);

                string
                shadowCopyPath = f_266_3942_3991(fullPath, assemblyDirectory)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 4008, 4045);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.LoadImpl(shadowCopyPath), 266, 4015, 4044);
                DynAbs.Tracing.TraceSender.TraceExitMethod(266, 3764, 4056);

                string
                f_266_3869_3903(Microsoft.CodeAnalysis.ShadowCopyAnalyzerAssemblyLoader
                this_param)
                {
                    var return_v = this_param.CreateUniqueDirectoryForAssembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 3869, 3903);
                    return return_v;
                }


                string
                f_266_3942_3991(string
                fullPath, string
                assemblyDirectory)
                {
                    var return_v = CopyFileAndResources(fullPath, assemblyDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 3942, 3991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(266, 3764, 4056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(266, 3764, 4056);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string CopyFileAndResources(string fullPath, string assemblyDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(266, 4068, 5802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 4178, 4236);

                string
                fileNameWithExtension = f_266_4209_4235(fullPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 4250, 4329);

                string
                shadowCopyPath = f_266_4274_4328(assemblyDirectory, fileNameWithExtension)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 4345, 4380);

                f_266_4345_4379(fullPath, shadowCopyPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 4396, 4455);

                string
                originalDirectory = f_266_4423_4454(fullPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 4469, 4559);

                string
                fileNameWithoutExtension = f_266_4503_4558(fileNameWithExtension)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 4573, 4652);

                string
                resourcesNameWithoutExtension = fileNameWithoutExtension + ".resources"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 4666, 4741);

                string
                resourcesNameWithExtension = resourcesNameWithoutExtension + ".dll"
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 4757, 5753);
                    foreach (var directory in f_266_4783_4832_I(f_266_4783_4832(originalDirectory)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(266, 4757, 5753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 4866, 4917);

                        string
                        directoryName = f_266_4889_4916(directory)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 4937, 5012);

                        string
                        resourcesPath = f_266_4960_5011(directory, resourcesNameWithExtension)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 5030, 5300) || true) && (f_266_5034_5060(resourcesPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(266, 5030, 5300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 5102, 5210);

                            string
                            resourcesShadowCopyPath = f_266_5135_5209(assemblyDirectory, directoryName, resourcesNameWithExtension)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 5232, 5281);

                            f_266_5232_5280(resourcesPath, resourcesShadowCopyPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(266, 5030, 5300);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 5320, 5419);

                        resourcesPath = f_266_5336_5418(directory, resourcesNameWithoutExtension, resourcesNameWithExtension);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 5437, 5738) || true) && (f_266_5441_5467(resourcesPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(266, 5437, 5738);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 5509, 5648);

                            string
                            resourcesShadowCopyPath = f_266_5542_5647(assemblyDirectory, directoryName, resourcesNameWithoutExtension, resourcesNameWithExtension)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 5670, 5719);

                            f_266_5670_5718(resourcesPath, resourcesShadowCopyPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(266, 5437, 5738);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(266, 4757, 5753);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(266, 1, 997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(266, 1, 997);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 5769, 5791);

                return shadowCopyPath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(266, 4068, 5802);

                string?
                f_266_4209_4235(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 4209, 4235);
                    return return_v;
                }


                string
                f_266_4274_4328(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 4274, 4328);
                    return return_v;
                }


                int
                f_266_4345_4379(string
                originalPath, string
                shadowCopyPath)
                {
                    CopyFile(originalPath, shadowCopyPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 4345, 4379);
                    return 0;
                }


                string?
                f_266_4423_4454(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 4423, 4454);
                    return return_v;
                }


                string?
                f_266_4503_4558(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 4503, 4558);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_266_4783_4832(string?
                path)
                {
                    var return_v = Directory.EnumerateDirectories(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 4783, 4832);
                    return return_v;
                }


                string?
                f_266_4889_4916(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 4889, 4916);
                    return return_v;
                }


                string
                f_266_4960_5011(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 4960, 5011);
                    return return_v;
                }


                bool
                f_266_5034_5060(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 5034, 5060);
                    return return_v;
                }


                string
                f_266_5135_5209(string
                path1, string
                path2, string
                path3)
                {
                    var return_v = Path.Combine(path1, path2, path3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 5135, 5209);
                    return return_v;
                }


                int
                f_266_5232_5280(string
                originalPath, string
                shadowCopyPath)
                {
                    CopyFile(originalPath, shadowCopyPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 5232, 5280);
                    return 0;
                }


                string
                f_266_5336_5418(string
                path1, string
                path2, string
                path3)
                {
                    var return_v = Path.Combine(path1, path2, path3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 5336, 5418);
                    return return_v;
                }


                bool
                f_266_5441_5467(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 5441, 5467);
                    return return_v;
                }


                string
                f_266_5542_5647(string
                path1, string
                path2, string
                path3, string
                path4)
                {
                    var return_v = Path.Combine(path1, path2, path3, path4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 5542, 5647);
                    return return_v;
                }


                int
                f_266_5670_5718(string
                originalPath, string
                shadowCopyPath)
                {
                    CopyFile(originalPath, shadowCopyPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 5670, 5718);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_266_4783_4832_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 4783, 4832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(266, 4068, 5802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(266, 4068, 5802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CopyFile(string originalPath, string shadowCopyPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(266, 5814, 6153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 5911, 5965);

                var
                directory = f_266_5927_5964(shadowCopyPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 5979, 6016);

                f_266_5979_6015(directory);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 6032, 6072);

                f_266_6032_6071(originalPath, shadowCopyPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 6088, 6142);

                f_266_6088_6141(f_266_6112_6140(shadowCopyPath));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(266, 5814, 6153);

                string?
                f_266_5927_5964(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 5927, 5964);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_266_5979_6015(string?
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 5979, 6015);
                    return return_v;
                }


                int
                f_266_6032_6071(string
                sourceFileName, string
                destFileName)
                {
                    File.Copy(sourceFileName, destFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 6032, 6071);
                    return 0;
                }


                System.IO.FileInfo
                f_266_6112_6140(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 6112, 6140);
                    return return_v;
                }


                int
                f_266_6088_6141(System.IO.FileInfo
                fileInfo)
                {
                    ClearReadOnlyFlagOnFile(fileInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 6088, 6141);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(266, 5814, 6153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(266, 5814, 6153);
            }
        }

        private static void ClearReadOnlyFlagOnFiles(string directoryPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(266, 6165, 6529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 6256, 6315);

                DirectoryInfo
                directory = f_266_6282_6314(directoryPath)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 6331, 6518);
                    foreach (var file in f_266_6352_6439_I(f_266_6352_6439(directory, searchPattern: "*", searchOption: SearchOption.AllDirectories)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(266, 6331, 6518);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 6473, 6503);

                        f_266_6473_6502(file);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(266, 6331, 6518);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(266, 1, 188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(266, 1, 188);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(266, 6165, 6529);

                System.IO.DirectoryInfo
                f_266_6282_6314(string
                path)
                {
                    var return_v = new System.IO.DirectoryInfo(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 6282, 6314);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.IO.FileInfo>
                f_266_6352_6439(System.IO.DirectoryInfo
                this_param, string
                searchPattern, System.IO.SearchOption
                searchOption)
                {
                    var return_v = this_param.EnumerateFiles(searchPattern: searchPattern, searchOption: searchOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 6352, 6439);
                    return return_v;
                }


                int
                f_266_6473_6502(System.IO.FileInfo
                fileInfo)
                {
                    ClearReadOnlyFlagOnFile(fileInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 6473, 6502);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.IO.FileInfo>
                f_266_6352_6439_I(System.Collections.Generic.IEnumerable<System.IO.FileInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 6352, 6439);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(266, 6165, 6529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(266, 6165, 6529);
            }
        }

        private static void ClearReadOnlyFlagOnFile(FileInfo fileInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(266, 6541, 6937);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 6664, 6776) || true) && (f_266_6668_6687(fileInfo))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(266, 6664, 6776);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 6729, 6757);

                        fileInfo.IsReadOnly = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(266, 6664, 6776);
                    }
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(266, 6805, 6926);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(266, 6805, 6926);
                    // There are many reasons this could fail. Ignore it and keep going.
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(266, 6541, 6937);

                bool
                f_266_6668_6687(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(266, 6668, 6687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(266, 6541, 6937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(266, 6541, 6937);
            }
        }

        private string CreateUniqueDirectoryForAssembly()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(266, 6949, 7302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 7023, 7089);

                int
                directoryId = f_266_7041_7088(ref _assemblyDirectoryId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 7105, 7207);

                string
                directory = f_266_7124_7206(_shadowCopyDirectoryAndMutex.Value.directory, f_266_7183_7205(directoryId))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 7223, 7260);

                f_266_7223_7259(directory);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 7274, 7291);

                return directory;
                DynAbs.Tracing.TraceSender.TraceExitMethod(266, 6949, 7302);

                int
                f_266_7041_7088(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 7041, 7088);
                    return return_v;
                }


                string
                f_266_7183_7205(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 7183, 7205);
                    return return_v;
                }


                string
                f_266_7124_7206(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 7124, 7206);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_266_7223_7259(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 7223, 7259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(266, 6949, 7302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(266, 6949, 7302);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private (string directory, Mutex mutex) CreateUniqueDirectoryForProcess()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(266, 7314, 7721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 7412, 7474);

                string
                guid = f_266_7426_7473(Guid.NewGuid().ToString("N"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 7488, 7542);

                string
                directory = f_266_7507_7541(_baseDirectory, guid)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 7558, 7615);

                var
                mutex = f_266_7570_7614(initiallyOwned: false, name: guid)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 7631, 7668);

                f_266_7631_7667(directory);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(266, 7684, 7710);

                return (directory, mutex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(266, 7314, 7721);

                string
                f_266_7426_7473(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 7426, 7473);
                    return return_v;
                }


                string
                f_266_7507_7541(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 7507, 7541);
                    return return_v;
                }


                System.Threading.Mutex
                f_266_7570_7614(bool
                initiallyOwned, string
                name)
                {
                    var return_v = new System.Threading.Mutex(initiallyOwned: initiallyOwned, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 7570, 7614);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_266_7631_7667(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 7631, 7667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(266, 7314, 7721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(266, 7314, 7721);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ShadowCopyAnalyzerAssemblyLoader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(266, 422, 7728);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(266, 422, 7728);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(266, 422, 7728);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(266, 422, 7728);

        static string
        f_266_1804_1822()
        {
            var return_v = Path.GetTempPath();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 1804, 1822);
            return return_v;
        }


        static string
        f_266_1791_1863(string
        path1, string
        path2, string
        path3)
        {
            var return_v = Path.Combine(path1, path2, path3);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 1791, 1863);
            return return_v;
        }


        static System.Lazy<(string directory, System.Threading.Mutex)>
        f_266_1926_2066(System.Func<(string directory, System.Threading.Mutex)>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<(string directory, System.Threading.Mutex)>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 1926, 2066);
            return return_v;
        }


        static System.Threading.Tasks.Task
        f_266_2115_2158(System.Action
        action)
        {
            var return_v = Task.Run(action);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(266, 2115, 2158);
            return return_v;
        }

    }
}

#endif
