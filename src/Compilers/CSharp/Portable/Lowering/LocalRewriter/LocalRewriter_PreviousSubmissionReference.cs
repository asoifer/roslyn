// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
internal partial class LocalRewriter
{
public override BoundNode VisitPreviousSubmissionReference(BoundPreviousSubmissionReference node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10519,384,1174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10519,506,558);

var 
targetType = (ImplicitNamedTypeSymbol)f_10519_548_557(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10519,572,629);

f_10519_572_628(f_10519_585_604(targetType)== TypeKind.Submission);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10519,643,704);

f_10519_643_703(f_10519_656_679(_factory)is { IsStatic: false });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10519,718,760);

f_10519_718_759(f_10519_731_751(_factory)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10519,776,824);

f_10519_776_823(_previousSubmissionFields != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10519,840,865);

var 
syntax = node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10519,879,960);

var 
targetScriptReference = f_10519_907_959(_previousSubmissionFields, targetType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10519,974,1047);

var 
thisReference = f_10519_994_1046(syntax, f_10519_1025_1045(_factory))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10519,1061,1163);

return f_10519_1068_1162(syntax, thisReference, targetScriptReference, ConstantValue.NotAvailable);
DynAbs.Tracing.TraceSender.TraceExitMethod(10519,384,1174);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10519_548_557(Microsoft.CodeAnalysis.CSharp.BoundPreviousSubmissionReference
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10519, 548, 557);
return return_v;
}


Microsoft.CodeAnalysis.TypeKind
f_10519_585_604(Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
this_param)
{
var return_v = this_param.TypeKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10519, 585, 604);
return return_v;
}


int
f_10519_572_628(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10519, 572, 628);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10519_656_679(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.TopLevelMethod ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10519, 656, 679);
return return_v;
}


int
f_10519_643_703(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10519, 643, 703);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_10519_731_751(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10519, 731, 751);
return return_v;
}


int
f_10519_718_759(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10519, 718, 759);
return 0;
}


int
f_10519_776_823(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10519, 776, 823);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_10519_907_959(Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
previousSubmissionType)
{
var return_v = this_param.GetOrMakeField( previousSubmissionType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10519, 907, 959);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10519_1025_1045(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10519, 1025, 1045);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundThisReference
f_10519_994_1046(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundThisReference( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10519, 994, 1046);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
f_10519_1068_1162(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundThisReference
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
fieldSymbol,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, fieldSymbol, constantValueOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10519, 1068, 1162);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10519,384,1174);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10519,384,1174);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
