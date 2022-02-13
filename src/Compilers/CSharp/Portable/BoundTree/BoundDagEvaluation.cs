// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    partial class BoundDagEvaluation
    {
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10547, 433, 489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10547, 436, 489);
                return obj is BoundDagEvaluation other && (DynAbs.Tracing.TraceSender.Expression_True(10547, 436, 489) && f_10547_471_489(this, other)); DynAbs.Tracing.TraceSender.TraceExitMethod(10547, 433, 489);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10547, 433, 489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10547, 433, 489);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10547_471_489(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
            this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
            other)
            {
                var return_v = this_param.Equals(other);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10547, 471, 489);
                return return_v;
            }

        }

        public virtual bool Equals(BoundDagEvaluation other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10547, 500, 791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10547, 577, 780);

                return this == other || (DynAbs.Tracing.TraceSender.Expression_False(10547, 584, 779) || f_10547_618_627(this) == f_10547_631_641(other) && (DynAbs.Tracing.TraceSender.Expression_True(10547, 618, 692) && f_10547_662_692(f_10547_662_672(this), f_10547_680_691(other))) && (DynAbs.Tracing.TraceSender.Expression_True(10547, 618, 779) && f_10547_713_779(f_10547_713_724(this), f_10547_732_744(other), TypeCompareKind.AllIgnoreOptions)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10547, 500, 791);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10547_618_627(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 618, 627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10547_631_641(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 631, 641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10547_662_672(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 662, 672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10547_680_691(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 680, 691);
                    return return_v;
                }


                bool
                f_10547_662_692(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10547, 662, 692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10547_713_724(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 713, 724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10547_732_744(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 732, 744);
                    return return_v;
                }


                bool
                f_10547_713_779(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10547, 713, 779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10547, 500, 791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10547, 500, 791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol Symbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10547, 847, 1437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10547, 883, 1422);

                    switch (this)
                    {

                        case BoundDagFieldEvaluation e:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10547, 883, 1422);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10547, 969, 1019);

                            return f_10547_976_1007(f_10547_976_983(e)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(10547, 976, 1018) ?? f_10547_1011_1018(e));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10547, 883, 1422);

                        case BoundDagPropertyEvaluation e:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10547, 883, 1422);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10547, 1076, 1094);

                            return f_10547_1083_1093(e);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10547, 883, 1422);

                        case BoundDagTypeEvaluation e:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10547, 883, 1422);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10547, 1147, 1161);

                            return f_10547_1154_1160(e);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10547, 883, 1422);

                        case BoundDagDeconstructEvaluation e:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10547, 883, 1422);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10547, 1221, 1248);

                            return f_10547_1228_1247(e);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10547, 883, 1422);

                        case BoundDagIndexEvaluation e:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10547, 883, 1422);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10547, 1302, 1320);

                            return f_10547_1309_1319(e);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10547, 883, 1422);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10547, 883, 1422);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10547, 1351, 1403);

                            throw f_10547_1357_1402(f_10547_1392_1401(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10547, 883, 1422);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10547, 847, 1437);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10547_976_983(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                    this_param)
                    {
                        var return_v = this_param.Field;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 976, 983);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10547_976_1007(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.CorrespondingTupleField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 976, 1007);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10547_1011_1018(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                    this_param)
                    {
                        var return_v = this_param.Field;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 1011, 1018);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10547_1083_1093(Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                    this_param)
                    {
                        var return_v = this_param.Property;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 1083, 1093);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10547_1154_1160(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 1154, 1160);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10547_1228_1247(Microsoft.CodeAnalysis.CSharp.BoundDagDeconstructEvaluation
                    this_param)
                    {
                        var return_v = this_param.DeconstructMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 1228, 1247);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10547_1309_1319(Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
                    this_param)
                    {
                        var return_v = this_param.Property;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 1309, 1319);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10547_1392_1401(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 1392, 1401);
                        return return_v;
                    }


                    System.Exception
                    f_10547_1357_1402(Microsoft.CodeAnalysis.CSharp.BoundKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10547, 1357, 1402);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10547, 801, 1448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10547, 801, 1448);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10547, 1460, 1603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10547, 1518, 1592);

                return f_10547_1525_1591(f_10547_1538_1557(f_10547_1538_1543()), f_10547_1559_1585_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10547_1559_1570(this), 10547, 1559, 1585).GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10547, 1559, 1590) ?? 0));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10547, 1460, 1603);

                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10547_1538_1543()
                {
                    var return_v = Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 1538, 1543);
                    return return_v;
                }


                int
                f_10547_1538_1557(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10547, 1538, 1557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10547_1559_1570(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 1559, 1570);
                    return return_v;
                }


                int?
                f_10547_1559_1585_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10547, 1559, 1585);
                    return return_v;
                }


                int
                f_10547_1525_1591(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10547, 1525, 1591);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10547, 1460, 1603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10547, 1460, 1603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundDagEvaluation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10547, 323, 1610);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10547, 323, 1610);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10547, 323, 1610);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10547, 323, 1610);
    }
    partial class BoundDagIndexEvaluation
    {
        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10547, 1706, 1740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10547, 1709, 1740);
                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 10547, 1709, 1727) ^ f_10547_1730_1740(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10547, 1706, 1740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10547, 1706, 1740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10547, 1706, 1740);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_10547_1730_1740(Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
            this_param)
            {
                var return_v = this_param.Index;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 1730, 1740);
                return return_v;
            }

        }

        public override bool Equals(BoundDagEvaluation obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10547, 1751, 2050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10547, 1827, 2039);

                return this == obj || (DynAbs.Tracing.TraceSender.Expression_False(10547, 1834, 2038) || DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(obj), 10547, 1866, 1882) && (DynAbs.Tracing.TraceSender.Expression_True(10547, 1866, 2038) && f_10547_1988_1998(this) == f_10547_2002_2038(((BoundDagIndexEvaluation)obj))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10547, 1751, 2050);

                int
                f_10547_1988_1998(Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 1988, 1998);
                    return return_v;
                }


                int
                f_10547_2002_2038(Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10547, 2002, 2038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10547, 1751, 2050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10547, 1751, 2050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundDagIndexEvaluation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10547, 1618, 2057);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10547, 1618, 2057);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10547, 1618, 2057);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10547, 1618, 2057);
    }
}
