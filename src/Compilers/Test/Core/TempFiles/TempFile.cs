// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Text;
using System.Diagnostics;
using Roslyn.Utilities;
using System.Threading.Tasks;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public class TempFile
    {
        private readonly string _path;

        internal TempFile(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25024, 607, 745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 589, 594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 662, 707);

                f_25024_662_706(f_25024_675_705(path));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 721, 734);

                _path = path;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25024, 607, 745);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 607, 745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 607, 745);
            }
        }

        internal TempFile(string prefix, string extension, string directory, string callerSourcePath, int callerLineNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25024, 757, 1766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 589, 594);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 897, 1755) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25024, 897, 1755);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 942, 1117) || true) && (prefix == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25024, 942, 1117);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 1002, 1098);

                            prefix = f_25024_1011_1055(callerSourcePath) + "_" + f_25024_1064_1091(callerLineNumber) + "_";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25024, 942, 1117);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 1137, 1245);

                        _path = f_25024_1145_1244(directory ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(25024, 1168, 1194) ?? TempRoot.Root), prefix + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Guid.NewGuid()).ToString(), 25024, 1205, 1219) + (extension ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(25024, 1223, 1242) ?? ".tmp")));

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 1309, 1358);

                            f_25024_1309_1357(_path, FileMode.CreateNew);
                            DynAbs.Tracing.TraceSender.TraceBreak(25024, 1380, 1386);

                            break;
                        }
                        catch (PathTooLongException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(25024, 1423, 1517);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 1492, 1498);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(25024, 1423, 1517);
                        }
                        catch (DirectoryNotFoundException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(25024, 1535, 1635);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 1610, 1616);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(25024, 1535, 1635);
                        }
                        catch (IOException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(25024, 1653, 1740);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(25024, 1653, 1740);
                            // retry
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25024, 897, 1755);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25024, 897, 1755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25024, 897, 1755);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25024, 757, 1766);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 757, 1766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 757, 1766);
            }
        }

        public FileStream Open(FileAccess access = FileAccess.ReadWrite)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25024, 1778, 1930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 1867, 1919);

                return f_25024_1874_1918(_path, FileMode.Open, access);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25024, 1778, 1930);

                System.IO.FileStream
                f_25024_1874_1918(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access)
                {
                    var return_v = new System.IO.FileStream(path, mode, access);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 1874, 1918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 1778, 1930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 1778, 1930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string Path
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25024, 1985, 2006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 1991, 2004);

                    return _path;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25024, 1985, 2006);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 1942, 2017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 1942, 2017);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TempFile WriteAllText(string content, Encoding encoding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25024, 2029, 2198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 2117, 2161);

                f_25024_2117_2160(_path, content, encoding);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 2175, 2187);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25024, 2029, 2198);

                int
                f_25024_2117_2160(string
                path, string
                contents, System.Text.Encoding
                encoding)
                {
                    File.WriteAllText(path, contents, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 2117, 2160);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 2029, 2198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 2029, 2198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TempFile WriteAllText(string content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25024, 2210, 2350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 2279, 2313);

                f_25024_2279_2312(_path, content);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 2327, 2339);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25024, 2210, 2350);

                int
                f_25024_2279_2312(string
                path, string
                contents)
                {
                    File.WriteAllText(path, contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 2279, 2312);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 2210, 2350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 2210, 2350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<TempFile> WriteAllTextAsync(string content, Encoding encoding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25024, 2362, 2668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 2467, 2629);
                using (var
                sw = f_25024_2483_2529(f_25024_2500_2518(_path), encoding)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 2563, 2614);

                    await f_25024_2569_2613(f_25024_2569_2591(sw, content), false);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25024, 2467, 2629);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 2645, 2657);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25024, 2362, 2668);

                System.IO.FileStream
                f_25024_2500_2518(string
                path)
                {
                    var return_v = File.Create(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 2500, 2518);
                    return return_v;
                }


                System.IO.StreamWriter
                f_25024_2483_2529(System.IO.FileStream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 2483, 2529);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_25024_2569_2591(System.IO.StreamWriter
                this_param, string
                value)
                {
                    var return_v = this_param.WriteAsync(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 2569, 2591);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_25024_2569_2613(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 2569, 2613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 2362, 2668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 2362, 2668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Task<TempFile> WriteAllTextAsync(string content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25024, 2680, 2820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 2760, 2809);

                return f_25024_2767_2808(this, content, f_25024_2794_2807());
                DynAbs.Tracing.TraceSender.TraceExitMethod(25024, 2680, 2820);

                System.Text.Encoding
                f_25024_2794_2807()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25024, 2794, 2807);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Test.Utilities.TempFile>
                f_25024_2767_2808(Microsoft.CodeAnalysis.Test.Utilities.TempFile
                this_param, string
                content, System.Text.Encoding
                encoding)
                {
                    var return_v = this_param.WriteAllTextAsync(content, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 2767, 2808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 2680, 2820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 2680, 2820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TempFile WriteAllBytes(byte[] content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25024, 2832, 2974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 2902, 2937);

                f_25024_2902_2936(_path, content);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 2951, 2963);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25024, 2832, 2974);

                int
                f_25024_2902_2936(string
                path, byte[]
                bytes)
                {
                    File.WriteAllBytes(path, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 2902, 2936);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 2832, 2974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 2832, 2974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TempFile WriteAllBytes(ImmutableArray<byte> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25024, 2986, 3134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 3070, 3097);

                content.WriteToFile(_path);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 3111, 3123);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25024, 2986, 3134);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 2986, 3134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 2986, 3134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ReadAllText()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25024, 3146, 3240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 3198, 3229);

                return f_25024_3205_3228(_path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25024, 3146, 3240);

                string
                f_25024_3205_3228(string
                path)
                {
                    var return_v = File.ReadAllText(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 3205, 3228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 3146, 3240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 3146, 3240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public byte[] ReadAllBytes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25024, 3252, 3348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 3305, 3337);

                return f_25024_3312_3336(_path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25024, 3252, 3348);

                byte[]
                f_25024_3312_3336(string
                path)
                {
                    var return_v = File.ReadAllBytes(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 3312, 3336);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 3252, 3348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 3252, 3348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TempFile CopyContentFrom(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25024, 3360, 3486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 3429, 3475);

                return f_25024_3436_3474(this, f_25024_3450_3473(path));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25024, 3360, 3486);

                byte[]
                f_25024_3450_3473(string
                path)
                {
                    var return_v = File.ReadAllBytes(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 3450, 3473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.TempFile
                f_25024_3436_3474(Microsoft.CodeAnalysis.Test.Utilities.TempFile
                this_param, byte[]
                content)
                {
                    var return_v = this_param.WriteAllBytes(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 3436, 3474);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 3360, 3486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 3360, 3486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25024, 3498, 3580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25024, 3556, 3569);

                return _path;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25024, 3498, 3580);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25024, 3498, 3580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 3498, 3580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TempFile()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25024, 527, 3587);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25024, 527, 3587);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25024, 527, 3587);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25024, 527, 3587);

        bool
        f_25024_675_705(string
        path)
        {
            var return_v = PathUtilities.IsAbsolute(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 675, 705);
            return return_v;
        }


        int
        f_25024_662_706(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 662, 706);
            return 0;
        }


        string?
        f_25024_1011_1055(string
        path)
        {
            var return_v = System.IO.Path.GetFileName(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 1011, 1055);
            return return_v;
        }


        string
        f_25024_1064_1091(int
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 1064, 1091);
            return return_v;
        }


        string
        f_25024_1145_1244(string
        path1, string
        path2)
        {
            var return_v = System.IO.Path.Combine(path1, path2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 1145, 1244);
            return return_v;
        }


        int
        f_25024_1309_1357(string
        fullPath, System.IO.FileMode
        mode)
        {
            TempRoot.CreateStream(fullPath, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25024, 1309, 1357);
            return 0;
        }

    }
}
