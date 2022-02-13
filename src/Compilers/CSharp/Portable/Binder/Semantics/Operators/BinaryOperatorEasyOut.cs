// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class OverloadResolution
    {
        internal static class BinopEasyOut
        {
            private const BinaryOperatorKind
            ERR = BinaryOperatorKind.Error
            ;

            private const BinaryOperatorKind
            OBJ = BinaryOperatorKind.Object
            ;

            private const BinaryOperatorKind
            STR = BinaryOperatorKind.String
            ;

            private const BinaryOperatorKind
            OSC = BinaryOperatorKind.ObjectAndString
            ;

            private const BinaryOperatorKind
            SOC = BinaryOperatorKind.StringAndObject
            ;

            private const BinaryOperatorKind
            INT = BinaryOperatorKind.Int
            ;

            private const BinaryOperatorKind
            UIN = BinaryOperatorKind.UInt
            ;

            private const BinaryOperatorKind
            LNG = BinaryOperatorKind.Long
            ;

            private const BinaryOperatorKind
            ULG = BinaryOperatorKind.ULong
            ;

            private const BinaryOperatorKind
            NIN = BinaryOperatorKind.NInt
            ;

            private const BinaryOperatorKind
            NUI = BinaryOperatorKind.NUInt
            ;

            private const BinaryOperatorKind
            FLT = BinaryOperatorKind.Float
            ;

            private const BinaryOperatorKind
            DBL = BinaryOperatorKind.Double
            ;

            private const BinaryOperatorKind
            DEC = BinaryOperatorKind.Decimal
            ;

            private const BinaryOperatorKind
            BOL = BinaryOperatorKind.Bool
            ;

            private const BinaryOperatorKind
            LIN = BinaryOperatorKind.Lifted | BinaryOperatorKind.Int
            ;

            private const BinaryOperatorKind
            LUN = BinaryOperatorKind.Lifted | BinaryOperatorKind.UInt
            ;

            private const BinaryOperatorKind
            LLG = BinaryOperatorKind.Lifted | BinaryOperatorKind.Long
            ;

            private const BinaryOperatorKind
            LUL = BinaryOperatorKind.Lifted | BinaryOperatorKind.ULong
            ;

            private const BinaryOperatorKind
            LNI = BinaryOperatorKind.Lifted | BinaryOperatorKind.NInt
            ;

            private const BinaryOperatorKind
            LNU = BinaryOperatorKind.Lifted | BinaryOperatorKind.NUInt
            ;

            private const BinaryOperatorKind
            LFL = BinaryOperatorKind.Lifted | BinaryOperatorKind.Float
            ;

            private const BinaryOperatorKind
            LDB = BinaryOperatorKind.Lifted | BinaryOperatorKind.Double
            ;

            private const BinaryOperatorKind
            LDC = BinaryOperatorKind.Lifted | BinaryOperatorKind.Decimal
            ;

            private const BinaryOperatorKind
            LBL = BinaryOperatorKind.Lifted | BinaryOperatorKind.Bool
            ;

            private static readonly BinaryOperatorKind[,] s_arithmetic;

            private static readonly BinaryOperatorKind[,] s_addition;

            private static readonly BinaryOperatorKind[,] s_shift;

            private static readonly BinaryOperatorKind[,] s_equality;

            private static readonly BinaryOperatorKind[,] s_logical;

            private static readonly BinaryOperatorKind[][,] s_opkind;

            public static BinaryOperatorKind OpKind(BinaryOperatorKind kind, TypeSymbol left, TypeSymbol right)
            {
                int leftIndex = left.TypeToIndex();
                if (leftIndex < 0)
                {
                    return BinaryOperatorKind.Error;
                }
                int rightIndex = right.TypeToIndex();
                if (rightIndex < 0)
                {
                    return BinaryOperatorKind.Error;
                }

                var result = BinaryOperatorKind.Error;

                // kind.OperatorIndex() collapses '&' and '&&' (and '|' and '||').  To correct
                // this problem, we handle kinds satisfying IsLogical() separately.  Fortunately,
                // such operators only work on boolean types, so there's no need to write out
                // a whole new table.
                //
                // Example: int & int is legal, but int && int is not, so we can't use the same
                // table for both operators.
                if (!kind.IsLogical() || (leftIndex == (int)BinaryOperatorKind.Bool && rightIndex == (int)BinaryOperatorKind.Bool))
                {
                    result = s_opkind[kind.OperatorIndex()][leftIndex, rightIndex];
                }

                return result == BinaryOperatorKind.Error ? result : result | kind;
            }

            static BinopEasyOut()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10852, 396, 37552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 488, 518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 566, 597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 645, 676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 724, 764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 812, 852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 900, 928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 976, 1005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 1053, 1082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 1130, 1160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 1208, 1237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 1285, 1315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 1363, 1393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 1441, 1472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 1520, 1552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 1600, 1629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 1677, 1733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 1781, 1838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 1886, 1943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 1991, 2049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 2097, 2154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 2202, 2260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 2308, 2366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 2414, 2473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 2521, 2581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 2629, 2686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 2811, 9157);
                s_arithmetic = new BinaryOperatorKind[,]{
                //          obj  str  bool chr  i08  i16  i32  i64  u08  u16  u32  u64 nint nuint r32  r64  dec bool? chr? i08? i16? i32? i64? u08? u16? u32? u64?nint?nuint?r32? r64? dec? 
                /*  obj */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  str */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* bool */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  chr */{ ERR, ERR, ERR, INT, INT, INT, INT, LNG, INT, INT, UIN, ULG, NIN, NUI, FLT, DBL, DEC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /*  i08 */{ ERR, ERR, ERR, INT, INT, INT, INT, LNG, INT, INT, LNG, ERR, NIN, ERR, FLT, DBL, DEC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*  i16 */{ ERR, ERR, ERR, INT, INT, INT, INT, LNG, INT, INT, LNG, ERR, NIN, ERR, FLT, DBL, DEC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*  i32 */{ ERR, ERR, ERR, INT, INT, INT, INT, LNG, INT, INT, LNG, ERR, NIN, ERR, FLT, DBL, DEC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*  i64 */{ ERR, ERR, ERR, LNG, LNG, LNG, LNG, LNG, LNG, LNG, LNG, ERR, LNG, ERR, FLT, DBL, DEC, ERR, LLG, LLG, LLG, LLG, LLG, LLG, LLG, LLG, ERR, LLG, ERR, LFL, LDB, LDC },
                /*  u08 */{ ERR, ERR, ERR, INT, INT, INT, INT, LNG, INT, INT, UIN, ULG, NIN, NUI, FLT, DBL, DEC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /*  u16 */{ ERR, ERR, ERR, INT, INT, INT, INT, LNG, INT, INT, UIN, ULG, NIN, NUI, FLT, DBL, DEC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /*  u32 */{ ERR, ERR, ERR, UIN, LNG, LNG, LNG, LNG, UIN, UIN, UIN, ULG, LNG, NUI, FLT, DBL, DEC, ERR, LUN, LLG, LLG, LLG, LLG, LUN, LUN, LUN, LUL, LLG, LNU, LFL, LDB, LDC },
                /*  u64 */{ ERR, ERR, ERR, ULG, ERR, ERR, ERR, ERR, ULG, ULG, ULG, ULG, ERR, ULG, FLT, DBL, DEC, ERR, LUL, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, LFL, LDB, LDC },
                /* nint */{ ERR, ERR, ERR, NIN, NIN, NIN, NIN, LNG, NIN, NIN, LNG, ERR, NIN, ERR, FLT, DBL, DEC, ERR, LNI, LNI, LNI, LNI, LLG, LNI, LNI, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*nuint */{ ERR, ERR, ERR, NUI, ERR, ERR, ERR, ERR, NUI, NUI, NUI, ULG, ERR, NUI, FLT, DBL, DEC, ERR, LNU, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LUL, ERR, LNU, LFL, LDB, LDC },
                /*  r32 */{ ERR, ERR, ERR, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, DBL, ERR, ERR, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LDB, ERR },
                /*  r64 */{ ERR, ERR, ERR, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, ERR, ERR, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, ERR },
                /*  dec */{ ERR, ERR, ERR, DEC, DEC, DEC, DEC, DEC, DEC, DEC, DEC, DEC, DEC, DEC, ERR, ERR, DEC, ERR, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, ERR, ERR, LDC },
                /*bool? */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* chr? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /* i08? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /* i16? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /* i32? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /* i64? */{ ERR, ERR, ERR, LLG, LLG, LLG, LLG, LLG, LLG, LLG, LLG, ERR, LLG, ERR, LFL, LDB, LDC, ERR, LLG, LLG, LLG, LLG, LLG, LLG, LLG, LLG, ERR, LLG, ERR, LFL, LDB, LDC },
                /* u08? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /* u16? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /* u32? */{ ERR, ERR, ERR, LUN, LLG, LLG, LLG, LLG, LUN, LUN, LUN, LUL, LLG, LNU, LFL, LDB, LDC, ERR, LUN, LLG, LLG, LLG, LLG, LUN, LUN, LUN, LUL, LLG, LNU, LFL, LDB, LDC },
                /* u64? */{ ERR, ERR, ERR, LUL, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, LFL, LDB, LDC, ERR, LUL, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, LFL, LDB, LDC },
                /*nint? */{ ERR, ERR, ERR, LNI, LNI, LNI, LNI, LLG, LNI, LNI, LLG, ERR, LNI, ERR, LFL, LDB, LDC, ERR, LNI, LNI, LNI, LNI, LLG, LNI, LNI, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*nuint?*/{ ERR, ERR, ERR, LNU, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LUL, ERR, LNU, LFL, LDB, LDC, ERR, LNU, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LUL, ERR, LNU, LFL, LDB, LDC },
                /* r32? */{ ERR, ERR, ERR, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LDB, ERR, ERR, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LDB, ERR },
                /* r64? */{ ERR, ERR, ERR, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, ERR, ERR, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, ERR },
                /* dec? */{ ERR, ERR, ERR, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, ERR, ERR, LDC, ERR, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, ERR, ERR, LDC },
            }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 9266, 15610);
                s_addition = new BinaryOperatorKind[,]{
                //          obj  str  bool chr  i08  i16  i32  i64  u08  u16  u32  u64 nint nuint r32  r64  dec bool? chr? i08? i16? i32? i64? u08? u16? u32? u64?nint?nuint?r32? r64? dec? 
                /*  obj */{ ERR, OSC, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  str */{ SOC, STR, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC, SOC },
                /* bool */{ ERR, OSC, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  chr */{ ERR, OSC, ERR, INT, INT, INT, INT, LNG, INT, INT, UIN, ULG, NIN, NUI, FLT, DBL, DEC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /*  i08 */{ ERR, OSC, ERR, INT, INT, INT, INT, LNG, INT, INT, LNG, ERR, NIN, ERR, FLT, DBL, DEC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*  i16 */{ ERR, OSC, ERR, INT, INT, INT, INT, LNG, INT, INT, LNG, ERR, NIN, ERR, FLT, DBL, DEC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*  i32 */{ ERR, OSC, ERR, INT, INT, INT, INT, LNG, INT, INT, LNG, ERR, NIN, ERR, FLT, DBL, DEC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*  i64 */{ ERR, OSC, ERR, LNG, LNG, LNG, LNG, LNG, LNG, LNG, LNG, ERR, LNG, ERR, FLT, DBL, DEC, ERR, LLG, LLG, LLG, LLG, LLG, LLG, LLG, LLG, ERR, LLG, ERR, LFL, LDB, LDC },
                /*  u08 */{ ERR, OSC, ERR, INT, INT, INT, INT, LNG, INT, INT, UIN, ULG, NIN, NUI, FLT, DBL, DEC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /*  u16 */{ ERR, OSC, ERR, INT, INT, INT, INT, LNG, INT, INT, UIN, ULG, NIN, NUI, FLT, DBL, DEC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /*  u32 */{ ERR, OSC, ERR, UIN, LNG, LNG, LNG, LNG, UIN, UIN, UIN, ULG, LNG, NUI, FLT, DBL, DEC, ERR, LUN, LLG, LLG, LLG, LLG, LUN, LUN, LUN, LUL, LLG, LNU, LFL, LDB, LDC },
                /*  u64 */{ ERR, OSC, ERR, ULG, ERR, ERR, ERR, ERR, ULG, ULG, ULG, ULG, ERR, ULG, FLT, DBL, DEC, ERR, LUL, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, LFL, LDB, LDC },
                /* nint */{ ERR, OSC, ERR, NIN, NIN, NIN, NIN, LNG, NIN, NIN, LNG, ERR, NIN, ERR, FLT, DBL, DEC, ERR, LNI, LNI, LNI, LNI, LLG, LNI, LNI, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*nuint */{ ERR, OSC, ERR, NUI, ERR, ERR, ERR, ERR, NUI, NUI, NUI, ULG, ERR, NUI, FLT, DBL, DEC, ERR, LNU, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LUL, ERR, LNU, LFL, LDB, LDC },
                /*  r32 */{ ERR, OSC, ERR, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, DBL, ERR, ERR, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LDB, ERR },
                /*  r64 */{ ERR, OSC, ERR, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, ERR, ERR, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, ERR },
                /*  dec */{ ERR, OSC, ERR, DEC, DEC, DEC, DEC, DEC, DEC, DEC, DEC, DEC, DEC, DEC, ERR, ERR, DEC, ERR, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, ERR, ERR, LDC },
                /*bool? */{ ERR, OSC, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* chr? */{ ERR, OSC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /* i08? */{ ERR, OSC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /* i16? */{ ERR, OSC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /* i32? */{ ERR, OSC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /* i64? */{ ERR, OSC, ERR, LLG, LLG, LLG, LLG, LLG, LLG, LLG, LLG, ERR, LLG, ERR, LFL, LDB, LDC, ERR, LLG, LLG, LLG, LLG, LLG, LLG, LLG, LLG, ERR, LLG, ERR, LFL, LDB, LDC },
                /* u08? */{ ERR, OSC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /* u16? */{ ERR, OSC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /* u32? */{ ERR, OSC, ERR, LUN, LLG, LLG, LLG, LLG, LUN, LUN, LUN, LUL, LLG, LNU, LFL, LDB, LDC, ERR, LUN, LLG, LLG, LLG, LLG, LUN, LUN, LUN, LUL, LLG, LNU, LFL, LDB, LDC },
                /* u64? */{ ERR, OSC, ERR, LUL, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, LFL, LDB, LDC, ERR, LUL, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, LFL, LDB, LDC },
                /*nint? */{ ERR, OSC, ERR, LNI, LNI, LNI, LNI, LLG, LNI, LNI, LLG, ERR, LNI, ERR, LFL, LDB, LDC, ERR, LNI, LNI, LNI, LNI, LLG, LNI, LNI, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*nuint?*/{ ERR, OSC, ERR, LNU, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LUL, ERR, LNU, LFL, LDB, LDC, ERR, LNU, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LUL, ERR, LNU, LFL, LDB, LDC },
                /* r32? */{ ERR, OSC, ERR, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LDB, ERR, ERR, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LDB, ERR },
                /* r64? */{ ERR, OSC, ERR, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, ERR, ERR, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, ERR },
                /* dec? */{ ERR, OSC, ERR, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, ERR, ERR, LDC, ERR, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, ERR, ERR, LDC },
            }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 15723, 22064);
                s_shift = new BinaryOperatorKind[,]{
                //          obj  str  bool chr  i08  i16  i32  i64  u08  u16  u32  u64 nint nuint r32  r64  dec bool? chr? i08? i16? i32? i64? u08? u16? u32? u64?nint?nuint?r32? r64? dec? 
                /*  obj */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  str */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* bool */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  chr */{ ERR, ERR, ERR, INT, INT, INT, INT, ERR, INT, INT, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  i08 */{ ERR, ERR, ERR, INT, INT, INT, INT, ERR, INT, INT, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  i16 */{ ERR, ERR, ERR, INT, INT, INT, INT, ERR, INT, INT, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  i32 */{ ERR, ERR, ERR, INT, INT, INT, INT, ERR, INT, INT, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  i64 */{ ERR, ERR, ERR, LNG, LNG, LNG, LNG, ERR, LNG, LNG, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LLG, LLG, LLG, LLG, ERR, LLG, LLG, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  u08 */{ ERR, ERR, ERR, INT, INT, INT, INT, ERR, INT, INT, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  u16 */{ ERR, ERR, ERR, INT, INT, INT, INT, ERR, INT, INT, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  u32 */{ ERR, ERR, ERR, UIN, UIN, UIN, UIN, ERR, UIN, UIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LUN, LUN, LUN, LUN, ERR, LUN, LUN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  u64 */{ ERR, ERR, ERR, ULG, ULG, ULG, ULG, ERR, ULG, ULG, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, LUL, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* nint */{ ERR, ERR, ERR, NIN, NIN, NIN, NIN, ERR, NIN, NIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LNI, LNI, LNI, LNI, ERR, LNI, LNI, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*nuint */{ ERR, ERR, ERR, NUI, NUI, NUI, NUI, ERR, NUI, NUI, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LNU, ERR, LNU, LNU, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  r32 */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  r64 */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  dec */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*bool? */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* chr? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* i08? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* i16? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* i32? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* i64? */{ ERR, ERR, ERR, LLG, LLG, LLG, LLG, ERR, LLG, LLG, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LLG, LLG, LLG, LLG, ERR, LLG, LLG, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* u08? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* u16? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, ERR, LIN, LIN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* u32? */{ ERR, ERR, ERR, LUN, LUN, LUN, LUN, ERR, LUN, LUN, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LUN, LUN, LUN, LUN, ERR, LUN, LUN, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* u64? */{ ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, LUL, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, LUL, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*nint? */{ ERR, ERR, ERR, LNI, LNI, LNI, LNI, ERR, LNI, LNI, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LNI, LNI, LNI, LNI, ERR, LNI, LNI, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*nuint?*/{ ERR, ERR, ERR, LNU, LNU, LNU, LNU, ERR, LNU, LNU, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LNU, ERR, LNU, LNU, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* r32? */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* r64? */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* dec? */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
            }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 22609, 28953);
                s_equality = new BinaryOperatorKind[,]{
                //          obj  str  bool chr  i08  i16  i32  i64  u08  u16  u32  u64 nint nuint r32  r64  dec bool? chr? i08? i16? i32? i64? u08? u16? u32? u64?nint?nuint?r32? r64? dec? 
                /*  obj */{ OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ },
                /*  str */{ OBJ, STR, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ },
                /* bool */{ OBJ, OBJ, BOL, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, LBL, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ },
                /*  chr */{ OBJ, OBJ, OBJ, INT, INT, INT, INT, LNG, INT, INT, UIN, ULG, NIN, NUI, FLT, DBL, DEC, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /*  i08 */{ OBJ, OBJ, OBJ, INT, INT, INT, INT, LNG, INT, INT, LNG, ERR, NIN, ERR, FLT, DBL, DEC, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*  i16 */{ OBJ, OBJ, OBJ, INT, INT, INT, INT, LNG, INT, INT, LNG, ERR, NIN, ERR, FLT, DBL, DEC, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*  i32 */{ OBJ, OBJ, OBJ, INT, INT, INT, INT, LNG, INT, INT, LNG, ERR, NIN, ERR, FLT, DBL, DEC, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*  i64 */{ OBJ, OBJ, OBJ, LNG, LNG, LNG, LNG, LNG, LNG, LNG, LNG, ERR, LNG, ERR, FLT, DBL, DEC, OBJ, LLG, LLG, LLG, LLG, LLG, LLG, LLG, LLG, ERR, LLG, ERR, LFL, LDB, LDC },
                /*  u08 */{ OBJ, OBJ, OBJ, INT, INT, INT, INT, LNG, INT, INT, UIN, ULG, NIN, NUI, FLT, DBL, DEC, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /*  u16 */{ OBJ, OBJ, OBJ, INT, INT, INT, INT, LNG, INT, INT, UIN, ULG, NIN, NUI, FLT, DBL, DEC, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /*  u32 */{ OBJ, OBJ, OBJ, UIN, LNG, LNG, LNG, LNG, UIN, UIN, UIN, ULG, LNG, NUI, FLT, DBL, DEC, OBJ, LUN, LLG, LLG, LLG, LLG, LUN, LUN, LUN, LUL, LLG, LNU, LFL, LDB, LDC },
                /*  u64 */{ OBJ, OBJ, OBJ, ULG, ERR, ERR, ERR, ERR, ULG, ULG, ULG, ULG, ERR, ULG, FLT, DBL, DEC, OBJ, LUL, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, LFL, LDB, LDC },
                /* nint */{ OBJ, OBJ, OBJ, NIN, NIN, NIN, NIN, LNG, NIN, NIN, LNG, ERR, NIN, ERR, FLT, DBL, DEC, OBJ, LNI, LNI, LNI, LNI, LLG, LNI, LNI, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*nuint */{ OBJ, OBJ, OBJ, NUI, ERR, ERR, ERR, ERR, NUI, NUI, NUI, ULG, ERR, NUI, FLT, DBL, DEC, OBJ, LNU, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LUL, ERR, LNU, LFL, LDB, LDC },
                /*  r32 */{ OBJ, OBJ, OBJ, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, FLT, DBL, OBJ, OBJ, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LDB, OBJ },
                /*  r64 */{ OBJ, OBJ, OBJ, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, DBL, OBJ, OBJ, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, OBJ },
                /*  dec */{ OBJ, OBJ, OBJ, DEC, DEC, DEC, DEC, DEC, DEC, DEC, DEC, DEC, DEC, DEC, OBJ, OBJ, DEC, OBJ, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, OBJ, OBJ, LDC },
                /*bool? */{ OBJ, OBJ, LBL, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, LBL, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ, OBJ },
                /* chr? */{ OBJ, OBJ, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /* i08? */{ OBJ, OBJ, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /* i16? */{ OBJ, OBJ, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /* i32? */{ OBJ, OBJ, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /* i64? */{ OBJ, OBJ, OBJ, LLG, LLG, LLG, LLG, LLG, LLG, LLG, LLG, ERR, LLG, ERR, LFL, LDB, LDC, OBJ, LLG, LLG, LLG, LLG, LLG, LLG, LLG, LLG, ERR, LLG, ERR, LFL, LDB, LDC },
                /* u08? */{ OBJ, OBJ, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /* u16? */{ OBJ, OBJ, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC, OBJ, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, LFL, LDB, LDC },
                /* u32? */{ OBJ, OBJ, OBJ, LUN, LLG, LLG, LLG, LLG, LUN, LUN, LUN, LUL, LLG, LNU, LFL, LDB, LDC, OBJ, LUN, LLG, LLG, LLG, LLG, LUN, LUN, LUN, LUL, LLG, LNU, LFL, LDB, LDC },
                /* u64? */{ OBJ, OBJ, OBJ, LUL, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, LFL, LDB, LDC, OBJ, LUL, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, LFL, LDB, LDC },
                /*nint? */{ OBJ, OBJ, OBJ, LNI, LNI, LNI, LNI, LLG, LNI, LNI, LLG, ERR, LNI, ERR, LFL, LDB, LDC, OBJ, LNI, LNI, LNI, LNI, LLG, LNI, LNI, LLG, ERR, LNI, ERR, LFL, LDB, LDC },
                /*nuint?*/{ OBJ, OBJ, OBJ, LNU, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LUL, ERR, LNU, LFL, LDB, LDC, OBJ, LNU, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LUL, ERR, LNU, LFL, LDB, LDC },
                /* r32? */{ OBJ, OBJ, OBJ, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LDB, OBJ, OBJ, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LFL, LDB, OBJ },
                /* r64? */{ OBJ, OBJ, OBJ, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, OBJ, OBJ, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, LDB, OBJ },
                /* dec? */{ OBJ, OBJ, OBJ, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, OBJ, OBJ, LDC, OBJ, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, LDC, OBJ, OBJ, LDC },
            }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 29072, 35415);
                s_logical = new BinaryOperatorKind[,]{
                //          obj  str  bool chr  i08  i16  i32  i64  u08  u16  u32  u64 nint nuint r32  r64  dec bool? chr? i08? i16? i32? i64? u08? u16? u32? u64?nint?nuint?r32? r64? dec? 
                /*  obj */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  str */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* bool */{ ERR, ERR, BOL, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LBL, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  chr */{ ERR, ERR, ERR, INT, INT, INT, INT, LNG, INT, INT, UIN, ULG, NIN, NUI, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, ERR, ERR, ERR },
                /*  i08 */{ ERR, ERR, ERR, INT, INT, INT, INT, LNG, INT, INT, LNG, ERR, NIN, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, ERR, ERR, ERR },
                /*  i16 */{ ERR, ERR, ERR, INT, INT, INT, INT, LNG, INT, INT, LNG, ERR, NIN, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, ERR, ERR, ERR },
                /*  i32 */{ ERR, ERR, ERR, INT, INT, INT, INT, LNG, INT, INT, LNG, ERR, NIN, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, ERR, ERR, ERR },
                /*  i64 */{ ERR, ERR, ERR, LNG, LNG, LNG, LNG, LNG, LNG, LNG, LNG, ERR, LNG, ERR, ERR, ERR, ERR, ERR, LLG, LLG, LLG, LLG, LLG, LLG, LLG, LLG, ERR, LLG, ERR, ERR, ERR, ERR },
                /*  u08 */{ ERR, ERR, ERR, INT, INT, INT, INT, LNG, INT, INT, UIN, ULG, NIN, NUI, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, ERR, ERR, ERR },
                /*  u16 */{ ERR, ERR, ERR, INT, INT, INT, INT, LNG, INT, INT, UIN, ULG, NIN, NUI, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, ERR, ERR, ERR },
                /*  u32 */{ ERR, ERR, ERR, UIN, LNG, LNG, LNG, LNG, UIN, UIN, UIN, ULG, LNG, NUI, ERR, ERR, ERR, ERR, LUN, LLG, LLG, LLG, LLG, LUN, LUN, LUN, LUL, LLG, LNU, ERR, ERR, ERR },
                /*  u64 */{ ERR, ERR, ERR, ULG, ERR, ERR, ERR, ERR, ULG, ULG, ULG, ULG, ERR, ULG, ERR, ERR, ERR, ERR, LUL, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, ERR, ERR, ERR },
                /* nint */{ ERR, ERR, ERR, NIN, NIN, NIN, NIN, LNG, NIN, NIN, LNG, ERR, NIN, ERR, ERR, ERR, ERR, ERR, LNI, LNI, LNI, LNI, LLG, LNI, LNI, LLG, ERR, LNI, ERR, ERR, ERR, ERR },
                /*nuint */{ ERR, ERR, ERR, NUI, ERR, ERR, ERR, ERR, NUI, NUI, NUI, ULG, ERR, NUI, ERR, ERR, ERR, ERR, LNU, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LUL, ERR, LNU, ERR, ERR, ERR },
                /*  r32 */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  r64 */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*  dec */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /*bool? */{ ERR, ERR, LBL, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, LBL, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* chr? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, ERR, ERR, ERR },
                /* i08? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, ERR, ERR, ERR },
                /* i16? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, ERR, ERR, ERR },
                /* i32? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LLG, ERR, LNI, ERR, ERR, ERR, ERR },
                /* i64? */{ ERR, ERR, ERR, LLG, LLG, LLG, LLG, LLG, LLG, LLG, LLG, ERR, LLG, ERR, ERR, ERR, ERR, ERR, LLG, LLG, LLG, LLG, LLG, LLG, LLG, LLG, ERR, LLG, ERR, ERR, ERR, ERR },
                /* u08? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, ERR, ERR, ERR },
                /* u16? */{ ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, ERR, ERR, ERR, ERR, LIN, LIN, LIN, LIN, LLG, LIN, LIN, LUN, LUL, LNI, LNU, ERR, ERR, ERR },
                /* u32? */{ ERR, ERR, ERR, LUN, LLG, LLG, LLG, LLG, LUN, LUN, LUN, LUL, LLG, LNU, ERR, ERR, ERR, ERR, LUN, LLG, LLG, LLG, LLG, LUN, LUN, LUN, LUL, LLG, LNU, ERR, ERR, ERR },
                /* u64? */{ ERR, ERR, ERR, LUL, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, ERR, ERR, ERR, ERR, LUL, ERR, ERR, ERR, ERR, LUL, LUL, LUL, LUL, ERR, LUL, ERR, ERR, ERR },
                /*nint? */{ ERR, ERR, ERR, LNI, LNI, LNI, LNI, LLG, LNI, LNI, LLG, ERR, LNI, ERR, ERR, ERR, ERR, ERR, LNI, LNI, LNI, LNI, LLG, LNI, LNI, LLG, ERR, LNI, ERR, ERR, ERR, ERR },
                /*nuint?*/{ ERR, ERR, ERR, LNU, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LUL, ERR, LNU, ERR, ERR, ERR, ERR, LNU, ERR, ERR, ERR, ERR, LNU, LNU, LNU, LUL, ERR, LNU, ERR, ERR, ERR },
                /* r32? */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* r64? */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
                /* dec? */{ ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR, ERR },
            }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 35480, 36135);
                s_opkind = new BinaryOperatorKind[][,]{
                /* *  */ s_arithmetic,
                /* +  */ s_addition,
                /* -  */ s_arithmetic,
                /* /  */ s_arithmetic,
                /* %  */ s_arithmetic,
                /* >> */ s_shift,
                /* << */ s_shift,
                /* == */ s_equality,
                /* != */ s_equality,
                /* >  */ s_arithmetic,
                /* <  */ s_arithmetic,
                /* >= */ s_arithmetic,
                /* <= */ s_arithmetic,
                /* &  */ s_logical,
                /* |  */ s_logical,
                /* ^  */ s_logical,
            }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10852, 396, 37552);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10852, 396, 37552);
            }

        }

        private void BinaryOperatorEasyOut(BinaryOperatorKind kind, BoundExpression left, BoundExpression right, BinaryOperatorOverloadResolutionResult result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10852, 37564, 38918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 37740, 37765);

                var
                leftType = f_10852_37755_37764(left)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 37779, 37855) || true) && (leftType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10852, 37779, 37855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 37833, 37840);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10852, 37779, 37855);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 37871, 37898);

                var
                rightType = f_10852_37887_37897(right)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 37912, 37989) || true) && (rightType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10852, 37912, 37989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 37967, 37974);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10852, 37912, 37989);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 38005, 38110) || true) && (f_10852_38009_38054(left, right))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10852, 38005, 38110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 38088, 38095);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10852, 38005, 38110);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 38126, 38187);

                var
                easyOut = f_10852_38140_38186(kind, leftType, rightType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 38203, 38298) || true) && (easyOut == BinaryOperatorKind.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10852, 38203, 38298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 38276, 38283);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10852, 38203, 38298);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 38314, 38406);

                BinaryOperatorSignature
                signature = f_10852_38350_38405(f_10852_38350_38366(this).builtInOperators, easyOut)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 38422, 38515);

                Conversion
                leftConversion = f_10852_38450_38514(leftType, signature.LeftType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 38529, 38625);

                Conversion
                rightConversion = f_10852_38558_38624(rightType, signature.RightType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 38641, 38706);

                f_10852_38641_38705(leftConversion.Exists && (DynAbs.Tracing.TraceSender.Expression_True(10852, 38654, 38704) && leftConversion.IsImplicit));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 38720, 38787);

                f_10852_38720_38786(rightConversion.Exists && (DynAbs.Tracing.TraceSender.Expression_True(10852, 38733, 38785) && rightConversion.IsImplicit));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 38803, 38907);

                f_10852_38803_38906(
                            result.Results, BinaryOperatorAnalysisResult.Applicable(signature, leftConversion, rightConversion));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10852, 37564, 38918);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10852_37755_37764(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 37755, 37764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10852_37887_37897(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 37887, 37897);
                    return return_v;
                }


                bool
                f_10852_38009_38054(Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = PossiblyUnusualConstantOperation(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10852, 38009, 38054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10852_38140_38186(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right)
                {
                    var return_v = BinopEasyOut.OpKind(kind, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10852, 38140, 38186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10852_38350_38366(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 38350, 38366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10852_38350_38405(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = this_param.GetSignature(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10852, 38350, 38405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10852_38450_38514(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = Conversions.FastClassifyConversion(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10852, 38450, 38514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10852_38558_38624(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = Conversions.FastClassifyConversion(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10852, 38558, 38624);
                    return return_v;
                }


                int
                f_10852_38641_38705(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10852, 38641, 38705);
                    return 0;
                }


                int
                f_10852_38720_38786(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10852, 38720, 38786);
                    return 0;
                }


                int
                f_10852_38803_38906(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10852, 38803, 38906);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10852, 37564, 38918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10852, 37564, 38918);
            }
        }

        private static bool PossiblyUnusualConstantOperation(BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10852, 38930, 40799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 39052, 39079);

                f_10852_39052_39078(left != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 39093, 39134);

                f_10852_39093_39133((object?)f_10852_39115_39124(left) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 39148, 39176);

                f_10852_39148_39175(right != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 39190, 39232);

                f_10852_39190_39231((object?)f_10852_39212_39222(right) != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 39854, 40039) || true) && (f_10852_39858_39876(left) == null && (DynAbs.Tracing.TraceSender.Expression_True(10852, 39858, 39915) && f_10852_39888_39907(right) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10852, 39854, 40039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 40011, 40024);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10852, 39854, 40039);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 40151, 40329) || true) && (f_10852_40155_40176(f_10852_40155_40164(left)) != f_10852_40180_40202(f_10852_40180_40190(right)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10852, 40151, 40329);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 40302, 40314);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10852, 40151, 40329);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 40345, 40691) || true) && (f_10852_40349_40370(f_10852_40349_40358(left)) == SpecialType.System_Int32 || (DynAbs.Tracing.TraceSender.Expression_False(10852, 40349, 40470) || f_10852_40419_40440(f_10852_40419_40428(left)) == SpecialType.System_Boolean) || (DynAbs.Tracing.TraceSender.Expression_False(10852, 40349, 40541) || f_10852_40491_40512(f_10852_40491_40500(left)) == SpecialType.System_String))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10852, 40345, 40691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 40663, 40676);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10852, 40345, 40691);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10852, 40776, 40788);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10852, 38930, 40799);

                int
                f_10852_39052_39078(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10852, 39052, 39078);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10852_39115_39124(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 39115, 39124);
                    return return_v;
                }


                int
                f_10852_39093_39133(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10852, 39093, 39133);
                    return 0;
                }


                int
                f_10852_39148_39175(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10852, 39148, 39175);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10852_39212_39222(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 39212, 39222);
                    return return_v;
                }


                int
                f_10852_39190_39231(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10852, 39190, 39231);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10852_39858_39876(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 39858, 39876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10852_39888_39907(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 39888, 39907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10852_40155_40164(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 40155, 40164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10852_40155_40176(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 40155, 40176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10852_40180_40190(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 40180, 40190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10852_40180_40202(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 40180, 40202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10852_40349_40358(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 40349, 40358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10852_40349_40370(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 40349, 40370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10852_40419_40428(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 40419, 40428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10852_40419_40440(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 40419, 40440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10852_40491_40500(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 40491, 40500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10852_40491_40512(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10852, 40491, 40512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10852, 38930, 40799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10852, 38930, 40799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OverloadResolution()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10852, 331, 40806);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 129257, 129299);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10852, 331, 40806);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10852, 331, 40806);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10852, 331, 40806);
    }
}
