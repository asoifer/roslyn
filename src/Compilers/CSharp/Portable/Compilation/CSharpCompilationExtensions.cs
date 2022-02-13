// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp
{
internal static class CSharpCompilationExtensions
{
internal static bool IsFeatureEnabled(this CSharpCompilation compilation, MessageID feature)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10914,365,607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10914,482,596);

return f_10914_489_587_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(((CSharpParseOptions)f_10914_510_559_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(compilation.SyntaxTrees.FirstOrDefault(), 10914, 510, 559)?.Options)), 10914, 489, 587)?.IsFeatureEnabled(feature))== true;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10914,365,607);

Microsoft.CodeAnalysis.ParseOptions?
f_10914_510_559_M(Microsoft.CodeAnalysis.ParseOptions?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10914, 510, 559);
return return_v;
}


bool?
f_10914_489_587_I(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10914, 489, 587);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10914,365,607);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10914,365,607);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static CSharpCompilationExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10914,299,614);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10914,299,614);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10914,299,614);
}

}
}
