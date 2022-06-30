// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{
    internal sealed partial class ControlFlowGraphBuilder
    {
        internal struct Context
        {

            public readonly IOperation? ImplicitInstance;

            public readonly INamedTypeSymbol? AnonymousType;

            public readonly ImmutableArray<KeyValuePair<IPropertySymbol, IOperation>> AnonymousTypePropertyValues;

            internal Context(IOperation? implicitInstance, INamedTypeSymbol? anonymousType, ImmutableArray<KeyValuePair<IPropertySymbol, IOperation>> anonymousTypePropertyValues)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(454, 969, 1496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(454, 1168, 1221);

                    f_454_1168_1220(f_454_1181_1219_M(!anonymousTypePropertyValues.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(454, 1239, 1303);

                    f_454_1239_1302(implicitInstance == null || (DynAbs.Tracing.TraceSender.Expression_False(454, 1252, 1301) || anonymousType == null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(454, 1321, 1357);

                    ImplicitInstance = implicitInstance;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(454, 1375, 1405);

                    AnonymousType = anonymousType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(454, 1423, 1481);

                    AnonymousTypePropertyValues = anonymousTypePropertyValues;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(454, 969, 1496);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(454, 969, 1496);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(454, 969, 1496);
                }
            }
            static Context()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(454, 682, 1507);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(454, 682, 1507);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(454, 682, 1507);
            }

            static bool
            f_454_1181_1219_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(454, 1181, 1219);
                return return_v;
            }


            static int
            f_454_1168_1220(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(454, 1168, 1220);
                return 0;
            }


            static int
            f_454_1239_1302(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(454, 1239, 1302);
                return 0;
            }

        }

        private Context GetCurrentContext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(454, 1519, 1901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(454, 1579, 1890);

                return f_454_1586_1889(_currentImplicitInstance.ImplicitInstance, _currentImplicitInstance.AnonymousType, f_454_1766_1785(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_currentImplicitInstance.AnonymousTypePropertyValues, 454, 1713, 1785)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.IPropertySymbol, Microsoft.CodeAnalysis.IOperation>>?>(454, 1713, 1888) ?? ImmutableArray<KeyValuePair<IPropertySymbol, IOperation>>.Empty));
                DynAbs.Tracing.TraceSender.TraceExitMethod(454, 1519, 1901);

                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.IPropertySymbol, Microsoft.CodeAnalysis.IOperation>>?
                f_454_1766_1785(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.IPropertySymbol, Microsoft.CodeAnalysis.IOperation>
                items)
                {
                    var return_v = items?.ToImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.IPropertySymbol, Microsoft.CodeAnalysis.IOperation>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(454, 1766, 1785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.Context
                f_454_1586_1889(Microsoft.CodeAnalysis.IOperation?
                implicitInstance, Microsoft.CodeAnalysis.INamedTypeSymbol?
                anonymousType, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.IPropertySymbol, Microsoft.CodeAnalysis.IOperation>>
                anonymousTypePropertyValues)
                {
                    var return_v = new Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.Context(implicitInstance, anonymousType, anonymousTypePropertyValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(454, 1586, 1889);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(454, 1519, 1901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(454, 1519, 1901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetCurrentContext(in Context context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(454, 1913, 2063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(454, 1988, 2052);

                _currentImplicitInstance = f_454_2015_2051(context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(454, 1913, 2063);

                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.ImplicitInstanceInfo
                f_454_2015_2051(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.Context
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.ImplicitInstanceInfo(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(454, 2015, 2051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(454, 1913, 2063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(454, 1913, 2063);
            }
        }
    }
}
