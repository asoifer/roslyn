// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Operations
{
    internal class Expression
    {
        public static ConstantValue SynthesizeNumeric(ITypeSymbol type, int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(151, 302, 2163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 401, 1934);

                switch (f_151_409_425(type))
                {

                    case SpecialType.System_Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 511, 546);

                        return f_151_518_545(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);

                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 616, 657);

                        return f_151_623_656(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);

                    case SpecialType.System_UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 728, 769);

                        return f_151_735_768(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);

                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 840, 882);

                        return f_151_847_881(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);

                    case SpecialType.System_UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 953, 996);

                        return f_151_960_995(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);

                    case SpecialType.System_Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 1066, 1108);

                        return f_151_1073_1107(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);

                    case SpecialType.System_SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 1178, 1220);

                        return f_151_1185_1219(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);

                    case SpecialType.System_Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 1289, 1330);

                        return f_151_1296_1329(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);

                    case SpecialType.System_Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 1399, 1440);

                        return f_151_1406_1439(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);

                    case SpecialType.System_Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 1512, 1552);

                        return f_151_1519_1551(value != 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);

                    case SpecialType.System_Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 1623, 1665);

                        return f_151_1630_1664(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);

                    case SpecialType.System_Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 1736, 1779);

                        return f_151_1743_1778(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);

                    case SpecialType.System_Object:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 401, 1934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 1850, 1919);

                        return f_151_1857_1918(1, ConstantValueTypeDiscriminator.Int32);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(151, 401, 1934);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 1950, 2111) || true) && (f_151_1954_1967(type) == TypeKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(151, 1950, 2111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 2018, 2096);

                    return f_151_2025_2095(((INamedTypeSymbol)type).EnumUnderlyingType!, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(151, 1950, 2111);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(151, 2127, 2152);

                return f_151_2134_2151();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(151, 302, 2163);

                Microsoft.CodeAnalysis.SpecialType
                f_151_409_425(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(151, 409, 425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_518_545(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 518, 545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_623_656(int
                value)
                {
                    var return_v = ConstantValue.Create((long)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 623, 656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_735_768(int
                value)
                {
                    var return_v = ConstantValue.Create((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 735, 768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_847_881(int
                value)
                {
                    var return_v = ConstantValue.Create((ulong)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 847, 881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_960_995(int
                value)
                {
                    var return_v = ConstantValue.Create((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 960, 995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_1073_1107(int
                value)
                {
                    var return_v = ConstantValue.Create((short)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 1073, 1107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_1185_1219(int
                value)
                {
                    var return_v = ConstantValue.Create((sbyte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 1185, 1219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_1296_1329(int
                value)
                {
                    var return_v = ConstantValue.Create((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 1296, 1329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_1406_1439(int
                value)
                {
                    var return_v = ConstantValue.Create((char)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 1406, 1439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_1519_1551(bool
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 1519, 1551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_1630_1664(int
                value)
                {
                    var return_v = ConstantValue.Create((float)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 1630, 1664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_1743_1778(int
                value)
                {
                    var return_v = ConstantValue.Create((double)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 1743, 1778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_1857_1918(int
                value, Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                discriminator)
                {
                    var return_v = ConstantValue.Create((object)value, discriminator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 1857, 1918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_151_1954_1967(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(151, 1954, 1967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_2025_2095(Microsoft.CodeAnalysis.INamedTypeSymbol
                type, int
                value)
                {
                    var return_v = SynthesizeNumeric((Microsoft.CodeAnalysis.ITypeSymbol)type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(151, 2025, 2095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_151_2134_2151()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(151, 2134, 2151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(151, 302, 2163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(151, 302, 2163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Expression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(151, 260, 2170);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(151, 260, 2170);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(151, 260, 2170);
        }


        static Expression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(151, 260, 2170);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(151, 260, 2170);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(151, 260, 2170);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(151, 260, 2170);
    }
}
