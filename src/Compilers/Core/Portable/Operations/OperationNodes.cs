// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Operations
{
    internal sealed class NoneOperation : Operation
    {
        public NoneOperation(ImmutableArray<IOperation> children, SemanticModel? semanticModel, SyntaxNode syntax, ITypeSymbol? type, ConstantValue? constantValue, bool isImplicit) : base(f_471_829_842_C(semanticModel), syntax, isImplicit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 636, 1024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 2074, 2116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 2126, 2190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 888, 934);

                Children = f_471_899_933(children, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 948, 960);

                Type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 974, 1013);

                OperationConstantValue = constantValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 636, 1024);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 636, 1024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 636, 1024);
            }
        }

        internal ImmutableArray<IOperation> Children { get; }

        protected override IOperation GetCurrent(int slot, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 1176, 1387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 1179, 1387);
                return slot switch
                {
                    0 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 1225, 1253) || true) && (index < f_471_1238_1246().Length) && (DynAbs.Tracing.TraceSender.Expression_True(471, 1225, 1253) || true)
                        => f_471_1278_1286()[index],
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 1312, 1372) && DynAbs.Tracing.TraceSender.Expression_True(471, 1312, 1372))
    => throw f_471_1323_1372((slot, index))
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 1176, 1387);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 1176, 1387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 1176, 1387);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
            f_471_1238_1246()
            {
                var return_v = Children;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 1238, 1246);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
            f_471_1278_1286()
            {
                var return_v = Children;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 1278, 1286);
                return return_v;
            }


            System.Exception
            f_471_1323_1372((int slot, int index)
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 1323, 1372);
                return return_v;
            }

        }

        protected override (bool hasNext, int nextSlot, int nextIndex) MoveNext(int previousSlot, int previousIndex)
        {
            switch (previousSlot)
            {
                case -1:
                    if (!Children.IsEmpty) return (true, 0, 0);
                    else goto case 0;
                case 0 when previousIndex + 1 < Children.Length:
                    return (true, 0, previousIndex + 1);
                case 0:
                case 1:
                    return (false, 1, 0);
                default:
                    throw ExceptionUtilities.UnexpectedValue((previousSlot, previousIndex));
            }
        }

        public override ITypeSymbol? Type { get; }

        internal override ConstantValue? OperationConstantValue { get; }

        public override OperationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 2235, 2256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 2238, 2256);
                    return OperationKind.None; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 2235, 2256);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 2235, 2256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 2235, 2256);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void Accept(OperationVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 2269, 2391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 2347, 2380);

                f_471_2347_2379(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 2269, 2391);

                int
                f_471_2347_2379(Microsoft.CodeAnalysis.Operations.OperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.NoneOperation
                operation)
                {
                    this_param.VisitNoneOperation((Microsoft.CodeAnalysis.IOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 2347, 2379);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 2269, 2391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 2269, 2391);
            }
        }

        public override TResult? Accept<TArgument, TResult>(OperationVisitor<TArgument, TResult> visitor, TArgument argument) where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 2403, 2630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 2569, 2619);

                return f_471_2576_2618(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 2403, 2630);

                TResult?
                f_471_2576_2618(Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.Operations.NoneOperation
                operation, TArgument?
                argument)
                {
                    var return_v = this_param.VisitNoneOperation((Microsoft.CodeAnalysis.IOperation)operation, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 2576, 2618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 2403, 2630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 2403, 2630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NoneOperation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(471, 572, 2637);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(471, 572, 2637);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 572, 2637);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(471, 572, 2637);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        f_471_899_933(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        operations, Microsoft.CodeAnalysis.Operations.NoneOperation
        parent)
        {
            var return_v = SetParentOperation(operations, (Microsoft.CodeAnalysis.IOperation)parent);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 899, 933);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SemanticModel?
        f_471_829_842_C(Microsoft.CodeAnalysis.SemanticModel?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 636, 1024);
            return return_v;
        }

    }
    internal partial class ConversionOperation
    {
        public IMethodSymbol? OperatorMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 2741, 2767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 2744, 2767);
                    return f_471_2744_2754().MethodSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 2741, 2767);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 2741, 2767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 2741, 2767);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.Operations.CommonConversion
        f_471_2744_2754()
        {
            var return_v = Conversion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 2744, 2754);
            return return_v;
        }

    }
    internal sealed partial class InvalidOperation : Operation, IInvalidOperation
    {
        public InvalidOperation(ImmutableArray<IOperation> children, SemanticModel? semanticModel, SyntaxNode syntax, ITypeSymbol? type, ConstantValue? constantValue, bool isImplicit) : base(f_471_3073_3086_C(semanticModel), syntax, isImplicit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 2877, 3371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 4421, 4463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 4473, 4537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 3178, 3221);

                f_471_3178_3220(children.All(o => o != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 3235, 3281);

                Children = f_471_3246_3280(children, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 3295, 3307);

                Type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 3321, 3360);

                OperationConstantValue = constantValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 2877, 3371);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 2877, 3371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 2877, 3371);
            }
        }

        internal ImmutableArray<IOperation> Children { get; }

        protected override IOperation GetCurrent(int slot, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 3523, 3734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 3526, 3734);
                return slot switch
                {
                    0 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 3572, 3600) || true) && (index < f_471_3585_3593().Length) && (DynAbs.Tracing.TraceSender.Expression_True(471, 3572, 3600) || true)
                        => f_471_3625_3633()[index],
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 3659, 3719) && DynAbs.Tracing.TraceSender.Expression_True(471, 3659, 3719))
    => throw f_471_3670_3719((slot, index))
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 3523, 3734);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 3523, 3734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 3523, 3734);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
            f_471_3585_3593()
            {
                var return_v = Children;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 3585, 3593);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
            f_471_3625_3633()
            {
                var return_v = Children;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 3625, 3633);
                return return_v;
            }


            System.Exception
            f_471_3670_3719((int slot, int index)
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 3670, 3719);
                return return_v;
            }

        }

        protected override (bool hasNext, int nextSlot, int nextIndex) MoveNext(int previousSlot, int previousIndex)
        {
            switch (previousSlot)
            {
                case -1:
                    if (!Children.IsEmpty) return (true, 0, 0);
                    else goto case 0;
                case 0 when previousIndex + 1 < Children.Length:
                    return (true, 0, previousIndex + 1);
                case 0:
                case 1:
                    return (false, 1, 0);
                default:
                    throw ExceptionUtilities.UnexpectedValue((previousSlot, previousIndex));
            }
        }

        public override ITypeSymbol? Type { get; }

        internal override ConstantValue? OperationConstantValue { get; }

        public override OperationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 4582, 4606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 4585, 4606);
                    return OperationKind.Invalid; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 4582, 4606);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 4582, 4606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 4582, 4606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void Accept(OperationVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 4619, 4735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 4697, 4724);

                f_471_4697_4723(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 4619, 4735);

                int
                f_471_4697_4723(Microsoft.CodeAnalysis.Operations.OperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.InvalidOperation
                operation)
                {
                    this_param.VisitInvalid((Microsoft.CodeAnalysis.Operations.IInvalidOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 4697, 4723);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 4619, 4735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 4619, 4735);
            }
        }

        public override TResult? Accept<TArgument, TResult>(OperationVisitor<TArgument, TResult> visitor, TArgument argument) where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 4747, 4968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 4913, 4957);

                return f_471_4920_4956(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 4747, 4968);

                TResult?
                f_471_4920_4956(Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.Operations.InvalidOperation
                operation, TArgument?
                argument)
                {
                    var return_v = this_param.VisitInvalid((Microsoft.CodeAnalysis.Operations.IInvalidOperation)operation, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 4920, 4956);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 4747, 4968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 4747, 4968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static InvalidOperation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(471, 2783, 4975);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(471, 2783, 4975);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 2783, 4975);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(471, 2783, 4975);

        static int
        f_471_3178_3220(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 3178, 3220);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        f_471_3246_3280(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        operations, Microsoft.CodeAnalysis.Operations.InvalidOperation
        parent)
        {
            var return_v = SetParentOperation(operations, (Microsoft.CodeAnalysis.IOperation)parent);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 3246, 3280);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SemanticModel?
        f_471_3073_3086_C(Microsoft.CodeAnalysis.SemanticModel?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 2877, 3371);
            return return_v;
        }

    }
    internal sealed class FlowAnonymousFunctionOperation : Operation, IFlowAnonymousFunctionOperation
    {
        public readonly ControlFlowGraphBuilder.Context Context;

        public readonly IAnonymousFunctionOperation Original;

        public FlowAnonymousFunctionOperation(in ControlFlowGraphBuilder.Context context, IAnonymousFunctionOperation original, bool isImplicit) : base(semanticModel: f_471_5385_5404_C(null), f_471_5406_5421(original), isImplicit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 5228, 5522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 5207, 5215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 5459, 5477);

                Context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 5491, 5511);

                Original = original;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 5228, 5522);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 5228, 5522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 5228, 5522);
            }
        }

        public IMethodSymbol Symbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 5560, 5578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 5563, 5578);
                    return f_471_5563_5578(Original); DynAbs.Tracing.TraceSender.TraceExitMethod(471, 5560, 5578);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 5560, 5578);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 5560, 5578);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override IOperation GetCurrent(int slot, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 5653, 5711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 5656, 5711);
                throw f_471_5662_5711((slot, index)); DynAbs.Tracing.TraceSender.TraceExitMethod(471, 5653, 5711);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 5653, 5711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 5653, 5711);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_471_5662_5711((int slot, int index)
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 5662, 5711);
                return return_v;
            }

        }

        protected override (bool hasNext, int nextSlot, int nextIndex) MoveNext(int previousSlot, int previousIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 5831, 5869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 5834, 5869);
                return (false, int.MinValue, int.MinValue); DynAbs.Tracing.TraceSender.TraceExitMethod(471, 5831, 5869);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 5831, 5869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 5831, 5869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override OperationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 5917, 5955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 5920, 5955);
                    return OperationKind.FlowAnonymousFunction; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 5917, 5955);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 5917, 5955);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 5917, 5955);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ITypeSymbol? Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 6000, 6007);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 6003, 6007);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 6000, 6007);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 6000, 6007);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 6000, 6007);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue? OperationConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 6074, 6081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 6077, 6081);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 6074, 6081);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 6074, 6081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 6074, 6081);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void Accept(OperationVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 6094, 6224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 6172, 6213);

                f_471_6172_6212(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 6094, 6224);

                int
                f_471_6172_6212(Microsoft.CodeAnalysis.Operations.OperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.FlowAnonymousFunctionOperation
                operation)
                {
                    this_param.VisitFlowAnonymousFunction((Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 6172, 6212);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 6094, 6224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 6094, 6224);
            }
        }

        public override TResult? Accept<TArgument, TResult>(OperationVisitor<TArgument, TResult> visitor, TArgument argument) where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 6234, 6469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 6400, 6458);

                return f_471_6407_6457(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 6234, 6469);

                TResult?
                f_471_6407_6457(Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.Operations.FlowAnonymousFunctionOperation
                operation, TArgument?
                argument)
                {
                    var return_v = this_param.VisitFlowAnonymousFunction((Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation)operation, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 6407, 6457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 6234, 6469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 6234, 6469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FlowAnonymousFunctionOperation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(471, 4983, 6476);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(471, 4983, 6476);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 4983, 6476);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(471, 4983, 6476);

        static Microsoft.CodeAnalysis.SyntaxNode
        f_471_5406_5421(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
        this_param)
        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 5406, 5421);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SemanticModel?
        f_471_5385_5404_C(Microsoft.CodeAnalysis.SemanticModel?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 5228, 5522);
            return return_v;
        }


        Microsoft.CodeAnalysis.IMethodSymbol
        f_471_5563_5578(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
        this_param)
        {
            var return_v = this_param.Symbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 5563, 5578);
            return return_v;
        }

    }
    internal abstract partial class BaseMemberReferenceOperation : IMemberReferenceOperation
    {
        public abstract ISymbol Member { get; }
    }
    internal sealed partial class MethodReferenceOperation
    {
        public override ISymbol Member
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 6745, 6754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 6748, 6754);
                    return f_471_6748_6754(); DynAbs.Tracing.TraceSender.TraceExitMethod(471, 6745, 6754);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 6745, 6754);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 6745, 6754);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.IMethodSymbol
        f_471_6748_6754()
        {
            var return_v = Method;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 6748, 6754);
            return return_v;
        }

    }
    internal sealed partial class PropertyReferenceOperation
    {
        public override ISymbol Member
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 6874, 6885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 6877, 6885);
                    return f_471_6877_6885(); DynAbs.Tracing.TraceSender.TraceExitMethod(471, 6874, 6885);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 6874, 6885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 6874, 6885);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.IPropertySymbol
        f_471_6877_6885()
        {
            var return_v = Property;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 6877, 6885);
            return return_v;
        }

    }
    internal sealed partial class EventReferenceOperation
    {
        public override ISymbol Member
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 7002, 7010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 7005, 7010);
                    return f_471_7005_7010(); DynAbs.Tracing.TraceSender.TraceExitMethod(471, 7002, 7010);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 7002, 7010);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 7002, 7010);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.IEventSymbol
        f_471_7005_7010()
        {
            var return_v = Event;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 7005, 7010);
            return return_v;
        }

    }
    internal sealed partial class FieldReferenceOperation
    {
        public override ISymbol Member
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 7127, 7135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 7130, 7135);
                    return f_471_7130_7135(); DynAbs.Tracing.TraceSender.TraceExitMethod(471, 7127, 7135);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 7127, 7135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 7127, 7135);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.IFieldSymbol
        f_471_7130_7135()
        {
            var return_v = Field;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 7130, 7135);
            return return_v;
        }

    }
    internal sealed partial class RangeCaseClauseOperation
    {
        public override CaseKind CaseKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 7256, 7273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 7259, 7273);
                    return CaseKind.Range; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 7256, 7273);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 7256, 7273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 7256, 7273);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class SingleValueCaseClauseOperation
    {
        public override CaseKind CaseKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 7400, 7423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 7403, 7423);
                    return CaseKind.SingleValue; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 7400, 7423);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 7400, 7423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 7400, 7423);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class RelationalCaseClauseOperation
    {
        public override CaseKind CaseKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 7549, 7571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 7552, 7571);
                    return CaseKind.Relational; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 7549, 7571);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 7549, 7571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 7549, 7571);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class DefaultCaseClauseOperation
    {
        public override CaseKind CaseKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 7694, 7713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 7697, 7713);
                    return CaseKind.Default; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 7694, 7713);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 7694, 7713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 7694, 7713);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class PatternCaseClauseOperation
    {
        public override CaseKind CaseKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 7836, 7855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 7839, 7855);
                    return CaseKind.Pattern; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 7836, 7855);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 7836, 7855);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 7836, 7855);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal abstract partial class HasDynamicArgumentsExpression : Operation
    {
        protected HasDynamicArgumentsExpression(ImmutableArray<IOperation> arguments, ImmutableArray<string> argumentNames, ImmutableArray<RefKind> argumentRefKinds, SemanticModel? semanticModel, SyntaxNode syntax, ITypeSymbol? type, bool isImplicit) : base(f_471_8224_8237_C(semanticModel), syntax, isImplicit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 7961, 8462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 8664, 8706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 8283, 8331);

                Arguments = f_471_8295_8330(arguments, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 8345, 8375);

                ArgumentNames = argumentNames;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 8389, 8425);

                ArgumentRefKinds = argumentRefKinds;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 8439, 8451);

                Type = type;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 7961, 8462);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 7961, 8462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 7961, 8462);
            }
        }

        public ImmutableArray<string> ArgumentNames { get; }

        public ImmutableArray<RefKind> ArgumentRefKinds { get; }

        public ImmutableArray<IOperation> Arguments { get; }

        public override ITypeSymbol? Type { get; }

        static HasDynamicArgumentsExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(471, 7871, 8713);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(471, 7871, 8713);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 7871, 8713);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(471, 7871, 8713);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        f_471_8295_8330(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        operations, Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
        parent)
        {
            var return_v = SetParentOperation(operations, (Microsoft.CodeAnalysis.IOperation)parent);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 8295, 8330);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SemanticModel?
        f_471_8224_8237_C(Microsoft.CodeAnalysis.SemanticModel?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 7961, 8462);
            return return_v;
        }

    }
    internal sealed partial class DynamicObjectCreationOperation : HasDynamicArgumentsExpression, IDynamicObjectCreationOperation
    {
        public DynamicObjectCreationOperation(IObjectOrCollectionInitializerOperation? initializer, ImmutableArray<IOperation> arguments, ImmutableArray<string> argumentNames, ImmutableArray<RefKind> argumentRefKinds, SemanticModel? semanticModel, SyntaxNode syntax, ITypeSymbol? type, bool isImplicit) : base(f_471_9178_9187_C(arguments), argumentNames, argumentRefKinds, semanticModel, syntax, type, isImplicit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 8863, 9350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 9362, 9430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 9287, 9339);

                Initializer = f_471_9301_9338(initializer, this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 8863, 9350);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 8863, 9350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 8863, 9350);
            }
        }

        public IObjectOrCollectionInitializerOperation? Initializer { get; }

        internal override ConstantValue? OperationConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 9496, 9503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 9499, 9503);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 9496, 9503);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 9496, 9503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 9496, 9503);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override OperationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 9549, 9587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 9552, 9587);
                    return OperationKind.DynamicObjectCreation; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 9549, 9587);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 9549, 9587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 9549, 9587);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override IOperation GetCurrent(int slot, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 9675, 9970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 9678, 9970);
                return slot switch
                {
                    0 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 9724, 9753) || true) && (index < f_471_9737_9746().Length) && (DynAbs.Tracing.TraceSender.Expression_True(471, 9724, 9753) || true)
                        => f_471_9778_9787()[index],
                    1 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 9815, 9839) || true) && (f_471_9820_9831() != null) && (DynAbs.Tracing.TraceSender.Expression_True(471, 9815, 9839) || true)
                        => f_471_9864_9875(),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 9894, 9954) && DynAbs.Tracing.TraceSender.Expression_True(471, 9894, 9954))
    => throw f_471_9905_9954((slot, index)),
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 9675, 9970);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 9675, 9970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 9675, 9970);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
            f_471_9737_9746()
            {
                var return_v = Arguments;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 9737, 9746);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
            f_471_9778_9787()
            {
                var return_v = Arguments;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 9778, 9787);
                return return_v;
            }


            Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
            f_471_9820_9831()
            {
                var return_v = Initializer;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 9820, 9831);
                return return_v;
            }


            Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
            f_471_9864_9875()
            {
                var return_v = Initializer;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 9864, 9875);
                return return_v;
            }


            System.Exception
            f_471_9905_9954((int slot, int index)
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 9905, 9954);
                return return_v;
            }

        }

        protected override (bool hasNext, int nextSlot, int nextIndex) MoveNext(int previousSlot, int previousIndex)
        {
            switch (previousSlot)
            {
                case -1:
                    if (!Arguments.IsEmpty) return (true, 0, 0);
                    else goto case 0;

                case 0 when previousIndex + 1 < Arguments.Length:
                    return (true, 0, previousIndex + 1);

                case 0:
                    if (Initializer != null) return (true, 1, 0);
                    else goto case 1;

                case 1:
                case 2:
                    return (false, 2, 0);

                default:
                    throw ExceptionUtilities.UnexpectedValue((previousSlot, previousIndex));
            }
        }

        public override void Accept(OperationVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 10798, 10928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 10876, 10917);

                f_471_10876_10916(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 10798, 10928);

                int
                f_471_10876_10916(Microsoft.CodeAnalysis.Operations.OperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.DynamicObjectCreationOperation
                operation)
                {
                    this_param.VisitDynamicObjectCreation((Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 10876, 10916);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 10798, 10928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 10798, 10928);
            }
        }

        public override TResult? Accept<TArgument, TResult>(OperationVisitor<TArgument, TResult> visitor, TArgument argument) where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 10938, 11173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 11104, 11162);

                return f_471_11111_11161(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 10938, 11173);

                TResult?
                f_471_11111_11161(Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.Operations.DynamicObjectCreationOperation
                operation, TArgument?
                argument)
                {
                    var return_v = this_param.VisitDynamicObjectCreation((Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation)operation, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 11111, 11161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 10938, 11173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 10938, 11173);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DynamicObjectCreationOperation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(471, 8721, 11180);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(471, 8721, 11180);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 8721, 11180);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(471, 8721, 11180);

        static Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
        f_471_9301_9338(Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
        operation, Microsoft.CodeAnalysis.Operations.DynamicObjectCreationOperation
        parent)
        {
            var return_v = SetParentOperation(operation, (Microsoft.CodeAnalysis.IOperation)parent);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 9301, 9338);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        f_471_9178_9187_C(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 8863, 9350);
            return return_v;
        }

    }
    internal sealed partial class DynamicInvocationOperation : HasDynamicArgumentsExpression, IDynamicInvocationOperation
    {
        public DynamicInvocationOperation(IOperation operation, ImmutableArray<IOperation> arguments, ImmutableArray<string> argumentNames, ImmutableArray<RefKind> argumentRefKinds, SemanticModel? semanticModel, SyntaxNode syntax, ITypeSymbol? type, bool isImplicit) : base(f_471_11601_11610_C(arguments), argumentNames, argumentRefKinds, semanticModel, syntax, type, isImplicit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 11322, 11769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 12973, 13009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 11710, 11758);

                Operation = f_471_11722_11757(operation, this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 11322, 11769);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 11322, 11769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 11322, 11769);
            }
        }

        protected override IOperation GetCurrent(int slot, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 11856, 12147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 11859, 12147);
                return slot switch
                {
                    0 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 11905, 11927) || true) && (f_471_11910_11919() != null) && (DynAbs.Tracing.TraceSender.Expression_True(471, 11905, 11927) || true)
                        => f_471_11952_11961(),
                    1 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 11982, 12011) || true) && (index < f_471_11995_12004().Length) && (DynAbs.Tracing.TraceSender.Expression_True(471, 11982, 12011) || true)
                        => f_471_12036_12045()[index],
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 12071, 12131) && DynAbs.Tracing.TraceSender.Expression_True(471, 12071, 12131))
    => throw f_471_12082_12131((slot, index)),
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 11856, 12147);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 11856, 12147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 11856, 12147);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.IOperation
            f_471_11910_11919()
            {
                var return_v = Operation;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 11910, 11919);
                return return_v;
            }


            Microsoft.CodeAnalysis.IOperation
            f_471_11952_11961()
            {
                var return_v = Operation;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 11952, 11961);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
            f_471_11995_12004()
            {
                var return_v = Arguments;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 11995, 12004);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
            f_471_12036_12045()
            {
                var return_v = Arguments;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 12036, 12045);
                return return_v;
            }


            System.Exception
            f_471_12082_12131((int slot, int index)
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 12082, 12131);
                return return_v;
            }

        }

        protected override (bool hasNext, int nextSlot, int nextIndex) MoveNext(int previousSlot, int previousIndex)
        {
            switch (previousSlot)
            {
                case -1:
                    if (Operation != null) return (true, 0, 0);
                    else goto case 0;

                case 0:
                    if (!Arguments.IsEmpty) return (true, 1, 0);
                    else goto case 1;

                case 1 when previousIndex + 1 < Arguments.Length:
                    return (true, 1, previousIndex + 1);

                case 1:
                case 2:
                    return (false, 2, 0);

                default:
                    throw ExceptionUtilities.UnexpectedValue((previousSlot, previousIndex));
            }
        }

        public IOperation Operation { get; }

        internal override ConstantValue? OperationConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 13075, 13082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 13078, 13082);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 13075, 13082);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 13075, 13082);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 13075, 13082);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override OperationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 13128, 13162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 13131, 13162);
                    return OperationKind.DynamicInvocation; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 13128, 13162);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 13128, 13162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 13128, 13162);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void Accept(OperationVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 13175, 13301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 13253, 13290);

                f_471_13253_13289(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 13175, 13301);

                int
                f_471_13253_13289(Microsoft.CodeAnalysis.Operations.OperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.DynamicInvocationOperation
                operation)
                {
                    this_param.VisitDynamicInvocation((Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 13253, 13289);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 13175, 13301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 13175, 13301);
            }
        }

        public override TResult? Accept<TArgument, TResult>(OperationVisitor<TArgument, TResult> visitor, TArgument argument) where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 13311, 13542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 13477, 13531);

                return f_471_13484_13530(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 13311, 13542);

                TResult?
                f_471_13484_13530(Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.Operations.DynamicInvocationOperation
                operation, TArgument?
                argument)
                {
                    var return_v = this_param.VisitDynamicInvocation((Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation)operation, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 13484, 13530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 13311, 13542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 13311, 13542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DynamicInvocationOperation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(471, 11188, 13549);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(471, 11188, 13549);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 11188, 13549);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(471, 11188, 13549);

        static Microsoft.CodeAnalysis.IOperation?
        f_471_11722_11757(Microsoft.CodeAnalysis.IOperation
        operation, Microsoft.CodeAnalysis.Operations.DynamicInvocationOperation
        parent)
        {
            var return_v = SetParentOperation(operation, (Microsoft.CodeAnalysis.IOperation)parent);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 11722, 11757);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        f_471_11601_11610_C(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 11322, 11769);
            return return_v;
        }

    }
    internal sealed partial class DynamicIndexerAccessOperation : HasDynamicArgumentsExpression, IDynamicIndexerAccessOperation
    {
        public DynamicIndexerAccessOperation(IOperation operation, ImmutableArray<IOperation> arguments, ImmutableArray<string> argumentNames, ImmutableArray<RefKind> argumentRefKinds, SemanticModel? semanticModel, SyntaxNode syntax, ITypeSymbol? type, bool isImplicit) : base(f_471_13979_13988_C(arguments), argumentNames, argumentRefKinds, semanticModel, syntax, type, isImplicit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 13697, 14147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 14159, 14195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 14088, 14136);

                Operation = f_471_14100_14135(operation, this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 13697, 14147);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 13697, 14147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 13697, 14147);
            }
        }

        public IOperation Operation { get; }

        internal override ConstantValue? OperationConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 14261, 14268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 14264, 14268);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 14261, 14268);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 14261, 14268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 14261, 14268);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override OperationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 14314, 14351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 14317, 14351);
                    return OperationKind.DynamicIndexerAccess; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 14314, 14351);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 14314, 14351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 14314, 14351);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override IOperation GetCurrent(int slot, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 14439, 14730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 14442, 14730);
                return slot switch
                {
                    0 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 14488, 14510) || true) && (f_471_14493_14502() != null) && (DynAbs.Tracing.TraceSender.Expression_True(471, 14488, 14510) || true)
                        => f_471_14535_14544(),
                    1 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 14565, 14594) || true) && (index < f_471_14578_14587().Length) && (DynAbs.Tracing.TraceSender.Expression_True(471, 14565, 14594) || true)
                        => f_471_14619_14628()[index],
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 14654, 14714) && DynAbs.Tracing.TraceSender.Expression_True(471, 14654, 14714))
    => throw f_471_14665_14714((slot, index)),
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 14439, 14730);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 14439, 14730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 14439, 14730);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.IOperation
            f_471_14493_14502()
            {
                var return_v = Operation;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 14493, 14502);
                return return_v;
            }


            Microsoft.CodeAnalysis.IOperation
            f_471_14535_14544()
            {
                var return_v = Operation;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 14535, 14544);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
            f_471_14578_14587()
            {
                var return_v = Arguments;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 14578, 14587);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
            f_471_14619_14628()
            {
                var return_v = Arguments;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 14619, 14628);
                return return_v;
            }


            System.Exception
            f_471_14665_14714((int slot, int index)
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 14665, 14714);
                return return_v;
            }

        }

        protected override (bool hasNext, int nextSlot, int nextIndex) MoveNext(int previousSlot, int previousIndex)
        {
            switch (previousSlot)
            {
                case -1:
                    if (Operation != null) return (true, 0, 0);
                    else goto case 0;

                case 0:
                    if (!Arguments.IsEmpty) return (true, 1, 0);
                    else goto case 1;

                case 1 when previousIndex + 1 < Arguments.Length:
                    return (true, 1, previousIndex + 1);

                case 1:
                case 2:
                    return (false, 2, 0);

                default:
                    throw ExceptionUtilities.UnexpectedValue((previousSlot, previousIndex));
            }
        }

        public override void Accept(OperationVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 15556, 15685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 15634, 15674);

                f_471_15634_15673(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 15556, 15685);

                int
                f_471_15634_15673(Microsoft.CodeAnalysis.Operations.OperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.DynamicIndexerAccessOperation
                operation)
                {
                    this_param.VisitDynamicIndexerAccess((Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 15634, 15673);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 15556, 15685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 15556, 15685);
            }
        }

        public override TResult? Accept<TArgument, TResult>(OperationVisitor<TArgument, TResult> visitor, TArgument argument) where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 15695, 15929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 15861, 15918);

                return f_471_15868_15917(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 15695, 15929);

                TResult?
                f_471_15868_15917(Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.Operations.DynamicIndexerAccessOperation
                operation, TArgument?
                argument)
                {
                    var return_v = this_param.VisitDynamicIndexerAccess((Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation)operation, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 15868, 15917);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 15695, 15929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 15695, 15929);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DynamicIndexerAccessOperation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(471, 13557, 15936);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(471, 13557, 15936);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 13557, 15936);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(471, 13557, 15936);

        static Microsoft.CodeAnalysis.IOperation?
        f_471_14100_14135(Microsoft.CodeAnalysis.IOperation
        operation, Microsoft.CodeAnalysis.Operations.DynamicIndexerAccessOperation
        parent)
        {
            var return_v = SetParentOperation(operation, (Microsoft.CodeAnalysis.IOperation)parent);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 14100, 14135);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        f_471_13979_13988_C(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 13697, 14147);
            return return_v;
        }

    }
    internal sealed partial class ForEachLoopOperation
    {
        public override LoopKind LoopKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 16045, 16064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 16048, 16064);
                    return LoopKind.ForEach; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 16045, 16064);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 16045, 16064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 16045, 16064);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class ForLoopOperation
    {
        public override LoopKind LoopKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 16177, 16192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 16180, 16192);
                    return LoopKind.For; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 16177, 16192);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 16177, 16192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 16177, 16192);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class ForToLoopOperation
    {
        public override LoopKind LoopKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 16307, 16324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 16310, 16324);
                    return LoopKind.ForTo; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 16307, 16324);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 16307, 16324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 16307, 16324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class WhileLoopOperation
    {
        protected override IOperation GetCurrent(int slot, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 16405, 17500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 16491, 16564);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(471, 16498, 16512) || ((f_471_16498_16512() && DynAbs.Tracing.TraceSender.Conditional_F2(471, 16515, 16536)) || DynAbs.Tracing.TraceSender.Conditional_F3(471, 16539, 16563))) ? f_471_16515_16536() : f_471_16539_16563();

                IOperation getCurrentSwitchTop()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 16630, 17024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 16633, 17024);
                        return slot switch
                        {
                            0 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 16687, 16709) || true) && (f_471_16692_16701() != null) && (DynAbs.Tracing.TraceSender.Expression_True(471, 16687, 16709) || true)
                                => f_471_16738_16747(),
                            1 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 16772, 16789) || true) && (f_471_16777_16781() != null) && (DynAbs.Tracing.TraceSender.Expression_True(471, 16772, 16789) || true)
                                => f_471_16818_16822(),
                            2 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 16847, 16876) || true) && (f_471_16852_16868() != null) && (DynAbs.Tracing.TraceSender.Expression_True(471, 16847, 16876) || true)
                                => f_471_16905_16921(),
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 16944, 17004) && DynAbs.Tracing.TraceSender.Expression_True(471, 16944, 17004))
        => throw f_471_16955_17004((slot, index)),
                        }; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 16630, 17024);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 16630, 17024);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 16630, 17024);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                IOperation getCurrentSwitchBottom()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 17094, 17488);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 17097, 17488);
                        return slot switch
                        {
                            0 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 17151, 17168) || true) && (f_471_17156_17160() != null) && (DynAbs.Tracing.TraceSender.Expression_True(471, 17151, 17168) || true)
                                => f_471_17197_17201(),
                            1 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 17226, 17248) || true) && (f_471_17231_17240() != null) && (DynAbs.Tracing.TraceSender.Expression_True(471, 17226, 17248) || true)
                                => f_471_17277_17286(),
                            2 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 17311, 17340) || true) && (f_471_17316_17332() != null) && (DynAbs.Tracing.TraceSender.Expression_True(471, 17311, 17340) || true)
                                => f_471_17369_17385(),
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 17408, 17468) && DynAbs.Tracing.TraceSender.Expression_True(471, 17408, 17468))
        => throw f_471_17419_17468((slot, index)),
                        }; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 17094, 17488);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 17094, 17488);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 17094, 17488);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 16405, 17500);

                bool
                f_471_16498_16512()
                {
                    var return_v = ConditionIsTop;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 16498, 16512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_471_16515_16536()
                {
                    var return_v = getCurrentSwitchTop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 16515, 16536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_471_16539_16563()
                {
                    var return_v = getCurrentSwitchBottom();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 16539, 16563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_471_16692_16701()
                {
                    var return_v = Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 16692, 16701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_471_16738_16747()
                {
                    var return_v = Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 16738, 16747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_471_16777_16781()
                {
                    var return_v = Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 16777, 16781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_471_16818_16822()
                {
                    var return_v = Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 16818, 16822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_471_16852_16868()
                {
                    var return_v = IgnoredCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 16852, 16868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_471_16905_16921()
                {
                    var return_v = IgnoredCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 16905, 16921);
                    return return_v;
                }


                System.Exception
                f_471_16955_17004((int slot, int index)
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 16955, 17004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_471_17156_17160()
                {
                    var return_v = Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 17156, 17160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_471_17197_17201()
                {
                    var return_v = Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 17197, 17201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_471_17231_17240()
                {
                    var return_v = Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 17231, 17240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_471_17277_17286()
                {
                    var return_v = Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 17277, 17286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_471_17316_17332()
                {
                    var return_v = IgnoredCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 17316, 17332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_471_17369_17385()
                {
                    var return_v = IgnoredCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 17369, 17385);
                    return return_v;
                }


                System.Exception
                f_471_17419_17468((int slot, int index)
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 17419, 17468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 16405, 17500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 16405, 17500);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override (bool hasNext, int nextSlot, int nextIndex) MoveNext(int previousSlot, int previousIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 17512, 19438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 17645, 17724);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(471, 17652, 17666) || ((f_471_17652_17666() && DynAbs.Tracing.TraceSender.Conditional_F2(471, 17669, 17693)) || DynAbs.Tracing.TraceSender.Conditional_F3(471, 17696, 17723))) ? f_471_17669_17693() : f_471_17696_17723();

                (bool hasNext, int nextSlot, int nextIndex) moveNextConditionIsTop()
                {
                    switch (previousSlot)
                    {
                        case -1:
                            if (Condition != null) return (true, 0, 0);
                            else goto case 0;
                        case 0:
                            if (Body != null) return (true, 1, 0);
                            else goto case 1;
                        case 1:
                            if (IgnoredCondition != null) return (true, 2, 0);
                            else goto case 2;
                        case 2:
                        case 3:
                            return (false, 3, 0);
                        default:
                            throw ExceptionUtilities.UnexpectedValue((previousSlot, previousIndex));
                    }
                }

                (bool hasNext, int nextSlot, int nextIndex) moveNextConditionIsBottom()
                {
                    switch (previousSlot)
                    {
                        case -1:
                            if (Body != null) return (true, 0, 0);
                            else goto case 0;
                        case 0:
                            if (Condition != null) return (true, 1, 0);
                            else goto case 1;
                        case 1:
                            if (IgnoredCondition != null) return (true, 2, 0);
                            else goto case 2;
                        case 2:
                        case 3:
                            return (false, 3, 0);
                        default:
                            throw ExceptionUtilities.UnexpectedValue((previousSlot, previousIndex));
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(471, 17512, 19438);

                bool
                f_471_17652_17666()
                {
                    var return_v = ConditionIsTop;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(471, 17652, 17666);
                    return return_v;
                }


                (bool hasNext, int nextSlot, int nextIndex)
                f_471_17669_17693()
                {
                    var return_v = moveNextConditionIsTop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 17669, 17693);
                    return return_v;
                }


                (bool hasNext, int nextSlot, int nextIndex)
                f_471_17696_17723()
                {
                    var return_v = moveNextConditionIsBottom();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 17696, 17723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 17512, 19438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 17512, 19438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override LoopKind LoopKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 19484, 19501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 19487, 19501);
                    return LoopKind.While; DynAbs.Tracing.TraceSender.TraceExitMethod(471, 19484, 19501);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 19484, 19501);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 19484, 19501);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class FlowCaptureReferenceOperation
    {
        public FlowCaptureReferenceOperation(int id, SyntaxNode syntax, ITypeSymbol? type, ConstantValue? constantValue) : this(f_471_19726_19743_C(f_471_19726_19743(id)), semanticModel: null, syntax: syntax, type: type, constantValue: constantValue, isImplicit: true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 19593, 19863);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 19593, 19863);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 19593, 19863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 19593, 19863);
            }
        }

        static Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
        f_471_19726_19743(int
        value)
        {
            var return_v = new Microsoft.CodeAnalysis.FlowAnalysis.CaptureId(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 19726, 19743);
            return return_v;
        }


        static Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
        f_471_19726_19743_C(Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 19593, 19863);
            return return_v;
        }

    }
    internal sealed partial class FlowCaptureOperation
    {
        public FlowCaptureOperation(int id, SyntaxNode syntax, IOperation value) : this(f_471_20038_20055_C(f_471_20038_20055(id)), value, semanticModel: null, syntax: syntax, isImplicit: true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 19945, 20182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 20143, 20171);

                f_471_20143_20170(value != null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 19945, 20182);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 19945, 20182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 19945, 20182);
            }
        }

        static Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
        f_471_20038_20055(int
        value)
        {
            var return_v = new Microsoft.CodeAnalysis.FlowAnalysis.CaptureId(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 20038, 20055);
            return return_v;
        }


        static int
        f_471_20143_20170(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 20143, 20170);
            return 0;
        }


        static Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
        f_471_20038_20055_C(Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 19945, 20182);
            return return_v;
        }

    }
    internal sealed partial class IsNullOperation
    {
        public IsNullOperation(SyntaxNode syntax, IOperation operand, ITypeSymbol type, ConstantValue? constantValue) : this(f_471_20389_20396_C(operand), semanticModel: null, syntax: syntax, type: type, constantValue: constantValue, isImplicit: true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 20259, 20560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 20519, 20549);

                f_471_20519_20548(operand != null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 20259, 20560);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 20259, 20560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 20259, 20560);
            }
        }

        static int
        f_471_20519_20548(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 20519, 20548);
            return 0;
        }


        static Microsoft.CodeAnalysis.IOperation
        f_471_20389_20396_C(Microsoft.CodeAnalysis.IOperation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 20259, 20560);
            return return_v;
        }

    }
    internal sealed partial class CaughtExceptionOperation
    {
        public CaughtExceptionOperation(SyntaxNode syntax, ITypeSymbol type) : this(semanticModel: f_471_20735_20754_C(null), syntax: syntax, type: type, isImplicit: true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 20646, 20823);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 20646, 20823);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 20646, 20823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 20646, 20823);
            }
        }

        static Microsoft.CodeAnalysis.SemanticModel?
        f_471_20735_20754_C(Microsoft.CodeAnalysis.SemanticModel?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 20646, 20823);
            return return_v;
        }

    }
    internal sealed partial class StaticLocalInitializationSemaphoreOperation
    {
        public StaticLocalInitializationSemaphoreOperation(ILocalSymbol local, SyntaxNode syntax, ITypeSymbol type) : this(f_471_21056_21061_C(local), semanticModel: null, syntax, type, isImplicit: true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 20928, 21137);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 20928, 21137);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 20928, 21137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 20928, 21137);
            }
        }

        static Microsoft.CodeAnalysis.ILocalSymbol
        f_471_21056_21061_C(Microsoft.CodeAnalysis.ILocalSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 20928, 21137);
            return return_v;
        }

    }
    internal sealed partial class BlockOperation
    {
        public static BlockOperation CreateTemporaryBlock(ImmutableArray<IOperation> statements, SemanticModel semanticModel, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(471, 21698, 21754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 21701, 21754);
                return f_471_21701_21754(statements, semanticModel, syntax); DynAbs.Tracing.TraceSender.TraceExitMethod(471, 21698, 21754);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 21698, 21754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 21698, 21754);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Operations.BlockOperation
            f_471_21701_21754(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
            statements, Microsoft.CodeAnalysis.SemanticModel
            semanticModel, Microsoft.CodeAnalysis.SyntaxNode
            syntax)
            {
                var return_v = new Microsoft.CodeAnalysis.Operations.BlockOperation(statements, semanticModel, syntax);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 21701, 21754);
                return return_v;
            }

        }

        private BlockOperation(ImmutableArray<IOperation> statements, SemanticModel semanticModel, SyntaxNode syntax)
        : base(f_471_21897_21910_C(semanticModel), syntax, isImplicit: true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(471, 21767, 22588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 22388, 22481);

                f_471_22388_22480(statements.All(s => s.Parent != this && s.Parent!.Kind == OperationKind.Block));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 22495, 22519);

                Operations = statements;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(471, 22533, 22577);

                Locals = ImmutableArray<ILocalSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(471, 21767, 22588);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(471, 21767, 22588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(471, 21767, 22588);
            }
        }

        static int
        f_471_22388_22480(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(471, 22388, 22480);
            return 0;
        }


        static Microsoft.CodeAnalysis.SemanticModel
        f_471_21897_21910_C(Microsoft.CodeAnalysis.SemanticModel
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(471, 21767, 22588);
            return return_v;
        }

    }
}
