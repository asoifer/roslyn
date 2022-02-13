// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
internal partial class LocalRewriter
{
public override BoundNode VisitHostObjectMemberReference(BoundHostObjectMemberReference node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10502,338,971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10502,456,504);

f_10502_456_503(_previousSubmissionFields != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10502,518,579);

f_10502_518_578(f_10502_531_554(_factory)is { IsStatic: false });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10502,593,635);

f_10502_593_634(f_10502_606_626(_factory)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10502,651,676);

var 
syntax = node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10502,690,763);

var 
hostObjectReference = f_10502_716_762(_previousSubmissionFields)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10502,777,850);

var 
thisReference = f_10502_797_849(syntax, f_10502_828_848(_factory))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10502,864,960);

return f_10502_871_959(syntax, thisReference, hostObjectReference, constantValueOpt: null);
DynAbs.Tracing.TraceSender.TraceExitMethod(10502,338,971);

int
f_10502_456_503(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10502, 456, 503);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10502_531_554(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.TopLevelMethod ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10502, 531, 554);
return return_v;
}


int
f_10502_518_578(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10502, 518, 578);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_10502_606_626(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10502, 606, 626);
return return_v;
}


int
f_10502_593_634(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10502, 593, 634);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_10502_716_762(Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
this_param)
{
var return_v = this_param.GetHostObjectField();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10502, 716, 762);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10502_828_848(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10502, 828, 848);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundThisReference
f_10502_797_849(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundThisReference( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10502, 797, 849);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
f_10502_871_959(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundThisReference
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
fieldSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, fieldSymbol, constantValueOpt: constantValueOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10502, 871, 959);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10502,338,971);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10502,338,971);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
