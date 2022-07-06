// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public sealed class CompilerTraitDiscoverer : ITraitDiscoverer
{
public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25137,520,932);

var listYield= new List<KeyValuePair<String, String>>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25137,634,715);

var 
array = (CompilerFeature[])f_25137_665_714(f_25137_665_705(traitAttribute))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25137,729,921);
foreach(var feature in f_25137_753_758_I(array) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25137,729,921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25137,792,823);

var 
value = f_25137_804_822(feature)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25137,841,906);

listYield.Add(f_25137_854_905("Compiler", value));
DynAbs.Tracing.TraceSender.TraceExitCondition(25137,729,921);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25137,1,193);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25137,1,193);
}DynAbs.Tracing.TraceSender.TraceExitMethod(25137,520,932);

return listYield;

System.Collections.Generic.IEnumerable<object>
f_25137_665_705(Xunit.Abstractions.IAttributeInfo
this_param)
{
var return_v = this_param.GetConstructorArguments();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25137, 665, 705);
return return_v;
}


object
f_25137_665_714(System.Collections.Generic.IEnumerable<object>
source)
{
var return_v = source.Single<object>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25137, 665, 714);
return return_v;
}


string
f_25137_804_822(Microsoft.CodeAnalysis.Test.Utilities.CompilerFeature
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25137, 804, 822);
return return_v;
}


System.Collections.Generic.KeyValuePair<string, string>
f_25137_854_905(string
key,string
value)
{
var return_v = new System.Collections.Generic.KeyValuePair<string, string>( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25137, 854, 905);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilerFeature[]
f_25137_753_758_I(Microsoft.CodeAnalysis.Test.Utilities.CompilerFeature[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25137, 753, 758);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25137,520,932);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25137,520,932);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public CompilerTraitDiscoverer()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25137,441,939);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25137,441,939);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25137,441,939);
}


static CompilerTraitDiscoverer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25137,441,939);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25137,441,939);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25137,441,939);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25137,441,939);
}
}
