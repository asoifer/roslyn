// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitAnonymousObjectCreationExpression(BoundAnonymousObjectCreationExpression node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10477,509,1353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10477,682,733);

var 
rewrittenArguments = f_10477_707_732(this, f_10477_717_731(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10477,749,1342);

return f_10477_756_1341(syntax: node.Syntax, constructor: f_10477_859_875(node), arguments: rewrittenArguments, argumentNamesOpt: default(ImmutableArray<string>), argumentRefKindsOpt: default(ImmutableArray<RefKind>), expanded: false, argsToParamsOpt: default(ImmutableArray<int>), defaultArguments: default(BitVector), constantValueOpt: null, initializerExpressionOpt: null, type: f_10477_1331_1340(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10477,509,1353);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10477_717_731(Microsoft.CodeAnalysis.CSharp.BoundAnonymousObjectCreationExpression
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10477, 717, 731);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10477_707_732(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10477, 707, 732);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10477_859_875(Microsoft.CodeAnalysis.CSharp.BoundAnonymousObjectCreationExpression
this_param)
{
var return_v = this_param.Constructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10477, 859, 875);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10477_1331_1340(Microsoft.CodeAnalysis.CSharp.BoundAnonymousObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10477, 1331, 1340);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10477_756_1341(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<string>
argumentNamesOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,Microsoft.CodeAnalysis.BitVector
defaultArguments,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
initializerExpressionOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax: syntax, constructor: constructor, arguments: arguments, argumentNamesOpt: argumentNamesOpt, argumentRefKindsOpt: argumentRefKindsOpt, expanded: expanded, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, constantValueOpt: constantValueOpt, initializerExpressionOpt: initializerExpressionOpt, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10477, 756, 1341);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10477,509,1353);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10477,509,1353);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
