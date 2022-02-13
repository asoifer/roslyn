// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{

    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal readonly struct TypeWithState
    {

        public readonly TypeSymbol? Type;

        public readonly NullableFlowState State;

        [MemberNotNullWhen(false, nameof(Type))]
        public bool HasNullType
        {
            [MemberNotNullWhen(false, nameof(Type))]
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10177, 744, 759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 747, 759);
                    return Type is null; DynAbs.Tracing.TraceSender.TraceExitMethod(10177, 744, 759);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 744, 759);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 744, 759);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool MayBeNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10177, 792, 831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 795, 831);
                    return State == NullableFlowState.MaybeNull; DynAbs.Tracing.TraceSender.TraceExitMethod(10177, 792, 831);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 792, 831);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 792, 831);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10177, 864, 901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 867, 901);
                    return State == NullableFlowState.NotNull; DynAbs.Tracing.TraceSender.TraceExitMethod(10177, 864, 901);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 864, 901);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 864, 901);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static TypeWithState ForType(TypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10177, 914, 1055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 992, 1044);

                return Create(type, NullableFlowState.MaybeDefault);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10177, 914, 1055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 914, 1055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 914, 1055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeWithState Create(TypeSymbol? type, NullableFlowState defaultState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10177, 1067, 1775);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 1176, 1543) || true) && (defaultState == NullableFlowState.MaybeDefault && (DynAbs.Tracing.TraceSender.Expression_True(10177, 1180, 1317) && (type is null || (DynAbs.Tracing.TraceSender.Expression_False(10177, 1248, 1316) || f_10177_1264_1316(type)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10177, 1176, 1543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 1378, 1465);

                    f_10177_1378_1464(((DynAbs.Tracing.TraceSender.Conditional_F1(10177, 1392, 1407) || ((!(type is null) && DynAbs.Tracing.TraceSender.Conditional_F2(10177, 1410, 1446)) || DynAbs.Tracing.TraceSender.Conditional_F3(10177, 1449, 1454))) ? f_10177_1410_1446(type) : false) != true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 1483, 1528);

                    return f_10177_1490_1527(type, defaultState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10177, 1176, 1543);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 1557, 1712);

                var
                state = (DynAbs.Tracing.TraceSender.Conditional_F1(10177, 1569, 1653) || ((defaultState != NullableFlowState.NotNull && (DynAbs.Tracing.TraceSender.Expression_True(10177, 1569, 1653) && (type is null || (DynAbs.Tracing.TraceSender.Expression_False(10177, 1615, 1652) || f_10177_1631_1652(type)))) && DynAbs.Tracing.TraceSender.Conditional_F2(10177, 1656, 1683)) || DynAbs.Tracing.TraceSender.Conditional_F3(10177, 1686, 1711))) ? NullableFlowState.MaybeNull : NullableFlowState.NotNull
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 1726, 1764);

                return f_10177_1733_1763(type, state);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10177, 1067, 1775);

                bool
                f_10177_1264_1316(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameterDisallowingAnnotationInCSharp8();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 1264, 1316);
                    return return_v;
                }


                bool
                f_10177_1410_1446(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableTypeOrTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 1410, 1446);
                    return return_v;
                }


                int
                f_10177_1378_1464(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 1378, 1464);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                f_10177_1490_1527(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.CSharp.NullableFlowState
                state)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState(type, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 1490, 1527);
                    return return_v;
                }


                bool
                f_10177_1631_1652(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CanContainNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 1631, 1652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                f_10177_1733_1763(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.CSharp.NullableFlowState
                state)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState(type, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 1733, 1763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 1067, 1775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 1067, 1775);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeWithState Create(TypeWithAnnotations typeWithAnnotations, FlowAnalysisAnnotations annotations = FlowAnalysisAnnotations.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10177, 1787, 2843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 1955, 1991);

                var
                type = typeWithAnnotations.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 2005, 2040);

                f_10177_2005_2039((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 2056, 2080);

                NullableFlowState
                state
                = default(NullableFlowState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 2094, 2789) || true) && (f_10177_2098_2119(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10177, 2094, 2789);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 2153, 2674) || true) && ((annotations & FlowAnalysisAnnotations.MaybeNull) == FlowAnalysisAnnotations.MaybeNull)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10177, 2153, 2674);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 2285, 2324);

                        state = NullableFlowState.MaybeDefault;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10177, 2153, 2674);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10177, 2153, 2674);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 2366, 2674) || true) && ((annotations & FlowAnalysisAnnotations.NotNull) == FlowAnalysisAnnotations.NotNull)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10177, 2366, 2674);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 2494, 2528);

                            state = NullableFlowState.NotNull;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10177, 2366, 2674);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10177, 2366, 2674);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 2610, 2655);

                            return typeWithAnnotations.ToTypeWithState();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10177, 2366, 2674);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10177, 2153, 2674);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10177, 2094, 2789);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10177, 2094, 2789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 2740, 2774);

                    state = NullableFlowState.NotNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10177, 2094, 2789);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 2805, 2832);

                return Create(type, state);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10177, 1787, 2843);

                int
                f_10177_2005_2039(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 2005, 2039);
                    return 0;
                }


                bool
                f_10177_2098_2119(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CanContainNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 2098, 2119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 1787, 2843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 1787, 2843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWithState(TypeSymbol? type, NullableFlowState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10177, 2855, 3262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 2944, 3034);

                f_10177_2944_3033(state == NullableFlowState.NotNull || (DynAbs.Tracing.TraceSender.Expression_False(10177, 2957, 3007) || type is null) || (DynAbs.Tracing.TraceSender.Expression_False(10177, 2957, 3032) || f_10177_3011_3032(type)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 3071, 3197);

                f_10177_3071_3196(state != NullableFlowState.MaybeDefault || (DynAbs.Tracing.TraceSender.Expression_False(10177, 3084, 3139) || type is null) || (DynAbs.Tracing.TraceSender.Expression_False(10177, 3084, 3195) || f_10177_3143_3195(type)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 3211, 3223);

                Type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 3237, 3251);

                State = state;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10177, 2855, 3262);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 2855, 3262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 2855, 3262);
            }
        }

        public string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10177, 3274, 3482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 3356, 3413);

                var
                temp = (DynAbs.Tracing.TraceSender.Conditional_F1(10177, 3367, 3379) || ((Type is null && DynAbs.Tracing.TraceSender.Conditional_F2(10177, 3382, 3384)) || DynAbs.Tracing.TraceSender.Conditional_F3(10177, 3387, 3412))) ? "" : f_10177_3387_3412(Type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 3427, 3471);

                return $"{{Type:{temp}, State:{State}{"}"}";
                DynAbs.Tracing.TraceSender.TraceExitMethod(10177, 3274, 3482);

                string
                f_10177_3387_3412(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetDebuggerDisplay();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 3387, 3412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 3274, 3482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 3274, 3482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10177, 3528, 3551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 3531, 3551);
                return GetDebuggerDisplay(); DynAbs.Tracing.TraceSender.TraceExitMethod(10177, 3528, 3551);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 3528, 3551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 3528, 3551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeWithState WithNotNullState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10177, 3604, 3657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 3607, 3657);
                return f_10177_3607_3657(Type, NullableFlowState.NotNull); DynAbs.Tracing.TraceSender.TraceExitMethod(10177, 3604, 3657);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 3604, 3657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 3604, 3657);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
            f_10177_3607_3657(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            type, Microsoft.CodeAnalysis.CSharp.NullableFlowState
            state)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState(type, state);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 3607, 3657);
                return return_v;
            }

        }

        public TypeWithState WithSuppression(bool suppress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10177, 3722, 3793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 3725, 3793);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10177, 3725, 3733) || ((suppress && DynAbs.Tracing.TraceSender.Conditional_F2(10177, 3736, 3786)) || DynAbs.Tracing.TraceSender.Conditional_F3(10177, 3789, 3793))) ? f_10177_3736_3786(Type, NullableFlowState.NotNull) : this; DynAbs.Tracing.TraceSender.TraceExitMethod(10177, 3722, 3793);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 3722, 3793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 3722, 3793);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
            f_10177_3736_3786(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            type, Microsoft.CodeAnalysis.CSharp.NullableFlowState
            state)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState(type, state);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 3736, 3786);
                return return_v;
            }

        }

        public TypeWithAnnotations ToTypeWithAnnotations(CSharpCompilation compilation, bool asAnnotatedType = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10177, 3806, 4712);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 3963, 4272) || true) && (Type is not null && (DynAbs.Tracing.TraceSender.Expression_True(10177, 3967, 4039) && f_10177_3987_4039(Type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10177, 3963, 4272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 4073, 4150);

                    var
                    type = TypeWithAnnotations.Create(Type, NullableAnnotation.NotAnnotated)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 4168, 4257);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10177, 4175, 4214) || ((State == NullableFlowState.MaybeDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10177, 4217, 4249)) || DynAbs.Tracing.TraceSender.Conditional_F3(10177, 4252, 4256))) ? type.SetIsAnnotated(compilation) : type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10177, 3963, 4272);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 4309, 4630);

                // LAFHIS
                NullableAnnotation
                annotation = (DynAbs.Tracing.TraceSender.Conditional_F1(10177, 4341, 4356) || ((asAnnotatedType && DynAbs.Tracing.TraceSender.Conditional_F2(10177, 4376, 4481)) || DynAbs.Tracing.TraceSender.Conditional_F3(10177, 4501, 4629))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(10177, 4377, 4415) || (((Type is not null && (DynAbs.Tracing.TraceSender.Expression_True(10177, 4378, 4414) && f_10177_4398_4414(Type))) && DynAbs.Tracing.TraceSender.Conditional_F2(10177, 4418, 4449)) || DynAbs.Tracing.TraceSender.Conditional_F3(10177, 4452, 4480))) ? NullableAnnotation.NotAnnotated : NullableAnnotation.Annotated) : ((DynAbs.Tracing.TraceSender.Conditional_F1(10177, 4502, 4563) || (((f_10177_4502_4519(State) || (DynAbs.Tracing.TraceSender.Expression_False(10177, 4502, 4563) || (Type is null || (DynAbs.Tracing.TraceSender.Expression_False(10177, 4524, 4562) || !f_10177_4541_4562(Type))))) && DynAbs.Tracing.TraceSender.Conditional_F2(10177, 4566, 4597)) || DynAbs.Tracing.TraceSender.Conditional_F3(10177, 4600, 4628))) ? NullableAnnotation.NotAnnotated : NullableAnnotation.Annotated)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 4644, 4701);

                return TypeWithAnnotations.Create(this.Type, annotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10177, 3806, 4712);

                bool
                f_10177_3987_4039(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameterDisallowingAnnotationInCSharp8();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 3987, 4039);
                    return return_v;
                }


                bool
                f_10177_4398_4414(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10177, 4398, 4414);
                    return return_v;
                }


                bool
                f_10177_4502_4519(Microsoft.CodeAnalysis.CSharp.NullableFlowState
                state)
                {
                    var return_v = state.IsNotNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 4502, 4519);
                    return return_v;
                }


                bool
                f_10177_4541_4562(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CanContainNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 4541, 4562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 3806, 4712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 3806, 4712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeWithAnnotations ToAnnotatedTypeWithAnnotations(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10177, 4813, 4886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10177, 4829, 4886);
                return ToTypeWithAnnotations(compilation, asAnnotatedType: true); DynAbs.Tracing.TraceSender.TraceExitMethod(10177, 4813, 4886);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10177, 4813, 4886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 4813, 4886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static TypeWithState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10177, 469, 4894);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10177, 469, 4894);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10177, 469, 4894);
        }

        static bool
        f_10177_3011_3032(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.CanContainNull();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 3011, 3032);
            return return_v;
        }


        static int
        f_10177_2944_3033(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 2944, 3033);
            return 0;
        }


        static bool
        f_10177_3143_3195(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.IsTypeParameterDisallowingAnnotationInCSharp8();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 3143, 3195);
            return return_v;
        }


        static int
        f_10177_3071_3196(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10177, 3071, 3196);
            return 0;
        }

    }
}
