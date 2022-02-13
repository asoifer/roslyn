// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class TypeUnification
    {
        public static bool CanUnify(TypeSymbol t1, TypeSymbol t2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10175, 614, 1559);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 696, 830) || true) && (f_10175_700_769(t1, t2, TypeCompareKind.CLRSignatureCompareOptions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 696, 830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 803, 815);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 696, 830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 846, 882);

                MutableTypeMap?
                substitution = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 896, 951);

                bool
                result = f_10175_910_950(t1, t2, ref substitution)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 976, 1512) || true) && (result && (DynAbs.Tracing.TraceSender.Expression_True(10175, 980, 1032) && ((object)t1 != null && (DynAbs.Tracing.TraceSender.Expression_True(10175, 991, 1031) && (object)t2 != null))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 976, 1512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 1066, 1159);

                    var
                    substituted1 = f_10175_1085_1158(substitution, TypeWithAnnotations.Create(t1))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 1177, 1270);

                    var
                    substituted2 = f_10175_1196_1269(substitution, TypeWithAnnotations.Create(t2))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 1290, 1392);

                    f_10175_1290_1391(f_10175_1303_1390(substituted1.Type, substituted2.Type, TypeCompareKind.CLRSignatureCompareOptions));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 1410, 1497);

                    f_10175_1410_1496(substituted1.CustomModifiers.SequenceEqual(substituted2.CustomModifiers));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 976, 1512);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 1534, 1548);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10175, 614, 1559);

                bool
                f_10175_700_769(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 700, 769);
                    return return_v;
                }


                bool
                f_10175_910_950(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, ref Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution)
                {
                    var return_v = CanUnifyHelper(t1, t2, ref substitution);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 910, 950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10175_1085_1158(Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = SubstituteAllTypeParameters((Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap?)substitution, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 1085, 1158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10175_1196_1269(Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = SubstituteAllTypeParameters((Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap?)substitution, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 1196, 1269);
                    return return_v;
                }


                bool
                f_10175_1303_1390(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 1303, 1390);
                    return return_v;
                }


                int
                f_10175_1290_1391(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 1290, 1391);
                    return 0;
                }


                int
                f_10175_1410_1496(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 1410, 1496);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10175, 614, 1559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10175, 614, 1559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeWithAnnotations SubstituteAllTypeParameters(AbstractTypeMap? substitution, TypeWithAnnotations type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10175, 1582, 2060);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 1726, 2021) || true) && (substitution != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 1726, 2021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 1784, 1813);

                    TypeWithAnnotations
                    previous
                    = default(TypeWithAnnotations);
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 1831, 2006);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 1874, 1890);

                                previous = type;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 1912, 1953);

                                type = type.SubstituteType(substitution);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 1831, 2006);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 1831, 2006) || true) && (!type.IsSameAs(previous))
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10175, 1831, 2006);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10175, 1831, 2006);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 1726, 2021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 2037, 2049);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10175, 1582, 2060);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10175, 1582, 2060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10175, 1582, 2060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CanUnifyHelper(TypeSymbol t1, TypeSymbol t2, ref MutableTypeMap? substitution)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10175, 2080, 2318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 2203, 2307);

                return f_10175_2210_2306(TypeWithAnnotations.Create(t1), TypeWithAnnotations.Create(t2), ref substitution);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10175, 2080, 2318);

                bool
                f_10175_2210_2306(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t2, ref Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution)
                {
                    var return_v = CanUnifyHelper(t1, t2, ref substitution);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 2210, 2306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10175, 2080, 2318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10175, 2080, 2318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CanUnifyHelper(TypeWithAnnotations t1, TypeWithAnnotations t2, ref MutableTypeMap? substitution)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10175, 3196, 11305);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 3337, 3439) || true) && (f_10175_3341_3352_M(!t1.HasType) || (DynAbs.Tracing.TraceSender.Expression_False(10175, 3341, 3367) || f_10175_3356_3367_M(!t2.HasType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 3337, 3439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 3401, 3424);

                    return t1.IsSameAs(t2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 3337, 3439);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 3455, 3620) || true) && (substitution != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 3455, 3620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 3513, 3550);

                    t1 = t1.SubstituteType(substitution);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 3568, 3605);

                    t2 = t2.SubstituteType(substitution);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 3455, 3620);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 3636, 3836) || true) && (f_10175_3640_3719(t1.Type, t2.Type, TypeCompareKind.CLRSignatureCompareOptions) && (DynAbs.Tracing.TraceSender.Expression_True(10175, 3640, 3775) && t1.CustomModifiers.SequenceEqual(t2.CustomModifiers)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 3636, 3836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 3809, 3821);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 3636, 3836);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 3994, 4184) || true) && (!f_10175_3999_4024(t1.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10175, 3998, 4053) && f_10175_4028_4053(t2.Type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 3994, 4184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 4087, 4116);

                    TypeWithAnnotations
                    tmp = t1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 4134, 4142);

                    t1 = t2;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 4160, 4169);

                    t2 = tmp;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 3994, 4184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 4266, 4336);

                f_10175_4266_4335(f_10175_4279_4304(t1.Type) || (DynAbs.Tracing.TraceSender.Expression_False(10175, 4279, 4334) || !f_10175_4309_4334(t2.Type)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 4352, 11294);

                switch (f_10175_4360_4372(t1.Type))
                {

                    case SymbolKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 4352, 11294);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 4481, 4666) || true) && (t2.TypeKind != t1.TypeKind || (DynAbs.Tracing.TraceSender.Expression_False(10175, 4485, 4568) || !t2.CustomModifiers.SequenceEqual(t1.CustomModifiers)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 4481, 4666);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 4626, 4639);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 4481, 4666);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 4694, 4741);

                            ArrayTypeSymbol
                            at1 = (ArrayTypeSymbol)t1.Type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 4767, 4814);

                            ArrayTypeSymbol
                            at2 = (ArrayTypeSymbol)t2.Type
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 4842, 4968) || true) && (!f_10175_4847_4870(at1, at2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 4842, 4968);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 4928, 4941);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 4842, 4968);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 4996, 5100);

                            return f_10175_5003_5099(f_10175_5018_5048(at1), f_10175_5050_5080(at2), ref substitution);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 4352, 11294);

                    case SymbolKind.PointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 4352, 11294);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 5218, 5403) || true) && (t2.TypeKind != t1.TypeKind || (DynAbs.Tracing.TraceSender.Expression_False(10175, 5222, 5305) || !t2.CustomModifiers.SequenceEqual(t1.CustomModifiers)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 5218, 5403);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 5363, 5376);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 5218, 5403);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 5431, 5482);

                            PointerTypeSymbol
                            pt1 = (PointerTypeSymbol)t1.Type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 5508, 5559);

                            PointerTypeSymbol
                            pt2 = (PointerTypeSymbol)t2.Type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 5587, 5695);

                            return f_10175_5594_5694(f_10175_5609_5641(pt1), f_10175_5643_5675(pt2), ref substitution);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 4352, 11294);

                    case SymbolKind.NamedType:
                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 4352, 11294);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 5855, 6040) || true) && (t2.TypeKind != t1.TypeKind || (DynAbs.Tracing.TraceSender.Expression_False(10175, 5859, 5942) || !t2.CustomModifiers.SequenceEqual(t1.CustomModifiers)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 5855, 6040);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 6000, 6013);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 5855, 6040);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 6068, 6115);

                            NamedTypeSymbol
                            nt1 = (NamedTypeSymbol)t1.Type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 6141, 6188);

                            NamedTypeSymbol
                            nt2 = (NamedTypeSymbol)t2.Type
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 6214, 6695) || true) && (f_10175_6218_6236_M(!nt1.IsGenericType) || (DynAbs.Tracing.TraceSender.Expression_False(10175, 6218, 6258) || f_10175_6240_6258_M(!nt2.IsGenericType)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 6214, 6695);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 6550, 6625);

                                f_10175_6550_6624(!f_10175_6564_6623(nt1, nt2, TypeCompareKind.CLRSignatureCompareOptions));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 6655, 6668);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 6214, 6695);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 6723, 6745);

                            int
                            arity = f_10175_6735_6744(nt1)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 6773, 6999) || true) && (f_10175_6777_6786(nt2) != arity || (DynAbs.Tracing.TraceSender.Expression_False(10175, 6777, 6901) || !f_10175_6800_6901(f_10175_6818_6840(nt2), f_10175_6842_6864(nt1), TypeCompareKind.ConsiderEverything)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 6773, 6999);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 6959, 6972);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 6773, 6999);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 7027, 7099);

                            var
                            nt1Arguments = f_10175_7046_7098(nt1)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 7125, 7197);

                            var
                            nt2Arguments = f_10175_7144_7196(nt2)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 7234, 7239);

                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 7225, 7619) || true) && (i < arity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 7252, 7255)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 7225, 7619))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 7225, 7619);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 7313, 7592) || true) && (!f_10175_7318_7482(nt1Arguments[i], nt2Arguments[i], ref substitution))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 7313, 7592);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 7548, 7561);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 7313, 7592);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10175, 1, 395);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10175, 1, 395);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 7934, 8052);

                            return (object)f_10175_7949_7967(nt1) == null || (DynAbs.Tracing.TraceSender.Expression_False(10175, 7941, 8051) || f_10175_7979_8051(f_10175_7994_8012(nt1), f_10175_8014_8032(nt2), ref substitution));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 4352, 11294);

                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 4352, 11294);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 8242, 8399) || true) && (f_10175_8246_8282(t2.Type) || (DynAbs.Tracing.TraceSender.Expression_False(10175, 8246, 8301) || t2.IsVoidType()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 8242, 8399);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 8359, 8372);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 8242, 8399);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 8427, 8482);

                            TypeParameterSymbol
                            tp1 = (TypeParameterSymbol)t1.Type
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 8752, 8876) || true) && (f_10175_8756_8778(t2.Type, tp1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 8752, 8876);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 8836, 8849);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 8752, 8876);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 8904, 9113) || true) && (t1.CustomModifiers.IsDefaultOrEmpty)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 8904, 9113);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 9001, 9044);

                                f_10175_9001_9043(ref substitution, tp1, t2);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 9074, 9086);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 8904, 9113);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 9141, 9400) || true) && (t1.CustomModifiers.SequenceEqual(t2.CustomModifiers))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 9141, 9400);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 9255, 9331);

                                f_10175_9255_9330(ref substitution, tp1, TypeWithAnnotations.Create(t2.Type));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 9361, 9373);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 9141, 9400);
                            }

                            // LAFHIS f_10175_9551_9601 REF
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 9428, 10017) || true) && (t1.CustomModifiers.Length < t2.CustomModifiers.Length && (DynAbs.Tracing.TraceSender.Expression_True(10175, 9432, 9602) && t1.CustomModifiers.SequenceEqual(f_10175_9551_9601(t2.CustomModifiers, t1.CustomModifiers.Length))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 9428, 10017);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 9660, 9948);

                                f_10175_9660_9947(ref substitution, tp1, TypeWithAnnotations.Create(t2.Type, customModifiers: f_10175_9822_9945(t2.CustomModifiers, t1.CustomModifiers.Length, t2.CustomModifiers.Length - t1.CustomModifiers.Length)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 9978, 9990);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 9428, 10017);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 10045, 11104) || true) && (f_10175_10049_10074(t2.Type))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 10045, 11104);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 10132, 10171);

                                var
                                tp2 = (TypeParameterSymbol)t2.Type
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 10203, 10428) || true) && (t2.CustomModifiers.IsDefaultOrEmpty)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 10203, 10428);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 10308, 10351);

                                    f_10175_10308_10350(ref substitution, tp2, t1);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 10385, 10397);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 10203, 10428);
                                }

                                // LAFHIS
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 10460, 11077) || true) && (t2.CustomModifiers.Length < t1.CustomModifiers.Length && (DynAbs.Tracing.TraceSender.Expression_True(10175, 10464, 10638) && t2.CustomModifiers.SequenceEqual(f_10175_10587_10637(t1.CustomModifiers, t2.CustomModifiers.Length))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 10460, 11077);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 10704, 11000);

                                    f_10175_10704_10999(ref substitution, tp2, TypeWithAnnotations.Create(t1.Type, customModifiers: f_10175_10874_10997(t1.CustomModifiers, t2.CustomModifiers.Length, t1.CustomModifiers.Length - t2.CustomModifiers.Length)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 11034, 11046);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 10460, 11077);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 10045, 11104);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 11132, 11145);

                            return false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 4352, 11294);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 4352, 11294);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 11243, 11256);

                            return false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 4352, 11294);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10175, 3196, 11305);

                bool
                f_10175_3341_3352_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 3341, 3352);
                    return return_v;
                }


                bool
                f_10175_3356_3367_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 3356, 3367);
                    return return_v;
                }


                bool
                f_10175_3640_3719(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 3640, 3719);
                    return return_v;
                }


                bool
                f_10175_3999_4024(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 3999, 4024);
                    return return_v;
                }


                bool
                f_10175_4028_4053(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 4028, 4053);
                    return return_v;
                }


                bool
                f_10175_4279_4304(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 4279, 4304);
                    return return_v;
                }


                bool
                f_10175_4309_4334(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 4309, 4334);
                    return return_v;
                }


                int
                f_10175_4266_4335(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 4266, 4335);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10175_4360_4372(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 4360, 4372);
                    return return_v;
                }


                bool
                f_10175_4847_4870(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                other)
                {
                    var return_v = this_param.HasSameShapeAs(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 4847, 4870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10175_5018_5048(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 5018, 5048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10175_5050_5080(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 5050, 5080);
                    return return_v;
                }


                bool
                f_10175_5003_5099(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t2, ref Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution)
                {
                    var return_v = CanUnifyHelper(t1, t2, ref substitution);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 5003, 5099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10175_5609_5641(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 5609, 5641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10175_5643_5675(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 5643, 5675);
                    return return_v;
                }


                bool
                f_10175_5594_5694(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t2, ref Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution)
                {
                    var return_v = CanUnifyHelper(t1, t2, ref substitution);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 5594, 5694);
                    return return_v;
                }


                bool
                f_10175_6218_6236_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 6218, 6236);
                    return return_v;
                }


                bool
                f_10175_6240_6258_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 6240, 6258);
                    return return_v;
                }


                bool
                f_10175_6564_6623(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 6564, 6623);
                    return return_v;
                }


                int
                f_10175_6550_6624(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 6550, 6624);
                    return 0;
                }


                int
                f_10175_6735_6744(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 6735, 6744);
                    return return_v;
                }


                int
                f_10175_6777_6786(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 6777, 6786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10175_6818_6840(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 6818, 6840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10175_6842_6864(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 6842, 6864);
                    return return_v;
                }


                bool
                f_10175_6800_6901(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 6800, 6901);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10175_7046_7098(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 7046, 7098);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10175_7144_7196(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 7144, 7196);
                    return return_v;
                }


                bool
                f_10175_7318_7482(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t2, ref Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution)
                {
                    var return_v = CanUnifyHelper(t1, t2, ref substitution);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 7318, 7482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10175_7949_7967(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 7949, 7967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10175_7994_8012(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 7994, 8012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10175_8014_8032(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 8014, 8032);
                    return return_v;
                }


                bool
                f_10175_7979_8051(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, ref Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution)
                {
                    var return_v = CanUnifyHelper((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t1, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, ref substitution);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 7979, 8051);
                    return return_v;
                }


                bool
                f_10175_8246_8282(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 8246, 8282);
                    return return_v;
                }


                bool
                f_10175_8756_8778(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParam)
                {
                    var return_v = Contains(type, typeParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 8756, 8778);
                    return return_v;
                }


                int
                f_10175_9001_9043(ref Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                tp1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t2)
                {
                    AddSubstitution(ref substitution, tp1, t2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 9001, 9043);
                    return 0;
                }


                int
                f_10175_9255_9330(ref Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                tp1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t2)
                {
                    AddSubstitution(ref substitution, tp1, t2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 9255, 9330);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CustomModifier>
                f_10175_9551_9601(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                source, int
                count)
                {
                    var return_v = source.Take<Microsoft.CodeAnalysis.CustomModifier>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 9551, 9601);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10175_9822_9945(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                items, int
                start, int
                length)
                {
                    var return_v = ImmutableArray.Create(items, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 9822, 9945);
                    return return_v;
                }


                int
                f_10175_9660_9947(ref Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                tp1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t2)
                {
                    AddSubstitution(ref substitution, tp1, t2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 9660, 9947);
                    return 0;
                }


                bool
                f_10175_10049_10074(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 10049, 10074);
                    return return_v;
                }


                int
                f_10175_10308_10350(ref Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                tp1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t2)
                {
                    AddSubstitution(ref substitution, tp1, t2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 10308, 10350);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CustomModifier>
                f_10175_10587_10637(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                source, int
                count)
                {
                    var return_v = source.Take<Microsoft.CodeAnalysis.CustomModifier>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 10587, 10637);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10175_10874_10997(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                items, int
                start, int
                length)
                {
                    var return_v = ImmutableArray.Create(items, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 10874, 10997);
                    return return_v;
                }


                int
                f_10175_10704_10999(ref Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap?
                substitution, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                tp1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                t2)
                {
                    AddSubstitution(ref substitution, tp1, t2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 10704, 10999);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10175, 3196, 11305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10175, 3196, 11305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddSubstitution(ref MutableTypeMap? substitution, TypeParameterSymbol tp1, TypeWithAnnotations t2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10175, 11317, 11871);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 11460, 11569) || true) && (substitution == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 11460, 11569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 11518, 11554);

                    substitution = f_10175_11533_11553();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 11460, 11569);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 11834, 11860);

                f_10175_11834_11859(
                            // MutableTypeMap.Add will throw if the key has already been added.  However,
                            // if t1 was already in the substitution, it would have been substituted at the
                            // start of CanUnifyHelper and we wouldn't be here.
                            substitution, tp1, t2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10175, 11317, 11871);

                Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap
                f_10175_11533_11553()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 11533, 11553);
                    return return_v;
                }


                int
                f_10175_11834_11859(Microsoft.CodeAnalysis.CSharp.Symbols.MutableTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 11834, 11859);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10175, 11317, 11871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10175, 11317, 11871);
            }
        }

        private static bool Contains(TypeSymbol type, TypeParameterSymbol typeParam)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10175, 12012, 13588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 12113, 13577);

                switch (f_10175_12121_12130(type))
                {

                    case SymbolKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 12113, 13577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 12212, 12276);

                        return f_10175_12219_12275(f_10175_12228_12263(((ArrayTypeSymbol)type)), typeParam);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 12113, 13577);

                    case SymbolKind.PointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 12113, 13577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 12344, 12412);

                        return f_10175_12351_12411(f_10175_12360_12399(((PointerTypeSymbol)type)), typeParam);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 12113, 13577);

                    case SymbolKind.NamedType:
                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 12113, 13577);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 12549, 12599);

                            NamedTypeSymbol
                            namedType = (NamedTypeSymbol)type
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 12625, 13289) || true) && ((object)namedType != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 12625, 13289);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 12715, 12859);

                                    var
                                    typeParts = (DynAbs.Tracing.TraceSender.Conditional_F1(10175, 12731, 12752) || ((f_10175_12731_12752(namedType) && DynAbs.Tracing.TraceSender.Conditional_F2(10175, 12755, 12797)) || DynAbs.Tracing.TraceSender.Conditional_F3(10175, 12800, 12858))) ? f_10175_12755_12797(namedType) : f_10175_12800_12858(namedType)
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 12889, 13195);
                                        foreach (TypeWithAnnotations typePart in f_10175_12930_12939_I(typeParts))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 12889, 13195);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 13005, 13164) || true) && (f_10175_13009_13043(typePart.Type, typeParam))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 13005, 13164);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 13117, 13129);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 13005, 13164);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 12889, 13195);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10175, 1, 307);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10175, 1, 307);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 13225, 13262);

                                    namedType = f_10175_13237_13261(namedType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 12625, 13289);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10175, 12625, 13289);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10175, 12625, 13289);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 13317, 13330);

                            return false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 12113, 13577);

                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 12113, 13577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 13423, 13501);

                        return f_10175_13430_13500(type, typeParam, TypeCompareKind.ConsiderEverything);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 12113, 13577);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10175, 12113, 13577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10175, 13549, 13562);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10175, 12113, 13577);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10175, 12012, 13588);

                Microsoft.CodeAnalysis.SymbolKind
                f_10175_12121_12130(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 12121, 12130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10175_12228_12263(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 12228, 12263);
                    return return_v;
                }


                bool
                f_10175_12219_12275(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParam)
                {
                    var return_v = Contains(type, typeParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 12219, 12275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10175_12360_12399(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 12360, 12399);
                    return return_v;
                }


                bool
                f_10175_12351_12411(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParam)
                {
                    var return_v = Contains(type, typeParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 12351, 12411);
                    return return_v;
                }


                bool
                f_10175_12731_12752(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 12731, 12752);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10175_12755_12797(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 12755, 12797);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10175_12800_12858(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 12800, 12858);
                    return return_v;
                }


                bool
                f_10175_13009_13043(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParam)
                {
                    var return_v = Contains(type, typeParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 13009, 13043);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10175_12930_12939_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 12930, 12939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10175_13237_13261(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10175, 13237, 13261);
                    return return_v;
                }


                bool
                f_10175_13430_13500(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10175, 13430, 13500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10175, 12012, 13588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10175, 12012, 13588);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeUnification()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10175, 388, 13595);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10175, 388, 13595);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10175, 388, 13595);
        }

    }
}
