// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
internal class CommonMethodEarlyWellKnownAttributeData : EarlyWellKnownAttributeData
{
private ImmutableArray<string> _lazyConditionalSymbols ;

public void AddConditionalSymbol(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(793,681,896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,751,781);

f_793_751_780(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,795,855);

_lazyConditionalSymbols = _lazyConditionalSymbols.Add(name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,869,885);

f_793_869_884(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(793,681,896);

int
f_793_751_780(Microsoft.CodeAnalysis.CommonMethodEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(793, 751, 780);
return 0;
}


int
f_793_869_884(Microsoft.CodeAnalysis.CommonMethodEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(793, 869, 884);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(793,681,896);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(793,681,896);
}
		}

public ImmutableArray<string> ConditionalSymbols
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(793,981,1110);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,1017,1046);

f_793_1017_1045(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,1064,1095);

return _lazyConditionalSymbols;
DynAbs.Tracing.TraceSender.TraceExitMethod(793,981,1110);

int
f_793_1017_1045(Microsoft.CodeAnalysis.CommonMethodEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(793, 1017, 1045);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(793,908,1121);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(793,908,1121);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private ObsoleteAttributeData _obsoleteAttributeData ;

public ObsoleteAttributeData? ObsoleteAttributeData
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(793,1365,1541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,1401,1430);

f_793_1401_1429(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,1448,1526);

return (DynAbs.Tracing.TraceSender.Conditional_F1(793, 1455, 1493)||((f_793_1455_1493(_obsoleteAttributeData)&&DynAbs.Tracing.TraceSender.Conditional_F2(793, 1496, 1500))||DynAbs.Tracing.TraceSender.Conditional_F3(793, 1503, 1525)))?null :_obsoleteAttributeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(793,1365,1541);

int
f_793_1401_1429(Microsoft.CodeAnalysis.CommonMethodEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(793, 1401, 1429);
return 0;
}


bool
f_793_1455_1493(Microsoft.CodeAnalysis.ObsoleteAttributeData
this_param)
{
var return_v = this_param.IsUninitialized ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(793, 1455, 1493);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(793,1289,1833);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(793,1289,1833);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(793,1555,1822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,1591,1621);

f_793_1591_1620(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,1639,1667);

f_793_1639_1666(value != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,1685,1722);

f_793_1685_1721(f_793_1698_1720_M(!value.IsUninitialized));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,1742,1773);

_obsoleteAttributeData = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,1791,1807);

f_793_1791_1806(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(793,1555,1822);

int
f_793_1591_1620(Microsoft.CodeAnalysis.CommonMethodEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(793, 1591, 1620);
return 0;
}


int
f_793_1639_1666(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(793, 1639, 1666);
return 0;
}


bool
f_793_1698_1720_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(793, 1698, 1720);
return return_v;
}


int
f_793_1685_1721(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(793, 1685, 1721);
return 0;
}


int
f_793_1791_1806(Microsoft.CodeAnalysis.CommonMethodEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(793, 1791, 1806);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(793,1289,1833);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(793,1289,1833);
}
		}}

public CommonMethodEarlyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(793,444,1860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,614,668);
this._lazyConditionalSymbols = ImmutableArray<string>.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(793,1218,1278);
this._obsoleteAttributeData = ObsoleteAttributeData.Uninitialized;DynAbs.Tracing.TraceSender.TraceExitConstructor(793,444,1860);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(793,444,1860);
}


static CommonMethodEarlyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(793,444,1860);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(793,444,1860);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(793,444,1860);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(793,444,1860);
}
}
