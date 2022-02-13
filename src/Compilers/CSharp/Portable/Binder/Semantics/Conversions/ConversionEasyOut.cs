// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class ConversionsBase
    {
        private static class ConversionEasyOut
        {
            private static readonly byte[,] s_convkind;

            static ConversionEasyOut()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10839, 990, 8287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 963, 973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 1049, 1096);

                    const byte
                    IDN = (byte)ConversionKind.Identity
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 1114, 1170);

                    const byte
                    IRF = (byte)ConversionKind.ImplicitReference
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 1188, 1244);

                    const byte
                    XRF = (byte)ConversionKind.ExplicitReference
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 1262, 1316);

                    const byte
                    XNM = (byte)ConversionKind.ExplicitNumeric
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 1334, 1385);

                    const byte
                    NOC = (byte)ConversionKind.NoConversion
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 1403, 1448);

                    const byte
                    BOX = (byte)ConversionKind.Boxing
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 1466, 1513);

                    const byte
                    UNB = (byte)ConversionKind.Unboxing
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 1531, 1585);

                    const byte
                    NUM = (byte)ConversionKind.ImplicitNumeric
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 1603, 1658);

                    const byte
                    NUL = (byte)ConversionKind.ImplicitNullable
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 1676, 1731);

                    const byte
                    XNL = (byte)ConversionKind.ExplicitNullable
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 1751, 8272);

                    s_convkind = new byte[,] {
                    // Converting Y to X:
                    //          obj  str  bool chr  i08  i16  i32  i64  u08  u16  u32  u64 nint nuint r32  r64  dec bool? chr? i08? i16? i32? i64? u08? u16? u32? u64?nint?nuint?r32? r64? dec? 
                    /*  obj */{ IDN, XRF, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB, UNB },
                    /*  str */{ IRF, IDN, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC },
                    /* bool */{ BOX, NOC, IDN, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NUL, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC },
                    /*  chr */{ BOX, NOC, NOC, IDN, XNM, XNM, NUM, NUM, XNM, NUM, NUM, NUM, NUM, NUM, NUM, NUM, NUM, NOC, NUL, XNL, XNL, NUL, NUL, XNL, NUL, NUL, NUL, NUL, NUL, NUL, NUL, NUL },
                    /*  i08 */{ BOX, NOC, NOC, XNM, IDN, NUM, NUM, NUM, XNM, XNM, XNM, XNM, NUM, XNM, NUM, NUM, NUM, NOC, XNL, NUL, NUL, NUL, NUL, XNL, XNL, XNL, XNL, NUL, XNL, NUL, NUL, NUL },
                    /*  i16 */{ BOX, NOC, NOC, XNM, XNM, IDN, NUM, NUM, XNM, XNM, XNM, XNM, NUM, XNM, NUM, NUM, NUM, NOC, XNL, XNL, NUL, NUL, NUL, XNL, XNL, XNL, XNL, NUL, XNL, NUL, NUL, NUL },
                    /*  i32 */{ BOX, NOC, NOC, XNM, XNM, XNM, IDN, NUM, XNM, XNM, XNM, XNM, NUM, XNM, NUM, NUM, NUM, NOC, XNL, XNL, XNL, NUL, NUL, XNL, XNL, XNL, XNL, NUL, XNL, NUL, NUL, NUL },
                    /*  i64 */{ BOX, NOC, NOC, XNM, XNM, XNM, XNM, IDN, XNM, XNM, XNM, XNM, XNM, XNM, NUM, NUM, NUM, NOC, XNL, XNL, XNL, XNL, NUL, XNL, XNL, XNL, XNL, XNL, XNL, NUL, NUL, NUL },
                    /*  u08 */{ BOX, NOC, NOC, XNM, XNM, NUM, NUM, NUM, IDN, NUM, NUM, NUM, NUM, NUM, NUM, NUM, NUM, NOC, XNL, XNL, NUL, NUL, NUL, NUL, NUL, NUL, NUL, NUL, NUL, NUL, NUL, NUL },
                    /*  u16 */{ BOX, NOC, NOC, XNM, XNM, XNM, NUM, NUM, XNM, IDN, NUM, NUM, NUM, NUM, NUM, NUM, NUM, NOC, XNL, XNL, XNL, NUL, NUL, XNL, NUL, NUL, NUL, NUL, NUL, NUL, NUL, NUL },
                    /*  u32 */{ BOX, NOC, NOC, XNM, XNM, XNM, XNM, NUM, XNM, XNM, IDN, NUM, XNM, NUM, NUM, NUM, NUM, NOC, XNL, XNL, XNL, XNL, NUL, XNL, XNL, NUL, NUL, XNL, NUL, NUL, NUL, NUL },
                    /*  u64 */{ BOX, NOC, NOC, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, IDN, XNM, XNM, NUM, NUM, NUM, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NUL, XNL, XNL, NUL, NUL, NUL },
                    /* nint */{ BOX, NOC, NOC, XNM, XNM, XNM, XNM, NUM, XNM, XNM, XNM, XNM, IDN, XNM, NUM, NUM, NUM, NOC, XNL, XNL, XNL, XNL, NUL, XNL, XNL, XNL, XNL, NUL, XNL, NUL, NUL, NUL },
                    /*nuint */{ BOX, NOC, NOC, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, NUM, XNM, IDN, NUM, NUM, NUM, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NUL, XNL, NUL, NUL, NUL, NUL },
                    /*  r32 */{ BOX, NOC, NOC, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, IDN, NUM, XNM, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NUL, NUL, XNL },
                    /*  r64 */{ BOX, NOC, NOC, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, IDN, XNM, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NUL, XNL },
                    /*  dec */{ BOX, NOC, NOC, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, XNM, IDN, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NUL },
                    /*bool? */{ BOX, NOC, XNL, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, IDN, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC, NOC },
                    /* chr? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, IDN, XNL, XNL, NUL, NUL, XNL, NUL, NUL, NUL, NUL, NUL, NUL, NUL, NUL },
                    /* i08? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, IDN, NUL, NUL, NUL, XNL, XNL, XNL, XNL, NUL, XNL, NUL, NUL, NUL },
                    /* i16? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, XNL, IDN, NUL, NUL, XNL, XNL, XNL, XNL, NUL, XNL, NUL, NUL, NUL },
                    /* i32? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, XNL, XNL, IDN, NUL, XNL, XNL, XNL, XNL, NUL, XNL, NUL, NUL, NUL },
                    /* i64? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, XNL, XNL, XNL, IDN, XNL, XNL, XNL, XNL, XNL, XNL, NUL, NUL, NUL },
                    /* u08? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, XNL, NUL, NUL, NUL, IDN, NUL, NUL, NUL, NUL, NUL, NUL, NUL, NUL },
                    /* u16? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, XNL, XNL, NUL, NUL, XNL, IDN, NUL, NUL, NUL, NUL, NUL, NUL, NUL },
                    /* u32? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, XNL, XNL, XNL, NUL, XNL, XNL, IDN, NUL, XNL, NUL, NUL, NUL, NUL },
                    /* u64? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, IDN, XNL, XNL, NUL, NUL, NUL },
                    /*nint? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, XNL, XNL, XNL, NUL, XNL, XNL, XNL, XNL, IDN, XNL, NUL, NUL, NUL },
                    /*nuint?*/{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NUL, XNL, IDN, NUL, NUL, NUL },
                    /* r32? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, IDN, NUL, XNL },
                    /* r64? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, IDN, XNL },
                    /* dec? */{ BOX, NOC, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, NOC, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, XNL, IDN }
               };
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10839, 990, 8287);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10839, 990, 8287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10839, 990, 8287);
                }
            }

            public static ConversionKind ClassifyConversion(TypeSymbol source, TypeSymbol target)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10839, 8303, 8876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 8421, 8460);

                    int
                    sourceIndex = f_10839_8439_8459(source)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 8478, 8593) || true) && (sourceIndex < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10839, 8478, 8593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 8539, 8574);

                        return ConversionKind.NoConversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10839, 8478, 8593);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 8611, 8650);

                    int
                    targetIndex = f_10839_8629_8649(target)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 8668, 8783) || true) && (targetIndex < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10839, 8668, 8783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 8729, 8764);

                        return ConversionKind.NoConversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10839, 8668, 8783);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10839, 8801, 8861);

                    return (ConversionKind)s_convkind[sourceIndex, targetIndex];
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10839, 8303, 8876);

                    int
                    f_10839_8439_8459(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.TypeToIndex();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10839, 8439, 8459);
                        return return_v;
                    }


                    int
                    f_10839_8629_8649(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.TypeToIndex();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10839, 8629, 8649);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10839, 8303, 8876);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10839, 8303, 8876);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ConversionsBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10839, 304, 8894);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 661, 687);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 82071, 82080);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 82110, 82118);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 82293, 83288);
            s_implicitNumericConversions = new bool[,]{
            // to     sb  b  s  us i ui  l ul  c  f  d  m
            // from
            /* sb */
         { F, F, T, F, T, F, T, F, F, T, T, T },
            /*  b */
         { F, F, T, T, T, T, T, T, F, T, T, T },
            /*  s */
         { F, F, F, F, T, F, T, F, F, T, T, T },
            /* us */
         { F, F, F, F, T, T, T, T, F, T, T, T },
            /*  i */
         { F, F, F, F, F, F, T, F, F, T, T, T },
            /* ui */
         { F, F, F, F, F, F, T, T, F, T, T, T },
            /*  l */
         { F, F, F, F, F, F, F, F, F, T, T, T },
            /* ul */
         { F, F, F, F, F, F, F, F, F, T, T, T },
            /*  c */
         { F, F, F, T, T, T, T, T, F, T, T, T },
            /*  f */
         { F, F, F, F, F, F, F, F, F, F, T, F },
            /*  d */
         { F, F, F, F, F, F, F, F, F, F, F, F },
            /*  m */
         { F, F, F, F, F, F, F, F, F, F, F, F }
        }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 83333, 84328);
            s_explicitNumericConversions = new bool[,]{
            // to     sb  b  s us  i ui  l ul  c  f  d  m
            // from
            /* sb */
         { F, T, F, T, F, T, F, T, T, F, F, F },
            /*  b */
         { T, F, F, F, F, F, F, F, T, F, F, F },
            /*  s */
         { T, T, F, T, F, T, F, T, T, F, F, F },
            /* us */
         { T, T, T, F, F, F, F, F, T, F, F, F },
            /*  i */
         { T, T, T, T, F, T, F, T, T, F, F, F },
            /* ui */
         { T, T, T, T, T, F, F, F, T, F, F, F },
            /*  l */
         { T, T, T, T, T, T, F, T, T, F, F, F },
            /* ul */
         { T, T, T, T, T, T, T, F, T, F, F, F },
            /*  c */
         { T, T, T, F, F, F, F, F, F, F, F, F },
            /*  f */
         { T, T, T, T, T, T, T, T, T, F, F, T },
            /*  d */
         { T, T, T, T, T, T, T, T, T, T, F, T },
            /*  m */
         { T, T, T, T, T, T, T, T, T, T, T, F }
        }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10839, 304, 8894);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10839, 304, 8894);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10839, 304, 8894);
    }
}
