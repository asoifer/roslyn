// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Reflection;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis
{
internal class CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol> : WellKnownAttributeData, ISecurityAttributeTarget
{
private string _assemblySignatureKeyAttributeSetting;

public string AssemblySignatureKeyAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,839,982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,875,904);

f_786_875_903(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,922,967);

return _assemblySignatureKeyAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,839,982);

int
f_786_875_903(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 875, 903);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,764,1186);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,764,1186);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,996,1175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,1032,1062);

f_786_1032_1061(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,1080,1126);

_assemblySignatureKeyAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,1144,1160);

f_786_1144_1159(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,996,1175);

int
f_786_1032_1061(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 1032, 1061);
return 0;
}


int
f_786_1144_1159(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 1144, 1159);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,764,1186);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,764,1186);
}
		}}

private ThreeState _assemblyDelaySignAttributeSetting;

public ThreeState AssemblyDelaySignAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,1409,1549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,1445,1474);

f_786_1445_1473(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,1492,1534);

return _assemblyDelaySignAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,1409,1549);

int
f_786_1445_1473(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 1445, 1473);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,1333,1750);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,1333,1750);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,1563,1739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,1599,1629);

f_786_1599_1628(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,1647,1690);

_assemblyDelaySignAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,1708,1724);

f_786_1708_1723(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,1563,1739);

int
f_786_1599_1628(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 1599, 1628);
return 0;
}


int
f_786_1708_1723(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 1708, 1723);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,1333,1750);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,1333,1750);
}
		}}

private string _assemblyKeyFileAttributeSetting ;

public string AssemblyKeyFileAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,1980,2118);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,2016,2045);

f_786_2016_2044(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,2063,2103);

return _assemblyKeyFileAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,1980,2118);

int
f_786_2016_2044(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 2016, 2044);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,1910,2317);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,1910,2317);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,2132,2306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,2168,2198);

f_786_2168_2197(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,2216,2257);

_assemblyKeyFileAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,2275,2291);

f_786_2275_2290(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,2132,2306);

int
f_786_2168_2197(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 2168, 2197);
return 0;
}


int
f_786_2275_2290(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 2275, 2290);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,1910,2317);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,1910,2317);
}
		}}

private string _assemblyKeyContainerAttributeSetting ;

public string AssemblyKeyContainerAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,2562,2705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,2598,2627);

f_786_2598_2626(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,2645,2690);

return _assemblyKeyContainerAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,2562,2705);

int
f_786_2598_2626(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 2598, 2626);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,2487,2909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,2487,2909);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,2719,2898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,2755,2785);

f_786_2755_2784(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,2803,2849);

_assemblyKeyContainerAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,2867,2883);

f_786_2867_2882(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,2719,2898);

int
f_786_2755_2784(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 2755, 2784);
return 0;
}


int
f_786_2867_2882(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 2867, 2882);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,2487,2909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,2487,2909);
}
		}}

private Version _assemblyVersionAttributeSetting;

public Version AssemblyVersionAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,3436,3574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,3472,3501);

f_786_3472_3500(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,3519,3559);

return _assemblyVersionAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,3436,3574);

int
f_786_3472_3500(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 3472, 3500);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,3365,3773);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,3365,3773);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,3588,3762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,3624,3654);

f_786_3624_3653(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,3672,3713);

_assemblyVersionAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,3731,3747);

f_786_3731_3746(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,3588,3762);

int
f_786_3624_3653(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 3624, 3653);
return 0;
}


int
f_786_3731_3746(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 3731, 3746);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,3365,3773);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,3365,3773);
}
		}}

private string _assemblyFileVersionAttributeSetting;

public string AssemblyFileVersionAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,3994,4136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,4030,4059);

f_786_4030_4058(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,4077,4121);

return _assemblyFileVersionAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,3994,4136);

int
f_786_4030_4058(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 4030, 4058);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,3920,4339);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,3920,4339);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,4150,4328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,4186,4216);

f_786_4186_4215(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,4234,4279);

_assemblyFileVersionAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,4297,4313);

f_786_4297_4312(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,4150,4328);

int
f_786_4186_4215(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 4186, 4215);
return 0;
}


int
f_786_4297_4312(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 4297, 4312);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,3920,4339);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,3920,4339);
}
		}}

