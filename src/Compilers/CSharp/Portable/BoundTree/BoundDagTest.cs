// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    partial class BoundDagTest
    {
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10550, 427, 462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 430, 462);
                return f_10550_430_462(this, obj as BoundDagTest); DynAbs.Tracing.TraceSender.TraceExitMethod(10550, 427, 462);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10550, 427, 462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10550, 427, 462);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10550_430_462(Microsoft.CodeAnalysis.CSharp.BoundDagTest
            this_param, object?
            other)
            {
                var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.BoundDagTest?)other);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10550, 430, 462);
                return return_v;
            }

        }

        private bool Equals(BoundDagTest? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10550, 475, 1525);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 540, 616) || true) && (other is null || (DynAbs.Tracing.TraceSender.Expression_False(10550, 544, 584) || f_10550_561_570(this) != f_10550_574_584(other)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10550, 540, 616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 603, 616);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10550, 540, 616);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 630, 678) || true) && (this == other)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10550, 630, 678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 666, 678);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10550, 630, 678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 694, 1514);

                switch (this, other)
                {

                    case (BoundDagTypeTest x, BoundDagTypeTest y):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10550, 694, 1514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 815, 878);

                        return f_10550_822_877(f_10550_822_828(x), f_10550_836_842(y), TypeCompareKind.AllIgnoreOptions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10550, 694, 1514);

                    case (BoundDagNonNullTest x, BoundDagNonNullTest y):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10550, 694, 1514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 970, 1014);

                        return f_10550_977_993(x) == f_10550_997_1013(y);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10550, 694, 1514);

                    case (BoundDagExplicitNullTest x, BoundDagExplicitNullTest y):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10550, 694, 1514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 1116, 1128);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10550, 694, 1514);

                    case (BoundDagValueTest x, BoundDagValueTest y):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10550, 694, 1514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 1216, 1247);

                        return f_10550_1223_1246(f_10550_1223_1230(x), f_10550_1238_1245(y));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10550, 694, 1514);

                    case (BoundDagRelationalTest x, BoundDagRelationalTest y):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10550, 694, 1514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 1345, 1404);

                        return f_10550_1352_1362(x) == f_10550_1366_1376(y) && (DynAbs.Tracing.TraceSender.Expression_True(10550, 1352, 1403) && f_10550_1380_1403(f_10550_1380_1387(x), f_10550_1395_1402(y)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10550, 694, 1514);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10550, 694, 1514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 1452, 1499);

                        throw f_10550_1458_1498(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10550, 694, 1514);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10550, 475, 1525);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10550_561_570(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 561, 570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10550_574_584(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 574, 584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10550_822_828(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 822, 828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10550_836_842(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 836, 842);
                    return return_v;
                }


                bool
                f_10550_822_877(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10550, 822, 877);
                    return return_v;
                }


                bool
                f_10550_977_993(Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest
                this_param)
                {
                    var return_v = this_param.IsExplicitTest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 977, 993);
                    return return_v;
                }


                bool
                f_10550_997_1013(Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest
                this_param)
                {
                    var return_v = this_param.IsExplicitTest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 997, 1013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10550_1223_1230(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 1223, 1230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10550_1238_1245(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 1238, 1245);
                    return return_v;
                }


                bool
                f_10550_1223_1246(Microsoft.CodeAnalysis.ConstantValue
                this_param, Microsoft.CodeAnalysis.ConstantValue
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10550, 1223, 1246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10550_1352_1362(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                this_param)
                {
                    var return_v = this_param.Relation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 1352, 1362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10550_1366_1376(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                this_param)
                {
                    var return_v = this_param.Relation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 1366, 1376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10550_1380_1387(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 1380, 1387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10550_1395_1402(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 1395, 1402);
                    return return_v;
                }


                bool
                f_10550_1380_1403(Microsoft.CodeAnalysis.ConstantValue
                this_param, Microsoft.CodeAnalysis.ConstantValue
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10550, 1380, 1403);
                    return return_v;
                }


                System.Exception
                f_10550_1458_1498(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10550, 1458, 1498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10550, 475, 1525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10550, 475, 1525);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10550, 1537, 1667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10550, 1595, 1656);

                return f_10550_1602_1655(f_10550_1615_1633(f_10550_1615_1619()), f_10550_1635_1654(f_10550_1635_1640()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10550, 1537, 1667);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10550_1615_1619()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 1615, 1619);
                    return return_v;
                }


                int
                f_10550_1615_1633(Microsoft.CodeAnalysis.CSharp.BoundKind
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10550, 1615, 1633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10550_1635_1640()
                {
                    var return_v = Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10550, 1635, 1640);
                    return return_v;
                }


                int
                f_10550_1635_1654(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10550, 1635, 1654);
                    return return_v;
                }


                int
                f_10550_1602_1655(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10550, 1602, 1655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10550, 1537, 1667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10550, 1537, 1667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundDagTest()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10550, 323, 1674);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10550, 323, 1674);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10550, 323, 1674);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10550, 323, 1674);
    }
}
