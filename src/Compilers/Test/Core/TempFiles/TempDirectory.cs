// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.IO;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public class TempDirectory
    {
        private readonly string _path;

        private readonly TempRoot _root;

        protected TempDirectory(TempRoot root)
        : this(f_25028_533_569_C(f_25028_533_569(TempRoot.Root)), root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25028, 474, 598);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25028, 474, 598);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25028, 474, 598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25028, 474, 598);
            }
        }

        private TempDirectory(string path, TempRoot root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25028, 610, 819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 414, 419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 456, 461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 684, 711);

                f_25028_684_710(path != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 725, 752);

                f_25028_725_751(root != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 768, 781);

                _path = path;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 795, 808);

                _root = root;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25028, 610, 819);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25028, 610, 819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25028, 610, 819);
            }
        }

        private static string CreateUniqueDirectory(string basePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25028, 831, 1310);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 916, 1299) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25028, 916, 1299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 961, 1034);

                        string
                        dir = f_25028_974_1033(basePath, Guid.NewGuid().ToString())
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 1096, 1127);

                            f_25028_1096_1126(dir);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 1149, 1160);

                            return dir;
                        }
                        catch (IOException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(25028, 1197, 1284);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(25028, 1197, 1284);
                            // retry
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25028, 916, 1299);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25028, 916, 1299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25028, 916, 1299);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25028, 831, 1310);

                string
                f_25028_974_1033(string
                path1, string
                path2)
                {
                    var return_v = System.IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 974, 1033);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_25028_1096_1126(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 1096, 1126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25028, 831, 1310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25028, 831, 1310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string Path
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25028, 1365, 1386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 1371, 1384);

                    return _path;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25028, 1365, 1386);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25028, 1322, 1397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25028, 1322, 1397);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TempFile CreateFile(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25028, 1554, 1814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 1618, 1672);

                string
                filePath = f_25028_1636_1671(_path, name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 1686, 1738);

                f_25028_1686_1737(filePath, FileMode.CreateNew);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 1752, 1803);

                return f_25028_1759_1802(_root, f_25028_1773_1801(filePath));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25028, 1554, 1814);

                string
                f_25028_1636_1671(string
                path1, string
                path2)
                {
                    var return_v = System.IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 1636, 1671);
                    return return_v;
                }


                int
                f_25028_1686_1737(string
                fullPath, System.IO.FileMode
                mode)
                {
                    TempRoot.CreateStream(fullPath, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 1686, 1737);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                f_25028_1773_1801(string
                path)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DisposableFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 1773, 1801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                f_25028_1759_1802(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
                this_param, Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                file)
                {
                    var return_v = this_param.AddFile(file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 1759, 1802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25028, 1554, 1814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25028, 1554, 1814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TempFile CreateOrOpenFile(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25028, 1946, 2215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 2016, 2070);

                string
                filePath = f_25028_2034_2069(_path, name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 2084, 2139);

                f_25028_2084_2138(filePath, FileMode.OpenOrCreate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 2153, 2204);

                return f_25028_2160_2203(_root, f_25028_2174_2202(filePath));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25028, 1946, 2215);

                string
                f_25028_2034_2069(string
                path1, string
                path2)
                {
                    var return_v = System.IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 2034, 2069);
                    return return_v;
                }


                int
                f_25028_2084_2138(string
                fullPath, System.IO.FileMode
                mode)
                {
                    TempRoot.CreateStream(fullPath, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 2084, 2138);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                f_25028_2174_2202(string
                path)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DisposableFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 2174, 2202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                f_25028_2160_2203(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
                this_param, Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                file)
                {
                    var return_v = this_param.AddFile(file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 2160, 2203);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25028, 1946, 2215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25028, 1946, 2215);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TempFile CopyFile(string originalPath, string name = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25028, 2358, 2670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 2448, 2546);

                string
                filePath = f_25028_2466_2545(_path, name ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(25028, 2496, 2544) ?? f_25028_2504_2544(originalPath)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 2560, 2594);

                f_25028_2560_2593(originalPath, filePath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 2608, 2659);

                return f_25028_2615_2658(_root, f_25028_2629_2657(filePath));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25028, 2358, 2670);

                string?
                f_25028_2504_2544(string
                path)
                {
                    var return_v = System.IO.Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 2504, 2544);
                    return return_v;
                }


                string
                f_25028_2466_2545(string
                path1, string
                path2)
                {
                    var return_v = System.IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 2466, 2545);
                    return return_v;
                }


                int
                f_25028_2560_2593(string
                sourceFileName, string
                destFileName)
                {
                    File.Copy(sourceFileName, destFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 2560, 2593);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                f_25028_2629_2657(string
                path)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DisposableFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 2629, 2657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                f_25028_2615_2658(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
                this_param, Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                file)
                {
                    var return_v = this_param.AddFile(file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 2615, 2658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25028, 2358, 2670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25028, 2358, 2670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TempDirectory CreateDirectory(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25028, 2867, 3109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 2941, 2994);

                string
                dirPath = f_25028_2958_2993(_path, name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 3008, 3043);

                f_25028_3008_3042(dirPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 3057, 3098);

                return f_25028_3064_3097(dirPath, _root);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25028, 2867, 3109);

                string
                f_25028_2958_2993(string
                path1, string
                path2)
                {
                    var return_v = System.IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 2958, 2993);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_25028_3008_3042(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 3008, 3042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.TempDirectory
                f_25028_3064_3097(string
                path, Microsoft.CodeAnalysis.Test.Utilities.TempRoot
                root)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.TempDirectory(path, root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 3064, 3097);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25028, 2867, 3109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25028, 2867, 3109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25028, 3121, 3203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25028, 3179, 3192);

                return _path;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25028, 3121, 3203);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25028, 3121, 3203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25028, 3121, 3203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TempDirectory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25028, 347, 3210);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25028, 347, 3210);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25028, 347, 3210);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25028, 347, 3210);

        static string
        f_25028_533_569(string
        basePath)
        {
            var return_v = CreateUniqueDirectory(basePath);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 533, 569);
            return return_v;
        }


        static string
        f_25028_533_569_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(25028, 474, 598);
            return return_v;
        }


        static int
        f_25028_684_710(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 684, 710);
            return 0;
        }


        static int
        f_25028_725_751(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25028, 725, 751);
            return 0;
        }

    }
}
