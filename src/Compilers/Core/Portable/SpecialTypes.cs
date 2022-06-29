// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal static class SpecialTypes
    {
        private static readonly string?[] s_emittedNames;

        private static readonly Dictionary<string, SpecialType> s_nameToTypeIdMap;

        private static readonly Microsoft.Cci.PrimitiveTypeCode[] s_typeIdToTypeCodeMap;

        private static readonly SpecialType[] s_typeCodeToTypeIdMap;

        static SpecialTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(38, 3052, 7604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 686, 2791);
                s_emittedNames = new string?[]
                        {
            // The following things should be in sync:
            // 1) SpecialType enum
            // 2) names in SpecialTypes.EmittedNames array.
            // 3) languageNames in SemanticFacts.cs
            // 4) languageNames in SemanticFacts.vb
            null, // SpecialType.None
            "System.Object",
            "System.Enum",
            "System.MulticastDelegate",
            "System.Delegate",
            "System.ValueType",
            "System.Void",
            "System.Boolean",
            "System.Char",
            "System.SByte",
            "System.Byte",
            "System.Int16",
            "System.UInt16",
            "System.Int32",
            "System.UInt32",
            "System.Int64",
            "System.UInt64",
            "System.Decimal",
            "System.Single",
            "System.Double",
            "System.String",
            "System.IntPtr",
            "System.UIntPtr",
            "System.Array",
            "System.Collections.IEnumerable",
            "System.Collections.Generic.IEnumerable`1",
            "System.Collections.Generic.IList`1",
            "System.Collections.Generic.ICollection`1",
            "System.Collections.IEnumerator",
            "System.Collections.Generic.IEnumerator`1",
            "System.Collections.Generic.IReadOnlyList`1",
            "System.Collections.Generic.IReadOnlyCollection`1",
            "System.Nullable`1",
            "System.DateTime",
            "System.Runtime.CompilerServices.IsVolatile",
            "System.IDisposable",
            "System.TypedReference",
            "System.ArgIterator",
            "System.RuntimeArgumentHandle",
            "System.RuntimeFieldHandle",
            "System.RuntimeMethodHandle",
            "System.RuntimeTypeHandle",
            "System.IAsyncResult",
            "System.AsyncCallback",
            "System.Runtime.CompilerServices.RuntimeFeature",
            "System.Runtime.CompilerServices.PreserveBaseOverridesAttribute",
                        }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 2860, 2877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 2948, 2969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3018, 3039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3098, 3178);

                s_nameToTypeIdMap = f_38_3118_3177(SpecialType.Count);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3194, 3200);

                int
                i
                = default(int);
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3221, 3226)
        , i = 1; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3216, 3575) || true) && (i < f_38_3232_3253(s_emittedNames))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3255, 3258)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(38, 3216, 3575))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(38, 3216, 3575);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3292, 3325);

                        string?
                        name = s_emittedNames[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3343, 3378);

                        f_38_3343_3377(name is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3396, 3432);

                        f_38_3396_3431(f_38_3409_3426(name, '+') < 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3516, 3560);

                        f_38_3516_3559(s_nameToTypeIdMap, name, i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(38, 1, 360);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(38, 1, 360);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3591, 3679);

                s_typeIdToTypeCodeMap = new Microsoft.Cci.PrimitiveTypeCode[(int)SpecialType.Count + 1];
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3700, 3705)
        , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3695, 3865) || true) && (i < f_38_3711_3739(s_typeIdToTypeCodeMap))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3741, 3744)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(38, 3695, 3865))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(38, 3695, 3865);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3778, 3850);

                        s_typeIdToTypeCodeMap[i] = Microsoft.Cci.PrimitiveTypeCode.NotPrimitive;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(38, 1, 171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(38, 1, 171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3881, 3978);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_Boolean] = Microsoft.Cci.PrimitiveTypeCode.Boolean;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 3992, 4083);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_Char] = Microsoft.Cci.PrimitiveTypeCode.Char;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 4097, 4188);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_Void] = Microsoft.Cci.PrimitiveTypeCode.Void;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 4202, 4297);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_String] = Microsoft.Cci.PrimitiveTypeCode.String;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 4311, 4404);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_Int64] = Microsoft.Cci.PrimitiveTypeCode.Int64;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 4418, 4511);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_Int32] = Microsoft.Cci.PrimitiveTypeCode.Int32;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 4525, 4618);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_Int16] = Microsoft.Cci.PrimitiveTypeCode.Int16;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 4632, 4724);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_SByte] = Microsoft.Cci.PrimitiveTypeCode.Int8;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 4738, 4833);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_UInt64] = Microsoft.Cci.PrimitiveTypeCode.UInt64;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 4847, 4942);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_UInt32] = Microsoft.Cci.PrimitiveTypeCode.UInt32;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 4956, 5051);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_UInt16] = Microsoft.Cci.PrimitiveTypeCode.UInt16;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 5065, 5157);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_Byte] = Microsoft.Cci.PrimitiveTypeCode.UInt8;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 5171, 5267);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_Single] = Microsoft.Cci.PrimitiveTypeCode.Float32;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 5281, 5377);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_Double] = Microsoft.Cci.PrimitiveTypeCode.Float64;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 5391, 5486);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_IntPtr] = Microsoft.Cci.PrimitiveTypeCode.IntPtr;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 5500, 5597);

                s_typeIdToTypeCodeMap[(int)SpecialType.System_UIntPtr] = Microsoft.Cci.PrimitiveTypeCode.UIntPtr;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 5613, 5703);

                s_typeCodeToTypeIdMap = new SpecialType[(int)Microsoft.Cci.PrimitiveTypeCode.Invalid + 1];
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 5724, 5729)
        , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 5719, 5861) || true) && (i < f_38_5735_5763(s_typeCodeToTypeIdMap))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 5765, 5768)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(38, 5719, 5861))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(38, 5719, 5861);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 5802, 5846);

                        s_typeCodeToTypeIdMap[i] = SpecialType.None;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(38, 1, 143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(38, 1, 143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 5877, 5974);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.Boolean] = SpecialType.System_Boolean;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 5988, 6079);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.Char] = SpecialType.System_Char;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 6093, 6184);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.Void] = SpecialType.System_Void;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 6198, 6293);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.String] = SpecialType.System_String;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 6307, 6400);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.Int64] = SpecialType.System_Int64;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 6414, 6507);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.Int32] = SpecialType.System_Int32;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 6521, 6614);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.Int16] = SpecialType.System_Int16;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 6628, 6720);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.Int8] = SpecialType.System_SByte;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 6734, 6829);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.UInt64] = SpecialType.System_UInt64;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 6843, 6938);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.UInt32] = SpecialType.System_UInt32;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 6952, 7047);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.UInt16] = SpecialType.System_UInt16;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 7061, 7153);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.UInt8] = SpecialType.System_Byte;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 7167, 7263);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.Float32] = SpecialType.System_Single;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 7277, 7373);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.Float64] = SpecialType.System_Double;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 7387, 7482);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.IntPtr] = SpecialType.System_IntPtr;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 7496, 7593);

                s_typeCodeToTypeIdMap[(int)Microsoft.Cci.PrimitiveTypeCode.UIntPtr] = SpecialType.System_UIntPtr;
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(38, 3052, 7604);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(38, 3052, 7604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(38, 3052, 7604);
            }
        }

        public static string? GetMetadataName(this SpecialType id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(38, 7742, 7867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 7825, 7856);

                return s_emittedNames[(int)id];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(38, 7742, 7867);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(38, 7742, 7867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(38, 7742, 7867);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SpecialType GetTypeFromMetadataName(string metadataName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(38, 7879, 8170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 7974, 7989);

                SpecialType
                id
                = default(SpecialType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 8005, 8119) || true) && (f_38_8009_8060(s_nameToTypeIdMap, metadataName, out id))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(38, 8005, 8119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 8094, 8104);

                    return id;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(38, 8005, 8119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 8135, 8159);

                return SpecialType.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(38, 7879, 8170);

                bool
                f_38_8009_8060(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SpecialType>
                this_param, string
                key, out Microsoft.CodeAnalysis.SpecialType
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(38, 8009, 8060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(38, 7879, 8170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(38, 7879, 8170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SpecialType GetTypeFromMetadataName(Microsoft.Cci.PrimitiveTypeCode typeCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(38, 8182, 8353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 8298, 8342);

                return s_typeCodeToTypeIdMap[(int)typeCode];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(38, 8182, 8353);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(38, 8182, 8353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(38, 8182, 8353);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Microsoft.Cci.PrimitiveTypeCode GetTypeCode(SpecialType typeId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(38, 8365, 8520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(38, 8467, 8509);

                return s_typeIdToTypeCodeMap[(int)typeId];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(38, 8365, 8520);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(38, 8365, 8520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(38, 8365, 8520);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SpecialType>
        f_38_3118_3177(Microsoft.CodeAnalysis.SpecialType
        capacity)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SpecialType>((int)capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(38, 3118, 3177);
            return return_v;
        }


        static int
        f_38_3232_3253(string?[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(38, 3232, 3253);
            return return_v;
        }


        static int
        f_38_3343_3377(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(38, 3343, 3377);
            return 0;
        }


        static int
        f_38_3409_3426(string
        this_param, char
        value)
        {
            var return_v = this_param.IndexOf(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(38, 3409, 3426);
            return return_v;
        }


        static int
        f_38_3396_3431(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(38, 3396, 3431);
            return 0;
        }


        static int
        f_38_3516_3559(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SpecialType>
        this_param, string
        key, int
        value)
        {
            this_param.Add(key, (Microsoft.CodeAnalysis.SpecialType)value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(38, 3516, 3559);
            return 0;
        }


        static int
        f_38_3711_3739(Microsoft.Cci.PrimitiveTypeCode[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(38, 3711, 3739);
            return return_v;
        }


        static int
        f_38_5735_5763(Microsoft.CodeAnalysis.SpecialType[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(38, 5735, 5763);
            return return_v;
        }

    }
}
