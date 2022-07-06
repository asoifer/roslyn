// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    internal sealed class TestStrongNameFileSystem : StrongNameFileSystem
    {
        internal Func<string, byte[]> ReadAllBytesFunc { get; set; }

        internal Func<string, FileMode, FileAccess, FileShare, FileStream> CreateFileStreamFunc { get; set; }

        internal TestStrongNameFileSystem()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25064, 589, 756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25064, 406, 466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25064, 476, 577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25064, 649, 686);

                ReadAllBytesFunc = base.ReadAllBytes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25064, 700, 745);

                CreateFileStreamFunc = base.CreateFileStream;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25064, 589, 756);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25064, 589, 756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25064, 589, 756);
            }
        }

        internal override byte[] ReadAllBytes(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25064, 823, 852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25064, 826, 852);
                return f_25064_826_852(ReadAllBytesFunc, fullPath); DynAbs.Tracing.TraceSender.TraceExitMethod(25064, 823, 852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25064, 823, 852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25064, 823, 852);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Func<string, byte[]>
            f_25064_826_842()
            {
                var return_v = ReadAllBytesFunc;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25064, 826, 842);
                return return_v;
            }


            byte[]
            f_25064_826_852(Func<string, byte[]>
            this_param, string
            arg)
            {
                var return_v = this_param.Invoke(arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25064, 826, 852);
                return return_v;
            }

        }

        internal override FileStream CreateFileStream(string filePath, FileMode fileMode, FileAccess fileAccess, FileShare fileShare)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25064, 989, 1068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25064, 1005, 1068);
                return f_25064_1005_1068(CreateFileStreamFunc, filePath, fileMode, fileAccess, fileShare); DynAbs.Tracing.TraceSender.TraceExitMethod(25064, 989, 1068);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25064, 989, 1068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25064, 989, 1068);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Func<string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, System.IO.FileStream>
            f_25064_1005_1025()
            {
                var return_v = CreateFileStreamFunc;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25064, 1005, 1025);
                return return_v;
            }


            System.IO.FileStream
            f_25064_1005_1068(Func<string, FileMode, FileAccess, FileShare, FileStream>
            this_param, string
            arg1, System.IO.FileMode
            arg2, System.IO.FileAccess
            arg3, System.IO.FileShare
            arg4)
            {
                var return_v = this_param.Invoke(arg1, arg2, arg3, arg4);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25064, 1005, 1068);
                return return_v;
            }

        }

        static TestStrongNameFileSystem()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25064, 320, 1076);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25064, 320, 1076);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25064, 320, 1076);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25064, 320, 1076);
    }
}
