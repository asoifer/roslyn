// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;
using System;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundExpression
    {
        internal BoundExpression WithSuppression(bool suppress = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 463, 918);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 550, 644) || true) && (f_10554_554_571(this) == suppress)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 550, 644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 617, 629);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 550, 644);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 725, 770);

                f_10554_725_769(suppress || (DynAbs.Tracing.TraceSender.Expression_False(10554, 738, 768) || f_10554_750_768_M(!this.IsSuppressed)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 786, 834);

                var
                result = (BoundExpression)f_10554_816_833(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 848, 879);

                result.IsSuppressed = suppress;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 893, 907);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 463, 918);

                bool
                f_10554_554_571(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 554, 571);
                    return return_v;
                }


                bool
                f_10554_750_768_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 750, 768);
                    return return_v;
                }


                int
                f_10554_725_769(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 725, 769);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10554_816_833(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.MemberwiseClone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 816, 833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 463, 918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 463, 918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression WithWasConverted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 930, 1652);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 1355, 1467) || true) && ((f_10554_1360_1364() != BoundKind.Local && (DynAbs.Tracing.TraceSender.Expression_True(10554, 1360, 1414) && f_10554_1387_1391() != BoundKind.Parameter)) || (DynAbs.Tracing.TraceSender.Expression_False(10554, 1359, 1436) || f_10554_1419_1436(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 1355, 1467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 1455, 1467);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 1355, 1467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 1483, 1531);

                var
                result = (BoundExpression)f_10554_1513_1530(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 1545, 1572);

                result.WasConverted = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 1586, 1600);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 930, 1652);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10554_1360_1364()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 1360, 1364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10554_1387_1391()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 1387, 1391);
                    return return_v;
                }


                bool
                f_10554_1419_1436(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.WasConverted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 1419, 1436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10554_1513_1530(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.MemberwiseClone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 1513, 1530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 930, 1652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 930, 1652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal new BoundExpression WithHasErrors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 1664, 1789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 1733, 1778);

                return (BoundExpression)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WithHasErrors(), 10554, 1757, 1777);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 1664, 1789);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 1664, 1789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 1664, 1789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool NeedsToBeConverted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 1801, 2856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 1860, 2845);

                switch (f_10554_1868_1872())
                {

                    case BoundKind.TupleLiteral:
                    case BoundKind.UnconvertedSwitchExpression:
                    case BoundKind.UnconvertedObjectCreationExpression:
                    case BoundKind.UnconvertedConditionalOperator:
                    case BoundKind.DefaultLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 1860, 2845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 2198, 2210);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 1860, 2845);

                    case BoundKind.StackAllocArrayCreation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 1860, 2845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 2554, 2579);

                        return f_10554_2561_2570(this) is null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 1860, 2845);

                    case BoundKind.Local when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 2629, 2647) || true) && (f_10554_2634_2647_M(!WasConverted)) && (DynAbs.Tracing.TraceSender.Expression_True(10554, 2629, 2647) || true)
                :
                    case BoundKind.Parameter when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 2691, 2709) || true) && (f_10554_2696_2709_M(!WasConverted)) && (DynAbs.Tracing.TraceSender.Expression_True(10554, 2691, 2709) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 1860, 2845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 2732, 2761);

                        return f_10554_2739_2760_M(!WasCompilerGenerated);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 1860, 2845);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 1860, 2845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 2817, 2830);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 1860, 2845);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 1801, 2856);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10554_1868_1872()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 1868, 1872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10554_2561_2570(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 2561, 2570);
                    return return_v;
                }


                bool
                f_10554_2634_2647_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 2634, 2647);
                    return return_v;
                }


                bool
                f_10554_2696_2709_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 2696, 2709);
                    return return_v;
                }


                bool
                f_10554_2739_2760_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 2739, 2760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 1801, 2856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 1801, 2856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 2936, 2999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 2972, 2984);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 2936, 2999);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 2868, 3010);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 2868, 3010);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual Symbol? ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 3086, 3149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 3122, 3134);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 3086, 3149);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 3022, 3160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 3022, 3160);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual LookupResultKind ResultKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 3346, 3428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 3382, 3413);

                    return LookupResultKind.Viable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 3346, 3428);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 3279, 3439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 3279, 3439);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool SuppressVirtualCalls
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 3702, 3766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 3738, 3751);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 3702, 3766);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 3637, 3777);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 3637, 3777);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public new NullabilityInfo TopLevelNullability
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 3864, 3891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 3867, 3891);
                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.TopLevelNullability, 10554, 3867, 3891); DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 3864, 3891);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 3789, 3957);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 3789, 3957);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 3910, 3945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 3913, 3945);
                    base.TopLevelNullability = value; DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 3910, 3945);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 3789, 3957);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 3789, 3957);
                }
            }
        }

        public CodeAnalysis.ITypeSymbol? GetPublicTypeSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 4037, 4106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 4040, 4106);
                return f_10554_4040_4106_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10554_4040_4044(), 10554, 4040, 4106)?.GetITypeSymbol(f_10554_4061_4105(f_10554_4061_4080().FlowState))); DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 4037, 4106);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 4037, 4106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 4037, 4106);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            f_10554_4040_4044()
            {
                var return_v = Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 4040, 4044);
                return return_v;
            }


            Microsoft.CodeAnalysis.NullabilityInfo
            f_10554_4061_4080()
            {
                var return_v = TopLevelNullability;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 4061, 4080);
                return return_v;
            }


            Microsoft.CodeAnalysis.NullableAnnotation
            f_10554_4061_4105(Microsoft.CodeAnalysis.NullableFlowState
            nullableFlowState)
            {
                var return_v = nullableFlowState.ToAnnotation();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 4061, 4105);
                return return_v;
            }


            Microsoft.CodeAnalysis.ITypeSymbol?
            f_10554_4040_4106_I(Microsoft.CodeAnalysis.ITypeSymbol?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 4040, 4106);
                return return_v;
            }

        }

        static BoundExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 408, 4114);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 408, 4114);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 408, 4114);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 408, 4114);
    }
    internal partial class BoundPassByCopy
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 4246, 4374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 4282, 4329);

                    f_10554_4282_4328(f_10554_4295_4319(f_10554_4295_4305()) == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 4347, 4359);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 4246, 4374);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10554_4295_4305()
                    {
                        var return_v = Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 4295, 4305);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10554_4295_4319(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.ConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 4295, 4319);
                        return return_v;
                    }


                    int
                    f_10554_4282_4328(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 4282, 4328);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 4177, 4385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 4177, 4385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 4462, 4548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 4498, 4533);

                    return f_10554_4505_4532(f_10554_4505_4515());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 4462, 4548);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10554_4505_4515()
                    {
                        var return_v = Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 4505, 4515);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10554_4505_4532(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.ExpressionSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 4505, 4532);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 4397, 4559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 4397, 4559);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundPassByCopy()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 4122, 4566);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 4122, 4566);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 4122, 4566);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 4122, 4566);
    }
    internal partial class BoundCall
    {
        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 4687, 4757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 4723, 4742);

                    return f_10554_4730_4741(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 4687, 4757);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10554_4730_4741(Microsoft.CodeAnalysis.CSharp.BoundCall
                    this_param)
                    {
                        var return_v = this_param.Method;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 4730, 4741);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 4623, 4768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 4623, 4768);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundCall()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 4574, 4775);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 4574, 4775);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 4574, 4775);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 4574, 4775);
    }
    internal partial class BoundTypeExpression
    {
        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 4906, 4956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 4912, 4954);

                    return f_10554_4919_4932(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?>(10554, 4919, 4953) ?? (Symbol)f_10554_4944_4953(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 4906, 4956);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
                    f_10554_4919_4932(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                    this_param)
                    {
                        var return_v = this_param.AliasOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 4919, 4932);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10554_4944_4953(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 4944, 4953);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 4842, 4967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 4842, 4967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override LookupResultKind ResultKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 5047, 5339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 5083, 5160);

                    ErrorTypeSymbol?
                    errorType = f_10554_5112_5140(f_10554_5112_5121(this)) as ErrorTypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 5178, 5324) || true) && (errorType is { })
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 5178, 5324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 5221, 5249);

                        return f_10554_5228_5248(errorType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 5178, 5324);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 5178, 5324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 5293, 5324);

                        return LookupResultKind.Viable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 5178, 5324);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 5047, 5339);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10554_5112_5121(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 5112, 5121);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10554_5112_5140(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 5112, 5140);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LookupResultKind
                    f_10554_5228_5248(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ResultKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 5228, 5248);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 4979, 5350);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 4979, 5350);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundTypeExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 4783, 5357);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 4783, 5357);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 4783, 5357);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 4783, 5357);
    }
    internal partial class BoundNamespaceExpression
    {
        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 5493, 5554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 5499, 5552);

                    return f_10554_5506_5519(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?>(10554, 5506, 5551) ?? (Symbol)f_10554_5531_5551(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 5493, 5554);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
                    f_10554_5506_5519(Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression
                    this_param)
                    {
                        var return_v = this_param.AliasOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 5506, 5519);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10554_5531_5551(Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression
                    this_param)
                    {
                        var return_v = this_param.NamespaceSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 5531, 5551);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 5429, 5565);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 5429, 5565);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundNamespaceExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 5365, 5572);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 5365, 5572);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 5365, 5572);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 5365, 5572);
    }
    internal partial class BoundLocal
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 5699, 5736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 5705, 5734);

                    return f_10554_5712_5733(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 5699, 5736);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10554_5712_5733(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 5712, 5733);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 5630, 5747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 5630, 5747);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 5823, 5855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 5829, 5853);

                    return f_10554_5836_5852(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 5823, 5855);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10554_5836_5852(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 5836, 5852);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 5759, 5866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 5759, 5866);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public BoundLocal(SyntaxNode syntax, LocalSymbol localSymbol, ConstantValue? constantValueOpt, TypeSymbol type, bool hasErrors = false)
        : this(f_10554_6034_6040_C(syntax), localSymbol, BoundLocalDeclarationKind.None, constantValueOpt, false, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10554, 5878, 6150);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10554, 5878, 6150);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 5878, 6150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 5878, 6150);
            }
        }

        public BoundLocal Update(LocalSymbol localSymbol, ConstantValue? constantValueOpt, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 6162, 6399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 6286, 6388);

                return f_10554_6293_6387(this, localSymbol, f_10554_6318_6338(this), constantValueOpt, f_10554_6358_6380(this), type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 6162, 6399);

                Microsoft.CodeAnalysis.CSharp.BoundLocalDeclarationKind
                f_10554_6318_6338(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.DeclarationKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 6318, 6338);
                    return return_v;
                }


                bool
                f_10554_6358_6380(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.IsNullableUnknown;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 6358, 6380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10554_6293_6387(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localSymbol, Microsoft.CodeAnalysis.CSharp.BoundLocalDeclarationKind
                declarationKind, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, bool
                isNullableUnknown, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(localSymbol, declarationKind, constantValueOpt, isNullableUnknown, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 6293, 6387);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 6162, 6399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 6162, 6399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundLocal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 5580, 6406);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 5580, 6406);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 5580, 6406);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 5580, 6406);

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10554_6034_6040_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10554, 5878, 6150);
            return return_v;
        }

    }
    internal partial class BoundFieldAccess
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 6539, 6576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 6545, 6574);

                    return f_10554_6552_6573(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 6539, 6576);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10554_6552_6573(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 6552, 6573);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 6470, 6587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 6470, 6587);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 6664, 6696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 6670, 6694);

                    return f_10554_6677_6693(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 6664, 6696);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10554_6677_6693(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    this_param)
                    {
                        var return_v = this_param.FieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 6677, 6693);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 6599, 6707);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 6599, 6707);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundFieldAccess()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 6414, 6714);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 6414, 6714);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 6414, 6714);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 6414, 6714);
    }
    internal partial class BoundPropertyAccess
    {
        public override Symbol? ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 6846, 6881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 6852, 6879);

                    return f_10554_6859_6878(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 6846, 6881);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10554_6859_6878(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                    this_param)
                    {
                        var return_v = this_param.PropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 6859, 6878);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 6781, 6892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 6781, 6892);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundPropertyAccess()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 6722, 6899);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 6722, 6899);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 6722, 6899);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 6722, 6899);
    }
    internal partial class BoundIndexerAccess
    {
        public override Symbol? ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 7030, 7058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 7036, 7056);

                    return f_10554_7043_7055(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 7030, 7058);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10554_7043_7055(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                    this_param)
                    {
                        var return_v = this_param.Indexer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 7043, 7055);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 6965, 7069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 6965, 7069);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override LookupResultKind ResultKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 7149, 7306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 7185, 7291);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10554, 7192, 7227) || ((f_10554_7192_7227_M(!this.OriginalIndexersOpt.IsDefault) && DynAbs.Tracing.TraceSender.Conditional_F2(10554, 7230, 7272)) || DynAbs.Tracing.TraceSender.Conditional_F3(10554, 7275, 7290))) ? LookupResultKind.OverloadResolutionFailure : DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ResultKind, 10554, 7275, 7290);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 7149, 7306);

                    bool
                    f_10554_7192_7227_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 7192, 7227);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 7081, 7317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 7081, 7317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundIndexerAccess()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 6907, 7324);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 6907, 7324);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 6907, 7324);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 6907, 7324);
    }
    internal partial class BoundDynamicIndexerAccess
    {
        internal string? TryGetIndexedPropertyName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 7397, 7728);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 7466, 7689);
                    foreach (var indexer in f_10554_7490_7508_I(f_10554_7490_7508()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 7466, 7689);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 7542, 7674) || true) && (f_10554_7546_7564_M(!indexer.IsIndexer) && (DynAbs.Tracing.TraceSender.Expression_True(10554, 7546, 7593) && f_10554_7568_7593(indexer)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 7542, 7674);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 7635, 7655);

                            return f_10554_7642_7654(indexer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 7542, 7674);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 7466, 7689);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10554, 1, 224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10554, 1, 224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 7705, 7717);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 7397, 7728);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10554_7490_7508()
                {
                    var return_v = ApplicableIndexers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 7490, 7508);
                    return return_v;
                }


                bool
                f_10554_7546_7564_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 7546, 7564);
                    return return_v;
                }


                bool
                f_10554_7568_7593(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsIndexedProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 7568, 7593);
                    return return_v;
                }


                string
                f_10554_7642_7654(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 7642, 7654);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10554_7490_7508_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 7490, 7508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 7397, 7728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 7397, 7728);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundDynamicIndexerAccess()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 7332, 7735);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 7332, 7735);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 7332, 7735);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 7332, 7735);
    }
    internal partial class BoundEventAccess
    {
        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 7863, 7895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 7869, 7893);

                    return f_10554_7876_7892(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 7863, 7895);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10554_7876_7892(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                    this_param)
                    {
                        var return_v = this_param.EventSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 7876, 7892);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 7799, 7906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 7799, 7906);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundEventAccess()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 7743, 7913);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 7743, 7913);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 7743, 7913);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 7743, 7913);
    }
    internal partial class BoundParameter
    {
        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 8039, 8075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 8045, 8073);

                    return f_10554_8052_8072(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 8039, 8075);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10554_8052_8072(Microsoft.CodeAnalysis.CSharp.BoundParameter
                    this_param)
                    {
                        var return_v = this_param.ParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 8052, 8072);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 7975, 8086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 7975, 8086);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 7921, 8093);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 7921, 8093);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 7921, 8093);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 7921, 8093);
    }
    internal partial class BoundBinaryOperator
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 8229, 8266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 8235, 8264);

                    return f_10554_8242_8263(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 8229, 8266);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10554_8242_8263(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 8242, 8263);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 8160, 8277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 8160, 8277);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 8354, 8384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 8360, 8382);

                    return f_10554_8367_8381(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 8354, 8384);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10554_8367_8381(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    this_param)
                    {
                        var return_v = this_param.MethodOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 8367, 8381);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 8289, 8395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 8289, 8395);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundBinaryOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 8101, 8402);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 8101, 8402);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 8101, 8402);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 8101, 8402);
    }
    internal partial class BoundInterpolatedString
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 8542, 8579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 8548, 8577);

                    return f_10554_8555_8576(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 8542, 8579);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10554_8555_8576(Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 8555, 8576);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 8473, 8590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 8473, 8590);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundInterpolatedString()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 8410, 8597);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 8410, 8597);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 8410, 8597);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 8410, 8597);
    }
    internal partial class BoundUserDefinedConditionalLogicalOperator
    {
        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 8751, 8787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 8757, 8785);

                    return f_10554_8764_8784(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 8751, 8787);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10554_8764_8784(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                    this_param)
                    {
                        var return_v = this_param.LogicalOperator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 8764, 8784);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 8687, 8798);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 8687, 8798);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundUserDefinedConditionalLogicalOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 8605, 8805);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 8605, 8805);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 8605, 8805);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 8605, 8805);
    }
    internal partial class BoundUnaryOperator
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 8940, 8977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 8946, 8975);

                    return f_10554_8953_8974(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 8940, 8977);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10554_8953_8974(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 8953, 8974);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 8871, 8988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 8871, 8988);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 9065, 9095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 9071, 9093);

                    return f_10554_9078_9092(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 9065, 9095);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10554_9078_9092(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                    this_param)
                    {
                        var return_v = this_param.MethodOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 9078, 9092);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 9000, 9106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 9000, 9106);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundUnaryOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 8813, 9113);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 8813, 9113);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 8813, 9113);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 8813, 9113);
    }
    internal partial class BoundIncrementOperator
    {
        public override Symbol? ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 9248, 9278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 9254, 9276);

                    return f_10554_9261_9275(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 9248, 9278);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10554_9261_9275(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                    this_param)
                    {
                        var return_v = this_param.MethodOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 9261, 9275);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 9183, 9289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 9183, 9289);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundIncrementOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 9121, 9296);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 9121, 9296);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 9121, 9296);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 9121, 9296);
    }
    internal partial class BoundCompoundAssignmentOperator
    {
        public override Symbol? ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 9440, 9476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 9446, 9474);

                    return this.Operator.Method;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 9440, 9476);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 9375, 9487);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 9375, 9487);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundCompoundAssignmentOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 9304, 9494);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 9304, 9494);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 9304, 9494);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 9304, 9494);
    }
    internal partial class BoundLiteral
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 9623, 9660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 9629, 9658);

                    return f_10554_9636_9657(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 9623, 9660);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10554_9636_9657(Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 9636, 9657);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 9554, 9671);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 9554, 9671);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundLiteral()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 9502, 9678);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 9502, 9678);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 9502, 9678);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 9502, 9678);
    }
    internal partial class BoundConversion
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 9810, 9847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 9816, 9845);

                    return f_10554_9823_9844(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 9810, 9847);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10554_9823_9844(Microsoft.CodeAnalysis.CSharp.BoundConversion
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 9823, 9844);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 9741, 9858);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 9741, 9858);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ConversionKind ConversionKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 9931, 9967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 9937, 9965);

                    return this.Conversion.Kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 9931, 9967);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 9870, 9978);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 9870, 9978);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 10044, 10093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 10050, 10091);

                    return this.Conversion.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 10044, 10093);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 9990, 10104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 9990, 10104);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MethodSymbol? SymbolOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 10171, 10209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 10177, 10207);

                    return this.Conversion.Method;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 10171, 10209);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 10116, 10220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 10116, 10220);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 10297, 10327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 10303, 10325);

                    return f_10554_10310_10324(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 10297, 10327);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10554_10310_10324(Microsoft.CodeAnalysis.CSharp.BoundConversion
                    this_param)
                    {
                        var return_v = this_param.SymbolOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 10310, 10324);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 10232, 10338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 10232, 10338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool SuppressVirtualCalls
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 10416, 10453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 10422, 10451);

                    return f_10554_10429_10450(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 10416, 10453);

                    bool
                    f_10554_10429_10450(Microsoft.CodeAnalysis.CSharp.BoundConversion
                    this_param)
                    {
                        var return_v = this_param.IsBaseConversion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 10429, 10450);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 10350, 10464);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 10350, 10464);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public BoundConversion UpdateOperand(BoundExpression operand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 10476, 10785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 10562, 10774);

                return f_10554_10569_10773(this, operand: operand, f_10554_10599_10614(this), f_10554_10616_10637(this), f_10554_10639_10651(this), f_10554_10653_10676(this), f_10554_10678_10696(this), f_10554_10698_10721(this), f_10554_10723_10761(this), f_10554_10763_10772(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 10476, 10785);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10554_10599_10614(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 10599, 10614);
                    return return_v;
                }


                bool
                f_10554_10616_10637(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.IsBaseConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 10616, 10637);
                    return return_v;
                }


                bool
                f_10554_10639_10651(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 10639, 10651);
                    return return_v;
                }


                bool
                f_10554_10653_10676(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 10653, 10676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10554_10678_10696(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 10678, 10696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                f_10554_10698_10721(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionGroupOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 10698, 10721);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10554_10723_10761(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.OriginalUserDefinedConversionsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 10723, 10761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10554_10763_10772(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 10763, 10772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10554_10569_10773(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isBaseConversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                originalUserDefinedConversionsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operand: operand, conversion, isBaseConversion, @checked, explicitCastInCode, constantValueOpt, conversionGroupOpt, originalUserDefinedConversionsOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 10569, 10773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 10476, 10785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 10476, 10785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ConversionHasSideEffects()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 11066, 12116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 11361, 12077);

                switch (f_10554_11369_11388(this))
                {

                    case ConversionKind.Identity:
                    // NOTE: even explicit float/double identity conversion does not have side
                    // effects since it does not throw
                    case ConversionKind.ImplicitNumeric:
                    case ConversionKind.ImplicitEnumeration:
                    // implicit ref cast does not throw ...
                    case ConversionKind.ImplicitReference:
                    case ConversionKind.Boxing:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 11361, 12077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 11887, 11900);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 11361, 12077);

                    case ConversionKind.ExplicitNumeric:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 11361, 12077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 12042, 12062);

                        return f_10554_12049_12061(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 11361, 12077);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 12093, 12105);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 11066, 12116);

                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10554_11369_11388(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 11369, 11388);
                    return return_v;
                }


                bool
                f_10554_12049_12061(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 12049, 12061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 11066, 12116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 11066, 12116);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundConversion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 9686, 12123);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 9686, 12123);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 9686, 12123);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 9686, 12123);
    }
    internal partial class BoundObjectCreationExpression
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 12269, 12306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 12275, 12304);

                    return f_10554_12282_12303(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 12269, 12306);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10554_12282_12303(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 12282, 12303);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 12200, 12317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 12200, 12317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 12393, 12425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 12399, 12423);

                    return f_10554_12406_12422(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 12393, 12425);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10554_12406_12422(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.Constructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 12406, 12422);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 12329, 12436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 12329, 12436);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal BoundObjectCreationExpression UpdateArgumentsAndInitializer(
                    ImmutableArray<BoundExpression> newArguments,
                    ImmutableArray<RefKind> newRefKinds,
                    BoundObjectInitializerExpressionBase? newInitializerExpression,
                    TypeSymbol? changeTypeOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 12577, 13455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 12904, 13444);

                return f_10554_12911_13443(this, constructor: f_10554_12949_12960(), arguments: newArguments, argumentNamesOpt: default(ImmutableArray<string>), argumentRefKindsOpt: newRefKinds, expanded: false, argsToParamsOpt: default(ImmutableArray<int>), defaultArguments: default(BitVector), constantValueOpt: f_10554_13311_13327(), initializerExpressionOpt: newInitializerExpression, type: changeTypeOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10554, 13421, 13442) ?? f_10554_13438_13442()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 12577, 13455);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10554_12949_12960()
                {
                    var return_v = Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 12949, 12960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10554_13311_13327()
                {
                    var return_v = ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 13311, 13327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10554_13438_13442()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 13438, 13442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10554_12911_13443(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                initializerExpressionOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(constructor: constructor, arguments: arguments, argumentNamesOpt: argumentNamesOpt, argumentRefKindsOpt: argumentRefKindsOpt, expanded: expanded, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, constantValueOpt: constantValueOpt, initializerExpressionOpt: initializerExpressionOpt, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 12911, 13443);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 12577, 13455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 12577, 13455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundObjectCreationExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 12131, 13462);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 12131, 13462);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 12131, 13462);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 12131, 13462);
    }
    internal partial class BoundAnonymousObjectCreationExpression
    {
        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 13612, 13644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 13618, 13642);

                    return f_10554_13625_13641(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 13612, 13644);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10554_13625_13641(Microsoft.CodeAnalysis.CSharp.BoundAnonymousObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.Constructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 13625, 13641);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 13548, 13655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 13548, 13655);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundAnonymousObjectCreationExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 13470, 13662);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 13470, 13662);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 13470, 13662);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 13470, 13662);
    }
    internal partial class BoundAnonymousPropertyDeclaration
    {
        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 13807, 13836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 13813, 13834);

                    return f_10554_13820_13833(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 13807, 13836);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10554_13820_13833(Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration
                    this_param)
                    {
                        var return_v = this_param.Property;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 13820, 13833);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 13743, 13847);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 13743, 13847);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundAnonymousPropertyDeclaration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 13670, 13854);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 13670, 13854);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 13670, 13854);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 13670, 13854);
    }
    internal partial class BoundLambda
    {
        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 13977, 14004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 13983, 14002);

                    return f_10554_13990_14001(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 13977, 14004);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                    f_10554_13990_14001(Microsoft.CodeAnalysis.CSharp.BoundLambda
                    this_param)
                    {
                        var return_v = this_param.Symbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 13990, 14001);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 13913, 14015);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 13913, 14015);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundLambda()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 13862, 14022);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 7437, 7493);
            // LAFHIS
            NoReturnExpression = new UnsupportedMetadataTypeSymbol(); //f_10591_7458_7493(); 
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 7458, 7493);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 13862, 14022);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 13862, 14022);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 13862, 14022);
    }
    internal partial class BoundAttribute
    {
        public override Symbol? ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 14149, 14181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 14155, 14179);

                    return f_10554_14162_14178(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 14149, 14181);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10554_14162_14178(Microsoft.CodeAnalysis.CSharp.BoundAttribute
                    this_param)
                    {
                        var return_v = this_param.Constructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 14162, 14178);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 14084, 14192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 14084, 14192);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 14030, 14199);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 14030, 14199);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 14030, 14199);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 14030, 14199);
    }
    internal partial class BoundDefaultLiteral
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 14335, 14355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 14341, 14353);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 14335, 14355);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 14266, 14366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 14266, 14366);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundDefaultLiteral()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 14207, 14373);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 14207, 14373);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 14207, 14373);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 14207, 14373);
    }
    internal partial class BoundConditionalOperator
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 14514, 14594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 14550, 14579);

                    return f_10554_14557_14578(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 14514, 14594);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10554_14557_14578(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 14557, 14578);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 14445, 14605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 14445, 14605);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsDynamic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 14663, 15034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 14900, 15019);

                    return f_10554_14907_14926(f_10554_14907_14921(this)) == BoundKind.UnaryOperator && (DynAbs.Tracing.TraceSender.Expression_True(10554, 14907, 15018) && f_10554_14957_15018(f_10554_14957_15006(((BoundUnaryOperator)f_10554_14978_14992(this)))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 14663, 15034);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10554_14907_14921(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                    this_param)
                    {
                        var return_v = this_param.Condition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 14907, 14921);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10554_14907_14926(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 14907, 14926);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10554_14978_14992(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                    this_param)
                    {
                        var return_v = this_param.Condition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 14978, 14992);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                    f_10554_14957_15006(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                    this_param)
                    {
                        var return_v = this_param.OperatorKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 14957, 15006);
                        return return_v;
                    }


                    bool
                    f_10554_14957_15018(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                    kind)
                    {
                        var return_v = kind.IsDynamic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 14957, 15018);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 14617, 15045);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 14617, 15045);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundConditionalOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 14381, 15052);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 14381, 15052);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 14381, 15052);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 14381, 15052);
    }
    internal partial class BoundUnconvertedConditionalOperator
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 15204, 15284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 15240, 15269);

                    return f_10554_15247_15268(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 15204, 15284);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10554_15247_15268(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 15247, 15268);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 15135, 15295);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 15135, 15295);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundUnconvertedConditionalOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 15060, 15302);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 15060, 15302);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 15060, 15302);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 15060, 15302);
    }
    internal partial class BoundSizeOfOperator
    {
        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 15438, 15518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 15474, 15503);

                    return f_10554_15481_15502(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 15438, 15518);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10554_15481_15502(Microsoft.CodeAnalysis.CSharp.BoundSizeOfOperator
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 15481, 15502);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 15369, 15529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 15369, 15529);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundSizeOfOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 15310, 15536);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 15310, 15536);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 15310, 15536);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 15310, 15536);
    }
    internal partial class BoundRangeVariable
    {
        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 15666, 15749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 15702, 15734);

                    return f_10554_15709_15733(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 15666, 15749);

                    Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    f_10554_15709_15733(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                    this_param)
                    {
                        var return_v = this_param.RangeVariableSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 15709, 15733);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 15602, 15760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 15602, 15760);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundRangeVariable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 15544, 15767);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 15544, 15767);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 15544, 15767);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 15544, 15767);
    }
    internal partial class BoundLabel
    {
        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 15889, 15958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 15925, 15943);

                    return f_10554_15932_15942(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 15889, 15958);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10554_15932_15942(Microsoft.CodeAnalysis.CSharp.BoundLabel
                    this_param)
                    {
                        var return_v = this_param.Label;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 15932, 15942);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 15825, 15969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 15825, 15969);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundLabel()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 15775, 15976);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 15775, 15976);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 15775, 15976);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 15775, 15976);
    }
    internal partial class BoundObjectInitializerMember
    {
        public override Symbol? ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 16117, 16193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 16153, 16178);

                    return f_10554_16160_16177(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 16117, 16193);

                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10554_16160_16177(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                    this_param)
                    {
                        var return_v = this_param.MemberSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 16160, 16177);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 16052, 16204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 16052, 16204);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundObjectInitializerMember()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 15984, 16211);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 15984, 16211);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 15984, 16211);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 15984, 16211);
    }
    internal partial class BoundCollectionElementInitializer
    {
        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 16356, 16429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 16392, 16414);

                    return f_10554_16399_16413(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 16356, 16429);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10554_16399_16413(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                    this_param)
                    {
                        var return_v = this_param.AddMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 16399, 16413);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 16292, 16440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 16292, 16440);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundCollectionElementInitializer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 16219, 16447);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 16219, 16447);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 16219, 16447);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 16219, 16447);
    }
    internal partial class BoundBaseReference
    {
        public override bool SuppressVirtualCalls
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 16579, 16599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 16585, 16597);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 16579, 16599);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 16513, 16610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 16513, 16610);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundBaseReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 16455, 16617);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 16455, 16617);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 16455, 16617);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 16455, 16617);
    }
    internal partial class BoundNameOfOperator
    {
        public override ConstantValue ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 16752, 16832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 16788, 16817);

                    return f_10554_16795_16816(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 16752, 16832);

                    Microsoft.CodeAnalysis.ConstantValue
                    f_10554_16795_16816(Microsoft.CodeAnalysis.CSharp.BoundNameOfOperator
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 16795, 16816);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 16684, 16843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 16684, 16843);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundNameOfOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 16625, 16850);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 16625, 16850);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 16625, 16850);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 16625, 16850);
    }

    internal struct BoundTypeOrValueData : System.IEquatable<BoundTypeOrValueData>
    {

        public Symbol ValueSymbol { get; }

        public BoundExpression ValueExpression { get; }

        public DiagnosticBag ValueDiagnostics { get; }

        public BoundExpression TypeExpression { get; }

        public DiagnosticBag TypeDiagnostics { get; }

        public BoundTypeOrValueData(Symbol valueSymbol, BoundExpression valueExpression, DiagnosticBag valueDiagnostics, BoundExpression typeExpression, DiagnosticBag typeDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10554, 17621, 18839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 17821, 17953);

                f_10554_17821_17952(valueSymbol != null, "Field 'valueSymbol' cannot be null (use Null=\"allow\" in BoundNodes.xml to remove this check)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 17967, 18107);

                f_10554_17967_18106(valueExpression != null, "Field 'valueExpression' cannot be null (use Null=\"allow\" in BoundNodes.xml to remove this check)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 18121, 18263);

                f_10554_18121_18262(valueDiagnostics != null, "Field 'valueDiagnostics' cannot be null (use Null=\"allow\" in BoundNodes.xml to remove this check)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 18277, 18415);

                f_10554_18277_18414(typeExpression != null, "Field 'typeExpression' cannot be null (use Null=\"allow\" in BoundNodes.xml to remove this check)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 18429, 18569);

                f_10554_18429_18568(typeDiagnostics != null, "Field 'typeDiagnostics' cannot be null (use Null=\"allow\" in BoundNodes.xml to remove this check)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 18585, 18616);

                this.ValueSymbol = valueSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 18630, 18669);

                this.ValueExpression = valueExpression;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 18683, 18724);

                this.ValueDiagnostics = valueDiagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 18738, 18775);

                this.TypeExpression = typeExpression;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 18789, 18828);

                this.TypeDiagnostics = typeDiagnostics;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10554, 17621, 18839);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 17621, 18839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 17621, 18839);
            }
        }

        public static bool operator ==(BoundTypeOrValueData a, BoundTypeOrValueData b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10554, 18953, 19421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 19056, 19410);

                return (object)a.ValueSymbol == (object)b.ValueSymbol && (DynAbs.Tracing.TraceSender.Expression_True(10554, 19063, 19184) && (object)a.ValueExpression == (object)b.ValueExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10554, 19063, 19261) && (object)a.ValueDiagnostics == (object)b.ValueDiagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(10554, 19063, 19334) && (object)a.TypeExpression == (object)b.TypeExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10554, 19063, 19409) && (object)a.TypeDiagnostics == (object)b.TypeDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10554, 18953, 19421);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 18953, 19421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 18953, 19421);
            }
        }

        public static bool operator !=(BoundTypeOrValueData a, BoundTypeOrValueData b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10554, 19433, 19564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 19536, 19553);

                return !(a == b);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10554, 19433, 19564);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 19433, 19564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 19433, 19564);
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 19576, 19724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 19641, 19713);

                return obj is BoundTypeOrValueData && (DynAbs.Tracing.TraceSender.Expression_True(10554, 19648, 19712) && (BoundTypeOrValueData)obj == this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 19576, 19724);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 19576, 19724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 19576, 19724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 19736, 20069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 19794, 20058);

                return f_10554_19801_20057(f_10554_19814_19839(ValueSymbol), f_10554_19858_20056(f_10554_19871_19900(ValueExpression), f_10554_19919_20055(f_10554_19932_19962(ValueDiagnostics), f_10554_19981_20054(f_10554_19994_20022(TypeExpression), f_10554_20024_20053(TypeDiagnostics)))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 19736, 20069);

                int
                f_10554_19814_19839(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 19814, 19839);
                    return return_v;
                }


                int
                f_10554_19871_19900(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 19871, 19900);
                    return return_v;
                }


                int
                f_10554_19932_19962(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 19932, 19962);
                    return return_v;
                }


                int
                f_10554_19994_20022(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 19994, 20022);
                    return return_v;
                }


                int
                f_10554_20024_20053(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 20024, 20053);
                    return return_v;
                }


                int
                f_10554_19981_20054(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 19981, 20054);
                    return return_v;
                }


                int
                f_10554_19919_20055(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 19919, 20055);
                    return return_v;
                }


                int
                f_10554_19858_20056(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 19858, 20056);
                    return return_v;
                }


                int
                f_10554_19801_20057(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 19801, 20057);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 19736, 20069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 19736, 20069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool System.IEquatable<BoundTypeOrValueData>.Equals(BoundTypeOrValueData b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 20081, 20209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 20181, 20198);

                return b == this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 20081, 20209);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 20081, 20209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 20081, 20209);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static BoundTypeOrValueData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 17256, 20216);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 17256, 20216);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 17256, 20216);
        }

        static int
        f_10554_17821_17952(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 17821, 17952);
            return 0;
        }


        static int
        f_10554_17967_18106(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 17967, 18106);
            return 0;
        }


        static int
        f_10554_18121_18262(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 18121, 18262);
            return 0;
        }


        static int
        f_10554_18277_18414(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 18277, 18414);
            return 0;
        }


        static int
        f_10554_18429_18568(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 18429, 18568);
            return 0;
        }

    }
    internal partial class BoundTupleExpression
    {
        internal void VisitAllElements<T>(Action<BoundExpression, T> action, T args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10554, 20401, 20874);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 20502, 20863);
                    foreach (var argument in f_10554_20527_20541_I(f_10554_20527_20541<T>(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 20502, 20863);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 20575, 20848) || true) && (f_10554_20579_20592<T>(argument) == BoundKind.TupleLiteral)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 20575, 20848);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 20660, 20724);

                            f_10554_20660_20723<T>(((BoundTupleExpression)argument), action, args);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 20575, 20848);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10554, 20575, 20848);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10554, 20806, 20829);

                            f_10554_20806_20828<T>(action, argument, args);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 20575, 20848);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10554, 20502, 20863);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10554, 1, 362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10554, 1, 362);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10554, 20401, 20874);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10554_20527_20541<T>(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 20527, 20541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10554_20579_20592<T>(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10554, 20579, 20592);
                    return return_v;
                }


                int
                f_10554_20660_20723<T>(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param, System.Action<Microsoft.CodeAnalysis.CSharp.BoundExpression, T>
                action, T?
                args)
                {
                    this_param.VisitAllElements<T>(action, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 20660, 20723);
                    return 0;
                }


                int
                f_10554_20806_20828<T>(System.Action<Microsoft.CodeAnalysis.CSharp.BoundExpression, T>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg1, T?
                arg2)
                {
                    this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 20806, 20828);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10554_20527_20541_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10554, 20527, 20541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10554, 20401, 20874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 20401, 20874);
            }
        }

        static BoundTupleExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10554, 20224, 20881);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10554, 20224, 20881);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10554, 20224, 20881);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10554, 20224, 20881);
    }
}
