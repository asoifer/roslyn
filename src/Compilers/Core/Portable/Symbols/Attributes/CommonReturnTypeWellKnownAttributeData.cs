// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
internal class CommonReturnTypeWellKnownAttributeData : WellKnownAttributeData, IMarshalAsAttributeTarget
{
private MarshalPseudoCustomAttributeData _lazyMarshalAsData;

MarshalPseudoCustomAttributeData IMarshalAsAttributeTarget.GetOrCreateData()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(800,770,1141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(800,871,901);

f_800_871_900(this, expected: false);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(800,915,1088) || true) && (_lazyMarshalAsData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(800,915,1088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(800,979,1039);

_lazyMarshalAsData = f_800_1000_1038();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(800,1057,1073);

f_800_1057_1072(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(800,915,1088);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(800,1104,1130);

return _lazyMarshalAsData;
DynAbs.Tracing.TraceSender.TraceExitMethod(800,770,1141);

int
f_800_871_900(Microsoft.CodeAnalysis.CommonReturnTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(800, 871, 900);
return 0;
}


Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
f_800_1000_1038()
{
var return_v = new Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(800, 1000, 1038);
return return_v;
}


int
f_800_1057_1072(Microsoft.CodeAnalysis.CommonReturnTypeWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(800, 1057, 1072);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(800,770,1141);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(800,770,1141);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public MarshalPseudoCustomAttributeData MarshallingInformation
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(800,1391,1515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(800,1427,1456);

f_800_1427_1455(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(800,1474,1500);

return _lazyMarshalAsData;
DynAbs.Tracing.TraceSender.TraceExitMethod(800,1391,1515);

int
f_800_1427_1455(Microsoft.CodeAnalysis.CommonReturnTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(800, 1427, 1455);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(800,1304,1526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(800,1304,1526);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public CommonReturnTypeWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(800,471,1553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(800,739,757);
DynAbs.Tracing.TraceSender.TraceExitConstructor(800,471,1553);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(800,471,1553);
}


static CommonReturnTypeWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(800,471,1553);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(800,471,1553);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(800,471,1553);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(800,471,1553);
}
}
