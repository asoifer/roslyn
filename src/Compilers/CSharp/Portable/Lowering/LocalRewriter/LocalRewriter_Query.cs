// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitRangeVariable(BoundRangeVariable node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10521,445,585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10521,539,574);

return f_10521_546_573(this, f_10521_562_572(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10521,445,585);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10521_562_572(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10521, 562, 572);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10521_546_573(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10521, 546, 573);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10521,445,585);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10521,445,585);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitQueryClause(BoundQueryClause node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10521,597,733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10521,687,722);

return f_10521_694_721(this, f_10521_710_720(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10521,597,733);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10521_710_720(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10521, 710, 720);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10521_694_721(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10521, 694, 721);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10521,597,733);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10521,597,733);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
