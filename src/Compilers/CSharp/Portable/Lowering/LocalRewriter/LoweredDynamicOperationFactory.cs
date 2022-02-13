// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class LoweredDynamicOperationFactory
    {
        private readonly SyntheticBoundNodeFactory _factory;

        private readonly int _methodOrdinal;

        private readonly int _localFunctionOrdinal;

        private NamedTypeSymbol? _currentDynamicCallSiteContainer;

        private int _callSiteIdDispenser;

        internal LoweredDynamicOperationFactory(SyntheticBoundNodeFactory factory, int methodOrdinal, int localFunctionOrdinal = -1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10537, 796, 1123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 565, 573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 605, 619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 651, 672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 708, 740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 763, 783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 945, 975);

                f_10537_945_974(factory != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 989, 1008);

                _factory = factory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 1022, 1053);

                _methodOrdinal = methodOrdinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 1067, 1112);

                _localFunctionOrdinal = localFunctionOrdinal;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10537, 796, 1123);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 796, 1123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 796, 1123);
            }
        }

        public int MethodOrdinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 1160, 1177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 1163, 1177);
                    return _methodOrdinal; DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 1160, 1177);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 1160, 1177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 1160, 1177);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        // We could read the values of the following enums from metadata instead of hardcoding them here but 
        // - they can never change since existing programs have the values inlined and would be broken if the values changed their meaning,
        // - if any new flags are added to the runtime binder the compiler will change as well to produce them.

        // The only scenario that is not supported by hardcoding the values is when a completely new Framework is created 
        // that redefines these constants and is not supposed to run existing programs.

        /// <summary>
        /// Corresponds to Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.
        /// </summary>
        [Flags]
        private enum CSharpBinderFlags
        {
            None = 0,
            CheckedContext = 1,
            InvokeSimpleName = 2,
            InvokeSpecialName = 4,
            BinaryOperationLogical = 8,
            ConvertExplicit = 16,
            ConvertArrayIndex = 32,
            ResultIndexed = 64,
            ValueFromCompoundAssignment = 128,
            ResultDiscarded = 256,
        }

        /// <summary>
        /// Corresponds to Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.
        /// </summary>
        [Flags]
        private enum CSharpArgumentInfoFlags
        {
            None = 0,
            UseCompileTimeType = 1,
            Constant = 2,
            NamedArgument = 4,
            IsRef = 8,
            IsOut = 16,
            IsStaticType = 32,
        }

        internal LoweredDynamicOperation MakeDynamicConversion(
                    BoundExpression loweredOperand,
                    bool isExplicit,
                    bool isArrayIndex,
                    bool isChecked,
                    TypeSymbol resultType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 2753, 4195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 3005, 3045);

                _factory.Syntax = loweredOperand.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 3061, 3095);

                CSharpBinderFlags
                binderFlags = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 3109, 3152);

                f_10537_3109_3151(!isExplicit || (DynAbs.Tracing.TraceSender.Expression_False(10537, 3122, 3150) || !isArrayIndex));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 3168, 3278) || true) && (isChecked)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 3168, 3278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 3215, 3263);

                    binderFlags |= CSharpBinderFlags.CheckedContext;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 3168, 3278);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 3292, 3404) || true) && (isExplicit)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 3292, 3404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 3340, 3389);

                    binderFlags |= CSharpBinderFlags.ConvertExplicit;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 3292, 3404);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 3418, 3534) || true) && (isArrayIndex)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 3418, 3534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 3468, 3519);

                    binderFlags |= CSharpBinderFlags.ConvertArrayIndex;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 3418, 3534);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 3550, 3611);

                var
                loweredArguments = f_10537_3573_3610(loweredOperand)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 3627, 4030);

                var
                binderConstruction = f_10537_3652_4029(this, WellKnownMember.Microsoft_CSharp_RuntimeBinder_Binder__Convert, new[]
                            {
f_10537_3804_3838(                // flags:
                _factory, binderFlags),
f_10537_3892_3919(
                // target type:
                _factory, resultType),
f_10537_3969_4013(
                // context:
                _factory)            })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 4046, 4184);

                return f_10537_4053_4183(this, binderConstruction, null, RefKind.None, loweredArguments, default(ImmutableArray<RefKind>), null, resultType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 2753, 4195);

                int
                f_10537_3109_3151(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 3109, 3151);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10537_3573_3610(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 3573, 3610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_3804_3838(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory.CSharpBinderFlags
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 3804, 3838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_3892_3919(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 3892, 3919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_3969_4013(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TypeofDynamicOperationContextType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 3969, 4013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10537_3652_4029(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                factoryMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.MakeBinderConstruction(factoryMethod, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 3652, 4029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_4053_4183(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                binderConstruction, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicOperation(binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 4053, 4183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 2753, 4195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 2753, 4195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LoweredDynamicOperation MakeDynamicUnaryOperator(
                    UnaryOperatorKind operatorKind,
                    BoundExpression loweredOperand,
                    TypeSymbol resultType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 4207, 5641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 4416, 4455);

                f_10537_4416_4454(f_10537_4429_4453(operatorKind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 4471, 4511);

                _factory.Syntax = loweredOperand.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 4527, 4561);

                CSharpBinderFlags
                binderFlags = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 4575, 4700) || true) && (f_10537_4579_4603(operatorKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 4575, 4700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 4637, 4685);

                    binderFlags |= CSharpBinderFlags.CheckedContext;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 4575, 4700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 4716, 4777);

                var
                loweredArguments = f_10537_4739_4776(loweredOperand)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 4793, 4853);

                MethodSymbol
                argumentInfoFactory = f_10537_4828_4852(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 4867, 5476);

                var
                binderConstruction = (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 4892, 4929) || ((((object)argumentInfoFactory != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 4932, 5468)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 5471, 5475))) ? f_10537_4932_5468(this, WellKnownMember.Microsoft_CSharp_RuntimeBinder_Binder__UnaryOperation, new[]
                            {
f_10537_5091_5125(                // flags:
                _factory, binderFlags),
f_10537_5183_5237(
                // expression type:
                _factory, f_10537_5205_5236(operatorKind)),
f_10537_5287_5331(
                // context:
                _factory),
f_10537_5388_5452(this, argumentInfoFactory, loweredArguments)            }) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 5492, 5630);

                return f_10537_5499_5629(this, binderConstruction, null, RefKind.None, loweredArguments, default(ImmutableArray<RefKind>), null, resultType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 4207, 5641);

                bool
                f_10537_4429_4453(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 4429, 4453);
                    return return_v;
                }


                int
                f_10537_4416_4454(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 4416, 4454);
                    return 0;
                }


                bool
                f_10537_4579_4603(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.IsChecked();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 4579, 4603);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10537_4739_4776(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 4739, 4776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_4828_4852(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param)
                {
                    var return_v = this_param.GetArgumentInfoFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 4828, 4852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_5091_5125(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory.CSharpBinderFlags
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 5091, 5125);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_10537_5205_5236(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.ToExpressionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 5205, 5236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_5183_5237(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Linq.Expressions.ExpressionType
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 5183, 5237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_5287_5331(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TypeofDynamicOperationContextType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 5287, 5331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_5388_5452(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments)
                {
                    var return_v = this_param.MakeCallSiteArgumentInfos(argumentInfoFactory, loweredArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 5388, 5452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10537_4932_5468(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                factoryMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.MakeBinderConstruction(factoryMethod, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 4932, 5468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_5499_5629(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                binderConstruction, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicOperation(binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 5499, 5629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 4207, 5641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 4207, 5641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LoweredDynamicOperation MakeDynamicBinaryOperator(
                    BinaryOperatorKind operatorKind,
                    BoundExpression loweredLeft,
                    BoundExpression loweredRight,
                    bool isCompoundAssignment,
                    TypeSymbol resultType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 5653, 7364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 5944, 5983);

                f_10537_5944_5982(f_10537_5957_5981(operatorKind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 5999, 6036);

                _factory.Syntax = loweredLeft.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 6052, 6086);

                CSharpBinderFlags
                binderFlags = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 6100, 6225) || true) && (f_10537_6104_6128(operatorKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 6100, 6225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 6162, 6210);

                    binderFlags |= CSharpBinderFlags.CheckedContext;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 6100, 6225);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 6241, 6374) || true) && (f_10537_6245_6269(operatorKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 6241, 6374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 6303, 6359);

                    binderFlags |= CSharpBinderFlags.BinaryOperationLogical;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 6241, 6374);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 6390, 6479);

                var
                loweredArguments = f_10537_6413_6478(loweredLeft, loweredRight)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 6495, 6555);

                MethodSymbol
                argumentInfoFactory = f_10537_6530_6554(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 6569, 7199);

                var
                binderConstruction = (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 6594, 6631) || ((((object)argumentInfoFactory != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 6634, 7191)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 7194, 7198))) ? f_10537_6634_7191(this, WellKnownMember.Microsoft_CSharp_RuntimeBinder_Binder__BinaryOperation, new[]
                            {
f_10537_6794_6828(                // flags:
                _factory, binderFlags),
f_10537_6886_6960(
                // expression type:
                _factory, f_10537_6908_6959(operatorKind, isCompoundAssignment)),
f_10537_7010_7054(
                // context:
                _factory),
f_10537_7111_7175(this, argumentInfoFactory, loweredArguments)            }) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 7215, 7353);

                return f_10537_7222_7352(this, binderConstruction, null, RefKind.None, loweredArguments, default(ImmutableArray<RefKind>), null, resultType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 5653, 7364);

                bool
                f_10537_5957_5981(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 5957, 5981);
                    return return_v;
                }


                int
                f_10537_5944_5982(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 5944, 5982);
                    return 0;
                }


                bool
                f_10537_6104_6128(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsChecked();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 6104, 6128);
                    return return_v;
                }


                bool
                f_10537_6245_6269(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLogical();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 6245, 6269);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10537_6413_6478(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item2)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 6413, 6478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_6530_6554(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param)
                {
                    var return_v = this_param.GetArgumentInfoFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 6530, 6554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_6794_6828(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory.CSharpBinderFlags
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 6794, 6828);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_10537_6908_6959(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, bool
                isCompoundAssignment)
                {
                    var return_v = kind.ToExpressionType(isCompoundAssignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 6908, 6959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_6886_6960(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Linq.Expressions.ExpressionType
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 6886, 6960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_7010_7054(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TypeofDynamicOperationContextType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 7010, 7054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_7111_7175(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments)
                {
                    var return_v = this_param.MakeCallSiteArgumentInfos(argumentInfoFactory, loweredArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 7111, 7175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10537_6634_7191(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                factoryMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.MakeBinderConstruction(factoryMethod, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 6634, 7191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_7222_7352(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                binderConstruction, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicOperation(binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 7222, 7352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 5653, 7364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 5653, 7364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LoweredDynamicOperation MakeDynamicMemberInvocation(
                    string name,
                    BoundExpression loweredReceiver,
                    ImmutableArray<TypeWithAnnotations> typeArgumentsWithAnnotations,
                    ImmutableArray<BoundExpression> loweredArguments,
                    ImmutableArray<string> argumentNames,
                    ImmutableArray<RefKind> refKinds,
                    bool hasImplicitReceiver,
                    bool resultDiscarded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 7376, 10310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 7848, 7889);

                _factory.Syntax = loweredReceiver.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 7903, 7948);

                f_10537_7903_7947(f_10537_7916_7939(_factory) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 7964, 7998);

                CSharpBinderFlags
                binderFlags = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8012, 8186) || true) && (hasImplicitReceiver && (DynAbs.Tracing.TraceSender.Expression_True(10537, 8016, 8087) && f_10537_8039_8087(f_10537_8039_8062(_factory))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 8012, 8186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8121, 8171);

                    binderFlags |= CSharpBinderFlags.InvokeSimpleName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 8012, 8186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8202, 8224);

                TypeSymbol
                resultType
                = default(TypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8238, 8538) || true) && (resultDiscarded)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 8238, 8538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8291, 8340);

                    binderFlags |= CSharpBinderFlags.ResultDiscarded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8358, 8417);

                    resultType = f_10537_8371_8416(_factory, SpecialType.System_Void);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 8238, 8538);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 8238, 8538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8483, 8523);

                    resultType = f_10537_8496_8522();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 8238, 8538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8554, 8578);

                RefKind
                receiverRefKind
                = default(RefKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8592, 8618);

                bool
                receiverIsStaticType
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8632, 9074) || true) && (f_10537_8636_8656(loweredReceiver) == BoundKind.TypeExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 8632, 9074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8718, 8797);

                    loweredReceiver = f_10537_8736_8796(_factory, f_10537_8752_8795(((BoundTypeExpression)loweredReceiver)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8815, 8846);

                    receiverRefKind = RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8864, 8892);

                    receiverIsStaticType = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 8632, 9074);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 8632, 9074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 8958, 9012);

                    receiverRefKind = f_10537_8976_9011(loweredReceiver);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 9030, 9059);

                    receiverIsStaticType = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 8632, 9074);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 9090, 9150);

                MethodSymbol
                argumentInfoFactory = f_10537_9125_9149(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 9164, 10155);

                var
                binderConstruction = (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 9189, 9226) || ((((object)argumentInfoFactory != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 9229, 10147)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 10150, 10154))) ? f_10537_9229_10147(this, WellKnownMember.Microsoft_CSharp_RuntimeBinder_Binder__InvokeMember, new[]
                            {
f_10537_9386_9420(                // flags:
                _factory, binderFlags),
f_10537_9474_9496(
                // member name:
                _factory, name),
(DynAbs.Tracing.TraceSender.Conditional_F1(10537, 9553, 9598)||((
                // type arguments:
                typeArgumentsWithAnnotations.IsDefaultOrEmpty &&DynAbs.Tracing.TraceSender.Conditional_F2(10537, 9622, 9691))||DynAbs.Tracing.TraceSender.Conditional_F3(10537, 9715, 9835)))?f_10537_9622_9691(                    _factory, f_10537_9636_9690(_factory, WellKnownType.System_Type)):f_10537_9715_9835(                    _factory, f_10537_9737_9786(_factory, WellKnownType.System_Type), f_10537_9788_9834(_factory, typeArgumentsWithAnnotations)),
f_10537_9885_9929(
                // context:
                _factory),
f_10537_9986_10131(this, argumentInfoFactory, loweredArguments, argumentNames, refKinds, loweredReceiver, receiverRefKind, receiverIsStaticType)            }) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 10171, 10299);

                return f_10537_10178_10298(this, binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, null, resultType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 7376, 10310);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10537_7916_7939(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TopLevelMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 7916, 7939);
                    return return_v;
                }


                int
                f_10537_7903_7947(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 7903, 7947);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_8039_8062(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TopLevelMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 8039, 8062);
                    return return_v;
                }


                bool
                f_10537_8039_8087(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 8039, 8087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_8371_8416(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 8371, 8416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10537_8496_8522()
                {
                    var return_v = AssemblySymbol.DynamicType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 8496, 8522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10537_8636_8656(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 8636, 8656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10537_8752_8795(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 8752, 8795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_8736_8796(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 8736, 8796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10537_8976_9011(Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver)
                {
                    var return_v = GetReceiverRefKind(loweredReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 8976, 9011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_9125_9149(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param)
                {
                    var return_v = this_param.GetArgumentInfoFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 9125, 9149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_9386_9420(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory.CSharpBinderFlags
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 9386, 9420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_9474_9496(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 9474, 9496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10537_9636_9690(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                elementType)
                {
                    var return_v = this_param.WellKnownArrayType(elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 9636, 9690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_9622_9691(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 9622, 9691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_9737_9786(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 9737, 9786);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10537_9788_9834(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.TypeOfs(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 9788, 9834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_9715_9835(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.ArrayOrEmpty((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 9715, 9835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_9885_9929(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TypeofDynamicOperationContextType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 9885, 9929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_9986_10131(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, bool
                receiverIsStaticType)
                {
                    var return_v = this_param.MakeCallSiteArgumentInfos(argumentInfoFactory, loweredArguments, argumentNames, refKinds, loweredReceiver, receiverRefKind, receiverIsStaticType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 9986, 10131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10537_9229_10147(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                factoryMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.MakeBinderConstruction(factoryMethod, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 9229, 10147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_10178_10298(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                binderConstruction, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicOperation(binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 10178, 10298);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 7376, 10310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 7376, 10310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LoweredDynamicOperation MakeDynamicEventAccessorInvocation(
                    string accessorName,
                    BoundExpression loweredReceiver,
                    BoundExpression loweredHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 10322, 11881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 10540, 10581);

                _factory.Syntax = loweredReceiver.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 10597, 10701);

                CSharpBinderFlags
                binderFlags = CSharpBinderFlags.InvokeSpecialName | CSharpBinderFlags.ResultDiscarded
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 10717, 10778);

                var
                loweredArguments = ImmutableArray<BoundExpression>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 10792, 10836);

                var
                resultType = f_10537_10809_10835()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 10852, 10912);

                MethodSymbol
                argumentInfoFactory = f_10537_10887_10911(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 10926, 11695);

                var
                binderConstruction = (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 10951, 10988) || ((((object)argumentInfoFactory != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 10991, 11687)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 11690, 11694))) ? f_10537_10991_11687(this, WellKnownMember.Microsoft_CSharp_RuntimeBinder_Binder__InvokeMember, new[]
                            {
f_10537_11148_11182(                // flags:
                _factory, binderFlags),
f_10537_11236_11266(
                // member name:
                _factory, accessorName),
f_10537_11323_11392(
                // type arguments:
                _factory, f_10537_11337_11391(_factory, WellKnownType.System_Type)),
f_10537_11442_11486(
                // context:
                _factory),
f_10537_11543_11671(this, argumentInfoFactory, loweredArguments, loweredReceiver: loweredReceiver, loweredRight: loweredHandler)            }) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 11711, 11870);

                return f_10537_11718_11869(this, binderConstruction, loweredReceiver, RefKind.None, loweredArguments, default(ImmutableArray<RefKind>), loweredHandler, resultType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 10322, 11881);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10537_10809_10835()
                {
                    var return_v = AssemblySymbol.DynamicType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 10809, 10835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_10887_10911(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param)
                {
                    var return_v = this_param.GetArgumentInfoFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 10887, 10911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_11148_11182(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory.CSharpBinderFlags
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 11148, 11182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_11236_11266(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 11236, 11266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10537_11337_11391(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                elementType)
                {
                    var return_v = this_param.WellKnownArrayType(elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 11337, 11391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_11323_11392(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 11323, 11392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_11442_11486(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TypeofDynamicOperationContextType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 11442, 11486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_11543_11671(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredRight)
                {
                    var return_v = this_param.MakeCallSiteArgumentInfos(argumentInfoFactory, loweredArguments, loweredReceiver: loweredReceiver, loweredRight: loweredRight);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 11543, 11671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10537_10991_11687(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                factoryMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.MakeBinderConstruction(factoryMethod, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 10991, 11687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_11718_11869(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                binderConstruction, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicOperation(binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 11718, 11869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 10322, 11881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 10322, 11881);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LoweredDynamicOperation MakeDynamicInvocation(
                    BoundExpression loweredReceiver,
                    ImmutableArray<BoundExpression> loweredArguments,
                    ImmutableArray<string> argumentNames,
                    ImmutableArray<RefKind> refKinds,
                    bool resultDiscarded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 11893, 13429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 12215, 12256);

                _factory.Syntax = loweredReceiver.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 12272, 12294);

                TypeSymbol
                resultType
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 12308, 12342);

                CSharpBinderFlags
                binderFlags = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 12356, 12656) || true) && (resultDiscarded)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 12356, 12656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 12409, 12458);

                    binderFlags |= CSharpBinderFlags.ResultDiscarded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 12476, 12535);

                    resultType = f_10537_12489_12534(_factory, SpecialType.System_Void);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 12356, 12656);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 12356, 12656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 12601, 12641);

                    resultType = f_10537_12614_12640();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 12356, 12656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 12672, 12732);

                MethodSymbol
                argumentInfoFactory = f_10537_12707_12731(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 12746, 13277);

                var
                binderConstruction = (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 12771, 12808) || ((((object)argumentInfoFactory != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 12811, 13269)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 13272, 13276))) ? f_10537_12811_13269(this, WellKnownMember.Microsoft_CSharp_RuntimeBinder_Binder__Invoke, new[]
                            {
f_10537_12962_12996(                // flags:
                _factory, binderFlags),
f_10537_13046_13090(
                // context:
                _factory),
f_10537_13147_13253(this, argumentInfoFactory, loweredArguments, argumentNames, refKinds, loweredReceiver)            }) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 13293, 13418);

                return f_10537_13300_13417(this, binderConstruction, loweredReceiver, RefKind.None, loweredArguments, refKinds, null, resultType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 11893, 13429);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_12489_12534(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 12489, 12534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10537_12614_12640()
                {
                    var return_v = AssemblySymbol.DynamicType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 12614, 12640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_12707_12731(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param)
                {
                    var return_v = this_param.GetArgumentInfoFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 12707, 12731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_12962_12996(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory.CSharpBinderFlags
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 12962, 12996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_13046_13090(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TypeofDynamicOperationContextType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 13046, 13090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_13147_13253(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver)
                {
                    var return_v = this_param.MakeCallSiteArgumentInfos(argumentInfoFactory, loweredArguments, argumentNames, refKinds, loweredReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 13147, 13253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10537_12811_13269(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                factoryMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.MakeBinderConstruction(factoryMethod, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 12811, 13269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_13300_13417(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                binderConstruction, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicOperation(binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 13300, 13417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 11893, 13429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 11893, 13429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LoweredDynamicOperation MakeDynamicConstructorInvocation(
                    SyntaxNode syntax,
                    TypeSymbol type,
                    ImmutableArray<BoundExpression> loweredArguments,
                    ImmutableArray<string> argumentNames,
                    ImmutableArray<RefKind> refKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 13441, 14631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 13755, 13780);

                _factory.Syntax = syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 13796, 13840);

                var
                loweredReceiver = f_10537_13818_13839(_factory, type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 13856, 13916);

                MethodSymbol
                argumentInfoFactory = f_10537_13891_13915(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 13930, 14485);

                var
                binderConstruction = (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 13955, 13992) || ((((object)argumentInfoFactory != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 13995, 14477)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 14480, 14484))) ? f_10537_13995_14477(this, WellKnownMember.Microsoft_CSharp_RuntimeBinder_Binder__InvokeConstructor, new[]
                            {
f_10537_14157_14176(                // flags:
                _factory, 0),
f_10537_14226_14270(
                // context:
                _factory),
f_10537_14327_14461(this, argumentInfoFactory, loweredArguments, argumentNames, refKinds, loweredReceiver, receiverIsStaticType: true)            }) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 14501, 14620);

                return f_10537_14508_14619(this, binderConstruction, loweredReceiver, RefKind.None, loweredArguments, refKinds, null, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 13441, 14631);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_13818_13839(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 13818, 13839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_13891_13915(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param)
                {
                    var return_v = this_param.GetArgumentInfoFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 13891, 13915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_14157_14176(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 14157, 14176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_14226_14270(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TypeofDynamicOperationContextType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 14226, 14270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_14327_14461(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, bool
                receiverIsStaticType)
                {
                    var return_v = this_param.MakeCallSiteArgumentInfos(argumentInfoFactory, loweredArguments, argumentNames, refKinds, loweredReceiver, receiverIsStaticType: receiverIsStaticType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 14327, 14461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10537_13995_14477(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                factoryMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.MakeBinderConstruction(factoryMethod, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 13995, 14477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_14508_14619(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                binderConstruction, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicOperation(binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 14508, 14619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 13441, 14631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 13441, 14631);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LoweredDynamicOperation MakeDynamicGetMember(
                    BoundExpression loweredReceiver,
                    string name,
                    bool resultIndexed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 14643, 16041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 14827, 14868);

                _factory.Syntax = loweredReceiver.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 14884, 14918);

                CSharpBinderFlags
                binderFlags = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 14932, 15045) || true) && (resultIndexed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 14932, 15045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 14983, 15030);

                    binderFlags |= CSharpBinderFlags.ResultIndexed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 14932, 15045);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 15061, 15122);

                var
                loweredArguments = ImmutableArray<BoundExpression>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 15136, 15180);

                var
                resultType = DynamicTypeSymbol.Instance
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 15196, 15256);

                MethodSymbol
                argumentInfoFactory = f_10537_15231_15255(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 15270, 15865);

                var
                binderConstruction = (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 15295, 15332) || ((((object)argumentInfoFactory != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 15335, 15857)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 15860, 15864))) ? f_10537_15335_15857(this, WellKnownMember.Microsoft_CSharp_RuntimeBinder_Binder__GetMember, new[]
                            {
f_10537_15489_15523(                // flags:
                _factory, binderFlags),
f_10537_15570_15592(
                // name:
                _factory, name),
f_10537_15642_15686(
                // context:
                _factory),
f_10537_15743_15841(this, argumentInfoFactory, loweredArguments, loweredReceiver: loweredReceiver)            }) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 15881, 16030);

                return f_10537_15888_16029(this, binderConstruction, loweredReceiver, RefKind.None, loweredArguments, default(ImmutableArray<RefKind>), null, resultType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 14643, 16041);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_15231_15255(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param)
                {
                    var return_v = this_param.GetArgumentInfoFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 15231, 15255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_15489_15523(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory.CSharpBinderFlags
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 15489, 15523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_15570_15592(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 15570, 15592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_15642_15686(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TypeofDynamicOperationContextType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 15642, 15686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_15743_15841(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver)
                {
                    var return_v = this_param.MakeCallSiteArgumentInfos(argumentInfoFactory, loweredArguments, loweredReceiver: loweredReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 15743, 15841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10537_15335_15857(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                factoryMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.MakeBinderConstruction(factoryMethod, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 15335, 15857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_15888_16029(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                binderConstruction, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicOperation(binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 15888, 16029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 14643, 16041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 14643, 16041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LoweredDynamicOperation MakeDynamicSetMember(
                    BoundExpression loweredReceiver,
                    string name,
                    BoundExpression loweredRight,
                    bool isCompoundAssignment = false,
                    bool isChecked = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 16053, 17703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 16332, 16373);

                _factory.Syntax = loweredReceiver.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 16389, 16423);

                CSharpBinderFlags
                binderFlags = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 16437, 16713) || true) && (isCompoundAssignment)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 16437, 16713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 16495, 16556);

                    binderFlags |= CSharpBinderFlags.ValueFromCompoundAssignment;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 16576, 16698) || true) && (isChecked)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 16576, 16698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 16631, 16679);

                        binderFlags |= CSharpBinderFlags.CheckedContext;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 16576, 16698);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 16437, 16713);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 16729, 16790);

                var
                loweredArguments = ImmutableArray<BoundExpression>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 16806, 16866);

                MethodSymbol
                argumentInfoFactory = f_10537_16841_16865(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 16880, 17503);

                var
                binderConstruction = (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 16905, 16942) || ((((object)argumentInfoFactory != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 16945, 17495)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 17498, 17502))) ? f_10537_16945_17495(this, WellKnownMember.Microsoft_CSharp_RuntimeBinder_Binder__SetMember, new[]
                            {
f_10537_17099_17133(                // flags:
                _factory, binderFlags),
f_10537_17180_17202(
                // name:
                _factory, name),
f_10537_17252_17296(
                // context:
                _factory),
f_10537_17353_17479(this, argumentInfoFactory, loweredArguments, loweredReceiver: loweredReceiver, loweredRight: loweredRight)            }) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 17519, 17692);

                return f_10537_17526_17691(this, binderConstruction, loweredReceiver, RefKind.None, loweredArguments, default(ImmutableArray<RefKind>), loweredRight, f_10537_17664_17690());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 16053, 17703);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_16841_16865(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param)
                {
                    var return_v = this_param.GetArgumentInfoFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 16841, 16865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_17099_17133(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory.CSharpBinderFlags
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 17099, 17133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_17180_17202(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 17180, 17202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_17252_17296(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TypeofDynamicOperationContextType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 17252, 17296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_17353_17479(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredRight)
                {
                    var return_v = this_param.MakeCallSiteArgumentInfos(argumentInfoFactory, loweredArguments, loweredReceiver: loweredReceiver, loweredRight: loweredRight);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 17353, 17479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10537_16945_17495(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                factoryMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.MakeBinderConstruction(factoryMethod, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 16945, 17495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10537_17664_17690()
                {
                    var return_v = AssemblySymbol.DynamicType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 17664, 17690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_17526_17691(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                binderConstruction, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicOperation(binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 17526, 17691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 16053, 17703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 16053, 17703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LoweredDynamicOperation MakeDynamicGetIndex(
                    BoundExpression loweredReceiver,
                    ImmutableArray<BoundExpression> loweredArguments,
                    ImmutableArray<string> argumentNames,
                    ImmutableArray<RefKind> refKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 17715, 18913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 18000, 18041);

                _factory.Syntax = loweredReceiver.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 18057, 18101);

                var
                resultType = DynamicTypeSymbol.Instance
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 18117, 18177);

                MethodSymbol
                argumentInfoFactory = f_10537_18152_18176(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 18191, 18761);

                var
                binderConstruction = (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 18216, 18253) || ((((object)argumentInfoFactory != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 18256, 18753)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 18756, 18760))) ? f_10537_18256_18753(this, WellKnownMember.Microsoft_CSharp_RuntimeBinder_Binder__GetIndex, new[]
                            {
f_10537_18418_18463(                // flags (unused):
                _factory, CSharpBinderFlags.None),
f_10537_18513_18557(
                // context:
                _factory),
f_10537_18614_18737(this, argumentInfoFactory, loweredArguments, argumentNames, refKinds, loweredReceiver: loweredReceiver)            }) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 18777, 18902);

                return f_10537_18784_18901(this, binderConstruction, loweredReceiver, RefKind.None, loweredArguments, refKinds, null, resultType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 17715, 18913);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_18152_18176(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param)
                {
                    var return_v = this_param.GetArgumentInfoFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 18152, 18176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_18418_18463(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory.CSharpBinderFlags
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 18418, 18463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_18513_18557(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TypeofDynamicOperationContextType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 18513, 18557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_18614_18737(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver)
                {
                    var return_v = this_param.MakeCallSiteArgumentInfos(argumentInfoFactory, loweredArguments, argumentNames, refKinds, loweredReceiver: loweredReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 18614, 18737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10537_18256_18753(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                factoryMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.MakeBinderConstruction(factoryMethod, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 18256, 18753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_18784_18901(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                binderConstruction, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicOperation(binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 18784, 18901);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 17715, 18913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 17715, 18913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LoweredDynamicOperation MakeDynamicSetIndex(
                    BoundExpression loweredReceiver,
                    ImmutableArray<BoundExpression> loweredArguments,
                    ImmutableArray<string> argumentNames,
                    ImmutableArray<RefKind> refKinds,
                    BoundExpression loweredRight,
                    bool isCompoundAssignment = false,
                    bool isChecked = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 18925, 20655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 19338, 19372);

                CSharpBinderFlags
                binderFlags = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 19386, 19662) || true) && (isCompoundAssignment)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 19386, 19662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 19444, 19505);

                    binderFlags |= CSharpBinderFlags.ValueFromCompoundAssignment;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 19525, 19647) || true) && (isChecked)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 19525, 19647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 19580, 19628);

                        binderFlags |= CSharpBinderFlags.CheckedContext;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 19525, 19647);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 19386, 19662);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 19678, 19743);

                var
                loweredReceiverRefKind = f_10537_19707_19742(loweredReceiver)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 19757, 19801);

                var
                resultType = DynamicTypeSymbol.Instance
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 19817, 19877);

                MethodSymbol
                argumentInfoFactory = f_10537_19852_19876(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 19891, 20485);

                var
                binderConstruction = (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 19916, 19953) || ((((object)argumentInfoFactory != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 19956, 20477)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 20480, 20484))) ? f_10537_19956_20477(this, WellKnownMember.Microsoft_CSharp_RuntimeBinder_Binder__SetIndex, new[]
                            {
f_10537_20118_20152(                // flags (unused):
                _factory, binderFlags),
f_10537_20202_20246(
                // context:
                _factory),
f_10537_20303_20461(this, argumentInfoFactory, loweredArguments, argumentNames, refKinds, loweredReceiver, loweredReceiverRefKind, loweredRight: loweredRight)            }) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 20501, 20644);

                return f_10537_20508_20643(this, binderConstruction, loweredReceiver, loweredReceiverRefKind, loweredArguments, refKinds, loweredRight, resultType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 18925, 20655);

                Microsoft.CodeAnalysis.RefKind
                f_10537_19707_19742(Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver)
                {
                    var return_v = GetReceiverRefKind(loweredReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 19707, 19742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_19852_19876(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param)
                {
                    var return_v = this_param.GetArgumentInfoFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 19852, 19876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_20118_20152(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory.CSharpBinderFlags
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 20118, 20152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_20202_20246(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TypeofDynamicOperationContextType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 20202, 20246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_20303_20461(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredRight)
                {
                    var return_v = this_param.MakeCallSiteArgumentInfos(argumentInfoFactory, loweredArguments, argumentNames, refKinds, loweredReceiver, receiverRefKind, loweredRight: loweredRight);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 20303, 20461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10537_19956_20477(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                factoryMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.MakeBinderConstruction(factoryMethod, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 19956, 20477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_20508_20643(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                binderConstruction, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicOperation(binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 20508, 20643);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 18925, 20655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 18925, 20655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LoweredDynamicOperation MakeDynamicIsEventTest(string name, BoundExpression loweredReceiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 20667, 21522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 20793, 20834);

                _factory.Syntax = loweredReceiver.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 20848, 20914);

                var
                resultType = f_10537_20865_20913(_factory, SpecialType.System_Boolean)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 20928, 21325);

                var
                binderConstruction = f_10537_20953_21324(this, WellKnownMember.Microsoft_CSharp_RuntimeBinder_Binder__IsEvent, new[]
                            {
f_10537_21114_21138(                // flags (unused):
                _factory, 0),
f_10537_21192_21214(
                // member name:
                _factory, name),
f_10537_21264_21308(
                // context:
                _factory)            })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 21341, 21511);

                return f_10537_21348_21510(this, binderConstruction, loweredReceiver, RefKind.None, ImmutableArray<BoundExpression>.Empty, default(ImmutableArray<RefKind>), null, resultType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 20667, 21522);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_20865_20913(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 20865, 20913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_21114_21138(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 21114, 21138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_21192_21214(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 21192, 21214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_21264_21308(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TypeofDynamicOperationContextType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 21264, 21308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10537_20953_21324(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                factoryMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.MakeBinderConstruction(factoryMethod, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 20953, 21324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_21348_21510(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                binderConstruction, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicOperation(binderConstruction, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 21348, 21510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 20667, 21522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 20667, 21522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodSymbol GetArgumentInfoFactory()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 21534, 21722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 21604, 21711);

                return f_10537_21611_21710(_factory, WellKnownMember.Microsoft_CSharp_RuntimeBinder_CSharpArgumentInfo__Create);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 21534, 21722);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_21611_21710(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 21611, 21710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 21534, 21722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 21534, 21722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression? MakeBinderConstruction(WellKnownMember factoryMethod, BoundExpression[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 21734, 22130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 21861, 21921);

                var
                binderFactory = f_10537_21881_21920(_factory, factoryMethod)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 21935, 22021) || true) && (binderFactory is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 21935, 22021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 21994, 22006);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 21935, 22021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 22037, 22119);

                return f_10537_22044_22118(_factory, null, binderFactory, f_10537_22093_22117(args));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 21734, 22130);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10537_21881_21920(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMember(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 21881, 21920);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10537_22093_22117(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 22093, 22117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10537_22044_22118(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.Call(receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 22044, 22118);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 21734, 22130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 21734, 22130);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RefKind GetReceiverRefKind(BoundExpression loweredReceiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10537, 22522, 23562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 22622, 22664);

                f_10537_22622_22663(f_10537_22635_22655(loweredReceiver) is { });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 22678, 22784) || true) && (f_10537_22682_22715_M(!f_10537_22683_22703(loweredReceiver).IsValueType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 22678, 22784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 22749, 22769);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 22678, 22784);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 22800, 23515);

                switch (f_10537_22808_22828(loweredReceiver))
                {

                    case BoundKind.Local:
                    case BoundKind.Parameter:
                    case BoundKind.ArrayAccess:
                    case BoundKind.ThisReference:
                    case BoundKind.PointerIndirectionOperator:
                    case BoundKind.PointerElementAccess:
                    case BoundKind.RefValueOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 22800, 23515);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 23204, 23223);

                        return RefKind.Ref;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 22800, 23515);

                    case BoundKind.BaseReference:
                    // base dynamic dispatch is not supported, an error has already been reported
                    case BoundKind.TypeExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 22800, 23515);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 23437, 23500);

                        throw f_10537_23443_23499(f_10537_23478_23498(loweredReceiver));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 22800, 23515);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 23531, 23551);

                return RefKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10537, 22522, 23562);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10537_22635_22655(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 22635, 22655);
                    return return_v;
                }


                int
                f_10537_22622_22663(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 22622, 22663);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10537_22683_22703(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 22683, 22703);
                    return return_v;
                }


                bool
                f_10537_22682_22715_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 22682, 22715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10537_22808_22828(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 22808, 22828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10537_23478_23498(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 23478, 23498);
                    return return_v;
                }


                System.Exception
                f_10537_23443_23499(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 23443, 23499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 22522, 23562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 22522, 23562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression MakeCallSiteArgumentInfos(
                    MethodSymbol argumentInfoFactory,
                    ImmutableArray<BoundExpression> loweredArguments,
                    ImmutableArray<string> argumentNames = default(ImmutableArray<string>),
                    ImmutableArray<RefKind> refKinds = default(ImmutableArray<RefKind>),
                    BoundExpression? loweredReceiver = null,
                    RefKind receiverRefKind = RefKind.None,
                    bool receiverIsStaticType = false,
                    BoundExpression? loweredRight = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 23574, 25530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 24133, 24161);

                const string?
                NoName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 24175, 24271);

                f_10537_24175_24270(argumentNames.IsDefaultOrEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10537, 24188, 24269) || loweredArguments.Length == argumentNames.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 24285, 24364);

                f_10537_24285_24363(refKinds.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10537, 24298, 24362) || loweredArguments.Length == refKinds.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 24378, 24449);

                f_10537_24378_24448(!receiverIsStaticType || (DynAbs.Tracing.TraceSender.Expression_False(10537, 24391, 24447) || receiverRefKind == RefKind.None));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 24465, 24591);

                var
                infos = new BoundExpression[((DynAbs.Tracing.TraceSender.Conditional_F1(10537, 24498, 24521) || ((loweredReceiver != null && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 24524, 24525)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 24528, 24529))) ? 1 : 0) + loweredArguments.Length + ((DynAbs.Tracing.TraceSender.Conditional_F1(10537, 24560, 24580) || ((loweredRight != null && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 24583, 24584)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 24587, 24588))) ? 1 : 0)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 24605, 24615);

                int
                j = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 24629, 24819) || true) && (loweredReceiver != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 24629, 24819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 24690, 24804);

                    infos[j++] = f_10537_24703_24803(this, argumentInfoFactory, loweredReceiver, NoName, receiverRefKind, receiverIsStaticType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 24629, 24819);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 24844, 24849);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 24835, 25235) || true) && (i < loweredArguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 24880, 24883)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 24835, 25235))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 24835, 25235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 24917, 25220);

                        infos[j++] = f_10537_24930_25219(this, argumentInfoFactory, loweredArguments[i], (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 25048, 25078) || ((argumentNames.IsDefaultOrEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 25081, 25087)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 25090, 25106))) ? NoName : argumentNames[i], (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 25129, 25147) || ((refKinds.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 25150, 25162)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 25165, 25176))) ? RefKind.None : refKinds[i], isStaticType: false);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10537, 1, 401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10537, 1, 401);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 25251, 25431) || true) && (loweredRight != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 25251, 25431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 25309, 25416);

                    infos[j++] = f_10537_25322_25415(this, argumentInfoFactory, loweredRight, NoName, RefKind.None, isStaticType: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 25251, 25431);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 25447, 25519);

                return f_10537_25454_25518(_factory, f_10537_25476_25510(argumentInfoFactory), infos);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 23574, 25530);

                int
                f_10537_24175_24270(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 24175, 24270);
                    return 0;
                }


                int
                f_10537_24285_24363(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 24285, 24363);
                    return 0;
                }


                int
                f_10537_24378_24448(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 24378, 24448);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_24703_24803(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundArgument, string?
                name, Microsoft.CodeAnalysis.RefKind
                refKind, bool
                isStaticType)
                {
                    var return_v = this_param.GetArgumentInfo(argumentInfoFactory, boundArgument, name, refKind, isStaticType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 24703, 24803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_24930_25219(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundArgument, string?
                name, Microsoft.CodeAnalysis.RefKind
                refKind, bool
                isStaticType)
                {
                    var return_v = this_param.GetArgumentInfo(argumentInfoFactory, boundArgument, name, refKind, isStaticType: isStaticType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 24930, 25219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_25322_25415(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                argumentInfoFactory, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundArgument, string?
                name, Microsoft.CodeAnalysis.RefKind
                refKind, bool
                isStaticType)
                {
                    var return_v = this_param.GetArgumentInfo(argumentInfoFactory, boundArgument, name, refKind, isStaticType: isStaticType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 25322, 25415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_25476_25510(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 25476, 25510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_25454_25518(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                elementType, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                elements)
                {
                    var return_v = this_param.ArrayOrEmpty((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 25454, 25518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 23574, 25530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 23574, 25530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LoweredDynamicOperation MakeDynamicOperation(
                    BoundExpression? binderConstruction,
                    BoundExpression? loweredReceiver,
                    RefKind receiverRefKind,
                    ImmutableArray<BoundExpression> loweredArguments,
                    ImmutableArray<RefKind> refKinds,
                    BoundExpression? loweredRight,
                    TypeSymbol resultType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 25542, 29623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 25946, 25988);

                f_10537_25946_25987(f_10537_25959_25986_M(!loweredArguments.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 26062, 26222);

                NamedTypeSymbol?
                delegateTypeOverMethodTypeParameters = f_10537_26118_26221(this, loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, resultType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 26236, 26355);

                NamedTypeSymbol
                callSiteTypeGeneric = f_10537_26274_26354(_factory, WellKnownType.System_Runtime_CompilerServices_CallSite_T)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 26369, 26500);

                MethodSymbol
                callSiteFactoryGeneric = f_10537_26407_26499(_factory, WellKnownMember.System_Runtime_CompilerServices_CallSite_T__Create)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 26514, 26661);

                FieldSymbol
                callSiteTargetFieldGeneric = (FieldSymbol)f_10537_26568_26660(_factory, WellKnownMember.System_Runtime_CompilerServices_CallSite_T__Target)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 26675, 26703);

                MethodSymbol
                delegateInvoke
                = default(MethodSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 26719, 27742) || true) && (binderConstruction == null || (DynAbs.Tracing.TraceSender.Expression_False(10537, 26723, 26814) || delegateTypeOverMethodTypeParameters is null) || (DynAbs.Tracing.TraceSender.Expression_False(10537, 26723, 26885) || f_10537_26835_26885(delegateTypeOverMethodTypeParameters)) || (DynAbs.Tracing.TraceSender.Expression_False(10537, 26723, 26990) || (delegateInvoke = f_10537_26924_26981(delegateTypeOverMethodTypeParameters)) is null) || (DynAbs.Tracing.TraceSender.Expression_False(10537, 26723, 27044) || f_10537_27011_27044(callSiteTypeGeneric)) || (DynAbs.Tracing.TraceSender.Expression_False(10537, 26723, 27095) || callSiteFactoryGeneric is null) || (DynAbs.Tracing.TraceSender.Expression_False(10537, 26723, 27150) || callSiteTargetFieldGeneric is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 26719, 27742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 27521, 27611);

                    f_10537_27521_27610(f_10537_27521_27541(_factory), ErrorCode.ERR_DynamicRequiredTypesMissing, NoLocation.Singleton);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 27631, 27727);

                    return LoweredDynamicOperation.Bad(loweredReceiver, loweredArguments, loweredRight, resultType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 26719, 27742);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 27758, 27959) || true) && (_currentDynamicCallSiteContainer is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 27758, 27959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 27836, 27944);

                    _currentDynamicCallSiteContainer = f_10537_27871_27943(_factory, _methodOrdinal, _localFunctionOrdinal);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 27758, 27959);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 27975, 28068);

                var
                containerDef = (SynthesizedContainer)f_10537_28016_28067(_currentDynamicCallSiteContainer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 28082, 28144);

                var
                methodToContainerTypeParametersMap = f_10537_28123_28143(containerDef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 28160, 28247);

                ImmutableArray<LocalSymbol>
                temps = f_10537_28196_28246(this, ref loweredArguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 28263, 28360);

                var
                callSiteType = f_10537_28282_28359(callSiteTypeGeneric, new[] { delegateTypeOverMethodTypeParameters })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 28374, 28448);

                var
                callSiteFactoryMethod = f_10537_28402_28447(callSiteFactoryGeneric, callSiteType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 28462, 28538);

                var
                callSiteTargetField = f_10537_28488_28537(callSiteTargetFieldGeneric, callSiteType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 28552, 28688);

                var
                callSiteField = f_10537_28572_28687(this, containerDef, delegateTypeOverMethodTypeParameters, methodToContainerTypeParametersMap)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 28702, 28764);

                var
                callSiteFieldAccess = f_10537_28728_28763(_factory, null, callSiteField)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 28778, 28893);

                var
                callSiteArguments = f_10537_28802_28892(callSiteFieldAccess, loweredReceiver, loweredArguments, loweredRight)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 28909, 28962);

                var
                nullCallSite = f_10537_28928_28961(_factory, f_10537_28942_28960(callSiteField))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 28978, 29300);

                var
                siteInitialization = f_10537_29003_29299(_factory, f_10537_29042_29097(_factory, callSiteFieldAccess, nullCallSite), f_10537_29116_29230(_factory, callSiteFieldAccess, f_10537_29167_29229(_factory, null, callSiteFactoryMethod, binderConstruction)), nullCallSite, f_10537_29280_29298(callSiteField))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 29316, 29496);

                var
                siteInvocation = f_10537_29337_29495(_factory, f_10537_29369_29425(_factory, callSiteFieldAccess, callSiteTargetField), delegateInvoke, callSiteArguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 29512, 29612);

                return f_10537_29519_29611(_factory, siteInitialization, siteInvocation, resultType, temps);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 25542, 29623);

                bool
                f_10537_25959_25986_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 25959, 25986);
                    return return_v;
                }


                int
                f_10537_25946_25987(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 25946, 25987);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10537_26118_26221(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredReceiver, Microsoft.CodeAnalysis.RefKind
                receiverRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.GetDelegateType(loweredReceiver, receiverRefKind, loweredArguments, refKinds, loweredRight, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 26118, 26221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_26274_26354(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 26274, 26354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_26407_26499(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 26407, 26499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10537_26568_26660(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMember(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 26568, 26660);
                    return return_v;
                }


                bool
                f_10537_26835_26885(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 26835, 26885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_26924_26981(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 26924, 26981);
                    return return_v;
                }


                bool
                f_10537_27011_27044(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 27011, 27044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10537_27521_27541(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 27521, 27541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10537_27521_27610(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 27521, 27610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_27871_27943(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory, int
                methodOrdinal, int
                localFunctionOrdinal)
                {
                    var return_v = CreateCallSiteContainer(factory, methodOrdinal, localFunctionOrdinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 27871, 27943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_28016_28067(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 28016, 28067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10537_28123_28143(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param)
                {
                    var return_v = this_param.TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 28123, 28143);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10537_28196_28246(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments)
                {
                    var return_v = this_param.MakeTempsForDiscardArguments(ref loweredArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 28196, 28246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_28282_28359(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[])typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 28282, 28359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_28402_28447(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 28402, 28447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10537_28488_28537(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 28488, 28537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10537_28572_28687(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                containerDefinition, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateTypeOverMethodTypeParameters, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                methodToContainerTypeParametersMap)
                {
                    var return_v = this_param.DefineCallSiteStorageSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containerDefinition, delegateTypeOverMethodTypeParameters, methodToContainerTypeParametersMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 28572, 28687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10537_28728_28763(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field(receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 28728, 28763);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10537_28802_28892(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                callSiteFieldAccess, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                right)
                {
                    var return_v = GetCallSiteArguments((Microsoft.CodeAnalysis.CSharp.BoundExpression)callSiteFieldAccess, receiver, arguments, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 28802, 28892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10537_28942_28960(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 28942, 28960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_28928_28961(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Null(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 28928, 28961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10537_29042_29097(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.ObjectEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 29042, 29097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10537_29167_29229(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg0)
                {
                    var return_v = this_param.Call(receiver, method, arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 29167, 29229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10537_29116_29230(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundCall
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 29116, 29230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10537_29280_29298(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 29280, 29298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10537_29003_29299(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                condition, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                consequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                alternative, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Conditional((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, (Microsoft.CodeAnalysis.CSharp.BoundExpression)consequence, alternative, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 29003, 29299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10537_29369_29425(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 29369, 29425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10537_29337_29495(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 29337, 29495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10537_29519_29611(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory, Microsoft.CodeAnalysis.CSharp.BoundExpression
                siteInitialization, Microsoft.CodeAnalysis.CSharp.BoundCall
                siteInvocation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation(factory, siteInitialization, (Microsoft.CodeAnalysis.CSharp.BoundExpression)siteInvocation, resultType, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 29519, 29611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 25542, 29623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 25542, 29623);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<LocalSymbol> MakeTempsForDiscardArguments(ref ImmutableArray<BoundExpression> loweredArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 29892, 30544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 30035, 30121);

                int
                discardCount = loweredArguments.Count(a => a.Kind == BoundKind.DiscardExpression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 30137, 30248) || true) && (discardCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 30137, 30248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 30192, 30233);

                    return ImmutableArray<LocalSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 30137, 30248);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 30264, 30363);

                ArrayBuilder<LocalSymbol>
                temporariesBuilder = f_10537_30311_30362(discardCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 30377, 30472);

                loweredArguments = f_10537_30396_30471(_factory, loweredArguments, temporariesBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 30486, 30533);

                return f_10537_30493_30532(temporariesBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 29892, 30544);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10537_30311_30362(int
                capacity)
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 30311, 30362);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10537_30396_30471(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder)
                {
                    var return_v = this_param.MakeTempsForDiscardArguments(arguments, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 30396, 30471);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10537_30493_30532(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 30493, 30532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 29892, 30544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 29892, 30544);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static NamedTypeSymbol CreateCallSiteContainer(SyntheticBoundNodeFactory factory, int methodOrdinal, int localFunctionOrdinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10537, 30556, 31713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 30715, 30778);

                f_10537_30715_30777(f_10537_30728_30752(factory).ModuleBuilderOpt is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 30792, 30836);

                f_10537_30792_30835(f_10537_30805_30827(factory) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 30850, 30895);

                f_10537_30850_30894(f_10537_30863_30886(factory) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 31010, 31094);

                int
                generation = f_10537_31027_31093(f_10537_31027_31051(factory).ModuleBuilderOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 31108, 31225);

                var
                containerName = f_10537_31128_31224(methodOrdinal, localFunctionOrdinal, generation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 31241, 31357);

                var
                synthesizedContainer = f_10537_31268_31356(containerName, f_10537_31308_31330(factory), f_10537_31332_31355(factory))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 31371, 31415);

                f_10537_31371_31414(factory, synthesizedContainer);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 31431, 31658) || true) && (f_10537_31435_31479_M(!synthesizedContainer.TypeParameters.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 31431, 31658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 31513, 31643);

                    return f_10537_31520_31642(synthesizedContainer, synthesizedContainer.ConstructedFromTypeParameters.Cast<TypeParameterSymbol, TypeSymbol>());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 31431, 31658);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 31674, 31702);

                return synthesizedContainer;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10537, 30556, 31713);

                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10537_30728_30752(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 30728, 30752);
                    return return_v;
                }


                int
                f_10537_30715_30777(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 30715, 30777);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10537_30805_30827(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TopLevelMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 30805, 30827);
                    return return_v;
                }


                int
                f_10537_30792_30835(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 30792, 30835);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10537_30863_30886(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 30863, 30886);
                    return return_v;
                }


                int
                f_10537_30850_30894(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 30850, 30894);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10537_31027_31051(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 31027, 31051);
                    return return_v;
                }


                int
                f_10537_31027_31093(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CurrentGenerationOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 31027, 31093);
                    return return_v;
                }


                string
                f_10537_31128_31224(int
                methodOrdinal, int
                localFunctionOrdinal, int
                generation)
                {
                    var return_v = GeneratedNames.MakeDynamicCallSiteContainerName(methodOrdinal, localFunctionOrdinal, generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 31128, 31224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_31308_31330(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.TopLevelMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 31308, 31330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10537_31332_31355(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 31332, 31355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DynamicSiteContainer
                f_10537_31268_31356(string
                name, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicSiteContainer(name, topLevelMethod, containingMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 31268, 31356);
                    return return_v;
                }


                int
                f_10537_31371_31414(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.DynamicSiteContainer
                nestedType)
                {
                    this_param.AddNestedType((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)nestedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 31371, 31414);
                    return 0;
                }


                bool
                f_10537_31435_31479_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 31435, 31479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_31520_31642(Microsoft.CodeAnalysis.CSharp.DynamicSiteContainer
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 31520, 31642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 30556, 31713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 30556, 31713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FieldSymbol DefineCallSiteStorageSymbol(NamedTypeSymbol containerDefinition, NamedTypeSymbol delegateTypeOverMethodTypeParameters, TypeMap methodToContainerTypeParametersMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 31725, 32757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 31933, 32017);

                var
                fieldName = f_10537_31949_32016(_callSiteIdDispenser++)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 32031, 32170);

                var
                delegateTypeOverContainerTypeParameters = f_10537_32077_32169(methodToContainerTypeParametersMap, delegateTypeOverMethodTypeParameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 32184, 32360);

                var
                callSiteType = f_10537_32203_32359(f_10537_32203_32298(f_10537_32203_32223(_factory), WellKnownType.System_Runtime_CompilerServices_CallSite_T), new[] { delegateTypeOverContainerTypeParameters })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 32374, 32491);

                var
                field = f_10537_32386_32490(containerDefinition, callSiteType, fieldName, isPublic: true, isStatic: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 32505, 32551);

                f_10537_32505_32550(_factory, containerDefinition, field);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 32565, 32619);

                f_10537_32565_32618(_currentDynamicCallSiteContainer is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 32633, 32746);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 32640, 32686) || ((f_10537_32640_32686(_currentDynamicCallSiteContainer) && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 32689, 32737)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 32740, 32745))) ? f_10537_32689_32737(field, _currentDynamicCallSiteContainer) : field;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 31725, 32757);

                string
                f_10537_31949_32016(int
                uniqueId)
                {
                    var return_v = GeneratedNames.MakeDynamicCallSiteFieldName(uniqueId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 31949, 32016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_32077_32169(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 32077, 32169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10537_32203_32223(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 32203, 32223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_32203_32298(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 32203, 32298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_32203_32359(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[])typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 32203, 32359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
                f_10537_32386_32490(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, bool
                isPublic, bool
                isStatic)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol(containingType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, isPublic: isPublic, isStatic: isStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 32386, 32490);
                    return return_v;
                }


                int
                f_10537_32505_32550(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
                field)
                {
                    this_param.AddField(containingType, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 32505, 32550);
                    return 0;
                }


                int
                f_10537_32565_32618(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 32565, 32618);
                    return 0;
                }


                bool
                f_10537_32640_32686(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 32640, 32686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10537_32689_32737(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 32689, 32737);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 31725, 32757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 31725, 32757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol? GetDelegateType(
                    BoundExpression? loweredReceiver,
                    RefKind receiverRefKind,
                    ImmutableArray<BoundExpression> loweredArguments,
                    ImmutableArray<RefKind> refKinds,
                    BoundExpression? loweredRight,
                    TypeSymbol resultType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 32769, 35777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 33111, 33197);

                f_10537_33111_33196(refKinds.IsDefaultOrEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10537, 33124, 33195) || refKinds.Length == loweredArguments.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 33213, 33311);

                var
                callSiteType = f_10537_33232_33310(_factory, WellKnownType.System_Runtime_CompilerServices_CallSite)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 33325, 33416) || true) && (f_10537_33329_33355(callSiteType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 33325, 33416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 33389, 33401);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 33325, 33416);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 33432, 33561);

                var
                delegateSignature = f_10537_33456_33560(this, callSiteType, loweredReceiver, loweredArguments, loweredRight, resultType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 33575, 33618);

                bool
                returnsVoid = f_10537_33594_33617(resultType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 33632, 33711);

                bool
                hasByRefs = receiverRefKind != RefKind.None || (DynAbs.Tracing.TraceSender.Expression_False(10537, 33649, 33710) || f_10537_33684_33710_M(!refKinds.IsDefaultOrEmpty))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 33727, 34427) || true) && (!hasByRefs)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 33727, 34427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 33775, 34038);

                    var
                    wkDelegateType = (DynAbs.Tracing.TraceSender.Conditional_F1(10537, 33796, 33807) || ((returnsVoid && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 33831, 33919)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 33943, 34037))) ? f_10537_33831_33919(invokeArgumentCount: f_10537_33894_33918(delegateSignature)) : f_10537_33943_34037(invokeArgumentCount: f_10537_34008_34032(delegateSignature) - 1)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34058, 34412) || true) && (wkDelegateType != WellKnownType.Unknown)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 34058, 34412);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34143, 34216);

                        var
                        delegateType = f_10537_34162_34215(f_10537_34162_34182(_factory), wkDelegateType)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34238, 34393) || true) && (f_10537_34242_34271_M(!delegateType.HasUseSiteError))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 34238, 34393);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34321, 34370);

                            return f_10537_34328_34369(delegateType, delegateSignature);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 34238, 34393);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 34058, 34412);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 33727, 34427);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34443, 34460);

                BitVector
                byRefs
                = default(BitVector);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34474, 35291) || true) && (hasByRefs)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 34474, 35291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34521, 34645);

                    byRefs = BitVector.Create(1 + ((DynAbs.Tracing.TraceSender.Conditional_F1(10537, 34552, 34575) || ((loweredReceiver != null && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 34578, 34579)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 34582, 34583))) ? 1 : 0) + loweredArguments.Length + ((DynAbs.Tracing.TraceSender.Conditional_F1(10537, 34614, 34634) || ((loweredRight != null && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 34637, 34638)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 34641, 34642))) ? 1 : 0));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34665, 34675);

                    int
                    j = 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34693, 34827) || true) && (loweredReceiver != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 34693, 34827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34762, 34808);

                        byRefs[j++] = receiverRefKind != RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 34693, 34827);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34847, 35182) || true) && (f_10537_34851_34870_M(!refKinds.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 34847, 35182);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34921, 34926);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34912, 35163) || true) && (i < refKinds.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34949, 34952)
        , i++, DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 34954, 34957)
        , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 34912, 35163))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 34912, 35163);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 35007, 35140) || true) && (refKinds[i] != RefKind.None)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 35007, 35140);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 35096, 35113);

                                    byRefs[j] = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 35007, 35140);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10537, 1, 252);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10537, 1, 252);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 34847, 35182);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 34474, 35291);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 34474, 35291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 35248, 35276);

                    byRefs = default(BitVector);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 34474, 35291);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 35307, 35377);

                int
                parameterCount = f_10537_35328_35352(delegateSignature) - ((DynAbs.Tracing.TraceSender.Conditional_F1(10537, 35356, 35367) || ((returnsVoid && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 35370, 35371)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 35374, 35375))) ? 0 : 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 35391, 35455);

                f_10537_35391_35454(f_10537_35404_35429(_factory).ModuleBuilderOpt is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 35469, 35554);

                int
                generation = f_10537_35486_35553(f_10537_35486_35511(_factory).ModuleBuilderOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 35568, 35700);

                var
                synthesizedType = f_10537_35590_35699(f_10537_35590_35631(f_10537_35590_35610(_factory)), parameterCount, byRefs, returnsVoid, generation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 35714, 35766);

                return f_10537_35721_35765(synthesizedType, delegateSignature);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 32769, 35777);

                int
                f_10537_33111_33196(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 33111, 33196);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_33232_33310(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 33232, 33310);
                    return return_v;
                }


                bool
                f_10537_33329_33355(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 33329, 33355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                f_10537_33456_33560(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                callSiteType, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeCallSiteDelegateSignature((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)callSiteType, receiver, arguments, right, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 33456, 33560);
                    return return_v;
                }


                bool
                f_10537_33594_33617(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 33594, 33617);
                    return return_v;
                }


                bool
                f_10537_33684_33710_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 33684, 33710);
                    return return_v;
                }


                int
                f_10537_33894_33918(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 33894, 33918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownType
                f_10537_33831_33919(int
                invokeArgumentCount)
                {
                    var return_v = WellKnownTypes.GetWellKnownActionDelegate(invokeArgumentCount: invokeArgumentCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 33831, 33919);
                    return return_v;
                }


                int
                f_10537_34008_34032(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 34008, 34032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownType
                f_10537_33943_34037(int
                invokeArgumentCount)
                {
                    var return_v = WellKnownTypes.GetWellKnownFunctionDelegate(invokeArgumentCount: invokeArgumentCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 33943, 34037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10537_34162_34182(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 34162, 34182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_34162_34215(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 34162, 34215);
                    return return_v;
                }


                bool
                f_10537_34242_34271_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 34242, 34271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_34328_34369(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 34328, 34369);
                    return return_v;
                }


                bool
                f_10537_34851_34870_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 34851, 34870);
                    return return_v;
                }


                int
                f_10537_35328_35352(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 35328, 35352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10537_35404_35429(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 35404, 35429);
                    return return_v;
                }


                int
                f_10537_35391_35454(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 35391, 35454);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10537_35486_35511(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 35486, 35511);
                    return return_v;
                }


                int
                f_10537_35486_35553(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CurrentGenerationOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 35486, 35553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10537_35590_35610(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 35590, 35610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                f_10537_35590_35631(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.AnonymousTypeManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 35590, 35631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol
                f_10537_35590_35699(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, int
                parameterCount, Microsoft.CodeAnalysis.BitVector
                byRefParameters, bool
                returnsVoid, int
                generation)
                {
                    var return_v = this_param.SynthesizeDelegate(parameterCount, byRefParameters, returnsVoid, generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 35590, 35699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_35721_35765(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 35721, 35765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 32769, 35777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 32769, 35777);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression GetArgumentInfo(
                    MethodSymbol argumentInfoFactory,
                    BoundExpression boundArgument,
                    string? name,
                    RefKind refKind,
                    bool isStaticType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 35789, 39274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 36035, 36069);

                CSharpArgumentInfoFlags
                flags = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 36085, 36196) || true) && (isStaticType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 36085, 36196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 36135, 36181);

                    flags |= CSharpArgumentInfoFlags.IsStaticType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 36085, 36196);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 36212, 36324) || true) && (name != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 36212, 36324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 36262, 36309);

                    flags |= CSharpArgumentInfoFlags.NamedArgument;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 36212, 36324);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 36340, 36463);

                f_10537_36340_36462(refKind == RefKind.None || (DynAbs.Tracing.TraceSender.Expression_False(10537, 36353, 36402) || refKind == RefKind.Ref) || (DynAbs.Tracing.TraceSender.Expression_False(10537, 36353, 36428) || refKind == RefKind.Out), "unexpected refKind in dynamic");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 36597, 36934) || true) && (refKind == RefKind.Out)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 36597, 36934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 36657, 36741);

                    flags |= CSharpArgumentInfoFlags.IsOut | CSharpArgumentInfoFlags.UseCompileTimeType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 36597, 36934);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 36597, 36934);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 36775, 36934) || true) && (refKind == RefKind.Ref)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 36775, 36934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 36835, 36919);

                        flags |= CSharpArgumentInfoFlags.IsRef | CSharpArgumentInfoFlags.UseCompileTimeType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 36775, 36934);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 36597, 36934);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 36950, 36983);

                var
                argType = f_10537_36964_36982(boundArgument)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 38745, 38875) || true) && (f_10537_38749_38776(boundArgument) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 38745, 38875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 38818, 38860);

                    flags |= CSharpArgumentInfoFlags.Constant;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 38745, 38875);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 39002, 39145) || true) && (argType is { } && (DynAbs.Tracing.TraceSender.Expression_True(10537, 39006, 39044) && !f_10537_39025_39044(argType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 39002, 39145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 39078, 39130);

                    flags |= CSharpArgumentInfoFlags.UseCompileTimeType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 39002, 39145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 39161, 39263);

                return f_10537_39168_39262(_factory, null, argumentInfoFactory, f_10537_39209_39237(_factory, flags), f_10537_39239_39261(_factory, name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 35789, 39274);

                int
                f_10537_36340_36462(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 36340, 36462);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10537_36964_36982(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 36964, 36982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10537_38749_38776(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 38749, 38776);
                    return return_v;
                }


                bool
                f_10537_39025_39044(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 39025, 39044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_39209_39237(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory.CSharpArgumentInfoFlags
                value)
                {
                    var return_v = this_param.Literal((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 39209, 39237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10537_39239_39261(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string?
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 39239, 39261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10537_39168_39262(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                arg0, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                arg1)
                {
                    var return_v = this_param.Call(receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 39168, 39262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 35789, 39274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 35789, 39274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<BoundExpression> GetCallSiteArguments(BoundExpression callSiteFieldAccess, BoundExpression? receiver, ImmutableArray<BoundExpression> arguments, BoundExpression? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10537, 39286, 40045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 39510, 39620);

                var
                result = new BoundExpression[1 + ((DynAbs.Tracing.TraceSender.Conditional_F1(10537, 39548, 39564) || ((receiver != null && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 39567, 39568)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 39571, 39572))) ? 1 : 0) + arguments.Length + ((DynAbs.Tracing.TraceSender.Conditional_F1(10537, 39596, 39609) || ((right != null && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 39612, 39613)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 39616, 39617))) ? 1 : 0)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 39634, 39644);

                int
                j = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 39660, 39694);

                result[j++] = callSiteFieldAccess;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 39710, 39802) || true) && (receiver != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 39710, 39802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 39764, 39787);

                    result[j++] = receiver;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 39710, 39802);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 39818, 39846);

                arguments.CopyTo(result, j);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 39860, 39882);

                j += arguments.Length;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 39898, 39984) || true) && (right != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 39898, 39984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 39949, 39969);

                    result[j++] = right;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 39898, 39984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 40000, 40034);

                return f_10537_40007_40033(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10537, 39286, 40045);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10537_40007_40033(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 40007, 40033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 39286, 40045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 39286, 40045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeSymbol[] MakeCallSiteDelegateSignature(TypeSymbol callSiteType, BoundExpression? receiver, ImmutableArray<BoundExpression> arguments, BoundExpression? right, TypeSymbol resultType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10537, 40057, 41321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 40275, 40346);

                var
                systemObjectType = f_10537_40298_40345(_factory, SpecialType.System_Object)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 40360, 40501);

                var
                result = new TypeSymbol[1 + ((DynAbs.Tracing.TraceSender.Conditional_F1(10537, 40393, 40409) || ((receiver != null && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 40412, 40413)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 40416, 40417))) ? 1 : 0) + arguments.Length + ((DynAbs.Tracing.TraceSender.Conditional_F1(10537, 40441, 40454) || ((right != null && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 40457, 40458)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 40461, 40462))) ? 1 : 0) + ((DynAbs.Tracing.TraceSender.Conditional_F1(10537, 40467, 40490) || ((f_10537_40467_40490(resultType) && DynAbs.Tracing.TraceSender.Conditional_F2(10537, 40493, 40494)) || DynAbs.Tracing.TraceSender.Conditional_F3(10537, 40497, 40498))) ? 0 : 1)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 40515, 40525);

                int
                j = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 40567, 40594);

                result[j++] = callSiteType;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 40636, 40753) || true) && (receiver != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 40636, 40753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 40690, 40738);

                    result[j++] = f_10537_40704_40717(receiver) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10537, 40704, 40737) ?? systemObjectType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 40636, 40753);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 40810, 40815);

                    // argument types:
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 40801, 40943) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 40839, 40842)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 40801, 40943))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 40801, 40943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 40876, 40928);

                        result[j++] = f_10537_40890_40907(arguments[i]) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10537, 40890, 40927) ?? systemObjectType);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10537, 1, 143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10537, 1, 143);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 41009, 41120) || true) && (right != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 41009, 41120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 41060, 41105);

                    result[j++] = f_10537_41074_41084(right) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10537, 41074, 41104) ?? systemObjectType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 41009, 41120);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 41165, 41280) || true) && (j < f_10537_41173_41186(result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10537, 41165, 41280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 41220, 41265);

                    result[j++] = resultType ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>(10537, 41234, 41264) ?? systemObjectType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10537, 41165, 41280);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10537, 41296, 41310);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10537, 40057, 41321);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10537_40298_40345(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 40298, 40345);
                    return return_v;
                }


                bool
                f_10537_40467_40490(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 40467, 40490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10537_40704_40717(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 40704, 40717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10537_40890_40907(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 40890, 40907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10537_41074_41084(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 41074, 41084);
                    return return_v;
                }


                int
                f_10537_41173_41186(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10537, 41173, 41186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10537, 40057, 41321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 40057, 41321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LoweredDynamicOperationFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10537, 453, 41328);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10537, 453, 41328);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10537, 453, 41328);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10537, 453, 41328);

        int
        f_10537_945_974(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10537, 945, 974);
            return 0;
        }

    }
}
