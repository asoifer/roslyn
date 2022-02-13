// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    public static class TypedConstantExtensions
    {
        public static string ToCSharpString(this TypedConstant constant)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10170, 650, 1704);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 739, 821) || true) && (constant.IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 739, 821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 792, 806);

                    return "null";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 739, 821);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 837, 1016) || true) && (constant.Kind == TypedConstantKind.Array)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 837, 1016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 915, 1001);

                    return "{" + f_10170_928_994(", ", constant.Values.Select(v => v.ToCSharpString())) + "}";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 837, 1016);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 1032, 1299) || true) && (constant.Kind == TypedConstantKind.Type || (DynAbs.Tracing.TraceSender.Expression_False(10170, 1036, 1142) || f_10170_1079_1113(constant.TypeInternal!) == SpecialType.System_Object))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 1032, 1299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 1176, 1215);

                    f_10170_1176_1214(constant.Value is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 1233, 1284);

                    return "typeof(" + f_10170_1252_1277(constant.Value) + ")";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 1032, 1299);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 1315, 1505) || true) && (constant.Kind == TypedConstantKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 1315, 1505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 1453, 1490);

                    return f_10170_1460_1489(constant);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 1315, 1505);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 1521, 1568);

                f_10170_1521_1567(constant.ValueInternal is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 1582, 1693);

                return f_10170_1589_1692(constant.ValueInternal, quoteStrings: true, useHexadecimalNumbers: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10170, 650, 1704);

                string
                f_10170_928_994(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 928, 994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10170_1079_1113(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 1079, 1113);
                    return return_v;
                }


                int
                f_10170_1176_1214(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 1176, 1214);
                    return 0;
                }


                string?
                f_10170_1252_1277(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 1252, 1277);
                    return return_v;
                }


                string
                f_10170_1460_1489(Microsoft.CodeAnalysis.TypedConstant
                constant)
                {
                    var return_v = DisplayEnumConstant(constant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 1460, 1489);
                    return return_v;
                }


                int
                f_10170_1521_1567(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 1521, 1567);
                    return 0;
                }


                string
                f_10170_1589_1692(object
                obj, bool
                quoteStrings, bool
                useHexadecimalNumbers)
                {
                    var return_v = SymbolDisplay.FormatPrimitive(obj, quoteStrings: quoteStrings, useHexadecimalNumbers: useHexadecimalNumbers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 1589, 1692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10170, 650, 1704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10170, 650, 1704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string DisplayEnumConstant(TypedConstant constant)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10170, 1762, 2689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 1852, 1906);

                f_10170_1852_1905(constant.Kind == TypedConstantKind.Enum);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 1985, 2074);

                SpecialType
                splType = f_10170_2007_2073(((INamedTypeSymbol)constant.Type!).EnumUnderlyingType!)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 2088, 2135);

                f_10170_2088_2134(constant.ValueInternal is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 2149, 2233);

                ConstantValue
                valueConstant = f_10170_2179_2232(constant.ValueInternal, splType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 2249, 2342);

                string
                typeName = f_10170_2267_2341(constant.Type, SymbolDisplayFormat.QualifiedNameOnlyFormat)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 2356, 2678) || true) && (f_10170_2360_2384(valueConstant))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 2356, 2678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 2418, 2509);

                    return f_10170_2425_2508(constant, splType, f_10170_2472_2497(valueConstant), typeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 2356, 2678);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 2356, 2678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 2575, 2663);

                    return f_10170_2582_2662(constant, splType, f_10170_2627_2651(valueConstant), typeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 2356, 2678);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10170, 1762, 2689);

                int
                f_10170_1852_1905(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 1852, 1905);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10170_2007_2073(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 2007, 2073);
                    return return_v;
                }


                int
                f_10170_2088_2134(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 2088, 2134);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10170_2179_2232(object
                value, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = ConstantValue.Create(value, st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 2179, 2232);
                    return return_v;
                }


                string
                f_10170_2267_2341(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 2267, 2341);
                    return return_v;
                }


                bool
                f_10170_2360_2384(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsUnsigned;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 2360, 2384);
                    return return_v;
                }


                ulong
                f_10170_2472_2497(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 2472, 2497);
                    return return_v;
                }


                string
                f_10170_2425_2508(Microsoft.CodeAnalysis.TypedConstant
                constant, Microsoft.CodeAnalysis.SpecialType
                specialType, ulong
                constantToDecode, string
                typeName)
                {
                    var return_v = DisplayUnsignedEnumConstant(constant, specialType, constantToDecode, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 2425, 2508);
                    return return_v;
                }


                long
                f_10170_2627_2651(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 2627, 2651);
                    return return_v;
                }


                string
                f_10170_2582_2662(Microsoft.CodeAnalysis.TypedConstant
                constant, Microsoft.CodeAnalysis.SpecialType
                specialType, long
                constantToDecode, string
                typeName)
                {
                    var return_v = DisplaySignedEnumConstant(constant, specialType, constantToDecode, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 2582, 2662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10170, 1762, 2689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10170, 1762, 2689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string DisplayUnsignedEnumConstant(TypedConstant constant, SpecialType specialType, ulong constantToDecode, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10170, 2701, 5986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 2865, 2919);

                f_10170_2865_2918(constant.Kind == TypedConstantKind.Enum);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 3210, 3229);

                ulong
                curValue = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 3298, 3340);

                PooledStringBuilder?
                pooledBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 3354, 3395);

                StringBuilder?
                valueStringBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 3485, 3527);

                var
                members = f_10170_3499_3526(constant.Type!)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 3541, 5323);
                    foreach (var member in f_10170_3564_3571_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 3541, 5323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 3605, 3640);

                        var
                        field = member as IFieldSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 3660, 5308) || true) && (field is object && (DynAbs.Tracing.TraceSender.Expression_True(10170, 3664, 3705) && f_10170_3683_3705(field)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 3660, 5308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 3747, 3833);

                            ConstantValue
                            memberConstant = f_10170_3778_3832(f_10170_3799_3818(field), specialType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 3855, 3902);

                            ulong
                            memberValue = f_10170_3875_3901(memberConstant)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 3990, 4292) || true) && (memberValue == constantToDecode)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 3990, 4292);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 4075, 4206) || true) && (pooledBuilder != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 4075, 4206);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 4158, 4179);

                                    f_10170_4158_4178(pooledBuilder);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 4075, 4206);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 4234, 4269);

                                return typeName + "." + f_10170_4258_4268(field);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 3990, 4292);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 4480, 5289) || true) && ((memberValue & constantToDecode) == memberValue)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 4480, 5289);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 4634, 4668);

                                curValue = curValue | memberValue;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 4696, 5081) || true) && (valueStringBuilder == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 4696, 5081);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 4784, 4834);

                                    pooledBuilder = f_10170_4800_4833();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 4864, 4907);

                                    valueStringBuilder = pooledBuilder.Builder;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 4696, 5081);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 4696, 5081);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 5021, 5054);

                                    f_10170_5021_5053(valueStringBuilder, " | ");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 4696, 5081);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 5109, 5145);

                                f_10170_5109_5144(
                                                        valueStringBuilder, typeName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 5171, 5202);

                                f_10170_5171_5201(valueStringBuilder, ".");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 5228, 5266);

                                f_10170_5228_5265(valueStringBuilder, f_10170_5254_5264(field));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 4480, 5289);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 3660, 5308);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 3541, 5323);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10170, 1, 1783);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10170, 1, 1783);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 5339, 5694) || true) && (pooledBuilder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 5339, 5694);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 5398, 5583) || true) && (curValue == constantToDecode)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 5398, 5583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 5525, 5564);

                        return f_10170_5532_5563(pooledBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 5398, 5583);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 5658, 5679);

                    f_10170_5658_5678(
                                    // Unable to decode the enum constant
                                    pooledBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 5339, 5694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 5794, 5841);

                f_10170_5794_5840(constant.ValueInternal is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 5855, 5902);

                var
                result = f_10170_5868_5901(constant.ValueInternal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 5916, 5947);

                f_10170_5916_5946(result is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 5961, 5975);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10170, 2701, 5986);

                int
                f_10170_2865_2918(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 2865, 2918);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10170_3499_3526(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 3499, 3526);
                    return return_v;
                }


                bool
                f_10170_3683_3705(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.HasConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 3683, 3705);
                    return return_v;
                }


                object
                f_10170_3799_3818(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 3799, 3818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10170_3778_3832(object
                value, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = ConstantValue.Create(value, st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 3778, 3832);
                    return return_v;
                }


                ulong
                f_10170_3875_3901(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 3875, 3901);
                    return return_v;
                }


                int
                f_10170_4158_4178(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 4158, 4178);
                    return 0;
                }


                string
                f_10170_4258_4268(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 4258, 4268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10170_4800_4833()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 4800, 4833);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10170_5021_5053(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 5021, 5053);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10170_5109_5144(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 5109, 5144);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10170_5171_5201(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 5171, 5201);
                    return return_v;
                }


                string
                f_10170_5254_5264(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 5254, 5264);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10170_5228_5265(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 5228, 5265);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10170_3564_3571_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 3564, 3571);
                    return return_v;
                }


                string
                f_10170_5532_5563(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 5532, 5563);
                    return return_v;
                }


                int
                f_10170_5658_5678(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 5658, 5678);
                    return 0;
                }


                int
                f_10170_5794_5840(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 5794, 5840);
                    return 0;
                }


                string?
                f_10170_5868_5901(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 5868, 5901);
                    return return_v;
                }


                int
                f_10170_5916_5946(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 5916, 5946);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10170, 2701, 5986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10170, 2701, 5986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string DisplaySignedEnumConstant(TypedConstant constant, SpecialType specialType, long constantToDecode, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10170, 5998, 9275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 6159, 6213);

                f_10170_6159_6212(constant.Kind == TypedConstantKind.Enum);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 6504, 6522);

                long
                curValue = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 6591, 6633);

                PooledStringBuilder?
                pooledBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 6647, 6688);

                StringBuilder?
                valueStringBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 6778, 6820);

                var
                members = f_10170_6792_6819(constant.Type!)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 6834, 8612);
                    foreach (var member in f_10170_6857_6864_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 6834, 8612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 6898, 6933);

                        var
                        field = member as IFieldSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 6951, 8597) || true) && (field is object && (DynAbs.Tracing.TraceSender.Expression_True(10170, 6955, 6996) && f_10170_6974_6996(field)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 6951, 8597);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 7038, 7124);

                            ConstantValue
                            memberConstant = f_10170_7069_7123(f_10170_7090_7109(field), specialType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 7146, 7191);

                            long
                            memberValue = f_10170_7165_7190(memberConstant)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 7279, 7581) || true) && (memberValue == constantToDecode)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 7279, 7581);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 7364, 7495) || true) && (pooledBuilder != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 7364, 7495);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 7447, 7468);

                                    f_10170_7447_7467(pooledBuilder);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 7364, 7495);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 7523, 7558);

                                return typeName + "." + f_10170_7547_7557(field);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 7279, 7581);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 7769, 8578) || true) && ((memberValue & constantToDecode) == memberValue)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 7769, 8578);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 7923, 7957);

                                curValue = curValue | memberValue;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 7985, 8370) || true) && (valueStringBuilder == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 7985, 8370);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 8073, 8123);

                                    pooledBuilder = f_10170_8089_8122();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 8153, 8196);

                                    valueStringBuilder = pooledBuilder.Builder;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 7985, 8370);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 7985, 8370);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 8310, 8343);

                                    f_10170_8310_8342(valueStringBuilder, " | ");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 7985, 8370);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 8398, 8434);

                                f_10170_8398_8433(
                                                        valueStringBuilder, typeName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 8460, 8491);

                                f_10170_8460_8490(valueStringBuilder, ".");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 8517, 8555);

                                f_10170_8517_8554(valueStringBuilder, f_10170_8543_8553(field));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 7769, 8578);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 6951, 8597);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 6834, 8612);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10170, 1, 1779);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10170, 1, 1779);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 8628, 8983) || true) && (pooledBuilder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 8628, 8983);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 8687, 8872) || true) && (curValue == constantToDecode)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10170, 8687, 8872);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 8814, 8853);

                        return f_10170_8821_8852(pooledBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 8687, 8872);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 8947, 8968);

                    f_10170_8947_8967(
                                    // Unable to decode the enum constant
                                    pooledBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10170, 8628, 8983);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 9083, 9130);

                f_10170_9083_9129(constant.ValueInternal is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 9144, 9191);

                var
                result = f_10170_9157_9190(constant.ValueInternal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 9205, 9236);

                f_10170_9205_9235(result is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10170, 9250, 9264);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10170, 5998, 9275);

                int
                f_10170_6159_6212(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 6159, 6212);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10170_6792_6819(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 6792, 6819);
                    return return_v;
                }


                bool
                f_10170_6974_6996(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.HasConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 6974, 6996);
                    return return_v;
                }


                object
                f_10170_7090_7109(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 7090, 7109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10170_7069_7123(object
                value, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = ConstantValue.Create(value, st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 7069, 7123);
                    return return_v;
                }


                long
                f_10170_7165_7190(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 7165, 7190);
                    return return_v;
                }


                int
                f_10170_7447_7467(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 7447, 7467);
                    return 0;
                }


                string
                f_10170_7547_7557(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 7547, 7557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10170_8089_8122()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 8089, 8122);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10170_8310_8342(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 8310, 8342);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10170_8398_8433(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 8398, 8433);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10170_8460_8490(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 8460, 8490);
                    return return_v;
                }


                string
                f_10170_8543_8553(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10170, 8543, 8553);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10170_8517_8554(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 8517, 8554);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10170_6857_6864_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 6857, 6864);
                    return return_v;
                }


                string
                f_10170_8821_8852(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 8821, 8852);
                    return return_v;
                }


                int
                f_10170_8947_8967(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 8947, 8967);
                    return 0;
                }


                int
                f_10170_9083_9129(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 9083, 9129);
                    return 0;
                }


                string?
                f_10170_9157_9190(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 9157, 9190);
                    return return_v;
                }


                int
                f_10170_9205_9235(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10170, 9205, 9235);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10170, 5998, 9275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10170, 5998, 9275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypedConstantExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10170, 370, 9282);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10170, 370, 9282);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10170, 370, 9282);
        }

    }
}
