// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundObjectCreationExpression : IBoundInvalidNode
    {
        internal static ImmutableArray<BoundExpression> GetChildInitializers(BoundExpression? objectOrCollectionInitializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10581, 426, 1171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 567, 667);

                var
                objectInitializerExpression = objectOrCollectionInitializer as BoundObjectInitializerExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 681, 817) || true) && (objectInitializerExpression != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10581, 681, 817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 754, 802);

                    return f_10581_761_801(objectInitializerExpression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10581, 681, 817);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 833, 941);

                var
                collectionInitializerExpression = objectOrCollectionInitializer as BoundCollectionInitializerExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 955, 1099) || true) && (collectionInitializerExpression != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10581, 955, 1099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 1032, 1084);

                    return f_10581_1039_1083(collectionInitializerExpression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10581, 955, 1099);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 1115, 1160);

                return ImmutableArray<BoundExpression>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10581, 426, 1171);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10581_761_801(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 761, 801);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10581_1039_1083(Microsoft.CodeAnalysis.CSharp.BoundCollectionInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 1039, 1083);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 426, 1171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 426, 1171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<BoundNode> IBoundInvalidNode.InvalidNodeChildren
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 1247, 1373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 1250, 1373);
                    return f_10581_1250_1373(receiverOpt: null, f_10581_1337_1346(), f_10581_1348_1372()); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 1247, 1373);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 1247, 1373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 1247, 1373);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_1337_1346()
        {
            var return_v = Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 1337, 1346);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
        f_10581_1348_1372()
        {
            var return_v = InitializerExpressionOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 1348, 1372);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
        f_10581_1250_1373(Microsoft.CodeAnalysis.CSharp.BoundNode?
        receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        arguments, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
        additionalNodeOpt)
        {
            var return_v = CSharpOperationFactory.CreateInvalidChildrenFromArgumentsExpression(receiverOpt: receiverOpt, arguments, (Microsoft.CodeAnalysis.CSharp.BoundExpression?)additionalNodeOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 1250, 1373);
            return return_v;
        }

    }
    internal sealed partial class BoundObjectInitializerMember : IBoundInvalidNode
    {
        ImmutableArray<BoundNode> IBoundInvalidNode.InvalidNodeChildren
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 1548, 1588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 1551, 1588);
                    return f_10581_1551_1588(f_10581_1578_1587()); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 1548, 1588);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 1548, 1588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 1548, 1588);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_1578_1587()
        {
            var return_v = Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 1578, 1587);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
        f_10581_1551_1588(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        from)
        {
            var return_v = StaticCast<BoundNode>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 1551, 1588);
            return return_v;
        }

    }
    internal sealed partial class BoundCollectionElementInitializer : IBoundInvalidNode
    {
        ImmutableArray<BoundNode> IBoundInvalidNode.InvalidNodeChildren
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 1768, 1870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 1771, 1870);
                    return f_10581_1771_1870(f_10581_1839_1858(), f_10581_1860_1869()); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 1768, 1870);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 1768, 1870);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 1768, 1870);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.BoundExpression?
        f_10581_1839_1858()
        {
            var return_v = ImplicitReceiverOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 1839, 1858);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_1860_1869()
        {
            var return_v = Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 1860, 1869);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
        f_10581_1771_1870(Microsoft.CodeAnalysis.CSharp.BoundExpression?
        receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        arguments)
        {
            var return_v = CSharpOperationFactory.CreateInvalidChildrenFromArgumentsExpression((Microsoft.CodeAnalysis.CSharp.BoundNode?)receiverOpt, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 1771, 1870);
            return return_v;
        }

    }
    internal sealed partial class BoundDeconstructionAssignmentOperator : BoundExpression
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 2043, 2102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 2046, 2102);
                    return f_10581_2046_2102(f_10581_2080_2089(this), f_10581_2091_2101(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 2043, 2102);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 2043, 2102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 2043, 2102);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundDeconstructionAssignmentOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 1886, 2110);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 1886, 2110);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 1886, 2110);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 1886, 2110);

        Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
        f_10581_2080_2089(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
        this_param)
        {
            var return_v = this_param.Left;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 2080, 2089);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundConversion
        f_10581_2091_2101(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
        this_param)
        {
            var return_v = this_param.Right;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 2091, 2101);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_2046_2102(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
        item1, Microsoft.CodeAnalysis.CSharp.BoundConversion
        item2)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item1, (Microsoft.CodeAnalysis.CSharp.BoundNode)item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 2046, 2102);
            return return_v;
        }

    }
    internal partial class BoundBadExpression : IBoundInvalidNode
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 2251, 2303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 2254, 2303);
                    return f_10581_2254_2303(f_10581_2282_2302(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 2251, 2303);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 2251, 2303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 2251, 2303);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<BoundNode> IBoundInvalidNode.InvalidNodeChildren
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 2380, 2431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 2383, 2431);
                    return f_10581_2383_2431(f_10581_2410_2430(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 2380, 2431);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 2380, 2431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 2380, 2431);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_2282_2302(Microsoft.CodeAnalysis.CSharp.BoundBadExpression
        this_param)
        {
            var return_v = this_param.ChildBoundNodes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 2282, 2302);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_2254_2303(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        from)
        {
            var return_v = StaticCast<BoundNode?>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 2254, 2303);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_2410_2430(Microsoft.CodeAnalysis.CSharp.BoundBadExpression
        this_param)
        {
            var return_v = this_param.ChildBoundNodes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 2410, 2430);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
        f_10581_2383_2431(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        from)
        {
            var return_v = StaticCast<BoundNode>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 2383, 2431);
            return return_v;
        }

    }
    internal partial class BoundCall : IBoundInvalidNode
    {
        ImmutableArray<BoundNode> IBoundInvalidNode.InvalidNodeChildren
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 2580, 2674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 2583, 2674);
                    return f_10581_2583_2674(f_10581_2651_2662(), f_10581_2664_2673()); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 2580, 2674);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 2580, 2674);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 2580, 2674);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.BoundExpression?
        f_10581_2651_2662()
        {
            var return_v = ReceiverOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 2651, 2662);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_2664_2673()
        {
            var return_v = Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 2664, 2673);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
        f_10581_2583_2674(Microsoft.CodeAnalysis.CSharp.BoundExpression?
        receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        arguments)
        {
            var return_v = CSharpOperationFactory.CreateInvalidChildrenFromArgumentsExpression((Microsoft.CodeAnalysis.CSharp.BoundNode?)receiverOpt, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 2583, 2674);
            return return_v;
        }

    }
    internal partial class BoundIndexerAccess : IBoundInvalidNode
    {
        ImmutableArray<BoundNode> IBoundInvalidNode.InvalidNodeChildren
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 2832, 2926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 2835, 2926);
                    return f_10581_2835_2926(f_10581_2903_2914(), f_10581_2916_2925()); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 2832, 2926);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 2832, 2926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 2832, 2926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.BoundExpression?
        f_10581_2903_2914()
        {
            var return_v = ReceiverOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 2903, 2914);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_2916_2925()
        {
            var return_v = Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 2916, 2925);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
        f_10581_2835_2926(Microsoft.CodeAnalysis.CSharp.BoundExpression?
        receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        arguments)
        {
            var return_v = CSharpOperationFactory.CreateInvalidChildrenFromArgumentsExpression((Microsoft.CodeAnalysis.CSharp.BoundNode?)receiverOpt, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 2835, 2926);
            return return_v;
        }

    }
    internal partial class BoundDynamicIndexerAccess
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 3062, 3133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 3065, 3133);
                    return f_10581_3065_3133(this.Arguments.Insert(0, f_10581_3118_3131(this))); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 3062, 3133);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 3062, 3133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 3062, 3133);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_3118_3131(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
        this_param)
        {
            var return_v = this_param.Receiver;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 3118, 3131);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_3065_3133(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        from)
        {
            var return_v = StaticCast<BoundNode?>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 3065, 3133);
            return return_v;
        }

    }
    internal partial class BoundAnonymousObjectCreationExpression
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 3282, 3328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 3285, 3328);
                    return f_10581_3285_3328(f_10581_3313_3327(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 3282, 3328);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 3282, 3328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 3282, 3328);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_3313_3327(Microsoft.CodeAnalysis.CSharp.BoundAnonymousObjectCreationExpression
        this_param)
        {
            var return_v = this_param.Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 3313, 3327);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_3285_3328(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        from)
        {
            var return_v = StaticCast<BoundNode?>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 3285, 3328);
            return return_v;
        }

    }
    internal partial class BoundAttribute
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 3453, 3540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 3456, 3540);
                    return f_10581_3456_3540(this.ConstructorArguments.AddRange(f_10581_3519_3538(this))); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 3453, 3540);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 3453, 3540);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 3453, 3540);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_3519_3538(Microsoft.CodeAnalysis.CSharp.BoundAttribute
        this_param)
        {
            var return_v = this_param.NamedArguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 3519, 3538);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_3456_3540(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        from)
        {
            var return_v = StaticCast<BoundNode?>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 3456, 3540);
            return return_v;
        }

    }
    internal partial class BoundQueryClause
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 3667, 3715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 3670, 3715);
                    return f_10581_3670_3715(f_10581_3704_3714(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 3667, 3715);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 3667, 3715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 3667, 3715);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundQueryClause()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 3556, 3723);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 3556, 3723);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 3556, 3723);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 3556, 3723);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_3704_3714(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 3704, 3714);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_3670_3715(Microsoft.CodeAnalysis.CSharp.BoundExpression
        item)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 3670, 3715);
            return return_v;
        }

    }
    internal partial class BoundArgListOperator
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 3846, 3892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 3849, 3892);
                    return f_10581_3849_3892(f_10581_3877_3891(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 3846, 3892);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 3846, 3892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 3846, 3892);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundArgListOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 3731, 3900);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 3731, 3900);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 3731, 3900);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 3731, 3900);

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_3877_3891(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
        this_param)
        {
            var return_v = this_param.Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 3877, 3891);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_3849_3892(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        from)
        {
            var return_v = StaticCast<BoundNode?>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 3849, 3892);
            return return_v;
        }

    }
    internal partial class BoundNameOfOperator
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 4022, 4073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 4025, 4073);
                    return f_10581_4025_4073(f_10581_4059_4072(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 4022, 4073);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 4022, 4073);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 4022, 4073);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_4059_4072(Microsoft.CodeAnalysis.CSharp.BoundNameOfOperator
        this_param)
        {
            var return_v = this_param.Argument;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 4059, 4072);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_4025_4073(Microsoft.CodeAnalysis.CSharp.BoundExpression
        item)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 4025, 4073);
            return return_v;
        }

    }
    internal partial class BoundPointerElementAccess
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 4209, 4274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 4212, 4274);
                    return f_10581_4212_4274(f_10581_4246_4261(this), f_10581_4263_4273(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 4209, 4274);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 4209, 4274);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 4209, 4274);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundPointerElementAccess()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 4089, 4282);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 4089, 4282);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 4089, 4282);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 4089, 4282);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_4246_4261(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
        this_param)
        {
            var return_v = this_param.Expression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 4246, 4261);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_4263_4273(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
        this_param)
        {
            var return_v = this_param.Index;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 4263, 4273);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_4212_4274(Microsoft.CodeAnalysis.CSharp.BoundExpression
        item1, Microsoft.CodeAnalysis.CSharp.BoundExpression
        item2)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item1, (Microsoft.CodeAnalysis.CSharp.BoundNode)item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 4212, 4274);
            return return_v;
        }

    }
    internal partial class BoundRefTypeOperator
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 4405, 4455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 4408, 4455);
                    return f_10581_4408_4455(f_10581_4442_4454(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 4405, 4455);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 4405, 4455);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 4405, 4455);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundRefTypeOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 4290, 4463);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 4290, 4463);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 4290, 4463);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 4290, 4463);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_4442_4454(Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator
        this_param)
        {
            var return_v = this_param.Operand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 4442, 4454);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_4408_4455(Microsoft.CodeAnalysis.CSharp.BoundExpression
        item)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 4408, 4455);
            return return_v;
        }

    }
    internal partial class BoundDynamicMemberAccess
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 4590, 4641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 4593, 4641);
                    return f_10581_4593_4641(f_10581_4627_4640(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 4590, 4641);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 4590, 4641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 4590, 4641);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundDynamicMemberAccess()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 4471, 4649);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 4471, 4649);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 4471, 4649);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 4471, 4649);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_4627_4640(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
        this_param)
        {
            var return_v = this_param.Receiver;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 4627, 4640);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_4593_4641(Microsoft.CodeAnalysis.CSharp.BoundExpression
        item)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 4593, 4641);
            return return_v;
        }

    }
    internal partial class BoundMakeRefOperator
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 4772, 4822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 4775, 4822);
                    return f_10581_4775_4822(f_10581_4809_4821(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 4772, 4822);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 4772, 4822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 4772, 4822);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundMakeRefOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 4657, 4830);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 4657, 4830);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 4657, 4830);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 4657, 4830);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_4809_4821(Microsoft.CodeAnalysis.CSharp.BoundMakeRefOperator
        this_param)
        {
            var return_v = this_param.Operand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 4809, 4821);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_4775_4822(Microsoft.CodeAnalysis.CSharp.BoundExpression
        item)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 4775, 4822);
            return return_v;
        }

    }
    internal partial class BoundRefValueOperator
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 4954, 5004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 4957, 5004);
                    return f_10581_4957_5004(f_10581_4991_5003(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 4954, 5004);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 4954, 5004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 4954, 5004);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundRefValueOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 4838, 5012);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 4838, 5012);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 4838, 5012);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 4838, 5012);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_4991_5003(Microsoft.CodeAnalysis.CSharp.BoundRefValueOperator
        this_param)
        {
            var return_v = this_param.Operand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 4991, 5003);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_4957_5004(Microsoft.CodeAnalysis.CSharp.BoundExpression
        item)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 4957, 5004);
            return return_v;
        }

    }
    internal partial class BoundDynamicInvocation
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 5137, 5210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 5140, 5210);
                    return f_10581_5140_5210(this.Arguments.Insert(0, f_10581_5193_5208(this))); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 5137, 5210);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 5137, 5210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 5137, 5210);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundDynamicInvocation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 5020, 5218);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 5020, 5218);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 5020, 5218);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 5020, 5218);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_5193_5208(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
        this_param)
        {
            var return_v = this_param.Expression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 5193, 5208);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_5140_5210(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        from)
        {
            var return_v = StaticCast<BoundNode?>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 5140, 5210);
            return return_v;
        }

    }
    internal partial class BoundFixedLocalCollectionInitializer
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 5357, 5410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 5360, 5410);
                    return f_10581_5360_5410(f_10581_5394_5409(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 5357, 5410);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 5357, 5410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 5357, 5410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundFixedLocalCollectionInitializer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 5226, 5418);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 5226, 5418);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 5226, 5418);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 5226, 5418);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_5394_5409(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
        this_param)
        {
            var return_v = this_param.Expression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 5394, 5409);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_5360_5410(Microsoft.CodeAnalysis.CSharp.BoundExpression
        item)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 5360, 5410);
            return return_v;
        }

    }
    internal partial class BoundStackAllocArrayCreationBase
    {
        internal static ImmutableArray<BoundExpression> GetChildInitializers(BoundArrayInitialization? arrayInitializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10581, 5498, 5725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 5635, 5714);

                return f_10581_5642_5672_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(arrayInitializer, 10581, 5642, 5672)?.Initializers) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>?>(10581, 5642, 5713) ?? ImmutableArray<BoundExpression>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10581, 5498, 5725);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                f_10581_5642_5672_M(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 5642, 5672);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 5498, 5725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 5498, 5725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundStackAllocArrayCreationBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 5426, 5732);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 5426, 5732);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 5426, 5732);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 5426, 5732);
    }
    internal partial class BoundStackAllocArrayCreation
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 5863, 5958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 5866, 5958);
                    return f_10581_5866_5958(f_10581_5894_5935(f_10581_5915_5934(this)).Insert(0, f_10581_5946_5956(this))); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 5863, 5958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 5863, 5958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 5863, 5958);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundStackAllocArrayCreation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 5740, 5966);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 5740, 5966);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 5740, 5966);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 5740, 5966);

        Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
        f_10581_5915_5934(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
        this_param)
        {
            var return_v = this_param.InitializerOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 5915, 5934);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_5894_5935(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
        arrayInitializer)
        {
            var return_v = GetChildInitializers(arrayInitializer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 5894, 5935);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_5946_5956(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 5946, 5956);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_5866_5958(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        from)
        {
            var return_v = StaticCast<BoundNode?>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 5866, 5958);
            return return_v;
        }

    }
    internal partial class BoundConvertedStackAllocExpression
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 6103, 6198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 6106, 6198);
                    return f_10581_6106_6198(f_10581_6134_6175(f_10581_6155_6174(this)).Insert(0, f_10581_6186_6196(this))); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 6103, 6198);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 6103, 6198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 6103, 6198);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundConvertedStackAllocExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 5974, 6206);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 5974, 6206);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 5974, 6206);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 5974, 6206);

        Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
        f_10581_6155_6174(Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
        this_param)
        {
            var return_v = this_param.InitializerOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 6155, 6174);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_6134_6175(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
        arrayInitializer)
        {
            var return_v = GetChildInitializers(arrayInitializer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 6134, 6175);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_6186_6196(Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 6186, 6196);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_6106_6198(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        from)
        {
            var return_v = StaticCast<BoundNode?>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 6106, 6198);
            return return_v;
        }

    }
    internal partial class BoundDynamicObjectCreationExpression
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 6345, 6483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 6348, 6483);
                    return f_10581_6348_6483(this.Arguments.AddRange(f_10581_6400_6481(f_10581_6451_6480(this)))); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 6345, 6483);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 6345, 6483);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 6345, 6483);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundDynamicObjectCreationExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 6214, 6491);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 6214, 6491);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 6214, 6491);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 6214, 6491);

        Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
        f_10581_6451_6480(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
        this_param)
        {
            var return_v = this_param.InitializerExpressionOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 6451, 6480);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_6400_6481(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
        objectOrCollectionInitializer)
        {
            var return_v = BoundObjectCreationExpression.GetChildInitializers((Microsoft.CodeAnalysis.CSharp.BoundExpression?)objectOrCollectionInitializer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 6400, 6481);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_6348_6483(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        from)
        {
            var return_v = StaticCast<BoundNode?>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 6348, 6483);
            return return_v;
        }

    }
    partial class BoundThrowExpression
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 6605, 6658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 6608, 6658);
                    return f_10581_6608_6658(f_10581_6642_6657(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 6605, 6658);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 6605, 6658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 6605, 6658);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundThrowExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 6499, 6666);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 6499, 6666);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 6499, 6666);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 6499, 6666);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_6642_6657(Microsoft.CodeAnalysis.CSharp.BoundThrowExpression
        this_param)
        {
            var return_v = this_param.Expression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 6642, 6657);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_6608_6658(Microsoft.CodeAnalysis.CSharp.BoundExpression
        item)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 6608, 6658);
            return return_v;
        }

    }
    internal abstract partial class BoundMethodOrPropertyGroup
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 6804, 6858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 6807, 6858);
                    return f_10581_6807_6858(f_10581_6841_6857(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 6804, 6858);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 6804, 6858);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 6804, 6858);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundMethodOrPropertyGroup()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 6674, 6866);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 6674, 6866);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 6674, 6866);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 6674, 6866);

        Microsoft.CodeAnalysis.CSharp.BoundExpression?
        f_10581_6841_6857(Microsoft.CodeAnalysis.CSharp.BoundMethodOrPropertyGroup
        this_param)
        {
            var return_v = this_param.ReceiverOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 6841, 6857);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_6807_6858(Microsoft.CodeAnalysis.CSharp.BoundExpression?
        item)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode?)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 6807, 6858);
            return return_v;
        }

    }
    internal partial class BoundSequence
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 6982, 7046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 6985, 7046);
                    return f_10581_6985_7046(this.SideEffects.Add(f_10581_7034_7044(this))); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 6982, 7046);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 6982, 7046);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 6982, 7046);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundSequence()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 6874, 7054);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 6874, 7054);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 6874, 7054);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 6874, 7054);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_7034_7044(Microsoft.CodeAnalysis.CSharp.BoundSequence
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 7034, 7044);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_6985_7046(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        from)
        {
            var return_v = StaticCast<BoundNode?>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 6985, 7046);
            return return_v;
        }

    }
    internal partial class BoundStatementList
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 7175, 7343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 7191, 7343);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10581, 7191, 7261) || (((f_10581_7192_7201(this) == BoundKind.StatementList || (DynAbs.Tracing.TraceSender.Expression_False(10581, 7192, 7260) || f_10581_7232_7241(this) == BoundKind.Scope)) && DynAbs.Tracing.TraceSender.Conditional_F2(10581, 7264, 7308)) || DynAbs.Tracing.TraceSender.Conditional_F3(10581, 7311, 7343))) ? f_10581_7264_7308(f_10581_7292_7307(this)) : ImmutableArray<BoundNode?>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 7175, 7343);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 7175, 7343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 7175, 7343);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.BoundKind
        f_10581_7192_7201(Microsoft.CodeAnalysis.CSharp.BoundStatementList
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 7192, 7201);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundKind
        f_10581_7232_7241(Microsoft.CodeAnalysis.CSharp.BoundStatementList
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 7232, 7241);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
        f_10581_7292_7307(Microsoft.CodeAnalysis.CSharp.BoundStatementList
        this_param)
        {
            var return_v = this_param.Statements;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 7292, 7307);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_7264_7308(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
        from)
        {
            var return_v = StaticCast<BoundNode?>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 7264, 7308);
            return return_v;
        }

    }
    internal partial class BoundPassByCopy
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 7469, 7522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 7472, 7522);
                    return f_10581_7472_7522(f_10581_7506_7521(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 7469, 7522);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 7469, 7522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 7469, 7522);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_7506_7521(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
        this_param)
        {
            var return_v = this_param.Expression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 7506, 7521);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_7472_7522(Microsoft.CodeAnalysis.CSharp.BoundExpression
        item)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 7472, 7522);
            return return_v;
        }

    }
    internal partial class BoundIndexOrRangePatternIndexerAccess
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 7670, 7726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 7673, 7726);
                    return f_10581_7673_7726(f_10581_7707_7715(), f_10581_7717_7725()); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 7670, 7726);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 7670, 7726);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 7670, 7726);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundIndexOrRangePatternIndexerAccess()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10581, 7538, 7734);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10581, 7538, 7734);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 7538, 7734);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10581, 7538, 7734);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_7707_7715()
        {
            var return_v = Receiver;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 7707, 7715);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_7717_7725()
        {
            var return_v = Argument;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 7717, 7725);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_7673_7726(Microsoft.CodeAnalysis.CSharp.BoundExpression
        item1, Microsoft.CodeAnalysis.CSharp.BoundExpression
        item2)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item1, (Microsoft.CodeAnalysis.CSharp.BoundNode)item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 7673, 7726);
            return return_v;
        }

    }
    internal partial class BoundFunctionPointerInvocation : IBoundInvalidNode
    {
        ImmutableArray<BoundNode> IBoundInvalidNode.InvalidNodeChildren
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 7896, 8014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 7899, 8014);
                    return f_10581_7899_8014(receiverOpt: f_10581_7980_8002(this), f_10581_8004_8013()); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 7896, 8014);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 7896, 8014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 7896, 8014);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10581, 8080, 8157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10581, 8083, 8157);
                    return f_10581_8083_8157(f_10581_8111_8156(((IBoundInvalidNode)this))); DynAbs.Tracing.TraceSender.TraceExitMethod(10581, 8080, 8157);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10581, 8080, 8157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10581, 8080, 8157);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10581_7980_8002(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
        this_param)
        {
            var return_v = this_param.InvokedExpression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 7980, 8002);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10581_8004_8013()
        {
            var return_v = Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 8004, 8013);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
        f_10581_7899_8014(Microsoft.CodeAnalysis.CSharp.BoundExpression
        receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        arguments)
        {
            var return_v = CSharpOperationFactory.CreateInvalidChildrenFromArgumentsExpression(receiverOpt: (Microsoft.CodeAnalysis.CSharp.BoundNode)receiverOpt, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 7899, 8014);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
        f_10581_8111_8156(Microsoft.CodeAnalysis.CSharp.IBoundInvalidNode
        this_param)
        {
            var return_v = this_param.InvalidNodeChildren;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10581, 8111, 8156);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10581_8083_8157(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
        from)
        {
            var return_v = StaticCast<BoundNode?>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10581, 8083, 8157);
            return return_v;
        }

    }
}