private string _assemblyTitleAttributeSetting;

public string AssemblyTitleAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,4542,4678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,4578,4607);

f_786_4578_4606(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,4625,4663);

return _assemblyTitleAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,4542,4678);

int
f_786_4578_4606(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 4578, 4606);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,4474,4875);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,4474,4875);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,4692,4864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,4728,4758);

f_786_4728_4757(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,4776,4815);

_assemblyTitleAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,4833,4849);

f_786_4833_4848(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,4692,4864);

int
f_786_4728_4757(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 4728, 4757);
return 0;
}


int
f_786_4833_4848(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 4833, 4848);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,4474,4875);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,4474,4875);
}
		}}

private string _assemblyDescriptionAttributeSetting;

public string AssemblyDescriptionAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,5096,5238);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,5132,5161);

f_786_5132_5160(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,5179,5223);

return _assemblyDescriptionAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,5096,5238);

int
f_786_5132_5160(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 5132, 5160);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,5022,5441);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,5022,5441);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,5252,5430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,5288,5318);

f_786_5288_5317(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,5336,5381);

_assemblyDescriptionAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,5399,5415);

f_786_5399_5414(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,5252,5430);

int
f_786_5288_5317(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 5288, 5317);
return 0;
}


int
f_786_5399_5414(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 5399, 5414);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,5022,5441);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,5022,5441);
}
		}}

private string _assemblyCultureAttributeSetting;

public string AssemblyCultureAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,5650,5788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,5686,5715);

f_786_5686_5714(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,5733,5773);

return _assemblyCultureAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,5650,5788);

int
f_786_5686_5714(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 5686, 5714);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,5580,5987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,5580,5987);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,5802,5976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,5838,5868);

f_786_5838_5867(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,5886,5927);

_assemblyCultureAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,5945,5961);

f_786_5945_5960(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,5802,5976);

int
f_786_5838_5867(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 5838, 5867);
return 0;
}


int
f_786_5945_5960(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 5945, 5960);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,5580,5987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,5580,5987);
}
		}}

private string _assemblyCompanyAttributeSetting;

public string AssemblyCompanyAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,6196,6334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,6232,6261);

f_786_6232_6260(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,6279,6319);

return _assemblyCompanyAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,6196,6334);

int
f_786_6232_6260(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 6232, 6260);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,6126,6533);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,6126,6533);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,6348,6522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,6384,6414);

f_786_6384_6413(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,6432,6473);

_assemblyCompanyAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,6491,6507);

f_786_6491_6506(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,6348,6522);

int
f_786_6384_6413(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 6384, 6413);
return 0;
}


int
f_786_6491_6506(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 6491, 6506);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,6126,6533);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,6126,6533);
}
		}}

private string _assemblyProductAttributeSetting;

public string AssemblyProductAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,6742,6880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,6778,6807);

f_786_6778_6806(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,6825,6865);

return _assemblyProductAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,6742,6880);

int
f_786_6778_6806(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 6778, 6806);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,6672,7079);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,6672,7079);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,6894,7068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,6930,6960);

f_786_6930_6959(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,6978,7019);

_assemblyProductAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,7037,7053);

f_786_7037_7052(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,6894,7068);

int
f_786_6930_6959(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 6930, 6959);
return 0;
}


int
f_786_7037_7052(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 7037, 7052);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,6672,7079);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,6672,7079);
}
		}}

private string _assemblyInformationalVersionAttributeSetting;

public string AssemblyInformationalVersionAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,7327,7478);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,7363,7392);

f_786_7363_7391(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,7410,7463);

return _assemblyInformationalVersionAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,7327,7478);

int
f_786_7363_7391(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 7363, 7391);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,7244,7690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,7244,7690);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,7492,7679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,7528,7558);

f_786_7528_7557(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,7576,7630);

_assemblyInformationalVersionAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,7648,7664);

f_786_7648_7663(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,7492,7679);

int
f_786_7528_7557(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 7528, 7557);
return 0;
}


int
f_786_7648_7663(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 7648, 7663);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,7244,7690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,7244,7690);
}
		}}

private string _assemblyCopyrightAttributeSetting;

public string AssemblyCopyrightAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,7905,8045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,7941,7970);

f_786_7941_7969(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,7988,8030);

return _assemblyCopyrightAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,7905,8045);

