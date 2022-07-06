// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Reflection.Metadata;
using Xunit;

namespace Roslyn.Test.Utilities
{
internal static class EncValidation
{
internal static void VerifyModuleMvid(int generation, MetadataReader previousReader, MetadataReader currentReader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25104,387,1675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,526,584);

var 
previousModule = f_25104_547_583(previousReader)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,598,654);

var 
currentModule = f_25104_618_653(currentReader)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,670,771);

f_25104_670_770(f_25104_683_726(previousReader, previousModule.Mvid), f_25104_728_769(currentReader, currentModule.Mvid));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,787,843);

f_25104_787_842(generation - 1, previousModule.Generation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,857,908);

f_25104_857_907(generation, currentModule.Generation);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,924,1566) || true) && (generation == 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25104,924,1566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,977,1024);

f_25104_977_1023(previousModule.GenerationId.IsNil);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,1042,1093);

f_25104_1042_1092(previousModule.BaseGenerationId.IsNil);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,1113,1160);

f_25104_1113_1159(currentModule.GenerationId.IsNil);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,1178,1228);

f_25104_1178_1227(currentModule.BaseGenerationId.IsNil);
DynAbs.Tracing.TraceSender.TraceExitCondition(25104,924,1566);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25104,924,1566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,1294,1341);

f_25104_1294_1340(currentModule.GenerationId.IsNil);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,1359,1410);

f_25104_1359_1409(currentModule.BaseGenerationId.IsNil);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,1430,1551);

f_25104_1430_1550(f_25104_1443_1494(previousReader, previousModule.GenerationId), f_25104_1496_1549(currentReader, currentModule.BaseGenerationId));
DynAbs.Tracing.TraceSender.TraceExitCondition(25104,924,1566);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25104,1582,1664);

f_25104_1582_1663(default(Guid), f_25104_1613_1662(currentReader, currentModule.GenerationId));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25104,387,1675);

System.Reflection.Metadata.ModuleDefinition
f_25104_547_583(System.Reflection.Metadata.MetadataReader
this_param)
{
var return_v = this_param.GetModuleDefinition();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 547, 583);
return return_v;
}


System.Reflection.Metadata.ModuleDefinition
f_25104_618_653(System.Reflection.Metadata.MetadataReader
this_param)
{
var return_v = this_param.GetModuleDefinition();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 618, 653);
return return_v;
}


System.Guid
f_25104_683_726(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.GuidHandle
handle)
{
var return_v = this_param.GetGuid( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 683, 726);
return return_v;
}


System.Guid
f_25104_728_769(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.GuidHandle
handle)
{
var return_v = this_param.GetGuid( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 728, 769);
return return_v;
}


int
f_25104_670_770(System.Guid
expected,System.Guid
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 670, 770);
return 0;
}


int
f_25104_787_842(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 787, 842);
return 0;
}


int
f_25104_857_907(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 857, 907);
return 0;
}


int
f_25104_977_1023(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 977, 1023);
return 0;
}


int
f_25104_1042_1092(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 1042, 1092);
return 0;
}


int
f_25104_1113_1159(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 1113, 1159);
return 0;
}


int
f_25104_1178_1227(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 1178, 1227);
return 0;
}


int
f_25104_1294_1340(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 1294, 1340);
return 0;
}


int
f_25104_1359_1409(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 1359, 1409);
return 0;
}


System.Guid
f_25104_1443_1494(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.GuidHandle
handle)
{
var return_v = this_param.GetGuid( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 1443, 1494);
return return_v;
}


System.Guid
f_25104_1496_1549(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.GuidHandle
handle)
{
var return_v = this_param.GetGuid( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 1496, 1549);
return return_v;
}


int
f_25104_1430_1550(System.Guid
expected,System.Guid
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 1430, 1550);
return 0;
}


System.Guid
f_25104_1613_1662(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.GuidHandle
handle)
{
var return_v = this_param.GetGuid( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 1613, 1662);
return return_v;
}


int
f_25104_1582_1663(System.Guid
expected,System.Guid
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25104, 1582, 1663);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25104,387,1675);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25104,387,1675);
}
		}

static EncValidation()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25104,335,1682);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25104,335,1682);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25104,335,1682);
}

}
}
