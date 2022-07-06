// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// This is a generated file, please edit Generate.ps1 to change the contents

#nullable disable

using Microsoft.CodeAnalysis;

namespace Roslyn.Test.Utilities
{
    public static class TestMetadata
    {
        public static class ResourcesNet20
        {
            private static byte[] _mscorlib;

            public static byte[] mscorlib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 566, 640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 569, 640);
                        return f_25033_569_640(ref _mscorlib, "net20.mscorlib.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 566, 640);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 566, 640);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 566, 640);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _System;

            public static byte[] System
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 727, 797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 730, 797);
                        return f_25033_730_797(ref _System, "net20.System.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 727, 797);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 727, 797);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 727, 797);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _MicrosoftVisualBasic;

            public static byte[] MicrosoftVisualBasic
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 912, 1011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 915, 1011);
                        return f_25033_915_1011(ref _MicrosoftVisualBasic, "net20.Microsoft.VisualBasic.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 912, 1011);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 912, 1011);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 912, 1011);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ResourcesNet20()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 431, 1023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 512, 521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 677, 684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 834, 855);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 431, 1023);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 431, 1023);
            }


            static byte[]
            f_25033_569_640(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 569, 640);
                return return_v;
            }


            static byte[]
            f_25033_730_797(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 730, 797);
                return return_v;
            }


            static byte[]
            f_25033_915_1011(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 915, 1011);
                return return_v;
            }

        }
        public static class Net20
        {
            public static PortableExecutableReference mscorlib { get; }

            public static PortableExecutableReference System { get; }

            public static PortableExecutableReference MicrosoftVisualBasic { get; }

            static Net20()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 1033, 1651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 1083, 1249);
                mscorlib = f_25033_1145_1248(f_25033_1145_1202(f_25033_1178_1201()), display: "mscorlib.dll (net20)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 1263, 1423);
                System = f_25033_1323_1422(f_25033_1323_1378(f_25033_1356_1377()), display: "System.dll (net20)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 1437, 1640);
                MicrosoftVisualBasic = f_25033_1511_1639(f_25033_1511_1580(f_25033_1544_1579()), display: "Microsoft.VisualBasic.dll (net20)"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 1033, 1651);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 1033, 1651);
            }


            static byte[]
            f_25033_1178_1201()
            {
                var return_v = ResourcesNet20.mscorlib;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 1178, 1201);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_1145_1202(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 1145, 1202);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_1145_1248(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 1145, 1248);
                return return_v;
            }


            static byte[]
            f_25033_1356_1377()
            {
                var return_v = ResourcesNet20.System;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 1356, 1377);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_1323_1378(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 1323, 1378);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_1323_1422(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 1323, 1422);
                return return_v;
            }


            static byte[]
            f_25033_1544_1579()
            {
                var return_v = ResourcesNet20.MicrosoftVisualBasic;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 1544, 1579);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_1511_1580(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 1511, 1580);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_1511_1639(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 1511, 1639);
                return return_v;
            }

        }
        public static class ResourcesNet35
        {
            private static byte[] _SystemCore;

            public static byte[] SystemCore
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 1800, 1879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 1803, 1879);
                        return f_25033_1803_1879(ref _SystemCore, "net35.System.Core.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 1800, 1879);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 1800, 1879);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 1800, 1879);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ResourcesNet35()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 1661, 1891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 1742, 1753);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 1661, 1891);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 1661, 1891);
            }


            static byte[]
            f_25033_1803_1879(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 1803, 1879);
                return return_v;
            }

        }
        public static class Net35
        {
            public static PortableExecutableReference SystemCore { get; }

            static Net35()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 1901, 2135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 1951, 2124);
                SystemCore = f_25033_2015_2123(f_25033_2015_2074(f_25033_2048_2073()), display: "System.Core.dll (net35)"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 1901, 2135);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 1901, 2135);
            }


            static byte[]
            f_25033_2048_2073()
            {
                var return_v = ResourcesNet35.SystemCore;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 2048, 2073);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_2015_2074(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 2015, 2074);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_2015_2123(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 2015, 2123);
                return return_v;
            }

        }
        public static class ResourcesNet40
        {
            private static byte[] _mscorlib;

            public static byte[] mscorlib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 2280, 2354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 2283, 2354);
                        return f_25033_2283_2354(ref _mscorlib, "net40.mscorlib.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 2280, 2354);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 2280, 2354);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 2280, 2354);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _System;

            public static byte[] System
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 2441, 2511);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 2444, 2511);
                        return f_25033_2444_2511(ref _System, "net40.System.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 2441, 2511);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 2441, 2511);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 2441, 2511);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemCore;

            public static byte[] SystemCore
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 2606, 2685);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 2609, 2685);
                        return f_25033_2609_2685(ref _SystemCore, "net40.System.Core.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 2606, 2685);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 2606, 2685);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 2606, 2685);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemData;

            public static byte[] SystemData
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 2780, 2859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 2783, 2859);
                        return f_25033_2783_2859(ref _SystemData, "net40.System.Data.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 2780, 2859);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 2780, 2859);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 2780, 2859);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemXml;

            public static byte[] SystemXml
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 2952, 3029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 2955, 3029);
                        return f_25033_2955_3029(ref _SystemXml, "net40.System.Xml.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 2952, 3029);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 2952, 3029);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 2952, 3029);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemXmlLinq;

            public static byte[] SystemXmlLinq
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 3130, 3216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 3133, 3216);
                        return f_25033_3133_3216(ref _SystemXmlLinq, "net40.System.Xml.Linq.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 3130, 3216);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 3130, 3216);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 3130, 3216);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _MicrosoftVisualBasic;

            public static byte[] MicrosoftVisualBasic
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 3331, 3430);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 3334, 3430);
                        return f_25033_3334_3430(ref _MicrosoftVisualBasic, "net40.Microsoft.VisualBasic.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 3331, 3430);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 3331, 3430);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 3331, 3430);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _MicrosoftCSharp;

            public static byte[] MicrosoftCSharp
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 3535, 3624);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 3538, 3624);
                        return f_25033_3538_3624(ref _MicrosoftCSharp, "net40.Microsoft.CSharp.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 3535, 3624);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 3535, 3624);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 3535, 3624);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ResourcesNet40()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 2145, 3636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 2226, 2235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 2391, 2398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 2548, 2559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 2722, 2733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 2896, 2906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 3066, 3080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 3253, 3274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 3467, 3483);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 2145, 3636);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 2145, 3636);
            }


            static byte[]
            f_25033_2283_2354(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 2283, 2354);
                return return_v;
            }


            static byte[]
            f_25033_2444_2511(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 2444, 2511);
                return return_v;
            }


            static byte[]
            f_25033_2609_2685(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 2609, 2685);
                return return_v;
            }


            static byte[]
            f_25033_2783_2859(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 2783, 2859);
                return return_v;
            }


            static byte[]
            f_25033_2955_3029(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 2955, 3029);
                return return_v;
            }


            static byte[]
            f_25033_3133_3216(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 3133, 3216);
                return return_v;
            }


            static byte[]
            f_25033_3334_3430(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 3334, 3430);
                return return_v;
            }


            static byte[]
            f_25033_3538_3624(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 3538, 3624);
                return return_v;
            }

        }
        public static class Net40
        {
            public static PortableExecutableReference mscorlib { get; }

            public static PortableExecutableReference System { get; }

            public static PortableExecutableReference SystemCore { get; }

            public static PortableExecutableReference SystemData { get; }

            public static PortableExecutableReference SystemXml { get; }

            public static PortableExecutableReference SystemXmlLinq { get; }

            public static PortableExecutableReference MicrosoftVisualBasic { get; }

            public static PortableExecutableReference MicrosoftCSharp { get; }

            static Net40()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 3646, 5221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 3696, 3862);
                mscorlib = f_25033_3758_3861(f_25033_3758_3815(f_25033_3791_3814()), display: "mscorlib.dll (net40)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 3876, 4036);
                System = f_25033_3936_4035(f_25033_3936_3991(f_25033_3969_3990()), display: "System.dll (net40)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 4050, 4223);
                SystemCore = f_25033_4114_4222(f_25033_4114_4173(f_25033_4147_4172()), display: "System.Core.dll (net40)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 4237, 4410);
                SystemData = f_25033_4301_4409(f_25033_4301_4360(f_25033_4334_4359()), display: "System.Data.dll (net40)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 4424, 4594);
                SystemXml = f_25033_4487_4593(f_25033_4487_4545(f_25033_4520_4544()), display: "System.Xml.dll (net40)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 4608, 4791);
                SystemXmlLinq = f_25033_4675_4790(f_25033_4675_4737(f_25033_4708_4736()), display: "System.Xml.Linq.dll (net40)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 4805, 5008);
                MicrosoftVisualBasic = f_25033_4879_5007(f_25033_4879_4948(f_25033_4912_4947()), display: "Microsoft.VisualBasic.dll (net40)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 5022, 5210);
                MicrosoftCSharp = f_25033_5091_5209(f_25033_5091_5155(f_25033_5124_5154()), display: "Microsoft.CSharp.dll (net40)"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 3646, 5221);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 3646, 5221);
            }


            static byte[]
            f_25033_3791_3814()
            {
                var return_v = ResourcesNet40.mscorlib;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 3791, 3814);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_3758_3815(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 3758, 3815);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_3758_3861(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 3758, 3861);
                return return_v;
            }


            static byte[]
            f_25033_3969_3990()
            {
                var return_v = ResourcesNet40.System;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 3969, 3990);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_3936_3991(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 3936, 3991);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_3936_4035(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 3936, 4035);
                return return_v;
            }


            static byte[]
            f_25033_4147_4172()
            {
                var return_v = ResourcesNet40.SystemCore;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 4147, 4172);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_4114_4173(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 4114, 4173);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_4114_4222(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 4114, 4222);
                return return_v;
            }


            static byte[]
            f_25033_4334_4359()
            {
                var return_v = ResourcesNet40.SystemData;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 4334, 4359);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_4301_4360(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 4301, 4360);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_4301_4409(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 4301, 4409);
                return return_v;
            }


            static byte[]
            f_25033_4520_4544()
            {
                var return_v = ResourcesNet40.SystemXml;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 4520, 4544);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_4487_4545(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 4487, 4545);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_4487_4593(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 4487, 4593);
                return return_v;
            }


            static byte[]
            f_25033_4708_4736()
            {
                var return_v = ResourcesNet40.SystemXmlLinq;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 4708, 4736);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_4675_4737(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 4675, 4737);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_4675_4790(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 4675, 4790);
                return return_v;
            }


            static byte[]
            f_25033_4912_4947()
            {
                var return_v = ResourcesNet40.MicrosoftVisualBasic;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 4912, 4947);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_4879_4948(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 4879, 4948);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_4879_5007(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 4879, 5007);
                return return_v;
            }


            static byte[]
            f_25033_5124_5154()
            {
                var return_v = ResourcesNet40.MicrosoftCSharp;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 5124, 5154);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_5091_5155(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 5091, 5155);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_5091_5209(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 5091, 5209);
                return return_v;
            }

        }
        public static class ResourcesNet451
        {
            private static byte[] _mscorlib;

            public static byte[] mscorlib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 5367, 5442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 5370, 5442);
                        return f_25033_5370_5442(ref _mscorlib, "net451.mscorlib.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 5367, 5442);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 5367, 5442);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 5367, 5442);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _System;

            public static byte[] System
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 5529, 5600);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 5532, 5600);
                        return f_25033_5532_5600(ref _System, "net451.System.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 5529, 5600);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 5529, 5600);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 5529, 5600);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemConfiguration;

            public static byte[] SystemConfiguration
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 5713, 5811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 5716, 5811);
                        return f_25033_5716_5811(ref _SystemConfiguration, "net451.System.Configuration.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 5713, 5811);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 5713, 5811);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 5713, 5811);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemCore;

            public static byte[] SystemCore
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 5906, 5986);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 5909, 5986);
                        return f_25033_5909_5986(ref _SystemCore, "net451.System.Core.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 5906, 5986);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 5906, 5986);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 5906, 5986);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemData;

            public static byte[] SystemData
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 6081, 6161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 6084, 6161);
                        return f_25033_6084_6161(ref _SystemData, "net451.System.Data.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 6081, 6161);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 6081, 6161);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 6081, 6161);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemDrawing;

            public static byte[] SystemDrawing
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 6262, 6348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 6265, 6348);
                        return f_25033_6265_6348(ref _SystemDrawing, "net451.System.Drawing.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 6262, 6348);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 6262, 6348);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 6262, 6348);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemEnterpriseServices;

            public static byte[] SystemEnterpriseServices
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 6471, 6579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 6474, 6579);
                        return f_25033_6474_6579(ref _SystemEnterpriseServices, "net451.System.EnterpriseServices.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 6471, 6579);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 6471, 6579);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 6471, 6579);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemRuntimeSerialization;

            public static byte[] SystemRuntimeSerialization
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 6706, 6819);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 6709, 6819);
                        return f_25033_6709_6819(ref _SystemRuntimeSerialization, "net451.System.Runtime.Serialization.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 6706, 6819);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 6706, 6819);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 6706, 6819);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemWindowsForms;

            public static byte[] SystemWindowsForms
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 6930, 7027);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 6933, 7027);
                        return f_25033_6933_7027(ref _SystemWindowsForms, "net451.System.Windows.Forms.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 6930, 7027);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 6930, 7027);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 6930, 7027);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemWebServices;

            public static byte[] SystemWebServices
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 7136, 7231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 7139, 7231);
                        return f_25033_7139_7231(ref _SystemWebServices, "net451.System.Web.Services.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 7136, 7231);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 7136, 7231);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 7136, 7231);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemXml;

            public static byte[] SystemXml
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 7324, 7402);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 7327, 7402);
                        return f_25033_7327_7402(ref _SystemXml, "net451.System.Xml.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 7324, 7402);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 7324, 7402);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 7324, 7402);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemXmlLinq;

            public static byte[] SystemXmlLinq
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 7503, 7590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 7506, 7590);
                        return f_25033_7506_7590(ref _SystemXmlLinq, "net451.System.Xml.Linq.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 7503, 7590);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 7503, 7590);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 7503, 7590);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _MicrosoftCSharp;

            public static byte[] MicrosoftCSharp
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 7695, 7785);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 7698, 7785);
                        return f_25033_7698_7785(ref _MicrosoftCSharp, "net451.Microsoft.CSharp.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 7695, 7785);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 7695, 7785);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 7695, 7785);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _MicrosoftVisualBasic;

            public static byte[] MicrosoftVisualBasic
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 7900, 8000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 7903, 8000);
                        return f_25033_7903_8000(ref _MicrosoftVisualBasic, "net451.Microsoft.VisualBasic.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 7900, 8000);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 7900, 8000);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 7900, 8000);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemObjectModel;

            public static byte[] SystemObjectModel
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 8109, 8203);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 8112, 8203);
                        return f_25033_8112_8203(ref _SystemObjectModel, "net451.System.ObjectModel.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 8109, 8203);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 8109, 8203);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 8109, 8203);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemRuntime;

            public static byte[] SystemRuntime
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 8304, 8390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 8307, 8390);
                        return f_25033_8307_8390(ref _SystemRuntime, "net451.System.Runtime.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 8304, 8390);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 8304, 8390);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 8304, 8390);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemRuntimeInteropServicesWindowsRuntime;

            public static byte[] SystemRuntimeInteropServicesWindowsRuntime
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 8549, 8695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 8552, 8695);
                        return f_25033_8552_8695(ref _SystemRuntimeInteropServicesWindowsRuntime, "net451.System.Runtime.InteropServices.WindowsRuntime.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 8549, 8695);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 8549, 8695);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 8549, 8695);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemThreading;

            public static byte[] SystemThreading
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 8800, 8890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 8803, 8890);
                        return f_25033_8803_8890(ref _SystemThreading, "net451.System.Threading.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 8800, 8890);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 8800, 8890);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 8800, 8890);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemThreadingTasks;

            public static byte[] SystemThreadingTasks
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 9005, 9106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 9008, 9106);
                        return f_25033_9008_9106(ref _SystemThreadingTasks, "net451.System.Threading.Tasks.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 9005, 9106);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 9005, 9106);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 9005, 9106);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ResourcesNet451()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 5231, 9118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 5313, 5322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 5479, 5486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 5637, 5657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 5848, 5859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 6023, 6034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 6198, 6212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 6385, 6410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 6616, 6643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 6856, 6875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 7064, 7082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 7268, 7278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 7439, 7453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 7627, 7643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 7822, 7843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 8037, 8055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 8240, 8254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 8427, 8470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 8732, 8748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 8927, 8948);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 5231, 9118);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 5231, 9118);
            }


            static byte[]
            f_25033_5370_5442(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 5370, 5442);
                return return_v;
            }


            static byte[]
            f_25033_5532_5600(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 5532, 5600);
                return return_v;
            }


            static byte[]
            f_25033_5716_5811(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 5716, 5811);
                return return_v;
            }


            static byte[]
            f_25033_5909_5986(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 5909, 5986);
                return return_v;
            }


            static byte[]
            f_25033_6084_6161(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 6084, 6161);
                return return_v;
            }


            static byte[]
            f_25033_6265_6348(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 6265, 6348);
                return return_v;
            }


            static byte[]
            f_25033_6474_6579(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 6474, 6579);
                return return_v;
            }


            static byte[]
            f_25033_6709_6819(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 6709, 6819);
                return return_v;
            }


            static byte[]
            f_25033_6933_7027(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 6933, 7027);
                return return_v;
            }


            static byte[]
            f_25033_7139_7231(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 7139, 7231);
                return return_v;
            }


            static byte[]
            f_25033_7327_7402(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 7327, 7402);
                return return_v;
            }


            static byte[]
            f_25033_7506_7590(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 7506, 7590);
                return return_v;
            }


            static byte[]
            f_25033_7698_7785(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 7698, 7785);
                return return_v;
            }


            static byte[]
            f_25033_7903_8000(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 7903, 8000);
                return return_v;
            }


            static byte[]
            f_25033_8112_8203(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 8112, 8203);
                return return_v;
            }


            static byte[]
            f_25033_8307_8390(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 8307, 8390);
                return return_v;
            }


            static byte[]
            f_25033_8552_8695(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 8552, 8695);
                return return_v;
            }


            static byte[]
            f_25033_8803_8890(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 8803, 8890);
                return return_v;
            }


            static byte[]
            f_25033_9008_9106(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 9008, 9106);
                return return_v;
            }

        }
        public static class Net451
        {
            public static PortableExecutableReference mscorlib { get; }

            public static PortableExecutableReference System { get; }

            public static PortableExecutableReference SystemConfiguration { get; }

            public static PortableExecutableReference SystemCore { get; }

            public static PortableExecutableReference SystemData { get; }

            public static PortableExecutableReference SystemDrawing { get; }

            public static PortableExecutableReference SystemEnterpriseServices { get; }

            public static PortableExecutableReference SystemRuntimeSerialization { get; }

            public static PortableExecutableReference SystemWindowsForms { get; }

            public static PortableExecutableReference SystemWebServices { get; }

            public static PortableExecutableReference SystemXml { get; }

            public static PortableExecutableReference SystemXmlLinq { get; }

            public static PortableExecutableReference MicrosoftCSharp { get; }

            public static PortableExecutableReference MicrosoftVisualBasic { get; }

            public static PortableExecutableReference SystemObjectModel { get; }

            public static PortableExecutableReference SystemRuntime { get; }

            public static PortableExecutableReference SystemRuntimeInteropServicesWindowsRuntime { get; }

            public static PortableExecutableReference SystemThreading { get; }

            public static PortableExecutableReference SystemThreadingTasks { get; }

            static Net451()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 9128, 13147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 9179, 9347);
                mscorlib = f_25033_9241_9346(f_25033_9241_9299(f_25033_9274_9298()), display: "mscorlib.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 9361, 9523);
                System = f_25033_9421_9522(f_25033_9421_9477(f_25033_9454_9476()), display: "System.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 9537, 9739);
                SystemConfiguration = f_25033_9610_9738(f_25033_9610_9679(f_25033_9643_9678()), display: "System.Configuration.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 9753, 9928);
                SystemCore = f_25033_9817_9927(f_25033_9817_9877(f_25033_9850_9876()), display: "System.Core.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 9942, 10117);
                SystemData = f_25033_10006_10116(f_25033_10006_10066(f_25033_10039_10065()), display: "System.Data.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 10131, 10315);
                SystemDrawing = f_25033_10198_10314(f_25033_10198_10261(f_25033_10231_10260()), display: "System.Drawing.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 10329, 10546);
                SystemEnterpriseServices = f_25033_10407_10545(f_25033_10407_10481(f_25033_10440_10480()), display: "System.EnterpriseServices.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 10560, 10784);
                SystemRuntimeSerialization = f_25033_10640_10783(f_25033_10640_10716(f_25033_10673_10715()), display: "System.Runtime.Serialization.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 10798, 10998);
                SystemWindowsForms = f_25033_10870_10997(f_25033_10870_10938(f_25033_10903_10937()), display: "System.Windows.Forms.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 11012, 11209);
                SystemWebServices = f_25033_11083_11208(f_25033_11083_11150(f_25033_11116_11149()), display: "System.Web.Services.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 11223, 11395);
                SystemXml = f_25033_11286_11394(f_25033_11286_11345(f_25033_11319_11344()), display: "System.Xml.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 11409, 11594);
                SystemXmlLinq = f_25033_11476_11593(f_25033_11476_11539(f_25033_11509_11538()), display: "System.Xml.Linq.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 11608, 11798);
                MicrosoftCSharp = f_25033_11677_11797(f_25033_11677_11742(f_25033_11710_11741()), display: "Microsoft.CSharp.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 11812, 12017);
                MicrosoftVisualBasic = f_25033_11886_12016(f_25033_11886_11956(f_25033_11919_11955()), display: "Microsoft.VisualBasic.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 12031, 12227);
                SystemObjectModel = f_25033_12102_12226(f_25033_12102_12169(f_25033_12135_12168()), display: "System.ObjectModel.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 12241, 12425);
                SystemRuntime = f_25033_12308_12424(f_25033_12308_12371(f_25033_12341_12370()), display: "System.Runtime.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 12439, 12712);
                SystemRuntimeInteropServicesWindowsRuntime = f_25033_12535_12711(f_25033_12535_12627(f_25033_12568_12626()), display: "System.Runtime.InteropServices.WindowsRuntime.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 12726, 12916);
                SystemThreading = f_25033_12795_12915(f_25033_12795_12860(f_25033_12828_12859()), display: "System.Threading.dll (net451)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 12930, 13136);
                SystemThreadingTasks = f_25033_13004_13135(f_25033_13004_13074(f_25033_13037_13073()), display: "System.Threading.Tasks.dll (net451)"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 9128, 13147);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 9128, 13147);
            }


            static byte[]
            f_25033_9274_9298()
            {
                var return_v = ResourcesNet451.mscorlib;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 9274, 9298);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_9241_9299(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 9241, 9299);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_9241_9346(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 9241, 9346);
                return return_v;
            }


            static byte[]
            f_25033_9454_9476()
            {
                var return_v = ResourcesNet451.System;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 9454, 9476);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_9421_9477(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 9421, 9477);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_9421_9522(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 9421, 9522);
                return return_v;
            }


            static byte[]
            f_25033_9643_9678()
            {
                var return_v = ResourcesNet451.SystemConfiguration;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 9643, 9678);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_9610_9679(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 9610, 9679);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_9610_9738(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 9610, 9738);
                return return_v;
            }


            static byte[]
            f_25033_9850_9876()
            {
                var return_v = ResourcesNet451.SystemCore;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 9850, 9876);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_9817_9877(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 9817, 9877);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_9817_9927(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 9817, 9927);
                return return_v;
            }


            static byte[]
            f_25033_10039_10065()
            {
                var return_v = ResourcesNet451.SystemData;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 10039, 10065);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_10006_10066(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 10006, 10066);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_10006_10116(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 10006, 10116);
                return return_v;
            }


            static byte[]
            f_25033_10231_10260()
            {
                var return_v = ResourcesNet451.SystemDrawing;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 10231, 10260);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_10198_10261(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 10198, 10261);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_10198_10314(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 10198, 10314);
                return return_v;
            }


            static byte[]
            f_25033_10440_10480()
            {
                var return_v = ResourcesNet451.SystemEnterpriseServices;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 10440, 10480);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_10407_10481(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 10407, 10481);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_10407_10545(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 10407, 10545);
                return return_v;
            }


            static byte[]
            f_25033_10673_10715()
            {
                var return_v = ResourcesNet451.SystemRuntimeSerialization;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 10673, 10715);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_10640_10716(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 10640, 10716);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_10640_10783(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 10640, 10783);
                return return_v;
            }


            static byte[]
            f_25033_10903_10937()
            {
                var return_v = ResourcesNet451.SystemWindowsForms;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 10903, 10937);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_10870_10938(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 10870, 10938);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_10870_10997(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 10870, 10997);
                return return_v;
            }


            static byte[]
            f_25033_11116_11149()
            {
                var return_v = ResourcesNet451.SystemWebServices;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 11116, 11149);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_11083_11150(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 11083, 11150);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_11083_11208(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 11083, 11208);
                return return_v;
            }


            static byte[]
            f_25033_11319_11344()
            {
                var return_v = ResourcesNet451.SystemXml;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 11319, 11344);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_11286_11345(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 11286, 11345);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_11286_11394(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 11286, 11394);
                return return_v;
            }


            static byte[]
            f_25033_11509_11538()
            {
                var return_v = ResourcesNet451.SystemXmlLinq;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 11509, 11538);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_11476_11539(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 11476, 11539);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_11476_11593(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 11476, 11593);
                return return_v;
            }


            static byte[]
            f_25033_11710_11741()
            {
                var return_v = ResourcesNet451.MicrosoftCSharp;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 11710, 11741);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_11677_11742(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 11677, 11742);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_11677_11797(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 11677, 11797);
                return return_v;
            }


            static byte[]
            f_25033_11919_11955()
            {
                var return_v = ResourcesNet451.MicrosoftVisualBasic;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 11919, 11955);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_11886_11956(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 11886, 11956);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_11886_12016(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 11886, 12016);
                return return_v;
            }


            static byte[]
            f_25033_12135_12168()
            {
                var return_v = ResourcesNet451.SystemObjectModel;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 12135, 12168);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_12102_12169(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 12102, 12169);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_12102_12226(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 12102, 12226);
                return return_v;
            }


            static byte[]
            f_25033_12341_12370()
            {
                var return_v = ResourcesNet451.SystemRuntime;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 12341, 12370);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_12308_12371(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 12308, 12371);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_12308_12424(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 12308, 12424);
                return return_v;
            }


            static byte[]
            f_25033_12568_12626()
            {
                var return_v = ResourcesNet451.SystemRuntimeInteropServicesWindowsRuntime;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 12568, 12626);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_12535_12627(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 12535, 12627);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_12535_12711(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 12535, 12711);
                return return_v;
            }


            static byte[]
            f_25033_12828_12859()
            {
                var return_v = ResourcesNet451.SystemThreading;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 12828, 12859);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_12795_12860(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 12795, 12860);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_12795_12915(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 12795, 12915);
                return return_v;
            }


            static byte[]
            f_25033_13037_13073()
            {
                var return_v = ResourcesNet451.SystemThreadingTasks;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 13037, 13073);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_13004_13074(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 13004, 13074);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_13004_13135(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 13004, 13135);
                return return_v;
            }

        }
        public static class ResourcesNet461
        {
            private static byte[] _mscorlib;

            public static byte[] mscorlib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 13293, 13368);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 13296, 13368);
                        return f_25033_13296_13368(ref _mscorlib, "net461.mscorlib.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 13293, 13368);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 13293, 13368);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 13293, 13368);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _System;

            public static byte[] System
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 13455, 13526);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 13458, 13526);
                        return f_25033_13458_13526(ref _System, "net461.System.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 13455, 13526);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 13455, 13526);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 13455, 13526);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemCore;

            public static byte[] SystemCore
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 13621, 13701);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 13624, 13701);
                        return f_25033_13624_13701(ref _SystemCore, "net461.System.Core.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 13621, 13701);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 13621, 13701);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 13621, 13701);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemRuntime;

            public static byte[] SystemRuntime
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 13802, 13888);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 13805, 13888);
                        return f_25033_13805_13888(ref _SystemRuntime, "net461.System.Runtime.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 13802, 13888);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 13802, 13888);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 13802, 13888);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemThreadingTasks;

            public static byte[] SystemThreadingTasks
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 14003, 14104);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 14006, 14104);
                        return f_25033_14006_14104(ref _SystemThreadingTasks, "net461.System.Threading.Tasks.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 14003, 14104);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 14003, 14104);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 14003, 14104);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _MicrosoftCSharp;

            public static byte[] MicrosoftCSharp
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 14209, 14299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 14212, 14299);
                        return f_25033_14212_14299(ref _MicrosoftCSharp, "net461.Microsoft.CSharp.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 14209, 14299);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 14209, 14299);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 14209, 14299);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _MicrosoftVisualBasic;

            public static byte[] MicrosoftVisualBasic
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 14414, 14514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 14417, 14514);
                        return f_25033_14417_14514(ref _MicrosoftVisualBasic, "net461.Microsoft.VisualBasic.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 14414, 14514);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 14414, 14514);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 14414, 14514);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ResourcesNet461()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 13157, 14526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 13239, 13248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 13405, 13412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 13563, 13574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 13738, 13752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 13925, 13946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 14141, 14157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 14336, 14357);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 13157, 14526);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 13157, 14526);
            }


            static byte[]
            f_25033_13296_13368(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 13296, 13368);
                return return_v;
            }


            static byte[]
            f_25033_13458_13526(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 13458, 13526);
                return return_v;
            }


            static byte[]
            f_25033_13624_13701(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 13624, 13701);
                return return_v;
            }


            static byte[]
            f_25033_13805_13888(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 13805, 13888);
                return return_v;
            }


            static byte[]
            f_25033_14006_14104(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 14006, 14104);
                return return_v;
            }


            static byte[]
            f_25033_14212_14299(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 14212, 14299);
                return return_v;
            }


            static byte[]
            f_25033_14417_14514(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 14417, 14514);
                return return_v;
            }

        }
        public static class Net461
        {
            public static PortableExecutableReference mscorlib { get; }

            public static PortableExecutableReference System { get; }

            public static PortableExecutableReference SystemCore { get; }

            public static PortableExecutableReference SystemRuntime { get; }

            public static PortableExecutableReference SystemThreadingTasks { get; }

            public static PortableExecutableReference MicrosoftCSharp { get; }

            public static PortableExecutableReference MicrosoftVisualBasic { get; }

            static Net461()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 14536, 15972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 14587, 14755);
                mscorlib = f_25033_14649_14754(f_25033_14649_14707(f_25033_14682_14706()), display: "mscorlib.dll (net461)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 14769, 14931);
                System = f_25033_14829_14930(f_25033_14829_14885(f_25033_14862_14884()), display: "System.dll (net461)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 14945, 15120);
                SystemCore = f_25033_15009_15119(f_25033_15009_15069(f_25033_15042_15068()), display: "System.Core.dll (net461)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 15134, 15318);
                SystemRuntime = f_25033_15201_15317(f_25033_15201_15264(f_25033_15234_15263()), display: "System.Runtime.dll (net461)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 15332, 15538);
                SystemThreadingTasks = f_25033_15406_15537(f_25033_15406_15476(f_25033_15439_15475()), display: "System.Threading.Tasks.dll (net461)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 15552, 15742);
                MicrosoftCSharp = f_25033_15621_15741(f_25033_15621_15686(f_25033_15654_15685()), display: "Microsoft.CSharp.dll (net461)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 15756, 15961);
                MicrosoftVisualBasic = f_25033_15830_15960(f_25033_15830_15900(f_25033_15863_15899()), display: "Microsoft.VisualBasic.dll (net461)"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 14536, 15972);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 14536, 15972);
            }


            static byte[]
            f_25033_14682_14706()
            {
                var return_v = ResourcesNet461.mscorlib;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 14682, 14706);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_14649_14707(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 14649, 14707);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_14649_14754(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 14649, 14754);
                return return_v;
            }


            static byte[]
            f_25033_14862_14884()
            {
                var return_v = ResourcesNet461.System;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 14862, 14884);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_14829_14885(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 14829, 14885);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_14829_14930(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 14829, 14930);
                return return_v;
            }


            static byte[]
            f_25033_15042_15068()
            {
                var return_v = ResourcesNet461.SystemCore;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 15042, 15068);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_15009_15069(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 15009, 15069);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_15009_15119(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 15009, 15119);
                return return_v;
            }


            static byte[]
            f_25033_15234_15263()
            {
                var return_v = ResourcesNet461.SystemRuntime;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 15234, 15263);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_15201_15264(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 15201, 15264);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_15201_15317(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 15201, 15317);
                return return_v;
            }


            static byte[]
            f_25033_15439_15475()
            {
                var return_v = ResourcesNet461.SystemThreadingTasks;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 15439, 15475);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_15406_15476(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 15406, 15476);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_15406_15537(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 15406, 15537);
                return return_v;
            }


            static byte[]
            f_25033_15654_15685()
            {
                var return_v = ResourcesNet461.MicrosoftCSharp;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 15654, 15685);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_15621_15686(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 15621, 15686);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_15621_15741(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 15621, 15741);
                return return_v;
            }


            static byte[]
            f_25033_15863_15899()
            {
                var return_v = ResourcesNet461.MicrosoftVisualBasic;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 15863, 15899);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_15830_15900(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 15830, 15900);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_15830_15960(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 15830, 15960);
                return return_v;
            }

        }
        public static class ResourcesNetCoreApp
        {
            private static byte[] _mscorlib;

            public static byte[] mscorlib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 16122, 16201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 16125, 16201);
                        return f_25033_16125_16201(ref _mscorlib, "netcoreapp.mscorlib.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 16122, 16201);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 16122, 16201);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 16122, 16201);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _System;

            public static byte[] System
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 16288, 16363);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 16291, 16363);
                        return f_25033_16291_16363(ref _System, "netcoreapp.System.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 16288, 16363);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 16288, 16363);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 16288, 16363);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemCore;

            public static byte[] SystemCore
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 16458, 16542);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 16461, 16542);
                        return f_25033_16461_16542(ref _SystemCore, "netcoreapp.System.Core.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 16458, 16542);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 16458, 16542);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 16458, 16542);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemCollections;

            public static byte[] SystemCollections
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 16651, 16749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 16654, 16749);
                        return f_25033_16654_16749(ref _SystemCollections, "netcoreapp.System.Collections.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 16651, 16749);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 16651, 16749);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 16651, 16749);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemConsole;

            public static byte[] SystemConsole
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 16850, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 16853, 16940);
                        return f_25033_16853_16940(ref _SystemConsole, "netcoreapp.System.Console.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 16850, 16940);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 16850, 16940);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 16850, 16940);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemLinq;

            public static byte[] SystemLinq
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 17035, 17119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 17038, 17119);
                        return f_25033_17038_17119(ref _SystemLinq, "netcoreapp.System.Linq.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 17035, 17119);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 17035, 17119);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 17035, 17119);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemLinqExpressions;

            public static byte[] SystemLinqExpressions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 17236, 17343);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 17239, 17343);
                        return f_25033_17239_17343(ref _SystemLinqExpressions, "netcoreapp.System.Linq.Expressions.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 17236, 17343);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 17236, 17343);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 17236, 17343);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemRuntime;

            public static byte[] SystemRuntime
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 17444, 17534);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 17447, 17534);
                        return f_25033_17447_17534(ref _SystemRuntime, "netcoreapp.System.Runtime.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 17444, 17534);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 17444, 17534);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 17444, 17534);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemRuntimeInteropServices;

            public static byte[] SystemRuntimeInteropServices
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 17665, 17786);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 17668, 17786);
                        return f_25033_17668_17786(ref _SystemRuntimeInteropServices, "netcoreapp.System.Runtime.InteropServices.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 17665, 17786);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 17665, 17786);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 17665, 17786);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemThreadingTasks;

            public static byte[] SystemThreadingTasks
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 17901, 18006);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 17904, 18006);
                        return f_25033_17904_18006(ref _SystemThreadingTasks, "netcoreapp.System.Threading.Tasks.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 17901, 18006);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 17901, 18006);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 17901, 18006);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _netstandard;

            public static byte[] netstandard
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 18103, 18188);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 18106, 18188);
                        return f_25033_18106_18188(ref _netstandard, "netcoreapp.netstandard.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 18103, 18188);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 18103, 18188);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 18103, 18188);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _MicrosoftCSharp;

            public static byte[] MicrosoftCSharp
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 18293, 18387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 18296, 18387);
                        return f_25033_18296_18387(ref _MicrosoftCSharp, "netcoreapp.Microsoft.CSharp.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 18293, 18387);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 18293, 18387);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 18293, 18387);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _MicrosoftVisualBasic;

            public static byte[] MicrosoftVisualBasic
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 18502, 18606);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 18505, 18606);
                        return f_25033_18505_18606(ref _MicrosoftVisualBasic, "netcoreapp.Microsoft.VisualBasic.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 18502, 18606);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 18502, 18606);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 18502, 18606);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ResourcesNetCoreApp()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 15982, 18618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 16068, 16077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 16238, 16245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 16400, 16411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 16579, 16597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 16786, 16800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 16977, 16988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 17156, 17178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 17380, 17394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 17571, 17600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 17823, 17844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 18043, 18055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 18225, 18241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 18424, 18445);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 15982, 18618);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 15982, 18618);
            }


            static byte[]
            f_25033_16125_16201(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 16125, 16201);
                return return_v;
            }


            static byte[]
            f_25033_16291_16363(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 16291, 16363);
                return return_v;
            }


            static byte[]
            f_25033_16461_16542(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 16461, 16542);
                return return_v;
            }


            static byte[]
            f_25033_16654_16749(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 16654, 16749);
                return return_v;
            }


            static byte[]
            f_25033_16853_16940(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 16853, 16940);
                return return_v;
            }


            static byte[]
            f_25033_17038_17119(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 17038, 17119);
                return return_v;
            }


            static byte[]
            f_25033_17239_17343(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 17239, 17343);
                return return_v;
            }


            static byte[]
            f_25033_17447_17534(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 17447, 17534);
                return return_v;
            }


            static byte[]
            f_25033_17668_17786(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 17668, 17786);
                return return_v;
            }


            static byte[]
            f_25033_17904_18006(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 17904, 18006);
                return return_v;
            }


            static byte[]
            f_25033_18106_18188(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 18106, 18188);
                return return_v;
            }


            static byte[]
            f_25033_18296_18387(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 18296, 18387);
                return return_v;
            }


            static byte[]
            f_25033_18505_18606(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 18505, 18606);
                return return_v;
            }

        }
        public static class NetCoreApp
        {
            public static PortableExecutableReference mscorlib { get; }

            public static PortableExecutableReference System { get; }

            public static PortableExecutableReference SystemCore { get; }

            public static PortableExecutableReference SystemCollections { get; }

            public static PortableExecutableReference SystemConsole { get; }

            public static PortableExecutableReference SystemLinq { get; }

            public static PortableExecutableReference SystemLinqExpressions { get; }

            public static PortableExecutableReference SystemRuntime { get; }

            public static PortableExecutableReference SystemRuntimeInteropServices { get; }

            public static PortableExecutableReference SystemThreadingTasks { get; }

            public static PortableExecutableReference netstandard { get; }

            public static PortableExecutableReference MicrosoftCSharp { get; }

            public static PortableExecutableReference MicrosoftVisualBasic { get; }

            static NetCoreApp()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 18628, 21427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 18683, 18859);
                mscorlib = f_25033_18745_18858(f_25033_18745_18807(f_25033_18778_18806()), display: "mscorlib.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 18873, 19043);
                System = f_25033_18933_19042(f_25033_18933_18993(f_25033_18966_18992()), display: "System.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 19057, 19240);
                SystemCore = f_25033_19121_19239(f_25033_19121_19185(f_25033_19154_19184()), display: "System.Core.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 19254, 19458);
                SystemCollections = f_25033_19325_19457(f_25033_19325_19396(f_25033_19358_19395()), display: "System.Collections.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 19472, 19664);
                SystemConsole = f_25033_19539_19663(f_25033_19539_19606(f_25033_19572_19605()), display: "System.Console.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 19678, 19861);
                SystemLinq = f_25033_19742_19860(f_25033_19742_19806(f_25033_19775_19805()), display: "System.Linq.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 19875, 20092);
                SystemLinqExpressions = f_25033_19950_20091(f_25033_19950_20025(f_25033_19983_20024()), display: "System.Linq.Expressions.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 20106, 20298);
                SystemRuntime = f_25033_20173_20297(f_25033_20173_20240(f_25033_20206_20239()), display: "System.Runtime.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 20312, 20550);
                SystemRuntimeInteropServices = f_25033_20394_20549(f_25033_20394_20476(f_25033_20427_20475()), display: "System.Runtime.InteropServices.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 20564, 20778);
                SystemThreadingTasks = f_25033_20638_20777(f_25033_20638_20712(f_25033_20671_20711()), display: "System.Threading.Tasks.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 20792, 20977);
                netstandard = f_25033_20857_20976(f_25033_20857_20922(f_25033_20890_20921()), display: "netstandard.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 20991, 21189);
                MicrosoftCSharp = f_25033_21060_21188(f_25033_21060_21129(f_25033_21093_21128()), display: "Microsoft.CSharp.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 21203, 21416);
                MicrosoftVisualBasic = f_25033_21277_21415(f_25033_21277_21351(f_25033_21310_21350()), display: "Microsoft.VisualBasic.dll (netcoreapp)"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 18628, 21427);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 18628, 21427);
            }


            static byte[]
            f_25033_18778_18806()
            {
                var return_v = ResourcesNetCoreApp.mscorlib;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 18778, 18806);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_18745_18807(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 18745, 18807);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_18745_18858(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 18745, 18858);
                return return_v;
            }


            static byte[]
            f_25033_18966_18992()
            {
                var return_v = ResourcesNetCoreApp.System;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 18966, 18992);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_18933_18993(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 18933, 18993);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_18933_19042(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 18933, 19042);
                return return_v;
            }


            static byte[]
            f_25033_19154_19184()
            {
                var return_v = ResourcesNetCoreApp.SystemCore;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 19154, 19184);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_19121_19185(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 19121, 19185);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_19121_19239(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 19121, 19239);
                return return_v;
            }


            static byte[]
            f_25033_19358_19395()
            {
                var return_v = ResourcesNetCoreApp.SystemCollections;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 19358, 19395);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_19325_19396(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 19325, 19396);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_19325_19457(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 19325, 19457);
                return return_v;
            }


            static byte[]
            f_25033_19572_19605()
            {
                var return_v = ResourcesNetCoreApp.SystemConsole;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 19572, 19605);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_19539_19606(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 19539, 19606);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_19539_19663(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 19539, 19663);
                return return_v;
            }


            static byte[]
            f_25033_19775_19805()
            {
                var return_v = ResourcesNetCoreApp.SystemLinq;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 19775, 19805);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_19742_19806(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 19742, 19806);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_19742_19860(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 19742, 19860);
                return return_v;
            }


            static byte[]
            f_25033_19983_20024()
            {
                var return_v = ResourcesNetCoreApp.SystemLinqExpressions;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 19983, 20024);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_19950_20025(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 19950, 20025);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_19950_20091(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 19950, 20091);
                return return_v;
            }


            static byte[]
            f_25033_20206_20239()
            {
                var return_v = ResourcesNetCoreApp.SystemRuntime;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 20206, 20239);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_20173_20240(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 20173, 20240);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_20173_20297(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 20173, 20297);
                return return_v;
            }


            static byte[]
            f_25033_20427_20475()
            {
                var return_v = ResourcesNetCoreApp.SystemRuntimeInteropServices;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 20427, 20475);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_20394_20476(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 20394, 20476);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_20394_20549(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 20394, 20549);
                return return_v;
            }


            static byte[]
            f_25033_20671_20711()
            {
                var return_v = ResourcesNetCoreApp.SystemThreadingTasks;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 20671, 20711);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_20638_20712(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 20638, 20712);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_20638_20777(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 20638, 20777);
                return return_v;
            }


            static byte[]
            f_25033_20890_20921()
            {
                var return_v = ResourcesNetCoreApp.netstandard;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 20890, 20921);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_20857_20922(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 20857, 20922);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_20857_20976(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 20857, 20976);
                return return_v;
            }


            static byte[]
            f_25033_21093_21128()
            {
                var return_v = ResourcesNetCoreApp.MicrosoftCSharp;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 21093, 21128);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_21060_21129(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 21060, 21129);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_21060_21188(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 21060, 21188);
                return return_v;
            }


            static byte[]
            f_25033_21310_21350()
            {
                var return_v = ResourcesNetCoreApp.MicrosoftVisualBasic;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 21310, 21350);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_21277_21351(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 21277, 21351);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_21277_21415(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 21277, 21415);
                return return_v;
            }

        }
        public static class ResourcesNetStandard20
        {
            private static byte[] _mscorlib;

            public static byte[] mscorlib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 21580, 21662);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 21583, 21662);
                        return f_25033_21583_21662(ref _mscorlib, "netstandard20.mscorlib.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 21580, 21662);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 21580, 21662);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 21580, 21662);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _System;

            public static byte[] System
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 21749, 21827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 21752, 21827);
                        return f_25033_21752_21827(ref _System, "netstandard20.System.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 21749, 21827);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 21749, 21827);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 21749, 21827);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemCore;

            public static byte[] SystemCore
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 21922, 22009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 21925, 22009);
                        return f_25033_21925_22009(ref _SystemCore, "netstandard20.System.Core.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 21922, 22009);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 21922, 22009);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 21922, 22009);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemDynamicRuntime;

            public static byte[] SystemDynamicRuntime
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 22124, 22232);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 22127, 22232);
                        return f_25033_22127_22232(ref _SystemDynamicRuntime, "netstandard20.System.Dynamic.Runtime.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 22124, 22232);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 22124, 22232);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 22124, 22232);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemLinq;

            public static byte[] SystemLinq
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 22327, 22414);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 22330, 22414);
                        return f_25033_22330_22414(ref _SystemLinq, "netstandard20.System.Linq.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 22327, 22414);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 22327, 22414);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 22327, 22414);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemLinqExpressions;

            public static byte[] SystemLinqExpressions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 22531, 22641);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 22534, 22641);
                        return f_25033_22534_22641(ref _SystemLinqExpressions, "netstandard20.System.Linq.Expressions.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 22531, 22641);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 22531, 22641);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 22531, 22641);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _SystemRuntime;

            public static byte[] SystemRuntime
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 22742, 22835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 22745, 22835);
                        return f_25033_22745_22835(ref _SystemRuntime, "netstandard20.System.Runtime.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 22742, 22835);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 22742, 22835);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 22742, 22835);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _netstandard;

            public static byte[] netstandard
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 22932, 23020);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 22935, 23020);
                        return f_25033_22935_23020(ref _netstandard, "netstandard20.netstandard.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 22932, 23020);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 22932, 23020);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 22932, 23020);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ResourcesNetStandard20()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 21437, 23032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 21526, 21535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 21699, 21706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 21864, 21875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 22046, 22067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 22269, 22280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 22451, 22473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 22678, 22692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 22872, 22884);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 21437, 23032);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 21437, 23032);
            }


            static byte[]
            f_25033_21583_21662(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 21583, 21662);
                return return_v;
            }


            static byte[]
            f_25033_21752_21827(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 21752, 21827);
                return return_v;
            }


            static byte[]
            f_25033_21925_22009(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 21925, 22009);
                return return_v;
            }


            static byte[]
            f_25033_22127_22232(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 22127, 22232);
                return return_v;
            }


            static byte[]
            f_25033_22330_22414(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 22330, 22414);
                return return_v;
            }


            static byte[]
            f_25033_22534_22641(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 22534, 22641);
                return return_v;
            }


            static byte[]
            f_25033_22745_22835(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 22745, 22835);
                return return_v;
            }


            static byte[]
            f_25033_22935_23020(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 22935, 23020);
                return return_v;
            }

        }
        public static class NetStandard20
        {
            public static PortableExecutableReference mscorlib { get; }

            public static PortableExecutableReference System { get; }

            public static PortableExecutableReference SystemCore { get; }

            public static PortableExecutableReference SystemDynamicRuntime { get; }

            public static PortableExecutableReference SystemLinq { get; }

            public static PortableExecutableReference SystemLinqExpressions { get; }

            public static PortableExecutableReference SystemRuntime { get; }

            public static PortableExecutableReference netstandard { get; }

            static NetStandard20()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 23042, 24777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 23100, 23282);
                mscorlib = f_25033_23162_23281(f_25033_23162_23227(f_25033_23195_23226()), display: "mscorlib.dll (netstandard20)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 23296, 23472);
                System = f_25033_23356_23471(f_25033_23356_23419(f_25033_23389_23418()), display: "System.dll (netstandard20)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 23486, 23675);
                SystemCore = f_25033_23550_23674(f_25033_23550_23617(f_25033_23583_23616()), display: "System.Core.dll (netstandard20)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 23689, 23909);
                SystemDynamicRuntime = f_25033_23763_23908(f_25033_23763_23840(f_25033_23796_23839()), display: "System.Dynamic.Runtime.dll (netstandard20)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 23923, 24112);
                SystemLinq = f_25033_23987_24111(f_25033_23987_24054(f_25033_24020_24053()), display: "System.Linq.dll (netstandard20)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 24126, 24349);
                SystemLinqExpressions = f_25033_24201_24348(f_25033_24201_24279(f_25033_24234_24278()), display: "System.Linq.Expressions.dll (netstandard20)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 24363, 24561);
                SystemRuntime = f_25033_24430_24560(f_25033_24430_24500(f_25033_24463_24499()), display: "System.Runtime.dll (netstandard20)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 24575, 24766);
                netstandard = f_25033_24640_24765(f_25033_24640_24708(f_25033_24673_24707()), display: "netstandard.dll (netstandard20)"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 23042, 24777);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 23042, 24777);
            }


            static byte[]
            f_25033_23195_23226()
            {
                var return_v = ResourcesNetStandard20.mscorlib;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 23195, 23226);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_23162_23227(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 23162, 23227);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_23162_23281(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 23162, 23281);
                return return_v;
            }


            static byte[]
            f_25033_23389_23418()
            {
                var return_v = ResourcesNetStandard20.System;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 23389, 23418);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_23356_23419(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 23356, 23419);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_23356_23471(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 23356, 23471);
                return return_v;
            }


            static byte[]
            f_25033_23583_23616()
            {
                var return_v = ResourcesNetStandard20.SystemCore;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 23583, 23616);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_23550_23617(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 23550, 23617);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_23550_23674(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 23550, 23674);
                return return_v;
            }


            static byte[]
            f_25033_23796_23839()
            {
                var return_v = ResourcesNetStandard20.SystemDynamicRuntime;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 23796, 23839);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_23763_23840(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 23763, 23840);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_23763_23908(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 23763, 23908);
                return return_v;
            }


            static byte[]
            f_25033_24020_24053()
            {
                var return_v = ResourcesNetStandard20.SystemLinq;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 24020, 24053);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_23987_24054(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 23987, 24054);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_23987_24111(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 23987, 24111);
                return return_v;
            }


            static byte[]
            f_25033_24234_24278()
            {
                var return_v = ResourcesNetStandard20.SystemLinqExpressions;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 24234, 24278);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_24201_24279(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 24201, 24279);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_24201_24348(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 24201, 24348);
                return return_v;
            }


            static byte[]
            f_25033_24463_24499()
            {
                var return_v = ResourcesNetStandard20.SystemRuntime;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 24463, 24499);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_24430_24500(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 24430, 24500);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_24430_24560(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 24430, 24560);
                return return_v;
            }


            static byte[]
            f_25033_24673_24707()
            {
                var return_v = ResourcesNetStandard20.netstandard;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 24673, 24707);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_24640_24708(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 24640, 24708);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_24640_24765(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 24640, 24765);
                return return_v;
            }

        }
        public static class ResourcesMicrosoftCSharp
        {
            private static byte[] _Netstandard10;

            public static byte[] Netstandard10
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 24942, 25053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 24945, 25053);
                        return f_25033_24945_25053(ref _Netstandard10, "netstandard10.microsoftcsharp.Microsoft.CSharp.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 24942, 25053);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 24942, 25053);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 24942, 25053);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _Netstandard13Lib;

            public static byte[] Netstandard13Lib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 25160, 25277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 25163, 25277);
                        return f_25033_25163_25277(ref _Netstandard13Lib, "netstandard13lib.microsoftcsharp.Microsoft.CSharp.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 25160, 25277);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 25160, 25277);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 25160, 25277);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ResourcesMicrosoftCSharp()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 24787, 25289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 24878, 24892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 25090, 25107);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 24787, 25289);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 24787, 25289);
            }


            static byte[]
            f_25033_24945_25053(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 24945, 25053);
                return return_v;
            }


            static byte[]
            f_25033_25163_25277(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 25163, 25277);
                return return_v;
            }

        }
        public static class MicrosoftCSharp
        {
            public static PortableExecutableReference Netstandard10 { get; }

            public static PortableExecutableReference Netstandard13Lib { get; }

            static MicrosoftCSharp()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 25299, 25798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 25359, 25563);
                Netstandard10 = f_25033_25426_25562(f_25033_25426_25498(f_25033_25459_25497()), display: "Microsoft.CSharp.dll (microsoftcsharp)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 25577, 25787);
                Netstandard13Lib = f_25033_25647_25786(f_25033_25647_25722(f_25033_25680_25721()), display: "Microsoft.CSharp.dll (microsoftcsharp)"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 25299, 25798);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 25299, 25798);
            }


            static byte[]
            f_25033_25459_25497()
            {
                var return_v = ResourcesMicrosoftCSharp.Netstandard10;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 25459, 25497);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_25426_25498(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 25426, 25498);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_25426_25562(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 25426, 25562);
                return return_v;
            }


            static byte[]
            f_25033_25680_25721()
            {
                var return_v = ResourcesMicrosoftCSharp.Netstandard13Lib;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 25680, 25721);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_25647_25722(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 25647, 25722);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_25647_25786(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 25647, 25786);
                return return_v;
            }

        }
        public static class ResourcesMicrosoftVisualBasic
        {
            private static byte[] _Netstandard11;

            public static byte[] Netstandard11
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 25968, 26089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 25971, 26089);
                        return f_25033_25971_26089(ref _Netstandard11, "netstandard11.microsoftvisualbasic.Microsoft.VisualBasic.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 25968, 26089);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 25968, 26089);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 25968, 26089);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ResourcesMicrosoftVisualBasic()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 25808, 26101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 25904, 25918);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 25808, 26101);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 25808, 26101);
            }


            static byte[]
            f_25033_25971_26089(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 25971, 26089);
                return return_v;
            }

        }
        public static class MicrosoftVisualBasic
        {
            public static PortableExecutableReference Netstandard11 { get; }

            static MicrosoftVisualBasic()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 26111, 26406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 26176, 26395);
                Netstandard11 = f_25033_26243_26394(f_25033_26243_26320(f_25033_26276_26319()), display: "Microsoft.VisualBasic.dll (microsoftvisualbasic)"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 26111, 26406);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 26111, 26406);
            }


            static byte[]
            f_25033_26276_26319()
            {
                var return_v = ResourcesMicrosoftVisualBasic.Netstandard11;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 26276, 26319);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_26243_26320(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 26243, 26320);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_26243_26394(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 26243, 26394);
                return return_v;
            }

        }
        public static class ResourcesSystemThreadingTasksExtensions
        {
            private static byte[] _PortableLib;

            public static byte[] PortableLib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 26582, 26721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 26585, 26721);
                        return f_25033_26585_26721(ref _PortableLib, "portablelib.systemthreadingtasksextensions.System.Threading.Tasks.Extensions.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 26582, 26721);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 26582, 26721);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 26582, 26721);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static byte[] _NetStandard20Lib;

            public static byte[] NetStandard20Lib
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 26828, 26977);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 26831, 26977);
                        return f_25033_26831_26977(ref _NetStandard20Lib, "netstandard20lib.systemthreadingtasksextensions.System.Threading.Tasks.Extensions.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 26828, 26977);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 26828, 26977);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 26828, 26977);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ResourcesSystemThreadingTasksExtensions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 26416, 26989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 26522, 26534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 26758, 26775);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 26416, 26989);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 26416, 26989);
            }


            static byte[]
            f_25033_26585_26721(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 26585, 26721);
                return return_v;
            }


            static byte[]
            f_25033_26831_26977(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 26831, 26977);
                return return_v;
            }

        }
        public static class SystemThreadingTasksExtensions
        {
            public static PortableExecutableReference PortableLib { get; }

            public static PortableExecutableReference NetStandard20Lib { get; }

            static SystemThreadingTasksExtensions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 26999, 27603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 27074, 27321);
                PortableLib = f_25033_27139_27320(f_25033_27139_27224(f_25033_27172_27223()), display: "System.Threading.Tasks.Extensions.dll (systemthreadingtasksextensions)"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 27335, 27592);
                NetStandard20Lib = f_25033_27405_27591(f_25033_27405_27495(f_25033_27438_27494()), display: "System.Threading.Tasks.Extensions.dll (systemthreadingtasksextensions)"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 26999, 27603);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 26999, 27603);
            }


            static byte[]
            f_25033_27172_27223()
            {
                var return_v = ResourcesSystemThreadingTasksExtensions.PortableLib;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 27172, 27223);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_27139_27224(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 27139, 27224);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_27139_27320(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 27139, 27320);
                return return_v;
            }


            static byte[]
            f_25033_27438_27494()
            {
                var return_v = ResourcesSystemThreadingTasksExtensions.NetStandard20Lib;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 27438, 27494);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_27405_27495(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 27405, 27495);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_27405_27591(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 27405, 27591);
                return return_v;
            }

        }
        public static class ResourcesBuildExtensions
        {
            private static byte[] _NetStandardToNet461;

            public static byte[] NetStandardToNet461
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25033, 27780, 27898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 27783, 27898);
                        return f_25033_27783_27898(ref _NetStandardToNet461, "netstandardtonet461.buildextensions.netstandard.dll"); DynAbs.Tracing.TraceSender.TraceExitMethod(25033, 27780, 27898);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25033, 27780, 27898);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 27780, 27898);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ResourcesBuildExtensions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 27613, 27910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 27704, 27724);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 27613, 27910);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 27613, 27910);
            }


            static byte[]
            f_25033_27783_27898(ref byte[]
            resource, string
            name)
            {
                var return_v = ResourceLoader.GetOrCreateResource(ref resource, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 27783, 27898);
                return return_v;
            }

        }
        public static class BuildExtensions
        {
            public static PortableExecutableReference NetStandardToNet461 { get; }

            static BuildExtensions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 27920, 28202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25033, 27980, 28191);
                NetStandardToNet461 = f_25033_28053_28190(f_25033_28053_28131(f_25033_28086_28130()), display: "netstandard.dll (buildextensions)"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 27920, 28202);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 27920, 28202);
            }


            static byte[]
            f_25033_28086_28130()
            {
                var return_v = ResourcesBuildExtensions.NetStandardToNet461;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25033, 28086, 28130);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyMetadata
            f_25033_28053_28131(byte[]
            peImage)
            {
                var return_v = AssemblyMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 28053, 28131);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PortableExecutableReference
            f_25033_28053_28190(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param, string
            display)
            {
                var return_v = this_param.GetReference(display: display);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25033, 28053, 28190);
                return return_v;
            }

        }

        static TestMetadata()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25033, 382, 28209);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25033, 382, 28209);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25033, 382, 28209);
        }

    }
}