int
f_786_7941_7969(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 7941, 7969);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,7833,8246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,7833,8246);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,8059,8235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,8095,8125);

f_786_8095_8124(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,8143,8186);

_assemblyCopyrightAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,8204,8220);

f_786_8204_8219(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,8059,8235);

int
f_786_8095_8124(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 8095, 8124);
return 0;
}


int
f_786_8204_8219(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 8204, 8219);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,7833,8246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,7833,8246);
}
		}}

private string _assemblyTrademarkAttributeSetting;

public string AssemblyTrademarkAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,8461,8601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,8497,8526);

f_786_8497_8525(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,8544,8586);

return _assemblyTrademarkAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,8461,8601);

int
f_786_8497_8525(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 8497, 8525);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,8389,8802);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,8389,8802);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,8615,8791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,8651,8681);

f_786_8651_8680(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,8699,8742);

_assemblyTrademarkAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,8760,8776);

f_786_8760_8775(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,8615,8791);

int
f_786_8651_8680(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 8651, 8680);
return 0;
}


int
f_786_8760_8775(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 8760, 8775);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,8389,8802);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,8389,8802);
}
		}}

private AssemblyFlags _assemblyFlagsAttributeSetting;

public AssemblyFlags AssemblyFlagsAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,9019,9155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,9055,9084);

f_786_9055_9083(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,9102,9140);

return _assemblyFlagsAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,9019,9155);

int
f_786_9055_9083(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 9055, 9083);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,8944,9352);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,8944,9352);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,9169,9341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,9205,9235);

f_786_9205_9234(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,9253,9292);

_assemblyFlagsAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,9310,9326);

f_786_9310_9325(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,9169,9341);

int
f_786_9205_9234(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 9205, 9234);
return 0;
}


int
f_786_9310_9325(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 9310, 9325);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,8944,9352);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,8944,9352);
}
		}}

private AssemblyHashAlgorithm? _assemblyAlgorithmIdAttributeSetting;

public AssemblyHashAlgorithm? AssemblyAlgorithmIdAttributeSetting
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,9598,9740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,9634,9663);

f_786_9634_9662(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,9681,9725);

return _assemblyAlgorithmIdAttributeSetting;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,9598,9740);

int
f_786_9634_9662(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 9634, 9662);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,9508,9943);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,9508,9943);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,9754,9932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,9790,9820);

f_786_9790_9819(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,9838,9883);

_assemblyAlgorithmIdAttributeSetting = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,9901,9917);

f_786_9901_9916(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,9754,9932);

int
f_786_9790_9819(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 9790, 9819);
return 0;
}


int
f_786_9901_9916(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 9901, 9916);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,9508,9943);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,9508,9943);
}
		}}

private bool _hasCompilationRelaxationsAttribute;

public bool HasCompilationRelaxationsAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,10154,10295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,10190,10219);

f_786_10190_10218(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,10237,10280);

return _hasCompilationRelaxationsAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,10154,10295);

int
f_786_10190_10218(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 10190, 10218);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,10083,10497);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,10083,10497);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,10309,10486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,10345,10375);

f_786_10345_10374(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,10393,10437);

_hasCompilationRelaxationsAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,10455,10471);

f_786_10455_10470(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,10309,10486);

int
f_786_10345_10374(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 10345, 10374);
return 0;
}


int
f_786_10455_10470(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 10455, 10470);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,10083,10497);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,10083,10497);
}
		}}

private bool _hasReferenceAssemblyAttribute;

public bool HasReferenceAssemblyAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,10693,10829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,10729,10758);

f_786_10729_10757(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,10776,10814);

return _hasReferenceAssemblyAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,10693,10829);

int
f_786_10729_10757(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 10729, 10757);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,10627,11026);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,10627,11026);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,10843,11015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,10879,10909);

f_786_10879_10908(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,10927,10966);

_hasReferenceAssemblyAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,10984,11000);

f_786_10984_10999(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,10843,11015);

int
f_786_10879_10908(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 10879, 10908);
return 0;
}


int
f_786_10984_10999(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 10984, 10999);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,10627,11026);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,10627,11026);
}
		}}

private bool? _runtimeCompatibilityWrapNonExceptionThrows;

internal const bool 
WrapNonExceptionThrowsDefault = true
;

public bool HasRuntimeCompatibilityAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,11387,11545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,11423,11452);

f_786_11423_11451(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,11470,11530);

return f_786_11477_11529(_runtimeCompatibilityWrapNonExceptionThrows);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,11387,11545);

int
f_786_11423_11451(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 11423, 11451);
return 0;
}


bool
f_786_11477_11529(bool?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(786, 11477, 11529);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,11318,11556);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,11318,11556);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool RuntimeCompatibilityWrapNonExceptionThrows
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,11647,11831);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,11683,11712);

f_786_11683_11711(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,11732,11816);

return _runtimeCompatibilityWrapNonExceptionThrows ??(DynAbs.Tracing.TraceSender.Expression_Null<bool?>(786, 11739, 11815)??WrapNonExceptionThrowsDefault);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,11647,11831);

int
f_786_11683_11711(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 11683, 11711);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,11568,12041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,11568,12041);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,11845,12030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,11881,11911);

f_786_11881_11910(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,11929,11981);

_runtimeCompatibilityWrapNonExceptionThrows = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,11999,12015);

f_786_11999_12014(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,11845,12030);

int
f_786_11881_11910(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 11881, 11910);
return 0;
}


int
f_786_11999_12014(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 11999, 12014);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,11568,12041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,11568,12041);
}
		}}

private bool _hasDebuggableAttribute;

public bool HasDebuggableAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,12218,12347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,12254,12283);

f_786_12254_12282(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,12301,12332);

return _hasDebuggableAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,12218,12347);

int
f_786_12254_12282(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 12254, 12282);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,12159,12537);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,12159,12537);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,12361,12526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,12397,12427);

f_786_12397_12426(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,12445,12477);

_hasDebuggableAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,12495,12511);

f_786_12495_12510(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,12361,12526);

int
f_786_12397_12426(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 12397, 12426);
return 0;
}


int
f_786_12495_12510(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 12495, 12510);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,12159,12537);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,12159,12537);
}
		}}

private SecurityWellKnownAttributeData _lazySecurityAttributeData;

        SecurityWellKnownAttributeData ISecurityAttributeTarget.GetOrCreateData()
        {
            VerifySealed(expected: false);

            if (_lazySecurityAttributeData == null)
            {
                _lazySecurityAttributeData = new SecurityWellKnownAttributeData();
                SetDataStored();
            }

            return _lazySecurityAttributeData;
        }

public SecurityWellKnownAttributeData SecurityInformation
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,13321,13453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,13357,13386);

f_786_13357_13385(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,13404,13438);

return _lazySecurityAttributeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,13321,13453);

int
f_786_13357_13385(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 13357, 13385);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,13239,13464);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,13239,13464);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private HashSet<TNamedTypeSymbol> _forwardedTypes;

public HashSet<TNamedTypeSymbol> ForwardedTypes
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,13662,13736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,13698,13721);

return _forwardedTypes;
DynAbs.Tracing.TraceSender.TraceExitMethod(786,13662,13736);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,13590,13918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,13590,13918);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(786,13750,13907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,13786,13816);

f_786_13786_13815(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,13834,13858);

_forwardedTypes = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,13876,13892);

f_786_13876_13891(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(786,13750,13907);

int
f_786_13786_13815(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 13786, 13815);
return 0;
}


int
f_786_13876_13891(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<TNamedTypeSymbol>
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(786, 13876, 13891);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(786,13590,13918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,13590,13918);
}
		}}

public CommonAssemblyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(786,510,13945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,716,753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,1288,1322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,1846,1899);
this._assemblyKeyFileAttributeSetting = StringMissingValue;DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,2418,2476);
this._assemblyKeyContainerAttributeSetting = StringMissingValue;DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,3006,3038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,3873,3909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,4433,4463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,4975,5011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,5537,5569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,6083,6115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,6629,6661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,7188,7233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,7788,7822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,8344,8378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,8903,8933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,9461,9497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,10037,10072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,10586,10616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,11121,11164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,12125,12148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,12645,12671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,13564,13579);
DynAbs.Tracing.TraceSender.TraceExitConstructor(786,510,13945);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,510,13945);
}


static CommonAssemblyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(786,510,13945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(786,11269,11305);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(786,510,13945);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(786,510,13945);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(786,510,13945);
}
}
