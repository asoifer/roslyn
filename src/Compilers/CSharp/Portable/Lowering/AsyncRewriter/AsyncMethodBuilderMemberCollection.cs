// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct AsyncMethodBuilderMemberCollection
    {

        internal readonly NamedTypeSymbol BuilderType;

        internal readonly TypeSymbol ResultType;

        internal readonly MethodSymbol CreateBuilder;

        internal readonly MethodSymbol SetException;

        internal readonly MethodSymbol SetResult;

        internal readonly MethodSymbol AwaitOnCompleted;

        internal readonly MethodSymbol AwaitUnsafeOnCompleted;

        internal readonly MethodSymbol Start;

        internal readonly MethodSymbol SetStateMachine;

        internal readonly PropertySymbol Task;

        internal readonly bool CheckGenericMethodConstraints;

        private AsyncMethodBuilderMemberCollection(
                    NamedTypeSymbol builderType,
                    TypeSymbol resultType,
                    MethodSymbol createBuilder,
                    MethodSymbol setException,
                    MethodSymbol setResult,
                    MethodSymbol awaitOnCompleted,
                    MethodSymbol awaitUnsafeOnCompleted,
                    MethodSymbol start,
                    MethodSymbol setStateMachine,
                    PropertySymbol task,
                    bool checkGenericMethodConstraints)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10446, 3678, 4682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4195, 4221);

                BuilderType = builderType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4235, 4259);

                ResultType = resultType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4273, 4303);

                CreateBuilder = createBuilder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4317, 4345);

                SetException = setException;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4359, 4381);

                SetResult = setResult;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4395, 4431);

                AwaitOnCompleted = awaitOnCompleted;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4445, 4493);

                AwaitUnsafeOnCompleted = awaitUnsafeOnCompleted;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4507, 4521);

                Start = start;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4535, 4569);

                SetStateMachine = setStateMachine;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4583, 4595);

                Task = task;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4609, 4671);

                CheckGenericMethodConstraints = checkGenericMethodConstraints;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10446, 3678, 4682);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10446, 3678, 4682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10446, 3678, 4682);
            }
        }

        internal static bool TryCreate(SyntheticBoundNodeFactory F, MethodSymbol method, TypeMap typeMap, out AsyncMethodBuilderMemberCollection collection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10446, 4694, 15918);
                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol createBuilderMethod = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4867, 6691) || true) && (f_10446_4871_4888(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 4867, 6691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 4922, 5030);

                    var
                    builderType = f_10446_4940_5029(F, WellKnownType.System_Runtime_CompilerServices_AsyncIteratorMethodBuilder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 5048, 5090);

                    f_10446_5048_5089((object)builderType != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 5110, 5410);

                    TryGetBuilderMember<MethodSymbol>(F, WellKnownMember.System_Runtime_CompilerServices_AsyncIteratorMethodBuilder__Create, builderType, customBuilder: false, out createBuilderMethod
                    );

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 5430, 5578) || true) && (createBuilderMethod is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 5430, 5578);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 5503, 5524);

                        collection = default;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 5546, 5559);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 5430, 5578);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 5598, 6676);

                    return TryCreate(F, customBuilder: false, builderType: builderType, resultType: f_10446_5763_5801(F, SpecialType.System_Void), createBuilderMethod: createBuilderMethod, taskProperty: null, setException: null, setResult: WellKnownMember.System_Runtime_CompilerServices_AsyncIteratorMethodBuilder__Complete, awaitOnCompleted: WellKnownMember.System_Runtime_CompilerServices_AsyncIteratorMethodBuilder__AwaitOnCompleted, awaitUnsafeOnCompleted: WellKnownMember.System_Runtime_CompilerServices_AsyncIteratorMethodBuilder__AwaitUnsafeOnCompleted, start: WellKnownMember.System_Runtime_CompilerServices_AsyncIteratorMethodBuilder__MoveNext_T, setStateMachine: null, collection: out collection);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 4867, 6691);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 6707, 8679) || true) && (f_10446_6711_6740(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 6707, 8679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 6774, 6878);

                    var
                    builderType = f_10446_6792_6877(F, WellKnownType.System_Runtime_CompilerServices_AsyncVoidMethodBuilder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 6896, 6938);

                    f_10446_6896_6937((object)builderType != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 6956, 6989);

                    // LAFHIS
                    MethodSymbol
                    createBuilderMethod2
                    = default(MethodSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 7007, 7034);

                    bool
                    customBuilder = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 7052, 7328);

                    TryGetBuilderMember<MethodSymbol>(F, WellKnownMember.System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Create, builderType, customBuilder, out createBuilderMethod2);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 7346, 7538) || true) && ((object)createBuilderMethod2 == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 7346, 7538);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 7427, 7484);

                        collection = default(AsyncMethodBuilderMemberCollection);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 7506, 7519);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 7346, 7538);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 7556, 8664);

                    return TryCreate(F, customBuilder: customBuilder, builderType: builderType, resultType: f_10446_7729_7767(F, SpecialType.System_Void), createBuilderMethod: createBuilderMethod2, taskProperty: null, setException: WellKnownMember.System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetException, setResult: WellKnownMember.System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult, awaitOnCompleted: WellKnownMember.System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitOnCompleted, awaitUnsafeOnCompleted: WellKnownMember.System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted, start: WellKnownMember.System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_T, setStateMachine: WellKnownMember.System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetStateMachine, collection: out collection);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 6707, 8679);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 8695, 11933) || true) && (f_10446_8699_8741(method, f_10446_8727_8740(F)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 8695, 11933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 8775, 8827);

                    var
                    returnType = (NamedTypeSymbol)f_10446_8809_8826(method)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 8845, 8873);

                    NamedTypeSymbol
                    builderType
                    = default(NamedTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 8891, 8931);

                    // LAFHIS
                    MethodSymbol
                    createBuilderMethod3 = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 8949, 8984);

                    PropertySymbol
                    taskProperty = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 9004, 9027);

                    object
                    builderArgument
                    = default(object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 9045, 9115);

                    bool
                    customBuilder = f_10446_9066_9114(returnType, out builderArgument)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 9133, 10469) || true) && (customBuilder)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 9133, 10469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 9192, 9298);

                        builderType = ValidateBuilderType(F, builderArgument, f_10446_9246_9278(returnType), isGeneric: false);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 9320, 9575) || true) && ((object)builderType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 9320, 9575);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 9401, 9466);

                            taskProperty = GetCustomTaskProperty(F, builderType, returnType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 9492, 9552);

                            createBuilderMethod = GetCustomCreateMethod(F, builderType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 9320, 9575);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 9133, 10469);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 9133, 10469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 9657, 9757);

                        builderType = f_10446_9671_9756(F, WellKnownType.System_Runtime_CompilerServices_AsyncTaskMethodBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 9779, 9821);

                        f_10446_9779_9820((object)builderType != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 9843, 10139);

                        TryGetBuilderMember<MethodSymbol>(F, WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder__Create, builderType, customBuilder, out createBuilderMethod3);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 10161, 10450);

                        TryGetBuilderMember<PropertySymbol>(F, WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder__Task, builderType, customBuilder, out taskProperty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 9133, 10469);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 10487, 10784) || true) && ((object)builderType == null || (DynAbs.Tracing.TraceSender.Expression_False(10446, 10491, 10578) || (object)createBuilderMethod3 == null) || (DynAbs.Tracing.TraceSender.Expression_False(10446, 10491, 10631) || (object)taskProperty == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 10487, 10784);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 10673, 10730);

                        collection = default(AsyncMethodBuilderMemberCollection);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 10752, 10765);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 10487, 10784);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 10802, 11918);

                    return TryCreate(F, customBuilder: customBuilder, builderType: builderType, resultType: f_10446_10975_11013(F, SpecialType.System_Void), createBuilderMethod: createBuilderMethod3, taskProperty: taskProperty, setException: WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder__SetException, setResult: WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder__SetResult, awaitOnCompleted: WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitOnCompleted, awaitUnsafeOnCompleted: WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted, start: WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder__Start_T, setStateMachine: WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder__SetStateMachine, collection: out collection);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 8695, 11933);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 11949, 15842) || true) && (f_10446_11953_12002(method, f_10446_11988_12001(F)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 11949, 15842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12036, 12088);

                    var
                    returnType = (NamedTypeSymbol)f_10446_12070_12087(method)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12106, 12197);

                    var
                    resultType = returnType.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.Single().Type
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12215, 12356) || true) && (f_10446_12219_12241(resultType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 12215, 12356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12283, 12337);

                        resultType = f_10446_12296_12336(F, SpecialType.System_Object);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 12215, 12356);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12374, 12507) || true) && (typeMap != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 12374, 12507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12435, 12488);

                        resultType = f_10446_12448_12482(typeMap, resultType).Type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 12374, 12507);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12525, 12587);

                    returnType = f_10446_12538_12586(f_10446_12538_12564(returnType), resultType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12605, 12633);

                    NamedTypeSymbol
                    builderType
                    = default(NamedTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12651, 12691);

                    // LAFHIS
                    MethodSymbol
                    createBuilderMethod4 = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12709, 12744);

                    PropertySymbol
                    taskProperty = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12764, 12787);

                    object
                    builderArgument
                    = default(object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12805, 12875);

                    bool
                    customBuilder = f_10446_12826_12874(returnType, out builderArgument)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12893, 14394) || true) && (customBuilder)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 12893, 14394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 12952, 13057);

                        builderType = ValidateBuilderType(F, builderArgument, f_10446_13006_13038(returnType), isGeneric: true);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 13079, 13424) || true) && ((object)builderType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 13079, 13424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 13160, 13224);

                            builderType = f_10446_13174_13223(f_10446_13174_13201(builderType), resultType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 13250, 13315);

                            taskProperty = GetCustomTaskProperty(F, builderType, returnType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 13341, 13401);

                            createBuilderMethod = GetCustomCreateMethod(F, builderType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 13079, 13424);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 12893, 14394);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 12893, 14394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 13506, 13608);

                        builderType = f_10446_13520_13607(F, WellKnownType.System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 13630, 13672);

                        f_10446_13630_13671((object)builderType != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 13694, 13742);

                        builderType = f_10446_13708_13741(builderType, resultType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 13764, 14062);

                        TryGetBuilderMember<MethodSymbol>(F, WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__Create, builderType, customBuilder, out createBuilderMethod4);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 14084, 14375);

                        TryGetBuilderMember<PropertySymbol>(F, WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__Task, builderType, customBuilder, out taskProperty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 12893, 14394);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 14412, 14709) || true) && ((object)builderType == null || (DynAbs.Tracing.TraceSender.Expression_False(10446, 14416, 14496) || (object)taskProperty == null) || (DynAbs.Tracing.TraceSender.Expression_False(10446, 14416, 14556) || (object)createBuilderMethod4 == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 14412, 14709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 14598, 14655);

                        collection = default(AsyncMethodBuilderMemberCollection);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 14677, 14690);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 14412, 14709);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 14727, 15827);

                    return TryCreate(F, customBuilder: customBuilder, builderType: builderType, resultType: resultType, createBuilderMethod: createBuilderMethod4, taskProperty: taskProperty, setException: WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__SetException, setResult: WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__SetResult, awaitOnCompleted: WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__AwaitOnCompleted, awaitUnsafeOnCompleted: WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__AwaitUnsafeOnCompleted, start: WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__Start_T, setStateMachine: WellKnownMember.System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__SetStateMachine, collection: out collection);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 11949, 15842);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 15858, 15907);

                throw f_10446_15864_15906(method);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10446, 4694, 15918);

                bool
                f_10446_4871_4888(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsIterator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 4871, 4888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_4940_5029(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 4940, 5029);
                    return return_v;
                }


                int
                f_10446_5048_5089(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 5048, 5089);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_5763_5801(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 5763, 5801);
                    return return_v;
                }


                bool
                f_10446_6711_6740(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsAsyncReturningVoid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 6711, 6740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_6792_6877(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 6792, 6877);
                    return return_v;
                }


                int
                f_10446_6896_6937(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 6896, 6937);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_7729_7767(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 7729, 7767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10446_8727_8740(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 8727, 8740);
                    return return_v;
                }


                bool
                f_10446_8699_8741(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = method.IsAsyncReturningTask(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 8699, 8741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10446_8809_8826(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 8809, 8826);
                    return return_v;
                }


                bool
                f_10446_9066_9114(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, out object
                builderArgument)
                {
                    var return_v = type.IsCustomTaskType(out builderArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 9066, 9114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10446_9246_9278(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 9246, 9278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_9671_9756(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 9671, 9756);
                    return return_v;
                }


                int
                f_10446_9779_9820(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 9779, 9820);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_10975_11013(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 10975, 11013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10446_11988_12001(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 11988, 12001);
                    return return_v;
                }


                bool
                f_10446_11953_12002(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = method.IsAsyncReturningGenericTask(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 11953, 12002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10446_12070_12087(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 12070, 12087);
                    return return_v;
                }


                bool
                f_10446_12219_12241(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 12219, 12241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_12296_12336(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 12296, 12336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10446_12448_12482(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 12448, 12482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_12538_12564(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 12538, 12564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_12538_12586(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 12538, 12586);
                    return return_v;
                }


                bool
                f_10446_12826_12874(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, out object
                builderArgument)
                {
                    var return_v = type.IsCustomTaskType(out builderArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 12826, 12874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10446_13006_13038(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 13006, 13038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_13174_13201(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 13174, 13201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_13174_13223(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 13174, 13223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_13520_13607(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 13520, 13607);
                    return return_v;
                }


                int
                f_10446_13630_13671(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 13630, 13671);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_13708_13741(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 13708, 13741);
                    return return_v;
                }


                System.Exception
                f_10446_15864_15906(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 15864, 15906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10446, 4694, 15918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10446, 4694, 15918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static NamedTypeSymbol ValidateBuilderType(SyntheticBoundNodeFactory F, object builderAttributeArgument, Accessibility desiredAccessibility, bool isGeneric)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10446, 15930, 16920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 16119, 16181);

                var
                builderType = builderAttributeArgument as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 16197, 16800) || true) && ((object)builderType != null && (DynAbs.Tracing.TraceSender.Expression_True(10446, 16201, 16276) && !f_10446_16251_16276(builderType)) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 16201, 16323) && !f_10446_16299_16323(builderType)) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 16201, 16402) && f_10446_16345_16378(builderType) == desiredAccessibility))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 16197, 16800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 16436, 16674);

                    bool
                    isArityOk = (DynAbs.Tracing.TraceSender.Conditional_F1(10446, 16453, 16462) || ((isGeneric
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10446, 16499, 16610)) || DynAbs.Tracing.TraceSender.Conditional_F3(10446, 16647, 16673))) ? f_10446_16499_16531(builderType) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 16499, 16584) && f_10446_16535_16576_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10446_16535_16561(builderType), 10446, 16535, 16576)?.IsGenericType) != true) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 16499, 16610) && f_10446_16588_16605(builderType) == 1
                    ) : f_10446_16647_16673_M(!builderType.IsGenericType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 16692, 16785) || true) && (isArityOk)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 16692, 16785);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 16747, 16766);

                        return builderType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 16692, 16785);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 16197, 16800);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 16816, 16883);

                f_10446_16816_16882(f_10446_16816_16829(F), ErrorCode.ERR_BadAsyncReturn, f_10446_16864_16881(f_10446_16864_16872(F)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 16897, 16909);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10446, 15930, 16920);

                bool
                f_10446_16251_16276(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 16251, 16276);
                    return return_v;
                }


                bool
                f_10446_16299_16323(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 16299, 16323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10446_16345_16378(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 16345, 16378);
                    return return_v;
                }


                bool
                f_10446_16499_16531(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsUnboundGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 16499, 16531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_16535_16561(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 16535, 16561);
                    return return_v;
                }


                bool?
                f_10446_16535_16576_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 16535, 16576);
                    return return_v;
                }


                int
                f_10446_16588_16605(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 16588, 16605);
                    return return_v;
                }


                bool
                f_10446_16647_16673_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 16647, 16673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10446_16816_16829(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 16816, 16829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10446_16864_16872(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 16864, 16872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10446_16864_16881(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 16864, 16881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10446_16816_16882(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 16816, 16882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10446, 15930, 16920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10446, 15930, 16920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryCreate(
                    SyntheticBoundNodeFactory F,
                    bool customBuilder,
                    NamedTypeSymbol builderType,
                    TypeSymbol resultType,
                    MethodSymbol createBuilderMethod,
                    PropertySymbol taskProperty,
                    WellKnownMember? setException,
                    WellKnownMember setResult,
                    WellKnownMember awaitOnCompleted,
                    WellKnownMember awaitUnsafeOnCompleted,
                    WellKnownMember start,
                    WellKnownMember? setStateMachine,
                    out AsyncMethodBuilderMemberCollection collection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10446, 16932, 19205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 17560, 17592);

                MethodSymbol
                setExceptionMethod
                = default(MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 17606, 17635);

                MethodSymbol
                setResultMethod
                = default(MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 17649, 17685);

                MethodSymbol
                awaitOnCompletedMethod
                = default(MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 17699, 17741);

                MethodSymbol
                awaitUnsafeOnCompletedMethod
                = default(MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 17755, 17780);

                MethodSymbol
                startMethod
                = default(MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 17794, 17829);

                MethodSymbol
                setStateMachineMethod
                = default(MethodSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 17845, 19094) || true) && (TryGetBuilderMember(F, setException, builderType, customBuilder, out setExceptionMethod) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 17849, 18040) && TryGetBuilderMember(F, setResult, builderType, customBuilder, out setResultMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 17849, 18157) && TryGetBuilderMember(F, awaitOnCompleted, builderType, customBuilder, out awaitOnCompletedMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 17849, 18286) && TryGetBuilderMember(F, awaitUnsafeOnCompleted, builderType, customBuilder, out awaitUnsafeOnCompletedMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 17849, 18381) && TryGetBuilderMember(F, start, builderType, customBuilder, out startMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 17849, 18496) && TryGetBuilderMember(F, setStateMachine, builderType, customBuilder, out setStateMachineMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 17845, 19094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 18530, 19047);

                    collection = f_10446_18543_19046(builderType, resultType, createBuilderMethod, setExceptionMethod, setResultMethod, awaitOnCompletedMethod, awaitUnsafeOnCompletedMethod, startMethod, setStateMachineMethod, taskProperty, checkGenericMethodConstraints: customBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 19067, 19079);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 17845, 19094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 19110, 19167);

                collection = default(AsyncMethodBuilderMemberCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 19181, 19194);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10446, 16932, 19205);

                Microsoft.CodeAnalysis.CSharp.AsyncMethodBuilderMemberCollection
                f_10446_18543_19046(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                builderType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                createBuilder, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                setException, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                setResult, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                awaitOnCompleted, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                awaitUnsafeOnCompleted, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                start, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                setStateMachine, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                task, bool
                checkGenericMethodConstraints)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncMethodBuilderMemberCollection(builderType, resultType, createBuilder, setException, setResult, awaitOnCompleted, awaitUnsafeOnCompleted, start, setStateMachine, task, checkGenericMethodConstraints: checkGenericMethodConstraints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 18543, 19046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10446, 16932, 19205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10446, 16932, 19205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetBuilderMember<TSymbol>(
                    SyntheticBoundNodeFactory F,
                    WellKnownMember? member,
                    NamedTypeSymbol builderType,
                    bool customBuilder,
                    out TSymbol symbol)
                    where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10446, 19217, 21102);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 19515, 19628) || true) && (f_10446_19519_19535_M(!member.HasValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 19515, 19628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 19569, 19583);

                    symbol = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 19601, 19613);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 19515, 19628);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 19644, 19687);

                WellKnownMember
                memberValue = f_10446_19674_19686<TSymbol>(member)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 19701, 20566) || true) && (customBuilder)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 19701, 20566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 19752, 19813);

                    var
                    descriptor = f_10446_19769_19812<TSymbol>(memberValue)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 19831, 20076);

                    var
                    sym = f_10446_19841_20075<TSymbol>(f_10446_19898_19928<TSymbol>(builderType), descriptor, f_10446_19984_19997<TSymbol>(F).WellKnownMemberSignatureComparer, accessWithinOpt: null)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 20094, 20216) || true) && ((object)sym != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 20094, 20216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 20159, 20197);

                        sym = f_10446_20165_20196<TSymbol>(sym, builderType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 20094, 20216);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 20234, 20258);

                    symbol = sym as TSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 19701, 20566);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 19701, 20566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 20324, 20393);

                    symbol = f_10446_20333_20381<TSymbol>(F, memberValue, isOptional: true) as TSymbol;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 20411, 20551) || true) && ((object)symbol != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 20411, 20551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 20479, 20532);

                        symbol = (TSymbol)f_10446_20497_20531<TSymbol>(symbol, builderType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 20411, 20551);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 19701, 20566);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 20580, 21065) || true) && ((object)symbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 20580, 21065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 20640, 20701);

                    var
                    descriptor = f_10446_20657_20700<TSymbol>(memberValue)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 20719, 20971);

                    var
                    diagnostic = f_10446_20736_20970<TSymbol>(f_10446_20775_20929<TSymbol>(ErrorCode.ERR_MissingPredefinedMember, ((DynAbs.Tracing.TraceSender.Conditional_F1(10446, 20836, 20849) || ((customBuilder && DynAbs.Tracing.TraceSender.Conditional_F2(10446, 20852, 20871)) || DynAbs.Tracing.TraceSender.Conditional_F3(10446, 20874, 20910))) ? (object)builderType : descriptor.DeclaringTypeMetadataName), descriptor.Name), f_10446_20952_20969<TSymbol>(f_10446_20952_20960<TSymbol>(F)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 20989, 21019);

                    f_10446_20989_21018<TSymbol>(f_10446_20989_21002<TSymbol>(F), diagnostic);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 21037, 21050);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 20580, 21065);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 21079, 21091);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10446, 19217, 21102);

                bool
                f_10446_19519_19535_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 19519, 19535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownMember
                f_10446_19674_19686<TSymbol>(Microsoft.CodeAnalysis.WellKnownMember?
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 19674, 19686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10446_19769_19812<TSymbol>(Microsoft.CodeAnalysis.WellKnownMember
                member) where TSymbol : Symbol

                {
                    var return_v = WellKnownMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 19769, 19812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10446_19898_19928<TSymbol>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 19898, 19928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10446_19984_19997<TSymbol>(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 19984, 19997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10446_19841_20075<TSymbol>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                declaringType, Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                descriptor, Microsoft.CodeAnalysis.CSharp.CSharpCompilation.WellKnownMembersSignatureComparer
                comparer, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                accessWithinOpt) where TSymbol : Symbol

                {
                    var return_v = CSharpCompilation.GetRuntimeMember(declaringType, descriptor, (Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>)comparer, accessWithinOpt: accessWithinOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 19841, 20075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10446_20165_20196<TSymbol>(Microsoft.CodeAnalysis.CSharp.Symbol
                s, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner) where TSymbol : Symbol

                {
                    var return_v = s.SymbolAsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 20165, 20196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10446_20333_20381<TSymbol>(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm, bool
                isOptional) where TSymbol : Symbol

                {
                    var return_v = this_param.WellKnownMember(wm, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 20333, 20381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10446_20497_20531<TSymbol>(TSymbol
                s, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner) where TSymbol : Symbol

                {
                    var return_v = s.SymbolAsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 20497, 20531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10446_20657_20700<TSymbol>(Microsoft.CodeAnalysis.WellKnownMember
                member) where TSymbol : Symbol

                {
                    var return_v = WellKnownMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 20657, 20700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10446_20775_20929<TSymbol>(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args) where TSymbol : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 20775, 20929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10446_20952_20960<TSymbol>(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 20952, 20960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10446_20952_20969<TSymbol>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 20952, 20969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10446_20736_20970<TSymbol>(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location) where TSymbol : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 20736, 20970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10446_20989_21002<TSymbol>(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 20989, 21002);
                    return return_v;
                }


                int
                f_10446_20989_21018<TSymbol>(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag) where TSymbol : Symbol

                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 20989, 21018);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10446, 19217, 21102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10446, 19217, 21102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodSymbol GetCustomCreateMethod(
                    SyntheticBoundNodeFactory F,
                    NamedTypeSymbol builderType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10446, 21114, 22347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 21460, 21495);

                const string
                methodName = "Create"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 21509, 21558);

                var
                members = f_10446_21523_21557(builderType, methodName)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 21572, 22195);
                    foreach (var member in f_10446_21595_21602_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 21572, 22195);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 21636, 21742) || true) && (f_10446_21640_21651(member) != SymbolKind.Method)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 21636, 21742);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 21714, 21723);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 21636, 21742);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 21760, 21794);

                        var
                        method = (MethodSymbol)member
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 21812, 22180) || true) && ((f_10446_21817_21845(method) == Accessibility.Public) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 21816, 21910) && f_10446_21895_21910(method)) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 21816, 21961) && f_10446_21935_21956(method) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 21816, 22009) && f_10446_21986_22009_M(!method.IsGenericMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 21816, 22105) && f_10446_22034_22105(f_10446_22034_22051(method), builderType, TypeCompareKind.AllIgnoreOptions)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 21812, 22180);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 22147, 22161);

                            return method;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 21812, 22180);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 21572, 22195);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10446, 1, 624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10446, 1, 624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 22209, 22310);

                f_10446_22209_22309(f_10446_22209_22222(F), ErrorCode.ERR_MissingPredefinedMember, f_10446_22266_22283(f_10446_22266_22274(F)), builderType, methodName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 22324, 22336);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10446, 21114, 22347);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10446_21523_21557(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 21523, 21557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10446_21640_21651(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 21640, 21651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10446_21817_21845(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 21817, 21845);
                    return return_v;
                }


                bool
                f_10446_21895_21910(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 21895, 21910);
                    return return_v;
                }


                int
                f_10446_21935_21956(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 21935, 21956);
                    return return_v;
                }


                bool
                f_10446_21986_22009_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 21986, 22009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10446_22034_22051(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 22034, 22051);
                    return return_v;
                }


                bool
                f_10446_22034_22105(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 22034, 22105);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10446_21595_21602_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 21595, 21602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10446_22209_22222(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 22209, 22222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10446_22266_22274(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 22266, 22274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10446_22266_22283(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 22266, 22283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10446_22209_22309(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 22209, 22309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10446, 21114, 22347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10446, 21114, 22347);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PropertySymbol GetCustomTaskProperty(
                    SyntheticBoundNodeFactory F,
                    NamedTypeSymbol builderType,
                    NamedTypeSymbol returnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10446, 22359, 23937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 22561, 22596);

                const string
                propertyName = "Task"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 22610, 22661);

                var
                members = f_10446_22624_22660(builderType, propertyName)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 22675, 23666);
                    foreach (var member in f_10446_22698_22705_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 22675, 23666);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 22739, 22847) || true) && (f_10446_22743_22754(member) != SymbolKind.Property)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 22739, 22847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 22819, 22828);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 22739, 22847);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 22865, 22903);

                        var
                        property = (PropertySymbol)member
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 22921, 23651) || true) && ((f_10446_22926_22956(property) == Accessibility.Public) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 22925, 23024) && f_10446_23006_23024_M(!property.IsStatic)) && (DynAbs.Tracing.TraceSender.Expression_True(10446, 22925, 23079) && (f_10446_23050_23073(property) == 0)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 22921, 23651);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 23121, 23592) || true) && (!f_10446_23126_23192(f_10446_23126_23139(property), returnType, TypeCompareKind.AllIgnoreOptions))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10446, 23121, 23592);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 23242, 23470);

                                var
                                badTaskProperty = f_10446_23264_23469(f_10446_23311_23420(ErrorCode.ERR_BadAsyncMethodBuilderTaskProperty, builderType, returnType, f_10446_23406_23419(property)), f_10446_23451_23468(f_10446_23451_23459(F)))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 23496, 23531);

                                f_10446_23496_23530(f_10446_23496_23509(F), badTaskProperty);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 23557, 23569);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 23121, 23592);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 23616, 23632);

                            return property;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 22921, 23651);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10446, 22675, 23666);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10446, 1, 992);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10446, 1, 992);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 23680, 23856);

                var
                diagnostic = f_10446_23697_23855(f_10446_23732_23818(ErrorCode.ERR_MissingPredefinedMember, builderType, propertyName), f_10446_23837_23854(f_10446_23837_23845(F)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 23870, 23900);

                f_10446_23870_23899(f_10446_23870_23883(F), diagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10446, 23914, 23926);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10446, 22359, 23937);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10446_22624_22660(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 22624, 22660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10446_22743_22754(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 22743, 22754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10446_22926_22956(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 22926, 22956);
                    return return_v;
                }


                bool
                f_10446_23006_23024_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 23006, 23024);
                    return return_v;
                }


                int
                f_10446_23050_23073(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 23050, 23073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10446_23126_23139(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 23126, 23139);
                    return return_v;
                }


                bool
                f_10446_23126_23192(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 23126, 23192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10446_23406_23419(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 23406, 23419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10446_23311_23420(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 23311, 23420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10446_23451_23459(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 23451, 23459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10446_23451_23468(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 23451, 23468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10446_23264_23469(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 23264, 23469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10446_23496_23509(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 23496, 23509);
                    return return_v;
                }


                int
                f_10446_23496_23530(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 23496, 23530);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10446_22698_22705_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 22698, 22705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10446_23732_23818(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 23732, 23818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10446_23837_23845(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 23837, 23845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10446_23837_23854(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 23837, 23854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10446_23697_23855(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 23697, 23855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10446_23870_23883(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10446, 23870, 23883);
                    return return_v;
                }


                int
                f_10446_23870_23899(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10446, 23870, 23899);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10446, 22359, 23937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10446, 22359, 23937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static AsyncMethodBuilderMemberCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10446, 1498, 23944);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10446, 1498, 23944);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10446, 1498, 23944);
        }
    }
}
