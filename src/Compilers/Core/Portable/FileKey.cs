// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.IO;

namespace Roslyn.Utilities
{

    internal struct FileKey : IEquatable<FileKey>
    {

        public readonly string FullPath;

        public readonly DateTime Timestamp;

        public FileKey(string fullPath, DateTime timestamp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(17, 825, 1096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(17, 901, 950);

                f_17_901_949(f_17_914_948(fullPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(17, 964, 1013);

                f_17_964_1012(timestamp.Kind == DateTimeKind.Utc);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(17, 1029, 1049);

                FullPath = fullPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(17, 1063, 1085);

                Timestamp = timestamp;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(17, 825, 1096);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(17, 825, 1096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(17, 825, 1096);
            }
        }

        public static FileKey Create(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(17, 1153, 1305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(17, 1223, 1294);

                return f_17_1230_1293(fullPath, f_17_1252_1292(fullPath));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(17, 1153, 1305);

                System.DateTime
                f_17_1252_1292(string
                fullPath)
                {
                    var return_v = FileUtilities.GetFileTimeStamp(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(17, 1252, 1292);
                    return return_v;
                }


                Roslyn.Utilities.FileKey
                f_17_1230_1293(string
                fullPath, System.DateTime
                timestamp)
                {
                    var return_v = new Roslyn.Utilities.FileKey(fullPath, timestamp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(17, 1230, 1293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(17, 1153, 1305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(17, 1153, 1305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(17, 1317, 1532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(17, 1375, 1521);

                return f_17_1382_1520(f_17_1413_1472(f_17_1413_1445(), this.FullPath), this.Timestamp.GetHashCode());
                DynAbs.Tracing.TraceSender.TraceExitMethod(17, 1317, 1532);

                System.StringComparer
                f_17_1413_1445()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(17, 1413, 1445);
                    return return_v;
                }


                int
                f_17_1413_1472(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(17, 1413, 1472);
                    return return_v;
                }


                int
                f_17_1382_1520(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(17, 1382, 1520);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(17, 1317, 1532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(17, 1317, 1532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(17, 1544, 1666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(17, 1609, 1655);

                return obj is FileKey && (DynAbs.Tracing.TraceSender.Expression_True(17, 1616, 1654) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(17, 1544, 1666);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(17, 1544, 1666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(17, 1544, 1666);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(17, 1678, 1802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(17, 1736, 1791);

                return f_17_1743_1790("'{0}'@{1}", FullPath, Timestamp);
                DynAbs.Tracing.TraceSender.TraceExitMethod(17, 1678, 1802);

                string
                f_17_1743_1790(string
                format, string
                arg0, System.DateTime
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(17, 1743, 1790);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(17, 1678, 1802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(17, 1678, 1802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(FileKey other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(17, 1814, 2042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(17, 1872, 2031);

                return
                                this.Timestamp == other.Timestamp && (DynAbs.Tracing.TraceSender.Expression_True(17, 1896, 2030) && f_17_1950_2030(this.FullPath, other.FullPath, StringComparison.OrdinalIgnoreCase));
                DynAbs.Tracing.TraceSender.TraceExitMethod(17, 1814, 2042);

                bool
                f_17_1950_2030(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(17, 1950, 2030);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(17, 1814, 2042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(17, 1814, 2042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static FileKey()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(17, 305, 2049);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(17, 305, 2049);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(17, 305, 2049);
        }

        static bool
        f_17_914_948(string
        path)
        {
            var return_v = PathUtilities.IsAbsolute(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(17, 914, 948);
            return return_v;
        }


        static int
        f_17_901_949(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(17, 901, 949);
            return 0;
        }


        static int
        f_17_964_1012(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(17, 964, 1012);
            return 0;
        }

    }
}
