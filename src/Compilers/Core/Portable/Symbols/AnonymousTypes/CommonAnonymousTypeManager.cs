// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Symbols
{
internal abstract class CommonAnonymousTypeManager
{
private ThreeState _templatesSealed ;

internal bool AreTemplatesSealed
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(783,810,861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(783,816,859);

return _templatesSealed == ThreeState.True;
DynAbs.Tracing.TraceSender.TraceExitMethod(783,810,861);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(783,753,872);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(783,753,872);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected void SealTemplates()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(783,884,985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(783,939,974);

_templatesSealed = ThreeState.True;
DynAbs.Tracing.TraceSender.TraceExitMethod(783,884,985);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(783,884,985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(783,884,985);
}
		}

public CommonAnonymousTypeManager()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(783,257,992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(783,595,630);
this._templatesSealed = ThreeState.False;DynAbs.Tracing.TraceSender.TraceExitConstructor(783,257,992);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(783,257,992);
}


static CommonAnonymousTypeManager()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(783,257,992);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(783,257,992);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(783,257,992);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(783,257,992);
}
}
