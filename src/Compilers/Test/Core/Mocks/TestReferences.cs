// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Test.Resources.Proprietary;
using Roslyn.Test.Utilities;
public static class TestReferences
{
    public static class MetadataTests
    {
        public static class NetModule01
        {
            private static readonly Lazy<PortableExecutableReference> s_appCS;

            public static PortableExecutableReference AppCS
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 916, 932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 919, 932);
                        return f_25120_919_932(s_appCS); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 916, 932);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 916, 932);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 916, 932);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_moduleCS00;

            public static PortableExecutableReference ModuleCS00
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 1330, 1351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 1333, 1351);
                        return f_25120_1333_1351(s_moduleCS00); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 1330, 1351);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 1330, 1351);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 1330, 1351);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_moduleCS01;

            public static PortableExecutableReference ModuleCS01
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 1749, 1770);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 1752, 1770);
                        return f_25120_1752_1770(s_moduleCS01); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 1749, 1770);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 1749, 1770);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 1749, 1770);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_moduleVB01;

            public static PortableExecutableReference ModuleVB01
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 2168, 2189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 2171, 2189);
                        return f_25120_2171_2189(s_moduleVB01); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 2168, 2189);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 2168, 2189);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 2168, 2189);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static NetModule01()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 501, 2201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 615, 853);
                s_appCS = f_25120_625_853(() => AssemblyMetadata.CreateFromImage(TestResources.MetadataTests.NetModule01.AppCS).GetReference(display: "AppCS"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 1007, 1262);
                s_moduleCS00 = f_25120_1022_1262(() => ModuleMetadata.CreateFromImage(TestResources.MetadataTests.NetModule01.ModuleCS00).GetReference(display: "ModuleCS00.mod"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 1426, 1681);
                s_moduleCS01 = f_25120_1441_1681(() => ModuleMetadata.CreateFromImage(TestResources.MetadataTests.NetModule01.ModuleCS01).GetReference(display: "ModuleCS01.mod"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 1845, 2100);
                s_moduleVB01 = f_25120_1860_2100(() => ModuleMetadata.CreateFromImage(TestResources.MetadataTests.NetModule01.ModuleVB01).GetReference(display: "ModuleVB01.mod"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 501, 2201);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 501, 2201);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_625_853(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 625, 853);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_919_932(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 919, 932);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_1022_1262(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 1022, 1262);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_1333_1351(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 1333, 1351);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_1441_1681(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 1441, 1681);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_1752_1770(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 1752, 1770);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_1860_2100(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 1860, 2100);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_2171_2189(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 2171, 2189);
                return return_v;
            }

        }
        public static class InterfaceAndClass
        {
            private static readonly Lazy<PortableExecutableReference> s_CSClasses01;

            public static PortableExecutableReference CSClasses01
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 2668, 2690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 2671, 2690);
                        return f_25120_2671_2690(s_CSClasses01); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 2668, 2690);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 2668, 2690);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 2668, 2690);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_CSInterfaces01;

            public static PortableExecutableReference CSInterfaces01
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 3112, 3137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 3115, 3137);
                        return f_25120_3115_3137(s_CSInterfaces01); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 3112, 3137);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 3112, 3137);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 3112, 3137);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_VBClasses01;

            public static PortableExecutableReference VBClasses01
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 3547, 3569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 3550, 3569);
                        return f_25120_3550_3569(s_VBClasses01); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 3547, 3569);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 3547, 3569);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 3547, 3569);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_VBClasses02;

            public static PortableExecutableReference VBClasses02
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 3979, 4001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 3982, 4001);
                        return f_25120_3982_4001(s_VBClasses02); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 3979, 4001);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 3979, 4001);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 3979, 4001);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_VBInterfaces01;

            public static PortableExecutableReference VBInterfaces01
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 4423, 4448);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 4426, 4448);
                        return f_25120_4426_4448(s_VBInterfaces01); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 4423, 4448);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 4423, 4448);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 4423, 4448);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static InterfaceAndClass()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 2213, 4460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 2333, 2599);
                s_CSClasses01 = f_25120_2349_2599(() => AssemblyMetadata.CreateFromImage(TestResources.MetadataTests.InterfaceAndClass.CSClasses01).GetReference(display: "CSClasses01.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 2765, 3040);
                s_CSInterfaces01 = f_25120_2784_3040(() => AssemblyMetadata.CreateFromImage(TestResources.MetadataTests.InterfaceAndClass.CSInterfaces01).GetReference(display: "CSInterfaces01.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 3212, 3478);
                s_VBClasses01 = f_25120_3228_3478(() => AssemblyMetadata.CreateFromImage(TestResources.MetadataTests.InterfaceAndClass.VBClasses01).GetReference(display: "VBClasses01.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 3644, 3910);
                s_VBClasses02 = f_25120_3660_3910(() => AssemblyMetadata.CreateFromImage(TestResources.MetadataTests.InterfaceAndClass.VBClasses02).GetReference(display: "VBClasses02.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 4076, 4351);
                s_VBInterfaces01 = f_25120_4095_4351(() => AssemblyMetadata.CreateFromImage(TestResources.MetadataTests.InterfaceAndClass.VBInterfaces01).GetReference(display: "VBInterfaces01.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 2213, 4460);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 2213, 4460);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_2349_2599(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 2349, 2599);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_2671_2690(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 2671, 2690);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_2784_3040(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 2784, 3040);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_3115_3137(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 3115, 3137);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_3228_3478(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 3228, 3478);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_3550_3569(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 3550, 3569);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_3660_3910(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 3660, 3910);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_3982_4001(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 3982, 4001);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_4095_4351(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 4095, 4351);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_4426_4448(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 4426, 4448);
                return return_v;
            }

        }

        static MetadataTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 451, 4467);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 451, 4467);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 451, 4467);
        }

    }
    public static class NetFx
    {
        public static class Minimal
        {
            private static readonly Lazy<PortableExecutableReference> s_mincorlib;

            public static PortableExecutableReference mincorlib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 4936, 4956);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 4939, 4956);
                        return f_25120_4939_4956(s_mincorlib); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 4936, 4956);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 4936, 4956);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 4936, 4956);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_minasync;

            public static PortableExecutableReference minasync
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 5336, 5355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 5339, 5355);
                        return f_25120_5339_5355(s_minasync); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 5336, 5355);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 5336, 5355);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 5336, 5355);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_minasynccorlib;

            public static PortableExecutableReference minasynccorlib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 5759, 5784);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 5762, 5784);
                        return f_25120_5762_5784(s_minasynccorlib); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 5759, 5784);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 5759, 5784);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 5759, 5784);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static Minimal()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 4517, 5796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 4627, 4869);
                s_mincorlib = f_25120_4641_4869(() => AssemblyMetadata.CreateFromImage(TestResources.NetFX.Minimal.mincorlib).GetReference(display: "mincorlib.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 5031, 5270);
                s_minasync = f_25120_5044_5270(() => AssemblyMetadata.CreateFromImage(TestResources.NetFX.Minimal.minasync).GetReference(display: "minasync.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 5430, 5687);
                s_minasynccorlib = f_25120_5449_5687(() => AssemblyMetadata.CreateFromImage(TestResources.NetFX.Minimal.minasynccorlib).GetReference(display: "minasynccorlib.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 4517, 5796);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 4517, 5796);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_4641_4869(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 4641, 4869);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_4939_4956(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 4939, 4956);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_5044_5270(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 5044, 5270);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_5339_5355(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 5339, 5355);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_5449_5687(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 5449, 5687);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_5762_5784(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 5762, 5784);
                return return_v;
            }

        }
        public static class ValueTuple
        {
            private static readonly Lazy<PortableExecutableReference> s_tuplelib;

            public static PortableExecutableReference tuplelib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 6238, 6257);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 6241, 6257);
                        return f_25120_6241_6257(s_tuplelib); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 6238, 6257);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 6238, 6257);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 6238, 6257);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ValueTuple()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 5808, 6269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 5921, 6172);
                s_tuplelib = f_25120_5934_6172(() => AssemblyMetadata.CreateFromImage(TestResources.NetFX.ValueTuple.tuplelib).GetReference(display: "System.ValueTuple.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 5808, 6269);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 5808, 6269);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_5934_6172(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 5934, 6172);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_6241_6257(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 6241, 6257);
                return return_v;
            }

        }
        public static class silverlight_v5_0_5_0
        {
            private static readonly Lazy<PortableExecutableReference> s_system;

            public static PortableExecutableReference System
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 6761, 6778);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 6764, 6778);
                        return f_25120_6764_6778(s_system); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 6761, 6778);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 6761, 6778);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 6761, 6778);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static silverlight_v5_0_5_0()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 6281, 6790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 6404, 6697);
                s_system = f_25120_6415_6697(() => AssemblyMetadata.CreateFromImage(ProprietaryTestResources.silverlight_v5_0_5_0.System_v5_0_5_0_silverlight).GetReference(display: "System.v5.0.5.0_silverlight.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 6281, 6790);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 6281, 6790);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_6415_6697(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 6415, 6697);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_6764_6778(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 6764, 6778);
                return return_v;
            }

        }

        static NetFx()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 4475, 6797);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 4475, 6797);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 4475, 6797);
        }

    }
    public static class NetStandard13
    {
        private static readonly Lazy<PortableExecutableReference> s_systemRuntime;

        public static PortableExecutableReference SystemRuntime
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 7260, 7284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 7263, 7284);
                    return f_25120_7263_7284(s_systemRuntime); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 7260, 7284);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 7260, 7284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 7260, 7284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static NetStandard13()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 6805, 7292);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 6913, 7193);
            s_systemRuntime = f_25120_6931_7193(() => AssemblyMetadata.CreateFromImage(ProprietaryTestResources.netstandard13.System_Runtime).GetReference(display: @"System.Runtime.dll (netstandard13 ref)"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 6805, 7292);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 6805, 7292);
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_6931_7193(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 6931, 7193);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_7263_7284(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 7263, 7284);
            return return_v;
        }

    }
    public static class DiagnosticTests
    {
        public static class ErrTestLib01
        {
            private static readonly Lazy<PortableExecutableReference> s_errTestLib01;

            public static PortableExecutableReference dll
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 7765, 7788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 7768, 7788);
                        return f_25120_7768_7788(s_errTestLib01); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 7765, 7788);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 7765, 7788);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 7765, 7788);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ErrTestLib01()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 7352, 7800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 7467, 7704);
                s_errTestLib01 = f_25120_7484_7704(() => AssemblyMetadata.CreateFromImage(TestResources.DiagnosticTests.ErrTestLib01).GetReference(display: "ErrTestLib01.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 7352, 7800);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 7352, 7800);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_7484_7704(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 7484, 7704);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_7768_7788(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 7768, 7788);
                return return_v;
            }

        }
        public static class ErrTestLib02
        {
            private static readonly Lazy<PortableExecutableReference> s_errTestLib02;

            public static PortableExecutableReference dll
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 8225, 8248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 8228, 8248);
                        return f_25120_8228_8248(s_errTestLib02); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 8225, 8248);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 8225, 8248);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 8225, 8248);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ErrTestLib02()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 7812, 8260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 7927, 8164);
                s_errTestLib02 = f_25120_7944_8164(() => AssemblyMetadata.CreateFromImage(TestResources.DiagnosticTests.ErrTestLib02).GetReference(display: "ErrTestLib02.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 7812, 8260);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 7812, 8260);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_7944_8164(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 7944, 8164);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_8228_8248(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 8228, 8248);
                return return_v;
            }

        }
        public static class ErrTestLib11
        {
            private static readonly Lazy<PortableExecutableReference> s_errTestLib11;

            public static PortableExecutableReference dll
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 8685, 8708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 8688, 8708);
                        return f_25120_8688_8708(s_errTestLib11); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 8685, 8708);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 8685, 8708);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 8685, 8708);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ErrTestLib11()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 8272, 8720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 8387, 8624);
                s_errTestLib11 = f_25120_8404_8624(() => AssemblyMetadata.CreateFromImage(TestResources.DiagnosticTests.ErrTestLib11).GetReference(display: "ErrTestLib11.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 8272, 8720);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 8272, 8720);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_8404_8624(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 8404, 8624);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_8688_8708(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 8688, 8708);
                return return_v;
            }

        }
        public static class ErrTestMod01
        {
            private static readonly Lazy<PortableExecutableReference> s_errTestMod01;

            public static PortableExecutableReference dll
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 9145, 9168);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 9148, 9168);
                        return f_25120_9148_9168(s_errTestMod01); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 9145, 9168);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 9145, 9168);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 9145, 9168);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ErrTestMod01()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 8732, 9180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 8847, 9084);
                s_errTestMod01 = f_25120_8864_9084(() => AssemblyMetadata.CreateFromImage(TestResources.DiagnosticTests.ErrTestMod01).GetReference(display: "ErrTestMod01.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 8732, 9180);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 8732, 9180);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_8864_9084(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 8864, 9084);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_9148_9168(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 9148, 9168);
                return return_v;
            }

        }
        public static class ErrTestMod02
        {
            private static readonly Lazy<PortableExecutableReference> s_errTestMod02;

            public static PortableExecutableReference dll
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 9605, 9628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 9608, 9628);
                        return f_25120_9608_9628(s_errTestMod02); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 9605, 9628);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 9605, 9628);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 9605, 9628);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ErrTestMod02()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 9192, 9640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 9307, 9544);
                s_errTestMod02 = f_25120_9324_9544(() => AssemblyMetadata.CreateFromImage(TestResources.DiagnosticTests.ErrTestMod02).GetReference(display: "ErrTestMod02.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 9192, 9640);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 9192, 9640);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_9324_9544(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 9324, 9544);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_9608_9628(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 9608, 9628);
                return return_v;
            }

        }
        public static class badresfile
        {
            private static readonly Lazy<PortableExecutableReference> s_badresfile;

            public static PortableExecutableReference res
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 10057, 10078);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 10060, 10078);
                        return f_25120_10060_10078(s_badresfile); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 10057, 10078);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 10057, 10078);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 10057, 10078);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static badresfile()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 9652, 10090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 9765, 9996);
                s_badresfile = f_25120_9780_9996(() => AssemblyMetadata.CreateFromImage(TestResources.DiagnosticTests.badresfile).GetReference(display: "badresfile.res"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 9652, 10090);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 9652, 10090);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_9780_9996(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 9780, 9996);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_10060_10078(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 10060, 10078);
                return return_v;
            }

        }

        static DiagnosticTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 7300, 10097);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 7300, 10097);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 7300, 10097);
        }

    }
    public static class SymbolsTests
    {
        private static readonly Lazy<PortableExecutableReference> s_mdTestLib1;

        public static PortableExecutableReference MDTestLib1
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 10499, 10520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 10502, 10520);
                    return f_25120_10502_10520(s_mdTestLib1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 10499, 10520);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 10499, 10520);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 10499, 10520);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<PortableExecutableReference> s_mdTestLib2;

        public static PortableExecutableReference MDTestLib2
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 10878, 10899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 10881, 10899);
                    return f_25120_10881_10899(s_mdTestLib2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 10878, 10899);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 10878, 10899);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 10878, 10899);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<PortableExecutableReference> s_VBConversions;

        public static PortableExecutableReference VBConversions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 11269, 11293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 11272, 11293);
                    return f_25120_11272_11293(s_VBConversions); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 11269, 11293);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 11269, 11293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 11269, 11293);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<PortableExecutableReference> s_withSpaces;

        public static PortableExecutableReference WithSpaces
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 11653, 11674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 11656, 11674);
                    return f_25120_11656_11674(s_withSpaces); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 11653, 11674);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 11653, 11674);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 11653, 11674);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<PortableExecutableReference> s_withSpacesModule;

        public static PortableExecutableReference WithSpacesModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 12056, 12083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 12059, 12083);
                    return f_25120_12059_12083(s_withSpacesModule); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 12056, 12083);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 12056, 12083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 12056, 12083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<PortableExecutableReference> s_inheritIComparable;

        public static PortableExecutableReference InheritIComparable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 12473, 12502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 12476, 12502);
                    return f_25120_12476_12502(s_inheritIComparable); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 12473, 12502);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 12473, 12502);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 12473, 12502);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<PortableExecutableReference> s_bigVisitor;

        public static PortableExecutableReference BigVisitor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 12860, 12881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 12863, 12881);
                    return f_25120_12863_12881(s_bigVisitor); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 12860, 12881);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 12860, 12881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 12860, 12881);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<PortableExecutableReference> s_properties;

        public static PortableExecutableReference Properties
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 13239, 13260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 13242, 13260);
                    return f_25120_13242_13260(s_properties); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 13239, 13260);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 13239, 13260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 13239, 13260);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<PortableExecutableReference> s_propertiesWithByRef;

        public static PortableExecutableReference PropertiesWithByRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 13654, 13684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 13657, 13684);
                    return f_25120_13657_13684(s_propertiesWithByRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 13654, 13684);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 13654, 13684);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 13654, 13684);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<PortableExecutableReference> s_indexers;

        public static PortableExecutableReference Indexers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 14034, 14053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 14037, 14053);
                    return f_25120_14037_14053(s_indexers); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 14034, 14053);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 14034, 14053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 14034, 14053);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<PortableExecutableReference> s_events;

        public static PortableExecutableReference Events
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 14395, 14412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 14398, 14412);
                    return f_25120_14398_14412(s_events); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 14395, 14412);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 14395, 14412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 14395, 14412);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        public static class netModule
        {
            private static readonly Lazy<PortableExecutableReference> s_netModule1;

            public static PortableExecutableReference netModule1
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 14847, 14868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 14850, 14868);
                        return f_25120_14850_14868(s_netModule1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 14847, 14868);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 14847, 14868);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 14847, 14868);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_netModule2;

            public static PortableExecutableReference netModule2
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 15253, 15274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 15256, 15274);
                        return f_25120_15256_15274(s_netModule2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 15253, 15274);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 15253, 15274);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 15253, 15274);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_crossRefModule1;

            public static PortableExecutableReference CrossRefModule1
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 15679, 15705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 15682, 15705);
                        return f_25120_15682_15705(s_crossRefModule1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 15679, 15705);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 15679, 15705);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 15679, 15705);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_crossRefModule2;

            public static PortableExecutableReference CrossRefModule2
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 16110, 16136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 16113, 16136);
                        return f_25120_16113_16136(s_crossRefModule2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 16110, 16136);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 16110, 16136);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 16110, 16136);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_crossRefLib;

            public static PortableExecutableReference CrossRefLib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 16820, 16842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 16823, 16842);
                        return f_25120_16823_16842(s_crossRefLib); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 16820, 16842);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 16820, 16842);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 16820, 16842);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_hash_module;

            public static PortableExecutableReference hash_module
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 17231, 17253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 17234, 17253);
                        return f_25120_17234_17253(s_hash_module); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 17231, 17253);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 17231, 17253);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 17231, 17253);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_x64COFF;

            public static PortableExecutableReference x64COFF
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 17620, 17638);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 17623, 17638);
                        return f_25120_17623_17638(s_x64COFF); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 17620, 17638);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 17620, 17638);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 17620, 17638);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static netModule()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 14425, 17650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 14537, 14779);
                s_netModule1 = f_25120_14552_14779(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.netModule.netModule1).GetReference(display: "netModule1.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 14943, 15185);
                s_netModule2 = f_25120_14958_15185(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.netModule.netModule2).GetReference(display: "netModule2.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 15349, 15606);
                s_crossRefModule1 = f_25120_15369_15606(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.netModule.CrossRefModule1).GetReference(display: "CrossRefModule1.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 15780, 16037);
                s_crossRefModule2 = f_25120_15800_16037(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.netModule.CrossRefModule2).GetReference(display: "CrossRefModule2.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 16211, 16751);
                s_crossRefLib = f_25120_16227_16751(() => AssemblyMetadata.Create(
                                            ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.netModule.CrossRefLib),
                                            ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.netModule.CrossRefModule1),
                                            ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.netModule.CrossRefModule2)).GetReference(display: "CrossRefLib.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 16917, 17162);
                s_hash_module = f_25120_16933_17162(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.netModule.hash_module).GetReference(display: "hash_module.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 17328, 17555);
                s_x64COFF = f_25120_17340_17555(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.netModule.x64COFF).GetReference(display: "x64COFF.obj"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 14425, 17650);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 14425, 17650);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_14552_14779(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 14552, 14779);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_14850_14868(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 14850, 14868);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_14958_15185(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 14958, 15185);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_15256_15274(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 15256, 15274);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_15369_15606(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 15369, 15606);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_15682_15705(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 15682, 15705);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_15800_16037(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 15800, 16037);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_16113_16136(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 16113, 16136);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_16227_16751(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 16227, 16751);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_16823_16842(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 16823, 16842);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_16933_17162(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 16933, 17162);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_17234_17253(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 17234, 17253);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_17340_17555(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 17340, 17555);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_17623_17638(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 17623, 17638);
                return return_v;
            }

        }
        public static class V1
        {
            public static class MTTestLib1
            {
                private static readonly Lazy<PortableExecutableReference> s_v1MTTestLib1;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 18128, 18151);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 18131, 18151);
                            return f_25120_18131_18151(s_v1MTTestLib1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 18128, 18151);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 18128, 18151);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 18128, 18151);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static MTTestLib1()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 17709, 18167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 17830, 18063);
                    s_v1MTTestLib1 = f_25120_17847_18063(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.V1.MTTestLib1).GetReference(display: "MTTestLib1.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 17709, 18167);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 17709, 18167);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_17847_18063(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 17847, 18063);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_18131_18151(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 18131, 18151);
                    return return_v;
                }

            }
            public static class MTTestModule1
            {
                private static readonly Lazy<PortableExecutableReference> s_v1MTTestLib1;

                public static PortableExecutableReference netmodule
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 18621, 18644);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 18624, 18644);
                            return f_25120_18624_18644(s_v1MTTestLib1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 18621, 18644);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 18621, 18644);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 18621, 18644);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static MTTestModule1()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 18183, 18660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 18307, 18550);
                    s_v1MTTestLib1 = f_25120_18324_18550(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.V1.MTTestModule1).GetReference(display: "MTTestModule1.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 18183, 18660);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 18183, 18660);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_18324_18550(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 18324, 18550);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_18624_18644(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 18624, 18644);
                    return return_v;
                }

            }
            public static class MTTestLib2
            {
                private static readonly Lazy<PortableExecutableReference> s_v1MTTestLib2;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 19095, 19118);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 19098, 19118);
                            return f_25120_19098_19118(s_v1MTTestLib2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 19095, 19118);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 19095, 19118);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 19095, 19118);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static MTTestLib2()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 18676, 19134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 18797, 19030);
                    s_v1MTTestLib2 = f_25120_18814_19030(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.V1.MTTestLib2).GetReference(display: "MTTestLib2.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 18676, 19134);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 18676, 19134);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_18814_19030(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 18814, 19030);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_19098_19118(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 19098, 19118);
                    return return_v;
                }

            }
            public static class MTTestModule2
            {
                private static readonly Lazy<PortableExecutableReference> s_v1MTTestLib1;

                public static PortableExecutableReference netmodule
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 19588, 19611);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 19591, 19611);
                            return f_25120_19591_19611(s_v1MTTestLib1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 19588, 19611);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 19588, 19611);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 19588, 19611);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static MTTestModule2()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 19150, 19627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 19274, 19517);
                    s_v1MTTestLib1 = f_25120_19291_19517(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.V1.MTTestModule2).GetReference(display: "MTTestModule2.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 19150, 19627);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 19150, 19627);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_19291_19517(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 19291, 19517);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_19591_19611(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 19591, 19611);
                    return return_v;
                }

            }

            static V1()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 17662, 19638);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 17662, 19638);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 17662, 19638);
            }

        }
        public static class V2
        {
            public static class MTTestLib1
            {
                private static readonly Lazy<PortableExecutableReference> s_v2MTTestLib1;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 20116, 20139);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 20119, 20139);
                            return f_25120_20119_20139(s_v2MTTestLib1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 20116, 20139);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 20116, 20139);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 20116, 20139);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static PortableExecutableReference
                f_25120_20119_20139(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 20119, 20139);
                    return return_v;
                }

            }
            public static class MTTestModule1
            {
                private static readonly Lazy<PortableExecutableReference> s_v1MTTestLib1;

                public static PortableExecutableReference netmodule
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 20611, 20634);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 20614, 20634);
                            return f_25120_20614_20634(s_v1MTTestLib1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 20611, 20634);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 20611, 20634);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 20611, 20634);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static PortableExecutableReference
                f_25120_20614_20634(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 20614, 20634);
                    return return_v;
                }

            }
            public static class MTTestLib3
            {
                private static readonly Lazy<PortableExecutableReference> s_v2MTTestLib3;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 21085, 21108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 21088, 21108);
                            return f_25120_21088_21108(s_v2MTTestLib3); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 21085, 21108);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 21085, 21108);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 21085, 21108);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static MTTestLib3()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 20666, 21124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 20787, 21020);
                    s_v2MTTestLib3 = f_25120_20804_21020(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.V2.MTTestLib3).GetReference(display: "MTTestLib3.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 20666, 21124);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 20666, 21124);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_20804_21020(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 20804, 21020);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_21088_21108(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 21088, 21108);
                    return return_v;
                }

            }
            public static class MTTestModule3
            {
                private static readonly Lazy<PortableExecutableReference> s_v1MTTestLib1;

                public static PortableExecutableReference netmodule
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 21578, 21601);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 21581, 21601);
                            return f_25120_21581_21601(s_v1MTTestLib1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 21578, 21601);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 21578, 21601);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 21578, 21601);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static MTTestModule3()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 21140, 21617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 21264, 21507);
                    s_v1MTTestLib1 = f_25120_21281_21507(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.V2.MTTestModule3).GetReference(display: "MTTestModule3.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 21140, 21617);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 21140, 21617);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_21281_21507(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 21281, 21507);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_21581_21601(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 21581, 21601);
                    return return_v;
                }

            }

            static V2()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 19650, 21628);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 19650, 21628);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 19650, 21628);
            }

        }
        public static class V3
        {
            public static class MTTestLib1
            {
                private static readonly Lazy<PortableExecutableReference> s_v3MTTestLib1;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 22106, 22129);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 22109, 22129);
                            return f_25120_22109_22129(s_v3MTTestLib1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 22106, 22129);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 22106, 22129);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 22106, 22129);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static PortableExecutableReference
                f_25120_22109_22129(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 22109, 22129);
                    return return_v;
                }

            }
            public static class MTTestModule1
            {
                private static readonly Lazy<PortableExecutableReference> s_v1MTTestLib1;

                public static PortableExecutableReference netmodule
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 22601, 22624);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 22604, 22624);
                            return f_25120_22604_22624(s_v1MTTestLib1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 22601, 22624);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 22601, 22624);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 22601, 22624);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static PortableExecutableReference
                f_25120_22604_22624(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 22604, 22624);
                    return return_v;
                }

            }
            public static class MTTestLib4
            {
                private static readonly Lazy<PortableExecutableReference> s_v3MTTestLib4;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 23075, 23098);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 23078, 23098);
                            return f_25120_23078_23098(s_v3MTTestLib4); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 23075, 23098);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 23075, 23098);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 23075, 23098);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static MTTestLib4()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 22656, 23114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 22777, 23010);
                    s_v3MTTestLib4 = f_25120_22794_23010(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.V3.MTTestLib4).GetReference(display: "MTTestLib4.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 22656, 23114);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 22656, 23114);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_22794_23010(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 22794, 23010);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_23078_23098(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 23078, 23098);
                    return return_v;
                }

            }
            public static class MTTestModule4
            {
                private static readonly Lazy<PortableExecutableReference> s_v1MTTestLib1;

                public static PortableExecutableReference netmodule
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 23568, 23591);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 23571, 23591);
                            return f_25120_23571_23591(s_v1MTTestLib1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 23568, 23591);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 23568, 23591);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 23568, 23591);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static MTTestModule4()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 23130, 23607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 23254, 23497);
                    s_v1MTTestLib1 = f_25120_23271_23497(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.V3.MTTestModule4).GetReference(display: "MTTestModule4.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 23130, 23607);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 23130, 23607);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_23271_23497(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 23271, 23497);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_23571_23591(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 23571, 23591);
                    return return_v;
                }

            }

            static V3()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 21640, 23618);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 21640, 23618);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 21640, 23618);
            }

        }
        public static class MultiModule
        {
            private static readonly Lazy<PortableExecutableReference> s_assembly;

            public static PortableExecutableReference Assembly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 24334, 24353);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 24337, 24353);
                        return f_25120_24337_24353(s_assembly); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 24334, 24353);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 24334, 24353);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 24334, 24353);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_mod2;

            public static PortableExecutableReference mod2
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 24718, 24733);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 24721, 24733);
                        return f_25120_24721_24733(s_mod2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 24718, 24733);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 24718, 24733);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 24718, 24733);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_mod3;

            public static PortableExecutableReference mod3
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 25098, 25113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 25101, 25113);
                        return f_25120_25101_25113(s_mod3); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 25098, 25113);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 25098, 25113);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 25098, 25113);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_consumer;

            public static PortableExecutableReference Consumer
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 25488, 25507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 25491, 25507);
                        return f_25120_25491_25507(s_consumer); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 25488, 25507);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 25488, 25507);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 25488, 25507);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static MultiModule()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 23630, 25519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 23744, 24268);
                s_assembly = f_25120_23757_24268(() => AssemblyMetadata.Create(
                                            ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.MultiModule.MultiModuleDll),
                                            ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.MultiModule.mod2),
                                            ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.MultiModule.mod3)).GetReference(display: "MultiModule.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 24428, 24656);
                s_mod2 = f_25120_24437_24656(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.MultiModule.mod2).GetReference(display: "mod2.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 24808, 25036);
                s_mod3 = f_25120_24817_25036(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.MultiModule.mod3).GetReference(display: "mod3.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 25188, 25422);
                s_consumer = f_25120_25201_25422(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.MultiModule.Consumer).GetReference(display: "Consumer.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 23630, 25519);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 23630, 25519);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_23757_24268(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 23757, 24268);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_24337_24353(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 24337, 24353);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_24437_24656(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 24437, 24656);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_24721_24733(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 24721, 24733);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_24817_25036(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 24817, 25036);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_25101_25113(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 25101, 25113);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_25201_25422(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 25201, 25422);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_25491_25507(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 25491, 25507);
                return return_v;
            }

        }
        public static class DifferByCase
        {
            private static readonly Lazy<PortableExecutableReference> s_typeAndNamespaceDifferByCase;

            public static PortableExecutableReference TypeAndNamespaceDifferByCase
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 26027, 26066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 26030, 26066);
                        return f_25120_26030_26066(s_typeAndNamespaceDifferByCase); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 26027, 26066);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 26027, 26066);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 26027, 26066);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_differByCaseConsumer;

            public static PortableExecutableReference Consumer
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 26454, 26485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 26457, 26485);
                        return f_25120_26457_26485(s_differByCaseConsumer); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 26454, 26485);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 26454, 26485);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 26454, 26485);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_csharpCaseSen;

            public static PortableExecutableReference CsharpCaseSen
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 26876, 26900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 26879, 26900);
                        return f_25120_26879_26900(s_csharpCaseSen); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 26876, 26900);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 26876, 26900);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 26876, 26900);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_csharpDifferCaseOverloads;

            public static PortableExecutableReference CsharpDifferCaseOverloads
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 27344, 27380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 27347, 27380);
                        return f_25120_27347_27380(s_csharpDifferCaseOverloads); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 27344, 27380);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 27344, 27380);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 27344, 27380);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static DifferByCase()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 25531, 27392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 25646, 25941);
                s_typeAndNamespaceDifferByCase = f_25120_25679_25941(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.DifferByCase.TypeAndNamespaceDifferByCase).GetReference(display: "TypeAndNamespaceDifferByCase.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 26141, 26388);
                s_differByCaseConsumer = f_25120_26166_26388(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.DifferByCase.Consumer).GetReference(display: "Consumer.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 26560, 26805);
                s_csharpCaseSen = f_25120_26578_26805(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.DifferByCase.Consumer).GetReference(display: "CsharpCaseSen.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 26975, 27261);
                s_csharpDifferCaseOverloads = f_25120_27005_27261(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.DifferByCase.CSharpDifferCaseOverloads).GetReference(display: "CSharpDifferCaseOverloads.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 25531, 27392);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 25531, 27392);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_25679_25941(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 25679, 25941);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_26030_26066(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 26030, 26066);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_26166_26388(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 26166, 26388);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_26457_26485(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 26457, 26485);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_26578_26805(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 26578, 26805);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_26879_26900(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 26879, 26900);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_27005_27261(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 27005, 27261);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_27347_27380(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 27347, 27380);
                return return_v;
            }

        }
        public static class CorLibrary
        {
            public static class GuidTest2
            {
                private static readonly Lazy<PortableExecutableReference> s_exe;

                public static PortableExecutableReference exe
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 27874, 27888);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 27877, 27888);
                            return f_25120_27877_27888(s_exe); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 27874, 27888);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 27874, 27888);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 27874, 27888);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static GuidTest2()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 27459, 27904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 27579, 27809);
                    s_exe = f_25120_27587_27809(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.CorLibrary.GuidTest2).GetReference(display: "GuidTest2.exe"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 27459, 27904);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 27459, 27904);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_27587_27809(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 27587, 27809);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_27877_27888(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 27877, 27888);
                    return return_v;
                }

            }

            private static readonly Lazy<PortableExecutableReference> s_noMsCorLibRef;

            public static PortableExecutableReference NoMsCorLibRef
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 28297, 28321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 28300, 28321);
                        return f_25120_28300_28321(s_noMsCorLibRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 28297, 28321);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 28297, 28321);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 28297, 28321);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
            public static class FakeMsCorLib
            {
                private static readonly Lazy<PortableExecutableReference> s_dll;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 28762, 28776);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 28765, 28776);
                            return f_25120_28765_28776(s_dll); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 28762, 28776);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 28762, 28776);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 28762, 28776);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static FakeMsCorLib()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 28338, 28792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 28461, 28697);
                    s_dll = f_25120_28469_28697(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.CorLibrary.FakeMsCorLib).GetReference(display: "FakeMsCorLib.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 28338, 28792);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 28338, 28792);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_28469_28697(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 28469, 28697);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_28765_28776(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 28765, 28776);
                    return return_v;
                }

            }

            static CorLibrary()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 27404, 28803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 27978, 28226);
                s_noMsCorLibRef = f_25120_27996_28226(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.CorLibrary.NoMsCorLibRef).GetReference(display: "NoMsCorLibRef.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 27404, 28803);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 27404, 28803);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_27996_28226(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 27996, 28226);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_28300_28321(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 28300, 28321);
                return return_v;
            }

        }
        public static class CustomModifiers
        {
            public static class Modifiers
            {
                private static readonly Lazy<PortableExecutableReference> s_dll;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 29295, 29309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 29298, 29309);
                            return f_25120_29298_29309(s_dll); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 29295, 29309);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 29295, 29309);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 29295, 29309);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                private static readonly Lazy<PortableExecutableReference> s_module;

                public static PortableExecutableReference netmodule
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 29707, 29724);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 29710, 29724);
                            return f_25120_29710_29724(s_module); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 29707, 29724);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 29707, 29724);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 29707, 29724);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static Modifiers()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 28875, 29740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 28995, 29230);
                    s_dll = f_25120_29003_29230(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.CustomModifiers.Modifiers).GetReference(display: "Modifiers.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 29388, 29636);
                    s_module = f_25120_29399_29636(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.CustomModifiers.ModifiersModule).GetReference(display: "Modifiers.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 28875, 29740);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 28875, 29740);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_29003_29230(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 29003, 29230);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_29298_29309(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 29298, 29309);
                    return return_v;
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_29399_29636(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 29399, 29636);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_29710_29724(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 29710, 29724);
                    return return_v;
                }

            }

            private static readonly Lazy<PortableExecutableReference> s_modoptTests;

            public static PortableExecutableReference ModoptTests
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 30130, 30152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 30133, 30152);
                        return f_25120_30133_30152(s_modoptTests); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 30130, 30152);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 30130, 30152);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 30130, 30152);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
            public static class CppCli
            {
                private static readonly Lazy<PortableExecutableReference> s_dll;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 30580, 30594);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 30583, 30594);
                            return f_25120_30583_30594(s_dll); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 30580, 30594);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 30580, 30594);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 30580, 30594);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static CppCli()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 30169, 30610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 30286, 30515);
                    s_dll = f_25120_30294_30515(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.CustomModifiers.CppCli).GetReference(display: "CppCli.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 30169, 30610);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 30169, 30610);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_30294_30515(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 30294, 30515);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_30583_30594(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 30583, 30594);
                    return return_v;
                }

            }
            public static class GenericMethodWithModifiers
            {
                private static readonly Lazy<PortableExecutableReference> s_dll;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 31097, 31111);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 31100, 31111);
                            return f_25120_31100_31111(s_dll); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 31097, 31111);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 31097, 31111);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 31097, 31111);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static GenericMethodWithModifiers()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 30626, 31127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 30763, 31032);
                    s_dll = f_25120_30771_31032(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.CustomModifiers.GenericMethodWithModifiers).GetReference(display: "GenericMethodWithModifiers.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 30626, 31127);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 30626, 31127);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_30771_31032(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 30771, 31032);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_31100_31111(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 31100, 31111);
                    return return_v;
                }

            }

            static CustomModifiers()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 28815, 31138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 29814, 30061);
                s_modoptTests = f_25120_29830_30061(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.CustomModifiers.ModoptTests).GetReference(display: "ModoptTests.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 28815, 31138);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 28815, 31138);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_29830_30061(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 29830, 30061);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_30133_30152(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 30133, 30152);
                return return_v;
            }

        }
        public static class Cyclic
        {
            public static class Cyclic1
            {
                private static readonly Lazy<PortableExecutableReference> s_cyclic1;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 31610, 31628);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 31613, 31628);
                            return f_25120_31613_31628(s_cyclic1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 31610, 31628);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 31610, 31628);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 31610, 31628);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static Cyclic1()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 31201, 31644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 31319, 31545);
                    s_cyclic1 = f_25120_31331_31545(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Cyclic.Cyclic1).GetReference(display: "Cyclic1.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 31201, 31644);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 31201, 31644);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_31331_31545(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 31331, 31545);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_31613_31628(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 31613, 31628);
                    return return_v;
                }

            }
            public static class Cyclic2
            {
                private static readonly Lazy<PortableExecutableReference> s_cyclic2;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 32069, 32087);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 32072, 32087);
                            return f_25120_32072_32087(s_cyclic2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 32069, 32087);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 32069, 32087);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 32069, 32087);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static Cyclic2()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 31660, 32103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 31778, 32004);
                    s_cyclic2 = f_25120_31790_32004(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Cyclic.Cyclic2).GetReference(display: "Cyclic2.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 31660, 32103);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 31660, 32103);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_31790_32004(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 31790, 32004);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_32072_32087(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 32072, 32087);
                    return return_v;
                }

            }

            static Cyclic()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 31150, 32114);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 31150, 32114);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 31150, 32114);
            }

        }
        public static class CyclicInheritance
        {
            private static readonly Lazy<PortableExecutableReference> s_class1;

            public static PortableExecutableReference Class1
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 32544, 32561);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 32547, 32561);
                        return f_25120_32547_32561(s_class1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 32544, 32561);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 32544, 32561);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 32544, 32561);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_class2;

            public static PortableExecutableReference Class2
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 32934, 32951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 32937, 32951);
                        return f_25120_32937_32951(s_class2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 32934, 32951);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 32934, 32951);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 32934, 32951);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_class3;

            public static PortableExecutableReference Class3
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 33324, 33341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 33327, 33341);
                        return f_25120_33327_33341(s_class3); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 33324, 33341);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 33324, 33341);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 33324, 33341);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static CyclicInheritance()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 32126, 33353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 32246, 32480);
                s_class1 = f_25120_32257_32480(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.CyclicInheritance.Class1).GetReference(display: "Class1.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 32636, 32870);
                s_class2 = f_25120_32647_32870(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.CyclicInheritance.Class2).GetReference(display: "Class2.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 33026, 33260);
                s_class3 = f_25120_33037_33260(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.CyclicInheritance.Class3).GetReference(display: "Class3.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 32126, 33353);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 32126, 33353);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_32257_32480(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 32257, 32480);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_32547_32561(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 32547, 32561);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_32647_32870(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 32647, 32870);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_32937_32951(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 32937, 32951);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_33037_33260(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 33037, 33260);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_33327_33341(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 33327, 33341);
                return return_v;
            }

        }

        private static readonly Lazy<PortableExecutableReference> s_cycledStructs;

        public static PortableExecutableReference CycledStructs
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 33743, 33767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 33746, 33767);
                    return f_25120_33746_33767(s_cycledStructs); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 33743, 33767);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 33743, 33767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 33743, 33767);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        public static class RetargetingCycle
        {
            public static class V1
            {
                public static class ClassA
                {
                    private static readonly Lazy<PortableExecutableReference> s_classA;

                    public static PortableExecutableReference dll
                    {
                        get
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 34329, 34346);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 34332, 34346);
                                return f_25120_34332_34346(s_classA); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 34329, 34346);
                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 34329, 34346);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 34329, 34346);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                    }

                    static ClassA()
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 33896, 34366);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 34021, 34260);
                        s_classA = f_25120_34032_34260(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.RetargetingCycle.RetV1.ClassA).GetReference(display: "ClassA.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 33896, 34366);

                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 33896, 34366);
                    }


                    static System.Lazy<PortableExecutableReference>
                    f_25120_34032_34260(System.Func<PortableExecutableReference>
                    valueFactory, System.Threading.LazyThreadSafetyMode
                    mode)
                    {
                        var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 34032, 34260);
                        return return_v;
                    }


                    static PortableExecutableReference
                    f_25120_34332_34346(System.Lazy<PortableExecutableReference>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 34332, 34346);
                        return return_v;
                    }

                }
                public static class ClassB
                {
                    private static readonly Lazy<PortableExecutableReference> s_classB;

                    public static PortableExecutableReference netmodule
                    {
                        get
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 34829, 34846);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 34832, 34846);
                                return f_25120_34832_34846(s_classB); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 34829, 34846);
                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 34829, 34846);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 34829, 34846);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                    }

                    static ClassB()
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 34386, 34866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 34511, 34754);
                        s_classB = f_25120_34522_34754(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.RetargetingCycle.RetV1.ClassB).GetReference(display: "ClassB.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 34386, 34866);

                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 34386, 34866);
                    }


                    static System.Lazy<PortableExecutableReference>
                    f_25120_34522_34754(System.Func<PortableExecutableReference>
                    valueFactory, System.Threading.LazyThreadSafetyMode
                    mode)
                    {
                        var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 34522, 34754);
                        return return_v;
                    }


                    static PortableExecutableReference
                    f_25120_34832_34846(System.Lazy<PortableExecutableReference>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 34832, 34846);
                        return return_v;
                    }

                }
            }
            public static class V2
            {
                public static class ClassA
                {
                    private static readonly Lazy<PortableExecutableReference> s_classA;

                    public static PortableExecutableReference dll
                    {
                        get
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 35385, 35402);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 35388, 35402);
                                return f_25120_35388_35402(s_classA); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 35385, 35402);
                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 35385, 35402);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 35385, 35402);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                    }

                    static PortableExecutableReference
                    f_25120_35388_35402(System.Lazy<PortableExecutableReference>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 35388, 35402);
                        return return_v;
                    }

                }
                public static class ClassB
                {
                    private static readonly Lazy<PortableExecutableReference> s_classB;

                    public static PortableExecutableReference dll
                    {
                        get
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 35875, 35892);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 35878, 35892);
                                return f_25120_35878_35892(s_classB); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 35875, 35892);
                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 35875, 35892);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 35875, 35892);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                    }

                    static PortableExecutableReference
                    f_25120_35878_35892(System.Lazy<PortableExecutableReference>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 35878, 35892);
                        return return_v;
                    }

                }
            }

            static RetargetingCycle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 33780, 35938);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 33780, 35938);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 33780, 35938);
            }

        }
        public static class Methods
        {
            private static readonly Lazy<PortableExecutableReference> s_CSMethods;

            public static PortableExecutableReference CSMethods
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 36360, 36380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 36363, 36380);
                        return f_25120_36363_36380(s_CSMethods); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 36360, 36380);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 36360, 36380);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 36360, 36380);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_VBMethods;

            public static PortableExecutableReference VBMethods
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 36755, 36775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 36758, 36775);
                        return f_25120_36758_36775(s_VBMethods); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 36755, 36775);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 36755, 36775);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 36755, 36775);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_ILMethods;

            public static PortableExecutableReference ILMethods
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 37150, 37170);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 37153, 37170);
                        return f_25120_37153_37170(s_ILMethods); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 37150, 37170);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 37150, 37170);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 37150, 37170);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_byRefReturn;

            public static PortableExecutableReference ByRefReturn
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 37553, 37575);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 37556, 37575);
                        return f_25120_37556_37575(s_byRefReturn); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 37553, 37575);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 37553, 37575);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 37553, 37575);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static Methods()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 35950, 37587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 36060, 36293);
                s_CSMethods = f_25120_36074_36293(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Methods.CSMethods).GetReference(display: "CSMethods.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 36455, 36688);
                s_VBMethods = f_25120_36469_36688(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Methods.VBMethods).GetReference(display: "VBMethods.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 36850, 37083);
                s_ILMethods = f_25120_36864_37083(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Methods.ILMethods).GetReference(display: "ILMethods.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 37245, 37484);
                s_byRefReturn = f_25120_37261_37484(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Methods.ByRefReturn).GetReference(display: "ByRefReturn.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 35950, 37587);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 35950, 37587);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_36074_36293(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 36074, 36293);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_36363_36380(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 36363, 36380);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_36469_36688(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 36469, 36688);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_36758_36775(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 36758, 36775);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_36864_37083(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 36864, 37083);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_37153_37170(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 37153, 37170);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_37261_37484(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 37261, 37484);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_37556_37575(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 37556, 37575);
                return return_v;
            }

        }
        public static class Fields
        {
            public static class CSFields
            {
                private static readonly Lazy<PortableExecutableReference> s_CSFields;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 38063, 38082);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 38066, 38082);
                            return f_25120_38066_38082(s_CSFields); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 38063, 38082);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 38063, 38082);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 38063, 38082);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static CSFields()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 37650, 38098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 37769, 37998);
                    s_CSFields = f_25120_37782_37998(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Fields.CSFields).GetReference(display: "CSFields.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 37650, 38098);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 37650, 38098);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_37782_37998(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 37782, 37998);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_38066_38082(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 38066, 38082);
                    return return_v;
                }

            }
            public static class VBFields
            {
                private static readonly Lazy<PortableExecutableReference> s_VBFields;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 38527, 38546);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 38530, 38546);
                            return f_25120_38530_38546(s_VBFields); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 38527, 38546);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 38527, 38546);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 38527, 38546);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static VBFields()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 38114, 38562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 38233, 38462);
                    s_VBFields = f_25120_38246_38462(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Fields.VBFields).GetReference(display: "VBFields.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 38114, 38562);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 38114, 38562);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_38246_38462(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 38246, 38462);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_38530_38546(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 38530, 38546);
                    return return_v;
                }

            }

            private static readonly Lazy<PortableExecutableReference> s_constantFields;

            public static PortableExecutableReference ConstantFields
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 38955, 38980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 38958, 38980);
                        return f_25120_38958_38980(s_constantFields); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 38955, 38980);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 38955, 38980);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 38955, 38980);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static Fields()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 37599, 38992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 38636, 38883);
                s_constantFields = f_25120_38655_38883(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Fields.ConstantFields).GetReference(display: "ConstantFields.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 37599, 38992);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 37599, 38992);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_38655_38883(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 38655, 38883);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_38958_38980(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 38958, 38980);
                return return_v;
            }

        }
        public static class MissingTypes
        {
            private static readonly Lazy<PortableExecutableReference> s_MDMissingType;

            public static PortableExecutableReference MDMissingType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 39440, 39464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 39443, 39464);
                        return f_25120_39443_39464(s_MDMissingType); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 39440, 39464);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 39440, 39464);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 39440, 39464);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_MDMissingTypeLib;

            public static PortableExecutableReference MDMissingTypeLib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 39872, 39899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 39875, 39899);
                        return f_25120_39875_39899(s_MDMissingTypeLib); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 39872, 39899);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 39872, 39899);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 39872, 39899);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_missingTypesEquality1;

            public static PortableExecutableReference MissingTypesEquality1
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 40327, 40359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 40330, 40359);
                        return f_25120_40330_40359(s_missingTypesEquality1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 40327, 40359);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 40327, 40359);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 40327, 40359);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_missingTypesEquality2;

            public static PortableExecutableReference MissingTypesEquality2
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 40787, 40819);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 40790, 40819);
                        return f_25120_40790_40819(s_missingTypesEquality2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 40787, 40819);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 40787, 40819);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 40787, 40819);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_CL2;

            public static PortableExecutableReference CL2
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 41175, 41189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 41178, 41189);
                        return f_25120_41178_41189(s_CL2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 41175, 41189);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 41175, 41189);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 41175, 41189);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_CL3;

            public static PortableExecutableReference CL3
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 41545, 41559);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 41548, 41559);
                        return f_25120_41548_41559(s_CL3); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 41545, 41559);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 41545, 41559);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 41545, 41559);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static MissingTypes()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 39004, 41571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 39119, 39369);
                s_MDMissingType = f_25120_39137_39369(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.MissingTypes.MDMissingType).GetReference(display: "MDMissingType.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 39539, 39798);
                s_MDMissingTypeLib = f_25120_39560_39798(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.MissingTypes.MDMissingTypeLib).GetReference(display: "MDMissingTypeLib.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 39974, 40248);
                s_missingTypesEquality1 = f_25120_40000_40248(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.MissingTypes.MissingTypesEquality1).GetReference(display: "MissingTypesEquality1.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 40434, 40708);
                s_missingTypesEquality2 = f_25120_40460_40708(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.MissingTypes.MissingTypesEquality2).GetReference(display: "MissingTypesEquality2.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 40894, 41114);
                s_CL2 = f_25120_40902_41114(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.MissingTypes.CL2).GetReference(display: "CL2.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 41264, 41484);
                s_CL3 = f_25120_41272_41484(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.MissingTypes.CL3).GetReference(display: "CL3.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 39004, 41571);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 39004, 41571);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_39137_39369(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 39137, 39369);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_39443_39464(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 39443, 39464);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_39560_39798(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 39560, 39798);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_39875_39899(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 39875, 39899);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_40000_40248(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 40000, 40248);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_40330_40359(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 40330, 40359);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_40460_40708(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 40460, 40708);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_40790_40819(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 40790, 40819);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_40902_41114(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 40902, 41114);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_41178_41189(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 41178, 41189);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_41272_41484(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 41272, 41484);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_41548_41559(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 41548, 41559);
                return return_v;
            }

        }
        public static class TypeForwarders
        {
            public static class TypeForwarder
            {
                private static readonly Lazy<PortableExecutableReference> s_typeForwarder2;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 42084, 42109);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 42087, 42109);
                            return f_25120_42087_42109(s_typeForwarder2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 42084, 42109);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 42084, 42109);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 42084, 42109);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static TypeForwarder()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 41642, 42125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 41766, 42019);
                    s_typeForwarder2 = f_25120_41785_42019(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.TypeForwarders.TypeForwarder).GetReference(display: "TypeForwarder.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 41642, 42125);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 41642, 42125);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_41785_42019(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 41785, 42019);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_42087_42109(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 42087, 42109);
                    return return_v;
                }

            }
            public static class TypeForwarderLib
            {
                private static readonly Lazy<PortableExecutableReference> s_typeForwarderLib2;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 42595, 42623);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 42598, 42623);
                            return f_25120_42598_42623(s_typeForwarderLib2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 42595, 42623);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 42595, 42623);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 42595, 42623);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static TypeForwarderLib()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 42141, 42639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 42268, 42530);
                    s_typeForwarderLib2 = f_25120_42290_42530(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.TypeForwarders.TypeForwarderLib).GetReference(display: "TypeForwarderLib.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 42141, 42639);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 42141, 42639);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_42290_42530(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 42290, 42530);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_42598_42623(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 42598, 42623);
                    return return_v;
                }

            }
            public static class TypeForwarderBase
            {
                private static readonly Lazy<PortableExecutableReference> s_typeForwarderBase2;

                public static PortableExecutableReference dll
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 43113, 43142);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 43116, 43142);
                            return f_25120_43116_43142(s_typeForwarderBase2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 43113, 43142);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 43113, 43142);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 43113, 43142);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static TypeForwarderBase()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 42655, 43158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 42783, 43048);
                    s_typeForwarderBase2 = f_25120_42806_43048(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.TypeForwarders.TypeForwarderBase).GetReference(display: "TypeForwarderBase.Dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 42655, 43158);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 42655, 43158);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_42806_43048(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 42806, 43048);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_43116_43142(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 43116, 43142);
                    return return_v;
                }

            }

            static TypeForwarders()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 41583, 43169);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 41583, 43169);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 41583, 43169);
            }

        }
        public static class MultiTargeting
        {
            private static readonly Lazy<PortableExecutableReference> s_source1Module;

            public static PortableExecutableReference Source1Module
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 43625, 43649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 43628, 43649);
                        return f_25120_43628_43649(s_source1Module); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 43625, 43649);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 43625, 43649);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 43625, 43649);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_source3Module;

            public static PortableExecutableReference Source3Module
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 44051, 44075);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 44054, 44075);
                        return f_25120_44054_44075(s_source3Module); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 44051, 44075);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 44051, 44075);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 44051, 44075);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_source4Module;

            public static PortableExecutableReference Source4Module
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 44477, 44501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 44480, 44501);
                        return f_25120_44480_44501(s_source4Module); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 44477, 44501);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 44477, 44501);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 44477, 44501);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_source5Module;

            public static PortableExecutableReference Source5Module
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 44903, 44927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 44906, 44927);
                        return f_25120_44906_44927(s_source5Module); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 44903, 44927);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 44903, 44927);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 44903, 44927);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_source7Module;

            public static PortableExecutableReference Source7Module
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 45329, 45353);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 45332, 45353);
                        return f_25120_45332_45353(s_source7Module); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 45329, 45353);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 45329, 45353);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 45329, 45353);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static MultiTargeting()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 43181, 45365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 43298, 43554);
                s_source1Module = f_25120_43316_43554(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.MultiTargeting.Source1Module).GetReference(display: "Source1Module.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 43724, 43980);
                s_source3Module = f_25120_43742_43980(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.MultiTargeting.Source3Module).GetReference(display: "Source3Module.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 44150, 44406);
                s_source4Module = f_25120_44168_44406(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.MultiTargeting.Source4Module).GetReference(display: "Source4Module.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 44576, 44832);
                s_source5Module = f_25120_44594_44832(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.MultiTargeting.Source5Module).GetReference(display: "Source5Module.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 45002, 45258);
                s_source7Module = f_25120_45020_45258(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.MultiTargeting.Source7Module).GetReference(display: "Source7Module.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 43181, 45365);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 43181, 45365);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_43316_43554(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 43316, 43554);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_43628_43649(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 43628, 43649);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_43742_43980(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 43742, 43980);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_44054_44075(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 44054, 44075);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_44168_44406(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 44168, 44406);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_44480_44501(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 44480, 44501);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_44594_44832(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 44594, 44832);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_44906_44927(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 44906, 44927);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_45020_45258(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 45020, 45258);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_45332_45353(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 45332, 45353);
                return return_v;
            }

        }
        public static class NoPia
        {
            private static readonly Lazy<PortableExecutableReference> s_stdOle;

            public static PortableExecutableReference StdOle
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 45779, 45796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 45782, 45796);
                        return f_25120_45782_45796(s_stdOle); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 45779, 45796);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 45779, 45796);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 45779, 45796);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_pia1;

            public static PortableExecutableReference Pia1
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 46149, 46164);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 46152, 46164);
                        return f_25120_46152_46164(s_pia1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 46149, 46164);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 46149, 46164);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 46149, 46164);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_pia1Copy;

            public static PortableExecutableReference Pia1Copy
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 46533, 46552);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 46536, 46552);
                        return f_25120_46536_46552(s_pia1Copy); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 46533, 46552);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 46533, 46552);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 46533, 46552);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_pia2;

            public static PortableExecutableReference Pia2
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 46905, 46920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 46908, 46920);
                        return f_25120_46908_46920(s_pia2); 
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 46905, 46920);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 46905, 46920);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 46905, 46920);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_pia3;

            public static PortableExecutableReference Pia3
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 47273, 47288);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 47276, 47288);
                        return f_25120_47276_47288(s_pia3); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 47273, 47288);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 47273, 47288);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 47273, 47288);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_pia4;

            public static PortableExecutableReference Pia4
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 47641, 47656);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 47644, 47656);
                        return f_25120_47644_47656(s_pia4); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 47641, 47656);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 47641, 47656);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 47641, 47656);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_pia5;

            public static PortableExecutableReference Pia5
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 48009, 48024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 48012, 48024);
                        return f_25120_48012_48024(s_pia5); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 48009, 48024);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 48009, 48024);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 48009, 48024);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_generalPia;

            public static PortableExecutableReference GeneralPia
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 48401, 48422);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 48404, 48422);
                        return f_25120_48404_48422(s_generalPia); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 48401, 48422);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 48401, 48422);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 48401, 48422);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_generalPiaCopy;

            public static PortableExecutableReference GeneralPiaCopy
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 48815, 48840);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 48818, 48840);
                        return f_25120_48818_48840(s_generalPiaCopy); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 48815, 48840);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 48815, 48840);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 48815, 48840);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_noPIAGenericsAsm1;

            public static PortableExecutableReference NoPIAGenericsAsm1
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 49249, 49277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 49252, 49277);
                        return f_25120_49252_49277(s_noPIAGenericsAsm1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 49249, 49277);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 49249, 49277);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 49249, 49277);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_externalAsm1;

            public static PortableExecutableReference ExternalAsm1
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 49662, 49685);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 49665, 49685);
                        return f_25120_49665_49685(s_externalAsm1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 49662, 49685);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 49662, 49685);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 49662, 49685);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_library1;

            public static PortableExecutableReference Library1
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 50054, 50073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 50057, 50073);
                        return f_25120_50057_50073(s_library1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 50054, 50073);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 50054, 50073);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 50054, 50073);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_library2;

            public static PortableExecutableReference Library2
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 50442, 50461);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 50445, 50461);
                        return f_25120_50445_50461(s_library2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 50442, 50461);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 50442, 50461);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 50442, 50461);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_localTypes1;

            public static PortableExecutableReference LocalTypes1
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 50842, 50864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 50845, 50864);
                        return f_25120_50845_50864(s_localTypes1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 50842, 50864);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 50842, 50864);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 50842, 50864);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_localTypes2;

            public static PortableExecutableReference LocalTypes2
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 51245, 51267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 51248, 51267);
                        return f_25120_51248_51267(s_localTypes2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 51245, 51267);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 51245, 51267);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 51245, 51267);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_localTypes3;

            public static PortableExecutableReference LocalTypes3
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 51648, 51670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 51651, 51670);
                        return f_25120_51651_51670(s_localTypes3); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 51648, 51670);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 51648, 51670);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 51648, 51670);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_A;

            public static PortableExecutableReference A
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 52011, 52023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 52014, 52023);
                        return f_25120_52014_52023(s_A); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 52011, 52023);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 52011, 52023);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 52011, 52023);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_B;

            public static PortableExecutableReference B
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 52364, 52376);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 52367, 52376);
                        return f_25120_52367_52376(s_B); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 52364, 52376);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 52364, 52376);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 52364, 52376);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_C;

            public static PortableExecutableReference C
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 52717, 52729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 52720, 52729);
                        return f_25120_52720_52729(s_C); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 52717, 52729);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 52717, 52729);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 52717, 52729);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_D;

            public static PortableExecutableReference D
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 53070, 53082);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 53073, 53082);
                        return f_25120_53073_53082(s_D); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 53070, 53082);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 53070, 53082);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 53070, 53082);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
            public static class Microsoft
            {
                public static class VisualStudio
                {
                    private static readonly Lazy<PortableExecutableReference> s_missingPIAAttributes;

                    public static PortableExecutableReference MissingPIAAttributes
                    {
                        get
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 53644, 53675);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 53647, 53675);
                                return f_25120_53647_53675(s_missingPIAAttributes); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 53644, 53675);
                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 53644, 53675);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 53644, 53675);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                    }

                    static VisualStudio()
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 53161, 53695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 53292, 53558);
                        s_missingPIAAttributes = f_25120_53317_53558(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.MissingPIAAttributes).GetReference(display: "MicrosoftPIAAttributes.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 53161, 53695);

                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 53161, 53695);
                    }


                    static System.Lazy<PortableExecutableReference>
                    f_25120_53317_53558(System.Func<PortableExecutableReference>
                    valueFactory, System.Threading.LazyThreadSafetyMode
                    mode)
                    {
                        var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 53317, 53558);
                        return return_v;
                    }


                    static PortableExecutableReference
                    f_25120_53647_53675(System.Lazy<PortableExecutableReference>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 53647, 53675);
                        return return_v;
                    }

                }

                static Microsoft()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 53099, 53710);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 53099, 53710);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 53099, 53710);
                }

            }

            static NoPia()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 45377, 53721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 45485, 45715);
                s_stdOle = f_25120_45496_45715(() => AssemblyMetadata.CreateFromImage(ProprietaryTestResources.ProprietaryPias.stdole).GetReference(display: "stdole.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 45871, 46087);
                s_pia1 = f_25120_45880_46087(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.Pia1).GetReference(display: "Pia1.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 46239, 46467);
                s_pia1Copy = f_25120_46252_46467(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.Pia1Copy).GetReference(display: "Pia1Copy.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 46627, 46843);
                s_pia2 = f_25120_46636_46843(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.Pia2).GetReference(display: "Pia2.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 46995, 47211);
                s_pia3 = f_25120_47004_47211(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.Pia3).GetReference(display: "Pia3.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 47363, 47579);
                s_pia4 = f_25120_47372_47579(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.Pia4).GetReference(display: "Pia4.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 47731, 47947);
                s_pia5 = f_25120_47740_47947(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.Pia5).GetReference(display: "Pia5.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 48099, 48333);
                s_generalPia = f_25120_48114_48333(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.GeneralPia).GetReference(display: "GeneralPia.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 48497, 48743);
                s_generalPiaCopy = f_25120_48516_48743(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.GeneralPiaCopy).GetReference(display: "GeneralPiaCopy.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 48915, 49174);
                s_noPIAGenericsAsm1 = f_25120_48937_49174(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.NoPIAGenerics1_Asm1).GetReference(display: "NoPIAGenerics1-Asm1.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 49352, 49592);
                s_externalAsm1 = f_25120_49369_49592(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.ExternalAsm1).GetReference(display: "ExternalAsm1.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 49760, 49988);
                s_library1 = f_25120_49773_49988(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.Library1).GetReference(display: "Library1.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 50148, 50376);
                s_library2 = f_25120_50161_50376(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.Library2).GetReference(display: "Library2.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 50536, 50773);
                s_localTypes1 = f_25120_50552_50773(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.LocalTypes1).GetReference(display: "LocalTypes1.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 50939, 51176);
                s_localTypes2 = f_25120_50955_51176(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.LocalTypes2).GetReference(display: "LocalTypes2.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 51342, 51579);
                s_localTypes3 = f_25120_51358_51579(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.LocalTypes3).GetReference(display: "LocalTypes3.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 51745, 51952);
                s_A = f_25120_51751_51952(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.A).GetReference(display: "A.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 52098, 52305);
                s_B = f_25120_52104_52305(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.B).GetReference(display: "B.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 52451, 52658);
                s_C = f_25120_52457_52658(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.C).GetReference(display: "C.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 52804, 53011);
                s_D = f_25120_52810_53011(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.NoPia.D).GetReference(display: "D.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 45377, 53721);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 45377, 53721);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_45496_45715(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 45496, 45715);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_45782_45796(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 45782, 45796);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_45880_46087(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 45880, 46087);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_46152_46164(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 46152, 46164);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_46252_46467(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 46252, 46467);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_46536_46552(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 46536, 46552);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_46636_46843(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 46636, 46843);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_46908_46920(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 46908, 46920);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_47004_47211(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 47004, 47211);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_47276_47288(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 47276, 47288);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_47372_47579(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 47372, 47579);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_47644_47656(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 47644, 47656);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_47740_47947(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 47740, 47947);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_48012_48024(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 48012, 48024);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_48114_48333(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 48114, 48333);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_48404_48422(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 48404, 48422);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_48516_48743(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 48516, 48743);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_48818_48840(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 48818, 48840);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_48937_49174(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 48937, 49174);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_49252_49277(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 49252, 49277);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_49369_49592(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 49369, 49592);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_49665_49685(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 49665, 49685);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_49773_49988(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 49773, 49988);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_50057_50073(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 50057, 50073);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_50161_50376(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 50161, 50376);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_50445_50461(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 50445, 50461);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_50552_50773(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 50552, 50773);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_50845_50864(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 50845, 50864);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_50955_51176(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 50955, 51176);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_51248_51267(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 51248, 51267);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_51358_51579(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 51358, 51579);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_51651_51670(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 51651, 51670);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_51751_51952(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 51751, 51952);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_52014_52023(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 52014, 52023);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_52104_52305(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 52104, 52305);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_52367_52376(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 52367, 52376);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_52457_52658(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 52457, 52658);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_52720_52729(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 52720, 52729);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_52810_53011(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 52810, 53011);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_53073_53082(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 53073, 53082);
                return return_v;
            }

        }
        public static class Interface
        {
            private static readonly Lazy<PortableExecutableReference> s_staticMethodInInterface;

            public static PortableExecutableReference StaticMethodInInterface
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 54203, 54237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 54206, 54237);
                        return f_25120_54206_54237(s_staticMethodInInterface); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 54203, 54237);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 54203, 54237);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 54203, 54237);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_MDInterfaceMapping;

            public static PortableExecutableReference MDInterfaceMapping
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 54650, 54679);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 54653, 54679);
                        return f_25120_54653_54679(s_MDInterfaceMapping); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 54650, 54679);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 54650, 54679);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 54650, 54679);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static Interface()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 53733, 54691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 53845, 54122);
                s_staticMethodInInterface = f_25120_53873_54122(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Interface.StaticMethodInInterface).GetReference(display: "StaticMethodInInterface.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 54312, 54574);
                s_MDInterfaceMapping = f_25120_54335_54574(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Interface.MDInterfaceMapping).GetReference(display: "MDInterfaceMapping.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 53733, 54691);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 53733, 54691);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_53873_54122(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 53873, 54122);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_54206_54237(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 54206, 54237);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_54335_54574(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 54335, 54574);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_54653_54679(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 54653, 54679);
                return return_v;
            }

        }
        public static class MetadataCache
        {
            private static readonly Lazy<PortableExecutableReference> s_MDTestLib1;

            public static PortableExecutableReference MDTestLib1
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 55110, 55131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 55113, 55131);
                        return f_25120_55113_55131(s_MDTestLib1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 55110, 55131);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 55110, 55131);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 55110, 55131);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_netModule1;

            public static PortableExecutableReference netModule1
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 55516, 55537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 55519, 55537);
                        return f_25120_55519_55537(s_netModule1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 55516, 55537);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 55516, 55537);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 55516, 55537);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static MetadataCache()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 54703, 55549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 54819, 55042);
                s_MDTestLib1 = f_25120_54834_55042(() => AssemblyMetadata.CreateFromImage(TestResources.General.MDTestLib1).GetReference(display: "MDTestLib1.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 55206, 55448);
                s_netModule1 = f_25120_55221_55448(() => ModuleMetadata.CreateFromImage(TestResources.SymbolsTests.netModule.netModule1).GetReference(display: "netModule1.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 54703, 55549);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 54703, 55549);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_54834_55042(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 54834, 55042);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_55113_55131(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 55113, 55131);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_55221_55448(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 55221, 55448);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_55519_55537(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 55519, 55537);
                return return_v;
            }

        }
        public static class ExplicitInterfaceImplementation
        {
            public static class Methods
            {
                private static readonly Lazy<PortableExecutableReference> s_CSharp;

                public static PortableExecutableReference CSharp
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 56096, 56113);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 56099, 56113);
                            return f_25120_56099_56113(s_CSharp); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 56096, 56113);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 56096, 56113);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 56096, 56113);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                private static readonly Lazy<PortableExecutableReference> s_IL;

                public static PortableExecutableReference IL
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 56517, 56530);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 56520, 56530);
                            return f_25120_56520_56530(s_IL); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 56517, 56530);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 56517, 56530);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 56517, 56530);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static PortableExecutableReference
                f_25120_56099_56113(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 56099, 56113);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_56520_56530(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 56520, 56530);
                    return return_v;
                }

            }
            public static class Properties
            {
                private static readonly Lazy<PortableExecutableReference> s_CSharp;

                public static PortableExecutableReference CSharp
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 57044, 57061);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 57047, 57061);
                            return f_25120_57047_57061(s_CSharp); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 57044, 57061);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 57044, 57061);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 57044, 57061);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                private static readonly Lazy<PortableExecutableReference> s_IL;

                public static PortableExecutableReference IL
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 57485, 57498);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 57488, 57498);
                            return f_25120_57488_57498(s_IL); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 57485, 57498);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 57485, 57498);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 57485, 57498);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static Properties()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 56562, 57514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 56683, 56976);
                    s_CSharp = f_25120_56694_56976(() => AssemblyMetadata.CreateFromImage(TestResources.General.CSharpExplicitInterfaceImplementationProperties).GetReference(display: "CSharpExplicitInterfaceImplementationProperties.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 57140, 57421);
                    s_IL = f_25120_57147_57421(() => AssemblyMetadata.CreateFromImage(TestResources.General.ILExplicitInterfaceImplementationProperties).GetReference(display: "ILExplicitInterfaceImplementationProperties.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 56562, 57514);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 56562, 57514);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_56694_56976(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 56694, 56976);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_57047_57061(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 57047, 57061);
                    return return_v;
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_57147_57421(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 57147, 57421);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_57488_57498(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 57488, 57498);
                    return return_v;
                }

            }
            public static class Events
            {
                private static readonly Lazy<PortableExecutableReference> s_CSharp;

                public static PortableExecutableReference CSharp
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 58000, 58017);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 58003, 58017);
                            return f_25120_58003_58017(s_CSharp); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 58000, 58017);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 58000, 58017);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 58000, 58017);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static Events()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 57530, 58033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 57647, 57932);
                    s_CSharp = f_25120_57658_57932(() => AssemblyMetadata.CreateFromImage(TestResources.General.CSharpExplicitInterfaceImplementationEvents).GetReference(display: "CSharpExplicitInterfaceImplementationEvents.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 57530, 58033);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 57530, 58033);
                }


                static System.Lazy<PortableExecutableReference>
                f_25120_57658_57932(System.Func<PortableExecutableReference>
                valueFactory, System.Threading.LazyThreadSafetyMode
                mode)
                {
                    var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 57658, 57932);
                    return return_v;
                }


                static PortableExecutableReference
                f_25120_58003_58017(System.Lazy<PortableExecutableReference>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 58003, 58017);
                    return return_v;
                }

            }

            static ExplicitInterfaceImplementation()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 55561, 58044);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 55561, 58044);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 55561, 58044);
            }

        }

        private static readonly Lazy<PortableExecutableReference> s_regress40025;

        public static PortableExecutableReference Regress40025
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 58415, 58438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 58418, 58438);
                    return f_25120_58418_58438(s_regress40025); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 58415, 58438);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 58415, 58438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 58415, 58438);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        public static class WithEvents
        {
            private static readonly Lazy<PortableExecutableReference> s_simpleWithEvents;

            public static PortableExecutableReference SimpleWithEvents
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 58895, 58922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 58898, 58922);
                        return f_25120_58898_58922(s_simpleWithEvents); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 58895, 58922);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 58895, 58922);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 58895, 58922);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static WithEvents()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 58451, 58934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 58564, 58821);
                s_simpleWithEvents = f_25120_58585_58821(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.WithEvents.SimpleWithEvents).GetReference(display: "SimpleWithEvents.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 58451, 58934);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 58451, 58934);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_58585_58821(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 58585, 58821);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_58898_58922(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 58898, 58922);
                return return_v;
            }

        }
        public static class DelegateImplementation
        {
            private static readonly Lazy<PortableExecutableReference> s_delegatesWithoutInvoke;

            public static PortableExecutableReference DelegatesWithoutInvoke
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 59410, 59443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 59413, 59443);
                        return f_25120_59413_59443(s_delegatesWithoutInvoke); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 59410, 59443);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 59410, 59443);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 59410, 59443);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_delegateByRefParamArray;

            public static PortableExecutableReference DelegateByRefParamArray
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 59861, 59895);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 59864, 59895);
                        return f_25120_59864_59895(s_delegateByRefParamArray); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 59861, 59895);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 59861, 59895);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 59861, 59895);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static DelegateImplementation()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 58946, 59907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 59071, 59330);
                s_delegatesWithoutInvoke = f_25120_59098_59330(() => AssemblyMetadata.CreateFromImage(TestResources.General.DelegatesWithoutInvoke).GetReference(display: "DelegatesWithoutInvoke.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 59518, 59780);
                s_delegateByRefParamArray = f_25120_59546_59780(() => AssemblyMetadata.CreateFromImage(TestResources.General.DelegateByRefParamArray).GetReference(display: "DelegateByRefParamArray.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 58946, 59907);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 58946, 59907);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_59098_59330(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 59098, 59330);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_59413_59443(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 59413, 59443);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_59546_59780(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 59546, 59780);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_59864_59895(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 59864, 59895);
                return return_v;
            }

        }
        public static class Metadata
        {
            private static readonly Lazy<PortableExecutableReference> s_invalidCharactersInAssemblyName2;

            public static PortableExecutableReference InvalidCharactersInAssemblyName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 60420, 60463);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 60423, 60463);
                        return f_25120_60423_60463(s_invalidCharactersInAssemblyName2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 60420, 60463);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 60420, 60463);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 60420, 60463);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_MDTestAttributeDefLib;

            public static PortableExecutableReference MDTestAttributeDefLib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 60887, 60919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 60890, 60919);
                        return f_25120_60890_60919(s_MDTestAttributeDefLib); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 60887, 60919);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 60887, 60919);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 60887, 60919);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_MDTestAttributeApplicationLib;

            public static PortableExecutableReference MDTestAttributeApplicationLib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 61375, 61415);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 61378, 61415);
                        return f_25120_61378_61415(s_MDTestAttributeApplicationLib); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 61375, 61415);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 61375, 61415);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 61375, 61415);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_attributeInterop01;

            public static PortableExecutableReference AttributeInterop01
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 61827, 61856);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 61830, 61856);
                        return f_25120_61830_61856(s_attributeInterop01); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 61827, 61856);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 61827, 61856);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 61827, 61856);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_attributeInterop02;

            public static PortableExecutableReference AttributeInterop02
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 62268, 62297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 62271, 62297);
                        return f_25120_62271_62297(s_attributeInterop02); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 62268, 62297);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 62268, 62297);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 62268, 62297);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_attributeTestLib01;

            public static PortableExecutableReference AttributeTestLib01
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 62709, 62738);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 62712, 62738);
                        return f_25120_62712_62738(s_attributeTestLib01); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 62709, 62738);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 62709, 62738);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 62709, 62738);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_attributeTestDef01;

            public static PortableExecutableReference AttributeTestDef01
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 63150, 63179);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 63153, 63179);
                        return f_25120_63153_63179(s_attributeTestDef01); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 63150, 63179);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 63150, 63179);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 63150, 63179);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_dynamicAttributeLib;

            public static PortableExecutableReference DynamicAttributeLib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 63589, 63619);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 63592, 63619);
                        return f_25120_63592_63619(s_dynamicAttributeLib); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 63589, 63619);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 63589, 63619);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 63589, 63619);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static Metadata()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 59919, 63631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 60030, 60331);
                s_invalidCharactersInAssemblyName2 = f_25120_60067_60331(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Metadata.InvalidCharactersInAssemblyName).GetReference(display: "InvalidCharactersInAssemblyName.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 60538, 60808);
                s_MDTestAttributeDefLib = f_25120_60564_60808(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Metadata.MDTestAttributeDefLib).GetReference(display: "MDTestAttributeDefLib.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 60994, 61288);
                s_MDTestAttributeApplicationLib = f_25120_61028_61288(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Metadata.MDTestAttributeApplicationLib).GetReference(display: "MDTestAttributeApplicationLib.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 61490, 61751);
                s_attributeInterop01 = f_25120_61513_61751(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Metadata.AttributeInterop01).GetReference(display: "AttributeInterop01.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 61931, 62192);
                s_attributeInterop02 = f_25120_61954_62192(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Metadata.AttributeInterop02).GetReference(display: "AttributeInterop02.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 62372, 62633);
                s_attributeTestLib01 = f_25120_62395_62633(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Metadata.AttributeTestLib01).GetReference(display: "AttributeTestLib01.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 62813, 63074);
                s_attributeTestDef01 = f_25120_62836_63074(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Metadata.AttributeTestDef01).GetReference(display: "AttributeTestDef01.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 63254, 63512);
                s_dynamicAttributeLib = f_25120_63278_63512(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.Metadata.DynamicAttribute).GetReference(display: "DynamicAttribute.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 59919, 63631);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 59919, 63631);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_60067_60331(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 60067, 60331);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_60423_60463(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 60423, 60463);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_60564_60808(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 60564, 60808);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_60890_60919(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 60890, 60919);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_61028_61288(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 61028, 61288);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_61378_61415(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 61378, 61415);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_61513_61751(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 61513, 61751);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_61830_61856(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 61830, 61856);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_61954_62192(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 61954, 62192);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_62271_62297(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 62271, 62297);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_62395_62633(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 62395, 62633);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_62712_62738(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 62712, 62738);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_62836_63074(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 62836, 63074);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_63153_63179(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 63153, 63179);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_63278_63512(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 63278, 63512);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_63592_63619(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 63592, 63619);
                return return_v;
            }

        }
        public static class UseSiteErrors
        {
            private static readonly Lazy<PortableExecutableReference> s_unavailable;

            public static PortableExecutableReference Unavailable
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 64054, 64076);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 64057, 64076);
                        return f_25120_64057_64076(s_unavailable); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 64054, 64076);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 64054, 64076);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 64054, 64076);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_CSharp;

            public static PortableExecutableReference CSharp
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 64438, 64455);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 64441, 64455);
                        return f_25120_64441_64455(s_CSharp); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 64438, 64455);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 64438, 64455);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 64438, 64455);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_IL;

            public static PortableExecutableReference IL
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 64801, 64814);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 64804, 64814);
                        return f_25120_64804_64814(s_IL); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 64801, 64814);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 64801, 64814);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 64801, 64814);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static UseSiteErrors()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 63643, 64826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 63759, 63985);
                s_unavailable = f_25120_63775_63985(() => AssemblyMetadata.CreateFromImage(TestResources.General.Unavailable).GetReference(display: "Unavailable.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 64151, 64374);
                s_CSharp = f_25120_64162_64374(() => AssemblyMetadata.CreateFromImage(TestResources.General.CSharpErrors).GetReference(display: "CSharpErrors.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 64530, 64741);
                s_IL = f_25120_64537_64741(() => AssemblyMetadata.CreateFromImage(TestResources.General.ILErrors).GetReference(display: "ILErrors.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 63643, 64826);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 63643, 64826);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_63775_63985(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 63775, 63985);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_64057_64076(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 64057, 64076);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_64162_64374(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 64162, 64374);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_64441_64455(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 64441, 64455);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_64537_64741(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 64537, 64741);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_64804_64814(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 64804, 64814);
                return return_v;
            }

        }
        public static class Versioning
        {
            private static readonly Lazy<PortableExecutableReference> s_AR_SA;

            public static PortableExecutableReference AR_SA
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 65226, 65242);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 65229, 65242);
                        return f_25120_65229_65242(s_AR_SA); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 65226, 65242);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 65226, 65242);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 65226, 65242);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_EN_US;

            public static PortableExecutableReference EN_US
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 65592, 65608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 65595, 65608);
                        return f_25120_65595_65608(s_EN_US); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 65592, 65608);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 65592, 65608);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 65592, 65608);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_C1;

            public static PortableExecutableReference C1
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 65938, 65951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 65941, 65951);
                        return f_25120_65941_65951(s_C1); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 65938, 65951);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 65938, 65951);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 65938, 65951);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static readonly Lazy<PortableExecutableReference> s_C2;

            public static PortableExecutableReference C2
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25120, 66281, 66294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 66284, 66294);
                        return f_25120_66284_66294(s_C2); DynAbs.Tracing.TraceSender.TraceExitMethod(25120, 66281, 66294);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25120, 66281, 66294);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 66281, 66294);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static Versioning()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 64838, 66306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 64951, 65163);
                s_AR_SA = f_25120_64961_65163(() => AssemblyMetadata.CreateFromImage(TestResources.General.Culture_AR_SA).GetReference(display: "AR-SA"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 65317, 65529);
                s_EN_US = f_25120_65327_65529(() => AssemblyMetadata.CreateFromImage(TestResources.General.Culture_EN_US).GetReference(display: "EN-US"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 65683, 65878);
                s_C1 = f_25120_65690_65878(() => AssemblyMetadata.CreateFromImage(TestResources.General.C1).GetReference(display: "C1"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 66026, 66221);
                s_C2 = f_25120_66033_66221(() => AssemblyMetadata.CreateFromImage(TestResources.General.C2).GetReference(display: "C2"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 64838, 66306);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 64838, 66306);
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_64961_65163(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 64961, 65163);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_65229_65242(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 65229, 65242);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_65327_65529(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 65327, 65529);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_65595_65608(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 65595, 65608);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_65690_65878(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 65690, 65878);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_65941_65951(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 65941, 65951);
                return return_v;
            }


            static System.Lazy<PortableExecutableReference>
            f_25120_66033_66221(System.Func<PortableExecutableReference>
            valueFactory, System.Threading.LazyThreadSafetyMode
            mode)
            {
                var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 66033, 66221);
                return return_v;
            }


            static PortableExecutableReference
            f_25120_66284_66294(System.Lazy<PortableExecutableReference>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 66284, 66294);
                return return_v;
            }

        }

        static SymbolsTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 10105, 66313);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 10212, 10435);
            s_mdTestLib1 = f_25120_10227_10435(() => AssemblyMetadata.CreateFromImage(TestResources.General.MDTestLib1).GetReference(display: "MDTestLib1.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 10591, 10814);
            s_mdTestLib2 = f_25120_10606_10814(() => AssemblyMetadata.CreateFromImage(TestResources.General.MDTestLib2).GetReference(display: "MDTestLib2.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 10970, 11202);
            s_VBConversions = f_25120_10988_11202(() => AssemblyMetadata.CreateFromImage(TestResources.General.VBConversions).GetReference(display: "VBConversions.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 11364, 11589);
            s_withSpaces = f_25120_11379_11589(() => AssemblyMetadata.CreateFromImage(TestResources.General.With_Spaces).GetReference(display: "With Spaces.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 11745, 11986);
            s_withSpacesModule = f_25120_11766_11986(() => ModuleMetadata.CreateFromImage(TestResources.General.With_SpacesModule).GetReference(display: "With Spaces.netmodule"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 12154, 12401);
            s_inheritIComparable = f_25120_12177_12401(() => AssemblyMetadata.CreateFromImage(TestResources.General.InheritIComparable).GetReference(display: "InheritIComparable.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 12573, 12796);
            s_bigVisitor = f_25120_12588_12796(() => AssemblyMetadata.CreateFromImage(TestResources.General.BigVisitor).GetReference(display: "BigVisitor.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 12952, 13175);
            s_properties = f_25120_12967_13175(() => AssemblyMetadata.CreateFromImage(TestResources.General.Properties).GetReference(display: "Properties.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 13331, 13581);
            s_propertiesWithByRef = f_25120_13355_13581(() => AssemblyMetadata.CreateFromImage(TestResources.General.PropertiesWithByRef).GetReference(display: "PropertiesWithByRef.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 13755, 13972);
            s_indexers = f_25120_13768_13972(() => AssemblyMetadata.CreateFromImage(TestResources.General.Indexers).GetReference(display: "Indexers.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 14124, 14335);
            s_events = f_25120_14135_14335(() => AssemblyMetadata.CreateFromImage(TestResources.General.Events).GetReference(display: "Events.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 33423, 33676);
            s_cycledStructs = f_25120_33441_33676(() => AssemblyMetadata.CreateFromImage(TestResources.SymbolsTests.CyclicStructure.cycledstructs).GetReference(display: "cycledstructs.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25120, 58114, 58349);
            s_regress40025 = f_25120_58131_58349(() => AssemblyMetadata.CreateFromImage(TestResources.General.Regress40025DLL).GetReference(display: "Regress40025DLL.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 10105, 66313);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 10105, 66313);
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_10227_10435(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 10227, 10435);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_10502_10520(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 10502, 10520);
            return return_v;
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_10606_10814(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 10606, 10814);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_10881_10899(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 10881, 10899);
            return return_v;
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_10988_11202(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 10988, 11202);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_11272_11293(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 11272, 11293);
            return return_v;
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_11379_11589(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 11379, 11589);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_11656_11674(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 11656, 11674);
            return return_v;
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_11766_11986(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 11766, 11986);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_12059_12083(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 12059, 12083);
            return return_v;
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_12177_12401(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 12177, 12401);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_12476_12502(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 12476, 12502);
            return return_v;
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_12588_12796(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 12588, 12796);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_12863_12881(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 12863, 12881);
            return return_v;
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_12967_13175(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 12967, 13175);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_13242_13260(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 13242, 13260);
            return return_v;
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_13355_13581(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 13355, 13581);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_13657_13684(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 13657, 13684);
            return return_v;
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_13768_13972(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 13768, 13972);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_14037_14053(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 14037, 14053);
            return return_v;
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_14135_14335(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 14135, 14335);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_14398_14412(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 14398, 14412);
            return return_v;
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_33441_33676(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 33441, 33676);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_33746_33767(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 33746, 33767);
            return return_v;
        }


        static System.Lazy<PortableExecutableReference>
        f_25120_58131_58349(System.Func<PortableExecutableReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<PortableExecutableReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25120, 58131, 58349);
            return return_v;
        }


        static PortableExecutableReference
        f_25120_58418_58438(System.Lazy<PortableExecutableReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25120, 58418, 58438);
            return return_v;
        }

    }

    static TestReferences()
    {
        DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25120, 408, 66316);
        DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25120, 408, 66316);

        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25120, 408, 66316);
    }

}
