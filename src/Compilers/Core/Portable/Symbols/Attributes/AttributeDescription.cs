// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Reflection.Metadata;
using System.Collections.Immutable;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    internal struct AttributeDescription
    {

        public readonly string Namespace;

        public readonly string Name;

        public readonly byte[][] Signatures;

        public readonly bool MatchIgnoringCase;

        public AttributeDescription(string @namespace, string name, byte[][] signatures, bool matchIgnoringCase = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(784, 750, 1212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 887, 926);

                f_784_887_925(@namespace != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 940, 973);

                f_784_940_972(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 987, 1026);

                f_784_987_1025(signatures != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 1042, 1070);

                this.Namespace = @namespace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 1084, 1101);

                this.Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 1115, 1144);

                this.Signatures = signatures;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 1158, 1201);

                this.MatchIgnoringCase = matchIgnoringCase;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(784, 750, 1212);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(784, 750, 1212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(784, 750, 1212);
            }
        }

        public string FullName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(784, 1271, 1309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 1277, 1307);

                    return Namespace + "." + Name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(784, 1271, 1309);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(784, 1224, 1320);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(784, 1224, 1320);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(784, 1332, 1449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 1390, 1438);

                // LAFHIS
                //return FullName + "(" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_784_1414_1431(Signatures)).ToString(), 784, 1414, 1431) + ")";
                var temp = FullName + "(" + (f_784_1414_1431(Signatures)).ToString() + ")";
                DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 1414, 1431);
                return temp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(784, 1332, 1449);

                int
                f_784_1414_1431(byte[][]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(784, 1414, 1431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(784, 1332, 1449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(784, 1332, 1449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int GetParameterCount(int signatureIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(784, 1461, 1833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 1536, 1584);

                var
                signature = this.Signatures[signatureIndex]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 1649, 1714);

                f_784_1649_1713(signature[0] == (byte)SignatureAttributes.Instance);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 1802, 1822);

                return signature[1];
                DynAbs.Tracing.TraceSender.TraceExitMethod(784, 1461, 1833);

                int
                f_784_1649_1713(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 1649, 1713);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(784, 1461, 1833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(784, 1461, 1833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const byte
        Void = (byte)SignatureTypeCode.Void
        ;

        private const byte
        Boolean = (byte)SignatureTypeCode.Boolean
        ;

        private const byte
        Char = (byte)SignatureTypeCode.Char
        ;

        private const byte
        SByte = (byte)SignatureTypeCode.SByte
        ;

        private const byte
        Byte = (byte)SignatureTypeCode.Byte
        ;

        private const byte
        Int16 = (byte)SignatureTypeCode.Int16
        ;

        private const byte
        UInt16 = (byte)SignatureTypeCode.UInt16
        ;

        private const byte
        Int32 = (byte)SignatureTypeCode.Int32
        ;

        private const byte
        UInt32 = (byte)SignatureTypeCode.UInt32
        ;

        private const byte
        Int64 = (byte)SignatureTypeCode.Int64
        ;

        private const byte
        UInt64 = (byte)SignatureTypeCode.UInt64
        ;

        private const byte
        Single = (byte)SignatureTypeCode.Single
        ;

        private const byte
        Double = (byte)SignatureTypeCode.Double
        ;

        private const byte
        String = (byte)SignatureTypeCode.String
        ;

        private const byte
        Object = (byte)SignatureTypeCode.Object
        ;

        private const byte
        SzArray = (byte)SignatureTypeCode.SZArray
        ;

        private const byte
        TypeHandle = (byte)SignatureTypeCode.TypeHandle
        ;

        internal enum TypeHandleTarget : byte
        {
            AttributeTargets,
            AssemblyNameFlags,
            MethodImplOptions,
            CharSet,
            LayoutKind,
            UnmanagedType,
            TypeLibTypeFlags,
            ClassInterfaceType,
            ComInterfaceType,
            CompilationRelaxations,
            DebuggingModes,
            SecurityCriticalScope,
            CallingConvention,
            AssemblyHashAlgorithm,
            TransactionOption,
            SecurityAction,
            SystemType,
            DeprecationType,
            Platform
        }

        internal struct TypeHandleTargetInfo
        {

            public readonly string Namespace;

            public readonly string Name;

            public readonly SerializationTypeCode Underlying;

            public TypeHandleTargetInfo(string @namespace, string name, SerializationTypeCode underlying)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(784, 3953, 4189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 4079, 4102);

                    Namespace = @namespace;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 4120, 4132);

                    Name = name;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 4150, 4174);

                    Underlying = underlying;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(784, 3953, 4189);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(784, 3953, 4189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(784, 3953, 4189);
                }
            }
            static TypeHandleTargetInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(784, 3738, 4200);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(784, 3738, 4200);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(784, 3738, 4200);
            }
        }

        internal static ImmutableArray<TypeHandleTargetInfo> TypeHandleTargets;

        static AttributeDescription()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(784, 4295, 6741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 4349, 4380);

                const string
                system = "System"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 4394, 4460);

                const string
                compilerServices = "System.Runtime.CompilerServices"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 4474, 4538);

                const string
                interopServices = "System.Runtime.InteropServices"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 4554, 6730);

                TypeHandleTargets = f_784_4574_6729((new[] {
f_784_4601_4681(system, "AttributeTargets", SerializationTypeCode.Int32)                ,f_784_4700_4794("System.Reflection", "AssemblyNameFlags", SerializationTypeCode.Int32)                ,f_784_4813_4904(compilerServices, "MethodImplOptions", SerializationTypeCode.Int32)                ,f_784_4923_5003(interopServices, "CharSet", SerializationTypeCode.Int32)                ,f_784_5022_5105(interopServices, "LayoutKind", SerializationTypeCode.Int32)                ,f_784_5124_5210(interopServices, "UnmanagedType", SerializationTypeCode.Int32)                ,f_784_5229_5318(interopServices, "TypeLibTypeFlags", SerializationTypeCode.Int32)                ,f_784_5337_5428(interopServices, "ClassInterfaceType", SerializationTypeCode.Int32)                ,f_784_5447_5536(interopServices, "ComInterfaceType", SerializationTypeCode.Int32)                ,f_784_5555_5651(compilerServices, "CompilationRelaxations", SerializationTypeCode.Int32)                ,f_784_5670_5782("System.Diagnostics.DebuggableAttribute", "DebuggingModes", SerializationTypeCode.Int32)                ,f_784_5801_5897("System.Security", "SecurityCriticalScope", SerializationTypeCode.Int32)                ,f_784_5916_6006(interopServices, "CallingConvention", SerializationTypeCode.Int32)                ,f_784_6025_6137("System.Configuration.Assemblies", "AssemblyHashAlgorithm", SerializationTypeCode.Int32)                ,f_784_6156_6258("System.EnterpriseServices", "TransactionOption", SerializationTypeCode.Int32)                ,f_784_6277_6378("System.Security.Permissions", "SecurityAction", SerializationTypeCode.Int32)                ,f_784_6397_6464(system, "Type", SerializationTypeCode.Type)                ,f_784_6483_6585("Windows.Foundation.Metadata", "DeprecationType", SerializationTypeCode.Int32)                ,f_784_6604_6699("Windows.Foundation.Metadata", "Platform", SerializationTypeCode.Int32)            }));
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(784, 4295, 6741);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(784, 4295, 6741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(784, 4295, 6741);
            }
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 1946, 1981);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2011, 2052);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2082, 2117);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2147, 2184);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2214, 2249);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2279, 2316);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2346, 2385);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2415, 2452);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2482, 2521);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2551, 2588);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2618, 2657);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2687, 2726);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2756, 2795);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2825, 2864);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2894, 2933);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 2963, 3004);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 3034, 3081);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 4265, 4282);
            TypeHandleTargets = default(ImmutableArray<TypeHandleTargetInfo>); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 6784, 6869);
            s_signature_HasThis_Void = new byte[] { (byte)SignatureAttributes.Instance, 0, Void }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 6911, 7007);
            s_signature_HasThis_Void_Byte = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, Byte }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 7049, 7147);
            s_signature_HasThis_Void_Int16 = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, Int16 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 7189, 7287);
            s_signature_HasThis_Void_Int32 = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 7329, 7429);
            s_signature_HasThis_Void_UInt32 = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, UInt32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 7471, 7582);
            s_signature_HasThis_Void_Int32_Int32 = new byte[] { (byte)SignatureAttributes.Instance, 2, Void, Int32, Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 7624, 7761);
            s_signature_HasThis_Void_Int32_Int32_Int32_Int32 = new byte[] { (byte)SignatureAttributes.Instance, 4, Void, Int32, Int32, Int32, Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 7803, 7903);
            s_signature_HasThis_Void_String = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 7945, 8045);
            s_signature_HasThis_Void_Object = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, Object }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 8087, 8202);
            s_signature_HasThis_Void_String_String = new byte[] { (byte)SignatureAttributes.Instance, 2, Void, String, String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 8244, 8361);
            s_signature_HasThis_Void_String_Boolean = new byte[] { (byte)SignatureAttributes.Instance, 2, Void, String, Boolean }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 8403, 8533);
            s_signature_HasThis_Void_String_String_String = new byte[] { (byte)SignatureAttributes.Instance, 3, Void, String, String, String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 8575, 8720);
            s_signature_HasThis_Void_String_String_String_String = new byte[] { (byte)SignatureAttributes.Instance, 4, Void, String, String, String, String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 8762, 8917);
            s_signature_HasThis_Void_AttributeTargets = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.AttributeTargets }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 8959, 9116);
            s_signature_HasThis_Void_AssemblyNameFlags = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.AssemblyNameFlags }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 9158, 9315);
            s_signature_HasThis_Void_MethodImplOptions = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.MethodImplOptions }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 9357, 9494);
            s_signature_HasThis_Void_CharSet = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.CharSet }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 9536, 9679);
            s_signature_HasThis_Void_LayoutKind = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.LayoutKind }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 9721, 9870);
            s_signature_HasThis_Void_UnmanagedType = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.UnmanagedType }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 9912, 10067);
            s_signature_HasThis_Void_TypeLibTypeFlags = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.TypeLibTypeFlags }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 10109, 10268);
            s_signature_HasThis_Void_ClassInterfaceType = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.ClassInterfaceType }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 10310, 10465);
            s_signature_HasThis_Void_ComInterfaceType = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.ComInterfaceType }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 10507, 10674);
            s_signature_HasThis_Void_CompilationRelaxations = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.CompilationRelaxations }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 10716, 10867);
            s_signature_HasThis_Void_DebuggingModes = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.DebuggingModes }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 10909, 11074);
            s_signature_HasThis_Void_SecurityCriticalScope = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.SecurityCriticalScope }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 11116, 11273);
            s_signature_HasThis_Void_CallingConvention = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.CallingConvention }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 11315, 11480);
            s_signature_HasThis_Void_AssemblyHashAlgorithm = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.AssemblyHashAlgorithm }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 11522, 11620);
            s_signature_HasThis_Void_Int64 = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, Int64 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 11662, 11829);
            s_signature_HasThis_Void_UInt8_UInt8_UInt32_UInt32_UInt32 = new byte[] {
            (byte)SignatureAttributes.Instance, 5, Void, Byte, Byte, UInt32, UInt32, UInt32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 11871, 12031);
            s_signature_HasThis_Void_UIn8_UInt8_Int32_Int32_Int32 = new byte[] {
            (byte)SignatureAttributes.Instance, 5, Void, Byte, Byte, Int32, Int32, Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 12077, 12179);
            s_signature_HasThis_Void_Boolean = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, Boolean }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 12221, 12340);
            s_signature_HasThis_Void_Boolean_Boolean = new byte[] { (byte)SignatureAttributes.Instance, 2, Void, Boolean, Boolean }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 12384, 12558);
            s_signature_HasThis_Void_Boolean_TransactionOption = new byte[] { (byte)SignatureAttributes.Instance, 2, Void, Boolean, TypeHandle, (byte)TypeHandleTarget.TransactionOption }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 12600, 12787);
            s_signature_HasThis_Void_Boolean_TransactionOption_Int32 = new byte[] { (byte)SignatureAttributes.Instance, 3, Void, Boolean, TypeHandle, (byte)TypeHandleTarget.TransactionOption, Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 12829, 13033);
            s_signature_HasThis_Void_Boolean_TransactionOption_Int32_Boolean = new byte[] { (byte)SignatureAttributes.Instance, 4, Void, Boolean, TypeHandle, (byte)TypeHandleTarget.TransactionOption, Int32, Boolean }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 13077, 13228);
            s_signature_HasThis_Void_SecurityAction = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.SecurityAction }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 13270, 13407);
            s_signature_HasThis_Void_Type = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, TypeHandle, (byte)TypeHandleTarget.SystemType }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 13449, 13638);
            s_signature_HasThis_Void_Type_Type = new byte[] { (byte)SignatureAttributes.Instance, 2, Void, TypeHandle, (byte)TypeHandleTarget.SystemType, TypeHandle, (byte)TypeHandleTarget.SystemType }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 13680, 13921);
            s_signature_HasThis_Void_Type_Type_Type = new byte[] { (byte)SignatureAttributes.Instance, 3, Void, TypeHandle, (byte)TypeHandleTarget.SystemType, TypeHandle, (byte)TypeHandleTarget.SystemType, TypeHandle, (byte)TypeHandleTarget.SystemType }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 13963, 14256);
            s_signature_HasThis_Void_Type_Type_Type_Type = new byte[] { (byte)SignatureAttributes.Instance, 4, Void, TypeHandle, (byte)TypeHandleTarget.SystemType, TypeHandle, (byte)TypeHandleTarget.SystemType, TypeHandle, (byte)TypeHandleTarget.SystemType, TypeHandle, (byte)TypeHandleTarget.SystemType }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 14298, 14448);
            s_signature_HasThis_Void_Type_Int32 = new byte[] { (byte)SignatureAttributes.Instance, 2, Void, TypeHandle, (byte)TypeHandleTarget.SystemType, Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 14492, 14611);
            s_signature_HasThis_Void_SzArray_Boolean = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, SzArray, Boolean }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 14653, 14766);
            s_signature_HasThis_Void_SzArray_Byte = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, SzArray, Byte }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 14808, 14925);
            s_signature_HasThis_Void_SzArray_String = new byte[] { (byte)SignatureAttributes.Instance, 1, Void, SzArray, String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 14967, 15101);
            s_signature_HasThis_Void_Boolean_SzArray_String = new byte[] { (byte)SignatureAttributes.Instance, 2, Void, Boolean, SzArray, String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 15143, 15260);
            s_signature_HasThis_Void_Boolean_String = new byte[] { (byte)SignatureAttributes.Instance, 2, Void, Boolean, String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 15304, 15487);
            s_signature_HasThis_Void_String_DeprecationType_UInt32 = new byte[] { (byte)SignatureAttributes.Instance, 3, Void, String, TypeHandle, (byte)TypeHandleTarget.DeprecationType, UInt32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 15529, 15766);
            s_signature_HasThis_Void_String_DeprecationType_UInt32_Platform = new byte[] { (byte)SignatureAttributes.Instance, 4, Void, String, TypeHandle, (byte)TypeHandleTarget.DeprecationType, UInt32, TypeHandle, (byte)TypeHandleTarget.Platform }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 15808, 16043);
            s_signature_HasThis_Void_String_DeprecationType_UInt32_Type = new byte[] { (byte)SignatureAttributes.Instance, 4, Void, String, TypeHandle, (byte)TypeHandleTarget.DeprecationType, UInt32, TypeHandle, (byte)TypeHandleTarget.SystemType }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 16085, 16283);
            s_signature_HasThis_Void_String_DeprecationType_UInt32_String = new byte[] { (byte)SignatureAttributes.Instance, 4, Void, String, TypeHandle, (byte)TypeHandleTarget.DeprecationType, UInt32, String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 16329, 16390);
            s_signatures_HasThis_Void_Only = new byte[][] { s_signature_HasThis_Void }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 16434, 16509);
            s_signatures_HasThis_Void_String_Only = new byte[][] { s_signature_HasThis_Void_String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 16553, 16624);
            s_signatures_HasThis_Void_Type_Only = new byte[][] { s_signature_HasThis_Void_Type }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 16668, 16745);
            s_signatures_HasThis_Void_Boolean_Only = new byte[][] { s_signature_HasThis_Void_Boolean }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 16791, 16899);
            s_signaturesOfTypeIdentifierAttribute = new byte[][] { s_signature_HasThis_Void, s_signature_HasThis_Void_String_String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 16943, 17019);
            s_signaturesOfAttributeUsage = new byte[][] { s_signature_HasThis_Void_AttributeTargets }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 17063, 17151);
            s_signaturesOfAssemblySignatureKeyAttribute = new byte[][] { s_signature_HasThis_Void_String_String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 17195, 17402);
            s_signaturesOfAssemblyFlagsAttribute = new byte[][]{
                s_signature_HasThis_Void_AssemblyNameFlags,
            s_signature_HasThis_Void_Int32,
            s_signature_HasThis_Void_UInt32
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 17446, 17528);
            s_signaturesOfDefaultParameterValueAttribute = new byte[][] { s_signature_HasThis_Void_Object }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 17572, 17648);
            s_signaturesOfDateTimeConstantAttribute = new byte[][] { s_signature_HasThis_Void_Int64 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 17692, 17849);
            s_signaturesOfDecimalConstantAttribute = new byte[][] { s_signature_HasThis_Void_UInt8_UInt8_UInt32_UInt32_UInt32, s_signature_HasThis_Void_UIn8_UInt8_Int32_Int32_Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 17893, 17980);
            s_signaturesOfSecurityPermissionAttribute = new byte[][] { s_signature_HasThis_Void_SecurityAction }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 18026, 18224);
            s_signaturesOfMethodImplAttribute = new byte[][]{
                s_signature_HasThis_Void,
            s_signature_HasThis_Void_Int16,
            s_signature_HasThis_Void_MethodImplOptions,
        }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 18270, 18346);
            s_signaturesOfDefaultCharSetAttribute = new byte[][] { s_signature_HasThis_Void_CharSet }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 18392, 18463);
            s_signaturesOfFieldOffsetAttribute = new byte[][] { s_signature_HasThis_Void_Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 18507, 18622);
            s_signaturesOfMemberNotNullAttribute = new byte[][] { s_signature_HasThis_Void_String, s_signature_HasThis_Void_SzArray_String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 18666, 18801);
            s_signaturesOfMemberNotNullWhenAttribute = new byte[][] { s_signature_HasThis_Void_Boolean_String, s_signature_HasThis_Void_Boolean_SzArray_String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 18845, 18921);
            s_signaturesOfFixedBufferAttribute = new byte[][] { s_signature_HasThis_Void_Type_Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 18965, 19053);
            s_signaturesOfPrincipalPermissionAttribute = new byte[][] { s_signature_HasThis_Void_SecurityAction }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 19097, 19179);
            s_signaturesOfPermissionSetAttribute = new byte[][] { s_signature_HasThis_Void_SecurityAction }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 19225, 19379);
            s_signaturesOfStructLayoutAttribute = new byte[][]{
                s_signature_HasThis_Void_Int16,
            s_signature_HasThis_Void_LayoutKind,
        }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 19425, 19579);
            s_signaturesOfMarshalAsAttribute = new byte[][]{
                s_signature_HasThis_Void_Int16,
            s_signature_HasThis_Void_UnmanagedType,
        }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 19625, 19784);
            s_signaturesOfTypeLibTypeAttribute = new byte[][]{
                s_signature_HasThis_Void_Int16,
            s_signature_HasThis_Void_TypeLibTypeFlags,
        }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 19830, 20186);
            s_signaturesOfWebMethodAttribute = new byte[][]{
                s_signature_HasThis_Void,
            s_signature_HasThis_Void_Boolean,
            s_signature_HasThis_Void_Boolean_TransactionOption,
            s_signature_HasThis_Void_Boolean_TransactionOption_Int32,
            s_signature_HasThis_Void_Boolean_TransactionOption_Int32_Boolean
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 20232, 20385);
            s_signaturesOfHostProtectionAttribute = new byte[][]{
                s_signature_HasThis_Void,
            s_signature_HasThis_Void_SecurityAction
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 20431, 20694);
            s_signaturesOfVisualBasicComClassAttribute = new byte[][]{
                s_signature_HasThis_Void,
            s_signature_HasThis_Void_String,
            s_signature_HasThis_Void_String_String,
            s_signature_HasThis_Void_String_String_String
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 20740, 20903);
            s_signaturesOfClassInterfaceAttribute = new byte[][]{
                s_signature_HasThis_Void_Int16,
            s_signature_HasThis_Void_ClassInterfaceType
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 20949, 21109);
            s_signaturesOfInterfaceTypeAttribute = new byte[][]{
                s_signature_HasThis_Void_Int16,
            s_signature_HasThis_Void_ComInterfaceType
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 21155, 21330);
            s_signaturesOfCompilationRelaxationsAttribute = new byte[][]{
                s_signature_HasThis_Void_Int32,
            s_signature_HasThis_Void_CompilationRelaxations
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 21376, 21541);
            s_signaturesOfDebuggableAttribute = new byte[][]{
                s_signature_HasThis_Void_Boolean_Boolean,
            s_signature_HasThis_Void_DebuggingModes
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 21587, 21904);
            s_signaturesOfComSourceInterfacesAttribute = new byte[][]{
                s_signature_HasThis_Void_String,
            s_signature_HasThis_Void_Type,
            s_signature_HasThis_Void_Type_Type,
            s_signature_HasThis_Void_Type_Type_Type,
            s_signature_HasThis_Void_Type_Type_Type_Type
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 21950, 22030);
            s_signaturesOfTypeLibVersionAttribute = new byte[][] { s_signature_HasThis_Void_Int32_Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 22074, 22172);
            s_signaturesOfComCompatibleVersionAttribute = new byte[][] { s_signature_HasThis_Void_Int32_Int32_Int32_Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 22216, 22352);
            s_signaturesOfObsoleteAttribute = new byte[][] { s_signature_HasThis_Void, s_signature_HasThis_Void_String, s_signature_HasThis_Void_String_Boolean }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 22396, 22499);
            s_signaturesOfDynamicAttribute = new byte[][] { s_signature_HasThis_Void, s_signature_HasThis_Void_SzArray_Boolean }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 22543, 22655);
            s_signaturesOfTupleElementNamesAttribute = new byte[][] { s_signature_HasThis_Void, s_signature_HasThis_Void_SzArray_String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 22701, 22863);
            s_signaturesOfSecurityCriticalAttribute = new byte[][]{
                s_signature_HasThis_Void,
            s_signature_HasThis_Void_SecurityCriticalScope
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 22909, 23008);
            s_signaturesOfMyGroupCollectionAttribute = new byte[][] { s_signature_HasThis_Void_String_String_String_String }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 23052, 23133);
            s_signaturesOfComEventInterfaceAttribute = new byte[][] { s_signature_HasThis_Void_Type_Type }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 23177, 23251);
            s_signaturesOfLCIDConversionAttribute = new byte[][] { s_signature_HasThis_Void_Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 23295, 23391);
            s_signaturesOfUnmanagedFunctionPointerAttribute = new byte[][] { s_signature_HasThis_Void_CallingConvention }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 23435, 23523);
            s_signaturesOfPrimaryInteropAssemblyAttribute = new byte[][] { s_signature_HasThis_Void_Int32_Int32 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 23567, 23739);
            s_signaturesOfAssemblyAlgorithmIdAttribute = new byte[][]{
                s_signature_HasThis_Void_AssemblyHashAlgorithm,
            s_signature_HasThis_Void_UInt32
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 23785, 24139);
            s_signaturesOfDeprecatedAttribute = new byte[][]{
                s_signature_HasThis_Void_String_DeprecationType_UInt32,
            s_signature_HasThis_Void_String_DeprecationType_UInt32_Platform,
            s_signature_HasThis_Void_String_DeprecationType_UInt32_Type,
            s_signature_HasThis_Void_String_DeprecationType_UInt32_String,
        }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 24185, 24291);
            s_signaturesOfNullableAttribute = new byte[][] { s_signature_HasThis_Void_Byte, s_signature_HasThis_Void_SzArray_Byte }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 24335, 24409);
            s_signaturesOfNullableContextAttribute = new byte[][] { s_signature_HasThis_Void_Byte }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 24453, 24562);
            s_signaturesOfNativeIntegerAttribute = new byte[][] { s_signature_HasThis_Void, s_signature_HasThis_Void_SzArray_Boolean }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 24659, 24790);
            OptionalAttribute = f_784_24679_24790("System.Runtime.InteropServices", "OptionalAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 24847, 24980);
            ComImportAttribute = f_784_24868_24980("System.Runtime.InteropServices", "ComImportAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 25037, 25154);
            AttributeUsageAttribute = f_784_25063_25154("System", "AttributeUsageAttribute", s_signaturesOfAttributeUsage); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 25211, 25343);
            ConditionalAttribute = f_784_25234_25343("System.Diagnostics", "ConditionalAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 25400, 25574);
            CaseInsensitiveExtensionAttribute = f_784_25436_25574("System.Runtime.CompilerServices", "ExtensionAttribute", s_signatures_HasThis_Void_Only, matchIgnoringCase: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 25631, 25804);
            CaseSensitiveExtensionAttribute = f_784_25665_25804("System.Runtime.CompilerServices", "ExtensionAttribute", s_signatures_HasThis_Void_Only, matchIgnoringCase: false); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 25863, 26022);
            InternalsVisibleToAttribute = f_784_25893_26022("System.Runtime.CompilerServices", "InternalsVisibleToAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 26079, 26234);
            AssemblySignatureKeyAttribute = f_784_26111_26234("System.Reflection", "AssemblySignatureKeyAttribute", s_signaturesOfAssemblySignatureKeyAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 26291, 26430);
            AssemblyKeyFileAttribute = f_784_26318_26430("System.Reflection", "AssemblyKeyFileAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 26487, 26626);
            AssemblyKeyNameAttribute = f_784_26514_26626("System.Reflection", "AssemblyKeyNameAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 26683, 26794);
            ParamArrayAttribute = f_784_26705_26794("System", "ParamArrayAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 26851, 26986);
            DefaultMemberAttribute = f_784_26876_26986("System.Reflection", "DefaultMemberAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 27043, 27188);
            IndexerNameAttribute = f_784_27066_27188("System.Runtime.CompilerServices", "IndexerNameAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 27245, 27389);
            AssemblyDelaySignAttribute = f_784_27274_27389("System.Reflection", "AssemblyDelaySignAttribute", s_signatures_HasThis_Void_Boolean_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 27446, 27585);
            AssemblyVersionAttribute = f_784_27473_27585("System.Reflection", "AssemblyVersionAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 27642, 27789);
            AssemblyFileVersionAttribute = f_784_27673_27789("System.Reflection", "AssemblyFileVersionAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 27846, 27981);
            AssemblyTitleAttribute = f_784_27871_27981("System.Reflection", "AssemblyTitleAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 28038, 28185);
            AssemblyDescriptionAttribute = f_784_28069_28185("System.Reflection", "AssemblyDescriptionAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 28242, 28381);
            AssemblyCultureAttribute = f_784_28269_28381("System.Reflection", "AssemblyCultureAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 28438, 28577);
            AssemblyCompanyAttribute = f_784_28465_28577("System.Reflection", "AssemblyCompanyAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 28634, 28773);
            AssemblyProductAttribute = f_784_28661_28773("System.Reflection", "AssemblyProductAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 28830, 28995);
            AssemblyInformationalVersionAttribute = f_784_28870_28995("System.Reflection", "AssemblyInformationalVersionAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 29052, 29195);
            AssemblyCopyrightAttribute = f_784_29081_29195("System.Reflection", "AssemblyCopyrightAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 29252, 29408);
            SatelliteContractVersionAttribute = f_784_29288_29408("System.Resources", "SatelliteContractVersionAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 29465, 29608);
            AssemblyTrademarkAttribute = f_784_29494_29608("System.Reflection", "AssemblyTrademarkAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 29665, 29799);
            AssemblyFlagsAttribute = f_784_29690_29799("System.Reflection", "AssemblyFlagsAttribute", s_signaturesOfAssemblyFlagsAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 29856, 30010);
            DecimalConstantAttribute = f_784_29883_30010("System.Runtime.CompilerServices", "DecimalConstantAttribute", s_signaturesOfDecimalConstantAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 30067, 30215);
            IUnknownConstantAttribute = f_784_30095_30215("System.Runtime.CompilerServices", "IUnknownConstantAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 30272, 30416);
            CallerFilePathAttribute = f_784_30298_30416("System.Runtime.CompilerServices", "CallerFilePathAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 30473, 30621);
            CallerLineNumberAttribute = f_784_30501_30621("System.Runtime.CompilerServices", "CallerLineNumberAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 30678, 30826);
            CallerMemberNameAttribute = f_784_30706_30826("System.Runtime.CompilerServices", "CallerMemberNameAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 30883, 31033);
            IDispatchConstantAttribute = f_784_30912_31033("System.Runtime.CompilerServices", "IDispatchConstantAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 31090, 31261);
            DefaultParameterValueAttribute = f_784_31123_31261("System.Runtime.InteropServices", "DefaultParameterValueAttribute", s_signaturesOfDefaultParameterValueAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 31318, 31465);
            UnverifiableCodeAttribute = f_784_31346_31465("System.Runtime.InteropServices", "UnverifiableCodeAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 31522, 31684);
            SecurityPermissionAttribute = f_784_31552_31684("System.Runtime.InteropServices", "SecurityPermissionAttribute", s_signaturesOfSecurityPermissionAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 31741, 31881);
            DllImportAttribute = f_784_31762_31881("System.Runtime.InteropServices", "DllImportAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 31938, 32077);
            MethodImplAttribute = f_784_31960_32077("System.Runtime.CompilerServices", "MethodImplAttribute", s_signaturesOfMethodImplAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 32134, 32271);
            PreserveSigAttribute = f_784_32157_32271("System.Runtime.InteropServices", "PreserveSigAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 32328, 32478);
            DefaultCharSetAttribute = f_784_32354_32478("System.Runtime.InteropServices", "DefaultCharSetAttribute", s_signaturesOfDefaultCharSetAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 32535, 32673);
            SpecialNameAttribute = f_784_32558_32673("System.Runtime.CompilerServices", "SpecialNameAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 32730, 32845);
            SerializableAttribute = f_784_32754_32845("System", "SerializableAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 32902, 33019);
            NonSerializedAttribute = f_784_32927_33019("System", "NonSerializedAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 33076, 33220);
            StructLayoutAttribute = f_784_33100_33220("System.Runtime.InteropServices", "StructLayoutAttribute", s_signaturesOfStructLayoutAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 33277, 33418);
            FieldOffsetAttribute = f_784_33300_33418("System.Runtime.InteropServices", "FieldOffsetAttribute", s_signaturesOfFieldOffsetAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 33475, 33617);
            FixedBufferAttribute = f_784_33498_33617("System.Runtime.CompilerServices", "FixedBufferAttribute", s_signaturesOfFixedBufferAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 33674, 33808);
            AllowNullAttribute = f_784_33695_33808("System.Diagnostics.CodeAnalysis", "AllowNullAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 33865, 34005);
            DisallowNullAttribute = f_784_33889_34005("System.Diagnostics.CodeAnalysis", "DisallowNullAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 34062, 34196);
            MaybeNullAttribute = f_784_34083_34196("System.Diagnostics.CodeAnalysis", "MaybeNullAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 34253, 34403);
            MaybeNullWhenAttribute = f_784_34278_34403("System.Diagnostics.CodeAnalysis", "MaybeNullWhenAttribute", s_signatures_HasThis_Void_Boolean_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 34460, 34590);
            NotNullAttribute = f_784_34479_34590("System.Diagnostics.CodeAnalysis", "NotNullAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 34647, 34795);
            MemberNotNullAttribute = f_784_34672_34795("System.Diagnostics.CodeAnalysis", "MemberNotNullAttribute", s_signaturesOfMemberNotNullAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 34852, 35012);
            MemberNotNullWhenAttribute = f_784_34881_35012("System.Diagnostics.CodeAnalysis", "MemberNotNullWhenAttribute", s_signaturesOfMemberNotNullWhenAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 35069, 35224);
            NotNullIfNotNullAttribute = f_784_35097_35224("System.Diagnostics.CodeAnalysis", "NotNullIfNotNullAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 35281, 35427);
            NotNullWhenAttribute = f_784_35304_35427("System.Diagnostics.CodeAnalysis", "NotNullWhenAttribute", s_signatures_HasThis_Void_Boolean_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 35484, 35638);
            DoesNotReturnIfAttribute = f_784_35511_35638("System.Diagnostics.CodeAnalysis", "DoesNotReturnIfAttribute", s_signatures_HasThis_Void_Boolean_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 35695, 35837);
            DoesNotReturnAttribute = f_784_35720_35837("System.Diagnostics.CodeAnalysis", "DoesNotReturnAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 35894, 36029);
            MarshalAsAttribute = f_784_35915_36029("System.Runtime.InteropServices", "MarshalAsAttribute", s_signaturesOfMarshalAsAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 36086, 36205);
            InAttribute = f_784_36100_36205("System.Runtime.InteropServices", "InAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 36262, 36383);
            OutAttribute = f_784_36277_36383("System.Runtime.InteropServices", "OutAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 36440, 36576);
            IsReadOnlyAttribute = f_784_36462_36576("System.Runtime.CompilerServices", "IsReadOnlyAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 36633, 36771);
            IsUnmanagedAttribute = f_784_36656_36771("System.Runtime.CompilerServices", "IsUnmanagedAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 36828, 36962);
            CoClassAttribute = f_784_36847_36962("System.Runtime.InteropServices", "CoClassAttribute", s_signatures_HasThis_Void_Type_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 37019, 37149);
            GuidAttribute = f_784_37035_37149("System.Runtime.InteropServices", "GuidAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 37206, 37329);
            CLSCompliantAttribute = f_784_37230_37329("System", "CLSCompliantAttribute", s_signatures_HasThis_Void_Boolean_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 37386, 37533);
            HostProtectionAttribute = f_784_37412_37533("System.Security.Permissions", "HostProtectionAttribute", s_signaturesOfHostProtectionAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 37590, 37748);
            SuppressUnmanagedCodeSecurityAttribute = f_784_37631_37748("System.Security", "SuppressUnmanagedCodeSecurityAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 37805, 37967);
            PrincipalPermissionAttribute = f_784_37836_37967("System.Security.Permissions", "PrincipalPermissionAttribute", s_signaturesOfPrincipalPermissionAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 38024, 38168);
            PermissionSetAttribute = f_784_38049_38168("System.Security.Permissions", "PermissionSetAttribute", s_signaturesOfPermissionSetAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 38225, 38375);
            TypeIdentifierAttribute = f_784_38251_38375("System.Runtime.InteropServices", "TypeIdentifierAttribute", s_signaturesOfTypeIdentifierAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 38432, 38556);
            VisualBasicEmbeddedAttribute = f_784_38463_38556("Microsoft.VisualBasic", "Embedded", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 38613, 38748);
            CodeAnalysisEmbeddedAttribute = f_784_38645_38748("Microsoft.CodeAnalysis", "EmbeddedAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 38805, 38950);
            VisualBasicComClassAttribute = f_784_38836_38950("Microsoft.VisualBasic", "ComClassAttribute", s_signaturesOfVisualBasicComClassAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 39007, 39158);
            StandardModuleAttribute = f_784_39033_39158("Microsoft.VisualBasic.CompilerServices", "StandardModuleAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 39215, 39364);
            OptionCompareAttribute = f_784_39240_39364("Microsoft.VisualBasic.CompilerServices", "OptionCompareAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 39421, 39590);
            AccessedThroughPropertyAttribute = f_784_39456_39590("System.Runtime.CompilerServices", "AccessedThroughPropertyAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 39647, 39771);
            WebMethodAttribute = f_784_39668_39771("System.Web.Services", "WebMethodAttribute", s_signaturesOfWebMethodAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 39828, 39985);
            DateTimeConstantAttribute = f_784_39856_39985("System.Runtime.CompilerServices", "DateTimeConstantAttribute", s_signaturesOfDateTimeConstantAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 40042, 40192);
            ClassInterfaceAttribute = f_784_40068_40192("System.Runtime.InteropServices", "ClassInterfaceAttribute", s_signaturesOfClassInterfaceAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 40249, 40414);
            ComSourceInterfacesAttribute = f_784_40280_40414("System.Runtime.InteropServices", "ComSourceInterfacesAttribute", s_signaturesOfComSourceInterfacesAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 40471, 40614);
            ComVisibleAttribute = f_784_40493_40614("System.Runtime.InteropServices", "ComVisibleAttribute", s_signatures_HasThis_Void_Boolean_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 40671, 40815);
            DispIdAttribute = f_784_40689_40815("System.Runtime.InteropServices", "DispIdAttribute", new byte[][] { s_signature_HasThis_Void_Int32 }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 40872, 41022);
            TypeLibVersionAttribute = f_784_40898_41022("System.Runtime.InteropServices", "TypeLibVersionAttribute", s_signaturesOfTypeLibVersionAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 41079, 41247);
            ComCompatibleVersionAttribute = f_784_41111_41247("System.Runtime.InteropServices", "ComCompatibleVersionAttribute", s_signaturesOfComCompatibleVersionAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 41304, 41451);
            InterfaceTypeAttribute = f_784_41329_41451("System.Runtime.InteropServices", "InterfaceTypeAttribute", s_signaturesOfInterfaceTypeAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 41508, 41678);
            WindowsRuntimeImportAttribute = f_784_41540_41678("System.Runtime.InteropServices.WindowsRuntime", "WindowsRuntimeImportAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 41735, 41877);
            DynamicSecurityMethodAttribute = f_784_41768_41877("System.Security", "DynamicSecurityMethodAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 41934, 42089);
            RequiredAttributeAttribute = f_784_41963_42089("System.Runtime.CompilerServices", "RequiredAttributeAttribute", s_signatures_HasThis_Void_Type_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 42146, 42303);
            AsyncMethodBuilderAttribute = f_784_42176_42303("System.Runtime.CompilerServices", "AsyncMethodBuilderAttribute", s_signatures_HasThis_Void_Type_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 42360, 42515);
            AsyncStateMachineAttribute = f_784_42389_42515("System.Runtime.CompilerServices", "AsyncStateMachineAttribute", s_signatures_HasThis_Void_Type_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 42572, 42733);
            IteratorStateMachineAttribute = f_784_42604_42733("System.Runtime.CompilerServices", "IteratorStateMachineAttribute", s_signatures_HasThis_Void_Type_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 42790, 42965);
            CompilationRelaxationsAttribute = f_784_42824_42965("System.Runtime.CompilerServices", "CompilationRelaxationsAttribute", s_signaturesOfCompilationRelaxationsAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 43022, 43172);
            ReferenceAssemblyAttribute = f_784_43051_43172("System.Runtime.CompilerServices", "ReferenceAssemblyAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 43229, 43385);
            RuntimeCompatibilityAttribute = f_784_43261_43385("System.Runtime.CompilerServices", "RuntimeCompatibilityAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 43442, 43568);
            DebuggableAttribute = f_784_43464_43568("System.Diagnostics", "DebuggableAttribute", s_signaturesOfDebuggableAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 43625, 43776);
            TypeForwardedToAttribute = f_784_43652_43776("System.Runtime.CompilerServices", "TypeForwardedToAttribute", s_signatures_HasThis_Void_Type_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 43833, 43942);
            STAThreadAttribute = f_784_43854_43942("System", "STAThreadAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 43999, 44108);
            MTAThreadAttribute = f_784_44020_44108("System", "MTAThreadAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 44165, 44273);
            ObsoleteAttribute = f_784_44185_44273("System", "ObsoleteAttribute", s_signaturesOfObsoleteAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 44330, 44471);
            TypeLibTypeAttribute = f_784_44353_44471("System.Runtime.InteropServices", "TypeLibTypeAttribute", s_signaturesOfTypeLibTypeAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 44528, 44658);
            DynamicAttribute = f_784_44547_44658("System.Runtime.CompilerServices", "DynamicAttribute", s_signaturesOfDynamicAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 44715, 44875);
            TupleElementNamesAttribute = f_784_44744_44875("System.Runtime.CompilerServices", "TupleElementNamesAttribute", s_signaturesOfTupleElementNamesAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 44932, 45070);
            IsByRefLikeAttribute = f_784_44955_45070("System.Runtime.CompilerServices", "IsByRefLikeAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 45127, 45258);
            DebuggerHiddenAttribute = f_784_45153_45258("System.Diagnostics", "DebuggerHiddenAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 45315, 45456);
            DebuggerNonUserCodeAttribute = f_784_45346_45456("System.Diagnostics", "DebuggerNonUserCodeAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 45513, 45662);
            DebuggerStepperBoundaryAttribute = f_784_45548_45662("System.Diagnostics", "DebuggerStepperBoundaryAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 45719, 45860);
            DebuggerStepThroughAttribute = f_784_45750_45860("System.Diagnostics", "DebuggerStepThroughAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 45917, 46058);
            SecurityCriticalAttribute = f_784_45945_46058("System.Security", "SecurityCriticalAttribute", s_signaturesOfSecurityCriticalAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 46115, 46255);
            SecuritySafeCriticalAttribute = f_784_46147_46255("System.Security", "SecuritySafeCriticalAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 46312, 46469);
            DesignerGeneratedAttribute = f_784_46341_46469("Microsoft.VisualBasic.CompilerServices", "DesignerGeneratedAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 46526, 46676);
            MyGroupCollectionAttribute = f_784_46555_46676("Microsoft.VisualBasic", "MyGroupCollectionAttribute", s_signaturesOfMyGroupCollectionAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 46733, 46892);
            ComEventInterfaceAttribute = f_784_46762_46892("System.Runtime.InteropServices", "ComEventInterfaceAttribute", s_signaturesOfComEventInterfaceAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 46949, 47100);
            BestFitMappingAttribute = f_784_46975_47100("System.Runtime.InteropServices", "BestFitMappingAttribute", s_signatures_HasThis_Void_Boolean_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 47157, 47258);
            FlagsAttribute = f_784_47174_47258("System", "FlagsAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 47315, 47465);
            LCIDConversionAttribute = f_784_47341_47465("System.Runtime.InteropServices", "LCIDConversionAttribute", s_signaturesOfLCIDConversionAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 47522, 47702);
            UnmanagedFunctionPointerAttribute = f_784_47558_47702("System.Runtime.InteropServices", "UnmanagedFunctionPointerAttribute", s_signaturesOfUnmanagedFunctionPointerAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 47759, 47933);
            PrimaryInteropAssemblyAttribute = f_784_47793_47933("System.Runtime.InteropServices", "PrimaryInteropAssemblyAttribute", s_signaturesOfPrimaryInteropAssemblyAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 47990, 48150);
            ImportedFromTypeLibAttribute = f_784_48021_48150("System.Runtime.InteropServices", "ImportedFromTypeLibAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 48207, 48344);
            DefaultEventAttribute = f_784_48231_48344("System.ComponentModel", "DefaultEventAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 48401, 48552);
            AssemblyConfigurationAttribute = f_784_48434_48552("System.Reflection", "AssemblyConfigurationAttribute", s_signatures_HasThis_Void_String_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 48609, 48761);
            AssemblyAlgorithmIdAttribute = f_784_48640_48761("System.Reflection", "AssemblyAlgorithmIdAttribute", s_signaturesOfAssemblyAlgorithmIdAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 48818, 48953);
            DeprecatedAttribute = f_784_48840_48953("Windows.Foundation.Metadata", "DeprecatedAttribute", s_signaturesOfDeprecatedAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 49010, 49143);
            NullableAttribute = f_784_49030_49143("System.Runtime.CompilerServices", "NullableAttribute", s_signaturesOfNullableAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 49200, 49354);
            NullableContextAttribute = f_784_49227_49354("System.Runtime.CompilerServices", "NullableContextAttribute", s_signaturesOfNullableContextAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 49411, 49571);
            NullablePublicOnlyAttribute = f_784_49441_49571("System.Runtime.CompilerServices", "NullablePublicOnlyAttribute", s_signatures_HasThis_Void_Boolean_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 49628, 49764);
            ExperimentalAttribute = f_784_49652_49764("Windows.Foundation.Metadata", "ExperimentalAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 49821, 49983);
            ExcludeFromCodeCoverageAttribute = f_784_49856_49983("System.Diagnostics.CodeAnalysis", "ExcludeFromCodeCoverageAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 50040, 50200);
            EnumeratorCancellationAttribute = f_784_50074_50200("System.Runtime.CompilerServices", "EnumeratorCancellationAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 50257, 50401);
            SkipLocalsInitAttribute = f_784_50283_50401("System.Runtime.CompilerServices", "SkipLocalsInitAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 50458, 50606);
            NativeIntegerAttribute = f_784_50483_50606("System.Runtime.CompilerServices", "NativeIntegerAttribute", s_signaturesOfNativeIntegerAttribute); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 50663, 50813);
            ModuleInitializerAttribute = f_784_50692_50813("System.Runtime.CompilerServices", "ModuleInitializerAttribute", s_signatures_HasThis_Void_Only); DynAbs.Tracing.TraceSender.TraceSimpleStatement(784, 50870, 51025);
            UnmanagedCallersOnlyAttribute = f_784_50902_51025("System.Runtime.InteropServices", "UnmanagedCallersOnlyAttribute", s_signatures_HasThis_Void_Only);
        }

        private static readonly byte[] s_signature_HasThis_Void;

        private static readonly byte[] s_signature_HasThis_Void_Byte;

        private static readonly byte[] s_signature_HasThis_Void_Int16;

        private static readonly byte[] s_signature_HasThis_Void_Int32;

        private static readonly byte[] s_signature_HasThis_Void_UInt32;

        private static readonly byte[] s_signature_HasThis_Void_Int32_Int32;

        private static readonly byte[] s_signature_HasThis_Void_Int32_Int32_Int32_Int32;

        private static readonly byte[] s_signature_HasThis_Void_String;

        private static readonly byte[] s_signature_HasThis_Void_Object;

        private static readonly byte[] s_signature_HasThis_Void_String_String;

        private static readonly byte[] s_signature_HasThis_Void_String_Boolean;

        private static readonly byte[] s_signature_HasThis_Void_String_String_String;

        private static readonly byte[] s_signature_HasThis_Void_String_String_String_String;

        private static readonly byte[] s_signature_HasThis_Void_AttributeTargets;

        private static readonly byte[] s_signature_HasThis_Void_AssemblyNameFlags;

        private static readonly byte[] s_signature_HasThis_Void_MethodImplOptions;

        private static readonly byte[] s_signature_HasThis_Void_CharSet;

        private static readonly byte[] s_signature_HasThis_Void_LayoutKind;

        private static readonly byte[] s_signature_HasThis_Void_UnmanagedType;

        private static readonly byte[] s_signature_HasThis_Void_TypeLibTypeFlags;

        private static readonly byte[] s_signature_HasThis_Void_ClassInterfaceType;

        private static readonly byte[] s_signature_HasThis_Void_ComInterfaceType;

        private static readonly byte[] s_signature_HasThis_Void_CompilationRelaxations;

        private static readonly byte[] s_signature_HasThis_Void_DebuggingModes;

        private static readonly byte[] s_signature_HasThis_Void_SecurityCriticalScope;

        private static readonly byte[] s_signature_HasThis_Void_CallingConvention;

        private static readonly byte[] s_signature_HasThis_Void_AssemblyHashAlgorithm;

        private static readonly byte[] s_signature_HasThis_Void_Int64;

        private static readonly byte[] s_signature_HasThis_Void_UInt8_UInt8_UInt32_UInt32_UInt32;

        private static readonly byte[] s_signature_HasThis_Void_UIn8_UInt8_Int32_Int32_Int32;

        private static readonly byte[] s_signature_HasThis_Void_Boolean;

        private static readonly byte[] s_signature_HasThis_Void_Boolean_Boolean;

        private static readonly byte[] s_signature_HasThis_Void_Boolean_TransactionOption;

        private static readonly byte[] s_signature_HasThis_Void_Boolean_TransactionOption_Int32;

        private static readonly byte[] s_signature_HasThis_Void_Boolean_TransactionOption_Int32_Boolean;

        private static readonly byte[] s_signature_HasThis_Void_SecurityAction;

        private static readonly byte[] s_signature_HasThis_Void_Type;

        private static readonly byte[] s_signature_HasThis_Void_Type_Type;

        private static readonly byte[] s_signature_HasThis_Void_Type_Type_Type;

        private static readonly byte[] s_signature_HasThis_Void_Type_Type_Type_Type;

        private static readonly byte[] s_signature_HasThis_Void_Type_Int32;

        private static readonly byte[] s_signature_HasThis_Void_SzArray_Boolean;

        private static readonly byte[] s_signature_HasThis_Void_SzArray_Byte;

        private static readonly byte[] s_signature_HasThis_Void_SzArray_String;

        private static readonly byte[] s_signature_HasThis_Void_Boolean_SzArray_String;

        private static readonly byte[] s_signature_HasThis_Void_Boolean_String;

        private static readonly byte[] s_signature_HasThis_Void_String_DeprecationType_UInt32;

        private static readonly byte[] s_signature_HasThis_Void_String_DeprecationType_UInt32_Platform;

        private static readonly byte[] s_signature_HasThis_Void_String_DeprecationType_UInt32_Type;

        private static readonly byte[] s_signature_HasThis_Void_String_DeprecationType_UInt32_String;

        private static readonly byte[][] s_signatures_HasThis_Void_Only;

        private static readonly byte[][] s_signatures_HasThis_Void_String_Only;

        private static readonly byte[][] s_signatures_HasThis_Void_Type_Only;

        private static readonly byte[][] s_signatures_HasThis_Void_Boolean_Only;

        private static readonly byte[][] s_signaturesOfTypeIdentifierAttribute;

        private static readonly byte[][] s_signaturesOfAttributeUsage;

        private static readonly byte[][] s_signaturesOfAssemblySignatureKeyAttribute;

        private static readonly byte[][] s_signaturesOfAssemblyFlagsAttribute;

        private static readonly byte[][] s_signaturesOfDefaultParameterValueAttribute;

        private static readonly byte[][] s_signaturesOfDateTimeConstantAttribute;

        private static readonly byte[][] s_signaturesOfDecimalConstantAttribute;

        private static readonly byte[][] s_signaturesOfSecurityPermissionAttribute;

        private static readonly byte[][] s_signaturesOfMethodImplAttribute;

        private static readonly byte[][] s_signaturesOfDefaultCharSetAttribute;

        private static readonly byte[][] s_signaturesOfFieldOffsetAttribute;

        private static readonly byte[][] s_signaturesOfMemberNotNullAttribute;

        private static readonly byte[][] s_signaturesOfMemberNotNullWhenAttribute;

        private static readonly byte[][] s_signaturesOfFixedBufferAttribute;

        private static readonly byte[][] s_signaturesOfPrincipalPermissionAttribute;

        private static readonly byte[][] s_signaturesOfPermissionSetAttribute;

        private static readonly byte[][] s_signaturesOfStructLayoutAttribute;

        private static readonly byte[][] s_signaturesOfMarshalAsAttribute;

        private static readonly byte[][] s_signaturesOfTypeLibTypeAttribute;

        private static readonly byte[][] s_signaturesOfWebMethodAttribute;

        private static readonly byte[][] s_signaturesOfHostProtectionAttribute;

        private static readonly byte[][] s_signaturesOfVisualBasicComClassAttribute;

        private static readonly byte[][] s_signaturesOfClassInterfaceAttribute;

        private static readonly byte[][] s_signaturesOfInterfaceTypeAttribute;

        private static readonly byte[][] s_signaturesOfCompilationRelaxationsAttribute;

        private static readonly byte[][] s_signaturesOfDebuggableAttribute;

        private static readonly byte[][] s_signaturesOfComSourceInterfacesAttribute;

        private static readonly byte[][] s_signaturesOfTypeLibVersionAttribute;

        private static readonly byte[][] s_signaturesOfComCompatibleVersionAttribute;

        private static readonly byte[][] s_signaturesOfObsoleteAttribute;

        private static readonly byte[][] s_signaturesOfDynamicAttribute;

        private static readonly byte[][] s_signaturesOfTupleElementNamesAttribute;

        private static readonly byte[][] s_signaturesOfSecurityCriticalAttribute;

        private static readonly byte[][] s_signaturesOfMyGroupCollectionAttribute;

        private static readonly byte[][] s_signaturesOfComEventInterfaceAttribute;

        private static readonly byte[][] s_signaturesOfLCIDConversionAttribute;

        private static readonly byte[][] s_signaturesOfUnmanagedFunctionPointerAttribute;

        private static readonly byte[][] s_signaturesOfPrimaryInteropAssemblyAttribute;

        private static readonly byte[][] s_signaturesOfAssemblyAlgorithmIdAttribute;

        private static readonly byte[][] s_signaturesOfDeprecatedAttribute;

        private static readonly byte[][] s_signaturesOfNullableAttribute;

        private static readonly byte[][] s_signaturesOfNullableContextAttribute;

        private static readonly byte[][] s_signaturesOfNativeIntegerAttribute;

        internal static readonly AttributeDescription OptionalAttribute;

        internal static readonly AttributeDescription ComImportAttribute;

        internal static readonly AttributeDescription AttributeUsageAttribute;

        internal static readonly AttributeDescription ConditionalAttribute;

        internal static readonly AttributeDescription CaseInsensitiveExtensionAttribute;

        internal static readonly AttributeDescription CaseSensitiveExtensionAttribute;

        internal static readonly AttributeDescription InternalsVisibleToAttribute;

        internal static readonly AttributeDescription AssemblySignatureKeyAttribute;

        internal static readonly AttributeDescription AssemblyKeyFileAttribute;

        internal static readonly AttributeDescription AssemblyKeyNameAttribute;

        internal static readonly AttributeDescription ParamArrayAttribute;

        internal static readonly AttributeDescription DefaultMemberAttribute;

        internal static readonly AttributeDescription IndexerNameAttribute;

        internal static readonly AttributeDescription AssemblyDelaySignAttribute;

        internal static readonly AttributeDescription AssemblyVersionAttribute;

        internal static readonly AttributeDescription AssemblyFileVersionAttribute;

        internal static readonly AttributeDescription AssemblyTitleAttribute;

        internal static readonly AttributeDescription AssemblyDescriptionAttribute;

        internal static readonly AttributeDescription AssemblyCultureAttribute;

        internal static readonly AttributeDescription AssemblyCompanyAttribute;

        internal static readonly AttributeDescription AssemblyProductAttribute;

        internal static readonly AttributeDescription AssemblyInformationalVersionAttribute;

        internal static readonly AttributeDescription AssemblyCopyrightAttribute;

        internal static readonly AttributeDescription SatelliteContractVersionAttribute;

        internal static readonly AttributeDescription AssemblyTrademarkAttribute;

        internal static readonly AttributeDescription AssemblyFlagsAttribute;

        internal static readonly AttributeDescription DecimalConstantAttribute;

        internal static readonly AttributeDescription IUnknownConstantAttribute;

        internal static readonly AttributeDescription CallerFilePathAttribute;

        internal static readonly AttributeDescription CallerLineNumberAttribute;

        internal static readonly AttributeDescription CallerMemberNameAttribute;

        internal static readonly AttributeDescription IDispatchConstantAttribute;

        internal static readonly AttributeDescription DefaultParameterValueAttribute;

        internal static readonly AttributeDescription UnverifiableCodeAttribute;

        internal static readonly AttributeDescription SecurityPermissionAttribute;

        internal static readonly AttributeDescription DllImportAttribute;

        internal static readonly AttributeDescription MethodImplAttribute;

        internal static readonly AttributeDescription PreserveSigAttribute;

        internal static readonly AttributeDescription DefaultCharSetAttribute;

        internal static readonly AttributeDescription SpecialNameAttribute;

        internal static readonly AttributeDescription SerializableAttribute;

        internal static readonly AttributeDescription NonSerializedAttribute;

        internal static readonly AttributeDescription StructLayoutAttribute;

        internal static readonly AttributeDescription FieldOffsetAttribute;

        internal static readonly AttributeDescription FixedBufferAttribute;

        internal static readonly AttributeDescription AllowNullAttribute;

        internal static readonly AttributeDescription DisallowNullAttribute;

        internal static readonly AttributeDescription MaybeNullAttribute;

        internal static readonly AttributeDescription MaybeNullWhenAttribute;

        internal static readonly AttributeDescription NotNullAttribute;

        internal static readonly AttributeDescription MemberNotNullAttribute;

        internal static readonly AttributeDescription MemberNotNullWhenAttribute;

        internal static readonly AttributeDescription NotNullIfNotNullAttribute;

        internal static readonly AttributeDescription NotNullWhenAttribute;

        internal static readonly AttributeDescription DoesNotReturnIfAttribute;

        internal static readonly AttributeDescription DoesNotReturnAttribute;

        internal static readonly AttributeDescription MarshalAsAttribute;

        internal static readonly AttributeDescription InAttribute;

        internal static readonly AttributeDescription OutAttribute;

        internal static readonly AttributeDescription IsReadOnlyAttribute;

        internal static readonly AttributeDescription IsUnmanagedAttribute;

        internal static readonly AttributeDescription CoClassAttribute;

        internal static readonly AttributeDescription GuidAttribute;

        internal static readonly AttributeDescription CLSCompliantAttribute;

        internal static readonly AttributeDescription HostProtectionAttribute;

        internal static readonly AttributeDescription SuppressUnmanagedCodeSecurityAttribute;

        internal static readonly AttributeDescription PrincipalPermissionAttribute;

        internal static readonly AttributeDescription PermissionSetAttribute;

        internal static readonly AttributeDescription TypeIdentifierAttribute;

        internal static readonly AttributeDescription VisualBasicEmbeddedAttribute;

        internal static readonly AttributeDescription CodeAnalysisEmbeddedAttribute;

        internal static readonly AttributeDescription VisualBasicComClassAttribute;

        internal static readonly AttributeDescription StandardModuleAttribute;

        internal static readonly AttributeDescription OptionCompareAttribute;

        internal static readonly AttributeDescription AccessedThroughPropertyAttribute;

        internal static readonly AttributeDescription WebMethodAttribute;

        internal static readonly AttributeDescription DateTimeConstantAttribute;

        internal static readonly AttributeDescription ClassInterfaceAttribute;

        internal static readonly AttributeDescription ComSourceInterfacesAttribute;

        internal static readonly AttributeDescription ComVisibleAttribute;

        internal static readonly AttributeDescription DispIdAttribute;

        internal static readonly AttributeDescription TypeLibVersionAttribute;

        internal static readonly AttributeDescription ComCompatibleVersionAttribute;

        internal static readonly AttributeDescription InterfaceTypeAttribute;

        internal static readonly AttributeDescription WindowsRuntimeImportAttribute;

        internal static readonly AttributeDescription DynamicSecurityMethodAttribute;

        internal static readonly AttributeDescription RequiredAttributeAttribute;

        internal static readonly AttributeDescription AsyncMethodBuilderAttribute;

        internal static readonly AttributeDescription AsyncStateMachineAttribute;

        internal static readonly AttributeDescription IteratorStateMachineAttribute;

        internal static readonly AttributeDescription CompilationRelaxationsAttribute;

        internal static readonly AttributeDescription ReferenceAssemblyAttribute;

        internal static readonly AttributeDescription RuntimeCompatibilityAttribute;

        internal static readonly AttributeDescription DebuggableAttribute;

        internal static readonly AttributeDescription TypeForwardedToAttribute;

        internal static readonly AttributeDescription STAThreadAttribute;

        internal static readonly AttributeDescription MTAThreadAttribute;

        internal static readonly AttributeDescription ObsoleteAttribute;

        internal static readonly AttributeDescription TypeLibTypeAttribute;

        internal static readonly AttributeDescription DynamicAttribute;

        internal static readonly AttributeDescription TupleElementNamesAttribute;

        internal static readonly AttributeDescription IsByRefLikeAttribute;

        internal static readonly AttributeDescription DebuggerHiddenAttribute;

        internal static readonly AttributeDescription DebuggerNonUserCodeAttribute;

        internal static readonly AttributeDescription DebuggerStepperBoundaryAttribute;

        internal static readonly AttributeDescription DebuggerStepThroughAttribute;

        internal static readonly AttributeDescription SecurityCriticalAttribute;

        internal static readonly AttributeDescription SecuritySafeCriticalAttribute;

        internal static readonly AttributeDescription DesignerGeneratedAttribute;

        internal static readonly AttributeDescription MyGroupCollectionAttribute;

        internal static readonly AttributeDescription ComEventInterfaceAttribute;

        internal static readonly AttributeDescription BestFitMappingAttribute;

        internal static readonly AttributeDescription FlagsAttribute;

        internal static readonly AttributeDescription LCIDConversionAttribute;

        internal static readonly AttributeDescription UnmanagedFunctionPointerAttribute;

        internal static readonly AttributeDescription PrimaryInteropAssemblyAttribute;

        internal static readonly AttributeDescription ImportedFromTypeLibAttribute;

        internal static readonly AttributeDescription DefaultEventAttribute;

        internal static readonly AttributeDescription AssemblyConfigurationAttribute;

        internal static readonly AttributeDescription AssemblyAlgorithmIdAttribute;

        internal static readonly AttributeDescription DeprecatedAttribute;

        internal static readonly AttributeDescription NullableAttribute;

        internal static readonly AttributeDescription NullableContextAttribute;

        internal static readonly AttributeDescription NullablePublicOnlyAttribute;

        internal static readonly AttributeDescription ExperimentalAttribute;

        internal static readonly AttributeDescription ExcludeFromCodeCoverageAttribute;

        internal static readonly AttributeDescription EnumeratorCancellationAttribute;

        internal static readonly AttributeDescription SkipLocalsInitAttribute;

        internal static readonly AttributeDescription NativeIntegerAttribute;

        internal static readonly AttributeDescription ModuleInitializerAttribute;

        internal static readonly AttributeDescription UnmanagedCallersOnlyAttribute;

        static int
        f_784_887_925(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 887, 925);
            return 0;
        }


        static int
        f_784_940_972(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 940, 972);
            return 0;
        }


        static int
        f_784_987_1025(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 987, 1025);
            return 0;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_4601_4681(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 4601, 4681);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_4700_4794(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 4700, 4794);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_4813_4904(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 4813, 4904);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_4923_5003(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 4923, 5003);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_5022_5105(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 5022, 5105);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_5124_5210(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 5124, 5210);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_5229_5318(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 5229, 5318);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_5337_5428(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 5337, 5428);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_5447_5536(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 5447, 5536);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_5555_5651(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 5555, 5651);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_5670_5782(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 5670, 5782);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_5801_5897(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 5801, 5897);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_5916_6006(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 5916, 6006);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_6025_6137(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 6025, 6137);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_6156_6258(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 6156, 6258);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_6277_6378(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 6277, 6378);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_6397_6464(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 6397, 6464);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_6483_6585(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 6483, 6585);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo
        f_784_6604_6699(string
        @namespace, string
        name, System.Reflection.Metadata.SerializationTypeCode
        underlying)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo(@namespace, name, underlying);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 6604, 6699);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo>
        f_784_4574_6729(Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo[]
        items)
        {
            var return_v = items.AsImmutable<Microsoft.CodeAnalysis.AttributeDescription.TypeHandleTargetInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 4574, 6729);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_24679_24790(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 24679, 24790);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_24868_24980(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 24868, 24980);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_25063_25154(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 25063, 25154);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_25234_25343(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 25234, 25343);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_25436_25574(string
        @namespace, string
        name, byte[][]
        signatures, bool
        matchIgnoringCase)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures, matchIgnoringCase: matchIgnoringCase);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 25436, 25574);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_25665_25804(string
        @namespace, string
        name, byte[][]
        signatures, bool
        matchIgnoringCase)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures, matchIgnoringCase: matchIgnoringCase);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 25665, 25804);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_25893_26022(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 25893, 26022);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_26111_26234(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 26111, 26234);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_26318_26430(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 26318, 26430);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_26514_26626(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 26514, 26626);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_26705_26794(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 26705, 26794);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_26876_26986(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 26876, 26986);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_27066_27188(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 27066, 27188);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_27274_27389(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 27274, 27389);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_27473_27585(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 27473, 27585);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_27673_27789(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 27673, 27789);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_27871_27981(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 27871, 27981);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_28069_28185(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 28069, 28185);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_28269_28381(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 28269, 28381);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_28465_28577(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 28465, 28577);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_28661_28773(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 28661, 28773);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_28870_28995(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 28870, 28995);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_29081_29195(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 29081, 29195);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_29288_29408(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 29288, 29408);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_29494_29608(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 29494, 29608);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_29690_29799(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 29690, 29799);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_29883_30010(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 29883, 30010);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_30095_30215(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 30095, 30215);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_30298_30416(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 30298, 30416);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_30501_30621(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 30501, 30621);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_30706_30826(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 30706, 30826);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_30912_31033(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 30912, 31033);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_31123_31261(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 31123, 31261);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_31346_31465(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 31346, 31465);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_31552_31684(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 31552, 31684);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_31762_31881(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 31762, 31881);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_31960_32077(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 31960, 32077);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_32157_32271(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 32157, 32271);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_32354_32478(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 32354, 32478);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_32558_32673(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 32558, 32673);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_32754_32845(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 32754, 32845);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_32927_33019(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 32927, 33019);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_33100_33220(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 33100, 33220);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_33300_33418(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 33300, 33418);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_33498_33617(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 33498, 33617);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_33695_33808(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 33695, 33808);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_33889_34005(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 33889, 34005);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_34083_34196(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 34083, 34196);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_34278_34403(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 34278, 34403);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_34479_34590(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 34479, 34590);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_34672_34795(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 34672, 34795);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_34881_35012(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 34881, 35012);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_35097_35224(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 35097, 35224);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_35304_35427(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 35304, 35427);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_35511_35638(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 35511, 35638);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_35720_35837(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 35720, 35837);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_35915_36029(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 35915, 36029);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_36100_36205(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 36100, 36205);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_36277_36383(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 36277, 36383);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_36462_36576(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 36462, 36576);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_36656_36771(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 36656, 36771);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_36847_36962(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 36847, 36962);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_37035_37149(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 37035, 37149);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_37230_37329(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 37230, 37329);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_37412_37533(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 37412, 37533);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_37631_37748(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 37631, 37748);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_37836_37967(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 37836, 37967);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_38049_38168(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 38049, 38168);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_38251_38375(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 38251, 38375);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_38463_38556(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 38463, 38556);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_38645_38748(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 38645, 38748);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_38836_38950(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 38836, 38950);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_39033_39158(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 39033, 39158);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_39240_39364(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 39240, 39364);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_39456_39590(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 39456, 39590);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_39668_39771(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 39668, 39771);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_39856_39985(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 39856, 39985);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_40068_40192(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 40068, 40192);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_40280_40414(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 40280, 40414);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_40493_40614(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 40493, 40614);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_40689_40815(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 40689, 40815);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_40898_41022(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 40898, 41022);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_41111_41247(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 41111, 41247);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_41329_41451(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 41329, 41451);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_41540_41678(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 41540, 41678);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_41768_41877(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 41768, 41877);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_41963_42089(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 41963, 42089);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_42176_42303(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 42176, 42303);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_42389_42515(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 42389, 42515);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_42604_42733(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 42604, 42733);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_42824_42965(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 42824, 42965);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_43051_43172(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 43051, 43172);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_43261_43385(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 43261, 43385);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_43464_43568(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 43464, 43568);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_43652_43776(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 43652, 43776);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_43854_43942(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 43854, 43942);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_44020_44108(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 44020, 44108);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_44185_44273(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 44185, 44273);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_44353_44471(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 44353, 44471);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_44547_44658(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 44547, 44658);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_44744_44875(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 44744, 44875);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_44955_45070(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 44955, 45070);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_45153_45258(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 45153, 45258);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_45346_45456(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 45346, 45456);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_45548_45662(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 45548, 45662);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_45750_45860(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 45750, 45860);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_45945_46058(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 45945, 46058);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_46147_46255(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 46147, 46255);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_46341_46469(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 46341, 46469);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_46555_46676(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 46555, 46676);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_46762_46892(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 46762, 46892);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_46975_47100(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 46975, 47100);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_47174_47258(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 47174, 47258);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_47341_47465(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 47341, 47465);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_47558_47702(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 47558, 47702);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_47793_47933(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 47793, 47933);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_48021_48150(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 48021, 48150);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_48231_48344(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 48231, 48344);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_48434_48552(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 48434, 48552);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_48640_48761(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 48640, 48761);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_48840_48953(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 48840, 48953);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_49030_49143(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 49030, 49143);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_49227_49354(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 49227, 49354);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_49441_49571(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 49441, 49571);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_49652_49764(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 49652, 49764);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_49856_49983(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 49856, 49983);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_50074_50200(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 50074, 50200);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_50283_50401(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 50283, 50401);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_50483_50606(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 50483, 50606);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_50692_50813(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 50692, 50813);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AttributeDescription
        f_784_50902_51025(string
        @namespace, string
        name, byte[][]
        signatures)
        {
            var return_v = new Microsoft.CodeAnalysis.AttributeDescription(@namespace, name, signatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(784, 50902, 51025);
            return return_v;
        }

    }
}
