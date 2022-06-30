// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Runtime.InteropServices;
using System.Security;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Interop
{
    internal static class ClrStrongName
    {
        [DllImport("mscoree.dll", PreserveSig = false, EntryPoint = "CLRCreateInstance")]
        [return: MarshalAs(UnmanagedType.Interface)]
        private static extern object nCreateInterface(
                        [MarshalAs(UnmanagedType.LPStruct)] Guid clsid,
                        [MarshalAs(UnmanagedType.LPStruct)] Guid riid);

        internal static IClrStrongName GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(400, 768, 1868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 837, 956);

                var
                metaHostClsid = f_400_857_955(unchecked(0x9280188D), 0xE8E, 0x4867, 0xB3, 0xC, 0x7F, 0xA8, 0x38, 0x84, 0xE8, 0xDE)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 970, 1108);

                var
                metaHostGuid = f_400_989_1107(unchecked(0xD332DB9E), unchecked((short)0xB9B3), 0x4125, 0x82, 0x07, 0xA1, 0x48, 0x84, 0xF5, 0x32, 0x16)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 1122, 1266);

                var
                clrStrongNameClsid = f_400_1147_1265(unchecked(0xB79B0ACD), unchecked((short)0xF5CD), 0x409b, 0xB5, 0xA5, 0xA1, 0x62, 0x44, 0x61, 0x0B, 0x92)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 1280, 1424);

                var
                clrRuntimeInfoGuid = f_400_1305_1423(unchecked(0xBD39D1D2), unchecked((short)0xBA2F), 0x486A, 0x89, 0xB0, 0xB4, 0xB0, 0xCB, 0x46, 0x68, 0x91)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 1438, 1563);

                var
                clrStrongNameGuid = f_400_1462_1562(unchecked(0x9FD93CCF), 0x3280, 0x4391, 0xB3, 0xA9, 0x96, 0xE1, 0xCD, 0xE7, 0x7C, 0x8D)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 1579, 1654);

                var
                metaHost = (IClrMetaHost)f_400_1608_1653(metaHostClsid, metaHostGuid)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 1668, 1760);

                var
                runtime = (IClrRuntimeInfo)f_400_1699_1759(metaHost, f_400_1719_1738(), clrRuntimeInfoGuid)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 1774, 1857);

                return (IClrStrongName)f_400_1797_1856(runtime, clrStrongNameClsid, clrStrongNameGuid);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(400, 768, 1868);

                System.Guid
                f_400_857_955(uint
                a, int
                b, int
                c, int
                d, int
                e, int
                f, int
                g, int
                h, int
                i, int
                j, int
                k)
                {
                    var return_v = new System.Guid((int)a, (short)b, (short)c, (byte)d, (byte)e, (byte)f, (byte)g, (byte)h, (byte)i, (byte)j, (byte)k);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 857, 955);
                    return return_v;
                }


                System.Guid
                f_400_989_1107(uint
                a, int
                b, int
                c, int
                d, int
                e, int
                f, int
                g, int
                h, int
                i, int
                j, int
                k)
                {
                    var return_v = new System.Guid((int)a, (short)b, (short)c, (byte)d, (byte)e, (byte)f, (byte)g, (byte)h, (byte)i, (byte)j, (byte)k);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 989, 1107);
                    return return_v;
                }


                System.Guid
                f_400_1147_1265(uint
                a, int
                b, int
                c, int
                d, int
                e, int
                f, int
                g, int
                h, int
                i, int
                j, int
                k)
                {
                    var return_v = new System.Guid((int)a, (short)b, (short)c, (byte)d, (byte)e, (byte)f, (byte)g, (byte)h, (byte)i, (byte)j, (byte)k);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 1147, 1265);
                    return return_v;
                }


                System.Guid
                f_400_1305_1423(uint
                a, int
                b, int
                c, int
                d, int
                e, int
                f, int
                g, int
                h, int
                i, int
                j, int
                k)
                {
                    var return_v = new System.Guid((int)a, (short)b, (short)c, (byte)d, (byte)e, (byte)f, (byte)g, (byte)h, (byte)i, (byte)j, (byte)k);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 1305, 1423);
                    return return_v;
                }


                System.Guid
                f_400_1462_1562(uint
                a, int
                b, int
                c, int
                d, int
                e, int
                f, int
                g, int
                h, int
                i, int
                j, int
                k)
                {
                    var return_v = new System.Guid((int)a, (short)b, (short)c, (byte)d, (byte)e, (byte)f, (byte)g, (byte)h, (byte)i, (byte)j, (byte)k);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 1462, 1562);
                    return return_v;
                }


                object
                f_400_1608_1653(System.Guid
                clsid, System.Guid
                riid)
                {
                    var return_v = nCreateInterface(clsid, riid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 1608, 1653);
                    return return_v;
                }


                string
                f_400_1719_1738()
                {
                    var return_v = GetRuntimeVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 1719, 1738);
                    return return_v;
                }


                object
                f_400_1699_1759(Microsoft.CodeAnalysis.Interop.IClrMetaHost
                this_param, string
                version, System.Guid
                interfaceId)
                {
                    var return_v = this_param.GetRuntime(version, interfaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 1699, 1759);
                    return return_v;
                }


                object
                f_400_1797_1856(Microsoft.CodeAnalysis.Interop.IClrRuntimeInfo
                this_param, System.Guid
                coClassId, System.Guid
                interfaceId)
                {
                    var return_v = this_param.GetInterface(coClassId, interfaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 1797, 1856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(400, 768, 1868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(400, 768, 1868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetRuntimeVersion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(400, 1880, 2490);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 2114, 2443) || true) && (!f_400_2119_2198(f_400_2140_2197("COMPLUS_InstallRoot")))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(400, 2114, 2443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 2232, 2300);

                    var
                    version = f_400_2246_2299("COMPLUS_Version")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 2318, 2428) || true) && (!f_400_2323_2352(version))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(400, 2318, 2428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 2394, 2409);

                        return version;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(400, 2318, 2428);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(400, 2114, 2443);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(400, 2459, 2479);

                return "v4.0.30319";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(400, 1880, 2490);

                string?
                f_400_2140_2197(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 2140, 2197);
                    return return_v;
                }


                bool
                f_400_2119_2198(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 2119, 2198);
                    return return_v;
                }


                string?
                f_400_2246_2299(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 2246, 2299);
                    return return_v;
                }


                bool
                f_400_2323_2352(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(400, 2323, 2352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(400, 1880, 2490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(400, 1880, 2490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ClrStrongName()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(400, 383, 2497);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(400, 383, 2497);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(400, 383, 2497);
        }

    }
}
