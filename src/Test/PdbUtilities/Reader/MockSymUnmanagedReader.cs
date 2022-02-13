// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

extern alias DSR;
using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using DSR::Microsoft.DiaSymReader;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using Xunit;

namespace Roslyn.Test.Utilities
{
    internal sealed class MockSymUnmanagedReader : ISymUnmanagedReader, ISymUnmanagedReader2, ISymUnmanagedReader3
    {
        private readonly ImmutableDictionary<int, MethodDebugInfoBytes> _methodDebugInfoMap;

        public MockSymUnmanagedReader(ImmutableDictionary<int, MethodDebugInfoBytes> methodDebugInfoMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(24003, 760, 933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 728, 747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 881, 922);

                _methodDebugInfoMap = methodDebugInfoMap;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(24003, 760, 933);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 760, 933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 760, 933);
            }
        }

        public int GetMethod(int methodToken, out ISymUnmanagedMethod method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 945, 1104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 1039, 1093);

                return f_24003_1046_1092(this, methodToken, 1, out method);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 945, 1104);

                int
                f_24003_1046_1092(Roslyn.Test.Utilities.MockSymUnmanagedReader
                this_param, int
                methodToken, int
                version, out ISymUnmanagedMethod
                retVal)
                {
                    var return_v = this_param.GetMethodByVersion(methodToken, version, out retVal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 1046, 1092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 945, 1104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 945, 1104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethodByVersion(int methodToken, int version, out ISymUnmanagedMethod retVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 1116, 1592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 1232, 1257);

                f_24003_1232_1256(1, version);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 1273, 1299);

                MethodDebugInfoBytes
                info
                = default(MethodDebugInfoBytes);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 1313, 1475) || true) && (!f_24003_1318_1372(_methodDebugInfoMap, methodToken, out info))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24003, 1313, 1475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 1406, 1420);

                    retVal = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 1438, 1460);

                    return HResult.E_FAIL;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24003, 1313, 1475);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 1491, 1512);

                f_24003_1491_1511(info);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 1526, 1547);

                retVal = info.Method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 1561, 1581);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 1116, 1592);

                int
                f_24003_1232_1256(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 1232, 1256);
                    return 0;
                }


                bool
                f_24003_1318_1372(System.Collections.Immutable.ImmutableDictionary<int, Roslyn.Test.Utilities.MethodDebugInfoBytes>
                this_param, int
                key, out Roslyn.Test.Utilities.MethodDebugInfoBytes
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 1318, 1372);
                    return return_v;
                }


                int
                f_24003_1491_1511(Roslyn.Test.Utilities.MethodDebugInfoBytes
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 1491, 1511);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 1116, 1592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 1116, 1592);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetSymAttribute(int methodToken, string name, int bufferLength, out int count, byte[] customDebugInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 1604, 2036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 1988, 2025);

                throw f_24003_1994_2024();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 1604, 2036);

                System.Exception
                f_24003_1994_2024()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24003, 1994, 2024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 1604, 2036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 1604, 2036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetSymAttributeByVersion(int methodToken, int version, string name, int bufferLength, out int count, byte[] customDebugInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 2048, 2740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 2215, 2240);

                f_24003_2215_2239(1, version);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 2256, 2282);

                f_24003_2256_2281("MD2", name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 2298, 2324);

                MethodDebugInfoBytes
                info
                = default(MethodDebugInfoBytes);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 2338, 2571) || true) && (!f_24003_2343_2397(_methodDebugInfoMap, methodToken, out info))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24003, 2338, 2571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 2431, 2441);

                    count = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 2459, 2482);

                    return HResult.S_FALSE;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24003, 2338, 2571);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 2587, 2608);

                f_24003_2587_2607(info);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 2622, 2695);

                info.Bytes.TwoPhaseCopy(bufferLength, out count, customDebugInformation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 2709, 2729);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 2048, 2740);

                int
                f_24003_2215_2239(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 2215, 2239);
                    return 0;
                }


                int
                f_24003_2256_2281(string
                expected, string
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 2256, 2281);
                    return 0;
                }


                bool
                f_24003_2343_2397(System.Collections.Immutable.ImmutableDictionary<int, Roslyn.Test.Utilities.MethodDebugInfoBytes>
                this_param, int
                key, out Roslyn.Test.Utilities.MethodDebugInfoBytes
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 2343, 2397);
                    return return_v;
                }


                int
                f_24003_2587_2607(Roslyn.Test.Utilities.MethodDebugInfoBytes
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 2587, 2607);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 2048, 2740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 2048, 2740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetDocument(string url, Guid language, Guid languageVendor, Guid documentType, out ISymUnmanagedDocument document)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 2752, 2949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 2902, 2938);

                throw f_24003_2908_2937();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 2752, 2949);

                System.NotImplementedException
                f_24003_2908_2937()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 2908, 2937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 2752, 2949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 2752, 2949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetDocuments(int bufferLength, out int count, ISymUnmanagedDocument[] documents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 2961, 3124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 3077, 3113);

                throw f_24003_3083_3112();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 2961, 3124);

                System.NotImplementedException
                f_24003_3083_3112()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 3083, 3112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 2961, 3124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 2961, 3124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetUserEntryPoint(out int methodToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 3136, 3257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 3210, 3246);

                throw f_24003_3216_3245();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 3136, 3257);

                System.NotImplementedException
                f_24003_3216_3245()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 3216, 3245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 3136, 3257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 3136, 3257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetVariables(int methodToken, int bufferLength, out int count, ISymUnmanagedVariable[] variables)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 3269, 3449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 3402, 3438);

                throw f_24003_3408_3437();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 3269, 3449);

                System.NotImplementedException
                f_24003_3408_3437()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 3408, 3437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 3269, 3449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 3269, 3449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetGlobalVariables(int bufferLength, out int count, ISymUnmanagedVariable[] variables)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 3461, 3630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 3583, 3619);

                throw f_24003_3589_3618();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 3461, 3630);

                System.NotImplementedException
                f_24003_3589_3618()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 3589, 3618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 3461, 3630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 3461, 3630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethodFromDocumentPosition(ISymUnmanagedDocument document, int line, int column, out ISymUnmanagedMethod method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 3642, 3840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 3793, 3829);

                throw f_24003_3799_3828();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 3642, 3840);

                System.NotImplementedException
                f_24003_3799_3828()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 3799, 3828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 3642, 3840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 3642, 3840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetNamespaces(int bufferLength, out int count, ISymUnmanagedNamespace[] namespaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 3852, 4018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 3971, 4007);

                throw f_24003_3977_4006();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 3852, 4018);

                System.NotImplementedException
                f_24003_3977_4006()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 3977, 4006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 3852, 4018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 3852, 4018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int Initialize(object metadataImporter, string fileName, string searchPath, IStream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 4030, 4200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 4153, 4189);

                throw f_24003_4159_4188();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 4030, 4200);

                System.NotImplementedException
                f_24003_4159_4188()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 4159, 4188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 4030, 4200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 4030, 4200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int UpdateSymbolStore(string fileName, IStream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 4212, 4345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 4298, 4334);

                throw f_24003_4304_4333();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 4212, 4345);

                System.NotImplementedException
                f_24003_4304_4333()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 4304, 4333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 4212, 4345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 4212, 4345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int ReplaceSymbolStore(string fileName, IStream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 4357, 4491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 4444, 4480);

                throw f_24003_4450_4479();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 4357, 4491);

                System.NotImplementedException
                f_24003_4450_4479()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 4450, 4479);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 4357, 4491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 4357, 4491);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetSymbolStoreFileName(int bufferLength, out int count, char[] name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 4503, 4654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 4607, 4643);

                throw f_24003_4613_4642();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 4503, 4654);

                System.NotImplementedException
                f_24003_4613_4642()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 4613, 4642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 4503, 4654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 4503, 4654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethodsFromDocumentPosition(ISymUnmanagedDocument document, int line, int column, int bufferLength, out int count, ISymUnmanagedMethod[] methods)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 4666, 4897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 4850, 4886);

                throw f_24003_4856_4885();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 4666, 4897);

                System.NotImplementedException
                f_24003_4856_4885()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 4856, 4885);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 4666, 4897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 4666, 4897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetDocumentVersion(ISymUnmanagedDocument document, out int version, out bool isCurrent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 4909, 5079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 5032, 5068);

                throw f_24003_5038_5067();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 4909, 5079);

                System.NotImplementedException
                f_24003_5038_5067()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 5038, 5067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 4909, 5079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 4909, 5079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethodVersion(ISymUnmanagedMethod method, out int version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 5091, 5235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 5188, 5224);

                throw f_24003_5194_5223();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 5091, 5235);

                System.NotImplementedException
                f_24003_5194_5223()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 5194, 5223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 5091, 5235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 5091, 5235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethodByVersionPreRemap(int methodToken, int version, out ISymUnmanagedMethod method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 5247, 5418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 5371, 5407);

                throw f_24003_5377_5406();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 5247, 5418);

                System.NotImplementedException
                f_24003_5377_5406()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 5377, 5406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 5247, 5418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 5247, 5418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetSymAttributePreRemap(int methodToken, string name, int bufferLength, out int count, byte[] customDebugInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 5430, 5630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 5583, 5619);

                throw f_24003_5589_5618();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 5430, 5630);

                System.NotImplementedException
                f_24003_5589_5618()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 5589, 5618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 5430, 5630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 5430, 5630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethodsInDocument(ISymUnmanagedDocument document, int bufferLength, out int count, ISymUnmanagedMethod[] methods)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 5642, 5841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 5794, 5830);

                throw f_24003_5800_5829();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 5642, 5841);

                System.NotImplementedException
                f_24003_5800_5829()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 5800, 5829);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 5642, 5841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 5642, 5841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetSymAttributeByVersionPreRemap(int methodToken, int version, string name, int bufferLength, out int count, byte[] customDebugInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 5853, 6075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 6028, 6064);

                throw f_24003_6034_6063();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 5853, 6075);

                System.NotImplementedException
                f_24003_6034_6063()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 6034, 6063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 5853, 6075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 5853, 6075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MockSymUnmanagedReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24003, 537, 6082);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24003, 537, 6082);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 537, 6082);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24003, 537, 6082);
    }
    internal sealed class MockSymUnmanagedMethod : ISymUnmanagedMethod
    {
        private readonly ISymUnmanagedScope _rootScope;

        public MockSymUnmanagedMethod(ISymUnmanagedScope rootScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(24003, 6232, 6350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 6209, 6219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 6316, 6339);

                _rootScope = rootScope;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(24003, 6232, 6350);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 6232, 6350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 6232, 6350);
            }
        }

        int ISymUnmanagedMethod.GetRootScope(out ISymUnmanagedScope retVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 6362, 6519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 6454, 6474);

                retVal = _rootScope;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 6488, 6508);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 6362, 6519);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 6362, 6519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 6362, 6519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedMethod.GetSequencePointCount(out int retVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 6531, 6673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 6617, 6628);

                retVal = 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 6642, 6662);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 6531, 6673);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 6531, 6673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 6531, 6673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedMethod.GetSequencePoints(int cPoints, out int pcPoints, int[] offsets, ISymUnmanagedDocument[] documents, int[] lines, int[] columns, int[] endLines, int[] endColumns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 6685, 7133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 6894, 6907);

                pcPoints = 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 6921, 6936);

                offsets[0] = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 6950, 6970);

                documents[0] = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 6984, 6997);

                lines[0] = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 7011, 7026);

                columns[0] = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 7040, 7056);

                endLines[0] = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 7070, 7088);

                endColumns[0] = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 7102, 7122);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 6685, 7133);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 6685, 7133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 6685, 7133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedMethod.GetNamespace(out ISymUnmanagedNamespace retVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 7145, 7288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 7241, 7277);

                throw f_24003_7247_7276();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 7145, 7288);

                System.NotImplementedException
                f_24003_7247_7276()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 7247, 7276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 7145, 7288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 7145, 7288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedMethod.GetOffset(ISymUnmanagedDocument document, int line, int column, out int retVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 7300, 7475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 7428, 7464);

                throw f_24003_7434_7463();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 7300, 7475);

                System.NotImplementedException
                f_24003_7434_7463()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 7434, 7463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 7300, 7475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 7300, 7475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedMethod.GetParameters(int cParams, out int pcParams, ISymUnmanagedVariable[] parms)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 7487, 7658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 7611, 7647);

                throw f_24003_7617_7646();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 7487, 7658);

                System.NotImplementedException
                f_24003_7617_7646()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 7617, 7646);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 7487, 7658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 7487, 7658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedMethod.GetRanges(ISymUnmanagedDocument document, int line, int column, int cRanges, out int pcRanges, int[] ranges)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 7670, 7874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 7827, 7863);

                throw f_24003_7833_7862();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 7670, 7874);

                System.NotImplementedException
                f_24003_7833_7862()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 7833, 7862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 7670, 7874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 7670, 7874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedMethod.GetScopeFromOffset(int offset, out ISymUnmanagedScope retVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 7886, 8043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 7996, 8032);

                throw f_24003_8002_8031();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 7886, 8043);

                System.NotImplementedException
                f_24003_8002_8031()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 8002, 8031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 7886, 8043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 7886, 8043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedMethod.GetSourceStartEnd(ISymUnmanagedDocument[] docs, int[] lines, int[] columns, out bool retVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 8055, 8243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 8196, 8232);

                throw f_24003_8202_8231();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 8055, 8243);

                System.NotImplementedException
                f_24003_8202_8231()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 8202, 8231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 8055, 8243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 8055, 8243);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedMethod.GetToken(out int pToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 8255, 8375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 8328, 8364);

                throw f_24003_8334_8363();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 8255, 8375);

                System.NotImplementedException
                f_24003_8334_8363()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 8334, 8363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 8255, 8375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 8255, 8375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MockSymUnmanagedMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24003, 6090, 8382);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24003, 6090, 8382);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 6090, 8382);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24003, 6090, 8382);
    }
    internal sealed class MockSymUnmanagedScope : ISymUnmanagedScope, ISymUnmanagedScope2
    {
        private readonly ImmutableArray<ISymUnmanagedScope> _children;

        private readonly ImmutableArray<ISymUnmanagedNamespace> _namespaces;

        private readonly ISymUnmanagedConstant[] _constants;

        private readonly int _startOffset;

        private readonly int _endOffset;

        public MockSymUnmanagedScope(ImmutableArray<ISymUnmanagedScope> children, ImmutableArray<ISymUnmanagedNamespace> namespaces, ISymUnmanagedConstant[] constants = null, int startOffset = 0, int endOffset = 1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(24003, 8792, 9241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 8683, 8693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 8725, 8737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 8769, 8779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9023, 9044);

                _children = children;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9058, 9083);

                _namespaces = namespaces;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9097, 9152);

                _constants = constants ?? (DynAbs.Tracing.TraceSender.Expression_Null<ISymUnmanagedConstant[]?>(24003, 9110, 9151) ?? new ISymUnmanagedConstant[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9166, 9193);

                _startOffset = startOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9207, 9230);

                _endOffset = endOffset;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(24003, 8792, 9241);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 8792, 9241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 8792, 9241);
            }
        }

        public int GetChildren(int numDesired, out int numRead, ISymUnmanagedScope[] buffer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 9253, 9463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9362, 9418);

                _children.TwoPhaseCopy(numDesired, out numRead, buffer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9432, 9452);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 9253, 9463);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 9253, 9463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 9253, 9463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetNamespaces(int numDesired, out int numRead, ISymUnmanagedNamespace[] buffer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 9475, 9693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9590, 9648);

                _namespaces.TwoPhaseCopy(numDesired, out numRead, buffer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9662, 9682);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 9475, 9693);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 9475, 9693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 9475, 9693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetStartOffset(out int pRetVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 9705, 9840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9772, 9795);

                pRetVal = _startOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9809, 9829);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 9705, 9840);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 9705, 9840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 9705, 9840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetEndOffset(out int pRetVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 9852, 9983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9917, 9938);

                pRetVal = _endOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 9952, 9972);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 9852, 9983);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 9852, 9983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 9852, 9983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetLocalCount(out int pRetVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 9995, 10118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 10061, 10073);

                pRetVal = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 10087, 10107);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 9995, 10118);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 9995, 10118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 9995, 10118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetLocals(int cLocals, out int pcLocals, ISymUnmanagedVariable[] locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 10130, 10296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 10238, 10251);

                pcLocals = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 10265, 10285);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 10130, 10296);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 10130, 10296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 10130, 10296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethod(out ISymUnmanagedMethod pRetVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 10308, 10433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 10386, 10422);

                throw f_24003_10392_10421();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 10308, 10433);

                System.NotImplementedException
                f_24003_10392_10421()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 10392, 10421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 10308, 10433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 10308, 10433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetParent(out ISymUnmanagedScope pRetVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 10445, 10569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 10522, 10558);

                throw f_24003_10528_10557();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 10445, 10569);

                System.NotImplementedException
                f_24003_10528_10557()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 10528, 10557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 10445, 10569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 10445, 10569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetConstantCount(out int pRetVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 10581, 10723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 10650, 10678);

                pRetVal = f_24003_10660_10677(_constants);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 10692, 10712);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 10581, 10723);

                int
                f_24003_10660_10677(ISymUnmanagedConstant[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24003, 10660, 10677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 10581, 10723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 10581, 10723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetConstants(int cConstants, out int pcConstants, ISymUnmanagedConstant[] constants)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 10735, 11068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 10855, 10887);

                pcConstants = f_24003_10869_10886(_constants);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 10901, 11023) || true) && (constants != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24003, 10901, 11023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 10956, 11008);

                    f_24003_10956_11007(_constants, constants, f_24003_10990_11006(constants));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24003, 10901, 11023);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 11037, 11057);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 10735, 11068);

                int
                f_24003_10869_10886(ISymUnmanagedConstant[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24003, 10869, 10886);
                    return return_v;
                }


                int
                f_24003_10990_11006(ISymUnmanagedConstant[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24003, 10990, 11006);
                    return return_v;
                }


                int
                f_24003_10956_11007(ISymUnmanagedConstant[]
                sourceArray, ISymUnmanagedConstant[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 10956, 11007);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 10735, 11068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 10735, 11068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MockSymUnmanagedScope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24003, 8390, 11075);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24003, 8390, 11075);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 8390, 11075);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24003, 8390, 11075);
    }
    internal sealed class MockSymUnmanagedNamespace : ISymUnmanagedNamespace
    {
        private readonly ImmutableArray<char> _nameChars;

        public MockSymUnmanagedNamespace(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(24003, 11233, 11568);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 11303, 11557) || true) && (name != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24003, 11303, 11557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 11353, 11400);

                    var
                    builder = f_24003_11367_11399()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 11418, 11441);

                    f_24003_11418_11440(builder, name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 11459, 11482);

                    f_24003_11459_11481(builder, '\0');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 11500, 11542);

                    _nameChars = f_24003_11513_11541(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24003, 11303, 11557);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(24003, 11233, 11568);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 11233, 11568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 11233, 11568);
            }
        }

        int ISymUnmanagedNamespace.GetName(int numDesired, out int numRead, char[] buffer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 11580, 11778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 11687, 11744);

                _nameChars.TwoPhaseCopy(numDesired, out numRead, buffer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 11758, 11767);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 11580, 11778);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 11580, 11778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 11580, 11778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedNamespace.GetNamespaces(int cNameSpaces, out int pcNameSpaces, ISymUnmanagedNamespace[] namespaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 11790, 11978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 11931, 11967);

                throw f_24003_11937_11966();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 11790, 11978);

                System.NotImplementedException
                f_24003_11937_11966()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 11937, 11966);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 11790, 11978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 11790, 11978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedNamespace.GetVariables(int cVars, out int pcVars, ISymUnmanagedVariable[] pVars)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 11990, 12159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 12112, 12148);

                throw f_24003_12118_12147();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 11990, 12159);

                System.NotImplementedException
                f_24003_12118_12147()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 12118, 12147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 11990, 12159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 11990, 12159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MockSymUnmanagedNamespace()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24003, 11083, 12166);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24003, 11083, 12166);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 11083, 12166);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24003, 11083, 12166);

        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<char>
        f_24003_11367_11399()
        {
            var return_v = ArrayBuilder<char>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 11367, 11399);
            return return_v;
        }


        int
        f_24003_11418_11440(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<char>
        this_param, string
        items)
        {
            this_param.AddRange((System.Collections.Generic.IEnumerable<char>)items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 11418, 11440);
            return 0;
        }


        int
        f_24003_11459_11481(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<char>
        this_param, params char[]
        items)
        {
            this_param.AddRange(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 11459, 11481);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<char>
        f_24003_11513_11541(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<char>
        this_param)
        {
            var return_v = this_param.ToImmutableAndFree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 11513, 11541);
            return return_v;
        }

    }

    internal delegate int GetSignatureDelegate(int bufferLength, out int count, byte[] signature);
    internal sealed class MockSymUnmanagedConstant : ISymUnmanagedConstant
    {
        private readonly string _name;

        private readonly object _value;

        private readonly GetSignatureDelegate _getSignature;

        public MockSymUnmanagedConstant(string name, object value, GetSignatureDelegate getSignature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(24003, 12508, 12722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 12387, 12392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 12427, 12433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 12482, 12495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 12626, 12639);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 12653, 12668);

                _value = value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 12682, 12711);

                _getSignature = getSignature;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(24003, 12508, 12722);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 12508, 12722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 12508, 12722);
            }
        }

        int ISymUnmanagedConstant.GetName(int bufferLength, out int count, char[] name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 12734, 13133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 12838, 12863);

                count = f_24003_12846_12858(_name) + 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 12904, 12965);

                f_24003_12904_12964((bufferLength == 0) || (DynAbs.Tracing.TraceSender.Expression_False(24003, 12917, 12963) || (bufferLength == count)));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 12988, 12993);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 12979, 13088) || true) && (i < bufferLength - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 13017, 13020)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(24003, 12979, 13088))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24003, 12979, 13088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 13054, 13073);

                        name[i] = f_24003_13064_13072(_name, i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24003, 1, 110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24003, 1, 110);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 13102, 13122);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 12734, 13133);

                int
                f_24003_12846_12858(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24003, 12846, 12858);
                    return return_v;
                }


                int
                f_24003_12904_12964(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 12904, 12964);
                    return 0;
                }


                char
                f_24003_13064_13072(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24003, 13064, 13072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 12734, 13133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 12734, 13133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedConstant.GetSignature(int bufferLength, out int count, byte[] signature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 13145, 13327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 13259, 13316);

                return f_24003_13266_13315(this, bufferLength, out count, signature);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 13145, 13327);

                int
                f_24003_13266_13315(Roslyn.Test.Utilities.MockSymUnmanagedConstant
                this_param, int
                bufferLength, out int
                count, byte[]
                signature)
                {
                    var return_v = this_param._getSignature(bufferLength, out count, signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 13266, 13315);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 13145, 13327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 13145, 13327);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int ISymUnmanagedConstant.GetValue(out object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24003, 13339, 13476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 13416, 13431);

                value = _value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 13445, 13465);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24003, 13339, 13476);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 13339, 13476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 13339, 13476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MockSymUnmanagedConstant()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24003, 12276, 13483);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24003, 12276, 13483);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 12276, 13483);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24003, 12276, 13483);
    }
    internal static class MockSymUnmanagedHelpers
    {
        public static void TwoPhaseCopy<T>(this ImmutableArray<T> source, int numDesired, out int numRead, T[] destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24003, 13553, 14126);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 13693, 14115) || true) && (destination == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24003, 13693, 14115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 13750, 13778);

                    f_24003_13750_13777<T>(0, numDesired);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 13796, 13843);

                    numRead = (DynAbs.Tracing.TraceSender.Conditional_F1(24003, 13806, 13822) || ((source.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(24003, 13825, 13826)) || DynAbs.Tracing.TraceSender.Conditional_F3(24003, 13829, 13842))) ? 0 : source.Length;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24003, 13693, 14115);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24003, 13693, 14115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 13909, 13940);

                    f_24003_13909_13939<T>(source.IsDefault);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 13958, 13998);

                    f_24003_13958_13997<T>(source.Length, numDesired);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 14016, 14061);

                    source.CopyTo(0, destination, 0, numDesired);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 14079, 14100);

                    numRead = numDesired;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24003, 13693, 14115);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24003, 13553, 14126);

                int
                f_24003_13750_13777<T>(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 13750, 13777);
                    return 0;
                }


                int
                f_24003_13909_13939<T>(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 13909, 13939);
                    return 0;
                }


                int
                f_24003_13958_13997<T>(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 13958, 13997);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 13553, 14126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 13553, 14126);
            }
        }

        public static void Add2(this ArrayBuilder<byte> bytes, short s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24003, 14138, 14369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 14226, 14268);

                var
                shortBytes = f_24003_14243_14267(s)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 14282, 14317);

                f_24003_14282_14316(2, f_24003_14298_14315(shortBytes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 14331, 14358);

                f_24003_14331_14357(bytes, shortBytes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24003, 14138, 14369);

                byte[]
                f_24003_14243_14267(short
                value)
                {
                    var return_v = BitConverter.GetBytes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 14243, 14267);
                    return return_v;
                }


                int
                f_24003_14298_14315(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24003, 14298, 14315);
                    return return_v;
                }


                int
                f_24003_14282_14316(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 14282, 14316);
                    return 0;
                }


                int
                f_24003_14331_14357(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, params byte[]
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 14331, 14357);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 14138, 14369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 14138, 14369);
            }
        }

        public static void Add4(this ArrayBuilder<byte> bytes, int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24003, 14381, 14604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 14467, 14507);

                var
                intBytes = f_24003_14482_14506(i)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 14521, 14554);

                f_24003_14521_14553(4, f_24003_14537_14552(intBytes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24003, 14568, 14593);

                f_24003_14568_14592(bytes, intBytes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24003, 14381, 14604);

                byte[]
                f_24003_14482_14506(int
                value)
                {
                    var return_v = BitConverter.GetBytes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 14482, 14506);
                    return return_v;
                }


                int
                f_24003_14537_14552(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24003, 14537, 14552);
                    return return_v;
                }


                int
                f_24003_14521_14553(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 14521, 14553);
                    return 0;
                }


                int
                f_24003_14568_14592(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, params byte[]
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24003, 14568, 14592);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24003, 14381, 14604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 14381, 14604);
            }
        }

        static MockSymUnmanagedHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24003, 13491, 14611);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24003, 13491, 14611);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24003, 13491, 14611);
        }

    }
}
