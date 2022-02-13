// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

extern alias DSR;
using System;
using System.Runtime.InteropServices.ComTypes;
using DSR::Microsoft.DiaSymReader;

namespace Roslyn.Test.Utilities
{
    public sealed class NotImplementedSymUnmanagedReader : ISymUnmanagedReader5
    {
        public static readonly NotImplementedSymUnmanagedReader Instance;

        private NotImplementedSymUnmanagedReader()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(24004, 599, 645);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(24004, 599, 645);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 599, 645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 599, 645);
            }
        }

        public int GetDocument(string url, Guid language, Guid languageVendor, Guid documentType, out ISymUnmanagedDocument retVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 657, 869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 805, 819);

                retVal = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 833, 858);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 657, 869);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 657, 869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 657, 869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetDocuments(int cDocs, out int pcDocs, ISymUnmanagedDocument[] pDocs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 881, 1048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 987, 998);

                pcDocs = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 1012, 1037);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 881, 1048);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 881, 1048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 881, 1048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetDocumentVersion(ISymUnmanagedDocument pDoc, out int version, out bool pbCurrent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 1060, 1273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 1179, 1191);

                version = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 1205, 1223);

                pbCurrent = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 1237, 1262);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 1060, 1273);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 1060, 1273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 1060, 1273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetGlobalVariables(int cVars, out int pcVars, ISymUnmanagedVariable[] vars)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 1285, 1457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 1396, 1407);

                pcVars = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 1421, 1446);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 1285, 1457);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 1285, 1457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 1285, 1457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethod(int methodToken, out ISymUnmanagedMethod retVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 1469, 1627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 1563, 1577);

                retVal = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 1591, 1616);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 1469, 1627);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 1469, 1627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 1469, 1627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethodByVersion(int methodToken, int version, out ISymUnmanagedMethod retVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 1639, 1819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 1755, 1769);

                retVal = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 1783, 1808);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 1639, 1819);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 1639, 1819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 1639, 1819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethodByVersionPreRemap(int methodToken, int version, out ISymUnmanagedMethod retVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 1831, 2019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 1955, 1969);

                retVal = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 1983, 2008);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 1831, 2019);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 1831, 2019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 1831, 2019);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethodFromDocumentPosition(ISymUnmanagedDocument document, int line, int column, out ISymUnmanagedMethod retVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 2031, 2246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 2182, 2196);

                retVal = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 2210, 2235);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 2031, 2246);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 2031, 2246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 2031, 2246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethodsFromDocumentPosition(ISymUnmanagedDocument document, int line, int column, int cMethod, out int pcMethod, ISymUnmanagedMethod[] pRetVal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 2258, 2503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 2440, 2453);

                pcMethod = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 2467, 2492);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 2258, 2503);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 2258, 2503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 2258, 2503);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethodsInDocument(ISymUnmanagedDocument document, int cMethod, out int pcMethod, ISymUnmanagedMethod[] methods)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 2515, 2728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 2665, 2678);

                pcMethod = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 2692, 2717);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 2515, 2728);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 2515, 2728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 2515, 2728);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMethodVersion(ISymUnmanagedMethod pMethod, out int version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 2740, 2900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 2838, 2850);

                version = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 2864, 2889);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 2740, 2900);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 2740, 2900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 2740, 2900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetNamespaces(int cNameSpaces, out int pcNameSpaces, ISymUnmanagedNamespace[] namespaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 2912, 3104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 3037, 3054);

                pcNameSpaces = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 3068, 3093);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 2912, 3104);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 2912, 3104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 2912, 3104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetSymAttribute(int parent, string name, int sizeBuffer, out int lengthBuffer, byte[] buffer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 3116, 3312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 3245, 3262);

                lengthBuffer = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 3276, 3301);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 3116, 3312);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 3116, 3312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 3116, 3312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetSymAttributeByVersion(int methodToken, int version, string name, int bufferLength, out int count, byte[] customDebugInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 3324, 3551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 3491, 3501);

                count = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 3515, 3540);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 3324, 3551);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 3324, 3551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 3324, 3551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetSymAttributeByVersionPreRemap(int methodToken, int version, string name, int bufferLength, out int count, byte[] customDebugInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 3563, 3798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 3738, 3748);

                count = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 3762, 3787);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 3563, 3798);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 3563, 3798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 3563, 3798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetSymAttributePreRemap(int parent, string name, int sizeBuffer, out int lengthBuffer, byte[] buffer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 3810, 4014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 3947, 3964);

                lengthBuffer = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 3978, 4003);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 3810, 4014);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 3810, 4014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 3810, 4014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetSymbolStoreFileName(int cchName, out int pcchName, char[] szName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 4026, 4193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 4130, 4143);

                pcchName = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 4157, 4182);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 4026, 4193);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 4026, 4193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 4026, 4193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetUserEntryPoint(out int EntryPoint)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 4205, 4354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 4278, 4304);

                EntryPoint = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 4318, 4343);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 4205, 4354);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 4205, 4354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 4205, 4354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetVariables(int parent, int cVars, out int pcVars, ISymUnmanagedVariable[] vars)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 4366, 4544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 4483, 4494);

                pcVars = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 4508, 4533);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 4366, 4544);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 4366, 4544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 4366, 4544);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int Initialize(object importer, string filename, string searchPath, IStream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 4556, 4707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 4671, 4696);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 4556, 4707);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 4556, 4707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 4556, 4707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int ReplaceSymbolStore(string filename, IStream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 4719, 4842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 4806, 4831);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 4719, 4842);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 4719, 4842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 4719, 4842);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int UpdateSymbolStore(string filename, IStream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 4854, 4976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 4940, 4965);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 4854, 4976);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 4854, 4976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 4854, 4976);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int MatchesModule(Guid guid, uint stamp, int age, out bool result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 4988, 5151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 5086, 5101);

                result = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 5115, 5140);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 4988, 5151);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 4988, 5151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 4988, 5151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe int GetPortableDebugMetadata(out byte* metadata, out int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 5163, 5353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 5264, 5280);

                metadata = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 5294, 5303);

                size = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 5317, 5342);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 5163, 5353);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 5163, 5353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 5163, 5353);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe int GetSourceServerData(out byte* data, out int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 5365, 5542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 5457, 5469);

                data = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 5483, 5492);

                size = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 5506, 5531);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 5365, 5542);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 5365, 5542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 5365, 5542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe int GetPortableDebugMetadataByVersion(int version, out byte* metadata, out int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24004, 5554, 5766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 5677, 5693);

                metadata = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 5707, 5716);

                size = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 5730, 5755);

                return HResult.E_NOTIMPL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24004, 5554, 5766);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24004, 5554, 5766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 5554, 5766);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NotImplementedSymUnmanagedReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24004, 389, 5773);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24004, 537, 586);
            Instance = f_24004_548_586(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24004, 389, 5773);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24004, 389, 5773);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24004, 389, 5773);

        static Roslyn.Test.Utilities.NotImplementedSymUnmanagedReader
        f_24004_548_586()
        {
            var return_v = new Roslyn.Test.Utilities.NotImplementedSymUnmanagedReader();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24004, 548, 586);
            return return_v;
        }

    }
}
