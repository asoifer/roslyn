// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal class StrongNameFileSystem
    {
        internal static readonly StrongNameFileSystem Instance;

        internal readonly string? _customTempPath;

        internal StrongNameFileSystem(string? customTempPath = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(562, 719, 848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(562, 691, 706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(562, 804, 837);

                _customTempPath = customTempPath;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(562, 719, 848);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(562, 719, 848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(562, 719, 848);
            }
        }

        internal virtual FileStream CreateFileStream(string filePath, FileMode fileMode, FileAccess fileAccess, FileShare fileShare)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(562, 860, 1085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(562, 1009, 1074);

                return f_562_1016_1073(filePath, fileMode, fileAccess, fileShare);
                DynAbs.Tracing.TraceSender.TraceExitMethod(562, 860, 1085);

                System.IO.FileStream
                f_562_1016_1073(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(562, 1016, 1073);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(562, 860, 1085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(562, 860, 1085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual byte[] ReadAllBytes(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(562, 1097, 1284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(562, 1175, 1224);

                f_562_1175_1223(f_562_1188_1222(fullPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(562, 1238, 1273);

                return f_562_1245_1272(fullPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(562, 1097, 1284);

                bool
                f_562_1188_1222(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(562, 1188, 1222);
                    return return_v;
                }


                int
                f_562_1175_1223(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(562, 1175, 1223);
                    return 0;
                }


                byte[]
                f_562_1245_1272(string
                path)
                {
                    var return_v = File.ReadAllBytes(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(562, 1245, 1272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(562, 1097, 1284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(562, 1097, 1284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool FileExists(string? fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(562, 1296, 1494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(562, 1371, 1440);

                f_562_1371_1439(fullPath == null || (DynAbs.Tracing.TraceSender.Expression_False(562, 1384, 1438) || f_562_1404_1438(fullPath)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(562, 1454, 1483);

                return f_562_1461_1482(fullPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(562, 1296, 1494);

                bool
                f_562_1404_1438(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(562, 1404, 1438);
                    return return_v;
                }


                int
                f_562_1371_1439(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(562, 1371, 1439);
                    return 0;
                }


                bool
                f_562_1461_1482(string?
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(562, 1461, 1482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(562, 1296, 1494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(562, 1296, 1494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual string GetTempPath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(562, 1544, 1584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(562, 1547, 1584);
                return _customTempPath ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(562, 1547, 1584) ?? f_562_1566_1584()); DynAbs.Tracing.TraceSender.TraceExitMethod(562, 1544, 1584);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(562, 1544, 1584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(562, 1544, 1584);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string
            f_562_1566_1584()
            {
                var return_v = Path.GetTempPath();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(562, 1566, 1584);
                return return_v;
            }

        }

        static StrongNameFileSystem()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(562, 519, 1592);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(562, 617, 654);
            Instance = f_562_628_654(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(562, 519, 1592);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(562, 519, 1592);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(562, 519, 1592);

        static Microsoft.CodeAnalysis.StrongNameFileSystem
        f_562_628_654()
        {
            var return_v = new Microsoft.CodeAnalysis.StrongNameFileSystem();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(562, 628, 654);
            return return_v;
        }

    }
}
