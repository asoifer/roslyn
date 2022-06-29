// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Roslyn.Utilities;
using System;
using System.IO;
using System.Threading;

namespace Microsoft.CodeAnalysis
{
    internal class TouchedFileLogger
    {
        private ConcurrentSet<string> _readFiles;

        private ConcurrentSet<string> _writtenFiles;

        public TouchedFileLogger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(141, 647, 808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 570, 580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 621, 634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 698, 739);

                _readFiles = f_141_711_738();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 753, 797);

                _writtenFiles = f_141_769_796();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(141, 647, 808);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(141, 647, 808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(141, 647, 808);
            }
        }

        public void AddRead(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(141, 1035, 1194);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 1092, 1148) || true) && (path == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(141, 1092, 1148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 1110, 1148);

                    throw f_141_1116_1147(path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(141, 1092, 1148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 1162, 1183);

                f_141_1162_1182(_readFiles, path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(141, 1035, 1194);

                System.ArgumentNullException
                f_141_1116_1147(string?
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 1116, 1147);
                    return return_v;
                }


                bool
                f_141_1162_1182(Roslyn.Utilities.ConcurrentSet<string>
                this_param, string
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 1162, 1182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(141, 1035, 1194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(141, 1035, 1194);
            }
        }

        public void AddWritten(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(141, 1427, 1592);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 1487, 1543) || true) && (path == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(141, 1487, 1543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 1505, 1543);

                    throw f_141_1511_1542(path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(141, 1487, 1543);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 1557, 1581);

                f_141_1557_1580(_writtenFiles, path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(141, 1427, 1592);

                System.ArgumentNullException
                f_141_1511_1542(string?
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 1511, 1542);
                    return return_v;
                }


                bool
                f_141_1557_1580(Roslyn.Utilities.ConcurrentSet<string>
                this_param, string
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 1557, 1580);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(141, 1427, 1592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(141, 1427, 1592);
            }
        }

        public void AddReadWritten(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(141, 1847, 1967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 1911, 1925);

                f_141_1911_1924(this, path);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 1939, 1956);

                f_141_1939_1955(this, path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(141, 1847, 1967);

                int
                f_141_1911_1924(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, string
                path)
                {
                    this_param.AddRead(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 1911, 1924);
                    return 0;
                }


                int
                f_141_1939_1955(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, string
                path)
                {
                    this_param.AddWritten(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 1939, 1955);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(141, 1847, 1967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(141, 1847, 1967);
            }
        }

        public void WriteReadPaths(TextWriter s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(141, 2214, 2759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 2279, 2319);

                var
                temp = new string[f_141_2301_2317(_readFiles)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 2333, 2343);

                int
                i = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 2357, 2452);

                var
                readFiles = f_141_2373_2451(ref _readFiles, null!)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 2466, 2601);
                    foreach (var path in f_141_2487_2496_I(readFiles))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(141, 2466, 2601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 2530, 2564);

                        temp[i] = f_141_2540_2563(path);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 2582, 2586);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(141, 2466, 2601);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(141, 1, 136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(141, 1, 136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 2615, 2640);

                f_141_2615_2639(temp);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 2656, 2748);
                    foreach (var path in f_141_2677_2681_I(temp))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(141, 2656, 2748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 2715, 2733);

                        f_141_2715_2732(s, path);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(141, 2656, 2748);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(141, 1, 93);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(141, 1, 93);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(141, 2214, 2759);

                int
                f_141_2301_2317(Roslyn.Utilities.ConcurrentSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(141, 2301, 2317);
                    return return_v;
                }


                Roslyn.Utilities.ConcurrentSet<string>
                f_141_2373_2451(ref Roslyn.Utilities.ConcurrentSet<string>
                location1, Roslyn.Utilities.ConcurrentSet<string>
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 2373, 2451);
                    return return_v;
                }


                string
                f_141_2540_2563(string
                this_param)
                {
                    var return_v = this_param.ToUpperInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 2540, 2563);
                    return return_v;
                }


                Roslyn.Utilities.ConcurrentSet<string>
                f_141_2487_2496_I(Roslyn.Utilities.ConcurrentSet<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 2487, 2496);
                    return return_v;
                }


                int
                f_141_2615_2639(string[]
                array)
                {
                    Array.Sort<string>(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 2615, 2639);
                    return 0;
                }


                int
                f_141_2715_2732(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 2715, 2732);
                    return 0;
                }


                string[]
                f_141_2677_2681_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 2677, 2681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(141, 2214, 2759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(141, 2214, 2759);
            }
        }

        public void WriteWrittenPaths(TextWriter s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(141, 3006, 3566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 3074, 3117);

                var
                temp = new string[f_141_3096_3115(_writtenFiles)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 3131, 3141);

                int
                i = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 3155, 3256);

                var
                writtenFiles = f_141_3174_3255(ref _writtenFiles, null!)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 3270, 3408);
                    foreach (var path in f_141_3291_3303_I(writtenFiles))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(141, 3270, 3408);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 3337, 3371);

                        temp[i] = f_141_3347_3370(path);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 3389, 3393);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(141, 3270, 3408);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(141, 1, 139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(141, 1, 139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 3422, 3447);

                f_141_3422_3446(temp);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 3463, 3555);
                    foreach (var path in f_141_3484_3488_I(temp))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(141, 3463, 3555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(141, 3522, 3540);

                        f_141_3522_3539(s, path);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(141, 3463, 3555);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(141, 1, 93);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(141, 1, 93);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(141, 3006, 3566);

                int
                f_141_3096_3115(Roslyn.Utilities.ConcurrentSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(141, 3096, 3115);
                    return return_v;
                }


                Roslyn.Utilities.ConcurrentSet<string>
                f_141_3174_3255(ref Roslyn.Utilities.ConcurrentSet<string>
                location1, Roslyn.Utilities.ConcurrentSet<string>
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 3174, 3255);
                    return return_v;
                }


                string
                f_141_3347_3370(string
                this_param)
                {
                    var return_v = this_param.ToUpperInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 3347, 3370);
                    return return_v;
                }


                Roslyn.Utilities.ConcurrentSet<string>
                f_141_3291_3303_I(Roslyn.Utilities.ConcurrentSet<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 3291, 3303);
                    return return_v;
                }


                int
                f_141_3422_3446(string[]
                array)
                {
                    Array.Sort<string>(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 3422, 3446);
                    return 0;
                }


                int
                f_141_3522_3539(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 3522, 3539);
                    return 0;
                }


                string[]
                f_141_3484_3488_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 3484, 3488);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(141, 3006, 3566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(141, 3006, 3566);
            }
        }

        static TouchedFileLogger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(141, 491, 3573);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(141, 491, 3573);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(141, 491, 3573);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(141, 491, 3573);

        static Roslyn.Utilities.ConcurrentSet<string>
        f_141_711_738()
        {
            var return_v = new Roslyn.Utilities.ConcurrentSet<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 711, 738);
            return return_v;
        }


        static Roslyn.Utilities.ConcurrentSet<string>
        f_141_769_796()
        {
            var return_v = new Roslyn.Utilities.ConcurrentSet<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(141, 769, 796);
            return return_v;
        }

    }
}
