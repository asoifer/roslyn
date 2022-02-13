// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class SpecialTypeExtensions
    {
        public static bool CanBeConst(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10058, 345, 1265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10058, 429, 1254);

                switch (specialType)
                {

                    case SpecialType.System_Boolean:
                    case SpecialType.System_Char:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_Byte:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_Single:
                    case SpecialType.System_Double:
                    case SpecialType.System_Decimal:
                    case SpecialType.System_String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10058, 429, 1254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10058, 1166, 1178);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10058, 429, 1254);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10058, 429, 1254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10058, 1226, 1239);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10058, 429, 1254);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10058, 345, 1265);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10058, 345, 1265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10058, 345, 1265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValidVolatileFieldType(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10058, 1277, 2065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10058, 1375, 2054);

                switch (specialType)
                {

                    case SpecialType.System_Byte:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Char:
                    case SpecialType.System_Single:
                    case SpecialType.System_Boolean:
                    case SpecialType.System_IntPtr:
                    case SpecialType.System_UIntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10058, 1375, 2054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10058, 1966, 1978);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10058, 1375, 2054);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10058, 1375, 2054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10058, 2026, 2039);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10058, 1375, 2054);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10058, 1277, 2065);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10058, 1277, 2065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10058, 1277, 2065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int FixedBufferElementSizeInBytes(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10058, 2077, 2426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10058, 2334, 2415);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10058, 2341, 2382) || ((specialType == SpecialType.System_Decimal && DynAbs.Tracing.TraceSender.Conditional_F2(10058, 2385, 2386)) || DynAbs.Tracing.TraceSender.Conditional_F3(10058, 2389, 2414))) ? 0 : f_10058_2389_2414(specialType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10058, 2077, 2426);

                int
                f_10058_2389_2414(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.SizeInBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10058, 2389, 2414);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10058, 2077, 2426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10058, 2077, 2426);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SpecialTypeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10058, 285, 2433);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10058, 285, 2433);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10058, 285, 2433);
        }

    }
}
