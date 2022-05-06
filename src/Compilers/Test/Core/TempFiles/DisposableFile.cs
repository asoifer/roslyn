// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;
using System.Runtime.InteropServices;
using Roslyn.Utilities;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public sealed class DisposableFile : TempFile, IDisposable
    {
        public DisposableFile(string path)
        : base(f_25027_550_554_C(path))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25027, 495, 577);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25027, 495, 577);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25027, 495, 577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25027, 495, 577);
            }
        }

        public DisposableFile(string prefix = null, string extension = null, string directory = null, string callerSourcePath = null, int callerLineNumber = 0)
        : base(f_25027_761_767_C(prefix), extension, directory, callerSourcePath, callerLineNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25027, 589, 848);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25027, 589, 848);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25027, 589, 848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25027, 589, 848);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25027, 860, 2160);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25027, 906, 2149) || true) && (f_25027_910_914() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25027, 906, 2149);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25027, 1000, 1018);

                        f_25027_1000_1017(f_25027_1012_1016());
                    }
                    catch (UnauthorizedAccessException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(25027, 1055, 2134);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25027, 1267, 1291);

                            f_25027_1267_1290(f_25027_1285_1289());
                        }
                        catch (IOException ex)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(25027, 1336, 1699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25027, 1407, 1676);

                            throw f_25027_1413_1675(f_25027_1443_1670(@"
The file '{0}' seems to have been opened in a way that prevents us from deleting it on close.
Is the file loaded as an assembly (e.g. via Assembly.LoadFile)?

{1}: {2}", f_25027_1634_1638(), f_25027_1640_1657(f_25027_1640_1652(ex)), f_25027_1659_1669(ex)), ex);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(25027, 1336, 1699);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(25027, 1721, 2115);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(25027, 1721, 2115);
                            //  We should ignore this exception if we got it the second time, 
                            //  the most important reason is that the file has already been 
                            //  scheduled for deletion and will be deleted when all handles 
                            //  are closed.
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(25027, 1055, 2134);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25027, 906, 2149);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25027, 860, 2160);

                string
                f_25027_910_914()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25027, 910, 914);
                    return return_v;
                }


                string
                f_25027_1012_1016()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25027, 1012, 1016);
                    return return_v;
                }


                int
                f_25027_1000_1017(string
                path)
                {
                    File.Delete(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25027, 1000, 1017);
                    return 0;
                }


                string
                f_25027_1285_1289()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25027, 1285, 1289);
                    return return_v;
                }


                int
                f_25027_1267_1290(string
                fullPath)
                {
                    DeleteFileOnClose(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25027, 1267, 1290);
                    return 0;
                }


                string
                f_25027_1634_1638()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25027, 1634, 1638);
                    return return_v;
                }


                System.Type
                f_25027_1640_1652(System.IO.IOException
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25027, 1640, 1652);
                    return return_v;
                }


                string
                f_25027_1640_1657(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25027, 1640, 1657);
                    return return_v;
                }


                string
                f_25027_1659_1669(System.IO.IOException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25027, 1659, 1669);
                    return return_v;
                }


                string
                f_25027_1443_1670(string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25027, 1443, 1670);
                    return return_v;
                }


                System.InvalidOperationException
                f_25027_1413_1675(string
                message, System.IO.IOException
                innerException)
                {
                    var return_v = new System.InvalidOperationException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25027, 1413, 1675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25027, 860, 2160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25027, 860, 2160);
            }
        }

        [DllImport("kernel32.dll", PreserveSig = false)]
        private static extern void SetFileInformationByHandle(SafeFileHandle handle, int fileInformationClass, ref uint fileDispositionInfoDeleteFile, int bufferSize);

        private const int
        FileDispositionInfo = 4
        ;

        internal static void PrepareDeleteOnCloseStreamForDisposal(FileStream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25027, 2455, 3001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25027, 2857, 2876);

                uint
                trueValue = 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25027, 2890, 2990);

                f_25027_2890_2989(f_25027_2917_2938(stream), FileDispositionInfo, ref trueValue, sizeof(uint));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25027, 2455, 3001);

                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_25027_2917_2938(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.SafeFileHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25027, 2917, 2938);
                    return return_v;
                }


                int
                f_25027_2890_2989(Microsoft.Win32.SafeHandles.SafeFileHandle
                handle, int
                fileInformationClass, ref uint
                fileDispositionInfoDeleteFile, int
                bufferSize)
                {
                    SetFileInformationByHandle(handle, fileInformationClass, ref fileDispositionInfoDeleteFile, bufferSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25027, 2890, 2989);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25027, 2455, 3001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25027, 2455, 3001);
            }
        }

        internal static void DeleteFileOnClose(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25027, 3248, 3585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25027, 3328, 3574);
                using (var
                stream = f_25027_3348_3479(fullPath, FileMode.Open, FileAccess.ReadWrite, FileShare.Delete | FileShare.ReadWrite, 8, FileOptions.DeleteOnClose)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25027, 3513, 3559);

                    f_25027_3513_3558(stream);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25027, 3328, 3574);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25027, 3248, 3585);

                System.IO.FileStream
                f_25027_3348_3479(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share, int
                bufferSize, System.IO.FileOptions
                options)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share, bufferSize, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25027, 3348, 3479);
                    return return_v;
                }


                int
                f_25027_3513_3558(System.IO.FileStream
                stream)
                {
                    PrepareDeleteOnCloseStreamForDisposal(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25027, 3513, 3558);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25027, 3248, 3585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25027, 3248, 3585);
            }
        }

        static DisposableFile()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25027, 420, 3592);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25027, 2419, 2442);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25027, 420, 3592);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25027, 420, 3592);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25027, 420, 3592);

        static string
        f_25027_550_554_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(25027, 495, 577);
            return return_v;
        }


        static string?
        f_25027_761_767_C(string?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(25027, 589, 848);
            return return_v;
        }

    }
}
