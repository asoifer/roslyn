// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Text;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
internal static class SemanticModelExtensions
{
public static void VerifyOperationTree(this SemanticModel model, SyntaxNode node, string expectedOperationTree)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25062,369,722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25062,505,549);

var 
actualTextBuilder = f_25062_529_548()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25062,563,615);

f_25062_563_614(model, node, actualTextBuilder);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25062,629,711);

f_25062_629_710(expectedOperationTree, f_25062_681_709(actualTextBuilder));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25062,369,722);

System.Text.StringBuilder
f_25062_529_548()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25062, 529, 548);
return return_v;
}


int
f_25062_563_614(Microsoft.CodeAnalysis.SemanticModel
model,Microsoft.CodeAnalysis.SyntaxNode
node,System.Text.StringBuilder
actualTextBuilder)
{
model.AppendOperationTree( node, actualTextBuilder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25062, 563, 614);
return 0;
}


string
f_25062_681_709(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25062, 681, 709);
return return_v;
}


bool
f_25062_629_710(string
expectedOperationTree,string
actualOperationTree)
{
var return_v = OperationTreeVerifier.Verify( expectedOperationTree, actualOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25062, 629, 710);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25062,369,722);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25062,369,722);
}
		}

public static void AppendOperationTree(this SemanticModel model, SyntaxNode node, StringBuilder actualTextBuilder, int initialIndent = 0)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25062,734,1384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25062,896,944);

IOperation 
operation = f_25062_919_943(model, node)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25062,958,1373) || true) && (operation != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25062,958,1373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25062,1013,1120);

string 
operationTree = f_25062_1036_1119(f_25062_1075_1092(model), operation, initialIndent)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25062,1138,1178);

f_25062_1138_1177(                actualTextBuilder, operationTree);
DynAbs.Tracing.TraceSender.TraceExitCondition(25062,958,1373);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25062,958,1373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25062,1244,1358);

f_25062_1244_1357(                actualTextBuilder, $"  SemanticModel.GetOperation() returned NULL for node with text: '{f_25062_1338_1353(node)}'");
DynAbs.Tracing.TraceSender.TraceExitCondition(25062,958,1373);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25062,734,1384);

Microsoft.CodeAnalysis.IOperation?
f_25062_919_943(Microsoft.CodeAnalysis.SemanticModel
this_param,Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = this_param.GetOperation( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25062, 919, 943);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_25062_1075_1092(Microsoft.CodeAnalysis.SemanticModel
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25062, 1075, 1092);
return return_v;
}


string
f_25062_1036_1119(Microsoft.CodeAnalysis.Compilation
compilation,Microsoft.CodeAnalysis.IOperation
operation,int
initialIndent)
{
var return_v = OperationTreeVerifier.GetOperationTree( compilation, operation, initialIndent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25062, 1036, 1119);
return return_v;
}


System.Text.StringBuilder
f_25062_1138_1177(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25062, 1138, 1177);
return return_v;
}


string
f_25062_1338_1353(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25062, 1338, 1353);
return return_v;
}


System.Text.StringBuilder
f_25062_1244_1357(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25062, 1244, 1357);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25062,734,1384);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25062,734,1384);
}
		}

static SemanticModelExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25062,307,1391);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25062,307,1391);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25062,307,1391);
}

}
}
