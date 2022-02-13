// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundSwitchStatement : IBoundSwitchStatement
    {
        BoundNode IBoundSwitchStatement.Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10575, 417, 435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10575, 420, 435);
                    return f_10575_420_435(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10575, 417, 435);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10575, 417, 435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10575, 417, 435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<BoundStatementList> IBoundSwitchStatement.Cases
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10575, 509, 568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10575, 512, 568);
                    return f_10575_512_568(f_10575_548_567(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10575, 509, 568);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10575, 509, 568);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10575, 509, 568);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundSwitchStatement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10575, 295, 576);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10575, 295, 576);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10575, 295, 576);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10575, 295, 576);

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10575_420_435(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
        this_param)
        {
            var return_v = this_param.Expression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10575, 420, 435);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
        f_10575_548_567(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
        this_param)
        {
            var return_v = this_param.SwitchSections;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10575, 548, 567);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatementList>
        f_10575_512_568(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
        from)
        {
            var return_v = StaticCast<BoundStatementList>.From(from);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10575, 512, 568);
            return return_v;
        }

    }
}
