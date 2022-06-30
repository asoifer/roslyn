// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Operations
{
    internal sealed partial class OperationCloner : OperationVisitor<object?, IOperation>
    {
        [return: NotNullIfNotNull("operation")]
        public IOperation? Visit(IOperation? operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(467, 473, 645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(467, 594, 634);

                return f_467_601_633(this, operation, argument: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(467, 473, 645);

                Microsoft.CodeAnalysis.IOperation?
                f_467_601_633(Microsoft.CodeAnalysis.Operations.OperationCloner
                this_param, Microsoft.CodeAnalysis.IOperation?
                operation, object?
                argument)
                {
                    var return_v = this_param.Visit(operation, argument: argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 601, 633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(467, 473, 645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(467, 473, 645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IOperation VisitNoneOperation(IOperation operation, object? argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(467, 657, 1006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(467, 769, 995);

                return f_467_776_994(f_467_794_863(this, ((Operation)operation).ChildOperations.ToImmutableArray()), f_467_865_907(((Operation)operation)), f_467_909_925(operation), f_467_927_941(operation), f_467_943_971(operation), f_467_973_993(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(467, 657, 1006);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_467_794_863(Microsoft.CodeAnalysis.Operations.OperationCloner
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                nodes)
                {
                    var return_v = this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 794, 863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_467_865_907(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 865, 907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_467_909_925(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 909, 925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_467_927_941(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 927, 941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_467_943_971(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = operation.GetConstantValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 943, 971);
                    return return_v;
                }


                bool
                f_467_973_993(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 973, 993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.NoneOperation
                f_467_776_994(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                children, Microsoft.CodeAnalysis.SemanticModel?
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ITypeSymbol?
                type, Microsoft.CodeAnalysis.ConstantValue?
                constantValue, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.NoneOperation(children, semanticModel, syntax, type, constantValue, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 776, 994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(467, 657, 1006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(467, 657, 1006);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IOperation VisitFlowAnonymousFunction(IFlowAnonymousFunctionOperation operation, object? argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(467, 1018, 1346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(467, 1157, 1215);

                var
                anonymous = (FlowAnonymousFunctionOperation)operation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(467, 1229, 1335);

                return f_467_1236_1334(anonymous.Context, anonymous.Original, f_467_1313_1333(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(467, 1018, 1346);

                bool
                f_467_1313_1333(Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 1313, 1333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.FlowAnonymousFunctionOperation
                f_467_1236_1334(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.Context
                context, Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
                original, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.FlowAnonymousFunctionOperation(context, original, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 1236, 1334);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(467, 1018, 1346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(467, 1018, 1346);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IOperation VisitDynamicObjectCreation(IDynamicObjectCreationOperation operation, object? argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(467, 1358, 1832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(467, 1497, 1821);

                return f_467_1504_1820(f_467_1539_1567(this, f_467_1545_1566(operation)), f_467_1569_1600(this, f_467_1580_1599(operation)), f_467_1602_1658(((HasDynamicArgumentsExpression)operation)), f_467_1660_1719(((HasDynamicArgumentsExpression)operation)), f_467_1721_1763(((Operation)operation)), f_467_1765_1781(operation), f_467_1783_1797(operation), f_467_1799_1819(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(467, 1358, 1832);

                Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
                f_467_1545_1566(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 1545, 1566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
                f_467_1539_1567(Microsoft.CodeAnalysis.Operations.OperationCloner
                this_param, Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
                node)
                {
                    var return_v = this_param.Visit<Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 1539, 1567);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_467_1580_1599(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 1580, 1599);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_467_1569_1600(Microsoft.CodeAnalysis.Operations.OperationCloner
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                nodes)
                {
                    var return_v = this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 1569, 1600);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_467_1602_1658(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
                this_param)
                {
                    var return_v = this_param.ArgumentNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 1602, 1658);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_467_1660_1719(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 1660, 1719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_467_1721_1763(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 1721, 1763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_467_1765_1781(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 1765, 1781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_467_1783_1797(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 1783, 1797);
                    return return_v;
                }


                bool
                f_467_1799_1819(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 1799, 1819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.DynamicObjectCreationOperation
                f_467_1504_1820(Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
                initializer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKinds, Microsoft.CodeAnalysis.SemanticModel?
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ITypeSymbol?
                type, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.DynamicObjectCreationOperation(initializer, arguments, argumentNames, argumentRefKinds, semanticModel, syntax, type, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 1504, 1820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(467, 1358, 1832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(467, 1358, 1832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IOperation VisitDynamicInvocation(IDynamicInvocationOperation operation, object? argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(467, 1844, 2304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(467, 1975, 2293);

                return f_467_1982_2292(f_467_2013_2039(this, f_467_2019_2038(operation)), f_467_2041_2072(this, f_467_2052_2071(operation)), f_467_2074_2130(((HasDynamicArgumentsExpression)operation)), f_467_2132_2191(((HasDynamicArgumentsExpression)operation)), f_467_2193_2235(((Operation)operation)), f_467_2237_2253(operation), f_467_2255_2269(operation), f_467_2271_2291(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(467, 1844, 2304);

                Microsoft.CodeAnalysis.IOperation
                f_467_2019_2038(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2019, 2038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_467_2013_2039(Microsoft.CodeAnalysis.Operations.OperationCloner
                this_param, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = this_param.Visit(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 2013, 2039);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_467_2052_2071(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2052, 2071);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_467_2041_2072(Microsoft.CodeAnalysis.Operations.OperationCloner
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                nodes)
                {
                    var return_v = this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 2041, 2072);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_467_2074_2130(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
                this_param)
                {
                    var return_v = this_param.ArgumentNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2074, 2130);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_467_2132_2191(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2132, 2191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_467_2193_2235(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2193, 2235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_467_2237_2253(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2237, 2253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_467_2255_2269(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2255, 2269);
                    return return_v;
                }


                bool
                f_467_2271_2291(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2271, 2291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.DynamicInvocationOperation
                f_467_1982_2292(Microsoft.CodeAnalysis.IOperation
                operation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKinds, Microsoft.CodeAnalysis.SemanticModel?
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ITypeSymbol?
                type, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.DynamicInvocationOperation(operation, arguments, argumentNames, argumentRefKinds, semanticModel, syntax, type, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 1982, 2292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(467, 1844, 2304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(467, 1844, 2304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IOperation VisitDynamicIndexerAccess(IDynamicIndexerAccessOperation operation, object? argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(467, 2316, 2785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(467, 2453, 2774);

                return f_467_2460_2773(f_467_2494_2520(this, f_467_2500_2519(operation)), f_467_2522_2553(this, f_467_2533_2552(operation)), f_467_2555_2611(((HasDynamicArgumentsExpression)operation)), f_467_2613_2672(((HasDynamicArgumentsExpression)operation)), f_467_2674_2716(((Operation)operation)), f_467_2718_2734(operation), f_467_2736_2750(operation), f_467_2752_2772(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(467, 2316, 2785);

                Microsoft.CodeAnalysis.IOperation
                f_467_2500_2519(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2500, 2519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_467_2494_2520(Microsoft.CodeAnalysis.Operations.OperationCloner
                this_param, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = this_param.Visit(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 2494, 2520);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_467_2533_2552(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2533, 2552);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_467_2522_2553(Microsoft.CodeAnalysis.Operations.OperationCloner
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                nodes)
                {
                    var return_v = this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 2522, 2553);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_467_2555_2611(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
                this_param)
                {
                    var return_v = this_param.ArgumentNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2555, 2611);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_467_2613_2672(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2613, 2672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_467_2674_2716(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2674, 2716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_467_2718_2734(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2718, 2734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_467_2736_2750(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2736, 2750);
                    return return_v;
                }


                bool
                f_467_2752_2772(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2752, 2772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.DynamicIndexerAccessOperation
                f_467_2460_2773(Microsoft.CodeAnalysis.IOperation
                operation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKinds, Microsoft.CodeAnalysis.SemanticModel?
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ITypeSymbol?
                type, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.DynamicIndexerAccessOperation(operation, arguments, argumentNames, argumentRefKinds, semanticModel, syntax, type, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 2460, 2773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(467, 2316, 2785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(467, 2316, 2785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IOperation VisitInvalid(IInvalidOperation operation, object? argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(467, 2797, 3129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(467, 2908, 3118);

                return f_467_2915_3117(f_467_2936_2986(this, f_467_2947_2985(((InvalidOperation)operation))), f_467_2988_3030(((Operation)operation)), f_467_3032_3048(operation), f_467_3050_3064(operation), f_467_3066_3094(operation), f_467_3096_3116(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(467, 2797, 3129);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_467_2947_2985(Microsoft.CodeAnalysis.Operations.InvalidOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2947, 2985);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_467_2936_2986(Microsoft.CodeAnalysis.Operations.OperationCloner
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                nodes)
                {
                    var return_v = this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 2936, 2986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_467_2988_3030(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 2988, 3030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_467_3032_3048(Microsoft.CodeAnalysis.Operations.IInvalidOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 3032, 3048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_467_3050_3064(Microsoft.CodeAnalysis.Operations.IInvalidOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 3050, 3064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_467_3066_3094(Microsoft.CodeAnalysis.Operations.IInvalidOperation
                operation)
                {
                    var return_v = operation.GetConstantValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 3066, 3094);
                    return return_v;
                }


                bool
                f_467_3096_3116(Microsoft.CodeAnalysis.Operations.IInvalidOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 3096, 3116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.InvalidOperation
                f_467_2915_3117(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                children, Microsoft.CodeAnalysis.SemanticModel?
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ITypeSymbol?
                type, Microsoft.CodeAnalysis.ConstantValue?
                constantValue, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.InvalidOperation(children, semanticModel, syntax, type, constantValue, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(467, 2915, 3117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(467, 2797, 3129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(467, 2797, 3129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IOperation VisitFlowCapture(IFlowCaptureOperation operation, object? argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(467, 3141, 3308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(467, 3260, 3297);

                throw f_467_3266_3296();
                DynAbs.Tracing.TraceSender.TraceExitMethod(467, 3141, 3308);

                System.Exception
                f_467_3266_3296()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 3266, 3296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(467, 3141, 3308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(467, 3141, 3308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IOperation VisitIsNull(IIsNullOperation operation, object? argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(467, 3320, 3477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(467, 3429, 3466);

                throw f_467_3435_3465();
                DynAbs.Tracing.TraceSender.TraceExitMethod(467, 3320, 3477);

                System.Exception
                f_467_3435_3465()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 3435, 3465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(467, 3320, 3477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(467, 3320, 3477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IOperation VisitCaughtException(ICaughtExceptionOperation operation, object? argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(467, 3489, 3664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(467, 3616, 3653);

                throw f_467_3622_3652();
                DynAbs.Tracing.TraceSender.TraceExitMethod(467, 3489, 3664);

                System.Exception
                f_467_3622_3652()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 3622, 3652);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(467, 3489, 3664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(467, 3489, 3664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IOperation VisitStaticLocalInitializationSemaphore(IStaticLocalInitializationSemaphoreOperation operation, object? argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(467, 3676, 3889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(467, 3841, 3878);

                throw f_467_3847_3877();
                DynAbs.Tracing.TraceSender.TraceExitMethod(467, 3676, 3889);

                System.Exception
                f_467_3847_3877()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(467, 3847, 3877);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(467, 3676, 3889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(467, 3676, 3889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
