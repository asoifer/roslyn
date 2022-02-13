// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class OverloadResolution
    {
        internal static class UnopEasyOut
        {
            private const UnaryOperatorKind
            ERR = UnaryOperatorKind.Error
            ;

            private const UnaryOperatorKind
            BOL = UnaryOperatorKind.Bool
            ;

            private const UnaryOperatorKind
            CHR = UnaryOperatorKind.Char
            ;

            private const UnaryOperatorKind
            I08 = UnaryOperatorKind.SByte
            ;

            private const UnaryOperatorKind
            U08 = UnaryOperatorKind.Byte
            ;

            private const UnaryOperatorKind
            I16 = UnaryOperatorKind.Short
            ;

            private const UnaryOperatorKind
            U16 = UnaryOperatorKind.UShort
            ;

            private const UnaryOperatorKind
            I32 = UnaryOperatorKind.Int
            ;

            private const UnaryOperatorKind
            U32 = UnaryOperatorKind.UInt
            ;

            private const UnaryOperatorKind
            I64 = UnaryOperatorKind.Long
            ;

            private const UnaryOperatorKind
            U64 = UnaryOperatorKind.ULong
            ;

            private const UnaryOperatorKind
            NIN = UnaryOperatorKind.NInt
            ;

            private const UnaryOperatorKind
            NUI = UnaryOperatorKind.NUInt
            ;

            private const UnaryOperatorKind
            R32 = UnaryOperatorKind.Float
            ;

            private const UnaryOperatorKind
            R64 = UnaryOperatorKind.Double
            ;

            private const UnaryOperatorKind
            DEC = UnaryOperatorKind.Decimal
            ;

            private const UnaryOperatorKind
            LBOL = UnaryOperatorKind.Lifted | UnaryOperatorKind.Bool
            ;

            private const UnaryOperatorKind
            LCHR = UnaryOperatorKind.Lifted | UnaryOperatorKind.Char
            ;

            private const UnaryOperatorKind
            LI08 = UnaryOperatorKind.Lifted | UnaryOperatorKind.SByte
            ;

            private const UnaryOperatorKind
            LU08 = UnaryOperatorKind.Lifted | UnaryOperatorKind.Byte
            ;

            private const UnaryOperatorKind
            LI16 = UnaryOperatorKind.Lifted | UnaryOperatorKind.Short
            ;

            private const UnaryOperatorKind
            LU16 = UnaryOperatorKind.Lifted | UnaryOperatorKind.UShort
            ;

            private const UnaryOperatorKind
            LI32 = UnaryOperatorKind.Lifted | UnaryOperatorKind.Int
            ;

            private const UnaryOperatorKind
            LU32 = UnaryOperatorKind.Lifted | UnaryOperatorKind.UInt
            ;

            private const UnaryOperatorKind
            LI64 = UnaryOperatorKind.Lifted | UnaryOperatorKind.Long
            ;

            private const UnaryOperatorKind
            LU64 = UnaryOperatorKind.Lifted | UnaryOperatorKind.ULong
            ;

            private const UnaryOperatorKind
            LNI = UnaryOperatorKind.Lifted | UnaryOperatorKind.NInt
            ;

            private const UnaryOperatorKind
            LNU = UnaryOperatorKind.Lifted | UnaryOperatorKind.NUInt
            ;

            private const UnaryOperatorKind
            LR32 = UnaryOperatorKind.Lifted | UnaryOperatorKind.Float
            ;

            private const UnaryOperatorKind
            LR64 = UnaryOperatorKind.Lifted | UnaryOperatorKind.Double
            ;

            private const UnaryOperatorKind
            LDEC = UnaryOperatorKind.Lifted | UnaryOperatorKind.Decimal
            ;

            private static readonly UnaryOperatorKind[] s_increment;

            private static readonly UnaryOperatorKind[] s_plus;

            private static readonly UnaryOperatorKind[] s_minus;

            private static readonly UnaryOperatorKind[] s_logicalNegation;

            private static readonly UnaryOperatorKind[] s_bitwiseComplement;

            private static readonly UnaryOperatorKind[][] s_opkind;

            public static UnaryOperatorKind OpKind(UnaryOperatorKind kind, TypeSymbol operand)
            {
                int index = operand.TypeToIndex();
                if (index < 0)
                {
                    return UnaryOperatorKind.Error;
                }
                int kindIndex = kind.OperatorIndex();
                var result = (kindIndex >= s_opkind.Length) ? UnaryOperatorKind.Error : s_opkind[kindIndex][index];
                return result == UnaryOperatorKind.Error ? result : result | kind;
            }

            static UnopEasyOut()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10861, 396, 6391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 486, 515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 564, 592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 639, 667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 714, 743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 790, 818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 865, 894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 941, 971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 1018, 1045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 1092, 1120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 1167, 1195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 1242, 1271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 1318, 1346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 1393, 1422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 1469, 1498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 1545, 1575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 1622, 1653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 1700, 1756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 1803, 1859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 1906, 1963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 2010, 2066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 2113, 2170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 2217, 2275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 2322, 2377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 2424, 2480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 2527, 2583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 2630, 2687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 2734, 2789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 2836, 2892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 2939, 2996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 3043, 3101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 3148, 3207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 3268, 3643);
                s_increment = new UnaryOperatorKind[]{ ERR,  ERR,  ERR,  CHR,  I08,  I16,  I32,  I64,  U08,  U16,  U32,  U64,  NIN,  NUI,  R32,  R64,  DEC,
               /* lifted */   ERR, LCHR, LI08, LI16, LI32, LI64, LU08, LU16, LU32, LU64,  LNI,  LNU, LR32, LR64, LDEC }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 3704, 4074);
                s_plus = new UnaryOperatorKind[]{ ERR,  ERR,  ERR,  I32,  I32,  I32,  I32,  I64,  I32,  I32,  U32,  U64,  NIN,  NUI,  R32,  R64,  DEC,
               /* lifted */   ERR, LI32, LI32, LI32, LI32, LI64, LI32, LI32, LU32, LU64,  LNI,  LNU, LR32, LR64, LDEC }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 4135, 4507);
                s_minus = new UnaryOperatorKind[]{ ERR,  ERR,  ERR,  I32,  I32,  I32,  I32,  I64,  I32,  I32,  I64,  ERR,  NIN,  ERR,  R32,  R64,  DEC,
               /* lifted */   ERR, LI32, LI32, LI32, LI32, LI64, LI32, LI32, LI64,  ERR,  LNI,  ERR,  LR32, LR64, LDEC }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 4568, 4949);
                s_logicalNegation = new UnaryOperatorKind[]{ ERR,  ERR,  BOL,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,
               /* lifted */  LBOL,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR,  ERR }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 5010, 5393);
                s_bitwiseComplement = new UnaryOperatorKind[]{ ERR,  ERR,  ERR,  I32,  I32,  I32,  I32,  I64,  I32,  I32,  U32,  U64,  NIN,  NUI,  ERR,  ERR,  ERR,
               /* lifted */   ERR, LI32, LI32, LI32, LI32, LI64, LI32, LI32, LU32, LU64,  LNI,  LNU,  ERR,  ERR,  ERR }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 5456, 5820);
                s_opkind = new UnaryOperatorKind[][]{
                /* ++ */  s_increment,
                /* -- */  s_increment,
                /* ++ */  s_increment,
                /* -- */  s_increment,
                /* +  */  s_plus,
                /* -  */  s_minus,
                /* !  */  s_logicalNegation,
                /* ~  */  s_bitwiseComplement
            }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10861, 396, 6391);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10861, 396, 6391);
            }

        }

        private void UnaryOperatorEasyOut(UnaryOperatorKind kind, BoundExpression operand, UnaryOperatorOverloadResolutionResult result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10861, 6403, 7273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 6556, 6587);

                var
                operandType = f_10861_6574_6586(operand)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 6601, 6680) || true) && (operandType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10861, 6601, 6680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 6658, 6665);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10861, 6601, 6680);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 6696, 6748);

                var
                easyOut = f_10861_6710_6747(kind, operandType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 6764, 6858) || true) && (easyOut == UnaryOperatorKind.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10861, 6764, 6858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 6836, 6843);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10861, 6764, 6858);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 6874, 6965);

                UnaryOperatorSignature
                signature = f_10861_6909_6964(f_10861_6909_6925(this).builtInOperators, easyOut)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 6981, 7077);

                Conversion?
                conversion = f_10861_7006_7076(operandType, signature.OperandType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 7093, 7158);

                f_10861_7093_7157(conversion.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(10861, 7106, 7156) && conversion.Value.IsImplicit));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10861, 7174, 7262);

                f_10861_7174_7261(
                            result.Results, UnaryOperatorAnalysisResult.Applicable(signature, conversion.Value));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10861, 6403, 7273);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10861_6574_6586(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10861, 6574, 6586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10861_6710_6747(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                operand)
                {
                    var return_v = UnopEasyOut.OpKind(kind, operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10861, 6710, 6747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10861_6909_6925(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10861, 6909, 6925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                f_10861_6909_6964(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = this_param.GetSignature(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10861, 6909, 6964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10861_7006_7076(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = Conversions.FastClassifyConversion(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10861, 7006, 7076);
                    return return_v;
                }


                int
                f_10861_7093_7157(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10861, 7093, 7157);
                    return 0;
                }


                int
                f_10861_7174_7261(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10861, 7174, 7261);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10861, 6403, 7273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10861, 6403, 7273);
            }
        }
    }
}
