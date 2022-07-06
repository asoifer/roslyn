// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public class DirectoryHelper
{        public event Action<string> 
FileFound
;

private readonly string _rootPath;

public DirectoryHelper(string path)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25087,530,796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25087,510,519);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25087,590,752) || true) && (!f_25087_595_617(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25087,590,752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25087,651,737);

throw f_25087_657_736("Directory '" + path + "' does not exist.", nameof(path));
DynAbs.Tracing.TraceSender.TraceExitCondition(25087,590,752);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25087,768,785);

_rootPath = path;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25087,530,796);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25087,530,796);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25087,530,796);
}
		}

public void IterateFiles(string[] searchPatterns)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25087,808,933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25087,882,922);

f_25087_882_921(this, searchPatterns, _rootPath);
DynAbs.Tracing.TraceSender.TraceExitMethod(25087,808,933);

int
f_25087_882_921(Microsoft.CodeAnalysis.Test.Utilities.DirectoryHelper
this_param,string[]
searchPatterns,string
directoryPath)
{
this_param.IterateFiles( searchPatterns, directoryPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25087, 882, 921);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25087,808,933);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25087,808,933);
}
		}

private void IterateFiles(string[] searchPatterns, string directoryPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25087,945,1530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25087,1042,1073);

var 
files = f_25087_1054_1072()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25087,1087,1264);
foreach(var pattern in f_25087_1111_1125_I(searchPatterns) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25087,1087,1264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25087,1159,1249);

f_25087_1159_1248(                files, f_25087_1174_1247(directoryPath, pattern, SearchOption.TopDirectoryOnly));
DynAbs.Tracing.TraceSender.TraceExitCondition(25087,1087,1264);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25087,1,178);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25087,1,178);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25087,1280,1365);
foreach(var f in f_25087_1298_1303_I(files) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25087,1280,1365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25087,1337,1350);

f_25087_1337_1349(FileFound, f);
DynAbs.Tracing.TraceSender.TraceExitCondition(25087,1280,1365);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25087,1,86);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25087,1,86);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25087,1381,1519);
foreach(var d in f_25087_1399_1438_I(f_25087_1399_1438(directoryPath)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25087,1381,1519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25087,1472,1504);

f_25087_1472_1503(this, searchPatterns, d);
DynAbs.Tracing.TraceSender.TraceExitCondition(25087,1381,1519);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25087,1,139);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25087,1,139);
}DynAbs.Tracing.TraceSender.TraceExitMethod(25087,945,1530);

System.Collections.Generic.List<string>
f_25087_1054_1072()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25087, 1054, 1072);
return return_v;
}


string[]
f_25087_1174_1247(string
path,string
searchPattern,System.IO.SearchOption
searchOption)
{
var return_v = Directory.GetFiles( path, searchPattern, searchOption);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25087, 1174, 1247);
return return_v;
}


int
f_25087_1159_1248(System.Collections.Generic.List<string>
this_param,string[]
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<string>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25087, 1159, 1248);
return 0;
}


string[]
f_25087_1111_1125_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25087, 1111, 1125);
return return_v;
}


int
f_25087_1337_1349(System.Action<string>
this_param,string
obj)
{
this_param.Invoke( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25087, 1337, 1349);
return 0;
}


System.Collections.Generic.List<string>
f_25087_1298_1303_I(System.Collections.Generic.List<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25087, 1298, 1303);
return return_v;
}


string[]
f_25087_1399_1438(string
path)
{
var return_v = Directory.GetDirectories( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25087, 1399, 1438);
return return_v;
}


int
f_25087_1472_1503(Microsoft.CodeAnalysis.Test.Utilities.DirectoryHelper
this_param,string[]
searchPatterns,string
directoryPath)
{
this_param.IterateFiles( searchPatterns, directoryPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25087, 1472, 1503);
return 0;
}


string[]
f_25087_1399_1438_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25087, 1399, 1438);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25087,945,1530);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25087,945,1530);
}
		}

static DirectoryHelper()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25087,391,1537);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25087,391,1537);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25087,391,1537);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25087,391,1537);

static bool
f_25087_595_617(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25087, 595, 617);
return return_v;
}


static System.ArgumentException
f_25087_657_736(string
message,string
paramName)
{
var return_v = new System.ArgumentException( message, paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25087, 657, 736);
return return_v;
}

}
}
