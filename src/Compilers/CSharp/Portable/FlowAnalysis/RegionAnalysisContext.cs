// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct RegionAnalysisContext
    {

        public readonly CSharpCompilation Compilation;

        public readonly Symbol Member;

        public readonly BoundNode BoundNode;

        public readonly BoundNode FirstInRegion, LastInRegion;

        public readonly bool Failed;

        public RegionAnalysisContext(CSharpCompilation compilation, Symbol member, BoundNode boundNode, BoundNode firstInRegion, BoundNode lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10906, 1290, 2381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10906, 1459, 1490);

                this.Compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10906, 1504, 1525);

                this.Member = member;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10906, 1539, 1566);

                this.BoundNode = boundNode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10906, 1580, 1615);

                this.FirstInRegion = firstInRegion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10906, 1629, 1662);

                this.LastInRegion = lastInRegion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10906, 1676, 1890);

                this.Failed =
                                boundNode == null || (DynAbs.Tracing.TraceSender.Expression_False(10906, 1707, 1766) || firstInRegion == null) || (DynAbs.Tracing.TraceSender.Expression_False(10906, 1707, 1807) || lastInRegion == null) || (DynAbs.Tracing.TraceSender.Expression_False(10906, 1707, 1889) || f_10906_1828_1858(firstInRegion.Syntax) > lastInRegion.Syntax.Span.End);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10906, 1906, 2370) || true) && (!this.Failed && (DynAbs.Tracing.TraceSender.Expression_True(10906, 1910, 1970) && f_10906_1926_1970(firstInRegion, lastInRegion)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10906, 1906, 2370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10906, 2004, 2355);

                    switch (f_10906_2012_2030(firstInRegion))
                    {

                        case BoundKind.NamespaceExpression:
                        case BoundKind.TypeExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10906, 2004, 2355);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10906, 2285, 2304);

                            this.Failed = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(10906, 2330, 2336);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10906, 2004, 2355);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10906, 1906, 2370);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10906, 1290, 2381);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10906, 1290, 2381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10906, 1290, 2381);
            }
        }
        static RegionAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10906, 578, 2388);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10906, 578, 2388);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10906, 578, 2388);
        }

        static int
        f_10906_1828_1858(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.SpanStart;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10906, 1828, 1858);
            return return_v;
        }


        bool
        f_10906_1926_1970(Microsoft.CodeAnalysis.CSharp.BoundNode?
        objA, Microsoft.CodeAnalysis.CSharp.BoundNode?
        objB)
        {
            var return_v = ReferenceEquals((object?)objA, (object?)objB);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10906, 1926, 1970);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundKind
        f_10906_2012_2030(Microsoft.CodeAnalysis.CSharp.BoundNode?
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10906, 2012, 2030);
            return return_v;
        }

    }
}
