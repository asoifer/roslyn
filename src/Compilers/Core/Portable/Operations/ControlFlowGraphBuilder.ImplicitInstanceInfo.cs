// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{
    internal partial class ControlFlowGraphBuilder
    {
        private struct ImplicitInstanceInfo
        {

            public IOperation? ImplicitInstance { get; }

            public INamedTypeSymbol? AnonymousType { get; }

            public PooledDictionary<IPropertySymbol, IOperation>? AnonymousTypePropertyValues { get; }

            public ImplicitInstanceInfo(IOperation currentImplicitInstance)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(456, 1566, 1876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 1662, 1708);

                    f_456_1662_1707(currentImplicitInstance != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 1726, 1769);

                    ImplicitInstance = currentImplicitInstance;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 1787, 1808);

                    AnonymousType = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 1826, 1861);

                    AnonymousTypePropertyValues = null;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(456, 1566, 1876);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(456, 1566, 1876);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(456, 1566, 1876);
                }
            }

            public ImplicitInstanceInfo(INamedTypeSymbol currentInitializedAnonymousType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(456, 1892, 2297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2002, 2064);

                    f_456_2002_2063(f_456_2015_2062(currentInitializedAnonymousType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2084, 2108);

                    ImplicitInstance = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2126, 2174);

                    AnonymousType = currentInitializedAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2192, 2282);

                    AnonymousTypePropertyValues = f_456_2222_2281();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(456, 1892, 2297);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(456, 1892, 2297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(456, 1892, 2297);
                }
            }

            public ImplicitInstanceInfo(in Context context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(456, 2313, 3513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2393, 2473);

                    f_456_2393_2472(context.ImplicitInstance == null || (DynAbs.Tracing.TraceSender.Expression_False(456, 2406, 2471) || context.AnonymousType == null));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2493, 3498) || true) && (context.ImplicitInstance != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(456, 2493, 3498);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2571, 2615);

                        ImplicitInstance = context.ImplicitInstance;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2637, 2658);

                        AnonymousType = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2680, 2715);

                        AnonymousTypePropertyValues = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(456, 2493, 3498);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(456, 2493, 3498);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2757, 3498) || true) && (context.AnonymousType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(456, 2757, 3498);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2832, 2856);

                            ImplicitInstance = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2878, 2916);

                            AnonymousType = context.AnonymousType;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 2938, 3028);

                            AnonymousTypePropertyValues = f_456_2968_3027();
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 3052, 3273);
                                foreach (KeyValuePair<IPropertySymbol, IOperation> pair in f_456_3111_3146_I(context.AnonymousTypePropertyValues))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(456, 3052, 3273);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 3196, 3250);

                                    f_456_3196_3249(AnonymousTypePropertyValues, pair.Key, pair.Value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(456, 3052, 3273);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(456, 1, 222);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(456, 1, 222);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(456, 2757, 3498);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(456, 2757, 3498);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 3355, 3379);

                            ImplicitInstance = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 3401, 3422);

                            AnonymousType = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 3444, 3479);

                            AnonymousTypePropertyValues = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(456, 2757, 3498);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(456, 2493, 3498);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(456, 2313, 3513);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(456, 2313, 3513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(456, 2313, 3513);
                }
            }

            public void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(456, 3529, 3631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(456, 3580, 3616);

                    // LAFHIS
                    //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => 
                    //DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(AnonymousTypePropertyValues, 456, 3580, 3615)?.Free(), 
                    //456, 3608, 3615);

                    DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(AnonymousTypePropertyValues, 456, 3580, 3615)?.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(456, 3608, 3615);

                    DynAbs.Tracing.TraceSender.TraceExitMethod(456, 3529, 3631);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(456, 3529, 3631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(456, 3529, 3631);
                }
            }
            static ImplicitInstanceInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(456, 753, 3642);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(456, 753, 3642);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(456, 753, 3642);
            }

            static int
            f_456_1662_1707(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(456, 1662, 1707);
                return 0;
            }


            static bool
            f_456_2015_2062(Microsoft.CodeAnalysis.INamedTypeSymbol
            this_param)
            {
                var return_v = this_param.IsAnonymousType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(456, 2015, 2062);
                return return_v;
            }


            static int
            f_456_2002_2063(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(456, 2002, 2063);
                return 0;
            }


            static Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.IPropertySymbol, Microsoft.CodeAnalysis.IOperation>
            f_456_2222_2281()
            {
                var return_v = PooledDictionary<IPropertySymbol, IOperation>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(456, 2222, 2281);
                return return_v;
            }


            static int
            f_456_2393_2472(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(456, 2393, 2472);
                return 0;
            }


            static Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.IPropertySymbol, Microsoft.CodeAnalysis.IOperation>
            f_456_2968_3027()
            {
                var return_v = PooledDictionary<IPropertySymbol, IOperation>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(456, 2968, 3027);
                return return_v;
            }


            static int
            f_456_3196_3249(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.IPropertySymbol, Microsoft.CodeAnalysis.IOperation>
            this_param, Microsoft.CodeAnalysis.IPropertySymbol
            key, Microsoft.CodeAnalysis.IOperation
            value)
            {
                this_param.Add(key, value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(456, 3196, 3249);
                return 0;
            }


            System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.IPropertySymbol, Microsoft.CodeAnalysis.IOperation>>
            f_456_3111_3146_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.IPropertySymbol, Microsoft.CodeAnalysis.IOperation>>
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(456, 3111, 3146);
                return return_v;
            }

        }
    }
}
