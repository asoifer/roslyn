// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundNode : IBoundNodeWithIOperationChildren
    {
        ImmutableArray<BoundNode?> IBoundNodeWithIOperationChildren.Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10589, 490, 506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10589, 493, 506);
                    return f_10589_493_506(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10589, 490, 506);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10589, 490, 506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10589, 490, 506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10589, 863, 898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10589, 866, 898);
                    return ImmutableArray<BoundNode?>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10589, 863, 898);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10589, 863, 898);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10589, 863, 898);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10589_493_506(Microsoft.CodeAnalysis.CSharp.BoundNode
        this_param)
        {
            var return_v = this_param.Children;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10589, 493, 506);
            return return_v;
        }

    }
    internal partial class BoundBadStatement : IBoundInvalidNode
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10589, 1046, 1070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10589, 1049, 1070);
                    return this.ChildBoundNodes!; DynAbs.Tracing.TraceSender.TraceExitMethod(10589, 1046, 1070);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10589, 1046, 1070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10589, 1046, 1070);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10589, 1147, 1170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10589, 1150, 1170);
                    return f_10589_1150_1170(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10589, 1147, 1170);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10589, 1147, 1170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10589, 1147, 1170);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundBadStatement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10589, 914, 1178);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10589, 914, 1178);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10589, 914, 1178);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10589, 914, 1178);

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
        f_10589_1150_1170(Microsoft.CodeAnalysis.CSharp.BoundBadStatement
        this_param)
        {
            var return_v = this_param.ChildBoundNodes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10589, 1150, 1170);
            return return_v;
        }

    }
    partial class BoundFixedStatement
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10589, 1291, 1357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10589, 1294, 1357);
                    return f_10589_1294_1357(f_10589_1328_1345(this), f_10589_1347_1356(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10589, 1291, 1357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10589, 1291, 1357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10589, 1291, 1357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundFixedStatement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10589, 1186, 1365);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10589, 1186, 1365);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10589, 1186, 1365);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10589, 1186, 1365);

        Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
        f_10589_1328_1345(Microsoft.CodeAnalysis.CSharp.BoundFixedStatement
        this_param)
        {
            var return_v = this_param.Declarations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10589, 1328, 1345);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundStatement
        f_10589_1347_1356(Microsoft.CodeAnalysis.CSharp.BoundFixedStatement
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10589, 1347, 1356);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10589_1294_1357(Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
        item1, Microsoft.CodeAnalysis.CSharp.BoundStatement
        item2)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item1, (Microsoft.CodeAnalysis.CSharp.BoundNode)item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10589, 1294, 1357);
            return return_v;
        }

    }
    partial class BoundPointerIndirectionOperator
    {
        protected override ImmutableArray<BoundNode?> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10589, 1490, 1540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10589, 1493, 1540);
                    return f_10589_1493_1540(f_10589_1527_1539(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10589, 1490, 1540);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10589, 1490, 1540);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10589, 1490, 1540);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundPointerIndirectionOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10589, 1373, 1548);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10589, 1373, 1548);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10589, 1373, 1548);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10589, 1373, 1548);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10589_1527_1539(Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
        this_param)
        {
            var return_v = this_param.Operand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10589, 1527, 1539);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode?>
        f_10589_1493_1540(Microsoft.CodeAnalysis.CSharp.BoundExpression
        item)
        {
            var return_v = ImmutableArray.Create<BoundNode?>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10589, 1493, 1540);
            return return_v;
        }

    }
}
