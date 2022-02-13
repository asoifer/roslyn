// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class IteratorRewriter : StateMachineRewriter
    {
        private readonly TypeWithAnnotations _elementType;

        private readonly bool _isEnumerable;

        private FieldSymbol _currentField;

        private IteratorRewriter(
                    BoundStatement body,
                    MethodSymbol method,
                    bool isEnumerable,
                    IteratorStateMachine stateMachineType,
                    VariableSlotAllocator slotAllocatorOpt,
                    TypeCompilationState compilationState,
                    DiagnosticBag diagnostics)
        : base(f_10470_1268_1272_C(body), method, stateMachineType, slotAllocatorOpt, compilationState, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10470, 925, 1614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 853, 866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 899, 912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 1514, 1558);

                _elementType = stateMachineType.ElementType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 1574, 1603);

                _isEnumerable = isEnumerable;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10470, 925, 1614);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 925, 1614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 925, 1614);
            }
        }

        internal static BoundStatement Rewrite(
                    BoundStatement body,
                    MethodSymbol method,
                    int methodOrdinal,
                    VariableSlotAllocator slotAllocatorOpt,
                    TypeCompilationState compilationState,
                    DiagnosticBag diagnostics,
                    out IteratorStateMachine stateMachineType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10470, 1741, 3687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 2106, 2182);

                TypeWithAnnotations
                elementType = f_10470_2140_2181(method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 2196, 2342) || true) && (elementType.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10470, 2200, 2239) || f_10470_2225_2239(method)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10470, 2196, 2342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 2273, 2297);

                    stateMachineType = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 2315, 2327);

                    return body;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10470, 2196, 2342);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 2426, 2444);

                bool
                isEnumerable
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 2458, 3113);

                switch (f_10470_2466_2514(f_10470_2466_2502(f_10470_2466_2483(method))))
                {

                    case SpecialType.System_Collections_IEnumerable:
                    case SpecialType.System_Collections_Generic_IEnumerable_T:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10470, 2458, 3113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 2694, 2714);

                        isEnumerable = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(10470, 2736, 2742);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10470, 2458, 3113);

                    case SpecialType.System_Collections_IEnumerator:
                    case SpecialType.System_Collections_Generic_IEnumerator_T:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10470, 2458, 3113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 2908, 2929);

                        isEnumerable = false;
                        DynAbs.Tracing.TraceSender.TraceBreak(10470, 2951, 2957);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10470, 2458, 3113);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10470, 2458, 3113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 3007, 3098);

                        throw f_10470_3013_3097(f_10470_3048_3096(f_10470_3048_3084(f_10470_3048_3065(method))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10470, 2458, 3113);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 3129, 3259);

                stateMachineType = f_10470_3148_3258(slotAllocatorOpt, compilationState, method, methodOrdinal, isEnumerable, elementType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 3273, 3370);

                f_10470_3273_3369(compilationState.ModuleBuilderOpt.CompilationState, method, stateMachineType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 3384, 3515);

                var
                rewriter = f_10470_3399_3514(body, method, isEnumerable, stateMachineType, slotAllocatorOpt, compilationState, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 3529, 3634) || true) && (!f_10470_3534_3573(rewriter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10470, 3529, 3634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 3607, 3619);

                    return body;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10470, 3529, 3634);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 3650, 3676);

                return f_10470_3657_3675(rewriter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10470, 1741, 3687);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10470_2140_2181(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IteratorElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 2140, 2181);
                    return return_v;
                }


                bool
                f_10470_2225_2239(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 2225, 2239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10470_2466_2483(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 2466, 2483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10470_2466_2502(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 2466, 2502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10470_2466_2514(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 2466, 2514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10470_3048_3065(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 3048, 3065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10470_3048_3084(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 3048, 3084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10470_3048_3096(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 3048, 3096);
                    return return_v;
                }


                System.Exception
                f_10470_3013_3097(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 3013, 3097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.IteratorStateMachine
                f_10470_3148_3258(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                iteratorMethod, int
                iteratorMethodOrdinal, bool
                isEnumerable, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.IteratorStateMachine(slotAllocatorOpt, compilationState, iteratorMethod, iteratorMethodOrdinal, isEnumerable, elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 3148, 3258);
                    return return_v;
                }


                int
                f_10470_3273_3369(Microsoft.CodeAnalysis.CSharp.ModuleCompilationState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.IteratorStateMachine
                stateMachineClass)
                {
                    this_param.SetStateMachineType(method, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)stateMachineClass);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 3273, 3369);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                f_10470_3399_3514(Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, bool
                isEnumerable, Microsoft.CodeAnalysis.CSharp.IteratorStateMachine
                stateMachineType, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.IteratorRewriter(body, method, isEnumerable, stateMachineType, slotAllocatorOpt, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 3399, 3514);
                    return return_v;
                }


                bool
                f_10470_3534_3573(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param)
                {
                    var return_v = this_param.VerifyPresenceOfRequiredAPIs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 3534, 3573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10470_3657_3675(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param)
                {
                    var return_v = this_param.Rewrite();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 3657, 3675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 1741, 3687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 1741, 3687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool VerifyPresenceOfRequiredAPIs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 3826, 5533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 3896, 3944);

                DiagnosticBag
                bag = f_10470_3916_3943()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 3960, 4009);

                f_10470_3960_4008(this, SpecialType.System_Int32, bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 4023, 4078);

                f_10470_4023_4077(this, SpecialType.System_IDisposable, bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 4092, 4160);

                f_10470_4092_4159(this, SpecialMember.System_IDisposable__Dispose, bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 4204, 4271);

                f_10470_4204_4270(this, SpecialType.System_Collections_IEnumerator, bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 4285, 4373);

                f_10470_4285_4372(this, SpecialMember.System_Collections_IEnumerator__Current, bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 4387, 4468);

                f_10470_4387_4467(this, SpecialMember.System_Collections_IEnumerator__MoveNext, bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 4482, 4560);

                f_10470_4482_4559(this, SpecialMember.System_Collections_IEnumerator__Reset, bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 4607, 4684);

                f_10470_4607_4683(this, SpecialType.System_Collections_Generic_IEnumerator_T, bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 4698, 4796);

                f_10470_4698_4795(this, SpecialMember.System_Collections_Generic_IEnumerator_T__Current, bag);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 4812, 5309) || true) && (_isEnumerable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10470, 4812, 5309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 4914, 4981);

                    f_10470_4914_4980(this, SpecialType.System_Collections_IEnumerable, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 4999, 5085);

                    f_10470_4999_5084(this, SpecialMember.System_Collections_IEnumerable__GetEnumerator, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 5103, 5180);

                    f_10470_5103_5179(this, SpecialType.System_Collections_Generic_IEnumerable_T, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 5198, 5294);

                    f_10470_5198_5293(this, SpecialMember.System_Collections_Generic_IEnumerable_T__GetEnumerator, bag);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10470, 4812, 5309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 5325, 5361);

                bool
                hasErrors = f_10470_5342_5360(bag)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 5375, 5463) || true) && (hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10470, 5375, 5463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 5422, 5448);

                    f_10470_5422_5447(diagnostics, bag);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10470, 5375, 5463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 5479, 5490);

                f_10470_5479_5489(
                            bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 5504, 5522);

                return !hasErrors;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 3826, 5533);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10470_3916_3943()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 3916, 3943);
                    return return_v;
                }


                int
                f_10470_3960_4008(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.EnsureSpecialType(type, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 3960, 4008);
                    return 0;
                }


                int
                f_10470_4023_4077(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.EnsureSpecialType(type, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 4023, 4077);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10470_4092_4159(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    var return_v = this_param.EnsureSpecialMember(member, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 4092, 4159);
                    return return_v;
                }


                int
                f_10470_4204_4270(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.EnsureSpecialType(type, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 4204, 4270);
                    return 0;
                }


                int
                f_10470_4285_4372(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.EnsureSpecialPropertyGetter(member, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 4285, 4372);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10470_4387_4467(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    var return_v = this_param.EnsureSpecialMember(member, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 4387, 4467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10470_4482_4559(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    var return_v = this_param.EnsureSpecialMember(member, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 4482, 4559);
                    return return_v;
                }


                int
                f_10470_4607_4683(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.EnsureSpecialType(type, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 4607, 4683);
                    return 0;
                }


                int
                f_10470_4698_4795(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.EnsureSpecialPropertyGetter(member, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 4698, 4795);
                    return 0;
                }


                int
                f_10470_4914_4980(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.EnsureSpecialType(type, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 4914, 4980);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10470_4999_5084(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    var return_v = this_param.EnsureSpecialMember(member, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 4999, 5084);
                    return return_v;
                }


                int
                f_10470_5103_5179(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.EnsureSpecialType(type, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 5103, 5179);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10470_5198_5293(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    var return_v = this_param.EnsureSpecialMember(member, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 5198, 5293);
                    return return_v;
                }


                bool
                f_10470_5342_5360(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 5342, 5360);
                    return return_v;
                }


                int
                f_10470_5422_5447(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 5422, 5447);
                    return 0;
                }


                int
                f_10470_5479_5489(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 5479, 5489);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 3826, 5533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 3826, 5533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol EnsureSpecialMember(SpecialMember member, DiagnosticBag bag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 5545, 5796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 5645, 5659);

                Symbol
                symbol
                = default(Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 5673, 5757);

                f_10470_5673_5756(f_10470_5704_5717(F), member, body.Syntax, bag, out symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 5771, 5785);

                return symbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 5545, 5796);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10470_5704_5717(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 5704, 5717);
                    return return_v;
                }


                bool
                f_10470_5673_5756(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialMember
                specialMember, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = Binder.TryGetSpecialTypeMember(compilation, specialMember, syntax, diagnostics, out symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 5673, 5756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 5545, 5796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 5545, 5796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EnsureSpecialType(SpecialType type, DiagnosticBag bag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 5808, 5972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 5900, 5961);

                f_10470_5900_5960(f_10470_5922_5935(F), type, body.Syntax, bag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 5808, 5972);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10470_5922_5935(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 5922, 5935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10470_5900_5960(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.GetSpecialType(compilation, typeId, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 5900, 5960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 5808, 5972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 5808, 5972);
            }
        }

        private void EnsureSpecialPropertyGetter(SpecialMember member, DiagnosticBag bag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 6122, 6854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 6228, 6301);

                PropertySymbol
                symbol = (PropertySymbol)f_10470_6268_6300(this, member, bag)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 6315, 6843) || true) && ((object)symbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10470, 6315, 6843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 6375, 6405);

                    var
                    getter = f_10470_6388_6404(symbol)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 6423, 6610) || true) && ((object)getter == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10470, 6423, 6610);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 6491, 6562);

                        f_10470_6491_6561(bag, ErrorCode.ERR_PropertyLacksGet, body.Syntax, symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 6584, 6591);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10470, 6423, 6610);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 6630, 6671);

                    var
                    info = f_10470_6641_6670(getter)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 6689, 6828) || true) && ((object)info != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10470, 6689, 6828);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 6755, 6809);

                        f_10470_6755_6808(bag, f_10470_6763_6807(info, f_10470_6786_6806(body.Syntax)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10470, 6689, 6828);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10470, 6315, 6843);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 6122, 6854);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10470_6268_6300(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    var return_v = this_param.EnsureSpecialMember(member, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 6268, 6300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_6388_6404(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 6388, 6404);
                    return return_v;
                }


                int
                f_10470_6491_6561(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Binder.Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 6491, 6561);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10470_6641_6670(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 6641, 6670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10470_6786_6806(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 6786, 6806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10470_6763_6807(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 6763, 6807);
                    return return_v;
                }


                int
                f_10470_6755_6808(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 6755, 6808);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 6122, 6854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 6122, 6854);
            }
        }

        protected override bool PreserveInitialParameterValuesAndThreadId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 6945, 6961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 6948, 6961);
                    return _isEnumerable; DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 6945, 6961);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 6945, 6961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 6945, 6961);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void GenerateControlFields()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 6974, 7337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 7046, 7174);

                this.stateField = f_10470_7064_7173(F, f_10470_7084_7123(F, SpecialType.System_Int32), f_10470_7125_7172());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 7229, 7326);

                _currentField = f_10470_7245_7325(F, _elementType, f_10470_7279_7324());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 6974, 7337);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10470_7084_7123(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 7084, 7123);
                    return return_v;
                }


                string
                f_10470_7125_7172()
                {
                    var return_v = GeneratedNames.MakeStateMachineStateFieldName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 7125, 7172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10470_7064_7173(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name)
                {
                    var return_v = this_param.StateMachineField((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 7064, 7173);
                    return return_v;
                }


                string
                f_10470_7279_7324()
                {
                    var return_v = GeneratedNames.MakeIteratorCurrentFieldName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 7279, 7324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10470_7245_7325(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, string
                name)
                {
                    var return_v = this_param.StateMachineField(type, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 7245, 7325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 6974, 7337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 6974, 7337);
            }
        }

        protected override void GenerateMethodImplementations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 7349, 7987);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 7465, 7504);

                    BoundExpression
                    managedThreadId = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 7564, 7599);

                    f_10470_7564_7598(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 7619, 7751) || true) && (_isEnumerable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10470, 7619, 7751);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 7678, 7732);

                        f_10470_7678_7731(this, ref managedThreadId);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10470, 7619, 7751);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 7771, 7808);

                    f_10470_7771_7807(this, managedThreadId);
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10470, 7837, 7976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 7930, 7961);

                    f_10470_7930_7960(diagnostics, f_10470_7946_7959(ex));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10470, 7837, 7976);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 7349, 7987);

                int
                f_10470_7564_7598(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param)
                {
                    this_param.GenerateEnumeratorImplementation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 7564, 7598);
                    return 0;
                }


                int
                f_10470_7678_7731(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, ref Microsoft.CodeAnalysis.CSharp.BoundExpression?
                managedThreadId)
                {
                    this_param.GenerateEnumerableImplementation(ref managedThreadId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 7678, 7731);
                    return 0;
                }


                int
                f_10470_7771_7807(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                managedThreadId)
                {
                    this_param.GenerateConstructor(managedThreadId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 7771, 7807);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10470_7946_7959(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 7946, 7959);
                    return return_v;
                }


                int
                f_10470_7930_7960(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 7930, 7960);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 7349, 7987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 7349, 7987);
            }
        }

        private void GenerateEnumeratorImplementation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 7999, 10047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 8071, 8156);

                var
                IDisposable_Dispose = f_10470_8097_8155(F, SpecialMember.System_IDisposable__Dispose)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 8172, 8271);

                var
                IEnumerator_MoveNext = f_10470_8199_8270(F, SpecialMember.System_Collections_IEnumerator__MoveNext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 8285, 8378);

                var
                IEnumerator_Reset = f_10470_8309_8377(F, SpecialMember.System_Collections_IEnumerator__Reset)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 8392, 8505);

                var
                IEnumerator_get_Current = f_10470_8422_8504(f_10470_8422_8494(F, SpecialMember.System_Collections_IEnumerator__Current))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 8521, 8667);

                var
                IEnumeratorOfElementType = f_10470_8552_8666(f_10470_8552_8619(F, SpecialType.System_Collections_Generic_IEnumerator_T), f_10470_8630_8665(_elementType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 8681, 8852);

                var
                IEnumeratorOfElementType_get_Current = f_10470_8724_8851(f_10470_8724_8816(f_10470_8724_8806(F, SpecialMember.System_Collections_Generic_IEnumerator_T__Current)), IEnumeratorOfElementType)
                ;

                // Add bool IEnumerator.MoveNext() and void IDisposable.Dispose()
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 8966, 9106);

                    var
                    disposeMethod = f_10470_8986_9105(this, IDisposable_Dispose, hasMethodBodyDependency: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 9126, 9202);

                    var
                    moveNextMethod = f_10470_9147_9201(this, IEnumerator_MoveNext)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 9222, 9280);

                    f_10470_9222_9279(this, moveNextMethod, disposeMethod);
                }

                // Add T IEnumerator<T>.Current
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 9375, 9440);

                    f_10470_9375_9439(this, IEnumeratorOfElementType_get_Current);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 9458, 9516);

                    f_10470_9458_9515(F, f_10470_9472_9514(F, f_10470_9481_9513(F, f_10470_9489_9497(F), _currentField)));
                }

                // Add void IEnumerator.Reset()
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 9611, 9687);

                    f_10470_9611_9686(this, IEnumerator_Reset, hasMethodBodyDependency: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 9705, 9796);

                    f_10470_9705_9795(F, f_10470_9719_9794(F, f_10470_9727_9793(F, f_10470_9733_9792(F, WellKnownType.System_NotSupportedException))));
                }

                // Add object IEnumerator.Current
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 9893, 9945);

                    f_10470_9893_9944(this, IEnumerator_get_Current);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 9963, 10021);

                    f_10470_9963_10020(F, f_10470_9977_10019(F, f_10470_9986_10018(F, f_10470_9994_10002(F), _currentField)));
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 7999, 10047);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_8097_8155(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMethod(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 8097, 8155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_8199_8270(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMethod(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 8199, 8270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_8309_8377(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMethod(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 8309, 8377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10470_8422_8494(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialProperty(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 8422, 8494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_8422_8504(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 8422, 8504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10470_8552_8619(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 8552, 8619);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10470_8630_8665(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 8630, 8665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10470_8552_8666(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 8552, 8666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10470_8724_8806(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialProperty(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 8724, 8806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_8724_8816(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 8724, 8816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_8724_8851(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 8724, 8851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                f_10470_8986_9105(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodToImplement, bool
                hasMethodBodyDependency)
                {
                    var return_v = this_param.OpenMethodImplementation(methodToImplement, hasMethodBodyDependency: hasMethodBodyDependency);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 8986, 9105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                f_10470_9147_9201(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodToImplement)
                {
                    var return_v = this_param.OpenMoveNextMethodImplementation(methodToImplement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9147, 9201);
                    return return_v;
                }


                int
                f_10470_9222_9279(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                moveNextMethod, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                disposeMethod)
                {
                    this_param.GenerateMoveNextAndDispose(moveNextMethod, disposeMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9222, 9279);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_9375_9439(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                getterToImplement)
                {
                    var return_v = this_param.OpenPropertyImplementation(getterToImplement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9375, 9439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10470_9489_9497(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9489, 9497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10470_9481_9513(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9481, 9513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10470_9472_9514(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9472, 9514);
                    return return_v;
                }


                int
                f_10470_9458_9515(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9458, 9515);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                f_10470_9611_9686(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodToImplement, bool
                hasMethodBodyDependency)
                {
                    var return_v = this_param.OpenMethodImplementation(methodToImplement, hasMethodBodyDependency: hasMethodBodyDependency);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9611, 9686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10470_9733_9792(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9733, 9792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10470_9727_9793(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.New(type, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9727, 9793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                f_10470_9719_9794(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                e)
                {
                    var return_v = this_param.Throw((Microsoft.CodeAnalysis.CSharp.BoundExpression)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9719, 9794);
                    return return_v;
                }


                int
                f_10470_9705_9795(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9705, 9795);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_9893_9944(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                getterToImplement)
                {
                    var return_v = this_param.OpenPropertyImplementation(getterToImplement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9893, 9944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10470_9994_10002(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9994, 10002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10470_9986_10018(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9986, 10018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10470_9977_10019(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9977, 10019);
                    return return_v;
                }


                int
                f_10470_9963_10020(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 9963, 10020);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 7999, 10047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 7999, 10047);
            }
        }

        private void GenerateEnumerableImplementation(ref BoundExpression managedThreadId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 10195, 11176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 10302, 10411);

                var
                IEnumerable_GetEnumerator = f_10470_10334_10410(F, SpecialMember.System_Collections_IEnumerable__GetEnumerator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 10427, 10555);

                var
                IEnumerableOfElementType = f_10470_10458_10554(f_10470_10458_10525(F, SpecialType.System_Collections_Generic_IEnumerable_T), _elementType.Type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 10569, 10736);

                var
                IEnumerableOfElementType_GetEnumerator = f_10470_10614_10735(f_10470_10614_10700(F, SpecialMember.System_Collections_Generic_IEnumerable_T__GetEnumerator), IEnumerableOfElementType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 10793, 10948);

                var
                getEnumeratorGeneric = f_10470_10820_10947(this, IEnumerableOfElementType_GetEnumerator, ref managedThreadId, StateMachineStates.FirstUnusedState)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 11015, 11087);

                var
                getEnumerator = f_10470_11035_11086(this, IEnumerable_GetEnumerator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 11101, 11165);

                f_10470_11101_11164(F, f_10470_11115_11163(F, f_10470_11124_11162(F, f_10470_11131_11139(F), getEnumeratorGeneric)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 10195, 11176);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_10334_10410(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMethod(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 10334, 10410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10470_10458_10525(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 10458, 10525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10470_10458_10554(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 10458, 10554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_10614_10700(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMethod(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 10614, 10700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_10614_10735(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 10614, 10735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                f_10470_10820_10947(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                getEnumeratorMethod, ref Microsoft.CodeAnalysis.CSharp.BoundExpression
                managedThreadId, int
                initialState)
                {
                    var return_v = this_param.GenerateIteratorGetEnumerator(getEnumeratorMethod, ref managedThreadId, initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 10820, 10947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                f_10470_11035_11086(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodToImplement)
                {
                    var return_v = this_param.OpenMethodImplementation(methodToImplement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11035, 11086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10470_11131_11139(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11131, 11139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10470_11124_11162(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                method)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11124, 11162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10470_11115_11163(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11115, 11163);
                    return return_v;
                }


                int
                f_10470_11101_11164(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11101, 11164);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 10195, 11176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 10195, 11176);
            }
        }

        private void GenerateConstructor(BoundExpression managedThreadId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 11188, 12299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 11475, 11541);

                f_10470_11475_11540(f_10470_11488_11516(stateMachineType) is IteratorConstructor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 11557, 11606);

                F.CurrentFunction = f_10470_11577_11605(stateMachineType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 11620, 11681);

                var
                bodyBuilder = f_10470_11638_11680()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 11695, 11735);

                f_10470_11695_11734(bodyBuilder, f_10470_11711_11733(F));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 11749, 11856);

                f_10470_11749_11855(bodyBuilder, f_10470_11765_11854(F, f_10470_11778_11807(F, f_10470_11786_11794(F), stateField), f_10470_11809_11853(F, f_10470_11821_11849(f_10470_11821_11838(F))[0])));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 11895, 12140) || true) && (managedThreadId != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10470, 11895, 12140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 12037, 12125);

                    f_10470_12037_12124(                // this.initialThreadId = Thread.CurrentThread.ManagedThreadId;
                                    bodyBuilder, f_10470_12053_12123(F, f_10470_12066_12105(F, f_10470_12074_12082(F), initialThreadIdField), managedThreadId));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10470, 11895, 12140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 12156, 12184);

                f_10470_12156_12183(
                            bodyBuilder, f_10470_12172_12182(F));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 12198, 12255);

                f_10470_12198_12254(F, f_10470_12212_12253(F, f_10470_12220_12252(bodyBuilder)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 12269, 12288);

                bodyBuilder = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 11188, 12299);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_11488_11516(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 11488, 11516);
                    return return_v;
                }


                int
                f_10470_11475_11540(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11475, 11540);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_11577_11605(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 11577, 11605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10470_11638_11680()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11638, 11680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10470_11711_11733(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.BaseInitialization();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11711, 11733);
                    return return_v;
                }


                int
                f_10470_11695_11734(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11695, 11734);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10470_11786_11794(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11786, 11794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10470_11778_11807(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11778, 11807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_11821_11838(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 11821, 11838);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10470_11821_11849(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 11821, 11849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10470_11809_11853(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11809, 11853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10470_11765_11854(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundParameter
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11765, 11854);
                    return return_v;
                }


                int
                f_10470_11749_11855(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 11749, 11855);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10470_12074_12082(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12074, 12082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10470_12066_12105(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12066, 12105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10470_12053_12123(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12053, 12123);
                    return return_v;
                }


                int
                f_10470_12037_12124(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12037, 12124);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10470_12172_12182(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12172, 12182);
                    return return_v;
                }


                int
                f_10470_12156_12183(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12156, 12183);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10470_12220_12252(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12220, 12252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10470_12212_12253(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12212, 12253);
                    return return_v;
                }


                int
                f_10470_12198_12254(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12198, 12254);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 11188, 12299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 11188, 12299);
            }
        }

        protected override void InitializeStateMachine(ArrayBuilder<BoundStatement> bodyBuilder, NamedTypeSymbol frameType, LocalSymbol stateMachineLocal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 12311, 13008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 12669, 12782);

                int
                initialState = (DynAbs.Tracing.TraceSender.Conditional_F1(10470, 12688, 12701) || ((_isEnumerable && DynAbs.Tracing.TraceSender.Conditional_F2(10470, 12704, 12743)) || DynAbs.Tracing.TraceSender.Conditional_F3(10470, 12746, 12781))) ? StateMachineStates.FinishedStateMachine : StateMachineStates.FirstUnusedState
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 12796, 12997);

                f_10470_12796_12996(bodyBuilder, f_10470_12830_12995(F, f_10470_12865_12891(F, stateMachineLocal), f_10470_12914_12994(F, f_10470_12920_12968(f_10470_12920_12948(stateMachineType), frameType), f_10470_12970_12993(F, initialState))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 12311, 13008);

                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10470_12865_12891(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12865, 12891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_12920_12948(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10470, 12920, 12948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10470_12920_12968(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12920, 12968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10470_12970_12993(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12970, 12993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10470_12914_12994(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.New(ctor, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12914, 12994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10470_12830_12995(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12830, 12995);
                    return return_v;
                }


                int
                f_10470_12796_12996(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 12796, 12996);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 12311, 13008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 12311, 13008);
            }
        }

        protected override BoundStatement GenerateStateMachineCreation(LocalSymbol stateMachineVariable, NamedTypeSymbol frameType, IReadOnlyDictionary<Symbol, CapturedSymbolReplacement> proxies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 13020, 13601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 13232, 13293);

                var
                bodyBuilder = f_10470_13250_13292()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 13309, 13382);

                f_10470_13309_13381(
                            bodyBuilder, f_10470_13325_13380(this, stateMachineVariable, proxies));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 13428, 13525);

                f_10470_13428_13524(
                            // return local;
                            bodyBuilder, f_10470_13462_13523(F, f_10470_13493_13522(F, stateMachineVariable)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 13541, 13590);

                return f_10470_13548_13589(F, f_10470_13556_13588(bodyBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 13020, 13601);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10470_13250_13292()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 13250, 13292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10470_13325_13380(Microsoft.CodeAnalysis.CSharp.IteratorRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                stateMachineVariable, System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                proxies)
                {
                    var return_v = this_param.GenerateParameterStorage(stateMachineVariable, proxies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 13325, 13380);
                    return return_v;
                }


                int
                f_10470_13309_13381(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 13309, 13381);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10470_13493_13522(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 13493, 13522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10470_13462_13523(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 13462, 13523);
                    return return_v;
                }


                int
                f_10470_13428_13524(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 13428, 13524);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10470_13556_13588(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 13556, 13588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10470_13548_13589(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 13548, 13589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 13020, 13601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 13020, 13601);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GenerateMoveNextAndDispose(
                    SynthesizedImplementationMethod moveNextMethod,
                    SynthesizedImplementationMethod disposeMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10470, 13613, 14290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 13799, 14190);

                var
                rewriter = f_10470_13814_14189(F, method, stateField, _currentField, hoistedVariables, nonReusableLocalProxies, synthesizedLocalOrdinals, slotAllocatorOpt, nextFreeHoistedLocalSlot, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10470, 14206, 14279);

                f_10470_14206_14278(
                            rewriter, body, moveNextMethod, disposeMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10470, 13613, 14290);

                Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                f_10470_13814_14189(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                originalMethod, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                state, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                current, Microsoft.CodeAnalysis.Collections.IOrderedReadOnlySet<Microsoft.CodeAnalysis.CSharp.Symbol>
                hoistedVariables, System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                nonReusableLocalProxies, Microsoft.CodeAnalysis.CodeGen.SynthesizedLocalOrdinalsDispenser
                synthesizedLocalOrdinals, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, int
                nextFreeHoistedLocalSlot, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter(F, originalMethod, state, current, (Roslyn.Utilities.IReadOnlySet<Microsoft.CodeAnalysis.CSharp.Symbol>)hoistedVariables, nonReusableLocalProxies, synthesizedLocalOrdinals, slotAllocatorOpt, nextFreeHoistedLocalSlot, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 13814, 14189);
                    return return_v;
                }


                int
                f_10470_14206_14278(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                moveNextMethod, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                disposeMethod)
                {
                    this_param.GenerateMoveNextAndDispose(body, moveNextMethod, disposeMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10470, 14206, 14278);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10470, 13613, 14290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 13613, 14290);
            }
        }

        static IteratorRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10470, 548, 14297);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10470, 548, 14297);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10470, 548, 14297);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10470, 548, 14297);

        static Microsoft.CodeAnalysis.CSharp.BoundStatement
        f_10470_1268_1272_C(Microsoft.CodeAnalysis.CSharp.BoundStatement
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10470, 925, 1614);
            return return_v;
        }

    }
}
