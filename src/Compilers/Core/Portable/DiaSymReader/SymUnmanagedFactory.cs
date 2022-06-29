// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Microsoft.DiaSymReader
{
    internal static class SymUnmanagedFactory
    {
        private const string
        AlternateLoadPathEnvironmentVariableName = "MICROSOFT_DIASYMREADER_NATIVE_ALT_LOAD_PATH"
        ;

        private const string
        LegacyDiaSymReaderModuleName = "diasymreader.dll"
        ;

        private const string
        DiaSymReaderModuleName32 = "Microsoft.DiaSymReader.Native.x86.dll"
        ;

        private const string
        DiaSymReaderModuleName64 = "Microsoft.DiaSymReader.Native.amd64.dll"
        ;

        private const string
        CreateSymReaderFactoryName = "CreateSymReader"
        ;

        private const string
        CreateSymWriterFactoryName = "CreateSymWriter"
        ;

        private const string
        SymWriterClsid = "0AE2DEB0-F901-478b-BB9F-881EE8066788"
        ;

        private const string
        SymReaderClsid = "0A3976C5-4529-4ef8-B0B0-42EED37082CD"
        ;

        private static Type s_lazySymReaderComType, s_lazySymWriterComType;

        internal static string DiaSymReaderModuleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(277, 1395, 1470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 1398, 1470);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(277, 1398, 1416) || (((IntPtr.Size == 4) && DynAbs.Tracing.TraceSender.Conditional_F2(277, 1419, 1443)) || DynAbs.Tracing.TraceSender.Conditional_F3(277, 1446, 1470))) ? DiaSymReaderModuleName32 : DiaSymReaderModuleName64; DynAbs.Tracing.TraceSender.TraceExitMethod(277, 1395, 1470);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(277, 1395, 1470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(277, 1395, 1470);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory | DllImportSearchPath.SafeDirectories)]
        [DllImport(DiaSymReaderModuleName32, EntryPoint = CreateSymReaderFactoryName)]
        private static extern void CreateSymReader32(ref Guid id, [MarshalAs(UnmanagedType.IUnknown)] out object symReader);

        [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory | DllImportSearchPath.SafeDirectories)]
        [DllImport(DiaSymReaderModuleName64, EntryPoint = CreateSymReaderFactoryName)]
        private static extern void CreateSymReader64(ref Guid id, [MarshalAs(UnmanagedType.IUnknown)] out object symReader);

        [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory | DllImportSearchPath.SafeDirectories)]
        [DllImport(DiaSymReaderModuleName32, EntryPoint = CreateSymWriterFactoryName)]
        private static extern void CreateSymWriter32(ref Guid id, [MarshalAs(UnmanagedType.IUnknown)] out object symWriter);

        [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory | DllImportSearchPath.SafeDirectories)]
        [DllImport(DiaSymReaderModuleName64, EntryPoint = CreateSymWriterFactoryName)]
        private static extern void CreateSymWriter64(ref Guid id, [MarshalAs(UnmanagedType.IUnknown)] out object symWriter);

        [DllImport("kernel32")]
        private static extern IntPtr LoadLibrary(string path);

        [DllImport("kernel32")]
        private static extern bool FreeLibrary(IntPtr hModule);

        [DllImport("kernel32")]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        private delegate void NativeFactory(ref Guid id, [MarshalAs(UnmanagedType.IUnknown)] out object instance);

        private static readonly Lazy<Func<string, string>> s_lazyGetEnvironmentVariable;

        internal static string GetEnvironmentVariable(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(277, 4057, 4429);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 4260, 4316);

                    return f_277_4267_4315_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_277_4267_4301(s_lazyGetEnvironmentVariable), 277, 4267, 4315).Invoke(name));
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(277, 4353, 4418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 4391, 4403);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(277, 4353, 4418);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(277, 4057, 4429);

                System.Func<string, string>
                f_277_4267_4301(System.Lazy<System.Func<string, string>>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(277, 4267, 4301);
                    return return_v;
                }


                string?
                f_277_4267_4315_I(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 4267, 4315);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(277, 4057, 4429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(277, 4057, 4429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object TryLoadFromAlternativePath(Guid clsid, string factoryName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(277, 4441, 5915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 4546, 4621);

                var
                dir = f_277_4556_4620(AlternateLoadPathEnvironmentVariableName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 4635, 4725) || true) && (f_277_4639_4664(dir))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 4635, 4725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 4698, 4710);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(277, 4635, 4725);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 4741, 4815);

                var
                moduleHandle = f_277_4760_4814(f_277_4772_4813(dir, f_277_4790_4812()))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 4829, 4971) || true) && (moduleHandle == IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 4829, 4971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 4894, 4956);

                    f_277_4894_4955(f_277_4922_4954());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(277, 4829, 4971);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 4987, 5010);

                object
                instance = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 5060, 5122);

                    var
                    createAddress = f_277_5080_5121(moduleHandle, factoryName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 5140, 5295) || true) && (createAddress == IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 5140, 5295);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 5214, 5276);

                        f_277_5214_5275(f_277_5242_5274());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(277, 5140, 5295);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 5474, 5556);

                    var
                    creator = f_277_5488_5555(createAddress)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 5582, 5615);

                    f_277_5582_5614(creator, ref clsid, out instance);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(277, 5644, 5872);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 5684, 5857) || true) && (instance == null && (DynAbs.Tracing.TraceSender.Expression_True(277, 5688, 5734) && !f_277_5709_5734(moduleHandle)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 5684, 5857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 5776, 5838);

                        f_277_5776_5837(f_277_5804_5836());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(277, 5684, 5857);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(277, 5644, 5872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 5888, 5904);

                return instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(277, 4441, 5915);

                string
                f_277_4556_4620(string
                name)
                {
                    var return_v = GetEnvironmentVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 4556, 4620);
                    return return_v;
                }


                bool
                f_277_4639_4664(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 4639, 4664);
                    return return_v;
                }


                string
                f_277_4790_4812()
                {
                    var return_v = DiaSymReaderModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(277, 4790, 4812);
                    return return_v;
                }


                string
                f_277_4772_4813(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 4772, 4813);
                    return return_v;
                }


                System.IntPtr
                f_277_4760_4814(string
                path)
                {
                    var return_v = LoadLibrary(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 4760, 4814);
                    return return_v;
                }


                int
                f_277_4922_4954()
                {
                    var return_v = Marshal.GetHRForLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 4922, 4954);
                    return return_v;
                }


                int
                f_277_4894_4955(int
                errorCode)
                {
                    Marshal.ThrowExceptionForHR(errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 4894, 4955);
                    return 0;
                }


                System.IntPtr
                f_277_5080_5121(System.IntPtr
                hModule, string
                procedureName)
                {
                    var return_v = GetProcAddress(hModule, procedureName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 5080, 5121);
                    return return_v;
                }


                int
                f_277_5242_5274()
                {
                    var return_v = Marshal.GetHRForLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 5242, 5274);
                    return return_v;
                }


                int
                f_277_5214_5275(int
                errorCode)
                {
                    Marshal.ThrowExceptionForHR(errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 5214, 5275);
                    return 0;
                }


                Microsoft.DiaSymReader.SymUnmanagedFactory.NativeFactory
                f_277_5488_5555(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.GetDelegateForFunctionPointer<NativeFactory>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 5488, 5555);
                    return return_v;
                }


                int
                f_277_5582_5614(Microsoft.DiaSymReader.SymUnmanagedFactory.NativeFactory
                this_param, ref System.Guid
                id, out object
                instance)
                {
                    this_param.Invoke(ref id, out instance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 5582, 5614);
                    return 0;
                }


                bool
                f_277_5709_5734(System.IntPtr
                hModule)
                {
                    var return_v = FreeLibrary(hModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 5709, 5734);
                    return return_v;
                }


                int
                f_277_5804_5836()
                {
                    var return_v = Marshal.GetHRForLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 5804, 5836);
                    return return_v;
                }


                int
                f_277_5776_5837(int
                errorCode)
                {
                    Marshal.ThrowExceptionForHR(errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 5776, 5837);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(277, 4441, 5915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(277, 4441, 5915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Type GetComTypeType(ref Type lazyType, Guid clsid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(277, 5927, 6256);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 6017, 6213) || true) && (lazyType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 6017, 6213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 6147, 6190);

                    lazyType = f_277_6158_6189(clsid);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(277, 6017, 6213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 6229, 6245);

                return lazyType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(277, 5927, 6256);

                System.Type
                f_277_6158_6189(System.Guid
                clsid)
                {
                    var return_v = Marshal.GetTypeFromCLSID(clsid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 6158, 6189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(277, 5927, 6256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(277, 5927, 6256);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CreateObject(bool createReader, bool useAlternativeLoadPath, bool useComRegistry, out string moduleName, out Exception loadException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(277, 6268, 8912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 6449, 6472);

                object
                instance = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 6486, 6507);

                loadException = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 6521, 6539);

                moduleName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 6555, 6624);

                var
                clsid = f_277_6567_6623((DynAbs.Tracing.TraceSender.Conditional_F1(277, 6576, 6588) || ((createReader && DynAbs.Tracing.TraceSender.Conditional_F2(277, 6591, 6605)) || DynAbs.Tracing.TraceSender.Conditional_F3(277, 6608, 6622))) ? SymReaderClsid : SymWriterClsid)
                ;

                try
                {
                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 6720, 7513) || true) && (IntPtr.Size == 4)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 6720, 7513);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 6790, 7091) || true) && (createReader)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 6790, 7091);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 6864, 6907);

                                f_277_6864_6906(ref clsid, out instance);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(277, 6790, 7091);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 6790, 7091);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 7021, 7064);

                                f_277_7021_7063(ref clsid, out instance);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(277, 6790, 7091);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(277, 6720, 7513);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 6720, 7513);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 7189, 7490) || true) && (createReader)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 7189, 7490);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 7263, 7306);

                                f_277_7263_7305(ref clsid, out instance);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(277, 7189, 7490);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 7189, 7490);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 7420, 7463);

                                f_277_7420_7462(ref clsid, out instance);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(277, 7189, 7490);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(277, 6720, 7513);
                        }
                    }
                    catch (DllNotFoundException e) when (useAlternativeLoadPath)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(277, 7550, 7920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 7651, 7768);

                        instance = f_277_7662_7767(clsid, (DynAbs.Tracing.TraceSender.Conditional_F1(277, 7696, 7708) || ((createReader && DynAbs.Tracing.TraceSender.Conditional_F2(277, 7711, 7737)) || DynAbs.Tracing.TraceSender.Conditional_F3(277, 7740, 7766))) ? CreateSymReaderFactoryName : CreateSymWriterFactoryName);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 7790, 7901) || true) && (instance == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 7790, 7901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 7860, 7878);

                            loadException = e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(277, 7790, 7901);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(277, 7550, 7920);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(277, 7949, 8068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 8001, 8019);

                    loadException = e;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 8037, 8053);

                    instance = null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(277, 7949, 8068);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 8084, 8869) || true) && (instance != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 8084, 8869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 8138, 8174);

                    moduleName = f_277_8151_8173();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(277, 8084, 8869);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 8084, 8869);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 8208, 8869) || true) && (useComRegistry)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(277, 8208, 8869);
                        // Try to find a registered CLR implementation
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 8368, 8549);

                            var
                            comType = (DynAbs.Tracing.TraceSender.Conditional_F1(277, 8382, 8394) || ((createReader && DynAbs.Tracing.TraceSender.Conditional_F2(277, 8422, 8471)) || DynAbs.Tracing.TraceSender.Conditional_F3(277, 8499, 8548))) ? f_277_8422_8471(ref s_lazySymReaderComType, clsid) : f_277_8499_8548(ref s_lazySymWriterComType, clsid)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 8573, 8618);

                            instance = f_277_8584_8617(comType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 8640, 8682);

                            moduleName = LegacyDiaSymReaderModuleName;
                        }
                        catch (Exception e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(277, 8719, 8854);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 8779, 8797);

                            loadException = e;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 8819, 8835);

                            instance = null;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(277, 8719, 8854);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(277, 8208, 8869);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(277, 8084, 8869);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 8885, 8901);

                return instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(277, 6268, 8912);

                System.Guid
                f_277_6567_6623(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 6567, 6623);
                    return return_v;
                }


                int
                f_277_6864_6906(ref System.Guid
                id, out object
                symReader)
                {
                    CreateSymReader32(ref id, out symReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 6864, 6906);
                    return 0;
                }


                int
                f_277_7021_7063(ref System.Guid
                id, out object
                symWriter)
                {
                    CreateSymWriter32(ref id, out symWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 7021, 7063);
                    return 0;
                }


                int
                f_277_7263_7305(ref System.Guid
                id, out object
                symReader)
                {
                    CreateSymReader64(ref id, out symReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 7263, 7305);
                    return 0;
                }


                int
                f_277_7420_7462(ref System.Guid
                id, out object
                symWriter)
                {
                    CreateSymWriter64(ref id, out symWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 7420, 7462);
                    return 0;
                }


                object
                f_277_7662_7767(System.Guid
                clsid, string
                factoryName)
                {
                    var return_v = TryLoadFromAlternativePath(clsid, factoryName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 7662, 7767);
                    return return_v;
                }


                string
                f_277_8151_8173()
                {
                    var return_v = DiaSymReaderModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(277, 8151, 8173);
                    return return_v;
                }


                System.Type
                f_277_8422_8471(ref System.Type
                lazyType, System.Guid
                clsid)
                {
                    var return_v = GetComTypeType(ref lazyType, clsid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 8422, 8471);
                    return return_v;
                }


                System.Type
                f_277_8499_8548(ref System.Type
                lazyType, System.Guid
                clsid)
                {
                    var return_v = GetComTypeType(ref lazyType, clsid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 8499, 8548);
                    return return_v;
                }


                object?
                f_277_8584_8617(System.Type
                type)
                {
                    var return_v = Activator.CreateInstance(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 8584, 8617);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(277, 6268, 8912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(277, 6268, 8912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymUnmanagedFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(277, 370, 8921);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 449, 537);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 571, 620);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 652, 718);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 750, 818);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 852, 898);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 930, 976);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 1055, 1110);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 1189, 1244);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 1277, 1299);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 1301, 1323);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(277, 3318, 4003);
            s_lazyGetEnvironmentVariable = f_277_3349_4003(() =>
                    {
                        try
                        {
                            foreach (var method in typeof(Environment).GetTypeInfo().GetDeclaredMethods("GetEnvironmentVariable"))
                            {
                                var parameters = method.GetParameters();
                                if (parameters.Length == 1 && parameters[0].ParameterType == typeof(string))
                                {
                                    return (Func<string, string>)method.CreateDelegate(typeof(Func<string, string>));
                                }
                            }
                        }
                        catch
                        {
                        }

                        return null;
                    }); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(277, 370, 8921);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(277, 370, 8921);
        }


        static System.Lazy<System.Func<string, string>>
        f_277_3349_4003(System.Func<System.Func<string, string>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Func<string, string>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(277, 3349, 4003);
            return return_v;
        }

    }
}
