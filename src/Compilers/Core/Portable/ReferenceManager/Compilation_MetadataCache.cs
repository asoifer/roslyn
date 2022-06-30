// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
public partial class Compilation
{
private readonly WeakList<IAssemblySymbolInternal> _retargetingAssemblySymbols ;

internal void CacheRetargetingAssemblySymbolNoLock(IAssemblySymbolInternal assembly)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(532,2022,2184);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(532,2131,2173);

f_532_2131_2172(            _retargetingAssemblySymbols, assembly);
DynAbs.Tracing.TraceSender.TraceExitMethod(532,2022,2184);

int
f_532_2131_2172(Roslyn.Utilities.WeakList<Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>
this_param,Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(532, 2131, 2172);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(532,2022,2184);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(532,2022,2184);
}
		}

internal void AddRetargetingAssemblySymbolsNoLock<T>(List<T> result) where T : IAssemblySymbolInternal
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(532,2442,2701);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(532,2569,2690);
foreach(var symbol in f_532_2592_2619_I(_retargetingAssemblySymbols) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(532,2569,2690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(532,2653,2675);

f_532_2653_2674(                result, symbol);
DynAbs.Tracing.TraceSender.TraceExitCondition(532,2569,2690);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(532,1,122);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(532,1,122);
}DynAbs.Tracing.TraceSender.TraceExitMethod(532,2442,2701);

int
f_532_2653_2674(System.Collections.Generic.List<T>
this_param,Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal
item)
{
this_param.Add( (T)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(532, 2653, 2674);
return 0;
}


Roslyn.Utilities.WeakList<Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>
f_532_2592_2619_I(Roslyn.Utilities.WeakList<Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(532, 2592, 2619);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(532,2442,2701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(532,2442,2701);
}
		}

internal WeakList<IAssemblySymbolInternal> RetargetingAssemblySymbols
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(532,2836,2879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(532,2842,2877);

return _retargetingAssemblySymbols;
DynAbs.Tracing.TraceSender.TraceExitMethod(532,2836,2879);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(532,2742,2890);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(532,2742,2890);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}
}
}
