// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Roslyn.Test.Utilities
{
public static class SharedResourceHelpers
{
public static void CleanupAllGeneratedFiles(string filename)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25042,327,1540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25042,747,808);

string 
directory = f_25042_766_807(filename)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25042,822,909);

string 
filenamewithoutextension = f_25042_856_908(filename)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25042,923,979);

string 
searchfilename = filenamewithoutextension + ".*"
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25042,993,1529);
foreach(string f in f_25042_1014_1069_I(f_25042_1014_1069(directory, searchfilename)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25042,993,1529);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25042,1103,1514) || true) && (f_25042_1107_1136(f)!= f_25042_1140_1176(filename))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25042,1103,1514);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25042,1270,1295);

f_25042_1270_1294(f);
                    }
                    catch
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(25042,1340,1495);
DynAbs.Tracing.TraceSender.TraceExitCatch(25042,1340,1495);
                        // Swallow any exceptions as the cleanup should not necessarily block the test
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(25042,1103,1514);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25042,993,1529);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25042,1,537);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25042,1,537);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25042,327,1540);

string?
f_25042_766_807(string
path)
{
var return_v = System.IO.Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25042, 766, 807);
return return_v;
}


string?
f_25042_856_908(string
path)
{
var return_v = System.IO.Path.GetFileNameWithoutExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25042, 856, 908);
return return_v;
}


string[]
f_25042_1014_1069(string?
path,string
searchPattern)
{
var return_v = System.IO.Directory.GetFiles( path, searchPattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25042, 1014, 1069);
return return_v;
}


string?
f_25042_1107_1136(string
path)
{
var return_v = System.IO.Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25042, 1107, 1136);
return return_v;
}


string?
f_25042_1140_1176(string
path)
{
var return_v = System.IO.Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25042, 1140, 1176);
return return_v;
}


int
f_25042_1270_1294(string
path)
{
System.IO.File.Delete( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25042, 1270, 1294);
return 0;
}


string[]
f_25042_1014_1069_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25042, 1014, 1069);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25042,327,1540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25042,327,1540);
}
		}

static SharedResourceHelpers()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25042,269,1547);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25042,269,1547);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25042,269,1547);
}

}
}
