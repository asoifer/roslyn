// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class StateMachineTypeSymbol : SynthesizedContainer, ISynthesizedMethodBodyImplementationSymbol
    {
        private ImmutableArray<CSharpAttributeData> _attributes;

        public readonly MethodSymbol KickoffMethod;

        public StateMachineTypeSymbol(VariableSlotAllocator slotAllocatorOpt, TypeCompilationState compilationState, MethodSymbol kickoffMethod, int kickoffMethodOrdinal)
        : base(f_10544_946_1027_C(f_10544_946_1027(slotAllocatorOpt, compilationState, kickoffMethod, kickoffMethodOrdinal)), kickoffMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10544, 763, 1164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 737, 750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 1068, 1104);

                f_10544_1068_1103(kickoffMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 1118, 1153);

                this.KickoffMethod = kickoffMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10544, 763, 1164);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10544, 763, 1164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10544, 763, 1164);
            }
        }

        private static string MakeName(VariableSlotAllocator slotAllocatorOpt, TypeCompilationState compilationState, MethodSymbol kickoffMethod, int kickoffMethodOrdinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10544, 1176, 1594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 1364, 1583);

                return f_10544_1371_1417_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(slotAllocatorOpt, 10544, 1371, 1417)?.PreviousStateMachineTypeName) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10544, 1371, 1582) ?? f_10544_1441_1582(f_10544_1481_1499(kickoffMethod), kickoffMethodOrdinal, f_10544_1523_1581(compilationState.ModuleBuilderOpt)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10544, 1176, 1594);

                string?
                f_10544_1371_1417_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10544, 1371, 1417);
                    return return_v;
                }


                string
                f_10544_1481_1499(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10544, 1481, 1499);
                    return return_v;
                }


                int
                f_10544_1523_1581(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                this_param)
                {
                    var return_v = this_param.CurrentGenerationOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10544, 1523, 1581);
                    return return_v;
                }


                string
                f_10544_1441_1582(string
                methodName, int
                methodOrdinal, int
                generation)
                {
                    var return_v = GeneratedNames.MakeStateMachineTypeName(methodName, methodOrdinal, generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 1441, 1582);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10544, 1176, 1594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10544, 1176, 1594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int SequenceNumber(MethodSymbol kickoffMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10544, 1606, 2145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 1821, 1835);

                int
                count = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 1849, 2105);
                    foreach (var m in f_10544_1867_1926_I(f_10544_1867_1926(f_10544_1867_1895(kickoffMethod), f_10544_1907_1925(kickoffMethod))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10544, 1849, 2105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 1960, 1968);

                        count++;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 1986, 2090) || true) && ((object)kickoffMethod == m)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10544, 1986, 2090);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 2058, 2071);

                            return count;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10544, 1986, 2090);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10544, 1849, 2105);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10544, 1, 257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10544, 1, 257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 2121, 2134);

                return count;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10544, 1606, 2145);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10544_1867_1895(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10544, 1867, 1895);
                    return return_v;
                }


                string
                f_10544_1907_1925(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10544, 1907, 1925);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10544_1867_1926(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 1867, 1926);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10544_1867_1926_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 1867, 1926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10544, 1606, 2145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10544, 1606, 2145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10544, 2221, 2265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 2227, 2263);

                    return f_10544_2234_2262(KickoffMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10544, 2221, 2265);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10544_2234_2262(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10544, 2234, 2262);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10544, 2157, 2276);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10544, 2157, 2276);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISynthesizedMethodBodyImplementationSymbol.HasMethodBodyDependency
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10544, 2384, 2534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 2507, 2519);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10544, 2384, 2534);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10544, 2288, 2545);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10544, 2288, 2545);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbolInternal ISynthesizedMethodBodyImplementationSymbol.Method
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10544, 2653, 2682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 2659, 2680);

                    return KickoffMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10544, 2653, 2682);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10544, 2557, 2693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10544, 2557, 2693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10544, 2705, 4238);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 2804, 4192) || true) && (_attributes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10544, 2804, 4192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 2863, 2910);

                    f_10544_2863_2909(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetAttributes(), 10544, 2876, 2896).Length == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 2930, 2979);

                    ArrayBuilder<CSharpAttributeData>
                    builder = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 3084, 3131);

                    var
                    kickoffType = f_10544_3102_3130(KickoffMethod)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 3149, 3824);
                        foreach (var attribute in f_10544_3175_3202_I(f_10544_3175_3202(kickoffType)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10544, 3149, 3824);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 3244, 3805) || true) && (f_10544_3248_3339(attribute, kickoffType, AttributeDescription.DebuggerNonUserCodeAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10544, 3248, 3459) || f_10544_3368_3459(attribute, kickoffType, AttributeDescription.DebuggerStepThroughAttribute)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10544, 3244, 3805);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 3509, 3731) || true) && (builder == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10544, 3509, 3731);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 3586, 3645);

                                    builder = f_10544_3596_3644(2);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10544, 3509, 3731);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 3759, 3782);

                                f_10544_3759_3781(
                                                        builder, attribute);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10544, 3244, 3805);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10544, 3149, 3824);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10544, 1, 676);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10544, 1, 676);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 3844, 4177);

                    f_10544_3844_4176(ref _attributes, (DynAbs.Tracing.TraceSender.Conditional_F1(10544, 3974, 3989) || ((builder == null && DynAbs.Tracing.TraceSender.Conditional_F2(10544, 3992, 4033)) || DynAbs.Tracing.TraceSender.Conditional_F3(10544, 4036, 4064))) ? ImmutableArray<CSharpAttributeData>.Empty : f_10544_4036_4064(builder), default(ImmutableArray<CSharpAttributeData>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10544, 2804, 4192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 4208, 4227);

                return _attributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10544, 2705, 4238);

                int
                f_10544_2863_2909(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 2863, 2909);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10544_3102_3130(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10544, 3102, 3130);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10544_3175_3202(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 3175, 3202);
                    return return_v;
                }


                bool
                f_10544_3248_3339(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 3248, 3339);
                    return return_v;
                }


                bool
                f_10544_3368_3459(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 3368, 3459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10544_3596_3644(int
                capacity)
                {
                    var return_v = ArrayBuilder<CSharpAttributeData>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 3596, 3644);
                    return return_v;
                }


                int
                f_10544_3759_3781(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 3759, 3781);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10544_3175_3202_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 3175, 3202);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10544_4036_4064(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 4036, 4064);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10544_3844_4176(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 3844, 4176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10544, 2705, 4238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10544, 2705, 4238);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10544, 4294, 4326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 4297, 4326);
                    return f_10544_4297_4326(KickoffMethod); DynAbs.Tracing.TraceSender.TraceExitMethod(10544, 4294, 4326);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10544, 4294, 4326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10544, 4294, 4326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasCodeAnalysisEmbeddedAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10544, 4395, 4403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10544, 4398, 4403);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10544, 4395, 4403);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10544, 4395, 4403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10544, 4395, 4403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static StateMachineTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10544, 512, 4411);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10544, 512, 4411);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10544, 512, 4411);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10544, 512, 4411);

        static string
        f_10544_946_1027(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
        slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
        compilationState, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        kickoffMethod, int
        kickoffMethodOrdinal)
        {
            var return_v = MakeName(slotAllocatorOpt, compilationState, kickoffMethod, kickoffMethodOrdinal);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 946, 1027);
            return return_v;
        }


        int
        f_10544_1068_1103(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10544, 1068, 1103);
            return 0;
        }


        static string
        f_10544_946_1027_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10544, 763, 1164);
            return return_v;
        }


        bool
        f_10544_4297_4326(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.AreLocalsZeroed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10544, 4297, 4326);
            return return_v;
        }

    }
}
