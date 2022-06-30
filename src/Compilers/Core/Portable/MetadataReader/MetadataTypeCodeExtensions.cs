// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Utilities;
using System.Reflection.Metadata;

namespace Microsoft.CodeAnalysis
{
    internal static class MetadataTypeCodeExtensions
    {
        internal static SpecialType ToSpecialType(this SignatureTypeCode typeCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(410, 397, 2543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 496, 2532);

                switch (typeCode)
                {

                    case SignatureTypeCode.TypedReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 606, 647);

                        return SpecialType.System_TypedReference;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.Void:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 717, 748);

                        return SpecialType.System_Void;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 821, 855);

                        return SpecialType.System_Boolean;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 926, 958);

                        return SpecialType.System_SByte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 1028, 1059);

                        return SpecialType.System_Byte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 1130, 1162);

                        return SpecialType.System_Int16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 1234, 1267);

                        return SpecialType.System_UInt16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 1338, 1370);

                        return SpecialType.System_Int32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 1442, 1475);

                        return SpecialType.System_UInt32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 1546, 1578);

                        return SpecialType.System_Int64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 1650, 1683);

                        return SpecialType.System_UInt64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 1755, 1788);

                        return SpecialType.System_Single;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 1860, 1893);

                        return SpecialType.System_Double;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 1963, 1994);

                        return SpecialType.System_Char;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 2066, 2099);

                        return SpecialType.System_String;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.IntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 2171, 2204);

                        return SpecialType.System_IntPtr;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.UIntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 2277, 2311);

                        return SpecialType.System_UIntPtr;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    case SignatureTypeCode.Object:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 2383, 2416);

                        return SpecialType.System_Object;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 496, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 2466, 2517);

                        throw f_410_2472_2516(typeCode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 496, 2532);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(410, 397, 2543);

                System.Exception
                f_410_2472_2516(System.Reflection.Metadata.SignatureTypeCode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(410, 2472, 2516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(410, 397, 2543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(410, 397, 2543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasShortFormSignatureEncoding(this SpecialType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(410, 2555, 5263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 4264, 5223);

                switch (type)
                {

                    case SpecialType.System_String:
                    case SpecialType.System_Object:
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
                    case SpecialType.System_IntPtr:
                    case SpecialType.System_UIntPtr:
                    case SpecialType.System_TypedReference:
                    case SpecialType.System_Single:
                    case SpecialType.System_Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 4264, 5223);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 5196, 5208);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 4264, 5223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 5239, 5252);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(410, 2555, 5263);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(410, 2555, 5263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(410, 2555, 5263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SerializationTypeCode ToSerializationType(this SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(410, 5275, 7068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 5387, 7057);

                switch (specialType)
                {

                    case SpecialType.System_Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 5494, 5531);

                        return SerializationTypeCode.Boolean;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 5603, 5638);

                        return SerializationTypeCode.SByte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 5709, 5743);

                        return SerializationTypeCode.Byte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 5815, 5850);

                        return SerializationTypeCode.Int16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 5922, 5957);

                        return SerializationTypeCode.Int32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 6029, 6064);

                        return SerializationTypeCode.Int64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 6137, 6173);

                        return SerializationTypeCode.UInt16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 6246, 6282);

                        return SerializationTypeCode.UInt32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 6355, 6391);

                        return SerializationTypeCode.UInt64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 6464, 6500);

                        return SerializationTypeCode.Single;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 6573, 6609);

                        return SerializationTypeCode.Double;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 6680, 6714);

                        return SerializationTypeCode.Char;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 6787, 6823);

                        return SerializationTypeCode.String;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    case SpecialType.System_Object:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 6896, 6938);

                        return SerializationTypeCode.TaggedObject;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(410, 5387, 7057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(410, 6988, 7042);

                        throw f_410_6994_7041(specialType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(410, 5387, 7057);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(410, 5275, 7068);

                System.Exception
                f_410_6994_7041(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(410, 6994, 7041);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(410, 5275, 7068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(410, 5275, 7068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MetadataTypeCodeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(410, 332, 7075);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(410, 332, 7075);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(410, 332, 7075);
        }

    }
}
