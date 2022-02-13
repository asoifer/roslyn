// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.DiaSymReader;

namespace Roslyn.Test.PdbUtilities
{
    internal class DelegatingSymUnmanagedWriter : SymUnmanagedWriter
    {
        private readonly SymUnmanagedWriter _target;

        public DelegatingSymUnmanagedWriter(SymUnmanagedWriter target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(24013, 510, 625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 490, 497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 597, 614);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(24013, 510, 625);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 510, 625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 510, 625);
            }
        }

        public override int DocumentTableCapacity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 707, 739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 710, 739);
                    return f_24013_710_739(_target); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 707, 739);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 637, 810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 637, 810);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 758, 798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 761, 798);
                    _target.DocumentTableCapacity = value; DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 758, 798);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 637, 810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 637, 810);
                }
            }
        }

        public override void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 853, 873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 856, 873);
                f_24013_856_873(_target); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 853, 873);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 853, 873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 853, 873);
            }
        }

        public override void CloseMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 919, 943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 922, 943);
                f_24013_922_943(_target); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 919, 943);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 919, 943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 919, 943);
            }
        }

        public override void CloseScope(int endOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 1001, 1033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 1004, 1033);
                f_24013_1004_1033(_target, endOffset); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 1001, 1033);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 1001, 1033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 1001, 1033);
            }
        }

        public override void CloseTokensToSourceSpansMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 1095, 1135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 1098, 1135);
                f_24013_1098_1135(_target); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 1095, 1135);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 1095, 1135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 1095, 1135);
            }
        }

        public override void DefineCustomMetadata(byte[] metadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 1205, 1246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 1208, 1246);
                f_24013_1208_1246(_target, metadata); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 1205, 1246);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 1205, 1246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 1205, 1246);
            }
        }

        public override int DefineDocument(string name, Guid language, Guid vendor, Guid type, Guid algorithmId, ReadOnlySpan<byte> checksum, ReadOnlySpan<byte> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 1433, 1519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 1436, 1519);
                return f_24013_1436_1519(_target, name, language, vendor, type, algorithmId, checksum, source); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 1433, 1519);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 1433, 1519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 1433, 1519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool DefineLocalConstant(string name, object value, int constantSignatureToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 1641, 1708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 1644, 1708);
                return f_24013_1644_1708(_target, name, value, constantSignatureToken); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 1641, 1708);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 1641, 1708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 1641, 1708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void DefineLocalVariable(int index, string name, int attributes, int localSignatureToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 1840, 1916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 1843, 1916);
                f_24013_1843_1916(_target, index, name, attributes, localSignatureToken); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 1840, 1916);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 1840, 1916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 1840, 1916);
            }
        }

        public override void DefineSequencePoints(int documentIndex, int count, int[] offsets, int[] startLines, int[] startColumns, int[] endLines, int[] endColumns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 2101, 2211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 2104, 2211);
                f_24013_2104_2211(_target, documentIndex, count, offsets, startLines, startColumns, endLines, endColumns); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 2101, 2211);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 2101, 2211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 2101, 2211);
            }
        }

        public override void GetSignature(out Guid guid, out uint stamp, out int age)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 2315, 2368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 2318, 2368);
                f_24013_2318_2368(_target, out guid, out stamp, out age); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 2315, 2368);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 2315, 2368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 2315, 2368);
            }
        }

        public override IEnumerable<ArraySegment<byte>> GetUnderlyingData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 2462, 2492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 2465, 2492);
                return f_24013_2465_2492(_target); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 2462, 2492);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 2462, 2492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 2462, 2492);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void MapTokenToSourceSpan(int token, int documentIndex, int startLine, int startColumn, int endLine, int endColumn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 2650, 2747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 2653, 2747);
                f_24013_2653_2747(_target, token, documentIndex, startLine, startColumn, endLine, endColumn); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 2650, 2747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 2650, 2747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 2650, 2747);
            }
        }

        public override void OpenMethod(int methodToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 2822, 2856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 2825, 2856);
                f_24013_2825_2856(_target, methodToken); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 2822, 2856);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 2822, 2856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 2822, 2856);
            }
        }

        public override void OpenScope(int startOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 2930, 2963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 2933, 2963);
                f_24013_2933_2963(_target, startOffset); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 2930, 2963);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 2930, 2963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 2930, 2963);
            }
        }

        public override void OpenTokensToSourceSpansMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 3039, 3078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 3042, 3078);
                f_24013_3042_3078(_target); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 3039, 3078);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 3039, 3078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 3039, 3078);
            }
        }

        public override void SetAsyncInfo(int moveNextMethodToken, int kickoffMethodToken, int catchHandlerOffset, ReadOnlySpan<int> yieldOffsets, ReadOnlySpan<int> resumeOffsets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 3276, 3389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 3279, 3389);
                f_24013_3279_3389(_target, moveNextMethodToken, kickoffMethodToken, catchHandlerOffset, yieldOffsets, resumeOffsets); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 3276, 3389);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 3276, 3389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 3276, 3389);
            }
        }

        public override void SetEntryPoint(int entryMethodToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 3472, 3514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 3475, 3514);
                f_24013_3475_3514(_target, entryMethodToken); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 3472, 3514);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 3472, 3514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 3472, 3514);
            }
        }

        public override void SetSourceLinkData(byte[] data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 3592, 3626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 3595, 3626);
                f_24013_3595_3626(_target, data); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 3592, 3626);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 3592, 3626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 3592, 3626);
            }
        }

        public override void SetSourceServerData(byte[] data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 3706, 3742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 3709, 3742);
                f_24013_3709_3742(_target, data); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 3706, 3742);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 3706, 3742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 3706, 3742);
            }
        }

        public override void UpdateSignature(Guid guid, uint stamp, int age)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 3837, 3881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 3840, 3881);
                f_24013_3840_3881(_target, guid, stamp, age); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 3837, 3881);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 3837, 3881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 3837, 3881);
            }
        }

        public override void UsingNamespace(string importString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 3964, 4003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 3967, 4003);
                f_24013_3967_4003(_target, importString); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 3964, 4003);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 3964, 4003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 3964, 4003);
            }
        }

        public override void WriteTo(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24013, 4073, 4099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24013, 4076, 4099);
                f_24013_4076_4099(_target, stream); DynAbs.Tracing.TraceSender.TraceExitMethod(24013, 4073, 4099);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24013, 4073, 4099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 4073, 4099);
            }
        }

        static DelegatingSymUnmanagedWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24013, 373, 4107);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24013, 373, 4107);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24013, 373, 4107);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24013, 373, 4107);

        int
        f_24013_710_739(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param)
        {
            var return_v = this_param.DocumentTableCapacity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24013, 710, 739);
            return return_v;
        }


        int
        f_24013_856_873(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param)
        {
            this_param.Dispose();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 856, 873);
            return 0;
        }


        int
        f_24013_922_943(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param)
        {
            this_param.CloseMethod();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 922, 943);
            return 0;
        }


        int
        f_24013_1004_1033(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, int
        endOffset)
        {
            this_param.CloseScope(endOffset);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 1004, 1033);
            return 0;
        }


        int
        f_24013_1098_1135(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param)
        {
            this_param.CloseTokensToSourceSpansMap();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 1098, 1135);
            return 0;
        }


        int
        f_24013_1208_1246(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, byte[]
        metadata)
        {
            this_param.DefineCustomMetadata(metadata);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 1208, 1246);
            return 0;
        }


        int
        f_24013_1436_1519(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, string
        name, System.Guid
        language, System.Guid
        vendor, System.Guid
        type, System.Guid
        algorithmId, System.ReadOnlySpan<byte>
        checksum, System.ReadOnlySpan<byte>
        source)
        {
            var return_v = this_param.DefineDocument(name, language, vendor, type, algorithmId, checksum, source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 1436, 1519);
            return return_v;
        }


        bool
        f_24013_1644_1708(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, string
        name, object
        value, int
        constantSignatureToken)
        {
            var return_v = this_param.DefineLocalConstant(name, value, constantSignatureToken);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 1644, 1708);
            return return_v;
        }


        int
        f_24013_1843_1916(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, int
        index, string
        name, int
        attributes, int
        localSignatureToken)
        {
            this_param.DefineLocalVariable(index, name, attributes, localSignatureToken);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 1843, 1916);
            return 0;
        }


        int
        f_24013_2104_2211(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, int
        documentIndex, int
        count, int[]
        offsets, int[]
        startLines, int[]
        startColumns, int[]
        endLines, int[]
        endColumns)
        {
            this_param.DefineSequencePoints(documentIndex, count, offsets, startLines, startColumns, endLines, endColumns);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 2104, 2211);
            return 0;
        }


        int
        f_24013_2318_2368(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, out System.Guid
        guid, out uint
        stamp, out int
        age)
        {
            this_param.GetSignature(out guid, out stamp, out age);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 2318, 2368);
            return 0;
        }


        System.Collections.Generic.IEnumerable<System.ArraySegment<byte>>
        f_24013_2465_2492(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param)
        {
            var return_v = this_param.GetUnderlyingData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 2465, 2492);
            return return_v;
        }


        int
        f_24013_2653_2747(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, int
        token, int
        documentIndex, int
        startLine, int
        startColumn, int
        endLine, int
        endColumn)
        {
            this_param.MapTokenToSourceSpan(token, documentIndex, startLine, startColumn, endLine, endColumn);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 2653, 2747);
            return 0;
        }


        int
        f_24013_2825_2856(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, int
        methodToken)
        {
            this_param.OpenMethod(methodToken);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 2825, 2856);
            return 0;
        }


        int
        f_24013_2933_2963(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, int
        startOffset)
        {
            this_param.OpenScope(startOffset);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 2933, 2963);
            return 0;
        }


        int
        f_24013_3042_3078(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param)
        {
            this_param.OpenTokensToSourceSpansMap();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 3042, 3078);
            return 0;
        }


        int
        f_24013_3279_3389(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, int
        moveNextMethodToken, int
        kickoffMethodToken, int
        catchHandlerOffset, System.ReadOnlySpan<int>
        yieldOffsets, System.ReadOnlySpan<int>
        resumeOffsets)
        {
            this_param.SetAsyncInfo(moveNextMethodToken, kickoffMethodToken, catchHandlerOffset, yieldOffsets, resumeOffsets);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 3279, 3389);
            return 0;
        }


        int
        f_24013_3475_3514(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, int
        entryMethodToken)
        {
            this_param.SetEntryPoint(entryMethodToken);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 3475, 3514);
            return 0;
        }


        int
        f_24013_3595_3626(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, byte[]
        data)
        {
            this_param.SetSourceLinkData(data);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 3595, 3626);
            return 0;
        }


        int
        f_24013_3709_3742(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, byte[]
        data)
        {
            this_param.SetSourceServerData(data);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 3709, 3742);
            return 0;
        }


        int
        f_24013_3840_3881(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, System.Guid
        guid, uint
        stamp, int
        age)
        {
            this_param.UpdateSignature(guid, stamp, age);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 3840, 3881);
            return 0;
        }


        int
        f_24013_3967_4003(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, string
        importString)
        {
            this_param.UsingNamespace(importString);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 3967, 4003);
            return 0;
        }


        int
        f_24013_4076_4099(Microsoft.DiaSymReader.SymUnmanagedWriter
        this_param, System.IO.Stream
        stream)
        {
            this_param.WriteTo(stream);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24013, 4076, 4099);
            return 0;
        }

    }
}
