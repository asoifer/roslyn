// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Xml.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CodeAnalysis.VisualBasic;
using static TestReferences.NetFx;
using static Roslyn.Test.Utilities.TestMetadata;
using Microsoft.CodeAnalysis.Test.Resources.Proprietary;

namespace Roslyn.Test.Utilities
{
    public abstract class TestBase : IDisposable
    {
        private TempRoot _temp;

        protected TestBase()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25004, 926, 968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 908, 913);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25004, 926, 968);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 926, 968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 926, 968);
            }
        }

        public static string GetUniqueName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25004, 980, 1088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 1041, 1077);

                return Guid.NewGuid().ToString("D");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25004, 980, 1088);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 980, 1088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 980, 1088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TempRoot Temp
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 1145, 1330);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 1181, 1282) || true) && (_temp == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25004, 1181, 1282);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 1240, 1263);

                        _temp = f_25004_1248_1262();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25004, 1181, 1282);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 1302, 1315);

                    return _temp;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 1145, 1330);

                    Microsoft.CodeAnalysis.Test.Utilities.TempRoot
                    f_25004_1248_1262()
                    {
                        var return_v = new Microsoft.CodeAnalysis.Test.Utilities.TempRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 1248, 1262);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 1100, 1341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 1100, 1341);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 1353, 1500);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 1407, 1489) || true) && (_temp != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25004, 1407, 1489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 1458, 1474);

                    f_25004_1458_1473(_temp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25004, 1407, 1489);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 1353, 1500);

                int
                f_25004_1458_1473(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 1458, 1473);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 1353, 1500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 1353, 1500);
            }
        }

        private static MetadataReference GetOrCreateMetadataReference(ref MetadataReference field, Func<MetadataReference> getReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25004, 1775, 2093);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 1928, 2055) || true) && (field == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25004, 1928, 2055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 1979, 2040);

                    f_25004_1979_2039(ref field, f_25004_2018_2032(getReference), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25004, 1928, 2055);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 2069, 2082);

                return field;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25004, 1775, 2093);

                Microsoft.CodeAnalysis.MetadataReference
                f_25004_2018_2032(System.Func<Microsoft.CodeAnalysis.MetadataReference>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 2018, 2032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference?
                f_25004_1979_2039(ref Microsoft.CodeAnalysis.MetadataReference?
                location1, Microsoft.CodeAnalysis.MetadataReference
                value, Microsoft.CodeAnalysis.MetadataReference?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 1979, 2039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 1775, 2093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 1775, 2093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Lazy<MetadataReference[]> s_lazyDefaultVbReferences;

        public static MetadataReference[] DefaultVbReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 2434, 2468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 2437, 2468);
                    return f_25004_2437_2468(s_lazyDefaultVbReferences); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 2434, 2468);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 2434, 2468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 2434, 2468);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference[]> s_lazyLatestVbReferences;

        public static MetadataReference[] LatestVbReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 2812, 2845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 2815, 2845);
                    return f_25004_2815_2845(s_lazyLatestVbReferences); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 2812, 2845);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 2812, 2845);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 2812, 2845);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static readonly AssemblyName RuntimeCorLibName;

        private static readonly Lazy<MetadataReference[]> s_winRtRefs;

        public static MetadataReference[] WinRtRefs
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 5274, 5294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 5277, 5294);
                    return f_25004_5277_5294(s_winRtRefs); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 5274, 5294);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 5274, 5294);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 5274, 5294);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference[]> s_portableRefsMinimal;

        public static MetadataReference[] PortableRefsMinimal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 5762, 5792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 5765, 5792);
                    return f_25004_5765_5792(s_portableRefsMinimal); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 5762, 5792);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 5762, 5792);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 5762, 5792);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static MetadataReference LinqAssemblyRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 5967, 5983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 5970, 5983);
                    return f_25004_5970_5983(); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 5967, 5983);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 5967, 5983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 5967, 5983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static MetadataReference ExtensionAssemblyRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 6167, 6183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 6170, 6183);
                    return f_25004_6170_6183(); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 6167, 6183);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 6167, 6183);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 6167, 6183);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemCoreRef;

        public static MetadataReference SystemCoreRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 6552, 6576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 6555, 6576);
                    return f_25004_6555_6576(s_systemCoreRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 6552, 6576);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 6552, 6576);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 6552, 6576);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemCoreRef_v4_0_30319_17929;

        public static MetadataReference SystemCoreRef_v4_0_30319_17929
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 6964, 7005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 6967, 7005);
                    return f_25004_6967_7005(s_systemCoreRef_v4_0_30319_17929); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 6964, 7005);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 6964, 7005);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 6964, 7005);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemCoreRef_v46;

        public static MetadataReference SystemCoreRef_v46
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 7362, 7403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 7365, 7403);
                    return f_25004_7365_7403(s_systemCoreRef_v4_0_30319_17929); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 7362, 7403);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 7362, 7403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 7362, 7403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemWindowsFormsRef;

        public static MetadataReference SystemWindowsFormsRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 7784, 7816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 7787, 7816);
                    return f_25004_7787_7816(s_systemWindowsFormsRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 7784, 7816);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 7784, 7816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 7784, 7816);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemDrawingRef;

        public static MetadataReference SystemDrawingRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 8176, 8203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 8179, 8203);
                    return f_25004_8179_8203(s_systemDrawingRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 8176, 8203);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 8176, 8203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 8176, 8203);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemDataRef;

        public static MetadataReference SystemDataRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 8551, 8575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 8554, 8575);
                    return f_25004_8554_8575(s_systemDataRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 8551, 8575);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 8551, 8575);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 8551, 8575);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_mscorlibRef;

        public static MetadataReference MscorlibRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 8914, 8936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 8917, 8936);
                    return f_25004_8917_8936(s_mscorlibRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 8914, 8936);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 8914, 8936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 8914, 8936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_mscorlibRefPortable;

        public static MetadataReference MscorlibRefPortable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 9329, 9359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 9332, 9359);
                    return f_25004_9332_9359(s_mscorlibRefPortable); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 9329, 9359);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 9329, 9359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 9329, 9359);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_aacorlibRef;

        public static MetadataReference AacorlibRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 10496, 10518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 10499, 10518);
                    return f_25004_10499_10518(s_aacorlibRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 10496, 10518);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 10496, 10518);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 10496, 10518);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static MetadataReference MscorlibRef_v20
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 10579, 10596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 10582, 10596);
                    return f_25004_10582_10596(); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 10579, 10596);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 10579, 10596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 10579, 10596);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static MetadataReference MscorlibRef_v4_0_30316_17626
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 10670, 10688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 10673, 10688);
                    return f_25004_10673_10688(); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 10670, 10688);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 10670, 10688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 10670, 10688);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_mscorlibRef_v46;

        public static MetadataReference MscorlibRef_v46
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 11078, 11104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 11081, 11104);
                    return f_25004_11081_11104(s_mscorlibRef_v46); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 11078, 11104);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 11078, 11104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 11078, 11104);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_mscorlibRef_silverlight;

        public static MetadataReference MscorlibRefSilverlight
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 11707, 11741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 11710, 11741);
                    return f_25004_11710_11741(s_mscorlibRef_silverlight); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 11707, 11741);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 11707, 11741);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 11707, 11741);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static MetadataReference MinCorlibRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 11799, 11840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 11802, 11840);
                    return f_25004_11802_11840(); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 11799, 11840);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 11799, 11840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 11799, 11840);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static MetadataReference MinAsyncCorlibRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 11903, 11949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 11906, 11949);
                    return f_25004_11906_11949(); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 11903, 11949);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 11903, 11949);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 11903, 11949);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static MetadataReference ValueTupleRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 12008, 12051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 12011, 12051);
                    return f_25004_12011_12051(); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 12008, 12051);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 12008, 12051);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 12008, 12051);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static MetadataReference MsvbRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 12104, 12134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 12107, 12134);
                    return f_25004_12107_12134(); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 12104, 12134);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 12104, 12134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 12104, 12134);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static MetadataReference MsvbRef_v4_0_30319_17929
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 12204, 12234);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 12207, 12234);
                    return f_25004_12207_12234(); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 12204, 12234);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 12204, 12234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 12204, 12234);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static MetadataReference CSharpRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 12289, 12308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 12292, 12308);
                    return f_25004_12292_12308(); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 12289, 12308);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 12289, 12308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 12289, 12308);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_desktopCSharpRef;

        public static MetadataReference CSharpDesktopRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 12672, 12699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 12675, 12699);
                    return f_25004_12675_12699(s_desktopCSharpRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 12672, 12699);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 12672, 12699);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 12672, 12699);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_std20Ref;

        public static MetadataReference NetStandard20Ref
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 13058, 13077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 13061, 13077);
                    return f_25004_13061_13077(s_std20Ref); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 13058, 13077);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 13058, 13077);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 13058, 13077);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_46NetStandardFacade;

        public static MetadataReference Net46StandardFacade
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 13460, 13490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 13463, 13490);
                    return f_25004_13463_13490(s_46NetStandardFacade); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 13460, 13490);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 13460, 13490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 13460, 13490);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemDynamicRuntimeRef;

        public static MetadataReference SystemDynamicRuntimeRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 13915, 13949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 13918, 13949);
                    return f_25004_13918_13949(s_systemDynamicRuntimeRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 13915, 13949);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 13915, 13949);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 13915, 13949);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemRef;

        public static MetadataReference SystemRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 14280, 14300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 14283, 14300);
                    return f_25004_14283_14300(s_systemRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 14280, 14300);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 14280, 14300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 14280, 14300);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemRef_v46;

        public static MetadataReference SystemRef_v46
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 14640, 14664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 14643, 14664);
                    return f_25004_14643_14664(s_systemRef_v46); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 14640, 14664);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 14640, 14664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 14640, 14664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemRef_v4_0_30319_17929;

        public static MetadataReference SystemRef_v4_0_30319_17929
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 15035, 15072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 15038, 15072);
                    return f_25004_15038_15072(s_systemRef_v4_0_30319_17929); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 15035, 15072);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 15035, 15072);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 15035, 15072);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemRef_v20;

        public static MetadataReference SystemRef_v20
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 15410, 15434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 15413, 15434);
                    return f_25004_15413_15434(s_systemRef_v20); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 15410, 15434);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 15410, 15434);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 15410, 15434);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemXmlRef;

        public static MetadataReference SystemXmlRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 15778, 15801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 15781, 15801);
                    return f_25004_15781_15801(s_systemXmlRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 15778, 15801);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 15778, 15801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 15778, 15801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemXmlLinqRef;

        public static MetadataReference SystemXmlLinqRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 16162, 16189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 16165, 16189);
                    return f_25004_16165_16189(s_systemXmlLinqRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 16162, 16189);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 16162, 16189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 16162, 16189);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_mscorlibFacadeRef;

        public static MetadataReference MscorlibFacadeRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 16529, 16557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 16532, 16557);
                    return f_25004_16532_16557(s_mscorlibFacadeRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 16529, 16557);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 16529, 16557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 16529, 16557);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemRuntimeFacadeRef;

        public static MetadataReference SystemRuntimeFacadeRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 16918, 16951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 16921, 16951);
                    return f_25004_16921_16951(s_systemRuntimeFacadeRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 16918, 16951);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 16918, 16951);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 16918, 16951);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemThreadingFacadeRef;

        public static MetadataReference SystemThreadingFacadeRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 17320, 17360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 17323, 17360);
                    return f_25004_17323_17360(s_systemThreadingTasksFacadeRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 17320, 17360);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 17320, 17360);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 17320, 17360);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemThreadingTasksFacadeRef;

        public static MetadataReference SystemThreadingTaskFacadeRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 17749, 17789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 17752, 17789);
                    return f_25004_17752_17789(s_systemThreadingTasksFacadeRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 17749, 17789);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 17749, 17789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 17749, 17789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_mscorlibPP7Ref;

        public static MetadataReference MscorlibPP7Ref
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 18169, 18194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 18172, 18194);
                    return f_25004_18172_18194(s_mscorlibPP7Ref); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 18169, 18194);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 18169, 18194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 18169, 18194);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_systemRuntimePP7Ref;

        public static MetadataReference SystemRuntimePP7Ref
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 18596, 18626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 18599, 18626);
                    return f_25004_18599_18626(s_systemRuntimePP7Ref); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 18596, 18626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 18596, 18626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 18596, 18626);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Lazy<MetadataReference> s_FSharpTestLibraryRef;

        public static MetadataReference FSharpTestLibraryRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25004, 18996, 19027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 18999, 19027);
                    return f_25004_18999_19027(s_FSharpTestLibraryRef); DynAbs.Tracing.TraceSender.TraceExitMethod(25004, 18996, 19027);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 18996, 19027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 18996, 19027);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static readonly MetadataReference InvalidRef;

        internal static DiagnosticDescription Diagnostic(
                    object code,
                    string squiggledText = null,
                    object[] arguments = null,
                    LinePosition? startLocation = null,
                    Func<SyntaxNode, bool> syntaxNodePredicate = null,
                    bool argumentOrderDoesNotMatter = false,
                    bool isSuppressed = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25004, 19214, 19888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 19603, 19877);

                return f_25004_19610_19876(code, squiggledText, arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, isSuppressed: isSuppressed);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25004, 19214, 19888);

                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25004_19610_19876(object
                code, string?
                squiggledText, object[]?
                arguments, Microsoft.CodeAnalysis.Text.LinePosition?
                startLocation, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                syntaxNodePredicate, bool
                argumentOrderDoesNotMatter, bool
                isSuppressed)
                {
                    var return_v = TestHelpers.Diagnostic(code, squiggledText, arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, isSuppressed: isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 19610, 19876);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 19214, 19888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 19214, 19888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DiagnosticDescription Diagnostic(
                   object code,
                   XCData squiggledText,
                   object[] arguments = null,
                   LinePosition? startLocation = null,
                   Func<SyntaxNode, bool> syntaxNodePredicate = null,
                   bool argumentOrderDoesNotMatter = false,
                   bool isSuppressed = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25004, 19900, 20560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 20275, 20549);

                return f_25004_20282_20548(code, squiggledText, arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, isSuppressed: isSuppressed);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25004, 19900, 20560);

                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25004_20282_20548(object
                code, System.Xml.Linq.XCData
                squiggledText, object[]?
                arguments, Microsoft.CodeAnalysis.Text.LinePosition?
                startLocation, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                syntaxNodePredicate, bool
                argumentOrderDoesNotMatter, bool
                isSuppressed)
                {
                    var return_v = TestHelpers.Diagnostic(code, squiggledText, arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, isSuppressed: isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 20282, 20548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25004, 19900, 20560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 19900, 20560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25004, 830, 20589);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 2155, 2369);
            s_lazyDefaultVbReferences = f_25004_2183_2369(() => new[] { Net40.mscorlib, Net40.System, Net40.SystemCore, Net40.MicrosoftVisualBasic }, LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 2531, 2748);
            s_lazyLatestVbReferences = f_25004_2558_2748(() => new[] { Net451.mscorlib, Net451.System, Net451.SystemCore, Net451.MicrosoftVisualBasic }, LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 2894, 3172);
            RuntimeCorLibName = (DynAbs.Tracing.TraceSender.Conditional_F1(25004, 2914, 2947) || ((f_25004_2914_2947() && DynAbs.Tracing.TraceSender.Conditional_F2(25004, 2963, 3061)) || DynAbs.Tracing.TraceSender.Conditional_F3(25004, 3077, 3172))) ? f_25004_2963_3061("netstandard, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51") : f_25004_3077_3172("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 3432, 5219);
            s_winRtRefs = f_25004_3446_5219(() =>
                        {
                            var winmd = AssemblyMetadata.CreateFromImage(TestResources.WinRt.Windows).GetReference(display: "Windows");

                            var windowsruntime =
                                AssemblyMetadata.CreateFromImage(ProprietaryTestResources.v4_0_30319_17929.System_Runtime_WindowsRuntime).GetReference(display: "System.Runtime.WindowsRuntime.dll");

                            var runtime =
                                AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemRuntime).GetReference(display: "System.Runtime.dll");

                            var objectModel =
                                AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemObjectModel).GetReference(display: "System.ObjectModel.dll");

                            var uixaml = AssemblyMetadata.CreateFromImage(ProprietaryTestResources.v4_0_30319_17929.System_Runtime_WindowsRuntime_UI_Xaml).
                                GetReference(display: "System.Runtime.WindowsRuntime.UI.Xaml.dll");

                            var interop = AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemRuntimeInteropServicesWindowsRuntime).
                                GetReference(display: "System.Runtime.InteropServices.WindowsRuntime.dll");

                //Not mentioned in the adapter doc but pointed to from System.Runtime, so we'll put it here.
                var system = AssemblyMetadata.CreateFromImage(ResourcesNet451.System).GetReference(display: "System.dll");

                            var mscor = AssemblyMetadata.CreateFromImage(ResourcesNet451.mscorlib).GetReference(display: "mscorlib");

                            return new MetadataReference[] { winmd, windowsruntime, runtime, objectModel, uixaml, interop, system, mscor };
                        }, LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 5508, 5697);
            s_portableRefsMinimal = f_25004_5532_5697(() => new MetadataReference[] { MscorlibPP7Ref, SystemRuntimePP7Ref }, LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 6244, 6495);
            s_systemCoreRef = f_25004_6275_6495(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemCore).GetReference(display: "System.Core.v4_0_30319.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 6637, 6890);
            s_systemCoreRef_v4_0_30319_17929 = f_25004_6672_6890(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemCore).GetReference(display: "System.Core.v4_0_30319_17929.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 7066, 7301);
            s_systemCoreRef_v46 = f_25004_7088_7301(() => AssemblyMetadata.CreateFromImage(ResourcesNet461.SystemCore).GetReference(display: "System.Core.v4_6_1038_0.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 7464, 7719);
            s_systemWindowsFormsRef = f_25004_7490_7719(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemWindowsForms).GetReference(display: "System.Windows.Forms.v4_0_30319.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 7877, 8116);
            s_systemDrawingRef = f_25004_7898_8116(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemDrawing).GetReference(display: "System.Drawing.v4_0_30319.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 8264, 8494);
            s_systemDataRef = f_25004_8282_8494(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemData).GetReference(display: "System.Data.v4_0_30319.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 8636, 8859);
            s_mscorlibRef = f_25004_8652_8859(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.mscorlib).GetReference(display: "mscorlib.v4_0_30319.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 8997, 9266);
            s_mscorlibRefPortable = f_25004_9021_9266(() => AssemblyMetadata.CreateFromImage(ProprietaryTestResources.v4_0_30319.mscorlib_portable).GetReference(display: "mscorlib.v4_0_30319.portable.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 9420, 10441);
            s_aacorlibRef = f_25004_9436_10441(() =>
                        {
                            var source = TestResources.NetFX.aacorlib_v15_0_3928.aacorlib_v15_0_3928_cs;
                            var syntaxTree = Microsoft.CodeAnalysis.CSharp.SyntaxFactory.ParseSyntaxTree(source);

                            var compilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);

                            var compilation = CSharpCompilation.Create("aacorlib.v15.0.3928.dll", new[] { syntaxTree }, null, compilationOptions);

                            Stream dllStream = new MemoryStream();
                            var emitResult = compilation.Emit(dllStream);
                            if (!emitResult.Success)
                            {
                                emitResult.Diagnostics.Verify();
                            }
                            dllStream.Seek(0, SeekOrigin.Begin);

                            return AssemblyMetadata.CreateFromStream(dllStream).GetReference(display: "mscorlib.v4_0_30319.dll");
                        }, LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 10749, 11019);
            s_mscorlibRef_v46 = f_25004_10769_11019(() => AssemblyMetadata.CreateFromImage(ResourcesNet461.mscorlib).GetReference(display: "mscorlib.v4_6_1038_0.dll", filePath: @"Z:\FxReferenceAssembliesUri"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 11345, 11641);
            s_mscorlibRef_silverlight = f_25004_11373_11641(() => AssemblyMetadata.CreateFromImage(ProprietaryTestResources.silverlight_v5_0_5_0.mscorlib_v5_0_5_0_silverlight).GetReference(display: "mscorlib.v5.0.5.0_silverlight.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 12369, 12612);
            s_desktopCSharpRef = f_25004_12390_12612(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.MicrosoftCSharp).GetReference(display: "Microsoft.CSharp.v4.0.30319.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 12760, 12996);
            s_std20Ref = f_25004_12773_12996(() => AssemblyMetadata.CreateFromImage(ResourcesNetStandard20.netstandard).GetReference(display: "netstandard20.netstandard.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 13138, 13395);
            s_46NetStandardFacade = f_25004_13162_13395(() => AssemblyMetadata.CreateFromImage(ResourcesBuildExtensions.NetStandardToNet461).GetReference(display: "netstandard20.netstandard.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 13551, 13848);
            s_systemDynamicRuntimeRef = f_25004_13579_13848(() => AssemblyMetadata.CreateFromImage(ProprietaryTestResources.netstandard13.System_Dynamic_Runtime).GetReference(display: "System.Dynamic.Runtime.dll (netstandard 1.3 ref)"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 14010, 14227);
            s_systemRef = f_25004_14024_14227(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.System).GetReference(display: "System.v4_0_30319.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 14361, 14583);
            s_systemRef_v46 = f_25004_14379_14583(() => AssemblyMetadata.CreateFromImage(ResourcesNet461.System).GetReference(display: "System.v4_6_1038_0.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 14725, 14965);
            s_systemRef_v4_0_30319_17929 = f_25004_14756_14965(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.System).GetReference(display: "System.v4_0_30319_17929.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 15133, 15353);
            s_systemRef_v20 = f_25004_15151_15353(() => AssemblyMetadata.CreateFromImage(ResourcesNet20.System).GetReference(display: "System.v2_0_50727.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 15495, 15722);
            s_systemXmlRef = f_25004_15512_15722(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemXml).GetReference(display: "System.Xml.v4_0_30319.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 15862, 16102);
            s_systemXmlLinqRef = f_25004_15883_16102(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemXmlLinq).GetReference(display: "System.Xml.Linq.v4_0_30319.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 16250, 16468);
            s_mscorlibFacadeRef = f_25004_16272_16468(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.mscorlib).GetReference(display: "mscorlib.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 16618, 16852);
            s_systemRuntimeFacadeRef = f_25004_16645_16852(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemRuntime).GetReference(display: "System.Runtime.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 17012, 17252);
            s_systemThreadingFacadeRef = f_25004_17041_17252(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemThreading).GetReference(display: "System.Threading.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 17421, 17677);
            s_systemThreadingTasksFacadeRef = f_25004_17455_17677(() => AssemblyMetadata.CreateFromImage(ResourcesNet451.SystemThreadingTasks).GetReference(display: "System.Threading.Tasks.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 17850, 18111);
            s_mscorlibPP7Ref = f_25004_17869_18111(() => AssemblyMetadata.CreateFromImage(ProprietaryTestResources.ReferenceAssemblies_PortableProfile7.mscorlib).GetReference(display: "mscorlib.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 18255, 18533);
            s_systemRuntimePP7Ref = f_25004_18279_18533(() => AssemblyMetadata.CreateFromImage(ProprietaryTestResources.ReferenceAssemblies_PortableProfile7.System_Runtime).GetReference(display: "System.Runtime.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 18687, 18932);
            s_FSharpTestLibraryRef = f_25004_18712_18932(() => AssemblyMetadata.CreateFromImage(TestResources.General.FSharpTestLibrary).GetReference(display: "FSharpTestLibrary.dll"), LazyThreadSafetyMode.PublicationOnly); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25004, 19081, 19148);
            InvalidRef = f_25004_19094_19148(fullPath: @"R:\Invalid.dll"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25004, 830, 20589);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25004, 830, 20589);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25004, 830, 20589);

        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference[]>
        f_25004_2183_2369(System.Func<Microsoft.CodeAnalysis.MetadataReference[]>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference[]>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 2183, 2369);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference[]
        f_25004_2437_2468(System.Lazy<Microsoft.CodeAnalysis.MetadataReference[]>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 2437, 2468);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference[]>
        f_25004_2558_2748(System.Func<Microsoft.CodeAnalysis.MetadataReference[]>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference[]>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 2558, 2748);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference[]
        f_25004_2815_2845(System.Lazy<Microsoft.CodeAnalysis.MetadataReference[]>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 2815, 2845);
            return return_v;
        }


        static bool
        f_25004_2914_2947()
        {
            var return_v = RuntimeUtilities.IsCoreClrRuntime
            ;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 2914, 2947);
            return return_v;
        }


        static System.Reflection.AssemblyName
        f_25004_2963_3061(string
        assemblyName)
        {
            var return_v = new System.Reflection.AssemblyName(assemblyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 2963, 3061);
            return return_v;
        }


        static System.Reflection.AssemblyName
        f_25004_3077_3172(string
        assemblyName)
        {
            var return_v = new System.Reflection.AssemblyName(assemblyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 3077, 3172);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference[]>
        f_25004_3446_5219(System.Func<Microsoft.CodeAnalysis.MetadataReference[]>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference[]>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 3446, 5219);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference[]
        f_25004_5277_5294(System.Lazy<Microsoft.CodeAnalysis.MetadataReference[]>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 5277, 5294);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference[]>
        f_25004_5532_5697(System.Func<Microsoft.CodeAnalysis.MetadataReference[]>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference[]>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 5532, 5697);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference[]
        f_25004_5765_5792(System.Lazy<Microsoft.CodeAnalysis.MetadataReference[]>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 5765, 5792);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_5970_5983()
        {
            var return_v = SystemCoreRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 5970, 5983);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_6170_6183()
        {
            var return_v = SystemCoreRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 6170, 6183);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_6275_6495(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 6275, 6495);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_6555_6576(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 6555, 6576);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_6672_6890(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 6672, 6890);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_6967_7005(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 6967, 7005);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_7088_7301(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 7088, 7301);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_7365_7403(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 7365, 7403);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_7490_7719(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 7490, 7719);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_7787_7816(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 7787, 7816);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_7898_8116(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 7898, 8116);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_8179_8203(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 8179, 8203);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_8282_8494(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 8282, 8494);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_8554_8575(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 8554, 8575);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_8652_8859(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 8652, 8859);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_8917_8936(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 8917, 8936);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_9021_9266(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 9021, 9266);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_9332_9359(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 9332, 9359);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_9436_10441(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 9436, 10441);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_10499_10518(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 10499, 10518);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25004_10582_10596()
        {
            var return_v = Net20.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 10582, 10596);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25004_10673_10688()
        {
            var return_v = Net451.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 10673, 10688);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_10769_11019(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 10769, 11019);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_11081_11104(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 11081, 11104);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_11373_11641(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 11373, 11641);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_11710_11741(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 11710, 11741);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25004_11802_11840()
        {
            var return_v = TestReferences.NetFx.Minimal.mincorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 11802, 11840);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25004_11906_11949()
        {
            var return_v = TestReferences.NetFx.Minimal.minasynccorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 11906, 11949);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25004_12011_12051()
        {
            var return_v = TestReferences.NetFx.ValueTuple.tuplelib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 12011, 12051);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25004_12107_12134()
        {
            var return_v = Net451.MicrosoftVisualBasic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 12107, 12134);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25004_12207_12234()
        {
            var return_v = Net451.MicrosoftVisualBasic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 12207, 12234);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_12292_12308()
        {
            var return_v = CSharpDesktopRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 12292, 12308);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_12390_12612(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 12390, 12612);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_12675_12699(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 12675, 12699);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_12773_12996(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 12773, 12996);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_13061_13077(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 13061, 13077);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_13162_13395(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 13162, 13395);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_13463_13490(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 13463, 13490);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_13579_13848(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 13579, 13848);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_13918_13949(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 13918, 13949);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_14024_14227(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 14024, 14227);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_14283_14300(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 14283, 14300);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_14379_14583(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 14379, 14583);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_14643_14664(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 14643, 14664);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_14756_14965(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 14756, 14965);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_15038_15072(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 15038, 15072);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_15151_15353(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 15151, 15353);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_15413_15434(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 15413, 15434);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_15512_15722(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 15512, 15722);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_15781_15801(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 15781, 15801);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_15883_16102(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 15883, 16102);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_16165_16189(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 16165, 16189);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_16272_16468(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 16272, 16468);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_16532_16557(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 16532, 16557);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_16645_16852(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 16645, 16852);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_16921_16951(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 16921, 16951);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_17041_17252(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 17041, 17252);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_17323_17360(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 17323, 17360);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_17455_17677(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 17455, 17677);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_17752_17789(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 17752, 17789);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_17869_18111(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 17869, 18111);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_18172_18194(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 18172, 18194);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_18279_18533(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 18279, 18533);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_18599_18626(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 18599, 18626);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        f_25004_18712_18932(System.Func<Microsoft.CodeAnalysis.MetadataReference>
        valueFactory, System.Threading.LazyThreadSafetyMode
        mode)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.MetadataReference>(valueFactory, mode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 18712, 18932);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25004_18999_19027(System.Lazy<Microsoft.CodeAnalysis.MetadataReference>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25004, 18999, 19027);
            return return_v;
        }


        static Roslyn.Test.Utilities.TestMetadataReference
        f_25004_19094_19148(string
        fullPath)
        {
            var return_v = new Roslyn.Test.Utilities.TestMetadataReference(fullPath: fullPath);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25004, 19094, 19148);
            return return_v;
        }

    }
}
