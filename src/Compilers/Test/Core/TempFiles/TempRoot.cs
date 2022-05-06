// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public sealed class TempRoot : IDisposable
{
private readonly ConcurrentBag<IDisposable> _temps ;

public static readonly string Root;

private bool _disposed;

static TempRoot()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25029,633,787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,583,587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,675,730);

Root = f_25029_682_729(f_25029_695_713(), "RoslynTests");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,744,776);

f_25029_744_775(Root);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25029,633,787);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25029,633,787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25029,633,787);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25029,799,1230);
System.IDisposable temp = default(System.IDisposable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,845,862);

_disposed = true;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,876,1219) || true) && (f_25029_883_911(_temps, out temp))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25029,876,1219);
                try
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,989,1093) || true) && (temp != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25029,989,1093);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,1055,1070);

f_25029_1055_1069(                        temp);
DynAbs.Tracing.TraceSender.TraceExitCondition(25029,989,1093);
}
                }
                catch
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(25029,1130,1204);
DynAbs.Tracing.TraceSender.TraceExitCatch(25029,1130,1204);
                    // ignore
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(25029,876,1219);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25029,876,1219);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25029,876,1219);
}DynAbs.Tracing.TraceSender.TraceExitMethod(25029,799,1230);

bool
f_25029_883_911(System.Collections.Concurrent.ConcurrentBag<System.IDisposable>
this_param,out System.IDisposable?
result)
{
var return_v = this_param.TryTake( out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 883, 911);
return return_v;
}


int
f_25029_1055_1069(System.IDisposable
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 1055, 1069);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25029,799,1230);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25029,799,1230);
}
		}

private void CheckDisposed()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25029,1242,1425);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,1295,1414) || true) && (this._disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25029,1295,1414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,1347,1399);

throw f_25029_1353_1398(nameof(TempRoot));
DynAbs.Tracing.TraceSender.TraceExitCondition(25029,1295,1414);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25029,1242,1425);

System.ObjectDisposedException
f_25029_1353_1398(string
objectName)
{
var return_v = new System.ObjectDisposedException( objectName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 1353, 1398);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25029,1242,1425);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25029,1242,1425);
}
		}

public TempDirectory CreateDirectory()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25029,1437,1636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,1500,1516);

f_25029_1500_1515(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,1530,1570);

var 
dir = f_25029_1540_1569(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,1584,1600);

f_25029_1584_1599(            _temps, dir);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,1614,1625);

return dir;
DynAbs.Tracing.TraceSender.TraceExitMethod(25029,1437,1636);

int
f_25029_1500_1515(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
this_param)
{
this_param.CheckDisposed();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 1500, 1515);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DisposableDirectory
f_25029_1540_1569(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
root)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DisposableDirectory( root);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 1540, 1569);
return return_v;
}


int
f_25029_1584_1599(System.Collections.Concurrent.ConcurrentBag<System.IDisposable>
this_param,Microsoft.CodeAnalysis.Test.Utilities.DisposableDirectory
item)
{
this_param.Add( (System.IDisposable)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 1584, 1599);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25029,1437,1636);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25029,1437,1636);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public TempFile CreateFile(string prefix = null, string extension = null, string directory = null, [CallerFilePath] string callerSourcePath = null, [CallerLineNumber] int callerLineNumber = 0)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25029,1648,2007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,1865,1881);

f_25029_1865_1880(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,1895,1996);

return f_25029_1902_1995(this, f_25029_1910_1994(prefix, extension, directory, callerSourcePath, callerLineNumber));
DynAbs.Tracing.TraceSender.TraceExitMethod(25029,1648,2007);

int
f_25029_1865_1880(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
this_param)
{
this_param.CheckDisposed();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 1865, 1880);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
f_25029_1910_1994(string?
prefix,string?
extension,string?
directory,string
callerSourcePath,int
callerLineNumber)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DisposableFile( prefix, extension, directory, callerSourcePath, callerLineNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 1910, 1994);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
f_25029_1902_1995(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
this_param,Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
file)
{
var return_v = this_param.AddFile( file);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 1902, 1995);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25029,1648,2007);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25029,1648,2007);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public DisposableFile AddFile(DisposableFile file)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25029,2019,2178);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,2094,2110);

f_25029_2094_2109(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,2124,2141);

f_25029_2124_2140(            _temps, file);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,2155,2167);

return file;
DynAbs.Tracing.TraceSender.TraceExitMethod(25029,2019,2178);

int
f_25029_2094_2109(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
this_param)
{
this_param.CheckDisposed();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 2094, 2109);
return 0;
}


int
f_25029_2124_2140(System.Collections.Concurrent.ConcurrentBag<System.IDisposable>
this_param,Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
item)
{
this_param.Add( (System.IDisposable)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 2124, 2140);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25029,2019,2178);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25029,2019,2178);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void CreateStream(string fullPath, FileMode mode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25029,2190,2370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,2280,2359);
using(var 
file = f_25029_2298_2328(fullPath, mode)
)            {
DynAbs.Tracing.TraceSender.TraceExitUsing(25029,2280,2359);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25029,2190,2370);

System.IO.FileStream
f_25029_2298_2328(string
path,System.IO.FileMode
mode)
{
var return_v = new System.IO.FileStream( path, mode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 2298, 2328);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25029,2190,2370);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25029,2190,2370);
}
		}

public TempRoot()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25029,398,2377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,501,542);
this._temps = f_25029_510_542();DynAbs.Tracing.TraceSender.TraceSimpleStatement(25029,611,620);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25029,398,2377);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25029,398,2377);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25029,398,2377);

System.Collections.Concurrent.ConcurrentBag<System.IDisposable>
f_25029_510_542()
{
var return_v = new System.Collections.Concurrent.ConcurrentBag<System.IDisposable>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 510, 542);
return return_v;
}


static string
f_25029_695_713()
{
var return_v = Path.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 695, 713);
return return_v;
}


static string
f_25029_682_729(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 682, 729);
return return_v;
}


static System.IO.DirectoryInfo
f_25029_744_775(string
path)
{
var return_v = Directory.CreateDirectory( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25029, 744, 775);
return return_v;
}

}
}
