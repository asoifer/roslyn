// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CodeAnalysis;

namespace Roslyn.Test.Utilities
{
internal class TestDocumentationProviderEquals : DocumentationProvider
{
protected internal override string GetDocumentationForSymbol(string documentationMemberID, CultureInfo preferredCulture, CancellationToken cancellationToken) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25115,697,702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25115,700,702);
return "";DynAbs.Tracing.TraceSender.TraceExitMethod(25115,697,702);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25115,697,702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25115,697,702);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool Equals(object obj) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25115,753,802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25115,756,802);
return obj != null &&(DynAbs.Tracing.TraceSender.Expression_True(25115, 756, 802)&&f_25115_771_785(this)== f_25115_789_802(obj));DynAbs.Tracing.TraceSender.TraceExitMethod(25115,753,802);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25115,753,802);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25115,753,802);
}
			throw new System.Exception("Slicer error: unreachable code");

System.Type
f_25115_771_785(Roslyn.Test.Utilities.TestDocumentationProviderEquals
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25115, 771, 785);
return return_v;
}


System.Type
f_25115_789_802(object
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25115, 789, 802);
return return_v;
}

		}

public override int GetHashCode() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25115,847,873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25115,850,873);
return f_25115_850_873(f_25115_850_859(this));DynAbs.Tracing.TraceSender.TraceExitMethod(25115,847,873);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25115,847,873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25115,847,873);
}
			throw new System.Exception("Slicer error: unreachable code");

System.Type
f_25115_850_859(Roslyn.Test.Utilities.TestDocumentationProviderEquals
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25115, 850, 859);
return return_v;
}


int
f_25115_850_873(System.Type
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25115, 850, 873);
return return_v;
}

		}

public TestDocumentationProviderEquals()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25115,452,881);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25115,452,881);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25115,452,881);
}


static TestDocumentationProviderEquals()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25115,452,881);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25115,452,881);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25115,452,881);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25115,452,881);
}
internal class TestDocumentationProviderNoEquals : DocumentationProvider
{
protected internal override string GetDocumentationForSymbol(string documentationMemberID, CultureInfo preferredCulture, CancellationToken cancellationToken) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25115,1184,1189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25115,1187,1189);
return "";DynAbs.Tracing.TraceSender.TraceExitMethod(25115,1184,1189);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25115,1184,1189);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25115,1184,1189);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool Equals(object obj) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25115,1240,1269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25115,1243,1269);
return f_25115_1243_1269(this, obj);DynAbs.Tracing.TraceSender.TraceExitMethod(25115,1240,1269);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25115,1240,1269);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25115,1240,1269);
}
			throw new System.Exception("Slicer error: unreachable code");

bool
f_25115_1243_1269(Roslyn.Test.Utilities.TestDocumentationProviderNoEquals
objA,object
objB)
{
var return_v = ReferenceEquals( (object)objA, objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25115, 1243, 1269);
return return_v;
}

		}

public override int GetHashCode() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25115,1314,1349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25115,1317,1349);
return f_25115_1317_1349(this);DynAbs.Tracing.TraceSender.TraceExitMethod(25115,1314,1349);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25115,1314,1349);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25115,1314,1349);
}
			throw new System.Exception("Slicer error: unreachable code");

int
f_25115_1317_1349(Roslyn.Test.Utilities.TestDocumentationProviderNoEquals
o)
{
var return_v = RuntimeHelpers.GetHashCode( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25115, 1317, 1349);
return return_v;
}

		}

public TestDocumentationProviderNoEquals()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25115,937,1357);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25115,937,1357);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25115,937,1357);
}


static TestDocumentationProviderNoEquals()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25115,937,1357);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25115,937,1357);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25115,937,1357);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25115,937,1357);
}
}
