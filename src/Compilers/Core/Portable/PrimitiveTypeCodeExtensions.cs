// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal static class PrimitiveTypeCodeExtensions
    {
        public static bool Is64BitIntegral(this Cci.PrimitiveTypeCode kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26, 342, 686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 434, 675);

                switch (kind)
                {

                    case Cci.PrimitiveTypeCode.Int64:
                    case Cci.PrimitiveTypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 434, 675);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 587, 599);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 434, 675);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 434, 675);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 647, 660);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 434, 675);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26, 342, 686);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26, 342, 686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26, 342, 686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsSigned(this Cci.PrimitiveTypeCode kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26, 698, 1293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 783, 1282);

                switch (kind)
                {

                    case Cci.PrimitiveTypeCode.Int8:
                    case Cci.PrimitiveTypeCode.Int16:
                    case Cci.PrimitiveTypeCode.Int32:
                    case Cci.PrimitiveTypeCode.Int64:
                    case Cci.PrimitiveTypeCode.IntPtr:
                    case Cci.PrimitiveTypeCode.Float32:
                    case Cci.PrimitiveTypeCode.Float64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 783, 1282);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 1194, 1206);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 783, 1282);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 783, 1282);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 1254, 1267);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 783, 1282);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26, 698, 1293);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26, 698, 1293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26, 698, 1293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsUnsigned(this Cci.PrimitiveTypeCode kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26, 1305, 1965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 1392, 1954);

                switch (kind)
                {

                    case Cci.PrimitiveTypeCode.UInt8:
                    case Cci.PrimitiveTypeCode.UInt16:
                    case Cci.PrimitiveTypeCode.UInt32:
                    case Cci.PrimitiveTypeCode.UInt64:
                    case Cci.PrimitiveTypeCode.UIntPtr:
                    case Cci.PrimitiveTypeCode.Char:
                    case Cci.PrimitiveTypeCode.Pointer:
                    case Cci.PrimitiveTypeCode.FunctionPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 1392, 1954);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 1866, 1878);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 1392, 1954);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 1392, 1954);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 1926, 1939);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 1392, 1954);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26, 1305, 1965);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26, 1305, 1965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26, 1305, 1965);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsFloatingPoint(this Cci.PrimitiveTypeCode kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26, 1977, 2324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 2069, 2313);

                switch (kind)
                {

                    case Cci.PrimitiveTypeCode.Float32:
                    case Cci.PrimitiveTypeCode.Float64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2069, 2313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 2225, 2237);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2069, 2313);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2069, 2313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 2285, 2298);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2069, 2313);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26, 1977, 2324);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26, 1977, 2324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26, 1977, 2324);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValueTypeDiscriminator GetConstantValueTypeDiscriminator(this Cci.PrimitiveTypeCode type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26, 2338, 3885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 2474, 3874);

                switch (type)
                {

                    case Cci.PrimitiveTypeCode.Int8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 2553, 2597);

                        return ConstantValueTypeDiscriminator.SByte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    case Cci.PrimitiveTypeCode.UInt8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 2649, 2692);

                        return ConstantValueTypeDiscriminator.Byte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    case Cci.PrimitiveTypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 2744, 2788);

                        return ConstantValueTypeDiscriminator.Int16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    case Cci.PrimitiveTypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 2841, 2886);

                        return ConstantValueTypeDiscriminator.UInt16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    case Cci.PrimitiveTypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 2938, 2982);

                        return ConstantValueTypeDiscriminator.Int32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    case Cci.PrimitiveTypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 3035, 3080);

                        return ConstantValueTypeDiscriminator.UInt32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    case Cci.PrimitiveTypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 3132, 3176);

                        return ConstantValueTypeDiscriminator.Int64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    case Cci.PrimitiveTypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 3229, 3274);

                        return ConstantValueTypeDiscriminator.UInt64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    case Cci.PrimitiveTypeCode.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 3325, 3368);

                        return ConstantValueTypeDiscriminator.Char;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    case Cci.PrimitiveTypeCode.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 3422, 3468);

                        return ConstantValueTypeDiscriminator.Boolean;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    case Cci.PrimitiveTypeCode.Float32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 3522, 3567);

                        return ConstantValueTypeDiscriminator.Single;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    case Cci.PrimitiveTypeCode.Float64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 3621, 3666);

                        return ConstantValueTypeDiscriminator.Double;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    case Cci.PrimitiveTypeCode.String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 3719, 3764);

                        return ConstantValueTypeDiscriminator.String;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26, 2474, 3874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26, 3812, 3859);

                        throw f_26_3818_3858(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26, 2474, 3874);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26, 2338, 3885);

                System.Exception
                f_26_3818_3858(Microsoft.Cci.PrimitiveTypeCode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26, 3818, 3858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26, 2338, 3885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26, 2338, 3885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PrimitiveTypeCodeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(26, 276, 3892);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(26, 276, 3892);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26, 276, 3892);
        }

    }
}
