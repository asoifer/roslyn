// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal static class SpecialTypeExtensions
    {
        public static bool IsClrInteger(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(37, 472, 1296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 558, 1285);

                switch (specialType)
                {

                    case SpecialType.System_Boolean:
                    case SpecialType.System_Char:
                    case SpecialType.System_Byte:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_IntPtr:
                    case SpecialType.System_UIntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 558, 1285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 1197, 1209);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 558, 1285);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 558, 1285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 1257, 1270);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 558, 1285);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(37, 472, 1296);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(37, 472, 1296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 472, 1296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsBlittable(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(37, 1417, 2239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 1502, 2228);

                switch (specialType)
                {

                    case SpecialType.System_Boolean:
                    case SpecialType.System_Char:
                    case SpecialType.System_Byte:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_Single:
                    case SpecialType.System_Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 1502, 2228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 2140, 2152);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 1502, 2228);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 1502, 2228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 2200, 2213);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 1502, 2228);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(37, 1417, 2239);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(37, 1417, 2239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 1417, 2239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValueType(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(37, 2251, 3731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 2336, 3720);

                switch (specialType)
                {

                    case SpecialType.System_Void:
                    case SpecialType.System_Boolean:
                    case SpecialType.System_Char:
                    case SpecialType.System_Byte:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_Single:
                    case SpecialType.System_Double:
                    case SpecialType.System_Decimal:
                    case SpecialType.System_IntPtr:
                    case SpecialType.System_UIntPtr:
                    case SpecialType.System_Nullable_T:
                    case SpecialType.System_DateTime:
                    case SpecialType.System_TypedReference:
                    case SpecialType.System_ArgIterator:
                    case SpecialType.System_RuntimeArgumentHandle:
                    case SpecialType.System_RuntimeFieldHandle:
                    case SpecialType.System_RuntimeMethodHandle:
                    case SpecialType.System_RuntimeTypeHandle:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 2336, 3720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 3632, 3644);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 2336, 3720);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 2336, 3720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 3692, 3705);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 2336, 3720);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(37, 2251, 3731);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(37, 2251, 3731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 2251, 3731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int SizeInBytes(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(37, 3743, 5242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 3827, 5231);

                switch (specialType)
                {

                    case SpecialType.System_SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 3932, 3953);

                        return sizeof(sbyte);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    case SpecialType.System_Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 4022, 4042);

                        return sizeof(byte);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    case SpecialType.System_Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 4112, 4133);

                        return sizeof(short);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    case SpecialType.System_UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 4204, 4226);

                        return sizeof(ushort);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    case SpecialType.System_Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 4296, 4315);

                        return sizeof(int);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    case SpecialType.System_UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 4386, 4406);

                        return sizeof(uint);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 4476, 4496);

                        return sizeof(long);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 4567, 4588);

                        return sizeof(ulong);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    case SpecialType.System_Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 4657, 4677);

                        return sizeof(char);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    case SpecialType.System_Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 4748, 4769);

                        return sizeof(float);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    case SpecialType.System_Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 4840, 4862);

                        return sizeof(double);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    case SpecialType.System_Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 4934, 4954);

                        return sizeof(bool);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    case SpecialType.System_Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 5102, 5125);

                        return sizeof(decimal);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 3827, 5231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 5207, 5216);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 3827, 5231);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(37, 3743, 5242);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(37, 3743, 5242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 3743, 5242);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPrimitiveRecursiveStruct(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(37, 5455, 6391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 5555, 6380);

                switch (specialType)
                {

                    case SpecialType.System_Boolean:
                    case SpecialType.System_Byte:
                    case SpecialType.System_Char:
                    case SpecialType.System_Double:
                    case SpecialType.System_Int16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_IntPtr:
                    case SpecialType.System_UIntPtr:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 5555, 6380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 6292, 6304);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 5555, 6380);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 5555, 6380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 6352, 6365);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 5555, 6380);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(37, 5455, 6391);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(37, 5455, 6391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 5455, 6391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValidEnumUnderlyingType(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(37, 6403, 7044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 6502, 7033);

                switch (specialType)
                {

                    case SpecialType.System_Byte:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 6502, 7033);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 6945, 6957);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 6502, 7033);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 6502, 7033);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 7005, 7018);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 6502, 7033);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(37, 6403, 7044);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(37, 6403, 7044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 6403, 7044);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNumericType(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(37, 7056, 7833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 7143, 7822);

                switch (specialType)
                {

                    case SpecialType.System_Byte:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_Single:
                    case SpecialType.System_Double:
                    case SpecialType.System_Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 7143, 7822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 7734, 7746);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 7143, 7822);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 7143, 7822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 7794, 7807);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 7143, 7822);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(37, 7056, 7833);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(37, 7056, 7833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 7056, 7833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIntegralType(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(37, 7966, 8596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 8054, 8585);

                switch (specialType)
                {

                    case SpecialType.System_Byte:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 8054, 8585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 8497, 8509);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 8054, 8585);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 8054, 8585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 8557, 8570);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 8054, 8585);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(37, 7966, 8596);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(37, 7966, 8596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 7966, 8596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsUnsignedIntegralType(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(37, 8608, 9054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 8704, 9043);

                switch (specialType)
                {

                    case SpecialType.System_Byte:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 8704, 9043);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 8955, 8967);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 8704, 9043);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 8704, 9043);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 9015, 9028);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 8704, 9043);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(37, 8608, 9054);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(37, 8608, 9054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 8608, 9054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsSignedIntegralType(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(37, 9066, 9508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 9160, 9497);

                switch (specialType)
                {

                    case SpecialType.System_SByte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 9160, 9497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 9409, 9421);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 9160, 9497);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 9160, 9497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 9469, 9482);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 9160, 9497);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(37, 9066, 9508);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(37, 9066, 9508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 9066, 9508);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int VBForToShiftBits(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(37, 9778, 10366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 9867, 10355);

                switch (specialType)
                {

                    case SpecialType.System_SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 9867, 10355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 9972, 9981);

                        return 7;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 9867, 10355);

                    case SpecialType.System_Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 9867, 10355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 10051, 10061);

                        return 15;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 9867, 10355);

                    case SpecialType.System_Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 9867, 10355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 10131, 10141);

                        return 31;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 9867, 10355);

                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 9867, 10355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 10211, 10221);

                        return 63;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 9867, 10355);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 9867, 10355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 10269, 10340);

                        throw f_37_10275_10339(specialType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(37, 9867, 10355);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(37, 9778, 10366);

                System.Exception
                f_37_10275_10339(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 10275, 10339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(37, 9778, 10366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 9778, 10366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SpecialType FromRuntimeTypeOfLiteralValue(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(37, 10378, 12768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 10472, 10506);

                f_37_10472_10505(value != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 10726, 10841) || true) && (f_37_10730_10745(value) == typeof(int))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 10726, 10841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 10794, 10826);

                    return SpecialType.System_Int32;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 10726, 10841);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 10857, 10976) || true) && (f_37_10861_10876(value) == typeof(string))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 10857, 10976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 10928, 10961);

                    return SpecialType.System_String;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 10857, 10976);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 10992, 11110) || true) && (f_37_10996_11011(value) == typeof(bool))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 10992, 11110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11061, 11095);

                    return SpecialType.System_Boolean;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 10992, 11110);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11126, 11241) || true) && (f_37_11130_11145(value) == typeof(char))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 11126, 11241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11195, 11226);

                    return SpecialType.System_Char;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 11126, 11241);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11257, 11373) || true) && (f_37_11261_11276(value) == typeof(long))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 11257, 11373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11326, 11358);

                    return SpecialType.System_Int64;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 11257, 11373);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11389, 11508) || true) && (f_37_11393_11408(value) == typeof(double))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 11389, 11508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11460, 11493);

                    return SpecialType.System_Double;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 11389, 11508);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11524, 11641) || true) && (f_37_11528_11543(value) == typeof(uint))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 11524, 11641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11593, 11626);

                    return SpecialType.System_UInt32;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 11524, 11641);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11657, 11775) || true) && (f_37_11661_11676(value) == typeof(ulong))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 11657, 11775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11727, 11760);

                    return SpecialType.System_UInt64;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 11657, 11775);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11791, 11909) || true) && (f_37_11795_11810(value) == typeof(float))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 11791, 11909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11861, 11894);

                    return SpecialType.System_Single;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 11791, 11909);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11925, 12046) || true) && (f_37_11929_11944(value) == typeof(decimal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 11925, 12046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 11997, 12031);

                    return SpecialType.System_Decimal;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 11925, 12046);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 12062, 12179) || true) && (f_37_12066_12081(value) == typeof(short))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 12062, 12179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 12132, 12164);

                    return SpecialType.System_Int16;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 12062, 12179);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 12195, 12314) || true) && (f_37_12199_12214(value) == typeof(ushort))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 12195, 12314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 12266, 12299);

                    return SpecialType.System_UInt16;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 12195, 12314);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 12330, 12453) || true) && (f_37_12334_12349(value) == typeof(DateTime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 12330, 12453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 12403, 12438);

                    return SpecialType.System_DateTime;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 12330, 12453);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 12469, 12584) || true) && (f_37_12473_12488(value) == typeof(byte))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 12469, 12584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 12538, 12569);

                    return SpecialType.System_Byte;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 12469, 12584);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 12600, 12717) || true) && (f_37_12604_12619(value) == typeof(sbyte))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(37, 12600, 12717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 12670, 12702);

                    return SpecialType.System_SByte;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(37, 12600, 12717);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(37, 12733, 12757);

                return SpecialType.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(37, 10378, 12768);

                int
                f_37_10472_10505(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 10472, 10505);
                    return 0;
                }


                System.Type
                f_37_10730_10745(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 10730, 10745);
                    return return_v;
                }


                System.Type
                f_37_10861_10876(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 10861, 10876);
                    return return_v;
                }


                System.Type
                f_37_10996_11011(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 10996, 11011);
                    return return_v;
                }


                System.Type
                f_37_11130_11145(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 11130, 11145);
                    return return_v;
                }


                System.Type
                f_37_11261_11276(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 11261, 11276);
                    return return_v;
                }


                System.Type
                f_37_11393_11408(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 11393, 11408);
                    return return_v;
                }


                System.Type
                f_37_11528_11543(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 11528, 11543);
                    return return_v;
                }


                System.Type
                f_37_11661_11676(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 11661, 11676);
                    return return_v;
                }


                System.Type
                f_37_11795_11810(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 11795, 11810);
                    return return_v;
                }


                System.Type
                f_37_11929_11944(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 11929, 11944);
                    return return_v;
                }


                System.Type
                f_37_12066_12081(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 12066, 12081);
                    return return_v;
                }


                System.Type
                f_37_12199_12214(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 12199, 12214);
                    return return_v;
                }


                System.Type
                f_37_12334_12349(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 12334, 12349);
                    return return_v;
                }


                System.Type
                f_37_12473_12488(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 12473, 12488);
                    return return_v;
                }


                System.Type
                f_37_12604_12619(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(37, 12604, 12619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(37, 10378, 12768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 10378, 12768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SpecialTypeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(37, 291, 12775);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(37, 291, 12775);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(37, 291, 12775);
        }

    }
}
