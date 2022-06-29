// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using Microsoft.CodeAnalysis.Text;
using Cci = Microsoft.Cci;
using DWORD = System.UInt32;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal class Win32Resource : Cci.IWin32Resource
    {
        private readonly byte[] _data;

        private readonly DWORD _codePage;

        private readonly DWORD _languageId;

        private readonly int _id;

        private readonly string _name;

        private readonly int _typeId;

        private readonly string _typeName;

        internal Win32Resource(
                    byte[] data,
                    DWORD codePage,
                    DWORD languageId,
                    int id,
                    string name,
                    int typeId,
                    string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(90, 763, 1213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 499, 504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 538, 547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 581, 592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 624, 627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 662, 667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 699, 706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 741, 750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 999, 1012);

                _data = data;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1026, 1047);

                _codePage = codePage;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1061, 1086);

                _languageId = languageId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1100, 1109);

                _id = id;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1123, 1136);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1150, 1167);

                _typeId = typeId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1181, 1202);

                _typeName = typeName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(90, 763, 1213);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(90, 763, 1213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(90, 763, 1213);
            }
        }

        public string TypeName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(90, 1248, 1260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1251, 1260);
                    return _typeName; DynAbs.Tracing.TraceSender.TraceExitMethod(90, 1248, 1260);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(90, 1248, 1260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(90, 1248, 1260);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int TypeId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(90, 1291, 1301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1294, 1301);
                    return _typeId; DynAbs.Tracing.TraceSender.TraceExitMethod(90, 1291, 1301);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(90, 1291, 1301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(90, 1291, 1301);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(90, 1333, 1341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1336, 1341);
                    return _name; DynAbs.Tracing.TraceSender.TraceExitMethod(90, 1333, 1341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(90, 1333, 1341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(90, 1333, 1341);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Id
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(90, 1368, 1374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1371, 1374);
                    return _id; DynAbs.Tracing.TraceSender.TraceExitMethod(90, 1368, 1374);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(90, 1368, 1374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(90, 1368, 1374);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DWORD LanguageId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(90, 1411, 1425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1414, 1425);
                    return _languageId; DynAbs.Tracing.TraceSender.TraceExitMethod(90, 1411, 1425);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(90, 1411, 1425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(90, 1411, 1425);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DWORD CodePage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(90, 1460, 1472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1463, 1472);
                    return _codePage; DynAbs.Tracing.TraceSender.TraceExitMethod(90, 1460, 1472);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(90, 1460, 1472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(90, 1460, 1472);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<byte> Data
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(90, 1515, 1523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(90, 1518, 1523);
                    return _data; DynAbs.Tracing.TraceSender.TraceExitMethod(90, 1515, 1523);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(90, 1515, 1523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(90, 1515, 1523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static Win32Resource()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(90, 409, 1531);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(90, 409, 1531);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(90, 409, 1531);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(90, 409, 1531);
    }
}
