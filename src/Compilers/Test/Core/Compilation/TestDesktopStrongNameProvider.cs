// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.Interop;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    internal sealed class TestDesktopStrongNameProvider : DesktopStrongNameProvider
    {
        internal delegate void ReadKeysFromContainerDelegate(
           string keyContainer,
           out ImmutableArray<byte> publicKey);

        internal ReadKeysFromContainerDelegate ReadKeysFromContainerFunc { get; set; }

        internal Action<ExtendedPEBuilder, BlobBuilder, RSAParameters> SignBuilderFunc { get; set; }

        internal Action<StrongNameKeys, string> SignFileFunc { get; set; }

        internal Func<IClrStrongName> GetStrongNameInterfaceFunc { get; set; }

        public TestDesktopStrongNameProvider(ImmutableArray<string> keyFileSearchPaths = default, StrongNameFileSystem fileSystem = null)
        : base(f_25063_1215_1233_C(keyFileSearchPaths), fileSystem)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25063, 1065, 1500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25063, 717, 795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25063, 805, 897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25063, 907, 973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25063, 983, 1053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25063, 1271, 1326);

                ReadKeysFromContainerFunc = base.ReadKeysFromContainer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25063, 1340, 1375);

                SignBuilderFunc = base.SignBuilder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25063, 1389, 1418);

                SignFileFunc = base.SignFile;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25063, 1432, 1489);

                GetStrongNameInterfaceFunc = base.GetStrongNameInterface;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25063, 1065, 1500);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25063, 1065, 1500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25063, 1065, 1500);
            }
        }

        internal override void ReadKeysFromContainer(string keyContainer, out ImmutableArray<byte> publicKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25063, 1614, 1671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25063, 1617, 1671);
                f_25063_1617_1671(ReadKeysFromContainerFunc, keyContainer, out publicKey); 
                DynAbs.Tracing.TraceSender.TraceExitMethod(25063, 1614, 1671);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25063, 1614, 1671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25063, 1614, 1671);
            }

            ReadKeysFromContainerDelegate
            f_25063_1617_1642()
            {
                var return_v = ReadKeysFromContainerFunc;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25063, 1617, 1642);
                return return_v;
            }


            int
            f_25063_1617_1671(ReadKeysFromContainerDelegate
            this_param, string
            keyContainer, out System.Collections.Immutable.ImmutableArray<byte>
            publicKey)
            {
                this_param.Invoke(keyContainer, out publicKey);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25063, 1617, 1671);
                return 0;
            }

        }

        internal override void SignFile(StrongNameKeys keys, string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25063, 1754, 1785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25063, 1757, 1785);
                f_25063_1757_1785(SignFileFunc, keys, filePath); DynAbs.Tracing.TraceSender.TraceExitMethod(25063, 1754, 1785);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25063, 1754, 1785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25063, 1754, 1785);
            }

            System.Action<Microsoft.CodeAnalysis.StrongNameKeys, string>
            f_25063_1757_1769()
            {
                var return_v = SignFileFunc;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25063, 1757, 1769);
                return return_v;
            }


            int
            f_25063_1757_1785(Action<StrongNameKeys, string>
            this_param, Microsoft.CodeAnalysis.StrongNameKeys
            arg1, string
            arg2)
            {
                this_param.Invoke(arg1, arg2);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25063, 1757, 1785);
                return 0;
            }

        }

        internal override void SignBuilder(ExtendedPEBuilder peBuilder, BlobBuilder peBlob, RSAParameters privateKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25063, 1908, 1957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25063, 1911, 1957);
                f_25063_1911_1957(SignBuilderFunc, peBuilder, peBlob, privateKey); DynAbs.Tracing.TraceSender.TraceExitMethod(25063, 1908, 1957);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25063, 1908, 1957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25063, 1908, 1957);
            }

            System.Action<Microsoft.Cci.ExtendedPEBuilder, System.Reflection.Metadata.BlobBuilder, System.Security.Cryptography.RSAParameters>
            f_25063_1911_1926()
            {
                var return_v = SignBuilderFunc;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25063, 1911, 1926);
                return return_v;
            }


            int
            f_25063_1911_1957(Action<ExtendedPEBuilder, BlobBuilder, RSAParameters>
            this_param, Microsoft.Cci.ExtendedPEBuilder
            arg1, System.Reflection.Metadata.BlobBuilder
            arg2, System.Security.Cryptography.RSAParameters
            arg3)
            {
                this_param.Invoke(arg1, arg2, arg3);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25063, 1911, 1957);
                return 0;
            }

        }

        internal override IClrStrongName GetStrongNameInterface()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25063, 2028, 2059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25063, 2031, 2059);
                return f_25063_2031_2059(GetStrongNameInterfaceFunc); DynAbs.Tracing.TraceSender.TraceExitMethod(25063, 2028, 2059);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25063, 2028, 2059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25063, 2028, 2059);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Func<Microsoft.CodeAnalysis.Interop.IClrStrongName>
            f_25063_2031_2057()
            {
                var return_v = GetStrongNameInterfaceFunc;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25063, 2031, 2057);
                return return_v;
            }


            IClrStrongName
            f_25063_2031_2059(Func<IClrStrongName>
            this_param)
            {
                var return_v = this_param.Invoke();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25063, 2031, 2059);
                return return_v;
            }

        }

        static TestDesktopStrongNameProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25063, 472, 2067);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25063, 472, 2067);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25063, 472, 2067);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25063, 472, 2067);

        static System.Collections.Immutable.ImmutableArray<string>
        f_25063_1215_1233_C(System.Collections.Immutable.ImmutableArray<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(25063, 1065, 1500);
            return return_v;
        }

    }
}
