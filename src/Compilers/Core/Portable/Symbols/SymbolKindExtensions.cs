// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal static class SymbolKindExtensions
    {
        public static int ToSortOrder(this SymbolKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(643, 335, 1926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 411, 1915);

                switch (kind)
                {

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 501, 510);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 573, 582);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 647, 656);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 718, 727);

                        return 3;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 793, 802);

                        return 4;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.Namespace:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 868, 877);

                        return 5;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.Alias:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 939, 948);

                        return 6;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 1014, 1023);

                        return 7;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.Assembly:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 1088, 1097);

                        return 8;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.Label:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 1253, 1263);

                        return 10;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 1325, 1335);

                        return 11;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.NetModule:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 1401, 1411);

                        return 12;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 1477, 1487);

                        return 13;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 1557, 1567);

                        return 14;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 1637, 1647);

                        return 15;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.DynamicType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 1715, 1725);

                        return 16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    case SymbolKind.Preprocessing:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 1795, 1805);

                        return 17;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(643, 411, 1915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(643, 1853, 1900);

                        throw f_643_1859_1899(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(643, 411, 1915);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(643, 335, 1926);

                System.Exception
                f_643_1859_1899(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(643, 1859, 1899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(643, 335, 1926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(643, 335, 1926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolKindExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(643, 276, 1933);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(643, 276, 1933);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(643, 276, 1933);
        }

    }
}
